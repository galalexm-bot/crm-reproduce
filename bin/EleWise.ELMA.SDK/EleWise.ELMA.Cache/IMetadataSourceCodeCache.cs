using System;
using EleWise.ELMA.Scripts.Models;

namespace EleWise.ELMA.Cache;

public interface IMetadataSourceCodeCache
{
	string GetFolderPath(CodeType codeType);

	bool IsGlobalCacheExists();

	void InvalidateCache(Guid metadataItemHeaderUid);

	void UpdateDiskCache();
}
