using System;

namespace EleWise.ELMA.Messages;

public static class MessagesConstants
{
	public static readonly Guid AssemblyUid = new Guid("{41F2DA01-8FF1-495D-B287-F10417BD1B28}");

	internal const string FeedArchiveIntervalSettingsKey = "MessageManager.FeedArchiveInterval";

	public const string FeedTableName = "Feed";

	public const string FeedArchiveTableName = "FeedArchive";

	public const string FeedFavoriteTableName = "FeedFavorite";

	public const string FeedInfoTableName = "FeedInfo";

	public const string FeedColumnId = "Id";

	public const string FeedColumnSubject = "Subject";

	public const string FeedColumnText = "Text";

	public const string FeedColumnTextHtml = "TextHtml";

	public const string FeedColumnActionUid = "ActionUid";

	public const string FeedColumnActionObjectUid = "ActionObjectUid";

	public const string FeedColumnActionObjectId = "ActionObjectId";

	public const string FeedColumnRecipient = "Recipient";

	public const string FeedColumnCreationDate = "CreationDate";

	public const string FeedColumnChangeDate = "ChangeDate";

	public const string FeedColumnCreationAuthor = "CreationAuthor";

	public const string FeedColumnIsParent = "IsParent";

	public const string FeedColumnParentObjectId = "ParentObjectId";

	public const string FeedColumnParentObjectUid = "ParentObjectUid";

	public const string FeedColumnChildCount = "ChildCount";

	public const string FeedColumnIsRead = "IsRead";

	public const string FeedColumnReadDate = "ReadDate";

	public const string FeedColumnHasUnreadChild = "HasUnreadChild";

	public const string FeedColumnUnreadCount = "UnreadCount";

	public const string FeedColumnPriority = "Priority";

	public const string FeedColumnChangeDateHash = "ChangeDateHash";

	public const string FeedColumnMessageAttachments = "MessageAttachments";

	public const string FeedColumnObjectRecipients = "ObjectRecipients";

	public const string FeedColumnMessageObjects = "MessageObjects";

	public const string FeedColumnUrl = "Url";

	public const string FeedColumnIsDelete = "IsDelete";

	public const string FeedColumnData = "Data";

	public const int FeedColumnUrlMaxLength = 2000;

	public const string FavoriteDelete = "-";

	public static readonly Guid ArchiveInformationChannelGroup = new Guid("{968D64DD-5DE0-4004-936C-56F406FF9343}");
}
