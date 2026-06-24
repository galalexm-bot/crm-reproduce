using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.BPM.Web.Common.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IEntityLastObjectsResolver
{
	bool CheckType(Guid typeUid);

	IEnumerable<IEntity> GetObjects(Guid typeUid, string text);
}
