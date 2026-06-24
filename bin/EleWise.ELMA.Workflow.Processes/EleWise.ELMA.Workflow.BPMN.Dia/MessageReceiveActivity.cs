using System;
using System.Activities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web.Script.Serialization;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.Audit;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scheduling;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Activities.Tasks;

public class MessageReceiveActivity : TaskActivity<MessageReceiveElement>, IActivityNotificationRecipientsByExecutors, IActivityNotificationRecipients
{
	[Component]
	private class Info : IWorkflowActivityInfo
	{
		internal static object U8lFLwWDBoXl0Kh5KLM;

		public Type ActivityType => o3UVHeWa9XaxM7pVL4p(typeof(MessageReceiveActivity).TypeHandle);

		public Type DiagramElementType => typeof(MessageReceiveElement);

		public Info()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			em2j85WY7yaQJmRimNi();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a731ad20cd44175bde6db1171290626 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type o3UVHeWa9XaxM7pVL4p(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static void em2j85WY7yaQJmRimNi()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		}

		internal static bool BMi5aEWKanFbEPvRlFk()
		{
			return U8lFLwWDBoXl0Kh5KLM == null;
		}

		internal static Info R3ipsvWMdJsJpydNrQN()
		{
			return (Info)U8lFLwWDBoXl0Kh5KLM;
		}
	}

	private Variable<long?> messageBookmarkId;

	private static readonly ILogger logger;

	private static MessageReceiveActivity NyPKSxdIbv4BpnwpVW7;

	public WorkflowMessageItemManager WorkflowMessageItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowMessageItemManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CWorkflowMessageItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3059bb5cee2f4eb68ccea048bb8e848c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowMessageBookmarkManager WorkflowMessageBookmarkManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowMessageBookmarkManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CWorkflowMessageBookmarkManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67c4b8cf6de246108f53fc3d72e6757a != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public WorkflowQueueItemManager WorkflowQueueItemManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowQueueItemManager_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CWorkflowQueueItemManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_fc30864faaad488ba50da4607dce40b9 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public IWorkflowQueueService WorkflowQueueService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowQueueService_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CWorkflowQueueService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e496a9998cf542ff98d1a5e001d6c664 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected override bool CanInduceIdle => true;

