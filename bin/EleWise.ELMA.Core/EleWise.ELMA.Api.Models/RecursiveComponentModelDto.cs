using System;

namespace EleWise.ELMA.Api.Models;

public sealed class RecursiveComponentModelDto
{
	private ClientComponentModelDto[] _003CComponentCache_003Ek__BackingField;

	private ClientComponentModelDto _003CHeader_003Ek__BackingField;

	private ClientExtensionPointModelDto[] _003CExtensionPoints_003Ek__BackingField;

	private CustomTypeModelDto[] _003CCustomTypes_003Ek__BackingField;

	private Guid[] _003CEntityMetadataUids_003Ek__BackingField;

	private Guid[] _003CEnumMetadataUids_003Ek__BackingField;

	private EntityDependencyDto[] _003CEntityDependencies_003Ek__BackingField;

	private string[] _003CErrors_003Ek__BackingField;

	public ClientComponentModelDto[] ComponentCache
	{
		get
		{
			return _003CComponentCache_003Ek__BackingField;
		}
		set
		{
			_003CComponentCache_003Ek__BackingField = value;
		}
	}

	public ClientComponentModelDto Header
	{
		get
		{
			return _003CHeader_003Ek__BackingField;
		}
		set
		{
			_003CHeader_003Ek__BackingField = value;
		}
	}

	public ClientExtensionPointModelDto[] ExtensionPoints
	{
		get
		{
			return _003CExtensionPoints_003Ek__BackingField;
		}
		set
		{
			_003CExtensionPoints_003Ek__BackingField = value;
		}
	}

	public CustomTypeModelDto[] CustomTypes
	{
		get
		{
			return _003CCustomTypes_003Ek__BackingField;
		}
		set
		{
			_003CCustomTypes_003Ek__BackingField = value;
		}
	}

	public Guid[] EntityMetadataUids
	{
		get
		{
			return _003CEntityMetadataUids_003Ek__BackingField;
		}
		set
		{
			_003CEntityMetadataUids_003Ek__BackingField = value;
		}
	}

	public Guid[] EnumMetadataUids
	{
		get
		{
			return _003CEnumMetadataUids_003Ek__BackingField;
		}
		set
		{
			_003CEnumMetadataUids_003Ek__BackingField = value;
		}
	}

	public EntityDependencyDto[] EntityDependencies
	{
		get
		{
			return _003CEntityDependencies_003Ek__BackingField;
		}
		set
		{
			_003CEntityDependencies_003Ek__BackingField = value;
		}
	}

	public string[] Errors
	{
		get
		{
			return _003CErrors_003Ek__BackingField;
		}
		set
		{
			_003CErrors_003Ek__BackingField = value;
		}
	}
}
