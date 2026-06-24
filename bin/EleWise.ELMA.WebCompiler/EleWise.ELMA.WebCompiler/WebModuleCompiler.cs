using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.WebPages.Razor.Configuration;

namespace EleWise.ELMA.WebCompiler;

internal class WebModuleCompiler
{
	private readonly Dictionary<string, byte[]> assemblyRaws;

	private readonly Dictionary<string, byte[]> debugRaws;

	protected readonly string applicationPhysicalPath;

	private readonly string defaultNamespace;

	private readonly ICompiler compiler;

	private readonly ICompilerConsole console;

	private readonly string baseAssemblyName;

	internal readonly string baseAssemblyUid;

	private readonly Func<string, string> getAssemblyLocation;

	public string PhysicalPath { get; private set; }

	public string VirtualPath { get; private set; }

	public string RelativePhysicalPath { get; set; }

	public List<string> IgnoredPaths { get; private set; }

	public List<string> ReferencedAssemblies { get; private set; }

	public virtual bool Debug { get; set; }

	public bool IgnoreParseError { get; set; }

	public bool RetryCompileWithoutFailedFiles { get; set; }

	public IEnumerable<string> AssemblyUids => assemblyRaws.Keys;

	public bool AnyAssemblyRaw => assemblyRaws.Any((KeyValuePair<string, byte[]> p) => p.Value != null);

	internal CompiledSiteInfo SiteInfo { get; set; }

	public HttpParseException[] ParseFileExceptions { get; private set; }

	public WebCompileDiagnostic[] CompilationDiagnostics { get; private set; }

	protected internal virtual string LogCompilingName => "~" + VirtualPath + "/";

	public event EventHandler BeforeCompile;

	public WebModuleCompiler(string applicationPhysicalPath, string physicalPath, string virtualPath, string defaultNamespace, string baseAssemblyName, ICompiler compiler, ICompilerConsole console, Func<string, string> getAssemblyLocation)
	{
		this.applicationPhysicalPath = applicationPhysicalPath;
		PhysicalPath = physicalPath;
		VirtualPath = virtualPath;
		IgnoredPaths = new List<string>();
		ReferencedAssemblies = new List<string>();
		ParseFileExceptions = new HttpParseException[0];
		this.defaultNamespace = defaultNamespace;
		this.baseAssemblyName = baseAssemblyName;
		baseAssemblyUid = ((uint)baseAssemblyName.GetHashCode()).ToString();
		this.compiler = compiler;
		this.console = console;
		this.getAssemblyLocation = getAssemblyLocation;
		assemblyRaws = new Dictionary<string, byte[]>(StringComparer.OrdinalIgnoreCase);
		debugRaws = new Dictionary<string, byte[]>(StringComparer.OrdinalIgnoreCase);
	}

	public byte[] GetAssemblyRaw(string assemblyUid)
	{
		return assemblyRaws[assemblyUid];
	}

	public byte[] GetDebugRaw(string assemblyUid)
	{
		return debugRaws[assemblyUid];
	}

	protected virtual ICollection<string> GetCompilingDirectories()
	{
		string modulePhysicalPath = (string.IsNullOrEmpty(RelativePhysicalPath) ? PhysicalPath : Path.Combine(PhysicalPath, RelativePhysicalPath));
		return Directory.GetFiles(modulePhysicalPath, "Web.config", SearchOption.AllDirectories).Where(delegate(string physicalPath)
		{
			string relativePhysicalPath = physicalPath.Substring(modulePhysicalPath.Length);
			return !IgnoredPaths.Any((string p) => relativePhysicalPath.StartsWith("\\" + p + "\\"));
		}).Select(Path.GetDirectoryName)
			.Reverse()
			.ToArray();
	}

	internal virtual ICollection<CompilingFileInfo> GetCompilingFileInfos(string compilingDirectory = null, ICollection<string> localIgnoredPaths = null)
	{
		string modulePhysicalPath = (string.IsNullOrEmpty(RelativePhysicalPath) ? PhysicalPath : Path.Combine(PhysicalPath, RelativePhysicalPath));
		return (from f in Directory.GetFiles(compilingDirectory ?? (string.IsNullOrEmpty(RelativePhysicalPath) ? PhysicalPath : Path.Combine(PhysicalPath, RelativePhysicalPath)), "*.cshtml", SearchOption.AllDirectories).Select(delegate(string physicalPath)
			{
				string relativePhysicalPath = physicalPath.Substring(modulePhysicalPath.Length);
				return (IgnoredPaths.Any((string p) => relativePhysicalPath.StartsWith("\\" + p + "\\")) || (localIgnoredPaths != null && localIgnoredPaths.Any((string p) => physicalPath.StartsWith(p + "\\")))) ? null : new CompilingFileInfo(VirtualPath + relativePhysicalPath.Replace('\\', '/'), physicalPath);
			})
			where f != null
			select f).ToArray();
	}

