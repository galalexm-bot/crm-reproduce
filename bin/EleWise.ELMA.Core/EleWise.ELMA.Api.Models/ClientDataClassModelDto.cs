using System;

namespace EleWise.ELMA.Api.Models;

public sealed class ClientDataClassModelDto
{
	private Guid _003CHeaderUid_003Ek__BackingField;

	private Guid _003CItemUid_003Ek__BackingField;

	private Guid _003CModuleItemUid_003Ek__BackingField;

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
