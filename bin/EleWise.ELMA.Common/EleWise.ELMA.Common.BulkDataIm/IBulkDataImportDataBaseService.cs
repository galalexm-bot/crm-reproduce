using System;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.Common.BulkDataImport.Models;

namespace EleWise.ELMA.Common.BulkDataImport.Services;

public interface IBulkDataImportDataBaseService
{
	BulkDataImportDataBaseResult Execute(Guid workUid, MapDataSetList mapDataSetList);
}
