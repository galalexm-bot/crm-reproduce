using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Dependencies;
using EleWise.ELMA.UI.Components.Dependency.Models;

namespace EleWise.ELMA.UI.Components.Dependency;

[ExtensionPoint(ComponentType.All)]
public interface IDependencyFinder
{
	IEnumerable<EleWise.ELMA.Model.Dependencies.Dependency> GetDependencies(IEnumerable<IDependencyRequest> dependencyRequests);
}
