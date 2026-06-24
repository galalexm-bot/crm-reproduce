// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ExtensionPoints.IPublicationHandler
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Metadata;

namespace EleWise.ELMA.ExtensionPoints
{
  /// <summary>Точка расширения публикации метаданных</summary>
  [ExtensionPoint(ComponentType.All)]
  internal interface IPublicationHandler
  {
    /// <summary>Обновить метаданные</summary>
    /// <param name="metadata">Метаданные</param>
    void UpdateMetadata(IMetadata metadata);

    /// <summary>Обновить элемент метаданных</summary>
    /// <param name="source">Источник</param>
    /// <param name="destination">Получатель</param>
    void UpdateMetadataItem(IMetadataItem source, IMetadataItem destination);
  }
}
