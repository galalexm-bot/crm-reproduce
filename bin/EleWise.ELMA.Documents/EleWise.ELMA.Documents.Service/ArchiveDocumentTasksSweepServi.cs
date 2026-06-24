using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Documents.Managers;
using EleWise.ELMA.Documents.Models;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;

namespace EleWise.ELMA.Documents.Services;

[Service]
internal class ArchiveDocumentTasksSweepService
{
	private static readonly Guid ArchiveDocumentTasksSweepQueueUid = new Guid("8C8208E5-3046-4C9F-A537-CBFA1C067321");

	private const string ArchiveDocumentTaskSweepQueueNameKey = "EleWise.ELMA.Documents.Services.ArchiveDocumentTaskSweepQueueNameKey";

	private static readonly Guid ArchiveDocumentSweepQueueUid = new Guid("5E464754-1179-4026-B9B8-817F00AD5FE5");

	private const string ArchiveDocumentSweepQueueNameKey = "EleWise.ELMA.Documents.Services.ArchiveDocumentSweepQueueNameKey";

	private const string LockKey = "EleWise.ELMA.Documents.Services.ArchiveDocumentTasksSweepService.LockKey";

	public static ArchiveDocumentTasksSweepService Instance => Locator.GetServiceNotNull<ArchiveDocumentTasksSweepService>();

	public ILockManager LockManager { get; set; }

	public IUnitOfWorkManager UnitOfWorkManager { get; set; }

	public ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	public void EnqueueDocumentWithTasks(long documentId, IList<ITaskBase> tasks, EleWise.ELMA.Security.Models.IUser user, string comment)
	{
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		using (LockManager.Lock("EleWise.ELMA.Documents.Services.ArchiveDocumentTasksSweepService.LockKey"))
		{
			try
			{
				List<ArchiveDocumentSweepQueueItem> list = LoadDocumentIdsQueue();
				ArchiveDocumentSweepQueueItem archiveDocumentSweepQueueItem = list.FirstOrDefault((ArchiveDocumentSweepQueueItem i) => i.DocumentId == documentId);
				if (archiveDocumentSweepQueueItem == null)
				{
					list.Add(new ArchiveDocumentSweepQueueItem
					{
						DocumentId = documentId,
						UpdateDate = DateTime.Now
					});
				}
				else
				{
					archiveDocumentSweepQueueItem.Holded = false;
					archiveDocumentSweepQueueItem.UpdateDate = DateTime.Now;
				}
				DataAccessManager.BLOBManager.SetBLOB(ArchiveDocumentSweepQueueUid, "EleWise.ELMA.Documents.Services.ArchiveDocumentSweepQueueNameKey", list);
				EnqueueDocumentTasks(documentId, tasks, user, comment);
			}
			catch
			{
				unitOfWork.Rollback();
				return;
			}
			unitOfWork.Commit();
		}
	}

	public List<long> GetQueuedDocumentIds()
	{
		List<long> result = new List<long>();
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		using (LockManager.Lock("EleWise.ELMA.Documents.Services.ArchiveDocumentTasksSweepService.LockKey"))
		{
			try
			{
				result = (from i in LoadDocumentIdsQueue()
					select i.DocumentId).ToList();
			}
			catch
			{
				unitOfWork.Rollback();
				return result;
			}
			unitOfWork.Commit();
			return result;
		}
	}

	public long[] GetFirstQueuedDocumentIds(int count, TimeSpan timeout)
	{
		long[] result = new long[0];
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		using (LockManager.Lock("EleWise.ELMA.Documents.Services.ArchiveDocumentTasksSweepService.LockKey"))
		{
			try
			{
				List<ArchiveDocumentSweepQueueItem> list = LoadDocumentIdsQueue();
				List<ArchiveDocumentSweepQueueItem> list2 = list.Where((ArchiveDocumentSweepQueueItem i) => !i.Holded || (i.Holded && DateTime.Now - i.UpdateDate > timeout)).Take(count).ToList();
				if (list2.Count > 0)
				{
					list2.ForEach(delegate(ArchiveDocumentSweepQueueItem i)
					{
						i.UpdateDate = DateTime.Now;
						i.Holded = true;
					});
					DataAccessManager.BLOBManager.SetBLOB(ArchiveDocumentSweepQueueUid, "EleWise.ELMA.Documents.Services.ArchiveDocumentSweepQueueNameKey", list);
					result = list2.Select((ArchiveDocumentSweepQueueItem i) => i.DocumentId).ToArray();
				}
			}
			catch
			{
				unitOfWork.Rollback();
				return result;
			}
			unitOfWork.Commit();
			return result;
		}
	}

