using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using Telerik.Web.Mvc.UI.DropDown;

namespace EleWise.ELMA.BPM.Web.Tasks.Components;

public static class WorkLogControllerHelper
{
	public static bool SaveTaskPlanWorkLogOvertime<T>(BPMController<T, long> controller, ITaskBase task, string planWorkLogFieldName = "Entity.PlanWorkLog") where T : IEntity<long>
	{
		if (task.PlanWorkLog.HasValue && task.PlanWorkLog.Value > 0L)
		{
			WorkTime factWorkLogAll = WorkLogItemManager.Instance.GetFactWorkLogAll(task);
			if (task.PlanWorkLog.Value.TotalMinutes < factWorkLogAll.TotalMinutes)
			{
				controller.Notifier.Error(SR.T("Фактические трудозатраты, уже поданные по задаче, превышают указанное значение плановых трудозатрат. Минимальное допустимое значение {0}", factWorkLogAll.ToString()));
				controller.UnitOfWorkManager.RollbackCurrent(string.Empty);
				task.PlanWorkLog = factWorkLogAll;
				if (((Controller)controller).get_ModelState().ContainsKey(planWorkLogFieldName))
				{
					((Controller)controller).get_ModelState().Remove(planWorkLogFieldName);
				}
				return true;
			}
		}
		return false;
	}

	public static bool CanShowPropertyOnSearchFilter(PropertyInfo property)
	{
		if (property == null)
		{
			return false;
		}
		return property.ReflectedType.GetInterfaces().Any(delegate(Type i)
		{
			PropertyInfo reflectionProperty = i.GetReflectionProperty(property.Name);
			if (reflectionProperty == null || reflectionProperty.PropertyType != property.PropertyType)
			{
				return false;
			}
			if (property.Name == "SearchString")
			{
				return false;
			}
			if (i.GetReflectionProperty(property.Name).GetCustomAttributes(typeof(WorkLogItemSearchHideAttribute), inherit: true).Length != 0)
			{
				return false;
			}
			if (i.GetReflectionProperty(property.Name).GetCustomAttributes(typeof(WorkLogItemSearchFieldAttribute), inherit: true).Length != 0)
			{
				return true;
			}
			return i == typeof(IWorkLogObjectSearchFilter) || GetWorkLogItemSearchExtensions().Any((IWorkLogObjectSearchExtension e) => e.Properties.Contains(property.Name) && e.ObjectTypeUids.Any((Guid t) => WorkLogExtensionHelper.FindExtensionByObjectUid(t, enabled: true) != null));
		});
	}

	private static IEnumerable<IWorkLogObjectSearchExtension> GetWorkLogItemSearchExtensions()
	{
		return ComponentManager.Current.GetExtensionPoints<IWorkLogObjectSearchExtension>().ToList();
	}

	public static IEnumerable<SelectListItem> GetWorkLogItemObjectTree([NotNull] this UrlHelper url, List<WorkLogReportObject> objectUidItems)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0026: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0047: Expected O, but got Unknown
		WorkLogReportObject rootTree = GetRootTree(objectUidItems);
		List<SelectListItem> list = new List<SelectListItem>(url.GetTree(new WorkLogReportObject[1] { rootTree }, ""));
		SelectListItem val = new SelectListItem();
		val.set_Value(string.Empty);
		val.set_Text(string.Empty);
		val.set_Selected(rootTree == null);
		SelectListItem item = val;
		list.Insert(0, item);
		return list;
	}

	public static IEnumerable<SelectListItem> GetWorkLogItemObjectTree([NotNull] this UrlHelper url)
	{
		return url.GetWorkLogItemObjectTree(WorkLogItemManager.Instance.WorkLogReportObjectsTree());
	}

	private static WorkLogReportObject GetRootTree(List<WorkLogReportObject> objectUidItems)
	{
		List<WorkLogReportObject> items = objectUidItems.Where((WorkLogReportObject w) => w.Parent == null).ToList();
		return new WorkLogReportObject
		{
			ObjectTypeName = "",
			ObjectTypeUid = Guid.Empty,
			Items = items
		};
	}

	private static IEnumerable<SelectListItem> GetTree([NotNull] this UrlHelper url, IEnumerable<WorkLogReportObject> items, string level)
	{
		//IL_0099: Unknown result type (might be due to invalid IL or missing references)
		//IL_009e: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0126: Expected O, but got Unknown
		List<WorkLogReportObject> list = new List<WorkLogReportObject>();
		list.AddRange(items);
		list.Sort((WorkLogReportObject g1, WorkLogReportObject g2) => g1.ObjectTypeName.CompareTo(g2.ObjectTypeName));
		List<SelectListItem> list2 = new List<SelectListItem>();
		foreach (WorkLogReportObject item in list)
		{
			if (item.ObjectTypeUid == Guid.Empty)
			{
				list2.AddRange(url.GetTree(item.Items, level));
				continue;
			}
			string fullImageUrl = url.Action("Object", "Images", (object)new
			{
				area = "EleWise.ELMA.SDK.Web",
				id = item.ObjectTypeUid,
				size = ObjectIconFormat.x16,
				useParent = false
			});
			DropDownSelectListItem val = new DropDownSelectListItem();
			((SelectListItem)val).set_Text(HttpUtility.HtmlEncode(item.ObjectTypeName ?? ""));
			val.set_DropDownText(string.Format("{1}{2} {0}", HttpUtility.HtmlEncode(item.ObjectTypeName ?? "").Replace(" ", "&nbsp;"), level, HtmlExtensions.Image(fullImageUrl, new
			{
				@class = "entityTypeIcon",
				width = "16",
				height = "16"
			})));
			((SelectListItem)val).set_Value(item.ObjectTypeUid.ToString());
			list2.Add((SelectListItem)val);
			list2.AddRange(url.GetTree(item.Items, $"{level}&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"));
		}
		return list2;
	}

	public static string WorkLogItemObjectItem([NotNull] this UrlHelper url, IEntity entity)
	{
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(entity.GetType()) as EntityMetadata;
		string text = entity.ToString().HtmlEncode();
		text = (string.IsNullOrWhiteSpace(text) ? SR.T("(без названия)") : text.Replace("\r", " ").Replace("\n", " ").Replace("\t", " "));
		string fullImageUrl = url.ObjectIcon(ObjectIconFormat.x16, entity);
		return string.Format("{0} {1}<br /><span style='color:gray; padding-left:20px'>{2}</span>", HtmlExtensions.Image(fullImageUrl, new
		{
			@class = "entityTypeIcon",
			width = "16",
			height = "16"
		}), string.IsNullOrEmpty(text) ? SR.T("(без названия)") : text, entityMetadata.DisplayName);
	}
}
