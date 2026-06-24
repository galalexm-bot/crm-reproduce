using System;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Content;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IContentActionCurrentMatcher
{
	int MatchCurrent(string area, ActionRoute routes, RequestContext requestContext);

	int MatchCurrent(Uri contentItemUri, Uri requestUri);
}
