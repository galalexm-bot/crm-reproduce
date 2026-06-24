using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.Documents.Web.History;

[Component]
public class RenderDocumentTaskRedirectHistory : RenderInDocumentHistoryBase
{
	public override Guid ActionUid => TaskBaseActions.RedirectGuid;

	public override IHistoryBaseModel RenderAction(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		string caption = ((@event.New != null) ? SR.T("Задача \"{0}\" переназначена", $"<a href=\"{html.Url().Entity(@event.New)}\">{SR.T(((ITaskBase)@event.New).Subject.HtmlEncode())}</a>") : null);
		ApplySettings(@event, historyLoader);
		return TaskBaseSimpleEventRender.RenderRedirect(html, @event, historyLoader, caption);
	}

	public override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		return TaskBaseSimpleEventRender.RedirectViewBlock();
	}

	public override bool CanRender(EntityActionEventArgs args)
	{
		return args.Object.Uid == InterfaceActivator.UID<IDocument>();
	}
}
