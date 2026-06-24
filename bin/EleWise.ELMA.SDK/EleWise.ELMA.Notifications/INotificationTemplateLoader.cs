using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Notifications;

[ExtensionPoint(ComponentType.WebServer)]
public interface INotificationTemplateLoader
{
	IEnumerable<INotificationTemplate> GetTemplates(INotification notification);

	IEnumerable<INotificationPartialTemplate> GetExtensionTemplates(string zone);
}
