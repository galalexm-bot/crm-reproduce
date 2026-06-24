// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.FullTextSearch.Exceptions.FullTextFilterException
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
  /// <summary>Ошибка получения данных из индекса</summary>
  [Serializable]
  public class FullTextFilterException : Exception
  {
    private static FullTextFilterException Vws3gwGqrIyKkfeiXDZd;

    public FullTextFilterException(string message)
    {
      FullTextFilterException.AaNAVYGqjkrrRscKApsr();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public FullTextFilterException(Exception innerException)
    {
      FullTextFilterException.AaNAVYGqjkrrRscKApsr();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) FullTextFilterException.yqLX2xGqLxgnSHK4kefN(FullTextFilterException.SswN69GqYlGP7LTrXoiC(-420743386 ^ -420992052)), innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public FullTextFilterException(string message, Exception innerException)
    {
      FullTextFilterException.AaNAVYGqjkrrRscKApsr();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void AaNAVYGqjkrrRscKApsr() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool GI0eg3GqgXMa5T5gqnR1() => FullTextFilterException.Vws3gwGqrIyKkfeiXDZd == null;

    internal static FullTextFilterException a6apL7Gq5DPhLR3U29kN() => FullTextFilterException.Vws3gwGqrIyKkfeiXDZd;

    internal static object SswN69GqYlGP7LTrXoiC(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);

    internal static object yqLX2xGqLxgnSHK4kefN([In] object obj0) => (object) EleWise.ELMA.SR.T((string) obj0);
  }
}
