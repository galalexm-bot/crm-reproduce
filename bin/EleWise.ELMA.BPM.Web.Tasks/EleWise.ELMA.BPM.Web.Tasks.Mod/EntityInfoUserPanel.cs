using System;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.BPM.Web.Tasks.Models;

public class EntityInfoUserPanel
{
	private Guid typeUid = Guid.Empty;

	public IEntity<long> Entity { get; set; }

	public IUser User { get; set; }

	public bool IsAvailableAddQuestion { get; set; }

	public string RedirectUrl { get; set; }

	public string QuestionBeforeSubmitScript { get; set; }

	public Guid AddQuestionActionUid { get; set; }

	public Guid TypeUid()
	{
		if (typeUid == Guid.Empty)
		{
			typeUid = InterfaceActivator.UID(Entity.CastAsRealType().GetType());
		}
		return typeUid;
	}

	public EntityInfoUserPanel(IUser user, IEntity<long> entity, bool isAvailableAddQuestion = true)
	{
		Entity = entity;
		User = user;
		IsAvailableAddQuestion = isAvailableAddQuestion;
	}
}
