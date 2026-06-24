// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Managers.IBlobStoreConfigurationService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Runtime.Managers
{
  /// <summary>Сервис для работы с бинарными данными через Remoting</summary>
  public interface IBlobStoreConfigurationService : IConfigurationService
  {
    /// <summary>Сохранить</summary>
    /// <param name="key"></param>
    /// <param name="value"></param>
    void Save(string key, byte[] value);

    /// <summary>Загрузить</summary>
    /// <param name="key"></param>
    byte[] LoadOrNull(string key);

    /// <summary>Удалить</summary>
    /// <param name="key"></param>
    void Remove(string key);
  }
}
