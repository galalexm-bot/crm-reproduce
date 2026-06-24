using System.Collections.Generic;

namespace EleWise.ELMA.WebCompiler;

public class CompilingModuleInfo
{
	private string physicalPath;

	public string PhysicalPath
	{
		get
		{
			return physicalPath;
		}
		set
		{
			physicalPath = value?.Replace('/', '\\').TrimEnd('\\');
		}
	}

	public string VirtualPath { get; set; }

	public string RelativePhysicalPath { get; set; }

	public List<string> IgnoredPaths { get; private set; }

	public CompilingModuleInfo()
	{
		IgnoredPaths = new List<string>();
	}
}
