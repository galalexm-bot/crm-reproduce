using EleWise.ELMA.Model.CodeGeneration.PublicApi;

namespace EleWise.ELMA.Common.DynamicAPI;

internal class PublicApiCommonRootNode : PublicApiStaticPropertyClassRootNode
{
	public new const string Path = "PublicAPI.Common";

	public PublicApiCommonRootNode()
		: base("CommonApiRoot", "Common")
	{
	}
}
