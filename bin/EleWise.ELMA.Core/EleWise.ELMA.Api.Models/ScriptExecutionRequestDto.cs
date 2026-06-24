namespace EleWise.ELMA.Api.Models;

internal sealed class ScriptExecutionRequestDto
{
	private string _003CScriptName_003Ek__BackingField;

	private string _003CModel_003Ek__BackingField;

	private string _003CItem_003Ek__BackingField;

	private ModelInfoDto _003CModelInfo_003Ek__BackingField;

	private SerializedModelDto[] _003CAdditionalModels_003Ek__BackingField;

	private EntityTypeSerializationSettingsDto[] _003CEntityTypeSerializationSettings_003Ek__BackingField;

	private UIRuntimeModelDto _003CRuntimeModel_003Ek__BackingField;

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

	public string Model
	{
		get
		{
			return _003CModel_003Ek__BackingField;
		}
		set
		{
			_003CModel_003Ek__BackingField = value;
		}
	}

	public string Item
	{
		get
		{
			return _003CItem_003Ek__BackingField;
		}
		set
		{
			_003CItem_003Ek__BackingField = value;
		}
	}

	public ModelInfoDto ModelInfo
	{
		get
		{
			return _003CModelInfo_003Ek__BackingField;
		}
		set
		{
			_003CModelInfo_003Ek__BackingField = value;
		}
	}

	public SerializedModelDto[] AdditionalModels
	{
		get
		{
			return _003CAdditionalModels_003Ek__BackingField;
		}
		set
		{
			_003CAdditionalModels_003Ek__BackingField = value;
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
