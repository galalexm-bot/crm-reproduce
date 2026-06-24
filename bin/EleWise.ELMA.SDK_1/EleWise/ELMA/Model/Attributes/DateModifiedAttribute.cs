// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Attributes.DateModifiedAttribute
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Model.Attributes
{
  /// <summary>Дата создания</summary>
  public class DateModifiedAttribute : Attribute
  {
    private DateTime _value;
    private static DateModifiedAttribute Ea1YbOouCLgbEPGcyRHj;

    /// <summary>Конструктор</summary>
    /// <param name="ticks"></param>
    public DateModifiedAttribute(long ticks)
    {
      DateModifiedAttribute.sDLvIcouZdi67U60rF2T();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this._value = new DateTime(ticks);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>Значение аттрибута</summary>
    public DateTime Value
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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
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

    internal static void sDLvIcouZdi67U60rF2T() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool KjWgtFouvwZqkAy2cTeZ() => DateModifiedAttribute.Ea1YbOouCLgbEPGcyRHj == null;

    internal static DateModifiedAttribute QGeusOou8kbHNw5ENW26() => DateModifiedAttribute.Ea1YbOouCLgbEPGcyRHj;
  }
}
