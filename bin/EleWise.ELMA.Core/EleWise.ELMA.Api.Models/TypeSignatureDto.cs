using System;

namespace EleWise.ELMA.Api.Models;

public sealed class TypeSignatureDto
{
	private Guid _003CTypeUid_003Ek__BackingField;

	private Guid _003CSubTypeUid_003Ek__BackingField;

	private bool _003CNullable_003Ek__BackingField;

	private int _003CRelationType_003Ek__BackingField;

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

	public Guid SubTypeUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CSubTypeUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CSubTypeUid_003Ek__BackingField = value;
		}
	}

	public bool Nullable
	{
		get
		{
			return _003CNullable_003Ek__BackingField;
		}
		set
		{
			_003CNullable_003Ek__BackingField = value;
		}
	}

	public int RelationType
	{
		get
		{
			return _003CRelationType_003Ek__BackingField;
		}
		set
		{
			_003CRelationType_003Ek__BackingField = value;
		}
	}
}
