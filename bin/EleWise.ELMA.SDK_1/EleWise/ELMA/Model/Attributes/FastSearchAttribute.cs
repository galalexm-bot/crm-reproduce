// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.FastSearchAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Настройка участия в быстром поиске</summary>
  public class FastSearchAttribute : Attribute
  {
    private bool _value;
    private static FastSearchAttribute MTTxOGoIudQpOxVhykAf;

    public FastSearchAttribute(bool value)
    {
      FastSearchAttribute.tKepHFoISgTxHtUqJCVZ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._value = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Участвует в быстром поиске</summary>
    public bool Value
    {
      get => this._value;
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
              this._value = value;
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

    internal static void tKepHFoISgTxHtUqJCVZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool OANCm7oII0Qd4F7RsJNm() => FastSearchAttribute.MTTxOGoIudQpOxVhykAf == null;

    internal static FastSearchAttribute HCggiaoIVe72gUFjWIK6() => FastSearchAttribute.MTTxOGoIudQpOxVhykAf;
  }
}
