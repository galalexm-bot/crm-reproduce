// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.INamedMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Интерфейс для метаданных объектов, имеющих имя, отображаемое имя и описание
  /// </summary>
  public interface INamedMetadata
  {
    /// <summary>Имя объекта</summary>
    string Name { get; set; }

    /// <summary>Отображаемое имя</summary>
    string DisplayName { get; set; }

    /// <summary>Описание</summary>
    string Description { get; set; }

    /// <summary>Список изображений</summary>
    List<MetadataImage> Images { get; set; }
  }
}
