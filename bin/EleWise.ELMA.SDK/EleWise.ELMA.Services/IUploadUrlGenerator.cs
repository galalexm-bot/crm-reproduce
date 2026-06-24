using System;

namespace EleWise.ELMA.Services;

public interface IUploadUrlGenerator
{
	Uri GetClosestBaseUploadUrl();
}
