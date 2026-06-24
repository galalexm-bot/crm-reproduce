using System;
using EleWise.ELMA.Common.BulkDataImport.DataSources;
using EleWise.ELMA.Common.BulkDataImport.Mapping;
using EleWise.ELMA.Common.BulkDataImport.Models;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Common.BulkDataImport.Services;

[DeveloperApi(DeveloperApiType.Service)]
[PublicApiMember("BulkDataImportServicesApi", "SR.M('Массовый импорт объектов в систему')", "SR.M('\r\n    /// <code>\r\n    /// //При помощи данного сервиса осуществляется массовый импорт объектов в систему\n    /// \n    /// //Чтобы импортировать объекты в основную базу данных используйте Import(dataSource, mapBuilder), где\r\n    /// //IDataSource dataSource - источник данных;\r\n    /// //<c>IDataSource</c> - Источник данных.\r\n    /// //<c>MapBuilderBase</c> mapBuilder - маппинг объектов;\r\n    /// PublicAPI.Services.BulkDataImport.Import(dataSource, mapBuilder);\r\n    /// \r\n    /// //Чтобы получить информацию по запущенному импорту используйте GetImportProgressInfo(workUid), где\r\n    /// //<c>Guid</c> workUid - уникальный идентификатор работы;\r\n    /// PublicAPI.Services.BulkDataImport.GetImportProgressInfo(workUid);\r\n    /// </code>')")]
public interface IBulkDataImportService
{
	[PublicApiNodeId("BulkDataImportServicesApi")]
	Guid Import(IDataSource dataSource, MapBuilderBase mapBuilder);

	[PublicApiNodeId("BulkDataImportServicesApi")]
	BulkDataImportProgressInfo GetImportProgressInfo(Guid workUid);
}
