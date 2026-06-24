using System;
using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IExportExcelStyledValueProvider : IExportExcelValueProvider
{
	object GetStyledValue(IEntity entity, Guid propertyUid, Style cellStyle);
}
