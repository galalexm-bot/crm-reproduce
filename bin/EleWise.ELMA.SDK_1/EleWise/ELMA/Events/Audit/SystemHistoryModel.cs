// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Events.Audit.SystemHistoryModel
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Security;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Dynamic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Events.Audit
{
  /// <summary>
  /// Модель для элемента отображения системных сообщений в истории работы с объектом
  /// </summary>
  public sealed class SystemHistoryModel : IHistoryBaseModel
  {
    private readonly EntityActionEventArgs _originalEvent;
    private readonly IUser _originalAuthor;
    private readonly object _eventData;
    private static SystemHistoryModel QRLkn5GUzZDCnnw7lroG;

    internal SystemHistoryModel([NotNull] EntityActionEventArgs originalEvent, string actionTheme)
    {
      SystemHistoryModel.G8GSXSGsWkaTjnRXfCxC();
      this._eventData = (object) new ExpandoObject();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 7;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.ActionDate = SystemHistoryModel.fpexoGGsGdoOwRXmyK7E((object) originalEvent);
            num = 3;
            continue;
          case 2:
            goto label_6;
          case 3:
            this._originalAuthor = (IUser) SystemHistoryModel.TvqF3pGsETOpnEqiRCsp((object) originalEvent);
            num = 2;
            continue;
          case 4:
            this._originalEvent = originalEvent;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 6 : 6;
            continue;
          case 5:
            this.AuditObject = (IAuditObject) SystemHistoryModel.NyZCpmGshACrCfsCIeBu((object) originalEvent);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 0 : 1;
            continue;
          case 6:
            this.ActionTheme = actionTheme;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 8 : 8;
            continue;
          case 7:
            if (originalEvent != null)
            {
              num = 4;
              continue;
            }
            goto label_3;
          case 8:
            this.AuditAction = (IAuditAction) SystemHistoryModel.j1hPZEGsbsTrW8H2eeDG((object) originalEvent);
            num = 5;
            continue;
          default:
            goto label_3;
        }
      }
label_6:
      return;
label_3:
      throw new ArgumentNullException((string) SystemHistoryModel.OqDNcjGsoIk0BJsPUx72(--1418440330 ^ 1418703784));
    }

    public IUser OriginalAuthor => this._originalAuthor;

    public EntityActionEventArgs OriginalEvent => this._originalEvent;

    public DateTime ActionDate
    {
      get => this.\u003CActionDate\u003Ek__BackingField;
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
              this.\u003CActionDate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
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

    public IUser ActionAuthor
    {
      get => this.\u003CActionAuthor\u003Ek__BackingField;
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
              this.\u003CActionAuthor\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 0 : 0;
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

    public string ActionTheme
    {
      get => this.\u003CActionTheme\u003Ek__BackingField;
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
              this.\u003CActionTheme\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
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

    public IAuditAction AuditAction
    {
      get => this.\u003CAuditAction\u003Ek__BackingField;
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
              this.\u003CAuditAction\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b == 0 ? 0 : 0;
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

    public IAuditObject AuditObject
    {
      get => this.\u003CAuditObject\u003Ek__BackingField;
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
              this.\u003CAuditObject\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0 ? 0 : 0;
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
    /// Динамический объект, по умолчанию инициализируется классом <see cref="T:System.Dynamic.ExpandoObject" />
    /// </summary>
    public object EventData => this._eventData;

    internal static void G8GSXSGsWkaTjnRXfCxC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object OqDNcjGsoIk0BJsPUx72(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object j1hPZEGsbsTrW8H2eeDG([In] object obj0) => (object) ((AuditEventArgs) obj0).Action;

    internal static object NyZCpmGshACrCfsCIeBu([In] object obj0) => (object) ((AuditEventArgs) obj0).Object;

    internal static DateTime fpexoGGsGdoOwRXmyK7E([In] object obj0) => ((EntityActionEventArgs) obj0).ActionDate;

    internal static object TvqF3pGsETOpnEqiRCsp([In] object obj0) => (object) ((EntityActionEventArgs) obj0).ActionAuthor;

    internal static bool VIwILLGsFqkdjMvxVoFm() => SystemHistoryModel.QRLkn5GUzZDCnnw7lroG == null;

    internal static SystemHistoryModel QNZDvSGsBrP7KdIIcM86() => SystemHistoryModel.QRLkn5GUzZDCnnw7lroG;
  }
}
