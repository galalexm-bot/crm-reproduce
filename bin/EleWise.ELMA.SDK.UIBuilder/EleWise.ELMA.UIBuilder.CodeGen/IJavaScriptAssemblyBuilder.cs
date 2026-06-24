namespace EleWise.ELMA.UIBuilder.CodeGeneration.JavaScript;

public interface IJavaScriptAssemblyBuilder
{
	string Errors { get; }

	byte[] AssemblyRaw { get; }

	byte[] MinAssemblyRaw { get; }

	IJavaScriptAssemblyModel CreateModel(string assemblyName, string folderPath, string assemblyFolderPath);

	bool Build(IJavaScriptAssemblyModel bridgeAssemblyModel, JavaScriptGeneratorConfiguration configuration);
}
