using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Notifications.Impl;

namespace EleWise.ELMA.Notifications;

[ExtensionPoint(ComponentType.WebServer)]
public interface INotificationTemplateDataSource
{
	IEnumerable<NotificationTemplateFileInfo> GetFiles();
}
