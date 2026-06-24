// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Excel.ExcelReportBuilder
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Diagnostics.Reports.Excel
{
  /// <summary>Построитель отчета в формате Excel</summary>
  public class ExcelReportBuilder
  {
    private Workbook _workbook;
    private ExcelStylesheet _styles;
    internal static ExcelReportBuilder xNohqTEEGwVavsDDq2qD;

    /// <summary>Ctor</summary>
    public ExcelReportBuilder()
    {
      ExcelReportBuilder.ikw9fEEEQgL9KBMJsjK7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            this._styles = new ExcelStylesheet();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 == 0 ? 1 : 2;
            continue;
          case 2:
            this.ApplyCellFormat = true;
            num = 3;
            continue;
          case 3:
            goto label_3;
          case 4:
            ExcelReportBuilder.ii6kQPEEC1fE9sugZfxh((object) this._workbook.Worksheets);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 1 : 1;
            continue;
          default:
            this._workbook = new Workbook();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0 ? 4 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Книга</summary>
    public Workbook Workbook => this._workbook;

    /// <summary>Стили</summary>
    public ExcelStylesheet Styles
    {
      get => this._styles;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (value == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0 ? 0 : 0;
                continue;
              }
              this._styles = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 2;
              continue;
            case 2:
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:
        throw new ArgumentNullException((string) ExcelReportBuilder.mNIBxBEEvAp58NppvYZg(654297945 ^ 654279215));
      }
    }

    /// <summary>Создать новый лист</summary>
    /// <param name="sheetName">Имя листа</param>
    /// <returns></returns>
    public Worksheet AddWorksheet(string sheetName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.Worksheet = (Worksheet) ExcelReportBuilder.GvaeskEEZmO76cLMwRmB(ExcelReportBuilder.jKQG5VEE8kuIUdtpJnHT((object) this._workbook), (object) sheetName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 0;
            continue;
          default:
            goto label_3;
        }
      }
label_3:
      return this.Worksheet;
    }

    /// <summary>Текущий лист</summary>
    public Worksheet Worksheet
    {
      get => this.\u003CWorksheet\u003Ek__BackingField;
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
              this.\u003CWorksheet\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
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

    /// <summary>
    /// Применять ли формат для ячеек. Если false, считается, что он уже должен быть установлен дял столбца или строки. Свойство обнуляется в true при создании нового листа.
    /// </summary>
    public bool ApplyCellFormat
    {
      get => this.\u003CApplyCellFormat\u003Ek__BackingField;
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
              this.\u003CApplyCellFormat\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0 ? 0 : 0;
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

    /// <summary>Получить строки текущего листа</summary>
    public RowCollection Rows => this.Cells.Rows;

    /// <summary>Номер текущей строки</summary>
    public int RowIndex
    {
      get => this.\u003CRowIndex\u003Ek__BackingField;
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
              this.\u003CRowIndex\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
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

    /// <summary>Перейти к следующей строке</summary>
    public void NextRow()
    {
      int num = 1;
      int rowIndex;
      while (true)
      {
        switch (num)
        {
          case 1:
            rowIndex = this.RowIndex;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            this.RowIndex = rowIndex + 1;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 2;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Получить текущую строку</summary>
    public Row Row => (Row) ExcelReportBuilder.bAjvxcEEIV7naVegI3ye(ExcelReportBuilder.b7tYgtEEu88rU5YYm76H((object) this.Cells), this.RowIndex);

    /// <summary>Установить стиль текущей строки</summary>
    /// <param name="style">Стиль</param>
    public void SetRowStyle(IExcelStyle style)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            if (style == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 0 : 0;
              continue;
            }
            goto case 2;
          case 2:
            this.Row.SetStyle(style);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 3 : 3;
            continue;
          case 3:
            goto label_2;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_2:
      return;
label_7:;
    }

    /// <summary>Получить колонки текущего листа</summary>
    public ColumnCollection Columns
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.CheckWorksheet();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0 ? 0 : 0;
              continue;
            default:
              goto label_2;
          }
        }
label_2:
        return (ColumnCollection) ExcelReportBuilder.vHCIIvEESmgOObLaHXfk(ExcelReportBuilder.bfC70xEEVSUEkSjgMVbN((object) this.Worksheet));
      }
    }

    /// <summary>Установить ширину колонок</summary>
    /// <param name="widths">Массив значений ширин колонок</param>
    public void SetColumnsWidths(params int[] widths)
    {
      int num = 1;
      int columnIndex;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_7;
          case 1:
            if (widths == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
              continue;
            }
            goto case 3;
          case 2:
          case 5:
            if (columnIndex >= widths.Length)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 4 : 0;
              continue;
            }
            goto case 6;
          case 3:
            columnIndex = 0;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 5 : 5;
            continue;
          case 4:
            goto label_5;
          case 6:
            this.Columns[columnIndex].Width = (double) widths[columnIndex];
            num = 7;
            continue;
          case 7:
            ++columnIndex;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0 ? 1 : 2;
            continue;
          default:
            goto label_2;
        }
      }
label_7:
      return;
label_5:
      return;
