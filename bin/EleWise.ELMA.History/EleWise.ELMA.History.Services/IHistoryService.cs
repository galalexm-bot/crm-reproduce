using System;
using System.Collections.Generic;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.History.Services;

internal interface IHistoryService
{
	EntityHistoryModel GetHistoryModel(long objectId, Guid objectTypeUid, bool? orderDesc, long? firstResult = null, int? maxResults = null, long? lastActionDate = null, int? packageIndex = null);

	void UpdateTables(long objectId, Guid objectTypeUid, IEntity entity);

	void CacheObjectHistory(long objectId, Guid objectTypeUid, long? lastActionDate);

	void DeleteRecord(long objectId, Guid objectTypeUid);

	IEnumerable<InverseRelatedEntityModel> DeleteRecordsByType(Guid objectTypeUid);
}
