using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Components;

public class ServerRestartSettings : GlobalSettingsBase
{
	internal class __Resources_ServerRestartSettings
	{
		public static string MinimumRestartTime_DisplayName => SR.T("Минимальный интервал времени до начала запланированного перезапуска");

		public static string MinimumRestartTime_Description => SR.T("Минимальное время, считая от текущего момента времени, через которое можно запланировать перезапуск.");

		public static string MaximumRestartTime_DisplayName => SR.T("Максимальный интервал времени до начала запланированного перезапуска");

		public static string MaximumRestartTime_Description => SR.T("Максимальное время, считая от текущего момента времени, после которого запланировать перезапуск невозможно.");

		public static string Overtime_DisplayName => SR.T("Максимальное время ожидания перезапуска сервера");

		public static string Overtime_Description => SR.T("Если по какой-либо причине сервер не может перезапуститься в назначенное время, перезапуск может быть осуществлен в промежуток времени, не превышающий данный лимит. Если лимит ожидания превышен, то перезапуск будет отменен.");

		public static string ClusterWaitTime_DisplayName => SR.T("Максимальное время ожидания перезапуска всех серверов кластера");

		public static string ClusterWaitTime_Description => SR.T("Время ожидания конца перезапуска для остальных серверов в кластере. Если не все сервера перезапустились в данный промежуток времени, то перезапуск будет считаться проваленным. Отсчет времени ведется от времени начала работы первого сервера в кластере.");

		public static string MaxHistoryEntries_DisplayName => SR.T("Максимальное количество записей в истории");

		public static string MaxHistoryEntries_Description => SR.T("Если значение равно 0, то перезапуски в историю не записываются. ");

		public static string NotificationEnabled_DisplayName => SR.T("Отправлять сообщения о перезапуске в информационные каналы");

		public static string NotificationChannels_DisplayName => SR.T("Информационные каналы для отправки сообщений");

		public static string NotificationChannels_Description => SR.T("Информационные каналы, в которые будут отправлены сообщения о планируемом перезапуске.");

		public static string NotificationTimeSpans_DisplayName => SR.T("Интервал отправки сообщений о перезапуске");

		public static string NotificationTimeSpans_Description => SR.T("Указывает, за сколько времени до перезапуска необходимо напомнить пользователям о перезапуске, отправив сообщения в информационные каналы.");

		public static string NotificationSubject_DisplayName => SR.T("Тема сообщения");

		public static string NotificationMessage_DisplayName => SR.T("Текст сообщения");

		public static string NotificationCommentMessage_DisplayName => SR.T("Текст комментария");

		public static string FirstNotificationDelay_DisplayName => SR.T("Задержка отправки сообщения о создании перезапуска");

		public static string FirstNotificationDelay_Description => SR.T("Указывает интервал времени, через который необходимо отправить уведомление о перезапуске сервера после того как он был запланирован.");
	}

	private static readonly TimeSpan MinimumOvertime = TimeSpan.FromMinutes(1.0);

	private static readonly TimeSpan MinimumClusterWaitTime = TimeSpan.FromMinutes(5.0);

	private IServerRestartMessageService messageService;

	private TimeSpan minimumRestartTime;

	private TimeSpan maximumRestartTime;

	private TimeSpan overtime;

	private TimeSpan clusterWaitTime;

	private int maxHistoryEntries;

	private TimeSpan firstNotificationDelay;

	private IServerRestartMessageService MessageService => messageService ?? (messageService = Locator.GetService<IServerRestartMessageService>());

	[DisplayName(typeof(__Resources_ServerRestartSettings), "MinimumRestartTime_DisplayName")]
	[Description(typeof(__Resources_ServerRestartSettings), "MinimumRestartTime_Description")]
	public TimeSpan MinimumRestartTime
	{
		get
		{
			return minimumRestartTime;
		}
		set
		{
			minimumRestartTime = ((value > TimeSpan.Zero) ? value : TimeSpan.Zero);
		}
	}

	[DisplayName(typeof(__Resources_ServerRestartSettings), "MaximumRestartTime_DisplayName")]
	[Description(typeof(__Resources_ServerRestartSettings), "MaximumRestartTime_Description")]
	public TimeSpan MaximumRestartTime
	{
		get
		{
			return maximumRestartTime;
		}
		set
		{
			maximumRestartTime = ((value > TimeSpan.Zero) ? value : TimeSpan.Zero);
		}
	}

	[DisplayName(typeof(__Resources_ServerRestartSettings), "Overtime_DisplayName")]
	[Description(typeof(__Resources_ServerRestartSettings), "Overtime_Description")]
	public TimeSpan Overtime
	{
		get
		{
			return overtime;
		}
		set
		{
			overtime = ((value > MinimumOvertime) ? value : MinimumOvertime);
		}
	}

	[DisplayName(typeof(__Resources_ServerRestartSettings), "ClusterWaitTime_DisplayName")]
	[Description(typeof(__Resources_ServerRestartSettings), "ClusterWaitTime_Description")]
	public TimeSpan ClusterWaitTime
	{
		get
		{
			return clusterWaitTime;
		}
		set
		{
			clusterWaitTime = ((value > MinimumClusterWaitTime) ? value : MinimumClusterWaitTime);
		}
	}

