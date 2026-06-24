// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Descriptors.IFormDescriptor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.UI.Metadata;
using System;
using System.Reflection;

namespace EleWise.ELMA.UI.Descriptors
{
  public interface IFormDescriptor
  {
    /// <summary>Уникальный идентификатор</summary>
    Guid Uid { get; }

    /// <summary>Идентификатор элемента метаданных формы</summary>
    long MetadataItemId { get; }

    /// <summary>Идентификатор заголовка элемента метаданных формы</summary>
    long MetadataItemHederId { get; }

    /// <summary>
    /// Уникальный идентификатор заголовка элемента метаданных формы
    /// </summary>
    Guid MetadataItemHederUid { get; }

    /// <summary>Id автора</summary>
    long? AuthorId { get; }

    /// <summary>Метаданные</summary>
    FormMetadata Metadata { get; }

    /// <summary>Сборка</summary>
    Assembly Assembly { get; }

    /// <summary>Тип контроллера</summary>
    Type ControllerType { get; }
  }
}
