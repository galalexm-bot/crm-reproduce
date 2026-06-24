namespace EleWise.ELMA.Packaging;

internal interface IProjectConfiguration
{
	string ConfigurationName { get; }

	string PlatformName { get; }

	string FullName { get; }

	bool IncludeInBuild { get; }
}
