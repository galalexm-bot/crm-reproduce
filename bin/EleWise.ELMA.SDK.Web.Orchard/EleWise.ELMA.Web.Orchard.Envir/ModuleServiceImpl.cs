using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Modules;
using Orchard.Environment.Extensions.Models;
using Orchard.Environment.Features;

namespace EleWise.ELMA.Web.Orchard.Enviroment.Modules;

[Service(Scope = ServiceScope.Shell)]
public class ModuleServiceImpl : IModuleService
{
	private readonly IFeatureManager featureManager;

	public ModuleServiceImpl(IFeatureManager featureManager)
	{
		this.featureManager = featureManager;
	}

	public IEnumerable<IWebModuleUnit> GetEnabledModules()
	{
		return (from fd in featureManager.GetEnabledFeatures()
			select new Module(fd)).ToList();
	}

	public IWebModuleUnit GetModuleByType(Type type)
	{
		return GetEnabledModules().FirstOrDefault((IWebModuleUnit m) => m.Uid == AssemblyModuleName(type.Assembly));
	}

	private string AssemblyModuleName(Assembly assembly)
	{
		return assembly.GetName().Name;
	}

	public IEnumerable<IWebModuleUnit> GetInstalledModules()
	{
		return (from fd in featureManager.GetAvailableFeatures()
			select new Module(fd)).ToList();
	}
}
