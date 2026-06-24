// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.ExtensionPoints.IFullTextSearchFieldsMappingsExtension
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.FullTextSearch.Model;
using EleWise.ELMA.Model.Metadata;
using System;

namespace EleWise.ELMA.FullTextSearch.ExtensionPoints
{
  /// <summary>
  /// Расширение для маппинга полей объекта полнотекстового поиска
  /// </summary>
  [ExtensionPoint(ComponentType.All)]
  public interface IFullTextSearchFieldsMappingsExtension : IModuleFullTextSearchExtension
  {
    /// <summary>Свойства для маппинга</summary>
    /// <param name="metadata">Метаданные индексируемого класса</param>
    FieldIndexList MappingFields(ClassMetadata metadata);

    /// <summary>Свойства для маппинга</summary>
    /// <param name="uid">Идентификатор метаданных индексируемого класса</param>
    FieldIndexList MappingFields(Guid uid);

    /// <summary>Свойства для маппинга</summary>
    /// <param name="cardType">Тип карточки объекта полнотекстового поиска</param>
    FieldIndexList MappingFields(Type cardType);
  }
}
