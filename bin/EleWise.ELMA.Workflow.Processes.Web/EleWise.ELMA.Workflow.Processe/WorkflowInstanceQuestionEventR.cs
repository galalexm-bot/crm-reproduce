using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Models.History;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Models;

namespace EleWise.ELMA.Workflow.Processes.Web.History;

[Component(Order = 1)]
public class WorkflowInstanceQuestionEventRender : BaseAuditQuestionEventRender
{
	protected override IEnumerable<Guid> Actions
	{
		get
		{
			yield return DefaultEntityActions.CreateGuid;
		}
	}

	protected override IEnumerable<Guid> Objects
	{
		get
		{
			yield return InterfaceActivator.UID<IQuestion>();
		}
	}

	public override bool CanRender(EntityActionEventArgs @event)
	{
		return CanRenderCheckClasses(@event, InterfaceActivator.UID<IWorkflowInstance>());
	}

	protected override IHistoryBaseModel CreateEventData(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		string actionTheme = SR.T("Задан вопрос");
		if (@event.ExtendedProperties.ContainsKey("Theme") && @event.ExtendedProperties["Theme"] != null)
		{
			actionTheme = @event.ExtendedProperties["Theme"].ToString();
		}
		return new QuestionTaskHistoryModel(@event, actionTheme)
		{
			Question = (IQuestion)@event.New
		};
	}
}
