using System;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.CRM.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Web.Content.Menu;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.CRM.Web.Controllers;

[RouteArea("EleWise.ELMA.CRM.Web")]
public class SaleTypeController : BPMController<ISaleType, long>
{
	private const string CATALOGS_MENU = "EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root";

	[EntityListLink(typeof(ISaleType))]
	public ActionResult Index()
	{
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
		return (ActionResult)(object)((Controller)this).View();
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command)
	{
		GridData<ISaleType> gridData = CreateGridData(command);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[HttpGet]
	public ActionResult Add()
	{
		ISaleType saleType = InterfaceActivator.Create<ISaleType>();
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
		return (ActionResult)(object)((Controller)this).View("Edit", (object)saleType);
	}

	[HttpGet]
	public ActionResult Edit(long id)
	{
		ISaleType saleType = EntityManager<ISaleType>.Instance.Load(id);
		((Controller)(object)this).SetCurrentMenuItem("EleWise.ELMA.BPM.Web.Common.Controllers.CatalogsController.Index-Root");
		return (ActionResult)(object)((Controller)this).View((object)saleType);
	}

	[HttpPost]
	public ActionResult Save(ISaleType model)
	{
		try
		{
			model.Save();
		}
		catch (Exception exception)
		{
			FormNotifierExtensions.Error(base.Notifier, exception);
			base.Logger.Log(LogLevel.Error, exception, "Error while saving ISaleType");
		}
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[Permission("{dde5667e-bc3f-458c-abb6-2d693f6ffec2}")]
	[HttpPost]
	public ActionResult Delete(long id)
	{
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Expected O, but got Unknown
		try
		{
			ISaleType obj = EntityManager<ISaleType>.Instance.Load(id);
			EntityManager<ISaleType>.Instance.Delete(obj);
			base.Notifier.Information(SR.T("Тип сделки удалён"));
		}
		catch (Exception exception)
		{
			base.Notifier.Error(SR.T("Произошла ошибка во время удаления типа сделки."));
			base.Logger.Error(SR.T("Произошла ошибка во время удаления типа сделки."), exception);
		}
		return (ActionResult)new EmptyResult();
	}
}
