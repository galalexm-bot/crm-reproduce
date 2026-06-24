using System;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Tasks.Managers;

internal class TaskBaseImplManager<T, TIntf, TId> : EntityImplManager<T, TIntf, TId>, ITaskBaseManager where T : TIntf where TIntf : class, ITaskBase, IEntity<TId>
{
	private ITaskBaseManager manager;

	private ITaskBaseManager Manager => manager ?? Locator.GetServiceNotNull<ITaskBaseManager>();

	[PublicApiMember]
	public bool CanComplete(ITaskBase task, IUser user)
	{
		return Manager.CanComplete(task, user);
	}

	[PublicApiMember]
	public bool? CanStartReAssign(ITaskBase task, IUser userToStart)
	{
		return Manager.CanStartReAssign(task, userToStart);
	}

	[PublicApiMember]
	public ITaskBaseManager GetImplManager(Type entityType)
	{
		return Manager.GetImplManager(entityType);
	}

	[PublicApiMember]
	public bool? IsAvailableCopy(ITaskBase task)
	{
		return Manager.IsAvailableCopy(task);
	}
}
