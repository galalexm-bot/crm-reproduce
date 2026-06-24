using System;
using System.Collections.Generic;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.BPM.Web.Calendar.Models;

public class CalendarEventEditedPropertiesModel
{
	public ICalendarEvent OldEntity { get; set; }

	public ICalendarEvent NewEntity { get; set; }

	public IList<PropertyMetadata> ChangedProperties { get; set; }

	public List<Guid> BaseProperties { get; set; }
}
