using EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;

namespace EleWise.ELMA.BridgeCompiler.Models;

internal class ReplaceModel : IJavaScriptReplaceModel
{
	public string ModuleName { get; }

	public string ReplaceName { get; }

	public string[] ToReplaceArguments { get; }

	public ReplaceModelOptions Options { get; }

	public string ReplaceFullName { get; }

	public string ReplaceInterfaceName { get; }

	public string ReplaceInterfaceFullName { get; }

	public ReplaceModel(string moduleName, string replaceName, string[] toReplaceArguments)
		: this(moduleName, replaceName, toReplaceArguments, new ReplaceModelOptions
		{
			Contract = true,
			Value = false
		})
	{
	}

	public ReplaceModel(string moduleName, string replaceName, string[] toReplaceArguments, ReplaceModelOptions options)
	{
		ModuleName = moduleName;
		ReplaceName = replaceName;
		ToReplaceArguments = toReplaceArguments;
		Options = options;
		ReplaceFullName = (string.IsNullOrWhiteSpace(moduleName) ? replaceName : (moduleName + "." + replaceName));
		ReplaceInterfaceName = ReplaceName.Replace('.', '$');
		ReplaceInterfaceFullName = ReplaceFullName.Replace('.', '$');
	}
}
