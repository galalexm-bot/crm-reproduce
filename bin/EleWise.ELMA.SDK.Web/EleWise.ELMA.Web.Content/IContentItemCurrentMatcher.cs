using System.Web.Routing;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Content;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IContentItemCurrentMatcher
{
	int MatchCurrent(RequestContext requestContext);
}
