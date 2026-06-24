using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.UIBuilder.Model;

internal sealed class PublishedModule
{
	public ModuleInfoMetadata Metadata { get; }

	public ServerBuildResult ServerBuildResult { get; }

	public ClientBuildResult ClientBuildResult { get; }

	public PublishedModule(ModuleInfoMetadata metadata, ServerBuildResult serverBuildResult, ClientBuildResult clientBuildResult)
	{
		Metadata = metadata;
		ServerBuildResult = serverBuildResult;
		ClientBuildResult = clientBuildResult;
	}
}
