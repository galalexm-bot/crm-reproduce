using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Services;
using NHibernate;
using NHibernate.Criterion;

namespace EleWise.ELMA.Documents.Audit.History;

[Component]
internal sealed class DocumentLinksHistoryCollectorCachable : BaseDocumentHistoryCollectorCachable
{
	private const string CollectorCuid = "B0C324FD-8B5A-41FC-9B66-BAE256334EEA";

	private DocumentLinkManager documentLinkManager;

	public override Guid OldCollectorGuid => new Guid("58664D6D-48D1-42A2-AF08-AF41CE4D3C32");

	public DocumentLinksHistoryCollectorCachable(DocumentLinksHistoryCollector collector, DocumentLinkManager documentLinkManager)
		: base(collector, new Guid("B0C324FD-8B5A-41FC-9B66-BAE256334EEA"), InterfaceActivator.UID<IDocumentLink>())
	{
		this.documentLinkManager = documentLinkManager;
	}

	public override ICriteria GetCriteria(long id, Guid entityTypeUid)
	{
		return documentLinkManager.GetAllLinksCriteria(id).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Id() });
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(ICriteria criteria)
	{
		return from a in criteria.List<long>()
			select new HistoryCollectorRelatedModel
			{
				CollectorGuid = OldCollectorGuid,
				EntityId = a,
				EntityTypeUid = base.EntityTypeGuid
			};
	}
}
