// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.ILinkedObject
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>
  /// Краткая информация об объекте, который может проверяться на связанность
  /// </summary>
  public interface ILinkedObject
  {
    /// <summary>Уникальный идентификатор объекта</summary>
    Guid Uid { get; }

    /// <summary>Наименование</summary>
    string Name { get; }

    /// <summary>Идентификатор типа</summary>
    Guid TypeUid { get; }

    /// <summary>Идентификатор подтипа</summary>
    Guid SubtypeUid { get; }
  }
}
