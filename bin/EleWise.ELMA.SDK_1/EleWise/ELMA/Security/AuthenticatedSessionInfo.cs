// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.AuthenticatedSessionInfo
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Specialized;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Web;

namespace EleWise.ELMA.Security
{
  /// <summary>Информация об авторизованной сессии пользователя</summary>
  public class AuthenticatedSessionInfo
  {
    private static readonly string HeaderKeyRemoteAddress;
    private static AuthenticatedSessionInfo dR8IbEBjb8mACXFuVL2S;

    /// <summary>Ctor</summary>
    public AuthenticatedSessionInfo()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 3;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
        num = 3;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.LastPingDate = this.CreationDate;
            num = 4;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.TicketUid = AuthenticatedSessionInfo.SE8ESeBjEQkiJcrSUMXI();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          case 4:
            this.LastActionDate = this.CreationDate;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 2;
            continue;
          default:
            this.CreationDate = AuthenticatedSessionInfo.YXyl2gBjfYwHwZgEeWc0();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 1 : 0;
            continue;
        }
      }
label_3:;
    }

    /// <summary>Ctor</summary>
    public AuthenticatedSessionInfo(Guid ticketUid, object userId, HttpContextBase httpContext)
    {
      AuthenticatedSessionInfo.rUPMU3BjQEqlak603mlS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 5;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.UserId = userId;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0 ? 3 : 2;
            continue;
          case 2:
            goto label_2;
          case 3:
            this.UpdateFromHttpContext(httpContext);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0 ? 0 : 4;
            continue;
          case 4:
            this.CreationDate = AuthenticatedSessionInfo.YXyl2gBjfYwHwZgEeWc0();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
            continue;
          case 5:
            this.TicketUid = ticketUid;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
            continue;
          case 6:
            this.LastActionDate = this.CreationDate;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0 ? 2 : 2;
            continue;
          default:
            this.LastPingDate = this.CreationDate;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 6 : 5;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Уникальный идентификатор билета авторизованной сессии</summary>
    public Guid TicketUid
    {
      get => this.\u003CTicketUid\u003Ek__BackingField;
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
              this.\u003CTicketUid\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0 ? 0 : 0;
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

    /// <summary>Статус</summary>
    public AuthenticatedSessionStatus Status
    {
      get => this.\u003CStatus\u003Ek__BackingField;
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
              this.\u003CStatus\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 0 : 0;
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

    /// <summary>Дата истечения срока действия сессии</summary>
    public DateTime? Expiration { get; set; }

    /// <summary>Идентификатор сессии</summary>
    public string SessionId
    {
      get => this.\u003CSessionId\u003Ek__BackingField;
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
              this.\u003CSessionId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0 ? 0 : 0;
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

    /// <summary>Идентификатор пользователя</summary>
    public object UserId
    {
      get => this.\u003CUserId\u003Ek__BackingField;
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
              this.\u003CUserId\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 0 : 0;
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

    /// <summary>Клиентский IP-адрес</summary>
    public string RemoteAddress
    {
      get => this.\u003CRemoteAddress\u003Ek__BackingField;
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
              this.\u003CRemoteAddress\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0 ? 0 : 0;
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

    /// <summary>Дата создания</summary>
    public DateTime CreationDate
    {
      get => this.\u003CCreationDate\u003Ek__BackingField;
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
              this.\u003CCreationDate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
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

    /// <summary>Время последнего реального действия пользователя</summary>
    public DateTime LastActionDate
    {
      get => this.\u003CLastActionDate\u003Ek__BackingField;
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
              this.\u003CLastActionDate\u003Ek__BackingField = value;
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

    /// <summary>Время последнего действия в сессии (включая пинг)</summary>
    public DateTime LastPingDate
    {
      get => this.\u003CLastPingDate\u003Ek__BackingField;
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
              this.\u003CLastPingDate\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
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

    /// <summary>Информация о последнем реальном действии пользователя</summary>
    public string LastActionInfo
    {
      get => this.\u003CLastActionInfo\u003Ek__BackingField;
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
              this.\u003CLastActionInfo\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0 ? 0 : 0;
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
    /// Помещать в поле LastActionDate текущее время при сохранении
    /// </summary>
    public bool LastActionIsCurrent
    {
      get => this.\u003CLastActionIsCurrent\u003Ek__BackingField;
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
              this.\u003CLastActionIsCurrent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 0 : 0;
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
    /// Помещать в поле LastPingDate текущее время при сохранении
    /// </summary>
    public bool LastPingIsCurrent
    {
      get => this.\u003CLastPingIsCurrent\u003Ek__BackingField;
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
              this.\u003CLastPingIsCurrent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
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
    /// Помещать в поле CreationDate текущее время при сохранении
    /// </summary>
    public bool CreationIsCurrent
    {
      get => this.\u003CCreationIsCurrent\u003Ek__BackingField;
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
              this.\u003CCreationIsCurrent\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0 ? 0 : 0;
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

    /// <summary>Обновить информацию из HTTP-запроса</summary>
    /// <param name="httpContext"></param>
    public void UpdateFromHttpContext(HttpContextBase httpContext)
    {
      int num1 = 9;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          string str;
          int num3;
          object obj1;
          switch (num2)
          {
            case 1:
            case 2:
              if (str == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0 ? 1 : 11;
                continue;
              }
              goto default;
            case 3:
            case 15:
              obj1 = (object) null;
              break;
            case 4:
              this.LastActionIsCurrent = true;
              num2 = 12;
              continue;
            case 5:
              if (str != null)
              {
                num2 = 10;
                continue;
              }
              goto case 1;
            case 6:
              goto label_25;
            case 7:
              str = str.Substring(1);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 2 : 1;
              continue;
            case 8:
              this.SessionId = httpContext == null || AuthenticatedSessionInfo.QKTqSiBjZbAQQ0cROMlY((object) httpContext) == null ? (string) (object) null : (string) AuthenticatedSessionInfo.D6PwKYBju8mdUxEnHKtY(AuthenticatedSessionInfo.QKTqSiBjZbAQQ0cROMlY((object) httpContext));
              num2 = 14;
              continue;
            case 9:
              object obj2;
              if (httpContext == null)
              {
                obj2 = (object) null;
              }
              else
              {
                object obj3 = AuthenticatedSessionInfo.oI2wYhBjv7yWXFGOiVHx((object) ((HttpRequestBase) AuthenticatedSessionInfo.gpd2LpBjCdWbdvYgmlXP((object) httpContext)).Headers, (object) AuthenticatedSessionInfo.HeaderKeyRemoteAddress);
                obj2 = obj3 == null ? AuthenticatedSessionInfo.EwbMYuBj8J381HYodylq(AuthenticatedSessionInfo.gpd2LpBjCdWbdvYgmlXP((object) httpContext)) : obj3;
              }
              this.RemoteAddress = (string) obj2;
              num2 = 8;
              continue;
            case 10:
              if (!AuthenticatedSessionInfo.npZNssBjSbLAc3LCG5f4((object) str, AuthenticatedSessionInfo.p3vJu5BjVUPwLG24iCh2(~-122002947 ^ 122026578)))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 == 0 ? 1 : 1;
                continue;
              }
              goto case 7;
            case 11:
              num3 = 0;
              goto label_29;
            case 12:
              this.LastActionInfo = str;
              num2 = 6;
              continue;
            case 13:
              if (AuthenticatedSessionInfo.gpd2LpBjCdWbdvYgmlXP((object) httpContext) != null)
              {
                obj1 = AuthenticatedSessionInfo.XKaFhOBjImIV0Gx9OIZL(AuthenticatedSessionInfo.gpd2LpBjCdWbdvYgmlXP((object) httpContext));
                break;
              }
              goto label_17;
            case 14:
              this.LastPingIsCurrent = true;
              num2 = 16;
              continue;
            case 16:
              if (httpContext != null)
                goto case 13;
              else
                goto label_12;
            default:
              num3 = AuthenticatedSessionInfo.uhs207BjiFe5U9ZlPT9p((object) str, AuthenticatedSessionInfo.p3vJu5BjVUPwLG24iCh2(-1217523399 ^ -1217435287), StringComparison.CurrentCultureIgnoreCase) ? 1 : 0;
              goto label_29;
          }
          str = (string) obj1;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0 ? 5 : 2;
          continue;
label_29:
          if (num3 == 0)
            num2 = 4;
          else
            goto label_24;
        }
label_12:
        num1 = 15;
        continue;
label_17:
        num1 = 3;
      }
label_25:
      return;
label_24:;
    }

    static AuthenticatedSessionInfo()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            AuthenticatedSessionInfo.HeaderKeyRemoteAddress = (string) AuthenticatedSessionInfo.p3vJu5BjVUPwLG24iCh2(1251470110 >> 2 ^ 312771259);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f != 0 ? 0 : 0;
            continue;
          case 2:
            AuthenticatedSessionInfo.rUPMU3BjQEqlak603mlS();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 1 : 1;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static Guid SE8ESeBjEQkiJcrSUMXI() => Guid.NewGuid();

    internal static DateTime YXyl2gBjfYwHwZgEeWc0() => DateTime.Now;

    internal static bool QPn5hABjhhwgVgsRqlsj() => AuthenticatedSessionInfo.dR8IbEBjb8mACXFuVL2S == null;

    internal static AuthenticatedSessionInfo WvlrhlBjGjlHV2Dxl8Ml() => AuthenticatedSessionInfo.dR8IbEBjb8mACXFuVL2S;

    internal static void rUPMU3BjQEqlak603mlS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object gpd2LpBjCdWbdvYgmlXP([In] object obj0) => (object) ((HttpContextBase) obj0).Request;

    internal static object oI2wYhBjv7yWXFGOiVHx([In] object obj0, [In] object obj1) => (object) ((NameValueCollection) obj0).Get((string) obj1);

    internal static object EwbMYuBj8J381HYodylq([In] object obj0) => (object) ((HttpRequestBase) obj0).UserHostAddress;

    internal static object QKTqSiBjZbAQQ0cROMlY([In] object obj0) => (object) ((HttpContextBase) obj0).Session;

    internal static object D6PwKYBju8mdUxEnHKtY([In] object obj0) => (object) ((HttpSessionStateBase) obj0).SessionID;

    internal static object XKaFhOBjImIV0Gx9OIZL([In] object obj0) => (object) ((HttpRequestBase) obj0).RawUrl;

    internal static object p3vJu5BjVUPwLG24iCh2(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool npZNssBjSbLAc3LCG5f4([In] object obj0, [In] object obj1) => ((string) obj0).StartsWith((string) obj1);

    internal static bool uhs207BjiFe5U9ZlPT9p([In] object obj0, [In] object obj1, [In] StringComparison obj2) => ((string) obj0).StartsWith((string) obj1, obj2);

    public static class Db
    {
      public const string TableName = "ActiveUserSession";

      public static class Fields
      {
        public static readonly string TicketUid;
        public static readonly string Status;
        public static readonly string Expiration;
        public static readonly string SessionId;
        public static readonly string SessionData;
        public static readonly string UserId;
        public static readonly string RemoteAddress;
        public static readonly string CreationDate;
        public static readonly string LastActionDate;
        public static readonly string LastPingDate;
        public static readonly string LastActionInfo;
        private static AuthenticatedSessionInfo.Db.Fields i5Kt8LZvATZSW7FwpwpQ;

        static Fields()
        {
          int num = 3;
          ParameterExpression parameterExpression;
          while (true)
          {
            switch (num)
            {
              case 1:
                // ISSUE: type reference
                parameterExpression = Expression.Parameter(AuthenticatedSessionInfo.Db.Fields.HILfXQZvmxMbZL6KkVj6(__typeref (AuthenticatedSessionInfo)), (string) AuthenticatedSessionInfo.Db.Fields.HBdw7eZvyfeygvuTm6x1(1514961705 ^ 1515106467));
                num = 13;
                continue;
              case 2:
                // ISSUE: type reference
                parameterExpression = (ParameterExpression) AuthenticatedSessionInfo.Db.Fields.NcZDnrZvM4xT3VfnEAoW(AuthenticatedSessionInfo.Db.Fields.HILfXQZvmxMbZL6KkVj6(__typeref (AuthenticatedSessionInfo)), AuthenticatedSessionInfo.Db.Fields.HBdw7eZvyfeygvuTm6x1(1597012150 ^ 1597158204));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 5 : 16;
                continue;
              case 3:
                AuthenticatedSessionInfo.Db.Fields.YVWunGZv0ILmj8NLGnmK();
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0 ? 2 : 2;
                continue;
              case 4:
                // ISSUE: type reference
                parameterExpression = Expression.Parameter(AuthenticatedSessionInfo.Db.Fields.HILfXQZvmxMbZL6KkVj6(__typeref (AuthenticatedSessionInfo)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886468603));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_519b81e595914ca5bc2f01b5d105756b != 0 ? 8 : 9;
                continue;
              case 5:
                // ISSUE: method reference
                AuthenticatedSessionInfo.Db.Fields.LastActionDate = LinqUtils.NameOf<AuthenticatedSessionInfo>(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression) AuthenticatedSessionInfo.Db.Fields.PZxvqeZvJrnnWOYRVgrc(AuthenticatedSessionInfo.Db.Fields.WdNJy3ZvdeVdAFPd5n42((object) parameterExpression, (object) (MethodInfo) AuthenticatedSessionInfo.Db.Fields.TCZqdJZv9DK4VcKkCPt9(__methodref (AuthenticatedSessionInfo.get_LastActionDate))), typeof (object)), parameterExpression));
                num = 4;
                continue;
              case 6:
                // ISSUE: type reference
                parameterExpression = Expression.Parameter(AuthenticatedSessionInfo.Db.Fields.HILfXQZvmxMbZL6KkVj6(__typeref (AuthenticatedSessionInfo)), (string) AuthenticatedSessionInfo.Db.Fields.HBdw7eZvyfeygvuTm6x1(-1858887263 ^ -1859032533));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 22 : 17;
                continue;
              case 7:
                parameterExpression = Expression.Parameter(typeof (AuthenticatedSessionInfo), (string) AuthenticatedSessionInfo.Db.Fields.HBdw7eZvyfeygvuTm6x1(-35995181 ^ -36173223));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 18 : 11;
                continue;
              case 8:
                // ISSUE: type reference
                parameterExpression = (ParameterExpression) AuthenticatedSessionInfo.Db.Fields.NcZDnrZvM4xT3VfnEAoW(AuthenticatedSessionInfo.Db.Fields.HILfXQZvmxMbZL6KkVj6(__typeref (AuthenticatedSessionInfo)), AuthenticatedSessionInfo.Db.Fields.HBdw7eZvyfeygvuTm6x1(--1360331293 ^ 1360513431));
                num = 5;
                continue;
              case 9:
                // ISSUE: method reference
                AuthenticatedSessionInfo.Db.Fields.LastPingDate = LinqUtils.NameOf<AuthenticatedSessionInfo>(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression) AuthenticatedSessionInfo.Db.Fields.PZxvqeZvJrnnWOYRVgrc(AuthenticatedSessionInfo.Db.Fields.WdNJy3ZvdeVdAFPd5n42((object) parameterExpression, (object) (MethodInfo) AuthenticatedSessionInfo.Db.Fields.TCZqdJZv9DK4VcKkCPt9(__methodref (AuthenticatedSessionInfo.get_LastPingDate))), typeof (object)), parameterExpression));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0 ? 0 : 1;
                continue;
              case 10:
                // ISSUE: type reference
                parameterExpression = (ParameterExpression) AuthenticatedSessionInfo.Db.Fields.NcZDnrZvM4xT3VfnEAoW(AuthenticatedSessionInfo.Db.Fields.HILfXQZvmxMbZL6KkVj6(__typeref (AuthenticatedSessionInfo)), AuthenticatedSessionInfo.Db.Fields.HBdw7eZvyfeygvuTm6x1(1669371371 ^ 1669488225));
                num = 12;
                continue;
              case 11:
                // ISSUE: method reference
                // ISSUE: type reference
                AuthenticatedSessionInfo.Db.Fields.Status = LinqUtils.NameOf<AuthenticatedSessionInfo>(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression) Expression.Convert((Expression) AuthenticatedSessionInfo.Db.Fields.WdNJy3ZvdeVdAFPd5n42((object) parameterExpression, (object) (MethodInfo) AuthenticatedSessionInfo.Db.Fields.TCZqdJZv9DK4VcKkCPt9(__methodref (AuthenticatedSessionInfo.get_Status))), AuthenticatedSessionInfo.Db.Fields.HILfXQZvmxMbZL6KkVj6(__typeref (object))), parameterExpression));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 15 : 7;
                continue;
              case 12:
                // ISSUE: method reference
                // ISSUE: type reference
                AuthenticatedSessionInfo.Db.Fields.CreationDate = LinqUtils.NameOf<AuthenticatedSessionInfo>(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression) Expression.Convert((Expression) AuthenticatedSessionInfo.Db.Fields.WdNJy3ZvdeVdAFPd5n42((object) parameterExpression, (object) (MethodInfo) AuthenticatedSessionInfo.Db.Fields.TCZqdJZv9DK4VcKkCPt9(__methodref (AuthenticatedSessionInfo.get_CreationDate))), AuthenticatedSessionInfo.Db.Fields.HILfXQZvmxMbZL6KkVj6(__typeref (object))), parameterExpression));
                num = 8;
                continue;
              case 13:
                // ISSUE: method reference
                AuthenticatedSessionInfo.Db.Fields.LastActionInfo = LinqUtils.NameOf<AuthenticatedSessionInfo>(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) AuthenticatedSessionInfo.Db.Fields.TCZqdJZv9DK4VcKkCPt9(__methodref (AuthenticatedSessionInfo.get_LastActionInfo))), parameterExpression));
                num = 21;
                continue;
              case 14:
                // ISSUE: method reference
                AuthenticatedSessionInfo.Db.Fields.SessionId = LinqUtils.NameOf<AuthenticatedSessionInfo>(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression) AuthenticatedSessionInfo.Db.Fields.WdNJy3ZvdeVdAFPd5n42((object) parameterExpression, (object) (MethodInfo) AuthenticatedSessionInfo.Db.Fields.TCZqdJZv9DK4VcKkCPt9(__methodref (AuthenticatedSessionInfo.get_SessionId))), parameterExpression));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 0 : 0;
                continue;
              case 15:
                // ISSUE: type reference
                parameterExpression = Expression.Parameter(AuthenticatedSessionInfo.Db.Fields.HILfXQZvmxMbZL6KkVj6(__typeref (AuthenticatedSessionInfo)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-630932142 - 1120244082 ^ -1751261078));
                num = 20;
                continue;
              case 16:
                // ISSUE: method reference
                // ISSUE: type reference
                AuthenticatedSessionInfo.Db.Fields.TicketUid = LinqUtils.NameOf<AuthenticatedSessionInfo>(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression) AuthenticatedSessionInfo.Db.Fields.PZxvqeZvJrnnWOYRVgrc((object) Expression.Property((Expression) parameterExpression, (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AuthenticatedSessionInfo.get_TicketUid))), AuthenticatedSessionInfo.Db.Fields.HILfXQZvmxMbZL6KkVj6(__typeref (object))), parameterExpression));
                num = 17;
                continue;
              case 17:
                // ISSUE: type reference
                parameterExpression = (ParameterExpression) AuthenticatedSessionInfo.Db.Fields.NcZDnrZvM4xT3VfnEAoW(AuthenticatedSessionInfo.Db.Fields.HILfXQZvmxMbZL6KkVj6(__typeref (AuthenticatedSessionInfo)), AuthenticatedSessionInfo.Db.Fields.HBdw7eZvyfeygvuTm6x1(1917998801 >> 2 ^ 479616574));
                num = 11;
                continue;
              case 18:
                // ISSUE: method reference
                AuthenticatedSessionInfo.Db.Fields.RemoteAddress = LinqUtils.NameOf<AuthenticatedSessionInfo>(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression) Expression.Property((Expression) parameterExpression, (MethodInfo) AuthenticatedSessionInfo.Db.Fields.TCZqdJZv9DK4VcKkCPt9(__methodref (AuthenticatedSessionInfo.get_RemoteAddress))), parameterExpression));
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0 ? 10 : 10;
                continue;
              case 19:
                // ISSUE: type reference
                parameterExpression = Expression.Parameter(AuthenticatedSessionInfo.Db.Fields.HILfXQZvmxMbZL6KkVj6(__typeref (AuthenticatedSessionInfo)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(589593376 ^ -1977315327 ^ -1459478357));
                num = 14;
                continue;
              case 20:
                // ISSUE: method reference
                // ISSUE: type reference
                AuthenticatedSessionInfo.Db.Fields.Expiration = LinqUtils.NameOf<AuthenticatedSessionInfo>(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression) AuthenticatedSessionInfo.Db.Fields.PZxvqeZvJrnnWOYRVgrc((object) Expression.Property((Expression) parameterExpression, (MethodInfo) AuthenticatedSessionInfo.Db.Fields.TCZqdJZv9DK4VcKkCPt9(__methodref (AuthenticatedSessionInfo.get_Expiration))), AuthenticatedSessionInfo.Db.Fields.HILfXQZvmxMbZL6KkVj6(__typeref (object))), parameterExpression));
                num = 19;
                continue;
              case 21:
                goto label_2;
              case 22:
                // ISSUE: method reference
                AuthenticatedSessionInfo.Db.Fields.UserId = LinqUtils.NameOf<AuthenticatedSessionInfo>(Expression.Lambda<Func<AuthenticatedSessionInfo, object>>((Expression) AuthenticatedSessionInfo.Db.Fields.WdNJy3ZvdeVdAFPd5n42((object) parameterExpression, (object) (MethodInfo) MethodBase.GetMethodFromHandle(__methodref (AuthenticatedSessionInfo.get_UserId))), parameterExpression));
                num = 7;
                continue;
              default:
                AuthenticatedSessionInfo.Db.Fields.SessionData = (string) AuthenticatedSessionInfo.Db.Fields.HBdw7eZvyfeygvuTm6x1(-477139494 ^ -477542024);
                num = 6;
                continue;
            }
          }
