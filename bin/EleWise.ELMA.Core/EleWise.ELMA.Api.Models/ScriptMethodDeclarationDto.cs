namespace EleWise.ELMA.Api.Models;

public sealed class ScriptMethodDeclarationDto
{
	private string _003CName_003Ek__BackingField;

	private string _003CReturnType_003Ek__BackingField;

	private ScriptMethodParameterDto[] _003CParameters_003Ek__BackingField;

	private string _003CSignature_003Ek__BackingField;

	private string _003CDescription_003Ek__BackingField;

	private string _003CDisplayInfo_003Ek__BackingField;

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

	public string ReturnType
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

	public ScriptMethodParameterDto[] Parameters
	{
		get
		{
			return _003CParameters_003Ek__BackingField;
		}
		set
		{
			_003CParameters_003Ek__BackingField = value;
		}
	}

	public string Signature
	{
		get
		{
			return _003CSignature_003Ek__BackingField;
		}
		set
		{
			_003CSignature_003Ek__BackingField = value;
		}
	}

	public string Description
	{
		get
		{
			return _003CDescription_003Ek__BackingField;
		}
		set
		{
			_003CDescription_003Ek__BackingField = value;
		}
	}

	public string DisplayInfo
	{
		get
		{
			return _003CDisplayInfo_003Ek__BackingField;
		}
		set
		{
			_003CDisplayInfo_003Ek__BackingField = value;
		}
	}
}
