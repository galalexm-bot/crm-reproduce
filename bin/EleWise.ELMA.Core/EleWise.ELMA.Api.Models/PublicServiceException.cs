namespace EleWise.ELMA.Api.Models;

public class PublicServiceException
{
	private int _003CStatusCode_003Ek__BackingField;

	private string _003CMessage_003Ek__BackingField;

	private PublicServiceException _003CInnerException_003Ek__BackingField;

	public int StatusCode
	{
		get
		{
			return _003CStatusCode_003Ek__BackingField;
		}
		set
		{
			_003CStatusCode_003Ek__BackingField = value;
		}
	}

	public string Message
	{
		get
		{
			return _003CMessage_003Ek__BackingField;
		}
		set
		{
			_003CMessage_003Ek__BackingField = value;
		}
	}

	public PublicServiceException InnerException
	{
		get
		{
			return _003CInnerException_003Ek__BackingField;
		}
		set
		{
			_003CInnerException_003Ek__BackingField = value;
		}
	}
}
