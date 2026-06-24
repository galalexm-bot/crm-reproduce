// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Logging.PatternLayout
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using log4net.Util;
using SG9KiyIbtdgGDf12qr;
using System.Reflection;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Logging
{
  public class PatternLayout : log4net.Layout.PatternLayout
  {
    private static PatternLayout YgLCh0hJzZNHcpRReH83;

    public PatternLayout()
    {
      PatternLayout.CMFQkph9WdoIJ5wfqSg7();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            PatternLayout.wGdYFVh9btHUm0qFfkhk((object) this, (object) new ConverterInfo()
            {
              Name = (string) PatternLayout.StQptVh9ofoj0feQ0odw(-138018305 ^ -138046859),
              Type = TypeOf<DiagnosticsPatternConverter>.Raw
            });
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    internal static void CMFQkph9WdoIJ5wfqSg7() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object StQptVh9ofoj0feQ0odw(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static void wGdYFVh9btHUm0qFfkhk([In] object obj0, [In] object obj1) => ((log4net.Layout.PatternLayout) obj0).AddConverter((ConverterInfo) obj1);

    internal static bool Dejnluh9FYvQ5aMJRiZ8() => PatternLayout.YgLCh0hJzZNHcpRReH83 == null;

    internal static PatternLayout DERrHah9BH0YkFc9JRHO() => PatternLayout.YgLCh0hJzZNHcpRReH83;
  }
}
