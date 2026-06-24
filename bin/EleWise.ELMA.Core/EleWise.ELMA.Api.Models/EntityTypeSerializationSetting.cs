using System;
using System.Collections.Generic;
using Bridge;
using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Api.Models;

[ObjectLiteral]
[SimpleSerialize]
public sealed class EntityTypeSerializationSettingsDto
{
	private Guid _003CTypeUid_003Ek__BackingField;

	private System.Collections.Generic.ICollection<string> _003CProperties_003Ek__BackingField;

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

	public System.Collections.Generic.ICollection<string> Properties
	{
		get
		{
			return _003CProperties_003Ek__BackingField;
		}
		set
		{
			_003CProperties_003Ek__BackingField = value;
		}
	}
}