label_2:;
        }

        internal static void YVWunGZv0ILmj8NLGnmK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

        internal static Type HILfXQZvmxMbZL6KkVj6([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

        internal static object HBdw7eZvyfeygvuTm6x1(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

        internal static object NcZDnrZvM4xT3VfnEAoW([In] Type obj0, [In] object obj1) => (object) Expression.Parameter(obj0, (string) obj1);

        internal static object PZxvqeZvJrnnWOYRVgrc([In] object obj0, [In] Type obj1) => (object) Expression.Convert((Expression) obj0, obj1);

        internal static object TCZqdJZv9DK4VcKkCPt9([In] RuntimeMethodHandle obj0) => (object) MethodBase.GetMethodFromHandle(obj0);

        internal static object WdNJy3ZvdeVdAFPd5n42([In] object obj0, [In] object obj1) => (object) Expression.Property((Expression) obj0, (MethodInfo) obj1);

        internal static bool HdHm8hZv7FL8Tb7a3QMd() => AuthenticatedSessionInfo.Db.Fields.i5Kt8LZvATZSW7FwpwpQ == null;

        internal static AuthenticatedSessionInfo.Db.Fields bekk6AZvx2yXmumDQuQY() => AuthenticatedSessionInfo.Db.Fields.i5Kt8LZvATZSW7FwpwpQ;
      }
    }
  }
}
