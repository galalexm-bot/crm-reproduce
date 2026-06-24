using System;
using System.Collections.Generic;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.Tasks.Audit;

[Component]
internal class CalendarEventQuestionHistoryCollector : QuestionHistoryCollectorBase
{
	private readonly Guid collectorGuid;

	private IEnumerable<Guid> supportTypeGuids;

	public override IEnumerable<Guid> SupportTypeGuids
	{
		get
		{
			IEnumerable<Guid> enumerable = supportTypeGuids;
			if (enumerable == null)
			{
				Guid[] obj = new Guid[1] { InterfaceActivator.UID<ICalendarEvent>() };
				IEnumerable<Guid> enumerable2 = obj;
				supportTypeGuids = obj;
				enumerable = enumerable2;
			}
			return enumerable;
		}
	}

	public override Guid CollectorGuid => collectorGuid;

	public CalendarEventQuestionHistoryCollector()
	{
		collectorGuid = new Guid("FDD66D2B-D8F0-4473-B7E9-CABA6C67EAEE");
	}
}
