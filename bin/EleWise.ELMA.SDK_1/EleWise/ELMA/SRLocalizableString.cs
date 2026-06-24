// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.SRLocalizableString
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Globalization;
using System.Runtime.InteropServices;

namespace EleWise.ELMA
{
  /// <summary>Расширение для локализации</summary>
  public static class SRLocalizableString
  {
    /// <summary>
    /// Создать <see cref="T:Microsoft.CodeAnalysis.LocalizableString" /> по помеченной для локализации строки
    /// </summary>
    /// <param name="srm">Строка, помеченная как локализуемая</param>
    /// <returns><see cref="T:Microsoft.CodeAnalysis.LocalizableString" /></returns>
    public static Microsoft.CodeAnalysis.LocalizableString ToLocalizableString(this string srm) => (Microsoft.CodeAnalysis.LocalizableString) new SRLocalizableString.InternalLocalizableString(srm);

    private class InternalLocalizableString : Microsoft.CodeAnalysis.LocalizableString
    {
      private readonly object srm;
      private static object uGnob6f76ToA45E7tikt;

      public InternalLocalizableString(string srm)
      {
        SRLocalizableString.InternalLocalizableString.DRZt6if77fPhgnaQjZDv();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.srm = (object) srm;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bbf07dd8ec2749979513a053e4fc549b != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      protected override bool AreEqual(object other)
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (!(other is SRLocalizableString.InternalLocalizableString localizableString))
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            case 2:
              goto label_2;
            default:
              goto label_3;
          }
        }
label_2:
        return SRLocalizableString.InternalLocalizableString.BAerqZf7xEyCnWLmjUJv(localizableString.srm, this.srm);
label_3:
        return false;
      }

      protected override int GetHash() => this.srm.GetHashCode();

      protected override string GetText(IFormatProvider formatProvider) => (string) SRLocalizableString.InternalLocalizableString.iATSZnf70S2d7N6dfjiS((object) (formatProvider as CultureInfo), this.srm);

      internal static void DRZt6if77fPhgnaQjZDv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool RCuC3kf7Hp7eUkoNk4nu() => SRLocalizableString.InternalLocalizableString.uGnob6f76ToA45E7tikt == null;

      internal static SRLocalizableString.InternalLocalizableString X90Kj5f7Au0Ai1B2wmRl() => (SRLocalizableString.InternalLocalizableString) SRLocalizableString.InternalLocalizableString.uGnob6f76ToA45E7tikt;

      internal static bool BAerqZf7xEyCnWLmjUJv([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

      internal static object iATSZnf70S2d7N6dfjiS([In] object obj0, [In] object obj1) => (object) SR.T((CultureInfo) obj0, (string) obj1);
    }
  }
}
