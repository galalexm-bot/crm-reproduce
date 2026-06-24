// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.IDiagnosticsEventProcessor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.Diagnostics
{
  /// <summary>Точка расширения для обработки событий диагностики</summary>
  [ExtensionPoint(ComponentType.Server)]
  public interface IDiagnosticsEventProcessor
  {
    /// <summary>Уникальный идентификатор обработчика</summary>
    Guid Uid { get; }

    /// <summary>Название обработчика</summary>
    string Name { get; }

    /// <summary>Предупреждение о деградации производительности</summary>
    string PerfomanceDegradationMessage { get; }

    /// <summary>Обработать событие</summary>
    /// <param name="e">Событие</param>
    void Process(DiagnosticsEvent e);

    /// <summary>Обновить настройки</summary>
    /// <param name="settings">Настройки обработчика</param>
    /// <param name="diagnosticsEnable">Включена ли диагностика</param>
    void RefreshSettings(EventProcessorsInfo settings, bool diagnosticsEnable);

    /// <summary>Получить настройки по умолчанию</summary>
    /// <returns></returns>
    object GetDefaultSettings();
  }
}
