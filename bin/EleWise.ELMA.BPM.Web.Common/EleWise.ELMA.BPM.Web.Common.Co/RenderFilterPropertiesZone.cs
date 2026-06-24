using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using EleWise.ELMA.BPM.Web.Common.Extensions;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Extensions;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Web.Mvc;
using EleWise.ELMA.Web.Mvc.ExtensionPoints;
using EleWise.ELMA.Web.Mvc.Html;

namespace EleWise.ELMA.BPM.Web.Common.Components;

[Component(EnableInterceptiors = false, InjectProerties = false, Order = 10)]
public class RenderFilterPropertiesZone : IExtensionZone
{
	public const string ZoneStartId = "RenderFilterPropertiesZone_";

	public static void PrepareFilterModelFields(HtmlHelper html, FilterModel model, out List<PropertiesViewModel.PropertyItem> visibleProperties, out List<PropertiesViewModel.PropertyItem> invisibleProperties, out Dictionary<string, Type> propertyFilterTypes)
	{
		List<string> hiddenColumns = model.HiddenColumns ?? ((List<string>)html.get_ViewData().get_Item("HiddenColumns"));
		List<string> ignoreColumns = model.IgnoreColumns ?? ((List<string>)html.get_ViewData().get_Item("IgnoreColumns"));
		List<Guid> defaultFields = model.DefaultFields ?? ((List<Guid>)html.get_ViewData().get_Item("DefaultFields"));
		List<Guid> forceMoveFields = model.ForceMoveFields ?? ((List<Guid>)html.get_ViewData().get_Item("ForceMoveFields"));
		string showOnlyMyProperty = model.ShowOnlyMyProperty ?? ((string)html.get_ViewData().get_Item("ShowOnlyMyProperty"));
		List<SearchFieldsData> selectedColumns = ((!model.ShowAllFields) ? ((List<SearchFieldsData>)model.Entity.SearchFields) : null);
		propertyFilterTypes = new Dictionary<string, Type>();
		List<FilterMetadataProperty> metadataProperties = model.Filter.LoadMetadataProperties("", null, propertyFilterTypes, model.MainTypeUid ?? model.Entity.ObjectsType.TypeUid, model.Entity.Code);
		List<PropertiesViewModel.PropertyItem> visiblePropertiesLocal = (visibleProperties = new List<PropertiesViewModel.PropertyItem>(metadataProperties.Count));
		if (selectedColumns != null)
		{
			visibleProperties.AddRange(((IEnumerable<SearchFieldsData>)selectedColumns).Select((Func<SearchFieldsData, PropertiesViewModel.PropertyItem>)((SearchFieldsData c) => null)));
		}
		List<PropertiesViewModel.PropertyItem> invisiblePropertiesLocal = (invisibleProperties = new List<PropertiesViewModel.PropertyItem>());
		html.HtmlHelperAction(model.Filter, delegate(HtmlHelper<object> hlp)
		{
			((HtmlHelper)(object)hlp).ExecuteWithoutCreators(delegate(HtmlHelper<object> helper)
			{
				//IL_002f: Unknown result type (might be due to invalid IL or missing references)
				//IL_0034: Unknown result type (might be due to invalid IL or missing references)
				//IL_0054: Unknown result type (might be due to invalid IL or missing references)
				//IL_0056: Expected O, but got Unknown
				//IL_005b: Expected O, but got Unknown
				ViewDataDictionary viewData = ((HtmlHelper)helper).get_ViewContext().get_ViewData();
				ViewDataDictionary<object> viewData2 = helper.get_ViewData();
				TemplateInfo val = new TemplateInfo();
				val.set_HtmlFieldPrefix(html.get_ViewData().get_TemplateInfo().GetFullHtmlFieldName("Filter"));
				TemplateInfo templateInfo = val;
				((ViewDataDictionary)viewData2).set_TemplateInfo(val);
				viewData.set_TemplateInfo(templateInfo);
				foreach (FilterMetadataProperty prop2 in metadataProperties)
				{
					if ((string.IsNullOrWhiteSpace(showOnlyMyProperty) || !(showOnlyMyProperty == prop2.PropertyName)) && (ignoreColumns == null || !ignoreColumns.Contains(prop2.PropertyName)) && prop2.Visible)
					{
						int num;
						if (selectedColumns != null)
						{
							num = selectedColumns.FindIndex((SearchFieldsData sc) => sc.PropertyName == prop2.PropertyName);
						}
						else
						{
							num = visiblePropertiesLocal.Count;
							visiblePropertiesLocal.Add(null);
						}
						bool isVisibleColumn = !prop2.Hidden && (hiddenColumns == null || !hiddenColumns.Contains(prop2.PropertyName)) && (selectedColumns == null || num >= 0);
						MvcHtmlString val2;
						try
						{
							val2 = model.PropertyEditor(helper, prop2, isVisibleColumn, defaultFields, forceMoveFields);
							if (val2 == null)
							{
								val2 = helper.Property<object>(prop2.PropertyName, delegate(WebViewAttributes a)
								{
									model.PropertyAction(helper, prop2, isVisibleColumn, defaultFields, forceMoveFields, a);
								});
							}
						}
						catch (Exception ex)
						{
							Logger.Log.Error("Error render property", ex);
							val2 = MvcHtmlString.Create(string.Format("<tr><td colspan=\"2\">{0}</td></tr>", SR.T("Не удалось отобразить свойство {0}: {1}", prop2.PropertyName, ex.Message)));
						}
						if (isVisibleColumn)
						{
							visiblePropertiesLocal[num] = new PropertiesViewModel.PropertyItem
							{
								Property = prop2,
								EditableProperty = val2
							};
						}
						else
						{
							invisiblePropertiesLocal.Add(new PropertiesViewModel.PropertyItem
							{
								Property = prop2,
								EditableProperty = val2
							});
						}
					}
				}
			});
		});
		visibleProperties.RemoveAll((PropertiesViewModel.PropertyItem prop) => prop == null);
	}

