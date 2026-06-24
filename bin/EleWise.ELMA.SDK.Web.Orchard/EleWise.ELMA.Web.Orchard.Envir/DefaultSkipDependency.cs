using EleWise.ELMA.ComponentModel;
using Orchard.Environment.ShellBuilders.Models;
using Orchard.Mvc.AntiForgery;

namespace EleWise.ELMA.Web.Orchard.Enviroment.ShellBuilders;

[Component]
public class DefaultSkipDependency : ISkipDependency
{
	public bool Skip(DependencyBlueprint dependencyBlueprint)
	{
		if (dependencyBlueprint.Type == typeof(AntiForgeryAuthorizationFilter))
		{
			return true;
		}
		return false;
	}
}
