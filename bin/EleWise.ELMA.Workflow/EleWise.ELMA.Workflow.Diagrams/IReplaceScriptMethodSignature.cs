using System.Collections.Generic;

namespace EleWise.ELMA.Workflow.Diagrams.Elements;

public interface IReplaceScriptMethodSignature
{
	void ReplaceSignature(Dictionary<string, string> replaceNames);
}
