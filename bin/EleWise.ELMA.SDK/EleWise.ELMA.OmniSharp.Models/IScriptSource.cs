namespace EleWise.ELMA.OmniSharp.Models;

public interface IScriptSource
{
	string Name { get; }

	string Content { get; }

	ScriptSourceType Type { get; }
}
