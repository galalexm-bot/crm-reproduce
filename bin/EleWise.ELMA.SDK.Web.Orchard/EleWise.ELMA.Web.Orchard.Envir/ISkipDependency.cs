using EleWise.ELMA.ComponentModel;
using Orchard.Environment.ShellBuilders.Models;

namespace EleWise.ELMA.Web.Orchard.Enviroment.ShellBuilders;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface ISkipDependency
{
	bool Skip(DependencyBlueprint dependencyBlueprint);
}
