using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.KPI.Common.Web.Models;
using EleWise.ELMA.KPI.Interfaces;
using EleWise.ELMA.KPI.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Mvc.Controllers;

namespace EleWise.ELMA.KPI.Common.Web.Controllers;

[RouteArea("EleWise.ELMA.KPI.Common.Web")]
public class ProjectionScaleController : BaseController<IProjectionScale, long>
{
	public EntityManager<IProjectionScaleItem, long> ProjectionScaleItemManager { get; set; }

	public IProjectionScaleService ProjectionScaleService { get; set; }

	public EntityManager<IProjectionScale, long> ProjectionScaleManager { get; set; }

	public ActionResult EditItem(Guid? id, string scaleId, string jsonData)
	{
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		//IL_008b: Expected O, but got Unknown
		ProjectionScaleItemModel projectionScaleItemModel = new ProjectionScaleItemModel();
		if (id.HasValue)
		{
			IProjectionScaleItem projectionScaleItem2 = (projectionScaleItemModel.Entity = ((IEnumerable<IProjectionScaleItem>)ProjectionScaleService.DeserializeForm(jsonData).Items).ToList().FirstOrDefault((IProjectionScaleItem s) => s.Uid == id.Value));
		}
		if (projectionScaleItemModel.Entity == null)
		{
			projectionScaleItemModel.Entity = ProjectionScaleItemManager.Create();
		}
		projectionScaleItemModel.ScaleId = scaleId;
		ViewDataDictionary viewData = ((ControllerBase)this).get_ViewData();
		TemplateInfo val = new TemplateInfo();
		val.set_HtmlFieldPrefix("ProjectionScaleItem");
		viewData.set_TemplateInfo(val);
		return (ActionResult)(object)((Controller)this).PartialView("AddProjectionScaleItemPopup", (object)projectionScaleItemModel);
	}

	public PartialViewResult ProjectionScaleForm(long scale, string json, string scaleId, ProjectionScaleOptions options = null)
	{
		IProjectionScale projectionScale = ProjectionScaleService.DeserializeForm(json);
		ProjectionScaleFormModel projectionScaleFormModel = new ProjectionScaleFormModel(projectionScale, scaleId, options);
		projectionScaleFormModel.ItemsJsonData = ProjectionScaleService.SerializeItems((ICollection<IProjectionScaleItem>)projectionScale.Items);
		projectionScaleFormModel.JsonData = json;
		return ProjectionScaleFormByModel(projectionScaleFormModel);
	}

	public PartialViewResult ProjectionScaleFormByModel(ProjectionScaleFormModel model)
	{
		if (string.IsNullOrEmpty(model.JsonData))
		{
			model.JsonData = ProjectionScaleService.SerializeForm(model.ProjectionScale);
		}
		if (string.IsNullOrEmpty(model.ItemsJsonData))
		{
			model.ItemsJsonData = ProjectionScaleService.SerializeItems((ICollection<IProjectionScaleItem>)model.ProjectionScale.Items);
		}
		return ((Controller)this).PartialView("ProjectionScaleForm", (object)model);
	}

	[HttpPost]
	public ActionResult SaveItem(string scaleJson, Guid? id, double? minValue, double? maxValue, double resultValue, string color, string scaleId)
	{
		IProjectionScale projectionScale = (scaleJson.IsNullOrWhiteSpace() ? ProjectionScaleManager.Create() : ProjectionScaleService.DeserializeForm(scaleJson));
		List<IProjectionScaleItem> list = ((projectionScale.Items != null) ? ((IEnumerable<IProjectionScaleItem>)projectionScale.Items).ToList() : new List<IProjectionScaleItem>());
		ProjectionScaleService.DefineIntervals(projectionScale, list);
		IProjectionScaleItem projectionScaleItem = list.Find(delegate(IProjectionScaleItem i)
		{
			Guid uid = i.Uid;
			Guid? guid = id;
			return uid == guid;
		});
		if (projectionScaleItem != null)
		{
			projectionScaleItem.MinValue = minValue;
			projectionScaleItem.MaxValue = maxValue;
			projectionScaleItem.ResultValue = resultValue;
			projectionScaleItem.Color = color;
		}
		else
		{
			IProjectionScaleItem projectionScaleItem2 = InterfaceActivator.Create<IProjectionScaleItem>();
			projectionScaleItem2.Name = SR.T("от {0} до {1}", minValue.HasValue ? minValue.ToString() : "∞", maxValue.HasValue ? maxValue.ToString() : "∞");
			projectionScaleItem2.MinValue = minValue;
			projectionScaleItem2.MaxValue = maxValue;
			projectionScaleItem2.ResultValue = resultValue;
			projectionScaleItem2.ProjectionScale = projectionScale;
			projectionScaleItem2.Color = color;
			ProjectionScaleService.AddInterval(projectionScale, projectionScaleItem2);
		}
		ProjectionScaleFormModel projectionScaleFormModel = new ProjectionScaleFormModel(projectionScale, scaleId);
		projectionScaleFormModel.ItemsJsonData = ProjectionScaleService.SerializeItems((ICollection<IProjectionScaleItem>)projectionScale.Items);
		return (ActionResult)(object)((Controller)this).PartialView("ProjectionScaleItemsGrid", (object)projectionScaleFormModel);
	}
}
