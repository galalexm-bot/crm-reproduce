using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EleWise.ELMA.WebCompiler;

public class WebApplicationCompiler
{
	private class ConsoleWrapper : ICompilerConsole
	{
		private readonly WebApplicationCompiler owner;

		public ConsoleWrapper(WebApplicationCompiler owner)
		{
			this.owner = owner;
		}

		public void WriteError(string message)
		{
			if (owner.Console != null)
			{
				owner.Console.WriteError(message);
			}
		}

		public void WriteInfo(string message)
		{
			if (owner.Console != null)
			{
				owner.Console.WriteInfo(message);
			}
		}

		public void WriteWarning(string message)
		{
			if (owner.Console != null)
			{
				owner.Console.WriteWarning(message);
			}
		}

		public void WriteDebug(string message)
		{
			if (owner.Console != null)
			{
				owner.Console.WriteDebug(message);
			}
		}
	}

	private static readonly string[] ignoreWarnings = new string[2] { "CS1685", "CS1702" };

	private readonly Dictionary<string, Dictionary<AssemblyName, string>> assemblies = new Dictionary<string, Dictionary<AssemblyName, string>>();

	private List<string> assembliesToCompile = new List<string>();

	private readonly Dictionary<string, string> appDomainAssembliesByName = new Dictionary<string, string>();

	internal readonly ICompiler compiler;

	internal readonly ICompilerConsole console;

	internal readonly AssemblyLoader assemblyLoader;

	private bool prepared;

	private readonly object prepareLock = new object();

	private List<CompilingModuleInfo> modules;

	public string PhysicalPath { get; private set; }

	public List<string> ModuleContainerFolders { get; private set; }

	public List<string> ModulesToCompile { get; private set; }

	public List<string> ModulesToIgnore { get; private set; }

	public List<CompilingModuleInfo> AdditionalModules { get; private set; }

	public List<Assembly> AdditionalAssemblies { get; private set; }

	public bool Debug { get; set; }

	public bool IgnoreParseError { get; set; }

	public bool RetryCompileWithoutFailedFiles { get; set; }

	public ICompilerConsole Console { get; set; }

	public WebApplicationCompiler(ICompiler compiler, AssemblyLoader assemblyLoader, string physicalPath)
	{
		this.compiler = compiler;
		this.assemblyLoader = assemblyLoader;
		console = new ConsoleWrapper(this);
		physicalPath = physicalPath.Replace('/', '\\');
		PhysicalPath = (physicalPath.EndsWith("\\") ? physicalPath.Substring(0, physicalPath.Length - 1) : physicalPath);
		ModuleContainerFolders = new List<string> { "Modules", "Themes" };
		ModulesToCompile = new List<string>();
		ModulesToIgnore = new List<string>();
		AdditionalModules = new List<CompilingModuleInfo>();
		AdditionalAssemblies = new List<Assembly>();
	}

	public void Compile(bool saveCompiledSiteInfo)
	{
		Prepare();
		WebModuleCompiler webModuleCompiler;
		foreach (CompilingModuleInfo module in modules)
		{
			try
			{
				webModuleCompiler = WebModuleBuildManager.GetModuleCompiler(this, module);
				try
				{
					webModuleCompiler.Compile();
					if (saveCompiledSiteInfo && webModuleCompiler.SiteInfo != null)
					{
						IEnumerable<CompiledAssemblyInfo> assembliesInfo = webModuleCompiler.AssemblyUids.Select((string assemblyName) => new CompiledAssemblyInfo
						{
							AssemblyName = assemblyName,
							AssemblyRaw = webModuleCompiler.GetAssemblyRaw(assemblyName),
							DebugRaw = (webModuleCompiler.Debug ? webModuleCompiler.GetDebugRaw(assemblyName) : null)
						});
						webModuleCompiler.SiteInfo.Save(webModuleCompiler.SiteInfo.Files, assembliesInfo);
					}
				}
				catch (WebCompileException)
				{
				}
				int length = module.PhysicalPath.Length;
				foreach (WebCompileDiagnostic item in webModuleCompiler.CompilationDiagnostics.Where((WebCompileDiagnostic d) => !ignoreWarnings.Contains(d.Id, StringComparer.OrdinalIgnoreCase)))
				{
					string text = ((item.Position == null || string.IsNullOrEmpty(item.Position.FilePath)) ? null : ((Path.GetExtension(item.Position.FilePath) == ".viewengine") ? ("~" + Path.ChangeExtension(item.Position.FilePath, ".cshtml") + ": ") : ("~" + module.VirtualPath + item.Position.FilePath.Substring(length).Replace('\\', '/') + "(" + item.Position.Line + ", " + item.Position.Character + "): ")));
					if (item.IsError)
					{
						console.WriteError(text + item);
					}
					else
					{
						console.WriteWarning(text + item);
					}
				}
			}
			catch (Exception ex2)
			{
				console.WriteError("FAILED:\r\n" + ex2);
			}
		}
	}

