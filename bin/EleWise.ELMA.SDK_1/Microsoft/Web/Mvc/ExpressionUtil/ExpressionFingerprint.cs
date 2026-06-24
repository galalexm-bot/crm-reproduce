// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.ExpressionFingerprint
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;
using System.Runtime.InteropServices;

namespace Microsoft.Web.Mvc.ExpressionUtil
{
  internal abstract class ExpressionFingerprint
  {
    private static ExpressionFingerprint q7Yq2mWeWPgAAG6jPbB;

    public ExpressionType NodeType
    {
      get => this.\u003CNodeType\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CNodeType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e == 0 ? 0 : 0;
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

    public Type Type
    {
      get => this.\u003CType\u003Ek__BackingField;
      private set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CType\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
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

    protected ExpressionFingerprint(ExpressionType nodeType, Type type)
    {
      ExpressionFingerprint.MMGX3wWN9Xn07uOHtVl();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
        num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          case 2:
            this.NodeType = nodeType;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0 ? 0 : 0;
            continue;
          default:
            this.Type = type;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    internal virtual void AddToHashCodeCombiner(HashCodeCombiner combiner)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            ExpressionFingerprint.HqbchpW3yr6CfUv8bK1((object) combiner, (int) this.NodeType);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            ExpressionFingerprint.snTxemWpSKLYhscsJ0F((object) combiner, (object) this.Type);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    protected bool Equals(ExpressionFingerprint other)
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.NodeType == other.NodeType)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
              continue;
            }
            goto label_7;
          case 2:
            goto label_7;
          case 3:
            if (other == null)
            {
              num = 2;
              continue;
            }
            goto case 1;
          default:
            goto label_6;
        }
      }
label_6:
      return object.Equals((object) this.Type, (object) ExpressionFingerprint.RMA9XsWaw8kwIesi74w((object) other));
label_7:
      return false;
    }

    public override bool Equals(object obj) => this.Equals(obj as ExpressionFingerprint);

    public override int GetHashCode()
    {
      int num = 2;
      HashCodeCombiner hashCodeCombiner;
      while (true)
      {
        switch (num)
        {
          case 1:
            ExpressionFingerprint.MJE5KmWDssewyJ8Gid1((object) this, (object) hashCodeCombiner);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
            continue;
          case 2:
            hashCodeCombiner = new HashCodeCombiner();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 1 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return ExpressionFingerprint.eb0VibWtSN66uocWjf0((object) hashCodeCombiner);
    }

    internal static bool gYi5RXWPIMDmEKgqwdk() => ExpressionFingerprint.q7Yq2mWeWPgAAG6jPbB == null;

    internal static ExpressionFingerprint S5k2S8W1l4lvxY2Cew4() => ExpressionFingerprint.q7Yq2mWeWPgAAG6jPbB;

    internal static void MMGX3wWN9Xn07uOHtVl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void HqbchpW3yr6CfUv8bK1([In] object obj0, int i) => ((HashCodeCombiner) obj0).AddInt32(i);

    internal static void snTxemWpSKLYhscsJ0F([In] object obj0, [In] object obj1) => ((HashCodeCombiner) obj0).AddObject(obj1);

    internal static Type RMA9XsWaw8kwIesi74w([In] object obj0) => ((ExpressionFingerprint) obj0).Type;

    internal static void MJE5KmWDssewyJ8Gid1([In] object obj0, [In] object obj1) => ((ExpressionFingerprint) obj0).AddToHashCodeCombiner((HashCodeCombiner) obj1);

    internal static int eb0VibWtSN66uocWjf0([In] object obj0) => ((HashCodeCombiner) obj0).CombinedHash;
  }
}
