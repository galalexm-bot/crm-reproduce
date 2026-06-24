using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using EleWise.ELMA.Memory;
using EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EleWise.ELMA.UIBuilder.Model;

internal sealed class BridgeCompilerModel : IJavaScriptCompilerModel
{
	private readonly string sourceFileName;

	public string ProjectName { get; }

	public string Version { get; }

	public IDictionary<string, string> SourceCodes { get; }

	public IDictionary<string, string> JsSourceCodes { get; }

	public IList<byte[]> References { get; }

	public IList<DiagnosticAnalyzer> DiagnosticAnalyzers { get; }

	public IList<IReplaceModelMetadata> ReplaceModelMetadata { get; }

	public bool ScriptApiCheck { get; private set; }

	public BridgeCompilerModel(string projectName, bool scriptApiCheck)
	{
		Contract.ArgumentNotNullOrEmpty(projectName, "projectName");
		ProjectName = projectName;
		ScriptApiCheck = scriptApiCheck;
		sourceFileName = projectName + "_Script";
		SourceCodes = new Dictionary<string, string>();
		JsSourceCodes = new Dictionary<string, string>();
		References = new List<byte[]>();
		ReplaceModelMetadata = new List<IReplaceModelMetadata>();
		DiagnosticAnalyzers = new List<DiagnosticAnalyzer>();
	}

	public BridgeCompilerModel(string projectName, bool scriptApiCheck, string version)
		: this(projectName, scriptApiCheck)
	{
		Version = version;
		sourceFileName = projectName + "_Version_" + version + "_Script_";
	}

	public void AddSourceCodeFromPath(string path)
	{
		if (File.Exists(path))
		{
			AddSourceCode(File.ReadAllText(path, Encoding.UTF8));
		}
	}

	public void AddSourceCode(string sourceCode)
	{
		AddSourceCode(null, sourceCode);
	}

	public void AddSourceCode(string fileName, string sourceCode)
	{
		if (!string.IsNullOrWhiteSpace(sourceCode))
		{
			string text = (string.IsNullOrWhiteSpace(fileName) ? sourceFileName : fileName);
			if (SourceCodes.ContainsKey(text))
			{
				text += $"_{SourceCodes.Count}";
			}
			SourceCodes.Add(text, sourceCode);
		}
	}

	public void AddJsSourceCode(string sourceCode)
	{
		if (!string.IsNullOrWhiteSpace(sourceCode))
		{
			string text = sourceFileName;
			if (JsSourceCodes.ContainsKey(text))
			{
				text += $"_{SourceCodes.Count}";
			}
			string value = "window.__define = window.define;window.__require = window.require;window.define = undefined;window.require = undefined;" + sourceCode + "window.define = window.__define;window.require = window.__require;window.__define = undefined;window.__require = undefined;";
			JsSourceCodes.Add(text, value);
		}
	}

	public string GetSourceCodeHash()
	{
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		using StreamWriter streamWriter = new StreamWriter(memoryStream);
		streamWriter.Write(SourceCodes.Count + "|");
		streamWriter.Write(SourceCodes.Values.Sum((string s) => s.Length) + "|");
		foreach (string value in SourceCodes.Values)
		{
			streamWriter.WriteLine(value);
		}
		streamWriter.Flush();
		memoryStream.Seek(0L, SeekOrigin.Begin);
		using SHA1 sHA = SHA1.Create();
		return Convert.ToBase64String(sHA.ComputeHash(memoryStream));
	}

	public void AddReference(byte[] assemblyRaw)
	{
		Contract.ArgumentNotNull(assemblyRaw, "assemblyRaw");
		if (!References.Contains(assemblyRaw))
		{
			References.Add(assemblyRaw);
		}
	}

	public void AddAnalyzers(params DiagnosticAnalyzer[] analyzers)
	{
		foreach (DiagnosticAnalyzer item in analyzers)
		{
			DiagnosticAnalyzers.Add(item);
		}
	}

	public IJavaScriptCompilerModel WithScriptApiCheck()
	{
		ScriptApiCheck = true;
		return this;
	}
}
