// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.IDeltaRootMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Enums;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Интерфейс корневого объекта метаданных, допускающих дельта-публикацию
  /// </summary>
  public interface IDeltaRootMetadata : IMetadata, IXsiType
  {
    /// <summary>Получить тип публикации для метаданных</summary>
    /// <param name="oldMetadata">Метаданные</param>
    PublicationType GetPublicationTypeOnChange(IMetadata oldMetadata);
  }
}
