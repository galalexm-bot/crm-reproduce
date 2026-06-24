using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Audit;

namespace EleWise.ELMA.CRM.Audit;

[Component]
internal class InpaymentQuestionHistoryCollector : QuestionHistoryCollectorBase
{
	private readonly Guid collectorGuid;

	public override Guid CollectorGuid => collectorGuid;

	public InpaymentQuestionHistoryCollector()
	{
		collectorGuid = new Guid("6566FE1B-5516-4D36-80E7-9406863E55CA");
	}

	public override bool CanUse(long id, Guid actionObject)
	{
		return actionObject == InterfaceActivator.UID<IInpayment>();
	}
}
