using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.Components.Feed;
using EleWise.ELMA.Messages.Components.Hubs;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.Exceptions;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Web.Hubs.Services;
using NHibernate;
using NHibernate.Transform;
using NHibernate.Type;

namespace EleWise.ELMA.Messages.Managers;

[Service]
internal class FeedManager : NHManagerBase
{
	internal const string FeedMessageCommand = "FeedMessage";

	protected Guid FeedSettingsUid = new Guid("{250FFBA3-1E6F-4A2F-AFCA-F1BB8B9D59DC}");

	private static readonly ILogger Logger = EleWise.ELMA.Logging.Logger.GetLogger("Feed");

	private static FeedManager feedManager;

	private readonly ThreadSubPool pool;

	private ISecurityService securityService;

	private static MessagesSettingsModule messagesSettingsModule;

	public const long MaxArchiveUserErrorCount = 3L;

	private const string FeedLoadKey = "FeedDateLimit";

	private const string FeedDateLimitCacheKey = "FeedDateLimit";

	private const string FeedDateLimitCacheTimestamp = "FeedDateLimit_Timestamp";

	private const string FeedArchiveInfoBlob = "FeedArchiveInfoKey";

	private const string FeedArchiveInfo = "FeedArchiveInfo";

	private const string FeedArchiveInfoTimestamp = "FeedArchiveInfo_Timestamp";

	protected string PriorityBLOBKey = "Priority";

	private const string UnreadedMessagesCountCacheKey = "FeedManager.GetUnreadCount";

	private const string UnreadedMessagesCountCacheRegion = "FeedManager.GetUnreadCount-Region";

	private const string FeedToArchiveIdxDisabled = "FeedToArchiveIdxDisabled";

	public UserManager UserManager { get; set; }

	public IAgentHubService AgentHubService { get; set; }

	public static FeedManager Instance => feedManager ?? (feedManager = Locator.GetServiceNotNull<FeedManager>());

	public IFeedHubService FeedHubService { get; set; }

	protected static MessagesSettingsModule MessagesSettingsModule => messagesSettingsModule ?? (messagesSettingsModule = Locator.GetServiceNotNull<MessagesSettingsModule>());

	protected static EleWise.ELMA.Security.Models.IUser CurrentUser => AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();

	public ITransformationProvider TransformationProvider { get; set; }

	public IUnitOfWorkManager UnitOfWorkManager { get; set; }

	public IBLOBDataManager BLOBManager { get; set; }

	public ISecurityService SecurityService
	{
		get
		{
			return securityService ?? (securityService = Locator.GetServiceNotNull<ISecurityService>());
		}
		set
		{
		}
	}

	public IEnumerable<IFeedMessageUpdateProvider> FeedMessageUpdateProviders { get; set; }

	public ILockManager LockManager { get; set; }

	public ICacheService CacheService { get; set; }

	public IComplexCacheService ComplexCacheService { get; set; }

	private Guid LogInfo(string actionName, string action, Guid logKey = default(Guid))
	{
		if (Logger.IsEnabled(LogLevel.Information) && !string.IsNullOrEmpty(actionName))
		{
			string text = action ?? "";
			if (!string.IsNullOrEmpty(text))
			{
				if (logKey == Guid.Empty)
				{
					logKey = Guid.NewGuid();
				}
				Logger.Info($"{actionName} ({logKey}): {text}");
			}
		}
		return logKey;
	}

	internal FeedManager()
	{
		pool = new ThreadSubPool("FeedManager.PoolSize", 5);
	}

	internal Table CreateFeedTable(string tableName)
	{
		Table table = new Table
		{
			Columns = new List<Column>(),
			Name = tableName,
			Sequence = false
		};
		table.Columns.Add(new Column("Id", DbType.Int64));
		table.Columns.Add(new Column("Subject", DbType.String, int.MaxValue));
		table.Columns.Add(new Column("Text", DbType.String, int.MaxValue));
		table.Columns.Add(new Column("TextHtml", DbType.String, int.MaxValue));
		table.Columns.Add(new Column("ActionObjectUid", DbType.Guid, ColumnProperty.NotNull));
		table.Columns.Add(new Column("ActionUid", DbType.Guid, ColumnProperty.NotNull));
		table.Columns.Add(new Column("ActionObjectId", DbType.Int64, ColumnProperty.NotNull));
		table.Columns.Add(new Column("Recipient", DbType.Int64, ColumnProperty.NotNull));
		table.Columns.Add(new Column("CreationDate", DbType.DateTime, ColumnProperty.NotNull));
		table.Columns.Add(new Column("ChangeDate", DbType.DateTime, ColumnProperty.NotNull));
		table.Columns.Add(new Column("CreationAuthor", DbType.Int64));
		table.Columns.Add(new Column("IsParent", DbType.Boolean, ColumnProperty.NotNull, false));
		table.Columns.Add(new Column("ParentObjectId", DbType.Int64));
		table.Columns.Add(new Column("ParentObjectUid", DbType.Guid));
		table.Columns.Add(new Column("ChildCount", DbType.Int32));
		table.Columns.Add(new Column("IsRead", DbType.Boolean, false));
		table.Columns.Add(new Column("ReadDate", DbType.DateTime, null));
		table.Columns.Add(new Column("HasUnreadChild", DbType.Boolean, true));
		table.Columns.Add(new Column("UnreadCount", DbType.Int32));
		table.Columns.Add(new Column("Priority", DbType.Int32, (object)0));
		table.Columns.Add(new Column("ChangeDateHash", DbType.String, 35, ColumnProperty.NotNull));
		table.Columns.Add(new Column("MessageAttachments", DbType.Binary, int.MaxValue));
		table.Columns.Add(new Column("ObjectRecipients", DbType.Binary, int.MaxValue));
		table.Columns.Add(new Column("MessageObjects", DbType.Binary, int.MaxValue));
		table.Columns.Add(new Column("Url", DbType.String, 2000));
		TransformationProvider.AddTable(table);
		return table;
	}

	internal Table CreateInfoTable()
	{
		Table table = new Table
		{
			Columns = new List<Column>(),
			Name = "FeedInfo",
			Sequence = true
		};
		table.Columns.Add(new Column("Id", DbType.Int64, ColumnProperty.PrimaryKey));
		table.Columns.Add(new Column("Recipient", DbType.Int64, ColumnProperty.NotNull));
		table.Columns.Add(new Column("ActionObjectUid", DbType.Guid, ColumnProperty.NotNull));
		table.Columns.Add(new Column("ActionObjectId", DbType.Int64, ColumnProperty.NotNull));
		table.Columns.Add(new Column("ChangeDate", DbType.DateTime, ColumnProperty.NotNull));
		table.Columns.Add(new Column("Data", DbType.Binary, int.MaxValue));
		TransformationProvider.AddTable(table);
		return table;
	}

	internal Table CreateFavoriteTable()
	{
		Table table = new Table
		{
			Columns = new List<Column>(),
			Name = "FeedFavorite",
			Sequence = true
		};
		table.Columns.Add(new Column("Id", DbType.Int64, ColumnProperty.PrimaryKey));
		table.Columns.Add(new Column("Recipient", DbType.Int64, ColumnProperty.NotNull));
		table.Columns.Add(new Column("ActionObjectUid", DbType.Guid, ColumnProperty.NotNull));
		table.Columns.Add(new Column("ActionObjectId", DbType.Int64, ColumnProperty.NotNull));
		table.Columns.Add(new Column("ChangeDateHash", DbType.String, 16, ColumnProperty.NotNull));
		table.Columns.Add(new Column("IsDelete", DbType.Boolean, false));
		TransformationProvider.AddTable(table);
		return table;
	}

	public List<FeedModel> LoadMessages(FeedLoadSettings settings = null, bool onlyUnread = false)
	{
		if (settings == null)
		{
			settings = new FeedLoadSettings();
		}
		long id = (settings.Recipient ?? CurrentUser).Id;
		string text = (string.IsNullOrEmpty(settings.ChangeDateHash) ? null : settings.ChangeDateHash.ToLowerInvariant());
		IQuery obj = base.Session.GetNamedQuery("ExecFeedLoad").CleanUpCache(cleanUpCache: false).SetParameter<string>("ChangeDateHash", text)
			.SetParameter<long>("Recipient", id)
			.SetParameter<int>("MaxChildCount", settings.MaxChildCount)
			.SetParameter<int>("Priority", (int)settings.Priority)
			.SetParameter<int>("MaxCount", settings.MaxCount)
			.SetParameter<bool>("AllMessages", !onlyUnread);
		Guid logKey = LogInfo("FeedLoad", $"Begin: Recipient={id}, ChangeDateHash={text}");
		List<FeedModel> result = obj.SetResultTransformer((IResultTransformer)(object)new FeedResultTransformer()).List<FeedModel>().ToList();
		LogInfo("FeedLoad", "End", logKey);
		return result;
	}

