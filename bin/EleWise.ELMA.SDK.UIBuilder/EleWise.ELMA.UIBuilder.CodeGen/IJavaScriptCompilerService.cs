using System;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;

public interface IJavaScriptCompilerService : IJavaScriptCompilerServiceBase
{
	JavaScriptCodeCompilerResult Compile(IJavaScriptCompilerModel bridgeCompilerModel, bool withoutJsOutput, Action beforeBuildAction);
}
