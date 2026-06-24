using EleWise.ELMA.Core.ComponentModel;

namespace EleWise.ELMA.Core.Storages;

[ServiceContract]
public interface ILocalStorage
{
	void SetItem(string key, object value);

	T GetItem<T>(string key);
}
