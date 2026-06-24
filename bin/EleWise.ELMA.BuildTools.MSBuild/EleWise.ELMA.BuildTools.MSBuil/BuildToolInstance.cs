using System;
using EleWise.ELMA.Packaging;

namespace EleWise.ELMA.BuildTools.MSBuild;

internal class BuildToolInstance : IBuildToolInstance
{
	public Version Version { get; set; }

	public string VisualStudioRootPath { get; set; }

	public string Name { get; set; }

	public string MSBuildPath { get; set; }
}
