using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AutoMapper;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.Channels;
using EleWise.ELMA.Messages.Exceptions;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Services;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Impl;

[Service(Scope = ServiceScope.Application, Type = ComponentType.WebServer)]
internal class TransactionalMessageManager : IMessageManager, IMessageChannelSenderService
{
	private const int DefaultMessageManagerDelay = 5;

	public static readonly ILogger MessagesLog = Logger.GetLogger("Messages");

	private const string CancelSendRegion = "MessageManagerCancelSend";

	public IEnumerable<IMessageChannel> Channels { get; set; }

	public IAuthenticationService AuthenticationService { get; set; }

	public MessageQueueItemManager MessageQueueItemManager { get; set; }

	public MessageQueueChannelItemManager MessageQueueChannelItemManager { get; set; }

	public ICacheService CacheService { get; set; }

	public ISessionProvider SessionProvider { get; set; }

	public IMessage Create()
	{
		EleWise.ELMA.Security.Models.IUser currentUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		return new Message
		{
			Author = currentUser
		};
	}

	public void Send(IMessageBase message)
	{
		Send(message, Channels);
	}

	private IEnumerable<IMessageChannel> GetChannels(string channels)
	{
		if (string.IsNullOrEmpty(channels))
		{
			return Enumerable.Empty<IMessageChannel>();
		}
		return from item in channels.Split(new char[2] { ';', ',' }, StringSplitOptions.RemoveEmptyEntries)
			select Channels.FirstOrDefault((IMessageChannel c) => c.Name == item);
	}

	[Transaction]
	public virtual void Send(IMessageBase message, IEnumerable<IMessageChannel> channels)
	{
		SendMessage(message, channels);
	}

	public void Send(IMessageBase message, IEnumerable<string> channelNames)
	{
		Contract.ArgumentNotNull(message, "message");
		if (Channels != null && Channels.Any())
		{
			List<string> names = ((channelNames != null) ? new List<string>(channelNames) : null);
			List<IMessageChannel> channels = Channels.Where((IMessageChannel channel) => names == null || names.Contains(channel.Name)).ToList();
			Send(message, channels);
		}
	}

	public void Send(IMessageBase message, IEnumerable<Guid> channelUids)
	{
		Contract.ArgumentNotNull(message, "message");
		if (Channels != null && Channels.Any())
		{
			List<Guid> uids = ((channelUids != null) ? new List<Guid>(channelUids) : null);
			List<IMessageChannel> channels = Channels.Where((IMessageChannel channel) => uids == null || uids.Contains(channel.Uid)).ToList();
			Send(message, channels);
		}
	}

	public void Delay(Guid objectUid, string objectId, Guid actionUid)
	{
		ContextVars.Set(GetDelayedKey(objectUid, objectId, actionUid), value: true);
	}

	public bool IsDelayed(Guid objectUid, string objectId, Guid actionUid)
	{
		return ContextVars.Contains(GetDelayedKey(objectUid, objectId, actionUid));
	}

	public void CancelSend(Guid objectUid, string objectId, long? recipientId = null)
	{
		if (!recipientId.HasValue)
		{
			EleWise.ELMA.Security.Models.IUser currentUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			if (currentUser == null)
			{
				return;
			}
			recipientId = currentUser.Id;
		}
		CacheService.Insert(GetCancelSendKey(objectUid, objectId, recipientId.Value), value: true, "MessageManagerCancelSend");
	}

	public bool IsCancelledSend(Guid objectUid, string objectId, long recipientId)
	{
		return CacheService.Contains(GetCancelSendKey(objectUid, objectId, recipientId), "MessageManagerCancelSend");
	}

