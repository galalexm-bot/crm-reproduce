using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Security.Extensions;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Extensions;
using EleWise.ELMA.Messages.Web.Models;
using EleWise.ELMA.Messages.Web.Services;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.Grids;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Models.Trees;
using EleWise.ELMA.Web.Mvc.Security;
using Iesi.Collections.Generic;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Messages.Web.Controllers;

[Permission("258BBEBC-006B-46FB-80AC-B36456A191E9")]
public class ChannelMessageController : BPMController<IChannelMessage, long>
{
	public const int MaxVisibleComments = 10;

	public IObjectAttachmentsArchiveService ObjectAttachmentsArchiveService { get; set; }

	public IEnumerable<IObjectAttachmentExtension> ObjectAttachmentExtensions { get; set; }

	private static EleWise.ELMA.Security.Models.IUser CurrentUser => Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();

	public static FeedPriority CurrentPriority(long? infoChannelId)
	{
		if (!infoChannelId.HasValue)
		{
			return FeedPriority.Lowest;
		}
		return ChannelMessageManager.Instance.GetPriority(CurrentUser, infoChannelId.Value);
	}

	public ActionResult AddMessageSelectorWindow(string gridId, string channelId, string userId = null)
	{
		MessageList messageList = new MessageList
		{
			GridId = gridId,
			BaseMessageFilter = InterfaceActivator.Create<IBaseMessageFilter>()
		};
		if (!string.IsNullOrEmpty(channelId))
		{
			messageList.BaseMessageFilter.ChannelId = long.Parse(channelId);
		}
		if (!string.IsNullOrEmpty(userId))
		{
			messageList.BaseMessageFilter.RecipientId = long.Parse(userId);
		}
		return (ActionResult)(object)((Controller)this).PartialView("AddChannelMessageWindow", (object)messageList);
	}

	public static void InitChannelMessageViewInfo(ChannelMessageViewInfo model, long[] channels, long[] recipients = null, bool forAll = false, bool forDepartment = false)
	{
		if (channels != null && channels.Length != 0)
		{
			IInformationChannelFilter informationChannelFilter = InterfaceActivator.Create<IInformationChannelFilter>();
			informationChannelFilter.Ids = channels.ToList();
			informationChannelFilter.IsArchive = false;
			informationChannelFilter.IsActive = true;
			informationChannelFilter.PermissionId = PermissionProvider.ChannelEditPermission.Id;
			model.Message.Channels.AddAll((ICollection<IInformationChannel>)InformationChannelManager.Instance.Find(informationChannelFilter, FetchOptions.All).ToList());
		}
		if (forAll || forDepartment)
		{
			IUserFilter userFilter = InterfaceActivator.Create<IUserFilter>();
			userFilter.ShowBlock = false;
			userFilter.ShowOnlySubordinateAndSelf = forDepartment;
			ICollection<EleWise.ELMA.Security.Models.IUser> collection = UserManager.Instance.Find(userFilter, FetchOptions.All);
			model.Message.Recipients.AddAll(collection);
		}
		else if (recipients != null && recipients.Length != 0)
		{
			model.Message.Recipients.AddAll(UserManager.Instance.FindByIdArray(recipients));
		}
		model.UpdateChannels();
	}

