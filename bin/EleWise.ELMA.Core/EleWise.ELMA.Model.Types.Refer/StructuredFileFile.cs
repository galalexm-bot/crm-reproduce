using System;
using EleWise.ELMA.Api.Attributes;

namespace EleWise.ELMA.Model.Types.References;

[SimpleSerialize]
public sealed class StructuredFileFile
{
	private Guid _003CUid_003Ek__BackingField;

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
}
