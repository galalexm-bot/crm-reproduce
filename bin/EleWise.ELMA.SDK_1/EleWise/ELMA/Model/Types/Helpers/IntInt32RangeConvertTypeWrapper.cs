// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Helpers.IntInt32RangeConvertTypeWrapper
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
  public class IntInt32RangeConvertTypeWrapper : IConvertTypeWrapper
  {
    internal static IntInt32RangeConvertTypeWrapper mJVYetbEYA1173CquflP;

    public Type OriginalType => IntInt32RangeConvertTypeWrapper.MsymIvbEsEMXijpMn6ob(__typeref (int));

    public Type ConvertType => IntInt32RangeConvertTypeWrapper.MsymIvbEsEMXijpMn6ob(__typeref (Int32Range));

    public bool RelativeConvertNeeded(Type type) => true;

    public object ConvertWrapper(object obj)
    {
      int num1 = 1;
      Int32Range int32Range;
      int num2;
      while (true)
      {
        switch (num1)
        {
          case 1:
            num2 = IntInt32RangeConvertTypeWrapper.IZph4jbEcbxeCDtXIfdd(obj);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
            continue;
          case 2:
            int32Range.From = new int?(num2);
            num1 = 3;
            continue;
          case 3:
            int32Range.To = new int?(num2);
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 4 : 1;
            continue;
          case 4:
            goto label_2;
          default:
            int32Range = new Int32Range();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 2 : 1;
            continue;
        }
      }
label_2:
      return (object) int32Range;
    }

    public IntInt32RangeConvertTypeWrapper()
    {
      IntInt32RangeConvertTypeWrapper.vKNdcXbEzqsf9oqRYxEQ();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static Type MsymIvbEsEMXijpMn6ob([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static int IZph4jbEcbxeCDtXIfdd([In] object obj0) => Convert.ToInt32(obj0);

    internal static bool LhFn2abELC1HON6BE97I() => IntInt32RangeConvertTypeWrapper.mJVYetbEYA1173CquflP == null;

    internal static IntInt32RangeConvertTypeWrapper MTFAV0bEUW3mIh3UYuKp() => IntInt32RangeConvertTypeWrapper.mJVYetbEYA1173CquflP;

    internal static void vKNdcXbEzqsf9oqRYxEQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