	public List<FeedModel> FindMessages(FeedLoadSettings settings = null, FeedFilter filter = null)
	{
		if (settings == null)
		{
			settings = new FeedLoadSettings();
		}
		if (filter == null || filter.IsEmpty())
		{
			return LoadMessages(settings);
		}
		string text = (string.IsNullOrEmpty(filter.SearchString) ? null : filter.SearchString.Trim());
		if (!string.IsNullOrEmpty(text))
		{
			text = $"%{filter.SearchString}%";
		}
		long id = (settings.Recipient ?? CurrentUser).Id;
		string text2 = (string.IsNullOrEmpty(settings.ChangeDateHash) ? null : settings.ChangeDateHash);
		DateTime dateTime = (filter.ChangeDate.From.HasValue ? filter.ChangeDate.From.Value : ArchiveDateLimit());
		bool flag = dateTime < GetRealArchiveDateLimit();
		IQuery val = base.Session.GetNamedQuery(flag ? "ExecFeedArchiveSearch" : "ExecFeedSearch").CleanUpCache(cleanUpCache: false).SetParameter<int>("MaxCount", settings.MaxCount)
			.SetParameter<int>("MaxChildCount", settings.MaxChildCount)
			.SetParameter<long>("Recipient", id)
			.SetParameter<string>("ChangeDateHash", text2)
			.SetParameter<string>("FastSearch", string.IsNullOrEmpty(text) ? null : text)
			.SetParameter<DateTime>("ChangeDateFrom", dateTime)
			.SetParameter<bool>("OnlyUnread", filter.OnlyUnread)
			.SetParameter<DateTime?>("ChangeDateTo", filter.ChangeDate.To)
			.SetParameter<string>("FeedAuthors", (filter.CreationAuthor != null) ? string.Join(",", filter.CreationAuthor.Select((EleWise.ELMA.Security.Models.IUser u) => u.Id)) : null);
		if (flag)
		{
			val.SetTimeout(EleWise.ELMA.Runtime.Db.Migrator.Providers.TransformationProvider.DefaultExtendedCommandTimeout);
		}
		Guid logKey = LogInfo("FeedSearch", $"Begin: Recipient={id}, ChangeDateHash={text2}");
		List<FeedModel> result = val.SetResultTransformer((IResultTransformer)(object)new FeedResultTransformer()).List<FeedModel>().ToList();
		LogInfo("FeedSearch", "FeedSearch", logKey);
		return result;
	}

	public FeedModel LoadParentMessage(long objectId, Guid objectUid, EleWise.ELMA.Security.Models.IUser recipient = null)
	{
		EleWise.ELMA.Security.Models.IUser user = recipient ?? CurrentUser;
		IQuery obj = base.Session.GetNamedQuery("ExecFeedParentMessageLoad").CleanUpCache(cleanUpCache: false).SetParameter<long>("ParentObjectId", objectId)
			.SetParameter<Guid>("ParentObjectUid", objectUid)
			.SetParameter<long>("Recipient", user.Id);
		Guid logKey = LogInfo("FeedParentMessageLoad", $"Begin: Recipient={user.Id}, ParentObjectId={objectId}, ParentObjectUid={objectUid}");
		FeedModel result = obj.SetResultTransformer((IResultTransformer)(object)new FeedResultTransformer()).UniqueResult<FeedModel>();
		LogInfo("FeedParentMessageLoad", "End", logKey);
		return result;
	}

	public FeedModel LoadComments(long actionObjectId, Guid actionObjectUid, FeedLoadSettings settings = null)
	{
		if (settings == null)
		{
			settings = new FeedLoadSettings();
		}
		long id = (settings.Recipient ?? CurrentUser).Id;
		string text = (string.IsNullOrEmpty(settings.ChangeDateHash) ? null : settings.ChangeDateHash);
		IQuery val = base.Session.GetNamedQuery("ExecFeedCommentsLoad").CleanUpCache(cleanUpCache: false).SetParameter<string>("ChangeDateHash", text)
			.SetParameter<long>("ParentObjectId", actionObjectId)
			.SetParameter<Guid>("ParentObjectUid", actionObjectUid)
			.SetParameter<long>("Recipient", id)
			.SetParameter<int>("MaxChildCount", settings.MaxChildCount);
		Guid logKey = LogInfo("FeedCommentsLoad", $"Begin: Recipient={id}, ChangeDateHash={text}, ParentObjectId={actionObjectId}, ParentObjectUid={actionObjectUid}");
		FeedModel result = val.SetResultTransformer((IResultTransformer)(object)new FeedResultTransformer()).UniqueResult<FeedModel>();
		LogInfo("FeedCommentsLoad", "End", logKey);
		return result;
	}

	private static IFeedCommentExtension GetCommentPoint(Guid objectUid)
	{
		IFeedCommentExtension[] source = (from p in ComponentManager.Current.GetExtensionPoints<IFeedCommentExtension>()
			where p.CommentIsSupported(objectUid)
			select p).ToArray();
		if (!source.Any())
		{
			return null;
		}
		return source.First();
	}

	public void CanCreateComment(List<CanCreateCommentItemMessage> objects)
	{
		foreach (KeyValuePair<Guid, IFeedCommentExtension> item in from p in (from o in objects
				where o != null
				where o.Message != null
				where o.Message.ParentObjectUid.HasValue
				select o.Message.ParentObjectUid.Value).Distinct().ToDictionary((Guid objectUid) => objectUid, GetCommentPoint)
			where p.Value != null
			select p)
		{
			item.Value.CanCreateComment(objects);
		}
	}

	public void CanCreateComment(List<CanCreateCommentItem> objects)
	{
		foreach (KeyValuePair<Guid, IFeedCommentExtension> item in from p in (from o in objects
				where o != null
				select o.ObjectUid).Distinct().ToDictionary((Guid objectUid) => objectUid, GetCommentPoint)
			where p.Value != null
			select p)
		{
			KeyValuePair<Guid, IFeedCommentExtension> valuePair = item;
			CanCreateCommentItem[] source = objects.Where((CanCreateCommentItem o) => o.ObjectUid == valuePair.Key).ToArray();
			Dictionary<long, bool> dict = source.Distinct().ToDictionary((CanCreateCommentItem k) => k.ObjectId, (CanCreateCommentItem v) => false);
			item.Value.CanCreateComment(item.Key, dict);
			source.Where((CanCreateCommentItem o) => dict.ContainsKey(o.ObjectId) && dict[o.ObjectId]).ForEach(delegate(CanCreateCommentItem ob)
			{
				ob.CanCreateComment = true;
			});
		}
	}

	[Transaction]
	public virtual Guid CreateComment(Guid objectUid, long objectId, string text, MessageAttachment[] messageAttachments)
	{
		return GetCommentPoint(objectUid)?.CreateComment(objectUid, objectId, text, messageAttachments) ?? Guid.Empty;
	}

	[Transaction]
	public virtual Guid CreateCommentAndSetRead(Guid objectUid, long objectId, string text, MessageAttachment[] messageAttachments, string changeDateHash)
	{
		IFeedCommentExtension commentPoint = GetCommentPoint(objectUid);
		if (commentPoint == null)
		{
			return Guid.Empty;
		}
		Guid guid = commentPoint.CreateComment(objectUid, objectId, text, messageAttachments);
		if (guid != Guid.Empty)
		{
			SetAsRead(changeDateHash, objectId, objectUid);
		}
		return guid;
	}

	private static IFeedQuestionExtension GetQuestionPoint(Guid objectUid)
	{
		IFeedQuestionExtension[] source = (from p in ComponentManager.Current.GetExtensionPoints<IFeedQuestionExtension>()
			where p.QuestionIsSupported(objectUid)
			select p).ToArray();
		if (!source.Any())
		{
			return null;
		}
		return source.First();
	}

	public void CanCreateQuestion(List<CanCreateQuestionItem> objects)
	{
		foreach (KeyValuePair<Guid, IFeedQuestionExtension> item in from p in objects.Select((CanCreateQuestionItem o) => o.ObjectUid).Distinct().ToDictionary((Guid objectUid) => objectUid, GetQuestionPoint)
			where p.Value != null
			select p)
		{
			KeyValuePair<Guid, IFeedQuestionExtension> valuePair = item;
			CanCreateQuestionItem[] source = objects.Where((CanCreateQuestionItem o) => o.ObjectUid == valuePair.Key).ToArray();
			Dictionary<long, bool> dict = source.Select((CanCreateQuestionItem o) => o.ObjectId).Distinct().ToDictionary((long id) => id, (long v) => false);
			item.Value.CanCreateQuestion(item.Key, dict);
			source.Where((CanCreateQuestionItem o) => dict.ContainsKey(o.ObjectId) && dict[o.ObjectId]).ForEach(delegate(CanCreateQuestionItem ob)
			{
				ob.CanCreateQuestion = true;
			});
		}
	}

	[Transaction]
	public virtual Guid CreateQuestion(Guid objectUid, long objectId, string text, EleWise.ELMA.Security.IUser executor, MessageAttachment[] messageAttachments, bool showAll)
	{
		return GetQuestionPoint(objectUid)?.CreateQuestion(objectUid, objectId, text, executor, messageAttachments, showAll) ?? Guid.Empty;
	}

	[Transaction]
	public virtual Guid CreateQuestionAndSetRead(Guid objectUid, long objectId, string text, EleWise.ELMA.Security.IUser executor, MessageAttachment[] messageAttachments, bool showAll, string changeDateHash)
	{
		IFeedQuestionExtension questionPoint = GetQuestionPoint(objectUid);
		if (questionPoint == null)
		{
			return Guid.Empty;
		}
		Guid guid = questionPoint.CreateQuestion(objectUid, objectId, text, executor, messageAttachments, showAll);
		if (guid != Guid.Empty)
		{
			SetAsRead(changeDateHash, objectId, objectUid);
		}
		return guid;
	}

