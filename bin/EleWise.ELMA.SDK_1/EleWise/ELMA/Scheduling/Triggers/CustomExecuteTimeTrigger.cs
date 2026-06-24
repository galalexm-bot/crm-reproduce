// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Triggers.CustomExecuteTimeTrigger
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Extensions;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Scheduling.Triggers
{
  /// <summary>Триггер с заданным вручную временем исполнения</summary>
  public class CustomExecuteTimeTrigger : ITriggerExtension, ITrigger
  {
    private TimeSpan overtimeToRun;
    private ITrigger baseTrigger;
    private DateTime executeTime;
    internal static CustomExecuteTimeTrigger ahLDjoBXu4rFAnTFRniq;

    /// <summary>Ctor</summary>
    /// <param name="baseTrigger">Базовый триггер</param>
    /// <param name="executeTime">Время исполнения</param>
    public CustomExecuteTimeTrigger(ITrigger baseTrigger, DateTime executeTime)
    {
      CustomExecuteTimeTrigger.gKVr8iBXSYhQQrYV0VM5();
      this.overtimeToRun = TimeSpan.FromMinutes(2.0);
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            this.executeTime = CustomExecuteTimeTrigger.Jb61tkBXiHAhHsgGcGkb(executeTime);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
            continue;
          case 2:
            this.baseTrigger = baseTrigger;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Название триггера</summary>
    public string Name => (string) CustomExecuteTimeTrigger.dLCgEjBXRMnhGCTxIuXH((object) this.baseTrigger);

    /// <summary>Уникальный идентификатор триггера</summary>
    public Guid Id => CustomExecuteTimeTrigger.k5QQ9aBXqTrc1u5rVZcH((object) this.baseTrigger);

    /// <summary>Базовый триггер</summary>
    public ITrigger BaseTrigger => this.baseTrigger;

    /// <summary>Получить следующую дату выполнения</summary>
    /// <param name="dateTime">Время последнего запуска</param>
    /// <param name="now">Текущее время</param>
    /// <returns></returns>
    public DateTime? GetNextTimeAfter(DateTime? dateTime, DateTime now) => dateTime.HasValue && !(dateTime.Value < this.executeTime) ? new DateTime?() : new DateTime?(this.executeTime);

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
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 != 0 ? 0 : 0;
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

    /// <summary>
    /// Интервал, после истечения которого задача считается неактивной
    /// </summary>
    public int? JobResultTimeout => new int?(this.overtimeToRun.Minutes);

    internal static void gKVr8iBXSYhQQrYV0VM5() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static DateTime Jb61tkBXiHAhHsgGcGkb(DateTime dateTime) => dateTime.GetDateTimeWithoutMilliseconds();

    internal static bool gQBIXYBXIMs3mjBS0Nux() => CustomExecuteTimeTrigger.ahLDjoBXu4rFAnTFRniq == null;

    internal static CustomExecuteTimeTrigger x2JDfyBXVdeNr7fNLt8Y() => CustomExecuteTimeTrigger.ahLDjoBXu4rFAnTFRniq;

    internal static object dLCgEjBXRMnhGCTxIuXH([In] object obj0) => (object) ((ITrigger) obj0).Name;

    internal static Guid k5QQ9aBXqTrc1u5rVZcH([In] object obj0) => ((ITrigger) obj0).Id;
  }
}
