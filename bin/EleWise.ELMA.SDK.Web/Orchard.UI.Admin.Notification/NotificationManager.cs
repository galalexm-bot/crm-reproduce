using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Logging;
using Orchard.Exceptions;
using Orchard.UI.Notify;

namespace Orchard.UI.Admin.Notification;

public class NotificationManager : INotificationManager, IDependency
{
	private readonly IEnumerable<INotificationProvider> _notificationProviders;

	public ILogger Logger { get; set; }

	public NotificationManager(IEnumerable<INotificationProvider> notificationProviders)
	{
		_notificationProviders = notificationProviders;
		Logger = NullLogger.Instance;
	}

	public IEnumerable<NotifyEntry> GetNotifications()
	{
		return _notificationProviders.SelectMany(delegate(INotificationProvider n)
		{
			try
			{
				return n.GetNotifications();
			}
			catch (Exception ex)
			{
				if (ex.IsFatal())
				{
					throw;
				}
				Logger.Error(ex, "An unhandled exception was thrown while generating a notification: {0}", n.GetType());
				return Enumerable.Empty<NotifyEntry>();
			}
		}).ToList();
	}
}
