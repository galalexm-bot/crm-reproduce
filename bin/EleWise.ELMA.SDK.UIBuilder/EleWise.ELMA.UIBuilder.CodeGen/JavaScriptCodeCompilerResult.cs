namespace EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;

public sealed class JavaScriptCodeCompilerResult
{
	public byte[] AssemblyRaw { get; set; }

	public byte[] DocumentationRaw { get; set; }

	public byte[] JsAssemblyRaw { get; set; }

	public byte[] MinJsAssemblyRaw { get; set; }
}
