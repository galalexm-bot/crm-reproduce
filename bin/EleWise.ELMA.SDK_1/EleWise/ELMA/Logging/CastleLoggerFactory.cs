// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.CastleLoggerFactory
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Logging
{
  internal class CastleLoggerFactory : ILoggerFactory
  {
    private readonly Castle.Core.Logging.ILoggerFactory castleLoggerFactory;
    private static CastleLoggerFactory rKjpAvhdKkWAVa8s48bP;

    public CastleLoggerFactory(Castle.Core.Logging.ILoggerFactory castleLoggerFactory)
    {
      CastleLoggerFactory.xfq1eThdkZd2JjfMuu7m();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.castleLoggerFactory = castleLoggerFactory;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 1;
            continue;
        }
      }
label_3:;
    }

    public ILogger CreateLogger(Type type) => (ILogger) new CastleLogger((Castle.Core.Logging.ILogger) CastleLoggerFactory.wTDmOehdn53GCYvAE48x((object) this.castleLoggerFactory, type));

    public ILogger CreateLogger(string name) => (ILogger) new CastleLogger((Castle.Core.Logging.ILogger) CastleLoggerFactory.sL6RumhdOjpnZYk81kmq((object) this.castleLoggerFactory, (object) name));

    internal static void xfq1eThdkZd2JjfMuu7m() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool YDUGvchdXs99tIbfb0tA() => CastleLoggerFactory.rKjpAvhdKkWAVa8s48bP == null;

    internal static CastleLoggerFactory feq2NHhdTsEUGN5y2Rdd() => CastleLoggerFactory.rKjpAvhdKkWAVa8s48bP;

    internal static object wTDmOehdn53GCYvAE48x([In] object obj0, [In] Type obj1) => (object) ((Castle.Core.Logging.ILoggerFactory) obj0).Create(obj1);

    internal static object sL6RumhdOjpnZYk81kmq([In] object obj0, [In] object obj1) => (object) ((Castle.Core.Logging.ILoggerFactory) obj0).Create((string) obj1);
  }
}
