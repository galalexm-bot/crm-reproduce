// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.PropertyNotFoundEQLException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Exceptions
{
  /// <summary>Свойтсво не найдено по имени</summary>
  [Serializable]
  public class PropertyNotFoundEQLException : PositionalEQLException
  {
    internal static PropertyNotFoundEQLException o7qVGcG5xhZSwZ9tkDaR;

    /// <summary>Имя свойства</summary>
    public string Property
    {
      get => this.\u003CProperty\u003Ek__BackingField;
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
              this.\u003CProperty\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0 ? 0 : 0;
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
    /// Инициализирует новый экземпляр класса <see cref="T:System.Exception" /> с сериализованными данными.
    /// </summary>
    /// <param name="info">Объект <see cref="T:System.Runtime.Serialization.SerializationInfo" />, содержащий сериализованные данные объекта о создаваемом исключении. </param>
    /// <param name="context">Объект <see cref="T:System.Runtime.Serialization.StreamingContext" />, содержащий контекстные сведения об источнике или назначении. </param>
    /// <exception cref="T:System.ArgumentNullException">Значение параметра <paramref name="info" /> — null. </exception>
    /// <exception cref="T:System.Runtime.Serialization.SerializationException">Имя класса — null или <see cref="P:System.Exception.HResult" /> равно нулю (0). </exception>
    protected PropertyNotFoundEQLException(SerializationInfo info, StreamingContext context)
    {
      PropertyNotFoundEQLException.voQ5gNG5ywYRmKxZiGhg();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:System.Exception" />.
    /// </summary>
    public PropertyNotFoundEQLException(int position, string property)
    {
      PropertyNotFoundEQLException.voQ5gNG5ywYRmKxZiGhg();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) null, EleWise.ELMA.SR.T((string) PropertyNotFoundEQLException.T6QncPG5MLst99dM4cHo(-740338220 ^ -740602566), (object) property, (object) position), position);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
        num = 1;
      while (true)
      {
        switch (num)
        {
          case 0:
            goto label_3;
          case 1:
            this.Property = property;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ec123c2cff254dd299d869147df69b1c != 0 ? 0 : 0;
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
    public PropertyNotFoundEQLException(
      string query,
      string message,
      int position,
      string property)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(query, message, position);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Property = property;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static bool OsgKH5G50xwKs3sQcbsw() => PropertyNotFoundEQLException.o7qVGcG5xhZSwZ9tkDaR == null;

    internal static PropertyNotFoundEQLException rgwy16G5m4bYUJMQ3NEG() => PropertyNotFoundEQLException.o7qVGcG5xhZSwZ9tkDaR;

    internal static void voQ5gNG5ywYRmKxZiGhg() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object T6QncPG5MLst99dM4cHo(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
