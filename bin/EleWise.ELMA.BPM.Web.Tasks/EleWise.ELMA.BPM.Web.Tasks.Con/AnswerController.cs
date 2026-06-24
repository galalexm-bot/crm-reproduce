using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Attributes;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Tasks")]
public class AnswerController : BPMController<IAnswer, long>
{
	[HttpGet]
	public ActionResult AnswerCreateForm(AnswerModel model)
	{
		if (model != null)
		{
			_ = model.ObjectId;
			if (model.ObjectId != 0L)
			{
				model.ParentShowAll = QuestionManager.Instance.Load(model.ObjectId)?.ShowAll ?? model.Answer.ShowAll;
			}
		}
		return (ActionResult)(object)((Controller)this).PartialView("AnswerForm", (object)model);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult AddAnswer(AnswerModel model)
	{
		SaveAnswer(model.ObjectId, model.Answer.Text, (ISet<IAttachment>)model.Answer.Attachments);
		if (!string.IsNullOrEmpty(model.RedirectUrl))
		{
			return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
		}
		return (ActionResult)(object)((Controller)this).Redirect("~/");
	}

	public static void SaveAnswer(long objectId, string text, ISet<IAttachment> attachments = null)
	{
		IUser currentUser = EleWise.ELMA.Security.Services.AuthenticationService.GetCurrentUser<IUser>();
		IQuestion question = QuestionManager.Instance.Load(objectId);
		if (question.Answer != null)
		{
			return;
		}
		InstanceOf<IAnswer> instanceOf = new InstanceOf<IAnswer>();
		instanceOf.New.CreationAuthor = currentUser;
		instanceOf.New.Question = question;
		instanceOf.New.Text = text;
		IAnswer @new = instanceOf.New;
		if (attachments != null && attachments.Count > 0)
		{
			@new.Attachments.AddAll((ICollection<IAttachment>)attachments.Where((IAttachment a) => a.File != null).ToList());
		}
		question.EndDate = DateTime.Now;
		question.Status = TaskBaseStatus.Complete;
		question.Answer = @new;
		@new.Save();
	}
}
