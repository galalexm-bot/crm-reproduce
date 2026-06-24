using System;
using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Deploy.Managers;

public interface IExportImportFileManager : IConfigurationService
{
	long GetBufferLength();

	string CreateFolderName(string id);

	string CreateDeployFolderName(string id);

	string CreateZipFileName(string id);

	string CreateFileName(string id);

	string CreateFileName(string id, string name, string ext);

	byte[] LoadFile(string id, long i);

	void DeleteFiles(string id);

	void AddToFile(string id, byte[] buf);

	void AddToNestedFile(string id, string nestedId, string path, byte[] buf);

	void LoadFileToCache(string fileName, string fullFileName, Guid uid);
}
