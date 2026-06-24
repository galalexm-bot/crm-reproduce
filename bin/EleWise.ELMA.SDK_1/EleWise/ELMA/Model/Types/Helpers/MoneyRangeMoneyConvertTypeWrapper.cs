// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.MoneyRangeMoneyConvertTypeWrapper
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
  public class MoneyRangeMoneyConvertTypeWrapper : IConvertTypeWrapper
  {
    private static MoneyRangeMoneyConvertTypeWrapper xqcCUwbfIuVoOFT67SoI;

    public Type OriginalType => typeof (MoneyRange);

    public Type ConvertType => MoneyRangeMoneyConvertTypeWrapper.qJTJ2KbficPCVI81dnob(__typeref (Money));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 1;
      MoneyRange moneyRange;
      while (true)
      {
        switch (num)
        {
          case 1:
            moneyRange = (MoneyRange) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return (object) moneyRange.From;
    }

    public MoneyRangeMoneyConvertTypeWrapper()
    {
      MoneyRangeMoneyConvertTypeWrapper.IKf9XNbfRr9YYT45ZdxE();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type qJTJ2KbficPCVI81dnob([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool ANCWa7bfV3S63ofNF7CQ() => MoneyRangeMoneyConvertTypeWrapper.xqcCUwbfIuVoOFT67SoI == null;

    internal static MoneyRangeMoneyConvertTypeWrapper kQ3PV5bfSNZBrhIFphXx() => MoneyRangeMoneyConvertTypeWrapper.xqcCUwbfIuVoOFT67SoI;

    internal static void IKf9XNbfRr9YYT45ZdxE() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
