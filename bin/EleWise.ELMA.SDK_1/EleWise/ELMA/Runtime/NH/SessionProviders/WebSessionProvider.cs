// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.SessionProviders.WebSessionProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.SessionProviders
{
  /// <summary>
  /// Провайдер сессий NHibernate для веб-приложений.
  /// Поддерживаются вызовы в контексте HttpContext-а и <see cref="T:EleWise.ELMA.Runtime.NH.CallContextSessionOwner" />
  /// </summary>
  public class WebSessionProvider : ISessionsContainerProvider, ISessionProvider
  {
    private static ISessionProvider sessionProvider;
    internal static WebSessionProvider CtB87WWHjp09VcAxqufM;

    /// <summary>
    /// Получить текущую сессию NHibernate для БД с именем <paramref name="dbName" />
    /// </summary>
    /// <param name="dbName">Имя БД</param>
    /// <returns>Сессия NHibernate</returns>
    [Obsolete("Use ISessionProvider.GetSession", true)]
    public ISession GetSession(string dbName) => (ISession) WebSessionProvider.xtix3PWHst4lQ7pqDcXD(WebSessionProvider.pnapXTWHUYAEh8J7VYIC(), (object) dbName);

    [Obsolete("Use ISessionProvider.SetCurrentSession", true)]
    public void SetCurrentSession(ISession session, string dbName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            WebSessionProvider.ky2rhdWHcvFOD5K93FYB(WebSessionProvider.pnapXTWHUYAEh8J7VYIC(), (object) session, (object) dbName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Завершить текущую единицу работ</summary>
    /// <param name="dbName">Имя БД</param>
    [Obsolete("Use ISessionProvider.EndUnitOfWork", true)]
    public void EndUnitOfWork(string dbName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ((ISessionProvider) WebSessionProvider.pnapXTWHUYAEh8J7VYIC()).EndUnitOfWork(dbName);
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

    /// <summary>Закрыть текущую сессию</summary>
    /// <param name="dbName">Имя БД</param>
    [Obsolete("Use ISessionProvider.CloseSession", true)]
    public void CloseSession(string dbName)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            WebSessionProvider.VGfkcBWHzvQlD1p17eJE(WebSessionProvider.pnapXTWHUYAEh8J7VYIC(), (object) dbName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
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
              sessionProvider = WebSessionProvider.sessionProvider;
              if (sessionProvider == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0 ? 0 : 0;
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
        return WebSessionProvider.sessionProvider = Locator.GetServiceNotNull<ISessionProvider>();
      }
    }

    IDictionary<Guid, ISessionsContainer> ISessionsContainerProvider.GetSessionsContainers() => (CallContextSessionOwner.Current ?? CallContextSessionOwner.Create()).GetSessionTable();

    /// <summary>Удалить словарь сессий для текущего HTTP-контекста</summary>
    internal static void RemoveSessionTable()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_5;
          case 1:
            goto label_3;
          case 2:
            CallContextSessionOwner current = CallContextSessionOwner.Current;
            if (current == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0 ? 1 : 1;
              continue;
            }
            current.Dispose();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 0 : 0;
            continue;
          default:
            goto label_2;
        }
      }
label_5:
      return;
label_3:
      return;
label_2:;
    }

    public WebSessionProvider()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object pnapXTWHUYAEh8J7VYIC() => (object) WebSessionProvider.SessionProvider;

    internal static object xtix3PWHst4lQ7pqDcXD([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static bool g6LYBMWHYtIi1awJ9au9() => WebSessionProvider.CtB87WWHjp09VcAxqufM == null;

    internal static WebSessionProvider QHi2QPWHLfbcXFkexBCi() => WebSessionProvider.CtB87WWHjp09VcAxqufM;

    internal static void ky2rhdWHcvFOD5K93FYB([In] object obj0, [In] object obj1, [In] object obj2) => ((ISessionProvider) obj0).SetCurrentSession((ISession) obj1, (string) obj2);

    internal static void VGfkcBWHzvQlD1p17eJE([In] object obj0, [In] object obj1) => ((ISessionProvider) obj0).CloseSession((string) obj1);
  }
}
