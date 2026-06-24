using System;
using Bridge;

namespace EleWise.ELMA.DTO;

internal sealed class ProxyType
{
	private Guid? typeUid;

	private readonly string _003CTypeString_003Ek__BackingField;

	internal string TypeString => _003CTypeString_003Ek__BackingField;

	internal Guid Type
	{
		get
		{
			//IL_0013: Unknown result type (might be due to invalid IL or missing references)
			//IL_0027: Unknown result type (might be due to invalid IL or missing references)
			//IL_0032: Unknown result type (might be due to invalid IL or missing references)
			if (typeUid.get_HasValue())
			{
				return typeUid.get_Value();
			}
			Guid val = default(Guid);
			((Guid)(ref val))._002Ector(TypeString);
			typeUid = val;
			return val;
		}
	}

	internal ProxyType(string type)
	{
		_003CTypeString_003Ek__BackingField = type;
	}

	[Name("$is")]
	internal bool CanCast(ReactiveProxy obj)
	{
		return obj.ProxyIs(TypeString);
	}

	public override string ToString()
	{
		return TypeString;
	}
}