	[Transaction]
	public virtual void SaveMessage(FeedModel message, FeedRecipientInfo[] recipients, bool setReadForAuthor, bool checkParent = false)
	{
		if (message == null)
		{
			throw new ArgumentNullException(SR.T("Не задано сообщение."));
		}
		if (recipients == null || !recipients.Any())
		{
			throw new ArgumentNullException(SR.T("Не указаны получатели сообщения."));
		}
		FeedModel feedModel = message.Parent ?? message;
		FeedModel feedModel2 = ((message.Parent != null) ? message : null);
		if (string.IsNullOrWhiteSpace(feedModel.Subject))
		{
			throw new ArgumentException(SR.T("Не задана тема сообщения."));
		}
		if (feedModel.ActionUid == Guid.Empty)
		{
			throw new ArgumentException(SR.T("Не указан UID действия."));
		}
		if (feedModel.ActionObjectUid == Guid.Empty)
		{
			throw new ArgumentException(SR.T("Не указан UID типа объекта сообщения."));
		}
		if (feedModel.ActionObjectId == 0L)
		{
			throw new ArgumentException(SR.T("Не указан ID объекта сообщения."));
		}
		if (feedModel.CreationAuthor == null)
		{
			throw new ArgumentException(SR.T("Не указан автор сообщения."));
		}
		if (feedModel.Url != null && feedModel.Url.Length > 2000)
		{
			throw new ArgumentException(SR.T("Слишком длинная ссылка Url для сообщения."));
		}
		if (feedModel2 != null)
		{
			if (feedModel2.ActionUid == Guid.Empty)
			{
				throw new ArgumentException(SR.T("Не указан UID действия комментария."));
			}
			if (feedModel2.ActionObjectUid == Guid.Empty)
			{
				throw new ArgumentException(SR.T("Не указан UID типа объекта комментария."));
			}
			if (feedModel2.ActionObjectId == 0L)
			{
				throw new ArgumentException(SR.T("Не указан ID объекта комментария."));
			}
			if (feedModel2.CreationAuthor == null)
			{
				throw new ArgumentException(SR.T("Не указан автор комментария."));
			}
			if (feedModel2.Url != null && feedModel2.Url.Length > 2000)
			{
				throw new ArgumentException(SR.T("Слишком длинная ссылка Url для комментария."));
			}
		}
		Guid guid = LogInfo("FeedSaveMessage", $"Begin: ActionObjectUid={feedModel.ActionObjectUid}, ActionObjectId={feedModel.ActionObjectId}");
		string text = CreateLockKey(feedModel.ActionObjectId, feedModel.ActionObjectUid);
		using (LockManager.Lock(text, 180))
		{
			try
			{
				LogInfo("FeedSaveMessage", $"LockBase: lockKey={text}", guid);
				DateTime now = DateTime.Now;
				if (feedModel.CreationDate == DateTime.MinValue)
				{
					feedModel.CreationDate = now;
				}
				long num = 0L;
				num = CreateNewIds(recipients.Length * ((feedModel2 == null) ? 1 : 2));
				if (num == 0L)
				{
					throw new Exception(SR.T("Ошибка получения идентификаторов для ленты сообщений"));
				}
				DateTime dateTime = now;
				string text2 = dateTime.Ticks.ToString("x16").ToLowerInvariant();
				IQuery sqlQuery = base.Session.GetNamedQuery("ExecFeedSaveMessage");
				sqlQuery.CleanUpCache(cleanUpCache: false);
				sqlQuery.SetParameter("Parent_Subject", (object)feedModel.Subject, (IType)(object)NHibernateUtil.StringClob);
				sqlQuery.SetParameter("Parent_Text", (object)feedModel.Text, (IType)(object)NHibernateUtil.StringClob);
				sqlQuery.SetParameter("Parent_TextHtml", (object)feedModel.TextHtml, (IType)(object)NHibernateUtil.StringClob);
				sqlQuery.SetParameter<Guid>("Parent_ActionUid", feedModel.ActionUid);
				sqlQuery.SetParameter<Guid>("Parent_ActionObjectUid", feedModel.ActionObjectUid);
				sqlQuery.SetParameter<long>("Parent_ActionObjectId", feedModel.ActionObjectId);
				sqlQuery.SetParameter<DateTime>("Parent_CreationDate", feedModel.CreationDate);
				sqlQuery.SetParameter<long>("Parent_CreationAuthor", feedModel.CreationAuthor.Id);
				sqlQuery.SetParameter("Parent_MessageAttachments", (object)PackList(feedModel.MessageAttachments), (IType)(object)NHibernateUtil.BinaryBlob);
				sqlQuery.SetParameter("Parent_ObjectRecipients", (object)PackList(feedModel.ObjectRecipients), (IType)(object)NHibernateUtil.BinaryBlob);
				sqlQuery.SetParameter("Parent_MessageObjects", (object)PackList(feedModel.MessageObjects), (IType)(object)NHibernateUtil.BinaryBlob);
				sqlQuery.SetParameter("Parent_Url", (object)feedModel.Url, (IType)(object)NHibernateUtil.String);
				sqlQuery.SetParameter("Subject", (object)feedModel2?.Subject, (IType)(object)NHibernateUtil.StringClob);
				sqlQuery.SetParameter("Text", (object)feedModel2?.Text, (IType)(object)NHibernateUtil.StringClob);
				sqlQuery.SetParameter("TextHtml", (object)feedModel2?.TextHtml, (IType)(object)NHibernateUtil.StringClob);
				sqlQuery.SetParameter("ActionUid", (feedModel2 == null) ? null : ((object)feedModel2.ActionUid), (IType)(object)NHibernateUtil.Guid);
				sqlQuery.SetParameter("ActionObjectUid", (feedModel2 == null) ? null : ((object)feedModel2.ActionObjectUid), (IType)(object)NHibernateUtil.Guid);
				sqlQuery.SetParameter("ActionObjectId", (feedModel2 == null) ? null : ((object)feedModel2.ActionObjectId), (IType)(object)NHibernateUtil.Int64);
				sqlQuery.SetParameter("CreationAuthor", (feedModel2 == null) ? null : ((object)feedModel2.CreationAuthor.Id), (IType)(object)NHibernateUtil.Int64);
				sqlQuery.SetParameter("MessageAttachments", (object)((feedModel2 == null) ? null : PackList(feedModel2.MessageAttachments)), (IType)(object)NHibernateUtil.BinaryBlob);
				sqlQuery.SetParameter("ObjectRecipients", (object)((feedModel2 == null) ? null : PackList(feedModel2.ObjectRecipients)), (IType)(object)NHibernateUtil.BinaryBlob);
				sqlQuery.SetParameter("MessageObjects", (object)((feedModel2 == null) ? null : PackList(feedModel2.MessageObjects)), (IType)(object)NHibernateUtil.BinaryBlob);
				sqlQuery.SetParameter("Url", (object)feedModel2?.Url, (IType)(object)NHibernateUtil.String);
				sqlQuery.SetParameter<bool>("SaveComment", feedModel2 != null);
				sqlQuery.SetParameter<DateTime>("ChangeDate", dateTime);
				sqlQuery.SetParameter<string>("ChangeDateHash", text2);
				sqlQuery.SetParameter("Recipients", (object)string.Join(",", from r in recipients.Distinct((FeedRecipientInfo r1, FeedRecipientInfo r2) => r1.User.Id == r2.User.Id)
					orderby r.User.Id
					select $"{r.User.Id}:{(int)r.Priority}"), (IType)(object)NHibernateUtil.StringClob);
				sqlQuery.SetParameter<bool>("SetReadForAuthor", setReadForAuthor);
				sqlQuery.SetParameter<long>("IdRangeStart", num);
				sqlQuery.SetParameter<bool>("CheckParent", checkParent);
				sqlQuery.SetParameter<DateTime>("DateTimeNow", now);
				int timeout = FeedSaveTimeout();
				base.Session.ExecuteWithTimeout(timeout, delegate
				{
					sqlQuery.ExecuteUpdate(cleanUpCache: false);
				});
				LogInfo("FeedSaveMessage", "ExecuteUpdate", guid);
				foreach (FeedRecipientInfo feedRecipientInfo in recipients)
				{
					ResetUnreadedMessagesCountCache(feedRecipientInfo.User);
				}
				if (feedModel2 != null)
				{
					message.ChangeDateHash = text2 + num.ToString().PadLeft(19, Convert.ToChar("0"));
					FeedHubService.SendComment(message, recipients.Select((FeedRecipientInfo q) => q.User));
				}
				LogInfo("FeedSaveMessage", "End", guid);
			}
			catch (Exception exception)
			{
				Logger.Error($"FeedSaveMessage ({guid}): Error: ", exception);
				throw;
			}
		}
		LogInfo("FeedSaveMessage", $"ReleaseLock: lockKey={text}", guid);
	}

	internal void CreateParentMessage(IEntity entity)
	{
		SecurityService.RunWithElevatedPrivilegiesAndWithDeleted(delegate
		{
			SecurityService.RunByUser(CurrentUser, delegate
			{
				DateTime now = DateTime.Now;
				FeedModel feedMessage = new FeedModel
				{
					ActionObjectId = ((entity.GetId() != null) ? long.Parse(entity.GetId().ToString()) : 0),
					ActionObjectUid = InterfaceActivator.UID(entity.GetType()),
					ActionUid = DefaultEntityActions.CreateGuid,
					CreationDate = now,
					Priority = FeedPriority.Normal
				};
				feedMessage.ParentObjectId = feedMessage.ActionObjectId;
				feedMessage.ParentObjectUid = feedMessage.ActionObjectUid;
				feedMessage.IsParent = true;
				feedMessage.Parent = null;
				IFeedMessageUpdater[] array = (from p in FeedMessageUpdateProviders
					where p.CanUpdateMessage(feedMessage.ActionUid, feedMessage.ActionObjectUid, feedMessage.ActionObjectId)
					select p.GetMessageUpdater(feedMessage.ActionUid, feedMessage.ActionObjectUid, feedMessage.ActionObjectId)).ToArray();
				if (array.Length == 0)
				{
					Logger.Info(SR.T("Невозможно сопоставить обработчик для элемента ленты сообщений: ObjectUid: {0}", feedMessage.ActionObjectUid));
				}
				else
				{
					array = array.Where((IFeedMessageUpdater u) => u.UpdateMessage(feedMessage)).ToArray();
				}
				FeedModel feedModel = feedMessage.Clone();
				ReplaceTextHtml(feedModel);
				SaveMessage(feedModel, new FeedRecipientInfo[1]
				{
					new FeedRecipientInfo
					{
						User = CurrentUser,
						Priority = (array.Any() ? array.Select((IFeedMessageUpdater u) => u.GetPriorityForRecipient(feedMessage, CurrentUser)).Max() : FeedPriority.Normal)
					}
				}, setReadForAuthor: true, checkParent: true);
			});
		});
	}

