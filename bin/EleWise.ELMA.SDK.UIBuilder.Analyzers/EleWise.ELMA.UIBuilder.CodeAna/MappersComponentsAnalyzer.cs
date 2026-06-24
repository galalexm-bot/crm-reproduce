using System.Collections.Generic;
using EleWise.ELMA.Model.CodeGeneration.Analyzers;
using Microsoft.CodeAnalysis.Diagnostics;

namespace EleWise.ELMA.UIBuilder.CodeAnalyzers;

[DiagnosticAnalyzer("C#", new string[] { })]
internal sealed class MappersComponentsAnalyzer : ComponentsAnalyzer
{
	protected override IEnumerable<string> GetIgnoredTypes()
	{
		return new string[1] { "EleWise.ELMA.Model.AutoMaps.SimpleMap`2" };
	}
}
