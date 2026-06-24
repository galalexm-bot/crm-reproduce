using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Audit.History;

namespace EleWise.ELMA.Documents.Audit.History;

[Component]
internal sealed class DocumentQuestionHistoryCollectorCachable : QuestionHistoryCollectorBaseCachable
{
	private const string CollectorCuid = "3CFA58A9-A812-414F-A381-609F2623D849";

	public override Guid OldCollectorGuid => new Guid("828D9D4C-9503-43E3-B58B-8A9F9B4E242C");

	public DocumentQuestionHistoryCollectorCachable(DocumentQuestionHistoryCollector collector)
		: base(collector, new Guid("3CFA58A9-A812-414F-A381-609F2623D849"), InterfaceActivator.UID<IDocument>())
	{
	}
}
