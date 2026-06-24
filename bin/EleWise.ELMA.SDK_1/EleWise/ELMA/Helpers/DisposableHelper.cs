// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Helpers.DisposableHelper
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;

namespace EleWise.ELMA.Helpers
{
  public class DisposableHelper
  {
    internal static DisposableHelper.EmptyDisposable emptyInstance;
    internal static DisposableHelper NnywANhLzdSYTYG5ULUT;

    public static IDisposable Empty => (IDisposable) DisposableHelper.emptyInstance;

    public DisposableHelper()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    static DisposableHelper()
    {
      int num = 2;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_2;
          case 1:
            DisposableHelper.emptyInstance = new DisposableHelper.EmptyDisposable();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0 ? 0 : 0;
            continue;
          case 2:
            DisposableHelper.bctXrvhUWhAbZKMTmQtl();
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0 ? 1 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_2:
      return;
label_5:;
    }

    internal static bool UExj1OhUF5Rqp1jg8o33() => DisposableHelper.NnywANhLzdSYTYG5ULUT == null;

    internal static DisposableHelper j840tLhUBUv3jAeO4HkS() => DisposableHelper.NnywANhLzdSYTYG5ULUT;

    internal static void bctXrvhUWhAbZKMTmQtl() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal class EmptyDisposable : IDisposable
    {
      internal static DisposableHelper.EmptyDisposable Vn3v5YvyTaw3lcpuwDec;

      public void Dispose()
      {
      }

      public EmptyDisposable()
      {
        DisposableHelper.EmptyDisposable.fphCckvyOi1iQUAdy9mQ();
        // ISSUE: explicit constructor call
        base.\u002Ector();
        int num = 0;
        if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
          num = 0;
        switch (num)
        {
        }
      }

      internal static void fphCckvyOi1iQUAdy9mQ() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

      internal static bool PTITh3vyk76hFBOqf0b9() => DisposableHelper.EmptyDisposable.Vn3v5YvyTaw3lcpuwDec == null;

      internal static DisposableHelper.EmptyDisposable qpKc77vynxV4UhqH1tsP() => DisposableHelper.EmptyDisposable.Vn3v5YvyTaw3lcpuwDec;
    }
  }
}
