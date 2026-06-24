// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Managers.ISchedulerJobRunInfoManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Scheduling.Models;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.Scheduling.Managers
{
  /// <summary>
  /// Интерфейс менеджера информации о запуске работы планировщика
  /// </summary>
  public interface ISchedulerJobRunInfoManager : 
    IEntityManager<ISchedulerJobRunInfo, long>,
    IEntityManager<ISchedulerJobRunInfo>,
    IEntityManager
  {
    /// <summary>Получить последнюю дату запуска триггера</summary>
    /// <param name="trigger">Триггер</param>
    /// <returns>Дата запуска (или <c>null</c>, если триггер еще не запускался)</returns>
    DateTime? GetLastRun(ITrigger trigger);

    /// <summary>Получить последнюю дату запуска триггера для работы</summary>
    /// <param name="trigger">Триггер</param>
    /// <param name="jobId">Идентификатор работы</param>
    /// <returns>Дата запуска (или <c>null</c>, если триггер еще не запускался)</returns>
    DateTime? GetLastRun(ITrigger trigger, Guid jobId);

    /// <summary>Получить информацию о последнем запуске триггера</summary>
    /// <param name="trigger">Триггер</param>
    /// <param name="onlyFinished">Выбирать информацию только о завершившемся запуске</param>
    /// <returns>Информация о последнем запуске триггера (или <c>null</c>, если триггер еще не запускался)</returns>
    ISchedulerJobRunInfo GetLastRunInfo(ITrigger trigger, bool onlyFinished);

    /// <summary>Получить информацию о последнем запуске триггера</summary>
    /// <param name="trigger">Триггер</param>
    /// <param name="jobId">Идентификатор работы</param>
    /// <param name="onlyFinished">Выбирать информацию только о завершившемся запуске</param>
    /// <returns>Информация о последнем запуске триггера (или <c>null</c>, если триггер еще не запускался)</returns>
    ISchedulerJobRunInfo GetLastRunInfo(ITrigger trigger, Guid jobId, bool onlyFinished);

    /// <summary>Получить информацию о последнем запуске триггера</summary>
    /// <param name="triggerId">Идентификатор триггера</param>
    /// <param name="jobId">Идентификатор работы</param>
    /// <param name="onlyFinished">Выбирать информацию только о завершившемся запуске</param>
    /// <returns>Информация о последнем запуске триггера (или <c>null</c>, если триггер еще не запускался)</returns>
    ISchedulerJobRunInfo GetLastRunInfo(Guid triggerId, Guid jobId, bool onlyFinished);

    /// <summary>Получить список истории о последних запусках триггера</summary>
    /// <param name="triggerId">Идентификатор триггера</param>
    /// <param name="jobId">Идентификатор работы</param>
    /// <param name="onlyFinished">Выбирать информацию только о завершившемся запуске</param>
    /// <returns>Информация о последнем запуске триггера (или <c>null</c>, если триггер еще не запускался)</returns>
    IList<ISchedulerJobRunInfo> GetLastRunInfos(Guid triggerId, Guid jobId, bool onlyFinished);

    /// <summary>
    /// Получить список истории о последних запусках триггеров
    /// </summary>
    /// <param name="triggerIds">Идентификатор триггера</param>
    /// <param name="onlyFinished">Выбирать информацию только о завершившемся запуске</param>
    /// <returns>Информация о последних запусках триггеров</returns>
    IList<ISchedulerJobRunInfo> GetLastRunInfos(IEnumerable<Guid> triggerIds, bool onlyFinished);

    /// <summary>Получить статус выполнения работы</summary>
    /// <param name="trigger">Триггер</param>
    /// <param name="job">Работа</param>
    /// <param name="dateToRun">Дата запуска</param>
    /// <returns>Статус задачи</returns>
    JobStatus GetStatus(ITrigger trigger, IJob job, DateTime dateToRun);

    /// <summary>Получить информацию по запуску</summary>
    /// <param name="trigger">Триггер</param>
    /// <param name="job">Работа</param>
    /// <param name="dateToRun">Время запуска по расписанию</param>
    /// <returns>Информация по запуску или null</returns>
    ISchedulerJobRunInfo Get(ITrigger trigger, IJob job, DateTime dateToRun);

    /// <summary>Изменить результат выполнения работы</summary>
    /// <param name="trigger">Триггер</param>
    /// <param name="job">Работа</param>
    /// <param name="dateToRun">Время запуска по расписанию</param>
    /// <param name="result">Результат</param>
    ISchedulerJobRunInfo SetResult(
      ITrigger trigger,
      IJob job,
      DateTime dateToRun,
      JobResult result);

    /// <summary>Изменить результат выполнения работы</summary>
    /// <param name="trigger">Триггер</param>
    /// <param name="job">Работа</param>
    /// <param name="dateToRun">Время запуска по расписанию</param>
    /// <param name="actualStartDate">Актуальное время запуска</param>
    /// <param name="result">Результат</param>
    ISchedulerJobRunInfo SetResult(
      ITrigger trigger,
      IJob job,
      DateTime dateToRun,
      DateTime? actualStartDate,
      JobResult result);

    /// <summary>Установить статус начала запуска задач</summary>
    /// <param name="trigger">Триггер</param>
    /// <param name="jobs">Список работ</param>
    /// <param name="dateToRun">Время запуска по расписанию</param>
    /// <returns><c>true</c> если статус установлен</returns>
    bool SetPending(ITrigger trigger, ICollection<IJob> jobs, DateTime dateToRun);

    /// <summary>Отменить начало запуска задач</summary>
    /// <param name="trigger">Триггер</param>
    /// <param name="jobs">Список работ</param>
    /// <param name="dateToRun">Время запуска по расписанию</param>
    void CancelPending(ITrigger trigger, ICollection<IJob> jobs, DateTime dateToRun);
  }
}
