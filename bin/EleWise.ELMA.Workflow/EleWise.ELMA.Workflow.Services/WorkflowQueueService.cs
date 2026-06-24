using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Locking;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Notifications.Impl;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Services;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.Diagrams.Activities.Helpers;
using EleWise.ELMA.Workflow.Exceptions;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Models.BackgroundOperations;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

[Service(Type = ComponentType.Server)]
internal class WorkflowQueueService : IWorkflowQueueService
{
	private struct ProcessingInstanceEntry
	{
		public static readonly ProcessingInstanceEntry Empty;

		public long Id;

		public TimeSpan? Timeout;

		internal static object xmhDGlZoHcP61CGlcHuy;

		public bool Equals(ProcessingInstanceEntry obj)
		{
			int num = 1;
			int num2 = num;
			TimeSpan? timeout2 = default(TimeSpan?);
			TimeSpan? timeout = default(TimeSpan?);
			while (true)
			{
				switch (num2)
				{
				case 4:
					timeout2 = obj.Timeout;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
					{
						num2 = 2;
					}
					break;
				default:
					timeout = Timeout;
					num2 = 4;
					break;
				case 2:
					if (timeout.HasValue != timeout2.HasValue)
					{
						num2 = 5;
						break;
					}
					if (timeout.HasValue)
					{
						return MBCk0sZo9tqocin5W3yA(timeout.GetValueOrDefault(), timeout2.GetValueOrDefault());
					}
					num2 = 3;
					break;
				case 3:
					return true;
				case 5:
					return false;
				case 1:
					if (Id != obj.Id)
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		static ProcessingInstanceEntry()
		{
			int num = 1;
			int num2 = num;
			ProcessingInstanceEntry empty = default(ProcessingInstanceEntry);
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 3:
					empty.Timeout = null;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
					{
						num2 = 0;
					}
					break;
				case 5:
					empty.Id = 0L;
					num2 = 3;
					break;
				case 2:
					Empty = empty;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
					{
						num2 = 4;
					}
					break;
				default:
					empty = default(ProcessingInstanceEntry);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
					{
						num2 = 5;
					}
					break;
				}
			}
		}

		internal static bool MBCk0sZo9tqocin5W3yA(TimeSpan P_0, TimeSpan P_1)
		{
			return P_0 == P_1;
		}

		internal static bool pGCUtZZoLedABvTapG4U()
		{
			return xmhDGlZoHcP61CGlcHuy == null;
		}

		internal static object rUpYifZofghc177jIxVT()
		{
			return xmhDGlZoHcP61CGlcHuy;
		}
	}

	private class ProcessingInstanceQueue
	{
		private readonly Queue<ProcessingInstanceEntry> queue;

		private bool completed;

		internal static object f0BiSNZoWq6SL7JIPiNf;

		public bool Enqueue(ProcessingInstanceEntry entry)
		{
			//Discarded unreachable code: IL_00df, IL_014a, IL_0182, IL_0191
			int num = 1;
			int num2 = num;
			bool lockTaken = default(bool);
			Queue<ProcessingInstanceEntry> queue = default(Queue<ProcessingInstanceEntry>);
			bool result = default(bool);
			while (true)
			{
				switch (num2)
				{
				default:
					lockTaken = false;
					num2 = 3;
					break;
				case 1:
					queue = this.queue;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return result;
				case 3:
					try
					{
						Monitor.Enter(queue, ref lockTaken);
						int num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
						{
							num3 = 1;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								return result;
							case 0:
								return result;
							case 3:
								return result;
							case 1:
								if (completed)
								{
									num3 = 4;
									continue;
								}
								break;
							case 4:
								result = false;
								num3 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
								{
									num3 = 3;
								}
								continue;
							case 2:
								result = true;
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
								{
									num3 = 0;
								}
								continue;
							case 5:
								break;
							}
							this.queue.Enqueue(entry);
							int num4 = 2;
							num3 = num4;
						}
					}
					finally
					{
						if (lockTaken)
						{
							int num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								default:
									wlRk24Zo64V0Zr1xpQy8(queue);
									num5 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
									{
										num5 = 0;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
					}
				}
			}
		}

		public bool Enqueue(long id, TimeSpan? timeout)
		{
			return Enqueue(new ProcessingInstanceEntry
			{
				Id = id,
				Timeout = timeout
			});
		}

		public ProcessingInstanceEntry Dequeue()
		{
			//Discarded unreachable code: IL_00b1, IL_00c0, IL_0138, IL_0168, IL_01a8, IL_01b3, IL_01c2
			int num = 1;
			int num2 = num;
			ProcessingInstanceEntry result = default(ProcessingInstanceEntry);
			bool lockTaken = default(bool);
			Queue<ProcessingInstanceEntry> obj = default(Queue<ProcessingInstanceEntry>);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return result;
				default:
					lockTaken = false;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 != 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					obj = queue;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						int num3 = 3;
						while (true)
						{
							switch (num3)
							{
							case 1:
								return result;
							case 5:
								return result;
							case 3:
								if (J5LDnrZoqO9YtK7oCPxj(queue) <= 0)
								{
									num3 = 4;
									continue;
								}
								break;
							case 2:
								result = ProcessingInstanceEntry.Empty;
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
								{
									num3 = 1;
								}
								continue;
							case 4:
							case 6:
								completed = true;
								num3 = 2;
								continue;
							}
							result = queue.Dequeue();
							int num4 = 5;
							num3 = num4;
						}
					}
					finally
					{
						int num5;
						if (!lockTaken)
						{
							num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
							{
								num5 = 1;
							}
							goto IL_016c;
						}
						goto IL_0182;
						IL_0182:
						Monitor.Exit(obj);
						num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
						{
							num5 = 0;
						}
						goto IL_016c;
						IL_016c:
						switch (num5)
						{
						default:
							goto end_IL_0147;
						case 2:
							break;
						case 1:
							goto end_IL_0147;
						case 0:
							goto end_IL_0147;
						}
						goto IL_0182;
						end_IL_0147:;
					}
				}
			}
		}

		public ProcessingInstanceQueue()
		{
			//Discarded unreachable code: IL_003a, IL_003f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			queue = new Queue<ProcessingInstanceEntry>();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static void wlRk24Zo64V0Zr1xpQy8(object P_0)
		{
			Monitor.Exit(P_0);
		}

		internal static bool YAuw2IZojX6POpYMZXZL()
		{
			return f0BiSNZoWq6SL7JIPiNf == null;
		}

		internal static ProcessingInstanceQueue jwqXyhZoRDpVS742Ur1U()
		{
			return (ProcessingInstanceQueue)f0BiSNZoWq6SL7JIPiNf;
		}

		internal static int J5LDnrZoqO9YtK7oCPxj(object P_0)
		{
			return ((Queue<ProcessingInstanceEntry>)P_0).Count;
		}
	}

	private class QueueItemProcessingStatus
	{
		internal static object VE5aYtZo3Q2u4wmJ1j3W;

