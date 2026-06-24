using System.Collections.Generic;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.Services;

internal interface IDmsObjectPermissionUpdateQueueItemRepository
{
	IEnumerable<DmsObjectPermissionUpdateQueueItem> GetItems(int count);

	void ReleaseItems();

	void BulkInsertQueueItems(IDmsObject folder, long user, string patches);

	void UpdateFailedQueueItem(DmsObjectPermissionUpdateQueueItem queueItem);

	void Delete(DmsObjectPermissionUpdateQueueItem queueItem);

	bool TryGetDocumentsCount(long folderId, out long count);
}
