using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Messages.Channels;
using EleWise.ELMA.Messages.Enums;
using EleWise.ELMA.Messages.Managers;
using EleWise.ELMA.Messages.Models;
using EleWise.ELMA.Messages.Web.Components;
using EleWise.ELMA.Messages.Web.Models;
using EleWise.ELMA.Messages.Web.Portlets;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Extensions;

namespace EleWise.ELMA.Messages.Web.Controllers;

public class FeedController : BPMController
{
	private const int FeedMaxCount = 10;

	private const int FeedMaxCommentsCount = 10;

	private const int MaxDaysAutoLoading = 30;

	private const string CommentMessageListView = "Feed/Partial/CommentMessageList";

	private const string PreviousCommentsButtonView = "Feed/Partial/PreviousCommentsButton";

	private static IUser CurrentUser => Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();

	private static FeedPriority CurrentPriority => FeedManager.Instance.GetPriority(CurrentUser);

	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public IEnumerable<ICommentAttachmentConvertor> CommentAttachmentConvertors { get; set; }

	public IHistoryOrder HistoryOrder { get; set; }

	[HttpGet]
	public ActionResult FeedPortlet(MessagesPortletPersonalization settings)
	{
		bool showOnlyNew = settings.ShowOnlyNew;
		FeedCounter[] unreadCount = FeedManager.Instance.GetUnreadCount();
		long count = unreadCount.FirstOrDefault((FeedCounter m) => m.WithPriority).Count;
		FeedLoadSettings settings2 = ((!(unreadCount.FirstOrDefault((FeedCounter m) => !m.WithPriority).Count > 0 && showOnlyNew)) ? new FeedLoadSettings
		{
			MaxCount = settings.MessagesCount,
			MaxChildCount = settings.CommentsCount,
			Priority = FeedPriority.Lowest
		} : new FeedLoadSettings
		{
			MaxCount = settings.MessagesCount,
			MaxChildCount = settings.CommentsCount,
			Priority = ((count > 0) ? CurrentPriority : FeedPriority.Lowest)
		});
		List<FeedModel> list = FeedManager.Instance.LoadMessages(settings2, showOnlyNew);
		List<CanCreateCommentItemMessage> list2 = list.Select((FeedModel m) => new CanCreateCommentItemMessage(m)).ToList();
		List<CanCreateQuestionItem> list3 = list.Select((FeedModel m) => new CanCreateQuestionItem(m.ParentObjectUid.Value, m.ParentObjectId.Value)).ToList();
		FeedManager.Instance.CanCreateComment(list2);
		FeedManager.Instance.CanCreateQuestion(list3);
		List<FeedMessageInfoModel> messageInfo = FeedManager.Instance.GetMessageInfo(list.Select((FeedModel m) => m.Id).ToList());
		FeedListModel feedListModel = new FeedListModel
		{
			MaxDaysAutoLoading = 30,
			OnlyUnread = showOnlyNew,
			Messages = list,
			CanCreateCommentList = list2.Select((CanCreateCommentItemMessage o) => o.ToCanCreateCommentItem()).ToList(),
			CanCreateQuestionList = list3,
			CurrentPriority = CurrentPriority,
			PriorityEnabled = true,
			IsPortlet = true,
			FeedMessageInfoAllMessages = messageInfo
		};
		return (ActionResult)(object)((Controller)this).PartialView("Feed/Feed", (object)feedListModel);
	}