	internal static void ReplaceTextHtml(FeedModel feedModel)
	{
		if (feedModel != null)
		{
			string shortMessageHtml = feedModel.TextHtml.ValueOrDefaultWhiteSpace(HttpUtility.HtmlEncode(feedModel.Text).Nl2Br());
			feedModel.TextHtml = ParseHtml(shortMessageHtml);
			if (feedModel.Parent != null)
			{
				string shortMessageHtml2 = feedModel.Parent.TextHtml.ValueOrDefaultWhiteSpace(HttpUtility.HtmlEncode(feedModel.Parent.Text).Nl2Br());
				feedModel.Parent.TextHtml = ParseHtml(shortMessageHtml2);
			}
		}
	}

	private static string ParseHtml(string shortMessageHtml)
	{
		if (string.IsNullOrWhiteSpace(shortMessageHtml))
		{
			return null;
		}
		return shortMessageHtml.PrepareHtmlHref();
	}

	private int FeedSaveAttemptCount()
	{
		int num = SR.GetSetting("MessageManager.FeedSaveAttemptCount", 5);
		if (num <= 0)
		{
			num = 5;
		}
		return num;
	}

	private int FeedSaveTimeout()
	{
		int num = SR.GetSetting("MessageManager.FeedSaveTimeout", 30);
		if (num <= 0)
		{
			num = 30;
		}
		return num;
	}

	private static string CreateLockKey(long actionObjectId, Guid actionObjectUid)
	{
		return $"Feed_{actionObjectUid}_{actionObjectId}";
	}

	internal long CreateNewIds(long count = 1L)
	{
		if (count <= 0)
		{
			return 0L;
		}
		long num = 0L;
		using (LockManager.Lock("FeedCreateNewIds"))
		{
			IQuery namedQuery = base.Session.GetNamedQuery("ExecFeedGetNewIds");
			namedQuery.CleanUpCache(cleanUpCache: false);
			namedQuery.SetParameter<long>("Count", count);
			return Convert.ToInt64(namedQuery.List()[0]);
		}
	}

	internal static byte[] PackList<T>(PackSerializableEnumerable<T> source) where T : IPackSerializableItem
	{
		if (source != null && source.Any())
		{
			return PackSerializableEnumerable<T>.Pack(source);
		}
		return null;
	}

	private FeedArchiveInfo GetArchiveInfo()
	{
		return new FeedArchiveInfo(ComplexCacheService.GetOrAdd("FeedArchiveInfo", "FeedArchiveInfo_Timestamp", () => DataAccessManager.BLOBManager.GetBLOB<string>(MessagesConstants.AssemblyUid, "FeedArchiveInfoKey") ?? ""));
	}

	private void ArchiveInfoSave(FeedArchiveInfo info)
	{
		ISession session = base.SessionProvider.GetSession(string.Empty);
		ISession session2 = base.SessionProvider.GetSession("FeedArchiveInfoSave");
		try
		{
			base.SessionProvider.SetCurrentSession(session2, string.Empty);
			ITransaction val = session2.BeginTransaction();
			try
			{
				try
				{
					DataAccessManager.BLOBManager.SetBLOB(MessagesConstants.AssemblyUid, "FeedArchiveInfoKey", info.ToString());
					ComplexCacheService.RefreshTimestamp("FeedArchiveInfo_Timestamp");
					val.Commit();
				}
				catch
				{
					val.Rollback();
				}
				finally
				{
					base.SessionProvider.SetCurrentSession(session, string.Empty);
					base.SessionProvider.CloseSession("FeedArchiveInfoSave");
				}
			}
			finally
			{
				((IDisposable)val)?.Dispose();
			}
		}
		finally
		{
			((IDisposable)session2)?.Dispose();
		}
	}

	public DateTime GetRealArchiveDateLimit()
	{
		DateTime? orAdd = ComplexCacheService.GetOrAdd("FeedDateLimit", "FeedDateLimit_Timestamp", () => DataAccessManager.BLOBManager.GetBLOB<DateTime?>(MessagesConstants.AssemblyUid, "FeedDateLimit"));
		if (!orAdd.HasValue)
		{
			return DateTime.MinValue.Date;
		}
		return orAdd.Value;
	}

	[Transaction]
	protected virtual void SetRealArchiveDateLimit(DateTime date)
	{
		ComplexCacheService.RefreshTimestamp("FeedDateLimit_Timestamp");
		DataAccessManager.BLOBManager.SetBLOB(MessagesConstants.AssemblyUid, "FeedDateLimit", (DateTime?)date);
	}

	public DateTime ArchiveDateLimit()
	{
		return DateTime.Now.Date.AddDays(0 - MessagesSettingsModule.Settings.FeedLimitToArchivePeriod);
	}

	[Transaction]
	internal virtual long FeedToArchive()
	{
		Guid guid = LogInfo("FeedToArchive", "Begin");
		FeedArchiveInfo archiveInfo = GetArchiveInfo();
		DateTime realArchiveDateLimit = GetRealArchiveDateLimit();
		DateTime dateLimit = ArchiveDateLimit();
		LogInfo("FeedToArchive", $"ToArchive-Start: {dateLimit}, LastUserId={archiveInfo.LastUserId}", guid);
		long userId;
		try
		{
			userId = 0L;
			base.Session.ExecuteWithTimeout(0, delegate
			{
				userId = Convert.ToInt64(base.Session.GetNamedQuery("ExecFeedToArchive").CleanUpCache(cleanUpCache: false).SetParameter<DateTime>("DateLimit", dateLimit)
					.SetParameter<long>("LastUserId", archiveInfo.LastUserId)
					.SetParameter<DateTime>("CurrentDate", DateTime.Now)
					.UniqueResult());
			});
			ResetUnreadedMessagesCountCache(userId);
			if (dateLimit >= realArchiveDateLimit)
			{
				SetRealArchiveDateLimit(dateLimit);
			}
			ArchiveInfoSave(new FeedArchiveInfo(userId, 0));
		}
		catch (Exception exception2)
		{
			try
			{
				ArchiveInfoSave(GetNextUserIfExceptionArchive(archiveInfo, dateLimit));
			}
			catch (Exception exception)
			{
				Logger.Error($"FeedToArchive-GetNextUser: Error: {guid}", exception);
			}
			Logger.Error($"FeedToArchive: Error: {guid}", exception2);
			throw new FeedToArchiveException(archiveInfo.LastUserId, exception2);
		}
		LogInfo("FeedToArchive", $"ToArchive-End, UserId={userId}", guid);
		return userId;
	}

	internal FeedArchiveInfo GetNextUserIfExceptionArchive(FeedArchiveInfo archiveInfo, DateTime dateLimit)
	{
		archiveInfo.ErrorCount++;
		if ((long)archiveInfo.ErrorCount >= 3L)
		{
			archiveInfo = new FeedArchiveInfo(Convert.ToInt64(base.Session.GetNamedQuery("ExecFeedToArchiveRecipient").CleanUpCache(cleanUpCache: false).SetParameter<DateTime>("DateLimit", dateLimit)
				.SetParameter<long>("LastUserId", archiveInfo.LastUserId)
				.UniqueResult()));
		}
		return archiveInfo;
	}

	public virtual string ChangeDateHashFirst()
	{
		EleWise.ELMA.Security.Models.IUser currentUser = CurrentUser;
		IQuery obj = base.Session.GetNamedQuery("ExecFeedChangeDateHashFirst").CleanUpCache(cleanUpCache: false).SetParameter<long>("Recipient", currentUser.Id);
		Guid logKey = LogInfo("FeedChangeDateHashFirst", $"Recipient={currentUser.Id}");
		string result = (string)obj.UniqueResult();
		LogInfo("FeedChangeDateHashFirst", "End", logKey);
		return result;
	}

	public virtual string ChangeDateHashLast()
	{
		EleWise.ELMA.Security.Models.IUser currentUser = CurrentUser;
		IQuery obj = base.Session.GetNamedQuery("ExecFeedChangeDateHashLast").CleanUpCache(cleanUpCache: false).SetParameter<long>("Recipient", currentUser.Id);
		Guid logKey = LogInfo("FeedChangeDateHashLast", $"Recipient={currentUser.Id}");
		string result = (string)obj.UniqueResult();
		LogInfo("FeedChangeDateHashLast", "End", logKey);
		return result;
	}

	public void SetAsRead(string changeDateHash, long actionObjectId, Guid actionObjectUid)
	{
		long recUserId = CurrentUser.Id;
		pool.Queue(delegate
		{
			new BackgroundTask(delegate
			{
				SetAsReadInternal(changeDateHash, actionObjectId, actionObjectUid, recUserId);
			}, typeof(FeedManager), "FeedManager.SetAsRead", SR.T("Отметить указанные сообщения как прочитанные")).Execute();
		});
	}

