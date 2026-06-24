using System;
using System.Collections.Generic;
using Bridge;

namespace EleWise.ELMA.Api.Models;

public sealed class ItemRuntimeModelDto
{
	internal class Comparer : IEqualityComparer<ItemRuntimeModelDto>, IBridgeClass
	{
		public bool Equals(ItemRuntimeModelDto x, ItemRuntimeModelDto y)
		{
			//IL_0021: Unknown result type (might be due to invalid IL or missing references)
			//IL_0026: Unknown result type (might be due to invalid IL or missing references)
			//IL_002a: Unknown result type (might be due to invalid IL or missing references)
			//IL_0037: Unknown result type (might be due to invalid IL or missing references)
			//IL_003c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0040: Unknown result type (might be due to invalid IL or missing references)
			if (x == y)
			{
				return true;
			}
			if (x == null)
			{
				return false;
			}
			if (y == null)
			{
				return false;
			}
			if (((object)x).GetType() != ((object)y).GetType())
			{
				return false;
			}
			Guid val = x.HeaderUid;
			if (((Guid)(ref val)).Equals(y.HeaderUid))
			{
				val = x.ItemUid;
				return ((Guid)(ref val)).Equals(y.ItemUid);
			}
			return false;
		}

		public int GetHashCode(ItemRuntimeModelDto obj)
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0006: Unknown result type (might be due to invalid IL or missing references)
			//IL_001b: Unknown result type (might be due to invalid IL or missing references)
			//IL_0020: Unknown result type (might be due to invalid IL or missing references)
			Guid val = obj.HeaderUid;
			int num = ((object)(Guid)(ref val)).GetHashCode() * 397;
			val = obj.ItemUid;
			return num ^ ((object)(Guid)(ref val)).GetHashCode();
		}
	}

	private Guid _003CHeaderUid_003Ek__BackingField;

	private Guid _003CItemUid_003Ek__BackingField;

	public Guid HeaderUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CHeaderUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CHeaderUid_003Ek__BackingField = value;
		}
	}

	public Guid ItemUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CItemUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CItemUid_003Ek__BackingField = value;
		}
	}
}
