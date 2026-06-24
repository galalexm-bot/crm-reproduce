// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.DailySettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Scheduling
{
  [Serializable]
  public class DailySettings
  {
    /// <summary>
    /// Каждую N-ый день (1, 2, 3, ..)
    /// По умолчанию - каждый день.
    /// </summary>
    public int EveryDay;
    /// <summary>Только по рабочим дням</summary>
    public bool OnlyWorkDays;
    internal static DailySettings TC4rlDBKaAWt1NcYa6rK;

    [XmlIgnore]
    public int EveryDayProperty
    {
      get => this.EveryDay;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.EveryDay = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 != 0 ? 0 : 0;
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

    [XmlIgnore]
    public bool OnlyWorkDaysProperty
    {
      get => this.OnlyWorkDays;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.OnlyWorkDays = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0 ? 0 : 0;
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

    public bool Validate(List<string> errors)
    {
      if (this.EveryDay >= 1)
        return true;
      errors.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1654249598 >> 2 ^ 413619699)));
      return false;
    }

    public DailySettings()
    {
      DailySettings.dPWTtiBKwQ33eka4YKEB();
      this.EveryDay = 1;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool aq8RTgBKDrZ5nyrCFkmS() => DailySettings.TC4rlDBKaAWt1NcYa6rK == null;

    internal static DailySettings K66gbOBKtHA3qK79BB2d() => DailySettings.TC4rlDBKaAWt1NcYa6rK;

    internal static void dPWTtiBKwQ33eka4YKEB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
