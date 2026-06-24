using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Audit;

[Component(Order = 8000)]
public class TaskQuestionHistoryCollector : QuestionHistoryCollectorBase
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
				Guid[] obj = new Guid[1] { InterfaceActivator.UID<ITaskBase>() };
				IEnumerable<Guid> enumerable2 = obj;
				supportTypeGuids = obj;
				enumerable = enumerable2;
			}
			return enumerable;
		}
	}

	public override Guid CollectorGuid => collectorGuid;

	public TaskQuestionHistoryCollector()
	{
		collectorGuid = new Guid("CEE288AD-4FAA-4320-BE5B-5D912F4A0096");
	}
}
