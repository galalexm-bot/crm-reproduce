using System.Collections.Generic;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;

public interface IJavaScriptCompilerModel
{
	string ProjectName { get; }

	string Version { get; }

	IDictionary<string, string> SourceCodes { get; }

	IDictionary<string, string> JsSourceCodes { get; }

	IList<byte[]> References { get; }

	IList<DiagnosticAnalyzer> DiagnosticAnalyzers { get; }

	IList<IReplaceModelMetadata> ReplaceModelMetadata { get; }

	bool ScriptApiCheck { get; }

	void AddSourceCodeFromPath(string path);

	void AddSourceCode(string sourceCode);

	void AddSourceCode(string fileName, string sourceCode);

	void AddReference(byte[] assemblyRaw);

	void AddAnalyzers(params DiagnosticAnalyzer[] analyzers);

	void AddJsSourceCode(string sourceCode);

	string GetSourceCodeHash();
}
