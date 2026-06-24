using System;

namespace EleWise.ELMA.Api.Models;

internal sealed class ActionExecutionRequestDto
{
	private Guid _003CTypeUid_003Ek__BackingField;

	private Guid _003CInstanceUid_003Ek__BackingField;

	private string _003CScriptName_003Ek__BackingField;

	private string _003CParameter_003Ek__BackingField;

	private TypeSignatureDto _003CParameterType_003Ek__BackingField;

	private TypeSignatureDto _003CReturnType_003Ek__BackingField;

	private EntityTypeSerializationSettingsDto[] _003CEntityTypeSerializationSettings_003Ek__BackingField;

	private UIRuntimeModelDto _003CRuntimeModel_003Ek__BackingField;

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

	public Guid InstanceUid
	{
		get
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			return _003CInstanceUid_003Ek__BackingField;
		}
		set
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			_003CInstanceUid_003Ek__BackingField = value;
		}
	}

	public string ScriptName
	{
		get
		{
			return _003CScriptName_003Ek__BackingField;
		}
		set
		{
			_003CScriptName_003Ek__BackingField = value;
		}
	}

	public string Parameter
	{
		get
		{
			return _003CParameter_003Ek__BackingField;
		}
		set
		{
			_003CParameter_003Ek__BackingField = value;
		}
	}

	public TypeSignatureDto ParameterType
	{
		get
		{
			return _003CParameterType_003Ek__BackingField;
		}
		set
		{
			_003CParameterType_003Ek__BackingField = value;
		}
	}

	public TypeSignatureDto ReturnType
	{
		get
		{
			return _003CReturnType_003Ek__BackingField;
		}
		set
		{
			_003CReturnType_003Ek__BackingField = value;
		}
	}

	public EntityTypeSerializationSettingsDto[] EntityTypeSerializationSettings
	{
		get
		{
			return _003CEntityTypeSerializationSettings_003Ek__BackingField;
		}
		set
		{
			_003CEntityTypeSerializationSettings_003Ek__BackingField = value;
		}
	}

	public UIRuntimeModelDto RuntimeModel
	{
		get
		{
			return _003CRuntimeModel_003Ek__BackingField;
		}
		set
		{
			_003CRuntimeModel_003Ek__BackingField = value;
		}
	}
}
