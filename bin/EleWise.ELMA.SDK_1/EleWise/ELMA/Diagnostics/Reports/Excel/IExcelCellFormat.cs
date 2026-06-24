// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Excel.IExcelCellFormat
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;

namespace EleWise.ELMA.Diagnostics.Reports.Excel
{
  /// <summary>Формат ячейки таблицы</summary>
  public interface IExcelCellFormat
  {
    /// <summary>Установить значение в ячейку</summary>
    /// <param name="cell"></param>
    /// <param name="value"></param>
    void SetCellValue(Cell cell, object value);

    /// <summary>Применить формат к стилю</summary>
    /// <param name="style">Стиль колонки, ячейки или строки</param>
    void ApplyFormat(Style style);
  }
}