		public bool Success
		{
			[CompilerGenerated]
			get
			{
				return _003CSuccess_003Ek__BackingField;
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
						_003CSuccess_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public bool IsSkippingResult
		{
			[CompilerGenerated]
			get
			{
				return _003CIsSkippingResult_003Ek__BackingField;
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
						_003CIsSkippingResult_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
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

		public bool AsyncWasStarted
		{
			[CompilerGenerated]
			get
			{
				return _003CAsyncWasStarted_003Ek__BackingField;
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
						_003CAsyncWasStarted_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
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

		public Exception AttemptException
		{
			[CompilerGenerated]
			get
			{
				return _003CAttemptException_003Ek__BackingField;
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
						_003CAttemptException_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public QueueItemProcessingStatus()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			mcJeUiZopeZs4XwvMpUO();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool GHoWfgZoTXs7N2XRaCY5()
		{
			return VE5aYtZo3Q2u4wmJ1j3W == null;
		}

		internal static QueueItemProcessingStatus PKvJFXZoQEHDVfmfTy64()
		{
			return (QueueItemProcessingStatus)VE5aYtZo3Q2u4wmJ1j3W;
		}

		internal static void mcJeUiZopeZs4XwvMpUO()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private static readonly ILogger Log;

	private readonly ConcurrentDictionary<long, WorkflowQueueItemExecutionInfo> processingItems;

	private readonly ConcurrentDictionary<long, WorkflowQueueItemExecutionInfo> queuedItems;

	private readonly ConcurrentDictionary<long, ProcessingInstanceQueue> processingInstances;

	private readonly FetchOptions wqiAuthorBackgroundOperationFetchOptions;

	private readonly FetchOptions wqiInstanceFetchOptions;

	private readonly FetchOptions wqiInstanceBackgroundOperationFetchOptions;

	private readonly IUnitOfWorkManager unitOfWorkManager;

	private readonly WorkflowInstanceManager workflowInstanceManager;

	private readonly WorkflowQueueItemManager workflowQueueItemManager;

	private readonly ThreadSubPool itemExecutorThreadPool;

	private readonly ISessionProvider sessionProvider;

	private readonly ICacheService cacheService;

	private readonly IRuntimeApplication runtimeApplication;

	private readonly WorkflowQueueDbService dbService;

	private readonly WorkflowRuntimeService workflowRuntimeService;

	private readonly ITransformationProvider transformationProvider;

	private readonly IBackgroundOperationService backgroundOperationService;

	private readonly NotificationManager notificationManager;

	private readonly UserGroupManager userGroupManager;

	private readonly Type thisType;

	private int lockTimeout;

	private TimeSpan touchTimeout;

	private TimeSpan timeout;

	private IEntityActionHandler entityActionHandler;

	private ISecurityService securityService;

	internal const string cacheRegion = "WorkflowQueueService";

	internal const string terminateItemCacheKey = "WorkflowQueueService_TerminateExecution_";

	internal static readonly TimeSpan[] AttemptIntervals;

	private static WorkflowQueueService TS6yQGVlRuiHd9uBA41;

	internal TimeSpan TouchTimeout => touchTimeout;

	internal static bool IsWorkflowQueueItemExecutor
	{
		get
		{
			bool value;
			return ContextVars.TryGetValue<bool>((string)aFBb7XVtxn63snJEOUu(-2125897096 ^ -2125959904), out value) && value;
		}
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
					ContextVars.Set(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495234644), value);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal ThreadSubPool ProcessingPool
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessingPool_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CProcessingPool_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	private IEntityActionHandler EntityActionHandler
	{
		get
		{
			int num = 1;
			int num2 = num;
			IEntityActionHandler entityActionHandler = default(IEntityActionHandler);
			IEntityActionHandler obj;
			while (true)
			{
				switch (num2)
				{
				default:
					entityActionHandler = (this.entityActionHandler = Locator.GetServiceNotNull<IEntityActionHandler>());
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					obj = this.entityActionHandler;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = entityActionHandler;
					break;
				}
				break;
			}
			return obj;
		}
	}

	private ISession Session => (ISession)sOxJ6xVa5MEPgPNKc5K(sessionProvider, "");

	private ISecurityService SecurityService
	{
		get
		{
			int num = 2;
			int num2 = num;
			ISecurityService securityService = default(ISecurityService);
			ISecurityService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					securityService = (this.securityService = Locator.GetServiceNotNull<ISecurityService>());
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					obj = this.securityService;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					obj = securityService;
					break;
				}
				break;
			}
			return obj;
		}
	}

	public WorkflowQueueService(IUnitOfWorkManager unitOfWorkManager, ISessionProvider sessionProvider, ICacheService cacheService, IRuntimeApplication runtimeApplication, WorkflowQueueDbService dbService, WorkflowRuntimeService workflowRuntimeService, WorkflowQueueItemManager workflowQueueItemManager, WorkflowInstanceManager workflowInstanceManager, ITransformationProvider transformationProvider, IBackgroundOperationService backgroundOperationService, NotificationManager notificationManager, UserGroupManager userGroupManager)
	{
		//Discarded unreachable code: IL_0282
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		processingItems = new ConcurrentDictionary<long, WorkflowQueueItemExecutionInfo>();
		queuedItems = new ConcurrentDictionary<long, WorkflowQueueItemExecutionInfo>();
		processingInstances = new ConcurrentDictionary<long, ProcessingInstanceQueue>();
		FetchOptions fetchOptions = new FetchOptions(0, 1);
		FetchOptions fetchOptions2 = fetchOptions;
		List<string> list = new List<string>();
		List<string> list2 = list;
		ParameterExpression parameterExpression = (ParameterExpression)thLRxxVbunn2cOAQ25b(Nk2TetVmhRBOtbduWJK(typeof(IWorkflowQueueItem).TypeHandle), aFBb7XVtxn63snJEOUu(0x7381F16B ^ 0x7381A9A5));
		list2.Add(LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)JrmIAeVgjn2dbmTb3oN(parameterExpression, (MethodInfo)ONloEdV5DJEOOT7ZUD4((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		List<string> list3 = list;
		parameterExpression = Expression.Parameter(Nk2TetVmhRBOtbduWJK(typeof(IWorkflowQueueItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14370830));
		list3.Add(LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>(Expression.Property(parameterExpression, (MethodInfo)ONloEdV5DJEOOT7ZUD4((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		fetchOptions2.FetchRelations = list;
		wqiAuthorBackgroundOperationFetchOptions = fetchOptions;
		fetchOptions = new FetchOptions(0, 1);
		FetchOptions fetchOptions3 = fetchOptions;
		list = new List<string>();
		List<string> list4 = list;
		parameterExpression = (ParameterExpression)thLRxxVbunn2cOAQ25b(Nk2TetVmhRBOtbduWJK(typeof(IWorkflowQueueItem).TypeHandle), aFBb7XVtxn63snJEOUu(0x628167BE ^ 0x62813F70));
		list4.Add(LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		fetchOptions3.FetchRelations = list;
		wqiInstanceFetchOptions = fetchOptions;
		fetchOptions = new FetchOptions(0, 1);
		FetchOptions fetchOptions4 = fetchOptions;
		list = new List<string>();
		List<string> list5 = list;
		parameterExpression = (ParameterExpression)thLRxxVbunn2cOAQ25b(Nk2TetVmhRBOtbduWJK(typeof(IWorkflowQueueItem).TypeHandle), aFBb7XVtxn63snJEOUu(-45832783 ^ -45810305));
		list5.Add(LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)JrmIAeVgjn2dbmTb3oN(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		List<string> list6 = list;
		parameterExpression = (ParameterExpression)thLRxxVbunn2cOAQ25b(Nk2TetVmhRBOtbduWJK(typeof(IWorkflowQueueItem).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -29959146));
		list6.Add(LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowQueueItem, object>>((Expression)JrmIAeVgjn2dbmTb3oN(parameterExpression, (MethodInfo)ONloEdV5DJEOOT7ZUD4((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		fetchOptions4.FetchRelations = list;
		wqiInstanceBackgroundOperationFetchOptions = fetchOptions;
		thisType = Nk2TetVmhRBOtbduWJK(typeof(WorkflowQueueService).TypeHandle);
		base._002Ector();
		int num = 7;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 13:
				this.transformationProvider = transformationProvider;
				num = 6;
				break;
			case 5:
				ReloadSettings();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 15:
				this.unitOfWorkManager = unitOfWorkManager;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
				{
					num = 1;
				}
				break;
			case 14:
			{
				this.workflowQueueItemManager = workflowQueueItemManager;
				int num2 = 9;
				num = num2;
				break;
			}
			case 8:
				this.runtimeApplication = runtimeApplication;
				num = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
				{
					num = 1;
				}
				break;
			case 11:
				this.cacheService = cacheService;
				num = 8;
				break;
			case 12:
				itemExecutorThreadPool = new ThreadSubPool((string)aFBb7XVtxn63snJEOUu(-1050383744 ^ -1050318950), 20, null, useElmaThreadPool: true, (string)aFBb7XVtxn63snJEOUu(0xB7793C9 ^ 0xB769EB3));
				num = 5;
				break;
			case 3:
				this.userGroupManager = userGroupManager;
				num = 12;
				break;
			case 10:
				this.dbService = dbService;
				num = 2;
				break;
			case 2:
				this.workflowRuntimeService = workflowRuntimeService;
				num = 12;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
				{
					num = 14;
				}
				break;
			case 6:
				this.backgroundOperationService = backgroundOperationService;
				num = 4;
				break;
			case 7:
				ProcessingPool = new ThreadSubPool(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x100DC15), 20, null, useElmaThreadPool: true, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614DF823));
				num = 15;
				break;
			case 1:
				this.sessionProvider = sessionProvider;
				num = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
				{
					num = 2;
				}
				break;
			case 4:
				this.notificationManager = notificationManager;
				num = 3;
				break;
			case 9:
				this.workflowInstanceManager = workflowInstanceManager;
				num = 13;
				break;
			}
		}
	}

	public void TerminateItem(Guid executionUid)
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
				cacheService.Insert((string)U2jIqdVBfQbfYToiTWa(aFBb7XVtxn63snJEOUu(0x5DB28AD2 ^ 0x5DB27160), executionUid), value: true, (string)aFBb7XVtxn63snJEOUu(0x6CC04061 ^ 0x6CC0BC67));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void ProcessItemAsync(IWorkflowQueueItem item)
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
				RFXZjYVcTiLLeTUt8lt(workflowQueueItemManager, item.Id);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ProcessItemAsync(long itemId)
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
				RFXZjYVcTiLLeTUt8lt(workflowQueueItemManager, itemId);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void ProcessItemAsync(long itemId, long instanceId, TimeSpan? timeout)
	{
		_003C_003Ec__DisplayClass40_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass40_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.itemId = itemId;
		CS_0024_003C_003E8__locals0.instanceId = instanceId;
		CS_0024_003C_003E8__locals0.timeout = timeout;
		if (processingItems.ContainsKey(CS_0024_003C_003E8__locals0.itemId))
		{
			return;
		}
		WorkflowQueueItemExecutionInfo workflowQueueItemExecutionInfo = new WorkflowQueueItemExecutionInfo
		{
			ExecutionUid = Guid.NewGuid(),
			ExecutionStart = DateTime.Now,
			ItemId = CS_0024_003C_003E8__locals0.itemId,
			InstanceId = CS_0024_003C_003E8__locals0.instanceId
		};
		if (!queuedItems.TryAdd(CS_0024_003C_003E8__locals0.itemId, workflowQueueItemExecutionInfo))
		{
			Log.DebugFormat(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x62806A10), CS_0024_003C_003E8__locals0.itemId, CS_0024_003C_003E8__locals0.instanceId);
			return;
		}
		Log.DebugFormat(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34EB5D2E), CS_0024_003C_003E8__locals0.itemId, CS_0024_003C_003E8__locals0.instanceId);
		try
		{
			ProcessingPool.Queue(delegate
			{
				int num3 = 1;
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					default:
						return;
					case 1:
						CS_0024_003C_003E8__locals0._003C_003E4__this.ProcessItemWithQueue(CS_0024_003C_003E8__locals0.itemId, CS_0024_003C_003E8__locals0.instanceId, CS_0024_003C_003E8__locals0.timeout);
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 != 0)
						{
							num4 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}, null, delegate
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
						CS_0024_003C_003E8__locals0._003C_003E4__this.DeleteQueuedItem(CS_0024_003C_003E8__locals0.itemId, CS_0024_003C_003E8__locals0.instanceId);
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			});
		}
		catch
		{
			DeleteQueuedItem(CS_0024_003C_003E8__locals0.itemId, CS_0024_003C_003E8__locals0.instanceId);
			dbService.ReleaseWorkflowQueueItem(workflowQueueItemExecutionInfo);
			throw;
		}
	}

	public void ProcessItemAsyncAfterCommit(IWorkflowQueueItem item)
	{
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = default(_003C_003Ec__DisplayClass41_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				NGXyEKVPanPCApYLbwD(_003C_003Ec__DisplayClass41_.item, aFBb7XVtxn63snJEOUu(0x75BAD659 ^ 0x75BA837F));
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				unitOfWorkManager.RegisterPostCommitAction(_003C_003Ec__DisplayClass41_._003CProcessItemAsyncAfterCommit_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				_003C_003Ec__DisplayClass41_._003C_003E4__this = this;
				num2 = 2;
				break;
			case 5:
				_003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
				num2 = 4;
				break;
			case 0:
				return;
			case 2:
				_003C_003Ec__DisplayClass41_.item = item;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void ProcessItemAsyncAfterCommit(long itemId)
	{
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass42_0 _003C_003Ec__DisplayClass42_ = default(_003C_003Ec__DisplayClass42_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 4:
				_003C_003Ec__DisplayClass42_.itemId = itemId;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				D4QVY1VX3ekH4tgJq1p(unitOfWorkManager, new Action(_003C_003Ec__DisplayClass42_._003CProcessItemAsyncAfterCommit_003Eb__0));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass42_._003C_003E4__this = this;
				num2 = 4;
				break;
			}
		}
	}

	public void ProcessItem(IWorkflowQueueItem item)
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
				ProcessItem(item, null);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ProcessItem(IWorkflowQueueItem item, TimeSpan? timeout)
	{
		ProcessItem(item, timeout, out var retryProcessItemAfterCommit, out var _);
		if (retryProcessItemAfterCommit)
		{
			ProcessItem(item);
		}
	}

	public void ProcessItem(long itemId)
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
				ProcessItem(itemId, null);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void ProcessItem(long itemId, TimeSpan? timeout)
	{
		InstanceOf<IWorkflowQueueItemFilter> instanceOf = new InstanceOf<IWorkflowQueueItemFilter>();
		instanceOf.New.Id = itemId;
		IWorkflowQueueItemFilter @new = instanceOf.New;
		IWorkflowQueueItem workflowQueueItem = workflowQueueItemManager.Find(@new, wqiInstanceFetchOptions).FirstOrDefault();
		if (workflowQueueItem != null)
		{
			ProcessItem(workflowQueueItem, timeout);
		}
	}

	public IEnumerable<WorkflowQueueItemExecutionInfo> GetCurrentExecutions()
	{
		List<WorkflowQueueItemExecutionInfo> list = processingItems.Values.ToList();
		foreach (KeyValuePair<long, WorkflowQueueItemExecutionInfo> queuedItem in queuedItems)
		{
			if (!processingItems.ContainsKey(queuedItem.Key))
			{
				list.Add(queuedItem.Value);
			}
		}
		return list;
	}

	public IEnumerable<WorkflowQueueItemExecutionInfo> GetGlobalExecutions()
	{
		if (runtimeApplication.GetActiveConnectionUids().Count() <= 1)
		{
			return GetCurrentExecutions();
		}
		return dbService.GetProcessingItems();
	}

	public IList<IWorkflowQueueItem> WaitWhileQueued(IWorkflowInstance instance, TimeSpan? waitTime = null)
	{
		_003C_003Ec__DisplayClass49_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass49_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.instance = instance;
		if (!waitTime.HasValue)
		{
			long num = SR.GetSetting(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028861977 ^ -1028800047), 1);
			if (num < 0)
			{
				num = 0L;
			}
			waitTime = TimeSpan.FromSeconds(num);
		}
		CS_0024_003C_003E8__locals0.maxTime = DateTime.Now.Add(waitTime.Value);
		CS_0024_003C_003E8__locals0.queueItems = null;
		try
		{
			Session.ExecuteWithTimeout((int)waitTime.Value.TotalSeconds, delegate
			{
				//Discarded unreachable code: IL_00d5, IL_00e4
				int num2 = 6;
				int num3 = num2;
				while (true)
				{
					switch (num3)
					{
					default:
						return;
					case 6:
						if (CS_0024_003C_003E8__locals0.queueItems != null)
						{
							num3 = 5;
							break;
						}
						goto case 3;
					case 1:
						if (!(_003C_003Ec__DisplayClass49_0.oB6aPIZoEK0DwG776PSa() < CS_0024_003C_003E8__locals0.maxTime))
						{
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
							{
								num3 = 0;
							}
							break;
						}
						goto case 6;
					case 3:
						CS_0024_003C_003E8__locals0.queueItems = CS_0024_003C_003E8__locals0._003C_003E4__this.workflowInstanceManager.GetActiveQueueItems(new IWorkflowInstance[1] { CS_0024_003C_003E8__locals0.instance }, allowSubInstances: true);
						num3 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
						{
							num3 = 2;
						}
						break;
					case 5:
						_003C_003Ec__DisplayClass49_0.cONmVxZohqC4VPk88752(1000);
						num3 = 3;
						break;
					case 4:
						return;
					case 0:
						return;
					case 2:
						if (!CS_0024_003C_003E8__locals0.queueItems.Any((IWorkflowQueueItem i) => _003C_003Ec.fm3ePaZoVaxtSKg6pvDO(i) == 0))
						{
							num3 = 4;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
							{
								num3 = 2;
							}
							break;
						}
						goto case 1;
					}
				}
			});
		}
		catch (Exception exception)
		{
			Logger.Log.Warn(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050319636), exception);
			if (transformationProvider.Dialect.IsIsolationLevelSupported(IsolationLevel.ReadUncommitted) && !unitOfWorkManager.HasActiveTransaction(""))
			{
				using (unitOfWorkManager.Create("", transactional: true, IsolationLevel.ReadUncommitted))
				{
					CS_0024_003C_003E8__locals0.queueItems = workflowInstanceManager.GetActiveQueueItems(new IWorkflowInstance[1] { CS_0024_003C_003E8__locals0.instance }, allowSubInstances: true);
				}
			}
		}
		return CS_0024_003C_003E8__locals0.queueItems ?? Array.Empty<IWorkflowQueueItem>();
	}

	internal void ReloadSettings()
	{
		int num = 2;
		long num3 = default(long);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					num3 = 600L;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
					{
						num2 = 3;
					}
					continue;
				case 9:
					lockTimeout = SR.GetSetting(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39121546), 1);
					num2 = 11;
					continue;
				default:
					touchTimeout = TimeSpan.FromSeconds(num3);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					num3 = SR.GetSetting((string)aFBb7XVtxn63snJEOUu(-1716629332 ^ -1716560368), 600);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					return;
				case 3:
					timeout = TimeSpan.FromSeconds(num3);
					num = 9;
					break;
				case 5:
					if (num3 <= 0)
					{
						num2 = 6;
						continue;
					}
					goto default;
				case 6:
					num3 = 600L;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					lockTimeout = 1;
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
					{
						num2 = 5;
					}
					continue;
				case 8:
					num3 = SR.GetSetting((string)aFBb7XVtxn63snJEOUu(-2057730233 ^ -2057795481), 600L);
					num = 5;
					break;
				case 1:
					if (num3 <= 0)
					{
						num2 = 10;
						continue;
					}
					goto case 3;
				case 11:
					if (lockTimeout <= 0)
					{
						num2 = 7;
						continue;
					}
					goto case 8;
				}
				break;
			}
		}
	}

	private void ProcessItemAsyncAfterCommitInternal(IWorkflowQueueItem queueItem)
	{
		//Discarded unreachable code: IL_003d
		int num = 1;
		int num2 = num;
		ProcessingInstanceQueue value = default(ProcessingInstanceQueue);
		long id = default(long);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (value == null)
				{
					num2 = 6;
					continue;
				}
				break;
			case 4:
			case 6:
				ProcessItemAsync(queueItem.Id, id, null);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			default:
				processingInstances.TryGetValue(id, out value);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
				{
					num2 = 2;
				}
				continue;
			case 1:
				id = ((IEntity<long>)BA8nBoVdsOHJo9RTTvP(queueItem)).Id;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				break;
			}
			if (value.Enqueue(queueItem.Id, null))
			{
				break;
			}
			num2 = 4;
		}
	}

	private void DeleteQueuedItem(long itemId, long instanceId)
	{
		//Discarded unreachable code: IL_008b, IL_009a, IL_00aa, IL_00b9, IL_017b
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (!Log.IsDebugEnabled())
				{
					num2 = 4;
					continue;
				}
				break;
			default:
			{
				if (queuedItems.TryRemove(itemId, out var _))
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 7;
			}
			case 2:
				return;
			case 3:
				qEjjTrVDCKA5mqKJOwG(Log, Eks9fAVuCft8raabylQ(aFBb7XVtxn63snJEOUu(-772614310 ^ -772548466), new object[2] { itemId, instanceId }));
				num2 = 8;
				continue;
			case 6:
				return;
			case 8:
				return;
			case 7:
				if (!B5D11RVnMBqqntRZvHr(Log))
				{
					num2 = 2;
					continue;
				}
				goto case 3;
			case 1:
				break;
			}
			qEjjTrVDCKA5mqKJOwG(Log, Eks9fAVuCft8raabylQ(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF7FE60), new object[2] { itemId, instanceId }));
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
			{
				num2 = 0;
			}
		}
	}

	private void ProcessItemWithQueue(long id, long instanceId, TimeSpan? timeout)
	{
		_003C_003Ec__DisplayClass60_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass60_0();
		CS_0024_003C_003E8__locals0.id = id;
		CS_0024_003C_003E8__locals0.instanceId = instanceId;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.proceed = false;
		CS_0024_003C_003E8__locals0.queue = processingInstances.GetOrAdd(CS_0024_003C_003E8__locals0.instanceId, delegate
		{
			int num5 = 1;
			int num6 = num5;
			while (true)
			{
				switch (num6)
				{
				default:
					return new ProcessingInstanceQueue();
				case 1:
					CS_0024_003C_003E8__locals0.proceed = true;
					num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
					{
						num6 = 0;
					}
					break;
				}
			}
		});
		if (!CS_0024_003C_003E8__locals0.queue.Enqueue(CS_0024_003C_003E8__locals0.id, timeout))
		{
			if (Log.IsDebugEnabled())
			{
				Log.Debug(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6D6F3E), CS_0024_003C_003E8__locals0.id, CS_0024_003C_003E8__locals0.instanceId));
			}
			ProcessItemAsync(CS_0024_003C_003E8__locals0.id, CS_0024_003C_003E8__locals0.instanceId, timeout);
			return;
		}
		if (Log.IsDebugEnabled())
		{
			Log.Debug(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22287512), CS_0024_003C_003E8__locals0.id, CS_0024_003C_003E8__locals0.instanceId));
		}
		if (!CS_0024_003C_003E8__locals0.proceed)
		{
			return;
		}
		while (true)
		{
			ProcessingInstanceEntry processingInstanceEntry = (CS_0024_003C_003E8__locals0.entry = CS_0024_003C_003E8__locals0.queue.Dequeue());
			if (processingInstanceEntry.Equals(ProcessingInstanceEntry.Empty))
			{
				break;
			}
			new BackgroundTask(delegate
			{
				//Discarded unreachable code: IL_0081, IL_0090, IL_01a4, IL_0259, IL_0268, IL_02cf, IL_02de
				switch (1)
				{
				case 1:
					try
					{
						int num;
						if (!_003C_003Ec__DisplayClass60_0.H3DeNTZFOvGhpcfRU4bY(Log))
						{
							num = 3;
							goto IL_0042;
						}
						goto IL_009b;
						IL_0042:
						IWorkflowQueueItemFilter @new = default(IWorkflowQueueItemFilter);
						IWorkflowQueueItem workflowQueueItem = default(IWorkflowQueueItem);
						while (true)
						{
							switch (num)
							{
							case 7:
								return;
							case 11:
								break;
							default:
								IsWorkflowQueueItemExecutor = true;
								num = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
								{
									num = 1;
								}
								continue;
							case 3:
							case 8:
							{
								InstanceOf<IWorkflowQueueItemFilter> instanceOf = new InstanceOf<IWorkflowQueueItemFilter>();
								_003C_003Ec__DisplayClass60_0.LrHUYLZF89U0voyxoyNL(instanceOf.New, CS_0024_003C_003E8__locals0.entry.Id);
								@new = instanceOf.New;
								num = 4;
								continue;
							}
							case 9:
								if (CS_0024_003C_003E8__locals0.retryProcessItemAfterCommit)
								{
									num = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
									{
										num = 0;
									}
									continue;
								}
								return;
							case 6:
								if (workflowQueueItem == null)
								{
									num = 7;
									continue;
								}
								goto default;
							case 1:
							{
								CS_0024_003C_003E8__locals0._003C_003E4__this.ProcessItem(workflowQueueItem, CS_0024_003C_003E8__locals0.entry.Timeout, out CS_0024_003C_003E8__locals0.retryProcessItemAfterCommit, out CS_0024_003C_003E8__locals0.asyncWasStarted);
								int num2 = 10;
								num = num2;
								continue;
							}
							case 2:
								_003C_003Ec__DisplayClass60_0.Np5LCvZFsGERnfZKYRmu(CS_0024_003C_003E8__locals0.queue, CS_0024_003C_003E8__locals0.entry);
								num = 5;
								continue;
							case 4:
								workflowQueueItem = CS_0024_003C_003E8__locals0._003C_003E4__this.workflowQueueItemManager.Find(@new, CS_0024_003C_003E8__locals0._003C_003E4__this.wqiInstanceFetchOptions).FirstOrDefault();
								num = 6;
								continue;
							case 10:
								IsWorkflowQueueItemExecutor = false;
								num = 9;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
								{
									num = 7;
								}
								continue;
							case 5:
								return;
							}
							break;
						}
						goto IL_009b;
						IL_009b:
						_003C_003Ec__DisplayClass60_0.XEpqStZFYjd20OtbC7WM(Log, _003C_003Ec__DisplayClass60_0.GX31c2ZFvM2iHH2rIZ5m(_003C_003Ec__DisplayClass60_0.ErLSnPZFZURUj7xw8vHO(-949717965 ^ -949573855), new object[2] { CS_0024_003C_003E8__locals0.id, CS_0024_003C_003E8__locals0.instanceId }));
						num = 8;
						goto IL_0042;
					}
					finally
					{
						int num4;
						if (!_003C_003Ec__DisplayClass60_0.H3DeNTZFOvGhpcfRU4bY(Log))
						{
							int num3 = 2;
							num4 = num3;
							goto IL_023e;
						}
						goto IL_0273;
						IL_023e:
						switch (num4)
						{
						default:
							goto end_IL_021d;
						case 2:
							goto end_IL_021d;
						case 1:
							break;
						case 0:
							goto end_IL_021d;
						}
						goto IL_0273;
						IL_0273:
						_003C_003Ec__DisplayClass60_0.XEpqStZFYjd20OtbC7WM(Log, SR.T((string)_003C_003Ec__DisplayClass60_0.ErLSnPZFZURUj7xw8vHO(0xB7793C9 ^ 0xB7540AD), CS_0024_003C_003E8__locals0.id, CS_0024_003C_003E8__locals0.instanceId));
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
						{
							num4 = 0;
						}
						goto IL_023e;
						end_IL_021d:;
					}
				case 0:
					break;
				}
			}, thisType, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11869086), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614DE441), CS_0024_003C_003E8__locals0.entry.Id)).Execute();
		}
		processingInstances.TryRemove(CS_0024_003C_003E8__locals0.instanceId, out CS_0024_003C_003E8__locals0.queue);
	}

