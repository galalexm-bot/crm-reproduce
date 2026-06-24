using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Tasks.Components;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Metadata;
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
public class RenderDocumentTaskInCompleteHistory : RenderInDocumentHistoryBase
{
	public override Guid ActionUid => TaskBaseActions.IncompleteGuid;

	public override IHistoryBaseModel RenderAction(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		string caption = ((@event.New != null) ? SR.T("Задачу \"{0}\" выполнить невозможно", $"<a href=\"{html.Url().Entity(@event.New)}\">{SR.T(((ITaskBase)@event.New).Subject.HtmlEncode())}</a>") : null);
		ApplySettings(@event, historyLoader);
		return TaskBaseSimpleEventRender.RenderInComplete(html, @event, historyLoader, caption);
	}

	public override HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		return null;
	}

	public override bool CanRender(EntityActionEventArgs args)
	{
		List<Guid> list = (from documentMetadata in MetadataServiceContext.Service.GetMetadataList().OfType<DocumentMetadata>()
			select documentMetadata.Uid).ToList();
		list.Add(InterfaceActivator.UID<IDocument>());
		if (!args.ExtendedProperties.ContainsKey("EventType") || (args.ExtendedProperties.ContainsKey("EventType") && "FromTask".Equals(args.ExtendedProperties["EventType"])))
		{
			return list.Any((Guid t) => t == args.Object.Uid);
		}
		return false;
	}
}
