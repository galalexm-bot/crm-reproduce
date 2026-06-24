// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Runtime.NH.ISessionProvider
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using NHibernate;

namespace EleWise.ELMA.Runtime.NH
{
  /// <summary>Провайдер сессий NHibernate</summary>
  public interface ISessionProvider
  {
    /// <summary>
    /// Получить текущую сессию NHibernate для БД с именем <paramref name="dbName" />
    /// </summary>
    /// <param name="dbName">Имя БД</param>
    /// <returns>Сессия NHibernate</returns>
    ISession GetSession(string dbName);

    /// <summary>Завершить текущую единицу работ</summary>
    /// <param name="dbName">Имя БД</param>
    void EndUnitOfWork(string dbName);

    /// <summary>Закрыть текущую сессию</summary>
    /// <param name="dbName">Имя БД</param>
    void CloseSession(string dbName);

    /// <summary>Установить текущую сессию</summary>
    /// <param name="session"></param>
    /// <param name="dbName">Имя БД</param>
    void SetCurrentSession(ISession session, string dbName);
  }
}
