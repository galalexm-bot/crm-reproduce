using System;
using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.History;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Web.Components;

namespace EleWise.ELMA.Workflow.Processes.Web.History;

[Component(Order = 100)]
public class RenderTaskEscalationHistory : IRenderInWorkflowInstanceHistory
{
	public Guid ActionUid => WorkflowTaskBaseActions.EscalationGuid;

	public HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		return null;
	}

	public IHistoryBaseModel RenderAction(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		string caption = ((@event.New != null) ? SR.T("Задача \"{0}\" завершена по эскалации", ((ITaskBase)@event.New).Subject.HtmlEncode()) : null);
		return WorkflowTaskSimpleEventRender.RenderEscalation(@event, historyLoader, caption);
	}
}
