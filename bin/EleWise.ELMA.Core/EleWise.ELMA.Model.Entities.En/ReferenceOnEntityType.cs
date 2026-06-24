using System;

namespace EleWise.ELMA.Model.Entities.EntityReferences;

public class ReferenceOnEntityType
{
	private readonly Guid _003CTypeUid_003Ek__BackingField;

	public Guid TypeUid => _003CTypeUid_003Ek__BackingField;

	public ReferenceOnEntityType(Guid typeUid)
	{
		//IL_0007: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		_003CTypeUid_003Ek__BackingField = typeUid;
	}

	public override bool Equals(object obj)
	{
		//IL_000b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0011: Unknown result type (might be due to invalid IL or missing references)
		if (obj is ReferenceOnEntityType referenceOnEntityType)
		{
			return referenceOnEntityType.TypeUid == TypeUid;
		}
		return false;
	}

	public override int GetHashCode()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Guid typeUid = TypeUid;
		return ((object)((object)(Guid)(ref typeUid)).ToString()).GetHashCode();
	}

	public override string ToString()
	{
		//IL_0001: Unknown result type (might be due to invalid IL or missing references)
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		Guid typeUid = TypeUid;
		return ((object)(Guid)(ref typeUid)).ToString();
	}
}