	[ContentItem(Name = "SR.M('Сообщения')", Image24 = "#messages.svg")]
	public ActionResult List(bool onlyUnread = true, bool priorityEnabled = true, bool favorites = false, [Bind(Prefix = "Filter")] FeedFilter filter = null)
	{
		if (filter != null && !filter.IsEmpty())
		{
			filter.OnlyUnread = onlyUnread;
			filter.Favorites = favorites;
			return FindList(filter);
		}
		FeedPriority currentPriority = CurrentPriority;
		FeedMessagesSettings feedMessagesSettings = BaseMessageManager.Instance.LoadSettings();
		List<FeedModel> list;
		if (favorites)
		{
			FeedFavoriteLoadSettings settings = new FeedFavoriteLoadSettings
			{
				MaxCount = feedMessagesSettings.MessagesCount
			};
			list = FeedManager.Instance.LoadFavoriteMessages(settings);
		}
		else
		{
			FeedLoadSettings settings2 = new FeedLoadSettings
			{
				MaxCount = feedMessagesSettings.MessagesCount,
				MaxChildCount = feedMessagesSettings.CommentsCount,
				Priority = ((onlyUnread && priorityEnabled) ? CurrentPriority : FeedPriority.Lowest)
			};
			list = FeedManager.Instance.LoadMessages(settings2, onlyUnread);
		}
		if (!favorites && onlyUnread && !list.Any())
		{
			if (priorityEnabled)
			{
				return List(onlyUnread: true, priorityEnabled: false);
			}
			return List(onlyUnread: false);
		}
		List<CanCreateCommentItemMessage> list2 = list.Select((FeedModel m) => new CanCreateCommentItemMessage(m)).ToList();
		List<CanCreateQuestionItem> list3 = list.Select((FeedModel m) => new CanCreateQuestionItem(m.ParentObjectUid.Value, m.ParentObjectId.Value)).ToList();
		FeedManager.Instance.CanCreateComment(list2);
		FeedManager.Instance.CanCreateQuestion(list3);
		List<FeedMessageInfoModel> messageInfo = FeedManager.Instance.GetMessageInfo(list.Select((FeedModel m) => m.Id).ToList());
		FeedListModel feedListModel = new FeedListModel
		{
			MaxDaysAutoLoading = 30,
			OnlyUnread = onlyUnread,
			Messages = list,
			CanCreateCommentList = list2.Select((CanCreateCommentItemMessage o) => o.ToCanCreateCommentItem()).ToList(),
			CanCreateQuestionList = list3,
			CurrentPriority = currentPriority,
			PriorityEnabled = priorityEnabled,
			FeedMessageInfoAllMessages = messageInfo,
			Favorites = favorites
		};
		return (ActionResult)(object)((Controller)this).View((object)feedListModel);
	}

	public ActionResult ListAjax(bool onlyUnread, string changeDateHash, string changeDateHashPrevious, bool priorityEnabled = true, bool setAsRead = true, bool isFavorites = false)
	{
		//IL_0272: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		if (onlyUnread && setAsRead && !isFavorites)
		{
			FeedManager.Instance.SetAsReadParents(changeDateHash, changeDateHashPrevious, priorityEnabled ? new FeedPriority?(CurrentPriority) : null);
		}
		FeedPriority currentPriority = CurrentPriority;
		string urlRedirect = "";
		FeedMessagesSettings feedMessagesSettings = BaseMessageManager.Instance.LoadSettings();
		List<FeedModel> list = null;
		if (isFavorites)
		{
			FeedFavoriteLoadSettings settings = new FeedFavoriteLoadSettings
			{
				MaxCount = feedMessagesSettings.MessagesCount,
				ChangeDateHash = changeDateHash
			};
			list = FeedManager.Instance.LoadFavoriteMessages(settings);
		}
		else
		{
			FeedLoadSettings settings2 = new FeedLoadSettings
			{
				MaxCount = feedMessagesSettings.MessagesCount,
				MaxChildCount = feedMessagesSettings.CommentsCount,
				ChangeDateHash = changeDateHash,
				Priority = ((onlyUnread && priorityEnabled) ? CurrentPriority : FeedPriority.Lowest)
			};
			list = FeedManager.Instance.LoadMessages(settings2, onlyUnread);
		}
		FeedListModel model = null;
		if (!isFavorites && onlyUnread && !list.Any())
		{
			if (priorityEnabled)
			{
				return ListAjax(onlyUnread: true, changeDateHash, changeDateHashPrevious, priorityEnabled: false, setAsRead: false);
			}
			urlRedirect = ((Controller)this).get_Url().Action("List");
		}
		else
		{
			List<CanCreateCommentItemMessage> list2 = list.Select((FeedModel m) => new CanCreateCommentItemMessage(m)).ToList();
			List<CanCreateQuestionItem> list3 = list.Select((FeedModel m) => new CanCreateQuestionItem(m.ParentObjectUid.Value, m.ParentObjectId.Value)).ToList();
			FeedManager.Instance.CanCreateComment(list2);
			FeedManager.Instance.CanCreateQuestion(list3);
			List<FeedMessageInfoModel> messageInfo = FeedManager.Instance.GetMessageInfo(list.Select((FeedModel m) => m.Id).ToList());
			model = new FeedListModel
			{
				OnlyUnread = (onlyUnread && !isFavorites),
				Messages = list,
				IsAjax = true,
				CanCreateCommentList = list2.Select((CanCreateCommentItemMessage o) => o.ToCanCreateCommentItem()).ToList(),
				CanCreateQuestionList = list3,
				CurrentPriority = currentPriority,
				PriorityEnabled = (priorityEnabled && !isFavorites),
				FeedMessageInfoAllMessages = messageInfo,
				Favorites = isFavorites
			};
		}
		FeedParentsListJsonModel model2 = new FeedParentsListJsonModel
		{
			Model = model,
			UrlRedirect = urlRedirect
		};
		FeedParentsListJsonCatchViewResult feedParentsListJsonCatchViewResult = new FeedParentsListJsonCatchViewResult();
		((ViewResultBase)feedParentsListJsonCatchViewResult).set_ViewName("Feed/Partial/ParentsListJson");
		ViewDataDictionary<FeedParentsListJsonModel> obj = new ViewDataDictionary<FeedParentsListJsonModel>(((ControllerBase)this).get_ViewData());
		obj.set_Model(model2);
		((ViewResultBase)feedParentsListJsonCatchViewResult).set_ViewData((ViewDataDictionary)(object)obj);
		((ViewResultBase)feedParentsListJsonCatchViewResult).set_TempData(new TempDataDictionary());
		return (ActionResult)(object)feedParentsListJsonCatchViewResult;
	}

