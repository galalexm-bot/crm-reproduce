// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.API.IPublicApplicationService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.API.Models;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Security;
using System;
using System.Collections.Generic;

namespace EleWise.ELMA.API
{
  /// <summary>
  /// Интерфейс сервиса для обеспечения работы внешних приложений
  /// </summary>
  [DeveloperApi(DeveloperApiType.Service)]
  public interface IPublicApplicationService
  {
    /// <summary>Список доступных приложений</summary>
    IEnumerable<IPublicApplication> Applications { get; }

    /// <summary>Создать приложение</summary>
    /// <param name="application">Описание публичного приложения</param>
    /// <returns></returns>
    bool CreateApplication(IPublicApplication application);

    /// <summary>Удалить приложение</summary>
    /// <param name="applicationUid">Идентификатор приложения</param>
    /// <returns></returns>
    bool RemoveApplication(Guid applicationUid);

    /// <summary>Проверить, активно ли внешнее приложение</summary>
    /// <param name="applicationUid">Идентификатор приложения</param>
    /// <returns></returns>
    bool IsActive(Guid applicationUid);

    /// <summary>
    /// Установить внешнему приложению статус <c>Активно</c>
    /// </summary>
    /// <param name="applicationUid">Идентификатор приложения</param>
    /// <returns></returns>
    bool Activate(Guid applicationUid);

    /// <summary>
    /// Установить внешнему приложению статус <c>Не активно</c>
    /// </summary>
    /// <param name="applicationUid">Идентификатор приложения</param>
    /// <returns></returns>
    bool DeActivate(Guid applicationUid);

    /// <summary>Создать публичный токен приложения</summary>
    /// <param name="applicationUid">Идентификатор приложения</param>
    /// <param name="expire">Дата истечения токена</param>
    /// <returns>Токен приложения или <c>null</c></returns>
    IPublicApplicationToken CreateToken(Guid applicationUid, DateTime expire);

    /// <summary>Проверить актуальность токена</summary>
    /// <param name="applicationToken">Публичный токен</param>
    /// <param name="token">Токен приложения</param>
    /// <returns><c>true</c>, если токен актуален</returns>
    bool IsTokenValid(string applicationToken, out IPublicApplicationToken token);

    /// <summary>
    /// Есть ли доступ у пользователя (проверяются пользовательские лицензии)
    /// </summary>
    /// <param name="applicationToken"></param>
    /// <param name="user"></param>
    /// <returns></returns>
    bool HasUserAccess(string applicationToken, IUser user);

    /// <summary>Обновить токен публичного приложения</summary>
    /// <param name="applicationToken">Токен приложения</param>
    /// <param name="expire">Новая дата истечения токена</param>
    /// <returns><c>true</c>, если токен приложения обновлен</returns>
    bool UpdateToken(string applicationToken, DateTime expire);

    /// <summary>Удалить токен приложения</summary>
    /// <param name="applicationToken">Токен приложения</param>
    /// <returns><c>true</c>, если токен приложения удален</returns>
    bool RemoveToken(string applicationToken);
  }
}
