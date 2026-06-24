using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Calendar;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface ICalendarItemSearchProvider : ICalendarItemProvider
{
	ICollection<ICalendarPlannedItem> GetRePlannedItems(IUser user, string searchString);

	ICollection<ICalendarPlannedItem> GetUnPlannedItems(IUser user, string searchString);
}
