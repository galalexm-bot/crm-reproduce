// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Glimpse.GlimpseHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using Glimpse.Core.Extensibility;
using Glimpse.Core.Framework;
using Glimpse.Core.Message;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Web;

namespace EleWise.ELMA.Diagnostics.Glimpse
{
  /// <summary>Хелпер для работы с Glimpse</summary>
  internal sealed class GlimpseHelper
  {
    public static readonly TimelineCategoryItem FindViewTimelineCategoryItem;
    public static readonly TimelineCategoryItem MethodTimelineCategoryItem;
    public static readonly TimelineCategoryItem MessagePoinTimelineCategoryItem;
    private static List<IGlimpseMessagesMaker> _messagesMakers;
    internal static GlimpseHelper cogSn1EiNrmxIZCdq0Lr;

    /// <summary>Включен?</summary>
    internal static bool IsEnabled
    {
      get
      {
        int num = 3;
        IGlimpseConfiguration currentConfiguration;
        RuntimePolicy runtimePolicy;
        while (true)
        {
          switch (num)
          {
            case 1:
              goto label_2;
            case 2:
              if (currentConfiguration != null)
              {
                runtimePolicy = currentConfiguration.RuntimePolicyStrategy();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 0;
                continue;
              }
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_16c894429d6244cc9f83b8d6eb99434f != 0 ? 0 : 1;
              continue;
            case 3:
              currentConfiguration = GlimpseHelper.GetCurrentConfiguration();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0 ? 1 : 2;
              continue;
            default:
              goto label_7;
          }
        }
label_2:
        return false;
label_7:
        return !runtimePolicy.HasFlag((Enum) RuntimePolicy.Off);
      }
    }

    /// <summary>Получить текущую конфигурацию</summary>
    /// <returns></returns>
    internal static IGlimpseConfiguration GetCurrentConfiguration()
    {
      int num = 7;
      GlimpseRuntime glimpseRuntime;
      while (true)
      {
        CallContextInfo callContextInfo;
        switch (num)
        {
          case 1:
            if (glimpseRuntime == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 5 : 2;
              continue;
            }
            goto label_2;
          case 2:
            if (!GlimpseHelper.CheckCurrentUser(callContextInfo.UserName))
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 8 : 7;
              continue;
            }
            break;
          case 3:
            if (callContextInfo == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0 ? 2 : 4;
              continue;
            }
            goto case 2;
          case 4:
          case 8:
            goto label_7;
          case 5:
            goto label_3;
          case 6:
            if (DiagnosticsManager.Enabled)
            {
              num = 9;
              continue;
            }
            break;
          case 7:
            if (GlimpseHelper.v1Hue8EiaCPgEbPusUnZ() != null)
            {
              num = 6;
              continue;
            }
            goto label_3;
          case 9:
            callContextInfo = (CallContextInfo) GlimpseHelper.Dn66FsEitLaa7GitYHum(GlimpseHelper.nlMuPGEiDEeGmUNlUBg3());
            num = 3;
            continue;
          default:
            goto label_2;
        }
        glimpseRuntime = GlimpseHelper.InaPCbEi6lZm5YEePqh8(GlimpseHelper.lokxegEiwuxS94vIWdLP(GlimpseHelper.v1Hue8EiaCPgEbPusUnZ()), GlimpseHelper.lssbJwEi4BD1b1IyaxMW(-1598106783 - -968262081 ^ -630127038)) as GlimpseRuntime;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 0 : 1;
      }
label_2:
      return (IGlimpseConfiguration) GlimpseHelper.EucDSUEiHwvoe6NwEy8o((object) glimpseRuntime);
label_3:
      return (IGlimpseConfiguration) null;
label_7:
      return (IGlimpseConfiguration) null;
    }

