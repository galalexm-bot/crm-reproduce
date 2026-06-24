using System;
using EleWise.ELMA.Common.BulkDataImport.Models;
using EleWise.ELMA.Model.Attributes;

namespace EleWise.ELMA.Common.BulkDataImport.Services;

[DeveloperApi(DeveloperApiType.Service)]
[PublicApiMember("BulkDataImportServicesApi", "SR.M('Сервис для выполнения команды в процессе массового импорта объектов в систему')", "SR.M('\r\n    /// <code>\r\n    /// //При помощи данного сервиса можно управлять запущенным процессом массового импорта\r\n    /// \r\n    /// //Чтобы отправить команду процессу импорта используйте ExecuteCommand(workUid, command), где\r\n    /// //Guid workUid - уникальный идентификатор процесса массового импорта;\r\n    /// //ImportCommand command - выполняемая команда;\r\n    /// PublicAPI.Services.BulkDataImportCommand.SetCommand(workUid, command);\r\n    /// \r\n    /// //Чтобы получить информацию по запущенному импорту GetCommand(workUid), где\r\n    /// //Guid workUid - уникальный идентификатор процесса массового импорта;\r\n    /// //Возвращает сохранённую команду ImportCommand? - null, если нет сохранённой команды.\r\n    /// PublicAPI.Services.BulkDataImport.GetCommand(workUid);\r\n    /// \r\n    /// //Чтоб удалить текущую сохранённую команду, используйте метод Reset(workUid), где\r\n    /// //Guid workUid - уникальный идентификатор процесса массового импорта;\r\n    /// PublicAPI.Services.BulkDataImport.Reset(workUid);\r\n    /// </code>')")]
public interface IBulkDataImportCommandService
{
	[PublicApiNodeId("BulkDataImportServicesApi")]
	void SetCommand(Guid workUid, ImportCommand command);

	ImportCommand? GetCommand(Guid workUid);

	void Reset(Guid workUid);
}
