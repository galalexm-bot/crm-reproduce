using System;

namespace EleWise.ELMA.Services;

public interface IUploadedContentLocationMapperService
{
	Uri GetUploadedContentLocation(string gatewayId, string id);
}
