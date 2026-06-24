// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.ExpressionFingerprintChain
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Microsoft.Web.Mvc.ExpressionUtil
{
  internal sealed class ExpressionFingerprintChain : IEquatable<ExpressionFingerprintChain>
  {
    public readonly List<ExpressionFingerprint> Elements;
    internal static ExpressionFingerprintChain Nc8msPWwRFCTBp84VlC;

    public bool Equals(ExpressionFingerprintChain other)
    {
      int num1 = 6;
      while (true)
      {
        int num2 = num1;
        int index;
        while (true)
        {
          switch (num2)
          {
            case 2:
              goto label_11;
            case 3:
            case 5:
              goto label_12;
            case 4:
              if (ExpressionFingerprintChain.tk9FZ5WACLxs1PqwaE4((object) this.Elements[index], (object) other.Elements[index]))
              {
                num2 = 8;
                continue;
              }
              goto label_7;
            case 6:
              if (other == null)
              {
                num2 = 5;
                continue;
              }
              goto case 7;
            case 7:
              if (ExpressionFingerprintChain.tBCn0pWHGken9Pi2Mxr((object) this.Elements) == other.Elements.Count)
              {
                index = 0;
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 8:
              ++index;
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0 ? 0 : 1;
              continue;
            case 9:
              goto label_7;
            default:
              if (index < ExpressionFingerprintChain.tBCn0pWHGken9Pi2Mxr((object) this.Elements))
                goto case 4;
              else
                goto label_10;
          }
        }
label_4:
        num1 = 3;
        continue;
label_10:
        num1 = 2;
      }
label_7:
      return false;
label_11:
      return true;
label_12:
      return false;
    }

    public override bool Equals(object obj) => this.Equals(obj as ExpressionFingerprintChain);

    public override int GetHashCode()
    {
      int num = 1;
      HashCodeCombiner hashCodeCombiner;
      while (true)
      {
        switch (num)
        {
          case 1:
            hashCodeCombiner = new HashCodeCombiner();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          default:
            this.Elements.ForEach(new Action<ExpressionFingerprint>(hashCodeCombiner.AddFingerprint));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 2;
            continue;
        }
      }
label_3:
      return ExpressionFingerprintChain.xWjutVW78N9NKbuWoxZ((object) hashCodeCombiner);
    }

    public ExpressionFingerprintChain()
    {
      ExpressionFingerprintChain.mpUDkiWxPiX17eU0d7A();
      this.Elements = new List<ExpressionFingerprint>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static int tBCn0pWHGken9Pi2Mxr([In] object obj0) => ((List<ExpressionFingerprint>) obj0).Count;

    internal static bool tk9FZ5WACLxs1PqwaE4([In] object obj0, [In] object obj1) => object.Equals(obj0, obj1);

    internal static bool FXEpnfW49CUa8xK0NFZ() => ExpressionFingerprintChain.Nc8msPWwRFCTBp84VlC == null;

    internal static ExpressionFingerprintChain W6lexRW6I50aDlFJHOp() => ExpressionFingerprintChain.Nc8msPWwRFCTBp84VlC;

    internal static int xWjutVW78N9NKbuWoxZ([In] object obj0) => ((HashCodeCombiner) obj0).CombinedHash;

    internal static void mpUDkiWxPiX17eU0d7A() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