	[HttpGet]
	public ActionResult EditForm(string popupId, string callback, long[] channels, long[] recipients = null, long[] objectIdsForDiscussion = null, Guid[] objectTypesForDiscussion = null, bool? ajaxSubmit = false, string subject = null, bool forAll = false, bool forDepartment = false, string beforeSubmitScript = null)
	{
		ChannelMessageViewInfo channelMessageViewInfo = new ChannelMessageViewInfo
		{
			Message = InterfaceActivator.Create<IChannelMessage>(),
			PopupId = popupId,
			Callback = callback,
			AjaxSubmit = (!ajaxSubmit.HasValue || ajaxSubmit.Value),
			BeforeSubmitScript = beforeSubmitScript
		};
		if (objectIdsForDiscussion != null && objectTypesForDiscussion != null && objectIdsForDiscussion.Length == objectTypesForDiscussion.Length)
		{
			for (int i = 0; i < objectIdsForDiscussion.Length; i++)
			{
				ISet<IDiscussionObject> discussionObjects = channelMessageViewInfo.Message.DiscussionObjects;
				InstanceOf<IDiscussionObject> instanceOf = new InstanceOf<IDiscussionObject>();
				instanceOf.New.ObjectId = objectIdsForDiscussion[i];
				instanceOf.New.ObjectType = objectTypesForDiscussion[i];
				discussionObjects.Add(instanceOf.New);
			}
		}
		InitChannelMessageViewInfo(channelMessageViewInfo, channels, recipients, forAll, forDepartment);
		if (!string.IsNullOrEmpty(subject))
		{
			channelMessageViewInfo.Message.Subject = subject;
		}
		return (ActionResult)(object)((Controller)this).PartialView((object)channelMessageViewInfo);
	}

	public static void ProcessChannelMessage(ChannelMessageViewInfo info)
	{
		foreach (IDiscussionObject item in (IEnumerable<IDiscussionObject>)info.Message.DiscussionObjects)
		{
			item.Message = info.Message;
		}
		if (!info.IsDiscussion)
		{
			ChannelMessageManager.Instance.ProcessChannelAndSave(info.Message);
			return;
		}
		EleWise.ELMA.Security.Models.IUser currentUser = CurrentUser;
		IDiscussion discussion = InterfaceActivator.Create<IDiscussion>();
		if (info.Message.Attachments != null)
		{
			discussion.Attachments.AddAll((ICollection<IAttachment>)info.Message.Attachments);
		}
		if (info.Message.Recipients != null)
		{
			discussion.Recipients.AddAll((ICollection<EleWise.ELMA.Security.Models.IUser>)info.Message.Recipients);
		}
		if (!((ICollection<EleWise.ELMA.Security.Models.IUser>)discussion.Recipients).Contains(currentUser))
		{
			discussion.Recipients.Add(currentUser);
		}
		discussion.FullMessage = info.Message.FullMessage;
		if (info.Message.Channels != null)
		{
			discussion.Channels.AddAll((ICollection<IInformationChannel>)info.Message.Channels);
		}
		discussion.Subject = info.Message.Subject;
		discussion.MessageType = ChannelMessageType.Post;
		discussion.EndDate = info.DateEnd;
		discussion.DiscussionStatus = DiscussionStatus.Open;
		discussion.Save();
	}

	[HttpPost]
	public ActionResult Save(ChannelMessageViewInfo info)
	{
		info.UpdateChannelsToMessage();
		if (!string.IsNullOrEmpty(info.Message.Subject) && ((info.Message.Channels != null && ((ICollection<IInformationChannel>)info.Message.Channels).Count > 0) || (info.Message.Recipients != null && ((ICollection<EleWise.ELMA.Security.Models.IUser>)info.Message.Recipients).Count > 0)))
		{
			ProcessChannelMessage(info);
			Locator.GetService<IMessageSendHistoryService>()?.Add(((IEnumerable<IInformationChannel>)info.Message.Channels).ToList());
		}
		string text = (info.AjaxSubmit ? string.Empty : ((Controller)this).get_Url().ReturnUrl());
		if (!info.AjaxSubmit)
		{
			return (ActionResult)(object)((Controller)this).Redirect((!string.IsNullOrEmpty(text)) ? text : ((Controller)this).get_Url().Action("Info", (object)new
			{
				id = info.Message.Id
			}));
		}
		return SuccessJson();
	}

