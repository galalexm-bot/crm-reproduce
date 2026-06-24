// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.ServerRestartScheduleException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>Ошибка планирования перезапуска сервера.</summary>
  /// <seealso cref="T:EleWise.ELMA.Services.IServerRestartService" />
  [Serializable]
  public class ServerRestartScheduleException : Exception
  {
    private static ServerRestartScheduleException JFxNwEGgMSbawgBKdUAN;

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:EleWise.ELMA.Exceptions.ServerRestartScheduleException" />.
    /// </summary>
    public ServerRestartScheduleException()
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:EleWise.ELMA.Exceptions.ServerRestartScheduleException" /> с указанным сообщением об ошибке.
    /// </summary>
    /// <param name="message">Сообщение, описывающее ошибку.</param>
    public ServerRestartScheduleException(string message)
    {
      ServerRestartScheduleException.M48ltAGgd6Zg7mhQs7X8();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:EleWise.ELMA.Exceptions.ServerRestartScheduleException" /> указанным сообщением об ошибке и
    /// ссылкой на внутреннее исключение, вызвавшее данное исключение.
    /// </summary>
    /// <param name="message">Сообщение, описывающее ошибку.</param>
    /// <param name="inner">Исключение, вызвавшее текущее исключение, или пустая ссылка, если внутреннее исключение не задано.</param>
    public ServerRestartScheduleException(string message, Exception inner)
    {
      ServerRestartScheduleException.M48ltAGgd6Zg7mhQs7X8();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, inner);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:EleWise.ELMA.Exceptions.ServerRestartScheduleException" /> с сериализованными данными.
    /// </summary>
    /// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, хранящий сериализованные данные объекта, относящиеся к выдаваемому исключению.</param>
    /// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении.</param>
    protected ServerRestartScheduleException(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool UMheavGgJObkQFv4KKN4() => ServerRestartScheduleException.JFxNwEGgMSbawgBKdUAN == null;

    internal static ServerRestartScheduleException RgK8Z5Gg9vKK4vjQpbgV() => ServerRestartScheduleException.JFxNwEGgMSbawgBKdUAN;

    internal static void M48ltAGgd6Zg7mhQs7X8() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
