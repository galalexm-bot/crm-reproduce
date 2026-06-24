// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.WeeklySettings
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace EleWise.ELMA.Scheduling
{
  [Serializable]
  public class WeeklySettings
  {
    /// <summary>
    /// Каждую N-ую неделю (1, 2, 3, ..)
    /// По умолчанию - каждую неделю.
    /// </summary>
    public int EveryTime;
    /// <summary>Дни недели. По умолчанию все дни.</summary>
    [NotNull]
    public List<DayOfWeek> DaysFoWeek;
    internal static WeeklySettings BKh6CIBK1Ooie0j3ojvY;

    [XmlIgnore]
    public int EveryTimeProperty
    {
      get => this.EveryTime;
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
              this.EveryTime = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0 ? 0 : 0;
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
    public List<DayOfWeek> DaysFoWeekProperty
    {
      get => this.DaysFoWeek;
      set => this.DaysFoWeek = value;
    }

    public bool Validate(List<string> errors)
    {
      if (this.EveryTime < 1)
      {
        errors.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488808135)));
        return false;
      }
      if (this.DaysFoWeek.Count != 0)
        return true;
      errors.Add(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(572119659 - -337058038 ^ 909234415)));
      return false;
    }

    public WeeklySettings()
    {
      WeeklySettings.uUMDQGBKpENveM3AKL45();
      this.EveryTime = 1;
      this.DaysFoWeek = new List<DayOfWeek>();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool FXKATyBKNQTZwNmM7Vi7() => WeeklySettings.BKh6CIBK1Ooie0j3ojvY == null;

    internal static WeeklySettings wxHrWwBK3G4rReX29Ex6() => WeeklySettings.BKh6CIBK1Ooie0j3ojvY;

    internal static void uUMDQGBKpENveM3AKL45() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
