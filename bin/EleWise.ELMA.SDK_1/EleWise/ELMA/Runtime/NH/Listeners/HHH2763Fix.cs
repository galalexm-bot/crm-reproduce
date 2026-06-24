// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Listeners.HHH2763Fix
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Engine;
using NHibernate.Event.Default;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Runtime.NH.Listeners
{
  /// <summary>
  /// fix listenero for a problem http://opensource.atlassian.com/projects/hibernate/browse/HHH-2763
  /// http://nhjira.koah.net/browse/NH-1882
  /// Проблему решаем очень просто:
  /// перед тем как вызвать CollectionEntry.PostFlush помечаем коллекция как обработанную.
  /// 
  /// </summary>
  [Serializable]
  public class HHH2763Fix : DefaultFlushEventListener
  {
    private static readonly ILogger Log;
    private static HHH2763Fix AC3xCvW7H2RP97Wvtpeu;

    protected override void PostFlush(ISessionImplementor session)
    {
      int num1 = 1;
      IEnumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 1:
            enumerator = (IEnumerator) HHH2763Fix.mlTNCEW7mPv4rnQoscPE(HHH2763Fix.wRSMEZW70yp7CA1Ykxpm((object) ((IPersistenceContext) HHH2763Fix.EiMME6W7xAB3Rr7LOthL((object) session)).CollectionEntries));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_19;
          default:
            goto label_3;
        }
      }
label_19:
      return;
label_3:
      try
      {
label_13:
        if (HHH2763Fix.nndmQ5W7djuBcf7n0IuL((object) enumerator))
          goto label_8;
        else
          goto label_14;
label_5:
        CollectionEntry collectionEntry;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 0:
              goto label_15;
            case 1:
              HHH2763Fix.zyYMHjW79QljKVC1nqCM((object) collectionEntry, true);
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0bd38a82655b469e9354577f70c3d203 != 0 ? 2 : 0;
              continue;
            case 2:
            case 5:
              goto label_13;
            case 3:
              if (collectionEntry.IsProcessed)
              {
                num2 = 5;
                continue;
              }
              goto case 4;
            case 4:
              HHH2763Fix.Log.InfoFormat((string) HHH2763Fix.TQ45AGW7MKkecsU4I8sA(--1418440330 ^ 1418298926), HHH2763Fix.OemOlJW7JcfFCGmB7kwF((object) collectionEntry));
              num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0 ? 1 : 1;
              continue;
            case 6:
              goto label_8;
            default:
              goto label_6;
          }
        }
label_15:
        return;
label_6:
        return;
label_8:
        collectionEntry = (CollectionEntry) HHH2763Fix.S3M6SjW7yJEDX4RiVQW8((object) enumerator);
        num2 = 3;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
        {
          num2 = 2;
          goto label_5;
        }
        else
          goto label_5;
label_14:
        num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0 ? 0 : 0;
        goto label_5;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num3 = 2;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
          num3 = 2;
        while (true)
        {
          switch (num3)
          {
            case 1:
              goto label_23;
            case 2:
              if (disposable != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0 ? 0 : 0;
                continue;
              }
              goto label_23;
            default:
              HHH2763Fix.QGQMrXW7lpmPhMZ48GIi((object) disposable);
              num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2a96f340091d4c458989d123a12a8553 == 0 ? 1 : 1;
              continue;
          }
        }
label_23:;
      }
    }

    public HHH2763Fix()
    {
      HHH2763Fix.JURQfLW7rRmPvEXTYwpi();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static HHH2763Fix()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: type reference
            HHH2763Fix.Log = (ILogger) HHH2763Fix.tU4SBxW75RuWXvDNqq4k(HHH2763Fix.v2cFHkW7gCXhJOaQlTw7(__typeref (HHH2763Fix)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object EiMME6W7xAB3Rr7LOthL([In] object obj0) => (object) ((ISessionImplementor) obj0).PersistenceContext;

    internal static object wRSMEZW70yp7CA1Ykxpm([In] object obj0) => (object) ((IDictionary) obj0).Values;

    internal static object mlTNCEW7mPv4rnQoscPE([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object S3M6SjW7yJEDX4RiVQW8([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static object TQ45AGW7MKkecsU4I8sA(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object OemOlJW7JcfFCGmB7kwF([In] object obj0) => (object) ((CollectionEntry) obj0).Role;

    internal static void zyYMHjW79QljKVC1nqCM([In] object obj0, [In] bool obj1) => ((CollectionEntry) obj0).IsProcessed = obj1;

    internal static bool nndmQ5W7djuBcf7n0IuL([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void QGQMrXW7lpmPhMZ48GIi([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool PcdpWGW7A0nKqvaaC7y9() => HHH2763Fix.AC3xCvW7H2RP97Wvtpeu == null;

    internal static HHH2763Fix D7gC7aW77BRxxIEUXXZU() => HHH2763Fix.AC3xCvW7H2RP97Wvtpeu;

    internal static void JURQfLW7rRmPvEXTYwpi() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type v2cFHkW7gCXhJOaQlTw7([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object tU4SBxW75RuWXvDNqq4k(Type componentType) => (object) Logger.GetLogger(componentType);
  }
}
