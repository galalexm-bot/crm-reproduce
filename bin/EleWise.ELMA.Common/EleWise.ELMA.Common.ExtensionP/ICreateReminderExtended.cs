using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface ICreateReminderExtended
{
	bool Check(IReminder reminder);

	IReminder Create(IReminder reminder);
}