	public ActionResult CommentsListAjax(long actionObjectId, Guid actionObjectUid, string changeDateHash, long loadCommentCount, string commentChangeDateHash, long parentChildCount, long parentChildUnreadCount)
	{
		FeedCommentsListModel feedCommentsListModel = CreateFeedCommentsListModel(actionObjectId, actionObjectUid, changeDateHash, loadCommentCount, commentChangeDateHash, parentChildCount, parentChildUnreadCount);
		((ControllerBase)this).get_ViewData().set_Item("UseShortView", (object)true);
		return (ActionResult)(object)((Controller)this).PartialView("Feed/Partial/CommentsList", (object)feedCommentsListModel);
	}

	public ActionResult GetPreviousCommentsListAjax(long actionObjectId, Guid actionObjectUid, string changeDateHash, long loadCommentCount, string commentChangeDateHash, long parentChildCount, long parentChildUnreadCount)
	{
		FeedCommentsListModel model = CreateFeedCommentsListModel(actionObjectId, actionObjectUid, changeDateHash, loadCommentCount, commentChangeDateHash, parentChildCount, parentChildUnreadCount);
		((ControllerBase)this).get_ViewData().set_Model((object)model);
		HtmlCatchViewResult htmlCatchViewResult = new HtmlCatchViewResult();
		((ViewResultBase)htmlCatchViewResult).set_ViewName("Feed/Partial/CommentMessageList");
		((ViewResultBase)htmlCatchViewResult).set_ViewData(((ControllerBase)this).get_ViewData());
		((ViewResultBase)htmlCatchViewResult).set_TempData(((ControllerBase)this).get_TempData());
		HtmlCatchViewResult htmlCatchViewResult2 = htmlCatchViewResult;
		HtmlCatchViewResult htmlCatchViewResult3 = new HtmlCatchViewResult();
		((ViewResultBase)htmlCatchViewResult3).set_ViewName("Feed/Partial/PreviousCommentsButton");
		((ViewResultBase)htmlCatchViewResult3).set_ViewData(((ControllerBase)this).get_ViewData());
		((ViewResultBase)htmlCatchViewResult3).set_TempData(((ControllerBase)this).get_TempData());
		HtmlCatchViewResult htmlCatchViewResult4 = htmlCatchViewResult3;
		return (ActionResult)(object)new CompositeActionResult((IEnumerable<ActionResult>)(object)new HtmlCatchViewResult[2] { htmlCatchViewResult2, htmlCatchViewResult4 }, delegate(ControllerContext context, IEnumerable<ActionResult> results)
		{
			HtmlCatchViewResult htmlCatchViewResult5 = results.FirstOrDefault((ActionResult r) => r is HtmlCatchViewResult && ((ViewResultBase)(r as HtmlCatchViewResult)).get_ViewName() == "Feed/Partial/CommentMessageList") as HtmlCatchViewResult;
			HtmlCatchViewResult htmlCatchViewResult6 = results.FirstOrDefault((ActionResult r) => r is HtmlCatchViewResult && ((ViewResultBase)(r as HtmlCatchViewResult)).get_ViewName() == "Feed/Partial/PreviousCommentsButton") as HtmlCatchViewResult;
			string value = "";
			string value2 = "";
			if (htmlCatchViewResult5 != null)
			{
				value = htmlCatchViewResult5.HtmlResult;
			}
			if (htmlCatchViewResult6 != null)
			{
				value2 = htmlCatchViewResult6.HtmlResult;
			}
			Dictionary<string, object> obj = new Dictionary<string, object>
			{
				["commentListHtml"] = value,
				["previousCommentsButtonHtml"] = value2
			};
			context.get_HttpContext().Response.ContentType = "application/json";
			context.get_HttpContext().Response.Output.Write(obj.ToJson());
		})
		{
			ResultType = ActionResultType.Unknown
		};
	}

