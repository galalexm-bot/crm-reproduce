using System.Collections.Generic;

namespace EleWise.ELMA.Modules;

public interface IApplication : IModule, ICompositeApplicationUnit, IApplicationUnit
{
	IModule MainModule { get; }

	IEnumerable<IModule> SystemModules { get; }
}
