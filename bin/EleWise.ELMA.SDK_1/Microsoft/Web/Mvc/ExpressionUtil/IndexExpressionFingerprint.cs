// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.IndexExpressionFingerprint
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Microsoft.Web.Mvc.ExpressionUtil
{
  internal sealed class IndexExpressionFingerprint : ExpressionFingerprint
  {
    private static IndexExpressionFingerprint lXORSHoZRiUVBwh3Fl4;

    public PropertyInfo Indexer
    {
      get => this.\u003CIndexer\u003Ek__BackingField;
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
              this.\u003CIndexer\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0 ? 0 : 0;
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

    public IndexExpressionFingerprint(ExpressionType nodeType, Type type, PropertyInfo indexer)
    {
      IndexExpressionFingerprint.lLcTGjoVAxnWVD3u4G6();
      // ISSUE: explicit constructor call
      base.\u002Ector(nodeType, type);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Indexer = indexer;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    public override bool Equals(object obj)
    {
      int num = 1;
      IndexExpressionFingerprint other;
      while (true)
      {
        switch (num)
        {
          case 1:
            other = obj as IndexExpressionFingerprint;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_3;
          case 3:
            if (object.Equals((object) this.Indexer, IndexExpressionFingerprint.i76Y3AoS3NE10RSdw5a((object) other)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 0 : 2;
              continue;
            }
            goto label_4;
          default:
            if (other != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 3 : 0;
              continue;
            }
            goto label_4;
        }
      }
label_3:
      return this.Equals((ExpressionFingerprint) other);
label_4:
      return false;
    }

    internal override void AddToHashCodeCombiner(HashCodeCombiner combiner)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            combiner.AddObject((object) this.Indexer);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            base.AddToHashCodeCombiner(combiner);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static bool X7eHcvou93yvMKnwSB9() => IndexExpressionFingerprint.lXORSHoZRiUVBwh3Fl4 == null;

    internal static IndexExpressionFingerprint mqEI4koIC1I8Doslhv3() => IndexExpressionFingerprint.lXORSHoZRiUVBwh3Fl4;

    internal static void lLcTGjoVAxnWVD3u4G6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object i76Y3AoS3NE10RSdw5a([In] object obj0) => (object) ((IndexExpressionFingerprint) obj0).Indexer;
  }
}
