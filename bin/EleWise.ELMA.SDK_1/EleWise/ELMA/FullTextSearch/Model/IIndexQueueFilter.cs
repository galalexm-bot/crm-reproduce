// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Model.IIndexQueueFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Ranges;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.FullTextSearch.Model
{
  /// <summary>Фильтр для объекта "IndexQueue"</summary>
  [FilterFor(typeof (IIndexQueue))]
  public interface IIndexQueueFilter : IEntityFilter
  {
    /// <summary>Фильтр для свойства "Id обрабатываемого объекта"</summary>
    Int64Range ObjectId { get; set; }

    /// <summary>Фильтр для свойства "Тип элемента очереди"</summary>
    List<IndexQueueType> QueueType { get; set; }

    /// <summary>Фильтр для свойства "Тип объекта"</summary>
    Guid? ObjectTypeUid { get; set; }

    /// <summary>Фильтр для свойства "Тип карточки"</summary>
    Guid? CardTypeUid { get; set; }

    /// <summary>Фильтр для свойства "Визуальные данные"</summary>
    bool? VisualData { get; set; }
  }
}
