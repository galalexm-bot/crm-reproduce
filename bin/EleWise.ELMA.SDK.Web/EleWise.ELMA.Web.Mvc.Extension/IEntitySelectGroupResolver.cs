using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Web.Mvc.Models;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEntitySelectGroupResolver
{
	bool CheckType(Guid typeUid);

	IEnumerable<EntitySelectGroup> GetGroups(Guid typeUid, IEnumerable<IEntity> entities);
}
