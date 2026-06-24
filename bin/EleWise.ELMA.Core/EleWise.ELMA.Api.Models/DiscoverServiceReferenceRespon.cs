using EleWise.ELMA.Model;

namespace EleWise.ELMA.Api.Models;

internal sealed class DiscoverServiceReferenceResponseDto : Reactive
{
	private ScriptWebReferenceDto _003CWebReference_003Ek__BackingField;

	private ServiceReferenceInfoDto _003CServiceReferenceInfo_003Ek__BackingField;

	private string _003CServiceString_003Ek__BackingField;

	private string _003CCodeFilePath_003Ek__BackingField;

	private bool _003CNeedAuthenticateUser_003Ek__BackingField;

	private string _003CAuthenticationType_003Ek__BackingField;

	private string _003CErrorMessage_003Ek__BackingField;

	public ScriptWebReferenceDto WebReference
	{
		get
		{
			return _003CWebReference_003Ek__BackingField;
		}
		set
		{
			_003CWebReference_003Ek__BackingField = value;
		}
	}

	public ServiceReferenceInfoDto ServiceReferenceInfo
	{
		get
		{
			return _003CServiceReferenceInfo_003Ek__BackingField;
		}
		set
		{
			_003CServiceReferenceInfo_003Ek__BackingField = value;
		}
	}

	public string ServiceString
	{
		get
		{
			return _003CServiceString_003Ek__BackingField;
		}
		set
		{
			_003CServiceString_003Ek__BackingField = value;
		}
	}

	public string CodeFilePath
	{
		get
		{
			return _003CCodeFilePath_003Ek__BackingField;
		}
		set
		{
			_003CCodeFilePath_003Ek__BackingField = value;
		}
	}

	public bool NeedAuthenticateUser
	{
		get
		{
			return _003CNeedAuthenticateUser_003Ek__BackingField;
		}
		set
		{
			_003CNeedAuthenticateUser_003Ek__BackingField = value;
		}
	}

	public string AuthenticationType
	{
		get
		{
			return _003CAuthenticationType_003Ek__BackingField;
		}
		set
		{
			_003CAuthenticationType_003Ek__BackingField = value;
		}
	}

	public string ErrorMessage
	{
		get
		{
			return _003CErrorMessage_003Ek__BackingField;
		}
		set
		{
			_003CErrorMessage_003Ek__BackingField = value;
		}
	}
}
