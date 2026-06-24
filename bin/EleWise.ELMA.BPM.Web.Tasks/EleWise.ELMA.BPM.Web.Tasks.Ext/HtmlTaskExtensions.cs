using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using System.Web.Routing;
using EleWise.ELMA.BPM.Web.Tasks.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Html.Selectors;
using EleWise.ELMA.Web.Mvc.Models.Selectors;
using Telerik.Web.Mvc.UI;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

public static class HtmlTaskExtensions
{
	private static IEnumerable<ITaskAttachmetSpecifiedExtension> taskAttachmetSpecifiedExtension;

	private static IEnumerable<ITaskAttachmetSpecifiedViewExtension> taskAttachmetSpecifiedViewExtension;

	private static IEnumerable<ITaskAttachmetSpecifiedExtension> TaskAttachmetSpecifiedExtension => taskAttachmetSpecifiedExtension ?? (taskAttachmetSpecifiedExtension = ComponentManager.Current.GetExtensionPoints<ITaskAttachmetSpecifiedExtension>());

	private static IEnumerable<ITaskAttachmetSpecifiedViewExtension> TaskAttachmetSpecifiedViewExtension => taskAttachmetSpecifiedViewExtension ?? (taskAttachmetSpecifiedViewExtension = ComponentManager.Current.GetExtensionPoints<ITaskAttachmetSpecifiedViewExtension>());

	public static string GetDepartmentTaskDataFilter(this HtmlHelper htmlHelper, DepartmentTasksModel model)
	{
		switch (model.SearchTasksType)
		{
		case SearchTasksType.ForDepartmentCurrent:
		case SearchTasksType.ForDepartmentExpired:
		case SearchTasksType.ForDepartmentClosed:
			return "DataFilter.Executor.Id";
		case SearchTasksType.FromDepartmentCurrent:
		case SearchTasksType.FromDepartmentExpired:
		case SearchTasksType.FromDepartmentCompleted:
		case SearchTasksType.FromDepartmentClosed:
			return "DataFilter.CreationAuthor.Id";
		case SearchTasksType.ForDepartmentControl:
			return "DataFilter.ControlUser.Id";
		default:
			return "DataFilter.InformTo[0].Id";
		}
	}

	public static string PriorityRow(this HtmlHelper htmlHelper, ITaskBase task)
	{
		IEnumerable<ITaskRowStyles> extensionPoints = ComponentManager.Current.GetExtensionPoints<ITaskRowStyles>(useCache: true);
		if (extensionPoints.Any())
		{
			ITaskRowStyles taskRowStyles = extensionPoints.FirstOrDefault((ITaskRowStyles i) => i.IsValid(task));
			if (taskRowStyles != null)
			{
				return taskRowStyles.GetClass(task);
			}
		}
		return string.Empty;
	}

	public static void AddParentTaskTab(this TabPanelItemsBuilder tabs, ITaskBase task, string action, string conroller, object routeValues, string message = null)
	{
		tabs.AddParentTaskTab(task, action, conroller, routeValues, null, message);
	}

	public static void AddParentTaskTab(this TabPanelItemsBuilder tabs, ITaskBase task, string action, string conroller, object routeValues, int? tabIndex, string message = null)
	{
		if (task != null && Locator.GetServiceNotNull<ISecurityService>().HasPermission(EleWise.ELMA.Tasks.PermissionProvider.ViewTaskPermission, task))
		{
			RouteValueDictionary routeValueDictionary = new RouteValueDictionary(routeValues);
			routeValueDictionary.Add("id", task.Id);
			TabPanelItem tabPanelItem = new TabPanelItem();
			((NavigationItem<TabStripItem>)(object)tabPanelItem).set_Text(string.Format(message ?? SR.T("Родительская задача ({0})"), task.Subject.Trunk(12, "...")));
			((TabStripItem)tabPanelItem).set_ContentUrl(tabs.GetHtml().Url().Action(action, conroller, routeValueDictionary));
			tabPanelItem.TabIndex = tabIndex;
			tabs.Add(tabPanelItem);
		}
	}

