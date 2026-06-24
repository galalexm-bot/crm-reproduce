using System;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.FileProvider.Distributed.Services;

public interface IDownloadUrlService
{
	Uri GetDownloadUrl(BinaryFile binaryFile, string password);
}
