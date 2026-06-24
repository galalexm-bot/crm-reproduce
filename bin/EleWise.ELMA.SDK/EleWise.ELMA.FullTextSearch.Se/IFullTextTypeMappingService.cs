using System;
using System.Collections.Generic;
using EleWise.ELMA.FullTextSearch.Model;

namespace EleWise.ELMA.FullTextSearch.Services;

public interface IFullTextTypeMappingService
{
	void CreateMapping();

	Dictionary<Guid, List<string>> GetImportantProperties(Guid objectTypeUid);

	Dictionary<Guid, List<string>> GetVisualDataProperties(Guid objectTypeUid);

	Dictionary<Guid, List<string>> GetImportantDynamicProperties(Guid objectTypeUid);

	List<KeyValuePair<string, object>> OnInsertProcessing(Guid objectTypeUid, object obj);

	List<KeyValuePair<string, object>> OnDeleteProcessing(Guid objectTypeUid, object obj);

	bool IsSupported(Guid objectTypeUid);

	List<QueueToIndex> GetQueueToIndex(List<KeyValuePair<string, object>> item, long id, Guid objectTypeUid);
}
