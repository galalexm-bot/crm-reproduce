using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IExportExcelValueProvider
{
	bool Resolve(IEntity entity, Guid propertyUid);

	object GetValue(IEntity entity, Guid propertyUid);
}
