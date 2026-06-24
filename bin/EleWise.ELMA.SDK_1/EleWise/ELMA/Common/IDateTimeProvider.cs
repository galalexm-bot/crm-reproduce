// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Common.IDateTimeProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Common
{
  /// <summary>Интерфейс для получения текущего времени.</summary>
  public interface IDateTimeProvider
  {
    /// <summary>Возвращает текущее локальное время.</summary>
    /// <returns>Текущее время.</returns>
    DateTime Now();

    /// <summary>Возвращает текущее время UTC.</summary>
    /// <returns>Текущее время.</returns>
    DateTime UtcNow();
  }
}
