using System;

namespace EleWise.ELMA.Packaging;

internal interface IBuildToolInstance
{
	Version Version { get; }

	string VisualStudioRootPath { get; }

	string Name { get; }

	string MSBuildPath { get; }
}
