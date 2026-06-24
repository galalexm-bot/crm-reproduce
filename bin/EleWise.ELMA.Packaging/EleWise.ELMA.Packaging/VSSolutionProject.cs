using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Packaging;

public class VSSolutionProject
{
	public string ProjectName { get; private set; }

	public string RelativePath { get; private set; }

	public string ProjectGuid { get; private set; }

	public Dictionary<string, VSProjectConfigInfo> Configs { get; private set; }

	[Obsolete("Класс устарел", true)]
	public VSSolutionProject(object solutionProject)
	{
	}
}
