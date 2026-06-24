using EleWise.ELMA.Services;

namespace EleWise.ELMA.Messages.Web.Components;

public static class Settings
{
	public static MessagesSettings GetSettings()
	{
		return Locator.GetServiceNotNull<MessagesSettingsModule>().Settings;
	}
}
