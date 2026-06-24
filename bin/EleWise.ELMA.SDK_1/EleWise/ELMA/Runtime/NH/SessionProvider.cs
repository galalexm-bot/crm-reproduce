// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.SessionProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH
{
  /// <inheritdoc />
  internal sealed class SessionProvider : ISessionProvider
  {
    private static readonly Guid Uid;
    private readonly ISessionsContainerProvider sessionsContainerProvider;
    private readonly SessionFactoryHolder sessionFactory;
    private readonly IInterceptorProvider interceptorProvider;
    private static SessionProvider jQW7oiWpoSpVqY16MuKy;

    /// <summary>ctor</summary>
    /// <param name="sessionsContainerProvider">Провайдер контейнера сессий</param>
    /// <param name="sessionFactory">Сервис для хранения фабрики сессий. Нужен для того, чтобы можно было динамически переконфигурировать NHibernate.</param>
    /// <param name="interceptorProvider">Провайдер IInterceptorProvider</param>
    public SessionProvider(
      ISessionsContainerProvider sessionsContainerProvider,
      SessionFactoryHolder sessionFactory,
      IInterceptorProvider interceptorProvider)
    {
      SessionProvider.p3hk7QWpGElAPNWphHBN();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7b7601840955431b8667c611372f91fa == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.sessionsContainerProvider = sessionsContainerProvider;
            num = 3;
            continue;
          case 2:
            goto label_3;
          case 3:
            this.sessionFactory = sessionFactory;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          default:
            this.interceptorProvider = interceptorProvider;
            num = 2;
            continue;
        }
      }
label_3:;
    }

    /// <inheritdoc />
    public ISession GetSession(string dbName)
    {
      int num1 = 1;
      ISession session;
      while (true)
      {
        int num2 = num1;
        Dictionary<string, ISession> sessionTable;
        while (true)
        {
          string str1;
          switch (num2)
          {
            case 1:
              string str2 = dbName;
              if (str2 == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0 ? 0 : 0;
                continue;
              }
              str1 = str2;
              break;
            case 2:
              sessionTable = this.GetSessionTable();
              num2 = 5;
              continue;
            case 3:
              session = this.OpenSession((ISessionFactory) SessionProvider.ubEthcWpE75BErgTYaeg((object) this.sessionFactory));
              num2 = 6;
              continue;
            case 4:
              goto label_3;
            case 5:
              if (!sessionTable.TryGetValue(dbName, out session))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 2 : 3;
                continue;
              }
              goto label_3;
            case 6:
              goto label_6;
            default:
              str1 = string.Empty;
              break;
          }
          dbName = str1;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0 ? 2 : 1;
        }
label_6:
        sessionTable.Add(dbName, session);
        num1 = 4;
      }
label_3:
      return session;
    }

    /// <inheritdoc />
    public void CloseSession(string dbName)
    {
      int num1 = 3;
      while (true)
      {
        Dictionary<string, ISession> sessionTable;
        ISession session;
        string str1;
        switch (num1)
        {
          case 1:
            if (sessionTable.TryGetValue(dbName, out session))
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3f79fc1df51f454c8144de48f315a54f == 0 ? 0 : 0;
              continue;
            }
            goto label_14;
          case 2:
            str1 = string.Empty;
            break;
          case 3:
            string str2 = dbName;
            if (str2 == null)
            {
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a1b1f08beb50460aaa983666473eef2e != 0 ? 2 : 2;
              continue;
            }
            str1 = str2;
            break;
          case 4:
label_3:
            sessionTable.Remove(dbName);
            num1 = 6;
            continue;
          case 5:
            sessionTable = this.GetSessionTable();
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 1 : 1;
            continue;
          case 6:
            goto label_18;
          default:
            try
            {
              int num2;
              if (!SessionProvider.Ofr8jHWpfsBUNNptOr6B((object) session))
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
              else
                goto label_8;
label_7:
              switch (num2)
              {
                case 2:
                  break;
                default:
                  goto label_3;
              }
label_8:
              SessionProvider.tNqCa5WpQkmgyN0lfWWg((object) session);
              num2 = 1;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
              {
                num2 = 0;
                goto label_7;
              }
              else
                goto label_7;
            }
            catch (Exception ex)
            {
              int num3 = 0;
              if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
                num3 = 0;
              while (true)
              {
                switch (num3)
                {
                  case 1:
                    goto label_3;
                  default:
                    SessionProvider.NuEEfFWpCoQnLhKbfW07((object) Logger.Log, (object) ex);
                    num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0 ? 1 : 0;
                    continue;
                }
              }
            }
        }
        dbName = str1;
        num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8575f6e311ac4db8b96176046b2c5efb != 0 ? 5 : 2;
      }
