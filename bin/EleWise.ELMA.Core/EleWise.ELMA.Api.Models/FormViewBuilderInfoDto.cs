namespace EleWise.ELMA.Api.Models;

public class FormViewBuilderInfoDto
{
	private PropertyViewInfoDto[] _003CProperties_003Ek__BackingField;

	private NotificationInfoDto[] _003CNotifications_003Ek__BackingField;

	private bool _003CClosePopup_003Ek__BackingField;

	public PropertyViewInfoDto[] Properties
	{
		get
		{
			return _003CProperties_003Ek__BackingField;
		}
		set
		{
			_003CProperties_003Ek__BackingField = value;
		}
	}

	public NotificationInfoDto[] Notifications
	{
		get
		{
			return _003CNotifications_003Ek__BackingField;
		}
		set
		{
			_003CNotifications_003Ek__BackingField = value;
		}
	}

	public bool ClosePopup
	{
		get
		{
			return _003CClosePopup_003Ek__BackingField;
		}
		set
		{
			_003CClosePopup_003Ek__BackingField = value;
		}
	}
}
