using EleWise.ELMA.Configuration;

namespace EleWise.ELMA.Runtime.Providers;

public interface IUpdatableProviderManager
{
	void UpdateConfiguration(RuntimeConfiguration configuration);
}