    /// <summary>
    /// Проверяет разрешено ли текущему пользователю работать с Glimpse
    /// </summary>
    /// <returns></returns>
    internal static bool AllowCurrentUser()
    {
      int num = 5;
      bool? nullable1;
      bool? nullable2;
      while (true)
      {
        switch (num)
        {
          case 1:
            GlimpseHelper.AllowCurrentUserCtx(nullable1);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 2 : 1;
            continue;
          case 2:
            goto label_9;
          case 3:
            nullable1 = GlimpseHelper.AllowCurrentUserCtx(nullable2);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 != 0 ? 0 : 0;
            continue;
          case 4:
            goto label_4;
          case 5:
            if (HttpContext.Current != null)
            {
              nullable2 = new bool?();
              num = 3;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_24c4d95e07c94a449594142b78a5da65 != 0 ? 4 : 2;
            continue;
          case 6:
            goto label_10;
          default:
            if (nullable1.HasValue)
            {
              num = 6;
              continue;
            }
            nullable1 = new bool?(GlimpseHelper.CheckCurrentUser());
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 1 : 1;
            continue;
        }
      }
label_4:
      return false;
label_9:
      return nullable1.Value;
label_10:
      return nullable1.Value;
    }

    /// <summary>Проверить текущего пользователя</summary>
    /// <returns></returns>
    private static bool CheckCurrentUser(string name = null)
    {
      int num1 = 10;
      string name1;
      string[] source;
      while (true)
      {
        int num2 = num1;
        string setting;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (GlimpseHelper.H7B4NGEimaiYtD8GqCCA((object) ((HttpContext) GlimpseHelper.v1Hue8EiaCPgEbPusUnZ()).Request))
              {
                num2 = 3;
                continue;
              }
              goto label_3;
            case 2:
              goto label_24;
            case 3:
              if (((HttpContext) GlimpseHelper.v1Hue8EiaCPgEbPusUnZ()).User != null)
              {
                num2 = 14;
                continue;
              }
              goto label_3;
            case 4:
              if (GlimpseHelper.DrIGaAEi7plbWfXJNECB((object) setting))
              {
                num2 = 8;
                continue;
              }
              if (GlimpseHelper.HGxkOCEix9lvAtRp0iIK((object) setting, GlimpseHelper.lssbJwEi4BD1b1IyaxMW(1021410165 ^ 1021389093)))
              {
                num2 = 11;
                continue;
              }
              source = (string[]) GlimpseHelper.JVU4rlEi07UGCp8u1FBm((object) setting, (object) new char[1]
              {
                ','
              }, StringSplitOptions.RemoveEmptyEntries);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 2 : 6;
              continue;
            case 5:
              goto label_27;
            case 6:
              if (GlimpseHelper.DrIGaAEi7plbWfXJNECB((object) name))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 != 0 ? 1 : 1;
                continue;
              }
              goto label_24;
            case 7:
              goto label_4;
            case 8:
              goto label_15;
            case 9:
              goto label_13;
            case 10:
              if (!GlimpseHelper.Dpo2bHEiAEuaWANtOtqG())
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 9 : 9;
                continue;
              }
              setting = EleWise.ELMA.SR.GetSetting((string) GlimpseHelper.lssbJwEi4BD1b1IyaxMW(694673736 ^ -23604109 ^ -671848769));
              num2 = 4;
              continue;
            case 11:
              goto label_22;
            case 12:
              goto label_28;
            case 13:
              if (GlimpseHelper.DrIGaAEi7plbWfXJNECB((object) name1))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 12 : 0;
                continue;
              }
              goto label_27;
            case 14:
              if (GlimpseHelper.LasebWEiM8hYQGlTEXmK(GlimpseHelper.eVNahJEiyosG7IDZxRlZ(GlimpseHelper.v1Hue8EiaCPgEbPusUnZ())) != null)
              {
                num2 = 7;
                continue;
              }
              goto label_3;
            default:
              goto label_3;
          }
        }
label_4:
        name1 = ((IIdentity) GlimpseHelper.LasebWEiM8hYQGlTEXmK(GlimpseHelper.eVNahJEiyosG7IDZxRlZ((object) HttpContext.Current))).Name;
        num1 = 13;
      }
label_3:
      return false;
label_13:
      return false;
label_15:
      return false;
label_22:
      return true;
