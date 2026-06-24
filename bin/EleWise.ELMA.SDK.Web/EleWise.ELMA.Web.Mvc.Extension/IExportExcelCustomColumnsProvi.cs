using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Types;

namespace EleWise.ELMA.Web.Mvc.ExtensionPoints;

[ExtensionPoint(ServiceScope.Shell, ComponentType.All)]
public interface IExportExcelCustomColumnsProvider : IExportExcelValueProvider
{
	IEnumerable<ExportColumnDescription> GetColumns(Type type, IEnumerable<ExportColumnDescription> baseColumns);
}
