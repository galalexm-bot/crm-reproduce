// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.PositionalEQLException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>Исключение, привязанное к позиции в запросе EQL</summary>
  [Serializable]
  public class PositionalEQLException : EQLException
  {
    private static PositionalEQLException JjyNPXG56Hno7mMBj2L1;

    /// <summary>Позиция в запросе</summary>
    public int Position
    {
      get => this.\u003CPosition\u003Ek__BackingField;
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
              this.\u003CPosition\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_72b576a8bec0469a88a683e1609e22de != 0 ? 0 : 0;
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
    public PositionalEQLException(string query, string message, int position)
    {
      PositionalEQLException.JO3homG57cXKlUWxZoPC();
      // ISSUE: explicit constructor call
      base.\u002Ector(query, message);
      int num = 1;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Position = position;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0 ? 0 : 0;
            continue;
          default:
            goto label_5;
        }
      }
label_3:
      return;
label_5:;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:System.Exception" />.
    /// </summary>
    public PositionalEQLException(int position)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Position = position;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Выполняет инициализацию нового экземпляра класса <see cref="T:System.Exception" /> с указанным сообщением об ошибке и ссылкой на внутреннее исключение, которое стало причиной данного исключения.
    /// </summary>
    /// <param name="message">Сообщение об ошибке с объяснением причины исключения. </param>
    /// <param name="innerException">Исключение, вызвавшее текущее исключение, или указатель NULL (Nothing в Visual Basic), если внутреннее исключение не задано. </param>
    public PositionalEQLException(string message, Exception innerException, int position)
    {
      PositionalEQLException.JO3homG57cXKlUWxZoPC();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, innerException);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Position = position;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:System.Exception" /> с сериализованными данными.
    /// </summary>
    /// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные объекта о создаваемом исключении. </param>
    /// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении. </param>
    /// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="info" /> — null. </exception>
    /// <exception cref="T:System.Runtime.Serialization.SerializationException">Имя класса — null или <see cref="P:System.Exception.HResult" /> равно нулю (0). </exception>
    public PositionalEQLException(SerializationInfo info, StreamingContext context)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static bool ivpeEFG5HNB7JFKjjKbE() => PositionalEQLException.JjyNPXG56Hno7mMBj2L1 == null;

    internal static PositionalEQLException UDfa6KG5ATpg5Ah1Q9Wt() => PositionalEQLException.JjyNPXG56Hno7mMBj2L1;

    internal static void JO3homG57cXKlUWxZoPC() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
  }
}
