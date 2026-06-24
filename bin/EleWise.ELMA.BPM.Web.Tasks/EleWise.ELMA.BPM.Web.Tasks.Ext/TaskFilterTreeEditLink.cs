using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Tasks.Extensions;

[Component]
public class TaskFilterTreeEditLink : IFilterTreeEditLink
{
	public bool AvailableFilterType(Guid ObjectsType)
	{
		return MetadataLoader.IsBaseOrChildClass<ITaskBase>(ObjectsType);
	}

	public string GenerateLink(UrlHelper Url, FilterTreeItem FilterTreeItem)
	{
		string text = "EditFilters";
		switch (FilterTreeItem.Code.Value.ToString("B").ToUpper())
		{
		case "{231F289D-88DA-4C29-856A-56365909499D}":
			text = "EditFiltersIncoming";
			break;
		case "{05B409B2-4AFA-478B-BE1A-4E51E3BA8EE1}":
			text = "EditFiltersOutgoing";
			break;
		case "{FA610A6E-9CF2-4E10-AF47-3AC6AF579C6A}":
			text = "EditFiltersExecutionControl";
			break;
		case "{32F61BC5-CBC7-403A-B36D-143018981709}":
			text = "EditFiltersCurrentControl";
			break;
		case "{19545547-E11C-4C4B-9BC5-4FF4BBAE04CE}":
			text = "EditFiltersSearch";
			break;
		case "{91187856-7B58-4913-8194-D60A446861EA}":
			text = "EditFiltersCoExecutionControl";
			break;
		}
		return HtmlExtensions.ImageLink(Url, "#edit.svg", "", Url.Action("EditFilter", FilterTreeItem.Controller, (object)new
		{
			area = FilterTreeItem.Area,
			FilterId = FilterTreeItem.FolderId,
			ReturnUrl = Url.Action(text, FilterTreeItem.Controller, (object)new
			{
				area = FilterTreeItem.Area
			})
		}), null, new
		{
			@class = "tree-item-button",
			tooltipheader = SR.T("Изменить фильтр"),
			tooltiptext = SR.T("Можно изменить: значения полей фильтрации, набор колонок в таблице, состав полей на форме поиска, права доступа")
		});
	}
}
