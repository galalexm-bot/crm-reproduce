// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Hubs.IHubConnectionContextWrapper`1
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using System.Collections.Generic;

namespace EleWise.ELMA.Hubs
{
  /// <summary>
  /// Инкапсулирует всю информацию о соединении для <see cref="T:EleWise.ELMA.Hubs.IHub" />.
  /// </summary>
  public interface IHubConnectionContextWrapper<T>
  {
    /// <summary>Получить всех клиентов</summary>
    T All { get; }

    /// <summary>
    /// Получить всех клиентов, исключая определённые подключения
    /// </summary>
    /// <param name="excludeConnectionIds">Идентификаторы подключений, которые нужно исключить</param>
    /// <returns></returns>
    T AllExcept(params string[] excludeConnectionIds);

    /// <summary>Получить определённого клиента</summary>
    /// <param name="connectionId">Идентификатор подключения клиента</param>
    /// <returns></returns>
    T Client(string connectionId);

    /// <summary>Получить определённых клиентов</summary>
    /// <param name="connectionIds">Идентификаторы подключения клиентов</param>
    /// <returns></returns>
    T Clients(IList<string> connectionIds);

    /// <summary>
    /// Получить определённую группу клиентов, исключая из неё определённых клиентов
    /// </summary>
    /// <param name="groupName">Имя группы</param>
    /// <param name="excludeConnectionIds">Идентификаторы подключения клиентов, которых нужно исключить</param>
    /// <returns></returns>
    T Group(string groupName, params string[] excludeConnectionIds);

    /// <summary>
    /// Получить определённые группы клиентов, исключая из них определённых клиентов
    /// </summary>
    /// <param name="groupNames">Имена групп</param>
    /// <param name="excludeConnectionIds">Идентификаторы подключения клиентов, которых нужно исключить</param>
    /// <returns></returns>
    T Groups(IList<string> groupNames, params string[] excludeConnectionIds);

    /// <summary>
    /// Получить определённого пользователя по его идентификатору
    /// </summary>
    /// <remarks>
    /// В качестве идентификатора используется <see cref="P:EleWise.ELMA.Security.IUser.UserName" />
    /// </remarks>
    /// <param name="userId">Идентификатор пользователя</param>
    /// <returns></returns>
    T User(string userId);

    /// <summary>
    /// Получить определённых пользователей по его идентификатору
    /// </summary>
    /// <remarks>
    /// В качестве идентификатора используется <see cref="P:EleWise.ELMA.Security.IUser.UserName" />
    /// </remarks>
    /// <param name="userIds">Идентификаторы пользователей</param>
    /// <returns></returns>
    T Users(IList<string> userIds);
  }
}