label_24:
      return ((IEnumerable<string>) source).Contains<string>(name);
label_27:
      return ((IEnumerable<string>) source).Contains<string>(name1);
label_28:
      return false;
    }

    /// <summary>
    /// Получить список пользователей, которым разрешен доступ, из контекста Web-запроса
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    private static bool? AllowCurrentUserCtx(bool? value = null)
    {
      if (!value.HasValue)
        return (bool?) HttpContext.Current.Items[(object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97696798)];
      HttpContext.Current.Items[(object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2092274397 << 4 ^ 883065220)] = (object) value;
      return value;
    }

    /// <summary>Отправить сообщение в Glimpse</summary>
    /// <param name="message">Сообщение</param>
    internal static void PublishMessage(object message)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        IGlimpseConfiguration glimpseConfiguration;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_7;
            case 2:
              goto label_3;
            case 3:
              if (glimpseConfiguration == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 == 0 ? 2 : 2;
                continue;
              }
              break;
            case 4:
              goto label_4;
          }
          ((IMessageBroker) GlimpseHelper.TZURjJEi9Xk9brVM930Z((object) glimpseConfiguration)).Publish<object>(message);
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 1 : 0;
        }
label_4:
        glimpseConfiguration = (IGlimpseConfiguration) GlimpseHelper.XOSI5rEiJP1uhw69N1SF();
        num1 = 3;
      }
label_7:
      return;
label_3:;
    }

    /// <summary>Обработать событие диагностики</summary>
    /// <param name="event">Событие</param>
    public void OnDiagnosticEvent(DiagnosticsEvent @event)
    {
      int num = 7;
      IGlimpseMessagesMaker glimpseMessagesMaker;
      IDiagnosticsCallInfoEvent diagnosticsCallInfoEvent;
      DiagnosticsEvent event1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_16;
          case 1:
            if (!GlimpseHelper.KYYMt8EidBNdadN7AA7v())
            {
              num = 13;
              continue;
            }
            goto case 10;
          case 2:
            if (glimpseMessagesMaker == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 3 : 5;
              continue;
            }
            ((IEnumerable<object>) GlimpseHelper.GwhF3nERBy8EGh9Fr1LT((object) glimpseMessagesMaker, (object) event1)).ForEach<object>(new Action<object>(GlimpseHelper.PublishMessage));
            num = 4;
            continue;
          case 3:
            goto label_9;
          case 4:
            goto label_6;
          case 5:
            diagnosticsCallInfoEvent = event1 as IDiagnosticsCallInfoEvent;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0 ? 6 : 9;
            continue;
          case 6:
            event1 = @event;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0 ? 1 : 0;
            continue;
          case 7:
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0 ? 4 : 6;
            continue;
          case 8:
            goto label_10;
          case 9:
            if (diagnosticsCallInfoEvent == null)
            {
              num = 3;
              continue;
            }
            goto case 11;
          case 10:
            if (event1 != null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93e237849fe9450198ccc24b28d87fd7 != 0 ? 2 : 12;
              continue;
            }
            goto label_5;
          case 11:
            BaseMessage baseMessage = new BaseMessage();
            GlimpseHelper.iP4HZHEigZ9qUbV30i90((object) baseMessage, GlimpseHelper.k2EdAqEirBnFG0CIgV6a(GlimpseHelper.jQug0wEileZyTQ99qWf3((object) diagnosticsCallInfoEvent)));
            GlimpseHelper.dG5yidEiLDdtM11s43Mn((object) baseMessage, GlimpseHelper.bgbEM4EiYK9bll1S1Ips(((AbstractCallInfo) GlimpseHelper.jQug0wEileZyTQ99qWf3((object) diagnosticsCallInfoEvent)).StartTime, GlimpseHelper.lLjfZmEijSdKbZdE8GfR(GlimpseHelper.YOOGkHEi5bimoAdVCiQJ(GlimpseHelper.jQug0wEileZyTQ99qWf3((object) diagnosticsCallInfoEvent)))));
            GlimpseHelper.rayiKkEisB7L6BcouLEq((object) baseMessage, GlimpseHelper.bQdl36EiUpJPahMdjv1V(GlimpseHelper.jQug0wEileZyTQ99qWf3((object) diagnosticsCallInfoEvent)));
            baseMessage.EventName = ((AbstractCallInfo) GlimpseHelper.jQug0wEileZyTQ99qWf3((object) diagnosticsCallInfoEvent)).Description;
            GlimpseHelper.F5L4eYEizVnqvBkTB4sH((object) baseMessage, (object) new TimelineCategoryItem((string) GlimpseHelper.NHdPEpEicNDqwcY4Bl2b((object) diagnosticsCallInfoEvent.Info), (string) GlimpseHelper.lssbJwEi4BD1b1IyaxMW(-1852837372 ^ -1853120028), (string) GlimpseHelper.lssbJwEi4BD1b1IyaxMW(-1837662597 ^ -1837945463)));
            GlimpseHelper.t24vXpERFroFBeU5WMfL((object) baseMessage);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 12:
            // ISSUE: reference to a compiler-generated method
            glimpseMessagesMaker = this.MessageMakers.FirstOrDefault<IGlimpseMessagesMaker>((Func<IGlimpseMessagesMaker, bool>) (m => GlimpseHelper.\u003C\u003Ec__DisplayClass10_0.aKxhJa8XGtUIc8acG4bG((object) m, (object) event1)));
            num = 2;
            continue;
          case 13:
            goto label_2;
          default:
            goto label_22;
        }
      }
