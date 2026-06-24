// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Model.Db.DbModelException
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Runtime.Db;
using j3AmrhgkCleVTGdEwA;
using System;
using System.Runtime.Serialization;

namespace EleWise.ELMA.Model.Db
{
  /// <summary>
  /// Исключение при обновлении структуры БД для хранения моделей
  /// </summary>
  [Serializable]
  public class DbModelException : DbStructureException
  {
    internal static DbModelException q5DdqMooO8h0iQybh9xW;

    /// <summary>Конструктор для сериализации</summary>
    public DbModelException()
    {
      DbModelException.FHnDCYooPoBpiR3P81Gq();
      // ISSUE: explicit constructor call
      base.\u002Ector();
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Создать исключение с сообщением</summary>
    /// <param name="message"></param>
    public DbModelException(string message)
    {
      DbModelException.FHnDCYooPoBpiR3P81Gq();
      // ISSUE: explicit constructor call
      base.\u002Ector(message);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_2d7babf4b803435ab9570024598726ad == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Создать исключение с сообщением и причиной</summary>
    /// <param name="message">Сообщение</param>
    /// <param name="cause">Причина</param>
    public DbModelException(string message, Exception cause)
    {
      TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();
      // ISSUE: explicit constructor call
      base.\u002Ector(message, cause);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_beb14d0e642e408384966576c53c4652 == 0)
        num = 0;
      switch (num)
      {
      }
    }

    /// <summary>Deserialization ctor</summary>
    /// <param name="info">Info</param>
    /// <param name="context">Context</param>
    protected DbModelException(SerializationInfo info, StreamingContext context)
    {
      DbModelException.FHnDCYooPoBpiR3P81Gq();
      // ISSUE: explicit constructor call
      base.\u002Ector(info, context);
      int num = 0;
      if (\u003CModule\u003E\u007B3a453932\u002D0908\u002D413c\u002Db2f1\u002D639ca5a231f2\u007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
        num = 0;
      switch (num)
      {
      }
    }

    internal static void FHnDCYooPoBpiR3P81Gq() => TKW1L3mlUyvXmg29jA.JJCZtPuTvSt();

    internal static bool G4m2ROoo2CH8bIsGAAas() => DbModelException.q5DdqMooO8h0iQybh9xW == null;

    internal static DbModelException bfhu0FooeRlKPAn1XumU() => DbModelException.q5DdqMooO8h0iQybh9xW;
  }
}
