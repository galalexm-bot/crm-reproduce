using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.ComponentModel;

namespace EleWise.ELMA.Common.BulkDataImport.Handlers;

[ExtensionPoint(ComponentType.All)]
public interface IBulkDataImportHandler
{
	bool CanUse(Type type);

	void BeforeMapping(DataTable data, BulkDataImportHandlerData handlerData);

	void AfterImportPage(IEnumerable<MapInfo> mapInfos, BulkDataImportHandlerData handlerData);

	void AfterImport(BulkDataImportHandlerData handlerData);
}
