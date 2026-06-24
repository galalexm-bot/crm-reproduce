using EleWise.ELMA.Configuration;

namespace EleWise.ELMA.ExtensionPoints;

public interface IConfigurableProvider
{
	void Configure(ProviderSettingsSection settings, RuntimeConfiguration configuration);
}
