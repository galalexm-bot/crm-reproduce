// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.CodeGeneration.CSharpHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.CodeGeneration
{
  /// <summary>Класс-помощник для языка C#</summary>
  public static class CSharpHelper
  {
    private static readonly string[] keywords;
    private static CSharpHelper Woj0Yih35M2oMsHNoUBP;

    /// <summary>Является ли строка ключевым словом</summary>
    /// <param name="s">Строка</param>
    /// <returns></returns>
    public static bool IsKeyword(string s) => ((IEnumerable<string>) CSharpHelper.keywords).Contains<string>(s);

    static CSharpHelper()
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 1:
            TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0 ? 0 : 0;
            continue;
          case 2:
            goto label_2;
          default:
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            // ISSUE: reference to a compiler-generated method
            CSharpHelper.keywords = ((IEnumerable<string>) CSharpHelper.PFO1eGh3scKKe4djIujr(CSharpHelper.G43M4Kh3LQFgVZt6lTXu(-740338220 ^ -740543704), CSharpHelper.weEmAUh3Ueb3gSA3tywV(CSharpHelper.G43M4Kh3LQFgVZt6lTXu(-35995181 ^ -36003091)), StringSplitOptions.RemoveEmptyEntries)).Select<string, string>((Func<string, string>) (s => (string) CSharpHelper.\u003C\u003Ec.Ga85QlvSyKAPWACHcG8H((object) s, CSharpHelper.\u003C\u003Ec.IS1snVvSma4OTjCBtjfX(CSharpHelper.\u003C\u003Ec.PIKj57vS041xXO1cKSya(-2099751081 ^ -2099429785))))).ToArray<string>();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_eadbf314103b4af9a709bbf0e589a800 != 0 ? 2 : 1;
            continue;
        }
      }
label_2:;
    }

    internal static bool UhZawWh3jMZlWlqVN5KN() => CSharpHelper.Woj0Yih35M2oMsHNoUBP == null;

    internal static CSharpHelper LwGs0Bh3YeFTi68dQLgu() => CSharpHelper.Woj0Yih35M2oMsHNoUBP;

    internal static object G43M4Kh3LQFgVZt6lTXu(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object weEmAUh3Ueb3gSA3tywV([In] object obj0) => (object) ((string) obj0).ToCharArray();

    internal static object PFO1eGh3scKKe4djIujr([In] object obj0, [In] object obj1, [In] StringSplitOptions obj2) => (object) ((string) obj0).Split((char[]) obj1, obj2);
  }
}
