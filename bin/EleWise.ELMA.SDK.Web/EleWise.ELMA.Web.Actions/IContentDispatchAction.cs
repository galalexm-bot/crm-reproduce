using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.Web.Actions;

public interface IContentDispatchAction : IContentItem, IAuditEventHolder
{
	string GetHref(RequestContext requestContext, params object[] methodArgs);

	string GetOnClick(RequestContext requestContext, params object[] methodArgs);

	void OnRender(HtmlHelper htmlHelper, params object[] methodArgs);
}
