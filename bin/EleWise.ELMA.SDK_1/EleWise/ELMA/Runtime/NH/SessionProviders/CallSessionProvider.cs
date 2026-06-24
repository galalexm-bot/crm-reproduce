// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.SessionProviders.CallSessionProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.SessionProviders
{
  /// <summary>
  /// Провайдер, основанный на использовании <see cref="T:EleWise.ELMA.Runtime.NH.CallContextSessionOwner" />
  /// </summary>
  public sealed class CallSessionProvider : ISessionsContainerProvider, ISessionProvider
  {
    private static ISessionProvider sessionProvider;
    internal static CallSessionProvider kKymkHWHRe6ljsAEaIYa;

    /// <summary>
    /// Получить текущую сессию NHibernate для БД с именем <paramref name="dbName" />
    /// </summary>
    /// <param name="dbName">Имя БД</param>
    /// <returns>Сессия NHibernate</returns>
    [Obsolete("Use ISessionProvider.GetSession", true)]
    public ISession GetSession(string dbName) => (ISession) CallSessionProvider.uNH5HAWHTjJEgMRk9fne(CallSessionProvider.jmKDgJWHXTJMZ6naxaam(), (object) dbName);

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
            CallSessionProvider.jneRl5WHkcmPlA6MDJ0D(CallSessionProvider.jmKDgJWHXTJMZ6naxaam(), (object) session, (object) dbName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0 ? 0 : 0;
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
            CallSessionProvider.pTR2RlWHnTnlIUZoGuSs(CallSessionProvider.jmKDgJWHXTJMZ6naxaam(), (object) dbName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0 ? 0 : 0;
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
            CallSessionProvider.MgSmGZWHObFy9T6SWUe8(CallSessionProvider.jmKDgJWHXTJMZ6naxaam(), (object) dbName);
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
              sessionProvider = CallSessionProvider.sessionProvider;
              if (sessionProvider == null)
              {
                num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0 ? 0 : 0;
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
        return CallSessionProvider.sessionProvider = Locator.GetServiceNotNull<ISessionProvider>();
      }
    }

    IDictionary<Guid, ISessionsContainer> ISessionsContainerProvider.GetSessionsContainers() => (CallContextSessionOwner.Current ?? throw new Exception(z2jc63fLkugS1X8Q9N.tE1kD1vbB(874012245 ^ 874150667))).GetSessionTable();

    public CallSessionProvider()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object jmKDgJWHXTJMZ6naxaam() => (object) CallSessionProvider.SessionProvider;

    internal static object uNH5HAWHTjJEgMRk9fne([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static bool JFvJu6WHqwyIN3VDiao8() => CallSessionProvider.kKymkHWHRe6ljsAEaIYa == null;

    internal static CallSessionProvider BHwvTwWHKUkQoMtyHEam() => CallSessionProvider.kKymkHWHRe6ljsAEaIYa;

    internal static void jneRl5WHkcmPlA6MDJ0D([In] object obj0, [In] object obj1, [In] object obj2) => ((ISessionProvider) obj0).SetCurrentSession((ISession) obj1, (string) obj2);

    internal static void pTR2RlWHnTnlIUZoGuSs([In] object obj0, [In] object obj1) => ((ISessionProvider) obj0).EndUnitOfWork((string) obj1);

    internal static void MgSmGZWHObFy9T6SWUe8([In] object obj0, [In] object obj1) => ((ISessionProvider) obj0).CloseSession((string) obj1);
  }
}
