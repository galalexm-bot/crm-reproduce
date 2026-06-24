// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.RepeatSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>Настройки повторного запуска в течение дня</summary>
  [Serializable]
  public class RepeatSettings
  {
    /// <summary>Включено ли повторение</summary>
    public bool Enabled;
    /// <summary>
    /// Интервал повтора
    /// Например, повторять каждые 10 мин
    /// </summary>
    [XmlIgnore]
    public TimeSpan RepeatEvery;
    /// <summary>
    /// Повторять до времени
    /// Например, повторять до наступлдения 20:00
    /// </summary>
    [XmlIgnore]
    public TimeSpan RepeatTo;
    internal static RepeatSettings lXiWd0BK4qvdd0CrrEQ5;

    public string RepeatEveryXml
    {
      get => this.RepeatEvery.ToString();
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.RepeatEvery = RepeatSettings.jET3Q8BKATILVZWqmI0j((object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public string RepeatToXml
    {
      get => this.RepeatTo.ToString();
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.RepeatTo = RepeatSettings.jET3Q8BKATILVZWqmI0j((object) value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    public RepeatSettings()
    {
      RepeatSettings.ewn8OLBK7nm67wJFbi5A();
      this.RepeatEvery = RepeatSettings.Kv08S2BKxoFgNcyY2WOq(10.0);
      this.RepeatTo = TimeSpan.FromHours(23.0);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ghQxgCBK6NMhb4GBcKqm() => RepeatSettings.lXiWd0BK4qvdd0CrrEQ5 == null;

    internal static RepeatSettings XNuWihBKH8nAISQeJnlo() => RepeatSettings.lXiWd0BK4qvdd0CrrEQ5;

    internal static TimeSpan jET3Q8BKATILVZWqmI0j([In] object obj0) => TimeSpan.Parse((string) obj0);

    internal static void ewn8OLBK7nm67wJFbi5A() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static TimeSpan Kv08S2BKxoFgNcyY2WOq([In] double obj0) => TimeSpan.FromMinutes(obj0);
  }
}
