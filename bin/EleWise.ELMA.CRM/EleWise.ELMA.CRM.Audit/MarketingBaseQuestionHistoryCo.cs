using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Audit;

namespace EleWise.ELMA.CRM.Audit;

[Component]
internal class MarketingBaseQuestionHistoryCollector : QuestionHistoryCollectorBase
{
	private readonly Guid collectorGuid;

	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public override Guid CollectorGuid => collectorGuid;

	public MarketingBaseQuestionHistoryCollector()
	{
		collectorGuid = new Guid("79B00ACA-B150-4E05-9F8B-825F9BD7B3FD");
	}

	public override bool CanUse(long id, Guid actionObject)
	{
		return typeof(IMarketingBase).IsAssignableFrom(MetadataRuntimeService.GetTypeByUid(actionObject));
	}
}
