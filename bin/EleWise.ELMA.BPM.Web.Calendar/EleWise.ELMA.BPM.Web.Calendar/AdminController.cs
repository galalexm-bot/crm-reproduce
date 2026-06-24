using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Calendar.Models;
using EleWise.ELMA.Calendar.Models;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Web.Content;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using EleWise.ELMA.Web.Mvc.Security;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Calendar.Controllers;

[Permission("71C2885B-3C58-4671-AA89-BF50ED7A4950")]
public class AdminController : BPMController<ISchedule, long>
{
	public IPermissionManagmentService PermissionManagmentService { get; set; }

	[ContentItem(Name = "SR.M('Общие календари')", Image24 = "#calendar.svg")]
	public ActionResult Index()
	{
		return (ActionResult)(object)((Controller)this).View();
	}

	public ActionResult Detail(ISchedule model)
	{
		return (ActionResult)(object)((Controller)this).View((object)new ScheduleModel
		{
			Entity = model
		});
	}

	public ActionResult Delete(ISchedule model)
	{
		model.Delete();
		return (ActionResult)(object)((Controller)this).RedirectToAction("Index");
	}

	[HttpPost]
	public ActionResult Save(ScheduleModel model)
	{
		IScheduleFilter scheduleFilter = InterfaceActivator.Create<IScheduleFilter>();
		scheduleFilter.Shared = true;
		scheduleFilter.Query = string.Format("Name = '{0}'", Regex.Replace(model.Entity.Name.Trim(), "\\s+", " "));
		if (base.Manager.Find(scheduleFilter, FetchOptions.All).Any((ISchedule s) => s.Id != model.Entity.Id))
		{
			((Controller)this).get_ModelState().AddModelError("Name", SR.T("Календарь с таким именем существует."));
		}
		if (!((Controller)this).get_ModelState().get_IsValid())
		{
			return (ActionResult)(object)((Controller)this).Json((object)new
			{
				success = false,
				errors = ((Controller)this).get_ModelState().get_Values().SelectMany((ModelState v) => (IEnumerable<ModelError>)v.get_Errors())
			}, "text/html", (JsonRequestBehavior)0);
		}
		model.Entity.Save();
		return (ActionResult)(object)((Controller)this).Json((object)new
		{
			success = true,
			id = model.Entity.Id
		}, "text/html", (JsonRequestBehavior)0);
	}

	[CustomGridAction]
	public ActionResult Grid(GridCommand command)
	{
		IScheduleFilter scheduleFilter = InterfaceActivator.Create<IScheduleFilter>();
		scheduleFilter.Shared = true;
		GridData<ISchedule, IScheduleFilter> gridData = CreateGridData(command, scheduleFilter);
		return (ActionResult)(object)((Controller)this).PartialView((object)gridData);
	}

	[ContentItem(Name = "SR.M('Календари')", Id = "admin-calendar", Image16 = "#calendar.svg")]
	public ActionResult CalendarSettingsPage()
	{
		return (ActionResult)(object)((Controller)this).RedirectToAction("GetSettingsPage", "Settings", (object)new
		{
			area = "EleWise.ELMA.BPM.Web.Common",
			code = "admin-calendar",
			header = SR.T("Календари")
		});
	}
}
