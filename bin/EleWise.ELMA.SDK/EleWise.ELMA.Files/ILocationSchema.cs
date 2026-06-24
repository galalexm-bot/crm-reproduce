using System;

namespace EleWise.ELMA.Files;

public interface ILocationSchema
{
	Uri MapPersistentLocation(SystemFile systemFile);

	Uri MapTempLocation(string uid, string extension);

	Uri CreateNewTempLocation(string extension = null);

	Uri RemapTempLocationFor(Uri location);

	Uri MapPreviewLocation(string uid, string contentPath);
}
