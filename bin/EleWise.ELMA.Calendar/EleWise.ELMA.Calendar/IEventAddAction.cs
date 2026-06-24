using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Calendar;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public interface IEventAddAction
{
	string Uid { get; }

	string Name { get; }

	dynamic WindowSettings { get; }

	string Icon { get; }

	int Order { get; }

	bool AllowInShared { get; }

	string Url(RequestContext context);
}
