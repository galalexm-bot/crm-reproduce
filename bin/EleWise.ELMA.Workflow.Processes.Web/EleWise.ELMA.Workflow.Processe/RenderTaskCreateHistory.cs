using System;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.History;
using EleWise.ELMA.Workflow.Audit.HistoryModels;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.History;

[Component(Order = 100)]
public class RenderTaskCreateHistory : IRenderInWorkflowInstanceHistory
{
	public Guid ActionUid => DefaultEntityActions.CreateGuid;

	public IHistoryBaseModel RenderAction(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (@event.ExtendedProperties.ContainsKey("EventType") && @event.ExtendedProperties["EventType"] as string== "SubprocessTaskCreated")
		{
			string actionTheme = SR.T("Запущен подпроцесс \"{0}\"", SR.T(((IWorkflowInstance)@event.New).Process.Name.HtmlEncode()));
			return new CreateWorkflowInstanceHistoryModel(@event, actionTheme)
			{
				Entity = (IWorkflowInstance)@event.New
			};
		}
		string caption = ((@event.New != null) ? SR.T("Задача \"{0}\" создана", SR.T(((ITaskBase)@event.New).Subject.HtmlEncode())) : null);
		return TaskBaseSimpleEventRender.RenderCreate(html, @event, historyLoader, caption);
	}

	public HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		if (@event.ExtendedProperties.ContainsKey("EventType") && @event.ExtendedProperties["EventType"] as string== "SubprocessTaskCreated")
		{
			return new HistoryPartViewBlock
			{
				HistoryPartType = "action",
				Index = 1,
				RenderDelegate = (HtmlHelper html, IHistoryBaseModel model) => PartialExtensions.Partial(html, "AuditView/WorkflowInstance.StartSubprocess", (object)model)
			};
		}
		return null;
	}
}
