using System;
using System.Collections.Generic;
using EleWise.ELMA.History.Models;

namespace EleWise.ELMA.History.Services;

internal interface IHistoryUpdateQueueItemRepository
{
	IEnumerable<HistoryUpdateQueueItem> GetItems(int count);

	void ReleaseItems();

	void BulkInsertQueueItems(IEnumerable<InverseRelatedEntityModel> objects, bool forDelete);

	void InsertQueueItem(long objectId, Guid objectTypeUid, bool forDelete);

	void UpdateQueueItem(HistoryUpdateQueueItem queueItem);

	void DeleteQueueItem(HistoryUpdateQueueItem queueItem);

	bool HisotoryObjectUpdateInQueue(long objectId, Guid objectTypeUid);

	void DeleteQueueItemsByObjectTypeUid(Guid objectTypeUid);

	void DeleteQueueItemsByObjectTypeUids(IEnumerable<Guid> objectTypeUids);
}
