// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.Excel.IExcelStyle
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Aspose.Cells;

namespace EleWise.ELMA.Diagnostics.Reports.Excel
{
  /// <summary>Стиль элемента книги Excel</summary>
  public interface IExcelStyle
  {
    /// <summary>Применить стиль</summary>
    /// <param name="style">Стиль</param>
    /// <param name="styleFlag">Флаги применения стиля</param>
    void Apply(Style style, StyleFlag styleFlag);
  }
}
