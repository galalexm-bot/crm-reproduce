using System;

namespace EleWise.ELMA.Model.Types.References;

public sealed class ReferenceOnType
{
	private readonly Guid _003CTypeUid_003Ek__BackingField;

	private readonly Guid _003CSubTypeUid_003Ek__BackingField;

	public Guid TypeUid => _003CTypeUid_003Ek__BackingField;

	public Guid SubTypeUid => _003CSubTypeUid_003Ek__BackingField;

	public ReferenceOnType(Guid typeUid)
		: this(typeUid, Guid.Empty)
	{
	}//IL_0001: Unknown result type (might be due to invalid IL or missing references)
	//IL_0002: Unknown result type (might be due to invalid IL or missing references)


	public ReferenceOnType(Guid typeUid, Guid subTypeUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Unknown result type (might be due to invalid IL or missing references)
		_003CTypeUid_003Ek__BackingField = typeUid;
		_003CSubTypeUid_003Ek__BackingField = subTypeUid;
	}

	public override bool Equals(object o)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		if (o is ReferenceOnType referenceOnType && TypeUid == referenceOnType.TypeUid)
		{
			return SubTypeUid == referenceOnType.SubTypeUid;
		}
		return false;
	}

	public override int GetHashCode()
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		return ((object)$"{TypeUid}_{SubTypeUid}").GetHashCode();
	}
}
