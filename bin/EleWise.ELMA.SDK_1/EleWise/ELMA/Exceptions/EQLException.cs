// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.EQLException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>Исключение при работе с запросами EQL</summary>
  [Serializable]
  public class EQLException : Exception
  {
    private static EQLException oYBYdKG5DxsmpEbrlIx9;

    /// <summary>Запрос EQL</summary>
    public string Query
    {
      get => this.\u003CQuery\u003Ek__BackingField;
      set
      {
        int num = 1;
        while (true)
        {
          switch (num)
          {
            case 0:
              goto label_2;
            case 1:
              this.\u003CQuery\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0 ? 0 : 0;
              continue;
            default:
              goto label_4;
          }
        }
label_2:
        return;
label_4:;
      }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:System.Exception" />.
    /// </summary>
    public EQLException()
    {
      EQLException.a9PCY0G54fvDPTjanZTh();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fe531aa729e241e9a48ba8046819805f == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Выполняет инициализацию нового экземпляра класса <see cref="T:System.Exception" /> с указанным сообщением об ошибке и ссылкой на внутреннее исключение, которое стало причиной данного исключения.
    /// </summary>
    /// <param name="message">Сообщение об ошибке с объяснением причины исключения. </param>
    /// <param name="innerException">Исключение, вызвавшее текущее исключение, или указатель NULL (Nothing в Visual Basic), если внутреннее исключение не задано. </param>
    public EQLException(string message, Exception innerException)
    {
      EQLException.a9PCY0G54fvDPTjanZTh();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_6bc030c0637249eea635df8662eae071 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:System.Exception" /> с сериализованными данными.
    /// </summary>
    /// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные объекта о создаваемом исключении. </param>
    /// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении. </param>
    /// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="info" /> — null. </exception>
    /// <exception cref="T:System.Runtime.Serialization.SerializationException">Имя класса — null или <see cref="P:System.Exception.HResult" /> равно нулю (0). </exception>
    protected EQLException(SerializationInfo info, StreamingContext context)
    {
      EQLException.a9PCY0G54fvDPTjanZTh();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:System.Exception" />.
    /// </summary>
    public EQLException(string query, string message)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Query = query;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3be1502d95074968827ce5c7f0727648 != 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    internal static bool g0M57PG5t4rVIwJdRjUA() => EQLException.oYBYdKG5DxsmpEbrlIx9 == null;

    internal static EQLException nJnM1YG5wTL1J8ThIL7S() => EQLException.oYBYdKG5DxsmpEbrlIx9;

    internal static void a9PCY0G54fvDPTjanZTh() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