label_18:
      return;
label_14:;
    }

    /// <inheritdoc />
    public void EndUnitOfWork(string dbName)
    {
    }

    /// <inheritdoc />
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
            this.GetSessionTable()[dbName] = session;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_98b68f1bc8f8412da4e436206caef53e == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    /// <summary>Таблица сессий NHibernate</summary>
    /// <returns></returns>
    internal Dictionary<string, ISession> GetSessionTable()
    {
      IDictionary<Guid, ISessionsContainer> sessionsContainers = this.sessionsContainerProvider.GetSessionsContainers();
      ISessionsContainer sessionTable;
      if (!sessionsContainers.TryGetValue(SessionProvider.Uid, out sessionTable))
        sessionsContainers[SessionProvider.Uid] = sessionTable = (ISessionsContainer) new SessionProvider.SessionDictionary();
      return (Dictionary<string, ISession>) sessionTable;
    }

    private ISession OpenSession(ISessionFactory sessionFactory)
    {
      int num1 = 1;
      IInterceptor interceptor;
      while (true)
      {
        int num2 = num1;
        while (true)
        {
          object obj;
          switch (num2)
          {
            case 1:
              if (this.interceptorProvider == null)
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0 ? 0 : 0;
                continue;
              }
              obj = SessionProvider.Q3fLxhWpvf35QbZ9jHUj((object) this.interceptorProvider, (object) sessionFactory);
              break;
            case 2:
              goto label_4;
            case 3:
              goto label_11;
            case 4:
              goto label_5;
            default:
              obj = (object) null;
              break;
          }
          interceptor = (IInterceptor) obj;
          num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ba8376385de74edd8ca4e978608be085 != 0 ? 4 : 3;
        }
label_5:
        if (interceptor != null)
          num1 = 3;
        else
          break;
      }
label_4:
      object obj1 = (object) sessionFactory.OpenSession();
      goto label_12;
label_11:
      obj1 = SessionProvider.bnKNlHWp8VZngYIr2YY8((object) sessionFactory, (object) interceptor);
