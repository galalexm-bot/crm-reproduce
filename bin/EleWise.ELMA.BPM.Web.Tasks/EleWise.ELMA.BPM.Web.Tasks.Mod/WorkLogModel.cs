using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class WorkLogModel : EntityModel<IWorkLog>
{
	public long TaskId { get; set; }

	public string PopupId { get; set; }

	public string RedirectUrl { get; set; }

	public bool IsAjax { get; set; }

	public WorkLogModel()
	{
		base.Entity = InterfaceActivator.Create<IWorkLog>();
		base.Entity.WorkMinutes = 0L;
		base.Entity.Status = WorkLogStatus.New;
	}
}
