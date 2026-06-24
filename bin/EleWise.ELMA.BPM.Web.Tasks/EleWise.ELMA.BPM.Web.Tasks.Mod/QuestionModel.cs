using System;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.Forms;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class QuestionModel : FormViewModel
{
	public long ObjectId { get; set; }

	public Guid ObjectTypeUid { get; set; }

	public Guid AddQuestionActionUid { get; set; }

	public IQuestion Question { get; set; }

	public string PopupId { get; set; }

	public string BeforeSubmitScript { get; set; }

	public QuestionModel()
	{
		base.PostAction = "SaveQuestion";
		base.PostController = "Question";
		base.PostArea = "EleWise.ELMA.BPM.Web.Tasks";
		Question = InterfaceActivator.Create<IQuestion>();
	}
}
