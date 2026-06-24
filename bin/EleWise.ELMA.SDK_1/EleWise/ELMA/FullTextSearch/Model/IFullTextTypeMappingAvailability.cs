// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.IFullTextTypeMappingAvailability
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>
  /// Доступность сервиса управления типами полнотекстового поиска.
  /// </summary>
  internal interface IFullTextTypeMappingAvailability
  {
    /// <summary>Является ли сервис доступным.</summary>
    bool IsAvailable { get; }

    /// <summary>
    /// Список ошибок, из-за которых сервис является недоступным.
    /// </summary>
    IReadOnlyCollection<string> Errors { get; }
  }
}
