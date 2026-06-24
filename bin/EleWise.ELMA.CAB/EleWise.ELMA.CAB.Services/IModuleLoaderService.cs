using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.CAB.Configuration;
using EleWise.ELMA.CAB.Utility;

namespace EleWise.ELMA.CAB.Services;

public interface IModuleLoaderService
{
	IList<LoadedModuleInfo> LoadedModules { get; }

	event EventHandler<DataEventArgs<LoadedModuleInfo>> ModuleLoaded;

	void Load(WorkItem workItem, params IModuleInfo[] modules);

	void Load(WorkItem workItem, params Assembly[] assemblies);
}
