using System.Collections.Generic;
using System.Xml;

namespace EleWise.ELMA.Packaging;

internal interface ISolutionParser
{
	void Init(IBuildToolInstance instance = null, bool force = false);

	IEnumerable<IBuildToolInstance> QueryBuildToolsInstances();

	IParsedSolution Parse(string solutionFileName);

	IParsedProject ParseProject(string csprojPath);

	IParsedProject ParseProject(XmlReader xmlReader);
}
