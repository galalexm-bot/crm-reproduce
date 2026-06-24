using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.IO;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using Iesi.Collections.Generic;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;

namespace EleWise.ELMA.Messages.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class ChannelMessageManager : EntityManager<IChannelMessage, long>
{
	protected Guid ChannelMessageSettingsUid = new Guid("{BDDF06BE-FF0E-4414-B44B-07B069FB8175}");

	private AttachmentManager attachmentManager;

	protected string PriorityBLOBKey = "Priority";

	public new static ChannelMessageManager Instance => Locator.GetServiceNotNull<ChannelMessageManager>();

	protected IBLOBDataManager BLOBManager => DataAccessManager.BLOBManager;

	private AttachmentManager AttachmentManager => attachmentManager ?? (attachmentManager = AttachmentManager.Instance);

	private IFileManager FileManager => DataAccessManager.FileManager;

	[NotNull]
	public ICommentActionHandler CommentActionHandler { get; set; }

	protected void SetBLOBUserFeedPriority<T>(string key, T settings)
	{
		BLOBManager.SetBLOB(ChannelMessageSettingsUid, key, settings);
	}

	protected T GetBLOBUserFeedPriority<T>(string key, T defaultValue)
	{
		object bLOB = BLOBManager.GetBLOB<object>(ChannelMessageSettingsUid, key);
		if (bLOB == null)
		{
			return defaultValue;
		}
		return (T)bLOB;
	}

	protected string GetFeedPriorityBlobKey(EleWise.ELMA.Security.Models.IUser user, long infoChannelId)
	{
		return $"{PriorityBLOBKey}_{infoChannelId}_{user.Id}";
	}

