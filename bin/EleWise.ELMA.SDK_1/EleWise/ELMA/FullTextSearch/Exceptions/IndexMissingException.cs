// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Exceptions.IndexMissingException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;

namespace EleWise.ELMA.FullTextSearch.Exceptions
{
  /// <summary>Ошибка поиска индекса</summary>
  public class IndexMissingException : Exception
  {
    internal static IndexMissingException usGkORGqxJNIbFsuUeRK;

    /// <summary>Ctor</summary>
    /// <param name="cardType">Тип карточки объекта полнотекстового поиска</param>
    public IndexMissingException(Type cardType)
    {
      IndexMissingException.cx0iHGGqy1hBJyl6DaZF();
      // ISSUE: explicit constructor call
      base.\u002Ector(EleWise.ELMA.SR.T((string) IndexMissingException.UCx103GqMh05jWIjqb6H(1461625753 ^ 1461551065), (object) cardType));
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void cx0iHGGqy1hBJyl6DaZF() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object UCx103GqMh05jWIjqb6H(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static bool Fei2N5Gq0470quZ1aKqq() => IndexMissingException.usGkORGqxJNIbFsuUeRK == null;

    internal static IndexMissingException WxscbeGqm05Qhlam4MSF() => IndexMissingException.usGkORGqxJNIbFsuUeRK;
  }
}
