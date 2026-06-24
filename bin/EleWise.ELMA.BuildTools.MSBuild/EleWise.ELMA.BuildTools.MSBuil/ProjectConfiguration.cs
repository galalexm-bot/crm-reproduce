using EleWise.ELMA.Packaging;

namespace EleWise.ELMA.BuildTools.MSBuild;

internal class ProjectConfiguration : IProjectConfiguration
{
	public string ConfigurationName { get; set; }

	public string PlatformName { get; set; }

	public string FullName { get; set; }

	public bool IncludeInBuild { get; set; }
}
