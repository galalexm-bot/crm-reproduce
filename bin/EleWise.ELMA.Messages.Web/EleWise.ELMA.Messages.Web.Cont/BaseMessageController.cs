using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Components;
using EleWise.ELMA.Messages.Web.Models;
using EleWise.ELMA.Messages.Web.Portlets;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html.MessageCustomPager;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Portlets;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.Messages.Web.Controllers;

[Permission("258BBEBC-006B-46FB-80AC-B36456A191E9")]
public class BaseMessageController : BPMController<IBaseMessage, long>
{
	[HttpGet]
	public ActionResult MessagePortlet(MessagesPortletPersonalization settings)
	{
		MessageList messageList = new MessageList
		{
			BaseMessageFilter = InterfaceActivator.Create<IBaseMessageFilter>()
		};
		if (settings.ChannelId == -1)
		{
			messageList.BaseMessageFilter.ChannelId = null;
			messageList.BaseMessageFilter.Notifications = true;
		}
		else
		{
			messageList.BaseMessageFilter.ChannelId = settings.ChannelId;
			messageList.BaseMessageFilter.Notifications = false;
			messageList.BaseMessageFilter.ChannelMessages = true;
		}
		if (messageList.BaseMessageFilter.ChannelId.HasValue)
		{
			IInformationChannel informationChannel = InformationChannelManager.Instance.LoadOrNull(messageList.BaseMessageFilter.ChannelId.Value);
			if (informationChannel != null)
			{
				messageList.CanAddMessage = base.SecurityService.HasPermission(PermissionProvider.ChannelEditPermission, informationChannel);
			}
		}
		messageList.CommentsCount = settings.CommentsCount;
		return (ActionResult)(object)((Controller)this).PartialView((object)messageList);
	}

