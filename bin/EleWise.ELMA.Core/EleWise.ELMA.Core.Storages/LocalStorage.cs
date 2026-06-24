using Bridge.Html5;
using EleWise.ELMA.Core.ComponentModel;
using EleWise.ELMA.Core.Serialization;

namespace EleWise.ELMA.Core.Storages;

[Service]
public class LocalStorage : ILocalStorage
{
	private readonly Storage _storage;

	public LocalStorage()
	{
		_storage = Window.LocalStorage;
	}

	public void SetItem(string key, object value)
	{
		_storage.SetItem(key, (object)SerializationHelper.SerializeObjectByJson(value));
	}

	public T GetItem<T>(string key)
	{
		if (!(_storage.GetItem(key) is string obj))
		{
			return default(T);
		}
		return SerializationHelper.DeserializeObjectFromJson<T>(obj);
	}
}
