using System;
using System.Collections.Generic;
using System.IO;

namespace EleWise.ELMA.Packaging.Components;

public interface IElmaFolder
{
	bool IsSupported(string path);

	void AddFile(string path, Stream stream);

	void AddFile(string path, Stream stream, DateTime? creationTime, DateTime? lastWriteTime);

	void DeleteDirectory(string path, bool recursive);

	void DeleteFile(string path);

	bool DirectoryExists(string path);

	bool FileExists(string path);

	DateTimeOffset GetCreated(string path);

	IEnumerable<string> GetDirectories(string path);

	IEnumerable<string> GetFiles(string path, string filter, bool recursive);

	string GetFullPath(string path);

	DateTimeOffset GetLastAccessed(string path);

	DateTimeOffset GetLastModified(string path);

	Stream OpenFile(string path);

	void AddFile(string path, Action<Stream> writeToStream);

	Stream CreateFile(string path);
}
