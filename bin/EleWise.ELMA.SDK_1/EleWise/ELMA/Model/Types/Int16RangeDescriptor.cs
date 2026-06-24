// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.Int16RangeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Целое число 16 бит (Диапазон)"</summary>
  public class Int16RangeDescriptor : RangeTypeDescriptor<Int16Range, short, Int16Settings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{7C5ABF3A-1AC9-48CD-B8B0-84F70EAEAF50}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    internal static Int16RangeDescriptor hYdSsDoM17w8HXVKOpDU;

    /// <summary>Uid типа</summary>
    public override Guid Uid => Int16RangeDescriptor.UID;

    /// <summary>Имя "Целое число 16 бит (Диапазон)"</summary>
    public override string Name => EleWise.ELMA.SR.T((string) Int16RangeDescriptor.r8LQ8noMpkXFgX1gmlGx(1142330761 ^ 1541959139 ^ 536637280));

    public Int16RangeDescriptor()
    {
      Int16RangeDescriptor.JSva0hoMaefylcpI6DRO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static Int16RangeDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            Int16RangeDescriptor.JSva0hoMaefylcpI6DRO();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            Int16RangeDescriptor.UID = new Guid((string) Int16RangeDescriptor.r8LQ8noMpkXFgX1gmlGx(694673736 ^ -23604109 ^ -671964557));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object r8LQ8noMpkXFgX1gmlGx(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool AltobioMNLCn4V1m31hG() => Int16RangeDescriptor.hYdSsDoM17w8HXVKOpDU == null;

    internal static Int16RangeDescriptor VYUZQboM3GsNkGrbeD6L() => Int16RangeDescriptor.hYdSsDoM17w8HXVKOpDU;

    internal static void JSva0hoMaefylcpI6DRO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
