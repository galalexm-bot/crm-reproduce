using System;
using System.Activities;
using System.Activities.Hosting;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.DurableInstancing;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Modules;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Threading;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;
using EleWise.ELMA.Workflow.Diagrams;
using EleWise.ELMA.Workflow.Diagrams.Activities;
using EleWise.ELMA.Workflow.Exceptions;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Scheduling;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Services;

internal class WorkflowExecutingContext : IWorkflowExecutingContext, IDisposable
{
	private class TrackingServiceImpl : IWorkflowTrackingService
	{
		private readonly object workflowTrackingItemManager;

		private readonly object context;

		private readonly object unitOfWorkManager;

		private readonly List<IWorkflowTrackingItem> newItems;

		private readonly Dictionary<Guid, DateTime> setEndDateItems;

		private bool actionRegistered;

		internal static object VWnxssZiHDCafs3gMTaa;

		public TrackingServiceImpl(IWorkflowExecutingContext context, IUnitOfWorkManager unitOfWorkManager, WorkflowTrackingItemManager workflowTrackingItemManager)
		{
			//Discarded unreachable code: IL_004a, IL_004f
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
			newItems = new List<IWorkflowTrackingItem>();
			setEndDateItems = new Dictionary<Guid, DateTime>();
			base._002Ector();
			int num = 4;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
			{
				num = 2;
			}
			while (true)
			{
				switch (num)
				{
				case 2:
					ycCdsHZiWtLJe5sm7SRc(workflowTrackingItemManager, mo6K2rZi9fucO7DxXeJC(-420003255 ^ -420112737));
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num = 6;
					}
					break;
				case 6:
					this.context = context;
					num = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 == 0)
					{
						num = 5;
					}
					break;
				case 1:
					return;
				case 4:
					Contract.ArgumentNotNull(context, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2269BD32 ^ 0x22698202));
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
					{
						num = 0;
					}
					break;
				default:
					ycCdsHZiWtLJe5sm7SRc(unitOfWorkManager, mo6K2rZi9fucO7DxXeJC(-452127399 ^ -451952151));
					num = 2;
					break;
				case 3:
					this.workflowTrackingItemManager = workflowTrackingItemManager;
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num = 1;
					}
					break;
				case 5:
					this.unitOfWorkManager = unitOfWorkManager;
					num = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public void Add(Guid elementUid, bool executed)
		{
			int num = 3;
			int num2 = num;
			IWorkflowTrackingItem @new = default(IWorkflowTrackingItem);
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
				{
					InstanceOf<IWorkflowTrackingItem> instanceOf = new InstanceOf<IWorkflowTrackingItem>();
					Qr4C7AZiReYex8i9UUQD(instanceOf.New, CVCa9PZijoT56mtRD9Ne(context));
					gxKZfdZi6GE9nMj925k7(instanceOf.New, elementUid);
					instanceOf.New.StartDate = DateTime.Now;
					@new = instanceOf.New;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 2;
					}
					break;
				}
				case 4:
					newItems.Add(@new);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
					{
						num2 = 5;
					}
					break;
				case 2:
					if (executed)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 4;
				case 5:
					RegisterAction();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 1:
					@new.EndDate = @new.StartDate;
					num2 = 4;
					break;
				}
			}
		}

		public void Execute(Guid elementUid)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					setEndDateItems[elementUid] = NkKHJXZiq3Mq4fkwo3UV();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 0;
					}
					break;
				default:
					RegisterAction();
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 2;
					}
					break;
				}
			}
		}

		private void RegisterAction()
		{
			//Discarded unreachable code: IL_0066
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					((IUnitOfWorkManager)unitOfWorkManager).RegisterPreCommitAction((Action)Flush);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					return;
				case 4:
					actionRegistered = true;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return;
				case 2:
					if (actionRegistered)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 4;
				}
			}
		}

		private void Flush()
		{
			//Discarded unreachable code: IL_004d, IL_005c, IL_0067, IL_00f9, IL_010c, IL_011b, IL_012c, IL_0136, IL_02bb, IL_02ce, IL_02dd
			int num = 1;
			int num2 = num;
			List<IWorkflowTrackingItem>.Enumerator enumerator2 = default(List<IWorkflowTrackingItem>.Enumerator);
			Dictionary<Guid, DateTime>.Enumerator enumerator = default(Dictionary<Guid, DateTime>.Enumerator);
			IWorkflowTrackingItem workflowTrackingItem = default(IWorkflowTrackingItem);
			_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
			KeyValuePair<Guid, DateTime> current = default(KeyValuePair<Guid, DateTime>);
			IWorkflowInstance workflowInstance = default(IWorkflowInstance);
			while (true)
			{
				switch (num2)
				{
				case 4:
					enumerator2 = newItems.GetEnumerator();
					num2 = 3;
					break;
				case 3:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator2.MoveNext())
							{
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
								{
									num5 = 0;
								}
								goto IL_006b;
							}
							goto IL_00a7;
							IL_00a7:
							sica2KZiTxVZaVDp18AB(enumerator2.Current);
							num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
							{
								num5 = 0;
							}
							goto IL_006b;
							IL_006b:
							switch (num5)
							{
							default:
								return;
							case 1:
								break;
							case 2:
								goto IL_00a7;
							case 0:
								return;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
				default:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 5;
								goto IL_013a;
							}
							goto IL_01c2;
							IL_013a:
							while (true)
							{
								object obj;
								switch (num3)
								{
								case 4:
									if (workflowTrackingItem != null)
									{
										num3 = 8;
										continue;
									}
									break;
								case 1:
									_003C_003Ec__DisplayClass10_.elementUid = current.Key;
									num3 = 3;
									continue;
								case 3:
									workflowInstance = (IWorkflowInstance)CVCa9PZijoT56mtRD9Ne(context);
									num3 = 6;
									continue;
								case 9:
									goto IL_01c2;
								case 8:
									workflowTrackingItem.EndDate = NkKHJXZiq3Mq4fkwo3UV();
									num3 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
									{
										num3 = 0;
									}
									continue;
								case 2:
									_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
									num3 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
									{
										num3 = 0;
									}
									continue;
								case 6:
									obj = newItems.LastOrDefault(_003C_003Ec__DisplayClass10_._003CFlush_003Eb__0);
									if (obj != null)
									{
										goto IL_0273;
									}
									num3 = 7;
									continue;
								case 7:
									obj = Ele66KZi3eukDDILXg1W(workflowTrackingItemManager, workflowInstance, _003C_003Ec__DisplayClass10_.elementUid);
									goto IL_0273;
								case 5:
									goto end_IL_01ac;
									IL_0273:
									workflowTrackingItem = (IWorkflowTrackingItem)obj;
									num3 = 4;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							}
							continue;
							IL_01c2:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
							{
								num3 = 2;
							}
							goto IL_013a;
							continue;
							end_IL_01ac:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
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
				case 1:
					enumerator = setEndDateItems.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
					{
						num2 = 0;
					}
					break;
				case 2:
					return;
				}
			}
		}

		internal static object mo6K2rZi9fucO7DxXeJC(int _0020)
		{
			return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void ycCdsHZiWtLJe5sm7SRc(object P_0, object P_1)
		{
			Contract.ArgumentNotNull(P_0, (string)P_1);
		}

		internal static bool ouTbEiZiLcf0DuMYFxMp()
		{
			return VWnxssZiHDCafs3gMTaa == null;
		}

		internal static TrackingServiceImpl ysn5GtZifZdsdr9Gw2Vl()
		{
			return (TrackingServiceImpl)VWnxssZiHDCafs3gMTaa;
		}

		internal static object CVCa9PZijoT56mtRD9Ne(object P_0)
		{
			return ((IWorkflowExecutingContext)P_0).Instance;
		}

		internal static void Qr4C7AZiReYex8i9UUQD(object P_0, object P_1)
		{
			((IWorkflowTrackingItem)P_0).Instance = (IWorkflowInstance)P_1;
		}

		internal static void gxKZfdZi6GE9nMj925k7(object P_0, Guid value)
		{
			((IWorkflowTrackingItem)P_0).ElementUid = value;
		}

		internal static DateTime NkKHJXZiq3Mq4fkwo3UV()
		{
			return DateTime.Now;
		}

		internal static object Ele66KZi3eukDDILXg1W(object P_0, object P_1, Guid elementUid)
		{
			return ((WorkflowTrackingItemManager)P_0).GetLastUnfinishedTracking((IWorkflowInstance)P_1, elementUid);
		}

		internal static void sica2KZiTxVZaVDp18AB(object P_0)
		{
			((IEntity)P_0).Save();
		}
	}

	private static readonly FetchOptions WorkflowInstanceFetchOptions;

	private static WorkflowTaskBaseManager workflowTaskBaseManager;

	private static IEnumerable<IWorkflowRootActivityInfo> workflowRootActivityInfos;

	private static ISecurityService securityService;

	private static IEnumerable<ISchedulerTaskJobExecutor> schedulerTaskJobExecutors;

	private static TaskBaseManager taskBaseManager;

	private static WorkflowQueueItemManager workflowQueueItemManager;

	private static IEnumerable<IWorkflowInstanceTerminateAction> workflowInstanceTerminateActions;

	private static ISessionProvider sessionProvider;

	private static WorkflowInstanceManager workflowInstanceManager;

	private readonly WorkflowRuntimeService runtime;

	private readonly IContextBoundVariableService contextBoundVariableService;

	private readonly IBackgroundOperationService backgroundOperationService;

	private readonly Queue<Action> executingQueue;

	private readonly bool stateLoaded;

	private readonly QueueSynchronizationContext syncContext;

	private Exception terminationException;

	private bool isRealTerminated;

	private bool isExecuting;

	internal static WorkflowExecutingContext bbWRjbGJFWNwYNZKJPJ;

	public WorkflowApplication Application
	{
		[CompilerGenerated]
		get
		{
			return _003CApplication_003Ek__BackingField;
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
				case 1:
					_003CApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
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

	public IWorkflowInstance Instance
	{
		[CompilerGenerated]
		get
		{
			return _003CInstance_003Ek__BackingField;
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
					_003CInstance_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsTerminated
	{
		[CompilerGenerated]
		get
		{
			return _003CIsTerminated_003Ek__BackingField;
		}
		[CompilerGenerated]
		internal set
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
					_003CIsTerminated_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	internal static int LockTimeout
	{
		get
		{
			//Discarded unreachable code: IL_00a8, IL_00b2
			int num = 3;
			int num4 = default(int);
			int? setting = default(int?);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					int num3;
					switch (num2)
					{
					case 5:
						return num4;
					default:
						num4 = 1;
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
						{
							num2 = 5;
						}
						continue;
					case 3:
						goto end_IL_0012;
					case 4:
						num3 = SR.GetSetting((string)ppmDRXGmAGne1Z8hypi(0x13F63440 ^ 0x13F73AAA), 1);
						break;
					case 2:
						if (setting.HasValue)
						{
							num2 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
							{
								num2 = 1;
							}
							continue;
						}
						goto case 4;
					case 6:
						if (num4 <= 0)
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 5;
					case 1:
						num3 = setting.GetValueOrDefault();
						break;
					}
					num4 = num3;
					num2 = 6;
					continue;
					end_IL_0012:
					break;
				}
				setting = SR.GetSetting<int?>((string)ppmDRXGmAGne1Z8hypi(0x651FE29D ^ 0x651EF807));
				num = 2;
			}
		}
	}

	private static ISecurityService SecurityService
	{
		get
		{
			int num = 1;
			int num2 = num;
			ISecurityService obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = securityService;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = (securityService = Locator.GetServiceNotNull<ISecurityService>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	private static IEnumerable<ISchedulerTaskJobExecutor> SchedulerTaskJobExecutors => schedulerTaskJobExecutors ?? (schedulerTaskJobExecutors = ComponentManager.Current.GetExtensionPoints<ISchedulerTaskJobExecutor>());

	private static TaskBaseManager TaskBaseManager
	{
		get
		{
			int num = 1;
			int num2 = num;
			TaskBaseManager obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = taskBaseManager;
					if (obj != null)
					{
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					obj = (taskBaseManager = Locator.GetServiceNotNull<TaskBaseManager>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	private static WorkflowQueueItemManager WorkflowQueueItemManager
	{
		get
		{
			int num = 1;
			int num2 = num;
			WorkflowQueueItemManager obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = workflowQueueItemManager;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (workflowQueueItemManager = Locator.GetServiceNotNull<WorkflowQueueItemManager>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	private static IEnumerable<IWorkflowInstanceTerminateAction> WorkflowInstanceTerminateActions => workflowInstanceTerminateActions ?? (workflowInstanceTerminateActions = ComponentManager.Current.GetExtensionPoints<IWorkflowInstanceTerminateAction>());

	private static ISessionProvider SessionProvider
	{
		get
		{
			int num = 1;
			int num2 = num;
			ISessionProvider obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = sessionProvider;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (sessionProvider = Locator.GetServiceNotNull<ISessionProvider>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	private static WorkflowInstanceManager WorkflowInstanceManager
	{
		get
		{
			int num = 1;
			int num2 = num;
			WorkflowInstanceManager obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = workflowInstanceManager;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (workflowInstanceManager = Locator.GetServiceNotNull<WorkflowInstanceManager>());
					break;
				}
				break;
			}
			return obj;
		}
	}

	private static IEnumerable<IWorkflowRootActivityInfo> WorkflowRootActivityInfos => workflowRootActivityInfos ?? (workflowRootActivityInfos = ComponentManager.Current.GetExtensionPoints<IWorkflowRootActivityInfo>());

	private static WorkflowTaskBaseManager WorkflowTaskBaseManager
	{
		get
		{
			int num = 1;
			int num2 = num;
			WorkflowTaskBaseManager obj;
			while (true)
			{
				switch (num2)
				{
				case 1:
					obj = workflowTaskBaseManager;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				default:
					obj = (workflowTaskBaseManager = (WorkflowTaskBaseManager)JSI5t37dDrET5pRagq0());
					break;
				}
				break;
			}
			return obj;
		}
	}

	internal WorkflowExecutingContext(WorkflowRuntimeService runtime, IWorkflowInstance instance, IContextBoundVariableService contextBoundVariableService, IBackgroundOperationService backgroundOperationService)
	{
		//Discarded unreachable code: IL_002e, IL_05a8, IL_05f3, IL_0602, IL_0611, IL_0621, IL_0661, IL_0670, IL_072b, IL_077d, IL_078c, IL_081f, IL_0950, IL_0982, IL_09a0, IL_09af, IL_0a51, IL_0a60, IL_0aa8, IL_0b12
		iA7yjVGyvZh5KcNKjgM();
		executingQueue = new Queue<Action>();
		base._002Ector();
		int num = 6;
		int num2 = num;
		Dictionary<Guid, WorkflowExecutingContext> executingContexts = default(Dictionary<Guid, WorkflowExecutingContext>);
		bool flag2 = default(bool);
		IWorkflowRootActivityInfo workflowRootActivityInfo = default(IWorkflowRootActivityInfo);
		_003C_003Ec__DisplayClass21_0 _003C_003Ec__DisplayClass21_ = default(_003C_003Ec__DisplayClass21_0);
		Guid? startActivityUid = default(Guid?);
		WorkflowRootActivity workflowRootActivity = default(WorkflowRootActivity);
		Guid empty = default(Guid);
		bool flag = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 15:
				syncContext = new QueueSynchronizationContext(CheckTerminationException);
				num2 = 4;
				break;
			case 3:
				this.backgroundOperationService = backgroundOperationService;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 9;
				}
				break;
			case 12:
				executingContexts = GetExecutingContexts(contextBoundVariableService);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				flag2 = false;
				num2 = 15;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
				{
					num2 = 17;
				}
				break;
			case 16:
				bELNaSGt7UC0irUNoba(runtime, ppmDRXGmAGne1Z8hypi(--1212129906 ^ 0x483EBA7A));
				num2 = 8;
				break;
			default:
				Instance = instance;
				num2 = 14;
				break;
			case 2:
				Contract.ArgumentNotNull(instance, (string)ppmDRXGmAGne1Z8hypi(-1542190822 ^ -1542172644));
				num2 = 7;
				break;
			case 7:
				bELNaSGt7UC0irUNoba(instance.Process, ppmDRXGmAGne1Z8hypi(-980570076 ^ -980610018));
				num2 = 13;
				break;
			case 1:
				workflowRootActivityInfo = WorkflowRootActivityInfos.FirstOrDefault(_003C_003Ec__DisplayClass21_._003C_002Ector_003Eb__0);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
				{
					num2 = 12;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass21_ = new _003C_003Ec__DisplayClass21_0();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
				{
					num2 = 0;
				}
				break;
			case 11:
				bELNaSGt7UC0irUNoba(contextBoundVariableService, ppmDRXGmAGne1Z8hypi(--1436248540 ^ 0x559A7E12));
				num2 = 16;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
				{
					num2 = 4;
				}
				break;
			case 13:
				bELNaSGt7UC0irUNoba(CY1EsbGbnRXtn1mCHxR(instance.Process), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EAAE69));
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
				{
					num2 = 11;
				}
				break;
			case 8:
				rQWJs0Gcd2EOsC6DNyk((IInternalWorkflowService)((ILicensedModuleAssembly)GQ9j0IGBvrc46Q64IUZ(M62JFHG5xPHWTZXUN03(ComponentManager.Current), MEMqpfGgUdDPrpNc5Jh())).LicenseUnit, instance);
				num2 = 15;
				break;
			case 9:
				_003C_003Ec__DisplayClass21_.diagram = (WorkflowDiagram)CY1EsbGbnRXtn1mCHxR(FBaRZwGPR1m4eB5mLWG(instance));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
				{
					num2 = 1;
				}
				break;
			case 10:
				return;
			case 14:
				this.contextBoundVariableService = contextBoundVariableService;
				num2 = 3;
				break;
			case 4:
				this.runtime = runtime;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
				{
					num2 = 0;
				}
				break;
			case 17:
				try
				{
					if (workflowRootActivityInfo != null)
					{
						int num3 = 15;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
						{
							num3 = 7;
						}
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 22:
								return;
							case 42:
							{
								WorkflowApplication application2 = Application;
								application2.PersistableIdle = (Func<WorkflowApplicationIdleEventArgs, PersistableIdleAction>)Delegate.Combine(application2.PersistableIdle, new Func<WorkflowApplicationIdleEventArgs, PersistableIdleAction>(OnIdleAndPersistable));
								num3 = 10;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
								{
									num3 = 27;
								}
								continue;
							}
							case 32:
								throw new InvalidOperationException((string)dpm8IrGXD4rukmrYQv7(ppmDRXGmAGne1Z8hypi(-1776305410 ^ -1776377236), new object[1] { instance.Id }));
							case 5:
								startActivityUid = instance.StartActivityUid;
								num3 = 12;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
								{
									num3 = 38;
								}
								continue;
							case 19:
								break;
							case 15:
								workflowRootActivity = (WorkflowRootActivity)QL23NHGu836Skoi6fd8(TYyYJfGdOSwypTNyHD5(workflowRootActivityInfo));
								num3 = 29;
								continue;
							case 13:
							case 16:
							case 37:
							{
								WorkflowApplication application = Application;
								application.Completed = (Action<WorkflowApplicationCompletedEventArgs>)Delegate.Combine(application.Completed, new Action<WorkflowApplicationCompletedEventArgs>(OnCompleted));
								num3 = 42;
								continue;
							}
							case 14:
								sknV1VG3QRhu9dpyGbT(ap4lUTGT42sljWcBDbM(Application), new TrackingServiceImpl(this, (IUnitOfWorkManager)GfmbbaGQG0Lqu4oc0js(runtime), (WorkflowTrackingItemManager)YfyXuUGpbEFgP2wPbbb(runtime)));
								num3 = 6;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
								{
									num3 = 2;
								}
								continue;
							case 27:
								Application.OnUnhandledException = OnUnhandledException;
								num3 = 22;
								continue;
							case 29:
								workflowRootActivity.LoadFromDiagram(_003C_003Ec__DisplayClass21_.diagram);
								num3 = 21;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
								{
									num3 = 23;
								}
								continue;
							case 39:
								flag2 = true;
								num3 = 41;
								continue;
							case 43:
								Application.SynchronizationContext = syncContext;
								num3 = 8;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
								{
									num3 = 25;
								}
								continue;
							case 38:
								empty = Guid.Empty;
								num3 = 33;
								continue;
							case 34:
							case 36:
								Iceo7HGqY3NE8lIfAcr(Application, new ElmaInstanceStore((IWorkflowInstanceState)xIaV3RGHJfvSuwVBtF7(instance)));
								num3 = 43;
								continue;
							case 1:
							case 30:
								Application = new WorkflowApplication(workflowRootActivity);
								num3 = 35;
								continue;
							default:
								flag = true;
								num3 = 7;
								continue;
							case 46:
							{
								WorkflowRootActivity workflowRootActivity2 = workflowRootActivity;
								startActivityUid = instance.StartActivityUid;
								irTp7gGnIv2NONfxvrb(workflowRootActivity2, startActivityUid.Value);
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							case 4:
								stateLoaded = true;
								num3 = 37;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
								{
									num3 = 13;
								}
								continue;
							case 45:
								if (startActivityUid.HasValue)
								{
									num3 = 5;
									continue;
								}
								goto case 1;
							case 25:
								sknV1VG3QRhu9dpyGbT(Application.Extensions, this);
								num4 = 14;
								goto IL_0307;
							case 35:
								flag = false;
								num3 = 12;
								continue;
							case 12:
								if (xIaV3RGHJfvSuwVBtF7(instance) != null)
								{
									num3 = 6;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
									{
										num3 = 17;
									}
									continue;
								}
								goto case 2;
							case 17:
							case 28:
								if (instance.Status == WorkflowInstanceStatus.Running)
								{
									if (!executingContexts.ContainsKey(obdy4DG9WVcD8oC1X37(instance.State)))
									{
										num3 = 20;
										continue;
									}
									goto case 40;
								}
								num3 = 32;
								continue;
							case 11:
								RCO5P1GCZb2xGBwnCdy(xIaV3RGHJfvSuwVBtF7(instance));
								num3 = 4;
								continue;
							case 24:
								stateLoaded = false;
								num3 = 16;
								continue;
							case 23:
								startActivityUid = instance.StartActivityUid;
								num3 = 31;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
								{
									num3 = 45;
								}
								continue;
							case 10:
							case 26:
								if (JhJVVnGMk2mE3Yaasg4(xIaV3RGHJfvSuwVBtF7(instance)) != null)
								{
									num3 = 31;
									continue;
								}
								goto case 24;
							case 8:
								Application.Load(obdy4DG9WVcD8oC1X37(xIaV3RGHJfvSuwVBtF7(instance)));
								num3 = 44;
								continue;
							case 33:
								if (startActivityUid.HasValue)
								{
									if (!startActivityUid.HasValue)
									{
										num3 = 30;
										continue;
									}
									if (!EUCEjVGDHB5G5VtyyNx(startActivityUid.GetValueOrDefault(), empty))
									{
										goto case 1;
									}
									goto case 3;
								}
								num4 = 3;
								goto IL_0307;
							case 7:
								executingContexts.Add(((IWorkflowInstanceState)xIaV3RGHJfvSuwVBtF7(instance)).Uid, this);
								num3 = 5;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
								{
									num3 = 9;
								}
								continue;
							case 2:
								yWM9GfGLgWrZAuTBsgL(instance, InterfaceActivator.Create<IWorkflowInstanceState>());
								num3 = 18;
								continue;
							case 9:
								flag2 = true;
								num3 = 34;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
								{
									num3 = 23;
								}
								continue;
							case 18:
								instance.State.Uid = nMR9SmGfWFdH658eMlQ(Application);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
								{
									num3 = 0;
								}
								continue;
							case 40:
								throw new InvalidOperationException((string)dpm8IrGXD4rukmrYQv7(ppmDRXGmAGne1Z8hypi(-11799394 ^ -11866660), new object[1] { instance.Id }));
							case 20:
								executingContexts.Add(obdy4DG9WVcD8oC1X37(xIaV3RGHJfvSuwVBtF7(instance)), this);
								num3 = 39;
								continue;
							case 41:
								try
								{
									mFOUHJGRmBUbxoYPUld(efAGyFGWlfG03Bq8fer(runtime), xIaV3RGHJfvSuwVBtF7(instance), Ob5wZSGjnFVr5VWRIwj());
									int num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
									{
										num5 = 0;
									}
									switch (num5)
									{
									case 0:
										break;
									}
								}
								catch (ObtainObjectLockException)
								{
									int num6 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
									{
										num6 = 0;
									}
									switch (num6)
									{
									default:
										throw new WorkflowInstanceLockException(instance.Id);
									}
								}
								goto case 21;
							case 21:
								EdeRCWG6cq3riFcBVLG(xIaV3RGHJfvSuwVBtF7(instance));
								num3 = 34;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
								{
									num3 = 36;
								}
								continue;
							case 6:
								if (!flag)
								{
									num3 = 26;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
									{
										num3 = 15;
									}
									continue;
								}
								goto case 11;
							case 31:
								if (((IWorkflowInstanceState)xIaV3RGHJfvSuwVBtF7(instance)).State.Length != 0)
								{
									num3 = 8;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
									{
										num3 = 8;
									}
									continue;
								}
								goto case 24;
							case 44:
								stateLoaded = true;
								num3 = 13;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
								{
									num3 = 11;
								}
								continue;
							case 3:
								{
									num3 = 46;
									continue;
								}
								IL_0307:
								num3 = num4;
								continue;
							}
							break;
						}
					}
					throw new Exception((string)dpm8IrGXD4rukmrYQv7(ppmDRXGmAGne1Z8hypi(-1895853023 ^ -1895920581), new object[1] { _003C_003Ec__DisplayClass21_.diagram.GetType() }));
				}
				catch
				{
					int num7 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
					{
						num7 = 0;
					}
					while (true)
					{
						switch (num7)
						{
						default:
							if (flag2)
							{
								num7 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
								{
									num7 = 1;
								}
								continue;
							}
							break;
						case 1:
							executingContexts.Remove(obdy4DG9WVcD8oC1X37(xIaV3RGHJfvSuwVBtF7(instance)));
							num7 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
							{
								num7 = 0;
							}
							continue;
						case 2:
							break;
						}
						break;
					}
					throw;
				}
			}
		}
	}

	public void EnqueueAction(Action action)
	{
		//Discarded unreachable code: IL_00b3, IL_00fe, IL_010d, IL_013a, IL_0149
		int num = 2;
		int num2 = num;
		ActivityExecutionContextHelper.IItemSetter itemSetter = default(ActivityExecutionContextHelper.IItemSetter);
		while (true)
		{
			switch (num2)
			{
			case 2:
				executingQueue.Enqueue(action);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (!isExecuting)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			default:
				itemSetter = ActivityExecutionContextHelper.SetWorkflowInstance(Instance);
				num2 = 3;
				break;
			case 3:
				try
				{
					ExecuteQueue();
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					int num5;
					if (itemSetter == null)
					{
						int num4 = 2;
						num5 = num4;
						goto IL_00e3;
					}
					goto IL_0118;
					IL_00e3:
					switch (num5)
					{
					case 2:
						goto end_IL_00ca;
					case 1:
						goto end_IL_00ca;
					}
					goto IL_0118;
					IL_0118:
					bElrpZGkqZugT9HW0pJ(itemSetter);
					num5 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
					{
						num5 = 0;
					}
					goto IL_00e3;
					end_IL_00ca:;
				}
			case 4:
				return;
			}
		}
	}

	public void Dispose()
	{
		int num = 1;
		int num2 = num;
		Dictionary<Guid, WorkflowExecutingContext> executingContexts = default(Dictionary<Guid, WorkflowExecutingContext>);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (xIaV3RGHJfvSuwVBtF7(Instance) != null)
				{
					num2 = 3;
					break;
				}
				return;
			default:
				if (Instance != null)
				{
					num2 = 4;
					break;
				}
				return;
			case 1:
				executingContexts = GetExecutingContexts(contextBoundVariableService);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 3:
				executingContexts.Remove(obdy4DG9WVcD8oC1X37(xIaV3RGHJfvSuwVBtF7(Instance)));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ResumeBookmark(string bookmarkName, object value)
	{
		int num = 3;
		_003C_003Ec__DisplayClass36_0 _003C_003Ec__DisplayClass36_ = default(_003C_003Ec__DisplayClass36_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					_003C_003Ec__DisplayClass36_.value = value;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					return;
				case 5:
					throw new InvalidOperationException(SR.T((string)ppmDRXGmAGne1Z8hypi(0x5DB28AD2 ^ 0x5DB39332)));
				case 4:
					if (stateLoaded)
					{
						EnqueueAction(_003C_003Ec__DisplayClass36_._003CResumeBookmark_003Eb__0);
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto end_IL_0012;
				default:
					_003C_003Ec__DisplayClass36_.bookmarkName = bookmarkName;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num2 = 6;
					}
					break;
				case 2:
					_003C_003Ec__DisplayClass36_._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					_003C_003Ec__DisplayClass36_ = new _003C_003Ec__DisplayClass36_0();
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
					{
						num2 = 2;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public void ResumeBookmark(Guid bookmarkUid, object value)
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
				ResumeBookmark(bookmarkUid.ToString(), value);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void Run()
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
				EnqueueAction(delegate
				{
					//Discarded unreachable code: IL_0076, IL_00d7, IL_010f, IL_011e
					int num3 = 2;
					int num4 = num3;
					ActivityExecutionContextHelper.IItemSetter itemSetter = default(ActivityExecutionContextHelper.IItemSetter);
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 0:
							return;
						case 2:
							itemSetter = (ActivityExecutionContextHelper.IItemSetter)AevqFNGUiepR948QBtR(Instance);
							num4 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
							{
								num4 = 1;
							}
							break;
						case 1:
							try
							{
								SeGgC67nuvOPMd0siuM(Application);
								int num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										return;
									default:
										syncContext.ExecuteQueue();
										num5 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
										{
											num5 = 1;
										}
										break;
									}
								}
							}
							finally
							{
								if (itemSetter != null)
								{
									int num6 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
									{
										num6 = 1;
									}
									while (true)
									{
										switch (num6)
										{
										case 1:
											itemSetter.Dispose();
											num6 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
											{
												num6 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void Terminate(string reason)
	{
		//Discarded unreachable code: IL_00e8, IL_017e, IL_01b6, IL_01c5
		int num = 2;
		int num2 = num;
		ActivityExecutionContextHelper.IItemSetter itemSetter = default(ActivityExecutionContextHelper.IItemSetter);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				if (isRealTerminated)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				itemSetter = (ActivityExecutionContextHelper.IItemSetter)AevqFNGUiepR948QBtR(Instance);
				num2 = 3;
				break;
			case 3:
				try
				{
					isRealTerminated = true;
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 5:
							return;
						case 7:
							return;
						case 3:
							syncContext.ExecuteQueue();
							num3 = 7;
							break;
						case 6:
							w6pJwtGA4LZ0G5JCB3N(syncContext);
							num3 = 5;
							break;
						default:
							IsTerminated = true;
							num3 = 4;
							break;
						case 2:
							ProcessCompletion(new WorkflowApplicationTerminatedException(reason));
							num3 = 6;
							break;
						case 1:
						{
							ttqUe4GVbm80UlSHMYU(Application, reason);
							int num4 = 3;
							num3 = num4;
							break;
						}
						case 4:
							if (stateLoaded)
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
								{
									num3 = 1;
								}
								break;
							}
							goto case 2;
						}
					}
				}
				finally
				{
					if (itemSetter != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								bElrpZGkqZugT9HW0pJ(itemSetter);
								num5 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
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

	internal static IWorkflowExecutingContext Create(WorkflowRuntimeService runtime, IWorkflowInstance instance, IContextBoundVariableService contextBoundVariableService, IBackgroundOperationService backgroundOperationService)
	{
		int num = 1;
		WorkflowExecutingContext value = default(WorkflowExecutingContext);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return new WorkflowExecutingContextWrapper(value);
				case 1:
					bELNaSGt7UC0irUNoba(instance, ppmDRXGmAGne1Z8hypi(0x42311138 ^ 0x4231483E));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					if (GetExecutingContexts(contextBoundVariableService).TryGetValue(obdy4DG9WVcD8oC1X37(xIaV3RGHJfvSuwVBtF7(instance)), out value))
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto IL_0038;
				case 4:
					{
						if (xIaV3RGHJfvSuwVBtF7(instance) != null)
						{
							num2 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
							{
								num2 = 3;
							}
							continue;
						}
						goto IL_0038;
					}
					IL_0038:
					return new WorkflowExecutingContext(runtime, instance, contextBoundVariableService, backgroundOperationService);
				}
				break;
			}
			bELNaSGt7UC0irUNoba(contextBoundVariableService, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EE17AD));
			num = 4;
		}
	}

	private static Dictionary<Guid, WorkflowExecutingContext> GetExecutingContexts(object contextBoundVariableService)
	{
		return ((IContextBoundVariableService)contextBoundVariableService).GetOrAdd(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45760671), () => new Dictionary<Guid, WorkflowExecutingContext>());
	}

	private UnhandledExceptionAction OnUnhandledException(WorkflowApplicationUnhandledExceptionEventArgs e)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return UnhandledExceptionAction.Abort;
			default:
				terminationException = (Exception)L2GlFcGo5TDEVs2pVvT(e);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				((ILogger)JS3CeYGGHiPTbbSmwDt()).Error(string.Format((string)ppmDRXGmAGne1Z8hypi(0x70EBB9F3 ^ 0x70EAA29B), (a2vkkQG7LO07C13GR0O(e) != null) ? WHp8oXG2YSx0yhEq2Fx(a2vkkQG7LO07C13GR0O(e)) : ""), (Exception)L2GlFcGo5TDEVs2pVvT(e));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private void OnCompleted(WorkflowApplicationCompletedEventArgs e)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass45_0 _003C_003Ec__DisplayClass45_ = default(_003C_003Ec__DisplayClass45_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass45_ = new _003C_003Ec__DisplayClass45_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			case 2:
				dPckn8GiypEmbqKNxRn(WKPcUEGFJvjsV564163(), new Action(_003C_003Ec__DisplayClass45_._003COnCompleted_003Eb__0));
				num2 = 3;
				break;
			default:
				_003C_003Ec__DisplayClass45_._003C_003E4__this = this;
				num2 = 4;
				break;
			case 4:
				_003C_003Ec__DisplayClass45_.e = e;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	private void ProcessCompletion(WorkflowApplicationCompletedEventArgs e)
	{
		//Discarded unreachable code: IL_0052
		int num = 3;
		int num2 = num;
		Exception completionException = default(Exception);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
				if (e == null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				obj = dDu9qaGI2Xc0BEQgdY0(e);
				break;
			case 2:
				obj = null;
				break;
			default:
				ProcessCompletion(completionException);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				return;
			}
			completionException = (Exception)obj;
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
			{
				num2 = 0;
			}
		}
	}

	private void ProcessCompletion(Exception completionException)
	{
		//Discarded unreachable code: IL_014a, IL_0154, IL_02d8, IL_0318, IL_0327, IL_0333, IL_0371, IL_0380, IL_0390, IL_039f, IL_04a1, IL_04b0, IL_04d6, IL_0563, IL_05b1, IL_05c0, IL_067c, IL_068b, IL_06e8, IL_06f7, IL_0707, IL_0836, IL_086e, IL_087d, IL_08ef, IL_0916, IL_0925, IL_0930, IL_09bf, IL_09f2, IL_0a6a, IL_0a9a, IL_0ada, IL_0ae5, IL_0af4, IL_0ba1, IL_0be3, IL_0c1b, IL_0c3a, IL_0c49, IL_0c76, IL_0c99, IL_0d4c, IL_0d5b, IL_0db2, IL_0dec, IL_0dfa, IL_0e8c, IL_0eab, IL_0eba, IL_0ee7, IL_0ef6, IL_0f06, IL_0faa, IL_0fe4, IL_0ff3
		switch (1)
		{
		case 1:
			try
			{
				int num;
				if (completionException == null)
				{
					num = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num = 35;
					}
					goto IL_0049;
				}
				goto IL_0cb9;
				IL_0049:
				SubProcessElement subProcessElement = default(SubProcessElement);
				IEnumerator<IWorkflowTaskBase> enumerator4 = default(IEnumerator<IWorkflowTaskBase>);
				_003C_003Ec__DisplayClass47_0 _003C_003Ec__DisplayClass47_2 = default(_003C_003Ec__DisplayClass47_0);
				IWorkflowTaskBase current2 = default(IWorkflowTaskBase);
				IWorkflowInstance workflowInstance = default(IWorkflowInstance);
				long[] ids = default(long[]);
				IWorkflowInstanceFilter @new = default(IWorkflowInstanceFilter);
				Guid? subProcessElementUid = default(Guid?);
				IEnumerator<IWorkflowInstance> enumerator3 = default(IEnumerator<IWorkflowInstance>);
				_003C_003Ec__DisplayClass47_1 _003C_003Ec__DisplayClass47_ = default(_003C_003Ec__DisplayClass47_1);
				SubProcessElement subProcessElement2 = default(SubProcessElement);
				IEnumerator<IWorkflowInstanceSchedulerJobExecutor> enumerator = default(IEnumerator<IWorkflowInstanceSchedulerJobExecutor>);
				IWorkflowInstanceSchedulerJobExecutor current = default(IWorkflowInstanceSchedulerJobExecutor);
				IWorkflowExecutingContext workflowExecutingContext = default(IWorkflowExecutingContext);
				IEnumerator<IWorkflowInstanceTerminateAction> enumerator2 = default(IEnumerator<IWorkflowInstanceTerminateAction>);
				while (true)
				{
					int num6;
					switch (num)
					{
					case 52:
						subProcessElement = null;
						num = 46;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
						{
							num = 7;
						}
						continue;
					case 43:
						try
						{
							while (true)
							{
								int num14;
								if (!enumerator4.MoveNext())
								{
									num14 = 3;
									goto IL_0158;
								}
								goto IL_028e;
								IL_0158:
								while (true)
								{
									switch (num14)
									{
									case 4:
									{
										object manager = SJma8PG1vwuugJS3rfb();
										ParameterExpression parameterExpression = (ParameterExpression)Ak90QWGEpe1XvW1TuRv(rSqvLYGhRwX4vOvZAk9(typeof(TaskBaseManager).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x1135CEEE));
										((TaskBaseManager)manager).InvokeAction(Expression.Lambda<Action<TaskBaseManager>>((Expression)Od1TV97OJoqtJ492i5I(parameterExpression, (MethodInfo)BXUHTkGwiNhdPP65FOd((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(TaskBaseManager<ITaskBase>).TypeHandle), new Expression[3]
										{
											(Expression)xtRy7O7KeY4LurFymrY(qOuFB5G4mpht2VwiIJq(_003C_003Ec__DisplayClass47_2, rSqvLYGhRwX4vOvZAk9(typeof(_003C_003Ec__DisplayClass47_0).TypeHandle)), cQxq5OGzyDkD3Qb2mS5((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/)),
											(Expression)qOuFB5G4mpht2VwiIJq(false, rSqvLYGhRwX4vOvZAk9(typeof(bool).TypeHandle)),
											(Expression)qOuFB5G4mpht2VwiIJq(null, rSqvLYGhRwX4vOvZAk9(typeof(ICommentActionModel).TypeHandle))
										}), new ParameterExpression[1] { parameterExpression }), _003C_003Ec__DisplayClass47_2.workflowTask.GetType());
										num14 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
										{
											num14 = 0;
										}
										continue;
									}
									case 5:
										_003C_003Ec__DisplayClass47_2.workflowTask = current2.CastAsRealType();
										num14 = 4;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
										{
											num14 = 0;
										}
										continue;
									case 2:
										goto IL_028e;
									case 1:
										_003C_003Ec__DisplayClass47_2 = new _003C_003Ec__DisplayClass47_0();
										num14 = 5;
										continue;
									case 3:
										goto end_IL_0278;
									}
									break;
								}
								continue;
								IL_028e:
								current2 = enumerator4.Current;
								num14 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
								{
									num14 = 1;
								}
								goto IL_0158;
								continue;
								end_IL_0278:
								break;
							}
						}
						finally
						{
							int num15;
							if (enumerator4 == null)
							{
								num15 = 2;
								goto IL_02dc;
							}
							goto IL_02f2;
							IL_02dc:
							switch (num15)
							{
							case 2:
								goto end_IL_02c7;
							case 1:
								goto end_IL_02c7;
							}
							goto IL_02f2;
							IL_02f2:
							bElrpZGkqZugT9HW0pJ(enumerator4);
							num15 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
							{
								num15 = 0;
							}
							goto IL_02dc;
							end_IL_02c7:;
						}
						goto case 14;
					case 2:
						Instance.EndDate = iuEskDGx6C80TAkFhet();
						num = 21;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
						{
							num = 21;
						}
						continue;
					case 40:
						workflowInstance = (IWorkflowInstance)hSAvQZ7lNAYHdK4A0J2(Instance);
						num = 50;
						continue;
					case 14:
						ids = (long[])b1TsNI7va5A3K8RU8NQ(LRMhEq7Z9HC7LqnGnYd(), Instance);
						num = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
						{
							num = 19;
						}
						continue;
					case 31:
						subProcessElement = (SubProcessElement)((IWorkflowProcess)FBaRZwGPR1m4eB5mLWG(hSAvQZ7lNAYHdK4A0J2(Instance))).Diagram.Elements.First(delegate(Element elem)
						{
							//Discarded unreachable code: IL_008f
							int num19 = 2;
							int num20 = num19;
							Guid? subProcessElementUid2 = default(Guid?);
							Guid guid = default(Guid);
							while (true)
							{
								switch (num20)
								{
								case 1:
									subProcessElementUid2 = Instance.SubProcessElementUid;
									num20 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
									{
										num20 = 0;
									}
									break;
								case 2:
									guid = om04LW7LWTfdHL2mGXb(elem);
									num20 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
									{
										num20 = 1;
									}
									break;
								case 4:
									return false;
								case 3:
									return T6jMi87HVHQnlwZM2iL(guid, subProcessElementUid2.GetValueOrDefault());
								default:
									if (subProcessElementUid2.HasValue)
									{
										num20 = 3;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
										{
											num20 = 2;
										}
										break;
									}
									goto case 4;
								}
							}
						});
						num = 33;
						continue;
					case 1:
					{
						InstanceOf<IWorkflowInstanceFilter> instanceOf = new InstanceOf<IWorkflowInstanceFilter>();
						instanceOf.New.ParentInstance = Instance;
						instanceOf.New.Statuses = new List<WorkflowInstanceStatus> { WorkflowInstanceStatus.Running };
						@new = instanceOf.New;
						num = 7;
						continue;
					}
					case 45:
						subProcessElementUid = Instance.SubProcessElementUid;
						num = 11;
						continue;
					case 10:
						if (Instance.ParentBookmark == null)
						{
							num6 = 9;
							goto IL_0045;
						}
						goto case 16;
					default:
						OTCs4ZGNEYKIKKtxyFW(Instance, WorkflowInstanceStatus.Completed);
						num = 2;
						continue;
					case 5:
					case 18:
						if (hSAvQZ7lNAYHdK4A0J2(Instance) != null)
						{
							num = 31;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
							{
								num = 45;
							}
							continue;
						}
						goto case 13;
					case 21:
						Instance.Save();
						num = 15;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
						{
							num = 8;
						}
						continue;
					case 23:
						Instance.EndDate = iuEskDGx6C80TAkFhet();
						num = 22;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
						{
							num = 49;
						}
						continue;
					case 42:
						if (completionException != null)
						{
							num = 41;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
							{
								num = 17;
							}
							continue;
						}
						goto default;
					case 41:
						OTCs4ZGNEYKIKKtxyFW(Instance, WorkflowInstanceStatus.Terminated);
						num6 = 23;
						goto IL_0045;
					case 29:
						try
						{
							while (true)
							{
								IL_06cd:
								int num11;
								if (!KfyjQVGe1Vc5R9OdByG(enumerator3))
								{
									num11 = 12;
									goto IL_05cf;
								}
								goto IL_0696;
								IL_05cf:
								while (true)
								{
									switch (num11)
									{
									default:
										((WorkflowInstanceManager)qIMoXn7yEonpPyP8Z5v()).Terminate(_003C_003Ec__DisplayClass47_.subInstance, (string)F8J5847mMCMnxGtyeyw(completionException), AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
										num11 = 5;
										continue;
									case 14:
										subProcessElement2 = null;
										num11 = 15;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
										{
											num11 = 15;
										}
										continue;
									case 15:
										if (_003C_003Ec__DisplayClass47_.subInstance.ParentBookmark == null)
										{
											num11 = 3;
											continue;
										}
										goto case 8;
									case 1:
										break;
									case 7:
										if (subProcessElementUid.HasValue)
										{
											num11 = 3;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
											{
												num11 = 11;
											}
											continue;
										}
										goto case 6;
									case 4:
									case 5:
										goto IL_06cd;
									case 3:
									case 13:
										subProcessElementUid = _003C_003Ec__DisplayClass47_.subInstance.SubProcessElementUid;
										num11 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 != 0)
										{
											num11 = 7;
										}
										continue;
									case 11:
										subProcessElement2 = (SubProcessElement)((IEnumerable<Element>)nWJwIM7JApiSco9YwHf(CY1EsbGbnRXtn1mCHxR(FBaRZwGPR1m4eB5mLWG(Instance)))).First(_003C_003Ec__DisplayClass47_._003CProcessCompletion_003Eb__4);
										num11 = 6;
										continue;
									case 10:
										if (eSL9hC7gEr6d7XwKBQq(subProcessElement2))
										{
											num11 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
											{
												num11 = 0;
											}
											continue;
										}
										goto IL_06cd;
									case 6:
									case 9:
										if (subProcessElement2 == null)
										{
											num11 = 4;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
											{
												num11 = 1;
											}
											continue;
										}
										goto case 10;
									case 8:
									{
										subProcessElement2 = (SubProcessElement)((IEnumerable<Element>)nWJwIM7JApiSco9YwHf(CY1EsbGbnRXtn1mCHxR(FBaRZwGPR1m4eB5mLWG(Instance)))).First(_003C_003Ec__DisplayClass47_._003CProcessCompletion_003Eb__3);
										int num12 = 9;
										num11 = num12;
										continue;
									}
									case 2:
										_003C_003Ec__DisplayClass47_.subInstance = enumerator3.Current;
										num11 = 14;
										continue;
									case 12:
										return;
									}
									break;
								}
								goto IL_0696;
								IL_0696:
								_003C_003Ec__DisplayClass47_ = new _003C_003Ec__DisplayClass47_1();
								num11 = 2;
								goto IL_05cf;
							}
						}
						finally
						{
							if (enumerator3 != null)
							{
								int num13 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
								{
									num13 = 0;
								}
								while (true)
								{
									switch (num13)
									{
									case 1:
										bElrpZGkqZugT9HW0pJ(enumerator3);
										num13 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
										{
											num13 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
					case 34:
						break;
					case 11:
						if (!subProcessElementUid.HasValue)
						{
							num = 13;
							continue;
						}
						goto case 31;
					case 20:
					case 48:
						if (GetExecutingContexts(contextBoundVariableService).ContainsKey(((IWorkflowInstanceState)xIaV3RGHJfvSuwVBtF7(workflowInstance)).Uid))
						{
							num = 12;
							continue;
						}
						goto case 4;
					case 19:
						backgroundOperationService.CancelBackgroundOperation(ids);
						num = 25;
						continue;
					case 47:
						try
						{
							while (true)
							{
								int num7;
								if (!KfyjQVGe1Vc5R9OdByG(enumerator))
								{
									num7 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
									{
										num7 = 1;
									}
									goto IL_0934;
								}
								goto IL_0974;
								IL_0974:
								current = enumerator.Current;
								num7 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
								{
									num7 = 0;
								}
								goto IL_0934;
								IL_0934:
								switch (num7)
								{
								case 3:
									continue;
								case 1:
									goto IL_0974;
								case 2:
									goto end_IL_094e;
								}
								try
								{
									putuxgGa5ID7NbxsrNr(current, Instance);
									int num8 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
									{
										num8 = 0;
									}
									switch (num8)
									{
									case 0:
										break;
									}
								}
								catch (Exception ex)
								{
									int num9 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
									{
										num9 = 0;
									}
									while (true)
									{
										switch (num9)
										{
										case 1:
											RcuFb8GrZZudZZexXYl(JS3CeYGGHiPTbbSmwDt(), string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-885093259 ^ -885024841), current.GetType().FullName, Instance.Id), ex);
											num9 = 0;
											if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
											{
												num9 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
								continue;
								end_IL_094e:
								break;
							}
						}
						finally
						{
							int num10;
							if (enumerator == null)
							{
								num10 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
								{
									num10 = 0;
								}
								goto IL_0a9e;
							}
							goto IL_0ab4;
							IL_0ab4:
							enumerator.Dispose();
							num10 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
							{
								num10 = 1;
							}
							goto IL_0a9e;
							IL_0a9e:
							switch (num10)
							{
							default:
								goto end_IL_0a79;
							case 2:
								break;
							case 0:
								goto end_IL_0a79;
							case 1:
								goto end_IL_0a79;
							}
							goto IL_0ab4;
							end_IL_0a79:;
						}
						goto case 42;
					case 30:
						subProcessElement = (SubProcessElement)((IEnumerable<Element>)nWJwIM7JApiSco9YwHf(((IWorkflowProcess)FBaRZwGPR1m4eB5mLWG(Instance.ParentBookmark.Instance)).Diagram)).First(delegate(Element elem)
						{
							//Discarded unreachable code: IL_0077
							int num17 = 2;
							int num18 = num17;
							Guid? elementUid = default(Guid?);
							Guid uid = default(Guid);
							while (true)
							{
								switch (num18)
								{
								case 3:
									if (elementUid.HasValue)
									{
										num18 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
										{
											num18 = 0;
										}
										break;
									}
									goto case 4;
								case 1:
									elementUid = ((IWorkflowBookmark)CcusPr7tdyTYYxlYXIF(Instance)).ElementUid;
									num18 = 3;
									break;
								case 2:
									uid = elem.Uid;
									num18 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
									{
										num18 = 1;
									}
									break;
								case 4:
									return false;
								default:
									return T6jMi87HVHQnlwZM2iL(uid, elementUid.GetValueOrDefault());
								}
							}
						});
						num = 38;
						continue;
					case 49:
						enumerator4 = ((WorkflowTaskBaseManager)DvesEmGS4jN0ybl5KMg()).GetTasks(Instance).GetEnumerator();
						num = 43;
						continue;
					case 51:
						if (((IWorkflowInstanceState)xIaV3RGHJfvSuwVBtF7(workflowInstance)).State == null)
						{
							num = 48;
							continue;
						}
						goto case 8;
					case 4:
					case 9:
					case 24:
					case 32:
						if (completionException != null)
						{
							num = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
							{
								num = 1;
							}
							continue;
						}
						return;
					case 3:
						try
						{
							H4oVqh75ZiqwdaQtMiE(workflowExecutingContext, sNLGLA7baF76LXk8Kuf(CcusPr7tdyTYYxlYXIF(Instance)), Instance);
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
						finally
						{
							int num5;
							if (workflowExecutingContext == null)
							{
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 != 0)
								{
									num5 = 1;
								}
								goto IL_0c1f;
							}
							goto IL_0c54;
							IL_0c54:
							bElrpZGkqZugT9HW0pJ(workflowExecutingContext);
							num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
							{
								num5 = 0;
							}
							goto IL_0c1f;
							IL_0c1f:
							switch (num5)
							{
							default:
								goto end_IL_0bfa;
							case 1:
								goto end_IL_0bfa;
							case 2:
								break;
							case 0:
								goto end_IL_0bfa;
							}
							goto IL_0c54;
							end_IL_0bfa:;
						}
						goto case 4;
					case 6:
						if (completionException != null)
						{
							num = 27;
							continue;
						}
						goto case 10;
					case 27:
						if (subProcessElement.TerminateParentProcess)
						{
							num = 17;
							continue;
						}
						goto case 10;
					case 26:
						goto IL_0cb9;
					case 25:
						enumerator2 = WorkflowInstanceTerminateActions.GetEnumerator();
						num = 36;
						continue;
					case 46:
						if (Instance.ParentBookmark == null)
						{
							num = 18;
							continue;
						}
						goto case 30;
					case 50:
						if (givtpW70eSNBUF5RZHZ(workflowInstance) == WorkflowInstanceStatus.Running)
						{
							num = 6;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
							{
								num = 1;
							}
							continue;
						}
						goto case 4;
					case 7:
						enumerator3 = ((AbstractNHEntityManager<IWorkflowInstance, long>)qIMoXn7yEonpPyP8Z5v()).Find((IEntityFilter)@new, WorkflowInstanceFetchOptions).GetEnumerator();
						num = 29;
						continue;
					case 12:
					case 44:
						workflowExecutingContext = runtime.CreateExecutingContext(workflowInstance);
						num = 3;
						continue;
					case 15:
						gqclMg7sUouSoo1eTTS(G4lRGC78dAgdAGJbEbe(SessionProvider, ""));
						num = 52;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
						{
							num = 14;
						}
						continue;
					case 16:
						if (xIaV3RGHJfvSuwVBtF7(workflowInstance) != null)
						{
							num = 51;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
							{
								num = 28;
							}
							continue;
						}
						goto case 4;
					case 36:
						try
						{
							while (true)
							{
								int num2;
								if (!KfyjQVGe1Vc5R9OdByG(enumerator2))
								{
									num2 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
									{
										num2 = 0;
									}
									goto IL_0dfe;
								}
								goto IL_0e3a;
								IL_0e3a:
								Oa8HAK7YaciA1nKEN8B(enumerator2.Current, Instance);
								num2 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
								{
									num2 = 0;
								}
								goto IL_0dfe;
								IL_0dfe:
								switch (num2)
								{
								case 1:
									continue;
								case 2:
									goto IL_0e3a;
								case 0:
									break;
								}
								break;
							}
						}
						finally
						{
							int num3;
							if (enumerator2 == null)
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
								{
									num3 = 0;
								}
								goto IL_0e90;
							}
							goto IL_0ec5;
							IL_0ec5:
							bElrpZGkqZugT9HW0pJ(enumerator2);
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
							{
								num3 = 0;
							}
							goto IL_0e90;
							IL_0e90:
							switch (num3)
							{
							default:
								goto end_IL_0e6b;
							case 1:
								goto end_IL_0e6b;
							case 2:
								break;
							case 0:
								goto end_IL_0e6b;
							}
							goto IL_0ec5;
							end_IL_0e6b:;
						}
						goto case 21;
					case 39:
						return;
					case 13:
					case 33:
					case 38:
						if (subProcessElement == null)
						{
							num = 32;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
							{
								num = 16;
							}
							continue;
						}
						goto case 40;
					case 17:
						((WorkflowInstanceManager)qIMoXn7yEonpPyP8Z5v()).Terminate(workflowInstance, (string)F8J5847mMCMnxGtyeyw(completionException), AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
						num = 24;
						continue;
					case 8:
						if (((Array)JhJVVnGMk2mE3Yaasg4(xIaV3RGHJfvSuwVBtF7(workflowInstance))).Length != 0)
						{
							num = 44;
							continue;
						}
						goto case 20;
					case 22:
					case 28:
					case 35:
						enumerator = SchedulerTaskJobExecutors.OfType<IWorkflowInstanceSchedulerJobExecutor>().GetEnumerator();
						num = 47;
						continue;
					case 37:
						return;
						IL_0045:
						num = num6;
						continue;
					}
					break;
				}
				goto IL_0888;
				IL_0888:
				terminationException = completionException;
				num = 26;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
				{
					num = 39;
				}
				goto IL_0049;
				IL_0cb9:
				if (completionException is WorkflowApplicationTerminatedException)
				{
					num = 22;
					goto IL_0049;
				}
				goto IL_0888;
			}
			catch (Exception ex2)
			{
				int num16 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
				{
					num16 = 1;
				}
				while (true)
				{
					switch (num16)
					{
					case 1:
						terminationException = ex2;
						num16 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
						{
							num16 = 0;
						}
						break;
					default:
						throw;
					}
				}
			}
		case 0:
			break;
		}
	}

	private PersistableIdleAction OnIdleAndPersistable(WorkflowApplicationIdleEventArgs e)
	{
		return PersistableIdleAction.None;
	}

	private void ExecuteQueue()
	{
		//Discarded unreachable code: IL_0098, IL_00e1, IL_00f0, IL_0100, IL_013f, IL_014e, IL_017f, IL_01b2, IL_0224, IL_0237, IL_0246
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					int num3;
					if (isRealTerminated)
					{
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
						{
							num3 = 0;
						}
						goto IL_0052;
					}
					goto IL_011f;
					IL_0052:
					while (true)
					{
						switch (num3)
						{
						case 2:
							CheckTerminationException();
							num3 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
							{
								num3 = 0;
							}
							continue;
						case 1:
							pLX0ka7BDpOHf8iUhKV(executingQueue.Dequeue());
							num3 = 2;
							continue;
						case 5:
						case 6:
							if (isRealTerminated)
							{
								num3 = 4;
								continue;
							}
							goto case 1;
						case 3:
						case 8:
							goto IL_011f;
						case 7:
							try
							{
								CZxAvI7P6vvp9FYhwIt(Application);
								int num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
								{
									num4 = 0;
								}
								switch (num4)
								{
								case 0:
									break;
								}
								return;
							}
							catch (Exception exception)
							{
								int num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f == 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									case 1:
										return;
									}
									((ILogger)JS3CeYGGHiPTbbSmwDt()).Error(ppmDRXGmAGne1Z8hypi(-1214182792 ^ -1214245300), exception);
									num5 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
									{
										num5 = 1;
									}
								}
							}
						}
						break;
					}
					goto IL_0084;
					IL_0084:
					int num6 = 7;
					num3 = num6;
					goto IL_0052;
					IL_011f:
					if (aksqrw7cPpS9fijpSUk(executingQueue) > 0)
					{
						num3 = 6;
						goto IL_0052;
					}
					goto IL_0084;
				}
				finally
				{
					isExecuting = false;
					int num7 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
			case 2:
				isExecuting = true;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void CheckTerminationException()
	{
		//Discarded unreachable code: IL_0075, IL_0084
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				throw new InvalidOperationException((string)cfUghg7XD80y1vy9jxS(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498878021)), terminationException);
			case 0:
				return;
			case 1:
				if (terminationException == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	static WorkflowExecutingContext()
	{
		int num = 2;
		int num2 = num;
		FetchOptions fetchOptions = default(FetchOptions);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				WorkflowInstanceFetchOptions = fetchOptions;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				fetchOptions = new FetchOptions(0, 0);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
			{
				FetchOptions fetchOptions2 = fetchOptions;
				string[] array = new string[1];
				ParameterExpression parameterExpression = Expression.Parameter(typeof(IWorkflowInstance), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-768800937 ^ -768800531));
				array[0] = InterfaceActivator.PropertyName(Expression.Lambda<Func<IWorkflowInstance, object>>((Expression)LQyAQG7Di95P3cXOVZA(parameterExpression, (MethodInfo)B2JAsp7uaYbPaPFQW9C((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
				fetchOptions2.FetchRelations = new List<string>(array);
				num2 = 4;
				break;
			}
			case 0:
				return;
			}
		}
	}

	internal static void iA7yjVGyvZh5KcNKjgM()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object ppmDRXGmAGne1Z8hypi(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void bELNaSGt7UC0irUNoba(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object CY1EsbGbnRXtn1mCHxR(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static object M62JFHG5xPHWTZXUN03(object P_0)
	{
		return ((ComponentManager)P_0).ModuleManager;
	}

	internal static Guid MEMqpfGgUdDPrpNc5Jh()
	{
		return __AssemblyInfo.UID;
	}

	internal static object GQ9j0IGBvrc46Q64IUZ(object P_0, Guid P_1)
	{
		return ((IModuleManager)P_0).FindUnitByUid(P_1);
	}

	internal static void rQWJs0Gcd2EOsC6DNyk(object P_0, object P_1)
	{
		((IInternalWorkflowService)P_0).Run((IWorkflowInstance)P_1);
	}

	internal static object FBaRZwGPR1m4eB5mLWG(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object dpm8IrGXD4rukmrYQv7(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static Type TYyYJfGdOSwypTNyHD5(object P_0)
	{
		return ((IWorkflowRootActivityInfo)P_0).ActivityType;
	}

	internal static object QL23NHGu836Skoi6fd8(Type P_0)
	{
		return Locator.GetServiceNotNull(P_0);
	}

	internal static bool EUCEjVGDHB5G5VtyyNx(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void irTp7gGnIv2NONfxvrb(object P_0, Guid value)
	{
		((WorkflowRootActivity)P_0).StartActivityUid = value;
	}

	internal static object xIaV3RGHJfvSuwVBtF7(object P_0)
	{
		return ((IWorkflowInstance)P_0).State;
	}

	internal static void yWM9GfGLgWrZAuTBsgL(object P_0, object P_1)
	{
		((IWorkflowInstance)P_0).State = (IWorkflowInstanceState)P_1;
	}

	internal static Guid nMR9SmGfWFdH658eMlQ(object P_0)
	{
		return ((WorkflowInstance)P_0).Id;
	}

	internal static Guid obdy4DG9WVcD8oC1X37(object P_0)
	{
		return ((IWorkflowInstanceState)P_0).Uid;
	}

	internal static object efAGyFGWlfG03Bq8fer(object P_0)
	{
		return ((WorkflowRuntimeService)P_0).Session;
	}

	internal static int Ob5wZSGjnFVr5VWRIwj()
	{
		return LockTimeout;
	}

	internal static void mFOUHJGRmBUbxoYPUld(object P_0, object P_1, int P_2)
	{
		((ISession)P_0).LockWithWait(P_1, P_2);
	}

	internal static void EdeRCWG6cq3riFcBVLG(object P_0)
	{
		((IEntity)P_0).Refresh();
	}

	internal static void Iceo7HGqY3NE8lIfAcr(object P_0, object P_1)
	{
		((WorkflowApplication)P_0).InstanceStore = (InstanceStore)P_1;
	}

	internal static void sknV1VG3QRhu9dpyGbT(object P_0, object P_1)
	{
		((WorkflowInstanceExtensionManager)P_0).Add(P_1);
	}

	internal static object ap4lUTGT42sljWcBDbM(object P_0)
	{
		return ((WorkflowApplication)P_0).Extensions;
	}

	internal static object GfmbbaGQG0Lqu4oc0js(object P_0)
	{
		return ((WorkflowRuntimeService)P_0).UnitOfWorkManager;
	}

	internal static object YfyXuUGpbEFgP2wPbbb(object P_0)
	{
		return ((WorkflowRuntimeService)P_0).WorkflowTrackingItemManager;
	}

	internal static void RCO5P1GCZb2xGBwnCdy(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static object JhJVVnGMk2mE3Yaasg4(object P_0)
	{
		return ((IWorkflowInstanceState)P_0).State;
	}

	internal static bool VAN9WKGlmma3Xs6cphp()
	{
		return bbWRjbGJFWNwYNZKJPJ == null;
	}

	internal static WorkflowExecutingContext nO8E08G009aXQQrICNx()
	{
		return bbWRjbGJFWNwYNZKJPJ;
	}

	internal static void bElrpZGkqZugT9HW0pJ(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object AevqFNGUiepR948QBtR(object P_0)
	{
		return ActivityExecutionContextHelper.SetWorkflowInstance((IWorkflowInstance)P_0);
	}

	internal static void ttqUe4GVbm80UlSHMYU(object P_0, object P_1)
	{
		((WorkflowApplication)P_0).Terminate((string)P_1);
	}

	internal static void w6pJwtGA4LZ0G5JCB3N(object P_0)
	{
		((QueueSynchronizationContext)P_0).ExecuteQueue();
	}

	internal static object JS3CeYGGHiPTbbSmwDt()
	{
		return Logger.Log;
	}

	internal static object a2vkkQG7LO07C13GR0O(object P_0)
	{
		return ((WorkflowApplicationUnhandledExceptionEventArgs)P_0).ExceptionSource;
	}

	internal static object WHp8oXG2YSx0yhEq2Fx(object P_0)
	{
		return ((Activity)P_0).DisplayName;
	}

	internal static object L2GlFcGo5TDEVs2pVvT(object P_0)
	{
		return ((WorkflowApplicationUnhandledExceptionEventArgs)P_0).UnhandledException;
	}

	internal static object WKPcUEGFJvjsV564163()
	{
		return SecurityService;
	}

	internal static void dPckn8GiypEmbqKNxRn(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithElevatedPrivilegies((Action)P_1);
	}

	internal static object dDu9qaGI2Xc0BEQgdY0(object P_0)
	{
		return ((WorkflowApplicationCompletedEventArgs)P_0).TerminationException;
	}

	internal static void putuxgGa5ID7NbxsrNr(object P_0, object P_1)
	{
		((IWorkflowInstanceSchedulerJobExecutor)P_0).CloseActiveJobs((IWorkflowInstance)P_1);
	}

	internal static void RcuFb8GrZZudZZexXYl(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static bool KfyjQVGe1Vc5R9OdByG(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void OTCs4ZGNEYKIKKtxyFW(object P_0, WorkflowInstanceStatus value)
	{
		((IWorkflowInstance)P_0).Status = value;
	}

	internal static DateTime iuEskDGx6C80TAkFhet()
	{
		return DateTime.Now;
	}

	internal static object DvesEmGS4jN0ybl5KMg()
	{
		return WorkflowTaskBaseManager;
	}

	internal static object SJma8PG1vwuugJS3rfb()
	{
		return TaskBaseManager;
	}

	internal static Type rSqvLYGhRwX4vOvZAk9(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object Ak90QWGEpe1XvW1TuRv(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object BXUHTkGwiNhdPP65FOd(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
	{
		return MethodBase.GetMethodFromHandle(P_0, P_1);
	}

	internal static object qOuFB5G4mpht2VwiIJq(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object cQxq5OGzyDkD3Qb2mS5(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object xtRy7O7KeY4LurFymrY(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object Od1TV97OJoqtJ492i5I(object P_0, object P_1, object P_2)
	{
		return Expression.Call((Expression)P_0, (MethodInfo)P_1, (Expression[])P_2);
	}

	internal static object LRMhEq7Z9HC7LqnGnYd()
	{
		return WorkflowQueueItemManager;
	}

	internal static object b1TsNI7va5A3K8RU8NQ(object P_0, object P_1)
	{
		return ((WorkflowQueueItemManager)P_0).DeleteByWorkflowInstance((IWorkflowInstance)P_1);
	}

	internal static void Oa8HAK7YaciA1nKEN8B(object P_0, object P_1)
	{
		((IWorkflowInstanceTerminateAction)P_0).Execute((IWorkflowInstance)P_1);
	}

	internal static object G4lRGC78dAgdAGJbEbe(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static void gqclMg7sUouSoo1eTTS(object P_0)
	{
		((ISession)P_0).Flush();
	}

	internal static object nWJwIM7JApiSco9YwHf(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static object hSAvQZ7lNAYHdK4A0J2(object P_0)
	{
		return ((IWorkflowInstance)P_0).ParentInstance;
	}

	internal static WorkflowInstanceStatus givtpW70eSNBUF5RZHZ(object P_0)
	{
		return ((IWorkflowInstance)P_0).Status;
	}

	internal static object qIMoXn7yEonpPyP8Z5v()
	{
		return WorkflowInstanceManager;
	}

	internal static object F8J5847mMCMnxGtyeyw(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object CcusPr7tdyTYYxlYXIF(object P_0)
	{
		return ((IWorkflowInstance)P_0).ParentBookmark;
	}

	internal static Guid sNLGLA7baF76LXk8Kuf(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Uid;
	}

	internal static void H4oVqh75ZiqwdaQtMiE(object P_0, Guid bookmarkUid, object P_2)
	{
		((IWorkflowExecutingContext)P_0).ResumeBookmark(bookmarkUid, P_2);
	}

	internal static bool eSL9hC7gEr6d7XwKBQq(object P_0)
	{
		return ((SubProcessElement)P_0).TerminateChildProcesses;
	}

	internal static void pLX0ka7BDpOHf8iUhKV(object P_0)
	{
		P_0();
	}

	internal static int aksqrw7cPpS9fijpSUk(object P_0)
	{
		return ((Queue<Action>)P_0).Count;
	}

	internal static void CZxAvI7P6vvp9FYhwIt(object P_0)
	{
		((WorkflowApplication)P_0).Unload();
	}

	internal static object cfUghg7XD80y1vy9jxS(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object JSI5t37dDrET5pRagq0()
	{
		return WorkflowTaskBaseManager.Instance;
	}

	internal static object B2JAsp7uaYbPaPFQW9C(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object LQyAQG7Di95P3cXOVZA(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static void SeGgC67nuvOPMd0siuM(object P_0)
	{
		((WorkflowApplication)P_0).Run();
	}

	internal static bool T6jMi87HVHQnlwZM2iL(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static Guid om04LW7LWTfdHL2mGXb(object P_0)
	{
		return ((Element)P_0).Uid;
	}
}