	public void ProcessTopDocumentTasks(long documentId, int tasksCount)
	{
		bool flag = false;
		bool flag2 = false;
		while (!flag)
		{
			using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
			try
			{
				List<ArchiveDocumentTaskSweepQueueItem> list = LoadDocumentTasksQueue(documentId);
				foreach (ArchiveDocumentTaskSweepQueueItem topDocumentTasksQueueItem in GetTopDocumentTasksQueueItems(documentId, tasksCount, list))
				{
					ProcessDocumentTasksQueueItem(documentId, topDocumentTasksQueueItem);
				}
				list.RemoveAll((ArchiveDocumentTaskSweepQueueItem i) => i.Picked && string.IsNullOrEmpty(i.Error));
				flag2 = list.Count == 0;
				flag = flag2 || list.All((ArchiveDocumentTaskSweepQueueItem i) => i.Picked);
				SaveDocumentTasksQueue(documentId, list);
				unitOfWork.Commit();
			}
			catch
			{
				unitOfWork.Rollback();
				return;
			}
		}
		if (flag2)
		{
			RemoveQueuedDocumentId(documentId);
		}
	}

	private void RemoveQueuedDocumentId(long documentId)
	{
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		using (LockManager.Lock("EleWise.ELMA.Documents.Services.ArchiveDocumentTasksSweepService.LockKey"))
		{
			try
			{
				List<ArchiveDocumentSweepQueueItem> value = (from i in LoadDocumentIdsQueue()
					where i.DocumentId != documentId
					select i).ToList();
				DataAccessManager.BLOBManager.SetBLOB(ArchiveDocumentSweepQueueUid, "EleWise.ELMA.Documents.Services.ArchiveDocumentSweepQueueNameKey", value);
			}
			catch
			{
				unitOfWork.Rollback();
				return;
			}
			unitOfWork.Commit();
		}
	}

	private void ReleaseQueuedDocumentId(long documentId)
	{
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		using (LockManager.Lock("EleWise.ELMA.Documents.Services.ArchiveDocumentTasksSweepService.LockKey"))
		{
			try
			{
				List<ArchiveDocumentSweepQueueItem> list = LoadDocumentIdsQueue();
				ArchiveDocumentSweepQueueItem archiveDocumentSweepQueueItem = list.FirstOrDefault((ArchiveDocumentSweepQueueItem i) => i.DocumentId == documentId);
				if (archiveDocumentSweepQueueItem != null)
				{
					archiveDocumentSweepQueueItem.UpdateDate = DateTime.Now;
					archiveDocumentSweepQueueItem.Holded = false;
					DataAccessManager.BLOBManager.SetBLOB(ArchiveDocumentSweepQueueUid, "EleWise.ELMA.Documents.Services.ArchiveDocumentSweepQueueNameKey", list);
				}
			}
			catch
			{
				unitOfWork.Rollback();
				return;
			}
			unitOfWork.Commit();
		}
	}

	private void EnqueueDocumentTasks(long documentId, IList<ITaskBase> tasks, EleWise.ELMA.Security.Models.IUser user, string comment)
	{
		using IUnitOfWork unitOfWork = UnitOfWorkManager.Create(string.Empty, transactional: true);
		try
		{
			List<ArchiveDocumentTaskSweepQueueItem> list = LoadDocumentTasksQueue(documentId);
			bool flag = false;
			foreach (ITaskBase task in tasks)
			{
				if (!list.Any((ArchiveDocumentTaskSweepQueueItem i) => i.TaskId == task.Id))
				{
					list.Add(new ArchiveDocumentTaskSweepQueueItem
					{
						CreationDate = DateTime.Now,
						UserId = user.Id,
						TaskId = task.Id,
						Comment = comment
					});
					flag = true;
				}
			}
			if (flag)
			{
				SaveDocumentTasksQueue(documentId, list);
			}
		}
		catch
		{
			unitOfWork.Rollback();
			return;
		}
		unitOfWork.Commit();
	}

