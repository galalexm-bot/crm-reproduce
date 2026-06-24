// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.MoneyRangeMoneyNullConvertTypeWrapper
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
  public class MoneyRangeMoneyNullConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static MoneyRangeMoneyNullConvertTypeWrapper W3LfkJbfqIJlRZBPqaZu;

    public Type OriginalType => MoneyRangeMoneyNullConvertTypeWrapper.kAJ9xRbfTfH8MfnHtGvh(__typeref (MoneyRange));

    public Type ConvertType => MoneyRangeMoneyNullConvertTypeWrapper.kAJ9xRbfTfH8MfnHtGvh(__typeref (Money?));

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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return (object) moneyRange.From;
    }

    public MoneyRangeMoneyNullConvertTypeWrapper()
    {
      MoneyRangeMoneyNullConvertTypeWrapper.pUafitbfk6lvPI1ESS1X();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type kAJ9xRbfTfH8MfnHtGvh([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool vSCc0sbfKBG3HVePbkXF() => MoneyRangeMoneyNullConvertTypeWrapper.W3LfkJbfqIJlRZBPqaZu == null;

    internal static MoneyRangeMoneyNullConvertTypeWrapper BmMllgbfX8jILaAtUt0R() => MoneyRangeMoneyNullConvertTypeWrapper.W3LfkJbfqIJlRZBPqaZu;

    internal static void pUafitbfk6lvPI1ESS1X() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
