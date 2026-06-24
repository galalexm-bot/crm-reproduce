using System;
using System.IO;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface IZipStreamService
{
	Exception CreateZipFolder(Stream zipStream, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter);

	Exception CreateZipFolder(Stream zipStream, string sourceDirectory, bool recurse);

	Exception CreateZipFolder(Stream zipStream, string sourceDirectory);

	Exception ExtractZipFolder(Stream zipStream, string targetDirectory, string fileFilter);

	Exception ExtractZipFolder(Stream zipStream, string targetDirectory);
}
