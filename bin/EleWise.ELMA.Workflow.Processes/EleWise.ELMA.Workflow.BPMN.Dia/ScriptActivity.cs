using System;
using System.Activities;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.BackgroundOperations;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Models.BackgroundOperations;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Tasks;

public class ScriptActivity : TaskActivity<ScriptElement>
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		internal static object gfumArH85PZj2yl5KM6;

		public Type ActivityType => typeof(ScriptActivity);

		public Type DiagramElementType => KNRgrNHsnf32Vj0Ogeg(typeof(ScriptElement).TypeHandle);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			j5hvOeH2wKxR37Iajki();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_140e6a1eacec422f932ef627eb6c4c16 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type KNRgrNHsnf32Vj0Ogeg(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void j5hvOeH2wKxR37Iajki()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}

		internal static bool RRmLUvHwSWTyZ9mcQJO()
		{
			return gfumArH85PZj2yl5KM6 == null;
		}

		internal static Info tBkwUYHtDjoLsJIwW3m()
		{
			return (Info)gfumArH85PZj2yl5KM6;
		}
	}

	private readonly Variable<List<Guid>> bgOperationUidsInProgress;

	private readonly WorkflowScriptingService workflowScriptingService;

	private readonly IWorkflowQueueService workflowQueueService;

	private readonly WorkflowQueueItemManager workflowQueueItemManager;

	private readonly IBackgroundOperationService backgroundOperationService;

	internal static ScriptActivity p6HTZYkwu5NerWdrZQU;

	protected override bool CanInduceIdle => true;

	public ScriptActivity(WorkflowScriptingService workflowScriptingService, IWorkflowQueueService workflowQueueService, WorkflowQueueItemManager workflowQueueItemManager, IBackgroundOperationService backgroundOperationService)
	{
		//Discarded unreachable code: IL_002a
		f50mkWk2I1J0kHAGANk();
		bgOperationUidsInProgress = new Variable<List<Guid>>();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			case 1:
				this.backgroundOperationService = backgroundOperationService;
				num = 4;
				break;
			case 3:
			{
				this.workflowScriptingService = workflowScriptingService;
				int num2 = 2;
				num = num2;
				break;
			}
			case 2:
				this.workflowQueueService = workflowQueueService;
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb != 0)
				{
					num = 0;
				}
				break;
			default:
				this.workflowQueueItemManager = workflowQueueItemManager;
				num = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5e3789bc3f974f489e0b5a0c8243b85d == 0)
				{
					num = 1;
				}
				break;
			case 4:
				return;
			}
		}
	}

	protected override void ExecuteTask(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_0149, IL_0158, IL_0168
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 7:
					return;
				case 1:
					return;
				case 8:
					ExecuteScript(context, base.Element.ScriptName);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c == 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					Lseb4BkMws0TgWXprXo(this, context);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_37eee1d96f2f408eb3b01bde6c7d25e0 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (!CanProceed(context))
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					break;
				case 6:
					break;
				case 3:
					baX9CTkQ2C7GdACqbwB(context, IlhvZekqxTqSOdxZ5J1(0x624F2FBE ^ 0x624F2FF4));
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a51554405284f038cd375280fa9ccb8 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					Contract.ServiceNotNull(jd5cQpkVjs7T4yIQBbk(this), (string)IlhvZekqxTqSOdxZ5J1(0x82E000E ^ 0x82E0052));
					num2 = 5;
					continue;
				case 5:
					if (!AXkC2LkKmQvpARE1K05(atRceEkD8jngRFNGn6V(base.Element)))
					{
						num2 = 8;
						continue;
					}
					goto case 9;
				}
				break;
			}
			Lseb4BkMws0TgWXprXo(this, context);
			num = 4;
		}
	}

	protected override void CacheMetadata(NativeActivityMetadata metadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				BGQXUekaW97H6nLArIV(this, metadata);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				metadata.AddImplementationVariable(bgOperationUidsInProgress);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	private void AddInProgressOperation(NativeActivityContext context, Guid taskUid)
	{
		int num = 3;
		int num2 = num;
		List<Guid> list2 = default(List<Guid>);
		while (true)
		{
			List<Guid> list;
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 3:
				list = bgOperationUidsInProgress.Get(context);
				if (list == null)
				{
					num2 = 2;
					continue;
				}
				break;
			case 1:
				list2.Add(taskUid);
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 == 0)
				{
					num2 = 4;
				}
				continue;
			case 4:
				bgOperationUidsInProgress.Set(context, list2);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				list = new List<Guid>();
				break;
			}
			list2 = list;
			num2 = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e != 0)
			{
				num2 = 1;
			}
		}
	}

	private void RemoveInProgressOperation(NativeActivityContext context, Guid taskUid)
	{
		int num = 1;
		int num2 = num;
		List<Guid> list2 = default(List<Guid>);
		while (true)
		{
			List<Guid> list;
			switch (num2)
			{
			case 4:
				bgOperationUidsInProgress.Set(context, list2);
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return;
			case 1:
				list = bgOperationUidsInProgress.Get(context);
				if (list == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1bd128a8000b4a92bbfa94dfdfc79104 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				list2.Remove(taskUid);
				num2 = 4;
				continue;
			default:
				list = new List<Guid>();
				break;
			}
			list2 = list;
			num2 = 3;
		}
	}

	private void CreateBackgroundOperation(NativeActivityContext context, IBackgroundOperation bgOperation, IWorkflowBookmark bookmark)
	{
		int num = 5;
		int num2 = num;
		IBackgroundOperationInfo backgroundOperationInfo = default(IBackgroundOperationInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				backgroundOperationInfo.OperationData = (byte[])OtZycfkYtfpo8NQJaxN(bgOperation);
				num2 = 6;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_25eedcea124a48258fd18106b7da9d93 != 0)
				{
					num2 = 4;
				}
				break;
			default:
				AddInProgressOperation(context, q0x0GDkPvsZYNZnjaKV(backgroundOperationInfo));
				num2 = 2;
				break;
			case 6:
				Fe1N34kvlru4TYn8wPu(backgroundOperationInfo, bookmark);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_931b467c9a154e15b6f12c7011275615 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				backgroundOperationInfo.Status = BackgroundOperationStatus.Prepared;
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				ScheduleBackgroundOperation(context, backgroundOperationInfo);
				num2 = 3;
				break;
			case 5:
				backgroundOperationInfo = InterfaceActivator.Create<IBackgroundOperationInfo>();
				num2 = 4;
				break;
			case 3:
				return;
			}
		}
	}

	private void OnBackgroundOperationCompleted(NativeActivityContext context, Bookmark bookmark, object state)
	{
		//Discarded unreachable code: IL_0120
		int num = 6;
		int num2 = num;
		WorkflowBackgroundOperationExecuteData workflowBackgroundOperationExecuteData = default(WorkflowBackgroundOperationExecuteData);
		while (true)
		{
			switch (num2)
			{
			case 6:
				baX9CTkQ2C7GdACqbwB(state, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-481953825 ^ -481987923));
				num2 = 5;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				RemoveInProgressOperation(context, q0x0GDkPvsZYNZnjaKV(workflowBackgroundOperationExecuteData.BackgroundOperation));
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				workflowBackgroundOperationExecuteData = state as WorkflowBackgroundOperationExecuteData;
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				return;
			case 8:
				return;
			default:
				ContinueOnDefaultConnector(context);
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb == 0)
				{
					num2 = 8;
				}
				break;
			case 7:
				ExecuteUserCallback(context, workflowBackgroundOperationExecuteData);
				num2 = 4;
				break;
			case 1:
				if (!CanProceed(context))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9da417d3072c4857ad8a08ca0cf38980 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (workflowBackgroundOperationExecuteData == null)
				{
					num2 = 2;
					break;
				}
				goto case 7;
			}
		}
	}

	private void ExecuteUserCallback(NativeActivityContext context, WorkflowBackgroundOperationExecuteData data)
	{
		//Discarded unreachable code: IL_00ab, IL_00ba, IL_00f4, IL_0113, IL_0129, IL_01dc, IL_0218, IL_0227, IL_02c2, IL_034d, IL_035c
		int num = 1;
		IBackgroundOperationResult backgroundOperationResult = default(IBackgroundOperationResult);
		Exception ex = default(Exception);
		BaseBackgroundOperationWithCallbacks baseBackgroundOperationWithCallbacks = default(BaseBackgroundOperationWithCallbacks);
		IBackgroundOperationInfo backgroundOperation = default(IBackgroundOperationInfo);
		Dictionary<string, object> dictionary = default(Dictionary<string, object>);
		string[] array = default(string[]);
		string method = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				object obj2;
				switch (num2)
				{
				case 24:
					backgroundOperationResult = (IBackgroundOperationResult)dLa0KVk9YTrL8Qg8MHH(data);
					num2 = 7;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_77bc2455d9c3443ca1c76a1788888437 == 0)
					{
						num2 = 9;
					}
					continue;
				case 8:
					throw ex;
				case 5:
					return;
				case 17:
				case 25:
					if (UOxKEWkcRWmbBy3SPrm(backgroundOperationResult))
					{
						num2 = 18;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 21;
				case 21:
					obj = LgcZUqkTvhApJbq1Jnv(elv8vkkjlPtE1liuGHy(baseBackgroundOperationWithCallbacks));
					goto IL_0389;
				case 10:
					obj2 = gMoNugkSq4ObecXPR6W(elv8vkkjlPtE1liuGHy(baseBackgroundOperationWithCallbacks));
					goto IL_03b1;
				case 22:
					backgroundOperation.Status = BackgroundOperationStatus.Completed;
					num2 = 19;
					continue;
				case 6:
					dictionary = new Dictionary<string, object> { 
					{
						array[0],
						workflowScriptingService.GetScriptInstance((IWorkflowInstance)M7fZu9kbU6NN3PxeJ5G(P69iZxkkKssyKwUdy0X(data)))
					} };
					num2 = 14;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 == 0)
					{
						num2 = 3;
					}
					continue;
				case 11:
				case 13:
					ExecuteScript(context, method, dictionary, (IWorkflowBookmark)K5OJZokUF1X5aJvm7ia(backgroundOperation));
					num2 = 22;
					continue;
				case 19:
					A0EkRekmQ8F11gZk7K3(backgroundOperation);
					num = 7;
					break;
				case 15:
					if (!AXkC2LkKmQvpARE1K05(LgcZUqkTvhApJbq1Jnv(baseBackgroundOperationWithCallbacks.SuccessCallback)))
					{
						num2 = 20;
						continue;
					}
					return;
				default:
					baseBackgroundOperationWithCallbacks = ia9symk4xUkIbjMKc7Z(backgroundOperation.OperationData) as BaseBackgroundOperationWithCallbacks;
					num2 = 24;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9f9823be58b94730af510f3472045ea6 != 0)
					{
						num2 = 23;
					}
					continue;
				case 1:
					backgroundOperation = data.BackgroundOperation;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					return;
				case 3:
					dictionary.Add(array[1], ia9symk4xUkIbjMKc7Z(S64TQDkdgRUaywJuDVX(backgroundOperationResult)));
					num2 = 13;
					continue;
				case 4:
					return;
				case 20:
					if (!UOxKEWkcRWmbBy3SPrm(backgroundOperationResult))
					{
						num2 = 25;
						continue;
					}
					goto case 16;
				case 16:
					if (!AXkC2LkKmQvpARE1K05(LgcZUqkTvhApJbq1Jnv(APXy2LkN9aLqSQUlWCu(baseBackgroundOperationWithCallbacks))))
					{
						num2 = 17;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_a9f4f79195cf4308a30b686c5cb386e5 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 23;
				case 9:
					if (!backgroundOperationResult.IsError)
					{
						num2 = 3;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 20;
				case 23:
					ex = ia9symk4xUkIbjMKc7Z(S64TQDkdgRUaywJuDVX(backgroundOperationResult)) as Exception;
					num = 12;
					break;
				case 12:
					if (ex == null)
					{
						num2 = 5;
						continue;
					}
					goto case 8;
				case 14:
					if (array.Length <= 1)
					{
						num2 = 11;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd == 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 3;
				case 2:
					if (!UOxKEWkcRWmbBy3SPrm(backgroundOperationResult))
					{
						num2 = 10;
						continue;
					}
					obj2 = gMoNugkSq4ObecXPR6W(APXy2LkN9aLqSQUlWCu(baseBackgroundOperationWithCallbacks));
					goto IL_03b1;
				case 18:
					{
						obj = LgcZUqkTvhApJbq1Jnv(APXy2LkN9aLqSQUlWCu(baseBackgroundOperationWithCallbacks));
						goto IL_0389;
					}
					IL_03b1:
					array = (string[])obj2;
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_98890646a18d4a91b352a4ea5d1be319 != 0)
					{
						num2 = 6;
					}
					continue;
					IL_0389:
					method = (string)obj;
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	private void ExecuteScript(NativeActivityContext context, string method, Dictionary<string, object> inputArgs = null, IWorkflowBookmark boundBookmark = null)
	{
		IWorkflowInstance instance = GetInstance(context);
		if (base.WorkflowScriptingService.ExecuteScript(instance, method, inputArgs) is IBackgroundOperation bgOperation)
		{
			IWorkflowBookmark bookmark = boundBookmark ?? CreateBookmark(instance);
			CreateBackgroundOperation(context, bgOperation, bookmark);
		}
	}

	private bool CanProceed(NativeActivityContext context)
	{
		int num = 1;
		int num2 = num;
		List<Guid> list;
		while (true)
		{
			switch (num2)
			{
			case 1:
				list = bgOperationUidsInProgress.Get(context);
				if (list != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d526d6cd8ea24dfca60f96f0f0be6307 != 0)
				{
					num2 = 0;
				}
				continue;
			default:
				list = new List<Guid>();
				break;
			}
			break;
		}
		return lcYfGYkAIsajeJPX2Aa(list) == 0;
	}

	private void QueueActivity(IWorkflowInstance instance, Element element, IBackgroundOperationInfo bgOperationInfo)
	{
		//Discarded unreachable code: IL_0075, IL_0084
		int num = 3;
		IWorkflowQueueItem workflowQueueItem = default(IWorkflowQueueItem);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 5:
					return;
				case 2:
					Contract.ArgumentNotNull(element, (string)IlhvZekqxTqSOdxZ5J1(0x713816B4 ^ 0x71389AD0));
					num2 = 4;
					continue;
				case 1:
					break;
				case 3:
					baX9CTkQ2C7GdACqbwB(instance, IlhvZekqxTqSOdxZ5J1(-182059571 ^ -182068585));
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0c2830bb8fb347508ec492b48872fee7 != 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
				{
					bool num3 = SR.GetSetting((string)IlhvZekqxTqSOdxZ5J1(0x29336E79 ^ 0x2933E1DB), 10) - kISK9IkpTQScP4ioejw(backgroundOperationService) > 0;
					workflowQueueItem = (IWorkflowQueueItem)spnrHYkGP6Q07ymXioS(workflowQueueItemManager, instance, element, false);
					if (!num3)
					{
						workflowQueueItem.ServerConnectionUid = null;
					}
					workflowQueueItem.BackgroundOperation = bgOperationInfo;
					workflowQueueItem.Save();
					if (!num3)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				}
				break;
			}
			workflowQueueService.ProcessItemAsyncAfterCommit(workflowQueueItem);
			num = 5;
		}
	}

	private void ScheduleBackgroundOperation(NativeActivityContext context, IBackgroundOperationInfo bgOperationInfo)
	{
		int num = 4;
		int num2 = num;
		IWorkflowInstance instance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			case 2:
				QueueActivity(instance, base.Element, bgOperationInfo);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				GvQvORknOh2Q9JOATx2(base.Element, IlhvZekqxTqSOdxZ5J1(-92270799 ^ -92241699));
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				EbaYHjk6s8lR2bjOLTd(context, YxT8PBkO5me2l3TZ0Od(K5OJZokUF1X5aJvm7ia(bgOperationInfo)).ToString(), new BookmarkCallback(OnBackgroundOperationCompleted));
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				instance = (IWorkflowInstance)h26Hf3kyOxKmVgv4UHE(this, context);
				num2 = 2;
				break;
			case 1:
				return;
			}
		}
	}

	internal static void f50mkWk2I1J0kHAGANk()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static bool SuvyQoktZCS8DjXyml6()
	{
		return p6HTZYkwu5NerWdrZQU == null;
	}

	internal static ScriptActivity ILs6DEksOtS8JI0WDb2()
	{
		return p6HTZYkwu5NerWdrZQU;
	}

	internal static object IlhvZekqxTqSOdxZ5J1(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void baX9CTkQ2C7GdACqbwB(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object jd5cQpkVjs7T4yIQBbk(object P_0)
	{
		return ((WorkflowActivity)P_0).WorkflowRuntimeService;
	}

	internal static object atRceEkD8jngRFNGn6V(object P_0)
	{
		return ((ScriptElement)P_0).ScriptName;
	}

	internal static bool AXkC2LkKmQvpARE1K05(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void Lseb4BkMws0TgWXprXo(object P_0, object P_1)
	{
		((WorkflowActivity)P_0).ContinueOnDefaultConnector((NativeActivityContext)P_1);
	}

	internal static void BGQXUekaW97H6nLArIV(object P_0, NativeActivityMetadata P_1)
	{
		((NativeActivity<ActivityExecuteResult>)P_0).CacheMetadata(P_1);
	}

	internal static object OtZycfkYtfpo8NQJaxN(object P_0)
	{
		return ClassSerializationHelper.SerializeObject(P_0);
	}

	internal static void Fe1N34kvlru4TYn8wPu(object P_0, object P_1)
	{
		((IBackgroundOperationInfo)P_0).BoundBookmark = (IWorkflowBookmark)P_1;
	}

	internal static Guid q0x0GDkPvsZYNZnjaKV(object P_0)
	{
		return ((IBackgroundOperationInfo)P_0).Uid;
	}

	internal static object ia9symk4xUkIbjMKc7Z(object P_0)
	{
		return ClassSerializationHelper.DeserializeObject((byte[])P_0);
	}

	internal static object dLa0KVk9YTrL8Qg8MHH(object P_0)
	{
		return ((WorkflowBackgroundOperationExecuteData)P_0).BackgroundOperationResult;
	}

	internal static object LgcZUqkTvhApJbq1Jnv(object P_0)
	{
		return ((ICallbackDelegate)P_0).DelegateSignature;
	}

	internal static bool UOxKEWkcRWmbBy3SPrm(object P_0)
	{
		return ((IBackgroundOperationResult)P_0).IsError;
	}

	internal static object APXy2LkN9aLqSQUlWCu(object P_0)
	{
		return ((BaseBackgroundOperationWithCallbacks)P_0).ErrorCallback;
	}

	internal static object S64TQDkdgRUaywJuDVX(object P_0)
	{
		return ((IBackgroundOperationResult)P_0).SerializedResult;
	}

	internal static object elv8vkkjlPtE1liuGHy(object P_0)
	{
		return ((BaseBackgroundOperationWithCallbacks)P_0).SuccessCallback;
	}

	internal static object gMoNugkSq4ObecXPR6W(object P_0)
	{
		return ((ICallbackDelegate)P_0).ArgumentNames;
	}

	internal static object P69iZxkkKssyKwUdy0X(object P_0)
	{
		return ((WorkflowBackgroundOperationExecuteData)P_0).Bookmark;
	}

	internal static object M7fZu9kbU6NN3PxeJ5G(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object K5OJZokUF1X5aJvm7ia(object P_0)
	{
		return ((IBackgroundOperationInfo)P_0).BoundBookmark;
	}

	internal static void A0EkRekmQ8F11gZk7K3(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static int lcYfGYkAIsajeJPX2Aa(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static int kISK9IkpTQScP4ioejw(object P_0)
	{
		return ((IBackgroundOperationService)P_0).GetActiveOperationsCount();
	}

	internal static object spnrHYkGP6Q07ymXioS(object P_0, object P_1, object P_2, bool P_3)
	{
		return ((WorkflowQueueItemManager)P_0).CreateQueueItem((IWorkflowInstance)P_1, (Element)P_2, P_3);
	}

	internal static void GvQvORknOh2Q9JOATx2(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static object h26Hf3kyOxKmVgv4UHE(object P_0, object P_1)
	{
		return ((WorkflowActivity)P_0).GetInstance((NativeActivityContext)P_1);
	}

	internal static Guid YxT8PBkO5me2l3TZ0Od(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Uid;
	}

	internal static object EbaYHjk6s8lR2bjOLTd(object P_0, object P_1, object P_2)
	{
		return ((NativeActivityContext)P_0).CreateBookmark((string)P_1, (BookmarkCallback)P_2);
	}
}
