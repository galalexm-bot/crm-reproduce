using System;

namespace EleWise.ELMA.Api.Models;

public class DependencyDto
{
	private Guid _003CHeaderUid_003Ek__BackingField;

	private Guid _003CModuleUid_003Ek__BackingField;

	private string _003CName_003Ek__BackingField;

	private string _003CDisplayName_003Ek__BackingField;

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

	public Guid ModuleUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CModuleUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CModuleUid_003Ek__BackingField = value;
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
}
