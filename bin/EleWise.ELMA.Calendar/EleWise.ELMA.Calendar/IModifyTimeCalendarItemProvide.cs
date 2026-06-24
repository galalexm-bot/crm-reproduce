using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Calendar;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IModifyTimeCalendarItemProvider
{
	Guid Uid { get; }

	ICalendarItem ModifyTime(string id, DateTime startDate, DateTime endDate);
}
