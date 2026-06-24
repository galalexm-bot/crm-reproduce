using System;
using System.Collections.Generic;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Models.History;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Web.Components;

[Component(Order = 50)]
public class DocumentQuestionEventRender : BaseAuditQuestionEventRender
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
		return CanRenderCheckClasses(@event, InterfaceActivator.UID<IDocument>());
	}

	protected override IHistoryBaseModel CreateEventData(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		return new QuestionTaskHistoryModel(@event, SR.T("Задан вопрос"))
		{
			Question = (IQuestion)@event.New
		};
	}
}
