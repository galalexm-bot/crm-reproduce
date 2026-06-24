using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Components.Feed;

[Service]
public class QuestionAddService : IQuestionAddService
{
	public bool AddQuestion(Guid addQuestionGuid, string text, string subject, EleWise.ELMA.Security.IUser executor, IEntity target, bool showAll)
	{
		IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
		IQuestion question = InterfaceActivator.Create<IQuestion>();
		question.RefObject = new ReferenceOnEntity
		{
			Object = target
		};
		question.Subject = subject;
		question.Executor = (EleWise.ELMA.Security.Models.IUser)executor;
		question.Description = text.Trim();
		question.ShowAll = showAll;
		question.Status = TaskBaseStatus.NewOrder;
		question.Save();
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, target, addQuestionGuid);
		if (entityActionEventArgs != null)
		{
			serviceNotNull.ActionExecuted(entityActionEventArgs);
		}
		return true;
	}
}
