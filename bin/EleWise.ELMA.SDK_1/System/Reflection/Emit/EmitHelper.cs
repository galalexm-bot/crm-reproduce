// Decompiled with JetBrains decompiler
// Type: System.Reflection.Emit.EmitHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Runtime.InteropServices;

namespace System.Reflection.Emit
{
  internal static class EmitHelper
  {
    internal static EmitHelper OGbAPlEQhdxY0Qjggx0;

    public static void Emit_Ldc_I4(this ILGenerator il, int arg)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EmitHelper.knj7F5E8vMqBFS4eBxG((object) new EmitHelper.ILAdapter(il), arg);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_15b4035e530d46429104ec3abcdabf41 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public static void Emit_Ldc_Guid(this ILGenerator il, Guid arg)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            EmitHelper.k0MqroEZWYT9cEMpwBp((object) new EmitHelper.ILAdapter(il), arg);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static void knj7F5E8vMqBFS4eBxG([In] object obj0, int arg) => ((EleWise.ELMA.Reflection.EmitHelper.IILAdapter) obj0).Emit_Ldc_I4(arg);

    internal static bool eas14bECMvct1nwBADW() => EmitHelper.OGbAPlEQhdxY0Qjggx0 == null;

    internal static EmitHelper HN8YEwEvJLodnPalW9q() => EmitHelper.OGbAPlEQhdxY0Qjggx0;

    internal static void k0MqroEZWYT9cEMpwBp([In] object obj0, Guid uid) => ((EleWise.ELMA.Reflection.EmitHelper.IILAdapter) obj0).Emit_Ldc_Guid(uid);

    private class ILAdapter : EleWise.ELMA.Reflection.EmitHelper.IILAdapter
    {
      private readonly object il;
      internal static object K86CASfHEeiborKGcwaQ;

      public ILAdapter(ILGenerator il)
      {
        TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
          num = 0;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_3;
            default:
              this.il = (object) il;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 1 : 0;
              continue;
          }
        }
label_3:;
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
              ((ILGenerator) this.il).Emit(OpCodes.Ldc_I4_S, b);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
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
              ((ILGenerator) this.il).Emit(OpCodes.Ldc_I4, i);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 0 : 0;
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
              EmitHelper.ILAdapter.NAPnhKfHCGKbAIV46FbV(this.il, OpCodes.Ldc_I4_M1);
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
              EmitHelper.ILAdapter.NAPnhKfHCGKbAIV46FbV(this.il, OpCodes.Ldc_I4_0);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
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
              EmitHelper.ILAdapter.NAPnhKfHCGKbAIV46FbV(this.il, OpCodes.Ldc_I4_1);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
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
              EmitHelper.ILAdapter.NAPnhKfHCGKbAIV46FbV(this.il, OpCodes.Ldc_I4_2);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0 ? 0 : 0;
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
              EmitHelper.ILAdapter.NAPnhKfHCGKbAIV46FbV(this.il, OpCodes.Ldc_I4_3);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 0 : 0;
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
              EmitHelper.ILAdapter.NAPnhKfHCGKbAIV46FbV(this.il, OpCodes.Ldc_I4_4);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_74b3b832e58d418e87e3ee261fe7306d == 0 ? 0 : 0;
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
              ((ILGenerator) this.il).Emit(OpCodes.Ldc_I4_5);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
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
              EmitHelper.ILAdapter.NAPnhKfHCGKbAIV46FbV(this.il, OpCodes.Ldc_I4_6);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 0 : 0;
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
              EmitHelper.ILAdapter.NAPnhKfHCGKbAIV46FbV(this.il, OpCodes.Ldc_I4_7);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
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
              ((ILGenerator) this.il).Emit(OpCodes.Ldc_I4_8);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0 ? 0 : 0;
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
              EmitHelper.ILAdapter.Q7ijaOfHvjF9j0Z4o25P(this.il, OpCodes.Newobj, (object) ctor);
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

      internal static bool Sp1Qg6fHfEnky3nfPjpR() => EmitHelper.ILAdapter.K86CASfHEeiborKGcwaQ == null;

      internal static EmitHelper.ILAdapter W4LDUIfHQWJeOesuJHVY() => (EmitHelper.ILAdapter) EmitHelper.ILAdapter.K86CASfHEeiborKGcwaQ;

      internal static void NAPnhKfHCGKbAIV46FbV([In] object obj0, [In] OpCode obj1) => ((ILGenerator) obj0).Emit(obj1);

      internal static void Q7ijaOfHvjF9j0Z4o25P([In] object obj0, [In] OpCode obj1, [In] object obj2) => ((ILGenerator) obj0).Emit(obj1, (ConstructorInfo) obj2);
    }
  }
}
