// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Threading.SimpleSynchronizationContext
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System.Threading;

namespace EleWise.ELMA.Threading
{
  public class SimpleSynchronizationContext : SynchronizationContext
  {
    private static SimpleSynchronizationContext AuhmjQBRCfi5KVcxRPbQ;

    public override SynchronizationContext CreateCopy() => (SynchronizationContext) new SimpleSynchronizationContext();

    public override void Post(SendOrPostCallback d, object state)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            d(state);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public override void Send(SendOrPostCallback d, object state)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            d(state);
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    public SimpleSynchronizationContext()
    {
      SimpleSynchronizationContext.I08nnOBRZlU4UD5oydqp();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool NJBuv6BRvPJnQfSXCALr() => SimpleSynchronizationContext.AuhmjQBRCfi5KVcxRPbQ == null;

    internal static SimpleSynchronizationContext QryRbiBR8CyDGcls0wy5() => SimpleSynchronizationContext.AuhmjQBRCfi5KVcxRPbQ;

    internal static void I08nnOBRZlU4UD5oydqp() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