	private List<ArchiveDocumentTaskSweepQueueItem> GetTopDocumentTasksQueueItems(long documentId, int top, List<ArchiveDocumentTaskSweepQueueItem> queue)
	{
		List<ArchiveDocumentTaskSweepQueueItem> list = (from i in queue
			where !i.Picked
			orderby i.CreationDate
			select i).Take(top).ToList();
		foreach (ArchiveDocumentTaskSweepQueueItem item in list)
		{
			item.Picked = true;
		}
		return list;
	}

	private void ProcessDocumentTasksQueueItem(long documentId, ArchiveDocumentTaskSweepQueueItem item)
	{
		InstanceOf<ICommentActionModel> instanceOf = new InstanceOf<ICommentActionModel>();
		ICommentActionModel @new = instanceOf.New;
		InstanceOf<IComment> instanceOf2 = new InstanceOf<IComment>();
		instanceOf2.New.Text = item.Comment;
		@new.Comment = instanceOf2.New;
		ICommentActionModel actionModel = instanceOf.New;
		try
		{
			item.Status = ArchiveDocumentTaskSweepQueueItemStatus.Process;
			SecurityService.RunByUser(item.GetUser(), delegate
			{
				DocumentManager.Instance.TerminateTask(item.GetTask(), actionModel);
			});
		}
		catch (Exception ex)
		{
			string error = ex.Message + Environment.NewLine + ex.StackTrace;
			item.Error = error;
			Logger.Log.Error(SR.T("При обработке элемента очереди отправки документа в архив произошла ошибка (DocumentId={0}, DocumentTaskId={1}).", documentId, item.TaskId), ex);
		}
		finally
		{
			item.Status = ArchiveDocumentTaskSweepQueueItemStatus.Complete;
		}
	}

	private List<ArchiveDocumentTaskSweepQueueItem> LoadDocumentTasksQueue(long documentId)
	{
		List<ArchiveDocumentTaskSweepQueueItem> bLOB = DataAccessManager.BLOBManager.GetBLOB<List<ArchiveDocumentTaskSweepQueueItem>>(ArchiveDocumentTasksSweepQueueUid, "EleWise.ELMA.Documents.Services.ArchiveDocumentTaskSweepQueueNameKey" + documentId);
		if (bLOB == null)
		{
			return new List<ArchiveDocumentTaskSweepQueueItem>();
		}
		return bLOB;
	}

	private List<ArchiveDocumentSweepQueueItem> LoadDocumentIdsQueue()
	{
		List<ArchiveDocumentSweepQueueItem> bLOB = DataAccessManager.BLOBManager.GetBLOB<List<ArchiveDocumentSweepQueueItem>>(ArchiveDocumentSweepQueueUid, "EleWise.ELMA.Documents.Services.ArchiveDocumentSweepQueueNameKey");
		if (bLOB == null)
		{
			return new List<ArchiveDocumentSweepQueueItem>();
		}
		return bLOB;
	}

	private void SaveDocumentTasksQueue(long documentId, List<ArchiveDocumentTaskSweepQueueItem> queue)
	{
		if (queue.Count > 0)
		{
			DataAccessManager.BLOBManager.SetBLOB(ArchiveDocumentTasksSweepQueueUid, "EleWise.ELMA.Documents.Services.ArchiveDocumentTaskSweepQueueNameKey" + documentId, queue);
		}
		else
		{
			DataAccessManager.BLOBManager.RemoveBLOB<List<ArchiveDocumentTaskSweepQueueItem>>(ArchiveDocumentTasksSweepQueueUid, "EleWise.ELMA.Documents.Services.ArchiveDocumentTaskSweepQueueNameKey" + documentId);
		}
	}
}
