namespace EleWise.ELMA.Api.Models;

public class NotificationInfoDto
{
	private string _003CMessage_003Ek__BackingField;

	private int _003CType_003Ek__BackingField;

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

	public int Type
	{
		get
		{
			return _003CType_003Ek__BackingField;
		}
		set
		{
			_003CType_003Ek__BackingField = value;
		}
	}
}
