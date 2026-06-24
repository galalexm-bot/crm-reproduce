using System.Collections.Generic;
using EleWise.ELMA.Collections;

namespace EleWise.ELMA.Model.Entities;

public sealed class EntityListInfo
{
	private System.Collections.Generic.ICollection<EntityInfo> _003CItems_003Ek__BackingField;

	public System.Collections.Generic.ICollection<EntityInfo> Items
	{
		get
		{
			return _003CItems_003Ek__BackingField;
		}
		set
		{
			_003CItems_003Ek__BackingField = value;
		}
	}

	public EntityListInfo()
	{
		Items = new ReactiveCollection<EntityInfo>();
	}
}
