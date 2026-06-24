// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.ShowDefaultMethodsAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>
  /// Показывать внутренние стандартные методы, а также методы расширения
  /// </summary>
  public class ShowDefaultMethodsAttribute : Attribute
  {
    private static ShowDefaultMethodsAttribute YiALDkoCfeZwNa6w5wID;

    public bool ShowDefaultMethods
    {
      get => this.\u003CShowDefaultMethods\u003Ek__BackingField;
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
              this.\u003CShowDefaultMethods\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 0 : 0;
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

    public ShowDefaultMethodsAttribute(bool show)
    {
      ShowDefaultMethodsAttribute.lfT2c7oCvBgE2LH6yOMv();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.ShowDefaultMethods = show;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    internal static bool rq0Wu8oCQC2AErJVfrpx() => ShowDefaultMethodsAttribute.YiALDkoCfeZwNa6w5wID == null;

    internal static ShowDefaultMethodsAttribute pwpAUPoCC59gdJou3lPs() => ShowDefaultMethodsAttribute.YiALDkoCfeZwNa6w5wID;

    internal static void lfT2c7oCvBgE2LH6yOMv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
