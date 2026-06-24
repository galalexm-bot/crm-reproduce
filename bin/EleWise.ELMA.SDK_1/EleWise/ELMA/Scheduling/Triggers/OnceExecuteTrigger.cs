// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Triggers.OnceExecuteTrigger
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Scheduling.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.Scheduling.Triggers
{
  /// <summary>Триггер с одиночным выполнением</summary>
  public class OnceExecuteTrigger : ITriggerExtension, ITrigger
  {
    private TimeSpan overtimeToRun;
    private readonly DateTime executeTime;
    private Func<ISchedulerTask> _taskAccessor;
    internal static OnceExecuteTrigger jlmy2HBXeMHcdmXbqs2u;

    /// <summary>Ctor</summary>
    /// <param name="task">Задача планировщика</param>
    public OnceExecuteTrigger([NotNull] ISchedulerTask task)
    {
      OnceExecuteTrigger.H0DeQ5BXN0jlgcGIW6wd();
      // ISSUE: explicit constructor call
      this.\u002Ector((Func<ISchedulerTask>) (() => task));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Ctor</summary>
    /// <param name="taskAccessor">Функция, возвращающая задачу планировщика</param>
    public OnceExecuteTrigger([NotNull] Func<ISchedulerTask> taskAccessor)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      this.overtimeToRun = TimeSpan.MaxValue;
      // ISSUE: explicit constructor call
      base.\u002Ector();
      this._taskAccessor = taskAccessor != null ? taskAccessor : throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(236071375 ^ 236129399));
      ISchedulerTask schedulerTask = taskAccessor();
      DateTime? nullable = schedulerTask != null ? schedulerTask.OnceExecuteTime : throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~538519529 ^ -538444350));
      nullable = nullable.HasValue ? schedulerTask.OnceExecuteTime : throw new ArgumentException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(979449278 ^ 979374158));
      this.executeTime = nullable.Value;
    }

    /// <summary>Название триггера</summary>
    public string Name
    {
      get => this.\u003CName\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CName\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Уникальный идентификатор триггера</summary>
    public Guid Id
    {
      get => this.\u003CId\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>Получить следующую дату выполнения</summary>
    /// <param name="dateTime">Время последнего запуска</param>
    /// <param name="now">Текущее время</param>
    /// <returns></returns>
    public DateTime? GetNextTimeAfter(DateTime? dateTime, DateTime now) => dateTime.HasValue ? new DateTime?() : new DateTime?(this.executeTime);

    public TimeSpan OvertimeToRun
    {
      get => this.overtimeToRun;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.overtimeToRun = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    internal ISchedulerTask Task
    {
      get
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              if (this._taskAccessor != null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0 ? 0 : 0;
                continue;
              }
              goto label_4;
            case 2:
              goto label_4;
            default:
              goto label_5;
          }
        }
label_4:
        return (ISchedulerTask) null;
label_5:
        return this._taskAccessor();
      }
    }

    /// <summary>
    /// Интервал, после истечения которого задача считается неактивной
    /// </summary>
    public int? JobResultTimeout => new int?();

    internal static void H0DeQ5BXN0jlgcGIW6wd() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool cspBiABXPLvkxrIogIP5() => OnceExecuteTrigger.jlmy2HBXeMHcdmXbqs2u == null;

    internal static OnceExecuteTrigger vhntu6BX1CEoMMapFdqa() => OnceExecuteTrigger.jlmy2HBXeMHcdmXbqs2u;
  }
}
