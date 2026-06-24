namespace EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;

public interface IJavaScriptReplaceModel
{
	string ModuleName { get; }

	string ReplaceName { get; }

	string[] ToReplaceArguments { get; }

	ReplaceModelOptions Options { get; }
}
