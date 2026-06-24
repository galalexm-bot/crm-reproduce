// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Scheduling.Managers.SchedulerTaskJobManager
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Util;
using SG9KiyIbtdgGDf12qr;
using System.Collections;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Scheduling.Managers
{
  /// <summary>Менеджер работ задачи планировщика</summary>
  [DeveloperApi(DeveloperApiType.Manager)]
  public class SchedulerTaskJobManager : EntityManager<ISchedulerTaskJob, long>
  {
    private static SchedulerTaskJobManager yD9nlmBTPmTQG2PmcASn;

    /// <summary>
    /// <see cref="T:EleWise.ELMA.Runtime.Db.Migrator.Framework.ITransformationProvider" />
    /// </summary>
    public ITransformationProvider TransformationProvider
    {
      get => this.\u003CTransformationProvider\u003Ek__BackingField;
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
              this.\u003CTransformationProvider\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a != 0 ? 0 : 0;
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

    /// <summary>Удалить работы</summary>
    /// <param name="jobIds">Идентификаторы работ</param>
    [Transaction]
    public virtual void DeleteJobs(long[] jobIds)
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 1:
            object obj = SchedulerTaskJobManager.LbNZjDBTpXeijSIPSFHg((object) this.SessionProvider, (object) "");
            SchedulerTaskJobManager.LAI6vkBTaEDd7Z4UBdXc(obj);
            SchedulerTaskJobManager.sCJg9IBT6LtQgBh9CrmI(SchedulerTaskJobManager.xPGN1OBT48rVdMhEwDxt(obj, (object) string.Format((string) SchedulerTaskJobManager.WTS86yBTDLseZsE6BRAK(-606654180 ^ -606725626), SchedulerTaskJobManager.d1f5cUBTwFGmWywZUFZh(SchedulerTaskJobManager.RF63REBTtbtPFmt1VGdN((object) this.TransformationProvider), SchedulerTaskJobManager.WTS86yBTDLseZsE6BRAK(-1939377524 ^ -1939449380)), (object) ElmaInExpression.ToString((string) SchedulerTaskJobManager.d1f5cUBTwFGmWywZUFZh(SchedulerTaskJobManager.RF63REBTtbtPFmt1VGdN((object) this.TransformationProvider), SchedulerTaskJobManager.WTS86yBTDLseZsE6BRAK(-867826612 ^ -867793646)), (IEnumerable) jobIds, delimiter: (string) SchedulerTaskJobManager.WTS86yBTDLseZsE6BRAK(-2107978722 ^ -2107981724)))), false);
            ((ISession) obj).CleanUpCache(typeof (ISchedulerTaskJob));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 2 : 5;
            continue;
          case 2:
            goto label_4;
          case 3:
            goto label_2;
          case 4:
            if (jobIds == null)
            {
              num = 3;
              continue;
            }
            break;
          case 5:
            goto label_9;
        }
        if (SchedulerTaskJobManager.Uo4y4ABT3D2hsQtYjlMr((object) jobIds))
          num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0 ? 0 : 1;
        else
          goto label_3;
      }
label_4:
      return;
label_2:
      return;
label_9:
      return;
label_3:;
    }

    public SchedulerTaskJobManager()
    {
      SchedulerTaskJobManager.TfiNbkBTHKI6DWmJS9M6();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool OTB1OJBT1hEJkspYq0GX() => SchedulerTaskJobManager.yD9nlmBTPmTQG2PmcASn == null;

    internal static SchedulerTaskJobManager MNl12WBTNcdbUQOtFfdZ() => SchedulerTaskJobManager.yD9nlmBTPmTQG2PmcASn;

    internal static bool Uo4y4ABT3D2hsQtYjlMr([In] object obj0) => ((IEnumerable) obj0).Any();

    internal static object LbNZjDBTpXeijSIPSFHg([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static void LAI6vkBTaEDd7Z4UBdXc([In] object obj0) => ((ISession) obj0).Flush();

    internal static object WTS86yBTDLseZsE6BRAK(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object RF63REBTtbtPFmt1VGdN([In] object obj0) => (object) ((ITransformationProvider) obj0).Dialect;

    internal static object d1f5cUBTwFGmWywZUFZh([In] object obj0, [In] object obj1) => (object) ((Dialect) obj0).QuoteIfNeeded((string) obj1);

    internal static object xPGN1OBT48rVdMhEwDxt([In] object obj0, [In] object obj1) => (object) ((ISession) obj0).CreateSQLQuery((string) obj1);

    internal static int sCJg9IBT6LtQgBh9CrmI([In] object obj0, bool cleanUpCache) => ((IQuery) obj0).ExecuteUpdate(cleanUpCache);

    internal static void TfiNbkBTHKI6DWmJS9M6() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
