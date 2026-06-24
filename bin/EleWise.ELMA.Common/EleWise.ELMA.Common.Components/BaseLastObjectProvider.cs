using System;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;

namespace EleWise.ELMA.Common.Components;

public abstract class BaseLastObjectProvider : ILastObjectProvider
{
	public abstract Guid TypeUid { get; }

	public abstract string DisplayName { get; }

	public virtual void AddInfo(IEntity<long> entity)
	{
		LastObjectInfoManager.Instance.AddInfo(new ReferenceOnEntity
		{
			ObjectTypeUId = TypeUid,
			ObjectId = entity.Id
		});
	}

	public virtual bool CanAdd(IEntity<long> entity)
	{
		return true;
	}

	public virtual void RemoveInfo(IEntity<long> entity)
	{
		LastObjectInfoManager.Instance.RemoveInfo(new ReferenceOnEntity
		{
			ObjectTypeUId = TypeUid,
			ObjectId = entity.Id
		});
	}
}
