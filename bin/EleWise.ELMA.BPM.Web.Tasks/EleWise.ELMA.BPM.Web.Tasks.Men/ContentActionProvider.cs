using System.Collections.Generic;
using System.Linq;
using System.Web.Routing;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Content.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Tasks;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Content;

namespace EleWise.ELMA.BPM.Web.Tasks.Menu;

[Component]
public class ContentActionProvider : ControllerActionProviderBase
{
	private readonly ContentAction executionControl;

	private readonly ContentAction currentControl;

	private readonly ContentAction CoExecutionControl;

	private readonly ContentAction department;

	private readonly ContentAction workLogReportCreate;

	private readonly ContentAction forDepartmentCurrent;

	private readonly ContentAction forDepartmentExpired;

	private readonly ContentAction fromDepartmentCurrent;

	private readonly ContentAction fromDepartmentExpired;

	private readonly ContentAction fromDepartmentCompleted;

	private readonly ContentAction forDepartmentClosed;

	private readonly ContentAction fromDepartmentClosed;

	public ISecurityService SecurityService { get; set; }

	private ITaskFilter CoExecutionFilter
	{
		get
		{
			ITaskFilter taskFilter = InterfaceActivator.Create<ITaskFilter>();
			taskFilter.NotShowInLists = false;
			taskFilter.TypeUid = InterfaceActivator.UID<ITask>();
			taskFilter.Query = "InformTo = CurrentUser()";
			taskFilter.CompleteStatus = TaskCompleteStatus.Active;
			return taskFilter;
		}
	}

	private ITaskFilter ExecutionControlFilter
	{
		get
		{
			ITaskFilter taskFilter = InterfaceActivator.Create<ITaskFilter>();
			taskFilter.NotShowInLists = false;
			taskFilter.TypeUid = InterfaceActivator.UID<ITask>();
			taskFilter.UnderControl = true;
			taskFilter.ControlType = TaskControlType.Execution;
			taskFilter.Statuses = TaskBaseExtensions.ControlStatuses.ToList();
			taskFilter.ControlUser = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			return taskFilter;
		}
	}

