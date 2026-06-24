using System.Collections.Generic;
using Orchard.UI.Notify;

namespace Orchard.UI.Admin.Notification;

public interface INotificationManager : IDependency
{
	IEnumerable<NotifyEntry> GetNotifications();
}
