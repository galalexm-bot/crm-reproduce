using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.Workflow.Processes.Web.History;

[Component(Order = 100)]
internal sealed class RenderCreateSubTaskHistory : IRenderInWorkflowInstanceHistory
{
	public Guid ActionUid => TaskBaseActions.CreateSubTaskGuid;

	public IHistoryBaseModel RenderAction(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		return TaskBaseSimpleEventRender.RenderCreateSubTask(html, @event, historyLoader);
	}

	public HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		return new HistoryPartViewBlock
		{
			HistoryPartType = "action",
			Index = 1,
			RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/Task.CreateSubTask", (object)model)
		};
	}
}
