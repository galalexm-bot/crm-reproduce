using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Enums;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Selectors;
using EleWise.ELMA.Web.Mvc.Models.Selectors;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

public static class TaskExtension
{
	public const string RED = "#FF0000";

	public const string GREEN = "#008000";

	public const string BLUE_CURRENTCONTROL = "#3366CC";

	public const string RED_COMPLETE = "#FF5F0F";

	public const string GREEN_COMPLETE = "#006600";

	public const string UNKNOWN = "#666666";

	public const string BaseGreen = "#68BA78";

	public const string BaseRed = "#DD1717";

	public const string BaseYellow = "#FCD109";

	public static string Icon(this HtmlHelper htmlHelper, ITaskBase task)
	{
		if (task.Status == TaskBaseStatus.Complete)
		{
			return "#complete.svg";
		}
		return htmlHelper.Url().ObjectIcon(ObjectIconFormat.x16, task) ?? "#company_menu.svg";
	}

	public static MvcHtmlString PlannedLink(this HtmlHelper htmlHelper, ITaskBase task)
	{
		if (task == null || task.Executor == null)
		{
			return MvcHtmlString.Empty;
		}
		if (((IEnumerable<ITaskTimePlan>)task.TimeSet).Any())
		{
			return MvcHtmlString.Create(htmlHelper.ImageButton("#calendar_done.svg").Size(UISize.Small).Attributes(new
			{
				tooltiptext = string.Join("<br />", ((IEnumerable<ITaskTimePlan>)task.TimeSet).Select((ITaskTimePlan t) => t.StartTime.ToShortDateString() + " " + t.StartTime.ToShortTimeString() + " - " + t.EndTime.ToShortDateString() + " " + t.EndTime.ToShortTimeString()).ToArray())
			})
				.Disabled()
				.ToHtmlString());
		}
		bool flag = TaskBaseManager.Instance.CanSchedule(task, DateTime.MinValue, DateTime.MaxValue);
		object obj;
		if (!flag)
		{
			obj = null;
		}
		else
		{
			Guid uid = TaskCalendarItemProvider._uid;
			obj = uid.ToString();
		}
		string providerUid = (string)obj;
		string text = htmlHelper.Url().Action("PopupUserView", "Scheduler", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Calendar",
			providerUid = providerUid,
			id = task.Executor.Id,
			date = (((IEnumerable<ITaskTimePlan>)task.TimeSet).Any() ? ((IEnumerable<ITaskTimePlan>)task.TimeSet).Last().StartTime.ToString() : DateTime.Now.ToString()),
			itemId = task.Id
		});
		string text2 = HttpUtility.JavaScriptStringEncode(SR.T(task.Subject)).Replace("\\\"", "\\u0022");
		string click = "createAndLoadWindow('schedulePopup', { title: '" + SR.T("Календарь") + "', html: '', widthMode: 'xl', height: elma.getSchedulePopupContentHeight(), onCloseScript: 'onCloseEndDatePopup()'}, '" + text + "', { itemTheme: '" + text2 + "' }, false)";
		return MvcHtmlString.Create(htmlHelper.ImageButton("#calendar.svg").Size(UISize.Small).Attributes(new
		{
			tooltiptext = (flag ? SR.T("Запланировать") : "")
		})
			.Click(click)
			.ToHtmlString());
	}

	public static MvcHtmlString StatusLink(this HtmlHelper htmlHelper, ITaskBase task)
	{
		return htmlHelper.StatusLink(task, completeAlwaysThrough: true);
	}

	public static MvcHtmlString StatusLink(this HtmlHelper htmlHelper, ITaskBase task, bool completeAlwaysThrough)
	{
		return htmlHelper.StatusLink(task, showInfo: true, false, completeAlwaysThrough, false);
	}

	public static MvcHtmlString StatusLink(this HtmlHelper htmlHelper, ITaskBase task, bool showInfo, bool? showAuthor = false, bool? completeAlwaysThrough = false, bool? inNewTab = false)
	{
		return htmlHelper.StatusLink(task, showInfo, null, showAuthor.HasValue && showAuthor.Value, completeAlwaysThrough.HasValue && completeAlwaysThrough.Value, "", inNewTab);
	}

	public static MvcHtmlString StatusLink(this HtmlHelper htmlHelper, ITaskBase task, bool showInfo, out string infoText, bool? showAuthor = false, bool? completeAlwaysThrough = false, bool? inNewTab = false)
	{
		return htmlHelper.StatusLink(task, showInfo, null, showAuthor.HasValue && showAuthor.Value, completeAlwaysThrough.HasValue && completeAlwaysThrough.Value, out infoText, "", inNewTab);
	}

	public static MvcHtmlString StatusLink(this HtmlHelper htmlHelper, ITaskBase task, bool showInfo, string url, bool showAuthor, bool completeAlwaysThrough, string defaultTitle = "", bool? inNewTab = false)
	{
		string infoText;
		return htmlHelper.StatusLink(task, showInfo, url, showAuthor, completeAlwaysThrough, out infoText, defaultTitle, inNewTab);
	}

	public static MvcHtmlString StatusLink(this HtmlHelper htmlHelper, ITaskBase task, bool showInfo, string url, bool showAuthor, bool completeAlwaysThrough, out string infoText, string defaultTitle = "", bool? inNewTab = false)
	{
		return htmlHelper.StatusLink(task, showInfo, url, showAuthor, completeAlwaysThrough, out infoText, defaultTitle, inNewTab, showTaskIcon: false, showDescription: true);
	}

	public static MvcHtmlString StatusLink(this HtmlHelper htmlHelper, ITaskBase task, bool showInfo, string url, bool showAuthor, bool completeAlwaysThrough, out string infoText, string defaultTitle, bool? inNewTab, bool showTaskIcon, bool showDescription)
	{
		TaskStatusLinkModel taskStatusLinkModel = new TaskStatusLinkModel(task)
		{
			ShowInfo = showInfo,
			Url = url,
			ShowAuthor = showAuthor,
			CompleteAlwaysThrough = completeAlwaysThrough,
			DefaultTitle = defaultTitle,
			InNewTab = inNewTab,
			ShowTaskIcon = showTaskIcon,
			ShowDescription = showDescription
		};
		MvcHtmlString result = htmlHelper.StatusLink(taskStatusLinkModel);
		infoText = taskStatusLinkModel.InfoText;
		return result;
	}

	internal static MvcHtmlString StatusLink(this HtmlHelper htmlHelper, TaskStatusLinkModel statusLinkModel)
	{
		//IL_0040: Unknown result type (might be due to invalid IL or missing references)
		//IL_0046: Expected O, but got Unknown
		//IL_0367: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0479: Unknown result type (might be due to invalid IL or missing references)
		//IL_0480: Expected O, but got Unknown
		//IL_0549: Unknown result type (might be due to invalid IL or missing references)
		//IL_0550: Expected O, but got Unknown
		//IL_056c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0572: Expected O, but got Unknown
		ITaskBase task = statusLinkModel.Task;
		string text = SR.T(task.Subject);
		if (string.IsNullOrEmpty(text))
		{
			text = statusLinkModel.DefaultTitle ?? SR.Untitled;
		}
		TagBuilder val = new TagBuilder("a");
		task = task.CastAsRealType();
		val.MergeAttribute("href", string.IsNullOrEmpty(statusLinkModel.Url) ? htmlHelper.Url().Entity(task) : statusLinkModel.Url, true);
		if (statusLinkModel.InNewTab ?? false)
		{
			val.MergeAttribute("target", "_blank");
		}
		val.SetInnerText(text);
		if (task.Status == TaskBaseStatus.NewOrder || task.Status == TaskBaseStatus.OnApproval)
		{
			val.AddCssClass(task.Status.Name);
		}
		if (task.Status == TaskBaseStatus.CompleteControlled || task.Status == TaskBaseStatus.IncompleteControlled || task.Status == TaskBaseStatus.WasClosed)
		{
			val.AddCssClass("lineThrough");
			if (task.Status == TaskBaseStatus.CompleteControlled)
			{
				val.AddCssClass(task.Status.Name);
			}
			if (task.Status == TaskBaseStatus.IncompleteControlled)
			{
				val.AddCssClass(task.Status.Name);
			}
		}
		else if (task.Status == TaskBaseStatus.Incomplete || task.Status == TaskBaseStatus.IncompleteNeedControl || task.Status == TaskBaseStatus.RefuseApproval || task.Status == TaskBaseStatus.RefuseApprovalExecutor)
		{
			val.AddCssClass(task.Status.Name);
		}
		else if (task.Status == TaskBaseStatus.Complete || task.Status == TaskBaseStatus.CompleteNeedControl)
		{
			if (statusLinkModel.CompleteAlwaysThrough)
			{
				val.AddCssClass("lineThrough");
			}
			val.AddCssClass(task.Status.Name);
		}
		else if (task.EndDate < DateTime.Now)
		{
			val.AddCssClass("TaskExpired");
		}
		else if (task.Status == TaskBaseStatus.InProgress)
		{
			val.AddCssClass(task.Status.Name);
		}
		MvcHtmlString val2 = null;
		if (statusLinkModel.ShowTaskIcon)
		{
			IEnumerable<ITaskRowStyles> extensionPoints = ComponentManager.Current.GetExtensionPoints<ITaskRowStyles>(useCache: true);
			if (extensionPoints.Any())
			{
				ITaskRowStyles taskRowStyles = extensionPoints.FirstOrDefault((ITaskRowStyles t) => t.IsValid(task));
				if (taskRowStyles != null)
				{
					val2 = taskRowStyles.GetIcon(htmlHelper, task);
				}
			}
			if (val2 == null)
			{
				val2 = htmlHelper.Image(htmlHelper.Icon(task), "", new
				{
					@class = "taskStatusLinkIcon"
				});
			}
		}
		else
		{
			val2 = MvcHtmlString.Empty;
		}
		TagBuilder val3 = new TagBuilder("span");
		val3.MergeAttribute("class", "taskStatusLink", true);
		StringBuilder stringBuilder = new StringBuilder().Append(val2).Append(val.ToString((TagRenderMode)0));
		if (statusLinkModel.TaskLinkAdditionalInfo && !string.IsNullOrEmpty(statusLinkModel.TaskLinkAdditionalInfoViewName))
		{
			stringBuilder.Append(((HtmlString)(object)PartialExtensions.Partial(htmlHelper, statusLinkModel.TaskLinkAdditionalInfoViewName, (object)task)).ToHtmlString());
		}
		val3.set_InnerHtml(stringBuilder.ToString());
		string text2 = val3.ToString((TagRenderMode)0);
		string text3 = "";
		if (statusLinkModel.ShowDescription)
		{
			if (!string.IsNullOrEmpty(statusLinkModel.DescriptionViewName))
			{
				text3 = ((HtmlString)(object)PartialExtensions.Partial(htmlHelper, statusLinkModel.DescriptionViewName, (object)task)).ToHtmlString();
			}
			else
			{
				ITaskStatusLinkDescription taskStatusLinkDescription = ComponentManager.Current.GetExtensionPoints<ITaskStatusLinkDescription>().FirstOrDefault((ITaskStatusLinkDescription e) => e.CheckType(task));
				if (taskStatusLinkDescription != null)
				{
					text3 = ((object)taskStatusLinkDescription.Description(htmlHelper, task)).ToString();
				}
				else
				{
					NamedMetadata namedMetadata = (NamedMetadata)Locator.GetService<IMetadataRuntimeService>().GetMetadata(task.TypeUid);
					TagBuilder val4 = new TagBuilder("span");
					val4.AddCssClass("task-description-statusLink");
					string text4 = null;
					text4 = ((!statusLinkModel.ShowAuthor) ? ((namedMetadata != null && !string.IsNullOrEmpty(namedMetadata.DisplayName)) ? namedMetadata.DisplayName : SR.T("Задача")) : SR.T("{0} ({1})", (namedMetadata != null && !string.IsNullOrEmpty(namedMetadata.DisplayName)) ? namedMetadata.DisplayName : SR.T("Задача"), ((HtmlString)(object)PartialExtensions.Partial(htmlHelper, "DisplayTemplates/Entities/User", (object)task.CreationAuthor)).ToHtmlString()));
					val4.set_InnerHtml(text4);
					text3 = val4.ToString((TagRenderMode)0);
				}
			}
		}
		statusLinkModel.InfoText = text3;
		if (statusLinkModel.ShowInfo && !string.IsNullOrEmpty(text3))
		{
			TagBuilder val5 = new TagBuilder("div");
			val5.set_InnerHtml(text3);
			text2 += val5.ToString((TagRenderMode)0);
		}
		return new MvcHtmlString(text2);
	}

	public static MvcHtmlString CardStatusLink(this HtmlHelper htmlHelper, ITaskBase task, MvcHtmlString preparedStatusLinkString)
	{
		return htmlHelper.CardStatusLink(task, (Func<(MvcHtmlString, string)>)(() => (preparedStatusLinkString, "")));
	}

	public static MvcHtmlString CardStatusLink(this HtmlHelper htmlHelper, ITaskBase task)
	{
		string infoText;
		return htmlHelper.CardStatusLink(task, (Func<(MvcHtmlString, string)>)(() => (htmlHelper.StatusLink(task, showInfo: false, null, showAuthor: false, completeAlwaysThrough: true, out infoText, "", false, showTaskIcon: true, showDescription: false), infoText)));
	}

	public static MvcHtmlString CardStatusLink(this HtmlHelper htmlHelper, ITaskBase task, Func<(MvcHtmlString, string)> StatusLinkRender)
	{
		//IL_006f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		//IL_009b: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a1: Expected O, but got Unknown
		//IL_00b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d9: Expected O, but got Unknown
		//IL_00d4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00de: Expected O, but got Unknown
		//IL_0119: Unknown result type (might be due to invalid IL or missing references)
		//IL_0120: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0161: Expected O, but got Unknown
		//IL_01b7: Unknown result type (might be due to invalid IL or missing references)
		//IL_01bd: Expected O, but got Unknown
		GridDataFilter<ITaskBase> gridDataFilter = htmlHelper.get_ViewData().get_Model() as GridDataFilter<ITaskBase>;
		TaskGridModel taskGridModel = htmlHelper.get_ViewData().get_Model() as TaskGridModel;
		bool num = ((htmlHelper.get_ViewData().get_Item("SearchTasksType") != null) ? ((SearchTasksType)htmlHelper.get_ViewData().get_Item("SearchTasksType") == SearchTasksType.Outgoing) : (taskGridModel != null && (taskGridModel.SearchTasksType == SearchTasksType.Search || taskGridModel.SearchTasksType == SearchTasksType.ClosePeriodTasks)));
		TagBuilder val = new TagBuilder("div");
		val.set_InnerHtml(((HtmlString)(object)StatusLinkRender().Item1).ToHtmlString());
		TagBuilder val2 = val;
		val2.AddCssClass("task-status-link-container");
		TagBuilder val3 = new TagBuilder("div");
		val3.AddCssClass("task-end-date-container");
		ViewDataDictionary val4 = new ViewDataDictionary();
		val4.Add("GridId", (object)((gridDataFilter != null) ? gridDataFilter.GridId : ""));
		val3.set_InnerHtml(((HtmlString)(object)PartialExtensions.Partial(htmlHelper, "AllTasks/EndDateGridTemplate", (object)task, new ViewDataDictionary(val4))).ToHtmlString());
		string arg;
		IUser user;
		if (num)
		{
			arg = SR.T("Кому");
			user = task.Executor;
		}
		else
		{
			arg = SR.T("От");
			user = task.CreationAuthor;
		}
		TagBuilder val5 = new TagBuilder("div");
		val5.AddCssClass("task-author-container");
		if (user != null)
		{
			val5.set_InnerHtml($"<div style=\"float:left;\">{arg}:&nbsp;</div>" + PartialExtensions.Partial(htmlHelper, "DisplayTemplates/Entities/User", (object)user));
		}
		TagBuilder val6 = new TagBuilder("div");
		val6.AddCssClass("additional-task-info");
		val6.set_InnerHtml(val5.ToString((TagRenderMode)0) + val3.ToString((TagRenderMode)0));
		if (user == null)
		{
			val2.AddCssClass("empty-task-author");
			val6.AddCssClass("empty-task-author");
		}
		return new MvcHtmlString(val2.ToString((TagRenderMode)0) + val6.ToString((TagRenderMode)0));
	}

	public static MvcHtmlString TaskQuickActionsButton(this HtmlHelper htmlHelper, ITaskBase task, string prefix)
	{
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000b: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0099: Expected O, but got Unknown
		TagBuilder val = new TagBuilder("div");
		if (task != null)
		{
			Dictionary<string, string> dictionary = new Dictionary<string, string>
			{
				{
					"id",
					$"TaskQuickActions{prefix}_{task.Id}"
				},
				{ "class", "task-menu-icon TaskQuickActions" },
				{ "dynamicloadmodepanel", "3" },
				{
					"dynamicurl",
					htmlHelper.Url().Action("GetTaskQuickActions", "AllTasks", (object)new
					{
						area = "EleWise.ELMA.BPM.Web.Tasks",
						id = task.Id
					})
				}
			};
			val.MergeAttributes<string, string>((IDictionary<string, string>)dictionary);
		}
		return new MvcHtmlString(val.ToString((TagRenderMode)0));
	}

	public static MvcHtmlString TaskCommentPopup(this HtmlHelper html, TaskCommentModel commentModel)
	{
		using (IEnumerator<ITaskActionRenderer> enumerator = (from e in ComponentManager.Current.GetExtensionPoints<ITaskActionRenderer>()
			where e.CanRender(commentModel)
			select e).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				return enumerator.Current.Render(html, commentModel);
			}
		}
		return html.PopupWindow(commentModel.PopupId, commentModel.ActionName, delegate
		{
			//IL_001c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0022: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_003d: Expected O, but got Unknown
			//IL_0042: Expected O, but got Unknown
			HtmlHelper obj = html;
			TaskCommentModel taskCommentModel = commentModel;
			ViewDataDictionary val = new ViewDataDictionary(html.get_ViewData());
			TemplateInfo val2 = new TemplateInfo();
			val2.set_HtmlFieldPrefix(commentModel.HtmlPrefix);
			val.set_TemplateInfo(val2);
			return PartialExtensions.Partial(obj, "Task/Partial/TaskComment", (object)taskCommentModel, val);
		});
	}

	public static MvcHtmlString TaskCommentPopupDynamic(this HtmlHelper html, TaskCommentModel commentModel)
	{
		using (IEnumerator<ITaskActionRenderer> enumerator = (from e in ComponentManager.Current.GetExtensionPoints<ITaskActionRenderer>()
			where e.CanRender(commentModel)
			select e).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				return enumerator.Current.Render(html, commentModel);
			}
		}
		return html.PopupWindow(commentModel.PopupId, commentModel.ActionName, html.Url().Action("TaskComment", "Task", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			PostAction = commentModel.PostAction,
			PostController = commentModel.PostController,
			PostArea = commentModel.PostArea,
			PopupId = commentModel.PopupId,
			ActionName = commentModel.ActionName,
			ObjectId = commentModel.ObjectId,
			ObjectTypeUid = commentModel.ObjectTypeUid,
			ShowAttachment = commentModel.ShowAttachment,
			HtmlPrefix = commentModel.HtmlPrefix,
			ShowWorkLog = commentModel.ShowWorkLog,
			RedirectUrl = commentModel.RedirectUrl,
			ShowAlertInform = commentModel.ShowAlertInform
		}));
	}

	public static string RowClassStatus(this HtmlHelper html, ITaskBase task)
	{
		if (task.Status == TaskBaseStatus.NewOrder)
		{
			return "newOrder";
		}
		if (task.Status == TaskBaseStatus.OnApproval)
		{
			return "onApproval";
		}
		if (task.Status == TaskBaseStatus.CompleteControlled)
		{
			return "completeControlled";
		}
		if (task.Status == TaskBaseStatus.IncompleteControlled)
		{
			return "incompleteControlled";
		}
		if (task.Status == TaskBaseStatus.WasClosed)
		{
			return "wasClosed";
		}
		if (task.Status == TaskBaseStatus.Incomplete)
		{
			return "incomplete";
		}
		if (task.Status == TaskBaseStatus.RefuseApproval)
		{
			return "refuseApproval";
		}
		if (task.Status == TaskBaseStatus.RefuseApprovalExecutor)
		{
			return "refuseApprovalExecutor";
		}
		if (task.Status == TaskBaseStatus.Complete)
		{
			return "complete";
		}
		if (task.Status == TaskBaseStatus.InProgress)
		{
			return "inProgress";
		}
		if (task.EndDate < DateTime.Now)
		{
			return "overdue";
		}
		return "";
	}

	public static void AddSubTaskTab(this HtmlHelper html, TabPanelItemsBuilder tabs, ITaskBase task, bool isSelected, string returnUrl = null)
	{
		html.AddSubTaskTab(tabs, task, isSelected, null, returnUrl);
	}

	public static void AddSubTaskTab(this HtmlHelper html, TabPanelItemsBuilder tabs, ITaskBase task, bool isSelected, int? tabIndex, string returnUrl = null)
	{
		if (task.ChildTasks != null && ((ICollection<ITaskBase>)task.ChildTasks).Count > 0)
		{
			TabPanelItem tabPanelItem = new TabPanelItem();
			((NavigationItem<TabStripItem>)(object)tabPanelItem).set_Text(SR.T("Подзадачи"));
			((NavigationItem<TabStripItem>)(object)tabPanelItem).set_Selected(isSelected || GetSelectedTabParamFromRequest(html));
			((TabStripItem)tabPanelItem).set_ContentUrl(html.Url().Action("SubTasksGrid", "AllTasks", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks",
				parentTaskId = task.Id
			}));
			tabPanelItem.TabIndex = tabIndex;
			tabs.Add(tabPanelItem);
		}
	}

	public static MvcHtmlString SubTaskSelector(this HtmlHelper html, ITaskBase parentTask, string redirectUrl = null)
	{
		return html.SubTaskSelector(parentTask, redirectUrl, isAjaxParam: false);
	}

	public static MvcHtmlString SubTaskSelector(this HtmlHelper html, ITaskBase parentTask, string redirectUrl, bool isAjaxParam)
	{
		IEnumerable<ICreateSubtaskExtension> source = from e in ComponentManager.Current.GetExtensionPoints<ICreateSubtaskExtension>()
			where e.CanCreateSubtaskFrom(parentTask)
			select e;
		List<SubTaskTypeSelectorModel.SelectorItem> list = source.Select((ICreateSubtaskExtension t) => new SubTaskTypeSelectorModel.SelectorItem
		{
			KeyValue = t.SubTaskTypeUid,
			Text = t.SubTaskTypeName
		}).ToList();
		int num = list.FindIndex((SubTaskTypeSelectorModel.SelectorItem si) => si.KeyValue == parentTask.TypeUid);
		if (num < 0)
		{
			ICreateSubtaskExtension parentTaskExtension = source.FirstOrDefault((ICreateSubtaskExtension ext) => ext.ParentTaskTypeUid == parentTask.TypeUid);
			if (parentTaskExtension != null)
			{
				num = list.FindIndex((SubTaskTypeSelectorModel.SelectorItem si) => si.KeyValue == parentTaskExtension.SubTaskTypeUid);
			}
		}
		if (num < 0)
		{
			num = 0;
		}
		SubTaskTypeSelectorModel subTaskTypeSelectorModel = new SubTaskTypeSelectorModel
		{
			ActionUrlBase = html.Url().Action("SubTaskType", "Task", (object)new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks",
				parentId = parentTask.Id,
				returnUrl = redirectUrl,
				isAjax = isAjaxParam
			}),
			SelectorValues = list,
			SelectedIndex = num,
			IsAjax = isAjaxParam
		};
		return PartialExtensions.Partial(html, "SubTask/Partial/SubTaskTypeSelector", (object)subTaskTypeSelectorModel);
	}

	public static bool SelectedTabFromRequestIsSubTasksTab(HttpRequestBase request, ViewDataDictionary viewData)
	{
		return (string)(request.Params["SelectedTab"] ?? request.Params["SeletedTab"] ?? viewData.get_Item("SelectedTab") ?? viewData.get_Item("SeletedTab")) == "TabSubTasks";
	}

	private static bool GetSelectedTabParamFromRequest(HtmlHelper html)
	{
		HttpRequestBase request = ((ControllerContext)html.get_ViewContext()).get_HttpContext().Request;
		ViewDataDictionary viewData = html.get_ViewData();
		return SelectedTabFromRequestIsSubTasksTab(request, viewData);
	}
}
