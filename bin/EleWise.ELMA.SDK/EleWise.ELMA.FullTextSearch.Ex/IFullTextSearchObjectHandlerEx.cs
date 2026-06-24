using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Model;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints;

[ExtensionPoint(ComponentType.All)]
public interface IFullTextSearchObjectHandlerExtension
{
	Guid Uid { get; }

	Type SupportedCard { get; }

	List<Guid> SupportedUids { get; }

	List<string> GetImportantProperties { get; }

	List<string> GetVisualDataProperties { get; }

	List<QueueToIndex> ProcessingMergedIndexQueue(List<KeyValuePair<string, object>> mergedIndexQueueItem, long id, Guid typeUid);

	void OnInsertProcessing(Guid typeUid, object obj);

	void OnDeleteProcessing(Guid typeUid, object obj);
}
