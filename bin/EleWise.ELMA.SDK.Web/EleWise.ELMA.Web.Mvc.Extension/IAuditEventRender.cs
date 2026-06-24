using System.Web.Mvc;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IAuditEventRender
{
	bool CanRender(EntityActionEventArgs @event);

	MvcHtmlString Render(HtmlHelper html, EntityActionEventArgs @event, IEntityActionHistoryLoader historyLoader);
}
