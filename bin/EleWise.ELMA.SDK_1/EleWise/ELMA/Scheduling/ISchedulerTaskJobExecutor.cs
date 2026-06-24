// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.ISchedulerTaskJobExecutor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling.Models;
using System;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>
  /// Исполнитель работ планировщика, основанных на модели SchedulerTaskJob
  /// </summary>
  [ExtensionPoint(ComponentType.WebServer)]
  public interface ISchedulerTaskJobExecutor
  {
    /// <summary>Может ли выполнять данный исполнитель данную работу</summary>
    /// <param name="job">Работа</param>
    /// <returns>True, если может</returns>
    bool CanExecute(ISchedulerTaskJob job);

    /// <summary>Выполнить работу задачи планирощика</summary>
    /// <param name="job">Работа</param>
    /// <param name="dateToRun">Дата запуска</param>
    /// <returns>Результат выполнения (или null, если данный исполнитель не выполняет работы данного типа)</returns>
    JobResult Do(ISchedulerTaskJob job, DateTime dateToRun);
  }
}
