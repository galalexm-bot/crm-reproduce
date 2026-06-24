using System;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IModelTypeMetadataExtensionPoint
{
	bool CanUse(Type containerType);

	Type GetModelType(Type containerType, object container);
}
