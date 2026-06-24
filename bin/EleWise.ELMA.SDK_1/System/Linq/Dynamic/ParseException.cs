// Decompiled with JetBrains decompiler
// Type: System.Linq.Dynamic.ParseException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace System.Linq.Dynamic
{
  [Serializable]
  public sealed class ParseException : Exception
  {
    private int position;
    private static ParseException pZdxaOhPiyYR2ZcdyVF;

    public ParseException()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public ParseException(string message, int position)
    {
      ParseException.xoISUah3Nq77wpBEaqe();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.position = position;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    public int Position => this.position;

    public override string ToString() => string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(333888594 ^ 1075625116 ^ 1408896018), (object) this.Message, (object) this.position);

    internal static bool TrWCf7h1OyMxds2eWEq() => ParseException.pZdxaOhPiyYR2ZcdyVF == null;

    internal static ParseException A0475ghNuhCDAJkyG3t() => ParseException.pZdxaOhPiyYR2ZcdyVF;

    internal static void xoISUah3Nq77wpBEaqe() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
