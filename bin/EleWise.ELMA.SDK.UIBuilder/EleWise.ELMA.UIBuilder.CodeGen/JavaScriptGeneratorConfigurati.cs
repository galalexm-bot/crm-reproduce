using System.Collections.Generic;

namespace EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;

public sealed class JavaScriptGeneratorConfiguration
{
	public bool Minify { get; set; }

	public bool GenerateSourceMap { get; set; }

	public IEnumerable<string> JsSourceCode { get; set; }
}
