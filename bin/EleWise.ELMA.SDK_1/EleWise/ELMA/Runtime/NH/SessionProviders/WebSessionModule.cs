// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.SessionProviders.WebSessionModule
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Context;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web;

namespace EleWise.ELMA.Runtime.NH.SessionProviders
{
  /// <summary>HTTP-модуль для поддержки NHibernate</summary>
  public class WebSessionModule : IHttpModule
  {
    private static ISessionProvider sessionProvider;
    [Obsolete("Use GetSessionTable and RemoveSessionTable", true)]
    protected const string SESSION_KEY = "NHibernateModule.Session";
    private static readonly ILogger Logger;
    private static WebSessionModule XfNKqsWH22OgVoePrqwV;

    void IHttpModule.Init(HttpApplication context)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            WebSessionModule.xsAseSWH1ng56wisaIX9((object) this, (object) context);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9a346b859fbf42ffb993af465115552b != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>
    /// Инициализация модуля. Подписка на события начала и завершения веб-запроса
    /// </summary>
    /// <param name="context">Контекст веб-приложения</param>
    public virtual void Init(HttpApplication context)
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            WebSessionModule.Idw7O6WHNXbSTo00SRWQ((object) context, (object) new EventHandler(this.OnEndRequest));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0 ? 0 : 0;
            continue;
          case 2:
            context.BeginRequest += new EventHandler(this.OnBeginRequest);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    /// <summary>Уничтожение модуля</summary>
    public void Dispose()
    {
    }

    /// <summary>Получить сессию</summary>
    /// <param name="dbName">Имя БД</param>
    /// <returns>Сессия NHibernate</returns>
    public static ISession GetSession(string dbName) => WebSessionModule.SessionProvider.GetSession(dbName);

