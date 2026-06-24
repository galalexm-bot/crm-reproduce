namespace EleWise.ELMA.Api.Models;

internal sealed class ActionExecutionResponseDto
{
	private object _003CResult_003Ek__BackingField;

	private ClientComponentModelDto[] _003CAdditionalComponentModels_003Ek__BackingField;

	private string _003CExceptionMessage_003Ek__BackingField;

	private string _003CExceptionStackTrace_003Ek__BackingField;

	public object Result
	{
		get
		{
			return _003CResult_003Ek__BackingField;
		}
		set
		{
			_003CResult_003Ek__BackingField = value;
		}
	}

	public ClientComponentModelDto[] AdditionalComponentModels
	{
		get
		{
			return _003CAdditionalComponentModels_003Ek__BackingField;
		}
		set
		{
			_003CAdditionalComponentModels_003Ek__BackingField = value;
		}
	}

	public string ExceptionMessage
	{
		get
		{
			return _003CExceptionMessage_003Ek__BackingField;
		}
		set
		{
			_003CExceptionMessage_003Ek__BackingField = value;
		}
	}

	public string ExceptionStackTrace
	{
		get
		{
			return _003CExceptionStackTrace_003Ek__BackingField;
		}
		set
		{
			_003CExceptionStackTrace_003Ek__BackingField = value;
		}
	}
}
