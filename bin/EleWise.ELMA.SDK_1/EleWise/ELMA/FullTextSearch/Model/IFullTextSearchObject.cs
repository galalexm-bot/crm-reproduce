// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.IFullTextSearchObject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>
  /// Базовый интерфейс для передачи информации об объекте в полнотекстовом поиске
  /// </summary>
  public interface IFullTextSearchObject : IAutoImplement
  {
    /// <summary>Uid типа индексируемого объекта</summary>
    [DisplayName("TypeUid")]
    string TypeUid { get; set; }

    string Id { get; set; }
  }
}
