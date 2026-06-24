using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Runtime.Managers;

[PublicApiMember("BlobStoreServicesApi", "SR.M('Сервис управлением BLOB')", "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса мы можем управлять хранилищем бинарных данных:\r\n    /// //записывать, получать и удалять значения\r\n    /// \r\n    /// //запишем сервис в переменную, чтобы с ним легче было работать\r\n    /// var service = PublicAPI.Services.BLOBStore; \r\n    /// \r\n    /// //для записи данных используйте функию Save(key, value),\r\n    /// //где key - это ключ, по которому произойдет запись в базу,\r\n    /// //value - байтовый массив записываемых данных\r\n    /// service.Save(key, value);\r\n    /// \r\n    /// //для загрузки записанного значения используйте функцию LoadOrNull(key)\r\n    /// var myValue = service.LoadOrNull(key);\r\n    /// \r\n    /// //для удаления записанного значения используйте функцию Remove\r\n    /// service.Remove(key); \r\n    /// </code>')")]
[DeveloperApi(DeveloperApiType.Service)]
public interface IBLOBStore
{
	[PublicApiNodeId("BlobStoreServicesApi")]
	void Save(string key, byte[] value);

	[PublicApiNodeId("BlobStoreServicesApi")]
	byte[] LoadOrNull(string key);

	[PublicApiNodeId("BlobStoreServicesApi")]
	void Remove(string key);
}