    /// <summary>Установить сессию</summary>
    /// <param name="dbName">Имя БД</param>
    /// <param name="session">Сессия NHibernate</param>
    public static void SetSession(string dbName, ISession session)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ((ISessionProvider) WebSessionModule.dUqxBoWH3tHJk9ynMKuG()).SetCurrentSession(session, dbName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Закрыть сессию для указанной БД</summary>
    /// <param name="dbName">Имя БД</param>
    public static void CloseSession(string dbName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            WebSessionModule.JIE5NnWHpb13EWbpNlSk((object) WebSessionModule.SessionProvider, (object) dbName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Закрыть сессию для указанной БД</summary>
    /// <param name="dbName">Имя БД</param>
    public static void ReleaseSession(string dbName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            WebSessionModule.JIE5NnWHpb13EWbpNlSk(WebSessionModule.dUqxBoWH3tHJk9ynMKuG(), (object) dbName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Инициализировать сессии</summary>
    public static void InitSessions()
    {
    }

    /// <summary>Удалить сессии</summary>
    public static void ReleaseSessions()
    {
      switch (1)
      {
        case 1:
          try
          {
            WebSessionModule.cPTcWtWHa1sPXirhJ4OQ();
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
              num = 0;
            switch (num)
            {
              case 0:
                return;
              default:
                return;
            }
          }
          catch (Exception ex)
          {
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
              num = 0;
            while (true)
            {
              switch (num)
              {
                case 1:
                  goto label_1;
                default:
                  WebSessionModule.D2iEY6WHtStNPGILMO4a((object) WebSessionModule.Logger, WebSessionModule.cLVOLBWHDVYBbC0xM0CB(1654249598 >> 2 ^ 413422523), (object) ex);
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_00111710bff240b2876edfc455f27786 == 0 ? 1 : 1;
                  continue;
              }
            }
label_1:
            break;
          }
      }
    }

    private static ISessionProvider SessionProvider
    {
      get
      {
        int num = 1;
        ISessionProvider sessionProvider;
        while (true)
        {
          switch (num)
          {
            case 1:
              sessionProvider = WebSessionModule.sessionProvider;
              if (sessionProvider == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 0 : 0;
                continue;
              }
              goto label_2;
            default:
              goto label_5;
          }
        }
label_2:
        return sessionProvider;
label_5:
        return WebSessionModule.sessionProvider = Locator.GetServiceNotNull<ISessionProvider>();
      }
    }

    /// <summary>Получить словарь сессий для текущего HTTP-контекста</summary>
    /// <returns>Словарь сессий</returns>
    protected internal static Dictionary<string, ISession> GetSessionTable() => Locator.GetService<EleWise.ELMA.Runtime.NH.SessionProvider>().GetSessionTable();

    /// <summary>Удалить словарь сессий для текущего HTTP-контекста</summary>
    protected static void RemoveSessionTable() => WebSessionModule.lehm34WHw5CdZMtcJIYQ();

    /// <summary>Открыть сессию</summary>
    /// <param name="sessionFactory">Фабрика сессий</param>
    /// <returns>Сессия</returns>
    protected static ISession OpenSession(ISessionFactory sessionFactory)
    {
      int num = 1;
      IInterceptor interceptor;
      while (true)
      {
        object obj;
        switch (num)
        {
          case 1:
            IInterceptorProvider service = Locator.GetService<IInterceptorProvider>();
            if (service == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0 ? 0 : 0;
              continue;
            }
            obj = WebSessionModule.wnQyP8WH4IRokmMILuG7((object) service, (object) sessionFactory);
            break;
          case 2:
            if (interceptor != null)
            {
              num = 4;
              continue;
            }
            goto label_6;
          case 3:
            goto label_6;
          case 4:
            goto label_10;
          default:
            obj = (object) null;
            break;
        }
        interceptor = (IInterceptor) obj;
        num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 2 : 0;
      }
label_6:
      object obj1 = WebSessionModule.QUQciDWH67KGk1ti9b5L((object) sessionFactory);
      goto label_11;
label_10:
      obj1 = WebSessionModule.xBasFFWHAb8eLViHubBh((object) ((ISessionBuilder<ISessionBuilder>) WebSessionModule.lWjYZ7WHHP34HM23PoJo((object) sessionFactory)).Interceptor(interceptor));
label_11:
      WebSessionModule.MGJ7A7WH7mp3OCbSfxit(obj1, FlushMode.Commit);
      ((ISession) obj1).CacheMode = CacheMode.Normal;
      return (ISession) obj1;
    }

    /// <summary>Закрыть сессию</summary>
    /// <param name="session">Сессия</param>
    protected static void CloseSession(ISession session)
    {
      int num1 = 4;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          switch (num2)
          {
            case 1:
              goto label_23;
            case 2:
              goto label_7;
            case 3:
              goto label_17;
            case 4:
              if (session != null)
                break;
              goto label_6;
          }
          if (WebSessionModule.ctlAbmWHxiVyKrP7CiLE((object) session))
            num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 0;
          else
            goto label_21;
        }
label_6:
        num1 = 3;
      }
label_23:
      return;
label_17:
      return;
label_7:
      try
      {
        WebSessionModule.PhqmMHWH0m4cD6f2Yl8l((object) session);
        int num3 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 != 0)
          num3 = 0;
        switch (num3)
        {
          case 0:
            return;
          default:
            return;
        }
      }
      catch (HibernateException ex)
      {
        int num4 = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
          num4 = 0;
        while (true)
        {
          switch (num4)
          {
            case 1:
              goto label_10;
            default:
              WebSessionModule.fNLZv8WHmYFPPKVSRAVn((object) WebSessionModule.Logger, WebSessionModule.cLVOLBWHDVYBbC0xM0CB(993438473 ^ 993299717), (object) ex);
              num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 1;
              continue;
          }
        }
label_10:
        return;
      }
      catch (Exception ex)
      {
        int num5 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
          num5 = 1;
        while (true)
        {
          switch (num5)
          {
            case 0:
              goto label_4;
            case 1:
              WebSessionModule.fNLZv8WHmYFPPKVSRAVn((object) WebSessionModule.Logger, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099613435), (object) ex);
              num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0 ? 0 : 0;
              continue;
            default:
              goto label_3;
          }
        }
label_4:
        return;
label_3:
        return;
      }
label_21:;
    }

    private void OnBeginRequest(object sender, EventArgs e)
    {
      WebSessionModule.WebELMAContext.OnBeginRequest();
      WebSessionModule.CuKhS2WHybcUN9m4r8AX();
    }

    private void OnEndRequest(object sender, EventArgs e)
    {
      switch (1)
      {
        case 1:
          try
          {
            WebSessionModule.AiAqd3WHMA4cEO98DWYt();
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
              num = 1;
            while (true)
            {
              switch (num)
              {
                case 0:
                  goto label_5;
                case 1:
                  WebSessionModule.UwQCK3WHJ6DAgbEnqSGX();
                  num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0 ? 0 : 0;
                  continue;
                default:
                  goto label_1;
              }
            }
label_5:
            break;
label_1:
            break;
          }
          finally
          {
            WebSessionModule.WebELMAContext.OnEndRequest();
            int num = 0;
            if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
              num = 0;
            switch (num)
            {
              default:
            }
          }
      }
    }

    private static void ReleaseSettings()
    {
      int num = 3;
      PoolBasedSettingsService service;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_7;
          case 2:
            if (WebSessionModule.Ow1KSOWHdul4Ko0mKX4f(WebSessionModule.BrCJ68WH9dVlsLiv5SXO()) == StartStatus.Started)
            {
              service = Locator.GetService<PoolBasedSettingsService>();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f == 0 ? 0 : 0;
              continue;
            }
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_670ddbf6329347f19559980f06879e11 == 0 ? 1 : 1;
            continue;
          case 3:
            if (Locator.Initialized)
            {
              num = 2;
              continue;
            }
            goto label_2;
          case 4:
            WebSessionModule.VX9fwSWHlYk12b1B5u9a((object) service);
            num = 6;
            continue;
          case 5:
            goto label_5;
          case 6:
            goto label_13;
          default:
            if (service == null)
            {
              num = 5;
              continue;
            }
            goto case 4;
        }
      }
label_7:
      return;
label_5:
      return;
label_13:
      return;
label_2:;
    }

