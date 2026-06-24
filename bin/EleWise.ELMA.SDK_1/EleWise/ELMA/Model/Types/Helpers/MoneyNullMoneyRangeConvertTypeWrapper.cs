// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.MoneyNullMoneyRangeConvertTypeWrapper
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
  public class MoneyNullMoneyRangeConvertTypeWrapper : IConvertTypeWrapper
  {
    private static MoneyNullMoneyRangeConvertTypeWrapper Lhc1T9bf12qfcn71vc1U;

    public Type OriginalType => typeof (Money?);

    public Type ConvertType => MoneyNullMoneyRangeConvertTypeWrapper.CneHIJbfpCq6bbeGjlNo(__typeref (MoneyRange));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 4;
      MoneyRange moneyRange;
      while (true)
      {
        Money money1;
        Money? nullable;
        Money money2;
        Money money3;
        switch (num)
        {
          case 1:
            moneyRange = new MoneyRange();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          case 3:
            if (!nullable.HasValue)
            {
              num = 5;
              continue;
            }
            money3 = nullable.Value;
            break;
          case 4:
            nullable = (Money?) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 3 : 2;
            continue;
          case 5:
            money2 = new Money();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 7 : 0;
            continue;
          case 6:
            moneyRange.To = money1;
            num = 2;
            continue;
          case 7:
            money3 = money2;
            break;
          default:
            moneyRange.From = money1;
            num = 6;
            continue;
        }
        money1 = money3;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
      }
label_2:
      return (object) moneyRange;
    }

    public MoneyNullMoneyRangeConvertTypeWrapper()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type CneHIJbfpCq6bbeGjlNo([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool SLUSvJbfNyyCQYH2nBrj() => MoneyNullMoneyRangeConvertTypeWrapper.Lhc1T9bf12qfcn71vc1U == null;

    internal static MoneyNullMoneyRangeConvertTypeWrapper NAkJvPbf3OYPQwOV8rcV() => MoneyNullMoneyRangeConvertTypeWrapper.Lhc1T9bf12qfcn71vc1U;
  }
}
