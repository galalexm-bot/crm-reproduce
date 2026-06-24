using System.Collections.Generic;

namespace Orchard.Mvc.ViewEngines;

public class CreateModulesViewEngineParams
{
	public IEnumerable<string> VirtualPaths { get; set; }

	public IEnumerable<string> ExtensionLocations { get; set; }
}
