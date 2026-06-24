using System;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.FileProvider.Distributed;

internal interface IDownloadUrlFactory
{
	Uri GetPersistentContentDownloadUrl(SystemFile systemFile, string password);

	Uri GetTempContentDownloadUrl(Uri contentLocation, string contentType, string name);
}
