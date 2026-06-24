using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Runtime.Managers;

public interface IBlobStoreConfigurationService : IConfigurationService
{
	void Save(string key, byte[] value);

	byte[] LoadOrNull(string key);

	void Remove(string key);
}
