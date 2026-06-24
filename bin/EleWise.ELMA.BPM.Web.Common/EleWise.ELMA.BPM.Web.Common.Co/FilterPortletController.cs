using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Components;
using EleWise.ELMA.BPM.Web.Common.ExtensionPoints;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Common.Portlets;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Html;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;
using Telerik.Web.Mvc.UI.DropDown;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

public class FilterPortletController : BPMController
{
	public IMetadataRuntimeService MetadataRuntimeService { get; set; }

	public FilterMenuProvider FilterMenuProvider { get; set; }

	[CreatorForm]
	[HttpGet]
	public ActionResult Portlet(FilterPortletPersonalization settings)
	{
		FilterPortletModel filterPortletModel = new FilterPortletModel
		{
			InstanceId = settings.InstanceId.ToString(),
			Filter = settings.Filter,
			ShowOnlyMy = settings.ShowOnlyMy,
			ShowFilterFields = settings.ShowFilterFields
		};
		return (ActionResult)(object)((Controller)this).PartialView((object)filterPortletModel);
	}

	public ActionResult FilterFields(string HtmlFieldPrefix, [Bind(Prefix = "DataFilter")] FilterModel model, string portletPrefix = null)
	{
		//IL_002c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0031: Unknown result type (might be due to invalid IL or missing references)
		//IL_003d: Expected O, but got Unknown
		FilterModel filterModel = null;
		if (!string.IsNullOrEmpty(portletPrefix))
		{
			if (model == null)
			{
				filterModel = new FilterModel();
				((Controller)this).TryUpdateModel<FilterModel>(filterModel, portletPrefix);
			}
			else
			{
				filterModel = model;
			}
		}
		FilterControllerHelper.FilterFields(filterModel);
		ViewDataDictionary viewData = ((ControllerBase)this).get_ViewData();
		TemplateInfo val = new TemplateInfo();
		val.set_HtmlFieldPrefix(HtmlFieldPrefix);
		viewData.set_TemplateInfo(val);
		((ControllerBase)this).get_ViewData().Add("filterGridId", (object)portletPrefix);
		((Controller)this).get_RouteData().Values.Add("prefix", (portletPrefix != null) ? portletPrefix.Replace("-", "m") : "");
		return (ActionResult)(object)((Controller)this).PartialView("Filter/FilterModelFields", (object)filterModel);
	}

	[CreatorForm]
	[CustomGridAction]
	public ActionResult PortletGrid(GridCommand command, [Bind(Prefix = "DataFilter")] FilterModel model, Guid filterTypeUid, long? filterId, bool showOnlyMy, string instanceId, bool showFilterFields = false, string portletPrefix = null)
	{
		FilterModel filterModel = null;
		if (!string.IsNullOrEmpty(portletPrefix))
		{
			if (model == null)
			{
				filterModel = new FilterModel();
				((Controller)this).TryUpdateModel<FilterModel>(filterModel, portletPrefix);
			}
			else
			{
				filterModel = model;
			}
		}
		Type typeByUid = MetadataRuntimeService.GetTypeByUid(filterTypeUid);
		ClassMetadata classMetadata = (ClassMetadata)MetadataLoader.LoadMetadata(typeByUid);
		string text = $"Portlet_{instanceId}_{filterId}";
		FilterModel filterModel2 = filterModel ?? CreateFilter(classMetadata.Uid, text, filterId);
		filterModel2.EnableSave = !showFilterFields;
		ComponentManager.Current.GetExtensionPoints<IFilterPortletShowOnlyMy>().FirstOrDefault((IFilterPortletShowOnlyMy p) => p.CheckShowOnlyMy(filterTypeUid))?.SetShowOnlyMy(filterModel2, showOnlyMy);
		IFilterPortlet filterPortlet = ComponentManager.Current.GetExtensionPoints<IFilterPortlet>().First((IFilterPortlet p) => p.AvailableFilterType(filterTypeUid));
		string viewName = filterPortlet.ViewName();
		object model2 = filterPortlet.GetModel(command, filterModel2, text, GetHtmlHelper());
		IGridData gridData = null;
		if (model2 is IFilterPortletModel filterPortletModel)
		{
			gridData = filterPortletModel.GetGridData();
		}
		PortletGridFilterModel portletGridFilterModel = new PortletGridFilterModel
		{
			ViewModel = model2,
			FilterModel = filterModel2,
			ViewName = viewName,
			FilterGridId = text,
			ShowFilterFields = showFilterFields
		};
		return ExportExcel(gridData, typeByUid, () => (ActionResult)(object)((Controller)this).PartialView("PortletGridFilter", (object)portletGridFilterModel));
	}

	[Obsolete("Use CreateFilter(Guid, string, long?, string) instead", true)]
	protected virtual FilterModel CreateFilter(Guid typeUid, long? FilterId = null, string portletPrefix = null)
	{
		return CreateFilter(typeUid, null, FilterId, portletPrefix);
	}

