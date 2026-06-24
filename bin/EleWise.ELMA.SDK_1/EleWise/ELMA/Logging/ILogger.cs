// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.ILogger
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Logging
{
  /// <summary>Интерфейс для логгера</summary>
  public interface ILogger
  {
    /// <summary>Определить, включено ли логирование</summary>
    /// <param name="level"></param>
    /// <returns></returns>
    bool IsEnabled(LogLevel level);

    /// <summary>Логировать сообщение</summary>
    /// <param name="level">Уровень логирования</param>
    /// <param name="exception">Исключение</param>
    /// <param name="format">Строка с форматом</param>
    /// <param name="args">Аргументы форматирования строки</param>
    void Log(LogLevel level, Exception exception, string format, params object[] args);

    /// <summary>Изменение конфигурации логирования</summary>
    event EventHandler ConfigurationChanged;
  }
}
