// Decompiled with JetBrains decompiler
// Type: EleWise.ELMA.Security.ISecurityService
// Assembly: EleWise.ELMA.SDK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=cb29d04eca9b031d
// MVID: CEBF4313-ABB2-45F5-B9CA-100E053C346A
// Assembly location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.dll
// XML documentation location: D:\ELMA-CE\Web\bin\EleWise.ELMA.SDK.xml

using EleWise.ELMA.Model.Attributes;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace EleWise.ELMA.Security
{
  /// <summary>Интерфейс проверки привилегий пользователя</summary>
  /// <example>
  /// <code>
  /// //С помощью данного сервиса можно проверять на наличие привилегий у пользователей и запускать какие-либо
  /// //действия от лица определённого пользователя с ограниченными или полными правами
  /// 
  /// //запишем сервис в переменную, чтобы с ним легче было работать
  /// <![CDATA[var service = Locator.GetServiceNotNull<ISecurityService>();]]>
  /// 
  /// //Чтобы проверить наличие привилегий, используйте следующие функции:
  /// //1.HasPermission(user, permission) - проверить наличие привилегии у определённого пользователя
  /// var hasPermission = service.HasPermission(user, permission);
  /// 
  /// //2.HasPermission(permission) - проверить наличие привилегии у текущего пользователя
  /// var hasPermission = service.HasPermission(permission);
  /// 
  /// //3.HasPermission(user, permission, permissionSubject, skipAdmin) - проверить наличие привилегии у пользователя относительно экземпляра объекта
  /// var hasPermission = service.HasPermission(user, permission, permissionSubject, skipAdmin);
  /// 
  /// //4.HasPermission(permission, target, skipAdmin) - проверить наличие привилегии у текущего пользователя относительно экземпляра объекта
  /// var hasPermission = service.HasPermission(permission, target, skipAdmin);
  /// 
  /// //Чтобы проверить возможность проверки на наличие привилегии, используйте функцию CanCheckPermission(permission, target)
  /// var canCheck = service.CanCheckPermission(permission, target);
  /// 
  /// //Чтобы запустить код с теми или иными привилегиями используйте следующие функции:
  /// //1.RunWithElevatedPrivilegies(action) - запустить код с повышенными привилегиями.
  /// service.RunWithElevatedPrivilegies(() =&gt;
  /// 	{
  ///             Console.WriteLine("Это работает!");
  ///     });
  /// 
  /// //2.RunWithElevatedPrivilegiesAndWithDeleted(action) - запустить без фильтрации по пермишеннам и удалению
  /// service.RunWithElevatedPrivilegiesAndWithDeleted(() =&gt;
  /// 	{
  ///             Console.WriteLine("Это работает!");
  ///     });
  /// 
  /// //3.RunWithUsualPrivilegies(action) - запустить с обычными привилегиями
  /// service.RunWithUsualPrivilegies(() =&gt;
  /// 	{
  ///             Console.WriteLine("Это работает!");
  ///     });
  /// 
  /// //Чтобы запустить код от лица какого-либо пользователя используйте следующие функции:
  /// //1.RunBySystemUser(action) - запустить код от имени системного пользователя с повышенными привилегиями.
  /// service.RunBySystemUser(() =&gt;
  /// 	{
  ///             Console.WriteLine("Это работает!");
  ///     });
  /// 
  /// //2.RunByUser(user, action) - запустить код от имени пользователя
  /// service.RunByUser(user, () =&gt;
  /// 	{
  ///             Console.WriteLine("Это работает!");
  ///     });
  /// </code>
  /// </example>
  [DeveloperApi(DeveloperApiType.Service)]
  [PublicApiMember("SecurityServicesApi", "SR.M('Сервис безопасности: работа с привилегиями')", "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса можно проверять на наличие привилегий у пользователей и запускать какие-либо\r\n    /// //действия от лица определённого пользователя с ограниченными или полными правами\r\n    /// \r\n    /// //запишем сервис в переменную, чтобы с ним легче было работать\r\n    /// var service = PublicAPI.Services.Security;\r\n    /// \r\n    /// //Чтобы проверить наличие привилегий, используйте следующие функции:\r\n    /// //1.HasPermission(user, permission) - проверить наличие привилегии у определённого пользователя\r\n    /// var hasPermission = service.HasPermission(user, permission);\r\n    /// \r\n    /// //2.HasPermission(permission) - проверить наличие привилегии у текущего пользователя\r\n    /// var hasPermission = service.HasPermission(permission);\r\n    /// \r\n    /// //3.HasPermission(user, permission, permissionSubject, skipAdmin) - проверить наличие привилегии у пользователя относительно экземпляра объекта\r\n    /// var hasPermission = service.HasPermission(user, permission, permissionSubject, skipAdmin);\r\n    /// \r\n    /// //4.HasPermission(permission, target, skipAdmin) - проверить наличие привилегии у текущего пользователя относительно экземпляра объекта\r\n    /// var hasPermission = service.HasPermission(permission, target, skipAdmin);\r\n    /// \r\n    /// //Чтобы проверить возможность проверки на наличие привилегии, используйте функцию CanCheckPermission(permission, target)\r\n    /// var canCheck = service.CanCheckPermission(permission, target);\r\n    /// \r\n    /// //Чтобы запустить код с теми или иными привилегиями используйте следующие функции:\r\n    /// //1.RunWithElevatedPrivilegies(action) - запустить код с повышенными привилегиями.\r\n    /// service.RunWithElevatedPrivilegies(() => \r\n\t///\t\t{\r\n\t///             Console.WriteLine(\"Это работает!\");\r\n\t///     });\r\n\t/// \r\n    /// //2.RunWithElevatedPrivilegiesAndWithDeleted(action) - запустить без фильтрации по пермишеннам и удалению\r\n    /// service.RunWithElevatedPrivilegiesAndWithDeleted(() => \r\n    ///\t\t{\r\n    ///             Console.WriteLine(\"Это работает!\");\r\n    ///     });\r\n    /// \r\n    /// //3.RunWithUsualPrivilegies(action) - запустить с обычными привилегиями\r\n    /// service.RunWithUsualPrivilegies(() => \r\n    ///\t\t{\r\n    ///             Console.WriteLine(\"Это работает!\");\r\n    ///     });\r\n    /// \r\n    /// //Чтобы запустить код от лица какого-либо пользователя используйте следующие функции:\r\n    /// //1.RunBySystemUser(action) - запустить код от имени системного пользователя с повышенными привилегиями.\r\n    /// service.RunBySystemUser(() => \r\n    ///\t\t{\r\n    ///             Console.WriteLine(\"Это работает!\");\r\n    ///     });\r\n    /// \r\n    /// //2.RunByUser(user, action) - запустить код от имени пользователя\r\n    /// service.RunByUser(user, () => \r\n    ///\t\t{\r\n    ///             Console.WriteLine(\"Это работает!\");\r\n    ///     });\r\n    /// </code>')")]
  public interface ISecurityService
  {
    /// <summary>Проверить обладание привелегей пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="permission">Привилегия</param>
    /// <returns><c>true</c>, если привилегия существует</returns>
    [PublicApiNodeId("SecurityServicesApi")]
    bool HasPermission(IUser user, Permission permission);

    /// <summary>Проверить обладание привелегей текущего пользователя</summary>
    /// <param name="permission">Привилегия</param>
    /// <returns><c>true</c>, если привилегия существует</returns>
    [PublicApiNodeId("SecurityServicesApi")]
    bool HasPermission(Permission permission);

    /// <summary>
    /// Проверить обладание привилегией пользователя относительно типа
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="permission">Привилегия</param>
    /// <param name="type">Тип объекта</param>
    /// <returns></returns>
    bool HasPermission(IUser user, Permission permission, Type type);

    /// <summary>
    /// Проверить обладание привилегией пользователя относительно типа
    /// </summary>
    /// <param name="user">Пользователь</param>
    /// <param name="permission">Привилегия</param>
    /// <param name="type">Тип объекта</param>
    /// <param name="skipAdmin">пропустить проверку Административной привилегии</param>
    /// <returns></returns>
    bool HasPermission(IUser user, Permission permission, Type type, bool skipAdmin);

    /// <summary>
    /// Проверить обладание привилегией пользователя относительно поля типа
    /// </summary>
    /// <param name="user">пользователь</param>
    /// <param name="permission">привилегия</param>
    /// <param name="type">тип</param>
    /// <param name="propertyInfo">свойство</param>
    /// <returns></returns>
    bool HasPermission(IUser user, Permission permission, Type type, PropertyInfo propertyInfo);

    /// <summary>
    /// Проверить обладание привилегией пользователя относительно экземпляра объекта
    /// </summary>
    /// <param name="user"></param>
    /// <param name="permission"></param>
    /// <param name="target">экземпляр</param>
    /// <returns></returns>
    bool HasPermission(IUser user, Permission permission, IPermissionTarget target);

    /// <summary>
    /// Проверить обладание привилегией пользователя относительно экземпляра объекта
    /// Например, право "редактировать документ" или право "закрыть задачу".
    /// </summary>
    /// <param name="user"></param>
    /// <param name="permission"></param>
    /// <param name="permissionSubject">экземпляр</param>
    /// <param name="skipAdmin">пропустить проверку Административной привилегии</param>
    /// <returns><c>true</c>, если привилегия существует</returns>
    [PublicApiNodeId("SecurityServicesApi")]
    bool HasPermission(
      IUser user,
      Permission permission,
      object permissionSubject,
      bool skipAdmin = false);

    /// <summary>
    /// Проверить обладание привилегией текущего пользователя относительно типа
    /// </summary>
    /// <param name="permission">Привилегия</param>
    /// <param name="type">Тип объекта</param>
    /// <param name="skipAdmin">пропустить проверку Административной привилегии</param>
    /// <returns></returns>
    bool HasPermission(Permission permission, Type type, bool skipAdmin = false);

    /// <summary>
    /// Проверить обладание привилегией текущего пользователя относительно экземпляра объекта
    /// Например, право "редактировать документ" или право "закрыть задачу".
    /// </summary>
    /// <param name="permission">Привилегия</param>
    /// <param name="target">Экземпляр объекта</param>
    /// <param name="skipAdmin">пропустить проверку Административной привилегии</param>
    /// <returns><c>true</c>, если привилегия существует</returns>
    [PublicApiNodeId("SecurityServicesApi")]
    bool HasPermission(Permission permission, object target, bool skipAdmin = false);

    /// <summary>Проверить возможность запроса привилегии для объекта</summary>
    /// <param name="permission">Привилегия</param>
    /// <param name="target">Экземпляр объекта</param>
    /// <returns><c>true</c>, если привилегия существует</returns>
    [PublicApiNodeId("SecurityServicesApi")]
    bool CanCheckPermission(Permission permission, object target);

    /// <summary>Проверить возможность запроса привилегии для типа</summary>
    /// <param name="permission">Привилегия</param>
    /// <param name="type">тип</param>
    /// <returns><c>true</c>, если привилегия существует</returns>
    [PublicApiNodeId("SecurityServicesApi")]
    bool CanCheckPermission(Permission permission, Type type);

    /// <summary>
    /// Запустить код с повышенными привилегиями.
    /// Сделует использовать для загрузки данныз из БД без фильтрации по привилегиям (методы IEntityManager.Load и IEntityManager.Find).
    /// </summary>
    /// <example>
    /// private ISecurityService securityService;
    /// // менеджер для работы с документами
    /// private IEntityManager[IDocument] manager;
    /// ...
    /// // следующий код сгенерирует исключение SecurityException если у текущего пользователя не имеется право на просмотр докумнента
    /// var doc = manager.Load(id);
    /// 
    /// // следующий код в любом случае загрузит документ из БД при условии что документ с соответвующим id существует
    /// securityService.RunWithElevatedPrivilegies(delegate() {doc = manager.Load(id);});
    /// </example>
    /// <param name="action">Действие</param>
    [PublicApiNodeId("SecurityServicesApi")]
    void RunWithElevatedPrivilegies(Action action);

    /// <summary>Запуск без фильтрации по пермишеннам и удалению</summary>
    /// <param name="action">Действие</param>
    [PublicApiNodeId("SecurityServicesApi")]
    void RunWithElevatedPrivilegiesAndWithDeleted(Action action);

    /// <summary>Запустить с обычными привилегиями</summary>
    /// <param name="action">Действие</param>
    [PublicApiNodeId("SecurityServicesApi")]
    void RunWithUsualPrivilegies(Action action);

    /// <summary>
    /// Запустить код от имени системного пользователя с повышенными привилегиями.
    /// Внутри производится авторизация под системным пользователем и вызывается метод RunWithElevatedPrivilegies.
    /// </summary>
    /// <param name="action">Действие</param>
    [PublicApiNodeId("SecurityServicesApi")]
    void RunBySystemUser(Action action);

    /// <summary>Запустить от имени пользователя</summary>
    /// <param name="user">Пользователь</param>
    /// <param name="action">Действие</param>
    [PublicApiNodeId("SecurityServicesApi")]
    void RunByUser(IUser user, Action action);

    /// <summary>Получить пользователей обладающие привилегиями</summary>
    /// <param name="permissions"></param>
    /// <param name="typeUid"></param>
    /// <param name="entityId"></param>
    /// <returns></returns>
    [PublicApiNodeId("SecurityServicesApi")]
    List<IUser> GetUsersByPermissions(Guid typeUid, long entityId, List<Guid> permissions);
  }
}
