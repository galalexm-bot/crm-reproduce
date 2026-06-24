// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Extensions.DayOfWeekExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Extensions
{
  /// <summary>Расширение DayOfWeek</summary>
  public static class DayOfWeekExtensions
  {
    internal static DayOfWeekExtensions h45kKKGauyeD8dR9mvSD;

    /// <summary>
    /// Получить соответствие дня недели свойству WorkTimeInterval производственного календаря.
    /// Возвращает 7 в случае DayOfWeek.Sunday
    /// </summary>
    /// <param name="dayOfWeek">День недели</param>
    /// <returns>Индекс</returns>
    public static int GetWorkTimeIntervalDayOfWeek(this DayOfWeek dayOfWeek) => DayOfWeekExtensions.aiv5YZGaSIn7B7vT35yc((int) dayOfWeek);

    /// <summary>
    /// Получить соответствие дня недели свойству WorkTimeInterval производственного календаря.
    /// Возвращает 7 в случае 0
    /// </summary>
    /// <param name="dayOfWeek">День недели</param>
    /// <returns>Индекс</returns>
    public static int GetWorkTimeIntervalDayOfWeek(this int dayOfWeek)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (dayOfWeek != 0)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return dayOfWeek;
label_3:
      return 7;
    }

    /// <summary>
    /// Преобразовать день недели в числовое значение в диапазоне [0..6]
    /// </summary>
    /// <param name="current">День недели</param>
    /// <param name="startDayOfWeek">День начала недели</param>
    /// <returns>День недели в диапазоне от 0 до 6</returns>
    public static int GetDayOfWeekNumber(this DayOfWeek current, DayOfWeek startDayOfWeek) => (current + 7 - startDayOfWeek) % 7;

    internal static int aiv5YZGaSIn7B7vT35yc(int dayOfWeek) => dayOfWeek.GetWorkTimeIntervalDayOfWeek();

    internal static bool cyfNlJGaIpc7KFxQNQy2() => DayOfWeekExtensions.h45kKKGauyeD8dR9mvSD == null;

    internal static DayOfWeekExtensions aclf2pGaVDJQDu13QAh9() => DayOfWeekExtensions.h45kKKGauyeD8dR9mvSD;
  }
}
