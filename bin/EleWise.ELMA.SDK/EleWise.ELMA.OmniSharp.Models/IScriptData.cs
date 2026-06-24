using System.Collections.Generic;

namespace EleWise.ELMA.OmniSharp.Models;

public interface IScriptData
{
	IEnumerable<IScriptSource> Sources { get; }

	IEnumerable<IScriptReference> Assemblies { get; }
}
