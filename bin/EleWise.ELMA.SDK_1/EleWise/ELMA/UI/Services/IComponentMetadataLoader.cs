// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Services.IComponentMetadataLoader
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.UI.Metadata;
using System;

namespace EleWise.ELMA.UI.Services
{
  /// <summary>Загрузчик метаданных компонента</summary>
  public interface IComponentMetadataLoader
  {
    /// <summary>Загрузить метаданные компонента</summary>
    /// <param name="metadataUid">Идентификатор метаданных</param>
    /// <returns>Метаданные компонента</returns>
    ComponentMetadata GetComponentMetadata(Guid metadataUid);
  }
}
