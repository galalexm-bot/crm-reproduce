using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;

namespace EleWise.ELMA.Common.Services;

public class BlobStoreConfigurationService : DTOManager, IBlobStoreConfigurationService, IConfigurationService
{
	private BlobStore Store => Locator.GetServiceNotNull<BlobStore>();

	public virtual void Save(string key, byte[] value)
	{
		Store.Save(key, value);
	}

	public virtual byte[] LoadOrNull(string key)
	{
		return Store.LoadOrNull(key);
	}

	public virtual void Remove(string key)
	{
		Store.Remove(key);
	}
}
