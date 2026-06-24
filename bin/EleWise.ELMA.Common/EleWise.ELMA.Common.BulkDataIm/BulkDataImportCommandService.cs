using System;
using EleWise.ELMA.Common.BulkDataImport.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;

namespace EleWise.ELMA.Common.BulkDataImport.Services;

[Service]
internal class BulkDataImportCommandService : IBulkDataImportCommandService
{
	private const string lockCommandKey = "BulkDataImportServiceCommandLock";

	private const string blobCommandKey = "BulkDataImportServiceCommandBlob";

	internal const string CommandUID_S = "C824F2AB-D540-4FDE-BCF4-BBACA68D5C22";

	private Guid CommandUID = new Guid("C824F2AB-D540-4FDE-BCF4-BBACA68D5C22");

	internal const string BulkDataImportServiceCommandDescription = "SR.M('\r\n    /// <code>\r\n    /// //При помощи данного сервиса можно управлять запущенным процессом массового импорта\r\n    /// \r\n    /// //Чтобы отправить команду процессу импорта используйте ExecuteCommand(workUid, command), где\r\n    /// //Guid workUid - уникальный идентификатор процесса массового импорта;\r\n    /// //ImportCommand command - выполняемая команда;\r\n    /// PublicAPI.Services.BulkDataImportCommand.SetCommand(workUid, command);\r\n    /// \r\n    /// //Чтобы получить информацию по запущенному импорту GetCommand(workUid), где\r\n    /// //Guid workUid - уникальный идентификатор процесса массового импорта;\r\n    /// //Возвращает сохранённую команду ImportCommand? - null, если нет сохранённой команды.\r\n    /// PublicAPI.Services.BulkDataImport.GetCommand(workUid);\r\n    /// \r\n    /// //Чтоб удалить текущую сохранённую команду, используйте метод Reset(workUid), где\r\n    /// //Guid workUid - уникальный идентификатор процесса массового импорта;\r\n    /// PublicAPI.Services.BulkDataImport.Reset(workUid);\r\n    /// </code>')";

	public ILockManager LockManager { get; set; }

	public IContextBoundVariableService ContextBoundVariableService { get; set; }

	[PublicApiNodeId("BulkDataImportServicesApi")]
	public void SetCommand(Guid workUid, ImportCommand command)
	{
		ThreadStarter.QueueThread(new BackgroundTask(delegate
		{
			using IUnitOfWork unitOfWork = UnitOfWork.New("");
			using (LockManager.Lock("BulkDataImportServiceCommandLock"))
			{
				DataAccessManager.BLOBManager.SetBLOB(CommandUID, "BulkDataImportServiceCommandBlob" + workUid, command);
			}
			unitOfWork.Commit();
		}, GetType(), "BulkDataImportCommandService", "SetCommand").Execute);
	}

	[PublicApiNodeId("BulkDataImportServicesApi")]
	public ImportCommand? GetCommand(Guid workUid)
	{
		ContextBoundVariableService.ClearCache();
		return DataAccessManager.BLOBManager.GetBLOB<ImportCommand?>(CommandUID, "BulkDataImportServiceCommandBlob" + workUid);
	}

	public void Reset(Guid workUid)
	{
		ThreadStarter.QueueThread(new BackgroundTask(delegate
		{
			using IUnitOfWork unitOfWork = UnitOfWork.New("");
			using (LockManager.Lock("BulkDataImportServiceCommandLock"))
			{
				DataAccessManager.BLOBManager.RemoveBLOB<ImportCommand>(CommandUID, "BulkDataImportServiceCommandBlob" + workUid);
			}
			unitOfWork.Commit();
		}, GetType(), "BulkDataImportCommandService", "Reset").Execute);
	}
}
