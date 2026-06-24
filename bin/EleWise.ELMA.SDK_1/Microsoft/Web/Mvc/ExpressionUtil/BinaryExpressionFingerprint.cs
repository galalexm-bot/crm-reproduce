// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.BinaryExpressionFingerprint
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
  internal sealed class BinaryExpressionFingerprint : ExpressionFingerprint
  {
    private static BinaryExpressionFingerprint frJFagWv6bPZoVp6OR2;

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0 ? 0 : 0;
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

    public BinaryExpressionFingerprint(ExpressionType nodeType, Type type, MethodInfo method)
    {
      BinaryExpressionFingerprint.Gg8XVvWuHZSMUj4uNq9();
      // ISSUE: explicit constructor call
      base.\u002Ector(nodeType, type);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Method = method;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public override bool Equals(object obj)
    {
      int num = 4;
      BinaryExpressionFingerprint other;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (BinaryExpressionFingerprint.bSjG9qWVoABAH9TDddQ((object) this.Method, BinaryExpressionFingerprint.CtsQiRWIpEEUtrnsGge((object) other)))
            {
              num = 2;
              continue;
            }
            goto label_8;
          case 2:
            goto label_7;
          case 3:
            if (other == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0 ? 0 : 0;
              continue;
            }
            goto case 1;
          case 4:
            other = obj as BinaryExpressionFingerprint;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e != 0 ? 3 : 3;
            continue;
          default:
            goto label_8;
        }
      }
label_7:
      return this.Equals((ExpressionFingerprint) other);
label_8:
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          case 2:
            BinaryExpressionFingerprint.gNEA0tWS06XqPH8j9qY((object) combiner, (object) this.Method);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool hPcStqW8FLHwqIQAdIj() => BinaryExpressionFingerprint.frJFagWv6bPZoVp6OR2 == null;

    internal static BinaryExpressionFingerprint LAnthKWZDURSWhuoTUI() => BinaryExpressionFingerprint.frJFagWv6bPZoVp6OR2;

    internal static void Gg8XVvWuHZSMUj4uNq9() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object CtsQiRWIpEEUtrnsGge([In] object obj0) => (object) ((BinaryExpressionFingerprint) obj0).Method;

    internal static bool bSjG9qWVoABAH9TDddQ([In] object obj0, [In] object obj1) => object.Equals(obj0, obj1);

    internal static void gNEA0tWS06XqPH8j9qY([In] object obj0, [In] object obj1) => ((HashCodeCombiner) obj0).AddObject(obj1);
  }
}
