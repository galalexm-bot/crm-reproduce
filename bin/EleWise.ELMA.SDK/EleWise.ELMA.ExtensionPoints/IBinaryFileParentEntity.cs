using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.ExtensionPoints;

[ExtensionPoint(ServiceScope.Application, ComponentType.All)]
public interface IBinaryFileParentEntity
{
	IEntity GetEntity(BinaryFile file);

	SystemException CreateEncryptException(object id);
}
