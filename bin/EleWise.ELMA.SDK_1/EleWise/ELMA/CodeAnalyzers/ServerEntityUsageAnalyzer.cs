// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.CodeAnalyzers.ServerEntityUsageAnalyzer
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using Microsoft.CodeAnalysis;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.CodeAnalyzers
{
  /// <summary>
  /// Обработчик использования свойств сущности в серверном коде
  /// </summary>
  public sealed class ServerEntityUsageAnalyzer : EntityUsageAnalyzer
  {
    private static ServerEntityUsageAnalyzer TWoWWCfR9M33dER0sXrn;

    /// <inheritdoc />
    protected override bool CheckModule(IModuleSymbol module)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            if (module == null)
            {
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_26ee82fd2c524121afb3dd85911dad32 == 0 ? 0 : 0;
              continue;
            }
            goto label_3;
          default:
            goto label_2;
        }
      }
label_2:
      return false;
label_3:
      return ServerEntityUsageAnalyzer.wJTD2YfR59BObGsQeo9m(ServerEntityUsageAnalyzer.j0BPOUfRr9ZFgy3XnmDc((object) module), ServerEntityUsageAnalyzer.naYRdNfRgwJwrktIr7Qm(-1487388570 ^ -1487401498));
    }

    public ServerEntityUsageAnalyzer()
    {
      ServerEntityUsageAnalyzer.KEyt5DfRjTKDpp7jXDQ1();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object j0BPOUfRr9ZFgy3XnmDc([In] object obj0) => (object) ((ISymbol) obj0).Name;

    internal static object naYRdNfRgwJwrktIr7Qm(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool wJTD2YfR59BObGsQeo9m([In] object obj0, [In] object obj1) => (string) obj0 == (string) obj1;

    internal static bool n327kkfRdfRFHM1NfZ6P() => ServerEntityUsageAnalyzer.TWoWWCfR9M33dER0sXrn == null;

    internal static ServerEntityUsageAnalyzer itClvmfRluMbtCHYltRQ() => ServerEntityUsageAnalyzer.TWoWWCfR9M33dER0sXrn;

    internal static void KEyt5DfRjTKDpp7jXDQ1() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
