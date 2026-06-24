// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.MemberExpressionFingerprint
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
  internal sealed class MemberExpressionFingerprint : ExpressionFingerprint
  {
    internal static MemberExpressionFingerprint NyqxEsonjP7Unghn9n3;

    public MemberInfo Member
    {
      get => this.\u003CMember\u003Ek__BackingField;
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
              this.\u003CMember\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
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

    public MemberExpressionFingerprint(ExpressionType nodeType, Type type, MemberInfo member)
    {
      MemberExpressionFingerprint.EXh6WsoeZoFITGvgeZH();
      // ISSUE: explicit constructor call
      base.\u002Ector(nodeType, type);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Member = member;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public override bool Equals(object obj)
    {
      int num = 3;
      MemberExpressionFingerprint other;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (other != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0 ? 0 : 0;
              continue;
            }
            goto label_8;
          case 3:
            other = obj as MemberExpressionFingerprint;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 2 : 1;
            continue;
          default:
            if (MemberExpressionFingerprint.N8AMlyo1MSQXsFv90m2((object) this.Member, MemberExpressionFingerprint.RtnwihoPjJUV6TFqU5o((object) other)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 1 : 1;
              continue;
            }
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
            continue;
          case 2:
            MemberExpressionFingerprint.ew5FLsoNJI0WVw83Z3j((object) combiner, (object) this.Member);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool Da278toOMc54JAYXpOl() => MemberExpressionFingerprint.NyqxEsonjP7Unghn9n3 == null;

    internal static MemberExpressionFingerprint wwGM2qo2NVbmYZnKsOX() => MemberExpressionFingerprint.NyqxEsonjP7Unghn9n3;

    internal static void EXh6WsoeZoFITGvgeZH() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object RtnwihoPjJUV6TFqU5o([In] object obj0) => (object) ((MemberExpressionFingerprint) obj0).Member;

    internal static bool N8AMlyo1MSQXsFv90m2([In] object obj0, [In] object obj1) => object.Equals(obj0, obj1);

    internal static void ew5FLsoNJI0WVw83Z3j([In] object obj0, [In] object obj1) => ((HashCodeCombiner) obj0).AddObject(obj1);
  }
}
