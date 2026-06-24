using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messaging;

namespace EleWise.ELMA.Messages.Impl.Actors;

internal sealed class MessagesHandlerActor : Actor, IMessagesHandlerActor, IActorWithGuidKey, IActor
{
	private const int DefaultProcessingMessageCount = 500;

	private const int DefaultCheckInterval = 10;

	private const string ReminderName = "MessagesHandlerActor";

	private readonly IActorModelRuntime actorModelRuntime;

	private readonly ILogger logger;

	private readonly IMessageQueueItemManager messageQueueItemManager;

	private readonly IMessageQueueChannelItemManager messageQueueChannelItemManager;

	private readonly IReadOnlyCollection<IMessageChannel> messageChannels;

	private readonly IFeatureFlagService featureFlagService;

	private IDisposable timer;

	internal const string MessageManagerEnabled = "MessageManager.Enabled";

	public MessagesHandlerActor(IActorModelRuntime actorModelRuntime, ILoggerFactory loggerFactory, IMessageQueueItemManager messageQueueItemManager, IMessageQueueChannelItemManager messageQueueChannelItemManager, IEnumerable<IMessageChannel> messageChannels, IFeatureFlagService featureFlagService)
	{
		this.actorModelRuntime = actorModelRuntime;
		this.messageQueueItemManager = messageQueueItemManager;
		this.messageQueueChannelItemManager = messageQueueChannelItemManager;
		this.messageChannels = messageChannels.ToReadOnlyCollection();
		this.featureFlagService = featureFlagService;
		logger = loggerFactory.CreateLogger(typeof(MessagesHandlerActor));
	}

	public override Task OnActivateAsync()
	{
		SetupTimer();
		return Task.CompletedTask;
	}

	public override Task ReceiveReminder(string reminderName)
	{
		if (featureFlagService.Enabled("MessageManager.Enabled", defaultEnabled: true))
		{
			SetupTimer();
		}
		else
		{
			DeactivateOnIdle();
		}
		return Task.CompletedTask;
	}

	public Task Start()
	{
		return RegisterOrUpdateReminder("MessagesHandlerActor", TimeSpan.FromMinutes(1.0), TimeSpan.FromMinutes(1.0));
	}

	private async Task ProcessMessageQueue(object arg)
	{
		if (!featureFlagService.Enabled("MessageManager.Enabled", defaultEnabled: true))
		{
			timer.Dispose();
			timer = null;
			logger.Debug(SR.T("Менеджер сообщений отключен"));
			return;
		}
		try
		{
			EventSettings.Enabled = false;
			messageQueueItemManager.DeleteProcessedQueueItems();
			int num = SR.GetSetting("MessageManager.ProcessingMessageCount", 500);
			if (num <= 0)
			{
				num = 500;
			}
			Dictionary<long, IEnumerable<(long, Guid)>> dictionary = (from item in messageQueueChannelItemManager.FindIdsAndChannelToSend(num, GetEnabledMessageChannels())
				group item by item.messageQueueItemId).ToDictionary((IGrouping<long, (long messageQueueItemId, long messageQueueChannelItemId, Guid messageChannelUid)> item) => item.Key, (IGrouping<long, (long messageQueueItemId, long messageQueueChannelItemId, Guid messageChannelUid)> item) => item.Select(((long messageQueueItemId, long messageQueueChannelItemId, Guid messageChannelUid) i) => (i.messageQueueChannelItemId, i.messageChannelUid)));
			List<Task> list = new List<Task>();
			foreach (KeyValuePair<long, IEnumerable<(long, Guid)>> item in dictionary)
			{
				long key = item.Key;
				ReadOnlyCollection<(long, Guid)> channels = item.Value.ToReadOnlyCollection();
				IMessageSenderActor actor = actorModelRuntime.GetActor<IMessageSenderActor>(key);
				list.Add(actor.Send(channels));
			}
			await Task.WhenAll(list);
		}
		catch (Exception exception)
		{
			logger.Error(SR.T("Ошибка обработки очереди отправки сообщений"), exception);
		}
		finally
		{
			EventSettings.Enabled = true;
		}
	}

	private void SetupTimer()
	{
		if (timer == null)
		{
			int num = SR.GetSetting("MessageManager.CheckInterval", 10);
			if (num < 10)
			{
				num = 10;
			}
			TimeSpan timeSpan = TimeSpan.FromSeconds(num);
			timer = RegisterTimer(ProcessMessageQueue, null, timeSpan, timeSpan);
		}
	}

	private IReadOnlyCollection<IMessageChannel> GetEnabledMessageChannels()
	{
		return messageChannels.Where(delegate(IMessageChannel channel)
		{
			if (channel is IManageableMessageChannel manageableMessageChannel)
			{
				bool enabled = manageableMessageChannel.Enabled;
				if (!enabled)
				{
					logger.Debug(SR.T("Отправка сообщений для канала '{0}' отключена", channel.DisplayName));
				}
				return enabled;
			}
			return true;
		}).ToReadOnlyCollection();
	}
}
