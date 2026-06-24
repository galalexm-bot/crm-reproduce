// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Providers.IUpdatableProviderManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Configuration;

namespace EleWise.ELMA.Runtime.Providers
{
  /// <summary>
  /// При изменении файла конфигурации вызывается метод у всех провайдеров, реализующих интерфейс, для обновления их настроек.
  /// </summary>
  public interface IUpdatableProviderManager
  {
    /// <summary>Обновить настройки при изменении config</summary>
    void UpdateConfiguration(RuntimeConfiguration configuration);
  }
}
