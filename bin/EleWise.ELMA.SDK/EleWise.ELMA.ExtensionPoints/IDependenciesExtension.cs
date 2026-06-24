using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Dependencies;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IDependenciesExtension
{
	IEnumerable<IDependencyContainer> GetDependencyContainers(Guid uid);
}
