using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.Workflow.Processes.Web.History;

[Component(Order = 100)]
public class RenderTaskStartWorkHistory : IRenderInWorkflowInstanceHistory
{
	public Guid ActionUid => TaskBaseActions.StartWorkGuid;

	public IHistoryBaseModel RenderAction(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		string caption = ((@event.New != null) ? SR.T("Работа над задачей \"{0}\" начата", SR.T(((ITaskBase)@event.New).Subject.HtmlEncode())) : null);
		return TaskBaseSimpleEventRender.RenderStartWork(html, @event, historyLoader, caption);
	}

	public HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		return TaskBaseSimpleEventRender.RenderStartWork();
	}
}
