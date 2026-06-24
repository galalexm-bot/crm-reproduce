using EleWise.ELMA.Content.Models;

namespace EleWise.ELMA.Content.Transformation;

internal sealed class PageV2TransformationContainer : IPageTransformationContainer
{
	public IPortalObject Page { get; set; }

	public string Parameters { get; set; }
}
