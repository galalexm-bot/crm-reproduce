using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;

namespace EleWise.ELMA.BPM.Web.Common.Controllers;

public class SerializedFilterController : BPMController
{
	private const string DataFilterPrefix = "DataFilter";

	public ActionResult Filter(Guid entityTypeUid, object serializedFilter, bool enableEqlQuery)
	{
		IFilter filter = InterfaceActivator.Create<IFilter>();
		FilterModel filterModel = CreateFilterModel(entityTypeUid, filter, serializedFilter, enableEqlQuery);
		((ControllerBase)this).get_ViewData().set_Item("EleWise.ELMA.BPM.Web.Common.Components.SerializedFilter-Prefix", (object)"DataFilter");
		return (ActionResult)(object)((Controller)this).PartialView("Filter/SerializedFilter", (object)filterModel);
	}

	public ActionResult FilterFields(string HtmlFieldPrefix, [Bind(Prefix = "DataFilter")] FilterModel model = null, Guid? zoneId = null)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Expected O, but got Unknown
		FilterControllerHelper.FilterFields(model);
		ViewDataDictionary viewData = ((ControllerBase)this).get_ViewData();
		TemplateInfo val = new TemplateInfo();
		val.set_HtmlFieldPrefix(HtmlFieldPrefix);
		viewData.set_TemplateInfo(val);
		if (zoneId.HasValue)
		{
			((ControllerBase)this).get_ViewData().set_Item("ZoneUid", (object)zoneId.Value);
			return (ActionResult)(object)((Controller)this).PartialView("Filter/RenderFilterPropertiesZone", (object)model);
		}
		return (ActionResult)(object)((Controller)this).PartialView("Filter/FilterModelFields", (object)model);
	}

	private static FilterModel CreateFilterModel(Guid entityTypeUid, IFilter filter, object serializedFilter, bool enableEqlQuery = false)
	{
		IEntityFilter entityFilter = null;
		Guid? typeUid = null;
		if (serializedFilter != null)
		{
			entityFilter = UniversalFilterSaver.UnPack(serializedFilter);
			typeUid = MetadataLoader.GetEntityMetadataByFilter(entityFilter.GetType(), inherit: true, loadImplementation: false)?.Uid;
		}
		FilterModel filterModel = new FilterModel(filter, entityTypeUid, typeUid, entityTypeUid, "Filter", null, null, enableEqlQuery);
		if (serializedFilter != null)
		{
			filterModel.Filter = entityFilter;
		}
		return filterModel;
	}
}
