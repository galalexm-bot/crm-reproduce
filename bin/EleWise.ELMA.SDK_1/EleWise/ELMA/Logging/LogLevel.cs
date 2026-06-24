// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.LogLevel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

namespace EleWise.ELMA.Logging
{
  /// <summary>Уровень логирования</summary>
  public enum LogLevel
  {
    /// <summary>Полное логирование с подробностями</summary>
    Verbose,
    /// <summary>Трасировка</summary>
    Trace,
    /// <summary>Отладочный уровень логирования</summary>
    Debug,
    /// <summary>Информационный уровень логирования</summary>
    Information,
    /// <summary>Предупреждения</summary>
    Warning,
    /// <summary>Ошибки</summary>
    Error,
    /// <summary>Фатальные ошибки</summary>
    Fatal,
  }
}