	public bool CanRenderInZone(string zoneId, HtmlHelper html)
	{
		return zoneId?.StartsWith("RenderFilterPropertiesZone_") ?? false;
	}

	public void RenderZone(string zoneId, HtmlHelper html)
	{
		if (zoneId == null || !zoneId.StartsWith("RenderFilterPropertiesZone_"))
		{
			return;
		}
		Guid zoneId2 = new Guid(zoneId.Replace("RenderFilterPropertiesZone_", ""));
		if (!(html.get_ViewData().get_Model() is FilterModel filterModel))
		{
			return;
		}
		string text = ((string)html.get_ViewData().get_Item("postfix")) ?? "";
		html.get_ViewData().get_TemplateInfo().set_HtmlFieldPrefix(string.IsNullOrWhiteSpace(text) ? "DataFilter" : (text + ".DataFilter"));
		Dictionary<string, Type> propertyFilterTypes = null;
		if (filterModel.VisibleProperties == null || filterModel.InvisibleProperties == null)
		{
			PrepareFilterModelFields(html, filterModel, out var visibleProperties, out var invisibleProperties, out propertyFilterTypes);
			filterModel.VisibleProperties = visibleProperties;
			filterModel.InvisibleProperties = invisibleProperties;
		}
		FilterPropertiesZone filterPropertiesZone = FilterPropertiesZoneExtensions.FindZone(filterModel.GetZoneFilterPropertiesTree(), zoneId2);
		if (filterPropertiesZone != null)
		{
			FillProperties(filterPropertiesZone, filterModel);
			if (propertyFilterTypes != null)
			{
				RenderPartialExtensions.RenderPartial(html, "Filter/FilterModelPropertyFilterTypes", (object)propertyFilterTypes);
			}
			RenderPartialExtensions.RenderPartial(html, "Filter/FilterPropertiesZone", (object)filterPropertiesZone);
		}
	}

	private void FillProperties(FilterPropertiesZone zone, FilterModel model)
	{
		zone.VisibleProperties = ((!zone.Provider.UseSaveState) ? model.VisibleProperties.Where((PropertiesViewModel.PropertyItem vp) => vp != null && zone.Provider.IsPropertyInZone(model, vp.Property)).ToList() : model.VisibleProperties);
		zone.InvisibleProperties = ((!zone.Provider.UseSaveState) ? model.InvisibleProperties.Where((PropertiesViewModel.PropertyItem vp) => vp != null && zone.Provider.IsPropertyInZone(model, vp.Property)).ToList() : model.InvisibleProperties);
		zone.FilterModel = model;
		foreach (FilterPropertiesZone childZone in zone.ChildZones)
		{
			FillProperties(childZone, model);
		}
	}
}