	protected virtual Configuration OpenWebConfiguration(IEnumerable<string> compilingDirectories, string compilingDirectory)
	{
		string text = (string.IsNullOrEmpty(RelativePhysicalPath) ? PhysicalPath : Path.Combine(PhysicalPath, RelativePhysicalPath));
		WebConfigurationFileMap webConfigurationFileMap = new WebConfigurationFileMap();
		webConfigurationFileMap.VirtualDirectories.Add("/", new VirtualDirectoryMapping(applicationPhysicalPath, isAppRoot: true));
		foreach (string compilingDirectory2 in compilingDirectories)
		{
			if (!string.IsNullOrEmpty(VirtualPath) || !compilingDirectory2.Equals(PhysicalPath, StringComparison.InvariantCultureIgnoreCase))
			{
				string text2 = compilingDirectory2.Substring(text.Length);
				webConfigurationFileMap.VirtualDirectories.Add("/Module" + text2, new VirtualDirectoryMapping(compilingDirectory2, isAppRoot: false));
			}
		}
		return WebConfigurationManager.OpenMappedWebConfiguration(webConfigurationFileMap, (string.IsNullOrEmpty(VirtualPath) && compilingDirectory.Equals(PhysicalPath, StringComparison.InvariantCultureIgnoreCase)) ? "/Web.config" : ("/Module" + compilingDirectory.Substring(text.Length) + "/Web.config"), "ELMA");
	}

	public virtual void Compile()
	{
		//IL_020d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0214: Expected O, but got Unknown
		console.WriteInfo($"Compiling module {LogCompilingName} ...");
		if (this.BeforeCompile != null)
		{
			this.BeforeCompile(this, EventArgs.Empty);
		}
		List<string> list = new List<string>();
		ICollection<string> compilingDirectories = GetCompilingDirectories();
		List<HttpParseException> list2 = new List<HttpParseException>();
		List<WebCompileDiagnostic> list3 = new List<WebCompileDiagnostic>();
		CompiledSiteInfo compiledSiteInfo = null;
		WebCompileException ex2 = null;
		int length = (string.IsNullOrEmpty(RelativePhysicalPath) ? PhysicalPath : Path.Combine(PhysicalPath, RelativePhysicalPath)).Length;
		WebCompileException ex;
		foreach (string item in compilingDirectories)
		{
			string text = Guid.NewGuid().ToString("n");
			string assemblyUid = baseAssemblyUid + text;
			string text2 = item.Substring(length).Replace('\\', '_');
			if (text2.Length > 0)
			{
				text2 = text2.TrimStart('_') + "_";
			}
			RazorCompiler razorCompiler = new RazorCompiler(compiler, console, baseAssemblyName + text2 + text, defaultNamespace)
			{
				Debug = Debug,
				IgnoreParseError = IgnoreParseError
			};
			razorCompiler.Assemblies.AddRange(ReferencedAssemblies);
			Configuration configuration = OpenWebConfiguration(compilingDirectories, item);
			if (configuration != null)
			{
				foreach (AssemblyInfo item2 in ((CompilationSection)configuration.GetSection("system.web/compilation")).Assemblies.OfType<AssemblyInfo>())
				{
					if (item2.Assembly == null || !(item2.Assembly != "*"))
					{
						continue;
					}
					try
					{
						string text3 = getAssemblyLocation(item2.Assembly);
						if (text3 != null && !razorCompiler.Assemblies.Contains(text3))
						{
							razorCompiler.Assemblies.Add(text3);
						}
					}
					catch
					{
					}
				}
				RazorPagesSection val = (RazorPagesSection)configuration.GetSection("system.web.webPages.razor/pages");
				if (val != null)
				{
					razorCompiler.DefaultBaseClass = val.get_PageBaseType();
					foreach (NamespaceInfo item3 in val.get_Namespaces().OfType<NamespaceInfo>())
					{
						razorCompiler.Namespaces.Add(item3.Namespace);
					}
				}
			}
			CompilingFileInfo[] array = GetCompilingFileInfos(item, list).ToArray();
			list.Add(item);
			try
			{
				if (array.Length != 0)
				{
					assemblyRaws[assemblyUid] = razorCompiler.Compile(array, out var pdbRaw);
					debugRaws[assemblyUid] = pdbRaw;
				}
			}
			catch (WebCompileException ex3)
			{
				ex = ex3;
				if (ex.FilesWithErrors.Count > 0 && RetryCompileWithoutFailedFiles)
				{
					List<CompilingFileInfo> list4 = array.Where((CompilingFileInfo f) => !ex.FilesWithErrors.Contains(f)).ToList();
					if (list4.Count > 0)
					{
						console.WriteDebug($"Recompiling {LogCompilingName} ...");
						assemblyRaws[assemblyUid] = razorCompiler.Compile(list4, out var pdbRaw2);
						debugRaws[assemblyUid] = pdbRaw2;
					}
				}
				else
				{
					ex2 = ex;
					assemblyRaws[assemblyUid] = null;
					debugRaws[assemblyUid] = null;
				}
			}
			finally
			{
				list2.AddRange(razorCompiler.ParseFileExceptions);
				list3.AddRange(razorCompiler.CompilationDiagnostics);
			}
			if (razorCompiler.FileResults.Length != 0)
			{
				(compiledSiteInfo ?? (compiledSiteInfo = new CompiledSiteInfo(string.IsNullOrEmpty(RelativePhysicalPath) ? PhysicalPath : Path.Combine(PhysicalPath, RelativePhysicalPath), console, Debug))).AddFiles(razorCompiler.FileResults.Select(delegate(FileCompileResult r)
				{
					r.Compiled.AssemblyUid = assemblyUid;
					return r.Compiled;
				}));
			}
		}
		SiteInfo = compiledSiteInfo;
		ParseFileExceptions = list2.ToArray();
		CompilationDiagnostics = list3.ToArray();
		if (ex2 != null)
		{
			throw ex2;
		}
	}
}
