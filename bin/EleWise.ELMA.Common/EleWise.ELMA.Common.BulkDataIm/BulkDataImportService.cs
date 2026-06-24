using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.BulkDataImport.DataSources;
using EleWise.ELMA.Common.BulkDataImport.Handlers;
using EleWise.ELMA.Common.BulkDataImport.Helpers;
using EleWise.ELMA.Common.BulkDataImport.Mapping;
using EleWise.ELMA.Common.BulkDataImport.Mapping.Models;
using EleWise.ELMA.Common.BulkDataImport.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Threading;

namespace EleWise.ELMA.Common.BulkDataImport.Services;

[Service]
internal class BulkDataImportService : IBulkDataImportService
{
	private const string lockKey = "BulkDataImportServiceLock";

	private const string blobKey = "BulkDataImportServiceBlob";

	private const string loggerKey = "BulkDataImportService";

	private const string UID_S = "B5D3969A-62BE-42E6-AC23-D4507C567152";

	private Guid UID = new Guid("B5D3969A-62BE-42E6-AC23-D4507C567152");

	public const string BulkDataImportServiceDescription = "SR.M('\r\n    /// <code>\r\n    /// //При помощи данного сервиса осуществляется массовый импорт объектов в систему\n    /// \n    /// //Чтобы импортировать объекты в основную базу данных используйте Import(dataSource, mapBuilder), где\r\n    /// //IDataSource dataSource - источник данных;\r\n    /// //<c>IDataSource</c> - Источник данных.\r\n    /// //<c>MapBuilderBase</c> mapBuilder - маппинг объектов;\r\n    /// PublicAPI.Services.BulkDataImport.Import(dataSource, mapBuilder);\r\n    /// \r\n    /// //Чтобы получить информацию по запущенному импорту используйте GetImportProgressInfo(workUid), где\r\n    /// //<c>Guid</c> workUid - уникальный идентификатор работы;\r\n    /// PublicAPI.Services.BulkDataImport.GetImportProgressInfo(workUid);\r\n    /// </code>')";

	public IEnumerable<IBulkDataImportHandler> BulkDataImportHandlers { get; set; }

	public ICacheService CacheService { get; set; }

	public IBulkDataImportDataBaseService BulkDataImportDataBaseService { get; set; }

	public IBulkDataImportCommandService BulkDataImportCommandService { get; set; }

	public ILockManager LockManager { get; set; }

	[PublicApiNodeId("BulkDataImportServicesApi")]
	public Guid Import(IDataSource dataSource, MapBuilderBase mapBuilder)
	{
		List<IBulkDataImportHandler> handlers = BulkDataImportHandlers.Where((IBulkDataImportHandler a) => a.CanUse(mapBuilder.BuilderType())).ToList();
		Guid guid = Guid.NewGuid();
		ThreadStarter.StartNewThread(new BackgroundTask(delegate
		{
			RunImport(dataSource, mapBuilder, handlers, guid);
		}, typeof(MapBuilderBase), "RunImport", "RunImport").Execute);
		return guid;
	}

	[PublicApiNodeId("BulkDataImportServicesApi")]
	public BulkDataImportProgressInfo GetImportProgressInfo(Guid workUid)
	{
		if (!CacheService.TryGetValue<BulkDataImportProgressInfo>("BulkDataImportServiceBlob" + workUid, out var value))
		{
			return null;
		}
		return value;
	}

