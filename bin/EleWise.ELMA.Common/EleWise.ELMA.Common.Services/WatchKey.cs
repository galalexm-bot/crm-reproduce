using System;

namespace EleWise.ELMA.Common.Services;

public class WatchKey
{
	public Guid ObjectUid { get; set; }

	public Guid ActionUid { get; set; }

	public object EntityId { get; set; }

	public override int GetHashCode()
	{
		return ((6 * 4 + ObjectUid.GetHashCode()) * 4 + ActionUid.GetHashCode()) * 4 + ((EntityId != null) ? EntityId.GetHashCode() : 0);
	}

	public override bool Equals(object obj)
	{
		if (!(obj is WatchKey watchKey))
		{
			return false;
		}
		if (ObjectUid == watchKey.ObjectUid && ActionUid == watchKey.ActionUid)
		{
			if (EntityId != null || watchKey.EntityId != null)
			{
				if (EntityId != null)
				{
					return EntityId.Equals(watchKey.EntityId);
				}
				return false;
			}
			return true;
		}
		return false;
	}
}
