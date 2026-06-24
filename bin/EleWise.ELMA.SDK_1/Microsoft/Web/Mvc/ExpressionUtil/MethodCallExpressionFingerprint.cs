// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.MethodCallExpressionFingerprint
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
  internal sealed class MethodCallExpressionFingerprint : ExpressionFingerprint
  {
    internal static MethodCallExpressionFingerprint XVR33Uo3uR8WSVt0r6H;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0 ? 0 : 0;
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

    public MethodCallExpressionFingerprint(ExpressionType nodeType, Type type, MethodInfo method)
    {
      MethodCallExpressionFingerprint.iGgivsoD0589NBAYbml();
      // ISSUE: explicit constructor call
      base.\u002Ector(nodeType, type);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Method = method;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public override bool Equals(object obj)
    {
      int num = 3;
      MethodCallExpressionFingerprint other;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_4;
          case 2:
            if (other != null)
            {
              num = 4;
              continue;
            }
            goto label_4;
          case 3:
            other = obj as MethodCallExpressionFingerprint;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 2;
            continue;
          case 4:
            if (!MethodCallExpressionFingerprint.wZM943ot7wl0g3bnTNn((object) this.Method, (object) other.Method))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_3;
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
            MethodCallExpressionFingerprint.XnWMg4owc326Td6HY0w((object) combiner, (object) this.Method);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            base.AddToHashCodeCombiner(combiner);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static bool ayO6T8op4UT1MPgZucM() => MethodCallExpressionFingerprint.XVR33Uo3uR8WSVt0r6H == null;

    internal static MethodCallExpressionFingerprint BghCjxoauBVIaILbiBg() => MethodCallExpressionFingerprint.XVR33Uo3uR8WSVt0r6H;

    internal static void iGgivsoD0589NBAYbml() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool wZM943ot7wl0g3bnTNn([In] object obj0, [In] object obj1) => object.Equals(obj0, obj1);

    internal static void XnWMg4owc326Td6HY0w([In] object obj0, [In] object obj1) => ((HashCodeCombiner) obj0).AddObject(obj1);
  }
}
