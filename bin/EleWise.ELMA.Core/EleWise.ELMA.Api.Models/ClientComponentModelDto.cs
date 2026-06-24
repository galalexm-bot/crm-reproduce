using System;

namespace EleWise.ELMA.Api.Models;

public sealed class ClientComponentModelDto
{
	private Guid _003CItemUid_003Ek__BackingField;

	private Guid _003CModuleItemUid_003Ek__BackingField;

	private bool _003CAsync_003Ek__BackingField;

	private Guid[] _003COwners_003Ek__BackingField;

	private string[] _003CRenderUidList_003Ek__BackingField;

	private ClientFunctionModelDto[] _003CFunctions_003Ek__BackingField;

	private ClientDataClassModelDto[] _003CDataClasses_003Ek__BackingField;

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

	public bool Async
	{
		get
		{
			return _003CAsync_003Ek__BackingField;
		}
		set
		{
			_003CAsync_003Ek__BackingField = value;
		}
	}

	public Guid[] Owners
	{
		get
		{
			return _003COwners_003Ek__BackingField;
		}
		set
		{
			_003COwners_003Ek__BackingField = value;
		}
	}

	public string[] RenderUidList
	{
		get
		{
			return _003CRenderUidList_003Ek__BackingField;
		}
		set
		{
			_003CRenderUidList_003Ek__BackingField = value;
		}
	}

	public ClientFunctionModelDto[] Functions
	{
		get
		{
			return _003CFunctions_003Ek__BackingField;
		}
		set
		{
			_003CFunctions_003Ek__BackingField = value;
		}
	}

	public ClientDataClassModelDto[] DataClasses
	{
		get
		{
			return _003CDataClasses_003Ek__BackingField;
		}
		set
		{
			_003CDataClasses_003Ek__BackingField = value;
		}
	}
}