	internal void BeforeCompile(object sender, EventArgs e)
	{
		Prepare();
		WebModuleCompiler obj = (WebModuleCompiler)sender;
		obj.ReferencedAssemblies.Clear();
		obj.ReferencedAssemblies.AddRange(assembliesToCompile);
	}

	private void AddAssembliesFromDirectory(string path, HashSet<string> assembliesToCompile)
	{
		foreach (string item in Directory.GetFiles(path, "*.dll").Union(Directory.GetFiles(path, "*.exe")))
		{
			AddAssembly(AssemblyName.GetAssemblyName(item), assembliesToCompile);
		}
	}

	private void Prepare()
	{
		if (prepared)
		{
			return;
		}
		lock (prepareLock)
		{
			if (prepared)
			{
				return;
			}
			HashSet<string> source = new HashSet<string>();
			foreach (Assembly item in from a in AppDomain.CurrentDomain.GetAssemblies()
				where !a.IsDynamic
				select a)
			{
				appDomainAssembliesByName[item.FullName] = item.Location;
			}
			AddAssembly(new AssemblyName("System, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089"), source);
			AddAssembly(new AssemblyName("System.Web, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a"), source);
			console.WriteInfo("Loading main assemblies...");
			string path = Path.Combine(PhysicalPath, "bin");
			AddAssembliesFromDirectory(path, source);
			IEnumerable<string> enumerable = ModuleContainerFolders.SelectMany(delegate(string f)
			{
				string path3 = Path.Combine(PhysicalPath, f);
				return (!Directory.Exists(path3)) ? new string[0] : Directory.GetDirectories(path3);
			});
			modules = new List<CompilingModuleInfo>();
			CompilingModuleInfo compilingModuleInfo = GetCompilingModuleInfo(PhysicalPath, "");
			modules.Add(compilingModuleInfo);
			console.WriteInfo("Loading assemblies from modules...");
			foreach (string item2 in enumerable)
			{
				string relativePath = item2.Substring(PhysicalPath.Length + 1);
				if (!ModulesToIgnore.Any((string p) => p.Equals(relativePath, StringComparison.CurrentCultureIgnoreCase)))
				{
					CompilingModuleInfo compilingModuleInfo2 = GetCompilingModuleInfo(item2, "/" + relativePath.Replace('\\', '/'));
					string path2 = Path.Combine(compilingModuleInfo2.PhysicalPath, "bin");
					if (Directory.Exists(path2))
					{
						AddAssembliesFromDirectory(path2, source);
					}
					modules.Add(compilingModuleInfo2);
				}
			}
			modules.AddRange(AdditionalModules);
			assembliesToCompile = source.Select(GetLastVersionLocation).ToList();
			prepared = true;
		}
	}

	internal string GetAssemblyLocation(string assembly)
	{
		AssemblyName assemblyName = new AssemblyName(assembly);
		AddAssembly(assemblyName);
		return GetLastVersionLocation(assemblyName.Name);
	}

	private string GetLastVersionLocation(string shortName)
	{
		Dictionary<AssemblyName, string> dictionary = assemblies[shortName];
		if (dictionary.Count == 1)
		{
			return dictionary.Values.First();
		}
		Version maxVersion = dictionary.Keys.Where((AssemblyName an) => an.Version != null).Max((AssemblyName an) => an.Version);
		return dictionary.First((KeyValuePair<AssemblyName, string> an) => an.Key.Version == maxVersion).Value;
	}

	private void AddAssembly(AssemblyName name, HashSet<string> assembliesToCompile = null)
	{
		try
		{
			string fullName = name.FullName;
			string name2 = name.Name;
			if (!assemblies.TryGetValue(name2, out var value))
			{
				value = new Dictionary<AssemblyName, string>();
				assemblies[name2] = value;
			}
			if (!value.Keys.Any((AssemblyName n) => n.FullName.Equals(fullName)))
			{
				if (!appDomainAssembliesByName.TryGetValue(fullName, out var value2))
				{
					value2 = ((name.CodeBase != null) ? new Uri(name.CodeBase).LocalPath : Assembly.ReflectionOnlyLoad(name.FullName).Location);
				}
				value[name] = value2;
			}
			assembliesToCompile?.Add(name2);
		}
		catch (FileLoadException)
		{
		}
		catch (BadImageFormatException)
		{
		}
	}

	private CompilingModuleInfo GetCompilingModuleInfo(string modulePhysicalPath, string virtualPath)
	{
		string text = PhysicalPath;
		if (text.EndsWith("\\"))
		{
			text = text.Remove(text.Length - 1);
		}
		if (modulePhysicalPath.EndsWith("\\"))
		{
			modulePhysicalPath = modulePhysicalPath.Remove(modulePhysicalPath.Length - 1);
		}
		CompilingModuleInfo compilingModuleInfo = new CompilingModuleInfo
		{
			PhysicalPath = modulePhysicalPath,
			VirtualPath = virtualPath
		};
		if (modulePhysicalPath.Equals(text))
		{
			compilingModuleInfo.IgnoredPaths.AddRange(ModuleContainerFolders);
		}
		return compilingModuleInfo;
	}
}
