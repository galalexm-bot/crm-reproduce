using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.Model;

public sealed class ModuleBuildResult
{
	public ServerBuildResult ServerBuildResult { get; set; }

	public ClientBuildResult ClientBuildResult { get; set; }
}