	[ContentItem(Name = "SR.M('Сообщения')", Image24 = "#messages.svg")]
	public ActionResult List([Bind(Prefix = "BaseMessageFilter")] IBaseMessageFilter filter)
	{
		if (filter == null)
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List", "Feed");
		}
		MessageList messageList = new MessageList
		{
			BaseMessageFilter = filter
		};
		if (messageList.BaseMessageFilter.Sended)
		{
			messageList.GridId = "MessagesSended";
		}
		else if (messageList.BaseMessageFilter.ChannelId.HasValue)
		{
			messageList.GridId = "MessagesChannel" + messageList.BaseMessageFilter.ChannelId;
		}
		if (messageList.BaseMessageFilter.ChannelId.HasValue)
		{
			IInformationChannel informationChannel = InformationChannelManager.Instance.LoadOrNull(messageList.BaseMessageFilter.ChannelId.Value);
			if (informationChannel != null)
			{
				messageList.CanAddMessage = base.SecurityService.HasPermission(PermissionProvider.ChannelEditPermission, informationChannel);
			}
		}
		return (ActionResult)(object)((Controller)this).View((object)messageList);
	}

	public ActionResult Feed([Bind(Prefix = "BaseMessageFilter")] IBaseMessageFilter filter, bool compactView = false, string gridId = "MessagesId", int? page = null, int? size = null, int? commentsCount = null)
	{
		FetchOptions all = FetchOptions.All;
		all.SortExpression = "Id";
		all.SortDirection = ListSortDirection.Descending;
		filter = GetFilter(filter);
		long num = base.Manager.Count(filter);
		GridState gridState = GridPersonalizationAdministration.LoadState(gridId) ?? new GridState
		{
			CurrentPage = 1,
			PageSize = 15
		};
		if (page.HasValue)
		{
			gridState.CurrentPage = page.Value;
		}
		if (size.HasValue)
		{
			gridState.PageSize = size.Value;
		}
		if (page.HasValue || size.HasValue)
		{
			GridPersonalizationAdministration.SaveState(gridId, gridState);
		}
		if ((gridState.CurrentPage - 1) * gridState.PageSize > num)
		{
			gridState.CurrentPage = Convert.ToInt32(num / gridState.PageSize);
		}
		MessagePagerSettings messagePagerSettings = new MessagePagerSettings();
		all.MaxResults = gridState.PageSize;
		all.FirstResult = (gridState.CurrentPage - 1) * gridState.PageSize;
		messagePagerSettings.Page = gridState.CurrentPage;
		messagePagerSettings.PageSize = gridState.PageSize;
		FeedMessagesSettings settings = BaseMessageManager.Instance.LoadSettings();
		ICollection<IBaseMessage> source = base.Manager.Find(filter, all);
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		IEnumerable<InfoChannelMessageParent> parentsMessages = ChannelMessageHelper.GetParentsMessages(source.ToList(), currentUser, base.SecurityService, (!commentsCount.HasValue) ? null : (commentsCount + 1));
		Func<DateTime?, DateTime?, DateTime?> maxDate = (DateTime? d1, DateTime? d2) => (!((d1 ?? DateTime.MinValue) > (d2 ?? DateTime.MinValue))) ? d2 : d1;
		ListChannelMessageParentModel listChannelMessageParentModel = new ListChannelMessageParentModel(parentsMessages.OrderByDescending((InfoChannelMessageParent m) => maxDate(m.CreationDate, (m.Messages != null) ? m.Messages.Max((InfoChannelMessageChild mm) => mm.CreationDate) : m.CreationDate)).Select(delegate(InfoChannelMessageParent m)
		{
			m.IsAssignMessage = MessageNotAssignedUserManager.Instance.IsAssignToMessage(Convert.ToInt64(m.ObjectId));
			m.HasOldComments = m.Messages != null && m.Messages.Count > (commentsCount ?? settings.CommentsCount);
			m.CompactView = compactView;
			m.Messages = ((m.Messages == null) ? m.Messages : m.Messages.OrderByDescending((InfoChannelMessageChild ms) => ms.CreationDate).Select(delegate(InfoChannelMessageChild ms)
			{
				ms.CompactView = compactView;
				return ms;
			}).Take(commentsCount ?? settings.CommentsCount)
				.Reverse()
				.ToList());
			return m;
		}).ToList())
		{
			CompactView = compactView,
			GridId = gridId,
			PagerSettings = messagePagerSettings,
			ItemsCount = num,
			Filter = filter
		};
		Guid typeUid = InterfaceActivator.UID<IChannelMessage>();
		Dictionary<Pair<Guid, long>, string> dictionary = FeedManager.Instance.FavoriteHashList(currentUser, source.Select((IBaseMessage m) => new Pair<Guid, long>(typeUid, m.Id)).ToList());
		foreach (InfoChannelMessageParent item in listChannelMessageParentModel)
		{
			long id = item.ObjectId;
			Pair<Guid, long> pair = dictionary.Keys.FirstOrDefault((Pair<Guid, long> m) => m.Second == id);
			item.IsFavorite = pair != null && !dictionary[pair].IsNullOrEmpty();
		}
		listChannelMessageParentModel.CommentsCount = commentsCount;
		return (ActionResult)(object)((Controller)this).PartialView("AllFeed", (object)listChannelMessageParentModel);
	}

	public ActionResult PagerFeed(string filter, bool compactView = false, string gridId = "MessagesId", int? page = null, int? size = null, int? commentsCount = null)
	{
		IBaseMessageFilter filter2 = (IBaseMessageFilter)UniversalFilterSaver.UnPack(ClassSerializationHelper.DeserializeObjectByXml<SerializableFilter>(filter));
		return Feed(filter2, compactView, gridId, page, size, commentsCount);
	}

	[HttpGet]
	public ActionResult Members(long id)
	{
		IBaseMessage baseMessage = base.Manager.Load(id);
		if (!ChannelMessageManager.Instance.HasFullAccess(baseMessage))
		{
			throw new SecurityException(SR.T("Недостаточно прав"));
		}
		return (ActionResult)(object)((Controller)this).View((object)baseMessage);
	}

	public ActionResult Line(GridCommand command, [Bind(Prefix = "BaseMessageFilter")] IBaseMessageFilter filter)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_000a: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		if (command == null)
		{
			command = new GridCommand();
		}
		if (filter == null)
		{
			filter = InterfaceActivator.Create<IBaseMessageFilter>();
		}
		BaseMessageGrid baseMessageGrid = new BaseMessageGrid();
		if (!command.get_SortDescriptors().Any((SortDescriptor d) => d.get_Member() == "CreationDate"))
		{
			IList<SortDescriptor> sortDescriptors = command.get_SortDescriptors();
			SortDescriptor val = new SortDescriptor();
			val.set_Member("CreationDate");
			val.set_SortDirection(ListSortDirection.Descending);
			sortDescriptors.Add(val);
		}
		baseMessageGrid.Data = CreateGridData(command, filter);
		return (ActionResult)(object)((Controller)this).PartialView((object)baseMessageGrid);
	}

	[HttpGet]
	public ActionResult Settings(string popupId, string redirectUrl = null)
	{
		SettingsMessagesInfo settingsMessagesInfo = new SettingsMessagesInfo
		{
			PopupId = popupId,
			RedirectUrl = redirectUrl,
			Settings = LoadSettings()
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)settingsMessagesInfo);
	}

	[HttpPost]
	public ActionResult Settings(SettingsMessagesInfo model)
	{
		BaseMessageManager.Instance.SaveSettings(model.Settings);
		return (ActionResult)(object)((Controller)this).Redirect((!string.IsNullOrEmpty(model.RedirectUrl)) ? model.RedirectUrl : ((Controller)this).get_Url().ReturnUrl());
	}

	public static FeedMessagesSettings LoadSettings()
	{
		FeedMessagesSettings feedMessagesSettings = BaseMessageManager.Instance.LoadSettings();
		GetOldSettings(feedMessagesSettings);
		return feedMessagesSettings;
	}

	[Obsolete("Метод устарел. Используется исключительно для сохранения старых настроек")]
	private static void GetOldSettings(FeedMessagesSettings settings)
	{
		IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
		SettingsMessages settingsMessages = PersonalizationAdministration.LoadState<SettingsMessages>(currentUser.UserName, "SettingsMessages");
		if (settingsMessages != null)
		{
			settings.PostCommentEnterKey = settingsMessages.PostCommentEnterKey;
			BaseMessageManager.Instance.SaveSettings(settings);
			PersonalizationAdministration.ResetState<SettingsMessages>(currentUser.UserName, "SettingsMessages");
		}
	}

	[Obsolete("Метод устарел. Используйте вместо него метод EleWise.ELMA.Messages.Managers.BaseMessageManager.SaveSettings")]
	public static void SaveSettings(SettingsMessages settings)
	{
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult SendFastComment(FastCommentModel model)
	{
		if (string.IsNullOrEmpty(model.TextPostMessage.Trim(" \t\r\n".ToCharArray())))
		{
			return (ActionResult)(object)((Controller)this).Redirect(((Controller)this).get_Url().ReturnUrl());
		}
		IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
		DateTime now = DateTime.Now;
		IChannelMessage channelMessage = AbstractNHEntityManager<IChannelMessage, long>.Instance.Load(model.ObjectId);
		IChannelMessage message = channelMessage.Parent ?? channelMessage;
		ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
		commentActionModel.Comment = InterfaceActivator.Create<IComment>();
		commentActionModel.Comment.Text = model.TextPostMessage.Trim();
		ChannelMessageManager.Instance.AddComment(message, commentActionModel);
		IChannelMessage channelMessage2 = ChannelMessageManager.Instance.Create();
		channelMessage2.FullMessage = model.TextPostMessage.Trim(" \t\r\n".ToCharArray());
		InfoChannelMessageChild infoChannelMessageChild = new InfoChannelMessageChild
		{
			Message = channelMessage2,
			AllowComment = false,
			AllowDelete = false,
			AllowEdit = false,
			CreationAuthor = currentUser,
			CreationDate = now,
			FullMessageText = model.TextPostMessage,
			Id = 0L,
			ObjectId = model.ObjectId,
			ShortMessageText = channelMessage2.FullMessage
		};
		return (ActionResult)(object)((Controller)this).PartialView("FeedMessageComment", (object)infoChannelMessageChild);
	}

	private IBaseMessageFilter GetFilter(IBaseMessageFilter filter = null)
	{
		if (filter == null)
		{
			filter = InterfaceActivator.Create<IBaseMessageFilter>();
			filter.Notifications = true;
		}
		if (filter.Notifications)
		{
			filter.RecipientId = Convert.ToInt64(base.AuthenticationService.GetCurrentUser().GetId());
		}
		return filter;
	}

	public ActionResult FavoriteLikeAjax(long objectId, bool like, Guid? typeUid)
	{
		bool success = false;
		string error = "";
		FeedManager instance = FeedManager.Instance;
		typeUid = typeUid ?? InterfaceActivator.UID<IChannelMessage>();
		if (typeUid == InterfaceActivator.UID<IChannelMessage>())
		{
			try
			{
				if (like)
				{
					IChannelMessage entity = ChannelMessageManager.Instance.Load(objectId);
					instance.CreateParentMessage(entity);
					instance.AddToFavorite(typeUid.Value, objectId);
				}
				else
				{
					instance.DeleteFromFavorite(typeUid.Value, objectId);
				}
				success = true;
			}
			catch (Exception ex)
			{
				error = ex.Message;
				EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Невозможно сохранить сообщение."), ex);
			}
		}
		return (ActionResult)(object)((Controller)this).Json((object)new { success, error }, (JsonRequestBehavior)0);
	}

	[ContentItem(Name = "SR.M('Сообщения')", Id = "messages-admin-settings", Image16 = "#messages.svg")]
	public ActionResult MessagesSettingsPage()
	{
		return (ActionResult)(object)((Controller)this).RedirectToAction("GetSettingsPage", "Settings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			code = "messages-admin-settings",
			header = SR.T("Сообщения")
		});
	}
}
