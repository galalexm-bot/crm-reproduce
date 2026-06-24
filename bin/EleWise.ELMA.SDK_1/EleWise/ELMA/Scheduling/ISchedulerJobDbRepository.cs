// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.ISchedulerJobDbRepository
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Scheduling.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>
  /// Интерфейс репозитория работ планировщика, хранящихся в БД
  /// </summary>
  internal interface ISchedulerJobDbRepository : ISchedulerJobRepository
  {
    /// <summary>Создать задачу для исполнения планировщиком</summary>
    /// <param name="task">Задача планировщика</param>
    /// <param name="customExecuteTime">Запланированое время исполнения</param>
    /// <returns>Запланированная работы планировщика</returns>
    ISchedulerJob CreateSchedulerJob(ISchedulerTask task, DateTime? customExecuteTime = null);

    /// <summary>
    /// Получить список одиночных задач и зарезервировать их для выполнения
    /// </summary>
    /// <returns>Список одиночных задач</returns>
    ICollection<ISchedulerJob> GetOnceSchedulerJobs();

    /// <summary>Получить список запланированных задач</summary>
    /// <param name="dateTimeToRun">Дата/время для запуска</param>
    /// <returns>Коллекцию запланированных работ планировщика</returns>
    Task<ICollection<ISchedulerJob>> GetSchedulerJobs(DateTime dateTimeToRun);
  }
}
