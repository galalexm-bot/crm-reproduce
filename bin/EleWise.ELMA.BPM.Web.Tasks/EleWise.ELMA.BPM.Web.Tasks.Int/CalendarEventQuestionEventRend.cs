using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Models.History;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Integration.History;

[Component(Order = 50)]
public class CalendarEventQuestionEventRender : BaseAuditQuestionEventRender
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
		return CanRenderCheckClasses(@event, InterfaceActivator.UID<ICalendarEvent>());
	}

	protected override IHistoryBaseModel CreateEventData(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		return new QuestionCalendarEventHistoryModel(@event, SR.T("Задан вопрос"))
		{
			Question = (IQuestion)@event.New
		};
	}
}
