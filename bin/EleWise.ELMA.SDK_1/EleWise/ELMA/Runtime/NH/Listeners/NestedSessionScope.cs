// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Listeners.NestedSessionScope
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.Listeners
{
  internal class NestedSessionScope : IDisposable
  {
    private readonly ISession originalSession;
    private readonly ISession nestedSession;
    private readonly string dbName;
    private readonly CallContextSessionOwner callContextSessionOwner;
    private static NestedSessionScope qYhNveW7pFxsDM7GsQNS;

    private ISessionProvider SessionProvider => Locator.GetServiceNotNull<ISessionProvider>();

    public NestedSessionScope(ISession nestedSession, string dbName)
    {
      NestedSessionScope.UEybn8W7tFSw0xq6M63C();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            this.nestedSession = nestedSession;
            num = 2;
            continue;
          case 2:
            this.dbName = dbName;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          case 3:
            this.originalSession = (ISession) NestedSessionScope.vp5nc8W74KELEbunxZ75((object) this.SessionProvider, (object) dbName);
            num = 5;
            continue;
          case 4:
            goto label_3;
          case 5:
            NestedSessionScope.giqUQDW76Xp0rPBWdMVl((object) this.SessionProvider, (object) nestedSession, (object) dbName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 1 : 4;
            continue;
          default:
            this.callContextSessionOwner = (CallContextSessionOwner) NestedSessionScope.OrJ7oDW7wDFWliZ6CKE4();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0 ? 3 : 2;
            continue;
        }
      }
label_3:;
    }

    void IDisposable.Dispose()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_6;
          case 1:
            CallContextSessionOwner contextSessionOwner = this.callContextSessionOwner;
            if (contextSessionOwner == null)
            {
              num = 3;
              continue;
            }
            contextSessionOwner.Dispose();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca == 0 ? 0 : 0;
            continue;
          case 2:
            NestedSessionScope.giqUQDW76Xp0rPBWdMVl((object) this.SessionProvider, (object) this.originalSession, (object) this.dbName);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 1 : 0;
            continue;
          case 3:
            goto label_3;
          default:
            goto label_2;
        }
      }
label_6:
      return;
label_3:
      return;
label_2:;
    }

    /// <summary>Выполнить в сессии</summary>
    /// <param name="nestedSession">Сессия</param>
    /// <param name="dbName">Имя БД</param>
    /// <param name="action">Выполняемая функция</param>
    public static void DoWith([NotNull] ISession nestedSession, [NotNull] string dbName, [NotNull] System.Action action)
    {
      int num1 = 3;
      System.Action action1;
      while (true)
      {
        switch (num1)
        {
          case 1:
            goto label_2;
          case 2:
            action1 = action;
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0 ? 0 : 0;
            continue;
          case 3:
            num1 = 2;
            continue;
          default:
            NestedSessionScope.DoWith<int>(nestedSession, dbName, (Func<int>) (() =>
            {
              int num2 = 1;
              while (true)
              {
                switch (num2)
                {
                  case 1:
                    // ISSUE: reference to a compiler-generated method
                    NestedSessionScope.\u003C\u003Ec__DisplayClass8_0.uDgFKPQYVVciosRsG5cD((object) action1);
                    num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0 ? 0 : 0;
                    continue;
                  default:
                    goto label_2;
                }
              }
label_2:
              return 0;
            }));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0 ? 1 : 1;
            continue;
        }
      }
label_2:;
    }

    /// <summary>Выполнить в сессии</summary>
    /// <param name="nestedSession">Сессия</param>
    /// <param name="dbName">Имя БД</param>
    /// <param name="action">Выполняемая функция</param>
    public static T DoWith<T>([NotNull] ISession nestedSession, [NotNull] string dbName, [NotNull] Func<T> action)
    {
      if (nestedSession == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(1514961705 ^ 1515082591));
      if (dbName == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(132912447 ^ 133053867));
      if (action == null)
        throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35923929));
      using (new NestedSessionScope(nestedSession, dbName))
        return action();
    }

    internal static void UEybn8W7tFSw0xq6M63C() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object OrJ7oDW7wDFWliZ6CKE4() => (object) CallContextSessionOwner.Create();

    internal static object vp5nc8W74KELEbunxZ75([In] object obj0, [In] object obj1) => (object) ((ISessionProvider) obj0).GetSession((string) obj1);

    internal static void giqUQDW76Xp0rPBWdMVl([In] object obj0, [In] object obj1, [In] object obj2) => ((ISessionProvider) obj0).SetCurrentSession((ISession) obj1, (string) obj2);

    internal static bool XHJ53WW7aRHU3MK2r9QQ() => NestedSessionScope.qYhNveW7pFxsDM7GsQNS == null;

    internal static NestedSessionScope URNjCKW7DODWsPETbLRU() => NestedSessionScope.qYhNveW7pFxsDM7GsQNS;
  }
}