	public static MvcHtmlString ReAssignTaskWindow(this HtmlHelper html, ReAssignTaskViewModel model)
	{
		if (model == null)
		{
			throw new ArgumentNullException("model");
		}
		if (model.Task == null)
		{
			throw new ArgumentException("model.Task == null");
		}
		using (IEnumerator<ITaskActionRenderer> enumerator = (from e in ComponentManager.Current.GetExtensionPoints<ITaskActionRenderer>()
			where e.CanRender(model)
			select e).GetEnumerator())
		{
			if (enumerator.MoveNext())
			{
				return enumerator.Current.Render(html, model);
			}
		}
		return html.AdaptivePopupWindow(model.PopupId, SR.T("Переназначить задачу"), html.Url().Action("ReAssignTaskForm", "Task", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Tasks",
			taskId = model.Task.Id,
			PopupId = model.PopupId,
			RequiredStartDate = model.RequiredStartDate,
			RequiredEndDate = model.RequiredEndDate,
			HideStartDate = model.HideStartDate,
			HideEndDate = model.HideEndDate,
			RedirectUrl = model.RedirectUrl,
			ReAssigneClick = model.ReAssigneClick,
			NeedCheckOrganizationItem = model.NeedCheckOrganizationItem,
			HideReAssignTaskPriority = model.HideReAssignTaskPriority,
			IsAjax = model.IsAjax,
			ExecutorFilterProvider = model.ExecutorFilterProvider,
			ExecutorFilterData = model.ExecutorFilterData
		}), UIWindowSize.M);
	}

	public static MvcHtmlString TaskActions(this HtmlHelper html, TaskActionsModel model)
	{
		return PartialExtensions.Partial(html, "TaskActions", (object)model);
	}

	public static MvcHtmlString TaskCreator(this HtmlHelper html, TaskCreatorModel model)
	{
		return PartialExtensions.Partial(html, "Task/TaskCreator", (object)model);
	}

	public static MvcHtmlString TaskCreator(this HtmlHelper html, ITaskBase task, string hidden = null, bool checkReplacement = true)
	{
		TaskCreatorModel taskCreatorModel = new TaskCreatorModel
		{
			ParentTask = task,
			CheckReplacement = checkReplacement
		};
		if (!string.IsNullOrEmpty(hidden))
		{
			taskCreatorModel.Hidden = hidden;
		}
		return html.TaskCreator(taskCreatorModel);
	}

	public static MvcHtmlString TaskMarkRead(this HtmlHelper html, ITaskBase task)
	{
		return PartialExtensions.Partial(html, "Task/MarkRead", (object)task);
	}

	public static MvcHtmlString TaskGeneralInfo(this HtmlHelper html, ITaskBase task, bool? needApproval, bool? needHistory)
	{
		TaskViewModel taskViewModel = new TaskViewModel
		{
			Entity = task,
			NeedApproval = (!needApproval.HasValue || needApproval.Value),
			NeedHistory = (!needHistory.HasValue || needHistory.Value)
		};
		return PartialExtensions.Partial(html, "Task/GeneralInfo", (object)taskViewModel);
	}

	public static MvcHtmlString AttachmentsHash(this HtmlHelper html, ITaskBase newTask, ITaskBase oldTask = null, bool? onlyNew = null)
	{
		Dictionary<string, IEnumerable<long>> attachmentsInfo = GetAttachmentsInfo(newTask);
		Dictionary<string, IEnumerable<long>> dictionary = (onlyNew.HasValue ? GetAttachmentsInfo(oldTask) : null) ?? CreateAttachmentsInfo();
		if (attachmentsInfo != null)
		{
			StringBuilder stringBuilder = new StringBuilder();
			foreach (ITaskAttachmetSpecifiedExtension extension in TaskAttachmetSpecifiedExtension)
			{
				ITaskAttachmetSpecifiedViewExtension taskAttachmetSpecifiedViewExtension = TaskAttachmetSpecifiedViewExtension.FirstOrDefault((ITaskAttachmetSpecifiedViewExtension ext) => ext.Name == extension.Name);
				if (taskAttachmetSpecifiedViewExtension != null)
				{
					IEnumerable<long> enumerable = attachmentsInfo[extension.Name];
					IEnumerable<long> enumerable2 = dictionary[extension.Name];
					long[] array = ((!onlyNew.HasValue) ? enumerable : (onlyNew.Value ? enumerable.Except(enumerable2) : enumerable2.Except(enumerable))).ToArray();
					if (array.Length != 0)
					{
						stringBuilder.Append(taskAttachmetSpecifiedViewExtension.Attachments(html, extension.GetAttachments(array)));
					}
				}
			}
			if (!(stringBuilder.ToString() != ""))
			{
				return MvcHtmlString.Empty;
			}
			return MvcHtmlString.Create(stringBuilder.ToString());
		}
		return MvcHtmlString.Empty;
	}

	private static Dictionary<string, IEnumerable<long>> GetAttachmentsInfo(ITaskBase task)
	{
		if (task == null)
		{
			return null;
		}
		Dictionary<string, IEnumerable<long>> dictionary = CreateAttachmentsInfo();
		string[] array = task.AttachmentSpecifiedHash.Split(';');
		for (int i = 0; i < array.Length; i++)
		{
			string[] array2 = array[i].Split(':');
			if (array2.Length <= 1)
			{
				continue;
			}
			dictionary.TryGetValue(array2[0], out var value);
			if (value != null && !string.IsNullOrEmpty(array2[1]))
			{
				long[] array3 = (from id in array2[1].Split(',')
					select Convert.ToInt64(id)).ToArray();
				if (array3.Length != 0)
				{
					dictionary[array2[0]] = array3;
				}
			}
		}
		return dictionary;
	}

	private static Dictionary<string, IEnumerable<long>> CreateAttachmentsInfo()
	{
		Dictionary<string, IEnumerable<long>> dictionary = new Dictionary<string, IEnumerable<long>>();
		foreach (ITaskAttachmetSpecifiedExtension item in TaskAttachmetSpecifiedExtension)
		{
			dictionary.Add(item.Name, new List<long>());
		}
		return dictionary;
	}
}