	private ActionResult FindList(FeedFilter filter)
	{
		if (filter == null || filter.IsEmpty())
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List");
		}
		if (string.IsNullOrEmpty(filter.SearchString) && !filter.ChangeDate.From.HasValue && !filter.ChangeDate.To.HasValue && !filter.CreationAuthor.Any())
		{
			return (ActionResult)(object)((Controller)this).RedirectToAction("List");
		}
		if (!filter.ChangeDate.From.HasValue)
		{
			filter.ChangeDate = new DateTimeRange(FeedManager.Instance.GetRealArchiveDateLimit(), filter.ChangeDate.To);
		}
		FeedMessagesSettings feedMessagesSettings = BaseMessageManager.Instance.LoadSettings();
		List<FeedModel> list;
		if (filter.Favorites)
		{
			FeedFavoriteLoadSettings settings = new FeedFavoriteLoadSettings
			{
				MaxCount = feedMessagesSettings.MessagesCount
			};
			filter.OnlyUnread = false;
			list = FeedManager.Instance.FindFavoriteMessages(settings, filter);
		}
		else
		{
			FeedLoadSettings settings2 = new FeedLoadSettings
			{
				MaxCount = feedMessagesSettings.MessagesCount,
				MaxChildCount = feedMessagesSettings.CommentsCount
			};
			list = FeedManager.Instance.FindMessages(settings2, filter);
		}
		List<CanCreateCommentItemMessage> list2 = list.Select((FeedModel m) => new CanCreateCommentItemMessage(m)).ToList();
		List<CanCreateQuestionItem> list3 = list.Select((FeedModel m) => new CanCreateQuestionItem(m.ParentObjectUid.Value, m.ParentObjectId.Value)).ToList();
		FeedManager.Instance.CanCreateComment(list2);
		FeedManager.Instance.CanCreateQuestion(list3);
		List<FeedMessageInfoModel> messageInfo = FeedManager.Instance.GetMessageInfo(list.Select((FeedModel m) => m.Id).ToList());
		FeedListModel feedListModel = new FeedListModel
		{
			MaxDaysAutoLoading = 30,
			Messages = list,
			Filter = filter,
			IsSearch = true,
			CanCreateCommentList = list2.Select((CanCreateCommentItemMessage o) => o.ToCanCreateCommentItem()).ToList(),
			CanCreateQuestionList = list3,
			FeedMessageInfoAllMessages = messageInfo,
			OnlyUnread = filter.OnlyUnread,
			Favorites = filter.Favorites
		};
		return (ActionResult)(object)((Controller)this).View("List", (object)feedListModel);
	}

	public ActionResult SearchListAjax([Bind(Prefix = "Filter")] FeedFilter filter, bool favorites = false, string changeDateHash = null)
	{
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		FeedMessagesSettings feedMessagesSettings = BaseMessageManager.Instance.LoadSettings();
		List<FeedModel> list;
		if (favorites)
		{
			FeedFavoriteLoadSettings settings = new FeedFavoriteLoadSettings
			{
				MaxCount = feedMessagesSettings.MessagesCount,
				ChangeDateHash = changeDateHash
			};
			filter.OnlyUnread = false;
			list = FeedManager.Instance.FindFavoriteMessages(settings, filter);
		}
		else
		{
			FeedLoadSettings settings2 = new FeedLoadSettings
			{
				MaxCount = feedMessagesSettings.MessagesCount,
				MaxChildCount = feedMessagesSettings.CommentsCount,
				ChangeDateHash = changeDateHash
			};
			list = FeedManager.Instance.FindMessages(settings2, filter);
		}
		List<CanCreateCommentItemMessage> list2 = list.Select((FeedModel m) => new CanCreateCommentItemMessage(m)).ToList();
		List<CanCreateQuestionItem> list3 = list.Select((FeedModel m) => new CanCreateQuestionItem(m.ParentObjectUid.Value, m.ParentObjectId.Value)).ToList();
		FeedManager.Instance.CanCreateComment(list2);
		FeedManager.Instance.CanCreateQuestion(list3);
		List<FeedMessageInfoModel> messageInfo = FeedManager.Instance.GetMessageInfo(list.Select((FeedModel m) => m.Id).ToList());
		FeedListModel model = new FeedListModel
		{
			Messages = list,
			IsAjax = true,
			Filter = filter,
			IsSearch = true,
			CanCreateCommentList = list2.Select((CanCreateCommentItemMessage o) => o.ToCanCreateCommentItem()).ToList(),
			CanCreateQuestionList = list3,
			FeedMessageInfoAllMessages = messageInfo
		};
		FeedParentsListJsonModel model2 = new FeedParentsListJsonModel
		{
			Model = model
		};
		FeedParentsListJsonCatchViewResult feedParentsListJsonCatchViewResult = new FeedParentsListJsonCatchViewResult();
		((ViewResultBase)feedParentsListJsonCatchViewResult).set_ViewName("Feed/Partial/ParentsListJson");
		ViewDataDictionary<FeedParentsListJsonModel> obj = new ViewDataDictionary<FeedParentsListJsonModel>(((ControllerBase)this).get_ViewData());
		obj.set_Model(model2);
		((ViewResultBase)feedParentsListJsonCatchViewResult).set_ViewData((ViewDataDictionary)(object)obj);
		((ViewResultBase)feedParentsListJsonCatchViewResult).set_TempData(new TempDataDictionary());
		return (ActionResult)(object)feedParentsListJsonCatchViewResult;
	}

	public ActionResult SetAsRead(string changeDateHash, long actionObjectId, Guid actionObjectUid)
	{
		//IL_000d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Expected O, but got Unknown
		FeedManager.Instance.SetAsRead(changeDateHash, actionObjectId, actionObjectUid);
		return (ActionResult)new EmptyResult();
	}

	public ActionResult FeedSetAsReadAll(string changeDateHash)
	{
		try
		{
			FeedManager.Instance.SetAsReadParents(null, changeDateHash);
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = true
			}, (JsonRequestBehavior)0);
		}
		catch (Exception)
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false
			}, (JsonRequestBehavior)0);
		}
	}

	public ActionResult PrioritySettingsPopup(string windowId, string callBackScript, string priorityTextScript)
	{
		PrioritySettingsModel prioritySettingsModel = new PrioritySettingsModel
		{
			Priority = CurrentPriority,
			PopupId = windowId,
			CallBackScript = callBackScript,
			PostController = "Feed",
			PostAction = "PrioritySettingsSave",
			PriorityTextScript = priorityTextScript
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)prioritySettingsModel);
	}

	public ActionResult PrioritySettingsSave(PrioritySettingsModel settings)
	{
		//IL_0015: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		FeedManager.Instance.SetPriority(CurrentUser, settings.Priority);
		return (ActionResult)new EmptyResult();
	}

	public ActionResult SendComment(string comment, long actionObjectId, Guid actionObjectUid, string changeDateHash)
	{
		return SendCommentWithAttachments(comment, new MessageAttachment[0], actionObjectId, actionObjectUid, changeDateHash);
	}

	public ActionResult SendCommentWithAttachments(string comment, MessageAttachment[] messageAttachments, long actionObjectId, Guid actionObjectUid, string changeDateHash)
	{
		//IL_0461: Unknown result type (might be due to invalid IL or missing references)
		//IL_046b: Expected O, but got Unknown
		string text = "";
		bool success = false;
		bool canCreateNextComment = false;
		bool flag = false;
		Guid guid = Guid.Empty;
		FeedCommentsListModel model = null;
		messageAttachments = messageAttachments ?? new MessageAttachment[0];
		List<MessageAttachment> list = new List<MessageAttachment>();
		FeedModel parentMessage = FeedManager.Instance.LoadParentMessage(actionObjectId, actionObjectUid);
		parentMessage.IsRead = true;
		parentMessage.ChildCount++;
		Func<bool> func = delegate
		{
			List<CanCreateCommentItemMessage> list3 = new List<CanCreateCommentItemMessage>
			{
				new CanCreateCommentItemMessage(parentMessage)
			};
			FeedManager.Instance.CanCreateComment(list3);
			return list3[0].CanCreateComment;
		};
		Func<bool> func2 = delegate
		{
			List<CanCreateQuestionItem> list2 = new List<CanCreateQuestionItem>
			{
				new CanCreateQuestionItem(actionObjectUid, actionObjectId)
			};
			FeedManager.Instance.CanCreateQuestion(list2);
			return list2[0].CanCreateQuestion;
		};
		try
		{
			comment = comment.Trim();
			foreach (IGrouping<Guid, MessageAttachment> group in from a in messageAttachments
				group a by a.TypeUid)
			{
				ICommentAttachmentConvertor commentAttachmentConvertor = CommentAttachmentConvertors.FirstOrDefault((ICommentAttachmentConvertor c) => c.Supported(group.Key));
				if (commentAttachmentConvertor != null)
				{
					foreach (MessageAttachment item in group)
					{
						IEntity entity = commentAttachmentConvertor.ConvertToAttachment(item.Id, item.TypeUid);
						if (entity != null)
						{
							entity.Save();
							list.Add(new MessageAttachment
							{
								TypeUid = commentAttachmentConvertor.AttachmentTypeUid,
								Id = entity.GetId().ToString()
							});
						}
						else
						{
							text = SR.T("Не удалось конвертировать объект во вложение");
						}
					}
				}
				else
				{
					text = SR.T("Не удалось найти конвертер для объекта");
				}
			}
			guid = FeedManager.Instance.CreateCommentAndSetRead(actionObjectUid, actionObjectId, comment, list.ToArray(), changeDateHash);
			flag = guid != Guid.Empty;
			if (!flag)
			{
				text = SR.T("Действие запрещено.");
			}
		}
		catch (Exception ex)
		{
			text = ex.Message;
			EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Невозможно сохранить сообщение."), ex);
		}
		if (string.IsNullOrEmpty(text))
		{
			InternalMailChannel.ReplaceTextHtml(new FeedModel
			{
				ActionObjectId = actionObjectId,
				ActionObjectUid = actionObjectUid,
				ActionUid = guid,
				IsRead = true,
				MessageAttachments = new FeedMessageAttachmentList(list),
				Parent = parentMessage,
				TextHtml = WebUtility.HtmlEncode(comment).Nl2Br(),
				CreationAuthor = CurrentUser,
				CreationDate = DateTime.Now,
				ChangeDate = DateTime.Now,
				IsParent = false,
				ParentObjectId = actionObjectId,
				ParentObjectUid = actionObjectUid
			});
			Dictionary<MessageAttachment, object> dictionary = new Dictionary<MessageAttachment, object>();
			foreach (IGrouping<Guid, MessageAttachment> item2 in from a in list
				group a by a.TypeUid)
			{
				Guid key = item2.Key;
				Type typeByUid = MetadataRuntimeService.GetTypeByUid(key);
				if (!(typeByUid != null))
				{
					continue;
				}
				IEntityManager entityManager = ModelHelper.GetEntityManager(typeByUid);
				foreach (MessageAttachment item3 in item2)
				{
					object obj = entityManager.LoadOrNull(item3.Id);
					if (obj != null)
					{
						dictionary.Add(item3, obj);
					}
				}
			}
			model = new FeedCommentsListModel
			{
				ParentMessage = parentMessage,
				IsAjax = true,
				CommentsType = FeedCommentsListType.New,
				RenderExtension = new FeedRenderService().GetExtension(actionObjectUid),
				FeedAttachments = dictionary
			};
			canCreateNextComment = func();
			success = true;
		}
		FeedCommentsListJsonModel model2 = new FeedCommentsListJsonModel
		{
			Model = model,
			CanCreateComment = flag,
			CanCreateNextComment = canCreateNextComment,
			CanCreateQuestion = func2(),
			Error = text,
			Success = success
		};
		((ControllerBase)this).get_ViewData().set_Item("UseShortView", (object)true);
		FeedCommentsListJsonCatchViewResult feedCommentsListJsonCatchViewResult = new FeedCommentsListJsonCatchViewResult();
		((ViewResultBase)feedCommentsListJsonCatchViewResult).set_ViewName("Feed/Partial/CommentsListJson");
		ViewDataDictionary<FeedCommentsListJsonModel> obj2 = new ViewDataDictionary<FeedCommentsListJsonModel>(((ControllerBase)this).get_ViewData());
		obj2.set_Model(model2);
		((ViewResultBase)feedCommentsListJsonCatchViewResult).set_ViewData((ViewDataDictionary)(object)obj2);
		((ViewResultBase)feedCommentsListJsonCatchViewResult).set_TempData(new TempDataDictionary());
		return (ActionResult)(object)feedCommentsListJsonCatchViewResult;
	}

	public ActionResult SendQuestion(string comment, long actionObjectId, Guid actionObjectUid, string changeDateHash, long? recipientId)
	{
		//IL_0298: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a2: Expected O, but got Unknown
		string text = "";
		bool success = false;
		Guid guid = Guid.Empty;
		FeedCommentsListModel model = null;
		Func<bool> func = delegate
		{
			FeedModel message = FeedManager.Instance.LoadParentMessage(actionObjectId, actionObjectUid);
			List<CanCreateCommentItemMessage> list = new List<CanCreateCommentItemMessage>
			{
				new CanCreateCommentItemMessage(message)
			};
			FeedManager.Instance.CanCreateComment(list);
			return list[0].CanCreateComment;
		};
		try
		{
			if (!recipientId.HasValue)
			{
				throw new ArgumentNullException(SR.T("Не указан исполнитель."));
			}
			comment = comment.Trim();
			IUser user = UserManager.Instance.LoadOrNull(recipientId.Value);
			guid = FeedManager.Instance.CreateQuestionAndSetRead(actionObjectUid, actionObjectId, comment, user, new MessageAttachment[0], showAll: true, changeDateHash);
			if (guid != Guid.Empty)
			{
				comment = string.Format("<div class='FeedComment-Author'>{1}: <a href='#' onclick='showUserInfo({2});return false;'>{3}</a></div>\r\n<div class='FeedCommentAddInfo'><div class='CommentAddInfoDefault'>{0}</div></div>\r\n<div class='FeedText FeedMessageTextFullSize'>{4}</div>", SR.T("Задан вопрос"), SR.T("кому"), user.Id, user.GetShortName(), comment);
			}
			else
			{
				text = SR.T("Действие запрещено.");
			}
		}
		catch (Exception ex)
		{
			text = ex.Message;
			EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Невозможно сохранить вопрос."), ex);
		}
		if (string.IsNullOrEmpty(text))
		{
			FeedModel feedModel = new FeedModel
			{
				ActionObjectId = actionObjectId,
				ActionObjectUid = actionObjectUid,
				IsRead = true
			};
			InternalMailChannel.ReplaceTextHtml(new FeedModel
			{
				ActionObjectId = actionObjectId,
				ActionObjectUid = actionObjectUid,
				ActionUid = guid,
				IsRead = true,
				Parent = feedModel,
				TextHtml = WebUtility.HtmlEncode(comment).Nl2Br(),
				CreationAuthor = CurrentUser,
				CreationDate = DateTime.Now,
				ChangeDate = DateTime.Now,
				IsParent = false,
				ParentObjectId = actionObjectId,
				ParentObjectUid = actionObjectUid
			});
			model = new FeedCommentsListModel
			{
				ParentMessage = feedModel,
				IsAjax = true,
				CommentsType = FeedCommentsListType.New,
				RenderExtension = new FeedRenderService().GetExtension(actionObjectUid),
				SystemMessage = true
			};
			success = true;
		}
		bool flag = func();
		FeedCommentsListJsonModel model2 = new FeedCommentsListJsonModel
		{
			Model = model,
			CanCreateComment = flag,
			CanCreateNextComment = flag,
			CanCreateQuestion = (guid != Guid.Empty),
			Error = text,
			Success = success
		};
		((ControllerBase)this).get_ViewData().set_Item("UseShortView", (object)true);
		FeedCommentsListJsonCatchViewResult feedCommentsListJsonCatchViewResult = new FeedCommentsListJsonCatchViewResult();
		((ViewResultBase)feedCommentsListJsonCatchViewResult).set_ViewName("Feed/Partial/CommentsListJson");
		ViewDataDictionary<FeedCommentsListJsonModel> obj = new ViewDataDictionary<FeedCommentsListJsonModel>(((ControllerBase)this).get_ViewData());
		obj.set_Model(model2);
		((ViewResultBase)feedCommentsListJsonCatchViewResult).set_ViewData((ViewDataDictionary)(object)obj);
		((ViewResultBase)feedCommentsListJsonCatchViewResult).set_TempData(new TempDataDictionary());
		return (ActionResult)(object)feedCommentsListJsonCatchViewResult;
	}

	public ActionResult FavoriteLikeAjax(long actionObjectId, Guid actionObjectUid, bool like)
	{
		bool success = false;
		string error = "";
		FeedManager instance = FeedManager.Instance;
		try
		{
			if (like)
			{
				instance.AddToFavorite(actionObjectUid, actionObjectId);
			}
			else
			{
				instance.DeleteFromFavorite(actionObjectUid, actionObjectId);
			}
			success = true;
		}
		catch (Exception ex)
		{
			error = ex.Message;
			EleWise.ELMA.Logging.Logger.Log.Error(SR.T("Невозможно сохранить сообщение."), ex);
		}
		return (ActionResult)(object)((Controller)this).Json((object)new { success, error }, (JsonRequestBehavior)0);
	}

	[HttpPost]
	public ActionResult OrderCommentsHistory(OrderCommentsHistoryParams parameters)
	{
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		HistoryOrder.SetOrderType(parameters.CommentsSortDirection, new HistoryIdParams
		{
			Id = parameters.MessageId.ToString(),
			TypeUid = InterfaceActivator.UID<IChannelMessage>()
		});
		return (ActionResult)new EmptyResult();
	}

	[HttpPost]
	public PartialViewResult CommentAttachments(IEnumerable<MessageAttachmentModel> model)
	{
		if (model == null)
		{
			return null;
		}
		MessageAttachment[] array = model.Select((MessageAttachmentModel x) => new MessageAttachment(x.Name, x.TypeUid, x.Id)).ToArray();
		Dictionary<MessageAttachment, object> feedAttachments = new FeedRenderService().GetAttachments(array);
		Dictionary<MessageAttachment, object> dictionary = array.Where((MessageAttachment x) => feedAttachments.ContainsKey(x)).ToDictionary((MessageAttachment x) => x, (MessageAttachment x) => feedAttachments[x]);
		((ControllerBase)this).get_ViewData().set_Item("UseShortView", (object)true);
		return ((Controller)this).PartialView("Partial/CommentAttachments", (object)dictionary);
	}

	private FeedCommentsListModel CreateFeedCommentsListModel(long actionObjectId, Guid actionObjectUid, string changeDateHash, long loadCommentCount, string commentChangeDateHash, long parentChildCount, long parentChildUnreadCount)
	{
		FeedManager.Instance.SetAsRead(commentChangeDateHash, actionObjectId, actionObjectUid);
		FeedLoadSettings settings = new FeedLoadSettings
		{
			MaxCount = 10,
			MaxChildCount = 10,
			ChangeDateHash = changeDateHash
		};
		FeedModel feedModel = FeedManager.Instance.LoadComments(actionObjectId, actionObjectUid, settings);
		FeedRenderService feedRenderService = new FeedRenderService();
		FeedRenderService feedRenderService2 = new FeedRenderService();
		return new FeedCommentsListModel
		{
			ParentMessage = feedModel,
			ParentChildCount = parentChildCount,
			ParentChildUnreadCount = parentChildUnreadCount,
			LoadCommentCount = loadCommentCount + feedModel.Messages.Count,
			IsAjax = true,
			RenderExtension = feedRenderService2.GetExtension(feedModel.ParentObjectUid.Value),
			CommentsType = FeedCommentsListType.Previous,
			FeedAttachments = feedRenderService.GetAttachments(new List<FeedModel> { feedModel })
		};
	}
}