label_16:
      return;
label_9:
      return;
label_6:
      return;
label_10:
      return;
label_2:
      return;
label_22:
      return;
label_5:;
    }

    private IList<IGlimpseMessagesMaker> MessageMakers => (IList<IGlimpseMessagesMaker>) GlimpseHelper._messagesMakers ?? (IList<IGlimpseMessagesMaker>) (GlimpseHelper._messagesMakers = ComponentManager.Current.GetExtensionPoints<IGlimpseMessagesMaker>().ToList<IGlimpseMessagesMaker>());

    public GlimpseHelper()
    {
      GlimpseHelper.c5qE2vERWiZLvff77FLA();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static GlimpseHelper()
    {
      int num = 4;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            GlimpseHelper.MethodTimelineCategoryItem = new TimelineCategoryItem((string) GlimpseHelper.lssbJwEi4BD1b1IyaxMW(-1487388570 ^ -1487119004), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822641616), (string) GlimpseHelper.lssbJwEi4BD1b1IyaxMW(-1445902765 ^ -1980277732 ^ 539119221));
            num = 2;
            continue;
          case 2:
            GlimpseHelper.MessagePoinTimelineCategoryItem = new TimelineCategoryItem((string) GlimpseHelper.lssbJwEi4BD1b1IyaxMW(712480695 ^ 712229883), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-53329496 >> 4 ^ -3575744), (string) GlimpseHelper.lssbJwEi4BD1b1IyaxMW(87862435 ^ 87619791));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c == 0 ? 0 : 0;
            continue;
          case 3:
            GlimpseHelper.FindViewTimelineCategoryItem = new TimelineCategoryItem(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -36011215), (string) GlimpseHelper.lssbJwEi4BD1b1IyaxMW(272623989 ^ 272350577), z2jc63fLkugS1X8Q9N.tE1kD1vbB(92412609 - 1050237057 ^ -957573546));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0 ? 1 : 1;
            continue;
          case 4:
            GlimpseHelper.c5qE2vERWiZLvff77FLA();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 3;
            continue;
          default:
            goto label_7;
        }
      }
label_2:
      return;
