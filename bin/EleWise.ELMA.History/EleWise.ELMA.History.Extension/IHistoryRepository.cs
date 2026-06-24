using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.History.Enums;
using EleWise.ELMA.History.Models;

namespace EleWise.ELMA.History.ExtensionPoints;

internal interface IHistoryRepository
{
	Guid Uid { get; }

	string Name { get; }

	bool CheckRepositoryStatus(IDictionary<string, string> checkSettings, out string info);

	bool GetRepositoryStatus();

	bool TableExists(string tableName);

	bool CreateTables();

	void CheckEntityHistoryTable(string tablename);

	bool DropTable(string tableName);

	bool OpenConnection();

	bool CloseConnection();

	void InitRepository(HistoryProviderSettingsSection settingsSection);

	void BulkInsertHistoryRelatedObjects(long objectId, Guid objectTypeUid, IEnumerable<KeyValuePair<long, Guid>> relatedObjects);

	IEnumerable<RelatedEntityActionHistoryUnitOfWorkModel> GetUnitOfWorks(long objectId, Guid objectTypeUid, int? maxResults, bool orderDesc, DateTime? lastActionDate, int packageIndex);

	void CacheHistoryPart(string tableName, DataTable dataTable);

	HistoryUpdatingStatus GetUpdatingStatus(long objectId, Guid objectTypeUid);

	IEnumerable<EntityActionEventTuple> LoadCachedHistory(long objectId, Guid objectTypeUid, IEnumerable<Guid> unitOfWorks, bool orderDesc);

	void ClearObserverTable(long objectId, Guid objectTypeUid);

	IEnumerable<InverseRelatedEntityModel> ClearObserverTableByType(Guid objectTypeUid);

	void UpdateCachedHistoryObjects(long objectId, Guid oldObjectTypeUid, Guid newObjectTypeUid);
}
