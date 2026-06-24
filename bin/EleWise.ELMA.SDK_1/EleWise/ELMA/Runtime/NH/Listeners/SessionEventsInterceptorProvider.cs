// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.Listeners.SessionEventsInterceptorProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Type;
using System;
using System.Collections;

namespace EleWise.ELMA.Runtime.NH.Listeners
{
  [Service]
  public class SessionEventsInterceptorProvider : IInterceptorProvider
  {
    internal static SessionEventsInterceptorProvider WGXL4EWAl1p1ySJxbFyg;

    public IInterceptor GetInterceptor(ISessionFactory factory) => (IInterceptor) new SessionEventsInterceptorProvider.Intercptor();

    public SessionEventsInterceptorProvider()
    {
      SessionEventsInterceptorProvider.oIINKBWA5LFSSK9PFiAO();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void oIINKBWA5LFSSK9PFiAO() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Y4g5POWArtrEygbkQmvM() => SessionEventsInterceptorProvider.WGXL4EWAl1p1ySJxbFyg == null;

    internal static SessionEventsInterceptorProvider Jpbxn9WAgg4QysgBVvGf() => SessionEventsInterceptorProvider.WGXL4EWAl1p1ySJxbFyg;

    [Serializable]
    private class Intercptor : EmptyInterceptor
    {
      private static object muwiejQjtIwLbqGeXarI;

      public override void PreFlush(ICollection entitites)
      {
      }

      public override bool OnSave(
        object entity,
        object id,
        object[] state,
        string[] propertyNames,
        IType[] types)
      {
        return false;
      }

      public Intercptor()
      {
        SessionEventsInterceptorProvider.Intercptor.GMg9BYQj67QJivZJ46wB();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void GMg9BYQj67QJivZJ46wB() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool AhxeNVQjwQJJOhH33MbV() => SessionEventsInterceptorProvider.Intercptor.muwiejQjtIwLbqGeXarI == null;

      internal static SessionEventsInterceptorProvider.Intercptor em4TmAQj4foLA2tUDIVC() => (SessionEventsInterceptorProvider.Intercptor) SessionEventsInterceptorProvider.Intercptor.muwiejQjtIwLbqGeXarI;
    }
  }
}
