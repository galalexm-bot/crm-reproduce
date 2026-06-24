// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Excel.Formats.CustomCellFormat
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Diagnostics.Reports.Excel.Formats
{
  public class CustomCellFormat : ExcelCellFormat
  {
    private Action<Cell, object> _setValueAction;
    internal static CustomCellFormat oktsivEfFgAavvMfJj0g;

    public CustomCellFormat(Action<Cell, object> setValueAction)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this._setValueAction = setValueAction != null ? setValueAction : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87072693));
    }

    public override void SetCellValue(Cell cell, object value)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this._setValueAction(cell, value);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    internal static bool OR6R7TEfB5LU5XRxnmsA() => CustomCellFormat.oktsivEfFgAavvMfJj0g == null;

    internal static CustomCellFormat wFfiyoEfWey458lAMKVX() => CustomCellFormat.oktsivEfFgAavvMfJj0g;
  }
}
