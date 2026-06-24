// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Settings.Events.IGlobalSettingsEventHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Serialization;

namespace EleWise.ELMA.Runtime.Settings.Events
{
  /// <summary>
  /// Обработчик события после изменения глобальной настройки
  /// </summary>
  [ExtensionPoint(ServiceScope.Shell, ComponentType.Server)]
  public interface IGlobalSettingsEventHandler : IEventHandler
  {
    /// <summary>Изменить настройку</summary>
    /// <param name="args"></param>
    void ChangeSetting(EditGlobalSettingsEventArgs args);

    /// <summary>Загрузить настройки по умолчанию</summary>
    void LoadSettings(IStoreValuesObject settings);
  }
}
