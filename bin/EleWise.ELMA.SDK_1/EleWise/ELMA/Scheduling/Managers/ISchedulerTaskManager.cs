// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Managers.ISchedulerTaskManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Scheduling.Models;
using System.Collections.Generic;

namespace EleWise.ELMA.Scheduling.Managers
{
  /// <summary>Интерфейс менеджера задач планировщика</summary>
  public interface ISchedulerTaskManager : 
    IEntityManager<ISchedulerTask, long>,
    IEntityManager<ISchedulerTask>,
    IEntityManager
  {
    /// <summary>Найти задачи для исполнения в данный момент</summary>
    /// <returns>Задачи планировщика</returns>
    IEnumerable<ISchedulerTask> FindTasksToExecute();

    /// <summary>
    /// Найти периодические задачи для исполнения в данный момент
    /// </summary>
    /// <returns>Задачи планировщика</returns>
    IEnumerable<ISchedulerTask> FindPeriodicTasksToExecute();

    /// <summary>Найти разовые задачи для исполнения в данный момент</summary>
    /// <returns>Задачи планировщика</returns>
    IEnumerable<ISchedulerTask> FindOnceExecuteTasksToExecute();

    /// <summary>Выполнить задачу планировщика</summary>
    /// <param name="task">Задача планировщика</param>
    void ExecuteTask(ISchedulerTask task);

    /// <summary>Удалить задачу и её работы</summary>
    /// <param name="task">Задача</param>
    /// <param name="excludeJobs">Идентификаторы работы, которые надо исключить из удаления</param>
    void DeleteTaskAndJobs(ISchedulerTask task, IEnumerable<long> excludeJobs);
  }
}
