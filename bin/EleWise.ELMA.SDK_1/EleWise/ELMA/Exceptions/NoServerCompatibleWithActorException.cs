// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.NoServerCompatibleWithActorException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>
  /// Ошибка возникает, когда нет сервера, способного разместить актор
  /// </summary>
  [Serializable]
  public class NoServerCompatibleWithActorException : Exception
  {
    private static NoServerCompatibleWithActorException lUA7vuGgQgDfkeQNYpvE;

    /// <summary>
    /// Initializes a new instance of the <see cref="T:EleWise.ELMA.Exceptions.NoServerCompatibleWithActorException" /> class with a specified error message
    /// </summary>
    /// <param name="message">The message that describes the error</param>
    public NoServerCompatibleWithActorException(string message)
    {
      NoServerCompatibleWithActorException.fV825LGg8gc8ZOvHgudU();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:EleWise.ELMA.Exceptions.NoServerCompatibleWithActorException" /> class with a specified error message and a reference to the inner exception that is the cause of this exception
    /// </summary>
    /// <param name="message">The error message that explains the reason for the exception</param>
    /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified</param>
    public NoServerCompatibleWithActorException(string message, Exception innerException)
    {
      NoServerCompatibleWithActorException.fV825LGg8gc8ZOvHgudU();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="T:EleWise.ELMA.Exceptions.NoServerCompatibleWithActorException" /> class with serialized data
    /// </summary>
    /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown</param>
    /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination</param>
    protected NoServerCompatibleWithActorException(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void fV825LGg8gc8ZOvHgudU() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool Aib2YmGgCwOjXRf6VT50() => NoServerCompatibleWithActorException.lUA7vuGgQgDfkeQNYpvE == null;

    internal static NoServerCompatibleWithActorException y9MRblGgvv366FOaOons() => NoServerCompatibleWithActorException.lUA7vuGgQgDfkeQNYpvE;
  }
}