	private void SendMessage([NotNull] IMessageBase message, IEnumerable<IMessageChannel> channels)
	{
		Contract.ArgumentNotNull(message, "message");
		channels = ((channels != null) ? channels.ToList() : Channels.ToList());
		if (channels == null || !channels.Any())
		{
			return;
		}
		channels = (GetChannels(message.Channels).ToList().Any() ? channels.Intersect(GetChannels(message.Channels)).ToList() : channels.Where((IMessageChannel c) => c.Default).ToList());
		foreach (IEmulationMessageExtension extensionPoint in ComponentManager.Current.GetExtensionPoints<IEmulationMessageExtension>())
		{
			if (extensionPoint != null && extensionPoint.SendMessage(message, channels))
			{
				return;
			}
		}
		if (!(message is ITransactionalMessage))
		{
			foreach (IMessageChannel channel in channels)
			{
				SendMessageInternal(message, channel);
			}
			return;
		}
		IMessageQueueItem messageQueueItem = InterfaceActivator.Create<IMessageQueueItem>();
		messageQueueItem.Data = message;
		DateTime? nextSendDate = null;
		if (message.GetMessages().Any((IMessage m) => m.Delayed))
		{
			TimeSpan timeSpan = TimeSpan.FromSeconds(Math.Max(SR.GetSetting("MessageManager.Delay", 5), 5));
			nextSendDate = DateTime.Now + timeSpan;
		}
		foreach (IMessageChannel channel2 in channels)
		{
			IMessageQueueChannelItem messageQueueChannelItem = InterfaceActivator.Create<IMessageQueueChannelItem>();
			messageQueueChannelItem.Item = messageQueueItem;
			messageQueueChannelItem.ChannelUid = channel2.Uid;
			messageQueueChannelItem.Attempt = 0L;
			messageQueueChannelItem.NextSendDate = nextSendDate;
			messageQueueItem.Channels.Add(messageQueueChannelItem);
		}
		messageQueueItem.Save();
	}

	private void SendMessageInternal([NotNull] IMessageBase message, [NotNull] IMessageChannel messageChannel)
	{
		IGroupingMessageChannel groupingMessageChannel = messageChannel as IGroupingMessageChannel;
		foreach (IMessage message4 in message.GetMessages())
		{
			List<EleWise.ELMA.Security.Models.IUser> list = new List<EleWise.ELMA.Security.Models.IUser>();
			bool flag = false;
			if (message4.Recipient == null)
			{
				MessagesLog.Warn($"Recipient for message not defined (Subject: {message4.Subject})");
				continue;
			}
			if (groupingMessageChannel != null)
			{
				List<EleWise.ELMA.Security.IUser> list2 = message4.GetRecipients().ToList();
				List<EleWise.ELMA.Security.IUser> list3 = new List<EleWise.ELMA.Security.IUser>();
				for (int i = 0; i < list2.Count; i++)
				{
					EleWise.ELMA.Security.IUser user = list2[i];
					if ((groupingMessageChannel is InternalMailChannel || user != message4.Author || message4.SendToAuthor) && !SkipRecipient(message4, (EleWise.ELMA.Security.Models.IUser)user) && !HasExceptionOnChannel(message4, groupingMessageChannel, user))
					{
						list3.Add(user);
					}
				}
				if (list3.Any())
				{
					try
					{
						groupingMessageChannel.Send(message4, list3);
					}
					catch (GroupingUserMailMessagesException ex)
					{
						list.AddRange(ex.Exceptions.Select((KeyValuePair<EleWise.ELMA.Security.IUser, Exception> o) => o.Key).Cast<EleWise.ELMA.Security.Models.IUser>());
					}
				}
			}
			else
			{
				IMessage msgItemCopy = message4;
				IMessage[] array = msgItemCopy.GetRecipients().Cast<EleWise.ELMA.Security.Models.IUser>().Select(delegate(EleWise.ELMA.Security.Models.IUser r)
				{
					IMessage message3 = Create();
					Mapper.Map<IMessage, IMessage>(msgItemCopy, message3);
					message3.Recipient = r;
					return message3;
				})
					.ToArray();
				foreach (IMessage message2 in array)
				{
					EleWise.ELMA.Security.Models.IUser user2 = message2.Recipient as EleWise.ELMA.Security.Models.IUser;
					if (SkipRecipient(message2, user2))
					{
						MessagesLog.InfoFormat("Skip user {0}", (user2 != null) ? user2.Id.ToString() : "null");
						continue;
					}
					try
					{
						SendToChannelInternal(messageChannel, message2, user2);
						flag = true;
					}
					catch (Exception exception)
					{
						if (!flag)
						{
							throw;
						}
						EleWise.ELMA.Security.Models.IUser user3 = (EleWise.ELMA.Security.Models.IUser)message2.Recipient;
						MessagesLog.Warn($"Failed to send message in channel: {messageChannel.Uid} to user: {user3.Id}", exception);
						list.Add(user3);
					}
				}
			}
			if (list.Count <= 0)
			{
				continue;
			}
			throw new SendMessageException
			{
				Channel = messageChannel.Uid,
				ProcessedMessage = message4,
				Users = list.ToArray()
			};
		}
	}