	public FeedPriority GetPriority(EleWise.ELMA.Security.Models.IUser user, long infoChannelId)
	{
		IInformationChannel channel = null;
		Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
		{
			channel = InformationChannelManager.Instance.LoadOrNull(infoChannelId);
		});
		return GetPriority(user, channel);
	}

	public FeedPriority GetPriority(EleWise.ELMA.Security.Models.IUser user, IInformationChannel infoChannel)
	{
		return GetBLOBUserFeedPriority(GetFeedPriorityBlobKey(user, infoChannel.Id), infoChannel.FeedPriority);
	}

	public void SetPriority(EleWise.ELMA.Security.Models.IUser user, FeedPriority priority, long infoChannelId)
	{
		SetBLOBUserFeedPriority(GetFeedPriorityBlobKey(user, infoChannelId), priority);
	}

	public bool HasComment(IBaseMessage message)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		return HasComment(message, currentUser);
	}

	private bool HasComment(IBaseMessage message, EleWise.ELMA.Security.Models.IUser user)
	{
		if (!HasView(message, user))
		{
			return false;
		}
		if (message.CreationAuthor.Id == user.Id)
		{
			return true;
		}
		if (((IEnumerable<EleWise.ELMA.Security.Models.IUser>)message.Recipients).Any((EleWise.ELMA.Security.Models.IUser r) => r != null && r.Id == user.Id))
		{
			return true;
		}
		if (message is IChannelMessage channelMessage && ((IEnumerable<IInformationChannel>)channelMessage.Channels).Any((IInformationChannel ch) => ch != null && ch.IsCommentable && !ch.IsArchive && ch.IsActive && base.SecurityService.HasPermission(user, PermissionProvider.ChannelViewPermission, ch)))
		{
			return true;
		}
		return false;
	}

	public bool HasView(IBaseMessage message)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		return HasView(message, currentUser);
	}

	private bool HasView(IBaseMessage message, EleWise.ELMA.Security.Models.IUser user)
	{
		if (HasEdit(message, user))
		{
			return true;
		}
		if (((IEnumerable<EleWise.ELMA.Security.Models.IUser>)message.Recipients).Any((EleWise.ELMA.Security.Models.IUser r) => r.Id == user.Id))
		{
			return true;
		}
		if (message is IChannelMessage message2)
		{
			return UsersPermissionsChannelMessage(message2, PermissionProvider.ChannelViewPermission, user);
		}
		return false;
	}

	public bool HasEdit(IBaseMessage message)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		return HasEdit(message, currentUser);
	}

	private bool HasEdit(IBaseMessage message, EleWise.ELMA.Security.Models.IUser user)
	{
		if (HasFullAccess(message, user))
		{
			return true;
		}
		if (message is IChannelMessage message2 && UsersPermissionsChannelMessage(message2, PermissionProvider.ChannelEditPermission, user))
		{
			return true;
		}
		return false;
	}

	public bool HasFullAccess(IBaseMessage message)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		return HasFullAccess(message, currentUser);
	}

	private bool HasFullAccess(IBaseMessage message, EleWise.ELMA.Security.Models.IUser user)
	{
		if (user == null || message == null)
		{
			return false;
		}
		if (message.CreationAuthor.Id == user.Id)
		{
			return true;
		}
		if (message is IChannelMessage message2 && UsersPermissionsChannelMessage(message2, PermissionProvider.ChannelFullAccessPermission, user))
		{
			return true;
		}
		return false;
	}

	private bool UsersPermissionsChannelMessage(IChannelMessage message, Permission channelPermission, EleWise.ELMA.Security.Models.IUser user)
	{
		return ((IEnumerable<IInformationChannel>)message?.Channels).Any((IInformationChannel ch) => base.SecurityService.HasPermission(user, channelPermission, ch)) ?? false;
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		base.SetupFilter(criteria, filter);
		if (filter is IChannelMessageFilter channelMessageFilter)
		{
			if (channelMessageFilter.ChannelId.HasValue)
			{
				criteria.CreateAlias("Channels", "chs", (JoinType)0).Add((ICriterion)(object)Restrictions.Eq("chs.Id", (object)channelMessageFilter.ChannelId.Value));
			}
			if (channelMessageFilter.IsAnswer.HasValue)
			{
				criteria.Add((ICriterion)(object)(channelMessageFilter.IsAnswer.Value ? Restrictions.IsNotNull("Parent") : Restrictions.IsNull("Parent")));
			}
		}
	}

	public IEnumerable<IChannelMessage> LoadComments(long id, int loadedCommentsCount, int loadCommentsCount)
	{
		IEnumerable<IChannelMessage> enumerable = CreateCriteria().Add((ICriterion)(object)Restrictions.Eq("Parent.Id", (object)id)).AddOrder(Order.Desc("CreationDate")).SetFirstResult(loadedCommentsCount)
			.SetMaxResults(loadCommentsCount)
			.List<IChannelMessage>();
		if (Locator.GetServiceNotNull<IHistoryOrder>().GetOrderType(new HistoryIdParams
		{
			Id = id.ToString(),
			TypeUid = InterfaceActivator.UID<IChannelMessage>()
		}) == ListSortDirection.Ascending)
		{
			enumerable = enumerable.Reverse();
		}
		return enumerable;
	}

	[Transaction]
	public virtual void AddComment(IChannelMessage message, ICommentActionModel actionModel)
	{
		string text = actionModel.Comment.Text.Trim(" \t\r\n".ToCharArray());
		if (!string.IsNullOrEmpty(text))
		{
			actionModel.Comment.Text = text;
			IChannelMessage channelMessage = InterfaceActivator.Create<IChannelMessage>();
			channelMessage.Parent = message;
			channelMessage.MessageType = ChannelMessageType.Comment;
			channelMessage.FullMessage = actionModel.Comment.Text;
			ApplyCommentActionModel(channelMessage, actionModel);
			channelMessage.Channels = message.Channels;
			channelMessage.Recipients = message.Recipients;
			message.Messages.Add(channelMessage);
			message.Save();
		}
	}

	[Transaction]
	public virtual IChannelMessage AddComment(Guid channelMessageUid, string text)
	{
		string text2 = text.Trim(" \t\r\n".ToCharArray());
		if (string.IsNullOrEmpty(text2))
		{
			throw new Exception("Нельзя добавить пустой комментарий");
		}
		IChannelMessage channelMessage = LoadOrNull(channelMessageUid);
		if (channelMessage == null)
		{
			throw new Exception("Не найден пост для добавления комментария");
		}
		if (!HasComment(channelMessage))
		{
			throw new Exception("Недостаточно прав на работу с этим чатом");
		}
		ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
		commentActionModel.Comment = InterfaceActivator.Create<IComment>();
		commentActionModel.Comment.Text = text2;
		IChannelMessage channelMessage2 = InterfaceActivator.Create<IChannelMessage>();
		channelMessage2.Parent = channelMessage;
		channelMessage2.MessageType = ChannelMessageType.Comment;
		channelMessage2.FullMessage = commentActionModel.Comment.Text;
		ApplyCommentActionModel(channelMessage2, commentActionModel);
		channelMessage2.Channels = channelMessage.Channels;
		channelMessage2.Recipients = channelMessage.Recipients;
		channelMessage.Messages.Add(channelMessage2);
		channelMessage.Save();
		return channelMessage2;
	}

	[Auditable]
	protected virtual void ApplyCommentActionModel(IChannelMessage message, ICommentActionModel actionModel)
	{
		CommentActionHandler.Process(message, actionModel);
	}

	[Transaction]
	public virtual void UpdateChannelsAndRecipients(IChannelMessage channelMessage, ISet<IInformationChannel> channels, ISet<EleWise.ELMA.Security.Models.IUser> recipients, bool createAction = false)
	{
		bool flag = false;
		if (channels != null)
		{
			if (((ICollection<IInformationChannel>)channels).Count != ((ICollection<IInformationChannel>)channelMessage.Channels).Count || !channelMessage.Channels.ContainsAll((ICollection<IInformationChannel>)channels))
			{
				((ICollection<IInformationChannel>)channelMessage.Channels).Clear();
				channelMessage.Channels.AddAll((ICollection<IInformationChannel>)channels);
				flag = true;
			}
		}
		else
		{
			((ICollection<IInformationChannel>)channelMessage.Channels).Clear();
			flag = true;
		}
		if (recipients != null)
		{
			if (((ICollection<EleWise.ELMA.Security.Models.IUser>)recipients).Count != ((ICollection<EleWise.ELMA.Security.Models.IUser>)channelMessage.Recipients).Count || !channelMessage.Recipients.ContainsAll((ICollection<EleWise.ELMA.Security.Models.IUser>)recipients))
			{
				List<EleWise.ELMA.Security.Models.IUser> list = ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)recipients).Where((EleWise.ELMA.Security.Models.IUser r) => ((IEnumerable<EleWise.ELMA.Security.Models.IUser>)channelMessage.Recipients).All((EleWise.ELMA.Security.Models.IUser r2) => r2.Id != r.Id)).ToList();
				((ICollection<EleWise.ELMA.Security.Models.IUser>)channelMessage.Recipients).Clear();
				channelMessage.Recipients.AddAll((ICollection<EleWise.ELMA.Security.Models.IUser>)recipients);
				flag = true;
				if (createAction && list != null && list.Any())
				{
					EntityActionEventArgs entityActionEventArgs = new EntityActionEventArgs(null, channelMessage, "5d388b12-37e0-413b-b24b-d13cb57f4142");
					entityActionEventArgs.ExtendedProperties["NewRecipients"] = list.ToList();
					base.ActionHandler.ActionExecuted(entityActionEventArgs);
				}
			}
		}
		else
		{
			((ICollection<EleWise.ELMA.Security.Models.IUser>)channelMessage.Recipients).Clear();
			flag = true;
		}
		if (flag)
		{
			channelMessage.Save();
		}
		if (channelMessage.Messages == null)
		{
			return;
		}
		foreach (IChannelMessage item in (IEnumerable<IChannelMessage>)channelMessage.Messages)
		{
			UpdateChannelsAndRecipients(item, channels, recipients);
		}
	}

	public virtual IEnumerable<IChannelMessage> GetMessagesByDiscussion(long objectId, Guid objectType)
	{
		DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<IDiscussionObject>()).CreateAlias("Message", "msg", (JoinType)0).Add((ICriterion)(object)Restrictions.Eq("ObjectId", (object)objectId))
			.Add((ICriterion)(object)Restrictions.Eq("ObjectType", (object)objectType))
			.SetProjection((IProjection)(object)Projections.Property("msg.Id"));
		return CreateCriteria().Add((ICriterion)(object)Subqueries.PropertyIn("Id", val)).List<IChannelMessage>();
	}

	public void ProcessChannelAndSave(IChannelMessage message)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		ISecurityService securityService = Locator.GetServiceNotNull<ISecurityService>();
		foreach (IInformationChannel item in ((IEnumerable<IInformationChannel>)message.Channels).Where((IInformationChannel informationChannel) => !securityService.HasPermission(PermissionProvider.ChannelEditPermission, informationChannel)).ToList())
		{
			((ICollection<IInformationChannel>)message.Channels).Remove(item);
		}
		if (!((ICollection<EleWise.ELMA.Security.Models.IUser>)message.Recipients).Contains(currentUser))
		{
			message.Recipients.Add(currentUser);
		}
		message.Save();
	}

	[Transaction]
	public virtual void CreateTestMessage(string subject, string message, long attachmentSize)
	{
		IChannelMessage channelMessage = Create();
		channelMessage.Subject = subject;
		channelMessage.FullMessage = message;
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		channelMessage.Recipients.Add(currentUser);
		if (attachmentSize > 0)
		{
			BinaryFile file = CreateTestAttachment(attachmentSize);
			IAttachment attachment = AttachmentManager.Create(file);
			channelMessage.Attachments.Add(attachment);
		}
		EntityActionEventArgs e = new EntityActionEventArgs(null, channelMessage, "aacb60f1-ba29-49a8-909b-ccbfa5bab433");
		base.ActionHandler.ActionExecuted(e);
		channelMessage.Save();
	}

	private BinaryFile CreateTestAttachment(long contentLength)
	{
		Guid uid = GenerateGuidByContentLength(contentLength);
		try
		{
			if (uid.Equals(Guid.Empty))
			{
				throw new Exception(SR.T("Не удалось сформировать уникальный идентификатор для файла тестового вложения"));
			}
			BinaryFile binaryFile = FileManager.LoadFile(uid.ToString());
			if (binaryFile == null || binaryFile.GetSize() <= 0)
			{
				throw new FileNotFoundException();
			}
			return binaryFile;
		}
		catch (FileNotFoundException)
		{
			base.Logger.Log(LogLevel.Information, null, SR.T("Файл тествого вложения не найден и будет создан новый"));
			BinaryFile binaryFile = BinaryFile.CreateNew().Uid(uid).Name(SR.T("Данные.dat"))
				.ContentType("application/octet-stream")
				.Content(new byte[contentLength])
				.Build();
			FileManager.SaveFile(binaryFile);
			return binaryFile;
		}
		catch (Exception ex2)
		{
			base.Logger.Log(LogLevel.Error, ex2, ex2.Message);
			throw ex2;
		}
	}

	private Guid GenerateGuidByContentLength(long contentLength)
	{
		try
		{
			if (Guid.TryParse(EncryptionHelper.GetMd5Hash(contentLength.ToString()), out var result))
			{
				return result;
			}
			return Guid.Empty;
		}
		catch (Exception ex)
		{
			base.Logger.Log(LogLevel.Error, ex, SR.T("Не удалось преобразовать размер вложения к уникальному идентификатору файла: {0}", ex.Message));
			return Guid.Empty;
		}
	}

	public List<MessageObject> DiscussionObjectsToMessageObjects(List<IDiscussionObject> discussionObjects)
	{
		List<MessageObject> messageObjects = (from o in discussionObjects.Select((IDiscussionObject o) => new
			{
				TypeUid = o.ObjectType,
				Id = o.ObjectId.ToString(CultureInfo.InvariantCulture)
			}).Distinct()
			select new MessageObject(null, o.TypeUid, o.Id)).ToList();
		ComponentManager.Current.GetExtensionPoints<IChannelMessageObjectsExtension>().ForEach(delegate(IChannelMessageObjectsExtension p)
		{
			List<MessageObject> list = messageObjects.Where((MessageObject m) => string.IsNullOrEmpty(m.Name) && p.IsSupport(m.TypeUid)).ToList();
			if (list.Any())
			{
				list = p.UpdateMessageObjectsNames(list);
				list.ForEach(delegate(MessageObject m)
				{
					int num = messageObjects.FindIndex((MessageObject o) => o.Id == m.Id && o.TypeUid == m.TypeUid);
					if (num != -1)
					{
						messageObjects[num] = m;
					}
				});
			}
		});
		return messageObjects;
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void AddMessageToInfoChannel(string messageSubject, string messageText, IInformationChannel infoChannel, EleWise.ELMA.Security.Models.IUser messageAuthor)
	{
		IChannelMessage channelMessage = InterfaceActivator.Create<IChannelMessage>();
		channelMessage.CreationAuthor = messageAuthor ?? base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		channelMessage.Subject = messageSubject;
		channelMessage.FullMessage = messageText;
		channelMessage.Channels.Add(infoChannel);
		infoChannel.Messages.Add(channelMessage);
		infoChannel.Save();
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual void AddMessageToInfoChannel(string messageSubject, string messageText, IInformationChannel infoChannel)
	{
		AddMessageToInfoChannel(messageSubject, messageText, infoChannel, null);
	}

	[PublicApiMember]
	[PublicApiNodeId("MessagesPortalApi")]
	public virtual IInformationChannel FindInformationChannel(string chanelName)
	{
		IInformationChannelFilter informationChannelFilter = InterfaceActivator.Create<IInformationChannelFilter>();
		informationChannelFilter.Name = chanelName;
		ICollection<IInformationChannel> collection = EntityManager<IInformationChannel>.Instance.Find(informationChannelFilter, null);
		if (collection != null && collection.Count > 1)
		{
			throw new Exception("Найдено больше одного инфоканала");
		}
		if (collection == null || !collection.Any())
		{
			return null;
		}
		return collection.FirstOrDefault();
	}
}
