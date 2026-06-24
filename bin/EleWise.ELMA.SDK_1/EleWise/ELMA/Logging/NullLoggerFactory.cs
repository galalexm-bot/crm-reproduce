// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.NullLoggerFactory
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Logging
{
  internal class NullLoggerFactory : ILoggerFactory
  {
    private static NullLoggerFactory muHyiLhl60QSf7w7oqIy;

    public ILogger CreateLogger(Type type) => NullLogger.Instance;

    public ILogger CreateLogger(string name) => (ILogger) NullLoggerFactory.YEK01uhl7MPpjqKTVfEu();

    public NullLoggerFactory()
    {
      NullLoggerFactory.AbkQNnhlxsDOmbxMK3WS();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object YEK01uhl7MPpjqKTVfEu() => (object) NullLogger.Instance;

    internal static void AbkQNnhlxsDOmbxMK3WS() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool a9ecVjhlHPRs7ajQZsrs() => NullLoggerFactory.muHyiLhl60QSf7w7oqIy == null;

    internal static NullLoggerFactory HGsIuphlAWd9ZBLlQB9n() => NullLoggerFactory.muHyiLhl60QSf7w7oqIy;
  }
}
