// Decompiled with JetBrains decompiler
// Type: Mono.Cecil.Cil.EmitHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Mono.Cecil.Cil
{
  internal static class EmitHelper
  {
    internal static EmitHelper SFkMSjojDlYOhvPxKfp;

    public static void Emit_Ldc_I4(this ILProcessor il, int arg)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EmitHelper.WiBpouoUy33feAx61sF((object) new EmitHelper.ILAdapter(il), arg);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Emit_Ldc_Guid(this ILProcessor il, Guid arg)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            new EmitHelper.ILAdapter(il).Emit_Ldc_Guid(arg);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void WiBpouoUy33feAx61sF([In] object obj0, int arg) => ((EleWise.ELMA.Reflection.EmitHelper.IILAdapter) obj0).Emit_Ldc_I4(arg);

    internal static bool shqxUloY9aqcbnSjMnK() => EmitHelper.SFkMSjojDlYOhvPxKfp == null;

    internal static EmitHelper NYMjqVoL5fwLrKu0Mb2() => EmitHelper.SFkMSjojDlYOhvPxKfp;

    private class ILAdapter : EleWise.ELMA.Reflection.EmitHelper.IILAdapter
    {
      private readonly object il;
      private static object PxOUvbf4JWurVvXsLeDc;

      public ILAdapter(ILProcessor il)
      {
        EmitHelper.ILAdapter.UDjXUWf4lPtJafXgscYY();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.il = (object) il;
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

      public void Ldc_I4_S(sbyte b)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EmitHelper.ILAdapter.voywEGf4rS2pn8a18tZl(this.il, OpCodes.Ldc_I4_S, b);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void Ldc_I4(int i)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EmitHelper.ILAdapter.zUU4PIf4gg2nq1RTlOpe(this.il, OpCodes.Ldc_I4, i);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void Ldc_I4_M1()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EmitHelper.ILAdapter.t2RBuLf45865gBiAKKqg(this.il, OpCodes.Ldc_I4_M1);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void Ldc_I4_0()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EmitHelper.ILAdapter.t2RBuLf45865gBiAKKqg(this.il, OpCodes.Ldc_I4_0);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void Ldc_I4_1()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EmitHelper.ILAdapter.t2RBuLf45865gBiAKKqg(this.il, OpCodes.Ldc_I4_1);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void Ldc_I4_2()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EmitHelper.ILAdapter.t2RBuLf45865gBiAKKqg(this.il, OpCodes.Ldc_I4_2);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void Ldc_I4_3()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ((ILProcessor) this.il).Emit(OpCodes.Ldc_I4_3);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void Ldc_I4_4()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EmitHelper.ILAdapter.t2RBuLf45865gBiAKKqg(this.il, OpCodes.Ldc_I4_4);
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

      public void Ldc_I4_5()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EmitHelper.ILAdapter.t2RBuLf45865gBiAKKqg(this.il, OpCodes.Ldc_I4_5);
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

      public void Ldc_I4_6()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EmitHelper.ILAdapter.t2RBuLf45865gBiAKKqg(this.il, OpCodes.Ldc_I4_6);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void Ldc_I4_7()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EmitHelper.ILAdapter.t2RBuLf45865gBiAKKqg(this.il, OpCodes.Ldc_I4_7);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public void Ldc_I4_8()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              EmitHelper.ILAdapter.t2RBuLf45865gBiAKKqg(this.il, OpCodes.Ldc_I4_8);
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

      public void Newobj(ConstructorInfo ctor)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              ((ILProcessor) this.il).Emit(OpCodes.Newobj, ((ModuleDefinition) EmitHelper.ILAdapter.Qoey4vf4jMOoNY9Wf8CZ((object) ((ILProcessor) this.il).Body.Method)).Import((MethodBase) ctor));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      internal static void UDjXUWf4lPtJafXgscYY() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool rg9kq8f49UKoGekPsiHX() => EmitHelper.ILAdapter.PxOUvbf4JWurVvXsLeDc == null;

      internal static EmitHelper.ILAdapter r9LJhBf4dJSxlXcWl7a4() => (EmitHelper.ILAdapter) EmitHelper.ILAdapter.PxOUvbf4JWurVvXsLeDc;

      internal static void voywEGf4rS2pn8a18tZl([In] object obj0, [In] OpCode obj1, [In] sbyte obj2) => ((ILProcessor) obj0).Emit(obj1, obj2);

      internal static void zUU4PIf4gg2nq1RTlOpe([In] object obj0, [In] OpCode obj1, [In] int obj2) => ((ILProcessor) obj0).Emit(obj1, obj2);

      internal static void t2RBuLf45865gBiAKKqg([In] object obj0, [In] OpCode obj1) => ((ILProcessor) obj0).Emit(obj1);

      internal static object Qoey4vf4jMOoNY9Wf8CZ([In] object obj0) => (object) ((MemberReference) obj0).Module;
    }
  }
}
