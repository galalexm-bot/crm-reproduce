// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Reflection.EmitHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Reflection
{
  internal static class EmitHelper
  {
    private static readonly ConstructorInfo GuidCtor;
    private static EmitHelper Rg2c19Bk7GJeGUSCpypR;

    internal static void Emit_Ldc_I4(this EmitHelper.IILAdapter il, int arg)
    {
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_28;
          case 1:
            goto label_24;
          case 2:
            EmitHelper.I2TRyVBkrWWh24wpnNXD((object) il, (sbyte) arg);
            num = 10;
            continue;
          case 3:
            if (arg > (int) sbyte.MaxValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 7 : 13;
              continue;
            }
            goto case 2;
          case 4:
            if (arg >= (int) sbyte.MinValue)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0 ? 2 : 3;
              continue;
            }
            goto case 13;
          case 5:
            switch (arg)
            {
              case -1:
                goto label_15;
              case 0:
                EmitHelper.zC3pXGBkmCDpDmjUZK0F((object) il);
                num = 11;
                continue;
              case 1:
                EmitHelper.ufuvngBkydMimoHX9IqT((object) il);
                num = 14;
                continue;
              case 2:
                il.Ldc_I4_2();
                num = 9;
                continue;
              case 3:
                EmitHelper.NNGQuEBkM5b29SVMkNP9((object) il);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 14 : 16;
                continue;
              case 4:
                EmitHelper.eYf0ptBkJLOPUT6xcXum((object) il);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
                continue;
              case 5:
                EmitHelper.I5EF4hBk9YdOZxJLZj39((object) il);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f != 0 ? 12 : 3;
                continue;
              case 6:
                EmitHelper.dF5WtTBkdVt0ARDmQ9gc((object) il);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0 ? 8 : 2;
                continue;
              case 7:
                EmitHelper.C5m4fbBklawHbAKh3KUk((object) il);
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 16 : 17;
                continue;
              case 8:
                il.Ldc_I4_8();
                num = 6;
                continue;
              default:
                num = 4;
                continue;
            }
          case 6:
            goto label_6;
          case 7:
            goto label_19;
          case 8:
            goto label_26;
          case 9:
            goto label_4;
          case 10:
            goto label_23;
          case 11:
            goto label_11;
          case 12:
            goto label_13;
          case 13:
            EmitHelper.Q922qPBkgbPX107P81qf((object) il, arg);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0 ? 7 : 6;
            continue;
          case 14:
            goto label_30;
          case 15:
label_15:
            il.Ldc_I4_M1();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 1;
            continue;
          case 16:
            goto label_17;
          case 17:
            goto label_8;
          default:
            goto label_16;
        }
      }
label_28:
      return;
label_24:
      return;
label_6:
      return;
label_19:
      return;
label_26:
      return;
label_4:
      return;
label_23:
      return;
label_11:
      return;
label_13:
      return;
label_30:
      return;
label_17:
      return;
label_8:
      return;
