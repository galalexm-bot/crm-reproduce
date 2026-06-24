// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Scripts.ScriptConsoleBase
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.Model.Scripts
{
  /// <summary>Базовый класс для консоли сценариев</summary>
  public abstract class ScriptConsoleBase : IScriptConsole
  {
    internal static ScriptConsoleBase d6nr6SbiPH8Ti5mCukbg;

    public abstract void Write(string message);

    public virtual void WriteLine(string message)
    {
      int num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            ScriptConsoleBase.wxWSgZbia9T99xSjYF33((object) this, ScriptConsoleBase.z92R4dbipSvCYQ7U3J6p((object) message, ScriptConsoleBase.rRcgOPbi3hVhidHH33wE(-1839087379 - 334718690 ^ 2121152821)));
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0 ? 0 : 0;
            continue;
          default:
            goto label_4;
        }
      }
label_2:
      return;
label_4:;
    }

    protected ScriptConsoleBase()
    {
      ScriptConsoleBase.iNC2SHbiDoZ7tJKV8tCa();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object rRcgOPbi3hVhidHH33wE(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object z92R4dbipSvCYQ7U3J6p([In] object obj0, [In] object obj1) => (object) ((string) obj0 + (string) obj1);

    internal static void wxWSgZbia9T99xSjYF33([In] object obj0, [In] object obj1) => ((ScriptConsoleBase) obj0).Write((string) obj1);

    internal static bool nAndw1bi1tKmuSsHsd7Z() => ScriptConsoleBase.d6nr6SbiPH8Ti5mCukbg == null;

    internal static ScriptConsoleBase l9Qr5SbiNcrc5vFuvQQ8() => ScriptConsoleBase.d6nr6SbiPH8Ti5mCukbg;

    internal static void iNC2SHbiDoZ7tJKV8tCa() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
