using EleWise.ELMA.CodeAnalyzers;
using Microsoft.CodeAnalysis;

namespace EleWise.ELMA.UIBuilder.CodeAnalyzers;

public sealed class ClientEntityUsageAnalyzer : EntityUsageAnalyzer
{
	protected override bool CheckModule(IModuleSymbol module)
	{
		if (module == null)
		{
			return false;
		}
		return ((ISymbol)module).get_Name() == "DynamicUIModel.dll";
	}
}
