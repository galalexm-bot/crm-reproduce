// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.Exceptions.OtherConnectionsException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Runtime.Exceptions
{
  /// <summary>
  /// Исключение, генерируемое при наличии активных подключений к базе
  /// </summary>
  [Serializable]
  public class OtherConnectionsException : Exception
  {
    internal static OtherConnectionsException VgXOLWWbsG1XW3m6SEjd;

    public OtherConnectionsException()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    public OtherConnectionsException(string message)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    public OtherConnectionsException(string message, Exception innerException)
    {
      OtherConnectionsException.i6gEqHWhFxfCAK5sWOaM();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    protected OtherConnectionsException(SerializationInfo info, StreamingContext context)
    {
      OtherConnectionsException.i6gEqHWhFxfCAK5sWOaM();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool lwUru2WbcsgycCNP9YRH() => OtherConnectionsException.VgXOLWWbsG1XW3m6SEjd == null;

    internal static OtherConnectionsException lt8Y6PWbzN1dSQnMSUuD() => OtherConnectionsException.VgXOLWWbsG1XW3m6SEjd;

    internal static void i6gEqHWhFxfCAK5sWOaM() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
