using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Common.Services;

[Service]
internal class EntityTaskModelDraftService : IEntityTaskModelDraftService
{
	private IEnumerable<IEntityTaskModelDraftExtensionPoint> entityTaskModelDraftExtensionPoints;

	public EntityTaskModelDraftService(IEnumerable<IEntityTaskModelDraftExtensionPoint> entityTaskModelDraftExtensionPoints)
	{
		this.entityTaskModelDraftExtensionPoints = entityTaskModelDraftExtensionPoints;
	}

	public void ApplyStates(long taskId, object state)
	{
		foreach (IEntityTaskModelDraftExtensionPoint entityTaskModelDraftExtensionPoint in entityTaskModelDraftExtensionPoints)
		{
			if (entityTaskModelDraftExtensionPoint.CanSave(state.GetType()))
			{
				entityTaskModelDraftExtensionPoint.ApplyState(taskId, state);
			}
		}
	}

	public void ApplyState(object draftState, object state)
	{
		foreach (IEntityTaskModelDraftExtensionPoint entityTaskModelDraftExtensionPoint in entityTaskModelDraftExtensionPoints)
		{
			if (entityTaskModelDraftExtensionPoint.CanSave(state.GetType()))
			{
				entityTaskModelDraftExtensionPoint.ApplyState(draftState, state);
			}
		}
	}

	public List<object> GetStates(long taskId)
	{
		return GetStates(taskId, null);
	}

	public List<object> GetStates(long taskId, Type type)
	{
		List<object> list = new List<object>();
		foreach (IEntityTaskModelDraftExtensionPoint entityTaskModelDraftExtensionPoint in entityTaskModelDraftExtensionPoints)
		{
			object state = entityTaskModelDraftExtensionPoint.GetState(taskId);
			if (state != null && (type == null || state.GetType() == type))
			{
				list.Add(entityTaskModelDraftExtensionPoint.GetState(taskId));
			}
		}
		return list;
	}

	public void RemoveStates(long taskId)
	{
		foreach (IEntityTaskModelDraftExtensionPoint entityTaskModelDraftExtensionPoint in entityTaskModelDraftExtensionPoints)
		{
			entityTaskModelDraftExtensionPoint.RemoveState(taskId);
		}
	}

	public void Save(object state, long taskId)
	{
		foreach (IEntityTaskModelDraftExtensionPoint entityTaskModelDraftExtensionPoint in entityTaskModelDraftExtensionPoints)
		{
			if (entityTaskModelDraftExtensionPoint.CanSave(state.GetType()))
			{
				entityTaskModelDraftExtensionPoint.Save(state, taskId);
			}
		}
	}
}
