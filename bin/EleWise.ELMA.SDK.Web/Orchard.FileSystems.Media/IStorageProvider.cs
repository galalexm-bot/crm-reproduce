using System.Collections.Generic;
using System.IO;

namespace Orchard.FileSystems.Media;

public interface IStorageProvider : IDependency
{
	bool FileExists(string path);

	string GetPublicUrl(string path);

	string GetStoragePath(string url);

	IStorageFile GetFile(string path);

	IEnumerable<IStorageFile> ListFiles(string path);

	bool FolderExists(string path);

	IEnumerable<IStorageFolder> ListFolders(string path);

	bool TryCreateFolder(string path);

	void CreateFolder(string path);

	void DeleteFolder(string path);

	void RenameFolder(string oldPath, string newPath);

	void DeleteFile(string path);

	void RenameFile(string oldPath, string newPath);

	void CopyFile(string originalPath, string duplicatePath);

	IStorageFile CreateFile(string path);

	bool TrySaveStream(string path, Stream inputStream);

	void SaveStream(string path, Stream inputStream);

	string Combine(string path1, string path2);
}
