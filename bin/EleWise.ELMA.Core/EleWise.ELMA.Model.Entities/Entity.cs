using System;
using System.Runtime.Serialization;
using Bridge;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.DTO;

namespace EleWise.ELMA.Model.Entities;

public class Entity : DataClass
{
	private long? _003CId_003Ek__BackingField;

	private Guid _003CUid_003Ek__BackingField;

	private Guid _003CTypeUid_003Ek__BackingField;

	public long? Id
	{
		get
		{
			return _003CId_003Ek__BackingField;
		}
		set
		{
			_003CId_003Ek__BackingField = value;
		}
	}

	public Guid Uid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CUid_003Ek__BackingField = value;
		}
	}

	public Guid TypeUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CTypeUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CTypeUid_003Ek__BackingField = value;
		}
	}

	public override string ToString()
	{
		return ObjectExtensions.As<string>(((object)this).get_Item("$jsonObj").get_Item("$toString"));
	}

	[OnDeserialized]
	public void OnDeserializedMethod(object raw)
	{
		((object)this).set_Item("$jsonObj", raw);
	}

	[Name("$is")]
	private static bool Is(object obj)
	{
		return Is(obj, Script.Write<System.Type>("this", new object[0]));
	}

	private static bool Is(object obj, System.Type type)
	{
		if (type == typeof(Entity))
		{
			if (obj is ReactiveProxy reactiveProxy && reactiveProxy.isEntity)
			{
				return true;
			}
			if (ObjectExtensions.As<string>(obj.get_Item("$$name")) == "EleWise.ELMA.Model.Entities.Entity")
			{
				return true;
			}
		}
		return false;
	}
}
