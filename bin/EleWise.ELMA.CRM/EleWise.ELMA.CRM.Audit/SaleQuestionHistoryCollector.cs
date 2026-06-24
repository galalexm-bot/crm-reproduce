using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Audit;

namespace EleWise.ELMA.CRM.Audit;

[Component]
internal class SaleQuestionHistoryCollector : QuestionHistoryCollectorBase
{
	private readonly Guid collectorGuid;

	public override Guid CollectorGuid => collectorGuid;

	public SaleQuestionHistoryCollector()
	{
		collectorGuid = new Guid("1ACBA1EF-EE23-48C4-88A2-69AF7072CE96");
	}

	public override bool CanUse(long id, Guid actionObject)
	{
		return actionObject == InterfaceActivator.UID<ISale>();
	}
}
