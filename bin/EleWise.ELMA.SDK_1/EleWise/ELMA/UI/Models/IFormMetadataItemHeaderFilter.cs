// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.UI.Models.IFormMetadataItemHeaderFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using System;

namespace EleWise.ELMA.UI.Models
{
  /// <summary>Фильтр для объекта "Заголовок метаданных формы"</summary>
  [FilterFor(typeof (IFormMetadataItemHeader))]
  public interface IFormMetadataItemHeaderFilter : IEntityFilter
  {
    /// <summary>Фильтр для свойства "Наименование"</summary>
    string Name { get; set; }

    /// <summary>Фильтр для свойства "Отображаемое имя"</summary>
    string DisplayName { get; set; }

    /// <summary>Фильтр для свойства "Дата создания"</summary>
    DateTimeRange CreationDate { get; set; }

    /// <summary>Фильтр для свойства "Тип метаданных"</summary>
    Guid? MetadataType { get; set; }

    /// <summary>Фильтр для свойства "Группа"</summary>
    IFormMetadataItemGroup Group { get; set; }
  }
}
