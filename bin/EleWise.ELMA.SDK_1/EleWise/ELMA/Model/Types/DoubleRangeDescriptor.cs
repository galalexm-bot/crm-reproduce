// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.DoubleRangeDescriptor
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
  /// <summary>Описание типа "Дробное число (Диапазон)"</summary>
  public class DoubleRangeDescriptor : RangeTypeDescriptor<DoubleRange, double, DoubleSettings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{232ECBCE-6F65-4C16-821A-CB2F79C6A720}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    internal static DoubleRangeDescriptor tChkKAoyyuNnmQKvfXY0;

    /// <summary>Uid типа</summary>
    public override Guid Uid => DoubleRangeDescriptor.UID;

    /// <summary>Имя "Дробное число (Диапазон)"</summary>
    public override string Name => (string) DoubleRangeDescriptor.TbLjLUoy9c3EDyf7sx97((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459454317));

    public DoubleRangeDescriptor()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DoubleRangeDescriptor()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            DoubleRangeDescriptor.EbqwpBoyd0ZS0uTmK5MZ();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            DoubleRangeDescriptor.UID = new Guid((string) DoubleRangeDescriptor.wiJkmOoylmITXv75PTIk(~-306453669 ^ 306612546));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 2 : 0;
            continue;
        }
      }
label_2:;
    }

    internal static object TbLjLUoy9c3EDyf7sx97([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool JhP9YjoyMgmZt1Enl2xx() => DoubleRangeDescriptor.tChkKAoyyuNnmQKvfXY0 == null;

    internal static DoubleRangeDescriptor b3gYQIoyJqbu5kqBhQvu() => DoubleRangeDescriptor.tChkKAoyyuNnmQKvfXY0;

    internal static void EbqwpBoyd0ZS0uTmK5MZ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object wiJkmOoylmITXv75PTIk(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
