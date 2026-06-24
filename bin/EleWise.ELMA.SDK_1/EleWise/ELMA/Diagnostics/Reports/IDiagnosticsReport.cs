// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Reports.IDiagnosticsReport
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using System;

namespace EleWise.ELMA.Diagnostics.Reports
{
  /// <summary>Отчет о диагностике системы</summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IDiagnosticsReport
  {
    /// <summary>Уникальный идентификатор отчета</summary>
    Guid Uid { get; }

    /// <summary>Название отчета</summary>
    string Name { get; }

    /// <summary>Экспортировать отчет</summary>
    /// <returns>Имя файла</returns>
    string Export();

    /// <summary>Экспортировать отчет</summary>
    /// <returns>Имя файла</returns>
    void Export(string fileName);
  }
}
