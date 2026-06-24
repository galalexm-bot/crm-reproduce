using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.History;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Web.Components;

[Component(Order = 100)]
public class WorkflowTaskSimpleEventRender : BaseAuditEventRender
{
	protected override IEnumerable<Guid> Actions => new Guid[1] { WorkflowTaskBaseActions.EscalationGuid };

	protected override IEnumerable<Guid> Objects => MetadataLoader.GetChildClasses((ClassMetadata)MetadataServiceContext.Service.GetMetadata(InterfaceActivator.UID<ITaskBase>())).SelectMany((ClassMetadata m) => new List<Guid>
	{
		m.Uid,
		(m is EntityMetadata) ? (m as EntityMetadata).ImplementationUid : m.Uid
	}).Distinct();

	protected override IHistoryBaseModel CreateEventData(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		Contract.ArgumentNotNull(html, "html");
		Contract.ArgumentNotNull(@event, "event");
		Contract.ArgumentNotNull(@event.Action, "event.Action");
		Contract.ArgumentNotNull(historyLoader, "historyLoader");
		if (@event.Action.Uid == WorkflowTaskBaseActions.EscalationGuid)
		{
			return RenderEscalation(@event, historyLoader, SR.T("Задача завершена по эскалации"));
		}
		return null;
	}

	public static IHistoryBaseModel RenderEscalation(EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader, string caption)
	{
		Contract.ArgumentNotNull(historyLoader, "historyLoader");
		IWorkflowTask task = @event.New as IWorkflowTask;
		CommentTaskHistoryModel commentHistory = new CommentTaskHistoryModel(@event, caption);
		if (task != null)
		{
			if (task.Comments != null)
			{
				IEnumerable<EntityActionEventArgs> source = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IComment>(), DefaultEntityActions.CreateGuid);
				commentHistory.Comments = (from IComment q in source.Select((EntityActionEventArgs q) => q.New)
					where ((ICollection<IComment>)task.Comments).Contains(q) && q.CreationAuthor.Equals(commentHistory.ActionAuthor)
					select q).ToList();
			}
			if (task.Attachments != null)
			{
				IEnumerable<EntityActionEventArgs> source2 = historyLoader.LoadHistory(@event.UnitOfWorkUid, InterfaceActivator.UID<IAttachment>(), DefaultEntityActions.CreateGuid);
				commentHistory.Attachments = (from IAttachment a in source2.Select((EntityActionEventArgs e) => e.New)
					where ((ICollection<IAttachment>)task.Attachments).Contains(a)
					select a).ToList();
			}
		}
		return commentHistory;
	}
}
