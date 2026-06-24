using System.Security;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security.Services;

namespace EleWise.ELMA.CRM.Managers;

public abstract class BaseCrmManager<T> : EntityManager<T, long> where T : IEntity<long>
{
	[NotNull]
	public ICommentActionHandler CommentActionHandler { get; set; }

	[Transaction]
	public virtual void AddComment(IEntity entity, string comment, string actionUidStr)
	{
		ICommentActionModel commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
		commentActionModel.Comment = InterfaceActivator.Create<IComment>();
		commentActionModel.Comment.Text = comment;
		CommentActionHandler.Process(entity, commentActionModel);
		base.ActionHandler.ActionExecuted(TryCreateCommentActionEventArgs(null, entity, actionUidStr, commentActionModel));
	}

	[Auditable]
	protected virtual EntityActionEventArgs TryCreateCommentActionEventArgs(IEntity old, IEntity @new, string actionUidStr, ICommentActionModel actionModel)
	{
		EntityActionEventArgs entityActionEventArgs = EntityActionEventArgs.TryCreate(old, @new, actionUidStr);
		if (entityActionEventArgs != null)
		{
			CommentActionHandler.ProcessEventArgs(entityActionEventArgs, actionModel);
		}
		return entityActionEventArgs;
	}

	[PublicApiMember]
	public override void Delete(T obj)
	{
		CheckPermissionToDelete();
		if (!base.SecurityService.HasPermission(CommonPermissions.View, obj))
		{
			throw new SecurityException();
		}
		base.Delete(obj);
	}

	protected void BaseDelete(T obj)
	{
		base.Delete(obj);
	}

	public override void DeleteAll()
	{
		CheckPermissionToDelete();
		foreach (T item in FindAll(cacheble: false))
		{
			base.Delete(item);
		}
	}

	private void CheckPermissionToDelete()
	{
		if (!base.SecurityService.HasPermission(CRMPermissionProvider.CRMFullAccessPermission) && !base.SecurityService.HasPermission(CRMPermissionProvider.CRMDeletePermission))
		{
			throw new SecurityException();
		}
	}
}
