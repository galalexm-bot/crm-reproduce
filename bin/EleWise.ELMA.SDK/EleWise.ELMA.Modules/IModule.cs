using System.Collections.Generic;

namespace EleWise.ELMA.Modules;

public interface IModule : ICompositeApplicationUnit, IApplicationUnit
{
	ModuleType ModuleType { get; }

	string WebSite { get; }

	string HtmlDescription { get; }

	bool ServerModuleRequired { get; }

	IEnumerable<IModuleAssembly> Assemblies { get; }

	IEnumerable<IModule> ExtensionModules { get; }

	ModuleStatus Status { get; }

	ModuleDisabledReason DisabledReason { get; }
}
