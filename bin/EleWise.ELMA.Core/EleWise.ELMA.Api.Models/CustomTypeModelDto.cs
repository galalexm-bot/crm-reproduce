using System;

namespace EleWise.ELMA.Api.Models;

public sealed class CustomTypeModelDto
{
	private Guid _003CTypeUid_003Ek__BackingField;

	private Guid _003CSubTypeUid_003Ek__BackingField;

	private bool _003CIsCollection_003Ek__BackingField;

	private Guid _003CHeaderUid_003Ek__BackingField;

	private Guid _003CItemUid_003Ek__BackingField;

	private Guid _003CModuleItemUid_003Ek__BackingField;

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

	public bool IsCollection
	{
		get
		{
			return _003CIsCollection_003Ek__BackingField;
		}
		set
		{
			_003CIsCollection_003Ek__BackingField = value;
		}
	}

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

	public Guid ModuleItemUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CModuleItemUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CModuleItemUid_003Ek__BackingField = value;
		}
	}
}
