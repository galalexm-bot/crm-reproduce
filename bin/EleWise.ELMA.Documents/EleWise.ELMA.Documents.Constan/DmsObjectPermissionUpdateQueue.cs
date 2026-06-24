namespace EleWise.ELMA.Documents.Constants;

internal class DmsObjectPermissionUpdateQueueItemConstants
{
	public static class Fields
	{
		public const string Id = "Id";

		public const string Patch = "Patch";

		public const string CreationDate = "CreationDate";

		public const string DmsObject = "DmsObject";

		public const string FolderId = "FolderId";

		public const string FolderName = "FolderName";

		public const string Attempt = "Attempt";

		public const string LastUpdateDate = "LastUpdateDate";

		public const string NextUpdateDate = "NextUpdateDate";

		public const string ServerConnectionUid = "ServerConnectionUid";

		public const string User = "User";
	}

	public static class StorageProcedures
	{
		public const string GetDocumentsFromFolder = "GetDocumentsFromFolder";

		public const string GetDmsObjectPermissionUpdateQueueItems = "GetDmsObjectPermissionUpdateQueueItems";

		public const string ReleaseDmsObjectPermissionUpdateQueueItems = "ReleaseDmsObjectPermissionUpdateQueueItems";
	}

	public static class Settings
	{
		public const string DmsObjectsPermissionCountSettingKey = "DmsObjectPermissionUpdateQueueItem.DmsObjectsCount";

		public const string ReleaseItemsIntervalSettingKey = "DmsObjectPermissionUpdateQueueItem.ReleaseItemsInterval";

		public const string IntervalSettingKey = "DmsObjectPermissionUpdateQueueItem.Interval";

		public const string EnabledSettingKey = "DmsObjectPermissionUpdateQueueItem.Enabled";

		public const int DmsObjectsPermissionCountDefault = 5000;

		public const int ReleaseItemsIntervalDefault = 60;

		public const int IntervalDefault = 5000;
	}

	public const string TableName = "DmsObjectPermissionUpdateQueueItem";
}
