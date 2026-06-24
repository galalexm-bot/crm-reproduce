// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.IBLOBStore
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>Интерфейс хранилища бинарных данных</summary>
  /// <example>
  /// <code>
  /// //С помощью данного сервиса мы можем управлять хранилищем бинарных данных:
  /// //записывать, получать и удалять значения
  /// 
  /// //запишем сервис в переменную, чтобы с ним легче было работать
  /// <![CDATA[var service = Locator.GetServiceNotNull<IBLOBStore>();]]>
  /// 
  /// //для записи данных используйте функию Save(key, value),
  /// //где key - это ключ, по которому произойдет запись в базу,
  /// //value - байтовый массив записываемых данных
  /// service.Save(key, value);
  /// 
  /// //для загрузки записанного значения используйте функцию LoadOrNull(key)
  /// var myValue = service.LoadOrNull(key);
  /// 
  /// //для удаления записанного значения используйте функцию Remove
  /// service.Remove(key);
  /// </code>
  /// </example>
  [PublicApiMember("BlobStoreServicesApi", "SR.M('Сервис управлением BLOB')", "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса мы можем управлять хранилищем бинарных данных:\r\n    /// //записывать, получать и удалять значения\r\n    /// \r\n    /// //запишем сервис в переменную, чтобы с ним легче было работать\r\n    /// var service = PublicAPI.Services.BLOBStore; \r\n    /// \r\n    /// //для записи данных используйте функию Save(key, value),\r\n    /// //где key - это ключ, по которому произойдет запись в базу,\r\n    /// //value - байтовый массив записываемых данных\r\n    /// service.Save(key, value);\r\n    /// \r\n    /// //для загрузки записанного значения используйте функцию LoadOrNull(key)\r\n    /// var myValue = service.LoadOrNull(key);\r\n    /// \r\n    /// //для удаления записанного значения используйте функцию Remove\r\n    /// service.Remove(key); \r\n    /// </code>')")]
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IBLOBStore
  {
    /// <summary>Сохранить</summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    [PublicApiNodeId("BlobStoreServicesApi")]
    void Save(string key, byte[] value);

    /// <summary>Загрузить</summary>
    /// <param name="key"></param>
    [PublicApiNodeId("BlobStoreServicesApi")]
    byte[] LoadOrNull(string key);

    /// <summary>Удалить</summary>
    /// <param name="key"></param>
    [PublicApiNodeId("BlobStoreServicesApi")]
    void Remove(string key);
  }
}
