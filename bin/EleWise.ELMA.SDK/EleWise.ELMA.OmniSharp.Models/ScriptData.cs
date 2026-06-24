using System.Collections.Generic;
using System.Linq;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.OmniSharp.Models;

public class ScriptData : IScriptData
{
	public IEnumerable<IScriptSource> Sources { get; }

	public IEnumerable<IScriptReference> Assemblies { get; }

	public ScriptData(IEnumerable<IScriptSource> sources, IEnumerable<IScriptReference> assemblies = null)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Sources = sources ?? Enumerable.Empty<IScriptSource>();
		Assemblies = assemblies ?? Enumerable.Empty<IScriptReference>();
	}
}
