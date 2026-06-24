using System;

namespace EleWise.ELMA.FileProvider.Distributed;

internal interface IUploadUrlFactory
{
	Uri GetClosestUploadBaseUrl();
}
