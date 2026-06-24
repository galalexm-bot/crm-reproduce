// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Metadata.IMetadata
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ExtensionPoints;
using System;

namespace EleWise.ELMA.Model.Metadata
{
  /// <summary>Базовый интерфейс метаданных</summary>
  public interface IMetadata : IXsiType
  {
    /// <summary>Уникальный идентификатор объекта</summary>
    Guid Uid { get; set; }

    /// <summary>Инициализировать новый объект метаданных</summary>
    void InitNew();

    /// <summary>Выполнить действия после загрузки объекта метаданных</summary>
    void AfterLoad();

    /// <summary>
    /// Идентификатор модуля, к которому принадлежат метаданные
    /// </summary>
    Guid ModuleUid { get; }

    /// <summary>Внутренние метаданные модуля</summary>
    bool Internal { get; }
  }
}
