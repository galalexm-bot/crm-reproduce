using System.Web.Mvc;
using System.Web.Routing;

namespace EleWise.ELMA.Web.Content;

public interface IContentAction : IContentItem
{
	string ReferenceType { get; }

	string ActionType { get; }

	string Category { get; }

	string NameForLocalization { get; }

	string DescriptionForLocalization { get; }

	string GetHref(RequestContext requestContext);

	void OnRender(HtmlHelper htmlHelper);

	bool IsAvalilable(RequestContext requestContext);

	int MatchCurrent(RequestContext requestContext);
}
