using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Html;
using Telerik.Web.Mvc.UI;
using Telerik.Web.Mvc.UI.DropDown;
using Telerik.Web.Mvc.UI.Fluent;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component(Order = 90)]
internal class TaskControlObjectsTypeFilterPropertyEditorExtension : IFilterPropertyEditorExtension
{
	private const string Padding = "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";

	private static Guid taskBaseTypeUid = InterfaceActivator.UID<ITaskBase>();

	private readonly IMemoryCacheService memoryCacheService;

	private readonly TaskControlManager taskControlManager;

	public TaskControlObjectsTypeFilterPropertyEditorExtension(IMemoryCacheService memoryCacheService, TaskControlManager taskControlManager)
	{
		this.memoryCacheService = memoryCacheService;
		this.taskControlManager = taskControlManager;
	}

	public bool Resolve(FilterMetadataProperty property, FilterModel filterModel)
	{
		if (property.ClassUid == TaskControlUniqueFilterExtension.Guid && property.PropertyName == "ObjectsType" && filterModel.Filter is ITaskControlFilter)
		{
			return taskControlManager.GetBaseControlClassMetadata().Count > 1;
		}
		return false;
	}

	public MvcHtmlString PropertyEditor(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel)
	{
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012b: Expected O, but got Unknown
		HtmlAttributes htmlAttributes = new HtmlAttributes().Set(delegate(HtmlAttributes a)
		{
			a.style.width = "350px";
		});
		MvcHtmlString obj = PartialExtensions.Partial((HtmlHelper)(object)html, "Filter/ObjectsTypeChangedFunc", (object)filterModel);
		object obj2 = (((ViewDataDictionary)html.get_ViewData()).ContainsKey("filterGridId") ? ((ViewDataDictionary)html.get_ViewData()).get_Item("filterGridId") : string.Empty);
		string postfix = ((obj2 != null) ? obj2.ToString().Replace("-", "m") : "");
		List<SelectListItem> list = TypesTree(html, property, filterModel);
		MvcHtmlString val = MvcHtmlString.Create(((ViewComponentBuilderBase<DropDownList, DropDownListBuilder>)(object)((ViewComponentBuilderBase<DropDownList, DropDownListBuilder>)(object)((DropDownBuilderBase<DropDownList, DropDownListBuilder>)(object)((DropDownBuilderBase<DropDownList, DropDownListBuilder>)(object)((DropDownBuilderBase<DropDownList, DropDownListBuilder>)(object)((DropDownBuilderBase<DropDownList, DropDownListBuilder>)(object)((ViewComponentBuilderBase<DropDownList, DropDownListBuilder>)(object)((ViewComponentFactory)HtmlHelperExtension.Telerik<object>(html)).DropDownList()).Name(((ViewDataDictionary)html.get_ViewData()).get_TemplateInfo().GetFullHtmlFieldName("") + "TypeSelector")).BindTo((IEnumerable<SelectListItem>)list)).ClientEvents((Action<DropDownClientEventsBuilder>)delegate(DropDownClientEventsBuilder events)
		{
			events.OnChange(((ViewDataDictionary)html.get_ViewData()).get_TemplateInfo().GetFullHtmlFieldId("ObjectsTypeChanged") + postfix);
		})).DropDownHtmlAttributes((IDictionary<string, object>)htmlAttributes)).Encode(false)).HtmlAttributes((IDictionary<string, object>)htmlAttributes)).ToHtmlString());
		return new MvcHtmlString(string.Concat(obj, val));
	}

	public void PropertyAction(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel, WebViewAttributes a)
	{
	}

	protected List<SelectListItem> TypesTree(HtmlHelper<object> html, FilterMetadataProperty property, FilterModel filterModel)
	{
		List<TaskControlTreeItem> orAdd = memoryCacheService.GetOrAdd("TaskControlObjectsTypeFieldsFilterExtension.TypesTree", TypesTree);
		return new List<SelectListItem>(GetTree(((HtmlHelper)(object)html).Url(), new TaskControlTreeItem[1]
		{
			new TaskControlTreeItem
			{
				Items = orAdd.Where((TaskControlTreeItem w) => w.Parent == null).ToList()
			}
		}, filterModel.FilterTypeUid, ""));
	}

