using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Security;

[DeveloperApi(DeveloperApiType.Service)]
[PublicApiMember("SecurityServicesApi", "SR.M('Сервис безопасности: работа с привилегиями')", "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса можно проверять на наличие привилегий у пользователей и запускать какие-либо\r\n    /// //действия от лица определённого пользователя с ограниченными или полными правами\r\n    /// \r\n    /// //запишем сервис в переменную, чтобы с ним легче было работать\r\n    /// var service = PublicAPI.Services.Security;\r\n    /// \r\n    /// //Чтобы проверить наличие привилегий, используйте следующие функции:\r\n    /// //1.HasPermission(user, permission) - проверить наличие привилегии у определённого пользователя\r\n    /// var hasPermission = service.HasPermission(user, permission);\r\n    /// \r\n    /// //2.HasPermission(permission) - проверить наличие привилегии у текущего пользователя\r\n    /// var hasPermission = service.HasPermission(permission);\r\n    /// \r\n    /// //3.HasPermission(user, permission, permissionSubject, skipAdmin) - проверить наличие привилегии у пользователя относительно экземпляра объекта\r\n    /// var hasPermission = service.HasPermission(user, permission, permissionSubject, skipAdmin);\r\n    /// \r\n    /// //4.HasPermission(permission, target, skipAdmin) - проверить наличие привилегии у текущего пользователя относительно экземпляра объекта\r\n    /// var hasPermission = service.HasPermission(permission, target, skipAdmin);\r\n    /// \r\n    /// //Чтобы проверить возможность проверки на наличие привилегии, используйте функцию CanCheckPermission(permission, target)\r\n    /// var canCheck = service.CanCheckPermission(permission, target);\r\n    /// \r\n    /// //Чтобы запустить код с теми или иными привилегиями используйте следующие функции:\r\n    /// //1.RunWithElevatedPrivilegies(action) - запустить код с повышенными привилегиями.\r\n    /// service.RunWithElevatedPrivilegies(() => \r\n\t///\t\t{\r\n\t///             Console.WriteLine(\"Это работает!\");\r\n\t///     });\r\n\t/// \r\n    /// //2.RunWithElevatedPrivilegiesAndWithDeleted(action) - запустить без фильтрации по пермишеннам и удалению\r\n    /// service.RunWithElevatedPrivilegiesAndWithDeleted(() => \r\n    ///\t\t{\r\n    ///             Console.WriteLine(\"Это работает!\");\r\n    ///     });\r\n    /// \r\n    /// //3.RunWithUsualPrivilegies(action) - запустить с обычными привилегиями\r\n    /// service.RunWithUsualPrivilegies(() => \r\n    ///\t\t{\r\n    ///             Console.WriteLine(\"Это работает!\");\r\n    ///     });\r\n    /// \r\n    /// //Чтобы запустить код от лица какого-либо пользователя используйте следующие функции:\r\n    /// //1.RunBySystemUser(action) - запустить код от имени системного пользователя с повышенными привилегиями.\r\n    /// service.RunBySystemUser(() => \r\n    ///\t\t{\r\n    ///             Console.WriteLine(\"Это работает!\");\r\n    ///     });\r\n    /// \r\n    /// //2.RunByUser(user, action) - запустить код от имени пользователя\r\n    /// service.RunByUser(user, () => \r\n    ///\t\t{\r\n    ///             Console.WriteLine(\"Это работает!\");\r\n    ///     });\r\n    /// </code>')")]
public interface ISecurityService
{
	[PublicApiNodeId("SecurityServicesApi")]
	bool HasPermission(IUser user, Permission permission);

	[PublicApiNodeId("SecurityServicesApi")]
	bool HasPermission(Permission permission);

	bool HasPermission(IUser user, Permission permission, Type type);

	bool HasPermission(IUser user, Permission permission, Type type, bool skipAdmin);

	bool HasPermission(IUser user, Permission permission, Type type, PropertyInfo propertyInfo);

	bool HasPermission(IUser user, Permission permission, IPermissionTarget target);

	[PublicApiNodeId("SecurityServicesApi")]
	bool HasPermission(IUser user, Permission permission, object permissionSubject, bool skipAdmin = false);

	bool HasPermission(Permission permission, Type type, bool skipAdmin = false);

	[PublicApiNodeId("SecurityServicesApi")]
	bool HasPermission(Permission permission, object target, bool skipAdmin = false);

	[PublicApiNodeId("SecurityServicesApi")]
	bool CanCheckPermission(Permission permission, object target);

	[PublicApiNodeId("SecurityServicesApi")]
	bool CanCheckPermission(Permission permission, Type type);

	[PublicApiNodeId("SecurityServicesApi")]
	void RunWithElevatedPrivilegies(Action action);

	[PublicApiNodeId("SecurityServicesApi")]
	void RunWithElevatedPrivilegiesAndWithDeleted(Action action);

	[PublicApiNodeId("SecurityServicesApi")]
	void RunWithUsualPrivilegies(Action action);

	[PublicApiNodeId("SecurityServicesApi")]
	void RunBySystemUser(Action action);

	[PublicApiNodeId("SecurityServicesApi")]
	void RunByUser(IUser user, Action action);

	[PublicApiNodeId("SecurityServicesApi")]
	List<IUser> GetUsersByPermissions(Guid typeUid, long entityId, List<Guid> permissions);
}
