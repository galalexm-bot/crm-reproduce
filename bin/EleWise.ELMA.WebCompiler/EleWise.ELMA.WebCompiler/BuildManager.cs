using System;
using System.Collections.Generic;
using System.Web;
using System.Web.Caching;
using System.Web.Hosting;

namespace EleWise.ELMA.WebCompiler;

public class BuildManager
{
	private static List<string> modulesToIgnore;

	private static List<CompilingModuleInfo> additionalModules;

	internal static BuildManager instance;

	internal readonly WebApplicationBuildManager buildManager;

	internal readonly WebConfigApplicationBuildManager buildManagerConfig;

	public static void Init(string applicationPhysicalPath, string configurationPhysicalPath, ICompiler compiler, AssemblyLoader assemblyLoader, ICompilerConsole console = null, bool debug = false)
	{
		instance = new BuildManager(applicationPhysicalPath, configurationPhysicalPath, compiler, assemblyLoader, console, debug);
		if (modulesToIgnore != null)
		{
			instance.buildManager.Compiler.ModulesToIgnore.AddRange(modulesToIgnore);
			modulesToIgnore = null;
		}
		if (additionalModules != null)
		{
			instance.buildManager.Compiler.AdditionalModules.AddRange(additionalModules);
			additionalModules = null;
		}
	}

	public static void AddIgnoreModule(string module)
	{
		(((instance != null && instance.buildManager != null && instance.buildManager.Compiler != null) ? instance.buildManager.Compiler.ModulesToIgnore : null) ?? modulesToIgnore ?? (modulesToIgnore = new List<string>())).Add(module);
	}

	public static void AddAdditionalModule(CompilingModuleInfo moduleInfo)
	{
		(((instance != null && instance.buildManager != null && instance.buildManager.Compiler != null) ? instance.buildManager.Compiler.AdditionalModules : null) ?? additionalModules ?? (additionalModules = new List<CompilingModuleInfo>())).Add(moduleInfo);
	}

	public static Type GetCompiledType(string virtualPath)
	{
		string key = "WebBuildManagerRazor_" + virtualPath;
		Type type = HttpRuntime.Cache[key] as Type;
		if (instance != null)
		{
			instance.Visit(virtualPath);
			if (type == null)
			{
				type = instance.GetViewType(virtualPath);
				if (type != null)
				{
					CacheDependency cacheDependency = HostingEnvironment.VirtualPathProvider.GetCacheDependency(virtualPath, new string[1] { virtualPath }, DateTime.UtcNow);
					if (cacheDependency != null)
					{
						HttpRuntime.Cache.Insert(key, type, cacheDependency);
					}
				}
			}
		}
		return type;
	}

	private BuildManager(string applicationPhysicalPath, string configurationPhysicalPath, ICompiler compiler, AssemblyLoader assemblyLoader, ICompilerConsole console, bool debug)
	{
		buildManager = new WebApplicationBuildManager(applicationPhysicalPath, compiler, assemblyLoader, console, debug);
		buildManagerConfig = new WebConfigApplicationBuildManager(buildManager.Compiler, configurationPhysicalPath);
	}

	private Type GetViewType(string virtualPath)
	{
		CompilingFileInfo fileInfo = CompilingFileInfo.Create(virtualPath);
		return buildManager.GetViewType(fileInfo) ?? buildManagerConfig.GetViewType(fileInfo);
	}

	private void Visit(string virtualPath)
	{
		buildManagerConfig.Visit(virtualPath);
	}
}
