// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Exceptions.IndexingServerUnavailableException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.InteropServices;

namespace EleWise.ELMA.FullTextSearch.Exceptions
{
  /// <summary>Ошибка связи с сервером полнотекстового поиска</summary>
  [Serializable]
  internal class IndexingServerUnavailableException : Exception
  {
    private static IndexingServerUnavailableException JmK8xpGqJFW5spY3aJrF;

    /// <inheritdoc />
    public override string Message => (string) IndexingServerUnavailableException.s5OAkjGqlCPqLkFS7UMN((object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(1669212571 ^ 1669199121));

    public IndexingServerUnavailableException()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static object s5OAkjGqlCPqLkFS7UMN([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);

    internal static bool NjDTa9Gq94LYi4HJ0BHi() => IndexingServerUnavailableException.JmK8xpGqJFW5spY3aJrF == null;

    internal static IndexingServerUnavailableException YPad1mGqdIERxwUvecs2() => IndexingServerUnavailableException.JmK8xpGqJFW5spY3aJrF;
  }
}
