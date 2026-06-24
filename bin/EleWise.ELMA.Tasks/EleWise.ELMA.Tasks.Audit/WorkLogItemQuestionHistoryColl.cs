using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Audit;

[Component]
public class WorkLogItemQuestionHistoryCollector : QuestionHistoryCollectorBase
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
				Guid[] obj = new Guid[1] { InterfaceActivator.UID<IWorkLogItem>() };
				IEnumerable<Guid> enumerable2 = obj;
				supportTypeGuids = obj;
				enumerable = enumerable2;
			}
			return enumerable;
		}
	}

	public override Guid CollectorGuid => collectorGuid;

	public WorkLogItemQuestionHistoryCollector()
	{
		collectorGuid = new Guid("E9E56FA9-CE34-48E9-8BD7-5EF3F8D69EF9");
	}
}
