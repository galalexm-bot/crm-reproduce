using EleWise.ELMA.Configuration;

namespace EleWise.ELMA.Orleans.Configuration;

public class ReminderServiceSettingsSection : ProviderSettingsSection
{
	protected override void InitializeAutoInitilize()
	{
		base.AutoInitialize = false;
	}
}