	private void ProcessItem(IWorkflowQueueItem item, TimeSpan? timeout, out bool retryProcessItemAfterCommit, out bool asyncWasStarted)
	{
		Contract.ArgumentNotNull(item, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574621099));
		bool flag = false;
		Guid executionUid = Guid.NewGuid();
		long id = item.Id;
		long id2 = item.Instance.Id;
		retryProcessItemAfterCommit = false;
		asyncWasStarted = false;
		WorkflowQueueItemExecutionInfo workflowQueueItemExecutionInfo = null;
		try
		{
			workflowQueueItemExecutionInfo = new WorkflowQueueItemExecutionInfo
			{
				ItemId = item.Id,
				InstanceId = id2,
				ExecutionStart = DateTime.Now,
				ExecutionUid = executionUid
			};
			flag = processingItems.TryAdd(id, workflowQueueItemExecutionInfo);
			if (!flag)
			{
				return;
			}
			if (!dbService.TryInsertProcessingItem(workflowQueueItemExecutionInfo))
			{
				dbService.ReleaseWorkflowQueueItem(workflowQueueItemExecutionInfo, DateTime.Now.AddSeconds(5.0));
				return;
			}
			ProcessItemInternal(item, executionUid, item.Timeout ?? timeout, out var attemptException, out var isSkipping, out var exceptionFlow, out asyncWasStarted);
			if (attemptException == null)
			{
				return;
			}
			using IUnitOfWork unitOfWork = unitOfWorkManager.Create(string.Empty, transactional: true, IsolationLevel.ReadCommitted);
			try
			{
				item.Attempt++;
				item.LastExecuteDate = DateTime.Now;
				item.LastError = attemptException.ToString();
				item.ServerConnectionUid = null;
				if (exceptionFlow != null)
				{
					item.SkipExecution = true;
					item.SkipConnectorUid = exceptionFlow.Uid;
					item.LastExceptionData = new ExceptionData(0, attemptException.Message, attemptException);
					item.Timeout = null;
				}
				if (item.SkipExecution.HasValue && item.SkipExecution.Value && !isSkipping)
				{
					item.NextExecuteDate = DateTime.Now.AddHours(-1.0);
					retryProcessItemAfterCommit = true;
				}
				else
				{
					item.NextExecuteDate = ((item.Attempt < AttemptIntervals.Length) ? new DateTime?(item.LastExecuteDate.Value + AttemptIntervals[item.Attempt]) : null);
				}
				EntityActionHandlerExecute(item, attemptException, exceptionFlow);
				item.Save();
				unitOfWork.Commit();
			}
			catch (Exception exception)
			{
				Logger.Log.Warn(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351299646) + item.Id, exception);
				unitOfWork.Rollback();
			}
		}
		finally
		{
			if (flag && !asyncWasStarted)
			{
				DeleteFromProcessingItems(id);
			}
		}
	}

	private void EntityActionHandlerExecute(IWorkflowQueueItem queueItem, Exception attemptException, FlowConnectorElement exceptionFlow)
	{
		//Discarded unreachable code: IL_0100
		int num = 14;
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		DateTime? nextExecuteDate = default(DateTime?);
		IUserGroup userGroup = default(IUserGroup);
		_003C_003Ec__DisplayClass62_0 _003C_003Ec__DisplayClass62_ = default(_003C_003Ec__DisplayClass62_0);
		IEnumerable<EleWise.ELMA.Security.Models.IUser> usersByGroupAsEntity = default(IEnumerable<EleWise.ELMA.Security.Models.IUser>);
		Element element = default(Element);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 17:
					entityActionEventArgs.ExtendedProperties[(string)aFBb7XVtxn63snJEOUu(0xA7339EE ^ 0xA722BD4)] = ChiROrVWvoZlp18L9ia(attemptException);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num2 = 1;
					}
					break;
				case 4:
					if (!nextExecuteDate.HasValue)
					{
						num2 = 2;
						break;
					}
					return;
				case 7:
					if (attemptException is WorkflowInstanceLockException)
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 3;
				case 2:
					userGroup = userGroupManager.Load(BaseWorkflowConstants.ScriptErrorNotificationSendPermissionGroupId);
					num2 = 5;
					break;
				case 12:
					exkJshV6eOZ7L9jRoxH(EntityActionHandler, entityActionEventArgs);
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
					{
						num2 = 1;
					}
					break;
				case 9:
					entityActionEventArgs = new EntityActionEventArgs(null, (IEntity)BA8nBoVdsOHJo9RTTvP(_003C_003Ec__DisplayClass62_.queueItem), (string)aFBb7XVtxn63snJEOUu(-1386448964 ^ -1386387868));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
					{
						num2 = 0;
					}
					break;
				case 11:
					notificationManager.AddUsersToAdditionalSendList(usersByGroupAsEntity);
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num2 = 18;
					}
					break;
				case 14:
					_003C_003Ec__DisplayClass62_ = new _003C_003Ec__DisplayClass62_0();
					num2 = 13;
					break;
				case 10:
					return;
				case 3:
					if (exceptionFlow != null)
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 18:
					element = ((IEnumerable<Element>)Ng9hX4V95wZhO9UZiQH(KP47GtVfk1LmhdvMyP5(uirg5HVLA2yNI0QNO4N(BA8nBoVdsOHJo9RTTvP(_003C_003Ec__DisplayClass62_.queueItem))))).FirstOrDefault(_003C_003Ec__DisplayClass62_._003CEntityActionHandlerExecute_003Eb__0);
					num2 = 9;
					break;
				default:
					entityActionEventArgs.ExtendedProperties[(string)aFBb7XVtxn63snJEOUu(0x75872B6 ^ 0x7596092)] = attemptException.ToString();
					num2 = 17;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
					{
						num2 = 10;
					}
					break;
				case 5:
					usersByGroupAsEntity = userGroupManager.GetUsersByGroupAsEntity(userGroup.Id, new UserStatus[1]);
					num2 = 11;
					break;
				case 13:
					_003C_003Ec__DisplayClass62_.queueItem = queueItem;
					num2 = 6;
					break;
				case 6:
					if (zrIbDEVHhGIP8Djq4pu(_003C_003Ec__DisplayClass62_.queueItem) == 1)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
						{
							num2 = 7;
						}
						break;
					}
					goto case 8;
				case 8:
				case 15:
					nextExecuteDate = _003C_003Ec__DisplayClass62_.queueItem.NextExecuteDate;
					num2 = 4;
					break;
				case 1:
				{
					IDictionary<string, object> extendedProperties = entityActionEventArgs.ExtendedProperties;
					string key = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D55BE5);
					nextExecuteDate = _003C_003Ec__DisplayClass62_.queueItem.NextExecuteDate;
					extendedProperties[key] = ((!nextExecuteDate.HasValue) ? n1J0kEVjwflFHW1WiFq(aFBb7XVtxn63snJEOUu(0x6C7F14 ^ 0x6D6D9A)) : Eks9fAVuCft8raabylQ(aFBb7XVtxn63snJEOUu(-683713632 ^ -683783724), new object[1] { zrIbDEVHhGIP8Djq4pu(_003C_003Ec__DisplayClass62_.queueItem) }));
					num2 = 16;
					break;
				}
				case 16:
					entityActionEventArgs.ExtendedProperties[(string)aFBb7XVtxn63snJEOUu(-1386448964 ^ -1386388216)] = ((element != null) ? QXqqhfVRnFxopwi7X6Y(element) : "");
					num2 = 12;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 15;
		}
	}

	private void ProcessItemInternal(IWorkflowQueueItem originalQueueItem, Guid executionUid, TimeSpan? timeout, out Exception attemptException, out bool isSkipping, out FlowConnectorElement exceptionFlow, out bool asyncWasStarted)
	{
		_003C_003Ec__DisplayClass63_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass63_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.executionUid = executionUid;
		attemptException = null;
		isSkipping = false;
		exceptionFlow = null;
		asyncWasStarted = false;
		CS_0024_003C_003E8__locals0.queueItemId = originalQueueItem.Id;
		CS_0024_003C_003E8__locals0.backgroundTask = new BackgroundTask<QueueItemProcessingStatus>(delegate
		{
			//Discarded unreachable code: IL_0171, IL_0180, IL_0220, IL_022f, IL_02d1, IL_030a, IL_0319, IL_0328, IL_04ba, IL_04c9
			int num3 = 3;
			IWorkflowInstanceFilter @new = default(IWorkflowInstanceFilter);
			_003C_003Ec__DisplayClass63_1 _003C_003Ec__DisplayClass63_ = default(_003C_003Ec__DisplayClass63_1);
			_003C_003Ec__DisplayClass63_2 _003C_003Ec__DisplayClass63_2 = default(_003C_003Ec__DisplayClass63_2);
			BackgroundOperationStatus value = default(BackgroundOperationStatus);
			BackgroundOperationStatus? status = default(BackgroundOperationStatus?);
			while (true)
			{
				int num4 = num3;
				while (true)
				{
					switch (num4)
					{
					case 8:
					{
						InstanceOf<IWorkflowInstanceFilter> instanceOf = new InstanceOf<IWorkflowInstanceFilter>();
						_003C_003Ec__DisplayClass63_0.QgBM83ZFBuAkWr93Qu29(instanceOf.New, CS_0024_003C_003E8__locals0.queueItemId);
						@new = instanceOf.New;
						num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
						{
							num4 = 1;
						}
						break;
					}
					case 31:
					{
						object obj = _003C_003Ec__DisplayClass63_0.SbIodQZFcHeHEcrjNWOs(_003C_003Ec__DisplayClass63_.queueItem);
						_003C_003Ec__DisplayClass63_.queueItem.Delete();
						((IEntity)obj).Delete();
						num4 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
						{
							num4 = 4;
						}
						break;
					}
					case 14:
						_003C_003Ec__DisplayClass63_0.NnOCftZFu2rJ1GaKCoU2(_003C_003Ec__DisplayClass63_2.CS_0024_003C_003E8__locals2.statusResult, _003C_003Ec__DisplayClass63_2.attemptExceptionInternal);
						num4 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
						{
							num4 = 1;
						}
						break;
					case 25:
						value = status.Value;
						num4 = 30;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
						{
							num4 = 33;
						}
						break;
					case 20:
						if (_003C_003Ec__DisplayClass63_0.g8WOpWZFdkfdpjCVXFBC(_003C_003Ec__DisplayClass63_2.CS_0024_003C_003E8__locals2.queueItem) != null)
						{
							num4 = 23;
							break;
						}
						goto case 32;
					case 27:
						_003C_003Ec__DisplayClass63_2.CS_0024_003C_003E8__locals2 = _003C_003Ec__DisplayClass63_;
						num4 = 30;
						break;
					case 2:
						_003C_003Ec__DisplayClass63_.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
						num4 = 7;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
						{
							num4 = 16;
						}
						break;
					case 4:
					case 10:
					case 12:
					case 26:
						return _003C_003Ec__DisplayClass63_.statusResult;
					case 15:
						goto IL_023a;
					case 21:
					case 22:
						return _003C_003Ec__DisplayClass63_.statusResult;
					case 9:
						_003C_003Ec__DisplayClass63_0.NnOCftZFu2rJ1GaKCoU2(_003C_003Ec__DisplayClass63_.statusResult, new InvalidOperationException((string)_003C_003Ec__DisplayClass63_0.kTX0LvZFnGkrnr24WbP1(_003C_003Ec__DisplayClass63_0.dNfbaVZFDvHIlBRN8YCV(-39189604 ^ -39268320))));
						num4 = 17;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
						{
							num4 = 26;
						}
						break;
					case 16:
						_003C_003Ec__DisplayClass63_.statusResult = new QueueItemProcessingStatus();
						num4 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
						{
							num4 = 5;
						}
						break;
					case 5:
						if (status.HasValue)
						{
							num4 = 7;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
							{
								num4 = 2;
							}
							break;
						}
						goto IL_01e8;
					case 30:
						_003C_003Ec__DisplayClass63_2.success = false;
						num4 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
						{
							num4 = 24;
						}
						break;
					case 19:
						_003C_003Ec__DisplayClass63_0.dIWrHwZFXrqTq8JKbwoN(_003C_003Ec__DisplayClass63_.statusResult, true);
						num4 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
						{
							num4 = 4;
						}
						break;
					case 28:
						if (_003C_003Ec__DisplayClass63_0.SbIodQZFcHeHEcrjNWOs(_003C_003Ec__DisplayClass63_.queueItem) != null)
						{
							num4 = 18;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
							{
								num4 = 12;
							}
							break;
						}
						goto IL_01e8;
					case 32:
						CS_0024_003C_003E8__locals0._003C_003E4__this.InvokeScriptActivityUserCallback(_003C_003Ec__DisplayClass63_2.CS_0024_003C_003E8__locals2.queueItem, out _003C_003Ec__DisplayClass63_2.success, out _003C_003Ec__DisplayClass63_2.attemptExceptionInternal);
						num4 = 17;
						break;
					case 23:
						CS_0024_003C_003E8__locals0._003C_003E4__this.SecurityService.RunByUser(_003C_003Ec__DisplayClass63_2.CS_0024_003C_003E8__locals2.queueItem.Author, _003C_003Ec__DisplayClass63_2._003CProcessItemInternal_003Eb__2);
						num4 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
						{
							num4 = 13;
						}
						break;
					case 6:
						if (_003C_003Ec__DisplayClass63_.queueItem == null)
						{
							goto end_IL_0012;
						}
						goto case 28;
					case 33:
						switch (value)
						{
						case BackgroundOperationStatus.PendingCancellation:
							break;
						case BackgroundOperationStatus.Prepared:
							goto IL_023a;
						default:
							goto IL_0479;
						case BackgroundOperationStatus.PendingCallback:
							goto IL_0556;
						case BackgroundOperationStatus.Active:
						case BackgroundOperationStatus.Completed:
							goto IL_0578;
						}
						goto case 31;
					case 13:
					case 17:
						_003C_003Ec__DisplayClass63_2.CS_0024_003C_003E8__locals2.statusResult.Success = _003C_003Ec__DisplayClass63_2.success;
						num4 = 14;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
						{
							num4 = 12;
						}
						break;
					case 7:
						status = _003C_003Ec__DisplayClass63_.queueItem.BackgroundOperation.Status;
						num4 = 25;
						break;
					case 1:
						_003C_003Ec__DisplayClass63_.queueItem = CS_0024_003C_003E8__locals0._003C_003E4__this.workflowQueueItemManager.Find(@new, CS_0024_003C_003E8__locals0._003C_003E4__this.wqiAuthorBackgroundOperationFetchOptions).FirstOrDefault();
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
						{
							num4 = 6;
						}
						break;
					case 24:
						_003C_003Ec__DisplayClass63_2.attemptExceptionInternal = null;
						num4 = 20;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
						{
							num4 = 20;
						}
						break;
					case 11:
						goto IL_0556;
					case 3:
						_003C_003Ec__DisplayClass63_ = new _003C_003Ec__DisplayClass63_1();
						num4 = 2;
						break;
					default:
						goto IL_0578;
					case 18:
						{
							status = ((IBackgroundOperationInfo)_003C_003Ec__DisplayClass63_0.SbIodQZFcHeHEcrjNWOs(_003C_003Ec__DisplayClass63_.queueItem)).Status;
							num4 = 5;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
							{
								num4 = 3;
							}
							break;
						}
						IL_023a:
						_003C_003Ec__DisplayClass63_0.hbUyiiZFPPePTSmcfu3a(_003C_003Ec__DisplayClass63_.statusResult, CS_0024_003C_003E8__locals0._003C_003E4__this.backgroundOperationService.StartBackgroundOperation(_003C_003Ec__DisplayClass63_.queueItem, CS_0024_003C_003E8__locals0.executionUid, CS_0024_003C_003E8__locals0._003C_003E4__this.ProcessBackgroundOperationCompletion));
						num4 = 19;
						break;
						IL_0578:
						_003C_003Ec__DisplayClass63_0.dIWrHwZFXrqTq8JKbwoN(_003C_003Ec__DisplayClass63_.statusResult, false);
						num4 = 9;
						break;
						IL_0556:
						_003C_003Ec__DisplayClass63_2 = new _003C_003Ec__DisplayClass63_2();
						num4 = 27;
						break;
						IL_0479:
						num4 = 29;
						break;
						IL_01e8:
						_003C_003Ec__DisplayClass63_0.gW7J2MZFLy1qjQvyY7MZ(CS_0024_003C_003E8__locals0._003C_003E4__this.workflowRuntimeService, _003C_003Ec__DisplayClass63_0.DRlaADZFHytY2UlHc4pM(_003C_003Ec__DisplayClass63_.queueItem), new Action(_003C_003Ec__DisplayClass63_._003CProcessItemInternal_003Eb__1));
						num4 = 21;
						break;
					}
					continue;
					end_IL_0012:
					break;
				}
				num3 = 22;
			}
		}, thisType, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614DE7A7), SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1214182792 ^ -1214244736), CS_0024_003C_003E8__locals0.queueItemId));
		if (!timeout.HasValue || timeout.Value.TotalSeconds < 1.0)
		{
			timeout = this.timeout;
		}
		DateTime now = DateTime.Now;
		bool flag = false;
		CS_0024_003C_003E8__locals0.isWorkflowQueueItemExecutor = IsWorkflowQueueItemExecutor;
		bool flag2 = false;
		bool flag3 = false;
		_003C_003Ec__DisplayClass63_4 CS_0024_003C_003E8__locals1 = new _003C_003Ec__DisplayClass63_4();
		CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals4 = CS_0024_003C_003E8__locals0;
		CS_0024_003C_003E8__locals1.bgTaskIsEnded = new ManualResetEvent(initialState: false);
		try
		{
			using IElmaThreadPoolWorkItem elmaThreadPoolWorkItem = ((IElmaThreadPool)itemExecutorThreadPool).Push((ThreadStart)delegate
			{
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						_003C_003Ec__DisplayClass63_4.QJLOiQZFxcHZE5PU76Lh(value: false);
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						_003C_003Ec__DisplayClass63_4.PU9VFtZFNmf2f3184I5n(CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals4.backgroundTask);
						num2 = 4;
						break;
					case 3:
						return;
					default:
						_003C_003Ec__DisplayClass63_4.LQkDpOZFSxmFgXCPwnUv(CS_0024_003C_003E8__locals1.bgTaskIsEnded);
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						IsWorkflowQueueItemExecutor = CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals4.isWorkflowQueueItemExecutor;
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
						{
							num2 = 1;
						}
						break;
					}
				}
			});
			elmaThreadPoolWorkItem.WaitThread();
			string key = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712483075) + CS_0024_003C_003E8__locals1.CS_0024_003C_003E8__locals4.executionUid;
			do
			{
				if (elmaThreadPoolWorkItem.WaitExecute(TimeSpan.FromMilliseconds(500.0)) && CS_0024_003C_003E8__locals1.bgTaskIsEnded.WaitOne(500))
				{
					flag = true;
					break;
				}
				flag2 = DateTime.Now - now > timeout.Value;
				flag3 = cacheService.Contains(key, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x559B95DA));
				if (flag2 || flag3)
				{
					elmaThreadPoolWorkItem.AbortWorkerThread();
				}
			}
			while (!flag2 && !flag3);
		}
		finally
		{
			if (CS_0024_003C_003E8__locals1.bgTaskIsEnded != null)
			{
				((IDisposable)CS_0024_003C_003E8__locals1.bgTaskIsEnded).Dispose();
			}
		}
		if (!flag)
		{
			Exception ex = ((CS_0024_003C_003E8__locals0.backgroundTask.ExecutionException != null) ? CS_0024_003C_003E8__locals0.backgroundTask.ExecutionException : null);
			if (flag3 && ex != null)
			{
				attemptException = new WorkflowQueueTerminatedException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB399B4)), ex);
			}
			else if (flag2 && ex != null)
			{
				attemptException = new TimeoutException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD305CC2 ^ 0xD314F22)), ex);
				exceptionFlow = ActivityExceptionFlowHelper.GetExceptionFlow(originalQueueItem, EventTrigger.Timer);
			}
			else
			{
				attemptException = new Exception(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x595C500A ^ 0x595D4442), CS_0024_003C_003E8__locals0.queueItemId), ex);
				exceptionFlow = ActivityExceptionFlowHelper.GetErrorExceptionFlow(originalQueueItem, attemptException);
			}
			return;
		}
		QueueItemProcessingStatus result = CS_0024_003C_003E8__locals0.backgroundTask.Result;
		if (result == null)
		{
			if (CS_0024_003C_003E8__locals0.backgroundTask.ExecutionException == null)
			{
				throw new Exception(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574669913)));
			}
			attemptException = CS_0024_003C_003E8__locals0.backgroundTask.ExecutionException;
		}
		else if (result.Success)
		{
			isSkipping = result.IsSkippingResult;
			asyncWasStarted = result.AsyncWasStarted;
		}
		else
		{
			if (result.AttemptException == null)
			{
				throw new Exception(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895923353)));
			}
			attemptException = result.AttemptException;
		}
		if (attemptException != null)
		{
			exceptionFlow = ActivityExceptionFlowHelper.GetErrorExceptionFlow(originalQueueItem, attemptException);
		}
	}

	private void ProcessBackgroundOperationCompletion(long id, IBackgroundOperationResult result, CancellationToken token)
	{
		//Discarded unreachable code: IL_0047, IL_0090, IL_02b2, IL_02c1, IL_02f1, IL_0300, IL_030f, IL_031e, IL_0495, IL_0586, IL_05c6, IL_05d5, IL_05e1, IL_05f0, IL_0621, IL_0661, IL_0670, IL_067c, IL_068b, IL_06b7, IL_0713, IL_0722
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				CallContextSessionOwner callContextSessionOwner = (CallContextSessionOwner)MyLR4uVqmIii0i97UDC();
				int num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 1:
					break;
				default:
					try
					{
						IUnitOfWork unitOfWork = (IUnitOfWork)Tm1Lx2V35f6K3RPDMBV(unitOfWorkManager, string.Empty, true, IsolationLevel.ReadCommitted);
						int num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
						{
							num2 = 0;
						}
						switch (num2)
						{
						case 1:
							break;
						default:
							try
							{
								InstanceOf<IWorkflowQueueItemFilter> instanceOf = new InstanceOf<IWorkflowQueueItemFilter>();
								instanceOf.New.Id = id;
								IWorkflowQueueItemFilter @new = instanceOf.New;
								int num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
								{
									num3 = 0;
								}
								IWorkflowQueueItem workflowQueueItem2 = default(IWorkflowQueueItem);
								IBackgroundOperationInfo backgroundOperationInfo = default(IBackgroundOperationInfo);
								IWorkflowQueueItem workflowQueueItem = default(IWorkflowQueueItem);
								WorkflowQueueTerminatedException ex = default(WorkflowQueueTerminatedException);
								while (true)
								{
									int num4;
									switch (num3)
									{
									case 2:
										return;
									case 32:
										return;
									case 18:
									case 27:
										ProcessItemAsyncAfterCommit(workflowQueueItem2);
										num4 = 6;
										goto IL_00de;
									case 6:
									case 31:
										akuFmLVU2ry5rImUgqe(workflowQueueItem2);
										num4 = 9;
										goto IL_00de;
									case 9:
									case 16:
									case 26:
										DeleteFromProcessingItems(id);
										num3 = 14;
										break;
									case 7:
										backgroundOperationInfo.Status = BackgroundOperationStatus.Prepared;
										num3 = 11;
										break;
									case 28:
										if (rqWPVwVA7gaWGfvRYkC())
										{
											num3 = 27;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
											{
												num3 = 8;
											}
											break;
										}
										goto case 13;
									case 23:
										backgroundOperationInfo = (IBackgroundOperationInfo)noorOlVTASBlejGSYTn(workflowQueueItem);
										num3 = 4;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
										{
											num3 = 19;
										}
										break;
									case 10:
										sdgHrUVpSSVnpICi13x(backgroundOperationInfo);
										num3 = 26;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
										{
											num3 = 21;
										}
										break;
									case 4:
									case 21:
										workflowQueueItem2 = (IWorkflowQueueItem)caQ7h3VV4eMLLP8QbjU(backgroundOperationService, workflowQueueItem, result);
										num3 = 12;
										break;
									case 30:
										workflowQueueItem.LastExecuteDate = DateTime.Now;
										num3 = 3;
										break;
									case 19:
										if (lJ4XmeVQv4m7eJGAAVs(BA8nBoVdsOHJo9RTTvP(workflowQueueItem)) != WorkflowInstanceStatus.Running)
										{
											num3 = 3;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
											{
												num3 = 22;
											}
											break;
										}
										goto case 8;
									case 11:
										akuFmLVU2ry5rImUgqe(backgroundOperationInfo);
										num3 = 15;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
										{
											num3 = 9;
										}
										break;
									case 12:
										sdgHrUVpSSVnpICi13x(workflowQueueItem);
										num3 = 28;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
										{
											num3 = 24;
										}
										break;
									case 15:
										EntityActionHandlerExecute(workflowQueueItem, ex, null);
										num3 = 16;
										break;
									case 5:
										lqwAo5VMi0yGvTB8bhd(workflowQueueItem, new ExceptionData(0, (string)ChiROrVWvoZlp18L9ia(ex), ex));
										num3 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
										{
											num3 = 0;
										}
										break;
									case 8:
										if (!token.IsCancellationRequested)
										{
											num3 = 4;
											break;
										}
										goto case 25;
									case 24:
									{
										IWorkflowQueueItem workflowQueueItem3 = workflowQueueItem;
										long value = zrIbDEVHhGIP8Djq4pu(workflowQueueItem3) + 1;
										YcO0WqVCBiOIrniKLen(workflowQueueItem3, value);
										num3 = 29;
										break;
									}
									case 29:
										workflowQueueItem.ServerConnectionUid = null;
										num3 = 19;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
										{
											num3 = 30;
										}
										break;
									case 14:
										cxqIJ1VGWq6pMHdgecO(unitOfWork);
										num3 = 32;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
										{
											num3 = 12;
										}
										break;
									default:
										workflowQueueItem = workflowQueueItemManager.Find(@new, wqiInstanceBackgroundOperationFetchOptions).FirstOrDefault();
										num3 = 17;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
										{
											num3 = 6;
										}
										break;
									case 17:
										if (workflowQueueItem == null)
										{
											num3 = 2;
											break;
										}
										goto case 23;
									case 3:
										workflowQueueItem.LastError = ex.ToString();
										num3 = 5;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
										{
											num3 = 3;
										}
										break;
									case 13:
										if (!SR.GetSetting((string)aFBb7XVtxn63snJEOUu(0x34EA50D4 ^ 0x34EA2250), defaultValue: true))
										{
											num3 = 27;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
											{
												num3 = 31;
											}
											break;
										}
										goto case 18;
									case 22:
										workflowQueueItem.Delete();
										num3 = 10;
										break;
									case 25:
										ex = new WorkflowQueueTerminatedException((string)n1J0kEVjwflFHW1WiFq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -62957741)));
										num4 = 24;
										goto IL_00de;
									case 20:
										akuFmLVU2ry5rImUgqe(workflowQueueItem);
										num3 = 7;
										break;
									case 1:
										{
											workflowQueueItem.NextExecuteDate = ((workflowQueueItem.Attempt < AttemptIntervals.Length) ? new DateTime?(bhZwfAVkVXQ7XaD4Jxg(workflowQueueItem.LastExecuteDate.Value, AttemptIntervals[workflowQueueItem.Attempt])) : null);
											num3 = 20;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
											{
												num3 = 18;
											}
											break;
										}
										IL_00de:
										num3 = num4;
										break;
									}
								}
							}
							finally
							{
								int num5;
								if (unitOfWork == null)
								{
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
									{
										num5 = 0;
									}
									goto IL_058a;
								}
								goto IL_05a0;
								IL_05a0:
								unitOfWork.Dispose();
								num5 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
								{
									num5 = 2;
								}
								goto IL_058a;
								IL_058a:
								switch (num5)
								{
								default:
									goto end_IL_0565;
								case 1:
									break;
								case 0:
									goto end_IL_0565;
								case 2:
									goto end_IL_0565;
								}
								goto IL_05a0;
								end_IL_0565:;
							}
						}
						break;
					}
					finally
					{
						int num6;
						if (callContextSessionOwner == null)
						{
							num6 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 == 0)
							{
								num6 = 0;
							}
							goto IL_0625;
						}
						goto IL_063b;
						IL_063b:
						((IDisposable)callContextSessionOwner).Dispose();
						num6 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
						{
							num6 = 1;
						}
						goto IL_0625;
						IL_0625:
						switch (num6)
						{
						default:
							goto end_IL_0600;
						case 2:
							break;
						case 0:
							goto end_IL_0600;
						case 1:
							goto end_IL_0600;
						}
						goto IL_063b;
						end_IL_0600:;
					}
				}
				break;
			}
			catch (Exception exception)
			{
				int num7 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
				{
					num7 = 0;
				}
				while (true)
				{
					switch (num7)
					{
					case 1:
						return;
					}
					((ILogger)Lpk8VNV7UDOqRfrlU8B()).Error(n1J0kEVjwflFHW1WiFq(aFBb7XVtxn63snJEOUu(0x628167BE ^ 0x6280727C)), exception);
					num7 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
					{
						num7 = 1;
					}
				}
			}
		}
	}

	private void DeleteFromProcessingItems(long queueItemId)
	{
		//Discarded unreachable code: IL_0032, IL_0041
		int num = 2;
		int num2 = num;
		WorkflowQueueItemExecutionInfo value = default(WorkflowQueueItemExecutionInfo);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 3:
				return;
			case 2:
				if (!processingItems.TryRemove(queueItemId, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			NosMK4V2V2DlfjX3Lum(dbService, value.ExecutionUid);
			num2 = 3;
		}
	}

	private void DeleteFromQueueItems(long queueItemId)
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
				Laf1pxVoDqnTBdFVYWD(dbService, queueItemId);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void InvokeScriptActivityUserCallback(IWorkflowQueueItem queueItem, out bool success, out Exception attemptExceptionInternal)
	{
		//Discarded unreachable code: IL_00e9, IL_01ed, IL_026c, IL_02c5, IL_02e4, IL_02f3, IL_0320, IL_032f
		int num = 1;
		_003C_003Ec__DisplayClass67_0 _003C_003Ec__DisplayClass67_ = default(_003C_003Ec__DisplayClass67_0);
		ExtendableLock extendableLock = default(ExtendableLock);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					_003C_003Ec__DisplayClass67_.queueItem = queueItem;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
					break;
				case 6:
					attemptExceptionInternal = null;
					num2 = 3;
					continue;
				default:
					_003C_003Ec__DisplayClass67_._003C_003E4__this = this;
					num2 = 5;
					continue;
				case 7:
					try
					{
						IUnitOfWork unitOfWork = (IUnitOfWork)Tm1Lx2V35f6K3RPDMBV(unitOfWorkManager, string.Empty, true, IsolationLevel.ReadCommitted);
						int num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						default:
							try
							{
								WorkflowBackgroundOperationExecuteData workflowBackgroundOperationExecuteData = new WorkflowBackgroundOperationExecuteData((IBackgroundOperationInfo)noorOlVTASBlejGSYTn(_003C_003Ec__DisplayClass67_.queueItem));
								int num4 = 2;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
								{
									num4 = 2;
								}
								while (true)
								{
									switch (num4)
									{
									case 3:
									{
										object obj = noorOlVTASBlejGSYTn(_003C_003Ec__DisplayClass67_.queueItem);
										sdgHrUVpSSVnpICi13x(_003C_003Ec__DisplayClass67_.queueItem);
										((IEntity)obj).Delete();
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
										{
											num4 = 0;
										}
										break;
									}
									default:
										unitOfWork.Commit();
										num4 = 4;
										break;
									case 4:
										success = true;
										num4 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
										{
											num4 = 1;
										}
										break;
									case 2:
									{
										DSMjQOVFbkxLeX4MoGT(workflowRuntimeService, workflowBackgroundOperationExecuteData);
										int num5 = 3;
										num4 = num5;
										break;
									}
									case 1:
										return;
									}
								}
							}
							catch (Exception ex)
							{
								int num6 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
								{
									num6 = 1;
								}
								while (true)
								{
									switch (num6)
									{
									case 1:
										attemptExceptionInternal = ex;
										num6 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
										{
											num6 = 0;
										}
										break;
									default:
										EVqfHbVinsQK2GbP2ne(unitOfWork);
										num6 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
										{
											num6 = 2;
										}
										break;
									case 2:
										return;
									}
								}
							}
							finally
							{
								if (unitOfWork != null)
								{
									int num7 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
									{
										num7 = 0;
									}
									while (true)
									{
										switch (num7)
										{
										default:
											WgUqNmVI6bAPW0n6okd(unitOfWork);
											num7 = 1;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
											{
												num7 = 1;
											}
											continue;
										case 1:
											break;
										}
										break;
									}
								}
							}
						}
					}
					finally
					{
						int num8;
						if (extendableLock == null)
						{
							num8 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
							{
								num8 = 1;
							}
							goto IL_02c9;
						}
						goto IL_02fe;
						IL_02fe:
						WgUqNmVI6bAPW0n6okd(extendableLock);
						num8 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
						{
							num8 = 0;
						}
						goto IL_02c9;
						IL_02c9:
						switch (num8)
						{
						default:
							goto end_IL_02a4;
						case 1:
							goto end_IL_02a4;
						case 2:
							break;
						case 0:
							goto end_IL_02a4;
						}
						goto IL_02fe;
						end_IL_02a4:;
					}
				case 2:
					success = false;
					num2 = 6;
					continue;
				case 1:
					_003C_003Ec__DisplayClass67_ = new _003C_003Ec__DisplayClass67_0();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					return;
				}
				break;
			}
			extendableLock = new ExtendableLock((string)aFBb7XVtxn63snJEOUu(0x5F534A5C ^ 0x5F525C56), touchTimeout, _003C_003Ec__DisplayClass67_._003CInvokeScriptActivityUserCallback_003Eb__0, null);
			num = 7;
		}
	}

	static WorkflowQueueService()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				Log = Logger.GetLogger((string)aFBb7XVtxn63snJEOUu(0x1843E01F ^ 0x18431C2D));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 1:
				AttemptIntervals = new TimeSpan[9]
				{
					TimeSpan.Zero,
					TimeSpan.FromMinutes(1.0),
					TimeSpan.FromMinutes(1.0),
					NSmUpqVrihv1Wa6UCYu(1.0),
					NSmUpqVrihv1Wa6UCYu(2.0),
					NSmUpqVrihv1Wa6UCYu(5.0),
					NSmUpqVrihv1Wa6UCYu(10.0),
					NSmUpqVrihv1Wa6UCYu(15.0),
					NSmUpqVrihv1Wa6UCYu(25.0)
				};
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static Type Nk2TetVmhRBOtbduWJK(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object aFBb7XVtxn63snJEOUu(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object thLRxxVbunn2cOAQ25b(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object ONloEdV5DJEOOT7ZUD4(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object JrmIAeVgjn2dbmTb3oN(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static bool tso1bJV0h99NeGxvmIa()
	{
		return TS6yQGVlRuiHd9uBA41 == null;
	}

	internal static WorkflowQueueService mHjEuwVyBnUchXDcd51()
	{
		return TS6yQGVlRuiHd9uBA41;
	}

	internal static object U2jIqdVBfQbfYToiTWa(object P_0, object P_1)
	{
		return string.Concat(P_0, P_1);
	}

	internal static void RFXZjYVcTiLLeTUt8lt(object P_0, long itemId)
	{
		((WorkflowQueueItemManager)P_0).WorkflowQueueItemForcedLaunch(itemId);
	}

	internal static void NGXyEKVPanPCApYLbwD(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void D4QVY1VX3ekH4tgJq1p(object P_0, object P_1)
	{
		((IUnitOfWorkManager)P_0).RegisterPostCommitAction((Action)P_1);
	}

	internal static object BA8nBoVdsOHJo9RTTvP(object P_0)
	{
		return ((IWorkflowQueueItem)P_0).Instance;
	}

	internal static object Eks9fAVuCft8raabylQ(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static void qEjjTrVDCKA5mqKJOwG(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static bool B5D11RVnMBqqntRZvHr(object P_0)
	{
		return ((ILogger)P_0).IsDebugEnabled();
	}

	internal static long zrIbDEVHhGIP8Djq4pu(object P_0)
	{
		return ((IWorkflowQueueItem)P_0).Attempt;
	}

	internal static object uirg5HVLA2yNI0QNO4N(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object KP47GtVfk1LmhdvMyP5(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static object Ng9hX4V95wZhO9UZiQH(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static object ChiROrVWvoZlp18L9ia(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object n1J0kEVjwflFHW1WiFq(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object QXqqhfVRnFxopwi7X6Y(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static void exkJshV6eOZ7L9jRoxH(object P_0, object P_1)
	{
		((IEntityActionHandler)P_0).ActionExecuted((EntityActionEventArgs)P_1);
	}

	internal static object MyLR4uVqmIii0i97UDC()
	{
		return CallContextSessionOwner.Create();
	}

	internal static object Tm1Lx2V35f6K3RPDMBV(object P_0, object P_1, bool P_2, IsolationLevel P_3)
	{
		return ((IUnitOfWorkManager)P_0).Create((string)P_1, P_2, P_3);
	}

	internal static object noorOlVTASBlejGSYTn(object P_0)
	{
		return ((IWorkflowQueueItem)P_0).BackgroundOperation;
	}

	internal static WorkflowInstanceStatus lJ4XmeVQv4m7eJGAAVs(object P_0)
	{
		return ((IWorkflowInstance)P_0).Status;
	}

	internal static void sdgHrUVpSSVnpICi13x(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static void YcO0WqVCBiOIrniKLen(object P_0, long value)
	{
		((IWorkflowQueueItem)P_0).Attempt = value;
	}

	internal static void lqwAo5VMi0yGvTB8bhd(object P_0, object P_1)
	{
		((IWorkflowQueueItem)P_0).LastExceptionData = (ExceptionData)P_1;
	}

	internal static DateTime bhZwfAVkVXQ7XaD4Jxg(DateTime P_0, TimeSpan P_1)
	{
		return P_0 + P_1;
	}

	internal static void akuFmLVU2ry5rImUgqe(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object caQ7h3VV4eMLLP8QbjU(object P_0, object P_1, object P_2)
	{
		return ((IBackgroundOperationService)P_0).CreateUserCallbackQueueItem((IWorkflowQueueItem)P_1, (IBackgroundOperationResult)P_2);
	}

	internal static bool rqWPVwVA7gaWGfvRYkC()
	{
		return IsWorkflowQueueItemExecutor;
	}

	internal static void cxqIJ1VGWq6pMHdgecO(object P_0)
	{
		((IUnitOfWork)P_0).Commit();
	}

	internal static object Lpk8VNV7UDOqRfrlU8B()
	{
		return Logger.Log;
	}

	internal static bool NosMK4V2V2DlfjX3Lum(object P_0, Guid executionUid)
	{
		return ((WorkflowQueueDbService)P_0).TryDeleteProcessingItem(executionUid);
	}

	internal static bool Laf1pxVoDqnTBdFVYWD(object P_0, long queueItemId)
	{
		return ((WorkflowQueueDbService)P_0).TryDeleteWorkflowQueueItem(queueItemId);
	}

	internal static void DSMjQOVFbkxLeX4MoGT(object P_0, object P_1)
	{
		((WorkflowRuntimeService)P_0).Execute((IWorkflowExecuteData)P_1);
	}

	internal static void EVqfHbVinsQK2GbP2ne(object P_0)
	{
		((IUnitOfWork)P_0).Rollback();
	}

	internal static void WgUqNmVI6bAPW0n6okd(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object sOxJ6xVa5MEPgPNKc5K(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static TimeSpan NSmUpqVrihv1Wa6UCYu(double P_0)
	{
		return TimeSpan.FromMinutes(P_0);
	}
}
