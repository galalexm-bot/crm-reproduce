using System.ServiceModel.Channels;

namespace EleWise.ELMA.Web.Service;

public sealed class WebContentRawMapper : WebContentTypeMapper
{
	public override WebContentFormat GetMessageFormatForContentType(string contentType)
	{
		return WebContentFormat.Raw;
	}
}
