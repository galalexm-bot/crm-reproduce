using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.Web.Mvc.Models.History;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public abstract class BaseAuditEventRender : IAuditEventRender
{
	private IList<Guid> actions;

	private IList<Guid> objects;

	protected abstract IEnumerable<Guid> Actions { get; }

	protected abstract IEnumerable<Guid> Objects { get; }

	public virtual bool CanRender(EntityActionEventArgs @event)
	{
		if (@event != null && @event.Action != null && @event.Object != null && (objects ?? (objects = Objects.ToList())).Contains(@event.Object.Uid))
		{
			return (actions ?? (actions = Actions.ToList())).Contains(@event.Action.Uid);
		}
		return false;
	}

	public virtual MvcHtmlString Render(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (@event == null)
		{
			throw new ArgumentNullException("event");
		}
		if (historyLoader == null)
		{
			throw new ArgumentNullException("historyLoader");
		}
		IHistoryBaseModel historyModel = EvaluateEventData(@event, CreateEventData(html, @event, historyLoader));
		return RenderEventData(html, @event, historyModel);
	}

	protected virtual MvcHtmlString RenderEventData(HtmlHelper html, EntityActionEventArgs @event, IHistoryBaseModel historyModel)
	{
		if (html == null)
		{
			throw new ArgumentNullException("html");
		}
		if (@event == null)
		{
			throw new ArgumentNullException("event");
		}
		if (historyModel == null)
		{
			throw new ArgumentNullException("historyModel");
		}
		return html.HistoryItem(historyModel, GetExtraViewBlock(@event));
	}

	protected virtual HistoryPartViewBlock GetExtraViewBlock(EntityActionEventArgs @event)
	{
		return null;
	}

	protected abstract IHistoryBaseModel CreateEventData(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader);

	protected IHistoryBaseModel EvaluateEventData(EntityActionEventArgs @event, IHistoryBaseModel historyModel)
	{
		if (historyModel == null)
		{
			historyModel = new SystemHistoryModel(@event, SR.T("Не удалось сформировать объект истории для события {0} объекта {1}", @event.Action.DisplayName, @event.Object.DisplayName));
		}
		Locator.GetServiceNotNull<IEnumerable<IHistoryModelEvaluator>>().ForEach(delegate(IHistoryModelEvaluator e)
		{
			e.Evaluate(historyModel);
		});
		return historyModel;
	}
}