	private void RunImport(IDataSource dataSource, MapBuilderBase mapBuilder, IEnumerable<IBulkDataImportHandler> handlers, Guid workUid)
	{
		Guid logKey = Guid.NewGuid();
		SetImportStart(workUid);
		using BulkDataImportLogger bulkDataImportLogger = new BulkDataImportLogger(BulkDataImportLogger.LoggerPartName, "Import", logKey);
		try
		{
			BulkDataImportProgressInfo bulkDataImportProgressInfo = new BulkDataImportProgressInfo(workUid, ImportOperations.GetDataSourcePacket, OperationStatus.InProgress)
			{
				PackageSize = dataSource.PackageSize
			};
			UpdateImportInfo(workUid, bulkDataImportProgressInfo);
			BulkDataImportHandlerData bulkDataImportHandlerData = new BulkDataImportHandlerData();
			BulkDataImportHelper.CheckStopCommand(workUid);
			while (dataSource.Read())
			{
				BulkDataImportHelper.CheckStopCommand(workUid);
				using DataTable dataTable = dataSource.Current;
				bulkDataImportHandlerData.SetPackageNextIndex();
				bulkDataImportProgressInfo.CurrentOperation = ImportOperations.MappingData;
				bulkDataImportProgressInfo.PackageCount = dataSource.Count();
				bulkDataImportProgressInfo.CurrentPackage = dataSource.CurrentIndex;
				UpdateImportInfo(workUid, bulkDataImportProgressInfo);
				foreach (IBulkDataImportHandler handler in handlers)
				{
					BulkDataImportHelper.CheckStopCommand(workUid);
					try
					{
						handler.BeforeMapping(dataTable, bulkDataImportHandlerData);
					}
					catch (Exception exception)
					{
						bulkDataImportLogger.Error(exception);
						return;
					}
				}
				UpdateImportInfo(workUid, bulkDataImportProgressInfo, ImportOperations.RecordData);
				DateTime now = DateTime.Now;
				using MapDataSetList mapDataSetList = mapBuilder.SetDataSource(dataTable).Map();
				bulkDataImportLogger.Info("mapping", now);
				bulkDataImportProgressInfo.CurrentOperation = ImportOperations.RecordData;
				UpdateImportInfo(workUid, bulkDataImportProgressInfo);
				using (bulkDataImportLogger.InnerLogger("BulkDataImportService.executeResult"))
				{
					BulkDataImportDataBaseResult bulkDataImportDataBaseResult = BulkDataImportDataBaseService.Execute(workUid, mapDataSetList);
					if (!bulkDataImportDataBaseResult.Success)
					{
						bulkDataImportLogger.Error(new Exception("Произошла ошибка во время записи данных в базу", bulkDataImportDataBaseResult.Exception));
						return;
					}
				}
				bulkDataImportProgressInfo.CurrentOperation = ImportOperations.UserAction;
				UpdateImportInfo(workUid, bulkDataImportProgressInfo);
				using (bulkDataImportLogger.InnerLogger("BulkDataImportService.afterImportPageAction"))
				{
					foreach (IBulkDataImportHandler handler2 in handlers)
					{
						BulkDataImportHelper.CheckStopCommand(workUid);
						handler2.AfterImportPage(mapDataSetList.Items, bulkDataImportHandlerData);
					}
				}
			}
			using (bulkDataImportLogger.InnerLogger("BulkDataImportService.afterImportAllAction"))
			{
				foreach (IBulkDataImportHandler handler3 in handlers)
				{
					BulkDataImportHelper.CheckStopCommand(workUid);
					try
					{
						handler3.AfterImport(bulkDataImportHandlerData);
					}
					catch (Exception exception2)
					{
						bulkDataImportLogger.Error(exception2);
						break;
					}
				}
			}
		}
		catch (Exception exception3)
		{
			bulkDataImportLogger.Error(exception3);
		}
		finally
		{
			dataSource.CleanUp();
			SetImportEnd(workUid);
		}
	}

	private void SetImportStart(Guid uid)
	{
		using (LockManager.Lock("BulkDataImportServiceLock"))
		{
			CacheService.Insert("BulkDataImportServiceBlob" + uid, new BulkDataImportProgressInfo(uid, ImportOperations.StartExecute, OperationStatus.InProgress));
		}
	}

	private void UpdateImportInfo(Guid uid, BulkDataImportProgressInfo info, ImportOperations? operation = null)
	{
		if (operation.HasValue)
		{
			info.CurrentOperation = operation.Value;
		}
		using (LockManager.Lock("BulkDataImportServiceLock"))
		{
			CacheService.Insert("BulkDataImportServiceBlob" + uid, info);
		}
	}

	private void SetImportEnd(Guid uid)
	{
		using (LockManager.Lock("BulkDataImportServiceLock"))
		{
			CacheService.Remove("BulkDataImportServiceBlob" + uid);
			BulkDataImportCommandService.Reset(uid);
		}
	}
}