	[DisplayName(typeof(__Resources_ServerRestartSettings), "MaxHistoryEntries_DisplayName")]
	[Description(typeof(__Resources_ServerRestartSettings), "MaxHistoryEntries_Description")]
	[Int32Settings(MinValue = 0)]
	public int MaxHistoryEntries
	{
		get
		{
			return maxHistoryEntries;
		}
		set
		{
			maxHistoryEntries = ((value >= 0) ? value : 0);
		}
	}

	[DisplayName(typeof(__Resources_ServerRestartSettings), "NotificationEnabled_DisplayName")]
	public bool NotificationEnabled { get; set; }

	[DisplayName(typeof(__Resources_ServerRestartSettings), "NotificationChannels_DisplayName")]
	[Description(typeof(__Resources_ServerRestartSettings), "NotificationChannels_Description")]
	public List<long> NotificationChannels { get; set; }

	[DisplayName(typeof(__Resources_ServerRestartSettings), "NotificationTimeSpans_DisplayName")]
	[Description(typeof(__Resources_ServerRestartSettings), "NotificationTimeSpans_Description")]
	public List<TimeSpan> NotificationTimeSpans { get; set; }

	[DisplayName(typeof(__Resources_ServerRestartSettings), "NotificationSubject_DisplayName")]
	public string NotificationSubject { get; set; }

	[DisplayName(typeof(__Resources_ServerRestartSettings), "NotificationMessage_DisplayName")]
	public string NotificationMessage { get; set; }

	[DisplayName(typeof(__Resources_ServerRestartSettings), "NotificationCommentMessage_DisplayName")]
	public string NotificationCommentMessage { get; set; }

	[DisplayName(typeof(__Resources_ServerRestartSettings), "FirstNotificationDelay_DisplayName")]
	[Description(typeof(__Resources_ServerRestartSettings), "FirstNotificationDelay_Description")]
	public TimeSpan FirstNotificationDelay
	{
		get
		{
			return firstNotificationDelay;
		}
		set
		{
			firstNotificationDelay = ((value > TimeSpan.Zero) ? value : TimeSpan.Zero);
		}
	}

	public ServerRestartSettings()
	{
		MinimumRestartTime = TimeSpan.FromMinutes(5.0);
		MaximumRestartTime = TimeSpan.FromDays(90.0);
		Overtime = TimeSpan.FromMinutes(5.0);
		ClusterWaitTime = TimeSpan.FromMinutes(20.0);
		MaxHistoryEntries = 10;
		NotificationEnabled = true;
		NotificationChannels = new List<long>();
		NotificationTimeSpans = new List<TimeSpan>
		{
			TimeSpan.FromMinutes(60.0),
			TimeSpan.FromMinutes(30.0),
			TimeSpan.FromMinutes(15.0)
		};
		NotificationSubject = SR.T("Запланированный перезапуск сервера на {RestartDate}");
		NotificationMessage = SR.T("{Reason}\r\nПерезапуск сервера состоится через {TimeLeft}");
		NotificationCommentMessage = SR.T("Осталось {TimeLeft} до начала перезапуска.");
		FirstNotificationDelay = TimeSpan.FromMinutes(1.0);
	}

	public IEnumerable<InformationChannelInfo> GetInformationChannelInfo()
	{
		if (MessageService == null)
		{
			Logger.Log.Error("ServerRestartSettings.GetInformationChannelInfo(): IServerRestartMessageService is null!");
			return EleWise.ELMA.Helpers.EmptyArray<InformationChannelInfo>.Instance;
		}
		return MessageService.GetInformationChannelInfo(NotificationChannels);
	}

	protected override IDictionary<string, string> GetStorageValue(PropertyInfo property)
	{
		string value = ClassSerializationHelper.SerializeObjectByJson(property.GetValue(this, null));
		return new Dictionary<string, string> { { property.Name, value } };
	}

	protected override void SetStorageValue(PropertyInfo property, IDictionary<string, string> values)
	{
		if (values.ContainsKey(property.Name))
		{
			object obj = null;
			string json = values[property.Name];
			try
			{
				obj = ClassSerializationHelper.DeserializeObjectByJson(property.PropertyType, json);
			}
			catch (Exception exception)
			{
				Logger.Log.Error($"Cannot deserialize setting {property.Name} in type {property.DeclaringType.FullName}", exception);
			}
			if (obj != null)
			{
				property.SetValue(this, obj, null);
			}
		}
	}

	internal ServerRestartSettings Clone()
	{
		return new ServerRestartSettings
		{
			MinimumRestartTime = MinimumRestartTime,
			MaximumRestartTime = MaximumRestartTime,
			Overtime = Overtime,
			ClusterWaitTime = ClusterWaitTime,
			MaxHistoryEntries = MaxHistoryEntries,
			NotificationEnabled = NotificationEnabled,
			NotificationChannels = NotificationChannels.Select((long c) => c).ToList(),
			NotificationTimeSpans = NotificationTimeSpans.Select((TimeSpan t) => t).ToList(),
			NotificationSubject = NotificationSubject,
			NotificationMessage = NotificationMessage,
			NotificationCommentMessage = NotificationCommentMessage,
			FirstNotificationDelay = FirstNotificationDelay
		};
	}
}
