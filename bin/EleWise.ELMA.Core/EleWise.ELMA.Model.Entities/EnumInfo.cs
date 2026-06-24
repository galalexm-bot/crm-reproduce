using System;

namespace EleWise.ELMA.Model.Entities;

public sealed class EnumInfo
{
	private Guid _003CUid_003Ek__BackingField;

	private string _003CName_003Ek__BackingField;

	private string _003CDisplayName_003Ek__BackingField;

	private int? _003CIntValue_003Ek__BackingField;

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

	public string Name
	{
		get
		{
			return _003CName_003Ek__BackingField;
		}
		set
		{
			_003CName_003Ek__BackingField = value;
		}
	}

	public string DisplayName
	{
		get
		{
			return _003CDisplayName_003Ek__BackingField;
		}
		set
		{
			_003CDisplayName_003Ek__BackingField = value;
		}
	}

	public int? IntValue
	{
		get
		{
			return _003CIntValue_003Ek__BackingField;
		}
		set
		{
			_003CIntValue_003Ek__BackingField = value;
		}
	}
}
