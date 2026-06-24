using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Audit;

namespace EleWise.ELMA.Documents.Audit;

[Component]
internal class DocumentQuestionHistoryCollector : QuestionHistoryCollectorBase
{
	internal const string CollectorUid = "828D9D4C-9503-43E3-B58B-8A9F9B4E242C";

	private readonly Guid collectorGuid;

	private IEnumerable<Guid> supportTypeGuids;

	public DocumentHistoryProfileManager DocumentHistoryProfileManager { get; set; }

	public override IEnumerable<Guid> SupportTypeGuids
	{
		get
		{
			IEnumerable<Guid> enumerable = supportTypeGuids;
			if (enumerable == null)
			{
				Guid[] obj = new Guid[1] { InterfaceActivator.UID<IDocument>() };
				IEnumerable<Guid> enumerable2 = obj;
				supportTypeGuids = obj;
				enumerable = enumerable2;
			}
			return enumerable;
		}
	}

	public override Guid CollectorGuid => collectorGuid;

	public DocumentQuestionHistoryCollector()
	{
		collectorGuid = new Guid("828D9D4C-9503-43E3-B58B-8A9F9B4E242C");
	}

	public override bool CanUse(long id, Guid actionObject)
	{
		if (!DocumentHistoryProfileManager.ChapterIsVisible(DocumentHistoryChapters.DocumentGeneralHistoryChapterInfo.UID, actionObject) || !DocumentHistoryProfileManager.ActionIsVisible(DocumentHistoryChapters.DocumentGeneralHistoryChapterInfo.DocumentQuestionCreateAction.ActionUID, DocumentHistoryChapters.DocumentGeneralHistoryChapterInfo.UID, actionObject))
		{
			return false;
		}
		return base.CanUse(id, actionObject);
	}
}
