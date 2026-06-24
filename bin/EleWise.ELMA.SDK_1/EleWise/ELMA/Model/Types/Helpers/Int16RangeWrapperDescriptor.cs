// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.Int16RangeWrapperDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Ranges;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types.Helpers
{
  [Component(Order = 1000)]
  public class Int16RangeWrapperDescriptor : ITypeWrapperDescriptor
  {
    private static Int16RangeWrapperDescriptor RfTXPubEECh7PTFBSSwu;

    public Type OriginalType => Int16RangeWrapperDescriptor.y0uU5NbECRax1hRKKCTH(__typeref (Int16Range));

    public Type WrapperType => Int16RangeWrapperDescriptor.y0uU5NbECRax1hRKKCTH(__typeref (Int16RangeWrapper));

    public object CreateWrapper(object obj) => (object) new Int16RangeWrapper((Int16Range) obj);

    public object GetObject(object wrapper)
    {
      int num = 2;
      Int16Range int16Range;
      while (true)
      {
        Int16RangeWrapper int16RangeWrapper;
        switch (num)
        {
          case 1:
            if (int16RangeWrapper == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 6 : 6;
              continue;
            }
            break;
          case 2:
            int16RangeWrapper = wrapper as Int16RangeWrapper;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0 ? 0 : 1;
            continue;
          case 3:
            int16Range.To = Int16RangeWrapperDescriptor.ESCDfobE8w4xZyZGxiEY((object) int16RangeWrapper) ? new short?(Int16RangeWrapperDescriptor.rjL7HMbEZ1OVaaSHy20b((object) int16RangeWrapper)) : new short?();
            num = 4;
            continue;
          case 4:
            goto label_4;
          case 5:
            goto label_8;
          case 6:
            int16Range = new Int16Range();
            num = 5;
            continue;
          case 7:
            int16Range.From = Int16RangeWrapperDescriptor.mjf3pnbEvd0hG7FrQ6AQ((object) int16RangeWrapper) ? new short?(int16RangeWrapper.From) : new short?();
            num = 3;
            continue;
        }
        int16Range = new Int16Range();
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 5 : 7;
      }
label_4:
      return (object) int16Range;
label_8:
      return (object) int16Range;
    }

    public Type[] GenericArgumentsTypes => (Type[]) null;

    public bool TestType(Type type) => false;

    public Int16RangeWrapperDescriptor()
    {
      Int16RangeWrapperDescriptor.SXprYebEuttXdtrmDams();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type y0uU5NbECRax1hRKKCTH([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool o3FymQbEf9NOZ31VLYGe() => Int16RangeWrapperDescriptor.RfTXPubEECh7PTFBSSwu == null;

    internal static Int16RangeWrapperDescriptor Dk6GjLbEQ1HxWOTud1Ir() => Int16RangeWrapperDescriptor.RfTXPubEECh7PTFBSSwu;

    internal static bool mjf3pnbEvd0hG7FrQ6AQ([In] object obj0) => ((Int16RangeWrapper) obj0).HasFromValue;

    internal static bool ESCDfobE8w4xZyZGxiEY([In] object obj0) => ((Int16RangeWrapper) obj0).HasToValue;

    internal static short rjL7HMbEZ1OVaaSHy20b([In] object obj0) => ((Int16RangeWrapper) obj0).To;

    internal static void SXprYebEuttXdtrmDams() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
