using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Components;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Tasks.Audit.History;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;

namespace EleWise.ELMA.Documents.Audit.History;

[Component]
internal sealed class DocumentBaseTasksHistoryCollectorCachable : BaseDocumentHistoryCollectorCachable
{
	private const string CollectorCuid = "F579A0A3-0253-42EF-B502-AB3AE8435DA0";

	private readonly AttachmentsTaskBaseManager attachmentsTaskBaseManager;

	public override Guid OldCollectorGuid => new Guid("EFA288CF-B451-4641-BA2F-208D1B7F6BE9");

	public DocumentBaseTasksHistoryCollectorCachable(DocumentBaseTasksHistoryCollector collector, AttachmentsTaskBaseManager attachmentsTaskBaseManager)
		: base(collector, new Guid("F579A0A3-0253-42EF-B502-AB3AE8435DA0"), InterfaceActivator.UID<IAttachmentsTaskBase>())
	{
		this.attachmentsTaskBaseManager = attachmentsTaskBaseManager;
	}

	public override ICriteria GetCriteria(long id, Guid entityTypeUid)
	{
		Type type = InterfaceActivator.TypeOf<IAttachmentsTaskBase>();
		ICriteria tasksByDocumentCriteria = attachmentsTaskBaseManager.GetTasksByDocumentCriteria(id);
		tasksByDocumentCriteria.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property(NHibernateHelper.GetCriteriaTypeUidPropertyName(type)), "EntityTypeUid").Add((IProjection)(object)Projections.Property("Subject"), "Name")
			.Add((IProjection)(object)Projections.Id(), "EntityId") });
		return tasksByDocumentCriteria.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(HistoryCollectorRelatedModel)));
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(ICriteria criteria)
	{
		List<HistoryCollectorRelatedModel> list = new List<HistoryCollectorRelatedModel>();
		foreach (HistoryCollectorRelatedModel item in criteria.List<HistoryCollectorRelatedModel>())
		{
			item.CollectorGuid = OldCollectorGuid;
			item.AdditionalInformation = base.EntityTypeGuid;
			list.Add(item);
			list.AddRange(QuestionHistoryCollectorBaseCachable.RelatedObjects(item.EntityId, item.EntityTypeUid, OldCollectorGuid, item.Name));
		}
		return list;
	}
}
