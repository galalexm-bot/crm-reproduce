// Decompiled with JetBrains decompiler
// Type: Microsoft.Web.Mvc.ExpressionUtil.TypeBinaryExpressionFingerprint
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
  internal sealed class TypeBinaryExpressionFingerprint : ExpressionFingerprint
  {
    internal static TypeBinaryExpressionFingerprint M3Negao0bEwOI1on8Nr;

    public Type TypeOperand
    {
      get => this.\u003CTypeOperand\u003Ek__BackingField;
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
              this.\u003CTypeOperand\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
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

    public TypeBinaryExpressionFingerprint(ExpressionType nodeType, Type type, Type typeOperand)
    {
      TypeBinaryExpressionFingerprint.pt4PkdoMfV80IJFbekt();
      // ISSUE: explicit constructor call
      base.\u002Ector(nodeType, type);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.TypeOperand = typeOperand;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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
      TypeBinaryExpressionFingerprint other;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_6;
          case 2:
            if (other == null)
            {
              num = 4;
              continue;
            }
            break;
          case 3:
            other = obj as TypeBinaryExpressionFingerprint;
            num = 2;
            continue;
          case 4:
            goto label_7;
        }
        if (object.Equals((object) this.TypeOperand, (object) other.TypeOperand))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 1 : 1;
        else
          goto label_7;
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
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
            continue;
          case 2:
            TypeBinaryExpressionFingerprint.Enl86ooJDSO4sFLIX1A((object) combiner, (object) this.TypeOperand);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool sHEeg6omLrtuqsb34Ju() => TypeBinaryExpressionFingerprint.M3Negao0bEwOI1on8Nr == null;

    internal static TypeBinaryExpressionFingerprint ymTinNoyVUuYkUCHrRY() => TypeBinaryExpressionFingerprint.M3Negao0bEwOI1on8Nr;

    internal static void pt4PkdoMfV80IJFbekt() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void Enl86ooJDSO4sFLIX1A([In] object obj0, [In] object obj1) => ((HashCodeCombiner) obj0).AddObject(obj1);
  }
}
