using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class TaskBaseModel : EntityModel<ITaskBase>
{
	public string ReturnUrl { get; set; }

	[Required(true)]
	[RequiredField]
	public DateTime? StartDate { get; set; }

	[Required(true)]
	[RequiredField]
	public DateTime? EndDate { get; set; }

	[Obsolete("Не использовать", true)]
	public bool StartDateDamper { get; set; }

	[Obsolete("Не использовать", true)]
	public bool EndDateDamper { get; set; }

	public bool RequiredStartDate { get; set; }

	public bool RequiredEndDate { get; set; }

	public bool HideStartDate { get; set; }

	public string Comment { get; set; }

	public TaskBaseModel()
	{
		SetDefaultValues();
	}

	public TaskBaseModel(ITaskBase task)
	{
		SetDefaultValues();
		base.Entity = task;
		NormalizeDates();
	}

	private void SetDefaultValues()
	{
		RequiredStartDate = true;
		RequiredEndDate = true;
		base.Entity = TaskBaseManager.Instance.Create();
		base.Entity.StartDate = null;
	}

	public void NormalizeDates()
	{
		TaskModel.ToEditTaskDates(base.Entity, out var startDate, out var _, out var endDate, out var _);
		StartDate = startDate;
		EndDate = endDate;
	}
}