label_2:;
    }

    /// <summary>Установить высоту строки</summary>
    /// <param name="height">Значение высоты строки</param>
    public void SetRowHeight(int height)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ExcelReportBuilder.DLVIHTEEitiYjcxwqqYW(ExcelReportBuilder.bAjvxcEEIV7naVegI3ye((object) this.Rows, this.RowIndex), (double) height);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Получить ячейки текущего листа</summary>
    public Aspose.Cells.Cells Cells
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              this.CheckWorksheet();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_3:
        return (Aspose.Cells.Cells) ExcelReportBuilder.bfC70xEEVSUEkSjgMVbN((object) this.Worksheet);
      }
    }

    /// <summary>Установить значение ячейки</summary>
    /// <param name="columnIndex"></param>
    /// <param name="value"></param>
    public void SetValue(int columnIndex, object value, bool applyFormat = true)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.Cells[this.RowIndex, columnIndex].SetValue(value, applyFormat);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Установить значения ячеек текущей строки</summary>
    /// <param name="values"></param>
    public void SetValues(params object[] values)
    {
      int num1 = 1;
      while (true)
      {
        int num2 = num1;
        int columnIndex;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_12;
            case 1:
              if (values == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
                continue;
              }
              goto case 5;
            case 2:
            case 8:
              goto label_7;
            case 3:
            case 6:
              if (columnIndex < values.Length)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 2 : 0;
                continue;
              }
              goto label_11;
            case 4:
              goto label_13;
            case 5:
              columnIndex = 0;
              num2 = 6;
              continue;
            case 7:
              goto label_4;
            default:
              goto label_3;
          }
        }
label_7:
        this.SetValue(columnIndex, values[columnIndex]);
        num1 = 4;
        continue;
label_13:
        ++columnIndex;
        num1 = 3;
      }
label_12:
      return;
label_4:
      return;
label_3:
      return;
label_11:;
    }

    /// <summary>Установить стиль ячейки</summary>
    /// <param name="columnIndex">Номер колонки</param>
    /// <param name="style">Стиль</param>
    public void SetCellStyle(int columnIndex, IExcelStyle style)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            goto label_2;
          case 2:
            if (style == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 1 : 1;
              continue;
            }
            goto case 3;
          case 3:
            ((Cell) ExcelReportBuilder.vqSjoyEER7KL4cmvo2gL((object) this.Cells, this.RowIndex, columnIndex)).SetStyle(style);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
            continue;
          default:
            goto label_7;
        }
      }
label_3:
      return;
label_2:
      return;
label_7:;
    }

    public void RenderTable<TRow>(ExcelTable<TRow> table)
    {
      if (table == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(372753449 ^ 372652747));
      this.ApplyCellFormat = false;
      this.RowIndex = 0;
      this.Worksheet.FreezePanes(1, 1, 1, 1);
      IExcelCellFormat[] excelCellFormatArray = new IExcelCellFormat[table.Columns.Count];
      table.Order();
      for (int index = 0; index < table.Columns.Count; ++index)
      {
        ExcelTable<TRow>.IColumn column = table.Columns[index];
        this.Columns[index].Width = column.Width;
        IExcelCellFormat excelCellFormat = column.Format ?? ExcelCellFormat.GetDefaultFormat(column.ValueType);
        excelCellFormatArray[index] = excelCellFormat;
        if (excelCellFormat != null)
        {
          Style style = this.Columns[index].Style;
          excelCellFormat.ApplyFormat(style);
          this.Columns[index].ApplyStyle(style, new StyleFlag()
          {
            NumberFormat = true
          });
        }
        this.SetCellStyle(index, this.Styles.HeaderStyle);
        this.SetValue(index, (object) column.Title);
      }
      if (table.Items != null)
      {
        foreach (TRow row in table.Items)
        {
          this.NextRow();
          for (int index = 0; index < table.Columns.Count; ++index)
          {
            ExcelTable<TRow>.IColumn column = table.Columns[index];
            if (column.ValueAccessor != null)
              this.SetValue(index, column.ValueAccessor(row), excelCellFormatArray[index] == null);
          }
        }
      }
      this.Worksheet.AutoFilter.SetRange(0, 0, table.Columns.Count - 1);
    }

    private void CheckWorksheet()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_5;
          case 2:
            if (this.Worksheet != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 1 : 1;
              continue;
            }
            goto label_4;
          default:
            goto label_4;
        }
      }
label_5:
      return;
label_4:
      throw new InvalidOperationException(EleWise.ELMA.SR.T((string) ExcelReportBuilder.mNIBxBEEvAp58NppvYZg(1199946765 ^ 1199673317)));
    }

    internal static void ikw9fEEEQgL9KBMJsjK7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static void ii6kQPEEC1fE9sugZfxh([In] object obj0) => ((WorksheetCollection) obj0).Clear();

    internal static bool rKpbSIEEEQ8VXlLDKGC1() => ExcelReportBuilder.xNohqTEEGwVavsDDq2qD == null;

    internal static ExcelReportBuilder NdmZipEEfxhWqLbsn6yk() => ExcelReportBuilder.xNohqTEEGwVavsDDq2qD;

    internal static object mNIBxBEEvAp58NppvYZg(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object jKQG5VEE8kuIUdtpJnHT([In] object obj0) => (object) ((Workbook) obj0).Worksheets;

    internal static object GvaeskEEZmO76cLMwRmB([In] object obj0, [In] object obj1) => (object) ((WorksheetCollection) obj0).Add((string) obj1);

    internal static object b7tYgtEEu88rU5YYm76H([In] object obj0) => (object) ((Aspose.Cells.Cells) obj0).Rows;

    internal static object bAjvxcEEIV7naVegI3ye([In] object obj0, [In] int obj1) => (object) ((RowCollection) obj0)[obj1];

    internal static object bfC70xEEVSUEkSjgMVbN([In] object obj0) => (object) ((Worksheet) obj0).Cells;

    internal static object vHCIIvEESmgOObLaHXfk([In] object obj0) => (object) ((Aspose.Cells.Cells) obj0).Columns;

    internal static void DLVIHTEEitiYjcxwqqYW([In] object obj0, [In] double obj1) => ((Row) obj0).Height = obj1;

    internal static object vqSjoyEER7KL4cmvo2gL([In] object obj0, [In] int obj1, [In] int obj2) => (object) ((Aspose.Cells.Cells) obj0)[obj1, obj2];
  }
}
