// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Diagnostics.Glimpse.GlimpseSecurityPolicy
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using Glimpse.Core.Extensibility;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Diagnostics.Glimpse
{
  public class GlimpseSecurityPolicy : IRuntimePolicy
  {
    internal static GlimpseSecurityPolicy rmZteuERoBQyu641A2q5;

    public RuntimePolicy Execute(IRuntimePolicyContext policyContext)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (!GlimpseHelper.AllowCurrentUser())
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0 ? 0 : 0;
              continue;
            }
            goto label_4;
          case 2:
            goto label_4;
          default:
            goto label_5;
        }
      }
label_4:
      return RuntimePolicy.DisplayGlimpseClient;
label_5:
      return RuntimePolicy.Off;
    }

    public RuntimeEvent ExecuteOn => RuntimeEvent.ExecuteResource | RuntimeEvent.EndRequest;

    public GlimpseSecurityPolicy()
    {
      GlimpseSecurityPolicy.a37jThERGTXh43yn6jOX();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool Je27qZERbcgqWBJusljw() => GlimpseSecurityPolicy.rmZteuERoBQyu641A2q5 == null;

    internal static GlimpseSecurityPolicy mYYJ7CERhkOD3k97Ffbh() => GlimpseSecurityPolicy.rmZteuERoBQyu641A2q5;

    internal static void a37jThERGTXh43yn6jOX() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