	private IEnumerable<SelectListItem> GetTree(UrlHelper url, IEnumerable<TaskControlTreeItem> items, Guid selectedValue, string level)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f2: Expected O, but got Unknown
		List<TaskControlTreeItem> list = new List<TaskControlTreeItem>();
		list.AddRange(items);
		list.Sort(delegate(TaskControlTreeItem item1, TaskControlTreeItem item2)
		{
			if (item1.Metadata == null)
			{
				return -1;
			}
			return (item2.Metadata == null) ? 1 : item1.Metadata.DisplayName.CompareTo(item2.Metadata.DisplayName);
		});
		List<SelectListItem> list2 = new List<SelectListItem>();
		foreach (TaskControlTreeItem item in list)
		{
			if (item.ObjectTypeUid == Guid.Empty)
			{
				list2.AddRange(GetTree(url, item.Items, selectedValue, level));
				continue;
			}
			string text = HttpUtility.HtmlEncode((item.Metadata != null) ? item.Metadata.DisplayName : "");
			DropDownSelectListItem val = new DropDownSelectListItem();
			((SelectListItem)val).set_Text(text);
			val.set_DropDownText($"{level}<span class=\"iconTypeText\">{GetEntityIcon(url, item.ObjectTypeUid)}{text}</span>");
			((SelectListItem)val).set_Selected(item.ObjectTypeUid == selectedValue);
			((SelectListItem)val).set_Value(GetValue(item.ObjectTypeUid, item.FilterType));
			list2.Add((SelectListItem)val);
			list2.AddRange(GetTree(url, item.Items, selectedValue, level + "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"));
		}
		return list2;
	}

	protected static string GetEntityIcon(UrlHelper url, Guid typeUid)
	{
		EntityMetadata entityMetadata = MetadataLoader.LoadMetadata(typeUid) as EntityMetadata;
		if (url == null || entityMetadata == null)
		{
			return null;
		}
		if (entityMetadata.Images != null && entityMetadata.Images.Count > 0)
		{
			return string.Format("<img class=\"entityTypeIcon\" src=\"{0}\" alt=\"\"> ", url.Image(url.Action("Object", "Images", (object)new
			{
				area = "EleWise.ELMA.SDK.Web",
				id = entityMetadata.Uid
			})));
		}
		return GetEntityIcon(url, entityMetadata.BaseClassUid);
	}

	private List<TaskControlTreeItem> TypesTree()
	{
		ClassMetadata classMetadata = (ClassMetadata)InterfaceActivator.LoadMetadata<ITaskBase>();
		ModelHelper.GetEntityType(classMetadata.Uid);
		List<TaskControlTreeItem> result = new List<TaskControlTreeItem>
		{
			new TaskControlTreeItem
			{
				ObjectTypeUid = taskBaseTypeUid,
				Metadata = classMetadata,
				FilterType = MetadataLoader.GetFilterType(TaskControlUniqueFilterExtension.Guid)
			}
		};
		foreach (ClassMetadata baseControlClassMetadatum in taskControlManager.GetBaseControlClassMetadata())
		{
			foreach (ClassMetadata childClass in MetadataLoader.GetChildClasses(baseControlClassMetadatum, loadImplementation: true, includeRoot: true))
			{
				ModelHelper.GetEntityType(baseControlClassMetadatum.Uid);
				result.Add(new TaskControlTreeItem
				{
					ObjectTypeUid = childClass.Uid,
					Metadata = childClass,
					FilterType = MetadataLoader.GetFilterType(childClass.Uid)
				});
			}
		}
		foreach (TaskControlTreeItem item in result)
		{
			Guid baseClassUid = GetChildBasesClassesUids(item.ObjectTypeUid).FirstOrDefault((Guid u) => result.Any((TaskControlTreeItem m) => m.ObjectTypeUid == u));
			TaskControlTreeItem taskControlTreeItem = result.FirstOrDefault((TaskControlTreeItem m) => m.ObjectTypeUid == baseClassUid);
			if (taskControlTreeItem != null)
			{
				item.Parent = taskControlTreeItem;
				taskControlTreeItem.Items.Add(item);
			}
		}
		return result;
	}

	private string GetValue(Guid typeUid, Type type)
	{
		return string.Format("{{\"typeUid\":\"{0}\",\"typeName\":\"{1}\"}}", typeUid, (type != null) ? type.AssemblyQualifiedName : "");
	}

	private static List<Guid> GetChildBasesClassesUids(Guid entityTypeUid)
	{
		if (!(MetadataLoader.LoadMetadata(entityTypeUid) is ClassMetadata metadata))
		{
			return new List<Guid>();
		}
		return (from m in MetadataLoader.GetBaseClasses(metadata)
			select m.Uid).ToList();
	}
}
