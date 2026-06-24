// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Services.ITimestampService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Services
{
  /// <summary>Интерфейс сервиса временных штампов.</summary>
  public interface ITimestampService
  {
    /// <summary>Получить временной штамп.</summary>
    /// <returns>Временной штамп</returns>
    long GetTimestamp();

    /// <summary>
    /// Получить временной штамп для времени, указанного как смещение относительно текущего.
    /// </summary>
    /// <param name="timeOffset">Смещение относительно текущего врмемени.</param>
    /// <returns>Временной штамп</returns>
    long GetTimeStampRelativeToNow(TimeSpan timeOffset);
  }
}
