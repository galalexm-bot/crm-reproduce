using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;

namespace EleWise.ELMA.WebCompiler;

public class WebModuleBuildManager
{
	private readonly WebModuleCompiler moduleCompiler;

	internal CompiledSiteInfo currentSiteInfo;

	protected readonly ReaderWriterLockSlim @lock = new ReaderWriterLockSlim();

	protected readonly ICompilerConsole console;

	protected readonly AssemblyLoader assemblyLoader;

	public string PhysicalPath { get; private set; }

	public WebModuleBuildManager(WebApplicationCompiler applicationCompiler, string physicalPath, string virtualPath)
		: this(applicationCompiler, physicalPath, null, virtualPath)
	{
	}

	public WebModuleBuildManager(WebApplicationCompiler applicationCompiler, string physicalPath, string relativePhysicalPath, string virtualPath)
		: this(applicationCompiler, physicalPath, relativePhysicalPath, virtualPath, new CompiledSiteInfo(string.IsNullOrEmpty(relativePhysicalPath) ? physicalPath : Path.Combine(physicalPath, relativePhysicalPath), applicationCompiler.console, applicationCompiler.Debug))
	{
	}

	internal WebModuleBuildManager(WebApplicationCompiler applicationCompiler, string physicalPath, string relativePhysicalPath, string virtualPath, CompiledSiteInfo siteInfo)
	{
		console = applicationCompiler.console;
		assemblyLoader = applicationCompiler.assemblyLoader;
		PhysicalPath = physicalPath;
		currentSiteInfo = siteInfo;
		moduleCompiler = GetModuleCompiler(applicationCompiler, GetCompilingModuleInfo(applicationCompiler, string.IsNullOrEmpty(relativePhysicalPath) ? physicalPath : Path.Combine(physicalPath, relativePhysicalPath), virtualPath));
	}

	public virtual Type GetViewType(CompilingFileInfo fileInfo)
	{
		using (@lock.ReadLock())
		{
			if (currentSiteInfo.TryGetCompiledType(fileInfo, assemblyLoader, out var type) != false)
			{
				return type;
			}
		}
		using (@lock.WriteLock())
		{
			if (currentSiteInfo.TryLoad() && currentSiteInfo.TryGetCompiledType(fileInfo, assemblyLoader, out var type2) != false)
			{
				return type2;
			}
			if (!currentSiteInfo.IsInitialized || currentSiteInfo.HasChanges(moduleCompiler.GetCompilingFileInfos()))
			{
				moduleCompiler.Compile();
				if (moduleCompiler.SiteInfo != null)
				{
					IEnumerable<CompiledAssemblyInfo> assembliesInfo = moduleCompiler.AssemblyUids.Select((string assemblyName) => new CompiledAssemblyInfo
					{
						AssemblyName = assemblyName,
						AssemblyRaw = moduleCompiler.GetAssemblyRaw(assemblyName),
						DebugRaw = (moduleCompiler.Debug ? moduleCompiler.GetDebugRaw(assemblyName) : null)
					});
					currentSiteInfo.Save(moduleCompiler.SiteInfo.Files, assembliesInfo);
				}
				if (currentSiteInfo.TryGetCompiledType(fileInfo, assemblyLoader, out type2) != false)
				{
					return type2;
				}
			}
		}
		return null;
	}

	private CompilingModuleInfo GetCompilingModuleInfo(WebApplicationCompiler applicationCompiler, string modulePhysicalPath, string virtualPath)
	{
		if (modulePhysicalPath.EndsWith("\\"))
		{
			modulePhysicalPath = modulePhysicalPath.Remove(modulePhysicalPath.Length - 1);
		}
		CompilingModuleInfo compilingModuleInfo = new CompilingModuleInfo
		{
			PhysicalPath = modulePhysicalPath,
			VirtualPath = virtualPath
		};
		string text = applicationCompiler.PhysicalPath;
		if (text.EndsWith("\\"))
		{
			text = text.Remove(text.Length - 1);
		}
		if (modulePhysicalPath.Equals(text))
		{
			compilingModuleInfo.IgnoredPaths.AddRange(applicationCompiler.ModuleContainerFolders);
		}
		return compilingModuleInfo;
	}

	internal static WebModuleCompiler GetModuleCompiler(WebApplicationCompiler applicationCompiler, CompilingModuleInfo moduleInfo)
	{
		string baseAssemblyName = "WebModule_" + moduleInfo.VirtualPath.Replace("/", "_").Replace("~", "").Replace(".", "_") + "_";
		WebModuleCompiler webModuleCompiler = new WebModuleCompiler(applicationCompiler.PhysicalPath, moduleInfo.PhysicalPath, moduleInfo.VirtualPath, "ASP", baseAssemblyName, applicationCompiler.compiler, applicationCompiler.console, applicationCompiler.GetAssemblyLocation);
		webModuleCompiler.Debug = applicationCompiler.Debug;
		webModuleCompiler.RelativePhysicalPath = moduleInfo.RelativePhysicalPath;
		webModuleCompiler.RetryCompileWithoutFailedFiles = applicationCompiler.RetryCompileWithoutFailedFiles;
		webModuleCompiler.IgnoreParseError = applicationCompiler.IgnoreParseError;
		webModuleCompiler.IgnoredPaths.AddRange(moduleInfo.IgnoredPaths);
		webModuleCompiler.BeforeCompile += applicationCompiler.BeforeCompile;
		return webModuleCompiler;
	}
}
