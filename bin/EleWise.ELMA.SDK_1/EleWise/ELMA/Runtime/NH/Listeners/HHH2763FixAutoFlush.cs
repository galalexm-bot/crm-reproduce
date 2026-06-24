// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Listeners.HHH2763FixAutoFlush
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
  public class HHH2763FixAutoFlush : DefaultAutoFlushEventListener
  {
    private static readonly ILogger Log;
    private static HHH2763FixAutoFlush Kl16TKW7jHFaJ5IsF1D0;

    protected override void PostFlush(ISessionImplementor session)
    {
      int num1 = 2;
      IEnumerator enumerator;
      while (true)
      {
        switch (num1)
        {
          case 0:
            goto label_17;
          case 1:
            goto label_2;
          case 2:
            enumerator = (IEnumerator) HHH2763FixAutoFlush.youprAW7zBv7C2Px53LS(HHH2763FixAutoFlush.Thm7txW7ce43DyDn75WS(HHH2763FixAutoFlush.fxp0vDW7seughoxyDjSX(HHH2763FixAutoFlush.hx6OZFW7UjVq2MAMNaD3((object) session))));
            num1 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 == 0 ? 1 : 0;
            continue;
          default:
            goto label_13;
        }
      }
label_17:
      return;
label_13:
      return;
label_2:
      try
      {
label_7:
        if (HHH2763FixAutoFlush.VEO0ajWxWvLPwa5K2OqT((object) enumerator))
          goto label_9;
        else
          goto label_8;
label_3:
        CollectionEntry collectionEntry;
        int num2;
        while (true)
        {
          switch (num2)
          {
            case 1:
              if (HHH2763FixAutoFlush.JS2LjxWxB8gWWuKBJeh9((object) collectionEntry))
              {
                num2 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0 ? 0 : 0;
                continue;
              }
              goto case 2;
            case 2:
              HHH2763FixAutoFlush.Log.InfoFormat(z2jc63fLkugS1X8Q9N.tE1kD1vbB(~-122002947 ^ 122140326), (object) collectionEntry.Role);
              num2 = 6;
              continue;
            case 3:
              goto label_9;
            case 5:
              goto label_6;
            case 6:
              collectionEntry.IsProcessed = true;
              num2 = 4;
              continue;
            default:
              goto label_7;
          }
        }
label_6:
        return;
label_8:
        num2 = 5;
        goto label_3;
label_9:
        collectionEntry = (CollectionEntry) HHH2763FixAutoFlush.PjkL5YWxFgPKboRAdUXR((object) enumerator);
        num2 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
        {
          num2 = 0;
          goto label_3;
        }
        else
          goto label_3;
      }
      finally
      {
        IDisposable disposable = enumerator as IDisposable;
        int num3 = 1;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
          num3 = 1;
        while (true)
        {
          switch (num3)
          {
            case 1:
              if (disposable != null)
              {
                num3 = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0 ? 0 : 0;
                continue;
              }
              goto label_21;
            case 2:
              goto label_21;
            default:
              HHH2763FixAutoFlush.qNVFc6WxoeqZyZQ6VU4b((object) disposable);
              num3 = 2;
              continue;
          }
        }
label_21:;
      }
    }

    public HHH2763FixAutoFlush()
    {
      HHH2763FixAutoFlush.DrnhOhWxbEZfVYX5U0PL();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    static HHH2763FixAutoFlush()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            HHH2763FixAutoFlush.DrnhOhWxbEZfVYX5U0PL();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: type reference
            HHH2763FixAutoFlush.Log = (ILogger) HHH2763FixAutoFlush.nISqgIWxGKCGqfKe93sJ(HHH2763FixAutoFlush.wFyIdXWxhcNQGmFEGwk9(__typeref (HHH2763FixAutoFlush)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 != 0 ? 2 : 2;
            continue;
        }
      }
label_2:;
    }

    internal static object hx6OZFW7UjVq2MAMNaD3([In] object obj0) => (object) ((ISessionImplementor) obj0).PersistenceContext;

    internal static object fxp0vDW7seughoxyDjSX([In] object obj0) => (object) ((IPersistenceContext) obj0).CollectionEntries;

    internal static object Thm7txW7ce43DyDn75WS([In] object obj0) => (object) ((IDictionary) obj0).Values;

    internal static object youprAW7zBv7C2Px53LS([In] object obj0) => (object) ((IEnumerable) obj0).GetEnumerator();

    internal static object PjkL5YWxFgPKboRAdUXR([In] object obj0) => ((IEnumerator) obj0).Current;

    internal static bool JS2LjxWxB8gWWuKBJeh9([In] object obj0) => ((CollectionEntry) obj0).IsProcessed;

    internal static bool VEO0ajWxWvLPwa5K2OqT([In] object obj0) => ((IEnumerator) obj0).MoveNext();

    internal static void qNVFc6WxoeqZyZQ6VU4b([In] object obj0) => ((IDisposable) obj0).Dispose();

    internal static bool GOSO2OW7Yh3wMOKpyeJ6() => HHH2763FixAutoFlush.Kl16TKW7jHFaJ5IsF1D0 == null;

    internal static HHH2763FixAutoFlush yLcGYHW7L5aE9xUAEsd5() => HHH2763FixAutoFlush.Kl16TKW7jHFaJ5IsF1D0;

    internal static void DrnhOhWxbEZfVYX5U0PL() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static Type wFyIdXWxhcNQGmFEGwk9([In] RuntimeTypeHandle obj0) => Type.GetTypeFromHandle(obj0);

    internal static object nISqgIWxGKCGqfKe93sJ(Type componentType) => (object) Logger.GetLogger(componentType);
  }
}
