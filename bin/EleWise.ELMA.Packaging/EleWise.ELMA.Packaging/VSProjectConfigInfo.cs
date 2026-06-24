using System;

namespace EleWise.ELMA.Packaging;

public class VSProjectConfigInfo
{
	public bool IncludeInBuild { get; private set; }

	public string ConfigurationName { get; private set; }

	public string FullName { get; private set; }

	public string PlatformName { get; private set; }

	[Obsolete("Класс устарел", true)]
	public VSProjectConfigInfo(object configInfo)
	{
	}
}
