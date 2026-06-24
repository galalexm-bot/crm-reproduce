using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.Exceptions;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Services;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Messages.Impl.Actors;

internal sealed class MessageSenderActor : Actor, IMessageSenderActor, IActorWithIntegerKey, IActor
{
	private readonly ILogger logger;

	private readonly IMessageQueueItemManager messageQueueItemManager;

	private readonly IMessageQueueChannelItemManager messageQueueChannelItemManager;

	private readonly IUnitOfWorkManagerAsync unitOfWorkManager;

	private readonly IMessageManager messageManager;

	private readonly IMessageChannelSenderService messageChannelSenderService;

	private readonly IEnumerable<IMessageChannel> messageChannels;

	private readonly TimeSpan[] attemptIntervals = new TimeSpan[17]
	{
		TimeSpan.Zero,
		TimeSpan.FromMinutes(1.0),
		TimeSpan.FromMinutes(1.0),
		TimeSpan.FromMinutes(1.0),
		TimeSpan.FromMinutes(2.0),
		TimeSpan.FromMinutes(2.0),
		TimeSpan.FromMinutes(3.0),
		TimeSpan.FromMinutes(5.0),
		TimeSpan.FromMinutes(10.0),
		TimeSpan.FromMinutes(15.0),
		TimeSpan.FromMinutes(20.0),
		TimeSpan.FromMinutes(30.0),
		TimeSpan.FromMinutes(30.0),
		TimeSpan.FromHours(1.0),
		TimeSpan.FromHours(3.0),
		TimeSpan.FromHours(6.0),
		TimeSpan.FromHours(12.0)
	};

	public MessageSenderActor(ILoggerFactory loggerFactory, IMessageQueueItemManager messageQueueItemManager, IMessageQueueChannelItemManager messageQueueChannelItemManager, IUnitOfWorkManagerAsync unitOfWorkManager, IMessageManager messageManager, IMessageChannelSenderService messageChannelSenderService, IEnumerable<IMessageChannel> messageChannels)
	{
		this.messageQueueItemManager = messageQueueItemManager;
		this.messageQueueChannelItemManager = messageQueueChannelItemManager;
		this.unitOfWorkManager = unitOfWorkManager;
		this.messageManager = messageManager;
		this.messageChannelSenderService = messageChannelSenderService;
		this.messageChannels = messageChannels;
		logger = loggerFactory.CreateLogger(typeof(MessageSenderActor));
	}

	public async Task Send(IReadOnlyCollection<(long messageQueueChannelItemId, Guid messageChannelUid)> channels)
	{
		try
		{
			await RunExternalTask(async delegate
			{
				using (CallContextSessionOwner.Create())
				{
					foreach (var channel in channels)
					{
						await SendMessageToChannel(channel.messageChannelUid, channel.messageQueueChannelItemId);
					}
				}
			});
		}
		finally
		{
			DeactivateOnIdle();
		}
	}

