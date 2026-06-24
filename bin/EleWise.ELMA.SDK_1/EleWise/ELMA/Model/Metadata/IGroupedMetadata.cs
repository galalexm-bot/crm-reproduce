// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.IGroupedMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Метаданные объекта, который может быть привязан к группе объектов метаданных
  /// </summary>
  public interface IGroupedMetadata : IMetadata, IXsiType
  {
    /// <summary>Идентификатор группы объектов метаданных</summary>
    long GroupId { get; set; }
  }
}
