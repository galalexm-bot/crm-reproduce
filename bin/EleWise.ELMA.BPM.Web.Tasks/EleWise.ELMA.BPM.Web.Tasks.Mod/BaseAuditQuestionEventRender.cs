using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Web.Mvc.Models.History;

namespace EleWise.ELMA.BPM.Web.Tasks.Models.History;

[DeveloperApi(DeveloperApiType.ExtensionPoint)]
public abstract class BaseAuditQuestionEventRender : BaseAuditEventRender
{
	public IAuthenticationService AuthenticationService { get; set; }

	public bool CanRenderTypeUid(EntityActionEventArgs @event, Guid typeUidEntity)
	{
		if (!base.CanRender(@event))
		{
			return false;
		}
		bool flag = CheckShowAll(@event);
		return ((IQuestion)@event.New).RefObject.ObjectTypeUId == typeUidEntity && flag;
	}

	public bool CanRenderCheckClasses(EntityActionEventArgs @event, Guid typeUidEntity)
	{
		if (!base.CanRender(@event))
		{
			return false;
		}
		Guid objectTypeUId = ((IQuestion)@event.New).RefObject.ObjectTypeUId;
		if (!(MetadataServiceContext.Service.GetMetadata(objectTypeUId) is EntityMetadata entityMetadata))
		{
			return false;
		}
		bool flag = CheckShowAll(@event);
		List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses(entityMetadata);
		baseClasses.Add(entityMetadata);
		return baseClasses.Any((ClassMetadata c) => c.Uid == typeUidEntity) && flag;
	}

	public bool CheckShowAll(EntityActionEventArgs @event)
	{
		IQuestion question = (IQuestion)@event.New;
		IUser currentUser = AuthenticationService.GetCurrentUser<IUser>();
		if (question == null || question.ShowAll || (question.CreationAuthor != currentUser && question.Executor != currentUser))
		{
			return question.ShowAll;
		}
		return true;
	}
}
