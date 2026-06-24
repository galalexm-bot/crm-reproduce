using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Notifications;

[ExtensionPoint(ComponentType.WebServer)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface INotificationRecipientTypeHandler
{
	string Name { get; }

	IEnumerable<object> GetRecipients(object value);
}
