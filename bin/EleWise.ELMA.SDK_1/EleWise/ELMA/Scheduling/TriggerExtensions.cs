// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.TriggerExtensions
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scheduling.Managers;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Scheduling
{
  public static class TriggerExtensions
  {
    internal static TriggerExtensions m4LWELBKhYljBYKhiFg2;

    public static DateTime? GetNextTimeAfterUnfolded(
      this ITrigger trigger,
      DateTime? latestDateOfRun,
      DateTime now)
    {
      DateTime? first = new DateTime?();
      try
      {
        first = trigger.GetNextTimeAfter(latestDateOfRun, now);
      }
      catch (Exception ex)
      {
        if (Logger.Log.IsErrorEnabled())
          Logger.Log.Error((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883412172)), ex);
      }
      if (!first.HasValue)
      {
        if (Logger.Log.IsDebugEnabled())
          Logger.Log.Debug((object) EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812095702), (object) trigger));
        return new DateTime?();
      }
      try
      {
        return CollectionExtensions.Unfold<DateTime?>(first, (Func<DateTime?, DateTime?>) (d =>
        {
          DateTime? nextTimeAfter = trigger.GetNextTimeAfter(d, now);
          DateTime? nullable1 = d;
          DateTime? nullable2 = nextTimeAfter;
          if ((nullable1.HasValue & nullable2.HasValue ? (nullable1.GetValueOrDefault() >= nullable2.GetValueOrDefault() ? 1 : 0) : 0) != 0)
            throw new InvalidOperationException(EleWise.ELMA.SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(272623989 ^ 272276001), (object) nextTimeAfter, (object) d));
          return nextTimeAfter;
        }), (Func<DateTime?, bool>) (d => d.HasValue && d.Value <= now)).ToList<DateTime?>().LastOrDefault<DateTime?>((Func<DateTime?, bool>) (d => d.HasValue && d.Value <= now && now - d.Value <= trigger.OvertimeToRun));
      }
      catch (Exception ex)
      {
        Logger.Log.Error((object) string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107911172), (object) trigger.Name, (object) trigger.Id), ex);
        return new DateTime?();
      }
    }

    /// <summary>
    /// Получить таймаут триггера, если он задан, или взять таймаут из системных настроек
    /// </summary>
    /// <param name="trigger">Триггер - вычисляет в какое время должна выполнится работа</param>
    /// <returns>Время таймаута в минутах</returns>
    internal static TimeSpan GetTriggerTimeout(this ITrigger trigger)
    {
      int num1 = 5;
      ITriggerExtension triggerExtension;
      int? jobResultTimeout;
      while (true)
      {
        switch (num1)
        {
          case 1:
            jobResultTimeout = triggerExtension.JobResultTimeout;
            num1 = 6;
            continue;
          case 2:
            goto label_9;
          case 3:
            goto label_14;
          case 4:
            if (triggerExtension != null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0 ? 1 : 1;
              continue;
            }
            goto label_9;
          case 5:
            triggerExtension = trigger as ITriggerExtension;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 4 : 3;
            continue;
          case 6:
            if (!jobResultTimeout.HasValue)
            {
              num1 = 2;
              continue;
            }
            jobResultTimeout = triggerExtension.JobResultTimeout;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0 ? 0 : 0;
            continue;
          case 7:
            goto label_6;
          default:
            if (jobResultTimeout.Value > 0)
            {
              jobResultTimeout = triggerExtension.JobResultTimeout;
              num1 = 3;
              continue;
            }
            num1 = 7;
            continue;
        }
      }
label_6:
      int num2 = 1;
      goto label_15;
label_9:
      return SchedulerJobRunInfoManager.GetJobRunInfoTtl();
label_14:
      num2 = jobResultTimeout.Value;
label_15:
      return TriggerExtensions.LwoQxJBKfq0wTMRFWJ8F((double) num2);
    }

    internal static TimeSpan LwoQxJBKfq0wTMRFWJ8F([In] double obj0) => TimeSpan.FromMinutes(obj0);

    internal static bool ov7OC8BKG6IVNcS2WqIN() => TriggerExtensions.m4LWELBKhYljBYKhiFg2 == null;

    internal static TriggerExtensions cP0jO7BKEkdD5pAbuFyd() => TriggerExtensions.m4LWELBKhYljBYKhiFg2;
  }
}