label_12:
      SessionProvider.x4oy9xWpZsPoYUmZMagx(obj1, FlushMode.Commit);
      ((ISession) obj1).CacheMode = CacheMode.Normal;
      return (ISession) obj1;
    }

    static SessionProvider()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            SessionProvider.Uid = new Guid((string) SessionProvider.yI5JtsWpuu3RHr6k6I1W(322893104 - -1992822529 ^ -1979376537));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0 ? 0 : 0;
            continue;
          case 2:
            SessionProvider.p3hk7QWpGElAPNWphHBN();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_458ac053851844e4b12b357b6e068056 != 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static void p3hk7QWpGElAPNWphHBN() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool OlLi4UWpbGum9dmqd3xl() => SessionProvider.jQW7oiWpoSpVqY16MuKy == null;

    internal static SessionProvider yCicKWWphhip5hPvnHol() => SessionProvider.jQW7oiWpoSpVqY16MuKy;

    internal static object ubEthcWpE75BErgTYaeg([In] object obj0) => (object) ((SessionFactoryHolder) obj0).SessionFactory;

    internal static bool Ofr8jHWpfsBUNNptOr6B([In] object obj0) => ((ISession) obj0).IsOpen;

    internal static void tNqCa5WpQkmgyN0lfWWg([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static void NuEEfFWpCoQnLhKbfW07([In] object obj0, [In] object obj1) => ((ILogger) obj0).Error(obj1);

    internal static object Q3fLxhWpvf35QbZ9jHUj([In] object obj0, [In] object obj1) => (object) ((IInterceptorProvider) obj0).GetInterceptor((ISessionFactory) obj1);

    internal static object bnKNlHWp8VZngYIr2YY8([In] object obj0, [In] object obj1) => (object) ((ISessionFactory) obj0).OpenSession((IInterceptor) obj1);

    internal static void x4oy9xWpZsPoYUmZMagx([In] object obj0, [In] FlushMode obj1) => ((ISession) obj0).FlushMode = obj1;

    internal static object yI5JtsWpuu3RHr6k6I1W(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    private class SessionDictionary : Dictionary<string, ISession>, ISessionsContainer
    {
      public static readonly Guid Uid;
      internal static object Ky4fSoQMYSTtfRNR7LwS;

      public void CloseAll()
      {
        int num1 = 1;
        Dictionary<string, ISession>.ValueCollection.Enumerator enumerator;
        while (true)
        {
          switch (num1)
          {
            case 1:
              enumerator = this.Values.GetEnumerator();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 0 : 0;
              continue;
            case 2:
              goto label_26;
            case 3:
label_28:
              this.Clear();
              num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0 ? 2 : 2;
              continue;
            default:
              try
              {
label_9:
                if (enumerator.MoveNext())
                  goto label_11;
                else
                  goto label_10;
label_5:
                ISession current;
                int num2;
                while (true)
                {
                  switch (num2)
                  {
                    case 1:
                      goto label_12;
                    case 2:
                      goto label_28;
                    case 3:
                      goto label_11;
                    case 4:
                    case 6:
                      goto label_9;
                    case 5:
                      if (current == null)
                      {
                        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 4 : 4;
                        continue;
                      }
                      break;
                  }
                  SessionProvider.SessionDictionary.UQxPGqQMsh47FliM7MCf((object) Logger.Log, (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487025144));
                  num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 1;
                }
label_12:
                try
                {
                  SessionProvider.SessionDictionary.M0h51wQMcRb3t27fYqh7((object) current);
                  int num3 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
                    num3 = 0;
                  switch (num3)
                  {
                    default:
                      goto label_9;
                  }
                }
                catch (HibernateException ex)
                {
                  int num4 = 1;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8e162152046c4c96ae0975f28cad631a == 0)
                    num4 = 0;
                  while (true)
                  {
                    switch (num4)
                    {
                      case 1:
                        SessionProvider.SessionDictionary.eC7B46QJFD0uRdb1WrVu((object) Logger.Log, SessionProvider.SessionDictionary.g5qdpAQMz5ThDsGX80BV(-345420348 ^ -345281592), (object) ex);
                        num4 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0 ? 0 : 0;
                        continue;
                      default:
                        goto label_9;
                    }
                  }
                }
                catch (Exception ex)
                {
                  int num5 = 0;
                  if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
                    num5 = 0;
                  while (true)
                  {
                    switch (num5)
                    {
                      case 1:
                        goto label_9;
                      default:
                        SessionProvider.SessionDictionary.eC7B46QJFD0uRdb1WrVu(SessionProvider.SessionDictionary.mLy84AQJBjkOXtKX3EyG(), (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1470998129 - 231418599 ^ 1239440856), (object) ex);
                        num5 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 == 0 ? 1 : 1;
                        continue;
                    }
                  }
                }
label_10:
                num2 = 2;
                goto label_5;
label_11:
                current = enumerator.Current;
                num2 = 5;
                goto label_5;
              }
              finally
              {
                enumerator.Dispose();
                int num6 = 0;
                if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
                  num6 = 0;
                switch (num6)
                {
                  default:
                }
              }
          }
        }
label_26:;
      }

      public SessionDictionary()
      {
        SessionProvider.SessionDictionary.G4iuLWQJW8iYnFW4FoWv();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
          num = 0;
        switch (num)
        {
        }
      }

      static SessionDictionary()
      {
        int num = 2;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              SessionProvider.SessionDictionary.Uid = new Guid((string) SessionProvider.SessionDictionary.g5qdpAQMz5ThDsGX80BV(272623989 ^ 272494883));
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0 ? 0 : 0;
              continue;
            case 2:
              SessionProvider.SessionDictionary.G4iuLWQJW8iYnFW4FoWv();
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0 ? 1 : 1;
              continue;
            default:
              goto label_5;
          }
        }
label_2:
        return;
label_5:;
      }

      internal static void UQxPGqQMsh47FliM7MCf([In] object obj0, [In] object obj1) => ((ILogger) obj0).Verbose(obj1);

      internal static object M0h51wQMcRb3t27fYqh7([In] object obj0) => (object) ((ISession) obj0).Close();

      internal static object g5qdpAQMz5ThDsGX80BV(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

      internal static void eC7B46QJFD0uRdb1WrVu([In] object obj0, [In] object obj1, [In] object obj2) => ((ILogger) obj0).Error(obj1, (Exception) obj2);

      internal static object mLy84AQJBjkOXtKX3EyG() => (object) Logger.Log;

      internal static bool gmEMSuQMLeD7mvMV2ioU() => SessionProvider.SessionDictionary.Ky4fSoQMYSTtfRNR7LwS == null;

      internal static SessionProvider.SessionDictionary DJqO7hQMUrSp6u7IUIRH() => (SessionProvider.SessionDictionary) SessionProvider.SessionDictionary.Ky4fSoQMYSTtfRNR7LwS;

      internal static void G4iuLWQJW8iYnFW4FoWv() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
    }
  }
}
