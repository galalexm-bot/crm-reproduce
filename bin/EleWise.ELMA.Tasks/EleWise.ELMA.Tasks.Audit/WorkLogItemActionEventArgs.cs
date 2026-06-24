using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Tasks.Audit;

[Uid("91297E8E-E569-409A-A720-5C80C7123E1A")]
public class WorkLogItemActionEventArgs : EntityActionEventArgs
{
	private byte[] additionalData;

	private IList<WorkLogItemInfo> infos;

	public IList<WorkLogItemInfo> Infos
	{
		get
		{
			if (infos == null)
			{
				GetAdditionalData();
			}
			return infos;
		}
	}

	protected WorkLogItemActionEventArgs(IEntity entity, Guid objectUid, Guid actionUid)
		: base(entity, objectUid, actionUid)
	{
		infos = new List<WorkLogItemInfo>();
	}

	public WorkLogItemActionEventArgs(IEntity old, IEntity @new, Guid actionUid, IList<WorkLogItemInfo> info)
		: base(old, @new, actionUid)
	{
		infos = info;
	}

	public static WorkLogItemActionEventArgs TryCreate(IEntity old, IEntity @new, Guid actionUid, IList<WorkLogItemInfo> info)
	{
		try
		{
			WorkLogItemActionEventArgs workLogItemActionEventArgs = new WorkLogItemActionEventArgs(old, @new, actionUid, info);
			if (workLogItemActionEventArgs.Action == null || workLogItemActionEventArgs.Object == null)
			{
				return null;
			}
			return workLogItemActionEventArgs;
		}
		catch
		{
			return null;
		}
	}

	public override byte[] GetAdditionalData()
	{
		if (additionalData != null)
		{
			return additionalData;
		}
		return additionalData = ClassSerializationHelper.SerializeObject(infos);
	}

	public override void SetAdditionalData(byte[] data)
	{
		if (data != null)
		{
			additionalData = data;
			infos = (List<WorkLogItemInfo>)ClassSerializationHelper.DeserializeObject(data);
		}
	}
}
