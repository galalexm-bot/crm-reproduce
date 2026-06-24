using System.Collections.Generic;

namespace EleWise.ELMA.Packaging;

internal interface IParsedSolution
{
	IEnumerable<IParsedProject> Projects { get; }

	string SlnPath { get; }
}
