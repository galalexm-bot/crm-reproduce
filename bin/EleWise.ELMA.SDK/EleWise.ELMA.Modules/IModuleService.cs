using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Modules;

public interface IModuleService
{
	IEnumerable<IWebModuleUnit> GetEnabledModules();

	IWebModuleUnit GetModuleByType(Type type);

	IEnumerable<IWebModuleUnit> GetInstalledModules();
}
