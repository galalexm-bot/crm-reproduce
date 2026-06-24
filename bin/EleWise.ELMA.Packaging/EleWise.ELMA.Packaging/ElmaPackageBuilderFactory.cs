using System.Collections.Generic;
using System.ComponentModel.Composition;
using EleWise.ELMA.Packaging.Logging;
using NuGet;

namespace EleWise.ELMA.Packaging;

[Export(typeof(ElmaPackageBuilderFactory))]
public class ElmaPackageBuilderFactory
{
	[Import]
	public ILogger NuGetLogger { get; set; }

	[Import]
	internal ISolutionParser SolutionParser { get; set; }

	public virtual ElmaPackageBuilder Create()
	{
		IEnumerable<IBuildToolInstance> enumerable = SolutionParser.QueryBuildToolsInstances();
		Logger.Log.Debug("Discovered MSBuild instances:");
		foreach (IBuildToolInstance item in enumerable)
		{
			Logger.Log.DebugFormat("name={0}", item.Name);
			Logger.Log.DebugFormat("version={0}", item.Version);
			Logger.Log.DebugFormat("msbuild-path={0}", item.MSBuildPath);
			Logger.Log.DebugFormat("vs-path={0}", item.VisualStudioRootPath);
			Logger.Log.Debug("---");
		}
		SolutionParser.Init();
		return new ElmaPackageBuilder(SolutionParser);
	}
}
