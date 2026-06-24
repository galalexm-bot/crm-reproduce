// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Cache.Attributes.CacheAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Cache.Attributes
{
  /// <summary>
  /// Кеширование возвращаемого значения метода по значениям параметров в глобальном кеше
  /// </summary>
  public class CacheAttribute : Attribute
  {
    private readonly string duration;
    private TimeSpan? durationTime;
    internal static CacheAttribute bMGOpwfXuY6ONyjXVUZU;

    /// <summary>
    /// Кеширование возвращаемого значения метода по значениям параметров в глобальном кеше
    /// </summary>
    public CacheAttribute()
    {
      CacheAttribute.X8OBX2fXSwigRlqWy0jS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Кеширование возвращаемого значения метода по значениям параметров в глобальном кеше
    /// </summary>
    /// <param name="duration">Строка для преобразования в TimeSpan. Формат [ws][-][d.]hh:mm:ss[.ff][ws]. Пример "00:00:15" - 15 секунд.</param>
    public CacheAttribute(string duration)
    {
      CacheAttribute.X8OBX2fXSwigRlqWy0jS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 6;
      TimeSpan result;
      while (true)
      {
        switch (num)
        {
          case 1:
            CacheAttribute.lxASlnfXqTdcl5dFghrs(CacheAttribute.nsBn4QfXRH0Ne6Lu4O7A(), (object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(901793403 ^ 902103933), (object) duration));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0 ? 0 : 0;
            continue;
          case 2:
            if (TimeSpan.TryParse(duration, out result))
            {
              num = 4;
              continue;
            }
            goto case 1;
          case 3:
            this.durationTime = new TimeSpan?();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 7 : 6;
            continue;
          case 5:
            goto label_6;
          case 6:
            this.duration = duration;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0 ? 0 : 3;
            continue;
          case 7:
            if (!CacheAttribute.Kr8G6ifXi8eSdJjhsWP5((object) duration))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 2 : 1;
              continue;
            }
            goto label_2;
          default:
            this.durationTime = new TimeSpan?(result);
            num = 5;
            continue;
        }
      }
label_6:
      return;
label_2:;
    }

    /// <summary>
    /// Строка для преобразования в TimeSpan. Формат [ws][-][d.]hh:mm:ss[.ff][ws]. Пример "00:00:15" - 15 секунд.
    /// </summary>
    public string Duration => this.duration;

    /// <summary>Время, на которое нужно закэшировать результат</summary>
    public TimeSpan? DurationTime => this.durationTime;

    internal static void X8OBX2fXSwigRlqWy0jS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool hIxIW5fXI0xvBKWGLMaW() => CacheAttribute.bMGOpwfXuY6ONyjXVUZU == null;

    internal static CacheAttribute AojofVfXVtCZ72UQlbtT() => CacheAttribute.bMGOpwfXuY6ONyjXVUZU;

    internal static bool Kr8G6ifXi8eSdJjhsWP5([In] object obj0) => string.IsNullOrWhiteSpace((string) obj0);

    internal static object nsBn4QfXRH0Ne6Lu4O7A() => (object) Logger.Log;

    internal static void lxASlnfXqTdcl5dFghrs([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);
  }
}
