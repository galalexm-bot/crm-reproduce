using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web.Configuration;

namespace EleWise.ELMA.WebCompiler;

internal class SingleFileCompiler : WebModuleCompiler
{
	private readonly List<CompilingModuleInfo> additionalModules;

	private readonly CompilingFileInfo fileInfo;

	public CompiledFileInfo FileInfo { get; private set; }

	public string AssemblyUid => base.AssemblyUids.FirstOrDefault();

	public byte[] AssemblyRaw => GetAssemblyRaw(AssemblyUid);

	public byte[] DebugRaw => GetDebugRaw(AssemblyUid);

	protected internal override string LogCompilingName => base.VirtualPath;

	public override bool Debug
	{
		get
		{
			if (base.Debug)
			{
				return fileInfo.PhysicalPath != null;
			}
			return false;
		}
		set
		{
			base.Debug = value;
		}
	}

	public SingleFileCompiler(string applicationPhysicalPath, string configurationPhysicalPath, CompilingFileInfo fileInfo, string defaultNamespace, string baseAssemblyName, List<CompilingModuleInfo> additionalModules, ICompiler compiler, ICompilerConsole console, Func<string, string> getAssemblyLocation)
		: base(applicationPhysicalPath, configurationPhysicalPath, fileInfo.VirtualPath, defaultNamespace, baseAssemblyName, compiler, console, getAssemblyLocation)
	{
		this.fileInfo = fileInfo;
		this.additionalModules = additionalModules;
	}

	protected override ICollection<string> GetCompilingDirectories()
	{
		return new string[1] { base.PhysicalPath };
	}

	internal override ICollection<CompilingFileInfo> GetCompilingFileInfos(string compilingDirectory = null, ICollection<string> localIgnoredPaths = null)
	{
		return new CompilingFileInfo[1] { fileInfo };
	}

	protected override Configuration OpenWebConfiguration(IEnumerable<string> compilingDirectories, string compilingDirectory)
	{
		WebConfigurationFileMap webConfigurationFileMap = new WebConfigurationFileMap();
		string text = applicationPhysicalPath;
		string text2 = base.PhysicalPath;
		string text3 = "/Config";
		webConfigurationFileMap.VirtualDirectories.Add("/", new VirtualDirectoryMapping(text, isAppRoot: true));
		webConfigurationFileMap.VirtualDirectories.Add(text3, new VirtualDirectoryMapping(text2, isAppRoot: false));
		string[] array = base.VirtualPath.Remove(base.VirtualPath.LastIndexOf("/")).TrimStart('~', '/').Split('/');
		foreach (string text4 in array)
		{
			text = text + "\\" + text4;
			text3 = text3 + "/" + text4;
			foreach (CompilingModuleInfo additionalModule in additionalModules)
			{
				if (text3.Equals(additionalModule.VirtualPath, StringComparison.OrdinalIgnoreCase))
				{
					text = (string.IsNullOrEmpty(additionalModule.RelativePhysicalPath) ? additionalModule.PhysicalPath : Path.Combine(additionalModule.PhysicalPath, additionalModule.RelativePhysicalPath));
					break;
				}
			}
			webConfigurationFileMap.VirtualDirectories.Add(text3, new VirtualDirectoryMapping(text, isAppRoot: false));
			text2 = text2 + "\\" + text4;
			text3 += "/Config";
			webConfigurationFileMap.VirtualDirectories.Add(text3, new VirtualDirectoryMapping(text2, isAppRoot: false));
		}
		return WebConfigurationManager.OpenMappedWebConfiguration(webConfigurationFileMap, text3 + "/Web.config", "ELMA");
	}

	public override void Compile()
	{
		try
		{
			base.Compile();
		}
		finally
		{
			if (base.SiteInfo != null)
			{
				FileInfo = base.SiteInfo.Files[0];
				FileInfo.AssemblyUid = AssemblyUid;
			}
			else
			{
				FileInfo = null;
			}
		}
	}
}
