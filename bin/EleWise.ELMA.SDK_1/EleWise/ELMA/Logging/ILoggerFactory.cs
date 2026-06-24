// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.ILoggerFactory
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Logging
{
  /// <summary>Фабрика для создания логгеров</summary>
  public interface ILoggerFactory
  {
    /// <summary>Создать логгер по типу</summary>
    /// <param name="type">Тип CLR</param>
    /// <returns></returns>
    ILogger CreateLogger(Type type);

    /// <summary>Создать логгер по имени</summary>
    /// <param name="name">Имя логгера</param>
    /// <returns></returns>
    ILogger CreateLogger(string name);
  }
}
