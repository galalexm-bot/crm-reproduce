using System;
using System.IO;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Services;

[DeveloperApi(DeveloperApiType.Service)]
public interface ICacheFilesService
{
	bool DeleteByUid(Guid uid);

	Guid CreateCacheFile(string fileName);

	bool CreateCacheFileByUid(Guid uid, string fileName);

	bool IncrementCacheFile(Guid uid, Stream inputStream, long startPos = 0L, long endPos = long.MaxValue);

	bool IncrementCacheFile(Guid uid, byte[] buf, long startPos = 0L, long endPos = long.MaxValue);

	bool AppendCacheFile(Guid uid, byte[] buf, int cnt);

	bool AppendCacheFile(Guid uid, Stream inputStream);

	string GetFileName(Guid uid);

	string GetFilePath(Guid uid);

	long GetFileLength(Guid uid);
}
