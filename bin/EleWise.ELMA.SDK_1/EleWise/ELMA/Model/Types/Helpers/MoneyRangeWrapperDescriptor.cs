// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.MoneyRangeWrapperDescriptor
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
  [Component(Order = 1000)]
  public class MoneyRangeWrapperDescriptor : ITypeWrapperDescriptor
  {
    internal static MoneyRangeWrapperDescriptor X0NgimbfQCnOInZ29ewe;

    public Type OriginalType => MoneyRangeWrapperDescriptor.vLApCxbf8UirKOXPJptF(__typeref (MoneyRange));

    public Type WrapperType => MoneyRangeWrapperDescriptor.vLApCxbf8UirKOXPJptF(__typeref (MoneyRangeWrapper));

    public object CreateWrapper(object obj) => (object) new MoneyRangeWrapper((MoneyRange) obj);

    public object GetObject(object wrapper)
    {
      int num1 = 4;
      MoneyRange moneyRange;
      while (true)
      {
        int num2 = num1;
        MoneyRangeWrapper moneyRangeWrapper;
        while (true)
        {
          switch (num2)
          {
            case 1:
              moneyRange.To = MoneyRangeWrapperDescriptor.DrhEl5bfubITNU9OwjMs((object) moneyRangeWrapper.To);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
              continue;
            case 2:
              goto label_11;
            case 3:
              if (moneyRangeWrapper == null)
              {
                moneyRange = new MoneyRange();
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 2;
                continue;
              }
              goto label_4;
            case 4:
              moneyRangeWrapper = wrapper as MoneyRangeWrapper;
              num2 = 3;
              continue;
            case 5:
              moneyRange = new MoneyRange();
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 3 : 6;
              continue;
            case 6:
              moneyRange.From = MoneyRangeWrapperDescriptor.DrhEl5bfubITNU9OwjMs(MoneyRangeWrapperDescriptor.H99xZIbfZqvtvkcEqCCL((object) moneyRangeWrapper));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_4:
        num1 = 5;
      }
label_5:
      return (object) moneyRange;
label_11:
      return (object) moneyRange;
    }

    public Type[] GenericArgumentsTypes => (Type[]) null;

    public bool TestType(Type type) => false;

    public MoneyRangeWrapperDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type vLApCxbf8UirKOXPJptF([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool a57dtbbfCiWO0TCU3Lr2() => MoneyRangeWrapperDescriptor.X0NgimbfQCnOInZ29ewe == null;

    internal static MoneyRangeWrapperDescriptor eaoeBqbfvYBBlqtIueV2() => MoneyRangeWrapperDescriptor.X0NgimbfQCnOInZ29ewe;

    internal static object H99xZIbfZqvtvkcEqCCL([In] object obj0) => (object) ((MoneyRangeWrapper) obj0).From;

    internal static Money DrhEl5bfubITNU9OwjMs([In] object obj0) => ((MoneyWrapper) obj0).Value;
  }
}
