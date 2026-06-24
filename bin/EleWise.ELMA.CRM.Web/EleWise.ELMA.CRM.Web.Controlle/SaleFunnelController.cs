using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.CRM.Web.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers;

[RouteArea("EleWise.ELMA.CRM.Web")]
public class SaleFunnelController : BPMController<ISaleFunnel, long>
{
	private const string CATALOGS_MENU = "EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root";

	[EntityListLink(typeof(ISaleFunnel))]
	public ActionResult Index()
	{
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
		return (ActionResult)(object)((Controller)this).View();
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command)
	{
		ISaleFunnelFilter filter = InterfaceActivator.Create<ISaleFunnelFilter>();
		GridData<ISaleFunnel, ISaleFunnelFilter> gridData = CreateGridData(command, filter);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[HttpGet]
	public ActionResult Add()
	{
		SaleFunnelEditModel saleFunnelEditModel = new SaleFunnelEditModel(InterfaceActivator.Create<ISaleFunnel>());
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
		return (ActionResult)(object)((Controller)this).View("Edit", (object)saleFunnelEditModel);
	}

	[HttpGet]
	public ActionResult Edit(long id)
	{
		SaleFunnelEditModel saleFunnelEditModel = new SaleFunnelEditModel(EntityManager<ISaleFunnel>.Instance.Load(id));
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
		return (ActionResult)(object)((Controller)this).View((object)saleFunnelEditModel);
	}

	[HttpPost]
	public ActionResult Save(SaleFunnelEditModel model)
	{
		try
		{
			string name = model.Entity.Name;
			List<ISaleStage> json = SaleFunnelEditModel.Deserialize(model.JsonData);
			model.Entity.Name = name;
			((IEnumerable<ISaleStage>)model.Entity.SaleStages).Where((ISaleStage s) => !json.Contains(s)).ToList().ForEach(delegate(ISaleStage s)
			{
				s.SaleFunnel = null;
				((ICollection<ISaleStage>)model.Entity.SaleStages).Remove(s);
				s.Delete();
			});
			json.Where((ISaleStage s) => s.IsNew()).ToList().ForEach(delegate(ISaleStage s)
			{
				s.Id = 0L;
				s.SaleFunnel = model.Entity;
				model.Entity.SaleStages.Add(s);
			});
			model.Entity.Save();
			base.Notifier.Information(SR.T("Воронка продаж успешно сохранена."));
		}
		catch (Exception exception)
		{
			base.Logger.Log(LogLevel.Error, exception, "Error while saving Sale Funnel ID:{0} Name:{1}", model.Entity.Id, model.Entity.Name);
			base.Notifier.Error(SR.T("Произошла ошибка во время сохранения воронки продаж."));
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	public ActionResult EditStage(long? id, string JsonData)
	{
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		AddStagePopupViewModel addStagePopupViewModel = new AddStagePopupViewModel();
		if (id.HasValue)
		{
			List<ISaleStage> source = SaleFunnelEditModel.Deserialize(JsonData, loadEntityIfExists: false);
			addStagePopupViewModel.Entity = source.FirstOrDefault((ISaleStage s) => s.Id == id.Value);
		}
		if (addStagePopupViewModel.Entity == null)
		{
			InstanceOf<ISaleStage> instanceOf = new InstanceOf<ISaleStage>();
			ISaleStage @new = instanceOf.New;
			InstanceOf<IColor> instanceOf2 = new InstanceOf<IColor>();
			instanceOf2.New.ColorCode = "#0054a5";
			@new.Color = instanceOf2.New;
			addStagePopupViewModel.Entity = instanceOf.New;
		}
		ViewDataDictionary viewData = ((ControllerBase)this).get_ViewData();
		TemplateInfo val = new TemplateInfo();
		val.set_HtmlFieldPrefix("SaleStage");
		viewData.set_TemplateInfo(val);
		return (ActionResult)(object)((Controller)this).PartialView("AddStage", (object)addStagePopupViewModel);
	}

	public ActionResult SaveStage([Bind(Prefix = "SaleStage")] AddStagePopupViewModel stageModel, string stagesJsonData)
	{
		List<ISaleStage> list = SaleFunnelEditModel.Deserialize(stagesJsonData, loadEntityIfExists: false);
		int num = list.FindIndex((ISaleStage s) => s.Id == stageModel.Entity.Id);
		if (num >= 0)
		{
			list[num] = stageModel.Entity;
		}
		else
		{
			stageModel.Entity.Id = 0L;
			list.Add(stageModel.Entity);
			stageModel.Entity.Id = list.Min((ISaleStage s) => s.Id) - 1;
			stageModel.Entity.GlobalOrder = list.Max((ISaleStage s) => s.GlobalOrder) + 1;
		}
		((ControllerBase)this).get_ViewData().set_Item("GridId", (object)"SaleStagesGrid");
		return (ActionResult)(object)((Controller)this).PartialView("SaleStagesGrid", (object)list);
	}

	[Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
	[HttpPost]
	public ActionResult Delete(long id)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		try
		{
			ISaleFunnel obj = EntityManager<ISaleFunnel>.Instance.Load(id);
			EntityManager<ISaleFunnel>.Instance.Delete(obj);
			base.Notifier.Information(SR.T("Воронка продаж удалена"));
		}
		catch (Exception exception)
		{
			base.Notifier.Error(SR.T("Произошла ошибка во время удаления воронки продаж."));
			base.Logger.Error(SR.T("Произошла ошибка во время удаления воронки продаж."), exception);
		}
		return (ActionResult)new EmptyResult();
	}
}
