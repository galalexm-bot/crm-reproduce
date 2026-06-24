using System.Collections.Generic;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;

public interface IJavaScriptAssemblyModel
{
	string AssemblyName { get; }

	string FolderPath { get; }

	string AssemblyFolderPath { get; }

	IEnumerable<string> SourceCodes { get; }

	IEnumerable<string> References { get; }

	IEnumerable<IJavaScriptReplaceModel> ReplaceModels { get; }

	void AddReplaceModel(string moduleName, string replaceName, string[] toReplaceArguments, ReplaceModelOptions options);

	void AddSourceCodeFile(string filePath);

	void AddReferencePath(string referencePath);
}
