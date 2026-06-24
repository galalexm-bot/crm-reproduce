// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.ParameterExpressionFingerprint
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
  internal sealed class ParameterExpressionFingerprint : ExpressionFingerprint
  {
    internal static ParameterExpressionFingerprint e6gG3Lo4XTn1ya1Dmc8;

    public int ParameterIndex
    {
      get => this.\u003CParameterIndex\u003Ek__BackingField;
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
              this.\u003CParameterIndex\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 0 : 0;
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

    public ParameterExpressionFingerprint(ExpressionType nodeType, Type type, int parameterIndex)
    {
      ParameterExpressionFingerprint.w2dqoWoAjpgwUd5aPTd();
      // ISSUE: explicit constructor call
      base.\u002Ector(nodeType, type);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.ParameterIndex = parameterIndex;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public override bool Equals(object obj)
    {
      int num = 3;
      ParameterExpressionFingerprint other;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (this.ParameterIndex == ParameterExpressionFingerprint.SGMUkuo73foXH9psla2((object) other))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          case 2:
            if (other != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0 ? 1 : 0;
              continue;
            }
            goto label_3;
          case 3:
            other = obj as ParameterExpressionFingerprint;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 2 : 1;
            continue;
          default:
            goto label_2;
        }
      }
label_2:
      return this.Equals((ExpressionFingerprint) other);
label_3:
      return false;
    }

    internal override void AddToHashCodeCombiner(HashCodeCombiner combiner)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            base.AddToHashCodeCombiner(combiner);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 0 : 0;
            continue;
          case 2:
            ParameterExpressionFingerprint.N65G7IoxXuQF9epGYVu((object) combiner, this.ParameterIndex);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff == 0 ? 0 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool rFiT2xo6DqNJLUPCKe3() => ParameterExpressionFingerprint.e6gG3Lo4XTn1ya1Dmc8 == null;

    internal static ParameterExpressionFingerprint PbnYcqoHkHVhZpwnkkW() => ParameterExpressionFingerprint.e6gG3Lo4XTn1ya1Dmc8;

    internal static void w2dqoWoAjpgwUd5aPTd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static int SGMUkuo73foXH9psla2([In] object obj0) => ((ParameterExpressionFingerprint) obj0).ParameterIndex;

    internal static void N65G7IoxXuQF9epGYVu([In] object obj0, int i) => ((HashCodeCombiner) obj0).AddInt32(i);
  }
}
