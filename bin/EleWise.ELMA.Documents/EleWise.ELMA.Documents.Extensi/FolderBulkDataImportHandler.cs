using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Models;

namespace EleWise.ELMA.Documents.ExtensionPoint;

[Component(Order = 100)]
public class FolderBulkDataImportHandler : DmsObjectBulkDataImportHandler
{
	public override bool CanUse(Type type)
	{
		if (base.CanUse(type))
		{
			return typeof(IFolder).IsAssignableFrom(type);
		}
		return false;
	}

	public override void AfterImportPage(IEnumerable<MapInfo> mapInfos, BulkDataImportHandlerData handlerData)
	{
		base.AfterImportPage(mapInfos, handlerData);
		IEnumerable<Tuple<long, long>> idList = GetIdList(mapInfos, typeof(IFolder));
		if (idList.Any())
		{
			ExecuteInsertPermissions(idList, new List<Guid> { PermissionProvider.DocumentCreatePermission.Id }, GetDmsObjectPermissionTable());
		}
	}

	public override void AfterImport(BulkDataImportHandlerData handlerData)
	{
		AddTypeForCleanUp(typeof(IFolder));
		base.AfterImport(handlerData);
	}
}
