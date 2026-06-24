// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Exceptions.ClassNotFoundEQLException
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
  /// <summary>Класс не найден по имени</summary>
  [Serializable]
  public class ClassNotFoundEQLException : PositionalEQLException
  {
    private static ClassNotFoundEQLException BZrH6EG5JhF1bUjqlcR0;

    /// <summary>Имя класса</summary>
    public string Class
    {
      get => this.\u003CClass\u003Ek__BackingField;
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
              this.\u003CClass\u003Ek__BackingField = value;
              num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0 ? 0 : 0;
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
    protected ClassNotFoundEQLException(SerializationInfo info, StreamingContext context)
    {
      ClassNotFoundEQLException.GESY9GG5lYAuaGhd3sZf();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:System.Exception" />.
    /// </summary>
    public ClassNotFoundEQLException(int position, string @class)
    {
      ClassNotFoundEQLException.GESY9GG5lYAuaGhd3sZf();
      // ISSUE: explicit constructor call
      base.\u002Ector((string) null, EleWise.ELMA.SR.T((string) ClassNotFoundEQLException.Ju7uRFG5rbt0tqZbkd0W(-1255365154 ^ 596875508 ^ -1766120328), (object) @class, (object) position), position);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_c61a4898016348629effe6c617bb4dca != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Class = @class;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    /// <summary>
    /// Инициализирует новый экземпляр класса <see cref="T:System.Exception" />.
    /// </summary>
    public ClassNotFoundEQLException(string query, string message, int position, string @class)
    {
      ClassNotFoundEQLException.GESY9GG5lYAuaGhd3sZf();
      // ISSUE: explicit constructor call
      base.\u002Ector(query, message, position);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
        num = 0;
      while (true)
      {
        switch (num)
        {
          case 1:
            goto label_3;
          default:
            this.Class = @class;
            num = \u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0 ? 1 : 1;
            continue;
        }
      }
label_3:;
    }

    internal static bool JCxpeSG59ZhLQImsjcRW() => ClassNotFoundEQLException.BZrH6EG5JhF1bUjqlcR0 == null;

    internal static ClassNotFoundEQLException n1vNAKG5dEWfs1Oi4qnj() => ClassNotFoundEQLException.BZrH6EG5JhF1bUjqlcR0;

    internal static void GESY9GG5lYAuaGhd3sZf() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static object Ju7uRFG5rbt0tqZbkd0W(int _param0) => (object) z2jc63fLkugS1X8Q9N.tE1kD1vbB(_param0);
  }
}