	protected override void CacheMetadata(NativeActivityMetadata metadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				metadata.AddImplementationVariable(messageBookmarkId);
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_9747bbf97f854087a2d2f13ea94f4085 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				tmgHEQjEV68mVV3T993(this, metadata);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d3b68071fc514b3d835e436b531f4252 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void ExecuteTask(NativeActivityContext context)
	{
		//Discarded unreachable code: IL_0277, IL_0286, IL_03ef
		int num = 15;
		IWorkflowMessageType workflowMessageType = default(IWorkflowMessageType);
		IWorkflowBookmark workflowBookmark = default(IWorkflowBookmark);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		IWorkflowMessageBookmark workflowMessageBookmark = default(IWorkflowMessageBookmark);
		IWorkflowQueueItem workflowQueueItem = default(IWorkflowQueueItem);
		IWorkflowBookmark workflowBookmark2 = default(IWorkflowBookmark);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 19:
					return;
				case 1:
					workflowMessageType = (IWorkflowMessageType)iL6desj3n8u7NKexvDJ(this);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc == 0)
					{
						num2 = 7;
					}
					continue;
				case 2:
					workflowBookmark = CreateBookmark(workflowInstance);
					num = 17;
					break;
				case 9:
					logger.DebugFormat((string)xtbxtkjCp9uP4c3MSlk(-1756425685 ^ -1756393411));
					num2 = 3;
					continue;
				case 10:
					g12VRRjQ9wfhfGTKJMh(logger, xtbxtkjCp9uP4c3MSlk(-1774307336 ^ -1774275238), new object[4]
					{
						workflowMessageBookmark.Id,
						mlWrCfjqSnbjGg19CjW(workflowMessageBookmark),
						workflowBookmark.Id,
						workflowBookmark.Uid
					});
					num2 = 20;
					continue;
				case 12:
					CreateSheduleTask(workflowMessageBookmark, workflowInstance);
					num2 = 21;
					continue;
				case 20:
					g12VRRjQ9wfhfGTKJMh(logger, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xFAE81C9 ^ 0xFAE02BD), new object[2]
					{
						workflowQueueItem.Id,
						DjX1HvjwkjpBgrJAc5X(workflowQueueItem)
					});
					num = 12;
					break;
				case 14:
					Contract.ServiceNotNull(cgEp4fjo6FXkVfdTt3t(this), (string)xtbxtkjCp9uP4c3MSlk(0x7AADECE0 ^ 0x7AADECBC));
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4756c9eca18a4abd877173fe66f77852 == 0)
					{
						num2 = 1;
					}
					continue;
				case 22:
					workflowQueueItem = (IWorkflowQueueItem)vRsmJ4j8N8pgkWP6f88(this, workflowInstance, base.Element);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_708ed3fc86604750bea250f1bed031ed != 0)
					{
						num2 = 2;
					}
					continue;
				case 24:
					workflowMessageBookmark = (IWorkflowMessageBookmark)DwG5xnj2oIcTok2tisu(this, workflowMessageType, workflowInstance, workflowBookmark);
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e != 0)
					{
						num2 = 23;
					}
					continue;
				case 18:
					Yv7RFrjtASWvMal0kOt(workflowBookmark);
					num2 = 16;
					continue;
				case 5:
					workflowBookmark2 = CreateBookmark(workflowInstance);
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 != 0)
					{
						num2 = 4;
					}
					continue;
				case 7:
					if (workflowMessageType != null)
					{
						num2 = 6;
						continue;
					}
					goto default;
				case 3:
					workflowInstance = (IWorkflowInstance)KpoVXSjxGPc1vAg15Kj(this, context);
					num2 = 5;
					continue;
				default:
					ContinueOnDefaultConnector(context);
					num2 = 8;
					continue;
				case 13:
					DelayedExecuteTask(context, workflowMessageType);
					num2 = 19;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 == 0)
					{
						num2 = 9;
					}
					continue;
				case 23:
					SetMessageBookmarkId(context, workflowMessageBookmark.Id);
					num2 = 10;
					continue;
				case 21:
					return;
				case 11:
					logger.DebugFormat((string)xtbxtkjCp9uP4c3MSlk(-133069941 ^ -133101605));
					num2 = 13;
					continue;
				case 17:
					workflowBookmark.Uid = DjX1HvjwkjpBgrJAc5X(workflowQueueItem);
					num2 = 18;
					continue;
				case 4:
					CreateActivityBookmark(context, yoYS1cjFMkuStmi8A3T(workflowBookmark2).ToString(), OnTaskCompleted);
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f679e84d83df40c6973457c358e7e4e4 != 0)
					{
						num2 = 22;
					}
					continue;
				case 15:
					de8js2jXhT5d9P5gsZH(context, xtbxtkjCp9uP4c3MSlk(-1917423727 ^ -1917423653));
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0c2830bb8fb347508ec492b48872fee7 == 0)
					{
						num2 = 14;
					}
					continue;
				case 16:
					O9fwaFjsprcBY275R5C(this, context, yoYS1cjFMkuStmi8A3T(workflowBookmark).ToString(), new BookmarkCallback(OnTaskCompleted));
					num2 = 24;
					continue;
				case 8:
					return;
				case 6:
					if (!XTrl54jhbsN4sTIF2WH(workflowMessageType))
					{
						num2 = 11;
						continue;
					}
					goto case 9;
				}
				break;
			}
		}
	}

	protected virtual void SetMessageBookmarkId(NativeActivityContext context, long id)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				messageBookmarkId.Set(context, id);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_c3ae8e111f574ce9b09d9ed725c1ab53 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual long? GetMessageBookmarkId(NativeActivityContext context)
	{
		return messageBookmarkId.Get(context);
	}

	protected virtual void ExecuteUserTaskScript(NativeActivityContext context, WorkflowMessageReceviesTerminateData terminateData)
	{
		//Discarded unreachable code: IL_0086, IL_010b, IL_011a, IL_0129, IL_0239, IL_0315, IL_0461, IL_0499
		int num = 2;
		int num2 = num;
		IWorkflowBookmark workflowBookmark = default(IWorkflowBookmark);
		IEnumerator<FlowConnectorElement> enumerator = default(IEnumerator<FlowConnectorElement>);
		ISchedulerTask schedulerTask = default(ISchedulerTask);
		ITerminateMessageReceiveSchedulerJob terminateMessageReceiveSchedulerJob = default(ITerminateMessageReceiveSchedulerJob);
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = default(_003C_003Ec__DisplayClass21_0);
		EventTrigger eventTrigger = default(EventTrigger);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		DateTime? dateTime2 = default(DateTime?);
		DateTime? dateTime3 = default(DateTime?);
		FlowConnectorElement current = default(FlowConnectorElement);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return;
			default:
				O9fwaFjsprcBY275R5C(this, context, yoYS1cjFMkuStmi8A3T(workflowBookmark).ToString(), new BookmarkCallback(OnTaskCompleted));
				num2 = 5;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 == 0)
				{
					num2 = 7;
				}
				break;
			case 5:
				try
				{
					while (true)
					{
						int num3;
						if (!noBkhbjStgmwoB6a1aX(enumerator))
						{
							num3 = 12;
							goto IL_0094;
						}
						goto IL_0387;
						IL_0094:
						while (true)
						{
							int num4;
							DateTime? dateTime;
							switch (num3)
							{
							case 12:
								return;
							default:
								schedulerTask.OwnerUid = WorkflowSchedulerTaskOwner.UID;
								num3 = 17;
								continue;
							case 14:
								terminateMessageReceiveSchedulerJob.MessageBookmark = (IWorkflowMessageBookmark)orLRSRjVKmmZ5OBGmxx(_003C_003Ec__DisplayClass21_.terminateData);
								num3 = 23;
								continue;
							case 2:
								if (eventTrigger == EventTrigger.Script)
								{
									num3 = 3;
									continue;
								}
								break;
							case 17:
								terminateMessageReceiveSchedulerJob = InterfaceActivator.Create<ITerminateMessageReceiveSchedulerJob>();
								num3 = 9;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 != 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
							case 5:
							case 11:
								break;
							case 19:
								bqoOZjjTXJxC97hbT7u(schedulerTask, Guid.NewGuid());
								num3 = 7;
								continue;
							case 18:
								xaRN5Xj96SDpkVtKDkg(schedulerTask, tQxLosj4yNuXB3usiyk(xtbxtkjCp9uP4c3MSlk(0x3907FE5 ^ 0x390FB35), new object[3]
								{
									wsgCdmjYEhf9bW3ZVub(base.Element),
									aWAgBAjvIWFUADUoViK(workflowInstance),
									agPVsnjP9tObiUcgJZ5(workflowInstance.Process)
								}));
								num3 = 19;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_520732c4e13f4c5b8eebfda6fa186589 == 0)
								{
									num3 = 1;
								}
								continue;
							case 9:
								terminateMessageReceiveSchedulerJob.Uid = dEMST9jcH2GRRkFF9Fw();
								num3 = 14;
								continue;
							case 22:
								if (!dateTime2.HasValue)
								{
									num4 = 5;
									goto IL_0090;
								}
								goto case 4;
							case 4:
								if (!JNOU63ja9AXASM1VL1u(dateTime2.Value, DateTime.Now))
								{
									num3 = 1;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22e71f1d40564f3ab8f9ac9108d98dcb != 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto case 6;
							case 7:
								schedulerTask.OnceExecuteTime = dateTime2.Value;
								num3 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1b80284ddf044221848555b8c08e8f67 != 0)
								{
									num3 = 0;
								}
								continue;
							case 13:
								R6FUcjjjHasvoM2GsAl(terminateMessageReceiveSchedulerJob, schedulerTask.Name);
								num3 = 5;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7f79a06dec5f490c93fd11725200b9b3 == 0)
								{
									num3 = 8;
								}
								continue;
							case 16:
								dateTime3 = null;
								num4 = 15;
								goto IL_0090;
							case 15:
								dateTime = dateTime3;
								goto IL_042f;
							case 21:
								Yv7RFrjtASWvMal0kOt(schedulerTask);
								num3 = 11;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ad15cce9717f4dd880232fa1f5e3eab0 == 0)
								{
									num3 = 3;
								}
								continue;
							case 8:
								schedulerTask.Jobs.Add((ISchedulerTaskJob)terminateMessageReceiveSchedulerJob);
								num3 = 18;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_91adcac8aa2043159a205c4a9f0e85fa != 0)
								{
									num3 = 21;
								}
								continue;
							case 20:
								eventTrigger = pCg2xyjKsd82QWu0byn(current);
								num3 = 2;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_766d50e1f7cc46f1bc746fe53086708c != 0)
								{
									num3 = 0;
								}
								continue;
							case 10:
								goto IL_0387;
							case 3:
								if (L03NPRjM0fY1DSlc5Zs(current) != null)
								{
									num3 = 24;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_94abcc9c95ac4ce4baec9537ccf1485a == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 16;
							case 23:
								terminateMessageReceiveSchedulerJob.ConnectorUid = P17BjLjN23cWAZpen3X(current);
								num3 = 25;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 != 0)
								{
									num3 = 3;
								}
								continue;
							case 6:
								schedulerTask = InterfaceActivator.Create<ISchedulerTask>();
								num3 = 18;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_aaa603dc29cf4b6d80fd77debf189b8d == 0)
								{
									num3 = 10;
								}
								continue;
							case 25:
								vWnUiEjdBdCtVVLlKTx(terminateMessageReceiveSchedulerJob, schedulerTask);
								num3 = 13;
								continue;
							case 24:
								{
									dateTime = ((IntermediateTimerSettings)L03NPRjM0fY1DSlc5Zs(current)).GetNextTimerExpiration(workflowInstance);
									goto IL_042f;
								}
								IL_042f:
								dateTime2 = dateTime;
								num3 = 22;
								continue;
								IL_0090:
								num3 = num4;
								continue;
							}
							break;
						}
						continue;
						IL_0387:
						current = enumerator.Current;
						num3 = 20;
						goto IL_0094;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_aaa603dc29cf4b6d80fd77debf189b8d == 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								wJ4klijkFj85XEDEWkr(enumerator);
								num5 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ae8403b9a8240c5b9d009904e9a6779 == 0)
								{
									num5 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 2:
				_003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				workflowInstance = (IWorkflowInstance)KpoVXSjxGPc1vAg15Kj(this, context);
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass21_.terminateData = terminateData;
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22e71f1d40564f3ab8f9ac9108d98dcb != 0)
				{
					num2 = 3;
				}
				break;
			case 4:
				workflowBookmark = (IWorkflowBookmark)IbnkWVjDCWHARGEwB7L(orLRSRjVKmmZ5OBGmxx(_003C_003Ec__DisplayClass21_.terminateData));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				enumerator = base.Element.ExceptionOutputFlows.Where(_003C_003Ec__DisplayClass21_._003CExecuteUserTaskScript_003Eb__0).GetEnumerator();
				num2 = 5;
				break;
			}
		}
	}

	protected void CreateSheduleTask(IWorkflowMessageBookmark messageBookmark, IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_0071, IL_0080, IL_01bc, IL_01cb, IL_0249, IL_0282, IL_02da, IL_0330, IL_0350, IL_052c, IL_053b, IL_0646, IL_0659, IL_0668
		int num = 3;
		int num2 = num;
		DateTime? dateTime = default(DateTime?);
		List<FlowConnectorElement>.Enumerator enumerator = default(List<FlowConnectorElement>.Enumerator);
		FlowConnectorElement current = default(FlowConnectorElement);
		ISchedulerTask schedulerTask2 = default(ISchedulerTask);
		DateTime? dateTime4 = default(DateTime?);
		ITerminateMessageReceiveSchedulerJob terminateMessageReceiveSchedulerJob = default(ITerminateMessageReceiveSchedulerJob);
		EventTrigger eventTrigger = default(EventTrigger);
		ISchedulerTask schedulerTask = default(ISchedulerTask);
		ITerminateMessageReceiveSchedulerJob terminateMessageReceiveSchedulerJob2 = default(ITerminateMessageReceiveSchedulerJob);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 3:
				dateTime = null;
				num2 = 2;
				continue;
			case 2:
				enumerator = base.Element.ExceptionOutputFlows.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				while (true)
				{
					IL_0581:
					int num3;
					if (!enumerator.MoveNext())
					{
						num3 = 25;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
						{
							num3 = 1;
						}
						goto IL_008f;
					}
					goto IL_0558;
					IL_0558:
					current = enumerator.Current;
					num3 = 22;
					goto IL_008f;
					IL_008f:
					while (true)
					{
						DateTime? dateTime2;
						DateTime? dateTime3;
						int num4;
						switch (num3)
						{
						case 25:
							return;
						case 16:
							schedulerTask2.OwnerUid = WorkflowSchedulerTaskOwner.UID;
							num3 = 35;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 != 0)
							{
								num3 = 4;
							}
							continue;
						case 36:
							dateTime4 = null;
							num3 = 18;
							continue;
						case 31:
							if (L03NPRjM0fY1DSlc5Zs(current) != null)
							{
								num3 = 13;
								continue;
							}
							goto case 41;
						case 4:
							terminateMessageReceiveSchedulerJob = InterfaceActivator.Create<ITerminateMessageReceiveSchedulerJob>();
							num3 = 7;
							continue;
						case 21:
							if (eventTrigger != EventTrigger.Script)
							{
								num3 = 11;
								continue;
							}
							goto case 31;
						case 40:
							if (!dateTime.HasValue)
							{
								num3 = 20;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_76260b548c684c6c95eb679c837b8945 != 0)
								{
									num3 = 23;
								}
								continue;
							}
							goto case 37;
						case 3:
							terminateMessageReceiveSchedulerJob.ConnectorUid = P17BjLjN23cWAZpen3X(current);
							num3 = 32;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 != 0)
							{
								num3 = 32;
							}
							continue;
						case 29:
							schedulerTask.OwnerUid = WorkflowSchedulerTaskOwner.UID;
							num3 = 4;
							continue;
						case 37:
							schedulerTask2 = InterfaceActivator.Create<ISchedulerTask>();
							num3 = 10;
							continue;
						case 24:
							schedulerTask.Jobs.Add((ISchedulerTaskJob)terminateMessageReceiveSchedulerJob);
							num3 = 38;
							continue;
						case 2:
							n6d4LTjmZhXodYaPZmf(terminateMessageReceiveSchedulerJob2, messageBookmark);
							num3 = 39;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e45b9499c327415a9efec43f507582e4 == 0)
							{
								num3 = 18;
							}
							continue;
						case 33:
							schedulerTask = InterfaceActivator.Create<ISchedulerTask>();
							num3 = 15;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_eb17dd137d8d48b5ba1e0580355a54c3 == 0)
							{
								num3 = 6;
							}
							continue;
						case 20:
							dateTime2 = dateTime4;
							goto IL_05fe;
						case 26:
							R6FUcjjjHasvoM2GsAl(terminateMessageReceiveSchedulerJob2, schedulerTask2.Name);
							num3 = 34;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 == 0)
							{
								num3 = 30;
							}
							continue;
						case 38:
							schedulerTask.Save();
							num3 = 9;
							continue;
						case 6:
							Yv7RFrjtASWvMal0kOt(schedulerTask2);
							num3 = 5;
							continue;
						case 18:
							dateTime3 = dateTime4;
							goto IL_05d5;
						case 7:
							terminateMessageReceiveSchedulerJob.MessageBookmark = messageBookmark;
							num4 = 3;
							goto IL_008b;
						case 41:
							dateTime4 = null;
							num3 = 20;
							continue;
						case 39:
							terminateMessageReceiveSchedulerJob2.ConnectorUid = P17BjLjN23cWAZpen3X(current);
							num3 = 30;
							continue;
						case 15:
							xaRN5Xj96SDpkVtKDkg(schedulerTask, tQxLosj4yNuXB3usiyk(xtbxtkjCp9uP4c3MSlk(-254800515 ^ -254768723), new object[3]
							{
								wsgCdmjYEhf9bW3ZVub(base.Element),
								aWAgBAjvIWFUADUoViK(instance),
								agPVsnjP9tObiUcgJZ5(k08KtOjUEIKuyxdJCqc(instance))
							}));
							num3 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_66cfffef200f40f698da30612ad0e4fb == 0)
							{
								num3 = 1;
							}
							continue;
						case 34:
							schedulerTask2.Jobs.Add((ISchedulerTaskJob)terminateMessageReceiveSchedulerJob2);
							num3 = 6;
							continue;
						default:
							if (JNOU63ja9AXASM1VL1u(dateTime.Value, pZPllIjAjgs1GYrU09a()))
							{
								num3 = 33;
								continue;
							}
							goto IL_0581;
						case 35:
							terminateMessageReceiveSchedulerJob2 = InterfaceActivator.Create<ITerminateMessageReceiveSchedulerJob>();
							num3 = 2;
							continue;
						case 32:
							vWnUiEjdBdCtVVLlKTx(terminateMessageReceiveSchedulerJob, schedulerTask);
							num3 = 28;
							continue;
						case 19:
							schedulerTask2.OnceExecuteTime = dateTime.Value;
							num4 = 16;
							goto IL_008b;
						case 22:
							eventTrigger = pCg2xyjKsd82QWu0byn(current);
							num3 = 8;
							continue;
						case 10:
							xaRN5Xj96SDpkVtKDkg(schedulerTask2, tQxLosj4yNuXB3usiyk(xtbxtkjCp9uP4c3MSlk(-1756425685 ^ -1756391685), new object[3]
							{
								wsgCdmjYEhf9bW3ZVub(base.Element),
								aWAgBAjvIWFUADUoViK(instance),
								agPVsnjP9tObiUcgJZ5(k08KtOjUEIKuyxdJCqc(instance))
							}));
							num3 = 19;
							continue;
						case 17:
							if (!dateTime.HasValue)
							{
								num3 = 12;
								continue;
							}
							goto default;
						case 30:
							vWnUiEjdBdCtVVLlKTx(terminateMessageReceiveSchedulerJob2, schedulerTask2);
							num3 = 26;
							continue;
						case 28:
							R6FUcjjjHasvoM2GsAl(terminateMessageReceiveSchedulerJob, AjL19pjpm3UfbWgfL6G(schedulerTask));
							num3 = 8;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_515bc4036cf74f5eac12dac987ad5bea == 0)
							{
								num3 = 24;
							}
							continue;
						case 8:
							if (eventTrigger != EventTrigger.Timer)
							{
								num3 = 21;
								continue;
							}
							goto case 27;
						case 14:
							break;
						case 27:
							if (current.TimerSettings == null)
							{
								num3 = 36;
								continue;
							}
							dateTime3 = ((IntermediateTimerSettings)KmVLnvjbHZvAPCdoxR6(current)).GetNextTimerExpiration(instance);
							goto IL_05d5;
						case 5:
						case 9:
						case 11:
						case 12:
						case 23:
							goto IL_0581;
						case 1:
							schedulerTask.OnceExecuteTime = dateTime.Value;
							num4 = 29;
							goto IL_008b;
						case 13:
							{
								dateTime2 = ((IntermediateTimerSettings)L03NPRjM0fY1DSlc5Zs(current)).GetNextTimerExpiration(instance);
								goto IL_05fe;
							}
							IL_008b:
							num3 = num4;
							continue;
							IL_05d5:
							dateTime = dateTime3;
							num3 = 40;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1fcd5b77d5534d528c98a4d02b302a40 != 0)
							{
								num3 = 8;
							}
							continue;
							IL_05fe:
							dateTime = dateTime2;
							num3 = 13;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ff730ec99c9d438e9ab033b91102c6e4 == 0)
							{
								num3 = 17;
							}
							continue;
						}
						break;
					}
					goto IL_0558;
				}
			}
			finally
			{
				((IDisposable)enumerator).Dispose();
				int num5 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd == 0)
				{
					num5 = 0;
				}
				switch (num5)
				{
				case 0:
					break;
				}
			}
		}
	}

	protected void OnTaskCompleted(NativeActivityContext context, Bookmark bookmark, object state)
	{
		//Discarded unreachable code: IL_01e8, IL_01f7, IL_0290, IL_0374, IL_0383, IL_0439, IL_0448, IL_0453, IL_0486, IL_04bb, IL_04ca, IL_05b5, IL_05c8, IL_05d7, IL_068b, IL_069a, IL_078a, IL_0799
		int num = 36;
		IWorkflowMessageType workflowMessageType = default(IWorkflowMessageType);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		List<IWorkflowMessageItem> unreadMessages = default(List<IWorkflowMessageItem>);
		WorkflowMessageReceviesTerminateData workflowMessageReceviesTerminateData = default(WorkflowMessageReceviesTerminateData);
		WorkflowMessageExecuteData workflowMessageExecuteData2 = default(WorkflowMessageExecuteData);
		IWorkflowQueueItem workflowQueueItem = default(IWorkflowQueueItem);
		IWorkflowMessageItem workflowMessageItem = default(IWorkflowMessageItem);
		IWorkflowMessageBookmark workflowMessageBookmark2 = default(IWorkflowMessageBookmark);
		WorkflowMessageExecuteData workflowMessageExecuteData = default(WorkflowMessageExecuteData);
		IWorkflowMessageBookmark workflowMessageBookmark = default(IWorkflowMessageBookmark);
		List<IWorkflowMessageItem>.Enumerator enumerator = default(List<IWorkflowMessageItem>.Enumerator);
		IWorkflowMessageItem current = default(IWorkflowMessageItem);
		IWorkflowMessageTypeParameter workflowMessageTypeParameter = default(IWorkflowMessageTypeParameter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 36:
					de8js2jXhT5d9P5gsZH(state, xtbxtkjCp9uP4c3MSlk(-1329217772 ^ -1329251738));
					num2 = 35;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 == 0)
					{
						num2 = 35;
					}
					continue;
				case 29:
					g12VRRjQ9wfhfGTKJMh(logger, xtbxtkjCp9uP4c3MSlk(0x3F8E27D0 ^ 0x3F8EAF56), new object[2] { workflowMessageType.Id, workflowInstance.Id });
					num2 = 24;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36f887aeb2714eb8a19eed4fd9ed8ed8 != 0)
					{
						num2 = 44;
					}
					continue;
				case 42:
					g12VRRjQ9wfhfGTKJMh(logger, xtbxtkjCp9uP4c3MSlk(0x21359E1C ^ 0x2135182C), Array.Empty<object>());
					num2 = 34;
					continue;
				case 40:
					g12VRRjQ9wfhfGTKJMh(logger, xtbxtkjCp9uP4c3MSlk(-361150192 ^ -361116032), Array.Empty<object>());
					num2 = 12;
					continue;
				case 18:
					unreadMessages = WorkflowMessageItemManager.GetUnreadMessages(workflowMessageType, workflowInstance);
					num2 = 8;
					continue;
				case 25:
					return;
				case 27:
					if (workflowMessageReceviesTerminateData == null)
					{
						num2 = 31;
						continue;
					}
					goto case 40;
				case 13:
					workflowMessageReceviesTerminateData = state as WorkflowMessageReceviesTerminateData;
					num2 = 42;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 != 0)
					{
						num2 = 43;
					}
					continue;
				case 5:
					g12VRRjQ9wfhfGTKJMh(logger, xtbxtkjCp9uP4c3MSlk(0x234241C0 ^ 0x2342C440), Array.Empty<object>());
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_71034f51e0444c3592d323fffec09e96 == 0)
					{
						num2 = 3;
					}
					continue;
				case 37:
					return;
				case 23:
					return;
				case 34:
					throw new InvalidOperationException(SR.T((string)xtbxtkjCp9uP4c3MSlk(0x2772A0C0 ^ 0x2772265E)));
				case 15:
					qNCTNajy10rLwNnVCku(this, context, workflowMessageExecuteData2);
					num2 = 17;
					continue;
				case 2:
					workflowMessageType = (IWorkflowMessageType)iL6desj3n8u7NKexvDJ(this);
					num2 = 29;
					continue;
				case 14:
					RemoveAllActivityBookmarks(context);
					num = 33;
					break;
				case 17:
					ODMEbsjOoor9gGwIdFo(this, context);
					num2 = 25;
					continue;
				case 24:
					return;
				case 31:
					if (workflowQueueItem == null)
					{
						throw new InvalidOperationException((string)Nenw0ejij835ycgyBn6(xtbxtkjCp9uP4c3MSlk(-92270799 ^ -92240679), state.GetType().FullName));
					}
					num = 7;
					break;
				case 44:
					workflowMessageItem = null;
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_aaa603dc29cf4b6d80fd77debf189b8d == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					if (workflowMessageItem == null)
					{
						num2 = 39;
						continue;
					}
					g12VRRjQ9wfhfGTKJMh(logger, xtbxtkjCp9uP4c3MSlk(-1386102027 ^ -1386132689), new object[1] { workflowMessageItem.Id });
					num2 = 9;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0307c0add07f4a1a96da2f3cd63aa8fa == 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					if (!XTrl54jhbsN4sTIF2WH(workflowMessageBookmark2.MessageType))
					{
						num2 = 15;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 10;
				case 30:
					workflowMessageExecuteData = new WorkflowMessageExecuteData(workflowMessageBookmark, workflowMessageItem.MessageData as WebData);
					num2 = 32;
					continue;
				case 7:
					g12VRRjQ9wfhfGTKJMh(logger, xtbxtkjCp9uP4c3MSlk(0x5DD795B3 ^ 0x5DD7124D), new object[2] { workflowQueueItem.Id, workflowQueueItem.Uid });
					num = 4;
					break;
				case 22:
					workflowMessageBookmark2 = (IWorkflowMessageBookmark)GcSWIgjGSvUWNDYB0AF(workflowMessageExecuteData2);
					num2 = 5;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 == 0)
					{
						num2 = 5;
					}
					continue;
				case 1:
					workflowMessageBookmark = (IWorkflowMessageBookmark)liPGcjj6qTjH6O1QCsV(this, context, workflowInstance, workflowMessageType);
					num2 = 18;
					continue;
				case 26:
					try
					{
						while (true)
						{
							IL_0490:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f == 0)
								{
									num3 = 3;
								}
								goto IL_0457;
							}
							goto IL_0537;
							IL_0537:
							current = enumerator.Current;
							num3 = 5;
							goto IL_0457;
							IL_0457:
							while (true)
							{
								switch (num3)
								{
								case 4:
									break;
								case 1:
								case 7:
									goto IL_0490;
								case 2:
									workflowMessageItem = current;
									num3 = 4;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0b98e2160a714197bf0d3d74d55d90bc != 0)
									{
										num3 = 0;
									}
									continue;
								case 6:
									if (!((string)ohJIYljWE3kOdpaKnZT(WorkflowMessageBookmarkManager, workflowMessageTypeParameter, tM4FTRjB03ottAsVT5P(current) as WebData) == workflowMessageBookmark.ControlParameterValue))
									{
										num3 = 1;
										if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bbeafe91b1c448baa8c5cf2ab0baaadd == 0)
										{
											num3 = 1;
										}
										continue;
									}
									goto case 2;
								default:
									goto IL_0537;
								case 5:
									workflowMessageTypeParameter = ((IEnumerable<IWorkflowMessageTypeParameter>)((IWorkflowMessageType)nobAJjj0XHeuDZGhfis(current)).Parameters).FirstOrDefault((IWorkflowMessageTypeParameter a) => _003C_003Ec.dJqFhjWSS0abV4CyQs6(a));
									num3 = 6;
									continue;
								case 3:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 16;
				case 11:
					logger.DebugFormat((string)xtbxtkjCp9uP4c3MSlk(0x5DD795B3 ^ 0x5DD71C8F), pjAadFjHwx402utWi1Q(bookmark));
					num2 = 41;
					continue;
				case 12:
					if (!ProcessTaskTermination(context, workflowMessageReceviesTerminateData))
					{
						num2 = 23;
						continue;
					}
					goto case 38;
				case 10:
					if (LToAcojnTZnU4fxVFKg(workflowMessageBookmark2) != WorkflowMessageBookmarkStatus.Terminated)
					{
						num2 = 36;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_427a79594804461da96485ca77914e7b != 0)
						{
							num2 = 42;
						}
						continue;
					}
					goto case 15;
				case 38:
					RemoveAllActivityBookmarks(context);
					num2 = 24;
					continue;
				case 21:
					if (workflowMessageExecuteData2 == null)
					{
						num2 = 24;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a731ad20cd44175bde6db1171290626 == 0)
						{
							num2 = 27;
						}
						continue;
					}
					goto case 22;
				case 28:
					g12VRRjQ9wfhfGTKJMh(logger, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1197637235 ^ -1197667383), new object[1] { workflowMessageItem.Id });
					num2 = 19;
					continue;
				case 41:
					return;
				default:
					workflowMessageItem = unreadMessages.FirstOrDefault();
					num2 = 16;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff == 0)
					{
						num2 = 11;
					}
					continue;
				case 39:
					O9fwaFjsprcBY275R5C(this, context, pjAadFjHwx402utWi1Q(bookmark), new BookmarkCallback(OnTaskCompleted));
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb != 0)
					{
						num2 = 11;
					}
					continue;
				case 9:
					if (LToAcojnTZnU4fxVFKg(workflowMessageBookmark) == WorkflowMessageBookmarkStatus.Awaiting)
					{
						num2 = 30;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f2221527565f4c919b1fed8e8c54e4f7 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						g12VRRjQ9wfhfGTKJMh(logger, xtbxtkjCp9uP4c3MSlk(-949720076 ^ -949690084), new object[2] { workflowMessageItem.Id, workflowMessageBookmark.Id });
						num2 = 37;
					}
					continue;
				case 19:
					wBbS5Ojebml7RCcGRI7(workflowMessageItem);
					num2 = 14;
					continue;
				case 43:
					workflowQueueItem = state as IWorkflowQueueItem;
					num2 = 21;
					continue;
				case 35:
					workflowMessageExecuteData2 = state as WorkflowMessageExecuteData;
					num2 = 13;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_feeb07d467ad474ea937eb4a7eec98da != 0)
					{
						num2 = 8;
					}
					continue;
				case 20:
					enumerator = unreadMessages.GetEnumerator();
					num = 26;
					break;
				case 33:
					return;
				case 32:
					qNCTNajy10rLwNnVCku(this, context, workflowMessageExecuteData);
					num = 28;
					break;
				case 4:
					workflowInstance = (IWorkflowInstance)KpoVXSjxGPc1vAg15Kj(this, context);
					num2 = 2;
					continue;
				case 8:
					if (!((IEnumerable<IWorkflowMessageTypeParameter>)((IWorkflowMessageType)B2h55FjR6oK2hsbVW24(workflowMessageBookmark)).Parameters).Any((IWorkflowMessageTypeParameter a) => _003C_003Ec.dJqFhjWSS0abV4CyQs6(a)))
					{
						num2 = 6;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_abcdc9cbd98d49d386695d5b5f3da800 != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 20;
				}
				break;
			}
		}
	}

	protected virtual IWorkflowMessageType GetMessageType()
	{
		//Discarded unreachable code: IL_0079, IL_0088
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				return EntityManager<IWorkflowMessageType>.Instance.LoadOrNull(HHZySijuJ8Cgjdf1ZYC(base.Element));
			case 2:
				if (IBlJt2jl9l0syyxpATJ(HHZySijuJ8Cgjdf1ZYC(base.Element), Guid.Empty))
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b9495424a4ef4f809c30bcc362ac3faa == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	protected virtual IWorkflowQueueItem QueueActivity(IWorkflowInstance instance, Element element)
	{
		int num = 1;
		int num2 = num;
		IWorkflowQueueItem workflowQueueItem = default(IWorkflowQueueItem);
		while (true)
		{
			switch (num2)
			{
			case 1:
				de8js2jXhT5d9P5gsZH(instance, xtbxtkjCp9uP4c3MSlk(--230863782 ^ 0xDC294FC));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Le27p0jLFxT3lei9VDm(WorkflowQueueService, workflowQueueItem);
				num2 = 3;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb != 0)
				{
					num2 = 3;
				}
				break;
			default:
				de8js2jXhT5d9P5gsZH(element, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x60E50EF5 ^ 0x60E58291));
				num2 = 4;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8ed00be219534188ad23e215449e3f62 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return workflowQueueItem;
			case 4:
				workflowQueueItem = (IWorkflowQueueItem)bRoqA5jfgNxOR2p7FxV(WorkflowQueueItemManager, instance, element, true);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36f887aeb2714eb8a19eed4fd9ed8ed8 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	protected virtual IWorkflowMessageBookmark CreateMessageBookmark(IWorkflowMessageType messageType, IWorkflowInstance instance, IWorkflowBookmark bookmark)
	{
		//Discarded unreachable code: IL_0066
		int num = 7;
		object obj = default(object);
		IWorkflowMessageBookmark workflowMessageBookmark = default(IWorkflowMessageBookmark);
		PropertyMetadata propInfo = default(PropertyMetadata);
		_003C_003Ec__DisplayClass28_0 _003C_003Ec__DisplayClass28_ = default(_003C_003Ec__DisplayClass28_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (obj != null)
					{
						num2 = 2;
						continue;
					}
					goto case 3;
				case 8:
					hTmmp1jI1gCdC5Z5wWE(workflowMessageBookmark, ControlParameterValue(obj, propInfo));
					num2 = 11;
					continue;
				case 4:
					Q9maOYjrD222rTHE42y(workflowMessageBookmark, messageType);
					num2 = 9;
					continue;
				case 5:
					obj = o8SfHIj5xUqXU6T9IBp(instance.Context, _003C_003Ec__DisplayClass28_.controlParamVarUid);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_f44d857a149741d8874c141a12a734dc != 0)
					{
						num2 = 1;
					}
					continue;
				case 7:
					break;
				case 3:
				case 11:
					Yv7RFrjtASWvMal0kOt(workflowMessageBookmark);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1f93f2934a244aa9a51974d0e91035bb == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					propInfo = ((EntityMetadata)tXd43Hj1rQcPddVtRdr(fZVKsjjgwym3pUJOrdf(instance).GetType(), true, true)).Properties.FirstOrDefault(_003C_003Ec__DisplayClass28_._003CCreateMessageBookmark_003Eb__0);
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 != 0)
					{
						num2 = 6;
					}
					continue;
				case 10:
					YqoFLojJ9Jm5mbxI8B1(workflowMessageBookmark, bookmark);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 == 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					workflowMessageBookmark = InterfaceActivator.Create<IWorkflowMessageBookmark>();
					num2 = 10;
					continue;
				case 12:
					if (!IBlJt2jl9l0syyxpATJ(_003C_003Ec__DisplayClass28_.controlParamVarUid, Guid.Empty))
					{
						num2 = 3;
						continue;
					}
					goto case 5;
				default:
					return workflowMessageBookmark;
				case 9:
					_003C_003Ec__DisplayClass28_.controlParamVarUid = pm8SB5j7xumkZKDVye9(base.Element);
					num2 = 12;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 != 0)
					{
						num2 = 12;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass28_ = new _003C_003Ec__DisplayClass28_0();
			num = 6;
		}
	}

	protected virtual void ProcessTaskCompletion(NativeActivityContext context, WorkflowMessageExecuteData executeData)
	{
		//Discarded unreachable code: IL_0168, IL_0242, IL_024e, IL_025d, IL_0353, IL_0362, IL_03d9, IL_03e8, IL_0421, IL_0430
		int num = 5;
		int num2 = num;
		IWorkflowMessageType messageType = default(IWorkflowMessageType);
		IWorkflowMessageBookmark workflowMessageBookmark = default(IWorkflowMessageBookmark);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		WebData webData = default(WebData);
		bool flag = default(bool);
		FlowConnectorElement flowConnectorElement = default(FlowConnectorElement);
		string message = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 19:
				messageType = workflowMessageBookmark.MessageType;
				num2 = 14;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 != 0)
				{
					num2 = 14;
				}
				break;
			case 11:
				g12VRRjQ9wfhfGTKJMh(logger, xtbxtkjCp9uP4c3MSlk(0x148F9F60 ^ 0x148F13B8), new object[1] { workflowMessageBookmark.Id });
				num2 = 12;
				break;
			case 21:
				try
				{
					((IWorkflowScriptingService)odZQ8PSClA5FtThLAYA(this)).ExecuteScript(workflowInstance, (string)V5vsqGjzDCxIEqmixan(base.Element), new Dictionary<string, object>
					{
						{
							SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51B6C0BE ^ 0x51B6E540),
							webData
						},
						{
							(string)xtbxtkjCp9uP4c3MSlk(0x27475F40 ^ 0x27477E46),
							messageType
						},
						{
							(string)xtbxtkjCp9uP4c3MSlk(-1756425685 ^ -1756414043),
							flag
						}
					}, (Func<string, Type, object>)null);
					int num3 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e6a95a03603e49dfb9bfc60af0009767 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception e2)
				{
					int num4 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3600d9e606e544d2b67d1fc1ad9becc3 == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 2:
							if (ExceptionActivity(context, flowConnectorElement, e2, workflowInstance, message))
							{
								num4 = 3;
								continue;
							}
							break;
						default:
						{
							ContinueOnConnector(context, flowConnectorElement.Uid);
							int num5 = 4;
							num4 = num5;
							continue;
						}
						case 3:
							Yv7RFrjtASWvMal0kOt(workflowInstance);
							num4 = 0;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_48279d3d45e2437b9907d478ce5a47b1 == 0)
							{
								num4 = 0;
							}
							continue;
						case 1:
							message = (string)isLiXgSXYby67flBKUd(xtbxtkjCp9uP4c3MSlk(0x532DFB0A ^ 0x532D777C));
							num4 = 2;
							continue;
						case 4:
							return;
						case 5:
							break;
						}
						break;
					}
					throw;
				}
				goto case 1;
			case 17:
				if (!DbwAuuSEhdteag6Ln3u(V5vsqGjzDCxIEqmixan(base.Element)))
				{
					num2 = 21;
					break;
				}
				goto case 1;
			case 18:
				pcaXHpSor3PoLXubHnD(workflowMessageBookmark, WorkflowMessageBookmarkStatus.Received);
				num2 = 8;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3cf4c0e592254156b9e651c03075f59e == 0)
				{
					num2 = 6;
				}
				break;
			case 3:
			case 9:
				if (!flag)
				{
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8ed00be219534188ad23e215449e3f62 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 13;
			case 2:
			case 10:
			case 16:
			case 22:
				NrYflUShylVdlXQtwS7(this, context);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_122c98752b3a49d0ab2b48b3f7a3ed7e != 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				Yv7RFrjtASWvMal0kOt(workflowMessageBookmark);
				num2 = 11;
				break;
			case 12:
				SaveHistoryEvent(workflowInstance, hbNhBcS3GaOSnrSytQT(), workflowMessageBookmark);
				num2 = 10;
				break;
			case 1:
				if (LToAcojnTZnU4fxVFKg(workflowMessageBookmark) != 0)
				{
					num2 = 3;
					break;
				}
				goto case 18;
			case 5:
				workflowInstance = (IWorkflowInstance)KpoVXSjxGPc1vAg15Kj(this, context);
				num2 = 4;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_36f887aeb2714eb8a19eed4fd9ed8ed8 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				workflowMessageBookmark = (IWorkflowMessageBookmark)GcSWIgjGSvUWNDYB0AF(executeData);
				num2 = 20;
				break;
			case 13:
				SaveHistoryEvent(workflowInstance, WorkflowInstanceActions.MessageReceiveTerminatedGuid, workflowMessageBookmark);
				num2 = 22;
				break;
			case 7:
				if (workflowMessageBookmark == null)
				{
					num2 = 16;
					break;
				}
				goto case 19;
			case 14:
				ApplyMessageParametersToContextVariables(webData, messageType, (WorkflowInstanceContext)fZVKsjjgwym3pUJOrdf(workflowInstance));
				num2 = 15;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 == 0)
				{
					num2 = 15;
				}
				break;
			case 15:
				flag = LToAcojnTZnU4fxVFKg(workflowMessageBookmark) == WorkflowMessageBookmarkStatus.Terminated;
				num2 = 17;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_aaa603dc29cf4b6d80fd77debf189b8d == 0)
				{
					num2 = 1;
				}
				break;
			case 20:
				webData = (WebData)M9qGltjZYSUWpn67VYe(executeData);
				num2 = 7;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_5a94341a5fba41ffbc72638f18ecb9d8 != 0)
				{
					num2 = 3;
				}
				break;
			case 0:
				return;
			case 4:
				flowConnectorElement = base.Element.ExceptionOutputFlows.FirstOrDefault((FlowConnectorElement e) => _003C_003Ec.wk8r1sWkMoAu87wkvFj(e) == EventTrigger.ErrorCatch);
				num2 = 6;
				break;
			}
		}
	}

	protected virtual IWorkflowMessageBookmark GetMessageBookmark(NativeActivityContext context, IWorkflowInstance instance, IWorkflowMessageType messageType)
	{
		//Discarded unreachable code: IL_0051, IL_008d, IL_00c0, IL_013d, IL_0172, IL_0181
		int num = 5;
		int num2 = num;
		object obj;
		IWorkflowMessageBookmark workflowMessageBookmark2 = default(IWorkflowMessageBookmark);
		long? num3 = default(long?);
		while (true)
		{
			IWorkflowMessageBookmark workflowMessageBookmark;
			switch (num2)
			{
			default:
				workflowMessageBookmark = WorkflowMessageBookmarkManager.FindMessageBookmark(instance, messageType, P17BjLjN23cWAZpen3X(base.Element));
				goto IL_019e;
			case 1:
				obj = workflowMessageBookmark2;
				if (obj == null)
				{
					num2 = 3;
					continue;
				}
				break;
			case 5:
				try
				{
					num3 = GetMessageBookmarkId(context);
					int num4 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_58d62f4202494b18a0cc2631d85b3ead == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				catch (InvalidOperationException ex)
				{
					int num5 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0bce36a95fd341dfb7b4178ccc0544f2 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						default:
							WRsSg6SFgJnQuouAaLH(WtE6LTSxTNXVrho2NA5(), xtbxtkjCp9uP4c3MSlk(-982315145 ^ -982285799), ex);
							num5 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 != 0)
							{
								num5 = 1;
							}
							continue;
						case 1:
							num3 = null;
							num5 = 1;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
							{
								num5 = 2;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
				}
				goto case 4;
			case 4:
				if (num3.HasValue)
				{
					num2 = 2;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_de54abced8a94396b6a2752618533f57 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto default;
			case 2:
				workflowMessageBookmark = WorkflowMessageBookmarkManager.LoadOrNull(num3.Value);
				goto IL_019e;
			case 3:
				{
					obj = DwG5xnj2oIcTok2tisu(this, messageType, instance, gybi4HS8D4RlxUjKMAO(this, instance));
					break;
				}
				IL_019e:
				workflowMessageBookmark2 = workflowMessageBookmark;
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a51554405284f038cd375280fa9ccb8 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			break;
		}
		return (IWorkflowMessageBookmark)obj;
	}

	private void SaveHistoryEvent(IWorkflowInstance instance, Guid actionUid, IWorkflowMessageBookmark messageBookmark)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
			{
				IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
				WorkflowMessageReceiveActionEventArgs workflowMessageReceiveActionEventArgs = WorkflowMessageReceiveActionEventArgs.TryCreate(instance, instance, actionUid);
				VOFR3pSwWSfe8KZdMH9(workflowMessageReceiveActionEventArgs, base.Element.Name);
				workflowMessageReceiveActionEventArgs.MessageTypeId = ((B2h55FjR6oK2hsbVW24(messageBookmark) != null) ? ((IEntity<long>)B2h55FjR6oK2hsbVW24(messageBookmark)).Id : 0);
				workflowMessageReceiveActionEventArgs.ControlParameterValue = (string)sofZdFStHU4WbuiFSPx(messageBookmark);
				sR2uoJSsubVYqFmHo04(serviceNotNull, workflowMessageReceiveActionEventArgs);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a731ad20cd44175bde6db1171290626 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	private void MessageException(NativeActivityContext context, IWorkflowInstance instance, FlowConnectorElement element, string subject, string description = "")
	{
		int num = 2;
		int num2 = num;
		IEnumerable<IUser> usersForTerminationNotify = default(IEnumerable<IUser>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
			{
				IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
				EntityActionEventArgs entityActionEventArgs = new EntityActionEventArgs(null, instance, (string)xtbxtkjCp9uP4c3MSlk(0x78FAF0B5 ^ 0x78FA7D51));
				entityActionEventArgs.ExtendedProperties[(string)xtbxtkjCp9uP4c3MSlk(-711228462 ^ -711216088)] = instance.Id;
				entityActionEventArgs.ExtendedProperties[(string)xtbxtkjCp9uP4c3MSlk(-30505303 ^ -30486315)] = instance.Name;
				entityActionEventArgs.ExtendedProperties[(string)xtbxtkjCp9uP4c3MSlk(-1635137248 ^ -1635170544)] = subject;
				entityActionEventArgs.ExtendedProperties[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-282877824 ^ -282910426)] = k08KtOjUEIKuyxdJCqc(instance);
				entityActionEventArgs.ExtendedProperties[(string)xtbxtkjCp9uP4c3MSlk(-97750002 ^ -97769886)] = description;
				entityActionEventArgs.ExtendedProperties[(string)xtbxtkjCp9uP4c3MSlk(-1275462473 ^ -1275497739)] = usersForTerminationNotify;
				serviceNotNull.ActionExecuted(entityActionEventArgs);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 != 0)
				{
					num2 = 0;
				}
				break;
			}
			case 2:
				usersForTerminationNotify = GetUsersForTerminationNotify(context, element);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2180cded74a649d583efc1ab91959551 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private bool ExceptionActivity(NativeActivityContext context, FlowConnectorElement errorConnector, Exception e, IWorkflowInstance instance, string message)
	{
		//Discarded unreachable code: IL_009f, IL_00ae, IL_00df, IL_0101, IL_0110, IL_011f, IL_014d, IL_01e8, IL_01f7, IL_029e
		int num = 10;
		Exception ex = default(Exception);
		ScriptExecuteException ex2 = default(ScriptExecuteException);
		ExceptionData exceptionData = default(ExceptionData);
		Exception innerException = default(Exception);
		WorkflowInstanceContext workflowInstanceContext = default(WorkflowInstanceContext);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					ex = e;
					num2 = 22;
					continue;
				case 23:
					if (ex2 == null)
					{
						num2 = 20;
						continue;
					}
					goto case 8;
				case 8:
					exceptionData = new ExceptionData(ex2.CodeException, (string)pvYJKBSqwj0qlmyJABJ(ex2), ex2);
					num2 = 5;
					continue;
				case 19:
					ex2 = ex as ScriptExecuteException;
					num2 = 23;
					continue;
				default:
					ex = innerException;
					num2 = 8;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 != 0)
					{
						num2 = 11;
					}
					continue;
				case 5:
					ciQOiiSQNpvdhynFYBP(workflowInstanceContext, oJo0rMS2ck2lKRiouDA(errorConnector), exceptionData);
					num2 = 3;
					continue;
				case 21:
					if (innerException == null)
					{
						num2 = 2;
						continue;
					}
					goto default;
				case 22:
					flag = true;
					num2 = 17;
					continue;
				case 12:
				case 16:
					goto end_IL_0012;
				case 4:
				case 11:
				case 17:
					if (flag)
					{
						num2 = 12;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2f22e6eeec1e40a4b9dae10f79ea3ae0 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 19;
				case 1:
				case 2:
					flag = false;
					num2 = 4;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_37eee1d96f2f408eb3b01bde6c7d25e0 != 0)
					{
						num2 = 4;
					}
					continue;
				case 15:
				case 20:
					ciQOiiSQNpvdhynFYBP(workflowInstanceContext, oJo0rMS2ck2lKRiouDA(errorConnector), new ExceptionData(0, message + (string)pvYJKBSqwj0qlmyJABJ(e), e));
					num2 = 18;
					continue;
				case 10:
					if (errorConnector == null)
					{
						num2 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_feeb07d467ad474ea937eb4a7eec98da == 0)
						{
							num2 = 9;
						}
						continue;
					}
					break;
				case 3:
				case 18:
					MessageException(context, instance, errorConnector, base.Element.Name, (string)OhM4obSVtWS2Myg0KKc(message, pvYJKBSqwj0qlmyJABJ(e)));
					num2 = 7;
					continue;
				case 7:
					return true;
				case 9:
					return false;
				case 6:
					if (workflowInstanceContext.GetPropertySettings(oJo0rMS2ck2lKRiouDA(errorConnector)) != null)
					{
						num2 = 13;
						continue;
					}
					goto case 3;
				case 14:
					break;
				}
				workflowInstanceContext = (WorkflowInstanceContext)fZVKsjjgwym3pUJOrdf(instance);
				num2 = 6;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_ec7d0b62d0f94d70bbee4df19d5df325 != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			innerException = ex.InnerException;
			num = 21;
		}
	}

	private void ApplyMessageParametersToContextVariables(WebData data, IWorkflowMessageType messageType, WorkflowInstanceContext instanceContext)
	{
		//Discarded unreachable code: IL_00bc, IL_00cb, IL_0102, IL_0111, IL_011c, IL_02ea, IL_02fd, IL_030c, IL_031c
		int num = 2;
		int num2 = num;
		List<MessageParamMap>.Enumerator enumerator = default(List<MessageParamMap>.Enumerator);
		WebData webData = default(WebData);
		_003C_003Ec__DisplayClass34_0 _003C_003Ec__DisplayClass34_ = default(_003C_003Ec__DisplayClass34_0);
		_003C_003Ec__DisplayClass34_1 _003C_003Ec__DisplayClass34_2 = default(_003C_003Ec__DisplayClass34_1);
		IPropertyMetadata propertyMetadata = default(IPropertyMetadata);
		EntityMetadata entityMetadata = default(EntityMetadata);
		IWorkflowMessageTypeParameter workflowMessageTypeParameter = default(IWorkflowMessageTypeParameter);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 8:
				return;
			case 2:
				if (data == null)
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_98890646a18d4a91b352a4ea5d1be319 == 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				enumerator = base.Element.MessageParamMapping.GetEnumerator();
				num2 = 3;
				continue;
			case 10:
			case 13:
				webData.SaveToEntity(instanceContext);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_22be8589196e4573a0c71199212852ff != 0)
				{
					num2 = 0;
				}
				continue;
			case 14:
				_003C_003Ec__DisplayClass34_.dict = new Dictionary<string, string>();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_67ef56456b804d908fd1218d899249dc == 0)
				{
					num2 = 5;
				}
				continue;
			case 3:
				try
				{
					while (true)
					{
						IL_0298:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_feeb07d467ad474ea937eb4a7eec98da == 0)
							{
								num3 = 5;
							}
							goto IL_0120;
						}
						goto IL_020c;
						IL_020c:
						_003C_003Ec__DisplayClass34_2 = new _003C_003Ec__DisplayClass34_1();
						num3 = 3;
						goto IL_0120;
						IL_0120:
						while (true)
						{
							switch (num3)
							{
							case 3:
								_003C_003Ec__DisplayClass34_2.m = enumerator.Current;
								num3 = 7;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_368897dda30d41e8b26c6b065203d16b == 0)
								{
									num3 = 1;
								}
								continue;
							case 4:
								propertyMetadata = entityMetadata.GetPropertiesAndTableParts().FirstOrDefault(_003C_003Ec__DisplayClass34_2._003CApplyMessageParametersToContextVariables_003Eb__0);
								num3 = 10;
								continue;
							case 9:
								if (propertyMetadata != null)
								{
									num3 = 3;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d352efd9477f4d458f3173b66f7e626f == 0)
									{
										num3 = 8;
									}
									continue;
								}
								goto IL_0298;
							case 6:
								_003C_003Ec__DisplayClass34_.dict[(string)FfNeHqSMuN2NC9aluGQ(workflowMessageTypeParameter)] = (string)iALWRpSakdT7yjpveLc(propertyMetadata);
								num3 = 2;
								continue;
							case 10:
								workflowMessageTypeParameter = ((IEnumerable<IWorkflowMessageTypeParameter>)messageType.Parameters).FirstOrDefault(_003C_003Ec__DisplayClass34_2._003CApplyMessageParametersToContextVariables_003Eb__1);
								num3 = 9;
								continue;
							case 1:
								break;
							case 8:
								if (workflowMessageTypeParameter != null)
								{
									num3 = 6;
									continue;
								}
								goto IL_0298;
							default:
								if (IBlJt2jl9l0syyxpATJ(nT0be1SKMnpo1syCYfy(_003C_003Ec__DisplayClass34_2.m), Guid.Empty))
								{
									num3 = 2;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
									{
										num3 = 4;
									}
									continue;
								}
								goto IL_0298;
							case 7:
								if (IBlJt2jl9l0syyxpATJ(CDHrgNSDGsa1araYB2b(_003C_003Ec__DisplayClass34_2.m), Guid.Empty))
								{
									num3 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_3c90beae50bc45bbb9c4179594d556e4 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto IL_0298;
							case 2:
								goto IL_0298;
							case 5:
								goto end_IL_0298;
							}
							break;
						}
						goto IL_020c;
						continue;
						end_IL_0298:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 4;
			case 12:
				entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(instanceContext.GetType());
				num2 = 14;
				continue;
			case 9:
				_003C_003Ec__DisplayClass34_ = new _003C_003Ec__DisplayClass34_0();
				num2 = 12;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_b813a6ed0be8497dbd700b40350f9732 == 0)
				{
					num2 = 12;
				}
				continue;
			case 4:
				if (NwZZmOSYpLDo2gMM81j(_003C_003Ec__DisplayClass34_.dict) <= 0)
				{
					num2 = 8;
					continue;
				}
				goto case 7;
			case 7:
				webData = ClassSerializationHelper.CloneObject(data);
				num2 = 11;
				continue;
			case 1:
				if (base.Element.MessageParamMapping == null)
				{
					return;
				}
				num2 = 9;
				continue;
			case 11:
				if (webData.Items == null)
				{
					num2 = 10;
					continue;
				}
				break;
			case 6:
				break;
			}
			nchRPgSvOj81chg6JWB(webData, (from i in webData.Items.Select(_003C_003Ec__DisplayClass34_._003CApplyMessageParametersToContextVariables_003Eb__2)
				where i != null
				select i).ToArray());
			num2 = 0;
			if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_62d08e7f3c124cad9861c0b648fd4a53 != 0)
			{
				num2 = 13;
			}
		}
	}

	private IEnumerable<IUser> GetUsersForTerminationNotify(NativeActivityContext context, FlowConnectorElement element)
	{
		bool assignedToResponsible;
		IUser[] swimlaneExecutors = GetSwimlaneExecutors(context, out assignedToResponsible);
		IWorkflowInstance instance = GetInstance(context);
		return Locator.GetServiceNotNull<IActivityEscalationNotifyService>().GetRecipientsForNotification(new GetRecipientsParameters(this, instance, element, swimlaneExecutors));
	}

	private bool ProcessTaskTermination(NativeActivityContext context, WorkflowMessageReceviesTerminateData terminateData)
	{
		//Discarded unreachable code: IL_0118, IL_01b4, IL_01e7, IL_021a, IL_024b, IL_02eb
		int num = 6;
		bool flag = default(bool);
		FlowConnectorElement flowConnectorElement = default(FlowConnectorElement);
		IEnumerable<IUser> usersForTerminationNotify = default(IEnumerable<IUser>);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		IWorkflowMessageBookmark workflowMessageBookmark = default(IWorkflowMessageBookmark);
		bool result = default(bool);
		string message = default(string);
		FlowConnectorElement flowConnectorElement2 = default(FlowConnectorElement);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					if (flag)
					{
						num2 = 11;
						continue;
					}
					goto case 14;
				case 2:
					if (pCg2xyjKsd82QWu0byn(flowConnectorElement) == EventTrigger.Script)
					{
						num2 = 3;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7ff589a2577e4ae68ceb125a419ed974 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 11;
				case 7:
					return true;
				default:
					flowConnectorElement = cSRmdqSTQjc1gODIOBg(iC0y2aS4IuUqQ4jf57T(shKr5bSPQSr6jVOrgkl(this)), YndpOKS9is4bU7jT7oD(terminateData)) as FlowConnectorElement;
					num = 2;
					break;
				case 1:
					usersForTerminationNotify = GetUsersForTerminationNotify(context, cSRmdqSTQjc1gODIOBg(iC0y2aS4IuUqQ4jf57T(base.Diagram), terminateData.ConnectorUid) as FlowConnectorElement);
					num2 = 4;
					continue;
				case 6:
					workflowInstance = (IWorkflowInstance)KpoVXSjxGPc1vAg15Kj(this, context);
					num2 = 5;
					continue;
				case 9:
					pcaXHpSor3PoLXubHnD(workflowMessageBookmark, WorkflowMessageBookmarkStatus.Terminated);
					num2 = 8;
					continue;
				case 14:
					k3bLiISdCMSW4X40Itb(this, context, terminateData);
					num2 = 10;
					continue;
				case 10:
					return false;
				case 11:
					workflowMessageBookmark = (IWorkflowMessageBookmark)orLRSRjVKmmZ5OBGmxx(terminateData);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_dc680cc6c18b4142944f593b8b103a17 != 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					ContinueOnConnector(context, YndpOKS9is4bU7jT7oD(terminateData));
					num2 = 7;
					continue;
				case 3:
					flag = false;
					num2 = 13;
					continue;
				case 13:
					try
					{
						flag = (bool)base.WorkflowScriptingService.ExecuteScript(workflowInstance, (string)pkW3woScflZZlhu9Lfx(flowConnectorElement));
						int num3 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception e)
					{
						int num4 = 2;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_0307c0add07f4a1a96da2f3cd63aa8fa == 0)
						{
							num4 = 1;
						}
						while (true)
						{
							switch (num4)
							{
							case 5:
								return result;
							case 2:
								message = (string)isLiXgSXYby67flBKUd(xtbxtkjCp9uP4c3MSlk(--1060279669 ^ 0x3F321B2F));
								num4 = 7;
								break;
							case 1:
								result = true;
								num4 = 5;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bd008fca9c464e14859870d0f9208652 != 0)
								{
									num4 = 5;
								}
								break;
							default:
								GEmUCNSNK6W1xmnKqRY(this, context, P17BjLjN23cWAZpen3X(flowConnectorElement2));
								num4 = 1;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13175fe1d68b47f98df2806801617f3f == 0)
								{
									num4 = 1;
								}
								break;
							case 3:
								Yv7RFrjtASWvMal0kOt(workflowInstance);
								num4 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 == 0)
								{
									num4 = 0;
								}
								break;
							case 7:
								if (!ExceptionActivity(context, flowConnectorElement2, e, workflowInstance, message))
								{
									num4 = 0;
									if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_476f57418da6445caf8a3854ac0b8f67 != 0)
									{
										num4 = 4;
									}
									break;
								}
								goto case 3;
							case 4:
							case 6:
								throw;
							}
						}
					}
					goto case 12;
				case 5:
					flowConnectorElement2 = base.Element.ExceptionOutputFlows.FirstOrDefault((FlowConnectorElement o) => _003C_003Ec.wk8r1sWkMoAu87wkvFj(o) == EventTrigger.ErrorCatch);
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
				{
					IEntityActionHandler serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
					EntityActionEventArgs entityActionEventArgs = new EntityActionEventArgs(null, workflowMessageBookmark, (string)xtbxtkjCp9uP4c3MSlk(-1633140121 ^ -1633153691));
					entityActionEventArgs.ExtendedProperties[(string)xtbxtkjCp9uP4c3MSlk(-588615921 ^ -588629645)] = XbbN4HSjU1QJ2sjINyC(workflowInstance);
					entityActionEventArgs.ExtendedProperties[(string)xtbxtkjCp9uP4c3MSlk(-1969850261 ^ -1969860719)] = workflowMessageBookmark.Id;
					entityActionEventArgs.ExtendedProperties[(string)xtbxtkjCp9uP4c3MSlk(0x2772A0C0 ^ 0x27722EF0)] = ((xLN9guSSnZdMFTgr1EL(flowConnectorElement) != null) ? ((Element)xLN9guSSnZdMFTgr1EL(flowConnectorElement)).Name : "");
					entityActionEventArgs.ExtendedProperties[(string)xtbxtkjCp9uP4c3MSlk(-1979431200 ^ -1979398330)] = k08KtOjUEIKuyxdJCqc(workflowInstance);
					entityActionEventArgs.ExtendedProperties[(string)xtbxtkjCp9uP4c3MSlk(-361150192 ^ -361117870)] = usersForTerminationNotify;
					sR2uoJSsubVYqFmHo04(serviceNotNull, entityActionEventArgs);
					num = 9;
					break;
				}
				}
				break;
			}
		}
	}

	private IWorkflowMessageBookmark DelayedExecuteTask(NativeActivityContext context, IWorkflowMessageType msgType)
	{
		int num = 7;
		int num2 = num;
		IWorkflowMessageBookmark workflowMessageBookmark = default(IWorkflowMessageBookmark);
		IWorkflowBookmark workflowBookmark = default(IWorkflowBookmark);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			case 5:
				g12VRRjQ9wfhfGTKJMh(logger, xtbxtkjCp9uP4c3MSlk(0x5DD795B3 ^ 0x5DD71B65), new object[4]
				{
					workflowMessageBookmark.Id,
					mlWrCfjqSnbjGg19CjW(workflowMessageBookmark),
					workflowBookmark.Id,
					yoYS1cjFMkuStmi8A3T(workflowBookmark)
				});
				num2 = 2;
				break;
			case 4:
				return workflowMessageBookmark;
			default:
				O9fwaFjsprcBY275R5C(this, context, yoYS1cjFMkuStmi8A3T(workflowBookmark).ToString(), new BookmarkCallback(OnTaskCompleted));
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_d69eb50e19fe417b8cd197dfca4d0d49 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				workflowBookmark = (IWorkflowBookmark)gybi4HS8D4RlxUjKMAO(this, workflowInstance);
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_feeb07d467ad474ea937eb4a7eec98da == 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				workflowInstance = (IWorkflowInstance)KpoVXSjxGPc1vAg15Kj(this, context);
				num2 = 6;
				break;
			case 3:
				SaveHistoryEvent(workflowInstance, Gx8wq9SkuS6MBQn9IqM(), workflowMessageBookmark);
				num2 = 4;
				break;
			case 2:
				CreateSheduleTask(workflowMessageBookmark, workflowInstance);
				num2 = 3;
				break;
			case 1:
				workflowMessageBookmark = (IWorkflowMessageBookmark)DwG5xnj2oIcTok2tisu(this, msgType, workflowInstance, workflowBookmark);
				num2 = 5;
				break;
			}
		}
	}

	private string ControlParameterValue(object value, PropertyMetadata propInfo)
	{
		//Discarded unreachable code: IL_007e, IL_008d, IL_0102, IL_0111, IL_011c, IL_01f0, IL_0230, IL_023f, IL_024b
		int num = 4;
		int num2 = num;
		int? intValue = default(int?);
		_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_ = default(_003C_003Ec__DisplayClass38_0);
		EntitySettings entitySettings = default(EntitySettings);
		IEnumerator<IEntity> enumerator = default(IEnumerator<IEntity>);
		EntityMetadata entityMetadata = default(EntityMetadata);
		IEntity current = default(IEntity);
		List<KeyValuePair<Guid, object>> list = default(List<KeyValuePair<Guid, object>>);
		EnumValueMetadata enumValueMetadata = default(EnumValueMetadata);
		Guid guid = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return intValue.ToString();
			case 1:
				_003C_003Ec__DisplayClass38_.sVal = value.ToString();
				num2 = 6;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_12d847d953a942998a65b55f3d0b7ddb == 0)
				{
					num2 = 6;
				}
				break;
			case 4:
				entitySettings = yZRS4ASbpovCCeGYVqg(propInfo) as EntitySettings;
				num2 = 2;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_e284642f05f54785bb4c3e22d7a51872 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				enumerator = ((IEnumerable<IEntity>)value).GetEnumerator();
				num2 = 9;
				break;
			case 9:
				try
				{
					while (true)
					{
						int num3;
						if (!noBkhbjStgmwoB6a1aX(enumerator))
						{
							num3 = 2;
							goto IL_0120;
						}
						goto IL_0173;
						IL_0120:
						while (true)
						{
							switch (num3)
							{
							case 4:
								entityMetadata = (EntityMetadata)tXd43Hj1rQcPddVtRdr(current.GetType(), true, true);
								num3 = 3;
								continue;
							case 1:
								goto IL_0173;
							case 3:
								list.Add(new KeyValuePair<Guid, object>(orKWFWSALfhLu6C29Eu(entityMetadata), current.GetId()));
								num3 = 0;
								if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc == 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								goto end_IL_013e;
							}
							break;
						}
						continue;
						IL_0173:
						current = enumerator.Current;
						num3 = 4;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b != 0)
						{
							num3 = 3;
						}
						goto IL_0120;
						continue;
						end_IL_013e:
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_1b80284ddf044221848555b8c08e8f67 == 0)
						{
							num4 = 2;
						}
						goto IL_01f4;
					}
					goto IL_020a;
					IL_020a:
					wJ4klijkFj85XEDEWkr(enumerator);
					num4 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_69deb269d49f4dd296bf46a0a542f92b != 0)
					{
						num4 = 1;
					}
					goto IL_01f4;
					IL_01f4:
					switch (num4)
					{
					case 2:
						goto end_IL_01cf;
					case 1:
						goto end_IL_01cf;
					}
					goto IL_020a;
					end_IL_01cf:;
				}
				goto case 12;
			case 6:
			{
				EnumMetadata obj = (EnumMetadata)InterfaceActivator.LoadMetadata(value.GetType());
				enumValueMetadata = obj.Values.First(_003C_003Ec__DisplayClass38_._003CControlParameterValue_003Eb__1);
				if (cLwJErSymwaoe0xD0SW(obj) != 0)
				{
					guid = orKWFWSALfhLu6C29Eu(enumValueMetadata);
					num2 = 13;
					break;
				}
				num2 = 9;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_520732c4e13f4c5b8eebfda6fa186589 != 0)
				{
					num2 = 10;
				}
				break;
			}
			case 13:
				return guid.ToString();
			default:
				return value.ToString();
			case 14:
				return bKZq4ySmAPPgSvw82Z3((IEntity)value).ToString();
			case 11:
				list = new List<KeyValuePair<Guid, object>>();
				num2 = 2;
				break;
			case 5:
				_003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_2a154fb56e4e4b63873c2ec8d4e1cbe4 != 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				if (PpaceuSU6h4SPCGlu1H(entitySettings) != 0)
				{
					num2 = 11;
					break;
				}
				goto case 14;
			case 10:
				intValue = enumValueMetadata.IntValue;
				num2 = 7;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_54bd71afa46f40208dd1bf6a7ffae8c6 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				if (entitySettings != null)
				{
					num2 = 8;
					break;
				}
				if (!B1Q6AWSn8wA4cHGR1fg(Lhi5buSG8SVwItIALc8(propInfo), EnumDescriptor.UID))
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4db1e829bcb046ad87c01fa1925cdfce == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 12:
				return (string)QThdOCSphQVWMf13w0h(new JsonSerializer(), list.OrderBy((KeyValuePair<Guid, object> a) => a.Value));
			}
		}
	}

	public MessageReceiveActivity()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SnaJvISOiEg03RSUWvu();
		messageBookmarkId = new Variable<long?>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_25eedcea124a48258fd18106b7da9d93 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static MessageReceiveActivity()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				logger = (ILogger)RQqOnAS6Bdfwj2jAEVe(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-897645572 ^ -897637032));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_abcdc9cbd98d49d386695d5b5f3da800 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_91adcac8aa2043159a205c4a9f0e85fa == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool C9ntWrdZMAB46DAk8Rk()
	{
		return NyPKSxdIbv4BpnwpVW7 == null;
	}

	internal static MessageReceiveActivity eaJMEkdzwFlPHl7b7hc()
	{
		return NyPKSxdIbv4BpnwpVW7;
	}

	internal static void tmgHEQjEV68mVV3T993(object P_0, NativeActivityMetadata P_1)
	{
		((NativeActivity<ActivityExecuteResult>)P_0).CacheMetadata(P_1);
	}

	internal static object xtbxtkjCp9uP4c3MSlk(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void de8js2jXhT5d9P5gsZH(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object cgEp4fjo6FXkVfdTt3t(object P_0)
	{
		return ((WorkflowActivity)P_0).WorkflowRuntimeService;
	}

	internal static object iL6desj3n8u7NKexvDJ(object P_0)
	{
		return ((MessageReceiveActivity)P_0).GetMessageType();
	}

	internal static bool XTrl54jhbsN4sTIF2WH(object P_0)
	{
		return ((IWorkflowMessageType)P_0).ReliableDelivery;
	}

	internal static object KpoVXSjxGPc1vAg15Kj(object P_0, object P_1)
	{
		return ((WorkflowActivity)P_0).GetInstance((NativeActivityContext)P_1);
	}

	internal static Guid yoYS1cjFMkuStmi8A3T(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Uid;
	}

	internal static object vRsmJ4j8N8pgkWP6f88(object P_0, object P_1, object P_2)
	{
		return ((MessageReceiveActivity)P_0).QueueActivity((IWorkflowInstance)P_1, (Element)P_2);
	}

	internal static Guid DjX1HvjwkjpBgrJAc5X(object P_0)
	{
		return ((IWorkflowQueueItem)P_0).Uid;
	}

	internal static void Yv7RFrjtASWvMal0kOt(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static void O9fwaFjsprcBY275R5C(object P_0, object P_1, object P_2, object P_3)
	{
		((WorkflowActivity)P_0).CreateActivityBookmark((NativeActivityContext)P_1, (string)P_2, (BookmarkCallback)P_3);
	}

	internal static object DwG5xnj2oIcTok2tisu(object P_0, object P_1, object P_2, object P_3)
	{
		return ((MessageReceiveActivity)P_0).CreateMessageBookmark((IWorkflowMessageType)P_1, (IWorkflowInstance)P_2, (IWorkflowBookmark)P_3);
	}

	internal static Guid mlWrCfjqSnbjGg19CjW(object P_0)
	{
		return ((IWorkflowMessageBookmark)P_0).Uid;
	}

	internal static void g12VRRjQ9wfhfGTKJMh(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).DebugFormat((string)P_1, (object[])P_2);
	}

	internal static object orLRSRjVKmmZ5OBGmxx(object P_0)
	{
		return ((WorkflowMessageReceviesTerminateData)P_0).MessageBookmark;
	}

	internal static object IbnkWVjDCWHARGEwB7L(object P_0)
	{
		return ((IWorkflowMessageBookmark)P_0).Bookmark;
	}

	internal static EventTrigger pCg2xyjKsd82QWu0byn(object P_0)
	{
		return ((FlowConnectorElement)P_0).Trigger;
	}

	internal static object L03NPRjM0fY1DSlc5Zs(object P_0)
	{
		return ((FlowConnectorElement)P_0).TimerScriptEscalation;
	}

	internal static bool JNOU63ja9AXASM1VL1u(DateTime P_0, DateTime P_1)
	{
		return P_0 > P_1;
	}

	internal static object wsgCdmjYEhf9bW3ZVub(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static object aWAgBAjvIWFUADUoViK(object P_0)
	{
		return ((IWorkflowInstance)P_0).InstanceName();
	}

	internal static object agPVsnjP9tObiUcgJZ5(object P_0)
	{
		return ((IWorkflowProcess)P_0).Name;
	}

	internal static object tQxLosj4yNuXB3usiyk(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void xaRN5Xj96SDpkVtKDkg(object P_0, object P_1)
	{
		((ISchedulerTask)P_0).Name = (string)P_1;
	}

	internal static void bqoOZjjTXJxC97hbT7u(object P_0, Guid P_1)
	{
		((ISchedulerTask)P_0).Uid = P_1;
	}

	internal static Guid dEMST9jcH2GRRkFF9Fw()
	{
		return Guid.NewGuid();
	}

	internal static Guid P17BjLjN23cWAZpen3X(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static void vWnUiEjdBdCtVVLlKTx(object P_0, object P_1)
	{
		((ISchedulerTaskJob)P_0).Task = (ISchedulerTask)P_1;
	}

	internal static void R6FUcjjjHasvoM2GsAl(object P_0, object P_1)
	{
		((ISchedulerTaskJob)P_0).Name = (string)P_1;
	}

	internal static bool noBkhbjStgmwoB6a1aX(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void wJ4klijkFj85XEDEWkr(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object KmVLnvjbHZvAPCdoxR6(object P_0)
	{
		return ((FlowConnectorElement)P_0).TimerSettings;
	}

	internal static object k08KtOjUEIKuyxdJCqc(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static void n6d4LTjmZhXodYaPZmf(object P_0, object P_1)
	{
		((ITerminateMessageReceiveSchedulerJob)P_0).MessageBookmark = (IWorkflowMessageBookmark)P_1;
	}

	internal static DateTime pZPllIjAjgs1GYrU09a()
	{
		return DateTime.Now;
	}

	internal static object AjL19pjpm3UfbWgfL6G(object P_0)
	{
		return ((ISchedulerTask)P_0).Name;
	}

	internal static object GcSWIgjGSvUWNDYB0AF(object P_0)
	{
		return ((WorkflowMessageExecuteData)P_0).MessageBookmark;
	}

	internal static WorkflowMessageBookmarkStatus LToAcojnTZnU4fxVFKg(object P_0)
	{
		return ((IWorkflowMessageBookmark)P_0).Status;
	}

	internal static void qNCTNajy10rLwNnVCku(object P_0, object P_1, object P_2)
	{
		((MessageReceiveActivity)P_0).ProcessTaskCompletion((NativeActivityContext)P_1, (WorkflowMessageExecuteData)P_2);
	}

	internal static void ODMEbsjOoor9gGwIdFo(object P_0, object P_1)
	{
		((WorkflowActivity)P_0).RemoveAllActivityBookmarks((NativeActivityContext)P_1);
	}

	internal static object liPGcjj6qTjH6O1QCsV(object P_0, object P_1, object P_2, object P_3)
	{
		return ((MessageReceiveActivity)P_0).GetMessageBookmark((NativeActivityContext)P_1, (IWorkflowInstance)P_2, (IWorkflowMessageType)P_3);
	}

	internal static object B2h55FjR6oK2hsbVW24(object P_0)
	{
		return ((IWorkflowMessageBookmark)P_0).MessageType;
	}

	internal static object nobAJjj0XHeuDZGhfis(object P_0)
	{
		return ((IWorkflowMessageItem)P_0).MessageType;
	}

	internal static object tM4FTRjB03ottAsVT5P(object P_0)
	{
		return ((IWorkflowMessageItem)P_0).MessageData;
	}

	internal static object ohJIYljWE3kOdpaKnZT(object P_0, object P_1, object P_2)
	{
		return ((WorkflowMessageBookmarkManager)P_0).AwaitingMessageControlParamValue((IWorkflowMessageTypeParameter)P_1, (WebData)P_2);
	}

	internal static object pjAadFjHwx402utWi1Q(object P_0)
	{
		return ((Bookmark)P_0).Name;
	}

	internal static void wBbS5Ojebml7RCcGRI7(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static object Nenw0ejij835ycgyBn6(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static Guid HHZySijuJ8Cgjdf1ZYC(object P_0)
	{
		return ((MessageReceiveElement)P_0).UIDMessage;
	}

	internal static bool IBlJt2jl9l0syyxpATJ(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object bRoqA5jfgNxOR2p7FxV(object P_0, object P_1, object P_2, bool P_3)
	{
		return ((WorkflowQueueItemManager)P_0).CreateQueueItem((IWorkflowInstance)P_1, (Element)P_2, P_3);
	}

	internal static void Le27p0jLFxT3lei9VDm(object P_0, object P_1)
	{
		((IWorkflowQueueService)P_0).ProcessItemAsyncAfterCommit((IWorkflowQueueItem)P_1);
	}

	internal static void YqoFLojJ9Jm5mbxI8B1(object P_0, object P_1)
	{
		((IWorkflowMessageBookmark)P_0).Bookmark = (IWorkflowBookmark)P_1;
	}

	internal static void Q9maOYjrD222rTHE42y(object P_0, object P_1)
	{
		((IWorkflowMessageBookmark)P_0).MessageType = (IWorkflowMessageType)P_1;
	}

	internal static Guid pm8SB5j7xumkZKDVye9(object P_0)
	{
		return ((MessageReceiveElement)P_0).ControlParamVarUid;
	}

	internal static object o8SfHIj5xUqXU6T9IBp(object P_0, Guid P_1)
	{
		return ((Entity<long>)P_0).GetPropertyValue(P_1);
	}

	internal static object fZVKsjjgwym3pUJOrdf(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static object tXd43Hj1rQcPddVtRdr(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static void hTmmp1jI1gCdC5Z5wWE(object P_0, object P_1)
	{
		((IWorkflowMessageBookmark)P_0).ControlParameterValue = (string)P_1;
	}

	internal static object M9qGltjZYSUWpn67VYe(object P_0)
	{
		return ((WorkflowMessageExecuteData)P_0).Data;
	}

	internal static object V5vsqGjzDCxIEqmixan(object P_0)
	{
		return ((MessageReceiveElement)P_0).MessageProcessScriptName;
	}

	internal static bool DbwAuuSEhdteag6Ln3u(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object odZQ8PSClA5FtThLAYA(object P_0)
	{
		return ((BPMNActivity<MessageReceiveElement>)P_0).WorkflowScriptingService;
	}

	internal static object isLiXgSXYby67flBKUd(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void pcaXHpSor3PoLXubHnD(object P_0, WorkflowMessageBookmarkStatus value)
	{
		((IWorkflowMessageBookmark)P_0).Status = value;
	}

	internal static Guid hbNhBcS3GaOSnrSytQT()
	{
		return WorkflowInstanceActions.MessageReceiveCompletedGuid;
	}

	internal static void NrYflUShylVdlXQtwS7(object P_0, object P_1)
	{
		((WorkflowActivity)P_0).ContinueOnDefaultConnector((NativeActivityContext)P_1);
	}

	internal static object WtE6LTSxTNXVrho2NA5()
	{
		return Logger.Log;
	}

	internal static void WRsSg6SFgJnQuouAaLH(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static object gybi4HS8D4RlxUjKMAO(object P_0, object P_1)
	{
		return ((BPMNActivity<MessageReceiveElement>)P_0).CreateBookmark((IWorkflowInstance)P_1);
	}

	internal static void VOFR3pSwWSfe8KZdMH9(object P_0, object P_1)
	{
		((WorkflowMessageReceiveActionEventArgs)P_0).ElementName = (string)P_1;
	}

	internal static object sofZdFStHU4WbuiFSPx(object P_0)
	{
		return ((IWorkflowMessageBookmark)P_0).ControlParameterValue;
	}

	internal static void sR2uoJSsubVYqFmHo04(object P_0, object P_1)
	{
		((IEntityActionHandler)P_0).ActionExecuted((EntityActionEventArgs)P_1);
	}

	internal static Guid oJo0rMS2ck2lKRiouDA(object P_0)
	{
		return ((FlowConnectorElement)P_0).ContextExceptionVar;
	}

	internal static object pvYJKBSqwj0qlmyJABJ(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void ciQOiiSQNpvdhynFYBP(object P_0, Guid P_1, object P_2)
	{
		((Entity<long>)P_0).SetPropertyValue(P_1, P_2);
	}

	internal static object OhM4obSVtWS2Myg0KKc(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static Guid CDHrgNSDGsa1araYB2b(object P_0)
	{
		return ((MessageParamMap)P_0).ContextValueUid;
	}

	internal static Guid nT0be1SKMnpo1syCYfy(object P_0)
	{
		return ((MessageParamMap)P_0).MessageParamUid;
	}

	internal static object FfNeHqSMuN2NC9aluGQ(object P_0)
	{
		return ((IWorkflowMessageTypeParameter)P_0).Name;
	}

	internal static object iALWRpSakdT7yjpveLc(object P_0)
	{
		return ((IPropertyMetadata)P_0).Name;
	}

	internal static int NwZZmOSYpLDo2gMM81j(object P_0)
	{
		return ((Dictionary<string, string>)P_0).Count;
	}

	internal static void nchRPgSvOj81chg6JWB(object P_0, object P_1)
	{
		((WebData)P_0).Items = (WebDataItem[])P_1;
	}

	internal static object shKr5bSPQSr6jVOrgkl(object P_0)
	{
		return ((WorkflowActivity)P_0).Diagram;
	}

	internal static object iC0y2aS4IuUqQ4jf57T(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static Guid YndpOKS9is4bU7jT7oD(object P_0)
	{
		return ((WorkflowMessageReceviesTerminateData)P_0).ConnectorUid;
	}

	internal static object cSRmdqSTQjc1gODIOBg(object P_0, Guid P_1)
	{
		return ((ElementList)P_0)[P_1];
	}

	internal static object pkW3woScflZZlhu9Lfx(object P_0)
	{
		return ((FlowConnectorElement)P_0).ScriprEscalation;
	}

	internal static void GEmUCNSNK6W1xmnKqRY(object P_0, object P_1, Guid P_2)
	{
		((WorkflowActivity)P_0).ContinueOnConnector((NativeActivityContext)P_1, P_2);
	}

	internal static void k3bLiISdCMSW4X40Itb(object P_0, object P_1, object P_2)
	{
		((MessageReceiveActivity)P_0).ExecuteUserTaskScript((NativeActivityContext)P_1, (WorkflowMessageReceviesTerminateData)P_2);
	}

	internal static object XbbN4HSjU1QJ2sjINyC(object P_0)
	{
		return ((IWorkflowInstance)P_0).Name;
	}

	internal static object xLN9guSSnZdMFTgr1EL(object P_0)
	{
		return ((Connector)P_0).StartElement;
	}

	internal static Guid Gx8wq9SkuS6MBQn9IqM()
	{
		return WorkflowInstanceActions.MessageReceiveStartedGuid;
	}

	internal static object yZRS4ASbpovCCeGYVqg(object P_0)
	{
		return ((PropertyMetadata)P_0).Settings;
	}

	internal static RelationType PpaceuSU6h4SPCGlu1H(object P_0)
	{
		return ((EntitySettings)P_0).RelationType;
	}

	internal static object bKZq4ySmAPPgSvw82Z3(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static Guid orKWFWSALfhLu6C29Eu(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object QThdOCSphQVWMf13w0h(object P_0, object P_1)
	{
		return ((JavaScriptSerializer)P_0).Serialize(P_1);
	}

	internal static Guid Lhi5buSG8SVwItIALc8(object P_0)
	{
		return ((PropertyMetadata)P_0).TypeUid;
	}

	internal static bool B1Q6AWSn8wA4cHGR1fg(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static EnumMetadataType cLwJErSymwaoe0xD0SW(object P_0)
	{
		return ((EnumMetadata)P_0).Type;
	}

	internal static void SnaJvISOiEg03RSUWvu()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
	}

	internal static object RQqOnAS6Bdfwj2jAEVe(object P_0)
	{
		return Logger.GetLogger((string)P_0);
	}
}
