// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ComponentModel.ComponentType
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.ComponentModel
{
  /// <summary>
  /// Тип компонента. Определяет режим, в котором может использоваться компонент.
  /// </summary>
  [Flags]
  public enum ComponentType
  {
    /// <summary>Компонент с данным типом регистрируется всегда</summary>
    All = 4295, // 0x000010C7
    /// <summary>
    /// Компонент предназначен для использования в контексте сервера (в случаях запуска в рамках веб-приложения или дизайнера)
    /// </summary>
    Server = 1,
    /// <summary>
    /// Компонент предназначен для использования в контексте сервера, запущенного в рамках веб-приложения
    /// </summary>
    WebServer = 2,
    /// <summary>
    /// Компонент предназначен для использования в контексте веб-приложения
    /// </summary>
    Web = 4,
    /// <summary>
    /// Компонент предназначен для использования в контексте сервера, запущенного в рамках дизайнера (при локальном подключении к конфигурации)
    /// </summary>
    DesignServer = 64, // 0x00000040
    /// <summary>
    /// Компонент предназначен для использования в контексте дизайнера (вне зависимости от типа подключения к серверу)
    /// </summary>
    Design = 128, // 0x00000080
    /// <summary>
    /// Компонент предназначен для использования в контексте тестирования
    /// </summary>
    Test = 4096, // 0x00001000
  }
}