label_16:;
    }

    internal static void Emit_Ldc_Guid(this EmitHelper.IILAdapter il, Guid uid)
    {
      int num1 = 19;
      while (true)
      {
        int num2 = num1;
        byte num3;
        byte[] byteArray;
        byte num4;
        ushort num5;
        int num6;
        byte num7;
        byte num8;
        ushort num9;
        byte num10;
        byte num11;
        byte num12;
        byte num13;
        while (true)
        {
          switch (num2)
          {
            case 1:
              num9 = (ushort) ((uint) byteArray[5] << 8 | (uint) byteArray[4]);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 11 : 1;
              continue;
            case 2:
              num4 = byteArray[8];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 13 : 14;
              continue;
            case 3:
              EmitHelper.zPdHnNBk5rLd6KtJXQjj((object) il, (int) num5);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 9 : 17;
              continue;
            case 4:
              num10 = byteArray[12];
              num2 = 24;
              continue;
            case 5:
              EmitHelper.zPdHnNBk5rLd6KtJXQjj((object) il, num6);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 0 : 0;
              continue;
            case 6:
              EmitHelper.zPdHnNBk5rLd6KtJXQjj((object) il, (int) num10);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 6 : 7;
              continue;
            case 7:
              goto label_26;
            case 8:
              num3 = byteArray[15];
              num2 = 5;
              continue;
            case 9:
              EmitHelper.zPdHnNBk5rLd6KtJXQjj((object) il, (int) num7);
              num2 = 12;
              continue;
            case 10:
              goto label_24;
            case 11:
              num5 = (ushort) ((uint) byteArray[7] << 8 | (uint) byteArray[6]);
              num2 = 2;
              continue;
            case 12:
              EmitHelper.zPdHnNBk5rLd6KtJXQjj((object) il, (int) num12);
              num2 = 21;
              continue;
            case 13:
              num11 = byteArray[14];
              num2 = 8;
              continue;
            case 14:
              num7 = byteArray[9];
              num2 = 10;
              continue;
            case 15:
              goto label_3;
            case 16:
              EmitHelper.zPdHnNBk5rLd6KtJXQjj((object) il, (int) num3);
              num2 = 20;
              continue;
            case 17:
              EmitHelper.zPdHnNBk5rLd6KtJXQjj((object) il, (int) num4);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0 ? 3 : 9;
              continue;
            case 18:
              num6 = (int) byteArray[3] << 24 | (int) byteArray[2] << 16 | (int) byteArray[1] << 8 | (int) byteArray[0];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 1 : 1;
              continue;
            case 19:
              byteArray = uid.ToByteArray();
              num2 = 18;
              continue;
            case 20:
              EmitHelper.fKsVhGBkjyI6JuWPtUqM((object) il, (object) EmitHelper.GuidCtor);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0 ? 15 : 15;
              continue;
            case 21:
              EmitHelper.zPdHnNBk5rLd6KtJXQjj((object) il, (int) num8);
              num2 = 6;
              continue;
            case 22:
              EmitHelper.zPdHnNBk5rLd6KtJXQjj((object) il, (int) num11);
              num2 = 16;
              continue;
            case 23:
              num8 = byteArray[11];
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 4 : 4;
              continue;
            case 24:
              num13 = byteArray[13];
              num2 = 13;
              continue;
            default:
              EmitHelper.zPdHnNBk5rLd6KtJXQjj((object) il, (int) num9);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 3 : 3;
              continue;
          }
        }
label_24:
        num12 = byteArray[10];
        num1 = 23;
        continue;
label_26:
        EmitHelper.zPdHnNBk5rLd6KtJXQjj((object) il, (int) num13);
        num1 = 22;
      }
label_3:;
    }

    static EmitHelper()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            // ISSUE: type reference
            EmitHelper.GuidCtor = typeof (Guid).GetConstructor(new Type[11]
            {
              typeof (int),
              EmitHelper.QrQHSOBkLE6eh4WeG7Ue(__typeref (short)),
              typeof (short),
              EmitHelper.QrQHSOBkLE6eh4WeG7Ue(__typeref (byte)),
              typeof (byte),
              EmitHelper.QrQHSOBkLE6eh4WeG7Ue(__typeref (byte)),
              EmitHelper.QrQHSOBkLE6eh4WeG7Ue(__typeref (byte)),
              EmitHelper.QrQHSOBkLE6eh4WeG7Ue(__typeref (byte)),
              EmitHelper.QrQHSOBkLE6eh4WeG7Ue(__typeref (byte)),
              EmitHelper.QrQHSOBkLE6eh4WeG7Ue(__typeref (byte)),
              EmitHelper.QrQHSOBkLE6eh4WeG7Ue(__typeref (byte))
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 0 : 0;
            continue;
          case 2:
            EmitHelper.Chp88xBkYgGJa5gI9YUh();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void zC3pXGBkmCDpDmjUZK0F([In] object obj0) => ((EmitHelper.IILAdapter) obj0).Ldc_I4_0();

    internal static void ufuvngBkydMimoHX9IqT([In] object obj0) => ((EmitHelper.IILAdapter) obj0).Ldc_I4_1();

    internal static void NNGQuEBkM5b29SVMkNP9([In] object obj0) => ((EmitHelper.IILAdapter) obj0).Ldc_I4_3();

    internal static void eYf0ptBkJLOPUT6xcXum([In] object obj0) => ((EmitHelper.IILAdapter) obj0).Ldc_I4_4();

    internal static void I5EF4hBk9YdOZxJLZj39([In] object obj0) => ((EmitHelper.IILAdapter) obj0).Ldc_I4_5();

    internal static void dF5WtTBkdVt0ARDmQ9gc([In] object obj0) => ((EmitHelper.IILAdapter) obj0).Ldc_I4_6();

    internal static void C5m4fbBklawHbAKh3KUk([In] object obj0) => ((EmitHelper.IILAdapter) obj0).Ldc_I4_7();

    internal static void I2TRyVBkrWWh24wpnNXD([In] object obj0, sbyte b) => ((EmitHelper.IILAdapter) obj0).Ldc_I4_S(b);

    internal static void Q922qPBkgbPX107P81qf([In] object obj0, int i) => ((EmitHelper.IILAdapter) obj0).Ldc_I4(i);

    internal static bool jgvbdqBkxk54JOWhwCVm() => EmitHelper.Rg2c19Bk7GJeGUSCpypR == null;

    internal static EmitHelper bh16rwBk0aHLqdSL5sml() => EmitHelper.Rg2c19Bk7GJeGUSCpypR;

    internal static void zPdHnNBk5rLd6KtJXQjj([In] object obj0, int arg) => ((EmitHelper.IILAdapter) obj0).Emit_Ldc_I4(arg);

    internal static void fKsVhGBkjyI6JuWPtUqM([In] object obj0, [In] object obj1) => ((EmitHelper.IILAdapter) obj0).Newobj((ConstructorInfo) obj1);

    internal static void Chp88xBkYgGJa5gI9YUh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type QrQHSOBkLE6eh4WeG7Ue([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal interface IILAdapter
    {
      void Ldc_I4_S(sbyte b);

      void Ldc_I4(int i);

      void Ldc_I4_M1();

      void Ldc_I4_0();

      void Ldc_I4_1();

      void Ldc_I4_2();

      void Ldc_I4_3();

      void Ldc_I4_4();

      void Ldc_I4_5();

      void Ldc_I4_6();

      void Ldc_I4_7();

      void Ldc_I4_8();

      void Newobj(ConstructorInfo ctor);
    }
  }
}
