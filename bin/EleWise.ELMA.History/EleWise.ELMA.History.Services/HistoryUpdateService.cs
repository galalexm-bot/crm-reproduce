using System;
using System.Collections.Generic;
using System.Data;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.History.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.NH;

namespace EleWise.ELMA.History.Services;

[Service]
internal sealed class HistoryUpdateService : IHistoryUpdateService
{
	private readonly IUnitOfWorkManager unitOfWorkManager;

	private readonly IHistoryUpdateQueueItemRepository historyUpdateQueueItemRepository;

	private readonly IHistoryService historyService;

	public HistoryUpdateService(IUnitOfWorkManager unitOfWorkManager, IHistoryUpdateQueueItemRepository historyUpdateQueueItemRepository, IHistoryService historyService)
	{
		this.unitOfWorkManager = unitOfWorkManager;
		this.historyUpdateQueueItemRepository = historyUpdateQueueItemRepository;
		this.historyService = historyService;
	}

	public void UpdateHistory(HistoryUpdateQueueItem queueItem)
	{
		using IUnitOfWork unitOfWork = unitOfWorkManager.Create(string.Empty, transactional: true, IsolationLevel.ReadCommitted);
		bool flag = false;
		try
		{
			IEnumerable<InverseRelatedEntityModel> enumerable = UpdateInternal(queueItem);
			if (enumerable == null)
			{
				historyUpdateQueueItemRepository.DeleteQueueItem(queueItem);
			}
			else
			{
				historyUpdateQueueItemRepository.DeleteQueueItem(queueItem);
				historyUpdateQueueItemRepository.BulkInsertQueueItems(enumerable, forDelete: false);
			}
			unitOfWork.Commit();
		}
		catch (Exception exception)
		{
			flag = true;
			Logger.Log.Error(SR.T("Ошибка обработки элемента очереди '{0}' для объекта '{1}:{2}'", queueItem.Id, queueItem.ObjectId, queueItem.ObjectTypeUid), exception);
			unitOfWork.Rollback();
		}
		if (flag && queueItem.Attempt < HistoryUpdateQueueItemRepository.AttemptIntervals.Length - 1)
		{
			DateTime now = DateTime.Now;
			queueItem.Attempt++;
			queueItem.LastUpdateDate = now;
			queueItem.NextUpdateDate = now + HistoryUpdateQueueItemRepository.AttemptIntervals[queueItem.Attempt];
			queueItem.ServerConnectionUid = null;
			try
			{
				historyUpdateQueueItemRepository.UpdateQueueItem(queueItem);
				unitOfWork.Commit();
				return;
			}
			catch (Exception exception2)
			{
				Logger.Log.Error(SR.T("Не удалось обновить элемент очереди обновления истории '{0}'", queueItem.Id), exception2);
				unitOfWork.Rollback();
				return;
			}
		}
	}

	private IEnumerable<InverseRelatedEntityModel> UpdateInternal(HistoryUpdateQueueItem queueItem)
	{
		try
		{
			if (queueItem.DeleteRelated)
			{
				if (queueItem.ObjectId < 0)
				{
					return historyService.DeleteRecordsByType(queueItem.ObjectTypeUid);
				}
				historyService.DeleteRecord(queueItem.ObjectId, queueItem.ObjectTypeUid);
			}
			else
			{
				historyService.CacheObjectHistory(queueItem.ObjectId, queueItem.ObjectTypeUid, queueItem.LastActionDate);
			}
		}
		catch (Exception ex)
		{
			Logger.Log.Error(SR.T("В ходе обновления истории возникла ошибка"), ex);
			throw ex;
		}
		return null;
	}
}