	[HttpGet]
	public ActionResult Info(long id)
	{
		IChannelMessage channelMessage = base.Manager.Load(id);
		if (!ChannelMessageManager.Instance.HasView(channelMessage))
		{
			throw new SecurityException(SR.T("Нет прав на просмотр сообщения с идентификатором {0}", id));
		}
		if (channelMessage.Parent != null)
		{
			return (ActionResult)(object)((Controller)this).Redirect("/Messages/ChannelMessage/Info/" + channelMessage.Parent.Id);
		}
		ChannelMessageModel channelMessageModel = new ChannelMessageModel
		{
			Message = channelMessage,
			IsAssign = IsAssignToMessage(channelMessage)
		};
		SetAsReadForFeed(channelMessage);
		return (ActionResult)(object)((Controller)this).View((object)channelMessageModel);
	}

	[HttpPost]
	public ActionResult AddComment(CommentWithAttachments model)
	{
		IChannelMessage channelMessage = (IChannelMessage)model.Object;
		if (!ChannelMessageManager.Instance.HasComment(channelMessage))
		{
			throw new SecurityException(SR.T("Недостаточно доступа для комментирования сообщения"));
		}
		if (!string.IsNullOrEmpty(model.ActionModel.Comment.Text))
		{
			if (model.ActionModel.Attachments != null && model.ActionModel.Attachments.Count > 0)
			{
				foreach (IAttachment attachment in model.ActionModel.Attachments)
				{
					DataAccessManager.FileManager.SaveFile(attachment.File);
				}
			}
			ChannelMessageManager.Instance.AddComment(channelMessage, model.ActionModel);
			if (model.UseJson)
			{
				return SuccessJson();
			}
			if (!string.IsNullOrEmpty(model.RedirectUrl))
			{
				return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
			}
			return (ActionResult)(object)((Controller)this).RedirectToAction("Info", (object)new
			{
				id = channelMessage.Id
			});
		}
		if (model.UseJson)
		{
			return ErrorJson("error: input text");
		}
		if (!string.IsNullOrEmpty(model.RedirectUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Info", (object)new
		{
			id = channelMessage.Id
		});
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult SendFastCommentInChannel(ChannelMessageModel model)
	{
		IChannelMessage message = ChannelMessageManager.Instance.Load(model.Message.Id);
		if (!ChannelMessageManager.Instance.HasComment(message))
		{
			throw new SecurityException(SR.T("Недостаточно доступа для комментирования сообщения"));
		}
		if (!string.IsNullOrEmpty(model.TextPostComment))
		{
			ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
			commentActionModel.Comment = InterfaceActivator.Create<IComment>();
			commentActionModel.Comment.Text = model.TextPostComment.Trim();
			ChannelMessageManager.Instance.AddComment(message, commentActionModel);
		}
		string text = ((Controller)this).get_Url().ReturnUrl();
		return (ActionResult)(object)((Controller)this).Redirect((!string.IsNullOrEmpty(text)) ? text : ((Controller)this).get_Url().Action("Info", (object)new
		{
			id = model.Message.Id
		}));
	}

	[Obsolete("Не используется")]
	[CustomGridAction]
	public ActionResult CommentsGrid(GridCommand command, long id, [Bind(Prefix = "ChannelMessageFilter")] IChannelMessageFilter filter)
	{
		IChannelMessage parent = base.Manager.Load(id);
		if (filter == null)
		{
			filter = InterfaceActivator.Create<IChannelMessageFilter>();
		}
		filter.Parent = parent;
		filter.MessageType = ChannelMessageType.Comment;
		GridData<IChannelMessage, IChannelMessageFilter> gridData = CreateGridData(command, filter);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	public PartialViewResult LoadComments(long id, int loadCommentsCount)
	{
		return ((Controller)this).PartialView((object)ChannelMessageManager.Instance.LoadComments(id, loadCommentsCount, 10).ToArray());
	}

	[HttpGet]
	public ActionResult Channels(Guid? groupId)
	{
		InformationChannelList informationChannelList = new InformationChannelList();
		if (groupId.HasValue)
		{
			IInformationChannelGroup informationChannelGroup = ComponentManager.Current.GetExtensionPoints<IInformationChannelGroup>().FirstOrDefault((IInformationChannelGroup g) => g.Uid == groupId.Value);
			informationChannelList.GroupId = groupId.Value;
			informationChannelList.GroupName = informationChannelGroup.FullName;
		}
		return (ActionResult)(object)((Controller)this).View((object)informationChannelList);
	}

	[HttpPost]
	public ActionResult Assign(long id, bool val)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = CurrentUser;
		IInformationChannel channel = InformationChannelManager.Instance.Load(id);
		Assign(channel, currentUser, val);
		return SuccessJson();
	}

	private void Assign(IInformationChannel channel, EleWise.ELMA.Security.Models.IUser user, bool val)
	{
		IInformationChannelSubscriber informationChannelSubscriber = ((IEnumerable<IInformationChannelSubscriber>)channel.Subscribers).FirstOrDefault((IInformationChannelSubscriber u) => u.User.Id == user.Id);
		if (val)
		{
			if (informationChannelSubscriber == null)
			{
				informationChannelSubscriber = InterfaceActivator.Create<IInformationChannelSubscriber>();
				informationChannelSubscriber.User = user;
				informationChannelSubscriber.Channel = channel;
				channel.Subscribers.Add(informationChannelSubscriber);
				channel.Save();
			}
		}
		else if (informationChannelSubscriber != null)
		{
			((ICollection<IInformationChannelSubscriber>)channel.Subscribers).Remove(informationChannelSubscriber);
			informationChannelSubscriber.Delete();
			channel.Save();
		}
	}

	[CustomGridAction]
	public ActionResult ChannelsGrid(GridCommand command, CustomGridCommand customCommand, Guid? groupId)
	{
		EleWise.ELMA.Security.Models.IUser user = CurrentUser;
		if (customCommand != null)
		{
			if (customCommand.Ids == null)
			{
				customCommand.Ids = new long[0];
			}
			string commandName = customCommand.CommandName;
			if (!(commandName == "Assign"))
			{
				if (commandName == "DeAssign")
				{
					customCommand.Ids.ToList().ForEach(delegate(long id)
					{
						IInformationChannel channel2 = InformationChannelManager.Instance.Load(id);
						Assign(channel2, user, val: false);
					});
				}
			}
			else
			{
				customCommand.Ids.ToList().ForEach(delegate(long id)
				{
					IInformationChannel channel = InformationChannelManager.Instance.Load(id);
					Assign(channel, user, val: true);
				});
			}
		}
		IInformationChannelFilter informationChannelFilter = InterfaceActivator.Create<IInformationChannelFilter>();
		if (groupId.HasValue)
		{
			informationChannelFilter.GroupUid = groupId.Value;
		}
		GridData<IInformationChannel, IInformationChannelFilter> gridData = InformationChannelManager.Instance.CreateGridData(command, informationChannelFilter);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	public ActionResult ChannelLastMessages(long channelId)
	{
		Locator.GetServiceNotNull<ICommentActionHandler>();
		EleWise.ELMA.Security.Models.IUser currentUser = CurrentUser;
		InstanceOf<IChannelMessageFilter> instanceOf = new InstanceOf<IChannelMessageFilter>();
		instanceOf.New.ChannelId = channelId;
		instanceOf.New.IsAnswer = false;
		IChannelMessageFilter @new = instanceOf.New;
		FetchOptions all = FetchOptions.All;
		all.SortExpression = "CreationDate";
		all.SortDirection = ListSortDirection.Descending;
		all.MaxResults = 3;
		List<InfoChannelMessageParent> list = (from m in base.Manager.Find(@new, all)
			select new InfoChannelMessageParent
			{
				Message = m,
				Id = m.Id,
				ObjectId = m.Id,
				CreationAuthor = m.CreationAuthor,
				CreationDate = m.CreationDate,
				ShortMessageText = m.FullMessage,
				Subject = m.Subject,
				AllowEdit = false,
				URL = ((Controller)this).get_Url().Action("Info", "ChannelMessage", (object)new
				{
					area = "EleWise.ELMA.Messages.Web",
					id = m.Id
				}),
				DiscussionObjectsOriginal = ((IEnumerable<IDiscussionObject>)m.DiscussionObjects).ToList(),
				DiscussionObjects = (from o in ((IEnumerable<IDiscussionObject>)m.DiscussionObjects).Select(delegate(IDiscussionObject o)
					{
						Type entityType = ModelHelper.GetEntityType(o.ObjectType);
						IEntityManager manager = ModelHelper.GetEntityManager(entityType);
						object obj = null;
						Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegiesAndWithDeleted(delegate
						{
							obj = manager.LoadOrNull(o.ObjectId);
						});
						return obj;
					})
					where o != null
					select o).ToList()
			}).ToList();
		Guid typeUid = InterfaceActivator.UID<IChannelMessage>();
		Dictionary<Pair<Guid, long>, string> dictionary = FeedManager.Instance.FavoriteHashList(currentUser, list.Select((InfoChannelMessageParent m) => new Pair<Guid, long>(typeUid, m.Id)).ToList());
		foreach (InfoChannelMessageParent item in list)
		{
			long id = item.Id;
			Pair<Guid, long> pair = dictionary.Keys.FirstOrDefault((Pair<Guid, long> m) => m.Second == id);
			item.IsFavorite = pair != null && !dictionary[pair].IsNullOrEmpty();
		}
		return (ActionResult)(object)((Controller)this).PartialView("ChannelLastMessages", (object)list);
	}

	[HttpPost]
	public ActionResult MessageAssignedAction(long messageId, bool assign)
	{
		if ((assign && IsAssignToMessage(messageId)) || (!assign && !IsAssignToMessage(messageId)))
		{
			MessageNotAssignedUserManager.Instance.AssignedAction(messageId);
		}
		return SuccessJson();
	}

	private static bool IsAssignToMessage(IChannelMessage message)
	{
		return IsAssignToMessage(message.Id);
	}

	private static bool IsAssignToMessage(long messageId)
	{
		return MessageNotAssignedUserManager.Instance.IsAssignToMessage(messageId);
	}

	public ActionResult ChannelsAndRecipients(long messageId, string popupId)
	{
		IChannelMessage channelMessage = ChannelMessageManager.Instance.Load(messageId);
		ChannelsAndRecipientsModel channelsAndRecipientsModel = new ChannelsAndRecipientsModel
		{
			ChannelMessageId = messageId,
			PopupId = popupId
		};
		channelsAndRecipientsModel.ChannelsSelector.SetChannels(channelMessage.Channels);
		channelsAndRecipientsModel.Message = channelMessage;
		return (ActionResult)(object)((Controller)this).PartialView("ChannelsAndRecipients", (object)channelsAndRecipientsModel);
	}

	[HttpPost]
	public ActionResult ChannelsAndRecipients(ChannelsAndRecipientsModel model)
	{
		IChannelMessage channelMessage = ChannelMessageManager.Instance.Load(model.ChannelMessageId);
		if (channelMessage.CreationAuthor == CurrentUser)
		{
			ISet<IInformationChannel> channels = model.ChannelsSelector.GetChannels();
			ChannelMessageManager.Instance.UpdateChannelsAndRecipients(channelMessage, channels, model.Message.Recipients, createAction: true);
			Locator.GetService<IMessageSendHistoryService>()?.Add(((IEnumerable<IInformationChannel>)channels).ToList());
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Info", (object)new
		{
			id = model.ChannelMessageId
		});
	}

	public ActionResult ChannelsAndRecipientsView(long messageId, bool autoResize = true)
	{
		//IL_0041: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		ChannelsAndRecipientsModel channelsAndRecipientsModel = new ChannelsAndRecipientsModel();
		if (messageId != 0L)
		{
			IChannelMessage channelMessage = ChannelMessageManager.Instance.LoadOrNull(messageId);
			if (channelMessage == null)
			{
				return (ActionResult)new EmptyResult();
			}
			channelsAndRecipientsModel = new ChannelsAndRecipientsModel
			{
				ChannelMessageId = messageId,
				Message = channelMessage,
				Channels = channelMessage.Channels,
				AutoResize = autoResize
			};
		}
		return (ActionResult)(object)((Controller)this).PartialView("ChannelMessage/ChannelsAndRecipientsView", (object)channelsAndRecipientsModel);
	}

	public ActionResult CommentsList(long id)
	{
		IChannelMessage channelMessage = base.Manager.Load(id);
		return (ActionResult)(object)((Controller)this).PartialView("AuditView/ChannelMessage.Comments", (object)channelMessage.Messages);
	}

	public ActionResult PrioritySettingsPopup(string windowId, string callBackScript, string prePostScript, string priorityTextScript, long infoChannelId)
	{
		PrioritySettingsModel prioritySettingsModel = new PrioritySettingsModel
		{
			Priority = CurrentPriority(infoChannelId),
			PopupId = windowId,
			CallBackScript = callBackScript,
			PrePostScript = prePostScript,
			PostController = "ChannelMessage",
			PostAction = "PrioritySettingsSave",
			PriorityTextScript = priorityTextScript
		};
		return (ActionResult)(object)((Controller)this).PartialView("Feed/PrioritySettingsPopup", (object)prioritySettingsModel);
	}

	public ActionResult PrioritySettingsSave(PrioritySettingsModel settings, long infoChannelId)
	{
		//IL_0016: Unknown result type (might be due to invalid IL or missing references)
		//IL_001c: Expected O, but got Unknown
		ChannelMessageManager.Instance.SetPriority(CurrentUser, settings.Priority, infoChannelId);
		return (ActionResult)new EmptyResult();
	}

	public ActionResult FeedFavoriteLike(long id)
	{
		//IL_004a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		IChannelMessage channelMessage = base.Manager.Load(id);
		if (ChannelMessageManager.Instance.HasView(channelMessage))
		{
			Guid objectUid = InterfaceActivator.UID<IChannelMessage>();
			FeedManager instance = FeedManager.Instance;
			if (instance.IsFavorite(objectUid, id))
			{
				instance.DeleteFromFavorite(objectUid, id);
			}
			else
			{
				instance.CreateParentMessage(channelMessage);
				instance.AddToFavorite(objectUid, id);
			}
		}
		return (ActionResult)new EmptyResult();
	}

	public ActionResult DownloadSelectedFilesPopup(IChannelMessage message, string popupId = null)
	{
		IEnumerable<AttachmentFileModel> attachmentFileModelsForGrid = GetAttachmentFileModelsForGrid(message);
		Guid typeUid = message.TypeUid;
		AttachmentPopupModel attachmentPopupModel = new AttachmentPopupModel
		{
			PopupId = popupId,
			TypeUid = typeUid,
			Id = message.Id,
			GridData = DownloadArchiveController.GetGridDataForDownloadSelectedFilesGrid(attachmentFileModelsForGrid, null, null)
		};
		return (ActionResult)(object)((Controller)this).PartialView("~/Modules/EleWise.ELMA.BPM.Web.Common/Views/DownloadArchive/DownloadSelectedFilesPopupPartial.cshtml", (object)attachmentPopupModel);
	}

	[CustomGridAction]
	public ActionResult DownloadSelectedFilesGrid(GridCommand command, string gridId, Guid typeUid, long id, string nameProperty, string searchString, bool withNameProperty = false)
	{
		GridData<AttachmentFileModel> gridDataForDownloadSelectedFilesGrid = DownloadArchiveController.GetGridDataForDownloadSelectedFilesGrid((ModelHelper.GetEntity(typeUid, id) is IChannelMessage message) ? GetAttachmentFileModelsForGrid(message) : Enumerable.Empty<AttachmentFileModel>(), command, searchString);
		((ControllerBase)this).get_ViewData().set_Item("GridId", (object)gridId);
		return (ActionResult)(object)((Controller)this).PartialView("~/Modules/EleWise.ELMA.BPM.Web.Common/Views/DownloadArchive/DownloadSelectedFilesGrid.cshtml", (object)gridDataForDownloadSelectedFilesGrid);
	}

	public ActionResult DownloadAttachment(IChannelMessage message)
	{
		IEnumerable<AttachmentFileModel> source = ObjectAttachmentExtensions.Where((IObjectAttachmentExtension p) => p.EntityType(message.TypeUid)).SelectMany((IObjectAttachmentExtension x) => x.GetAttachments(message)).Distinct();
		Guid fileGuid = ObjectAttachmentsArchiveService.CreateArchiveCacheFile(source.Select((AttachmentFileModel u) => u.Uid.ToString()).ToArray());
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			result = true,
			fileGuid = fileGuid
		}, "text/plain", (JsonRequestBehavior)0);
	}

	public PartialViewResult RenderChannelTree(string id)
	{
		return ((Controller)this).PartialView((object)BuildChannelTreeModel(id));
	}

	[HttpPost]
	public ActionResult ChannelTreeUpdate(string treeId, string text)
	{
		TreeModel treeModel = BuildChannelTreeModel(treeId);
		treeModel.Children = treeModel.Children.FilterTreeNodes(text);
		return (ActionResult)(object)((Controller)this).PartialView("ChannelTree", (object)treeModel);
	}

	private TreeModel BuildChannelTreeModel(string id)
	{
		HtmlHelper htmlHelper = GetHtmlHelper();
		IInformationChannelFilter informationChannelFilter = InterfaceActivator.Create<IInformationChannelFilter>();
		informationChannelFilter.Assigned = true;
		ICollection<IInformationChannel> source = InformationChannelManager.Instance.Find(informationChannelFilter, FetchOptions.All);
		IEnumerable<IInformationChannelGroup> groups = ComponentManager.Current.GetExtensionPoints<IInformationChannelGroup>();
		List<TreeMenuNode> list = new List<TreeMenuNode>();
		foreach (IInformationChannelGroup item in groups)
		{
			list.Add(new TreeMenuNode
			{
				id = item.IdItem,
				text = item.Name,
				icon = ((!string.IsNullOrEmpty(item.ImageUrl)) ? item.ImageUrl : "#channel.svg"),
				expanded = item.Expanded,
				href = item.GetUrl(htmlHelper)
			});
		}
		foreach (IGrouping<Guid, IInformationChannel> channel in from ch in source
			group ch by ch.GroupUid into ch
			orderby groups.FirstOrDefault((IInformationChannelGroup g) => g.Uid == ch.Key)?.Order ?? int.MaxValue
			select ch)
		{
			IInformationChannelGroup group = groups.FirstOrDefault((IInformationChannelGroup gr) => gr.Uid == channel.Key);
			if (group == null)
			{
				continue;
			}
			TreeMenuNode treeMenuNode = list.FirstOrDefault((TreeMenuNode n) => n.id == group.IdItem);
			if (treeMenuNode != null)
			{
				treeMenuNode.children = channel.Select((IInformationChannel ch) => new TreeMenuNode
				{
					text = ch.DisplayName,
					id = $"channel_{ch.Id}",
					href = ((Controller)this).get_Url().InformationChannel(ch.Id)
				}).ToList();
			}
		}
		return new TreeModel
		{
			Children = list,
			Id = id
		};
	}

	private IEnumerable<AttachmentFileModel> GetAttachmentFileModelsForGrid(IChannelMessage message)
	{
		List<AttachmentFileModel> list = new List<AttachmentFileModel>();
		IEnumerable<IObjectAttachmentExtension> source = ObjectAttachmentExtensions.Where((IObjectAttachmentExtension p) => p.EntityType(message.TypeUid));
		list.AddRange(source.SelectMany((IObjectAttachmentExtension x) => x.GetAttachments(message)).Distinct());
		foreach (IChannelMessage comment in (IEnumerable<IChannelMessage>)message.Messages)
		{
			list.AddRange(source.SelectMany((IObjectAttachmentExtension x) => x.GetAttachments(comment)).Distinct());
		}
		return list;
	}
}
