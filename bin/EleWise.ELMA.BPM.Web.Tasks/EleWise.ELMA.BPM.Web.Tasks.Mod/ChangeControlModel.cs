using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class ChangeControlModel : FormViewModel
{
	public ITask Task { get; set; }

	public bool UnderControl { get; set; }

	public IUser ControlUser { get; set; }

	public TaskControlType ControlType { get; set; }

	public IComment Comment { get; set; }

	public ChangeControlModel(ITask task)
		: this()
	{
		Task = task;
		UnderControl = task.UnderControl;
		ControlUser = task.ControlUser;
		ControlType = task.ControlType;
		Comment = InterfaceActivator.Create<IComment>();
		base.Id = task.Id.ToString();
	}

	public ChangeControlModel()
	{
		base.PostAction = "ChangeControl";
		base.PostController = "Task";
		base.PostArea = "EleWise.ELMA.BPM.Web.Tasks";
	}
}
