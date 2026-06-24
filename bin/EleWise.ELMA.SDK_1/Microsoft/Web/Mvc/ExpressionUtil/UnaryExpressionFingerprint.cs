// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.UnaryExpressionFingerprint
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
  internal sealed class UnaryExpressionFingerprint : ExpressionFingerprint
  {
    internal static UnaryExpressionFingerprint wDmSl8o9UxBl6XVXnyZ;

    public MethodInfo Method
    {
      get => this.\u003CMethod\u003Ek__BackingField;
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
              this.\u003CMethod\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
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

    public UnaryExpressionFingerprint(ExpressionType nodeType, Type type, MethodInfo method)
    {
      UnaryExpressionFingerprint.v60cqjorwuSNUrVNEd9();
      // ISSUE: explicit constructor call
      base.\u002Ector(nodeType, type);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Method = method;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    public override bool Equals(object obj)
    {
      int num1 = 4;
      UnaryExpressionFingerprint other;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              if (UnaryExpressionFingerprint.ldOk2Go5vV87fXIiapH((object) this.Method, UnaryExpressionFingerprint.ivqcOCogKOhPrIX9bqC((object) other)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
                continue;
              }
              goto label_7;
            case 3:
              if (other == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 1;
                continue;
              }
              goto case 2;
            case 4:
              goto label_5;
            default:
              goto label_6;
          }
        }
label_5:
        other = obj as UnaryExpressionFingerprint;
        num1 = 3;
      }
label_6:
      return this.Equals((ExpressionFingerprint) other);
label_7:
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 2:
            combiner.AddObject((object) this.Method);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool KxDRHFod08JChKlDk3V() => UnaryExpressionFingerprint.wDmSl8o9UxBl6XVXnyZ == null;

    internal static UnaryExpressionFingerprint e8cAElolbUGElb7brTX() => UnaryExpressionFingerprint.wDmSl8o9UxBl6XVXnyZ;

    internal static void v60cqjorwuSNUrVNEd9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object ivqcOCogKOhPrIX9bqC([In] object obj0) => (object) ((UnaryExpressionFingerprint) obj0).Method;

    internal static bool ldOk2Go5vV87fXIiapH([In] object obj0, [In] object obj1) => object.Equals(obj0, obj1);
  }
}
