using System;

namespace EleWise.ELMA.History.Constants;

internal static class HistoryConst
{
	public const int LoadHistoryMaxResultDefault = 10;

	public static int HistoryCacheStatusDuration = 30;

	public const string HistoryCacheRegion = "HistoryCacheRegion";

	public const string HistoryTableName = "HistoryObject";

	public const string HistoryObjectFieldName = "Object";

	public const string HistoryModelFieldName = "Model";

	public const string HistoryIdFieldName = "Id";

	public const string HistoryUidFieldName = "Uid";

	public const string HistoryAuthorFieldName = "CreationAuthor";

	public const string HistorySessionFieldName = "SessionUid";

	public const string HistoryActionDateFieldName = "ActionDate";

	public const string HistoryActionFieldName = "ActionTypeUid";

	public const string HistoryUnitOfWorkFieldName = "UnitOfWorkUid";

	public const string HistoryEventArgsFieldName = "EventArgsUid";

	public const string IsRelatedEventFieldName = "IsRelatedEvent";

	public const string HistoryObserverTableName = "HistoryObjectObserver";

	public const string HistoryObjectObserversUpsertQueryName = "HistoryObjectObserversUpsert";

	public const string HistoryObjectObserverParentFieldName = "Parent";

	public const string HistoryObjectObserverChildFieldName = "Child";

	public const string LoadHistoryMaxResultSettings = "EntityHistoryPanel.LoadHistoryMaxResult";

	public const string CollectorsQueriesTableName = "HistoryCollectorsStates";

	public const string CollectorGuidFieldName = "CollectorGuid";

	public const string QueryFieldName = "Query";

	internal const string HistoryUpdatingStatusCacheKey = "HistoryUpdatingStatusFor";

	public static Guid DatabaseRepositoryUid => Guid.Parse("AFA3D302-347B-4B78-AFC0-10C90CADEBF3");
}
