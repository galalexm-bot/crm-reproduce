// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Scheduling.ISchedulerActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Scheduling
{
  /// <summary>Интерфейс актора планировщика заданий</summary>
  internal interface ISchedulerActor : IActorWithGuidKey, IActor
  {
    /// <summary>Запустить ядро планировщика</summary>
    Task Start();

    /// <summary>
    /// Запустить триггер с указанным уникальным идентификатором
    /// </summary>
    /// <param name="triggerUid">Уникальный идентифифкатор триггера</param>
    Task RunTrigger(Guid triggerUid);

    /// <summary>Выполнить работу планировщика</summary>
    /// <param name="triggerUid">Уникальный идентификатор триггера работы</param>
    /// <param name="currentDateTime">Дата/время для запуска</param>
    /// <param name="forceRun"><c>true</c> если работу необходимо запустить принудительно</param>
    Task RunSchedulerJob(Guid triggerUid, DateTime currentDateTime, bool forceRun);

    /// <summary>
    /// Выполнить задачу работу планировщика принудительно (не проверяя время по триггеру)
    /// </summary>
    /// <param name="triggerUid">Уникальный идентификатор триггера работы</param>
    /// <param name="jobUid">Уникальный идентификатор задачи</param>
    /// <param name="now">Текущее время</param>
    Task ForceRunJob(Guid triggerUid, Guid jobUid, DateTime? now = null);
  }
}