	private void SetAsReadInternal(string changeDateHash, long actionObjectId, Guid actionObjectUid, long recUserId)
	{
		if (actionObjectUid == Guid.Empty)
		{
			throw new ArgumentException(SR.T("Не указан UID типа объекта сообщения."));
		}
		if (actionObjectId == 0L)
		{
			throw new ArgumentException(SR.T("Не указан ID объекта сообщения."));
		}
		Guid logKey = LogInfo("FeedSetAsRead", $"Begin: ActionObjectUid={actionObjectUid}, ActionObjectId={actionObjectId}, ChangeDateHash={changeDateHash}, Recipient={recUserId}");
		changeDateHash = ChangeDateHashMaximalization(changeDateHash);
		string lockName = CreateLockKey(actionObjectId, actionObjectUid);
		using (LockManager.Lock(lockName))
		{
			int feedSaveTimeout = FeedSaveTimeout();
			int retryCount = FeedSaveAttemptCount();
			TransformationProvider.RetryOnDeadlock(delegate
			{
				UnitOfWorkManager.Execute(delegate(IUnitOfWork u)
				{
					u.Session.ExecuteWithTimeout(feedSaveTimeout, delegate
					{
						IQuery namedQuery = u.Session.GetNamedQuery("ExecFeedSetAsRead");
						namedQuery.CleanUpCache(cleanUpCache: false);
						namedQuery.SetParameter("ChangeDateHash", (object)(string.IsNullOrEmpty(changeDateHash) ? null : changeDateHash), (IType)(object)NHibernateUtil.String);
						namedQuery.SetParameter<long>("Recipient", recUserId);
						namedQuery.SetParameter("ActionObjectUid", (object)actionObjectUid, (IType)(object)NHibernateUtil.Guid);
						namedQuery.SetParameter("ActionObjectId", (object)actionObjectId, (IType)(object)NHibernateUtil.Int64);
						namedQuery.SetParameter("DateTimeNow", (object)DateTime.Now, (IType)(object)NHibernateUtil.DateTime);
						namedQuery.ExecuteUpdate(cleanUpCache: false);
					});
				});
			}, retryCount);
			LogInfo("FeedSetAsRead", "End", logKey);
		}
		ResetUnreadedMessagesCountCache(recUserId);
		UpdateFeedInAgent(recUserId);
	}

	private static string ChangeDateHashMaximalization(string changeDateHash)
	{
		if (!string.IsNullOrEmpty(changeDateHash))
		{
			return changeDateHash.Substring(0, 16).PadRight(35, Convert.ToChar("z"));
		}
		return null;
	}

	public void SetAsReadParents(string changeDateHashMin = null, string changeDateHashMax = null, FeedPriority? priority = null)
	{
		long recUserId = CurrentUser.Id;
		pool.Queue(delegate
		{
			new BackgroundTask(delegate
			{
				SetAsReadParentsInternal(changeDateHashMin, changeDateHashMax, priority, recUserId);
			}, typeof(FeedManager), "FeedManager.SetAsReadParents", SR.T("Отметить все родительские сообщения и их комментарии как прочитанные")).Execute();
		});
	}

	private void SetAsReadParentsInternal(string changeDateHashMin, string changeDateHashMax, FeedPriority? priority, long recUserId)
	{
		Guid logKey = LogInfo("FeedSetAsReadAll", $"Begin: ChangeDateHashMin={changeDateHashMin}, ChangeDateHashMax={changeDateHashMax}, Recipient={recUserId}");
		string lockName = "FeedManager_SetAsReadParents_" + recUserId;
		using (LockManager.Lock(lockName))
		{
			IQuery sqlQuery = base.Session.GetNamedQuery("ExecFeedSetAsReadAll");
			sqlQuery.CleanUpCache(cleanUpCache: false);
			sqlQuery.SetParameter("ChangeDateHashMin", (object)(string.IsNullOrEmpty(changeDateHashMin) ? null : changeDateHashMin), (IType)(object)NHibernateUtil.String);
			sqlQuery.SetParameter("ChangeDateHashMax", (object)(string.IsNullOrEmpty(changeDateHashMax) ? null : changeDateHashMax), (IType)(object)NHibernateUtil.String);
			sqlQuery.SetParameter("Priority", (!priority.HasValue) ? null : ((object)priority), (IType)(object)NHibernateUtil.Int32);
			sqlQuery.SetParameter<long>("Recipient", recUserId);
			sqlQuery.SetParameter("DateTimeNow", (object)DateTime.Now, (IType)(object)NHibernateUtil.DateTime);
			int feedSaveTimeout = FeedSaveTimeout();
			int retryCount = FeedSaveAttemptCount();
			TransformationProvider.RetryOnDeadlock(delegate
			{
				UnitOfWorkManager.Execute((Action)delegate
				{
					base.Session.ExecuteWithTimeout(feedSaveTimeout, delegate
					{
						sqlQuery.ExecuteUpdate(cleanUpCache: false);
					});
				});
			}, retryCount);
			LogInfo("FeedSetAsReadAll", "End", logKey);
		}
		ResetUnreadedMessagesCountCache(recUserId);
		UpdateFeedInAgent(recUserId);
	}

	public void SetAsReadForObject(Guid objectUid, long objectId, EleWise.ELMA.Security.Models.IUser recipient = null)
	{
		long recUserId = (recipient ?? CurrentUser).Id;
		pool.Queue(delegate
		{
			new BackgroundTask(delegate
			{
				SetAsReadForObjectInternal(objectUid, objectId, recUserId);
			}, typeof(FeedManager), "FeedManager.SetAsReadParents", SR.T("Отметить все родительские сообщения и их комментарии как прочитанные")).Execute();
		});
	}

	private void SetAsReadForObjectInternal(Guid objectUid, long objectId, long recUserId)
	{
		Guid logKey = LogInfo("FeedSetAsReadForObject", $"Begin: Recipient={recUserId}, ParentObjectUid={objectUid}, ParentObjectId={objectId}");
		string lockName = CreateLockKey(objectId, objectUid);
		using (LockManager.Lock(lockName))
		{
			DateTime now = DateTime.Now;
			IQuery sqlQuery = base.Session.GetNamedQuery("ExecFeedSetAsReadForObject");
			sqlQuery.CleanUpCache(cleanUpCache: false);
			sqlQuery.SetParameter<Guid>("ParentObjectUid", objectUid);
			sqlQuery.SetParameter<long>("ParentObjectId", objectId);
			sqlQuery.SetParameter<long>("Recipient", recUserId);
			sqlQuery.SetParameter("ReadDate", (object)now, (IType)(object)NHibernateUtil.DateTime);
			int feedSaveTimeout = FeedSaveTimeout();
			int retryCount = FeedSaveAttemptCount();
			TransformationProvider.RetryOnDeadlock(delegate
			{
				UnitOfWorkManager.Execute((Action)delegate
				{
					base.Session.ExecuteWithTimeout(feedSaveTimeout, delegate
					{
						sqlQuery.ExecuteUpdate(cleanUpCache: false);
					});
				});
			}, retryCount);
			LogInfo("FeedSetAsReadForObject", "End", logKey);
		}
		ResetUnreadedMessagesCountCache(recUserId);
		UpdateFeedInAgent(recUserId);
	}

	protected void SetBLOBUserFeedSettings<T>(string key, T settings)
	{
		BLOBManager.SetBLOB(FeedSettingsUid, key, settings);
	}

	protected T GetBLOBUserFeedSettings<T>(string key, T defaultValue)
	{
		object bLOB = BLOBManager.GetBLOB<object>(FeedSettingsUid, key);
		if (bLOB == null)
		{
			return defaultValue;
		}
		return (T)bLOB;
	}

	protected string GetFeedPriorityBlobKey(EleWise.ELMA.Security.Models.IUser user)
	{
		return $"{PriorityBLOBKey}_{user.Id}";
	}

	public FeedPriority GetPriority(EleWise.ELMA.Security.Models.IUser user)
	{
		return GetBLOBUserFeedSettings(GetFeedPriorityBlobKey(user), FeedPriority.Normal);
	}

	[Transaction]
	public virtual void SetPriority(EleWise.ELMA.Security.Models.IUser user, FeedPriority priority)
	{
		SetBLOBUserFeedSettings(GetFeedPriorityBlobKey(user), priority);
		ResetUnreadedMessagesCountCache(user);
	}

	public FeedCounter[] GetUnreadCount(EleWise.ELMA.Security.Models.IUser user = null)
	{
		user = user ?? CurrentUser;
		string key = CounterCacheKey(user);
		FeedCounter[] result;
		if (CacheService != null && (result = CacheService.Get<FeedCounter[]>(key, "FeedManager.GetUnreadCount-Region")) != null)
		{
			return result;
		}
		IQuery obj = base.Session.GetNamedQuery("ExecFeedGetUnreadCount").CleanUpCache(cleanUpCache: false).SetParameter<long>("Recipient", user.Id)
			.SetParameter("Priority", (object)(int)GetPriority(user), (IType)(object)NHibernateUtil.Int32);
		Guid logKey = LogInfo("FeedGetUnreadCount", $"Begin: Recipient={user.Id}");
		result = obj.SetResultTransformer((IResultTransformer)(object)new FeedCounterResultTransformer()).List<FeedCounter>().ToArray();
		LogInfo("FeedGetUnreadCount", "End", logKey);
		if (CacheService != null)
		{
			CacheService.Insert(key, result, "FeedManager.GetUnreadCount-Region");
		}
		return result;
	}

	public void ResetUnreadedMessagesCountCacheForAllUsers()
	{
		CacheService.ClearRegion("FeedManager.GetUnreadCount-Region");
	}

	public void ResetUnreadedMessagesCountCache(EleWise.ELMA.Security.Models.IUser user = null)
	{
		if (CacheService != null)
		{
			string key = CounterCacheKey(user);
			CacheService.Remove(key, "FeedManager.GetUnreadCount-Region");
		}
	}

	public void ResetUnreadedMessagesCountCache(long userId)
	{
		if (CacheService != null)
		{
			string key = CounterCacheKey(userId);
			CacheService.Remove(key, "FeedManager.GetUnreadCount-Region");
		}
	}

	private static string CounterCacheKey(EleWise.ELMA.Security.Models.IUser user = null)
	{
		return CounterCacheKey((user ?? CurrentUser).Id);
	}

	private static string CounterCacheKey(long userId)
	{
		return string.Format("{0}:{1}", "FeedManager.GetUnreadCount", userId);
	}