	private async Task SendMessageToChannel(Guid messageChannelUid, long messageQueueChannelItemId)
	{
		IMessageChannel messageChannel = messageChannels.FirstOrDefault((IMessageChannel channel) => channel.Uid == messageChannelUid);
		IMessageQueueChannelItem messageQueueChannelItem = messageQueueChannelItemManager.LoadOrNull(messageQueueChannelItemId);
		if (messageQueueChannelItem == null)
		{
			logger.Warn(SR.T("Отсутствует элемент очереди отправки сообщений '{0}' для канала '{1}'. Возможно сообщение было отправлено раньше", messageQueueChannelItemId, (messageChannel == null) ? messageQueueChannelItemId.ToString() : messageChannel.Name));
			return;
		}
		logger.Trace($"Start send MessageQueueChannelItem with Id={messageQueueChannelItemId} to MessageChannel '{((messageChannel == null) ? messageQueueChannelItemId.ToString() : messageChannel.Name)}'");
		using (IUnitOfWorkAsync unitOfWork = unitOfWorkManager.CreateAsync("", transactional: true, IsolationLevel.ReadCommitted))
		{
			if (messageChannel == null)
			{
				logger.Error(SR.T("Отсутствует канал отправки сообщений с идентификатором {0}", messageQueueChannelItemId));
				logger.Trace($"Delete MessageQueueChannelItem with Id={messageQueueChannelItem.Id}");
				messageQueueChannelItem.Delete();
				await unitOfWork.CommitAsync();
				return;
			}
			if (!(messageQueueChannelItem.Item?.Data is IMessageBase message))
			{
				logger.Info(SR.T("Элемент очереди отправки сообщений '{0}' для канала '{1}' не содержит данных. Сообщение не будет отправлено", messageQueueChannelItem.Id, messageChannel.Name));
				logger.Trace($"Delete MessageQueueChannelItem with Id={messageQueueChannelItem.Id}");
				messageQueueChannelItem.Delete();
				await unitOfWork.CommitAsync();
				return;
			}
			bool attemptFailed = false;
			try
			{
				logger.Trace("Send");
				messageChannelSenderService.Send(message, messageChannel);
				logger.Trace($"Delete MessageQueueChannelItem with Id={messageQueueChannelItem.Id}");
				messageQueueChannelItem.Delete();
				await unitOfWork.CommitAsync();
			}
			catch (SendMessageException ex)
			{
				logger.Warn(SR.T("Элемент очереди отправки сообщений '{0}' для канала '{1}' пользователям '{2}' будет отправлен повторно", messageQueueChannelItem.Id, messageChannel.Name, string.Join(", ", ex.Users.Select((IUser user) => user.Id))));
				try
				{
					DateTime now = DateTime.Now;
					long num = messageQueueChannelItem.Attempt + 1;
					if (num < attemptIntervals.Length - 1)
					{
						IMessage message2 = messageManager.Create();
						Mapper.Map<IMessage, IMessage>(ex.ProcessedMessage, message2);
						message2.Recipient = ex.Users;
						IMessageQueueItem messageQueueItem = messageQueueItemManager.Create();
						messageQueueItem.Data = message2;
						IMessageQueueChannelItem messageQueueChannelItem2 = messageQueueChannelItemManager.Create();
						messageQueueChannelItem2.Attempt = num;
						messageQueueChannelItem2.CreationDate = now;
						messageQueueChannelItem2.ChannelUid = ex.Channel;
						messageQueueChannelItem2.LastSendDate = now;
						messageQueueChannelItem2.Item = messageQueueItem;
						messageQueueChannelItem2.NextSendDate = now + attemptIntervals[messageQueueChannelItem2.Attempt];
						messageQueueItem.Channels.Add(messageQueueChannelItem2);
						messageQueueChannelItem2.Save();
						messageQueueItem.Save();
						logger.Trace($"Create new MessageQueueChannelItem with Id={messageQueueChannelItem2.Id}");
					}
					logger.Trace($"Delete MessageQueueChannelItem with Id={messageQueueChannelItem.Id}");
					messageQueueChannelItem.Delete();
					await unitOfWork.CommitAsync();
				}
				catch (Exception exception)
				{
					logger.Error(SR.T("Ошибка отправки сообщения '{0}' в канал '{1}'. Ошибка создания элемента очереди для повторной отправки", messageQueueChannelItemId, messageChannel.Name), exception);
					await unitOfWork.RollbackAsync();
				}
			}
			catch (Exception exception2)
			{
				attemptFailed = true;
				logger.Error(SR.T("Ошибка отправки элемента очереди '{0}' в канал '{1}'", messageQueueChannelItemId, messageChannel.Name), exception2);
				await unitOfWork.RollbackAsync();
			}
			if (attemptFailed && messageQueueChannelItem.Attempt < attemptIntervals.Length - 1)
			{
				messageQueueChannelItem.Attempt++;
				messageQueueChannelItem.LastSendDate = DateTime.Now;
				messageQueueChannelItem.NextSendDate = messageQueueChannelItem.LastSendDate + attemptIntervals[messageQueueChannelItem.Attempt];
				try
				{
					logger.Trace($"Update MessageQueueChannelItem with Id={messageQueueChannelItem.Id}");
					messageQueueChannelItem.Save();
					await unitOfWork.CommitAsync();
				}
				catch (Exception exception3)
				{
					logger.Error(SR.T("Не удалось обновить элемент очереди отправки сообщения '{0}'", messageQueueChannelItemId), exception3);
					await unitOfWork.RollbackAsync();
				}
			}
		}
		logger.Trace($"End send MessageQueueChannelItem with Id={messageQueueChannelItemId} to MessageChannel with Uid={messageChannelUid}");
	}
}
