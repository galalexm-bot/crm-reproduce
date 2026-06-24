using System;
using System.Collections.Generic;
using System.IO;
using Orchard.Caching;

namespace Orchard.FileSystems.AppData;

public interface IAppDataFolder : IVolatileProvider, ISingletonDependency, IDependency
{
	IEnumerable<string> ListFiles(string path);

	IEnumerable<string> ListDirectories(string path);

	string Combine(params string[] paths);

	bool FileExists(string path);

	void CreateFile(string path, string content);

	Stream CreateFile(string path);

	string ReadFile(string path);

	Stream OpenFile(string path);

	void StoreFile(string sourceFileName, string destinationPath);

	void DeleteFile(string path);

	DateTime GetFileLastWriteTimeUtc(string path);

	void CreateDirectory(string path);

	bool DirectoryExists(string path);

	IVolatileToken WhenPathChanges(string path);

	string MapPath(string path);

	string GetVirtualPath(string path);
}
