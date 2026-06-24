using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events;
using EleWise.ELMA.Model.Services;
using NHibernate;

namespace EleWise.ELMA.Documents.Audit.History;

[Component]
internal sealed class DocumentVersionsHistoryCollectorCachable : BaseDocumentHistoryCollectorCachable
{
	private const string CollectorCuid = "802A691A-CA58-4A58-84FF-A555128ED24E";

	private DocumentVersionManager documentVersionManager;

	public override Guid OldCollectorGuid => new Guid("9A41C69F-81AB-4C7E-8C7F-4B89E98705CE");

	public DocumentVersionsHistoryCollectorCachable(DocumentVersionsHistoryCollector collector, DocumentVersionManager documentVersionManager)
		: base(collector, new Guid("802A691A-CA58-4A58-84FF-A555128ED24E"), InterfaceActivator.UID<IDocumentVersion>())
	{
		this.documentVersionManager = documentVersionManager;
	}

	public override ICriteria GetCriteria(long id, Guid entityTypeUid)
	{
		return documentVersionManager.GetDocumentVersionIdCriteria(id);
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
