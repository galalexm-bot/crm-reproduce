using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Packaging;

[Obsolete("Класс устарел", true)]
public class VSSolutionParser
{
	public List<VSSolutionProject> Projects { get; private set; }

	[Obsolete("Класс устарел", true)]
	public void Parse(string solutionFileName)
	{
	}
}