	[Transaction]
	internal virtual void IndexesEnable(Guid logKey = default(Guid))
	{
		IBLOBDataManager bLOBManager = DataAccessManager.BLOBManager;
		if ((!bLOBManager.GetBLOB<bool?>(MessagesConstants.AssemblyUid, "FeedToArchiveIdxDisabled")) ?? true)
		{
			return;
		}
		using (StartInformation.Operation(StartInformation.Current.Percent, SR.M("Пересчёт индексов для ленты сообщений")))
		{
			logKey = LogInfo("FeedToArchive", "IndexesEnable-Start", logKey);
			(from p in ComponentManager.Current.GetExtensionPoints<IFeedIndexesExtension>().ToList()
				where p.IsSupport(TransformationProvider.Uid)
				select p).ForEach(delegate(IFeedIndexesExtension p)
			{
				p.Enable();
			});
			bLOBManager.RemoveBLOB<bool?>(MessagesConstants.AssemblyUid, "FeedToArchiveIdxDisabled");
			LogInfo("FeedToArchive", "IndexesEnable-End", logKey);
		}
	}

	[Transaction]
	internal virtual void IndexesDisable(Guid logKey = default(Guid))
	{
		logKey = LogInfo("FeedToArchive", "IndexesDisable-Start", logKey);
		DataAccessManager.BLOBManager.SetBLOB(MessagesConstants.AssemblyUid, "FeedToArchiveIdxDisabled", (bool?)true);
		(from p in ComponentManager.Current.GetExtensionPoints<IFeedIndexesExtension>().ToList()
			where p.IsSupport(TransformationProvider.Uid)
			select p).ForEach(delegate(IFeedIndexesExtension p)
		{
			p.Disable();
		});
		LogInfo("FeedToArchive", "IndexesDisable-End", logKey);
	}

	public List<FeedModel> LoadFavoriteMessages(FeedFavoriteLoadSettings settings = null)
	{
		if (settings == null)
		{
			settings = new FeedFavoriteLoadSettings();
		}
		long id = (settings.Recipient ?? CurrentUser).Id;
		Guid logKey = LogInfo("LoadFavoriteMessages", $"Begin: Recipient={id}, ChangeDateHash={settings.ChangeDateHash}");
		List<FeedModel> result = base.Session.GetNamedQuery("ExecFeedFavoriteLoad").CleanUpCache(cleanUpCache: false).SetParameter<long>("Recipient", id)
			.SetParameter<string>("ChangeDateHash", settings.ChangeDateHash)
			.SetParameter<int>("MaxCount", settings.MaxCount)
			.SetResultTransformer((IResultTransformer)(object)new FeedResultTransformer(sort: false))
			.List<FeedModel>()
			.ToList();
		LogInfo("LoadFavoriteMessages", "End", logKey);
		return result;
	}

	public List<FeedModel> FindFavoriteMessages(FeedFavoriteLoadSettings settings = null, FeedFilter filter = null)
	{
		if (settings == null)
		{
			settings = new FeedFavoriteLoadSettings();
		}
		if (filter == null || filter.IsEmpty())
		{
			return LoadFavoriteMessages(settings);
		}
		string text = (string.IsNullOrEmpty(filter.SearchString) ? null : filter.SearchString.Trim());
		if (!string.IsNullOrEmpty(text))
		{
			text = $"%{filter.SearchString}%";
		}
		long id = (settings.Recipient ?? CurrentUser).Id;
		DateTime dateTime = (filter.ChangeDate.From.HasValue ? filter.ChangeDate.From.Value : ArchiveDateLimit());
		IQuery obj = base.Session.GetNamedQuery("ExecFeedFavoritsSearch").CleanUpCache(cleanUpCache: false).SetParameter<int>("MaxCount", settings.MaxCount)
			.SetParameter<long>("Recipient", id)
			.SetParameter<string>("ChangeDateHash", settings.ChangeDateHash)
			.SetParameter<string>("FastSearch", string.IsNullOrEmpty(text) ? null : text)
			.SetParameter<DateTime>("ChangeDateFrom", dateTime)
			.SetParameter<bool>("OnlyUnread", filter.OnlyUnread)
			.SetParameter<DateTime?>("ChangeDateTo", filter.ChangeDate.To)
			.SetParameter<string>("FeedAuthors", (filter.CreationAuthor != null) ? string.Join(",", filter.CreationAuthor.Select((EleWise.ELMA.Security.Models.IUser u) => u.Id)) : null);
		Guid logKey = LogInfo("FeedFavoriteSearch", $"Begin: Recipient={id}, ChangeDateHash={settings.ChangeDateHash}");
		List<FeedModel> result = obj.SetResultTransformer((IResultTransformer)(object)new FeedResultTransformer(sort: false)).List<FeedModel>().ToList();
		LogInfo("FeedFavoriteSearch", "FeedFavoriteSearch", logKey);
		return result;
	}

	[Transaction]
	public virtual void AddToFavorite(Guid objectUid, long objectId)
	{
		AddToFavorite(CurrentUser, objectUid, objectId);
	}

	[Transaction]
	public virtual void AddToFavorite(EleWise.ELMA.Security.Models.IUser recipient, Guid objectUid, long objectId)
	{
		AddToFavoriteInner(recipient.Id, objectUid, objectId);
		UpdateFeedInAgent(recipient);
	}

	[Transaction]
	public virtual void AddToFavorite(long recipientId, Guid objectUid, long objectId)
	{
		EleWise.ELMA.Security.Models.IUser user = UserManager.LoadOrNull(recipientId);
		if (user != null)
		{
			AddToFavorite(user, objectUid, objectId);
		}
	}

	private void AddToFavoriteInner(long recipientId, Guid objectUid, long objectId)
	{
		string lockName = $"FeedAddToFavorit_{recipientId}_{objectUid}_{objectId}";
		Guid logKey = LogInfo("AddToFavorite", $"Begin: Recipient={recipientId}, objectUid={objectUid}, objectId={objectId}");
		using (LockManager.Lock(lockName))
		{
			string text = FavoriteHash(recipientId, objectUid, objectId, allMessages: true);
			if (!text.IsNullOrEmpty() && text != "-")
			{
				LogInfo("AddToFavorite", "Exists", logKey);
				return;
			}
			DateTime now = DateTime.Now;
			if (text == "-")
			{
				TransformationProvider.Update("FeedFavorite", new string[2] { "IsDelete", "ChangeDateHash" }, new object[2]
				{
					0,
					now.Ticks.ToString("x16").ToLowerInvariant()
				}, string.Format("{0} = {1} and {2} = {3} and {4} = {5}ObjectUid", "Recipient", recipientId, "ActionObjectId", objectId, "ActionObjectUid", TransformationProvider.ParameterSeparator), new Dictionary<string, object> { { "ObjectUid", objectUid } });
				LogInfo("AddToFavorite", "Restore", logKey);
				return;
			}
			TransformationProvider.Insert("FeedFavorite", new string[5] { "Recipient", "ActionObjectUid", "ActionObjectId", "ChangeDateHash", "IsDelete" }, new object[5]
			{
				recipientId,
				objectUid,
				objectId,
				now.Ticks.ToString("x16").ToLowerInvariant(),
				0
			}, isNeedInsertId: true);
			LogInfo("AddToFavorite", "Insert", logKey);
		}
		LogInfo("AddToFavorite", "End", logKey);
	}

	[Transaction]
	public virtual void DeleteFromFavorite(Guid objectUid, long objectId)
	{
		DeleteFromFavorite(CurrentUser, objectUid, objectId);
	}

	[Transaction]
	public virtual void DeleteFromFavorite(EleWise.ELMA.Security.Models.IUser recipient, Guid objectUid, long objectId)
	{
		DeleteFromFavoriteInner(recipient.Id, new List<Pair<Guid, long>>
		{
			new Pair<Guid, long>(objectUid, objectId)
		});
		UpdateFeedInAgent(recipient);
	}

	[Transaction]
	public virtual void DeleteFromFavorite(long recipientId, Guid objectUid, long objectId)
	{
		EleWise.ELMA.Security.Models.IUser user = UserManager.LoadOrNull(recipientId);
		if (user != null)
		{
			DeleteFromFavorite(user, new List<Pair<Guid, long>>
			{
				new Pair<Guid, long>(objectUid, objectId)
			});
		}
	}

	[Transaction]
	public virtual void DeleteFromFavorite(EleWise.ELMA.Security.Models.IUser recipient, List<Pair<Guid, long>> objects)
	{
		DeleteFromFavoriteInner(recipient.Id, objects);
		UpdateFeedInAgent(recipient);
	}

	[Transaction]
	public virtual void DeleteFromFavorite(long recipientId, List<Pair<Guid, long>> objects)
	{
		EleWise.ELMA.Security.Models.IUser user = UserManager.LoadOrNull(recipientId);
		if (user != null)
		{
			DeleteFromFavorite(user, objects);
		}
	}

	private void DeleteFromFavoriteInner(long recipientId, List<Pair<Guid, long>> objects)
	{
		Guid logKey = LogInfo("DeleteFromFavorite", $"Begin: Recipient={recipientId}");
		Pair<string, Dictionary<string, object>> pair = CreateFavoritFilter(objects, TransformationProvider);
		DateTime now = DateTime.Now;
		TransformationProvider.Update("FeedFavorite", new string[2] { "IsDelete", "ChangeDateHash" }, new object[2]
		{
			1,
			now.Ticks.ToString("x16").ToLowerInvariant()
		}, string.Format("{0} = {1} and ({2})", TransformationProvider.Dialect.QuoteIfNeeded("Recipient"), recipientId, pair.First), pair.Second);
		LogInfo("DeleteFromFavorite", "End", logKey);
	}

	public bool IsFavorite(Guid objectUid, long objectId)
	{
		return IsFavorite(CurrentUser.Id, objectUid, objectId);
	}

	public bool IsFavorite(long recipientId, Guid objectUid, long objectId)
	{
		string text = FavoriteHash(objectUid, objectId);
		if (!text.IsNullOrEmpty())
		{
			return text != "-";
		}
		return false;
	}

	public string FavoriteHash(Guid objectUid, long objectId)
	{
		return FavoriteHash(CurrentUser.Id, objectUid, objectId);
	}

