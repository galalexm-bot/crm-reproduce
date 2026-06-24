using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class AnswerModel : FormViewModel
{
	public long ObjectId { get; set; }

	public IAnswer Answer { get; set; }

	public long AnswerId { get; set; }

	public string PopupId { get; set; }

	public bool ParentShowAll { get; set; }

	public AnswerModel()
	{
		Answer = InterfaceActivator.Create<IAnswer>();
		base.PostAction = "AddAnswer";
		base.PostController = "Answer";
		base.PostArea = "EleWise.ELMA.BPM.Web.Tasks";
	}
}
