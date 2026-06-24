using System.IO;
using System.Reflection;

namespace EleWise.ELMA.WebCompiler;

internal class CompiledAssemblyInfo
{
	public string AssemblyName { get; set; }

	public byte[] AssemblyRaw { get; set; }

	public byte[] DebugRaw { get; set; }

	public void Write(string precompiledDirectory, ICompilerConsole console)
	{
		string text = Path.Combine(precompiledDirectory, AssemblyName + ".dll");
		console.WriteDebug($"Write new file {text}");
		File.WriteAllBytes(text, AssemblyRaw);
		if (DebugRaw != null)
		{
			string text2 = Path.ChangeExtension(text, ".pdb");
			console.WriteDebug($"Write file {text2}");
			File.WriteAllBytes(text2, DebugRaw);
		}
	}

	public Assembly Load(AssemblyLoader assemblyLoader, ICompilerConsole console)
	{
		console.WriteInfo($"Loading assembly {AssemblyName}");
		return assemblyLoader(AssemblyRaw, DebugRaw);
	}
}
