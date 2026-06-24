using System;
using System.Collections.Generic;
using System.IO;
using EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;

namespace EleWise.ELMA.BridgeCompiler.Models;

internal sealed class BridgeAssemblyModel : IJavaScriptAssemblyModel
{
	private readonly HashSet<string> sourceCodes;

	private readonly HashSet<string> references;

	private readonly List<IJavaScriptReplaceModel> replaceModels;

	public string AssemblyName { get; }

	public string FolderPath { get; }

	public string AssemblyFolderPath { get; }

	public IEnumerable<string> SourceCodes => sourceCodes;

	public IEnumerable<string> References => references;

	public string PluginsPath { get; private set; }

	public IEnumerable<IJavaScriptReplaceModel> ReplaceModels => replaceModels;

	public BridgeAssemblyModel(string assemblyName, string folderPath)
	{
		AssemblyName = assemblyName;
		FolderPath = folderPath;
		references = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
		sourceCodes = new HashSet<string>(StringComparer.InvariantCultureIgnoreCase);
		replaceModels = new List<IJavaScriptReplaceModel>();
	}

	public BridgeAssemblyModel(string assemblyName, string folderPath, string assemblyFolderPath)
		: this(assemblyName, folderPath)
	{
		AssemblyFolderPath = (string.IsNullOrWhiteSpace(assemblyFolderPath) ? Path.Combine(FolderPath, "bin") : assemblyFolderPath);
	}

	public void AddReplaceModel(string moduleName, string replaceName, string[] toReplaceArguments, ReplaceModelOptions options)
	{
		if (!string.IsNullOrWhiteSpace(replaceName) && toReplaceArguments.Length != 0 && replaceModels.Find((IJavaScriptReplaceModel a) => a.ReplaceName == replaceName && a.ModuleName == moduleName) == null)
		{
			replaceModels.Add(new ReplaceModel(moduleName, replaceName, toReplaceArguments, options));
		}
	}

	public void AddPluginsPath(string pluginsPath)
	{
		if (!string.IsNullOrWhiteSpace(pluginsPath))
		{
			PluginsPath = pluginsPath;
		}
	}

	public void AddReferencePath(string referencePath)
	{
		if (File.Exists(referencePath))
		{
			references.Add(referencePath);
		}
	}

	public void AddSourceCodeFile(string filePath)
	{
		sourceCodes.Add(filePath);
	}
}
