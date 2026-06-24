using System.Collections.Generic;
using Orchard.UI.Notify;

namespace Orchard.UI.Admin.Notification;

public interface INotificationProvider : IDependency
{
	IEnumerable<NotifyEntry> GetNotifications();
}
