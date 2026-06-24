// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Excel.ExcelCellFormat
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;
using EleWise.ELMA.Diagnostics.Reports.Excel.Formats;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Excel
{
  public abstract class ExcelCellFormat : IExcelCellFormat
  {
    internal static ExcelCellFormat tE8e7qEGi6UySDcRKWM3;

    public virtual void SetCellValue(Cell cell, object value)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            cell.Value = value;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0 ? 0 : 0;
            continue;
          case 2:
            if (value != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 1;
              continue;
            }
            goto label_6;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:
      return;
label_6:;
    }

    public virtual void ApplyFormat(Style style)
    {
    }

    public static IExcelCellFormat GetDefaultFormat(Type valueType)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_2;
          case 2:
            goto label_6;
          case 3:
            if (!(valueType == typeof (DateTime)))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 0 : 0;
              continue;
            }
            goto label_2;
          case 4:
            // ISSUE: type reference
            if (!ExcelCellFormat.VmfokPEGXGM165aul9e5(valueType, ExcelCellFormat.ALIFsSEGKYfh2Flq20kW(__typeref (TimeSpan))))
            {
              num = 3;
              continue;
            }
            goto label_6;
          default:
            goto label_3;
        }
      }
label_2:
      return (IExcelCellFormat) ExcelCellFormat.GTjnS8EGkyyK0Qh6nhlH();
label_3:
      return (IExcelCellFormat) null;
label_6:
      return (IExcelCellFormat) ExcelCellFormat.yXsLLLEGTp5VjiFDe1MW();
    }

    protected ExcelCellFormat()
    {
      ExcelCellFormat.Cghp1iEGnNQX4b6YAUog();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool EOJAoOEGRpGAQHkZdMfy() => ExcelCellFormat.tE8e7qEGi6UySDcRKWM3 == null;

    internal static ExcelCellFormat YCLTJnEGqBfFiwsaiJhI() => ExcelCellFormat.tE8e7qEGi6UySDcRKWM3;

    internal static Type ALIFsSEGKYfh2Flq20kW([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static bool VmfokPEGXGM165aul9e5([In] Type obj0, [In] Type obj1) => obj0 == obj1;

    internal static object yXsLLLEGTp5VjiFDe1MW() => (object) TimeSpanFormat.Default;

    internal static object GTjnS8EGkyyK0Qh6nhlH() => (object) EleWise.ELMA.Diagnostics.Reports.Excel.Formats.DateTimeFormat.Default;

    internal static void Cghp1iEGnNQX4b6YAUog() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
