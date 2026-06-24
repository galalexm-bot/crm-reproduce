// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Excel.Formats.PercentFormat
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Excel.Formats
{
  public class PercentFormat : FloatFormat
  {
    internal static PercentFormat F0QCEgEEjc2eoZwVlLct;

    public static PercentFormat Default { get; private set; }

    public PercentFormat()
    {
      PercentFormat.dUUrssEEUZLDRJPdWn6J();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.DecimalCount = 1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    protected override string GetFormat() => (string) PercentFormat.ySvI9PEEcA3ZmkR787EE((object) base.GetFormat(), PercentFormat.Ir0BG3EEsAFKapvFfYhH(-1350312861 << 3 ^ 2082133806));

    static PercentFormat()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            PercentFormat.dUUrssEEUZLDRJPdWn6J();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            PercentFormat.SZ610sEEzZOU3apIYEEN((object) new PercentFormat());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void dUUrssEEUZLDRJPdWn6J() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool bhULVgEEYdsGnLvNbdUp() => PercentFormat.F0QCEgEEjc2eoZwVlLct == null;

    internal static PercentFormat MiclWkEELeyfo5dOrtlm() => PercentFormat.F0QCEgEEjc2eoZwVlLct;

    internal static object Ir0BG3EEsAFKapvFfYhH(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object ySvI9PEEcA3ZmkR787EE([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void SZ610sEEzZOU3apIYEEN([In] object obj0) => PercentFormat.Default = (PercentFormat) obj0;
  }
}
