using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Workflow.Diagrams.Elements;

public interface IReplaceContextVar
{
	void ReplaceContextVar(Dictionary<Guid, Guid> ReplaceContextVar);
}
