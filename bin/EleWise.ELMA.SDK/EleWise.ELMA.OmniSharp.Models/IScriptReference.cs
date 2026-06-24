namespace EleWise.ELMA.OmniSharp.Models;

public interface IScriptReference
{
	string Name { get; }

	string HintPath { get; }

	byte[] AssemblyRaw { get; }

	byte[] DocumentationRaw { get; }
}