label_7:;
    }

    internal static bool GcKFgdEi3LqPMrZIjh8d() => GlimpseHelper.cogSn1EiNrmxIZCdq0Lr == null;

    internal static GlimpseHelper cfk4IMEiptZm7iF4giqm() => GlimpseHelper.cogSn1EiNrmxIZCdq0Lr;

    internal static object v1Hue8EiaCPgEbPusUnZ() => (object) HttpContext.Current;

    internal static object nlMuPGEiDEeGmUNlUBg3() => (object) DiagnosticsManager.Instance;

    internal static object Dn66FsEitLaa7GitYHum([In] object obj0) => (object) ((DiagnosticsManager) obj0).GetCurrentDiagnosticSession();

    internal static object lokxegEiwuxS94vIWdLP([In] object obj0) => (object) ((HttpContext) obj0).Application;

    internal static object lssbJwEi4BD1b1IyaxMW(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object InaPCbEi6lZm5YEePqh8([In] object obj0, [In] object obj1) => ((HttpApplicationState) obj0)[(string) obj1];

    internal static object EucDSUEiHwvoe6NwEy8o([In] object obj0) => (object) ((GlimpseRuntime) obj0).Configuration;

    internal static bool Dpo2bHEiAEuaWANtOtqG() => DiagnosticsManager.Enabled;

    internal static bool DrIGaAEi7plbWfXJNECB([In] object obj0) => ((string) obj0).IsNullOrWhiteSpace();

    internal static bool HGxkOCEix9lvAtRp0iIK([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static object JVU4rlEi07UGCp8u1FBm([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((char[]) obj1, obj2);

    internal static bool H7B4NGEimaiYtD8GqCCA([In] object obj0) => ((HttpRequest) obj0).IsAuthenticated;

    internal static object eVNahJEiyosG7IDZxRlZ([In] object obj0) => (object) ((HttpContext) obj0).User;

    internal static object LasebWEiM8hYQGlTEXmK([In] object obj0) => (object) ((IPrincipal) obj0).Identity;

    internal static object XOSI5rEiJP1uhw69N1SF() => (object) GlimpseHelper.GetCurrentConfiguration();

    internal static object TZURjJEi9Xk9brVM930Z([In] object obj0) => (object) ((IGlimpseConfiguration) obj0).MessageBroker;

    internal static bool KYYMt8EidBNdadN7AA7v() => GlimpseHelper.IsEnabled;

    internal static object jQug0wEileZyTQ99qWf3([In] object obj0) => (object) ((IDiagnosticsCallInfoEvent) obj0).Info;

    internal static DateTime k2EdAqEirBnFG0CIgV6a([In] object obj0) => ((AbstractCallInfo) obj0).StartTime;

    internal static void iP4HZHEigZ9qUbV30i90([In] object obj0, DateTime value) => ((BaseMessage) obj0).StartTime = value;

    internal static object YOOGkHEi5bimoAdVCiQJ([In] object obj0) => (object) ((AbstractCallInfo) obj0).ContextInfo;

    internal static DateTime lLjfZmEijSdKbZdE8GfR([In] object obj0) => ((CallContextInfo) obj0).StartTime;

    internal static TimeSpan bgbEM4EiYK9bll1S1Ips([In] DateTime obj0, [In] DateTime obj1) => obj0 - obj1;

    internal static void dG5yidEiLDdtM11s43Mn([In] object obj0, TimeSpan value) => ((BaseMessage) obj0).Offset = value;

    internal static TimeSpan bQdl36EiUpJPahMdjv1V([In] object obj0) => ((AbstractCallInfo) obj0).TotalTime;

    internal static void rayiKkEisB7L6BcouLEq([In] object obj0, TimeSpan value) => ((BaseMessage) obj0).Duration = value;

    internal static object NHdPEpEicNDqwcY4Bl2b([In] object obj0) => (object) ((AbstractCallInfo) obj0).CallType;

    internal static void F5L4eYEizVnqvBkTB4sH([In] object obj0, [In] object obj1) => ((BaseMessage) obj0).EventCategory = (TimelineCategoryItem) obj1;

    internal static void t24vXpERFroFBeU5WMfL([In] object obj0) => GlimpseHelper.PublishMessage(obj0);

    internal static object GwhF3nERBy8EGh9Fr1LT([In] object obj0, [In] object obj1) => (object) ((IGlimpseMessagesMaker) obj0).MakeMessages((DiagnosticsEvent) obj1);

    internal static void c5qE2vERWiZLvff77FLA() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
