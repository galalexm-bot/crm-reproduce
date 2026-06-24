namespace EleWise.ELMA.Api.Models;

internal sealed class ScriptExecutionResponseDto
{
	private object _003CModel_003Ek__BackingField;

	private object _003CItem_003Ek__BackingField;

	private ClientComponentModelDto[] _003CAdditionalComponentModels_003Ek__BackingField;

	private string _003CExceptionMessage_003Ek__BackingField;

	private string _003CExceptionStackTrace_003Ek__BackingField;

	private FormViewBuilderInfoDto _003CFormViewBuilderInfo_003Ek__BackingField;

	private string _003CRedirectUrl_003Ek__BackingField;

	private object _003CReturnValue_003Ek__BackingField;

	public object Model
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

	public object Item
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

	public FormViewBuilderInfoDto FormViewBuilderInfo
	{
		get
		{
			return _003CFormViewBuilderInfo_003Ek__BackingField;
		}
		set
		{
			_003CFormViewBuilderInfo_003Ek__BackingField = value;
		}
	}

	public string RedirectUrl
	{
		get
		{
			return _003CRedirectUrl_003Ek__BackingField;
		}
		set
		{
			_003CRedirectUrl_003Ek__BackingField = value;
		}
	}

	public object ReturnValue
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
}
