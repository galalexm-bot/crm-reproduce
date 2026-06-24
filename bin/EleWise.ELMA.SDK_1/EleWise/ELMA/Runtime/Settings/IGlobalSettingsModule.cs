// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Settings.IGlobalSettingsModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System;

namespace EleWise.ELMA.Runtime.Settings
{
  /// <summary>Модуль глобальных настроек системы</summary>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  [ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
  public interface IGlobalSettingsModule
  {
    /// <summary>
    /// Используются для фильтрации настроек для отдельного раздела системы (по умолчанию Common)
    /// </summary>
    string ModuleNamespace { get; }

    /// <summary>Идентификатор модуля</summary>
    Guid ModuleGuid { get; }

    /// <summary>Название модуля</summary>
    string ModuleName { get; }

    /// <summary>Объект с текущими настройками</summary>
    object Settings { get; set; }

    /// <summary>Сохранить настройки</summary>
    void SaveSettings();

    /// <summary>Очисть кэш (для перезагрузки настроек)</summary>
    void ClearCache();
  }
}
