using System.Web.Mvc;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Web.Content;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface ILinkTypeProvider
{
	string Id { get; }

	string Name { get; }

	bool ShowInTree { get; }

	string Category { get; }

	string Image { get; }

	string ActionType { get; }

	int? Order { get; }

	IContentAction Get(string id);

	bool IsAvalilable(RequestContext requestContext);

	string GetActionName(IContentAction contentAction);

	MvcHtmlString RenderActionView(HtmlHelper htmlHelper, IContentAction contentAction);

	MvcHtmlString RenderSelector(HtmlHelper htmlHelper);

	MvcHtmlString GetSelectedScript(HtmlHelper htmlHelper);

	MvcHtmlString GetRunScript(HtmlHelper htmlHelper);
}