    public WebSessionModule()
    {
      WebSessionModule.lmUx6GWHrn4ywNbP7usK();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static WebSessionModule()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: type reference
            WebSessionModule.Logger = (ILogger) WebSessionModule.Uy5BPSWH5sI1TVDYi4il(WebSessionModule.LKmKyHWHg8x4QWL2ipQF(__typeref (WebSessionModule)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static void xsAseSWH1ng56wisaIX9([In] object obj0, [In] object obj1) => ((WebSessionModule) obj0).Init((HttpApplication) obj1);

    internal static bool pvAXy7WHejEHiRr7Gfs0() => WebSessionModule.XfNKqsWH22OgVoePrqwV == null;

    internal static WebSessionModule spp3SgWHPBcqDvL0uwYh() => WebSessionModule.XfNKqsWH22OgVoePrqwV;

    internal static void Idw7O6WHNXbSTo00SRWQ([In] object obj0, [In] object obj1) => ((HttpApplication) obj0).EndRequest += (EventHandler) obj1;

    internal static object dUqxBoWH3tHJk9ynMKuG() => (object) WebSessionModule.SessionProvider;

    internal static void JIE5NnWHpb13EWbpNlSk([In] object obj0, [In] object obj1) => ((ISessionProvider) obj0).CloseSession((string) obj1);

    internal static void cPTcWtWHa1sPXirhJ4OQ() => WebSessionModule.RemoveSessionTable();

    internal static object cLVOLBWHDVYBbC0xM0CB(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void D2iEY6WHtStNPGILMO4a([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Verbose(obj1, (Exception) obj2);

    internal static void lehm34WHw5CdZMtcJIYQ() => WebSessionProvider.RemoveSessionTable();

    internal static object wnQyP8WH4IRokmMILuG7([In] object obj0, [In] object obj1) => (object) ((IInterceptorProvider) obj0).GetInterceptor((ISessionFactory) obj1);

    internal static object QUQciDWH67KGk1ti9b5L([In] object obj0) => (object) ((ISessionFactory) obj0).OpenSession();

    internal static object lWjYZ7WHHP34HM23PoJo([In] object obj0) => (object) ((ISessionFactory) obj0).WithOptions();

    internal static object xBasFFWHAb8eLViHubBh([In] object obj0) => (object) ((ISessionBuilder<ISessionBuilder>) obj0).OpenSession();

    internal static void MGJ7A7WH7mp3OCbSfxit([In] object obj0, [In] FlushMode obj1) => ((ISession) obj0).FlushMode = obj1;

    internal static bool ctlAbmWHxiVyKrP7CiLE([In] object obj0) => ((ISession) obj0).IsOpen;

    internal static void PhqmMHWH0m4cD6f2Yl8l([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void fNLZv8WHmYFPPKVSRAVn([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

    internal static void CuKhS2WHybcUN9m4r8AX() => WebSessionModule.InitSessions();

    internal static void AiAqd3WHMA4cEO98DWYt() => WebSessionModule.ReleaseSessions();

    internal static void UwQCK3WHJ6DAgbEnqSGX() => WebSessionModule.ReleaseSettings();

    internal static object BrCJ68WH9dVlsLiv5SXO() => (object) StartInformation.Root;

    internal static StartStatus Ow1KSOWHdul4Ko0mKX4f([In] object obj0) => ((StartInformation) obj0).Status;

    internal static void VX9fwSWHlYk12b1B5u9a([In] object obj0) => ((PoolBasedSettingsService) obj0).Release();

    internal static void lmUx6GWHrn4ywNbP7usK() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type LKmKyHWHg8x4QWL2ipQF([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object Uy5BPSWH5sI1TVDYi4il(Type componentType) => (object) EleWise.ELMA.Logging.Logger.GetLogger(componentType);

    private class WebELMAContext : ELMAContext
    {
      private readonly object currentHttpContext;
      internal static object aO6TitQrS1Uq2K87Q6Ak;

      protected override object KeyObject => (object) HttpContext.Current;

      /// <summary>Ctor</summary>
      private WebELMAContext()
      {
        WebSessionModule.WebELMAContext.TboMlvQrq5an6bNAcnjv();
        // ISSUE: explicit constructor call
        base.\u002Ector(false);
        int num = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
          num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
              this.currentHttpContext = WebSessionModule.WebELMAContext.hUDjTEQrK5Le2MM5kE6n();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 0 : 0;
              continue;
            default:
              goto label_5;
          }
        }
label_3:
        return;
label_5:;
      }

      public override void Dispose()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 1:
              WebSessionModule.WebELMAContext.V4EyWZQrXZpPKY5G62Uw((object) ELMAContext.Items);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_244a161c0e654262868d382e552e43fc != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_2;
            default:
              base.Dispose();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad != 0 ? 2 : 2;
              continue;
          }
        }
label_2:;
      }

      /// <inheritdoc />
      protected override void SetAsCurrentInnerLogic()
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              WebSessionModule.WebELMAContext.k2GgNnQrTXiLQ4BP0JFX(this.currentHttpContext);
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }

      public static void OnBeginRequest()
      {
        WebSessionModule.WebELMAContext webElmaContext = new WebSessionModule.WebELMAContext();
      }

      public static void OnEndRequest()
      {
        int num = 4;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_3;
            case 1:
            case 3:
              ELMAContext.Current.Dispose();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0 ? 0 : 0;
              continue;
            case 2:
              WebSessionModule.WebELMAContext webElmaContext = new WebSessionModule.WebELMAContext();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0 ? 1 : 1;
              continue;
            case 4:
              if (WebSessionModule.WebELMAContext.eRpVxmQrk3pEs7RTemMJ())
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 != 0 ? 0 : 3;
                continue;
              }
              goto case 2;
            default:
              goto label_2;
          }
        }
label_3:
        return;
label_2:;
      }

      internal static void TboMlvQrq5an6bNAcnjv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static object hUDjTEQrK5Le2MM5kE6n() => (object) HttpContext.Current;

      internal static bool x1dxkeQriM9T0KbgVOgm() => WebSessionModule.WebELMAContext.aO6TitQrS1Uq2K87Q6Ak == null;

      internal static WebSessionModule.WebELMAContext dqxkevQrRZ88TN2FfJRp() => (WebSessionModule.WebELMAContext) WebSessionModule.WebELMAContext.aO6TitQrS1Uq2K87Q6Ak;

      internal static void V4EyWZQrXZpPKY5G62Uw([In] object obj0) => ((ICollection<KeyValuePair<string, object>>) obj0).Clear();

      internal static void k2GgNnQrTXiLQ4BP0JFX([In] object obj0) => HttpContext.Current = (HttpContext) obj0;

      internal static bool eRpVxmQrk3pEs7RTemMJ() => ELMAContext.Initialized;
    }
  }
}
