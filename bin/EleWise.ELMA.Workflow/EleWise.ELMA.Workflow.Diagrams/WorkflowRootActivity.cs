using System;
using System.Activities;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Services;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Events;
using EleWise.ELMA.Workflow.Diagrams.Activities.Gateways;
using EleWise.ELMA.Workflow.Diagrams.Activities.Helpers;
using EleWise.ELMA.Workflow.Diagrams.Elements;
using EleWise.ELMA.Workflow.Diagrams.Elements.Gateways;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Diagrams.Activities;

[Service(EnableInterceptors = false, Scope = ServiceScope.Transient)]
public abstract class WorkflowRootActivity : NativeActivity
{
	private readonly Variable<List<GatewayExecutingInfo>> executingGateways;

	private static WorkflowRootActivity apaTloEM8sFNIDb9eKE;

	public IWorkflowRuntimeService WorkflowRuntimeService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowRuntimeService_003Ek__BackingField;
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
					_003CWorkflowRuntimeService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
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
				case 1:
					_003CWorkflowQueueService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
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

	public WorkflowInstanceManager WorkflowInstanceManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowInstanceManager_003Ek__BackingField;
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
					_003CWorkflowInstanceManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<WorkflowActivity> Activities { get; private set; }

	public Guid StartActivityUid
	{
		[CompilerGenerated]
		get
		{
			return _003CStartActivityUid_003Ek__BackingField;
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
					_003CStartActivityUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowDiagram Diagram
	{
		[CompilerGenerated]
		get
		{
			return _003CDiagram_003Ek__BackingField;
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
					_003CDiagram_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
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

	public ISessionProvider SessionProvider
	{
		[CompilerGenerated]
		protected get
		{
			return _003CSessionProvider_003Ek__BackingField;
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
					_003CSessionProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
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

	public IEnumerable<IWorkflowActivityInfo> WorkflowActivityInfos { get; set; }

	protected ISession Session => (ISession)SfYoNrwQXgk1nicfK6u(SessionProvider, string.Empty);

	protected override bool CanInduceIdle => true;

	protected WorkflowRootActivity()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		vXLY70EVlXjgy7iAFn8();
		executingGateways = new Variable<List<GatewayExecutingInfo>>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Activities = new List<WorkflowActivity>();
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
			{
				num = 0;
			}
		}
	}

	public virtual void LoadFromDiagram(WorkflowDiagram diagram)
	{
		//Discarded unreachable code: IL_006d, IL_0111, IL_0120, IL_01dc, IL_034b, IL_0390, IL_03c8, IL_044d, IL_045c
		int num = 4;
		int num2 = num;
		IEnumerator<Element> enumerator = default(IEnumerator<Element>);
		FlowElement flowElement = default(FlowElement);
		IWorkflowActivityInfo workflowActivityInfo = default(IWorkflowActivityInfo);
		WorkflowActivity workflowActivity = default(WorkflowActivity);
		_003C_003Ec__DisplayClass38_0 _003C_003Ec__DisplayClass38_ = default(_003C_003Ec__DisplayClass38_0);
		Element current = default(Element);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = ((ElementList)CV0GLoE2WNfriYI6FkW(diagram)).GetEnumerator();
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				try
				{
					while (true)
					{
						IL_0209:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 7;
							goto IL_007f;
						}
						goto IL_01e6;
						IL_007f:
						while (true)
						{
							int num4;
							switch (num3)
							{
							case 11:
								if (IsStartElement(flowElement))
								{
									num3 = 6;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
									{
										num3 = 10;
									}
									continue;
								}
								goto case 5;
							case 17:
								if (workflowActivityInfo == null)
								{
									num4 = 18;
									goto IL_007b;
								}
								workflowActivity = (WorkflowActivity)BEibIpEislG6G9BGMpW(workflowActivityInfo.ActivityType);
								num3 = 11;
								continue;
							case 13:
								_003C_003Ec__DisplayClass38_.type = _003C_003Ec__DisplayClass38_.type.BaseType;
								num3 = 12;
								continue;
							default:
								_003C_003Ec__DisplayClass38_.type = flowElement.GetType();
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
								{
									num3 = 1;
								}
								continue;
							case 16:
								Activities.Add(workflowActivity);
								num3 = 8;
								continue;
							case 6:
							case 20:
								workflowActivityInfo = WorkflowActivityInfos.FirstOrDefault(_003C_003Ec__DisplayClass38_._003CLoadFromDiagram_003Eb__0);
								num3 = 13;
								continue;
							case 10:
								StartActivityUid = current.Uid;
								num3 = 5;
								continue;
							case 9:
								break;
							case 4:
							case 8:
								goto IL_0209;
							case 18:
								throw new Exception((string)OdNaNBEFwsyCViadTy0(seNyLMEGJW3haxHiKB5(0x595C500A ^ 0x595D0ED6), new object[1] { flowElement.GetType() }));
							case 21:
								_003C_003Ec__DisplayClass38_ = new _003C_003Ec__DisplayClass38_0();
								num3 = 15;
								continue;
							case 15:
								workflowActivityInfo = null;
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
								{
									num3 = 0;
								}
								continue;
							case 1:
							case 12:
								if (workflowActivityInfo == null)
								{
									num3 = 14;
									continue;
								}
								goto case 17;
							case 14:
								if (D0xM6AEomA53YV7WDwA(_003C_003Ec__DisplayClass38_.type, null))
								{
									num3 = 20;
									continue;
								}
								goto case 17;
							case 2:
								flowElement = current as FlowElement;
								num3 = 11;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
								{
									num3 = 19;
								}
								continue;
							case 5:
								fPIBhLEa1Gj4QrRkPPF(workflowActivity, HX3lwREI04omeKUCcCd(current));
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
								{
									num3 = 3;
								}
								continue;
							case 22:
								UI0ZYTEeDqEZEqPBJ5l(workflowActivity, diagram);
								num3 = 5;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
								{
									num3 = 16;
								}
								continue;
							case 3:
								xSET3dEr524AZwNNFTP(workflowActivity, current);
								num4 = 22;
								goto IL_007b;
							case 19:
								if (flowElement == null)
								{
									num4 = 4;
									goto IL_007b;
								}
								goto case 21;
							case 7:
								return;
								IL_007b:
								num3 = num4;
								continue;
							}
							break;
						}
						goto IL_01e6;
						IL_01e6:
						current = enumerator.Current;
						num3 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
						{
							num3 = 1;
						}
						goto IL_007f;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								NjRAbCENK7CFaOwGV4H(enumerator);
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
								{
									num5 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 3:
				RAB4lwEA5U2DsFvVWoY(diagram);
				num2 = 6;
				break;
			case 4:
				if (!diagram.DiagramLoaded)
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 6;
			default:
				a940CJE7V3QcU2xovZd(this, seNyLMEGJW3haxHiKB5(-1716458555 ^ -1716407019));
				num2 = 7;
				break;
			case 6:
				Diagram = diagram;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 7:
				if (CV0GLoE2WNfriYI6FkW(diagram) == null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 1;
			case 8:
				return;
			}
		}
	}

	protected virtual void ProcessActivityCompleted(NativeActivityContext context, WorkflowActivity workflowActivity, ActivityExecuteResult result)
	{
		//Discarded unreachable code: IL_0119, IL_014d, IL_015c, IL_0211, IL_0313, IL_03ea, IL_03f9, IL_040a, IL_0549, IL_0558, IL_0595, IL_05ed, IL_060d, IL_06d0, IL_06df, IL_06f0, IL_0809, IL_0818, IL_0861, IL_08ea, IL_08f9, IL_0909, IL_0972, IL_0981, IL_09bc, IL_09e5, IL_0a5f, IL_0a72, IL_0ac9, IL_0ad8, IL_0b57, IL_0bd3, IL_0c09, IL_0c70, IL_0d42, IL_0d90, IL_0d9e, IL_0f3f, IL_0f88, IL_0f9b, IL_0fae
		int num = 17;
		List<GatewayExecutingInfo> list2 = default(List<GatewayExecutingInfo>);
		IGatewayActivity gatewayActivity = default(IGatewayActivity);
		HashSet<Element> hashSet = default(HashSet<Element>);
		int num3 = default(int);
		Guid[] nextElementUids = default(Guid[]);
		IWorkflowExecutingContext extension = default(IWorkflowExecutingContext);
		bool flag = default(bool);
		_003C_003Ec__DisplayClass39_3 _003C_003Ec__DisplayClass39_2 = default(_003C_003Ec__DisplayClass39_3);
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = default(_003C_003Ec__DisplayClass39_0);
		List<Tuple<Element, WorkflowActivity>> list = default(List<Tuple<Element, WorkflowActivity>>);
		WorkflowActivity workflowActivity2 = default(WorkflowActivity);
		List<Tuple<Element, WorkflowActivity>>.Enumerator enumerator2 = default(List<Tuple<Element, WorkflowActivity>>.Enumerator);
		HashSet<WorkflowActivity> hashSet2 = default(HashSet<WorkflowActivity>);
		WorkflowActivity item = default(WorkflowActivity);
		_003C_003Ec__DisplayClass39_2 _003C_003Ec__DisplayClass39_4 = default(_003C_003Ec__DisplayClass39_2);
		GatewayExecutingInfo gatewayExecutingInfo2 = default(GatewayExecutingInfo);
		bool flag2 = default(bool);
		List<GatewayExecutingInfo> list3 = default(List<GatewayExecutingInfo>);
		IGatewayActivity gatewayActivity2 = default(IGatewayActivity);
		Guid uid = default(Guid);
		HashSet<WorkflowActivity>.Enumerator enumerator = default(HashSet<WorkflowActivity>.Enumerator);
		WorkflowActivity current = default(WorkflowActivity);
		IWorkflowQueueItem workflowQueueItem = default(IWorkflowQueueItem);
		DateTime dateTime = default(DateTime);
		IWorkflowInstance instance = default(IWorkflowInstance);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				switch (num2)
				{
				case 41:
					list2 = new List<GatewayExecutingInfo>();
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
					{
						num2 = 28;
					}
					continue;
				case 39:
					if (gatewayActivity == null)
					{
						num2 = 25;
						continue;
					}
					goto case 58;
				case 60:
					hashSet = new HashSet<Element>();
					num2 = 47;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num2 = 38;
					}
					continue;
				case 31:
					num3++;
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
					{
						num2 = 0;
					}
					continue;
				case 18:
					nextElementUids = result.NextElementUids;
					num2 = 43;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
					{
						num2 = 21;
					}
					continue;
				case 38:
					extension = context.GetExtension<IWorkflowExecutingContext>();
					num2 = 5;
					continue;
				case 6:
				case 57:
					if (num3 >= nextElementUids.Length)
					{
						num2 = 4;
						continue;
					}
					goto case 14;
				case 58:
					num4 = ((PO9sE4EE512TKxfQ5BK(gatewayActivity) == GatewayStartType.Start) ? 1 : 0);
					goto IL_1005;
				case 35:
					if (flag)
					{
						num2 = 27;
						continue;
					}
					goto case 21;
				case 49:
					if (flag)
					{
						num2 = 13;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 38;
				case 11:
					_003C_003Ec__DisplayClass39_2.endGatewayElement = Diagram.Elements[YgP5GswmFnbO0WvrgCF(gatewayActivity)];
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 9;
					}
					continue;
				case 61:
					executingGateways.Set(context, list2);
					num2 = 36;
					continue;
				case 15:
					MW1qHvwZmmFDjp09ybJ(_003C_003Ec__DisplayClass39_.gatewayInfo, x2bmZ4wO06c9U6GCt7I(list));
					num2 = 38;
					continue;
				case 8:
					CawGklESxpoqaBvnlit(Diagram, seNyLMEGJW3haxHiKB5(0x6871CA ^ 0x68C030));
					num2 = 43;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
					{
						num2 = 52;
					}
					continue;
				case 13:
					workflowActivity2 = Activities.FirstOrDefault(_003C_003Ec__DisplayClass39_2._003CProcessActivityCompleted_003Eb__6);
					num2 = 46;
					continue;
				case 29:
					_003C_003Ec__DisplayClass39_2 = new _003C_003Ec__DisplayClass39_3();
					num2 = 11;
					continue;
				case 37:
					list2 = executingGateways.Get(context);
					num = 2;
					break;
				case 26:
					if (PO9sE4EE512TKxfQ5BK(gatewayActivity) == GatewayStartType.Start)
					{
						num2 = 33;
						continue;
					}
					goto case 50;
				case 16:
					_003C_003Ec__DisplayClass39_._003C_003E4__this = this;
					num2 = 48;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
					{
						num2 = 48;
					}
					continue;
				case 45:
				case 56:
					list2.RemoveAll(_003C_003Ec__DisplayClass39_._003CProcessActivityCompleted_003Eb__5);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
					{
						num2 = 1;
					}
					continue;
				case 30:
					if (flag)
					{
						num2 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 42;
				case 5:
					enumerator2 = list.GetEnumerator();
					num2 = 55;
					continue;
				case 55:
					try
					{
						while (true)
						{
							int num7;
							if (!enumerator2.MoveNext())
							{
								num7 = 41;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
								{
									num7 = 36;
								}
								goto IL_0418;
							}
							goto IL_0917;
							IL_0525:
							int num8 = 21;
							goto IL_0414;
							IL_06f5:
							hashSet2.AddIfNotContains(item);
							num8 = 29;
							goto IL_0414;
							IL_0917:
							item = enumerator2.Current.Item2;
							num8 = 33;
							goto IL_0414;
							IL_0414:
							num7 = num8;
							goto IL_0418;
							IL_0418:
							while (true)
							{
								object obj;
								switch (num7)
								{
								case 23:
									if (_003C_003Ec__DisplayClass39_4.endGateway != null)
									{
										num7 = 40;
										continue;
									}
									goto case 8;
								case 10:
								case 19:
								case 29:
									break;
								case 5:
									if (gatewayExecutingInfo2 == null)
									{
										goto IL_0525;
									}
									goto case 6;
								case 33:
									if (item == null)
									{
										num7 = 10;
										continue;
									}
									goto case 15;
								case 46:
								{
									GatewayExecutingInfo gatewayExecutingInfo3 = gatewayExecutingInfo2;
									num3 = (gatewayExecutingInfo3.FinishedGatesCount = NxwyZcwleqHHc5cf7PT(gatewayExecutingInfo3) + 1);
									num7 = 42;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
									{
										num7 = 32;
									}
									continue;
								}
								case 8:
								case 21:
								case 25:
									if (!flag2)
									{
										num7 = 19;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
										{
											num7 = 0;
										}
										continue;
									}
									goto IL_06f5;
								case 43:
									list3 = executingGateways.Get(context);
									num7 = 20;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
									{
										num7 = 20;
									}
									continue;
								case 37:
									if (gatewayExecutingInfo2 == null)
									{
										num7 = 32;
										continue;
									}
									goto case 46;
								case 13:
									list3.Remove(gatewayExecutingInfo2);
									num7 = 27;
									continue;
								case 16:
									flag2 = true;
									num7 = 23;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
									{
										num7 = 22;
									}
									continue;
								case 36:
									Wn73Evws1KEoHPfMFhw(WorkflowInstanceManager, extension.Instance, fhmT39w8ly2vam4aWMn(seNyLMEGJW3haxHiKB5(-1574607501 ^ -1574684137)));
									num7 = 18;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
									{
										num7 = 18;
									}
									continue;
								case 34:
									if (_003C_003Ec__DisplayClass39_4.endGateway.PairGatewayUid == _003C_003Ec__DisplayClass39_.gatewayInfo.StartGatewayUid)
									{
										num7 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
										{
											num7 = 26;
										}
										continue;
									}
									goto case 2;
								case 2:
									obj = null;
									goto IL_0a17;
								case 3:
									goto IL_06f5;
								case 27:
									executingGateways.Set(context, list3);
									num7 = 8;
									continue;
								case 38:
									goto IL_0724;
								case 28:
									if (mkXehSwJoFdJiJAAQh1(gatewayActivity2) == GatewayType.Xor)
									{
										num7 = 7;
										continue;
									}
									goto case 9;
								case 42:
									flag2 = NxwyZcwleqHHc5cf7PT(gatewayExecutingInfo2) >= iGTH3Ow05wypbXhdHHk(gatewayExecutingInfo2);
									num7 = 22;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
									{
										num7 = 7;
									}
									continue;
								case 35:
									if (gatewayActivity2 != null)
									{
										goto case 28;
									}
									goto IL_0794;
								case 15:
									_003C_003Ec__DisplayClass39_4 = new _003C_003Ec__DisplayClass39_2();
									num7 = 31;
									continue;
								case 31:
									_003C_003Ec__DisplayClass39_4.endGateway = item as IGatewayActivity;
									num7 = 16;
									continue;
								case 9:
									flag2 = false;
									num7 = 37;
									continue;
								case 40:
									if (PO9sE4EE512TKxfQ5BK(_003C_003Ec__DisplayClass39_4.endGateway) == GatewayStartType.End)
									{
										num7 = 0;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
										{
											num7 = 1;
										}
										continue;
									}
									goto case 8;
								default:
									if (list3.Contains(gatewayExecutingInfo2))
									{
										num7 = 13;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
										{
											num7 = 13;
										}
										continue;
									}
									goto case 8;
								case 11:
									if (list3 != null)
									{
										num7 = 12;
										continue;
									}
									goto case 30;
								case 20:
									if (_003C_003Ec__DisplayClass39_.gatewayInfo != null)
									{
										num7 = 34;
										continue;
									}
									goto case 2;
								case 14:
								case 44:
									throw new InvalidOperationException((string)fhmT39w8ly2vam4aWMn(seNyLMEGJW3haxHiKB5(-29981480 ^ -29893842)));
								case 12:
								case 24:
									if (gatewayExecutingInfo2 == null)
									{
										num7 = 30;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
										{
											num7 = 38;
										}
										continue;
									}
									goto case 35;
								case 30:
									if (gatewayExecutingInfo2 != null)
									{
										num7 = 24;
										continue;
									}
									goto case 39;
								case 7:
								case 22:
								case 32:
								case 47:
									if (flag2)
									{
										num7 = 5;
										continue;
									}
									goto case 8;
								case 18:
									return;
								case 4:
									goto IL_0917;
								case 1:
									gatewayActivity2 = Activities.FirstOrDefault(_003C_003Ec__DisplayClass39_4._003CProcessActivityCompleted_003Eb__3) as IGatewayActivity;
									num7 = 43;
									continue;
								case 6:
									if (list3 == null)
									{
										num7 = 25;
										continue;
									}
									goto default;
								case 45:
									if (kh6WdowYk2u8kFVbbVl(sY2MqVwv36LvPKpavDs(extension)))
									{
										num7 = 29;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
										{
											num7 = 36;
										}
										continue;
									}
									goto case 14;
								case 17:
									if (extension.Instance == null)
									{
										num7 = 44;
										continue;
									}
									goto case 45;
								case 39:
									if (extension != null)
									{
										num7 = 17;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
										{
											num7 = 11;
										}
										continue;
									}
									goto case 14;
								case 26:
									obj = _003C_003Ec__DisplayClass39_.gatewayInfo;
									goto IL_0a17;
								case 41:
									goto end_IL_04f8;
									IL_0a17:
									gatewayExecutingInfo2 = (GatewayExecutingInfo)obj;
									num7 = 11;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
									{
										num7 = 8;
									}
									continue;
								}
								break;
							}
							continue;
							IL_0794:
							num8 = 47;
							goto IL_0414;
							IL_0724:
							gatewayExecutingInfo2 = list3.LastOrDefault(_003C_003Ec__DisplayClass39_4._003CProcessActivityCompleted_003Eb__4);
							num8 = 35;
							goto IL_0414;
							continue;
							end_IL_04f8:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator2).Dispose();
						int num10 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
						{
							num10 = 0;
						}
						switch (num10)
						{
						case 0:
							break;
						}
					}
					goto case 35;
				case 48:
					Contract.ArgumentNotNull(context, (string)seNyLMEGJW3haxHiKB5(--727842433 ^ 0x2B61C1B1));
					num2 = 3;
					continue;
				case 27:
					if (ovcNqkwyhvDxwK5oY2y(hashSet2) > 0)
					{
						num2 = 37;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 29;
				case 9:
					if (_003C_003Ec__DisplayClass39_2.endGatewayElement == null)
					{
						num = 21;
						break;
					}
					goto case 13;
				case 53:
					return;
				case 46:
					if (workflowActivity2 == null)
					{
						num2 = 40;
						continue;
					}
					goto case 59;
				case 47:
					if (result.NextElementUids == null)
					{
						num2 = 51;
						continue;
					}
					goto case 10;
				case 17:
					_003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
					num2 = 16;
					continue;
				case 43:
					num3 = 0;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
					{
						num2 = 57;
					}
					continue;
				default:
					if (gatewayActivity == null)
					{
						num2 = 54;
						continue;
					}
					goto case 26;
				case 14:
					uid = nextElementUids[num3];
					num2 = 24;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num2 = 24;
					}
					continue;
				case 59:
					hashSet2.Add(workflowActivity2);
					num2 = 22;
					continue;
				case 21:
				case 22:
				case 36:
				case 40:
					enumerator = hashSet2.GetEnumerator();
					num2 = 30;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
					{
						num2 = 44;
					}
					continue;
				case 12:
				{
					_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_3 = _003C_003Ec__DisplayClass39_;
					GatewayExecutingInfo gatewayExecutingInfo = new GatewayExecutingInfo();
					nFZeQJwKpBp7LZLqgn5(gatewayExecutingInfo, f1rgCZE1M25IV1jxcVd(W8yWVcE4W4fiESei9FY(workflowActivity)));
					_003C_003Ec__DisplayClass39_3.gatewayInfo = gatewayExecutingInfo;
					num2 = 42;
					continue;
				}
				case 42:
					hashSet2 = new HashSet<WorkflowActivity>();
					num2 = 19;
					continue;
				case 4:
				case 51:
					gatewayActivity = workflowActivity as IGatewayActivity;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
					{
						num2 = 0;
					}
					continue;
				case 32:
					if (((Element)W8yWVcE4W4fiESei9FY(workflowActivity)).OutputConnectors[0].EndElement != null)
					{
						num2 = 23;
						continue;
					}
					goto case 20;
				case 24:
					hashSet.AddIfNotContains(((ElementList)CV0GLoE2WNfriYI6FkW(Diagram))[uid]);
					num2 = 31;
					continue;
				case 20:
				case 33:
				case 34:
					_003C_003Ec__DisplayClass39_.gatewayInfo = null;
					num2 = 39;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
					{
						num2 = 31;
					}
					continue;
				case 3:
					GHWF2sExlI1uLCSDbDO(workflowActivity, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614274E3 ^ 0x61432BA3));
					num2 = 8;
					continue;
				case 2:
					if (list2 != null)
					{
						num2 = 45;
						continue;
					}
					goto case 41;
				case 10:
					if (result.NextElementUids.Length != 0)
					{
						num2 = 18;
						continue;
					}
					goto case 4;
				case 52:
					zKNXUwEhoWuwJU7FuBx(GetTrackingService(context), f1rgCZE1M25IV1jxcVd(workflowActivity.Element));
					num2 = 60;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
					{
						num2 = 9;
					}
					continue;
				case 50:
				case 54:
					if (hashSet.Count != 0)
					{
						num2 = 34;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 7;
				case 1:
				case 28:
					list2.Add(_003C_003Ec__DisplayClass39_.gatewayInfo);
					num2 = 61;
					continue;
				case 44:
					try
					{
						while (true)
						{
							int num5;
							if (!enumerator.MoveNext())
							{
								num5 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
								{
									num5 = 0;
								}
								goto IL_0da2;
							}
							goto IL_0ee4;
							IL_0ee4:
							current = enumerator.Current;
							num5 = 6;
							goto IL_0da2;
							IL_0da2:
							while (true)
							{
								switch (num5)
								{
								default:
									return;
								case 0:
									return;
								case 9:
									WsyWCGwcPYTnMUIIjGk(context, workflowQueueItem.Uid.ToString(), new BookmarkCallback(OnBookmarkResumed));
									num5 = 1;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
									{
										num5 = 0;
									}
									continue;
								case 1:
								case 10:
									break;
								case 7:
									iYBRCVwgEGpXPkKZrEM(X6w2N1wbJKDnwSvwoyw(), Ee5sVEw558khAeYNIYI(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6C1B10), (int)(DateTime.Now - dateTime).TotalMilliseconds, seNyLMEGJW3haxHiKB5(-642713667 ^ -642657069)), Array.Empty<object>());
									num5 = 3;
									continue;
								case 4:
									dateTime = cpr8vqwtbKPWNrynbNg();
									num5 = 2;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
									{
										num5 = 0;
									}
									continue;
								case 2:
									Session.Flush();
									num5 = 7;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
									{
										num5 = 4;
									}
									continue;
								case 11:
									goto IL_0ee4;
								case 6:
									if (WorkflowQueueService == null)
									{
										num5 = 4;
										continue;
									}
									goto case 5;
								case 8:
									workflowQueueItem = QueueActivity(instance, (Element)W8yWVcE4W4fiESei9FY(current));
									num5 = 9;
									continue;
								case 5:
									instance = GetInstance(context);
									num5 = 8;
									continue;
								case 3:
									LppB5twBGqhyWJrH1YD(this, context, current);
									num5 = 10;
									continue;
								}
								break;
							}
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
				case 23:
					hashSet.Add((Element)bTbgqiEza9ereqShJU6(((Element)W8yWVcE4W4fiESei9FY(workflowActivity)).OutputConnectors[0]));
					num2 = 20;
					continue;
				case 7:
					if (uYsKmFEwg7uGV40fBr9(workflowActivity.Element.OutputConnectors) > 0)
					{
						num = 32;
						break;
					}
					goto case 20;
				case 25:
					num4 = 0;
					goto IL_1005;
				case 19:
					{
						list = (from t in hashSet.Select(_003C_003Ec__DisplayClass39_._003CProcessActivityCompleted_003Eb__0)
							where t.Item2 != null
							select t).ToList();
						num2 = 49;
						continue;
					}
					IL_1005:
					flag = (byte)num4 != 0;
					num = 30;
					break;
				}
				break;
			}
		}
	}

	protected virtual void ScheduleActivity(NativeActivityContext context, WorkflowActivity activity)
	{
		//Discarded unreachable code: IL_0066
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 4:
				return;
			default:
				context.ScheduleActivity(activity, ActivityCompleted);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				vb5vLqwXeOq2a4cno2D(GetTrackingService(context), f1rgCZE1M25IV1jxcVd(W8yWVcE4W4fiESei9FY(activity)), false);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (miNk8ywPnaj9PcaND2i(context.GetExtension<IWorkflowExecutingContext>() ?? throw new ServiceNotFoundException((string)seNyLMEGJW3haxHiKB5(0x34EA50D4 ^ 0x34EB0EE6))))
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void Execute(NativeActivityContext context)
	{
		int num = 4;
		int num2 = num;
		WorkflowActivity workflowActivity = default(WorkflowActivity);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				CawGklESxpoqaBvnlit(Diagram, seNyLMEGJW3haxHiKB5(-720457373 ^ -720502631));
				num2 = 3;
				break;
			case 3:
				workflowActivity = Activities.FirstOrDefault(delegate(WorkflowActivity a)
				{
					//Discarded unreachable code: IL_006b, IL_007a
					int num3 = 2;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 2:
							if (W8yWVcE4W4fiESei9FY(a) == null)
							{
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb != 0)
								{
									num4 = 1;
								}
								break;
							}
							goto default;
						default:
							return abAQR6wpWf7DZrV0VCo(((Element)W8yWVcE4W4fiESei9FY(a)).Uid, StartActivityUid);
						case 1:
							return false;
						}
					}
				});
				num2 = 2;
				break;
			case 0:
				return;
			case 2:
				if (workflowActivity == null)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				LppB5twBGqhyWJrH1YD(this, context, workflowActivity);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
				{
					num2 = 0;
				}
				break;
			}
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
			case 2:
				return;
			default:
				metadata.AddImplementationVariable(executingGateways);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				Dhb351wd8HxFsAfQPWR(this, metadata);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected IWorkflowTrackingService GetTrackingService(NativeActivityContext context)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				p8QfP5wulRN5NodDJvw(WorkflowRuntimeService, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542173344));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return context.GetExtension<IWorkflowTrackingService>() ?? throw new ServiceNotFoundException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D51441));
			}
		}
	}

	protected IWorkflowInstance GetInstance(NativeActivityContext context)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				p8QfP5wulRN5NodDJvw(WorkflowRuntimeService, seNyLMEGJW3haxHiKB5(-763667953 ^ -763683211));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (IWorkflowInstance)sY2MqVwv36LvPKpavDs(context.GetExtension<IWorkflowExecutingContext>() ?? throw new ServiceNotFoundException((string)seNyLMEGJW3haxHiKB5(0xA7339EE ^ 0xA7267DC)));
			}
		}
	}

	protected void ActivityCompleted(NativeActivityContext context, ActivityInstance activityInstance, ActivityExecuteResult result)
	{
		int num = 1;
		WorkflowActivity workflowActivity = default(WorkflowActivity);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					GHWF2sExlI1uLCSDbDO(activityInstance, seNyLMEGJW3haxHiKB5(-768800937 ^ -768841825));
					num2 = 5;
					continue;
				case 3:
					CawGklESxpoqaBvnlit(Diagram, seNyLMEGJW3haxHiKB5(0x37E97159 ^ 0x37E9C0A3));
					num2 = 6;
					continue;
				case 2:
					wK0dEswnMqOEQW51Bgm(T1U5RYwDk0ppMuJJgny(activityInstance) is WorkflowActivity, seNyLMEGJW3haxHiKB5(0x56F860D7 ^ 0x56F901F5));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					Contract.ArgumentNotNull(context, (string)seNyLMEGJW3haxHiKB5(-197778752 ^ -197779984));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					workflowActivity = (WorkflowActivity)T1U5RYwDk0ppMuJJgny(activityInstance);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					break;
				case 4:
					return;
				case 5:
					GHWF2sExlI1uLCSDbDO(activityInstance.Activity, seNyLMEGJW3haxHiKB5(0x2F44D93A ^ 0x2F45B9D6));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
			ProcessActivityCompleted(context, workflowActivity, result);
			num = 4;
		}
	}

	protected IWorkflowQueueItem QueueActivity(IWorkflowInstance instance, Element element)
	{
		//Discarded unreachable code: IL_0059, IL_008a, IL_00ca, IL_00d9
		int num = 4;
		int num2 = num;
		IWorkflowQueueItem workflowQueueItem = default(IWorkflowQueueItem);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!SR.GetSetting((string)seNyLMEGJW3haxHiKB5(0x2F44D93A ^ 0x2F44ABBE), defaultValue: true))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 5:
			case 6:
				bq3bU3wLIpUQPeS950E(WorkflowQueueService, workflowQueueItem);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (fuKRSYwHfM3NcLDrXL5())
				{
					num2 = 5;
					break;
				}
				goto case 2;
			case 4:
				workflowQueueItem = WorkflowQueueItemManager.CreateQueueItem(instance, element);
				num2 = 3;
				break;
			default:
				return workflowQueueItem;
			}
		}
	}

	protected abstract bool IsStartElement(FlowElement element);

	protected void OnBookmarkResumed(NativeActivityContext context, Bookmark bookmark, object state)
	{
		//Discarded unreachable code: IL_0358, IL_0415, IL_043c, IL_0475, IL_0491, IL_04a0, IL_04ea, IL_04f9, IL_0567, IL_0571, IL_0580, IL_05fb
		int num = 49;
		BPMNFlowElement bPMNFlowElement = default(BPMNFlowElement);
		bool flag = default(bool);
		EventTrigger trigger = default(EventTrigger);
		FlowConnectorElement flowConnectorElement = default(FlowConnectorElement);
		WorkflowActivity workflowActivity = default(WorkflowActivity);
		IActivityWithExceptionFlowsImpl activityWithExceptionFlowsImpl = default(IActivityWithExceptionFlowsImpl);
		Guid? skipConnectorUid = default(Guid?);
		_003C_003Ec__DisplayClass48_0 _003C_003Ec__DisplayClass48_ = default(_003C_003Ec__DisplayClass48_0);
		ActivityExecuteResult result = default(ActivityExecuteResult);
		bool? skipExecution = default(bool?);
		IWorkflowInstance instance = default(IWorkflowInstance);
		IWorkflowTrackingService trackingService = default(IWorkflowTrackingService);
		string errorText = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				object obj;
				switch (num2)
				{
				case 3:
					if (bPMNFlowElement == null)
					{
						num2 = 19;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 4;
				case 20:
					flag = false;
					num2 = 15;
					continue;
				case 9:
					trigger = flowConnectorElement.Trigger;
					num2 = 16;
					continue;
				case 6:
					flowConnectorElement = bPMNFlowElement.StandardOutputFlows.FirstOrDefault();
					num2 = 25;
					continue;
				case 52:
					throw new ArgumentException((string)seNyLMEGJW3haxHiKB5(-1516552726 ^ -1516610460));
				case 43:
					bPMNFlowElement = workflowActivity.Element as BPMNFlowElement;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					activityWithExceptionFlowsImpl = workflowActivity as IActivityWithExceptionFlowsImpl;
					num2 = 14;
					continue;
				case 12:
					if (flowConnectorElement == null)
					{
						num2 = 11;
						continue;
					}
					goto case 35;
				case 46:
					if (!skipConnectorUid.HasValue)
					{
						num2 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
						{
							num2 = 21;
						}
						continue;
					}
					obj2 = bPMNFlowElement.OutputFlows.FirstOrDefault(_003C_003Ec__DisplayClass48_._003COnBookmarkResumed_003Eb__1) as FlowConnectorElement;
					goto IL_065f;
				case 39:
					if (flowConnectorElement == null)
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 25;
				case 10:
					if (_003C_003Ec__DisplayClass48_.item != null)
					{
						workflowActivity = Activities.FirstOrDefault(_003C_003Ec__DisplayClass48_._003COnBookmarkResumed_003Eb__0);
						num2 = 20;
					}
					else
					{
						num2 = 52;
					}
					continue;
				case 16:
					if (trigger != EventTrigger.Timer)
					{
						num2 = 34;
						continue;
					}
					goto case 40;
				case 33:
					result = default(ActivityExecuteResult);
					num2 = 43;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a50dda04dedf4515816f963c67783c8f != 0)
					{
						num2 = 25;
					}
					continue;
				case 44:
					if (skipExecution.HasValue)
					{
						num2 = 5;
						continue;
					}
					goto case 11;
				case 7:
					_003C_003Ec__DisplayClass48_.item = state as IWorkflowQueueItem;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num2 = 10;
					}
					continue;
				case 38:
					LppB5twBGqhyWJrH1YD(this, context, workflowActivity);
					num2 = 23;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
					{
						num2 = 27;
					}
					continue;
				case 29:
					if (!skipExecution.Value)
					{
						num2 = 26;
						continue;
					}
					goto case 33;
				case 30:
					c9ZCx3w66e3or0EYuu8(context, activityWithExceptionFlowsImpl, instance, flowConnectorElement);
					num2 = 37;
					continue;
				case 11:
				case 19:
				case 24:
				case 26:
					if (flag)
					{
						num2 = 42;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 38;
				case 1:
				case 47:
					FaqtUSwTXFcefnmSSya(this, context, workflowActivity, result);
					num2 = 41;
					continue;
				case 17:
				case 28:
				case 31:
				case 37:
					vb5vLqwXeOq2a4cno2D(trackingService, f1rgCZE1M25IV1jxcVd(bPMNFlowElement), true);
					num2 = 8;
					continue;
				case 49:
					_003C_003Ec__DisplayClass48_ = new _003C_003Ec__DisplayClass48_0();
					num2 = 48;
					continue;
				case 27:
					return;
				case 42:
					return;
				case 51:
					ActivityExceptionFlowHelper.SendMessagesOnException(context, activityWithExceptionFlowsImpl, instance, flowConnectorElement, errorText);
					num2 = 31;
					continue;
				case 23:
					skipExecution = _003C_003Ec__DisplayClass48_.item.SkipExecution;
					num2 = 31;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 44;
					}
					continue;
				case 14:
					instance = GetInstance(context);
					num2 = 36;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num2 = 36;
					}
					continue;
				case 48:
					Contract.ArgumentNotNull(state, (string)seNyLMEGJW3haxHiKB5(0x56F860D7 ^ 0x56F90157));
					num2 = 7;
					continue;
				case 45:
					if (flowConnectorElement == null)
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
						{
							num2 = 32;
						}
						continue;
					}
					goto case 39;
				case 5:
					skipExecution = _003C_003Ec__DisplayClass48_.item.SkipExecution;
					num2 = 29;
					continue;
				case 25:
					trackingService = GetTrackingService(context);
					num2 = 12;
					continue;
				case 40:
					if (!qU1lgMwR5ojcobaKqo8(bPMNFlowElement))
					{
						num2 = 17;
						continue;
					}
					goto case 30;
				case 21:
					obj2 = null;
					goto IL_065f;
				case 34:
					if (trigger == EventTrigger.ErrorCatch)
					{
						num2 = 13;
						continue;
					}
					goto case 17;
				case 50:
					result.NextElementUids = new Guid[1] { AYOpKLw3Yw8UyydoObA(E4IbfvwqK31WvMy1eKn(flowConnectorElement)) };
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
					{
						num2 = 1;
					}
					continue;
				case 41:
					flag = true;
					num2 = 24;
					continue;
				case 18:
					if (E4IbfvwqK31WvMy1eKn(flowConnectorElement) == null)
					{
						num2 = 47;
						continue;
					}
					goto case 50;
				case 13:
					skfXSIwfnRpe0b8gCS6(instance, _003C_003Ec__DisplayClass48_.item, flowConnectorElement.ContextExceptionVar);
					num2 = 22;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
					{
						num2 = 11;
					}
					continue;
				default:
					obj = nTQ3hyw9EONJnH3n7Ok(_003C_003Ec__DisplayClass48_.item);
					break;
				case 8:
					vb5vLqwXeOq2a4cno2D(trackingService, f1rgCZE1M25IV1jxcVd(flowConnectorElement), true);
					num2 = 18;
					continue;
				case 22:
					if (_003C_003Ec__DisplayClass48_.item.LastExceptionData == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = NjSN1GwjhnKJWK3dk0d(KwB6TTwWq47p12LIBdR(_003C_003Ec__DisplayClass48_.item));
					break;
				case 4:
					skipConnectorUid = _003C_003Ec__DisplayClass48_.item.SkipConnectorUid;
					num2 = 46;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 38;
					}
					continue;
				case 36:
					if (activityWithExceptionFlowsImpl == null)
					{
						goto end_IL_0012;
					}
					goto case 9;
				case 35:
					if (flowConnectorElement.Trigger != 0)
					{
						num2 = 2;
						continue;
					}
					goto case 8;
				case 15:
					if (workflowActivity != null)
					{
						num2 = 23;
						continue;
					}
					goto case 11;
				case 32:
					{
						flowConnectorElement = bPMNFlowElement.StandardOutputFlows.FirstOrDefault((FlowConnectorElement f) => _003C_003Ec.xL0ZjuZxWuvpyI5v8dCK(f));
						num2 = 39;
						continue;
					}
					IL_065f:
					flowConnectorElement = (FlowConnectorElement)obj2;
					num2 = 27;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 45;
					}
					continue;
				}
				errorText = (string)obj;
				num2 = 18;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
				{
					num2 = 51;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 28;
		}
	}

	internal static void vXLY70EVlXjgy7iAFn8()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool aSAosNEk8GoMC93aIE7()
	{
		return apaTloEM8sFNIDb9eKE == null;
	}

	internal static WorkflowRootActivity DJ8JUhEUOg2kcIwsoXQ()
	{
		return apaTloEM8sFNIDb9eKE;
	}

	internal static void RAB4lwEA5U2DsFvVWoY(object P_0)
	{
		((Diagram)P_0).LoadDiagram();
	}

	internal static object seNyLMEGJW3haxHiKB5(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void a940CJE7V3QcU2xovZd(object P_0, object P_1)
	{
		((Activity)P_0).DisplayName = (string)P_1;
	}

	internal static object CV0GLoE2WNfriYI6FkW(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static bool D0xM6AEomA53YV7WDwA(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object OdNaNBEFwsyCViadTy0(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object BEibIpEislG6G9BGMpW(Type P_0)
	{
		return Locator.GetServiceNotNull(P_0);
	}

	internal static object HX3lwREI04omeKUCcCd(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static void fPIBhLEa1Gj4QrRkPPF(object P_0, object P_1)
	{
		((Activity)P_0).DisplayName = (string)P_1;
	}

	internal static void xSET3dEr524AZwNNFTP(object P_0, object P_1)
	{
		((WorkflowActivity)P_0).Element = (Element)P_1;
	}

	internal static void UI0ZYTEeDqEZEqPBJ5l(object P_0, object P_1)
	{
		((WorkflowActivity)P_0).Diagram = (WorkflowDiagram)P_1;
	}

	internal static void NjRAbCENK7CFaOwGV4H(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void GHWF2sExlI1uLCSDbDO(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void CawGklESxpoqaBvnlit(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static Guid f1rgCZE1M25IV1jxcVd(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static void zKNXUwEhoWuwJU7FuBx(object P_0, Guid elementUid)
	{
		((IWorkflowTrackingService)P_0).Execute(elementUid);
	}

	internal static GatewayStartType PO9sE4EE512TKxfQ5BK(object P_0)
	{
		return ((IGatewayActivity)P_0).GatewayStartType;
	}

	internal static int uYsKmFEwg7uGV40fBr9(object P_0)
	{
		return ((List<Connector>)P_0).Count;
	}

	internal static object W8yWVcE4W4fiESei9FY(object P_0)
	{
		return ((WorkflowActivity)P_0).Element;
	}

	internal static object bTbgqiEza9ereqShJU6(object P_0)
	{
		return ((Connector)P_0).EndElement;
	}

	internal static void nFZeQJwKpBp7LZLqgn5(object P_0, Guid value)
	{
		((GatewayExecutingInfo)P_0).StartGatewayUid = value;
	}

	internal static int x2bmZ4wO06c9U6GCt7I(object P_0)
	{
		return ((List<Tuple<Element, WorkflowActivity>>)P_0).Count;
	}

	internal static void MW1qHvwZmmFDjp09ybJ(object P_0, int value)
	{
		((GatewayExecutingInfo)P_0).StartedGatesCount = value;
	}

	internal static object sY2MqVwv36LvPKpavDs(object P_0)
	{
		return ((IWorkflowExecutingContext)P_0).Instance;
	}

	internal static bool kh6WdowYk2u8kFVbbVl(object P_0)
	{
		return ((IWorkflowInstance)P_0).IsEmulation;
	}

	internal static object fhmT39w8ly2vam4aWMn(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void Wn73Evws1KEoHPfMFhw(object P_0, object P_1, object P_2)
	{
		((WorkflowInstanceManager)P_0).AddComment((IWorkflowInstance)P_1, (string)P_2);
	}

	internal static GatewayType mkXehSwJoFdJiJAAQh1(object P_0)
	{
		return ((IGatewayActivity)P_0).GatewayType;
	}

	internal static int NxwyZcwleqHHc5cf7PT(object P_0)
	{
		return ((GatewayExecutingInfo)P_0).FinishedGatesCount;
	}

	internal static int iGTH3Ow05wypbXhdHHk(object P_0)
	{
		return ((GatewayExecutingInfo)P_0).StartedGatesCount;
	}

	internal static int ovcNqkwyhvDxwK5oY2y(object P_0)
	{
		return ((HashSet<WorkflowActivity>)P_0).Count;
	}

	internal static Guid YgP5GswmFnbO0WvrgCF(object P_0)
	{
		return ((IGatewayActivity)P_0).PairGatewayUid;
	}

	internal static DateTime cpr8vqwtbKPWNrynbNg()
	{
		return DateTime.Now;
	}

	internal static object X6w2N1wbJKDnwSvwoyw()
	{
		return Logger.Log;
	}

	internal static object Ee5sVEw558khAeYNIYI(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static void iYBRCVwgEGpXPkKZrEM(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).DebugFormat((string)P_1, (object[])P_2);
	}

	internal static void LppB5twBGqhyWJrH1YD(object P_0, object P_1, object P_2)
	{
		((WorkflowRootActivity)P_0).ScheduleActivity((NativeActivityContext)P_1, (WorkflowActivity)P_2);
	}

	internal static object WsyWCGwcPYTnMUIIjGk(object P_0, object P_1, object P_2)
	{
		return ((NativeActivityContext)P_0).CreateBookmark((string)P_1, (BookmarkCallback)P_2);
	}

	internal static bool miNk8ywPnaj9PcaND2i(object P_0)
	{
		return ((IWorkflowExecutingContext)P_0).IsTerminated;
	}

	internal static void vb5vLqwXeOq2a4cno2D(object P_0, Guid elementUid, bool executed)
	{
		((IWorkflowTrackingService)P_0).Add(elementUid, executed);
	}

	internal static void Dhb351wd8HxFsAfQPWR(object P_0, NativeActivityMetadata P_1)
	{
		((NativeActivity)P_0).CacheMetadata(P_1);
	}

	internal static void p8QfP5wulRN5NodDJvw(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static object T1U5RYwDk0ppMuJJgny(object P_0)
	{
		return ((ActivityInstance)P_0).Activity;
	}

	internal static void wK0dEswnMqOEQW51Bgm(bool P_0, object P_1)
	{
		Contract.CheckArgument(P_0, (string)P_1);
	}

	internal static bool fuKRSYwHfM3NcLDrXL5()
	{
		return EleWise.ELMA.Workflow.Services.WorkflowQueueService.IsWorkflowQueueItemExecutor;
	}

	internal static void bq3bU3wLIpUQPeS950E(object P_0, object P_1)
	{
		((IWorkflowQueueService)P_0).ProcessItemAsyncAfterCommit((IWorkflowQueueItem)P_1);
	}

	internal static void skfXSIwfnRpe0b8gCS6(object P_0, object P_1, Guid propertyUid)
	{
		ActivityExceptionFlowHelper.SetExceptionFlowPropertyValue((IWorkflowInstance)P_0, (IWorkflowQueueItem)P_1, propertyUid);
	}

	internal static object nTQ3hyw9EONJnH3n7Ok(object P_0)
	{
		return ((IWorkflowQueueItem)P_0).LastError;
	}

	internal static object KwB6TTwWq47p12LIBdR(object P_0)
	{
		return ((IWorkflowQueueItem)P_0).LastExceptionData;
	}

	internal static object NjSN1GwjhnKJWK3dk0d(object P_0)
	{
		return ((ExceptionData)P_0).Message;
	}

	internal static bool qU1lgMwR5ojcobaKqo8(object P_0)
	{
		return ((IElementWithExceptionFlows)P_0).QueueExecutionTimeoutSupported;
	}

	internal static void c9ZCx3w66e3or0EYuu8(object P_0, object P_1, object P_2, object P_3)
	{
		ActivityExceptionFlowHelper.SendMessagesOnTimeout((NativeActivityContext)P_0, (IActivityWithExceptionFlowsImpl)P_1, (IWorkflowInstance)P_2, (FlowConnectorElement)P_3);
	}

	internal static object E4IbfvwqK31WvMy1eKn(object P_0)
	{
		return ((Connector)P_0).EndPlug;
	}

	internal static Guid AYOpKLw3Yw8UyydoObA(object P_0)
	{
		return ((Plug)P_0).ElementUid;
	}

	internal static void FaqtUSwTXFcefnmSSya(object P_0, object P_1, object P_2, ActivityExecuteResult result)
	{
		((WorkflowRootActivity)P_0).ProcessActivityCompleted((NativeActivityContext)P_1, (WorkflowActivity)P_2, result);
	}

	internal static object SfYoNrwQXgk1nicfK6u(object P_0, object P_1)
	{
		return ((ISessionProvider)P_0).GetSession((string)P_1);
	}

	internal static bool abAQR6wpWf7DZrV0VCo(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
