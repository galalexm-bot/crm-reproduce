using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class CreateApprovalModel : FormViewModel
{
	public string PopupId { get; set; }

	[Required(true)]
	[RequiredField]
	public IUser Harmonizator { get; set; }

	[Obsolete("Не использовать", true)]
	public bool HarmonizatorStartDateDamper { get; set; }

	[Required(true)]
	[RequiredField]
	public DateTime HarmonizatorStartDate { get; set; }

	[Required(true)]
	[RequiredField]
	public DateTime HarmonizatorEndDate { get; set; }

	[Obsolete("Не использовать", true)]
	public bool HarmonizatorEndDateDamper { get; set; }

	public string Comment { get; set; }

	public ITask Task { get; set; }

	public CreateApprovalModel([NotNull] ITask task)
		: this()
	{
		if (task == null)
		{
			throw new ArgumentNullException("task");
		}
		Task = task;
		if (Task.StartDate.HasValue && Task.StartDate.Value > DateTime.Now)
		{
			HarmonizatorStartDate = new DateTime(Task.StartDate.Value.Year, Task.StartDate.Value.Month, Task.StartDate.Value.Day, DateTime.Now.Hour, DateTime.Now.Minute.LeadMinutesToFifteen(), 0);
		}
		if (Task.EndDate.HasValue && Task.EndDate.Value > DateTime.Now)
		{
			HarmonizatorEndDate = new DateTime(Task.EndDate.Value.Year, Task.EndDate.Value.Month, Task.EndDate.Value.Day, DateTime.Now.Hour, DateTime.Now.Minute.LeadMinutesToFifteen(), 0);
		}
	}

	public CreateApprovalModel()
	{
		base.PostAction = "CreateApproval";
		base.PostController = "Task";
		base.PostArea = "EleWise.ELMA.BPM.Web.Tasks";
		HarmonizatorStartDate = DateTime.Now;
		HarmonizatorEndDate = DateTime.Now;
	}
}
