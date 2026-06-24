using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class ReAssignTaskViewModel : FormViewModel
{
	public string PopupId { get; set; }

	public DateTime? ReAssignStartDate { get; set; }

	public DateTime? ReAssignEndDate { get; set; }

	[Obsolete("Не использовать", true)]
	public bool ReAssignStartDateDamper { get; set; }

	[Obsolete("Не использовать", true)]
	public bool ReAssignEndDateDamper { get; set; }

	public bool RequiredStartDate { get; set; }

	public bool RequiredEndDate { get; set; }

	public bool HideStartDate { get; set; }

	public bool HideEndDate { get; set; }

	public TaskPriority ReAssignTaskPriority { get; set; }

	public bool HideReAssignTaskPriority { get; set; }

	[Required(true)]
	[RequiredField]
	public IUser Executor { get; set; }

	public string Comment { get; set; }

	public ITaskBase Task { get; set; }

	public string ReAssigneClick { get; set; }

	public bool NeedCheckOrganizationItem { get; set; }

	public Guid ExecutorFilterProvider { get; set; }

	public string ExecutorFilterData { get; set; }

	public bool SetMeControler { get; set; }

	public bool SetMeParticipant { get; set; }

	public bool TakeCurrentControl { get; set; }

	public ReAssignTaskViewModel(ITaskBase task)
		: this()
	{
		Init(task);
		NeedCheckOrganizationItem = false;
	}

	public ReAssignTaskViewModel()
	{
		base.PostAction = "ReAssign";
		base.PostController = "Task";
		base.PostArea = "EleWise.ELMA.BPM.Web.Tasks";
		NeedCheckOrganizationItem = false;
		RequiredStartDate = true;
		RequiredEndDate = true;
	}

	public void Init(ITaskBase task)
	{
		Task = task;
		Executor = task.Executor;
		ReAssignTaskPriority = task.Priority;
		TaskModel.ToEditTaskDates(task, out var startDate, out var _, out var endDate, out var _);
		ReAssignStartDate = startDate;
		ReAssignEndDate = endDate;
	}

	public bool EnabledSetMeParticipant()
	{
		return EnabledSetMeParticipant(Task);
	}

	public static bool EnabledSetMeParticipant(ITaskBase taskbase)
	{
		if (!(taskbase.CastAsRealType() is ITask task))
		{
			return false;
		}
		IUser user = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
		if (task.ControlUser == user)
		{
			return false;
		}
		if (task.InformTo != null)
		{
			return ((IEnumerable<IUser>)task.InformTo).All((IUser inf) => inf != user);
		}
		return true;
	}

	public bool EnabledSetMeControler()
	{
		return EnabledSetMeControler(Task);
	}

	public static bool EnabledSetMeControler(ITaskBase taskbase)
	{
		if (!(taskbase.CastAsRealType() is ITask task))
		{
			return false;
		}
		return task.ControlUser == null;
	}

	public bool EnabledTakeCurrentControl()
	{
		return EnabledTakeCurrentControl(Task);
	}

	public static bool EnabledTakeCurrentControl(ITaskBase taskbase)
	{
		if (!(taskbase.CastAsRealType() is ITask task))
		{
			return false;
		}
		IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser<IUser>();
		if (task.CurrentControllers != null)
		{
			return !((ICollection<IUser>)task.CurrentControllers).Contains(currentUser);
		}
		return true;
	}
}