	public string FavoriteHash(EleWise.ELMA.Security.Models.IUser recipient, Guid objectUid, long objectId)
	{
		return FavoriteHash(recipient.Id, objectUid, objectId);
	}

	public string FavoriteHash(long recipientId, Guid objectUid, long objectId, bool allMessages = false)
	{
		Pair<Guid, long> pair = new Pair<Guid, long>(objectUid, objectId);
		return FavoriteHashList(recipientId, new List<Pair<Guid, long>> { pair }, allMessages)[pair];
	}

	public Dictionary<Pair<Guid, long>, string> FavoriteHashList(List<Pair<Guid, long>> objects)
	{
		return FavoriteHashList(CurrentUser.Id, objects);
	}

	public Dictionary<Pair<Guid, long>, string> FavoriteHashList(EleWise.ELMA.Security.Models.IUser recipient, List<Pair<Guid, long>> objects)
	{
		return FavoriteHashList(recipient.Id, objects);
	}

	public Dictionary<Pair<Guid, long>, string> FavoriteHashList(long recipientId, List<Pair<Guid, long>> objects, bool allMessages = false)
	{
		Dictionary<Pair<Guid, long>, string> result = new Dictionary<Pair<Guid, long>, string>();
		objects.Each(delegate(Pair<Guid, long> m)
		{
			result[m] = null;
		});
		if (!objects.Any())
		{
			return result;
		}
		Pair<string, Dictionary<string, object>> pair = CreateFavoritFilter(objects, TransformationProvider, "f");
		string sql = string.Format("select {7}.{0} {0}, {7}.{1} {1}, {7}.{2} {2}, {7}.{8} {8} from {3} where {7}.{4} = {5} {9} {6}", TransformationProvider.Dialect.QuoteIfNeeded("ChangeDateHash"), TransformationProvider.Dialect.QuoteIfNeeded("ActionObjectUid"), TransformationProvider.Dialect.QuoteIfNeeded("ActionObjectId"), TransformationProvider.NoLockTableExpression("FeedFavorite", "f"), TransformationProvider.Dialect.QuoteIfNeeded("Recipient"), recipientId, string.IsNullOrEmpty(pair.First) ? "" : $"and ({pair.First})", "f", TransformationProvider.Dialect.QuoteIfNeeded("IsDelete"), allMessages ? "" : string.Format(" and {0}.{1} = 0", "f", TransformationProvider.Dialect.QuoteIfNeeded("IsDelete")));
		using (IDataReader dataReader = TransformationProvider.ExecuteQuery(sql, pair.Second))
		{
			while (dataReader.Read())
			{
				string value = (Convert.ToBoolean(dataReader["IsDelete"]) ? "-" : dataReader["ChangeDateHash"].ToString());
				Guid guid = TransformationProvider.Dialect.GetGuid(dataReader["ActionObjectUid"]);
				int num = Convert.ToInt32(dataReader["ActionObjectId"]);
				Pair<Guid, long> key = new Pair<Guid, long>(guid, num);
				result[key] = value;
			}
		}
		return result;
	}

	private static Pair<string, Dictionary<string, object>> CreateFavoritFilter(IEnumerable<Pair<Guid, long>> objects, ITransformationProvider transform, string alias = "")
	{
		StringBuilder stringBuilder = new StringBuilder();
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (!string.IsNullOrEmpty(alias))
		{
			alias += ".";
		}
		foreach (Pair<Guid, long> @object in objects)
		{
			if (stringBuilder.Length != 0)
			{
				stringBuilder.Append(" or ");
			}
			string text = $"ActionObjectUid{dictionary.Count + 1}";
			dictionary.Add(text, @object.First);
			stringBuilder.Append(string.Format("({5}{0} = {1} and {5}{2} = {3}{4})", transform.Dialect.QuoteIfNeeded("ActionObjectId"), @object.Second, transform.Dialect.QuoteIfNeeded("ActionObjectUid"), transform.ParameterSeparator, text, alias));
		}
		return new Pair<string, Dictionary<string, object>>(stringBuilder.ToString(), dictionary);
	}

	public List<FeedMessageInfoModel> GetMessageInfoNew(FeedMessageInfoLoadSettings settings = null)
	{
		if (settings == null)
		{
			settings = new FeedMessageInfoLoadSettings();
		}
		long id = (settings.Recipient ?? CurrentUser).Id;
		Guid logKey = LogInfo("GetMessageInfoNew", $"Begin: Recipient={id}, ChangeDateHash={settings.ChangeDate}");
		List<FeedMessageInfoModel> result = base.Session.GetNamedQuery("ExecFeedInfoLoadNew").CleanUpCache(cleanUpCache: false).SetParameter<long>("Recipient", id)
			.SetParameter<DateTime?>("ChangeDate", settings.ChangeDate)
			.SetParameter<int>("MaxCount", settings.MaxCount)
			.SetResultTransformer((IResultTransformer)(object)new FeedMessageInfoTransformer())
			.List<FeedMessageInfoModel>()
			.ToList();
		LogInfo("GetMessageInfoNew", "End", logKey);
		return result;
	}

	public List<FeedMessageInfoModel> GetMessageInfo(List<long> messages, long? recipientId = null)
	{
		if (messages == null || !messages.Any())
		{
			return new List<FeedMessageInfoModel>();
		}
		long num = recipientId ?? CurrentUser.Id;
		string arg = string.Join(",", messages);
		string text = string.Join(",", messages.Select((long item, int i) => $"{TransformationProvider.ParameterSeparator}u{i}"));
		Dictionary<string, object> dictionary = new Dictionary<string, object> { { "recipient", num } };
		int num2 = 0;
		foreach (long message in messages)
		{
			dictionary.Add("u" + num2, message);
			num2++;
		}
		Guid logKey = LogInfo("GetMessageInfo", $"Begin: Recipient={num}, messages={arg}");
		string sql = string.Format("\r\nselect\r\n\ti.{0} {0}, i.{1} {1}, i.{2} {2}, i.{3} {3}, i.{4} {4}, i.{5}\r\nfrom {6}\r\ninner join (\r\n\tselect\r\n\t\ti1.{1}, i1.{2}, i1.{3}, MAX(i1.{4}) {4}\r\n\tfrom {7}\r\n\tinner join (\r\n\t\t\tselect t.{8}, t.{9}\r\n\t\t\tfrom {10}\r\n\t\t\twhere t.{0} in ({11})\r\n\t) f on f.{8} = i1.{1} and f.{9} = i1.{2}\r\n\twhere i1.{3} = {12}recipient\r\n\tgroup by i1.{1}, i1.{2}, i1.{3}\r\n) f on\r\n\tf.{1} = i.{1}\r\n\tand f.{2} = i.{2}\r\n\tand f.{3} = i.{3}\r\n\tand f.{4} = i.{4}\r\n", TransformationProvider.Dialect.QuoteIfNeeded("Id"), TransformationProvider.Dialect.QuoteIfNeeded("ActionObjectUid"), TransformationProvider.Dialect.QuoteIfNeeded("ActionObjectId"), TransformationProvider.Dialect.QuoteIfNeeded("Recipient"), TransformationProvider.Dialect.QuoteIfNeeded("ChangeDate"), TransformationProvider.Dialect.QuoteIfNeeded("Data"), TransformationProvider.NoLockTableExpression("FeedInfo", "i"), TransformationProvider.NoLockTableExpression("FeedInfo", "i1"), TransformationProvider.Dialect.QuoteIfNeeded("ParentObjectUid"), TransformationProvider.Dialect.QuoteIfNeeded("ParentObjectId"), TransformationProvider.NoLockTableExpression("Feed", "t"), text, TransformationProvider.ParameterSeparator);
		List<FeedMessageInfoModel> list = new List<FeedMessageInfoModel>();
		using (IDataReader dataReader = TransformationProvider.ExecuteQuery(sql, dictionary))
		{
			while (dataReader.Read())
			{
				FeedMessageInfoModel item2 = new FeedMessageInfoModel
				{
					Id = ((!(dataReader["Id"] is DBNull)) ? dataReader.GetInt64(dataReader.GetOrdinal("Id")) : 0),
					ActionObjectUid = ((!(dataReader["ActionObjectUid"] is DBNull)) ? TransformationProvider.Dialect.GetGuid(dataReader[dataReader.GetOrdinal("ActionObjectUid")]) : Guid.Empty),
					ActionObjectId = ((!(dataReader["ActionObjectId"] is DBNull)) ? dataReader.GetInt64(dataReader.GetOrdinal("ActionObjectId")) : 0),
					ChangeDate = ((!(dataReader["ChangeDate"] is DBNull)) ? dataReader.GetDateTime(dataReader.GetOrdinal("ChangeDate")) : DateTime.Now),
					Recipient = ((!(dataReader["Recipient"] is DBNull)) ? dataReader.GetInt64(dataReader.GetOrdinal("Recipient")) : 0),
					Data = ClassSerializationHelper.DeserializeObjectByJson<List<WebData>>(Encoding.UTF8.GetString((!(dataReader["Data"] is DBNull)) ? dataReader.GetBytes(dataReader.GetOrdinal("Data")) : new byte[0]))
				};
				list.Add(item2);
			}
		}
		LogInfo("GetMessageInfo", "End", logKey);
		return list;
	}

