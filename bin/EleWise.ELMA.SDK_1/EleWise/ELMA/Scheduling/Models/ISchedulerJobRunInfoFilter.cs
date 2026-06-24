// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Models.ISchedulerJobRunInfoFilter
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using System;

namespace EleWise.ELMA.Scheduling.Models
{
  /// <summary>
  /// Фильтр для объекта "Информация о запуске работы планировщика"
  /// </summary>
  [FilterFor(typeof (ISchedulerJobRunInfo))]
  public interface ISchedulerJobRunInfoFilter : IEntityFilter
  {
    /// <summary>Фильтр для свойства "Идентификатор триггера"</summary>
    Guid? TriggerId { get; set; }

    /// <summary>Фильтр для свойства "Идентификатор работы"</summary>
    Guid? JobId { get; set; }

    /// <summary>Фильтр для свойства "Работа"</summary>
    ISchedulerTaskJob Job { get; set; }
  }
}
