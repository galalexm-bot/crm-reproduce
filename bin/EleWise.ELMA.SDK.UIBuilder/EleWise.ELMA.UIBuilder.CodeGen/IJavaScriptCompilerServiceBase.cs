namespace EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;

public interface IJavaScriptCompilerServiceBase
{
	IJavaScriptCompilerModel CreateCompilerModel(string projectName, bool scriptApiCheck);

	IJavaScriptCompilerModel CreateCompilerModel(string projectName, bool scriptApiCheck, string version);

	JavaScriptCodeCompilerResult Compile(IJavaScriptCompilerModel bridgeCompilerModel);

	JavaScriptCodeCompilerResult Compile(IJavaScriptCompilerModel bridgeCompilerModel, bool withoutJsOutput);
}
