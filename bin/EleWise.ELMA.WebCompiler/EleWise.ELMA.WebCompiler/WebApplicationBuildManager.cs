using System;
using System.Collections.Concurrent;
using System.IO;
using System.Linq;

namespace EleWise.ELMA.WebCompiler;

public class WebApplicationBuildManager
{
	private readonly WebApplicationCompiler compiler;

	private readonly ConcurrentDictionary<string, WebModuleBuildManager> moduleManagers = new ConcurrentDictionary<string, WebModuleBuildManager>(StringComparer.OrdinalIgnoreCase);

	public string PhysicalPath { get; private set; }

	public WebApplicationCompiler Compiler => compiler;

	public WebApplicationBuildManager(string physicalPath, ICompiler compiler, AssemblyLoader assemblyLoader, ICompilerConsole console = null, bool debug = false)
	{
		PhysicalPath = physicalPath;
		this.compiler = new WebApplicationCompiler(compiler, assemblyLoader, physicalPath)
		{
			IgnoreParseError = true,
			RetryCompileWithoutFailedFiles = true,
			Console = console,
			Debug = debug
		};
	}

	public Type GetViewType(CompilingFileInfo fileInfo)
	{
		if (fileInfo.PhysicalPath == null)
		{
			return null;
		}
		string physicalPath = Path.GetFullPath(fileInfo.PhysicalPath);
		WebModuleBuildManager webModuleBuildManager = null;
		foreach (CompilingModuleInfo module in compiler.AdditionalModules)
		{
			if (physicalPath.StartsWith(module.PhysicalPath + "\\", StringComparison.OrdinalIgnoreCase))
			{
				webModuleBuildManager = moduleManagers.GetOrAdd(module.PhysicalPath, (string _) => (!Directory.Exists(module.PhysicalPath)) ? null : new WebModuleBuildManager(compiler, module.PhysicalPath, module.RelativePhysicalPath, module.VirtualPath));
				break;
			}
		}
		if (webModuleBuildManager == null && physicalPath.StartsWith(compiler.PhysicalPath + "\\", StringComparison.OrdinalIgnoreCase) && !compiler.ModulesToIgnore.Any((string m) => physicalPath.StartsWith(compiler.PhysicalPath + "\\" + m + "\\", StringComparison.OrdinalIgnoreCase)))
		{
			string[] pathItems = physicalPath.Substring(compiler.PhysicalPath.Length + 1).Split('\\');
			bool isRoot = pathItems.Length < 2 || compiler.ModuleContainerFolders.All((string f) => !f.Equals(pathItems[0], StringComparison.OrdinalIgnoreCase));
			string modulePath = (isRoot ? compiler.PhysicalPath : Path.Combine(compiler.PhysicalPath, pathItems[0], pathItems[1]));
			webModuleBuildManager = moduleManagers.GetOrAdd(modulePath, (string _) => (!Directory.Exists(modulePath)) ? null : new WebModuleBuildManager(compiler, modulePath, isRoot ? "" : ("/" + pathItems[0] + "/" + pathItems[1])));
		}
		return webModuleBuildManager?.GetViewType(fileInfo);
	}
}
