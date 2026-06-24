using System;
using System.Collections.Generic;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Common.Services;

[DeveloperApi(DeveloperApiType.Service)]
[PublicApiMember("WatchEntityServicesApi", "SR.M('Управление списками наблюдений')", "SR.M('\r\n    /// <code>\r\n    /// //С помощью данного сервиса мы можем управлять списками наблюдателей:\r\n    /// //очищать списки наблюдателей и создавать наблюдателей    /// \r\n    /// \r\n    /// //Чтобы очистить список наблюдателей для определённого объекта используйте функцию ClearForObject(objectUid, entityId).\r\n    /// //Чтобы очистить список наблюдателей для типа объекта вместо entityId передавайте значение null.\r\n    /// PublicAPI.Services.WatchEntity.ClearForObject(objectUid, entityId)\r\n    /// \r\n    /// //Чтобы добавить пользователя в список наблюдателей используйте функцию CreateWatchByUser(typeUid, entityId, user), где\r\n    /// //Guid typeUid - идентификатор типа сущности;\r\n    /// //long? entityId - идентификатор сущности;\r\n    /// //IUser user - пользователь.\r\n    /// PublicAPI.Services.WatchEntity.CreateWatchByUser(typeUid, entityId, user);\r\n    /// </code>')")]
public interface IWatchEntityService
{
	List<IUser> GetWatches(Guid objectUid, Guid actionUid, IEntity entity);

	[PublicApiNodeId("WatchEntityServicesApi")]
	void ClearForObject(Guid objectUid, object entityId = null);

	[PublicApiNodeId("WatchEntityServicesApi")]
	void CreateWatchByUser(Guid typeUid, long? entityId, IUser user);
}
