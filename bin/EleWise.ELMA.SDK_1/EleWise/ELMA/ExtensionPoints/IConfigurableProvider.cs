// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IConfigurableProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Configuration;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Интерфейс конфигурируемого провайдера приложения</summary>
  public interface IConfigurableProvider
  {
    /// <summary>
    /// Сконфигурировать провайдер (вызывается после загрузки конфиграции)
    /// </summary>
    /// <param name="settings">Секция настроек провайдера</param>
    /// <param name="configuration">Полная конфигурация приложения</param>
    void Configure(ProviderSettingsSection settings, RuntimeConfiguration configuration);
  }
}
