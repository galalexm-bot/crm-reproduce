using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Tasks.Components;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class ReplacementTaskModel : EntityModel<IReplacementTask>
{
	private bool? showPlanWorkLog;

	[Required(true)]
	[RequiredField]
	public DateTime StartDate { get; set; }

	[Required(true)]
	[RequiredField]
	public DateTime EndDate { get; set; }

	public long CurrentUserId { get; set; }

	public bool ReOpen { get; set; }

	public string ReturnUrl { get; set; }

	public bool ShowPlanWorkLog
	{
		get
		{
			if (WorkLogSettingsHelper.WorkLogEnabled())
			{
				bool? flag = showPlanWorkLog;
				if (!flag.HasValue)
				{
					if (base.Entity.PlanWorkLog.HasValue && base.Entity.PlanWorkLog.Value > 0L)
					{
						return !base.Entity.IsNew();
					}
					return false;
				}
				return flag.GetValueOrDefault();
			}
			return false;
		}
		set
		{
			showPlanWorkLog = value;
		}
	}

	public bool CheckReplacement { get; set; }

	public ReplacementTaskModel(IReplacementTask task)
	{
		SetDefaultValues();
		base.Entity = task;
		NormalizeDates();
		ShowPlanWorkLog = base.Entity.PlanWorkLog.HasValue && base.Entity.PlanWorkLog.Value > 0L && !base.Entity.IsNew();
	}

	public ReplacementTaskModel()
	{
		SetDefaultValues();
	}

	private void SetDefaultValues()
	{
		base.Entity = ReplacementTaskManager.Instance.Create();
		base.Entity.StartDate = null;
		NormalizeDates();
		CheckReplacement = true;
		ShowPlanWorkLog = false;
	}

	public static void ToEditTaskDates(ITaskBase task, out DateTime startDate, out DateTime endDate)
	{
		startDate = (task.StartDate.HasValue ? task.StartDate.Value : DateTime.Now);
		endDate = (task.EndDate.HasValue ? task.EndDate.Value : DateTime.Now);
	}

	public void NormalizeDates()
	{
		ToEditTaskDates(base.Entity, out var startDate, out var endDate);
		StartDate = startDate;
		EndDate = endDate;
	}
}