	internal void AddMessageInfo(FeedMessageInfoParameters info)
	{
		List<IFeedMessageGetData> list = (from m in ComponentManager.Current.GetExtensionPoints<IFeedMessageGetData>()
			where m.IsSupport(info.ObjectUid, info.ActionUid)
			select m).ToList();
		if (!list.Any())
		{
			return;
		}
		Dictionary<long, List<WebData>> dataList = (from m in info.Recipients
			group m by m).ToDictionary((IGrouping<long, long> m) => m.Key, (IGrouping<long, long> m) => new List<WebData>());
		foreach (IFeedMessageGetData item in list)
		{
			Dictionary<long, List<WebDataItem>> dictionary = (from m in item.GetData(info, info.Recipients.ToList())
				group m.Second by m.First).ToDictionary((IGrouping<long, List<WebDataItem>> m) => m.Key, (IGrouping<long, List<WebDataItem>> m) => m.SelectMany((List<WebDataItem> m1) => m1).ToList());
			foreach (long item2 in dictionary.Keys.Where((long k) => info.Recipients.Any((long r) => r == k)).ToList())
			{
				dataList[item2].Add(new WebData
				{
					Value = item.Name,
					Items = dictionary[item2].ToArray()
				});
			}
		}
		Guid guid = LogInfo("AddInfo", $"Begin: objectUid={info.ObjectUid}, objectId={info.ObjectId}, actionUid={info.ActionUid}");
		try
		{
			DateTime now = DateTime.Now;
			foreach (long item3 in info.Recipients.Where((long r) => dataList.Keys.Any((long k) => k == r)).ToList())
			{
				string s = ClassSerializationHelper.SerializeObjectByJson(dataList[item3]);
				TransformationProvider.Insert("FeedInfo", new string[5] { "Recipient", "ActionObjectUid", "ActionObjectId", "ChangeDate", "Data" }, new object[5]
				{
					item3,
					info.ObjectUid,
					info.ObjectId,
					now,
					Encoding.UTF8.GetBytes(s)
				}, isNeedInsertId: true);
				LogInfo("AddInfo", $"Insert: recipient={item3}", guid);
			}
		}
		catch (Exception exception)
		{
			Logger.Error($"AddInfo ({guid}): Error: ", exception);
			throw;
		}
		LogInfo("AddInfo", "End", guid);
	}

	internal void ClearOldMessageInfo()
	{
		Guid logKey = LogInfo("ClearOldMessageInfo", "Begin");
		string sql = string.Format("\r\ndelete from {0}\r\nwhere exists (\r\n\tselect aId from (\r\n\t\tselect\r\n\t\t\tmax(i.{1}) aId, i.{2} aActionObjectId, i.{3} aActionObjectUid, i.{4} aRecipient\r\n\t\tfrom {5}\r\n\t\tgroup by i.{2}, i.{3}, i.{4}\r\n\t\thaving count (i.{1}) > 1\r\n\t) a\r\n\twhere aId <> {0}.{1}\r\n        and aActionObjectId = {0}.{2}\r\n        and aActionObjectUid = {0}.{3}\r\n        and aRecipient = {0}.{4}\r\n)\r\n", TransformationProvider.Dialect.QuoteIfNeeded("FeedInfo"), TransformationProvider.Dialect.QuoteIfNeeded("Id"), TransformationProvider.Dialect.QuoteIfNeeded("ActionObjectId"), TransformationProvider.Dialect.QuoteIfNeeded("ActionObjectUid"), TransformationProvider.Dialect.QuoteIfNeeded("Recipient"), TransformationProvider.NoLockTableExpression("FeedInfo", "i"));
		TransformationProvider.ExecuteNonQuery(sql);
		LogInfo("ClearOldMessageInfo", "End", logKey);
	}

	internal long[] GetReadedPostsIds(DateTime fromDate)
	{
		IQuery obj = base.Session.GetNamedQuery("ExecFeedGetReadedPostsIds").CleanUpCache(cleanUpCache: false).SetParameter<long>("Recipient", CurrentUser.Id)
			.SetParameter<bool>("IsRead", true)
			.SetParameter<DateTime?>("FromDate", (fromDate > DateTime.FromOADate(0.0)) ? new DateTime?(fromDate) : null);
		Guid logKey = LogInfo("FeedGetReadedPostsIds", $"Begin: Recipient={CurrentUser.Id}");
		IList list = obj.List();
		LogInfo("FeedGetReadedPostsIds", "End", logKey);
		List<long> list2 = new List<long>();
		foreach (object item in list)
		{
			if (long.TryParse(item.ToString(), out var result))
			{
				list2.Add(result);
			}
		}
		return list2.ToArray();
	}

	internal List<FeedModel> LoadMessagesNew(FeedLoadSettings settings = null, bool onlyUnread = false)
	{
		if (settings == null)
		{
			settings = new FeedLoadSettings();
		}
		long id = (settings.Recipient ?? CurrentUser).Id;
		string text = (string.IsNullOrEmpty(settings.ChangeDateHash) ? null : settings.ChangeDateHash.ToLowerInvariant());
		IQuery obj = base.Session.GetNamedQuery("ExecFeedLoadNew").CleanUpCache(cleanUpCache: false).SetParameter<string>("ChangeDateHash", text)
			.SetParameter<long>("Recipient", id)
			.SetParameter<int>("MaxChildCount", settings.MaxChildCount)
			.SetParameter<int>("MaxCount", settings.MaxCount)
			.SetParameter<bool>("AllMessages", !onlyUnread);
		Guid logKey = LogInfo("FeedLoadNew", $"Begin: Recipient={id}, ChangeDateHash={text}");
		List<FeedModel> result = obj.SetResultTransformer((IResultTransformer)(object)new FeedResultTransformer()).List<FeedModel>().ToList();
		LogInfo("FeedLoadNew", "End", logKey);
		return result;
	}

	internal FeedModel LoadMessage(long messageId)
	{
		IQuery obj = base.Session.GetNamedQuery("ExecFeedMessageLoad").CleanUpCache(cleanUpCache: false).SetParameter<long>("Id", messageId);
		Guid logKey = LogInfo("FeedMessageLoad", $"Begin: Id={messageId}");
		FeedModel result = obj.SetResultTransformer((IResultTransformer)(object)new FeedResultTransformer()).UniqueResult<FeedModel>();
		LogInfo("FeedMessageLoad", "End", logKey);
		return result;
	}

	internal FeedModel LoadMessage(long parentObjectId, Guid parentObjectUid, long recipientId)
	{
		string text = "f";
		string text2 = ":";
		IQuery obj = ((IQuery)(object)base.Session.CreateSQLQuery(string.Format("select {0}.* from {1} where {0}.{3} = {2}parentObjectId and {0}.{4} = {2}parentObjectUid and {0}.{5} = {2}recipientId order by f.{6} desc, f.{7} desc", text, TransformationProvider.NoLockTableExpression("Feed", text), text2, TransformationProvider.Dialect.QuoteIfNeeded("ParentObjectId"), TransformationProvider.Dialect.QuoteIfNeeded("ParentObjectUid"), TransformationProvider.Dialect.QuoteIfNeeded("Recipient"), TransformationProvider.Dialect.QuoteIfNeeded("IsParent"), TransformationProvider.Dialect.QuoteIfNeeded("ChangeDateHash")))).CleanUpCache(cleanUpCache: false).SetParameter<long>("parentObjectId", parentObjectId).SetParameter<Guid>("parentObjectUid", parentObjectUid)
			.SetParameter<long>("recipientId", recipientId);
		Guid logKey = LogInfo("FeedMessageLoad", $"Begin: Id={parentObjectId}");
		FeedModel result = obj.SetResultTransformer((IResultTransformer)(object)new FeedResultTransformer()).UniqueResult<FeedModel>();
		LogInfo("FeedMessageLoad", "End", logKey);
		return result;
	}

	internal FeedModel[] LoadMessages(long[] ids)
	{
		if (ids == null)
		{
			throw new ArgumentNullException("ids");
		}
		if (ids.Length == 0)
		{
			return new FeedModel[0];
		}
		IQuery obj = base.Session.GetNamedQuery("ExecFeedLoadMessages").CleanUpCache(cleanUpCache: false).SetParameter("Ids", (object)string.Join(",", ids), (IType)(object)NHibernateUtil.StringClob);
		Guid logKey = LogInfo("FeedLoadMessages", "Begin");
		FeedModel[] result = obj.SetResultTransformer((IResultTransformer)(object)new FeedResultTransformer()).List<FeedModel>().ToArray();
		LogInfo("FeedLoadMessages", "End", logKey);
		return result;
	}

	internal List<FeedFavoriteModel> LoadFavoritesNew(FeedFavoriteLoadSettings settings)
	{
		if (settings == null)
		{
			settings = new FeedFavoriteLoadSettings();
		}
		bool flag = !settings.ChangeDateHash.IsNullOrEmpty();
		long id = (settings.Recipient ?? CurrentUser).Id;
		string text = (string.IsNullOrEmpty(settings.ChangeDateHash) ? null : settings.ChangeDateHash.ToLowerInvariant());
		IQuery obj = base.Session.GetNamedQuery("ExecFeedFavoriteLoadNew").CleanUpCache(cleanUpCache: false).SetParameter<string>("ChangeDateHash", text)
			.SetParameter<long>("Recipient", id)
			.SetParameter<int>("MaxCount", settings.MaxCount)
			.SetParameter<bool>("AllMessages", flag);
		Guid logKey = LogInfo("FeedLoadFavoritesNew", $"Begin: Recipient={id}, ChangeDateHash={text}, delete={flag}");
		List<FeedFavoriteModel> result = obj.SetResultTransformer((IResultTransformer)(object)new FeedFavoriteResultTransformer()).List<FeedFavoriteModel>().ToList();
		LogInfo("FeedLoadFavoritesNew", "End", logKey);
		return result;
	}

	private void UpdateFeedInAgent(long recipientId)
	{
		EleWise.ELMA.Security.Models.IUser recipient = UserManager.LoadOrNull(recipientId);
		UpdateFeedInAgent(recipient);
	}

	private void UpdateFeedInAgent(EleWise.ELMA.Security.Models.IUser recipient)
	{
		if (recipient == null)
		{
			throw new ArgumentException(SR.T("Не удаётся найти получателя сообщения."));
		}
		AgentHubService.Send(recipient, "FeedMessage", "");
	}
}
