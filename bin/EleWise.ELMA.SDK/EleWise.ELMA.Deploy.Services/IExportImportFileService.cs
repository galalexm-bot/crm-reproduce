using System;
using EleWise.ELMA.Files;

namespace EleWise.ELMA.Deploy.Services;

public interface IExportImportFileService
{
	string GetFilesFolderName();

	string GetFilesFolderPath();

	long GetBufferLength();

	string CreateFileName(string id, string name, string ext);

	string CreateFileName(string id, string folder, string name, string ext);

	string CreateZipFileName(string id);

	string CreateZipFileName(string id, string ext);

	string CreateFolderName(string id);

	string CreateDeployFolderName(string id);

	string CreateDeployFolderName(string id, string folder);

	void AddToFile(string id, BinaryFile file);

	void AddToFile(string id, byte[] buf);

	void AddToNestedFile(string id, string nestedId, string path, byte[] buf);

	void AddToNestedFile(string id, string nestedId, string fileExtension, string path, byte[] buf);

	byte[] LoadFile(string id, long i);

	byte[] LoadFile(string id, long i, string ext);

	void DeleteFiles(string id);

	void DeleteFiles(string id, string ext);

	void LoadFileToCache(string fileName, string fullFileName, Guid uid);

	bool Exists(string id, string ext);

	bool Exists(string id);
}
