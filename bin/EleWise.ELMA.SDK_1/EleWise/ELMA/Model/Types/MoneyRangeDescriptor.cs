// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Types.MoneyRangeDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Model.Ranges;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Model.Types
{
  /// <summary>Описание типа "Деньги (Диапазон)"</summary>
  public class MoneyRangeDescriptor : RangeTypeDescriptor<MoneyRange, Money, MoneySettings>
  {
    /// <summary>Uid типа</summary>
    public const string UID_S = "{C245122D-57EE-4B8E-8F9F-F538D06778F4}";
    /// <summary>Uid типа</summary>
    public static readonly Guid UID;
    internal static MoneyRangeDescriptor oNH8SloMji0qywMb7hsn;

    /// <summary>Uid типа</summary>
    public override Guid Uid => MoneyRangeDescriptor.UID;

    /// <summary>Имя "Деньги (Диапазон)"</summary>
    public override string Name => EleWise.ELMA.SR.T((string) MoneyRangeDescriptor.VLy29FoMU9prMavmQFCQ(-1886646897 ^ -1886481113));

    public MoneyRangeDescriptor()
    {
      MoneyRangeDescriptor.ISIiSqoMscFL8a4iEiq2();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static MoneyRangeDescriptor()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            MoneyRangeDescriptor.UID = new Guid((string) MoneyRangeDescriptor.VLy29FoMU9prMavmQFCQ(-1824388195 ^ -1824484525));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          case 2:
            MoneyRangeDescriptor.ISIiSqoMscFL8a4iEiq2();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static object VLy29FoMU9prMavmQFCQ(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool CrITPOoMYiBXaI7wc0f2() => MoneyRangeDescriptor.oNH8SloMji0qywMb7hsn == null;

    internal static MoneyRangeDescriptor TstgeLoMLE45f31m2qi9() => MoneyRangeDescriptor.oNH8SloMji0qywMb7hsn;

    internal static void ISIiSqoMscFL8a4iEiq2() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
