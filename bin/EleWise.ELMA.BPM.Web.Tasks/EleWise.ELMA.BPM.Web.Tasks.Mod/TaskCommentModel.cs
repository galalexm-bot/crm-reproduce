using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using EleWise.ELMA.BPM.Web.Common.Models;
using EleWise.ELMA.BPM.Web.Tasks.Extensions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class TaskCommentModel : CommentWithAttachments
{
	[DefaultValue(true)]
	public bool AlertInform { get; set; }

	public bool ShowWorkLog { get; set; }

	public bool ShowAlertInform { get; set; }

	public IWorkLog WorkLog { get; set; }

	public IEnumerable<ITaskCompleteValidator> GetValidators()
	{
		return from v in ComponentManager.Current.GetExtensionPoints<ITaskCompleteValidator>()
			where v.CheckType(this)
			select v;
	}

	public TaskCommentModel()
	{
		AlertInform = true;
		ShowWorkLog = false;
		WorkLog = InterfaceActivator.Create<IWorkLog>();
		WorkLog.WorkMinutes = 0L;
		WorkLog.Status = WorkLogStatus.New;
		ShowAlertInform = true;
	}
}
