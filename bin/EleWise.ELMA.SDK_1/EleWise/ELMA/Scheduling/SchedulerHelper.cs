// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.SchedulerHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime;
using EleWise.ELMA.Scheduling.Managers;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Scheduling.Triggers;
using System;

namespace EleWise.ELMA.Scheduling
{
  /// <summary>Вспомогательные методы для работы планировщика</summary>
  internal static class SchedulerHelper
  {
    /// <summary>Получить дату/время для начала работы</summary>
    /// <param name="trigger">Триггер</param>
    /// <param name="dateTime">Текущая дата/время</param>
    /// <param name="schedulerJobRunInfoManager">Менеджер инфомрации о запуске работы планировщика</param>
    /// <param name="runtimeApplication">Среда исполнения приложения</param>
    /// <returns>Дата/время начала работы</returns>
    public static DateTime? GetDateTimeToRun(
      ITrigger trigger,
      DateTime dateTime,
      ISchedulerJobRunInfoManager schedulerJobRunInfoManager,
      IRuntimeApplication runtimeApplication)
    {
      ISchedulerJobRunInfo lastRunInfo = schedulerJobRunInfoManager.GetLastRunInfo(trigger, false);
      if (lastRunInfo != null && (lastRunInfo.Status == JobStatus.Pending || lastRunInfo.Status == JobStatus.Working) && (lastRunInfo.ConnectionUid == Guid.Empty || !runtimeApplication.IsConnectionAlive(lastRunInfo.ConnectionUid) || dateTime > lastRunInfo.StatusUpdateDate.Add(trigger.GetTriggerTimeout())))
        lastRunInfo = schedulerJobRunInfoManager.GetLastRunInfo(trigger, true);
      if (lastRunInfo != null && (lastRunInfo.Status == JobStatus.Pending || lastRunInfo.Status == JobStatus.Pending))
        return new DateTime?();
      DateTime? dateToRun = lastRunInfo?.DateToRun;
      return !(trigger is OnceExecuteTrigger) ? trigger.GetNextTimeAfterUnfolded(dateToRun, dateTime) : trigger.GetNextTimeAfter(dateToRun, dateTime);
    }
  }
}
