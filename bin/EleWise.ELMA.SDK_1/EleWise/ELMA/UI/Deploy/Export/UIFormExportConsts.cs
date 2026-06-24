// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Deploy.Export.UIFormExportConsts
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.UI.Deploy.Export
{
  /// <summary>Константы для экспорта</summary>
  public static class UIFormExportConsts
  {
    /// <summary>
    /// Uid реализации точки расширения конфигурации экспорта страниц и портлетов
    /// </summary>
    public static readonly Guid ExportExtensionUid;
    public static readonly Guid ExportExtensionUidPage;
    public static readonly Guid ExportExtensionUidPortlet;
    private static UIFormExportConsts kWAJ9ud8TBkEeQUXbyU;

    static UIFormExportConsts()
    {
      int num = 3;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            UIFormExportConsts.ExportExtensionUidPortlet = new Guid((string) UIFormExportConsts.d46RZwdVNyA1SniUyK6(-1217523399 ^ -1217479495));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
            continue;
          case 2:
            UIFormExportConsts.ExportExtensionUid = new Guid((string) UIFormExportConsts.d46RZwdVNyA1SniUyK6(1242972401 >> 4 ^ 77711599));
            num = 4;
            continue;
          case 3:
            UIFormExportConsts.nuimCNdI1c2R3S5ldZ5();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 2 : 2;
            continue;
          case 4:
            UIFormExportConsts.ExportExtensionUidPage = new Guid((string) UIFormExportConsts.d46RZwdVNyA1SniUyK6(964881585 - -1459193222 ^ -1870864633));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 1 : 1;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    internal static void nuimCNdI1c2R3S5ldZ5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object d46RZwdVNyA1SniUyK6(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool wVQ96adZuWWory3KdY9() => UIFormExportConsts.kWAJ9ud8TBkEeQUXbyU == null;

    internal static UIFormExportConsts Q2M6BbduddQLsm9hXti() => UIFormExportConsts.kWAJ9ud8TBkEeQUXbyU;
  }
}
