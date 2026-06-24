using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BridgeCompiler.Models;
using EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;

namespace EleWise.ELMA.BridgeCompiler.JavaScriptParser.Models;

internal sealed class MetadataModel
{
	internal List<ReplaceModel> ReplaceModels { get; }

	internal string[] IgnoreModules { get; }

	public MetadataModel(IEnumerable<IJavaScriptReplaceModel> replaceModels)
	{
		ReplaceModels = ((replaceModels != null) ? replaceModels.Cast<ReplaceModel>().ToList() : new List<ReplaceModel>());
		IgnoreModules = new string[4] { "EleWise_ELMA_Core", "Reactive", "EleWise_ELMA_TestFramework", "EleWise_ELMA_Core_React" };
	}
}
