using System;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Types.Validation;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class FastTaskModel : FormViewModel
{
	public ITask Entity { get; set; }

	public string CallbackScript { get; set; }

	[Required(true)]
	[RequiredField]
	public DateTime StartDate { get; set; }

	[Required(true)]
	[RequiredField]
	public DateTime EndDate { get; set; }

	[Obsolete("Не использовать", true)]
	public bool StartDateDamper { get; set; }

	[Obsolete("Не использовать", true)]
	public bool EndDateDamper { get; set; }

	public FastTaskStatusSave Status { get; set; }

	[DisplayName(typeof(__Resources_FastTaskModel), "P_WorkLog")]
	public WorkTime? WorkMinutes { get; set; }

	public DateTime CreateDate { get; set; }

	public bool WorkLogItemPartEnabled { get; set; }

	[DisplayName(typeof(__Resources_FastTaskModel), "P_WorkLogItemHarmonizator")]
	public IUser WorkLogItemHarmonizator { get; set; }

	[DisplayName(typeof(__Resources_FastTaskModel), "P_WorkLogActivity")]
	public IWorkLogActivity WorkLogActivity { get; set; }
}
