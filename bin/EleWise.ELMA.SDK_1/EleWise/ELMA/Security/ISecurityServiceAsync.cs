// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.ISecurityServiceAsync
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System;
using System.Threading.Tasks;

namespace EleWise.ELMA.Security
{
  /// <summary>
  /// Интерфейс асинхронной проверки привилегий пользователя
  /// </summary>
  public interface ISecurityServiceAsync : ISecurityService
  {
    /// <summary>
    /// Запустить код с повышенными привилегиями.
    /// Следует использовать для загрузки данных из БД без фильтрации по привилегиям (методы IEntityManager.Load и IEntityManager.Find).
    /// </summary>
    /// <param name="action">Действие</param>
    /// <returns></returns>
    Task RunWithElevatedPrivilegiesAsync(Func<Task> action);

    /// <summary>
    /// Запустить код от имени системного пользователя с повышенными привилегиями.
    /// Внутри производится авторизация под системным пользователем и вызывается метод RunWithElevatedPrivilegies.
    /// </summary>
    /// <param name="action">Действие</param>
    Task RunBySystemUserAsync(Func<Task> action);

    /// <summary>Запустить от имени пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="action">Действие</param>
    Task RunByUserAsync(IUser user, Func<Task> action);
  }
}
