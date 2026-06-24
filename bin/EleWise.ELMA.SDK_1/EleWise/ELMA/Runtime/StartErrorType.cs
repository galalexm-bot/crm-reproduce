// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.StartErrorType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Runtime
{
  /// <summary>Тип ошибки запуска</summary>
  public enum StartErrorType
  {
    /// <summary>Неизвестная фатальная ошибка</summary>
    Fatal = 0,
    /// <summary>Попытка запуска более старой версии</summary>
    OlderVersion = 1,
    /// <summary>Есть другие активные соединения с БД</summary>
    OtherConnections = 2,
    /// <summary>Последнее обновление БД завершилось неудачно</summary>
    LastUpdateFault = 3,
    /// <summary>
    /// Требуется исправить сценарии объектов и типов документов в конфигурации
    /// </summary>
    ConfigurationScriptsRecompileRequired = 10, // 0x0000000A
  }
}
