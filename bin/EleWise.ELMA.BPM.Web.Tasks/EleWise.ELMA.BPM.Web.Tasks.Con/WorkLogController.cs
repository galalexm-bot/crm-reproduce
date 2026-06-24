using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Attributes;
using EleWise.ELMA.Web.Mvc.Extensions;
using EleWise.ELMA.Web.Mvc.Models.Grids;
using Telerik.Web.Mvc;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Tasks")]
public class WorkLogController : BPMController<IWorkLog, long>
{
	public IMetadataRuntimeService IMetadataRuntimeService { get; set; }

	[HttpGet]
	public ActionResult WorkLogCreateForm(WorkLogModel model)
	{
		return (ActionResult)(object)((Controller)this).PartialView("CreateForm", (object)model);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult SaveWorkLog(WorkLogModel model)
	{
		if (model != null && model.Entity != null && model.Entity.WorkMinutes > 0L)
		{
			IUser currentUser = base.AuthenticationService.GetCurrentUser<IUser>();
			IUser user3 = (model.Entity.CreationAuthor = (model.Entity.Worker = currentUser));
			ITaskBase task = null;
			base.SecurityService.RunWithElevatedPrivilegies(delegate
			{
				task = Locator.GetServiceNotNull<TaskBaseManager>().LoadOrNull(model.TaskId);
			});
			model.Entity.TaskBase = task;
			base.Manager.Save(model.Entity);
			if (model.IsAjax)
			{
				return (ActionResult)(object)((Controller)this).Json((object)new
				{
					success = true
				});
			}
			if (!string.IsNullOrEmpty(model.RedirectUrl))
			{
				return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
			}
		}
		return (ActionResult)(object)((Controller)this).Redirect("~/");
	}

	[CustomGridAction]
	public ActionResult WorkLogGrid(GridCommand command, long taskId)
	{
		ITaskBase task = null;
		base.SecurityService.RunWithElevatedPrivilegies(delegate
		{
			task = TaskBaseManager.Instance.LoadOrNull(taskId);
		});
		IWorkLogFilter workLogFilter = InterfaceActivator.Create<IWorkLogFilter>();
		workLogFilter.TaskBase = task;
		GridData<IWorkLog, IWorkLogFilter> gridData = base.Manager.CreateGridData(command, workLogFilter);
		return (ActionResult)(object)((Controller)this).PartialView("WorkLog/WorkLogGrid", (object)gridData);
	}

	private GridData<IWorkLog> getWorkLogGridModel(long taskId)
	{
		GridData<IWorkLog> gridData = null;
		ITaskBase taskBase = TaskBaseManager.Instance.LoadOrNull(taskId);
		if (taskBase != null)
		{
			gridData = new GridData<IWorkLog>();
			gridData.DataSource = WorkLogManager.Instance.GetWorkLogs(taskBase);
			gridData.Count = (int)WorkLogManager.Instance.GetWorkLogsCount(taskBase);
		}
		return gridData;
	}
}
