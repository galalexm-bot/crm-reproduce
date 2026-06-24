using System;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Models;

public class EntityLastActionInfo
{
	private IEntity entity;

	private bool isDeleted;

	public Guid ObjectUid { get; set; }

	public long ObjectId { get; set; }

	public DateTime ActionDate { get; set; }

	public IEntity Entity
	{
		get
		{
			if (entity != null && (long)entity.GetId() == ObjectId && InterfaceActivator.UID(entity.GetType()) == ObjectUid)
			{
				return entity;
			}
			entity = null;
			if (ObjectUid != Guid.Empty)
			{
				Locator.GetServiceNotNull<ISecurityService>().RunWithElevatedPrivilegies(delegate
				{
					Type entityType = ModelHelper.GetEntityType(ObjectUid);
					if (entityType == null)
					{
						return;
					}
					IEntityManager entityManager = ModelHelper.GetEntityManager(entityType);
					try
					{
						entity = entityManager.LoadOrNull(ObjectId) as IEntity;
					}
					catch (ObjectIsDeletedException)
					{
						isDeleted = true;
					}
					catch
					{
					}
				});
			}
			return entity;
		}
	}

	public bool IsDeleted()
	{
		if (Entity == null || isDeleted)
		{
			return true;
		}
		if (Entity is ISoftDeletable softDeletable)
		{
			return softDeletable.IsDeleted;
		}
		return false;
	}
}
