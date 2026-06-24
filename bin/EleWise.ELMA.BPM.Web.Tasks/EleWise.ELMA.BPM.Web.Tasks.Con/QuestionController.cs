using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EleWise.ELMA.BPM.Mvc.Controllers;
using EleWise.ELMA.BPM.Web.Tasks.Models;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Attributes;

namespace EleWise.ELMA.BPM.Web.Tasks.Controllers;

[RouteArea("EleWise.ELMA.BPM.Web.Tasks")]
public class QuestionController : BPMController<IQuestion, long>
{
	public IEntityActionHandler ActionHandler { get; set; }

	[HttpGet]
	public ActionResult QuestionCreateForm(QuestionModel model)
	{
		return (ActionResult)(object)((Controller)this).PartialView("CreateForm", (object)model);
	}

	[HttpPost]
	[TransactionAction]
	public ActionResult SaveQuestion(QuestionModel model)
	{
		//IL_0101: Unknown result type (might be due to invalid IL or missing references)
		//IL_0107: Expected O, but got Unknown
		IUser currentUser = GetCurrentUser();
		if (model != null)
		{
			model.Question.CreationAuthor = currentUser;
			model.Question.RefObject = new ReferenceOnEntity
			{
				ObjectId = model.ObjectId,
				ObjectTypeUId = model.ObjectTypeUid
			};
			IEntity @object = model.Question.RefObject.Object;
			if (@object != null)
			{
				model.Question.Subject = @object.ToString();
			}
			model.Question.Status = TaskBaseStatus.NewOrder;
			model.Question.Attachments.RemoveAll((ICollection<IAttachment>)((IEnumerable<IAttachment>)model.Question.Attachments).Where((IAttachment a) => a.File == null).ToList());
			base.Manager.Save(model.Question);
			if (model.AddQuestionActionUid != Guid.Empty && @object != null)
			{
				ActionHandler.ActionExecuted(EntityActionEventArgs.TryCreate(null, @object, model.AddQuestionActionUid));
			}
			if (model.IsAjax)
			{
				return (ActionResult)new EmptyResult();
			}
			if (!string.IsNullOrEmpty(model.RedirectUrl))
			{
				return (ActionResult)(object)((Controller)this).Redirect(model.RedirectUrl);
			}
		}
		return (ActionResult)(object)((Controller)this).Redirect("~/");
	}

	public ActionResult QuestionExec(long id)
	{
		IQuestion question = base.Manager.Load(id);
		SetAsReadForFeed(question);
		return (ActionResult)(object)((Controller)this).View((object)question);
	}

	public JsonResult GetQuestionStatus(long id)
	{
		IQuestion question = QuestionManager.Instance.Load(id);
		return ((Controller)this).Json((object)new
		{
			Name = question.Status.Name,
			HasAnswer = (question.Answer != null),
			IsAuthor = (question.CreationAuthor.Id == GetCurrentUser().Id)
		});
	}

	public ActionResult Close(long id)
	{
		IQuestion question = QuestionManager.Instance.Load(id);
		SetAsReadForFeed(question);
		QuestionManager.Instance.Close(question);
		return (ActionResult)(object)((Controller)this).Redirect("~/");
	}
}
