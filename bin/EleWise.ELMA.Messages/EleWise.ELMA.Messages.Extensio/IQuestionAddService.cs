using System;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security;

namespace EleWise.ELMA.Messages.ExtensionPoints;

public interface IQuestionAddService
{
	bool AddQuestion(Guid addQuestionGuid, string text, string subject, IUser executor, IEntity target, bool showAll);
}