	private ITaskFilter CurrentControlFilter
	{
		get
		{
			ITaskFilter taskFilter = InterfaceActivator.Create<ITaskFilter>();
			taskFilter.NotShowInLists = false;
			taskFilter.TypeUid = InterfaceActivator.UID<ITask>();
			taskFilter.UnderControl = true;
			taskFilter.Statuses = TaskBaseExtensions.CurrentControlStatuses.ToList();
			taskFilter.CurrentControllers.Add(AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
			return taskFilter;
		}
	}

	public ContentActionProvider()
	{
		CoExecutionControl = new ContentAction
		{
			Id = "coexecutioncontrolpage",
			NameForLocalization = SR.M("Соисполнение"),
			Image24 = "#executor.svg",
			IsAvalilableDelegate = CoExecutionControlIsAvalilable,
			Routes = new ActionRoute("Coexecution", "AllTasks", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks",
				FilterId = 0
			})
		};
		executionControl = new ContentAction
		{
			Id = "executionControl",
			NameForLocalization = SR.M("Контроль выполнения"),
			Image24 = "#control.svg",
			IsAvalilableDelegate = ExecutionControlIsAvalilable,
			Routes = new ActionRoute("ExecutionControl", "AllTasks", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks",
				FilterId = 0
			})
		};
		currentControl = new ContentAction
		{
			Id = "CurrentControl",
			NameForLocalization = SR.M("Текущий контроль"),
			Image24 = "#control.svg",
			IsAvalilableDelegate = CurrentControlIsAvalilable,
			Routes = new ActionRoute("CurrentControl", "AllTasks", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks",
				FilterId = 0
			})
		};
		workLogReportCreate = new ContentAction
		{
			Id = "EleWise.ELMA.BPM.Web.Tasks.Controllers.WorkLogReportController.Create-Root",
			NameForLocalization = SR.M("Создать - Отчёт о трудозатратах"),
			Image24 = "#add_worklog.svg",
			IsAvalilableDelegate = WorkLogReportIsAvalilable,
			Routes = new ActionRoute("Create", "WorkLogReport", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			})
		};
		department = new ContentAction
		{
			Id = "companyPage",
			NameForLocalization = SR.M("Сотрудники компании"),
			Image24 = "#company_menu.svg",
			Routes = new ActionRoute("Index", "Company", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			})
		};
		forDepartmentCurrent = new ContentAction
		{
			Id = "myDepartmentCurrent",
			Image24 = "#current.svg",
			NameForLocalization = SR.M("Задачи отдела - Текущие"),
			IsAvalilableDelegate = MyDepartmentIsAvalilable,
			Routes = new ActionRoute("MyDepartmentCurrent", "AllTasks", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			})
		};
		forDepartmentExpired = new ContentAction
		{
			Id = "myDepartmentExpired",
			Image24 = "#expired.svg",
			NameForLocalization = SR.M("Задачи отдела - Просроченные"),
			IsAvalilableDelegate = MyDepartmentIsAvalilable,
			Routes = new ActionRoute("MyDepartmentExpired", "AllTasks", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			})
		};
		fromDepartmentCurrent = new ContentAction
		{
			Id = "fromDepartmentCurrent",
			Image24 = "#current.svg",
			NameForLocalization = SR.M("Задачи от отдела - Текущие"),
			IsAvalilableDelegate = MyDepartmentIsAvalilable,
			Routes = new ActionRoute("FromDepartmentCurrent", "AllTasks", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			})
		};
		fromDepartmentExpired = new ContentAction
		{
			Id = "fromDepartmentExpired",
			Image24 = "#expired.svg",
			NameForLocalization = SR.M("Задачи от отдела - Просроченные"),
			IsAvalilableDelegate = MyDepartmentIsAvalilable,
			Routes = new ActionRoute("FromDepartmentExpired", "AllTasks", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			})
		};
		fromDepartmentCompleted = new ContentAction
		{
			Id = "fromDepartmentCompleted",
			Image24 = "#complete_outline.svg",
			NameForLocalization = SR.M("Задачи от отдела - Выполненые"),
			IsAvalilableDelegate = MyDepartmentIsAvalilable,
			Routes = new ActionRoute("FromDepartmentCompleted", "AllTasks", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			})
		};
		forDepartmentClosed = new ContentAction
		{
			Id = "forDepartmentClosed",
			Image24 = "#close_outline.svg",
			NameForLocalization = SR.M("Завершенные задачи отдела"),
			IsAvalilableDelegate = MyDepartmentIsAvalilable,
			Routes = new ActionRoute("ForDepartmentClosed", "AllTasks", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			})
		};
		fromDepartmentClosed = new ContentAction
		{
			Id = "fromDepartmentClosed",
			Image24 = "#close_outline.svg",
			NameForLocalization = SR.M("Завершенные задачи от отдела"),
			IsAvalilableDelegate = MyDepartmentIsAvalilable,
			Routes = new ActionRoute("FromDepartmentClosed", "AllTasks", new
			{
				area = "EleWise.ELMA.BPM.Web.Tasks"
			})
		};
	}

	protected bool CoExecutionControlIsAvalilable(RequestContext target)
	{
		if ((target.HttpContext.Items.Contains("ContentActionAvalilableSender") ? target.HttpContext.Items["ContentActionAvalilableSender"] : null) is IStartMenu || TaskManager.Instance.Exists(CoExecutionFilter))
		{
			return SecurityService.HasPermission(EleWise.ELMA.Tasks.PermissionProvider.TasksAccessPermission);
		}
		return false;
	}

	protected bool ExecutionControlIsAvalilable(RequestContext target)
	{
		if ((target.HttpContext.Items.Contains("ContentActionAvalilableSender") ? target.HttpContext.Items["ContentActionAvalilableSender"] : null) is IStartMenu || TaskControlManager.Instance.GetExecutionControlCount() > 0)
		{
			return SecurityService.HasPermission(EleWise.ELMA.Tasks.PermissionProvider.TasksAccessPermission);
		}
		return false;
	}

	protected bool CurrentControlIsAvalilable(RequestContext target)
	{
		if (TaskControlManager.Instance.GetCurrentControlCount() > 0)
		{
			return SecurityService.HasPermission(EleWise.ELMA.Tasks.PermissionProvider.TasksAccessPermission);
		}
		return false;
	}

	protected bool WorkLogReportIsAvalilable(RequestContext target)
	{
		return WorkLogSettingsHelper.WorkLogEnabled();
	}

	protected bool MyDepartmentIsAvalilable(RequestContext target)
	{
		return UserManager.Instance.HaveSubordinatesForUser(AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
	}

	protected bool MyDepartmentWorkLogIsAvalilable(RequestContext target)
	{
		if (WorkLogSettingsHelper.WorkLogEnabled())
		{
			return MyDepartmentIsAvalilable(target);
		}
		return false;
	}

	protected bool AdminWorkLogIsAvalilable(RequestContext target)
	{
		if (WorkLogSettingsHelper.WorkLogEnabled())
		{
			return SecurityService.HasPermission(EleWise.ELMA.Tasks.PermissionProvider.AdminWorklogPermission);
		}
		return false;
	}

	protected override IEnumerable<ContentAction> GetAction()
	{
		yield return executionControl;
		yield return currentControl;
		yield return CoExecutionControl;
		yield return department;
		yield return forDepartmentCurrent;
		yield return forDepartmentExpired;
		yield return fromDepartmentCurrent;
		yield return fromDepartmentExpired;
		yield return fromDepartmentCompleted;
		yield return forDepartmentClosed;
		yield return fromDepartmentClosed;
		yield return workLogReportCreate;
	}
}