	protected virtual FilterModel CreateFilter(Guid typeUid, string gridId, long? filterId = null, string portletPrefix = null)
	{
		if (!string.IsNullOrEmpty(portletPrefix))
		{
			FilterModel filterModel = new FilterModel();
			((Controller)this).TryUpdateModel<FilterModel>(filterModel, portletPrefix);
		}
		IFilter filter = ((filterId > 0) ? AbstractNHEntityManager<IFilter, long>.Instance.Load(filterId.Value) : InterfaceActivator.Create<IFilter>());
		FilterModelSettings filterModelSettings = default(FilterModelSettings);
		filterModelSettings.Filter = filter;
		filterModelSettings.FilterObjectTypeUid = typeUid;
		filterModelSettings.EnableEqlQuery = true;
		filterModelSettings.GridStateId = gridId;
		return new FilterModel(filterModelSettings);
	}

	public ActionResult RefreshColumnSettings(string HtmlFieldPrefix, string FilterIdStr, string InstanceId = null, bool? hideAvailableFilterColumns = true)
	{
		if (long.TryParse(FilterIdStr, out var filterId))
		{
			((ControllerBase)this).get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(HtmlFieldPrefix);
			IFilter filter;
			try
			{
				Pair<Guid, Guid?> filterTypeCode = FilterFolderManager.Instance.GetFilterTypeCode(filterId);
				filter = (IFilter)FilterMenuProvider.Folders(filterTypeCode.First, filterTypeCode.Second).FirstOrDefault((IFilterFolder f) => f.Id == filterId);
			}
			catch
			{
				return null;
			}
			string gridId = $"Portlet_{InstanceId}_{filter.Id}";
			GridState gridState = FilterPortletPersonalization.GetGridState(filter, InstanceId, gridId, !hideAvailableFilterColumns.HasValue || hideAvailableFilterColumns.Value);
			return (ActionResult)(object)((Controller)this).PartialView("Templates/GridSettingsEditForm", (object)gridState);
		}
		return null;
	}

	public bool CheckShowOnlyMy(string FilterIdStr)
	{
		if (long.TryParse(FilterIdStr, out var result))
		{
			IFilterFolder filter = EntityManager<IFilterFolder>.Instance.LoadOrNull(result);
			if (filter != null)
			{
				return ComponentManager.Current.GetExtensionPoints<IFilterPortletShowOnlyMy>().Any((IFilterPortletShowOnlyMy p) => p.CheckShowOnlyMy(filter.ObjectsType.TypeUid));
			}
			return false;
		}
		return false;
	}

	[Cache]
	public static IEnumerable<DropDownSelectListItem> GetTree(bool shared)
	{
		//IL_01aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e0: Expected O, but got Unknown
		//IL_01e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_022c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0231: Unknown result type (might be due to invalid IL or missing references)
		//IL_024c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0259: Unknown result type (might be due to invalid IL or missing references)
		//IL_027c: Expected O, but got Unknown
		ICollection<IFilterFolder> source = FilterFolderManager.Instance.LoadAvailableFilters(shared);
		IEnumerable<Guid> enumerable = source.Select((IFilterFolder f) => f.ObjectsType.TypeUid).Distinct();
		List<DropDownSelectListItem> list = new List<DropDownSelectListItem>();
		Guid uid;
		foreach (Guid typeUid in enumerable)
		{
			try
			{
				Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(typeUid);
				uid = typeUid;
				IEnumerable<IFilterFolder> source2 = source.Where((IFilterFolder f) => f.ObjectsType.TypeUid == uid);
				foreach (Guid? item in source2.Select((IFilterFolder f) => f.Code).Distinct())
				{
					Guid? codeCopy = item;
					IOrderedEnumerable<IFilterFolder> orderedEnumerable = from f in source2.Where(delegate(IFilterFolder f)
						{
							Guid? code = f.Code;
							Guid? guid = codeCopy;
							if (code.HasValue != guid.HasValue)
							{
								return false;
							}
							return !code.HasValue || code.GetValueOrDefault() == guid.GetValueOrDefault();
						})
						orderby f.Name
						select f;
					string title = ComponentManager.Current.GetExtensionPoints<IFilterPortletFilterTypeTitle>().First((IFilterPortletFilterTypeTitle p) => p.AvailableType(typeUid)).GetTitle(typeUid, item);
					if (string.IsNullOrEmpty(title))
					{
						continue;
					}
					IFilterPortletImageTitle filterPortletImageTitle = ComponentManager.Current.GetExtensionPoints<IFilterPortletImageTitle>().First((IFilterPortletImageTitle p) => p.AvailableFilterType(typeUid));
					string text = EleWise.ELMA.Web.Mvc.Html.HtmlExtensions.Image(new UrlHelper(HttpContextAccessor.CurrentContext.Request.RequestContext), filterPortletImageTitle.GetImage(typeUid, item) ?? "#filter.svg", "", "", (object)new
					{
						@class = "entityTypeIcon"
					});
					DropDownSelectListItem val = new DropDownSelectListItem();
					((SelectListItem)val).set_Value(string.Empty);
					((SelectListItem)val).set_Text(string.Empty);
					val.set_DropDownText($"{text}{title}");
					list.Add(val);
					foreach (IFilterFolder item2 in orderedEnumerable)
					{
						DropDownSelectListItem val2 = new DropDownSelectListItem();
						((SelectListItem)val2).set_Value(item2.Id.ToString(CultureInfo.InvariantCulture));
						((SelectListItem)val2).set_Text(item2.Name);
						val2.set_DropDownText(string.Format("{0}{1}{2}", "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;", text, item2.Name));
						list.Add(val2);
					}
				}
			}
			catch (TypeNotFoundException)
			{
			}
		}
		return list;
	}
}
