// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Extensions.DateTimeUtils
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Runtime.Extensions
{
  /// <summary>
  /// Хэлперы для работы с типом <see cref="T:System.DateTime" />
  /// </summary>
  public static class DateTimeUtils
  {
    internal static DateTimeUtils fIlBZ2WvlXR88bHBtH5P;

    /// <summary>
    /// Получить <see cref="T:System.DateTime" /> без миллисекунд
    /// </summary>
    /// <param name="dateTime">Время</param>
    /// <returns><see cref="T:System.DateTime" /> с обнуленным значением миллисекунд</returns>
    public static DateTime GetDateTimeWithoutMilliseconds(this DateTime dateTime) => dateTime.AddTicks(-(dateTime.Ticks % 10000000L));

    internal static bool WsodErWvrMDLKTFdNiBK() => DateTimeUtils.fIlBZ2WvlXR88bHBtH5P == null;

    internal static DateTimeUtils WinAP2WvgRi4Iu9Lxxnk() => DateTimeUtils.fIlBZ2WvlXR88bHBtH5P;
  }
}
