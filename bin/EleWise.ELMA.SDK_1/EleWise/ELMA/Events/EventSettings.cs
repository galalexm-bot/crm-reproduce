// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.EventSettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Events
{
  /// <summary>Настройки системы обработки событий</summary>
  public static class EventSettings
  {
    private static readonly ContextVars.Local<bool?> EnabledLocal;
    internal static EventSettings UqsnwJGYqUewK7H1y5th;

    /// <summary>Включено</summary>
    public static bool Enabled
    {
      get
      {
        int num = 3;
        bool? nullable;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            case 2:
              if (nullable.HasValue)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
                continue;
              }
              goto label_3;
            case 3:
              nullable = EventSettings.EnabledLocal.Value;
              num = 2;
              continue;
            default:
              goto label_4;
          }
        }
label_3:
        return true;
label_4:
        return nullable.GetValueOrDefault();
      }
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
              EventSettings.EnabledLocal.Value = new bool?(value);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0 ? 0 : 0;
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

    static EventSettings()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EventSettings.EnabledLocal = new ContextVars.Local<bool?>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          case 2:
            EventSettings.l4nmUsGYT94CfuI0cVD3();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool zHE1WmGYK1mwDQYtYlub() => EventSettings.UqsnwJGYqUewK7H1y5th == null;

    internal static EventSettings oZeTtuGYX1EMp8hxgH1n() => EventSettings.UqsnwJGYqUewK7H1y5th;

    internal static void l4nmUsGYT94CfuI0cVD3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
