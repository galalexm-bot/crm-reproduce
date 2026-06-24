using System;
using System.Collections.Generic;
using EleWise.ELMA.Calendar.Export.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Calendar.Export.Extensions;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IExternalCalendarEventConverter
{
	string Name { get; }

	Guid Uid { get; }

	IEnumerable<ExternalCalendarItem> Deserialize(string sourceId, string calendarContent, DateTime startDate, DateTime endDate);
}
