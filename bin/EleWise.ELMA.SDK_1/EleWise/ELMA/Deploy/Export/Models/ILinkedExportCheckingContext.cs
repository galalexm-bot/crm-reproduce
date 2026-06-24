// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Deploy.Export.Models.ILinkedExportCheckingContext
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Deploy.Export.Enums;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.Deploy.Export.Models
{
  /// <summary>
  /// Контекст проверки экспорта, содержащий информацию о поиска связаных объектов
  /// </summary>
  internal interface ILinkedExportCheckingContext
  {
    /// <summary>Проверка зависимостей</summary>
    /// <remarks>При отсутствии зависимостей будет сформировано сообщение этого типа. В случае значения null проверка проводиться не будет.</remarks>
    ExportCheckingMessageType? DefaultExportLinkChecking { get; set; }

    /// <summary>Входные параметры поиска зависимостей</summary>
    LinkedObjectsSearchParams SearchParams { get; set; }
  }
}
