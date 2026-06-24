// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.MoneyMoneyRangeConvertTypeWrapper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component]
  public class MoneyMoneyRangeConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static MoneyMoneyRangeConvertTypeWrapper Ar6wtNbfnlZViEmdFX4D;

    public Type OriginalType => typeof (Money);

    public Type ConvertType => MoneyMoneyRangeConvertTypeWrapper.GVUo3ibfe9rpurF06PTX(__typeref (MoneyRange));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 3;
      Money money;
      MoneyRange moneyRange;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            moneyRange = new MoneyRange();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 4 : 3;
            continue;
          case 3:
            money = (Money) obj;
            num = 2;
            continue;
          case 4:
            moneyRange.From = money;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
            continue;
          default:
            moneyRange.To = money;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 1 : 1;
            continue;
        }
      }
label_5:
      return (object) moneyRange;
    }

    public MoneyMoneyRangeConvertTypeWrapper()
    {
      MoneyMoneyRangeConvertTypeWrapper.xgI61xbfPGwtRUeutR3v();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type GVUo3ibfe9rpurF06PTX([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool dGhnCLbfO6P9c3mJGhPl() => MoneyMoneyRangeConvertTypeWrapper.Ar6wtNbfnlZViEmdFX4D == null;

    internal static MoneyMoneyRangeConvertTypeWrapper uHHMTRbf2lHg5M5EqpsJ() => MoneyMoneyRangeConvertTypeWrapper.Ar6wtNbfnlZViEmdFX4D;

    internal static void xgI61xbfPGwtRUeutR3v() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
