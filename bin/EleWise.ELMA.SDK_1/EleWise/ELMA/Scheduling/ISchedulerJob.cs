// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.ISchedulerJob
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>Запланированная работа планировщика</summary>
  /// <remarks>
  /// <see href="http://www.elma-bpm.ru/kb/article-794.html">Пример реализации в базе знаний</see>
  /// </remarks>
  [DeveloperApi(DeveloperApiType.ExtensionPoint)]
  public interface ISchedulerJob
  {
    /// <summary>
    /// Уникальный идентификатор владельца
    /// Если нужно, чтобы планировщик не был в блоке "Системные" необходимо реализовать <seealso cref="T:EleWise.ELMA.Scheduling.ISchedulerTaskOwner" /> и указать его Uid
    /// </summary>
    Guid? OwnerUid { get; }

    /// <summary>Триггер</summary>
    [NotNull]
    ITrigger Trigger { get; }

    /// <summary>Список выполняемых работ</summary>
    [NotNull]
    ICollection<IJob> Jobs { get; }
  }
}