	private static bool HasExceptionOnChannel(IMessage messageItem, IMessageChannel channel, EleWise.ELMA.Security.IUser recipient)
	{
		if (messageItem.ActionUid.HasValue && messageItem.ObjectUid.HasValue && MessageExceptionManager.Instance.HasException(recipient, messageItem.ObjectUid.Value, messageItem.ActionUid.Value, channel.Uid))
		{
			return true;
		}
		return false;
	}

	private static void SendToChannelInternal([NotNull] IMessageChannel channel, [NotNull] IMessage messageItem, [NotNull] EleWise.ELMA.Security.IUser recipient)
	{
		if (channel == null)
		{
			throw new ArgumentNullException("channel");
		}
		if (messageItem == null)
		{
			throw new ArgumentNullException("messageItem");
		}
		if (recipient == null)
		{
			throw new ArgumentNullException("recipient");
		}
		if (HasExceptionOnChannel(messageItem, channel, recipient))
		{
			MessagesLog.InfoFormat("Channel has exception (User: {3} Object: {0} Action: {1} Channel: {2})", messageItem.ObjectUid, messageItem.ActionUid, channel.Uid, recipient.GetId());
		}
		else if (!(channel is InternalMailChannel) && recipient == messageItem.Author && !messageItem.SendToAuthor)
		{
			MessagesLog.InfoFormat("Skip author {0}", recipient.GetId());
		}
		else
		{
			SR.RunWithCulture(Locator.GetServiceNotNull<ILocalizationService>().Load(recipient) ?? SR.KeyCultureInfo, delegate
			{
				channel.Send(messageItem);
			});
		}
	}

	private bool SkipRecipient(IMessage messageItem, EleWise.ELMA.Security.Models.IUser user)
	{
		if (user == null)
		{
			MessagesLog.Warn($"Unknown recipient type for message (Subject: {messageItem.Subject}; Recipient type: {messageItem.Recipient.GetType()})");
			return true;
		}
		Guid? objectUid = messageItem.ObjectUid;
		Guid guid = InterfaceActivator.UID<IChannelMessage>();
		if (objectUid.HasValue && (!objectUid.HasValue || objectUid.GetValueOrDefault() == guid) && !MessageNotAssignedUserManager.Instance.IsAssignToMessage(Convert.ToInt64(messageItem.ObjectId), user))
		{
			return true;
		}
		if (user.Status == UserStatus.Blocked || user.Status == UserStatus.System)
		{
			return true;
		}
		if (messageItem.Delayed && messageItem.ObjectUid.HasValue && messageItem.ObjectId != null && IsCancelledSend(messageItem.ObjectUid.Value, messageItem.ObjectId, user.Id))
		{
			return true;
		}
		return false;
	}

	private static string GetDelayedKey(Guid objectUid, string objectId, Guid actionUid)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("TransactionalMessageManager.Delayed[");
		stringBuilder.Append(objectUid.ToString());
		stringBuilder.Append(";");
		stringBuilder.Append(objectId);
		stringBuilder.Append(";");
		stringBuilder.Append(actionUid.ToString());
		stringBuilder.Append("]");
		return stringBuilder.ToString();
	}

	private static string GetCancelSendKey(Guid objectUid, string objectId, long recipientId)
	{
		StringBuilder stringBuilder = new StringBuilder();
		stringBuilder.Append("TransactionalMessageManager.CancelSend[");
		stringBuilder.Append(objectUid.ToString());
		stringBuilder.Append(";");
		stringBuilder.Append(objectId);
		stringBuilder.Append(";");
		stringBuilder.Append(recipientId.ToString());
		stringBuilder.Append("]");
		return stringBuilder.ToString();
	}

	void IMessageChannelSenderService.Send(IMessageBase message, IMessageChannel messageChannel)
	{
		SendMessageInternal(message, messageChannel);
	}
}
