// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Int32RangeDescriptor
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
  /// <summary>Описание типа "Целое число 32 бита (Диапазон)"</summary>
  public class Int32RangeDescriptor : RangeTypeDescriptor<Int32Range, int, Int32Settings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{D3F10142-1053-4407-9E33-A5D52ED0BEF4}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    internal static Int32RangeDescriptor ImpppuoMDqWpWOdnXOJA;

    /// <summary>Uid типа</summary>
    public override Guid Uid => Int32RangeDescriptor.UID;

    /// <summary>Имя "Целое число 32 бита (Диапазон)"</summary>
    public override string Name => (string) Int32RangeDescriptor.oIuMVLoM4yGW9rrxfFS7((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1859045831));

    public Int32RangeDescriptor()
    {
      Int32RangeDescriptor.O1d04ooM6itPR3mUVaJ3();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static Int32RangeDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            Int32RangeDescriptor.UID = new Guid((string) Int32RangeDescriptor.g3PttvoMH1wK2Lmynpfy(87862435 ^ 87964539));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
            continue;
          case 2:
            Int32RangeDescriptor.O1d04ooM6itPR3mUVaJ3();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object oIuMVLoM4yGW9rrxfFS7([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool FscAepoMtPnt4HtlYeUH() => Int32RangeDescriptor.ImpppuoMDqWpWOdnXOJA == null;

    internal static Int32RangeDescriptor Ytmy4KoMwOsBf2mht4Pr() => Int32RangeDescriptor.ImpppuoMDqWpWOdnXOJA;

    internal static void O1d04ooM6itPR3mUVaJ3() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object g3PttvoMH1wK2Lmynpfy(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
