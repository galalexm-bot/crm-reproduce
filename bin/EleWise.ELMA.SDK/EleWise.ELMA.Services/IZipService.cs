using System;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface IZipService
{
	Exception CreateZipFolder(string zipFileName, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter);

	Exception CreateZipFolder(string zipFileName, string sourceDirectory, bool recurse);

	Exception CreateZipFolder(string zipFileName, string sourceDirectory);

	Exception ExtractZipFolder(string zipFileName, string targetDirectory, string fileFilter);

	Exception ExtractZipFolder(string zipFileName, string targetDirectory);
}
