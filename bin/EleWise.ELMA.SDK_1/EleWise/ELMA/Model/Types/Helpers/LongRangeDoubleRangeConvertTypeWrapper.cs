// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.LongRangeDoubleRangeConvertTypeWrapper
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
  [Component]
  public class LongRangeDoubleRangeConvertTypeWrapper : IConvertTypeWrapper
  {
    private static LongRangeDoubleRangeConvertTypeWrapper M8uLNybGsgrRJTPtNBmF;

    public Type OriginalType => LongRangeDoubleRangeConvertTypeWrapper.k8sZSybEFeaMu0JRMUYq(__typeref (Int64Range));

    public Type ConvertType => LongRangeDoubleRangeConvertTypeWrapper.k8sZSybEFeaMu0JRMUYq(__typeref (DoubleRange));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num = 3;
      DoubleRange doubleRange;
      Int64Range int64Range;
      long? nullable1;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            doubleRange = new DoubleRange();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
            continue;
          case 3:
            int64Range = (Int64Range) obj;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 2 : 0;
            continue;
          case 4:
            ref DoubleRange local1 = ref doubleRange;
            nullable1 = int64Range.To;
            double? nullable2 = nullable1.HasValue ? new double?((double) nullable1.GetValueOrDefault()) : new double?();
            local1.To = nullable2;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 1 : 1;
            continue;
          default:
            ref DoubleRange local2 = ref doubleRange;
            nullable1 = int64Range.From;
            double? nullable3 = !nullable1.HasValue ? new double?() : new double?((double) nullable1.GetValueOrDefault());
            local2.From = nullable3;
            num = 4;
            continue;
        }
      }
label_4:
      return (object) doubleRange;
    }

    public LongRangeDoubleRangeConvertTypeWrapper()
    {
      LongRangeDoubleRangeConvertTypeWrapper.bAWYqYbEBdawBm9MaFIh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type k8sZSybEFeaMu0JRMUYq([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool q5STThbGctCiZgliPfnr() => LongRangeDoubleRangeConvertTypeWrapper.M8uLNybGsgrRJTPtNBmF == null;

    internal static LongRangeDoubleRangeConvertTypeWrapper P4RMNgbGzPdfo83OWPPQ() => LongRangeDoubleRangeConvertTypeWrapper.M8uLNybGsgrRJTPtNBmF;

    internal static void bAWYqYbEBdawBm9MaFIh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
