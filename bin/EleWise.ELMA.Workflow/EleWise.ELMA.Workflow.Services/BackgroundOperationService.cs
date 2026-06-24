using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Cache;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.BackgroundOperations;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Models.BackgroundOperations;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

[Service]
public class BackgroundOperationService : IBackgroundOperationService
{
	private struct ActiveBackgroundOperation
	{
		public static readonly ActiveBackgroundOperation Empty;

		public int TaskId;

		public long WorkflowQueueItemId;

		public long BackgroundOperationId;

		public Guid ExecutionUid;

		public Action<long, IBackgroundOperationResult, CancellationToken> OnOperationCompleted;

		public CancellationTokenSource CancellationTokenSource;

		private static object SaDdX4ZGMOoFaue9a1sY;

		public bool Equals(ActiveBackgroundOperation info)
		{
			//Discarded unreachable code: IL_00c8, IL_0112
			int num = 4;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (TaskId == info.TaskId)
					{
						num2 = 3;
						break;
					}
					goto case 1;
				case 2:
					if (BackgroundOperationId == info.BackgroundOperationId)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 7:
					return CancellationTokenSource == info.CancellationTokenSource;
				case 1:
				case 6:
					return false;
				case 5:
					if (!(OnOperationCompleted == info.OnOperationCompleted))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 7;
				case 3:
					if (WorkflowQueueItemId == info.WorkflowQueueItemId)
					{
						num2 = 2;
						break;
					}
					goto case 1;
				default:
					if (!(ExecutionUid == info.ExecutionUid))
					{
						num2 = 6;
						break;
					}
					goto case 5;
				}
			}
		}

		static ActiveBackgroundOperation()
		{
			HcGk1sZGVJKJN5V1Crxv();
		}

		internal static bool jc7UKPZGkRC8nBdgjxlG()
		{
			return SaDdX4ZGMOoFaue9a1sY == null;
		}

		internal static object a2CSlMZGUZwo5CS4GdRq()
		{
			return SaDdX4ZGMOoFaue9a1sY;
		}

		internal static void HcGk1sZGVJKJN5V1Crxv()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private class ActiveOperationsStorage
	{
		private readonly ConcurrentDictionary<long, ActiveBackgroundOperation> activeTasksToOperationIdMap;

		private readonly ConcurrentDictionary<int, ActiveBackgroundOperation> activeTasksToTaskIdMap;

		private readonly ConcurrentDictionary<Guid, ActiveBackgroundOperation> activeTasksToExecutionUid;

		private static object BqgWYLZGAWlGeO07FbN6;

		public void Add(ActiveBackgroundOperation data)
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 3:
					if (!data.Equals(ActiveBackgroundOperation.Empty))
					{
						activeTasksToTaskIdMap[data.TaskId] = data;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
						{
							num2 = 1;
						}
					}
					break;
				default:
					activeTasksToOperationIdMap[data.BackgroundOperationId] = data;
					num2 = 4;
					break;
				case 4:
					activeTasksToExecutionUid[data.ExecutionUid] = data;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					return;
				}
			}
		}

		public ActiveBackgroundOperation GetByTaskId(int taskId)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			ActiveBackgroundOperation value = default(ActiveBackgroundOperation);
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (activeTasksToTaskIdMap.TryGetValue(taskId, out value))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return ActiveBackgroundOperation.Empty;
				case 1:
					return value;
				}
			}
		}

		public ActiveBackgroundOperation GetByOperationId(long operationId)
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 1;
			int num2 = num;
			ActiveBackgroundOperation value = default(ActiveBackgroundOperation);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (activeTasksToOperationIdMap.TryGetValue(operationId, out value))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return ActiveBackgroundOperation.Empty;
				default:
					return value;
				}
			}
		}

		public ActiveBackgroundOperation GetByExecutionUid(Guid executionUid)
		{
			//Discarded unreachable code: IL_005a, IL_0069
			int num = 1;
			int num2 = num;
			ActiveBackgroundOperation value = default(ActiveBackgroundOperation);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (activeTasksToExecutionUid.TryGetValue(executionUid, out value))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return ActiveBackgroundOperation.Empty;
				default:
					return value;
				}
			}
		}

		public void Remove(ActiveBackgroundOperation data)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				ActiveBackgroundOperation value;
				switch (num2)
				{
				case 1:
					return;
				case 3:
					return;
				case 2:
					if (!data.Equals(ActiveBackgroundOperation.Empty))
					{
						U4ANk4ZG20qUTP3W5JxR(data.CancellationTokenSource);
						num2 = 5;
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 1;
					}
					break;
				default:
					activeTasksToOperationIdMap.TryRemove(data.BackgroundOperationId, out value);
					num2 = 4;
					break;
				case 4:
					activeTasksToExecutionUid.TryRemove(data.ExecutionUid, out value);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
					{
						num2 = 2;
					}
					break;
				case 5:
					activeTasksToTaskIdMap.TryRemove(data.TaskId, out value);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public Guid[] GetActiveExecutionsUids()
		{
			return activeTasksToExecutionUid.Keys.ToArray();
		}

		public ActiveOperationsStorage()
		{
			//Discarded unreachable code: IL_005a, IL_005f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			activeTasksToOperationIdMap = new ConcurrentDictionary<long, ActiveBackgroundOperation>();
			activeTasksToTaskIdMap = new ConcurrentDictionary<int, ActiveBackgroundOperation>();
			activeTasksToExecutionUid = new ConcurrentDictionary<Guid, ActiveBackgroundOperation>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool YFI78nZGGSlBEEna9c8g()
		{
			return BqgWYLZGAWlGeO07FbN6 == null;
		}

		internal static ActiveOperationsStorage F8Lf1OZG74n2nbFADrCZ()
		{
			return (ActiveOperationsStorage)BqgWYLZGAWlGeO07FbN6;
		}

		internal static void U4ANk4ZG20qUTP3W5JxR(object P_0)
		{
			((CancellationTokenSource)P_0).Dispose();
		}
	}

	private static readonly ILogger Log;

	private readonly IEnumerable<IBackgroundOperationExecutor> backgroundOperationExecutors;

	private readonly IUnitOfWorkManager unitOfWorkManager;

	private readonly ICacheService cacheService;

	private readonly WorkflowQueueItemManager workflowQueueItemManager;

	private readonly ITimestampService timestampService;

	private readonly ActiveOperationsStorage activeOperations;

	private long nextCancellationTimestamp;

	private int activeOperationsCount;

	internal static BackgroundOperationService kvklo8Crx4neZSJ2L0Y;

	public BackgroundOperationService(IEnumerable<IBackgroundOperationExecutor> backgroundOperationExecutors, IUnitOfWorkManager unitOfWorkManager, ICacheService cacheService, ITimestampService timestampService, WorkflowQueueItemManager workflowQueueItemManager)
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		activeOperations = new ActiveOperationsStorage();
		base._002Ector();
		this.backgroundOperationExecutors = backgroundOperationExecutors;
		this.unitOfWorkManager = unitOfWorkManager;
		this.cacheService = cacheService;
		this.workflowQueueItemManager = workflowQueueItemManager;
		this.timestampService = timestampService;
		nextCancellationTimestamp = timestampService.GetTimestamp();
	}

	[Transaction]
	public virtual bool StartBackgroundOperation(IWorkflowQueueItem queueItem, Guid executionUid, Action<long, IBackgroundOperationResult, CancellationToken> onCompletedAction)
	{
		Contract.ArgumentNotNull(queueItem, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x438A0E43 ^ 0x438AF9A1));
		Contract.ArgumentNotNull(queueItem.BackgroundOperation, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495277812));
		IBackgroundOperationInfo backgroundOperation = queueItem.BackgroundOperation;
		if (backgroundOperation.Status != BackgroundOperationStatus.Prepared)
		{
			return false;
		}
		if (InterlockedExtensions.IncrementIfLess(ref activeOperationsCount, SR.GetSetting(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x69063C81 ^ 0x6906C4B7), 10)))
		{
			_003C_003Ec__DisplayClass12_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
			CS_0024_003C_003E8__locals0._003C_003E4__this = this;
			CS_0024_003C_003E8__locals0.backgroundOperationInfo = ClassSerializationHelper.DeserializeObject(backgroundOperation.OperationData) as IBackgroundOperation;
			if (CS_0024_003C_003E8__locals0.backgroundOperationInfo == null)
			{
				Interlocked.Decrement(ref activeOperationsCount);
				throw new ArgumentNullException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393934670), backgroundOperation.Id, CS_0024_003C_003E8__locals0.backgroundOperationInfo.GetType()));
			}
			CS_0024_003C_003E8__locals0.operationExecutor = backgroundOperationExecutors.FirstOrDefault((IBackgroundOperationExecutor p) => _003C_003Ec__DisplayClass12_0.ssAx6hZGaqkoVXj77l2Z(p, CS_0024_003C_003E8__locals0.backgroundOperationInfo));
			if (CS_0024_003C_003E8__locals0.operationExecutor == null)
			{
				Interlocked.Decrement(ref activeOperationsCount);
				throw new NotImplementedException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -539968385), CS_0024_003C_003E8__locals0.backgroundOperationInfo.GetType()));
			}
			CS_0024_003C_003E8__locals0.cancelationTokenSource = new CancellationTokenSource();
			Task<object> task2 = Task.Factory.StartNew(() => CS_0024_003C_003E8__locals0.operationExecutor.RunTask(CS_0024_003C_003E8__locals0.backgroundOperationInfo, CS_0024_003C_003E8__locals0.cancelationTokenSource.Token)).Unwrap();
			task2.ContinueWith(delegate(Task<object> task)
			{
				CS_0024_003C_003E8__locals0._003C_003E4__this.OnTaskCompleted(task, CS_0024_003C_003E8__locals0.cancelationTokenSource.Token);
			});
			activeOperations.Add(new ActiveBackgroundOperation
			{
				BackgroundOperationId = backgroundOperation.Id,
				ExecutionUid = executionUid,
				CancellationTokenSource = CS_0024_003C_003E8__locals0.cancelationTokenSource,
				OnOperationCompleted = onCompletedAction,
				TaskId = task2.Id,
				WorkflowQueueItemId = queueItem.Id
			});
			return true;
		}
		queueItem.ServerConnectionUid = null;
		queueItem.NextExecuteDate = DateTime.Now.AddSeconds(30.0);
		queueItem.Save();
		return false;
	}

	[Transaction]
	public virtual IWorkflowQueueItem CreateUserCallbackQueueItem(IWorkflowQueueItem backgroundQueueItem, IBackgroundOperationResult result)
	{
		//Discarded unreachable code: IL_006e
		int num = 3;
		ActiveBackgroundOperation activeBackgroundOperation = default(ActiveBackgroundOperation);
		IBackgroundOperationInfo backgroundOperationInfo = default(IBackgroundOperationInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					Contract.ArgumentNotNull(xmkfv5C1B3Yfev4cEiw(backgroundQueueItem), (string)KG5cxeCxvba7kLnsERa(0x738ABA6E ^ 0x738A4026));
					num2 = 8;
					continue;
				case 4:
					if (!activeBackgroundOperation.Equals(ActiveBackgroundOperation.Empty))
					{
						num2 = 7;
						continue;
					}
					goto case 6;
				case 5:
				{
					IWorkflowQueueItem workflowQueueItem = workflowQueueItemManager.CreateQueueItem(backgroundQueueItem.Instance, rZtDGQC4SttTmg550O0(backgroundQueueItem), save: false);
					bEduFSCzD2LlsJUw3JP(workflowQueueItem, backgroundOperationInfo);
					return workflowQueueItem;
				}
				case 8:
					backgroundOperationInfo = (IBackgroundOperationInfo)xmkfv5C1B3Yfev4cEiw(backgroundQueueItem);
					num2 = 9;
					continue;
				case 3:
					LjDKhvCScSXPbXwuLVG(backgroundQueueItem, KG5cxeCxvba7kLnsERa(0x42311138 ^ 0x4231EB26));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					GFG357CwvBkbeFBitXu(backgroundOperationInfo, cDFt4QCE3A0Hy44Gslh(result));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					break;
				case 6:
					return null;
				case 7:
					backgroundOperationInfo.Status = BackgroundOperationStatus.PendingCallback;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					backgroundOperationInfo.Save();
					num2 = 5;
					continue;
				}
				break;
			}
			activeBackgroundOperation = GZfUNhCh2svnrRYfJom(activeOperations, backgroundOperationInfo.Id);
			num = 4;
		}
	}

	public virtual int GetActiveOperationsCount()
	{
		return activeOperationsCount;
	}

	private void OnTaskCompleted(Task<object> task, CancellationToken token)
	{
		ActiveBackgroundOperation byTaskId = activeOperations.GetByTaskId(task.Id);
		if (!byTaskId.Equals(ActiveBackgroundOperation.Empty))
		{
			IBackgroundOperationResult backgroundOperationResult = GetBackgroundOperationResult(task);
			if (backgroundOperationResult != null)
			{
				byTaskId.OnOperationCompleted(byTaskId.WorkflowQueueItemId, backgroundOperationResult, token);
			}
			activeOperations.Remove(byTaskId);
			Interlocked.Decrement(ref activeOperationsCount);
		}
	}

	private IBackgroundOperationResult GetBackgroundOperationResult(Task<object> task)
	{
		if (task.IsCanceled)
		{
			return null;
		}
		if (task.IsFaulted)
		{
			return new BackgroundOperationResult(isError: true, task.Exception);
		}
		if (task.Status == TaskStatus.RanToCompletion)
		{
			return new BackgroundOperationResult(isError: false, task.Result);
		}
		throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516517520)));
	}

	void IBackgroundOperationService.CancelBackgroundOperation(long[] ids)
	{
		//Discarded unreachable code: IL_00f0, IL_00ff, IL_010f
		int num = 6;
		long operationId = default(long);
		long[] array = default(long[]);
		int num3 = default(int);
		ActiveBackgroundOperation activeBackgroundOperation = default(ActiveBackgroundOperation);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					operationId = array[num3];
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					break;
				case 4:
					return;
				default:
					num3 = 0;
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num2 = 2;
					}
					continue;
				case 10:
					oqsL7bMKmhBvU46n8xp(activeBackgroundOperation.CancellationTokenSource, true);
					num2 = 8;
					continue;
				case 3:
				case 7:
					if (num3 >= array.Length)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				case 1:
					activeBackgroundOperation = GZfUNhCh2svnrRYfJom(activeOperations, operationId);
					num2 = 9;
					continue;
				case 5:
					array = ids;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
				case 11:
					num3++;
					num2 = 3;
					continue;
				case 9:
					if (activeBackgroundOperation.Equals(ActiveBackgroundOperation.Empty))
					{
						num2 = 11;
						continue;
					}
					goto case 10;
				}
				break;
			}
			LjDKhvCScSXPbXwuLVG(ids, KG5cxeCxvba7kLnsERa(-642713667 ^ -642773887));
			num = 5;
		}
	}

	void IBackgroundOperationService.ProcessBackgroundOperationsCancellation()
	{
		//Discarded unreachable code: IL_00b8, IL_0141
		int num = 5;
		int num3 = default(int);
		Guid[] array = default(Guid[]);
		string text = default(string);
		ActiveBackgroundOperation activeBackgroundOperation = default(ActiveBackgroundOperation);
		Guid guid = default(Guid);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
				case 7:
					num3++;
					num2 = 10;
					continue;
				case 5:
					if (timestampService.GetTimestamp() >= nextCancellationTimestamp)
					{
						num2 = 4;
						continue;
					}
					return;
				case 14:
					array = (Guid[])OBtRrVMvdxO2nxGWOT6(activeOperations);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 13;
					}
					continue;
				case 11:
					if (cacheService.Contains(text, (string)KG5cxeCxvba7kLnsERa(-2002063381 ^ -2002119699)))
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 3;
				case 8:
					oqsL7bMKmhBvU46n8xp(activeBackgroundOperation.CancellationTokenSource, true);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					j7062XMs0sOl0ugvRxq(cacheService, text);
					num2 = 7;
					continue;
				case 4:
					nextCancellationTimestamp = QYLdMHMZXEdOGvPuF2Q(timestampService, rwvqhrMOWctDTb6XJhy(SR.GetSetting((string)KG5cxeCxvba7kLnsERa(0x438A0E43 ^ 0x438AF505), 1000)));
					num2 = 14;
					continue;
				case 15:
					break;
				case 2:
					guid = array[num3];
					num2 = 15;
					continue;
				default:
					activeBackgroundOperation = M9jqLLM8fQp4BjCyClj(activeOperations, guid);
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
					{
						num2 = 5;
					}
					continue;
				case 12:
					if (activeBackgroundOperation.Equals(ActiveBackgroundOperation.Empty))
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 6:
				case 10:
					if (num3 >= array.Length)
					{
						num2 = 9;
						continue;
					}
					goto case 2;
				case 9:
					return;
				case 13:
					num3 = 0;
					num2 = 6;
					continue;
				}
				break;
			}
			text = (string)wQtqr0MYUNMZU2yXpWA(KG5cxeCxvba7kLnsERa(-1050383744 ^ -1050373838), guid);
			num = 11;
		}
	}

	static BackgroundOperationService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				MAaknqMJirs3Fj4lsjh();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Log = (ILogger)U8roMyMl9UaFAXOmv7R(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74ABBB25));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object KG5cxeCxvba7kLnsERa(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void LjDKhvCScSXPbXwuLVG(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object xmkfv5C1B3Yfev4cEiw(object P_0)
	{
		return ((IWorkflowQueueItem)P_0).BackgroundOperation;
	}

	internal static ActiveBackgroundOperation GZfUNhCh2svnrRYfJom(object P_0, long operationId)
	{
		return ((ActiveOperationsStorage)P_0).GetByOperationId(operationId);
	}

	internal static object cDFt4QCE3A0Hy44Gslh(object P_0)
	{
		return ClassSerializationHelper.SerializeObject(P_0);
	}

	internal static void GFG357CwvBkbeFBitXu(object P_0, object P_1)
	{
		((IBackgroundOperationInfo)P_0).Result = (byte[])P_1;
	}

	internal static Guid rZtDGQC4SttTmg550O0(object P_0)
	{
		return ((IWorkflowQueueItem)P_0).ElementUid;
	}

	internal static void bEduFSCzD2LlsJUw3JP(object P_0, object P_1)
	{
		((IWorkflowQueueItem)P_0).BackgroundOperation = (IBackgroundOperationInfo)P_1;
	}

	internal static bool NMwfpjCewl2Hvhyih6q()
	{
		return kvklo8Crx4neZSJ2L0Y == null;
	}

	internal static BackgroundOperationService q1pIIgCNMwLc6IumB7M()
	{
		return kvklo8Crx4neZSJ2L0Y;
	}

	internal static void oqsL7bMKmhBvU46n8xp(object P_0, bool P_1)
	{
		((CancellationTokenSource)P_0).Cancel(P_1);
	}

	internal static TimeSpan rwvqhrMOWctDTb6XJhy(double P_0)
	{
		return TimeSpan.FromMilliseconds(P_0);
	}

	internal static long QYLdMHMZXEdOGvPuF2Q(object P_0, TimeSpan P_1)
	{
		return ((ITimestampService)P_0).GetTimeStampRelativeToNow(P_1);
	}

	internal static object OBtRrVMvdxO2nxGWOT6(object P_0)
	{
		return ((ActiveOperationsStorage)P_0).GetActiveExecutionsUids();
	}

	internal static object wQtqr0MYUNMZU2yXpWA(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static ActiveBackgroundOperation M9jqLLM8fQp4BjCyClj(object P_0, Guid executionUid)
	{
		return ((ActiveOperationsStorage)P_0).GetByExecutionUid(executionUid);
	}

	internal static void j7062XMs0sOl0ugvRxq(object P_0, object P_1)
	{
		((ICacheService)P_0).Remove((string)P_1);
	}

	internal static void MAaknqMJirs3Fj4lsjh()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object U8roMyMl9UaFAXOmv7R(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
