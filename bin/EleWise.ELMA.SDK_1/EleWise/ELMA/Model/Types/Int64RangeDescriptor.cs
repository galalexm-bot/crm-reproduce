// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Int64RangeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Целое число (Диапазон)"</summary>
  public class Int64RangeDescriptor : RangeTypeDescriptor<Int64Range, long, Int64Settings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{925CC507-9275-41A6-B050-4C121926CD98}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    private static Int64RangeDescriptor Gm0U9FoMASVEUiCedLyg;

    /// <summary>Uid типа</summary>
    public override Guid Uid => Int64RangeDescriptor.UID;

    /// <summary>Имя "Целое число (Диапазон)"</summary>
    public override string Name => (string) Int64RangeDescriptor.J1i1AioM0bG8605TCS8L((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488711197));

    public Int64RangeDescriptor()
    {
      Int64RangeDescriptor.QRdyhHoMmAN6ITP55luD();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static Int64RangeDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            Int64RangeDescriptor.UID = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470440286 ^ 1470610182));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object J1i1AioM0bG8605TCS8L([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool eeatLWoM77BhV3jLY1BB() => Int64RangeDescriptor.Gm0U9FoMASVEUiCedLyg == null;

    internal static Int64RangeDescriptor kBbLxioMxor9RaeaKQsu() => Int64RangeDescriptor.Gm0U9FoMASVEUiCedLyg;

    internal static void QRdyhHoMmAN6ITP55luD() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
