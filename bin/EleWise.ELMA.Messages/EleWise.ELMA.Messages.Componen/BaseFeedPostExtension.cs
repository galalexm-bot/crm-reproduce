using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Messages.ExtensionPoints;
using EleWise.ELMA.Messaging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Components.Feed;

[Component]
public abstract class BaseFeedPostExtension : FeedCommentExtensionBase, IFeedQuestionExtension
{
	protected abstract List<Guid> CommentSupportedObject();

	public virtual Guid GetCommentActionUid(Guid objectUid)
	{
		return Guid.Empty;
	}

	public override bool CommentIsSupported(Guid objectUid)
	{
		if (CommentSupportedObject().Contains(objectUid))
		{
			return true;
		}
		Type type = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
		if (type == null)
		{
			return false;
		}
		return CommentSupportedObject().Any((Guid uid) => type.IsSubclassOf(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(uid)));
	}

	public override bool IsCommentAction(Guid objectUid, Guid actionUid)
	{
		if (actionUid != Guid.Empty)
		{
			return GetCommentActionUid(objectUid) == actionUid;
		}
		return false;
	}

	public abstract override void CanCreateComment(Guid objectUid, Dictionary<long, bool> items);

	public override Guid CreateComment(Guid objectUid, long objectId, string text, MessageAttachment[] messageAttachments)
	{
		if (objectUid == Guid.Empty || !CommentIsSupported(objectUid))
		{
			return Guid.Empty;
		}
		ICommentActionHandler serviceNotNull = Locator.GetServiceNotNull<ICommentActionHandler>();
		IEntityActionHandler serviceNotNull2 = Locator.GetServiceNotNull<IEntityActionHandler>();
		EleWise.ELMA.Security.IUser currentUser = Locator.GetServiceNotNull<IAuthenticationService>().GetCurrentUser();
		Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(objectUid);
		IEntityManager manager = ModelHelper.GetEntityManager(typeByUid);
		object target = null;
		ISecurityService serviceNotNull3 = Locator.GetServiceNotNull<ISecurityService>();
		serviceNotNull3.RunWithElevatedPrivilegies(delegate
		{
			target = manager.Load(objectId);
		});
		ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
		commentActionModel.Comment = InterfaceActivator.Create<IComment>();
		commentActionModel.Comment.Text = text.Trim();
		commentActionModel.Comment.CreationAuthor = (EleWise.ELMA.Security.Models.IUser)currentUser;
		List<IAttachment> list = ConvertAttachments(messageAttachments);
		if (list.Any())
		{
			commentActionModel.Attachments = list;
		}
		serviceNotNull.Process(target, commentActionModel);
		serviceNotNull3.RunWithElevatedPrivilegies(delegate
		{
			manager.Save(target);
		});
		Guid commentActionUid = GetCommentActionUid(objectUid);
		if (commentActionUid != Guid.Empty && target is IEntity)
		{
			EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(null, (IEntity)target, commentActionUid);
			if (entityActionEventArgs != null)
			{
				serviceNotNull.ProcessEventArgs(entityActionEventArgs, commentActionModel);
				serviceNotNull2.ActionExecuted(entityActionEventArgs);
			}
		}
		return commentActionUid;
	}

	public virtual Guid GetQuestionActionUid(Guid objectUid)
	{
		return Guid.Empty;
	}

	public virtual string GetQuestionSubject(IEntity target)
	{
		return SR.T("Вопрос");
	}

	protected abstract List<Guid> QuestionSupportedObject();

	public virtual bool QuestionIsSupported(Guid objectUid)
	{
		if (QuestionSupportedObject().Contains(objectUid))
		{
			return true;
		}
		Type type = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUidOrNull(objectUid);
		if (type == null)
		{
			return false;
		}
		return QuestionSupportedObject().Any((Guid uid) => type.IsSubclassOf(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(uid)));
	}

	public abstract void CanCreateQuestion(Guid objectUid, Dictionary<long, bool> items);

	public virtual Guid CreateQuestion(Guid objectUid, long objectId, string text, EleWise.ELMA.Security.IUser executor, MessageAttachment[] messageAttachments, bool showAll)
	{
		if (executor == null || objectUid == Guid.Empty || !QuestionIsSupported(objectUid))
		{
			return Guid.Empty;
		}
		Type typeByUid = Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(objectUid);
		IEntityManager manager = ModelHelper.GetEntityManager(typeByUid);
		IEntity target = null;
		Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
		{
			target = manager.LoadOrNull(objectId) as IEntity;
		});
		if (target != null)
		{
			IQuestionAddService service = Locator.GetService<IQuestionAddService>();
			if (service == null)
			{
				return Guid.Empty;
			}
			Guid questionActionUid = GetQuestionActionUid(objectUid);
			if (questionActionUid == Guid.Empty)
			{
				return Guid.Empty;
			}
			if (!service.AddQuestion(questionActionUid, text, GetQuestionSubject(target), executor, target, showAll))
			{
				return Guid.Empty;
			}
			return questionActionUid;
		}
		return Guid.Empty;
	}
}
