// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.ActorModel.Scheduling.ISchedulerJobActor
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.ActorModel.Scheduling
{
  /// <summary>
  /// Интерфейс актора-исполнителя работы планировщика заданий
  /// </summary>
  [FeatureFlagManaged("Scheduler.Actors.Enabled", true)]
  internal interface ISchedulerJobActor : IActorWithGuidCompoundKey, IActor
  {
    /// <summary>Запустить работу на исполнение</summary>
    Task Run();

    /// <summary>
    /// Принудительно запустить выполнение задачи из запланированной работы
    /// </summary>
    /// <param name="jobUid">Уникальный индентификатор работы</param>
    /// <param name="now">Текущее время</param>
    /// <remarks>
    /// Если <paramref name="jobUid" /> не указан, то принудительно запускаются
    /// на выполнение все задачи из запланированной работы планировщика
    /// </remarks>
    Task ForceRunJob(Guid? jobUid = null, DateTime? now = null);
  }
}
