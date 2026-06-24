namespace EleWise.ELMA.Api.Models;

public sealed class GenerateMethodCodeRequestDto
{
	private string _003CSourceCode_003Ek__BackingField;

	private string _003CClassName_003Ek__BackingField;

	private string _003CMethodName_003Ek__BackingField;

	private string _003CReturnType_003Ek__BackingField;

	private string _003CReturnValue_003Ek__BackingField;

	private ScriptMethodParameterDto[] _003CParameters_003Ek__BackingField;

	private string _003CDescription_003Ek__BackingField;

	public string SourceCode
	{
		get
		{
			return _003CSourceCode_003Ek__BackingField;
		}
		set
		{
			_003CSourceCode_003Ek__BackingField = value;
		}
	}

	public string ClassName
	{
		get
		{
			return _003CClassName_003Ek__BackingField;
		}
		set
		{
			_003CClassName_003Ek__BackingField = value;
		}
	}

	public string MethodName
	{
		get
		{
			return _003CMethodName_003Ek__BackingField;
		}
		set
		{
			_003CMethodName_003Ek__BackingField = value;
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

	public string ReturnValue
	{
		get
		{
			return _003CReturnValue_003Ek__BackingField;
		}
		set
		{
			_003CReturnValue_003Ek__BackingField = value;
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
}
