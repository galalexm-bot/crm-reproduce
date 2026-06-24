using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.Common.Models.Filters;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Exceptions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Actions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Filters;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Model.Types.Helpers;
using EleWise.ELMA.Model.Types.Settings;
using EleWise.ELMA.Model.Views;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Runtime.Providers;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Managers;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Templates;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Helpers;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Models.ChangeProcessVersion;
using EleWise.ELMA.Workflow.Security;
using EleWise.ELMA.Workflow.Services;
using EleWise.TemplateGenerator;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class WorkflowInstanceManager : EntityManager<IWorkflowInstance, long>
{
	public class ContextVarInfo
	{
		private static ContextVarInfo ix9ZhnZ67vNbc8n96Pvx;

		public long ProcessHeaderId
		{
			[CompilerGenerated]
			get
			{
				return _003CProcessHeaderId_003Ek__BackingField;
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
						_003CProcessHeaderId_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public string ContextName
		{
			[CompilerGenerated]
			get
			{
				return _003CContextName_003Ek__BackingField;
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
						_003CContextName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
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

		public Guid PropertyUid
		{
			[CompilerGenerated]
			get
			{
				return _003CPropertyUid_003Ek__BackingField;
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
						_003CPropertyUid_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
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

		public string PropertyName
		{
			[CompilerGenerated]
			get
			{
				return _003CPropertyName_003Ek__BackingField;
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
						_003CPropertyName_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public EntitySettings Settings
		{
			[CompilerGenerated]
			get
			{
				return _003CSettings_003Ek__BackingField;
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
						_003CSettings_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
						{
							num2 = 0;
						}
						break;
					}
				}
			}
		}

		public int TableNumber
		{
			[CompilerGenerated]
			get
			{
				return _003CTableNumber_003Ek__BackingField;
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
						_003CTableNumber_003Ek__BackingField = value;
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
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

		public ContextVarInfo()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			zCX2U2Z6FunREpRDsINa();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool hik7LKZ62PwnFKXZAdjl()
		{
			return ix9ZhnZ67vNbc8n96Pvx == null;
		}

		internal static ContextVarInfo KKE7jVZ6oJyJTLhqLK6j()
		{
			return ix9ZhnZ67vNbc8n96Pvx;
		}

		internal static void zCX2U2Z6FunREpRDsINa()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}
	}

	private readonly IAuthenticationService authenticationService;

	private static readonly string F_Id;

	private static readonly string F_Status;

	private static readonly string F_ParentInstance;

	private static readonly string F_ResumeJob_Id;

	private static readonly string F_ResumeJob_Task;

	private static readonly string F_ResumeJob_Bookmark;

	private static readonly string F_ResumeJob_OnceExecuteStatus;

	private static readonly string F_SchedulerTask_ExecuteTime;

	private static readonly string F_SchedulerTask_Status;

	private static readonly string F_SchedulerTask_CreationDate;

	private static readonly string F_Bookmark_ElementUid;

	private static readonly string F_Bookmark_Instance;

	private static readonly string F_TimerInfo_SchedulerJobId;

	private static readonly string F_TimerInfo_Instance;

	private static readonly string F_TimerInfo_ElementUid;

	private static readonly string F_TimerInfo_CreationDate;

	private static readonly string F_TimerInfo_ExecuteTime;

	internal static WorkflowInstanceManager HWNcLJPPgoRpgJLYjjq;

	public ProcessHeaderManager ProcessHeaderManager
	{
		[CompilerGenerated]
		get
		{
			return _003CProcessHeaderManager_003Ek__BackingField;
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
					_003CProcessHeaderManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
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

	public WorkflowProcessManager WorkflowProcessManager
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowProcessManager_003Ek__BackingField;
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
					_003CWorkflowProcessManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowInstanceContextService WorkflowInstanceContextService
	{
		[CompilerGenerated]
		get
		{
			return _003CWorkflowInstanceContextService_003Ek__BackingField;
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
					_003CWorkflowInstanceContextService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
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

	public new ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	[Obsolete("Устарел")]
	public IEnumerable<IEntityModelHistoryEventsFilter> Filters { get; set; }

	public IEnumerable<IWorkflowContextPropertyObserver> ContextObservers { get; set; }

	public ITransformationProvider TransformationProvider
	{
		[CompilerGenerated]
		get
		{
			return _003CTransformationProvider_003Ek__BackingField;
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
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public new static WorkflowInstanceManager Instance => Locator.GetServiceNotNull<WorkflowInstanceManager>();

	protected override string DefaultCriteriaAlias => DefaultCriteriaAliasStatic;

	public static string DefaultCriteriaAliasStatic => SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F73D03);

	public WorkflowInstanceManager(IAuthenticationService authenticationService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		i7lTluPuM7k2ixNBnxp();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.authenticationService = authenticationService;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[PublicApiMember]
	public override void Save(IWorkflowInstance obj)
	{
		//Discarded unreachable code: IL_00a1, IL_00d4, IL_0126, IL_0163, IL_0200, IL_0279, IL_02d6, IL_0301, IL_0310, IL_0320, IL_03b3, IL_0426, IL_0511, IL_0544, IL_0597, IL_05a6
		int num = 10;
		int num2 = num;
		NotificationElement.DataSource dataSource = default(NotificationElement.DataSource);
		while (true)
		{
			switch (num2)
			{
			case 5:
				sZ46u9PHN5cjbV6iRHO(((IWorkflowProcess)eLgYo2PDg0QbWE0OMmG(obj)).NamingScheme, PnRqCnPnwVhafkSNYwq(-683713632 ^ -683733652));
				num2 = 2;
				continue;
			case 8:
				return;
			case 4:
				try
				{
					MXqfS0PkHjcZX8XN54K(obj.MetricValues);
					int num7 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
					return;
				}
				catch (Exception ex)
				{
					int num8 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
					{
						num8 = 1;
					}
					while (true)
					{
						switch (num8)
						{
						default:
							return;
						case 0:
							return;
						case 1:
							f8QkdaPMRkgWWHtUFCl(qm2aodPC2arZ5caSJbF(this), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6D2378), ex);
							num8 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
							{
								num8 = 0;
							}
							break;
						}
					}
				}
			case 7:
				try
				{
					new TextTemplateGenerator((string)M3LpueP9pfSIn5QHqOA(wDwU1tPLsAX8SykaUT1(obj.Process)));
					int num5 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						default:
						{
							NotificationElement.DataSource dataSource2 = new NotificationElement.DataSource();
							Nfl4IyPWN8EoPSCZq5m(dataSource2, obj);
							dataSource2.Context = ByClPmPjBNwtm7qPTmc(obj);
							dataSource = dataSource2;
							num5 = 2;
							continue;
						}
						case 2:
							obj.Name = (string)TBkw4JPRJ16L1FLtSKZ(new TextTemplateGenerator((string)M3LpueP9pfSIn5QHqOA(((IWorkflowProcess)eLgYo2PDg0QbWE0OMmG(obj)).NamingScheme)), dataSource);
							num5 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
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
				catch (Exception exception2)
				{
					int num6 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
					{
						num6 = 1;
					}
					while (true)
					{
						switch (num6)
						{
						case 1:
							base.Logger.Error(vCjx7rP6aTgCoP7f6no(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -29961256), obj.Id, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x4943B496)), exception2);
							num6 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
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
				goto case 11;
			case 11:
				base.Save(obj);
				num2 = 12;
				continue;
			case 1:
				if (c5XAbqPUCVdHe5t3PfU(obj) == null)
				{
					return;
				}
				num2 = 4;
				continue;
			case 3:
				try
				{
					PropertyMetadata propertyMetadata = (PropertyMetadata)atfNB3P37CoWCprLgFQ((EntityMetadata)YCXmywPqO2LKW3OOdYi(obj.Context.GetType(), true, true));
					int num9 = 5;
					while (true)
					{
						switch (num9)
						{
						case 0:
							break;
						case 2:
							break;
						case 1:
							if (!TTrSWDPT0LHRYLspwNQ(propertyMetadata.TypeUid, StringDescriptor.UID))
							{
								num9 = 2;
								continue;
							}
							goto case 3;
						case 3:
							sDdux9PposJVck9HW6K(obj, (string)zZOSRLPQyByLPK5XrXR(ByClPmPjBNwtm7qPTmc(obj), propertyMetadata.Uid));
							num9 = 4;
							continue;
						case 5:
							if (propertyMetadata == null)
							{
								num9 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
								{
									num9 = 0;
								}
								continue;
							}
							goto case 1;
						case 4:
							break;
						}
						break;
					}
				}
				catch (Exception ex2)
				{
					int num10 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
					{
						num10 = 0;
					}
					while (true)
					{
						switch (num10)
						{
						case 1:
							f8QkdaPMRkgWWHtUFCl(qm2aodPC2arZ5caSJbF(this), vCjx7rP6aTgCoP7f6no(PnRqCnPnwVhafkSNYwq(-1214182792 ^ -1214161664), obj.Id, PnRqCnPnwVhafkSNYwq(--727842433 ^ 0x2B61A9F3)), ex2);
							num10 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
							{
								num10 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 11;
			default:
				if (gflnsLPf1fV0r752vE3(wDwU1tPLsAX8SykaUT1(eLgYo2PDg0QbWE0OMmG(obj))) == InstanceNamingScheme.SchemeType.Template)
				{
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			case 10:
				Contract.ArgumentNotNull(obj, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x595C500A ^ 0x595C06A2));
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
				{
					num2 = 3;
				}
				continue;
			case 2:
				if (((IWorkflowProcess)eLgYo2PDg0QbWE0OMmG(obj)).NamingScheme != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 9:
				sZ46u9PHN5cjbV6iRHO(eLgYo2PDg0QbWE0OMmG(obj), PnRqCnPnwVhafkSNYwq(--601115071 ^ 0x23D41F0D));
				num2 = 5;
				continue;
			case 6:
				break;
			case 12:
				try
				{
					MXqfS0PkHjcZX8XN54K(ByClPmPjBNwtm7qPTmc(obj));
					int num3 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception exception)
				{
					int num4 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							((ILogger)qm2aodPC2arZ5caSJbF(this)).Error(PnRqCnPnwVhafkSNYwq(-961162596 ^ -961182350), exception);
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 1;
			}
			num2 = 3;
		}
	}

	public long CountUsingContext(IWorkflowInstanceFilter filter)
	{
		//Discarded unreachable code: IL_0050, IL_005f, IL_008f, IL_009e, IL_00b5
		int num = 1;
		ICriteria val = default(ICriteria);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 3:
					MxXHpePGChkSsTGdbow(this, val, filter);
					num2 = 5;
					continue;
				case 1:
					if (filter == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				default:
					obj = uj1OL7PAo8mNfPvsL7L(this, null);
					break;
				case 5:
					return NuKmwgP7VWHPfqmNjLV(this, val);
				case 2:
					if (wHchNYPVPiLSsrnrGLh(filter) != null)
					{
						goto end_IL_0012;
					}
					goto default;
				case 4:
					obj = CreateContextFilterCriteria(filter, null);
					break;
				}
				val = (ICriteria)obj;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	public ICollection<object> FindUsingContext(IWorkflowInstanceFilter filter, FetchOptions fetchOptions)
	{
		int num;
		if (filter != null)
		{
			num = ((filter.ProcessHeader != null) ? 1 : 0);
			if (num != 0)
			{
				goto IL_007a;
			}
		}
		else
		{
			num = 0;
		}
		if (!string.IsNullOrEmpty(fetchOptions.SortExpression) && fetchOptions.SortExpression.StartsWith(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34EA0850), StringComparison.CurrentCultureIgnoreCase))
		{
			fetchOptions.SortExpression = fetchOptions.SortExpression.Substring(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12F30C0).Length + 1);
		}
		goto IL_007a;
		IL_007a:
		ICriteria val = ((num != 0) ? CreateContextFilterCriteria(filter, fetchOptions) : CreateCriteria(fetchOptions, GetFetchType(null)));
		SetupFilter(val, filter);
		if (num == 0)
		{
			return (from i in val.List<IWorkflowInstance>()
				select new WorkflowInstanceContextStub
				{
					WorkflowInstance = i
				}).Cast<object>().ToList();
		}
		return val.List<object>();
	}

	public void CheckFilterUsingContext(IWorkflowInstanceFilter filter)
	{
		//Discarded unreachable code: IL_0039, IL_004f
		int num = 4;
		int num2 = num;
		ICriteria val = default(ICriteria);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 3:
			case 5:
				obj = uj1OL7PAo8mNfPvsL7L(this, null);
				break;
			case 4:
				if (filter == null)
				{
					num2 = 3;
					continue;
				}
				goto case 2;
			default:
				MxXHpePGChkSsTGdbow(this, val, filter);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				if (filter.ProcessHeader == null)
				{
					num2 = 5;
					continue;
				}
				obj = INgnU8P2ZMpO6lOf7PQ(this, filter, null);
				break;
			case 1:
				return;
			}
			val = (ICriteria)obj;
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
			{
				num2 = 0;
			}
		}
	}

	protected override void SetupFilterQuery(ICriteria criteria, IEntityFilter filter, EntityMetadata metadata, Func<EntityPropertyMetadata, Func<EntityMetadata, string, ICriterion>, Func<string>, ICriterion> propertyCriterionFunc, string alias)
	{
		ICriteria val = criteria;
		string alias2 = alias;
		Type rootEntityTypeIfAvailable = criteria.GetRootEntityTypeIfAvailable();
		if (rootEntityTypeIfAvailable != null && !rootEntityTypeIfAvailable.IsInheritOrSame<IWorkflowInstance>())
		{
			ICriteria criteriaByAlias = criteria.GetCriteriaByAlias(DefaultCriteriaAlias);
			if (val != null && rootEntityTypeIfAvailable.GetInterfaces().Contains(typeof(IWorkflowInstanceContext)))
			{
				_003C_003Ec__DisplayClass37_0 _003C_003Ec__DisplayClass37_ = new _003C_003Ec__DisplayClass37_0();
				_003C_003Ec__DisplayClass37_.contextMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(rootEntityTypeIfAvailable);
				if (_003C_003Ec__DisplayClass37_.contextMetadata != null)
				{
					_003C_003Ec__DisplayClass37_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass37_1();
					CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass37_;
					val = criteriaByAlias;
					alias2 = DefaultCriteriaAlias;
					ParameterExpression parameterExpression = Expression.Parameter(typeof(IWorkflowInstance), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651FBA53));
					CS_0024_003C_003E8__locals0.contextUid = InterfaceActivator.PropertyUid(Expression.Lambda<Func<IWorkflowInstance, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					CS_0024_003C_003E8__locals0.contextAlias = criteria.get_Alias();
					propertyCriterionFunc = (EntityPropertyMetadata propMetadta, Func<EntityMetadata, string, ICriterion> criterionFunc, Func<string> newAliasFunc) => (!(propMetadta.Uid == CS_0024_003C_003E8__locals0.contextUid)) ? null : criterionFunc(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.contextMetadata, CS_0024_003C_003E8__locals0.contextAlias);
				}
			}
		}
		base.SetupFilterQuery(val, filter, metadata, propertyCriterionFunc, alias2);
	}

	public Type GetContextType(IProcessHeader processHeader)
	{
		int num = 2;
		int num2 = num;
		IWorkflowProcess workflowProcess = default(IWorkflowProcess);
		while (true)
		{
			switch (num2)
			{
			case 2:
				workflowProcess = (IWorkflowProcess)pcjv5dPoZRQRwhMcDFE(processHeader);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (workflowProcess == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
					{
						num2 = 0;
					}
					break;
				}
				return xOYWcvPFfTpGmJ65MXT(WorkflowInstanceContextService, workflowProcess);
			default:
				throw new ObjectNotFoundException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F70D21), processHeader.Id);
			}
		}
	}

	[Transaction]
	public virtual void AddMember(IWorkflowInstance instance, IWorkflowInstanceMember member)
	{
		int num = 1;
		_003C_003Ec__DisplayClass39_0 _003C_003Ec__DisplayClass39_ = default(_003C_003Ec__DisplayClass39_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					sZ46u9PHN5cjbV6iRHO(_003C_003Ec__DisplayClass39_.member, PnRqCnPnwVhafkSNYwq(-1108877388 ^ -1108900178));
					num2 = 4;
					continue;
				case 3:
					if (((IEnumerable<IWorkflowInstanceMember>)instance.Members).FirstOrDefault(_003C_003Ec__DisplayClass39_._003CAddMember_003Eb__0) != null)
					{
						num2 = 5;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
						{
							num2 = 7;
						}
					}
					else
					{
						instance.Members.Add(_003C_003Ec__DisplayClass39_.member);
						num2 = 5;
					}
					continue;
				case 1:
					_003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_0();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					return;
				case 6:
					sZ46u9PHN5cjbV6iRHO(instance, PnRqCnPnwVhafkSNYwq(0x628167BE ^ 0x62813EB8));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
					{
						num2 = 2;
					}
					continue;
				case 8:
					break;
				case 7:
					return;
				case 4:
					ViTMWHPinPX5mnUiSYs(_003C_003Ec__DisplayClass39_.member, instance);
					num2 = 8;
					continue;
				default:
					_003C_003Ec__DisplayClass39_.member = member;
					num2 = 6;
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass39_.memberTask = (ITaskBase)mW3UkFPI7RmTOpbwT5m(_003C_003Ec__DisplayClass39_.member);
			num = 3;
		}
	}

	[Transaction]
	public virtual void AddMember(IWorkflowInstance instance, [CanBeNull] EleWise.ELMA.Security.Models.IUser user)
	{
		int num = 1;
		int num2 = num;
		IWorkflowInstanceMember @new = default(IWorkflowInstanceMember);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				return;
			case 3:
				AddMember(instance, @new);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (user != null)
				{
					InstanceOf<IWorkflowInstanceMember> instanceOf = new InstanceOf<IWorkflowInstanceMember>();
					ViTMWHPinPX5mnUiSYs(instanceOf.New, instance);
					UfAuOKPa9ILZgFPXT4i(instanceOf.New, user);
					@new = instanceOf.New;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
					{
						num2 = 0;
					}
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void AddMember(IWorkflowInstance instance, [CanBeNull] IUserGroup group)
	{
		//Discarded unreachable code: IL_00d3
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass41_0 _003C_003Ec__DisplayClass41_ = default(_003C_003Ec__DisplayClass41_0);
		while (true)
		{
			switch (num2)
			{
			case 6:
				_003C_003Ec__DisplayClass41_ = new _003C_003Ec__DisplayClass41_0();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
				{
					num2 = 5;
				}
				continue;
			case 2:
				return;
			case 1:
				((UserGroupManager)R9xJ1FPrALZsammAApU()).GetUsersByGroup(group.Id).ToList().ForEach(_003C_003Ec__DisplayClass41_._003CAddMember_003Eb__0);
				num2 = 3;
				continue;
			case 3:
				return;
			case 4:
				_003C_003Ec__DisplayClass41_.instance = instance;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				_003C_003Ec__DisplayClass41_._003C_003E4__this = this;
				num2 = 4;
				continue;
			}
			if (group == null)
			{
				return;
			}
			num2 = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
			{
				num2 = 1;
			}
		}
	}

	[Transaction]
	public virtual void AddMember(IWorkflowInstance instance, [CanBeNull] IOrganizationItem orgItem)
	{
		//Discarded unreachable code: IL_0062
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass42_0 _003C_003Ec__DisplayClass42_ = default(_003C_003Ec__DisplayClass42_0);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return;
			case 3:
				if (orgItem != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 4:
				_003C_003Ec__DisplayClass42_._003C_003E4__this = this;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
				{
					num2 = 6;
				}
				break;
			case 2:
				return;
			default:
				((IEnumerable<EleWise.ELMA.Security.Models.IUser>)orgItem.Users).ToList().ForEach(_003C_003Ec__DisplayClass42_._003CAddMember_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass42_ = new _003C_003Ec__DisplayClass42_0();
				num2 = 4;
				break;
			case 1:
				AddMember(_003C_003Ec__DisplayClass42_.instance, (EleWise.ELMA.Security.Models.IUser)GpJ5IDPesW1cpNKZ3qt(orgItem));
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass42_.instance = instance;
				num2 = 3;
				break;
			}
		}
	}

	[Transaction]
	public virtual void ChangeResponsible(IWorkflowInstance instance, [NotNull] EleWise.ELMA.Security.Models.IUser user, bool sendNotification = true)
	{
		int num = 6;
		int num2 = num;
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		while (true)
		{
			switch (num2)
			{
			case 3:
				((IEntityActionHandler)q9jMDOP1eLyaXKd4ZXk(this)).ActionExecuted(entityActionEventArgs);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				entityActionEventArgs = new EntityActionEventArgs(instance, instance, uQPSOKPSS6hGKvWhuRi());
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				kATbIQPxkALLxZUyMy0(instance);
				num2 = 2;
				break;
			case 4:
				entityActionEventArgs.ExtendedProperties[(string)PnRqCnPnwVhafkSNYwq(-43932417 ^ -43909675)] = true;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				lVOs6UPNdl4WYOjgWoI(instance, user);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
				{
					num2 = 5;
				}
				break;
			default:
				if (!sendNotification)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			case 1:
				return;
			}
		}
	}

	public virtual IDictionary<IWorkflowInstance, ICollection<EleWise.ELMA.Security.Models.IUser>> GetProcessOwners(IWorkflowInstanceFilter filter)
	{
		_003C_003Ec__DisplayClass44_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass44_0();
		Contract.ArgumentNotNull(filter, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x192783AF));
		Contract.ArgumentNotNull(filter.Responsible, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1303601216 ^ -1303591284));
		CS_0024_003C_003E8__locals0.processOwners = new Dictionary<IWorkflowInstance, ICollection<EleWise.ELMA.Security.Models.IUser>>();
		Guid guid = InterfaceActivator.UID<IOrganizationItem>(loadImplementation: false);
		Guid guid2 = InterfaceActivator.UID<IUserGroup>(loadImplementation: false);
		List<WorkflowInstanceStatus> list = new List<WorkflowInstanceStatus>();
		if (filter.GeneralStatus.HasValue)
		{
			switch (filter.GeneralStatus.Value)
			{
			case WorkflowInstanceGeneralStatus.Current:
				list.Add(WorkflowInstanceStatus.Running);
				break;
			case WorkflowInstanceGeneralStatus.Completed:
				list.Add(WorkflowInstanceStatus.Completed);
				list.Add(WorkflowInstanceStatus.Aborted);
				break;
			case WorkflowInstanceGeneralStatus.Terminated:
				list.Add(WorkflowInstanceStatus.Terminated);
				break;
			default:
				throw new InvalidOperationException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46EFAA5)));
			}
		}
		string text = string.Empty;
		if (list.Count >= 1)
		{
			text = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614CACAD), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6D22B8), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514148322)));
		}
		string text2 = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-682910880 ^ -682901148), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683736484), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398709535)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF487FE)), text, TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720442237)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E92F4D), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x69063C81 ^ 0x6906629F)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125897096 ^ -2125906880)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF6AFB8), TransformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647773398), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667478133)), TransformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7381F16B ^ 0x7381AF3B), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B546B1)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D68F95)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x738AE412), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E92FD1)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x350C0E8 ^ 0x3509E70)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F44D93A ^ 0x2F448796)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x141C968 ^ 0x14197AC)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5BCD23A0 ^ 0x5BCD7D7A)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197755860)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2269BD32 ^ 0x2269E234)));
		IQuery val = ((IQuery)base.Session.CreateSQLQuery(text2).AddEntity(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398709321), InterfaceActivator.TypeOf<IWorkflowInstance>()).AddEntity(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -420013053), InterfaceActivator.TypeOf<EleWise.ELMA.Security.Models.IUser>())).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22371136), guid).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x11348D9A), guid2).SetParameter<ResponsibilityLevel>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647773784), ResponsibilityLevel.Owner)
			.SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-43932417 ^ -43910305), filter.Responsible.Id);
		if (list.Count >= 1)
		{
			val.SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965270793), (IEnumerable)list);
		}
		(from i in val.List<object[]>()
			group i by i[0]).ForEach(delegate(IGrouping<object, object[]> i)
		{
			CS_0024_003C_003E8__locals0.processOwners.Add((IWorkflowInstance)i.Key, i.Select((object[] j) => j[1]).OfType<EleWise.ELMA.Security.Models.IUser>().ToList());
		});
		return CS_0024_003C_003E8__locals0.processOwners;
	}

	public virtual List<Guid> GetVisiblePropertyUids(IWorkflowInstance instance)
	{
		_003C_003Ec__DisplayClass45_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass45_0();
		CS_0024_003C_003E8__locals0.instance = instance;
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642732357));
		if (ProcessHeaderManager.IsOwner(CS_0024_003C_003E8__locals0.instance.Process.Header) || ProcessHeaderManager.IsCurator(CS_0024_003C_003E8__locals0.instance.Process.Header) || SecurityService.HasPermission(WorkflowPermissionProvider.ProcessMonitor, CS_0024_003C_003E8__locals0.instance.Process.Header) || SecurityService.HasPermission(WorkflowPermissionProvider.FullMonitorAccessPermission))
		{
			return null;
		}
		if (CS_0024_003C_003E8__locals0.instance.Process.ContextViewScheme == null)
		{
			return null;
		}
		IEnumerable<IResponsibilityMatrixItem> responsibilityMatrixItems = WorkflowProcessManager.GetResponsibilityMatrixItems(CS_0024_003C_003E8__locals0.instance.Process);
		responsibilityMatrixItems = responsibilityMatrixItems.Where((IResponsibilityMatrixItem i) => !i.IsDynamic);
		EleWise.ELMA.Security.Models.IUser currentUser = authenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		CS_0024_003C_003E8__locals0.elementUids = (from wb in EntityManager<IWorkflowBookmark>.Instance.Find(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-17847711 ^ -17828433), currentUser.Id, CS_0024_003C_003E8__locals0.instance.Id))
			select wb.ElementUid).ToList();
		IEnumerable<Element> source = CS_0024_003C_003E8__locals0.instance.Process.Diagram.Elements.Where((Element e) => CS_0024_003C_003E8__locals0.elementUids.Contains(_003C_003Ec__DisplayClass45_0.AE17wqZqLkYk8GJtLt4d(e)));
		CS_0024_003C_003E8__locals0.swimlaneUids = (from e in source.OfType<BPMNFlowElement>()
			select (SwimlaneElement)_003C_003Ec__DisplayClass45_0.UH2sxuZqW2OLXU7qkTpu(e, _003C_003Ec__DisplayClass45_0.BUPPRAZq9a7lZsaSfAcn(_003C_003Ec__DisplayClass45_0.EMGWcwZqfAQ9iumHrGBn(CS_0024_003C_003E8__locals0.instance))) into s
			where s != null
			select _003C_003Ec.Uoy5sbZ6eOJRX4XHKx6L(s)).Union(responsibilityMatrixItems.Where(delegate(IResponsibilityMatrixItem i)
		{
			int num3 = 1;
			int num4 = num3;
			Guid? swimlaneUid2 = default(Guid?);
			while (true)
			{
				switch (num4)
				{
				case 1:
					swimlaneUid2 = i.SwimlaneUid;
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
					{
						num4 = 0;
					}
					break;
				default:
					return swimlaneUid2.HasValue;
				}
			}
		}).Select(delegate(IResponsibilityMatrixItem i)
		{
			int num = 1;
			int num2 = num;
			Guid? swimlaneUid = default(Guid?);
			while (true)
			{
				switch (num2)
				{
				case 1:
					swimlaneUid = i.SwimlaneUid;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return swimlaneUid.Value;
				}
			}
		})).Distinct().ToList();
		return (from i in CS_0024_003C_003E8__locals0.instance.Process.ContextViewScheme.Swimlanes.Where((SwimlaneContextViewScheme s) => CS_0024_003C_003E8__locals0.swimlaneUids.Contains(_003C_003Ec__DisplayClass45_0.FUV6K6ZqjcOatfT0sTJn(s))).Union(new SwimlaneContextViewScheme[1] { CS_0024_003C_003E8__locals0.instance.Process.ContextViewScheme.Default }).SelectMany((SwimlaneContextViewScheme s) => s.Items)
			select i.PropertyUid).Distinct().ToList();
	}

	public virtual FormView GetContextView(IWorkflowInstance instance, ViewType viewType)
	{
		int num = 2;
		int num2 = num;
		FormView formView = default(FormView);
		EntityMetadata metadata = default(EntityMetadata);
		List<Guid> visiblePropertyUids = default(List<Guid>);
		while (true)
		{
			switch (num2)
			{
			default:
				return formView;
			case 4:
				AddContextViewItems(metadata, visiblePropertyUids, formView, formView);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			{
				FormView formView2 = new FormView();
				lXsraCPhmjxxcdG3bY5(formView2, viewType);
				formView = formView2;
				num2 = 5;
				break;
			}
			case 5:
				visiblePropertyUids = GetVisiblePropertyUids(instance);
				num2 = 3;
				break;
			case 2:
				sZ46u9PHN5cjbV6iRHO(instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF488FE));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				metadata = (EntityMetadata)YCXmywPqO2LKW3OOdYi(ByClPmPjBNwtm7qPTmc(instance).GetType(), true, true);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	public virtual FormView GetContextViewNoBlok(IWorkflowInstance instance, ViewType viewType, bool block = false)
	{
		int num = 4;
		int num2 = num;
		EntityMetadata metadata = default(EntityMetadata);
		FormView formView = default(FormView);
		while (true)
		{
			switch (num2)
			{
			case 2:
				metadata = (EntityMetadata)YCXmywPqO2LKW3OOdYi(ByClPmPjBNwtm7qPTmc(instance).GetType(), true, true);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				formView = new FormView
				{
					ViewType = viewType
				};
				num2 = 2;
				break;
			case 1:
				AddContextViewItemsNoBlock(metadata, null, formView, formView, block);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return formView;
			case 4:
				Contract.ArgumentNotNull(instance, (string)PnRqCnPnwVhafkSNYwq(-11799394 ^ -11817576));
				num2 = 3;
				break;
			}
		}
	}

	public virtual FormViewItem GetContextViewTableParts(IWorkflowInstance instance, ViewType viewType)
	{
		int num = 3;
		int num2 = num;
		FormViewItem formViewItem = default(FormViewItem);
		EntityMetadata metadata = default(EntityMetadata);
		List<Guid> visiblePropertyUids = default(List<Guid>);
		while (true)
		{
			switch (num2)
			{
			case 2:
			{
				FormViewItem formViewItem2 = new FormViewItem();
				lXsraCPhmjxxcdG3bY5(formViewItem2, viewType);
				formViewItem = formViewItem2;
				num2 = 4;
				break;
			}
			case 1:
				AddContextViewItemsTableParts(metadata, visiblePropertyUids, formViewItem, formViewItem);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				metadata = (EntityMetadata)YCXmywPqO2LKW3OOdYi(ByClPmPjBNwtm7qPTmc(instance).GetType(), true, true);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return formViewItem;
			case 4:
				visiblePropertyUids = GetVisiblePropertyUids(instance);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				sZ46u9PHN5cjbV6iRHO(instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-682910880 ^ -682900890));
				num2 = 2;
				break;
			}
		}
	}

	[ActionMethod("e93ccf45-3ff5-4bf5-a83b-7ff73130e432")]
	[Transaction]
	public virtual void ChangeProcessVersion(ChangeProcessVersionActionData changeData)
	{
		//Discarded unreachable code: IL_01e7, IL_01f6, IL_021d, IL_022c, IL_02d8, IL_0318, IL_0327, IL_0333, IL_0342
		int num = 1;
		int num2 = num;
		IWorkflowExecutingContext workflowExecutingContext = default(IWorkflowExecutingContext);
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		IComment comment = default(IComment);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				throw new InvalidOperationException(SR.T((string)PnRqCnPnwVhafkSNYwq(-1716629332 ^ -1716637480)));
			case 1:
				if (!GKHPNRPwFGh0HCSPXR6(ValidateChangeProcessVersion(changeData.Instance, (IWorkflowProcess)WacpbZPEK3qOmVdtA6T(changeData))))
				{
					workflowExecutingContext = (IWorkflowExecutingContext)H9cwoJPz5wNNhlitbDs(WorkflowRuntimeService, T5QofYP4mCwjCfAEprn(changeData));
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 3:
				try
				{
					changeData.Actions.ForEach(delegate(IChangeProcessVersionAction a)
					{
						_003C_003Ec.xk4IaYZ6NjRW3YYNYKdV(a);
					});
					int num3 = 3;
					while (true)
					{
						switch (num3)
						{
						case 8:
							return;
						case 13:
							base.ActionHandler.ActionExecuted(entityActionEventArgs);
							num3 = 8;
							break;
						default:
							entityActionEventArgs = new EntityActionEventArgs(null, (IEntity)T5QofYP4mCwjCfAEprn(changeData), EaptZjXZLa4XSAgqFXN());
							num3 = 5;
							break;
						case 5:
							if (changeData.Reason == null)
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
								{
									num3 = 1;
								}
								break;
							}
							goto case 4;
						case 1:
						case 12:
						{
							kATbIQPxkALLxZUyMy0(T5QofYP4mCwjCfAEprn(changeData));
							int num4 = 13;
							num3 = num4;
							break;
						}
						case 9:
							OkKwR7X8mANunfjAQtn(comment, tcKJIjXYiIxHN6oK1O8(changeData));
							num3 = 10;
							break;
						case 11:
							EFKwF3XO2LmIcpDIQxH(changeData, ((IAuthenticationService)hXniDAXKG5bZIQlJEYa(this)).GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
							{
								num3 = 0;
							}
							break;
						case 2:
							p3l82LXv2ObFgvtGy8j(comment, changeData.Reason);
							num3 = 9;
							break;
						case 10:
							((IWorkflowInstance)T5QofYP4mCwjCfAEprn(changeData)).Comments.Add(comment);
							num3 = 7;
							break;
						case 4:
							comment = InterfaceActivator.Create<IComment>();
							num3 = 2;
							break;
						case 7:
							entityActionEventArgs.ExtendedProperties[(string)PnRqCnPnwVhafkSNYwq(-865213812 ^ -865238412)] = comment;
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
							{
								num3 = 12;
							}
							break;
						case 3:
							if (changeData.User != null)
							{
								num3 = 6;
								break;
							}
							goto case 11;
						}
					}
				}
				finally
				{
					int num5;
					if (workflowExecutingContext == null)
					{
						num5 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
						{
							num5 = 1;
						}
						goto IL_02dc;
					}
					goto IL_02f2;
					IL_02f2:
					HwQy5gXsvHZMcaxjnu6(workflowExecutingContext);
					num5 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 != 0)
					{
						num5 = 0;
					}
					goto IL_02dc;
					IL_02dc:
					switch (num5)
					{
					case 2:
						goto end_IL_02b7;
					case 1:
						goto end_IL_02b7;
					}
					goto IL_02f2;
					end_IL_02b7:;
				}
			}
		}
	}

	[Transaction]
	[ActionMethod("c828c2eb-7fb5-42dc-af0d-be34111b8292")]
	public virtual void Terminate(IWorkflowInstance instance, string reason = null, EleWise.ELMA.Security.Models.IUser user = null)
	{
		//Discarded unreachable code: IL_00bf, IL_00ce, IL_010f
		int num = 6;
		IComment comment = default(IComment);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 10:
				case 14:
					Ou5KEIXlWHksJ0IOh30(instance, user);
					num = 8;
					break;
				case 12:
					user = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
					num2 = 14;
					continue;
				case 6:
					sZ46u9PHN5cjbV6iRHO(instance, PnRqCnPnwVhafkSNYwq(-197778752 ^ -197755962));
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
				case 4:
					NUekjHXy3AKviUCwAJu(q9jMDOP1eLyaXKd4ZXk(this), new EntityActionEventArgs(null, instance, r4RsHnX0otefrRotuNK()));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
					{
						num2 = 0;
					}
					continue;
				case 13:
					comment = InterfaceActivator.Create<IComment>();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					kATbIQPxkALLxZUyMy0(instance);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					p3l82LXv2ObFgvtGy8j(comment, reason);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
					{
						num2 = 6;
					}
					continue;
				case 8:
					if (reason == null)
					{
						num2 = 4;
						continue;
					}
					goto case 13;
				case 11:
					instance.Comments.Add(comment);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
					{
						num2 = 9;
					}
					continue;
				case 7:
					OkKwR7X8mANunfjAQtn(comment, user);
					num = 11;
					break;
				case 0:
					return;
				case 2:
					if (user != null)
					{
						num2 = 10;
						continue;
					}
					goto case 12;
				case 5:
					hYc4t0XJZF6PeQeDVlR(WorkflowRuntimeService, instance, reason ?? SR.T((string)PnRqCnPnwVhafkSNYwq(0x7381F16B ^ 0x73819061)));
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void TerminateEmulation(IWorkflowInstance instance, string reason = null, EleWise.ELMA.Security.Models.IUser user = null)
	{
		//Discarded unreachable code: IL_016e, IL_017d
		int num = 5;
		IComment comment = default(IComment);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					instance.TerminateUser = user;
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num2 = 6;
					}
					continue;
				case 4:
					if (!instance.IsEmulation)
					{
						num2 = 2;
						continue;
					}
					WorkflowRuntimeService.Terminate(instance, (string)(reason ?? n79c2oXmBJNUtbMcGVc(PnRqCnPnwVhafkSNYwq(-360662087 ^ -360654205))));
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
					{
						num2 = 10;
					}
					continue;
				case 8:
					return;
				case 3:
					instance.Save();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					OkKwR7X8mANunfjAQtn(comment, user);
					num2 = 12;
					continue;
				case 12:
					instance.Comments.Add(comment);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
					sZ46u9PHN5cjbV6iRHO(instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351346760));
					num2 = 4;
					continue;
				case 6:
					if (reason == null)
					{
						num2 = 9;
						continue;
					}
					goto default;
				case 1:
				case 9:
					break;
				default:
					comment = InterfaceActivator.Create<IComment>();
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
					{
						num2 = 7;
					}
					continue;
				case 7:
					p3l82LXv2ObFgvtGy8j(comment, reason);
					num2 = 11;
					continue;
				case 2:
					return;
				}
				break;
			}
			((IEntityActionHandler)q9jMDOP1eLyaXKd4ZXk(this)).ActionExecuted(new EntityActionEventArgs(null, instance, r4RsHnX0otefrRotuNK()));
			num = 8;
		}
	}

	public IList<WorkflowInstanceTimerInfo> GetActiveTimerInfos(IEnumerable<IWorkflowInstance> instanceList)
	{
		Contract.ArgumentNotNull(instanceList, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360654141));
		return GetActiveTimerInfos(instanceList, allowSubInstances: false);
	}

	public IList<WorkflowInstanceTimerInfo> GetActiveTimerInfos(IEnumerable<IWorkflowInstance> instanceList, bool allowSubInstances)
	{
		Contract.ArgumentNotNull(instanceList, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11823644));
		ICriteria val = base.Session.CreateCriteria<IResumeProcessSchedulerJob>().CreateAlias(F_ResumeJob_Task, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x62812A34), (JoinType)0).CreateAlias(F_ResumeJob_Bookmark, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x423170AE), (JoinType)0)
			.CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398715435) + F_Bookmark_Instance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122768649))
			.Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965267201) + F_SchedulerTask_Status, (object)SchedulerTaskStatus.Enabled), (ICriterion)(object)Restrictions.Eq(F_ResumeJob_OnceExecuteStatus, (object)JobStatus.Fail)));
		if (!allowSubInstances)
		{
			val.Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651F8303) + F_Bookmark_Instance, (ICollection)instanceList.ToList()));
		}
		else
		{
			ICriterion val2 = Instance.CreateChildInstancesCriterion(instanceList, startFromRoot: false, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4FD00585 ^ 0x4FD06445));
			val.Add(val2);
		}
		return val.SetProjection((IProjection[])(object)new IProjection[6]
		{
			Projections.Alias((IProjection)(object)Projections.Property(F_ResumeJob_Id), F_TimerInfo_SchedulerJobId),
			Projections.Alias((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11823872) + F_Bookmark_Instance), F_TimerInfo_Instance),
			Projections.Alias((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75BAD659 ^ 0x75BAB7C7) + F_Bookmark_ElementUid), F_TimerInfo_ElementUid),
			Projections.Alias((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EBD841) + F_SchedulerTask_CreationDate), F_TimerInfo_CreationDate),
			Projections.Alias((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x7581304) + F_SchedulerTask_ExecuteTime), F_TimerInfo_ExecuteTime),
			Projections.Alias((IProjection)(object)Projections.Property(F_ResumeJob_OnceExecuteStatus), F_ResumeJob_OnceExecuteStatus)
		}).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(WorkflowInstanceTimerInfo))).List<WorkflowInstanceTimerInfo>();
	}

	public IList<IWorkflowQueueItem> GetActiveQueueItems(IEnumerable<IWorkflowInstance> instanceList, bool allowSubInstances)
	{
		Contract.ArgumentNotNull(instanceList, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x18438165));
		ICriteria val = base.Session.CreateCriteria<IWorkflowQueueItem>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x68101A));
		if (!allowSubInstances)
		{
			val.Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495304914), (ICollection)instanceList.ToList()));
		}
		else
		{
			ICriterion val2 = CreateChildInstancesCriterion(instanceList, startFromRoot: true, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2002063381 ^ -2002088399));
			val.Add(val2);
		}
		return val.List<IWorkflowQueueItem>();
	}

	public IList<IWorkflowInstance> GetActiveInstances(IWorkflowInstance subInstance)
	{
		List<IWorkflowInstance> list = new List<IWorkflowInstance>();
		for (IWorkflowInstance workflowInstance = subInstance; workflowInstance != null; workflowInstance = workflowInstance.ParentInstance)
		{
			list.Add(workflowInstance);
		}
		return list;
	}

	public IList<IWorkflowInstance> GetActiveSubInstances(IEnumerable<IWorkflowInstance> instanceList)
	{
		Contract.ArgumentNotNull(instanceList, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x75813CC));
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq(F_Status, (object)WorkflowInstanceStatus.Running)).Add((ICriterion)(object)Restrictions.In(F_ParentInstance, (ICollection)instanceList.ToList())).List<IWorkflowInstance>();
	}

	public IList<IWorkflowInstance> GetSubInstances(IEnumerable<IWorkflowInstance> instanceList)
	{
		return GetSubInstances(instanceList, null);
	}

	public IList<IWorkflowInstance> GetSubInstances(IEnumerable<IWorkflowInstance> instanceList, IEnumerable<WorkflowInstanceStatus> statuses)
	{
		Contract.ArgumentNotNull(instanceList, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716637226));
		ICriteria val = CreateCriteria().Add((ICriterion)(object)Restrictions.In(F_ParentInstance, (ICollection)instanceList.ToList()));
		if (statuses != null)
		{
			val.Add((ICriterion)(object)Restrictions.In(F_Status, (ICollection)statuses.ToList()));
		}
		return val.List<IWorkflowInstance>();
	}

	internal ICriteria GetSubInstancesCriteria(long instanceId)
	{
		return (ICriteria)HIeIpTXb4c0rsRywMrR(CreateCriteria(), Restrictions.Eq((string)pENGXVXt07ppc90cLSH(F_ParentInstance, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1001959786)), (object)instanceId));
	}

	public List<string> BuildInstancesByEntityQueryList(IEnumerable<long> entityIds, Type entityType, ICollection<Guid> propertyUids = null, string selectValueAlias = null)
	{
		_003C_003Ec__DisplayClass60_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass60_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.entityType = entityType;
		CS_0024_003C_003E8__locals0.selectValueAlias = selectValueAlias;
		CS_0024_003C_003E8__locals0.separateBuildMode = SR.GetSetting(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431991842), defaultValue: false);
		CS_0024_003C_003E8__locals0._entityIds = entityIds.EmptyIfNull().ToArray();
		EntityMetadata entityMetadata = (EntityMetadata)MetadataLoader.LoadMetadata(CS_0024_003C_003E8__locals0.entityType);
		CS_0024_003C_003E8__locals0.metadata = (EntityMetadata)MetadataLoader.LoadMetadata(entityMetadata.ImplementationUid, inherit: true, loadImplementation: false);
		List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses(CS_0024_003C_003E8__locals0.metadata, loadImplementation: false);
		baseClasses.Add(CS_0024_003C_003E8__locals0.metadata);
		List<Guid> list = baseClasses.Select((ClassMetadata c) => c.Uid).ToList();
		if (ContextObservers.FirstOrDefault((IWorkflowContextPropertyObserver o) => o.GetAllObservedSubTypeUids().Contains(_003C_003Ec__DisplayClass60_0.vySWsqZqTVdSQW6gMUKG(CS_0024_003C_003E8__locals0.metadata))) != null)
		{
			string text = string.Empty;
			if (entityIds != null && entityIds.Any())
			{
				text += string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398715369), ElmaInExpression.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x157D5AF4 ^ 0x157D3884), entityIds, DbType.Int64, null, null, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057712125)));
			}
			if (propertyUids != null && propertyUids.Any())
			{
				text += string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667472995), ElmaInExpression.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-961162596 ^ -961171440), propertyUids.Select((Guid u) => (string)_003C_003Ec__DisplayClass60_0.s0P0nIZqkQq02BVynGUJ(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect, _003C_003Ec__DisplayClass60_0.MrUnLdZqMNy3NPVbHN8h(_003C_003Ec__DisplayClass60_0.WArygvZqQKyWorV0Nov3(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider), _003C_003Ec__DisplayClass60_0.sJWqbcZqCGxdMk4tkPon(_003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(-1600060848 ^ -1600010176), u)))), DbType.Int64, null, null, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638225214 ^ -1638210682)));
			}
			IEnumerable<string> enumerable = list.Select((Guid u) => CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect.CharToGuidFromSqlWithoutQuote((string)_003C_003Ec__DisplayClass60_0.MrUnLdZqMNy3NPVbHN8h(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect, string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x548AD1D0), u))));
			string item = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862354712), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x42317532)), TransformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x738ADE76), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F6500A)), TransformationProvider.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA735DBA), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776296328)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1108895484)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10390509)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x69063C81 ^ 0x69065811)), ElmaInExpression.ToString(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-885093259 ^ -885069615), enumerable, DbType.Int64, null, null, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105848570)), text);
			return new List<string> { item };
		}
		ICriteria val = base.Session.CreateCriteria(InterfaceActivator.TypeOf<IProcessHeader>(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -63037301)).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E9159F), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1028861977 ^ -1028871367), (JoinType)0).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712518233), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x738ADF7A), (JoinType)0)
			.Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790214504)))
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D6AC2B)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14376884)).Add((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x13F63440 ^ 0x13F65106)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790214432))
				.Add((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12F0D14)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10401481))
				.Add((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197769368)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C7F6FED ^ 0x1C7F0A57))
				.Add((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EBDC25)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614274E3 ^ 0x61421113))
				.Add((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12F0E6E)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x4231771C)) });
		if (propertyUids != null && propertyUids.Any())
		{
			val.Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360653113), (ICollection)propertyUids.ToArray()));
		}
		ComponentManager.Current.GetExtensionPoints<IFilterWorkflowInstanceCriteriaBuilder>().FirstOrDefault(delegate(IFilterWorkflowInstanceCriteriaBuilder p)
		{
			//Discarded unreachable code: IL_0099, IL_00a8, IL_00b8, IL_00c7
			int num7 = 2;
			int num8 = num7;
			while (true)
			{
				switch (num8)
				{
				case 2:
					if (_003C_003Ec__DisplayClass60_0.dHgCnAZqU9txeKCatIIP(p) != null)
					{
						num8 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
						{
							num8 = 0;
						}
						break;
					}
					goto case 5;
				case 5:
					if (p.EntityTypeUids == null)
					{
						num8 = 4;
						break;
					}
					goto default;
				case 1:
					if (_003C_003Ec__DisplayClass60_0.dHgCnAZqU9txeKCatIIP(p).IsAssignableFrom(CS_0024_003C_003E8__locals0.entityType))
					{
						num8 = 3;
						break;
					}
					goto case 5;
				default:
					return p.EntityTypeUids.Any((Guid t) => _003C_003Ec__DisplayClass60_0.NLQ4O0ZqVBnpPTSdZVWJ(t, CS_0024_003C_003E8__locals0.metadata.ImplementationUid));
				case 4:
					return false;
				case 3:
					return true;
				}
			}
		})?.GetInstancesByEntityAddCriteria(val, list);
		List<ContextVarInfo> source = val.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ContextVarInfo))).List<ContextVarInfo>().ToList();
		CS_0024_003C_003E8__locals0.joinCount = 1;
		CS_0024_003C_003E8__locals0.each = delegate(ContextVarInfo i)
		{
			//Discarded unreachable code: IL_0410, IL_0512, IL_0521, IL_0531, IL_061b, IL_062a, IL_065b, IL_0750, IL_075f, IL_076f
			int num5 = 19;
			RelationType relationType = default(RelationType);
			int joinCount = default(int);
			TableSelect tableSelect7 = default(TableSelect);
			string text2 = default(string);
			_003C_003Ec__DisplayClass60_1 _003C_003Ec__DisplayClass60_2 = default(_003C_003Ec__DisplayClass60_1);
			string text3 = default(string);
			string tableName3 = default(string);
			while (true)
			{
				int num6 = num5;
				while (true)
				{
					switch (num6)
					{
					case 14:
						if (relationType != RelationType.ManyToManyInverse)
						{
							num6 = 15;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
							{
								num6 = 4;
							}
							continue;
						}
						goto case 13;
					case 38:
						CS_0024_003C_003E8__locals0.joinCount = joinCount + 1;
						num6 = 27;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
						{
							num6 = 19;
						}
						continue;
					case 25:
					case 29:
						_003C_003Ec__DisplayClass60_0.MZAU8PZqhc0pDttMbJK2(tableSelect7, text2);
						num6 = 7;
						continue;
					case 2:
						CS_0024_003C_003E8__locals0.joinCount = joinCount + 1;
						num6 = 10;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
						{
							num6 = 8;
						}
						continue;
					case 5:
					case 10:
					case 26:
					case 27:
						if (CS_0024_003C_003E8__locals0._entityIds.Length == 1)
						{
							num6 = 16;
							continue;
						}
						goto case 3;
					case 17:
						relationType = _003C_003Ec__DisplayClass60_0.vW4dauZqI1jTKWDvw5Fa(_003C_003Ec__DisplayClass60_0.y9UmGpZqiCKJu3HvTerf(_003C_003Ec__DisplayClass60_2.i));
						num5 = 11;
						break;
					case 33:
						tableSelect7.Joins.Add(string.Format((string)_003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(0x1AF6F1F2 ^ 0x1AF43F54), _003C_003Ec__DisplayClass60_0.IYyP5KZqookKOcNDOdlw(_003C_003Ec__DisplayClass60_0.WArygvZqQKyWorV0Nov3(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider), text3), _003C_003Ec__DisplayClass60_0.m4dq9fZqGA1XXw9k30Fb(_003C_003Ec__DisplayClass60_2.i), _003C_003Ec__DisplayClass60_0.IYyP5KZqookKOcNDOdlw(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect, _003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(-1393899982 ^ -1393917772)), _003C_003Ec__DisplayClass60_0.IYyP5KZqookKOcNDOdlw(_003C_003Ec__DisplayClass60_0.WArygvZqQKyWorV0Nov3(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider), _003C_003Ec__DisplayClass60_0.fcsD3uZqAR80CAroJG0j(_003C_003Ec__DisplayClass60_2.i))));
						num6 = 15;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
						{
							num6 = 35;
						}
						continue;
					case 13:
						tableSelect7.Joins.Add((string)_003C_003Ec__DisplayClass60_0.U7tFiBZqNNZNHu8WYJBZ(_003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(0x8D5763A ^ 0x8D7B928), new object[5]
						{
							_003C_003Ec__DisplayClass60_0.Gq4AGMZqaNfcC4mMrvMe(_003C_003Ec__DisplayClass60_2.i.Settings),
							CS_0024_003C_003E8__locals0.joinCount,
							_003C_003Ec__DisplayClass60_0.IYyP5KZqookKOcNDOdlw(_003C_003Ec__DisplayClass60_0.WArygvZqQKyWorV0Nov3(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider), _003C_003Ec__DisplayClass60_0.kF49B2ZqrpVnKMaMEffw(_003C_003Ec__DisplayClass60_0.y9UmGpZqiCKJu3HvTerf(_003C_003Ec__DisplayClass60_2.i))),
							_003C_003Ec__DisplayClass60_0.IYyP5KZqookKOcNDOdlw(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect, text3),
							_003C_003Ec__DisplayClass60_0.IYyP5KZqookKOcNDOdlw(_003C_003Ec__DisplayClass60_0.WArygvZqQKyWorV0Nov3(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider), _003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(-25709590 ^ -25692820))
						}));
						num6 = 32;
						continue;
					case 19:
						_003C_003Ec__DisplayClass60_2 = new _003C_003Ec__DisplayClass60_1();
						num6 = 18;
						continue;
					case 8:
						tableSelect7.Joins.Add(string.Format((string)_003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(-43932417 ^ -43815955), _003C_003Ec__DisplayClass60_0.Gq4AGMZqaNfcC4mMrvMe(_003C_003Ec__DisplayClass60_0.y9UmGpZqiCKJu3HvTerf(_003C_003Ec__DisplayClass60_2.i)), CS_0024_003C_003E8__locals0.joinCount, _003C_003Ec__DisplayClass60_0.IYyP5KZqookKOcNDOdlw(_003C_003Ec__DisplayClass60_0.WArygvZqQKyWorV0Nov3(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider), ((EntitySettings)_003C_003Ec__DisplayClass60_0.y9UmGpZqiCKJu3HvTerf(_003C_003Ec__DisplayClass60_2.i)).ParentColumnName), _003C_003Ec__DisplayClass60_0.IYyP5KZqookKOcNDOdlw(_003C_003Ec__DisplayClass60_0.WArygvZqQKyWorV0Nov3(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider), text3), _003C_003Ec__DisplayClass60_0.IYyP5KZqookKOcNDOdlw(_003C_003Ec__DisplayClass60_0.WArygvZqQKyWorV0Nov3(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider), _003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(-495296780 ^ -495314830))));
						num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
						{
							num6 = 0;
						}
						continue;
					case 34:
						text3 = (string)_003C_003Ec__DisplayClass60_0.ztQ9dmZq7Ccrn7G1qaCp(_003C_003Ec__DisplayClass60_2.i.ContextName, _003C_003Ec__DisplayClass60_0.m4dq9fZqGA1XXw9k30Fb(_003C_003Ec__DisplayClass60_2.i));
						num6 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
						{
							num6 = 23;
						}
						continue;
					case 30:
						if (_003C_003Ec__DisplayClass60_2.i.TableNumber <= 0)
						{
							num6 = 6;
							continue;
						}
						goto case 21;
					default:
						text2 = (string)_003C_003Ec__DisplayClass60_0.xTfoCLZqefDmDrnAewX0(_003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(0x13F63440 ^ 0x13F4FBC2), CS_0024_003C_003E8__locals0.joinCount, ((Dialect)_003C_003Ec__DisplayClass60_0.WArygvZqQKyWorV0Nov3(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider)).QuoteIfNeeded((string)_003C_003Ec__DisplayClass60_0.kF49B2ZqrpVnKMaMEffw(_003C_003Ec__DisplayClass60_0.y9UmGpZqiCKJu3HvTerf(_003C_003Ec__DisplayClass60_2.i))));
						num6 = 28;
						continue;
					case 32:
						text2 = (string)_003C_003Ec__DisplayClass60_0.xTfoCLZqefDmDrnAewX0(_003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(-683713632 ^ -683830238), CS_0024_003C_003E8__locals0.joinCount, ((Dialect)_003C_003Ec__DisplayClass60_0.WArygvZqQKyWorV0Nov3(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider)).QuoteIfNeeded((string)_003C_003Ec__DisplayClass60_0.AmwRJSZqxbvykOgVtQaX(_003C_003Ec__DisplayClass60_0.y9UmGpZqiCKJu3HvTerf(_003C_003Ec__DisplayClass60_2.i))));
						num5 = 20;
						break;
					case 3:
						if (CS_0024_003C_003E8__locals0._entityIds.Length != 0)
						{
							num6 = 24;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
							{
								num6 = 17;
							}
							continue;
						}
						goto case 25;
					case 7:
						return tableSelect7;
					case 4:
					case 6:
					case 36:
						if (_003C_003Ec__DisplayClass60_0.y9UmGpZqiCKJu3HvTerf(_003C_003Ec__DisplayClass60_2.i) == null)
						{
							num6 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 != 0)
							{
								num6 = 1;
							}
							continue;
						}
						goto case 17;
					case 21:
						if (!tableSelect7.ChildJoins.All(_003C_003Ec__DisplayClass60_2._003CBuildInstancesByEntityQueryList_003Eb__10))
						{
							num6 = 35;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
							{
								num6 = 36;
							}
							continue;
						}
						goto case 33;
					case 12:
						text3 = (string)_003C_003Ec__DisplayClass60_0.Ud0LCbZqFcd9eAiu7g1K(_003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(-1108877388 ^ -1109061454), _003C_003Ec__DisplayClass60_0.m4dq9fZqGA1XXw9k30Fb(_003C_003Ec__DisplayClass60_2.i));
						num6 = 4;
						continue;
					case 16:
						tableSelect7.Clauses.Add((string)_003C_003Ec__DisplayClass60_0.xTfoCLZqefDmDrnAewX0(_003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(0x157D5AF4 ^ 0x157D0ECE), text2, CS_0024_003C_003E8__locals0._entityIds[0]));
						num6 = 29;
						continue;
					case 28:
						joinCount = CS_0024_003C_003E8__locals0.joinCount;
						num6 = 38;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
						{
							num6 = 29;
						}
						continue;
					case 35:
						tableSelect7.ChildJoins.Add(_003C_003Ec__DisplayClass60_0.m4dq9fZqGA1XXw9k30Fb(_003C_003Ec__DisplayClass60_2.i));
						num6 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
						{
							num6 = 12;
						}
						continue;
					case 18:
						_003C_003Ec__DisplayClass60_2.i = i;
						num6 = 37;
						continue;
					case 11:
						if (relationType != RelationType.ManyToMany)
						{
							num6 = 14;
							continue;
						}
						goto case 8;
					case 24:
						tableSelect7.Clauses.Add(ElmaInExpression.ToString(text2, CS_0024_003C_003E8__locals0._entityIds, DbType.Int64, null, null, (string)_003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(-39189604 ^ -39171368)));
						num6 = 25;
						continue;
					case 23:
						_003C_003Ec__DisplayClass60_0.qdOKR1Zq2d8L7CPGYy7n(tableSelect7, tableName3);
						num6 = 30;
						continue;
					case 22:
						tableName3 = EntityPropertyMetadata.GetTableName((string)_003C_003Ec__DisplayClass60_0.fcsD3uZqAR80CAroJG0j(_003C_003Ec__DisplayClass60_2.i), 0);
						num6 = 34;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
						{
							num6 = 4;
						}
						continue;
					case 20:
						joinCount = CS_0024_003C_003E8__locals0.joinCount;
						num6 = 2;
						continue;
					case 37:
						tableSelect7 = new TableSelect();
						num6 = 22;
						continue;
					case 15:
					case 31:
						text2 = string.Format((string)_003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(-947937941 ^ -947976129), (_003C_003Ec__DisplayClass60_0.m4dq9fZqGA1XXw9k30Fb(_003C_003Ec__DisplayClass60_2.i) > 0) ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70E97655), _003C_003Ec__DisplayClass60_0.m4dq9fZqGA1XXw9k30Fb(_003C_003Ec__DisplayClass60_2.i)) : "", _003C_003Ec__DisplayClass60_0.IYyP5KZqookKOcNDOdlw(_003C_003Ec__DisplayClass60_0.WArygvZqQKyWorV0Nov3(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider), _003C_003Ec__DisplayClass60_0.Y6n64CZqSSH43mPZynTR(_003C_003Ec__DisplayClass60_0.y9UmGpZqiCKJu3HvTerf(_003C_003Ec__DisplayClass60_2.i))));
						num6 = 26;
						continue;
					case 1:
					case 9:
						text2 = (string)_003C_003Ec__DisplayClass60_0.xTfoCLZqefDmDrnAewX0(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x494376B0), (_003C_003Ec__DisplayClass60_2.i.TableNumber > 0) ? _003C_003Ec__DisplayClass60_0.sJWqbcZqCGxdMk4tkPon(_003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(-1712492721 ^ -1712348951), _003C_003Ec__DisplayClass60_0.m4dq9fZqGA1XXw9k30Fb(_003C_003Ec__DisplayClass60_2.i)) : "", _003C_003Ec__DisplayClass60_0.IYyP5KZqookKOcNDOdlw(CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect, _003C_003Ec__DisplayClass60_0.dAdtjMZq1Tv415lY3GEp(_003C_003Ec__DisplayClass60_2.i)));
						num6 = 5;
						continue;
					}
					break;
				}
			}
		};
		CS_0024_003C_003E8__locals0.eachSeparateMode = delegate(ContextVarInfo i)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass60_2();
			CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = CS_0024_003C_003E8__locals0;
			CS_0024_003C_003E8__locals0.i = i;
			CS_0024_003C_003E8__locals0.res = new List<TableSelect>();
			Func<ContextVarInfo, TableSelect> func = delegate(ContextVarInfo info)
			{
				int num3 = 5;
				TableSelect tableSelect5 = default(TableSelect);
				string tableName2 = default(string);
				_003C_003Ec__DisplayClass60_3 _003C_003Ec__DisplayClass60_ = default(_003C_003Ec__DisplayClass60_3);
				string tableName = default(string);
				while (true)
				{
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							CS_0024_003C_003E8__locals0.res.Add(tableSelect5);
							num4 = 6;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
							{
								num4 = 2;
							}
							continue;
						case 2:
							tableName2 = EntityPropertyMetadata.GetTableName((string)_003C_003Ec__DisplayClass60_2.wtg267Z3v8bdAJq5pwbX(CS_0024_003C_003E8__locals0.i), 0);
							num4 = 7;
							continue;
						case 6:
							return tableSelect5;
						case 10:
							tableSelect5.ChildJoins.Add(_003C_003Ec__DisplayClass60_2.t3DwqeZ3YfIJspqM5Luo(_003C_003Ec__DisplayClass60_.info));
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
							{
								num4 = 0;
							}
							continue;
						case 5:
							_003C_003Ec__DisplayClass60_ = new _003C_003Ec__DisplayClass60_3();
							num3 = 4;
							break;
						case 4:
							_003C_003Ec__DisplayClass60_.info = info;
							num4 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
							{
								num4 = 1;
							}
							continue;
						case 3:
							if (tableSelect5.ChildJoins.All(_003C_003Ec__DisplayClass60_._003CBuildInstancesByEntityQueryList_003Eb__13))
							{
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
								{
									num4 = 1;
								}
								continue;
							}
							goto default;
						case 9:
						{
							TableSelect tableSelect6 = new TableSelect();
							_003C_003Ec__DisplayClass60_2.Q68uXZZ38AQwVTBbnwQU(tableSelect6, tableName2);
							tableSelect5 = tableSelect6;
							num4 = 8;
							continue;
						}
						case 7:
							tableName = EntityPropertyMetadata.GetTableName((string)_003C_003Ec__DisplayClass60_2.wtg267Z3v8bdAJq5pwbX(_003C_003Ec__DisplayClass60_.info), _003C_003Ec__DisplayClass60_2.t3DwqeZ3YfIJspqM5Luo(_003C_003Ec__DisplayClass60_.info));
							num3 = 9;
							break;
						case 8:
							if (_003C_003Ec__DisplayClass60_2.t3DwqeZ3YfIJspqM5Luo(CS_0024_003C_003E8__locals0.i) > 0)
							{
								num4 = 3;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
								{
									num4 = 3;
								}
								continue;
							}
							goto default;
						case 1:
							tableSelect5.Joins.Add(string.Format((string)_003C_003Ec__DisplayClass60_2.z2eiAGZ3sHP9f0jlL0y9(0x70EBB9F3 ^ 0x70E97755), _003C_003Ec__DisplayClass60_2.Pxt2c3Z3JoMusyMHuKyv(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.TransformationProvider.Dialect, tableName), _003C_003Ec__DisplayClass60_.info.TableNumber, _003C_003Ec__DisplayClass60_2.Pxt2c3Z3JoMusyMHuKyv(_003C_003Ec__DisplayClass60_2.cuPUMdZ3lDZqVgiY1Npt(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.TransformationProvider), _003C_003Ec__DisplayClass60_2.z2eiAGZ3sHP9f0jlL0y9(-1638225214 ^ -1638208444)), _003C_003Ec__DisplayClass60_2.Pxt2c3Z3JoMusyMHuKyv(_003C_003Ec__DisplayClass60_2.cuPUMdZ3lDZqVgiY1Npt(CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1._003C_003E4__this.TransformationProvider), _003C_003Ec__DisplayClass60_2.wtg267Z3v8bdAJq5pwbX(_003C_003Ec__DisplayClass60_.info))));
							num4 = 10;
							continue;
						}
						break;
					}
				}
			};
			Func<string, TableSelect, bool> func2 = delegate(string prop, TableSelect table)
			{
				//Discarded unreachable code: IL_0104, IL_0113
				int num = 2;
				while (true)
				{
					int num2 = num;
					while (true)
					{
						switch (num2)
						{
						default:
							if (CS_0024_003C_003E8__locals0._entityIds.Length != 0)
							{
								num2 = 5;
								continue;
							}
							goto case 3;
						case 2:
							if (CS_0024_003C_003E8__locals0._entityIds.Length == 1)
							{
								num2 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
								{
									num2 = 0;
								}
								continue;
							}
							goto default;
						case 1:
							table.Clauses.Add((string)_003C_003Ec__DisplayClass60_0.xTfoCLZqefDmDrnAewX0(_003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(0x34EA50D4 ^ 0x34EA04EE), prop, CS_0024_003C_003E8__locals0._entityIds[0]));
							num = 4;
							break;
						case 5:
							table.Clauses.Add(ElmaInExpression.ToString(prop, CS_0024_003C_003E8__locals0._entityIds, DbType.Int64, null, null, (string)_003C_003Ec__DisplayClass60_0.uOHPhWZqpTobu1EOwsPb(0x1927DA93 ^ 0x192793D7)));
							num = 3;
							break;
						case 3:
						case 4:
							return true;
						}
						break;
					}
				}
			};
			if (CS_0024_003C_003E8__locals0.i.Settings != null)
			{
				switch (CS_0024_003C_003E8__locals0.i.Settings.RelationType)
				{
				case RelationType.ManyToMany:
				{
					TableSelect tableSelect3 = func(CS_0024_003C_003E8__locals0.i);
					tableSelect3.Joins.Add(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862245036), CS_0024_003C_003E8__locals0.i.Settings.RelationTableName, CS_0024_003C_003E8__locals0.joinCount, CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect.QuoteIfNeeded(CS_0024_003C_003E8__locals0.i.Settings.ParentColumnName), CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect.QuoteIfNeeded(tableSelect3.TableName), CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EBFF75))));
					tableSelect3.Property = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B539A6), CS_0024_003C_003E8__locals0.joinCount, CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect.QuoteIfNeeded(CS_0024_003C_003E8__locals0.i.Settings.ChildColumnName));
					func2(tableSelect3.Property, tableSelect3);
					CS_0024_003C_003E8__locals0.joinCount++;
					break;
				}
				case RelationType.ManyToManyInverse:
				{
					TableSelect tableSelect2 = func(CS_0024_003C_003E8__locals0.i);
					tableSelect2.Joins.Add(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5BCD23A0 ^ 0x5BCFECB2), CS_0024_003C_003E8__locals0.i.Settings.RelationTableName, CS_0024_003C_003E8__locals0.joinCount, CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect.QuoteIfNeeded(CS_0024_003C_003E8__locals0.i.Settings.ChildColumnName), CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect.QuoteIfNeeded(tableSelect2.TableName), CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA737F68))));
					tableSelect2.Property = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D6863D), CS_0024_003C_003E8__locals0.joinCount, CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect.QuoteIfNeeded(CS_0024_003C_003E8__locals0.i.Settings.ParentColumnName));
					func2(tableSelect2.Property, tableSelect2);
					CS_0024_003C_003E8__locals0.joinCount++;
					break;
				}
				default:
				{
					TableSelect tableSelect = func(CS_0024_003C_003E8__locals0.i);
					tableSelect.Property = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x6281F2EA), (CS_0024_003C_003E8__locals0.i.TableNumber > 0) ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514313864), CS_0024_003C_003E8__locals0.i.TableNumber) : "", CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect.QuoteIfNeeded(CS_0024_003C_003E8__locals0.i.Settings.FieldName));
					func2(tableSelect.Property, tableSelect);
					break;
				}
				}
			}
			else
			{
				TableSelect tableSelect4 = func(CS_0024_003C_003E8__locals0.i);
				tableSelect4.Property = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716599304), (CS_0024_003C_003E8__locals0.i.TableNumber > 0) ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-261315199 ^ -261199321), CS_0024_003C_003E8__locals0.i.TableNumber) : "", CS_0024_003C_003E8__locals0._003C_003E4__this.TransformationProvider.Dialect.QuoteIfNeeded(CS_0024_003C_003E8__locals0.i.PropertyName));
				func2(tableSelect4.Property, tableSelect4);
			}
			return CS_0024_003C_003E8__locals0.res;
		};
		CS_0024_003C_003E8__locals0.queryList = new List<string>();
		(from k in source
			group k by new { k.ProcessHeaderId, k.ContextName }).ToList().ForEach(gi =>
		{
			foreach (TableSelect item2 in CS_0024_003C_003E8__locals0.separateBuildMode ? gi.ToList().SelectMany((ContextVarInfo i) => CS_0024_003C_003E8__locals0.eachSeparateMode(i)) : (from i in gi.ToList()
				select CS_0024_003C_003E8__locals0.each(i)))
			{
				CS_0024_003C_003E8__locals0.queryList.Add(item2.GetSql(CS_0024_003C_003E8__locals0.selectValueAlias));
			}
		});
		return CS_0024_003C_003E8__locals0.queryList;
	}

	public List<string> BuildInstancesByEntityQueryList(IEntity<long> entity)
	{
		return BuildInstancesByEntityQueryList(new long[1] { entity.Id }, entity.CastAsRealType().GetType());
	}

	private ICriterion InstancesByEntityCriterion(IEntity<long> entity)
	{
		List<string> list = BuildInstancesByEntityQueryList(entity);
		if (list.Count == 0)
		{
			return null;
		}
		return (ICriterion)(object)NHQueryExtensions.Sql(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACCBBB9), string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657591227), list)));
	}

	public long GetInstancesByEntityCount(IEntity<long> entity, IEnumerable<WorkflowInstanceStatus> statuses = null)
	{
		ICriterion val = InstancesByEntityCriterion(entity);
		if (val == null)
		{
			return 0L;
		}
		ICriteria val2 = CreateCriteria();
		val2.Add(val);
		val2.Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA737F2E), (ICollection)((statuses != null) ? statuses.ToArray() : new WorkflowInstanceStatus[1] { WorkflowInstanceStatus.Running })));
		return ReturnCount(val2);
	}

	public IEnumerable<IWorkflowInstance> GetInstancesByEntity(IEntity<long> entity, FetchOptions fetchOptions = null, IEnumerable<WorkflowInstanceStatus> statuses = null)
	{
		ICriterion val = InstancesByEntityCriterion(entity);
		if (val == null)
		{
			return new List<IWorkflowInstance>();
		}
		ICriteria val2 = CreateCriteria(fetchOptions, base.ImplementationType);
		val2.Add(val);
		val2.Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37E97159 ^ 0x37E93799), (ICollection)((statuses != null) ? statuses.ToArray() : new WorkflowInstanceStatus[1] { WorkflowInstanceStatus.Running })));
		return Find(val2);
	}

	public void CloseTimer(IResumeProcessSchedulerJob job)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				sZ46u9PHN5cjbV6iRHO(job, PnRqCnPnwVhafkSNYwq(-1214182792 ^ -1214165466));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Contract.ArgumentNotNull(YRSof7X5Y4PlJ1H1sT1(job), (string)PnRqCnPnwVhafkSNYwq(0x34EA50D4 ^ 0x34EA36A6));
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				xCk7SfXgM3VdHrIbjxt(Locator.GetServiceNotNull<SchedulerTaskManager>(), YRSof7X5Y4PlJ1H1sT1(job));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[Transaction]
	public virtual void ChangeTimer(IResumeProcessSchedulerJob job, DateTime time)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				job.Task.OnceExecuteTime = time;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				sZ46u9PHN5cjbV6iRHO(job, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x69063C81 ^ 0x690678DF));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			case 4:
				((IEntity)YRSof7X5Y4PlJ1H1sT1(job)).Save();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				sZ46u9PHN5cjbV6iRHO(job.Task, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514156372));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void SaveSwimlaneExecutor(IWorkflowInstance instance, SwimlaneElement swimlane, EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_0091, IL_0124, IL_0133, IL_021a, IL_02a9, IL_02b8, IL_02c3, IL_0316, IL_0325, IL_03d2, IL_03e5, IL_0422, IL_0455, IL_04c3, IL_04d2, IL_0593, IL_05a2
		int num = 27;
		_003C_003Ec__DisplayClass68_0 _003C_003Ec__DisplayClass68_ = default(_003C_003Ec__DisplayClass68_0);
		IWorkflowSwimlaneExecutor workflowSwimlaneExecutor = default(IWorkflowSwimlaneExecutor);
		bool flag = default(bool);
		List<IWorkflowSwimlaneExecutor>.Enumerator enumerator = default(List<IWorkflowSwimlaneExecutor>.Enumerator);
		IWorkflowSwimlaneExecutor current = default(IWorkflowSwimlaneExecutor);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 18:
					return;
				case 3:
					if (WiGOVqXuRX4SiRJSxsj(dyfypyXdyki8uDyAe7s(_003C_003Ec__DisplayClass68_.swimlane), Guid.Empty))
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto default;
				case 14:
					instance.SwimlaneExecutors.Add(workflowSwimlaneExecutor);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
					{
						num2 = 7;
					}
					continue;
				case 8:
					if (flag)
					{
						num2 = 5;
						continue;
					}
					goto case 1;
				case 23:
				{
					if (_003C_003Ec__DisplayClass68_.swimlane == null)
					{
						num2 = 15;
						continue;
					}
					List<IWorkflowSwimlaneExecutor> list = ((IEnumerable<IWorkflowSwimlaneExecutor>)instance.SwimlaneExecutors).Where(_003C_003Ec__DisplayClass68_._003CSaveSwimlaneExecutor_003Eb__0).ToList();
					flag = false;
					enumerator = list.GetEnumerator();
					num2 = 17;
					continue;
				}
				case 6:
					if (!mejKXvXLD35pmTIcvka(_003C_003Ec__DisplayClass68_.swimlane))
					{
						num2 = 18;
						continue;
					}
					goto case 13;
				case 4:
					workflowSwimlaneExecutor.WorkflowInstance = instance;
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
					{
						num2 = 20;
					}
					continue;
				case 12:
					return;
				case 24:
					return;
				case 25:
					sZ46u9PHN5cjbV6iRHO(instance, PnRqCnPnwVhafkSNYwq(-1498811449 ^ -1498830143));
					num = 21;
					break;
				case 27:
					_003C_003Ec__DisplayClass68_ = new _003C_003Ec__DisplayClass68_0();
					num2 = 26;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
					{
						num2 = 26;
					}
					continue;
				case 19:
					ChangeResponsible(instance, user, NYgt8oX959LEl0ihRpt(_003C_003Ec__DisplayClass68_.swimlane));
					num2 = 12;
					continue;
				case 21:
					TPLJ5XXBm796FMwGLsU(WorkflowRuntimeService, PnRqCnPnwVhafkSNYwq(0x65B7F624 ^ 0x65B7B25E));
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
					{
						num2 = 23;
					}
					continue;
				default:
					if (user == null)
					{
						num2 = 24;
						continue;
					}
					goto case 11;
				case 11:
					if (wow7LmXHmq16PxDMXwP(_003C_003Ec__DisplayClass68_.swimlane) == SwimlaneType.BusinessRole)
					{
						return;
					}
					num2 = 6;
					continue;
				case 5:
				case 7:
					if (user == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 3;
				case 20:
					z1me7xXX3P17WY0KXY2(workflowSwimlaneExecutor, user);
					num2 = 2;
					continue;
				case 10:
					kATbIQPxkALLxZUyMy0(workflowSwimlaneExecutor);
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
					{
						num2 = 1;
					}
					continue;
				case 17:
					try
					{
						while (true)
						{
							IL_0390:
							int num5;
							if (!enumerator.MoveNext())
							{
								num5 = 5;
								goto IL_02c7;
							}
							goto IL_02fe;
							IL_02c7:
							while (true)
							{
								switch (num5)
								{
								case 1:
									flag = true;
									num5 = 7;
									continue;
								case 2:
									((ICollection<IWorkflowSwimlaneExecutor>)instance.SwimlaneExecutors).Remove(current);
									num5 = 6;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
									{
										num5 = 0;
									}
									continue;
								case 3:
									if (tJJJQWXcJx6mQFQo781(current) == user)
									{
										num5 = 1;
										if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
										{
											num5 = 0;
										}
										continue;
									}
									goto case 2;
								case 6:
									xUPO1YXP5TLWa2kiyl0(current);
									num5 = 4;
									continue;
								case 4:
								case 7:
									goto IL_0390;
								case 5:
									goto end_IL_0390;
								}
								break;
							}
							goto IL_02fe;
							IL_02fe:
							current = enumerator.Current;
							num5 = 3;
							goto IL_02c7;
							continue;
							end_IL_0390:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num6 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
						{
							num6 = 0;
						}
						switch (num6)
						{
						case 0:
							break;
						}
					}
					goto case 8;
				case 16:
					try
					{
						vaAgUnXD98Nw8rh109a(instance.Context, dyfypyXdyki8uDyAe7s(_003C_003Ec__DisplayClass68_.swimlane), user);
						int num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								base.Logger.Error(uIgYbUXniq6TSJdxvji(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F0A324), _003C_003Ec__DisplayClass68_.swimlane.Name, instance.Id), exception);
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
								{
									num4 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto default;
				case 1:
					if (user != null)
					{
						num = 22;
						break;
					}
					goto case 5;
				case 13:
					if (JDQp0NXfKKGQuxsMuZ5(instance) == user)
					{
						return;
					}
					num2 = 19;
					continue;
				case 26:
					_003C_003Ec__DisplayClass68_.swimlane = swimlane;
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
					{
						num2 = 25;
					}
					continue;
				case 22:
					workflowSwimlaneExecutor = InterfaceActivator.Create<IWorkflowSwimlaneExecutor>();
					num2 = 4;
					continue;
				case 15:
					return;
				case 2:
					workflowSwimlaneExecutor.SwimlaneUid = _003C_003Ec__DisplayClass68_.swimlane.Uid;
					num2 = 10;
					continue;
				}
				break;
			}
		}
	}

	public ICriterion CreateChildInstancesCriterion(IEnumerable<IWorkflowInstance> instanceList, bool startFromRoot, string instanceIdPropertyPath)
	{
		_003C_003Ec__DisplayClass69_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass69_0();
		CS_0024_003C_003E8__locals0.startFromRoot = startFromRoot;
		CS_0024_003C_003E8__locals0.instanceIdPropertyPath = instanceIdPropertyPath;
		long[] array = instanceList.Select(delegate(IWorkflowInstance i)
		{
			//Discarded unreachable code: IL_006a, IL_0079, IL_00d2, IL_00e1, IL_00f9
			int num = 1;
			int num2 = num;
			IWorkflowInstance workflowInstance = default(IWorkflowInstance);
			while (true)
			{
				switch (num2)
				{
				case 2:
				case 4:
					if (_003C_003Ec__DisplayClass69_0.OmQPxMZ3uI2D2ROZyR8W(workflowInstance) != null)
					{
						num2 = 7;
						continue;
					}
					break;
				case 5:
				case 7:
					workflowInstance = (IWorkflowInstance)_003C_003Ec__DisplayClass69_0.OmQPxMZ3uI2D2ROZyR8W(workflowInstance);
					num2 = 4;
					continue;
				case 6:
					return i.Id;
				default:
					workflowInstance = i;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (CS_0024_003C_003E8__locals0.startFromRoot)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 3:
					break;
				}
				break;
			}
			return workflowInstance.Id;
		}).ToArray();
		if (array.Length == 0)
		{
			return (ICriterion)(object)new CustomSQLCriterion(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1361027861), new long[1].Cast<object>().ToArray(), (IType[])(object)new IType[1] { (IType)NHibernateUtil.Int64 }, (SqlString sql, ICriteria c, ICriteriaQuery criteriaQuery) => sql.Replace((string)_003C_003Ec__DisplayClass69_0.GdAjthZ3H7BGHeYpP3Tl(0x37E97159 ^ 0x37EBBEE3), (string)((object[])_003C_003Ec__DisplayClass69_0.mj18BxZ3Dqefkxtpc4jk(criteriaQuery, c, CS_0024_003C_003E8__locals0.instanceIdPropertyPath))[0]));
		}
		string format = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34EA37FC);
		object[] obj = new object[4]
		{
			TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--727842433 ^ 0x2B619A8B)),
			TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516545602)),
			TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657599339)),
			null
		};
		string separator = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895834453);
		IEnumerable<string> values;
		if (array.Length == 0)
		{
			IEnumerable<string> enumerable = new string[1] { SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39164918) };
			values = enumerable;
		}
		else
		{
			values = array.Select((long i) => (string)_003C_003Ec.iXbCWbZ6xcb5KwQTuYE3(--601115071 ^ 0x23D42E29));
		}
		obj[3] = string.Join(separator, values);
		string sql2 = string.Format(format, obj);
		object[] values2 = array.Cast<object>().ToArray();
		IType[] types = (IType[])(object)array.Select((long i) => NHibernateUtil.Int64).ToArray();
		return (ICriterion)(object)new CustomSQLCriterion(sql2, values2, types, (SqlString sql, ICriteria c, ICriteriaQuery criteriaQuery) => (SqlString)_003C_003Ec__DisplayClass69_0.e0mxtuZ3n2FoewTE8JAk(sql, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667580805), ((object[])_003C_003Ec__DisplayClass69_0.mj18BxZ3Dqefkxtpc4jk(criteriaQuery, c, CS_0024_003C_003E8__locals0.instanceIdPropertyPath))[0]));
	}

	public ICriterion CreateChildInstancesCriterion(long header, bool startFromRoot, string instanceIdPropertyPath)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass70_0 _003C_003Ec__DisplayClass70_ = default(_003C_003Ec__DisplayClass70_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (ICriterion)(object)new CustomSQLCriterion((string)ppSrVpXRt4pkCJRUWMo(PnRqCnPnwVhafkSNYwq(-1776305410 ^ -1776296606), new object[8]
				{
					mX8V1eXWPogSGTl8pfj(TransformationProvider.Dialect, PnRqCnPnwVhafkSNYwq(--1436248540 ^ 0x559B0DD6)),
					mX8V1eXWPogSGTl8pfj(TransformationProvider.Dialect, PnRqCnPnwVhafkSNYwq(-1430645277 ^ -1430621769)),
					mX8V1eXWPogSGTl8pfj(j1KtReXjetb6lr7wSZn(TransformationProvider), PnRqCnPnwVhafkSNYwq(0x42311138 ^ 0x42315788)),
					mX8V1eXWPogSGTl8pfj(j1KtReXjetb6lr7wSZn(TransformationProvider), PnRqCnPnwVhafkSNYwq(0x2F44D93A ^ 0x2F448190)),
					mX8V1eXWPogSGTl8pfj(TransformationProvider.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2269BD32 ^ 0x2269E30A)),
					mX8V1eXWPogSGTl8pfj(j1KtReXjetb6lr7wSZn(TransformationProvider), PnRqCnPnwVhafkSNYwq(-2057730233 ^ -2057715263)),
					mX8V1eXWPogSGTl8pfj(j1KtReXjetb6lr7wSZn(TransformationProvider), PnRqCnPnwVhafkSNYwq(-105863102 ^ -105844922)),
					TransformationProvider.Dialect.QuoteIfNeeded((string)PnRqCnPnwVhafkSNYwq(0x651FE29D ^ 0x651F8A0B))
				}), new object[1] { header }, (IType[])(object)new IType[1] { (IType)NHibernateUtil.Int64 }, _003C_003Ec__DisplayClass70_._003CCreateChildInstancesCriterion_003Eb__0);
			default:
				_003C_003Ec__DisplayClass70_.instanceIdPropertyPath = instanceIdPropertyPath;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass70_ = new _003C_003Ec__DisplayClass70_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IWorkflowInstanceFilter ExtractWorkflowInstanceFilter(long filterId)
	{
		//Discarded unreachable code: IL_0095, IL_00a4
		int num = 2;
		int num2 = num;
		IFilter filter = default(IFilter);
		while (true)
		{
			switch (num2)
			{
			default:
				return (IWorkflowInstanceFilter)H8Y7evXqD7qQYhtWoZJ(n3muwoX6QYLYieTM4AV(filter), null, null, null);
			case 3:
				return null;
			case 1:
				if (n3muwoX6QYLYieTM4AV(filter) == null)
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 2:
				filter = Locator.GetServiceNotNull<FilterManager>().Load(filterId);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public List<StatusInfo> GetInstanceCountByStatus(long headerId, long? filterId)
	{
		Filter contextFilter;
		return GetInstanceCountByStatus(headerId, filterId, out contextFilter);
	}

	public List<StatusInfo> GetInstanceCountByStatus(long headerId, long? filterId, out Filter contextFilter)
	{
		IWorkflowInstanceFilter filter = null;
		if (filterId.HasValue)
		{
			filter = ExtractWorkflowInstanceFilter(filterId.Value);
		}
		return GetInstanceCountByStatus(headerId, filter, out contextFilter);
	}

	public List<StatusInfo> GetInstanceCountByStatus(long headerId, IWorkflowInstanceFilter filter, out Filter contextFilter)
	{
		IProcessHeader processHeader = ProcessHeaderManager.Instance.Load(headerId);
		if (filter == null)
		{
			filter = InterfaceActivator.Create<IWorkflowInstanceFilter>();
			filter.ProcessHeader = processHeader;
		}
		filter.IsEmulation = false;
		if (filter.ContextFilter == null && processHeader.Published != null)
		{
			Type instanceContextFilterType = Locator.GetServiceNotNull<WorkflowInstanceContextService>().GetInstanceContextFilterType(processHeader.Published);
			if (instanceContextFilterType != null)
			{
				filter.ContextFilter = (Filter)InterfaceActivator.Create(instanceContextFilterType);
			}
		}
		contextFilter = filter.ContextFilter;
		ICriteria val = CreateContextFilterCriteria(filter, FetchOptions.All);
		SetupFilter(val, filter);
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.GroupProperty(AliasProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431982818))), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x246EEF98 ^ 0x246E873E)).Add((IProjection)(object)Projections.CountDistinct(AliasProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12F2EEC))), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862353166)) });
		return val.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(StatusInfo))).List<StatusInfo>().ToList();
	}

	public List<StatusInfo> GetInstanceCountByStatus(long headerId)
	{
		return GetInstanceCountByStatus(headerId, null);
	}

	public List<CustomStatusInfo> GetInstanceCountByCustomStatus(IProcessHeader header, long? filterId, out Filter contextFilter)
	{
		IWorkflowInstanceFilter filter = null;
		if (filterId.HasValue)
		{
			filter = ExtractWorkflowInstanceFilter(filterId.Value);
		}
		return GetInstanceCountByCustomStatus(header, filter, out contextFilter);
	}

	public List<CustomStatusInfo> GetInstanceCountByCustomStatus(IProcessHeader header, IWorkflowInstanceFilter filter, out Filter contextFilter)
	{
		_003C_003Ec__DisplayClass77_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass77_0();
		CS_0024_003C_003E8__locals0.header = header;
		contextFilter = null;
		if (CS_0024_003C_003E8__locals0.header.Published == null || CS_0024_003C_003E8__locals0.header.Published.StatusContextVar == Guid.Empty)
		{
			return new List<CustomStatusInfo>();
		}
		PropertyMetadata propertyMetadata = ((EntityMetadata)MetadataLoader.LoadMetadata(WorkflowInstanceContextService.GetFullInstanceContextType(CS_0024_003C_003E8__locals0.header))).Properties.FirstOrDefault((PropertyMetadata p) => _003C_003Ec__DisplayClass77_0.RSaU9bZ3piDQh5h3sxH2(_003C_003Ec__DisplayClass77_0.nVQ1BsZ3TiYsP8FmCWBy(p), _003C_003Ec__DisplayClass77_0.bjvjHhZ3QbtdHyJlu4Wn(CS_0024_003C_003E8__locals0.header.Published)));
		if (propertyMetadata == null)
		{
			return new List<CustomStatusInfo>();
		}
		if (filter == null)
		{
			filter = InterfaceActivator.Create<IWorkflowInstanceFilter>();
			filter.ProcessHeader = CS_0024_003C_003E8__locals0.header;
		}
		filter.IsEmulation = false;
		if (filter.ContextFilter == null)
		{
			Type instanceContextFilterType = Locator.GetServiceNotNull<WorkflowInstanceContextService>().GetInstanceContextFilterType(CS_0024_003C_003E8__locals0.header.Published);
			if (!(instanceContextFilterType != null))
			{
				return new List<CustomStatusInfo>();
			}
			filter.ContextFilter = (Filter)InterfaceActivator.Create(instanceContextFilterType);
		}
		contextFilter = filter.ContextFilter;
		if (filter.ContextFilter.GetType().GetReflectionProperty(propertyMetadata.Name) == null)
		{
			return new List<CustomStatusInfo>();
		}
		ICriteria val = CreateContextFilterCriteria(filter, FetchOptions.All);
		SetupFilter(val, filter);
		PropertyProjection val2 = Projections.Property(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790215354), propertyMetadata.Name));
		IProjection obj;
		if (!(base.MainDatabaseProvider is NHProvider nHProvider))
		{
			IProjection val3 = (IProjection)(object)val2;
			obj = val3;
		}
		else
		{
			obj = nHProvider.GenerateComparableStringProjection((IProjection)(object)val2);
		}
		IProjection val4 = obj;
		val.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.GroupProperty(val4), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -540004939)).Add((IProjection)(object)Projections.CountDistinct(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A69AD2B), DefaultCriteriaAlias)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-961162596 ^ -961168856)) });
		List<CustomStatusInfo> list = new List<CustomStatusInfo>();
		try
		{
			foreach (object[] item in val.List<object[]>())
			{
				list.Add(new CustomStatusInfo
				{
					State = ((item[0] is DropDownItem) ? ((DropDownItem)item[0]) : ((item[0] != null) ? new DropDownItem(item[0].ToString()) : null)),
					Count = Convert.ToInt32(item[1])
				});
			}
			return list;
		}
		catch (Exception ex)
		{
			EleWise.ELMA.Logging.Logger.Log.Error(ex.Message, ex);
			return list;
		}
	}

	protected virtual void JoinProcessIfNeeded(ICriteria criteria, ref bool processHeaderJoined, List<long> processId = null)
	{
		if (processHeaderJoined)
		{
			return;
		}
		ICriteria val = null;
		try
		{
			val = criteria.GetCriteriaByPath(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -420012943));
		}
		catch (Exception)
		{
		}
		if (val != null)
		{
			return;
		}
		criteria.CreateAlias(AliasProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-261315199 ^ -261293127)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12F0172), (JoinType)0).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x1145D7F3), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949740275), (JoinType)0);
		processHeaderJoined = true;
		if (processId != null)
		{
			if (processId.Count == 1)
			{
				criteria.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514159728), (object)processId[0]));
			}
			else if (processId.Count > 1)
			{
				criteria.Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x157D5AF4 ^ 0x157D33BA), (ICollection)processId));
			}
		}
	}

	protected virtual void JoinHeaderIfNeeded(ICriteria criteria)
	{
		int num = 2;
		int num2 = num;
		string alias = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				alias = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747F92DE);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				criteria.GetOrCreateAlias((string)PnRqCnPnwVhafkSNYwq(0x1134D2C0 ^ 0x1134BBE4), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651F8BF9), (JoinType)0, ref alias);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_028c, IL_029c, IL_02c7, IL_0397, IL_046e, IL_06bb, IL_0763, IL_0772, IL_07be, IL_07cd, IL_0835, IL_08c7, IL_08d6, IL_08e1, IL_097f, IL_09b7, IL_09e8, IL_09f7, IL_0a42, IL_0a9b, IL_0aa5, IL_0ab4, IL_0ac4, IL_0b81, IL_0d54, IL_0d63, IL_0e4b, IL_0e5a, IL_0e6a, IL_0e79, IL_0ee9, IL_0ef8, IL_0f8d, IL_0fcf, IL_106b, IL_1091, IL_10a0, IL_10af, IL_10d0, IL_11a0, IL_11af, IL_121d, IL_12e4, IL_12f3, IL_1330, IL_133f, IL_155e, IL_1656, IL_1757, IL_1766, IL_1775, IL_17ae
		int num = 35;
		long? num3 = default(long?);
		IWorkflowInstanceFilter workflowInstanceFilter = default(IWorkflowInstanceFilter);
		_003C_003Ec__DisplayClass84_0 _003C_003Ec__DisplayClass84_4 = default(_003C_003Ec__DisplayClass84_0);
		IProcessHeader processHeader = default(IProcessHeader);
		SqlSubQuery sqlSubQuery = default(SqlSubQuery);
		EleWise.ELMA.Security.Models.IUser currentUser = default(EleWise.ELMA.Security.Models.IUser);
		_003C_003Ec__DisplayClass84_1 _003C_003Ec__DisplayClass84_ = default(_003C_003Ec__DisplayClass84_1);
		bool processHeaderJoined = default(bool);
		bool flag = default(bool);
		Guid guid2 = default(Guid);
		List<ProcessHeaderInfo> source = default(List<ProcessHeaderInfo>);
		_003C_003Ec__DisplayClass84_2 _003C_003Ec__DisplayClass84_2 = default(_003C_003Ec__DisplayClass84_2);
		IEnumerator<IWorflowInstanceSetupFilter> enumerator = default(IEnumerator<IWorflowInstanceSetupFilter>);
		WorkflowInstanceGeneralStatus value = default(WorkflowInstanceGeneralStatus);
		WorkflowInstanceGeneralStatus? generalStatus = default(WorkflowInstanceGeneralStatus?);
		DetachedCriteria val2 = default(DetachedCriteria);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		Guid? guid = default(Guid?);
		List<WorkflowInstanceStatus> list = default(List<WorkflowInstanceStatus>);
		DetachedCriteria val5 = default(DetachedCriteria);
		Func<DetachedCriteria> func = default(Func<DetachedCriteria>);
		List<Guid> activityUidsForFilter = default(List<Guid>);
		DetachedCriteria val = default(DetachedCriteria);
		DetachedCriteria val3 = default(DetachedCriteria);
		EleWise.ELMA.Security.Models.IUser currentUser2 = default(EleWise.ELMA.Security.Models.IUser);
		DetachedCriteria val4 = default(DetachedCriteria);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 51:
					num3 = workflowInstanceFilter.ProcessHeaderId;
					num2 = 146;
					continue;
				case 35:
					_003C_003Ec__DisplayClass84_4 = new _003C_003Ec__DisplayClass84_0();
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
					{
						num2 = 34;
					}
					continue;
				case 53:
					if (processHeader != null)
					{
						num2 = 50;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
						{
							num2 = 41;
						}
						continue;
					}
					goto case 52;
				case 79:
					sqlSubQuery = (SqlSubQuery)ohokmvXzPhbPCaTYtWd(ohokmvXzPhbPCaTYtWd(ohokmvXzPhbPCaTYtWd(base.Session.GetNamedSubQuery((string)PnRqCnPnwVhafkSNYwq(0x6CC04061 ^ 0x6CC02BC1)), PnRqCnPnwVhafkSNYwq(-2125897096 ^ -2125919840), InterfaceActivator.UID<IOrganizationItem>(loadImplementation: false)), PnRqCnPnwVhafkSNYwq(-17847711 ^ -17841773), InterfaceActivator.UID<IUserGroup>(loadImplementation: false)), PnRqCnPnwVhafkSNYwq(0x1134D2C0 ^ 0x1134BED0), currentUser.Id);
					num2 = 20;
					continue;
				case 20:
					JoinProcessIfNeeded(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, ref processHeaderJoined);
					num2 = 141;
					continue;
				case 56:
					flag = true;
					num2 = 108;
					continue;
				case 19:
					guid2 = xOubfOXG3fOHhhcHtdS(WorkflowPermissionProvider.MyProcessesPermission);
					num2 = 80;
					continue;
				case 121:
					if (!source.All(_003C_003Ec__DisplayClass84_2._003CSetupFilter_003Eb__2))
					{
						num2 = 76;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
						{
							num2 = 102;
						}
						continue;
					}
					goto case 124;
				case 24:
				case 55:
				case 63:
					enumerator = ((ComponentManager)hHhoNsdsvqVSv6Avon3()).GetExtensionPoints<IWorflowInstanceSetupFilter>().GetEnumerator();
					num = 120;
					break;
				case 21:
				case 89:
				case 91:
				case 107:
				case 108:
				case 140:
				case 144:
					if (workflowInstanceFilter.ProcessIds == null)
					{
						num = 63;
						break;
					}
					goto case 73;
				case 77:
				case 90:
					if (W2ycwdXVv3GLu83lRNm(workflowInstanceFilter) != null)
					{
						num2 = 8;
						continue;
					}
					goto default;
				case 27:
					value = generalStatus.Value;
					num2 = 44;
					continue;
				case 106:
					val2 = (DetachedCriteria)Y3ErIlXiiVEmFP57NWK(cMXllvXUc8RrgFHjRdJ(jTHNWJXxUci5VWZ7w88(cMXllvXUc8RrgFHjRdJ(DetachedCriteria.For(InterfaceActivator.TypeOf<IWorkflowTaskBase>(), (string)PnRqCnPnwVhafkSNYwq(--601115071 ^ 0x23D423A3)), F2U0sFXwlSbk2DmssZx(ppSrVpXRt4pkCJRUWMo(PnRqCnPnwVhafkSNYwq(-14356676 ^ -14383804), new object[7]
					{
						mX8V1eXWPogSGTl8pfj(j1KtReXjetb6lr7wSZn(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75BAD659 ^ 0x75BABC7F)),
						mX8V1eXWPogSGTl8pfj(j1KtReXjetb6lr7wSZn(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2269BD32 ^ 0x2269D628)),
						mX8V1eXWPogSGTl8pfj(j1KtReXjetb6lr7wSZn(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949736861)),
						mX8V1eXWPogSGTl8pfj(j1KtReXjetb6lr7wSZn(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895839063)),
						currentUser.Id,
						mX8V1eXWPogSGTl8pfj(j1KtReXjetb6lr7wSZn(serviceNotNull), PnRqCnPnwVhafkSNYwq(-360662087 ^ -360651435)),
						serviceNotNull.ParameterSeparator
					}), true, NHibernateUtil.Boolean)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498834435), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-790221436 ^ -790205972), (JoinType)0), RYD255XoJn93q4u1Dx5(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8D5763A ^ 0x8D51C64), string.Format((string)PnRqCnPnwVhafkSNYwq(0x37F755F5 ^ 0x37F73D13), rv6eGmX2FlSReM2fGgO(this)))), ((ProjectionList)X0D18YXhB3QKjJTla2d()).Add((IProjection)(object)Projections.Id()));
					num2 = 49;
					continue;
				case 72:
				{
					ICriteria criteria2 = _003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria;
					object obj = PnRqCnPnwVhafkSNYwq(--601115071 ^ 0x23D420F1);
					num3 = workflowInstanceFilter.ProcessHeaderId;
					criteria2.Add((ICriterion)VuXotDXQ6LwktchEluq(obj, num3.Value));
					num2 = 84;
					continue;
				}
				case 100:
					if (wHchNYPVPiLSsrnrGLh(workflowInstanceFilter) != null)
					{
						num2 = 4;
						continue;
					}
					goto case 51;
				case 98:
					_003C_003Ec__DisplayClass84_.tasksCriteria = null;
					num2 = 99;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
					{
						num2 = 54;
					}
					continue;
				case 127:
					guid = workflowInstanceFilter.CurrentExecuterRole;
					num2 = 9;
					continue;
				case 88:
					if (flag)
					{
						num2 = 54;
						continue;
					}
					goto case 66;
				case 133:
					list.Add(WorkflowInstanceStatus.Running);
					num2 = 132;
					continue;
				case 29:
					guid = workflowInstanceFilter.PermissionId;
					num = 19;
					break;
				case 4:
				case 137:
					_003C_003Ec__DisplayClass84_2 = new _003C_003Ec__DisplayClass84_2();
					num2 = 74;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
					{
						num2 = 32;
					}
					continue;
				case 146:
					if (!num3.HasValue)
					{
						num2 = 114;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
						{
							num2 = 53;
						}
						continue;
					}
					goto case 4;
				case 18:
					base.SetupFilter(_003C_003Ec__DisplayClass84_4.criteria, filter);
					num2 = 93;
					continue;
				case 32:
					generalStatus = workflowInstanceFilter.GeneralStatus;
					num = 40;
					break;
				case 10:
					if (!TTrSWDPT0LHRYLspwNQ(guid.Value, bSV4fPXNrxwqYNvM52N(WorkflowRoleTypes.ProcessInstanceMember)))
					{
						num2 = 105;
						continue;
					}
					goto case 88;
				case 17:
					HIeIpTXb4c0rsRywMrR(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, mckpYOXI1GXdvu9DpQ5(val5));
					num2 = 69;
					continue;
				case 142:
					if (!TTrSWDPT0LHRYLspwNQ(guid.Value, bSV4fPXNrxwqYNvM52N(WorkflowRoleTypes.DirectorsOfCurrentExecutor)))
					{
						num2 = 72;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
						{
							num2 = 104;
						}
						continue;
					}
					goto case 106;
				case 111:
				{
					Type type = xOYWcvPFfTpGmJ65MXT(WorkflowInstanceContextService, pcjv5dPoZRQRwhMcDFE(processHeader));
					Type type2 = WSseABXpjiKY6YLm0r6(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria);
					if (wqhTJZXCiTw74InZwft(type, type2))
					{
						num2 = 9;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
						{
							num2 = 125;
						}
						continue;
					}
					goto case 52;
				}
				case 124:
					_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria.Add((ICriterion)tHhVFXXrjR4Ik0hSFOI(PnRqCnPnwVhafkSNYwq(-25709590 ^ -25699868)));
					num2 = 58;
					continue;
				case 120:
					try
					{
						while (true)
						{
							int num4;
							if (!enumerator.MoveNext())
							{
								num4 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
								{
									num4 = 0;
								}
								goto IL_08e5;
							}
							goto IL_08fb;
							IL_08fb:
							enumerator.Current.SetupFilter(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, workflowInstanceFilter, ref processHeaderJoined, ref processHeaderJoined);
							num4 = 2;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
							{
								num4 = 1;
							}
							goto IL_08e5;
							IL_08e5:
							switch (num4)
							{
							case 1:
								goto IL_08fb;
							case 2:
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num5 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								case 1:
									enumerator.Dispose();
									num5 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
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
					goto case 18;
				case 12:
					workflowInstanceFilter = filter as IWorkflowInstanceFilter;
					num2 = 96;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
					{
						num2 = 25;
					}
					continue;
				case 96:
					if (workflowInstanceFilter != null)
					{
						num2 = 23;
						continue;
					}
					goto case 18;
				case 130:
					guid = workflowInstanceFilter.CurrentExecuterRole;
					num2 = 142;
					continue;
				case 11:
				case 22:
				case 132:
				case 139:
					if (lKksXwX3P7jga7pxehS(list) > 1)
					{
						num2 = 148;
						continue;
					}
					goto case 14;
				case 101:
				case 104:
					guid = workflowInstanceFilter.CurrentExecuterRole;
					num2 = 41;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num2 = 37;
					}
					continue;
				case 9:
					if (TTrSWDPT0LHRYLspwNQ(guid.Value, bSV4fPXNrxwqYNvM52N(WorkflowRoleTypes.CurrentExecutor)))
					{
						num2 = 2;
						continue;
					}
					goto case 130;
				case 93:
					return;
				case 78:
					_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria.Add((ICriterion)(object)Restrictions.Eq((string)qMaPAhXT2O0Ktp5OsZb(this, PnRqCnPnwVhafkSNYwq(-1895853023 ^ -1895825567)), (object)currentUser));
					num2 = 89;
					continue;
				case 1:
					guid = workflowInstanceFilter.CurrentExecuterRole;
					num2 = 128;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
					{
						num2 = 26;
					}
					continue;
				case 37:
				case 58:
				case 61:
				case 92:
				case 102:
				case 118:
					guid = workflowInstanceFilter.CurrentExecuterRole;
					num2 = 5;
					continue;
				case 62:
					func().Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-865213812 ^ -865236166), (ICollection)activityUidsForFilter));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
					{
						num2 = 76;
					}
					continue;
				case 85:
					HIeIpTXb4c0rsRywMrR(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, mckpYOXI1GXdvu9DpQ5(val));
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
					{
						num2 = 56;
					}
					continue;
				case 2:
				{
					object obj2 = jTHNWJXxUci5VWZ7w88(cMXllvXUc8RrgFHjRdJ(CiP1FhX78JAuSktVyun(InterfaceActivator.TypeOf<IWorkflowTaskBase>(), PnRqCnPnwVhafkSNYwq(0x37E97159 ^ 0x37E91B45)), VuXotDXQ6LwktchEluq(PnRqCnPnwVhafkSNYwq(--1756698829 ^ 0x68B572EB), currentUser)), PnRqCnPnwVhafkSNYwq(-148495695 ^ -148486005), PnRqCnPnwVhafkSNYwq(--1756698829 ^ 0x68B55CA5), (JoinType)0);
					object obj3 = PnRqCnPnwVhafkSNYwq(0x3C1FFB55 ^ 0x3C1FBD95);
					object[] array = (object[])rb2JjAXSLY8K5tNHMqX();
					val3 = (DetachedCriteria)Y3ErIlXiiVEmFP57NWK(cMXllvXUc8RrgFHjRdJ(((DetachedCriteria)obj2).Add((ICriterion)wruAT3X1gddVpfXIgbB(obj3, array)), RYD255XoJn93q4u1Dx5(PnRqCnPnwVhafkSNYwq(0x595C500A ^ 0x595C3A54), string.Format((string)PnRqCnPnwVhafkSNYwq(--601115071 ^ 0x23D42159), rv6eGmX2FlSReM2fGgO(this)))), ivpALDXFrn7MgtV2sfC(X0D18YXhB3QKjJTla2d(), ipWmXbXEoWR0IK4UQOo()));
					num2 = 129;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
					{
						num2 = 76;
					}
					continue;
				}
				case 42:
					if (workflowInstanceFilter.Statuses.Count > 0)
					{
						num2 = 59;
						continue;
					}
					goto case 26;
				case 126:
					HIeIpTXb4c0rsRywMrR(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, VuXotDXQ6LwktchEluq(qMaPAhXT2O0Ktp5OsZb(this, PnRqCnPnwVhafkSNYwq(-1393899982 ^ -1393917710)), list.First()));
					num = 28;
					break;
				case 46:
					if (guid.Value == bSV4fPXNrxwqYNvM52N(WorkflowRoleTypes.ResponsibleForInstance))
					{
						num2 = 7;
						continue;
					}
					goto case 21;
				case 60:
					if (!guid.HasValue)
					{
						num2 = 65;
						continue;
					}
					if (guid.HasValue)
					{
						num2 = 117;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
						{
							num2 = 38;
						}
						continue;
					}
					goto case 16;
				case 7:
					HIeIpTXb4c0rsRywMrR(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, VuXotDXQ6LwktchEluq(qMaPAhXT2O0Ktp5OsZb(this, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516540948)), currentUser));
					num2 = 21;
					continue;
				case 68:
					if (!TTrSWDPT0LHRYLspwNQ(guid.Value, WorkflowRoleTypes.ProcessCurator.UID))
					{
						num2 = 115;
						continue;
					}
					goto case 45;
				case 134:
					list.Add(WorkflowInstanceStatus.Aborted);
					num2 = 11;
					continue;
				case 81:
					if (guid.HasValue)
					{
						num2 = 29;
						continue;
					}
					goto case 37;
				case 6:
				case 147:
					if (workflowInstanceFilter.Statuses != null)
					{
						num2 = 42;
						continue;
					}
					goto case 26;
				case 49:
					HIeIpTXb4c0rsRywMrR(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, mckpYOXI1GXdvu9DpQ5(val2));
					num2 = 91;
					continue;
				case 47:
				case 54:
				case 105:
					guid = workflowInstanceFilter.CurrentExecuterRole;
					num2 = 15;
					continue;
				case 95:
					_003C_003Ec__DisplayClass84_4.criteria = criteria;
					num2 = 12;
					continue;
				case 148:
					HIeIpTXb4c0rsRywMrR(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, Restrictions.In(AliasProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25692886)), (ICollection)list));
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
					{
						num2 = 26;
					}
					continue;
				case 141:
					_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria.Add((ICriterion)Aquf1adYv1g3cWVewVG(JEJiF8dOd4CSdQPcKjv(PnRqCnPnwVhafkSNYwq(0x56F860D7 ^ 0x56F80CFF), iS8coVdKOEVyDJQ4w4V(sqlSubQuery), PnRqCnPnwVhafkSNYwq(-1514166050 ^ -1514143828)), cktAwBdZB5OEo6jQXwy(sqlSubQuery), hwJUUudv9c6dYsalCYO(sqlSubQuery)));
					num2 = 144;
					continue;
				case 16:
				case 33:
					if (KMAga8XaLiW5J2e9IZT(SecurityService, WorkflowPermissionProvider.FullMonitorAccessPermission))
					{
						num2 = 37;
						continue;
					}
					goto case 94;
				case 69:
					flag = true;
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c != 0)
					{
						num2 = 61;
					}
					continue;
				case 80:
					if (guid.HasValue)
					{
						num2 = 70;
						continue;
					}
					goto case 64;
				case 114:
				case 135:
					JoinProcessIfNeeded(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, ref processHeaderJoined);
					num2 = 71;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 32;
					}
					continue;
				case 76:
				case 138:
					flag = false;
					num2 = 112;
					continue;
				case 64:
				case 149:
					guid = workflowInstanceFilter.PermissionId;
					num2 = 55;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num2 = 86;
					}
					continue;
				case 119:
					goto IL_1038;
				case 73:
					if (pPSqBfd8bshc8K2Xg5E(workflowInstanceFilter.ProcessIds) <= 0)
					{
						num2 = 24;
						continue;
					}
					goto case 38;
				case 52:
				case 116:
					num3 = workflowInstanceFilter.ProcessHeaderId;
					num2 = 36;
					continue;
				case 23:
					_003C_003Ec__DisplayClass84_ = new _003C_003Ec__DisplayClass84_1();
					num2 = 75;
					continue;
				case 36:
					if (num3.HasValue)
					{
						num = 82;
						break;
					}
					goto case 84;
				case 59:
					HIeIpTXb4c0rsRywMrR(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, Restrictions.In((string)qMaPAhXT2O0Ktp5OsZb(this, PnRqCnPnwVhafkSNYwq(-432000546 ^ -431982818)), (ICollection)workflowInstanceFilter.Statuses));
					num2 = 67;
					continue;
				case 30:
					processHeaderJoined = false;
					num2 = 53;
					continue;
				case 99:
					func = _003C_003Ec__DisplayClass84_._003CSetupFilter_003Eb__0;
					num2 = 32;
					continue;
				case 44:
					switch (value)
					{
					case WorkflowInstanceGeneralStatus.Current:
						break;
					case WorkflowInstanceGeneralStatus.Terminated:
						goto IL_1038;
					default:
						goto IL_1191;
					case WorkflowInstanceGeneralStatus.Completed:
						goto IL_162e;
					}
					goto case 133;
				case 131:
					currentUser = authenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
					num2 = 97;
					continue;
				case 38:
					HIeIpTXb4c0rsRywMrR(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, yt3HGqXe0eo3LH5CJ02(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46ECF99), (ICollection)workflowInstanceFilter.ProcessIds));
					num = 55;
					break;
				case 3:
				case 13:
					JoinProcessIfNeeded(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, ref processHeaderJoined, new List<long> { processHeader.Id });
					num2 = 116;
					continue;
				case 26:
				case 28:
				case 67:
					processHeader = (IProcessHeader)wHchNYPVPiLSsrnrGLh(workflowInstanceFilter);
					num2 = 30;
					continue;
				case 71:
					JoinHeaderIfNeeded(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria);
					num2 = 25;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
					{
						num2 = 6;
					}
					continue;
				case 8:
					cMXllvXUc8RrgFHjRdJ(func(), VuXotDXQ6LwktchEluq(PnRqCnPnwVhafkSNYwq(0x6CC04061 ^ 0x6CC029FD), workflowInstanceFilter.TaskExecutor));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
					{
						num2 = 0;
					}
					continue;
				case 143:
					if (kp877EXAho5NEPaeSKh(activityUidsForFilter) <= 0)
					{
						num2 = 138;
						continue;
					}
					goto case 62;
				case 40:
					if (!generalStatus.HasValue)
					{
						num2 = 6;
						continue;
					}
					goto case 103;
				case 43:
					generalStatus = workflowInstanceFilter.GeneralStatus;
					num2 = 23;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
					{
						num2 = 27;
					}
					continue;
				case 87:
					val5 = (DetachedCriteria)Y3ErIlXiiVEmFP57NWK(((DetachedCriteria)cMXllvXUc8RrgFHjRdJ(CiP1FhX78JAuSktVyun(InterfaceActivator.TypeOf<IWorkflowInstanceMember>(), PnRqCnPnwVhafkSNYwq(0x1C7F6FED ^ 0x1C7F0639)), VuXotDXQ6LwktchEluq(PnRqCnPnwVhafkSNYwq(0x3C1FFB55 ^ 0x3C1F928B), currentUser2))).Add((ICriterion)RYD255XoJn93q4u1Dx5(PnRqCnPnwVhafkSNYwq(0x3C1FFB55 ^ 0x3C1F92A7), string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF4B91E), rv6eGmX2FlSReM2fGgO(this)))), ivpALDXFrn7MgtV2sfC(Projections.ProjectionList(), Projections.Id()));
					num2 = 17;
					continue;
				case 145:
					currentUser2 = authenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
					num2 = 41;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 != 0)
					{
						num2 = 87;
					}
					continue;
				case 45:
					val4 = (DetachedCriteria)Y3ErIlXiiVEmFP57NWK(cMXllvXUc8RrgFHjRdJ(cMXllvXUc8RrgFHjRdJ(((DetachedCriteria)CiP1FhX78JAuSktVyun(InterfaceActivator.TypeOf<IResponsibilityMatrixItem>(), PnRqCnPnwVhafkSNYwq(-39189604 ^ -39166584))).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386468958), (string)PnRqCnPnwVhafkSNYwq(0x2F44D93A ^ 0x2F44B26C), (JoinType)0), VuXotDXQ6LwktchEluq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x101BA6B), true)), RYD255XoJn93q4u1Dx5(PnRqCnPnwVhafkSNYwq(-261315199 ^ -261304581), PnRqCnPnwVhafkSNYwq(-1600060848 ^ -1600034338))), ((ProjectionList)X0D18YXhB3QKjJTla2d()).Add((IProjection)ipWmXbXEoWR0IK4UQOo()));
					num2 = 81;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
					{
						num2 = 113;
					}
					continue;
				case 125:
					JoinProcessIfNeeded(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, ref processHeaderJoined, new List<long> { processHeader.Id });
					num2 = 52;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1a2d7634479d44fb8d3718c31b05f73c == 0)
					{
						num2 = 5;
					}
					continue;
				case 94:
					source = ProcessHeaderManager.GetMonitorProcessesAllInfo().ToList();
					num2 = 100;
					continue;
				case 83:
				case 123:
					guid = workflowInstanceFilter.CurrentExecuterRole;
					num2 = 46;
					continue;
				case 112:
					guid = workflowInstanceFilter.PermissionId;
					num2 = 49;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
					{
						num2 = 81;
					}
					continue;
				case 14:
					if (lKksXwX3P7jga7pxehS(list) == 1)
					{
						num2 = 126;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 26;
				case 15:
					if (!TTrSWDPT0LHRYLspwNQ(guid.Value, bSV4fPXNrxwqYNvM52N(WorkflowRoleTypes.ProcessOwner)))
					{
						num2 = 123;
						continue;
					}
					goto case 79;
				case 41:
					if (!(guid.Value == WorkflowRoleTypes.Initiator.UID))
					{
						num2 = 109;
						continue;
					}
					goto case 78;
				case 113:
					JoinProcessIfNeeded(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, ref processHeaderJoined);
					num2 = 57;
					continue;
				case 48:
					goto IL_162e;
				case 109:
				case 136:
					guid = workflowInstanceFilter.CurrentExecuterRole;
					num2 = 68;
					continue;
				case 70:
					if (!guid.HasValue)
					{
						num2 = 22;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
						{
							num2 = 39;
						}
						continue;
					}
					if (!TTrSWDPT0LHRYLspwNQ(guid.GetValueOrDefault(), guid2))
					{
						goto case 64;
					}
					goto case 39;
				case 97:
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 127;
					continue;
				case 84:
					if (string.IsNullOrEmpty((string)XMoJhjXMOGXlpT03IN9(workflowInstanceFilter)))
					{
						num2 = 90;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
						{
							num2 = 49;
						}
						continue;
					}
					goto case 110;
				case 57:
					HIeIpTXb4c0rsRywMrR(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, mckpYOXI1GXdvu9DpQ5(val4));
					num2 = 48;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
					{
						num2 = 107;
					}
					continue;
				case 110:
					cMXllvXUc8RrgFHjRdJ(func(), d6LV7mXkB5VDj8IlAh0(PnRqCnPnwVhafkSNYwq(-22348816 ^ -22375820), workflowInstanceFilter.TaskName, MatchMode.Anywhere));
					num2 = 77;
					continue;
				case 103:
					list = new List<WorkflowInstanceStatus>();
					num2 = 43;
					continue;
				case 75:
					_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass84_4;
					num2 = 98;
					continue;
				case 50:
					if (pcjv5dPoZRQRwhMcDFE(processHeader) == null)
					{
						num2 = 13;
						continue;
					}
					goto case 111;
				case 82:
					JoinProcessIfNeeded(_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria, ref processHeaderJoined);
					num2 = 72;
					continue;
				case 31:
				case 115:
					guid = workflowInstanceFilter.CurrentExecuterRole;
					num2 = 10;
					continue;
				case 129:
					_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria.Add((ICriterion)mckpYOXI1GXdvu9DpQ5(val3));
					num2 = 140;
					continue;
				case 128:
					if (WiGOVqXuRX4SiRJSxsj(guid.Value, Guid.Empty))
					{
						num2 = 28;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
						{
							num2 = 131;
						}
						continue;
					}
					goto case 21;
				case 66:
					val = ((DetachedCriteria)cMXllvXUc8RrgFHjRdJ(cMXllvXUc8RrgFHjRdJ(CiP1FhX78JAuSktVyun(InterfaceActivator.TypeOf<IWorkflowInstanceMember>(), PnRqCnPnwVhafkSNYwq(-1361036319 ^ -1361030603)), VuXotDXQ6LwktchEluq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657592325), currentUser)), RYD255XoJn93q4u1Dx5(PnRqCnPnwVhafkSNYwq(0x7381F16B ^ 0x73819899), FYgeKbX4EtRvD85g0Kg(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642736293), rv6eGmX2FlSReM2fGgO(this))))).SetProjection((IProjection)ivpALDXFrn7MgtV2sfC(X0D18YXhB3QKjJTla2d(), ipWmXbXEoWR0IK4UQOo()));
					num2 = 85;
					continue;
				case 122:
					if (activityUidsForFilter != null)
					{
						num2 = 143;
						continue;
					}
					goto case 76;
				case 86:
					guid2 = xOubfOXG3fOHhhcHtdS(WorkflowPermissionProvider.ProcessMonitor);
					num2 = 60;
					continue;
				case 34:
					_003C_003Ec__DisplayClass84_4._003C_003E4__this = this;
					num2 = 95;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
					{
						num2 = 43;
					}
					continue;
				case 5:
					if (guid.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 21;
				default:
				{
					List<Guid> activityUids = workflowInstanceFilter.ActivityUids;
					long? processHeaderId;
					if (wHchNYPVPiLSsrnrGLh(workflowInstanceFilter) == null)
					{
						num3 = null;
						processHeaderId = num3;
					}
					else
					{
						processHeaderId = workflowInstanceFilter.ProcessHeader.Id;
					}
					activityUidsForFilter = WorkflowTaskBaseManager.GetActivityUidsForFilter(activityUids, processHeaderId, workflowInstanceFilter.SwimlaneUid);
					num2 = 122;
					continue;
				}
				case 39:
					num2 = 145;
					continue;
				case 117:
					if (TTrSWDPT0LHRYLspwNQ(guid.GetValueOrDefault(), guid2))
					{
						goto case 16;
					}
					goto case 65;
				case 65:
					num2 = 118;
					continue;
				case 74:
				{
					_003C_003Ec__DisplayClass84_2 _003C_003Ec__DisplayClass84_3 = _003C_003Ec__DisplayClass84_2;
					long headerId;
					if (wHchNYPVPiLSsrnrGLh(workflowInstanceFilter) == null)
					{
						num3 = workflowInstanceFilter.ProcessHeaderId;
						headerId = num3.Value;
					}
					else
					{
						headerId = ((IEntity<long>)wHchNYPVPiLSsrnrGLh(workflowInstanceFilter)).Id;
					}
					_003C_003Ec__DisplayClass84_3.headerId = headerId;
					num2 = 42;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num2 = 121;
					}
					continue;
				}
				case 25:
					{
						_003C_003Ec__DisplayClass84_.CS_0024_003C_003E8__locals1.criteria.Add((ICriterion)yt3HGqXe0eo3LH5CJ02(PnRqCnPnwVhafkSNYwq(0x1EA50FCC ^ 0x1EA56682), source.Select((ProcessHeaderInfo h) => _003C_003Ec.mumy30Z6SZAqwkQQtjsF(h)).ToArray()));
						num = 92;
						break;
					}
					IL_162e:
					list.Add(WorkflowInstanceStatus.Completed);
					num2 = 134;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
					{
						num2 = 119;
					}
					continue;
					IL_1191:
					num2 = 22;
					continue;
					IL_1038:
					list.Add(WorkflowInstanceStatus.Terminated);
					num2 = 139;
					continue;
				}
				break;
			}
		}
	}

	public virtual ICriteria CreateContextFilterCriteria(IWorkflowInstanceFilter filter, FetchOptions fetchOptions)
	{
		//Discarded unreachable code: IL_01d4, IL_01e3, IL_01f2, IL_0285, IL_0294, IL_03c6
		int num = 28;
		PropertyInfo propertyInfo = default(PropertyInfo);
		PropertyMetadata propertyMetadata = default(PropertyMetadata);
		ICriteria val = default(ICriteria);
		Type type = default(Type);
		IProcessHeader processHeader = default(IProcessHeader);
		bool? withNullStatus = default(bool?);
		_003C_003Ec__DisplayClass85_0 _003C_003Ec__DisplayClass85_ = default(_003C_003Ec__DisplayClass85_0);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					propertyInfo = (PropertyInfo)ktxuUGdtlfaRD7e2yoD(filter.ContextFilter.GetType(), I4W5rfdmLjt8FU4Cj6j(propertyMetadata));
					num2 = 10;
					continue;
				case 30:
					val.CreateAlias((string)PnRqCnPnwVhafkSNYwq(-682910880 ^ -682900534), (string)rv6eGmX2FlSReM2fGgO(this));
					num2 = 21;
					continue;
				case 13:
					SetupFetchOptions(val, fetchOptions, type);
					num2 = 26;
					continue;
				default:
					val = (ICriteria)wf48nhdJQytHOCYhNqS(this, null, type, PnRqCnPnwVhafkSNYwq(0x1145BED7 ^ 0x1145D22F), null);
					num2 = 30;
					continue;
				case 3:
					processHeader = (IProcessHeader)wHchNYPVPiLSsrnrGLh(filter);
					num2 = 19;
					continue;
				case 11:
					TPLJ5XXBm796FMwGLsU(WorkflowInstanceContextService, PnRqCnPnwVhafkSNYwq(-1498811449 ^ -1498833025));
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
					{
						num2 = 3;
					}
					continue;
				case 17:
					if (withNullStatus.HasValue)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 2;
				case 20:
					withNullStatus = filter.WithNullStatus;
					num = 17;
					break;
				case 8:
					if (propertyMetadata == null)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 9;
				case 16:
					if (_003C_003Ec__DisplayClass85_.process != null)
					{
						num2 = 29;
						continue;
					}
					goto case 5;
				case 23:
					entityMetadata = (EntityMetadata)YCXmywPqO2LKW3OOdYi(type, true, true);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
					{
						num2 = 0;
					}
					continue;
				case 24:
					if (withNullStatus.Value)
					{
						num = 12;
						break;
					}
					goto case 2;
				case 27:
					Contract.ArgumentNotNull(filter, (string)PnRqCnPnwVhafkSNYwq(0x246EEF98 ^ 0x246EB6A4));
					num2 = 18;
					continue;
				case 2:
				case 7:
				case 14:
				case 22:
					return val;
				case 5:
					throw new ObjectNotFoundException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642732183), ((IEntity<long>)wHchNYPVPiLSsrnrGLh(filter)).Id);
				case 29:
					type = xOYWcvPFfTpGmJ65MXT(WorkflowInstanceContextService, _003C_003Ec__DisplayClass85_.process);
					num2 = 23;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
					{
						num2 = 23;
					}
					continue;
				case 28:
					_003C_003Ec__DisplayClass85_ = new _003C_003Ec__DisplayClass85_0();
					num2 = 27;
					continue;
				case 10:
					if (propertyInfo != null)
					{
						num2 = 25;
						continue;
					}
					goto case 2;
				case 18:
					sZ46u9PHN5cjbV6iRHO(filter.ProcessHeader, PnRqCnPnwVhafkSNYwq(0x2269BD32 ^ 0x2269D152));
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
					{
						num2 = 15;
					}
					continue;
				case 6:
					withNullStatus = filter.WithNullStatus;
					num2 = 24;
					continue;
				case 1:
					HIeIpTXb4c0rsRywMrR(val, Restrictions.IsNull((string)FYgeKbX4EtRvD85g0Kg(PnRqCnPnwVhafkSNYwq(0x1843E01F ^ 0x184388DD), I4W5rfdmLjt8FU4Cj6j(propertyMetadata))));
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
					{
						num2 = 4;
					}
					continue;
				case 21:
					if (c51bqCdlg6e24hyIANY(fetchOptions, null))
					{
						num2 = 13;
						continue;
					}
					goto case 26;
				case 19:
					_003C_003Ec__DisplayClass85_.process = (IWorkflowProcess)pcjv5dPoZRQRwhMcDFE(processHeader);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
					{
						num2 = 16;
					}
					continue;
				case 15:
					TPLJ5XXBm796FMwGLsU(ProcessHeaderManager, PnRqCnPnwVhafkSNYwq(0x4940763B ^ 0x49401AB7));
					num2 = 11;
					continue;
				case 25:
					if (propertyInfo.GetValue(filter.ContextFilter, null) != null)
					{
						num2 = 14;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 1;
				case 4:
					IPD4T8dyrTChX9eDFoG(this, val, XQdnhwd0XAZfYBUTL8l(filter), entityMetadata, PnRqCnPnwVhafkSNYwq(-2077784392 ^ -2077758912));
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num2 = 20;
					}
					continue;
				case 26:
					if (XQdnhwd0XAZfYBUTL8l(filter) == null)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 4;
				case 12:
					propertyMetadata = entityMetadata.Properties.FirstOrDefault(_003C_003Ec__DisplayClass85_._003CCreateContextFilterCriteria_003Eb__0);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
					{
						num2 = 8;
					}
					continue;
				}
				break;
			}
		}
	}

	[ActionCheck("e93ccf45-3ff5-4bf5-a83b-7ff73130e432")]
	public virtual bool CanChangeVersion(ChangeProcessVersionActionData changeData)
	{
		//Discarded unreachable code: IL_0049, IL_00ba, IL_00c9, IL_0138
		int num = 8;
		int num2 = num;
		long num4 = default(long);
		long num5 = default(long);
		while (true)
		{
			long num3;
			switch (num2)
			{
			case 2:
				return num4 < num5;
			case 1:
				if (T5QofYP4mCwjCfAEprn(changeData) != null)
				{
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto IL_005a;
			case 8:
				if (pcjv5dPoZRQRwhMcDFE(((IWorkflowProcess)eLgYo2PDg0QbWE0OMmG(T5QofYP4mCwjCfAEprn(changeData))).Header) != null)
				{
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 5;
			case 5:
				return false;
			case 7:
				num4 = CB1yvAdbkFIJ2cMXg4G(eLgYo2PDg0QbWE0OMmG(T5QofYP4mCwjCfAEprn(changeData)));
				num2 = 4;
				continue;
			case 9:
				if (W719Rddgelf62qRiD4g(SecurityService, WorkflowPermissionProvider.ChangeProcessVersionPermission, T5QofYP4mCwjCfAEprn(changeData), false))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto IL_005a;
			case 3:
				num3 = ((IWorkflowProcess)WacpbZPEK3qOmVdtA6T(changeData)).VersionNumber;
				break;
			case 4:
				if (changeData.NewProcess == null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 3;
			default:
				if (mqDYdFdBxKKEHS0qs9b(T5QofYP4mCwjCfAEprn(changeData)) == WorkflowInstanceStatus.Running)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto IL_005a;
			case 6:
				{
					num3 = CB1yvAdbkFIJ2cMXg4G(pcjv5dPoZRQRwhMcDFE(xvS1p8d5p4t1VodExkk(eLgYo2PDg0QbWE0OMmG(T5QofYP4mCwjCfAEprn(changeData)))));
					break;
				}
				IL_005a:
				return false;
			}
			num5 = num3;
			num2 = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
			{
				num2 = 0;
			}
		}
	}

	[ActionCheck("c828c2eb-7fb5-42dc-af0d-be34111b8292")]
	protected virtual bool CanTerminate(IWorkflowInstance instance, string reason = null, EleWise.ELMA.Security.Models.IUser user = null)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return mqDYdFdBxKKEHS0qs9b(instance) == WorkflowInstanceStatus.Running;
			default:
				if (W719Rddgelf62qRiD4g(SecurityService, WorkflowPermissionProvider.TerminateProcess, instance, false))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto IL_0032;
			case 1:
				{
					if (instance != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_0032;
				}
				IL_0032:
				return false;
			}
		}
	}

	private void AddContextViewItems(EntityMetadata metadata, List<Guid> visiblePropertyUids, FormView view, RootViewItem parentViewItem)
	{
		_003C_003Ec__DisplayClass106_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass106_0();
		CS_0024_003C_003E8__locals0.view = view;
		foreach (IPropertyMetadata propertiesAndTablePart in metadata.GetPropertiesAndTableParts())
		{
			if (visiblePropertyUids != null && !visiblePropertyUids.Contains(propertiesAndTablePart.PropertyUid))
			{
				continue;
			}
			PropertyMetadata propertyMetadata = propertiesAndTablePart as PropertyMetadata;
			bool value = false;
			if (propertyMetadata != null && propertyMetadata.ViewSettings != null)
			{
				ViewAttribute forView = propertyMetadata.ViewSettings.GetForView(CS_0024_003C_003E8__locals0.view.ViewType);
				if (!forView.Visible)
				{
					continue;
				}
				value = forView.ReadOnly;
			}
			TablePartMetadata tablePartMetadata = propertiesAndTablePart as TablePartMetadata;
			if (tablePartMetadata != null)
			{
				value = tablePartMetadata.Properties.All((PropertyMetadata pm) => _003C_003Ec__DisplayClass106_0.dNeFb0ZTmC4Acgusu3EV(_003C_003Ec__DisplayClass106_0.s9hT9rZTytVe8osScB7o(_003C_003Ec__DisplayClass106_0.yAFKhfZT0nv8cVC5Gnge(pm), CS_0024_003C_003E8__locals0.view.ViewType)));
			}
			PropertyViewItem propertyViewItem = new PropertyViewItem
			{
				Uid = propertiesAndTablePart.PropertyUid,
				PropertyUid = propertiesAndTablePart.PropertyUid,
				Attributes = 
				{
					ReadOnly = value
				}
			};
			parentViewItem.Items.Add(propertyViewItem);
			if (tablePartMetadata != null)
			{
				AddContextViewItems(tablePartMetadata, visiblePropertyUids, CS_0024_003C_003E8__locals0.view, propertyViewItem);
			}
		}
	}

	private void AddContextViewItemsNoBlock(EntityMetadata metadata, List<Guid> visiblePropertyUids, FormView view, RootViewItem parentViewItem, bool block)
	{
		List<TablePartMetadata> tableParts = metadata.TableParts;
		foreach (IPropertyMetadata propertiesAndTablePart in metadata.GetPropertiesAndTableParts())
		{
			if (visiblePropertyUids != null && !visiblePropertyUids.Contains(propertiesAndTablePart.PropertyUid))
			{
				continue;
			}
			PropertyMetadata propertyMetadata = propertiesAndTablePart as PropertyMetadata;
			bool value = false;
			if (propertyMetadata != null && propertyMetadata.ViewSettings != null)
			{
				ViewAttribute forView = propertyMetadata.ViewSettings.GetForView(view.ViewType);
				if (!forView.Visible)
				{
					continue;
				}
				value = forView.ReadOnly;
			}
			bool flag = false;
			foreach (TablePartMetadata item in tableParts)
			{
				if (((IPropertyMetadata)item).PropertyUid == propertiesAndTablePart.PropertyUid)
				{
					flag = true;
				}
			}
			if (!flag || block)
			{
				PropertyViewItem propertyViewItem = new PropertyViewItem
				{
					Uid = propertiesAndTablePart.PropertyUid,
					PropertyUid = propertiesAndTablePart.PropertyUid,
					Attributes = 
					{
						ReadOnly = value
					}
				};
				parentViewItem.Items.Add(propertyViewItem);
				if (propertiesAndTablePart is TablePartMetadata metadata2)
				{
					AddContextViewItemsNoBlock(metadata2, visiblePropertyUids, view, propertyViewItem, block);
				}
			}
		}
	}

	private void AddContextViewItemsTableParts(EntityMetadata metadata, List<Guid> visiblePropertyUids, FormViewItem view, RootViewItem parentViewItem)
	{
		foreach (IPropertyMetadata propertiesAndTablePart in metadata.GetPropertiesAndTableParts())
		{
			if (visiblePropertyUids != null && !visiblePropertyUids.Contains(propertiesAndTablePart.PropertyUid))
			{
				continue;
			}
			PropertyMetadata propertyMetadata = propertiesAndTablePart as PropertyMetadata;
			bool value = false;
			if (propertyMetadata != null && propertyMetadata.ViewSettings != null)
			{
				ViewAttribute forView = propertyMetadata.ViewSettings.GetForView(view.ViewType);
				if (!forView.Visible)
				{
					continue;
				}
				value = forView.ReadOnly;
			}
			PropertyViewItem propertyViewItem = new PropertyViewItem
			{
				Uid = propertiesAndTablePart.PropertyUid,
				PropertyUid = propertiesAndTablePart.PropertyUid,
				Attributes = 
				{
					ReadOnly = value
				}
			};
			if (propertiesAndTablePart is TablePartMetadata metadata2)
			{
				AddContextViewItemsTableParts(metadata2, visiblePropertyUids, view, propertyViewItem);
				parentViewItem.Items.Add(propertyViewItem);
			}
			else if (view != parentViewItem)
			{
				parentViewItem.Items.Add(propertyViewItem);
			}
		}
	}

	public ChangeProcessVersionValidationResult ValidateChangeProcessVersion(IWorkflowInstance instance, IWorkflowProcess process)
	{
		//Discarded unreachable code: IL_0061
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass109_0 _003C_003Ec__DisplayClass109_ = default(_003C_003Ec__DisplayClass109_0);
		Guid[] array = default(Guid[]);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (process != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 6;
			case 3:
				_003C_003Ec__DisplayClass109_ = new _003C_003Ec__DisplayClass109_0();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
				{
					num2 = 1;
				}
				continue;
			case 2:
				_003C_003Ec__DisplayClass109_.instance = instance;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
				{
					num2 = 5;
				}
				continue;
			case 5:
				if (process == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				process = (IWorkflowProcess)pcjv5dPoZRQRwhMcDFE(((IWorkflowProcess)eLgYo2PDg0QbWE0OMmG(_003C_003Ec__DisplayClass109_.instance)).Header);
				num2 = 7;
				continue;
			case 4:
				return (ChangeProcessVersionValidationResult)yefXdud9YaVZ6lt5s0h(Yj9i9EdfiJqRV2wlLqk(((IWorkflowProcess)eLgYo2PDg0QbWE0OMmG(_003C_003Ec__DisplayClass109_.instance)).CastAsRealType().GetType()), ((IWorkflowProcess)eLgYo2PDg0QbWE0OMmG(_003C_003Ec__DisplayClass109_.instance)).CastAsRealType(), process.CastAsRealType(), array);
			case 6:
				throw new InvalidOperationException((string)JD0sNOdP8mORWkILLjV(PnRqCnPnwVhafkSNYwq(0x5DB28AD2 ^ 0x5DB2E7C6), new object[1] { wdsbFsdcOdHnbky2mkR(((IWorkflowProcess)eLgYo2PDg0QbWE0OMmG(_003C_003Ec__DisplayClass109_.instance)).Header) }));
			}
			IEntityManager<IWorkflowTrackingItem> instance2 = EntityManager<IWorkflowTrackingItem>.Instance;
			ParameterExpression parameterExpression = Expression.Parameter(S7lXYkdXEDvfrIuGyWO(typeof(IWorkflowTrackingItem).TypeHandle), (string)PnRqCnPnwVhafkSNYwq(0x1927DA93 ^ 0x19278FB5));
			array = (from e in instance2.Find(Expression.Lambda<Func<IWorkflowTrackingItem, bool>>((Expression)RrbNVVdL8exMkTO4mNp(srYtyFduR99qDyw8nyT(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Field(Expression.Constant(_003C_003Ec__DisplayClass109_, S7lXYkdXEDvfrIuGyWO(typeof(_003C_003Ec__DisplayClass109_0).TypeHandle)), (FieldInfo)IHtnugddFaSe5nOdPtM((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), hL90FTdHovUuXS82rH0(wHbCb5dnJeowlRHWGIa(parameterExpression, (MethodInfo)bl7IuWdDnRoc33FrXmr((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), Expression.Constant((DateTime?)null, S7lXYkdXEDvfrIuGyWO(typeof(DateTime?).TypeHandle)), false, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression }))
				select e.ElementUid).ToArray();
			num2 = 4;
		}
	}

	public Dictionary<IWorkflowInstance, IWorkflowProcess> GetInstanceUpdateVersionInfo(IWorkflowInstance instance, IWorkflowProcess newProcess)
	{
		_003C_003Ec__DisplayClass110_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass110_0();
		var list = (from r in base.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-980570076 ^ -980558476)).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1657582555 ^ -1657593431), newProcess.Id).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130108044), instance.Id)
				.SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x7581F0C), (IEnumerable)WorkflowInstanceChangingVersionHelper.DeleteStatuses)
				.CleanUpCache(cleanUpCache: false)
				.List<object[]>()
			select new
			{
				InstanceId = Convert.ToInt64(r[0]),
				ProcessId = Convert.ToInt64(r[1])
			}).ToList();
		if (list.Count == 0)
		{
			return new Dictionary<IWorkflowInstance, IWorkflowProcess>();
		}
		CS_0024_003C_003E8__locals0.wfInstances = FindByIdArray(list.Select(i => i.InstanceId).ToArray()).ToDictionary((IWorkflowInstance i) => i.Id);
		CS_0024_003C_003E8__locals0.wfProcesses = WorkflowProcessManager.FindByIdArray(list.Select(i => i.ProcessId).ToArray()).ToDictionary((IWorkflowProcess p) => p.Id);
		return list.ToDictionary(r => CS_0024_003C_003E8__locals0.wfInstances[r.InstanceId], r => CS_0024_003C_003E8__locals0.wfProcesses[r.ProcessId]);
	}

	internal void ContextUpdated(IWorkflowInstance instance)
	{
		int num = 1;
		_003C_003Ec__DisplayClass111_0 _003C_003Ec__DisplayClass111_ = default(_003C_003Ec__DisplayClass111_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 4:
					if (!Filters.Any(_003C_003Ec__DisplayClass111_._003CContextUpdated_003Eb__0))
					{
						goto end_IL_0012;
					}
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
					{
						num2 = 2;
					}
					break;
				case 1:
					_003C_003Ec__DisplayClass111_ = new _003C_003Ec__DisplayClass111_0();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					w23MkNdTx0BgxZfsIV0(((IQuery)YwbCGsd30i7MG8oIaje(((IQuery)R8xsYOdjbuqnQAndy5J(SkuSuZdWs43xldP5tHy(this), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x18438DC5))).SetParameter<DateTime>((string)PnRqCnPnwVhafkSNYwq(--1418337216 ^ 0x548A4F28), NePRJndRP6g44rJtKvy()), PnRqCnPnwVhafkSNYwq(0x6A69C5CD ^ 0x6A69ABF7), EfOPSLdqPUZ6Si52JTd(iGp52ud6VoVT8BNhuaD()))).SetParameter<Guid>((string)PnRqCnPnwVhafkSNYwq(0x4943E3E4 ^ 0x4943B1E4), DefaultEntityActions.UpdateGuid).SetParameter<long>((string)PnRqCnPnwVhafkSNYwq(--1418337216 ^ 0x548A0B44), _003C_003Ec__DisplayClass111_.instance.Id), false);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
					{
						num2 = 5;
					}
					break;
				case 5:
					return;
				case 6:
					bVHox6dQELBa1gUMPfQ(base.Session, new Type[1] { InterfaceActivator.TypeOf<IEntityModelHistory>() });
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
					{
						num2 = 5;
					}
					break;
				default:
					_003C_003Ec__DisplayClass111_.instance = instance;
					num2 = 4;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			EntityModelHistoryManager.Instance.RecordUpdated(_003C_003Ec__DisplayClass111_.instance);
			num = 3;
		}
	}

	[PublicApiMember]
	public virtual void SetResponsible(IWorkflowInstance instance, EleWise.ELMA.Security.Models.IUser newResponsible)
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
				Instance.ChangeResponsible(instance, newResponsible);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[PublicApiMember]
	public virtual void SetResponsible(IWorkflowInstance instance, EleWise.ELMA.Security.Models.IUser newResponsible, bool sendNotification)
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
				Instance.ChangeResponsible(instance, newResponsible, sendNotification);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[Transaction]
	[PublicApiMember]
	public virtual void AddComment(IWorkflowInstance instance, string comment)
	{
		//Discarded unreachable code: IL_00f6
		int num = 15;
		int num2 = num;
		IEntityActionHandler serviceNotNull = default(IEntityActionHandler);
		ICommentActionHandler serviceNotNull2 = default(ICommentActionHandler);
		ICommentActionModel commentActionModel = default(ICommentActionModel);
		IComment comment2 = default(IComment);
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		while (true)
		{
			switch (num2)
			{
			case 13:
				serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
				num2 = 7;
				break;
			case 4:
				IWbfTqdCG56ydao7ys3(serviceNotNull2, instance, commentActionModel);
				num2 = 16;
				break;
			case 10:
				comment2.Text = comment;
				num2 = 12;
				break;
			case 5:
				serviceNotNull2 = Locator.GetServiceNotNull<ICommentActionHandler>();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 4;
				}
				break;
			case 18:
				comment2.Save();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				kATbIQPxkALLxZUyMy0(instance);
				num2 = 13;
				break;
			case 15:
				if (instance != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
					{
						num2 = 14;
					}
					break;
				}
				goto case 11;
			case 2:
				if (entityActionEventArgs != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 == 0)
					{
						num2 = 3;
					}
					break;
				}
				return;
			case 16:
				instance.Comments.Add(comment2);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
				{
					num2 = 0;
				}
				break;
			case 9:
				serviceNotNull.ActionExecuted(entityActionEventArgs);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
				{
					num2 = 6;
				}
				break;
			case 1:
				commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 != 0)
				{
					num2 = 8;
				}
				break;
			case 3:
				serviceNotNull2.ProcessEventArgs(entityActionEventArgs, commentActionModel);
				num2 = 9;
				break;
			case 12:
				comment2.CreationDate = NePRJndRP6g44rJtKvy();
				num2 = 17;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				return;
			case 11:
				throw new NullReferenceException((string)n79c2oXmBJNUtbMcGVc(PnRqCnPnwVhafkSNYwq(-148495695 ^ -148484885)));
			case 14:
				comment2 = InterfaceActivator.Create<IComment>();
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
				{
					num2 = 10;
				}
				break;
			case 8:
				bExou3dp6uF6ANIAHUp(commentActionModel, comment2);
				num2 = 5;
				break;
			case 17:
				OkKwR7X8mANunfjAQtn(comment2, ((IAuthenticationService)hXniDAXKG5bZIQlJEYa(this)).GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
				num2 = 18;
				break;
			case 7:
				entityActionEventArgs = EntityActionEventArgs.TryCreate(null, instance, dTUeBbdMVVZuB0jv2iO());
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void AddComment(IWorkflowInstance instance, string comment, EleWise.ELMA.Security.Models.IUser commentAuthor)
	{
		//Discarded unreachable code: IL_00f0, IL_00ff
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass115_0 _003C_003Ec__DisplayClass115_ = default(_003C_003Ec__DisplayClass115_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				SecurityService.RunByUser(commentAuthor, _003C_003Ec__DisplayClass115_._003CAddComment_003Eb__0);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b != 0)
				{
					num2 = 9;
				}
				break;
			case 0:
				return;
			case 9:
				return;
			case 5:
				_003C_003Ec__DisplayClass115_._003C_003E4__this = this;
				num2 = 8;
				break;
			case 8:
				_003C_003Ec__DisplayClass115_.instance = instance;
				num2 = 7;
				break;
			case 1:
				if (commentAuthor != null)
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			case 4:
				throw new NullReferenceException((string)n79c2oXmBJNUtbMcGVc(PnRqCnPnwVhafkSNYwq(-1895853023 ^ -1895826807)));
			case 2:
				if (commentAuthor == EiSQwldkNhyBXjtZCOA(hXniDAXKG5bZIQlJEYa(this)))
				{
					tmA8GldUZQWRMSNf3oV(this, _003C_003Ec__DisplayClass115_.instance, _003C_003Ec__DisplayClass115_.comment);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 3;
				}
				break;
			case 6:
				_003C_003Ec__DisplayClass115_ = new _003C_003Ec__DisplayClass115_0();
				num2 = 5;
				break;
			case 7:
				_003C_003Ec__DisplayClass115_.comment = comment;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void CloseTimer(IWorkflowInstance instance, long schedulerJobId)
	{
		//Discarded unreachable code: IL_0144, IL_0153
		int num = 1;
		int num2 = num;
		WorkflowInstanceTimerInfo workflowInstanceTimerInfo = default(WorkflowInstanceTimerInfo);
		IResumeProcessSchedulerJob resumeProcessSchedulerJob = default(IResumeProcessSchedulerJob);
		_003C_003Ec__DisplayClass116_0 _003C_003Ec__DisplayClass116_ = default(_003C_003Ec__DisplayClass116_0);
		JobStatus? onceExecuteStatus = default(JobStatus?);
		List<IWorkflowInstance> instanceList = default(List<IWorkflowInstance>);
		while (true)
		{
			switch (num2)
			{
			case 12:
				if (workflowInstanceTimerInfo == null)
				{
					num2 = 7;
					break;
				}
				resumeProcessSchedulerJob = EntityManager<IResumeProcessSchedulerJob>.Instance.Load(hy2wD9dV82P4D4J11dI(workflowInstanceTimerInfo));
				num2 = 9;
				break;
			case 10:
				if (oAIrdHdAsYjh0B43eq5(resumeProcessSchedulerJob.Task) == SchedulerTaskStatus.Enabled)
				{
					num2 = 5;
					break;
				}
				goto case 2;
			case 9:
				if (YRSof7X5Y4PlJ1H1sT1(resumeProcessSchedulerJob) != null)
				{
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
					{
						num2 = 6;
					}
					break;
				}
				return;
			case 1:
				_003C_003Ec__DisplayClass116_ = new _003C_003Ec__DisplayClass116_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
				{
					num2 = 0;
				}
				break;
			case 13:
				if (onceExecuteStatus.Value == JobStatus.Fail)
				{
					num2 = 8;
					break;
				}
				return;
			case 14:
				workflowInstanceTimerInfo = GetActiveTimerInfos(instanceList).FirstOrDefault(_003C_003Ec__DisplayClass116_._003CCloseTimer_003Eb__0);
				num2 = 12;
				break;
			case 2:
				onceExecuteStatus = resumeProcessSchedulerJob.OnceExecuteStatus;
				num2 = 3;
				break;
			case 7:
				return;
			case 11:
				return;
			case 3:
				if (!onceExecuteStatus.HasValue)
				{
					return;
				}
				num2 = 6;
				break;
			default:
				_003C_003Ec__DisplayClass116_.schedulerJobId = schedulerJobId;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				onceExecuteStatus = resumeProcessSchedulerJob.OnceExecuteStatus;
				num2 = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
				{
					num2 = 13;
				}
				break;
			case 5:
			case 8:
				CloseTimer(resumeProcessSchedulerJob);
				num2 = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
				{
					num2 = 5;
				}
				break;
			case 4:
				instanceList = new List<IWorkflowInstance> { instance };
				num2 = 14;
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void ChangeTimer(IWorkflowInstance instance, long schedulerJobId, DateTime time)
	{
		//Discarded unreachable code: IL_008a
		int num = 6;
		IResumeProcessSchedulerJob resumeProcessSchedulerJob = default(IResumeProcessSchedulerJob);
		_003C_003Ec__DisplayClass117_0 _003C_003Ec__DisplayClass117_ = default(_003C_003Ec__DisplayClass117_0);
		WorkflowInstanceTimerInfo workflowInstanceTimerInfo = default(WorkflowInstanceTimerInfo);
		List<IWorkflowInstance> instanceList = default(List<IWorkflowInstance>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					PdRYnTdGaRVhtEkX1GS(this, resumeProcessSchedulerJob, time);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					_003C_003Ec__DisplayClass117_.schedulerJobId = schedulerJobId;
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
					{
						num2 = 7;
					}
					continue;
				case 4:
					break;
				case 6:
					_003C_003Ec__DisplayClass117_ = new _003C_003Ec__DisplayClass117_0();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num2 = 5;
					}
					continue;
				case 2:
					return;
				default:
					resumeProcessSchedulerJob = EntityManager<IResumeProcessSchedulerJob>.Instance.Load(hy2wD9dV82P4D4J11dI(workflowInstanceTimerInfo));
					num2 = 3;
					continue;
				case 7:
					instanceList = new List<IWorkflowInstance> { instance };
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					return;
				case 8:
					if (workflowInstanceTimerInfo == null)
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			workflowInstanceTimerInfo = GetActiveTimerInfos(instanceList).FirstOrDefault(_003C_003Ec__DisplayClass117_._003CChangeTimer_003Eb__0);
			num = 8;
		}
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsProcessesApi")]
	public virtual void AddPermission(IWorkflowInstance instance, Guid permissionId, EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_00da, IL_00e9
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new NullReferenceException(SR.T((string)PnRqCnPnwVhafkSNYwq(0x246EEF98 ^ 0x246E816C)));
			case 1:
			{
				IProcessHeaderPermission processHeaderPermission = InterfaceActivator.Create<IProcessHeaderPermission>();
				NRgY7id7sSYNrJSrPyN(processHeaderPermission, xvS1p8d5p4t1VodExkk(eLgYo2PDg0QbWE0OMmG(instance)));
				cGsFgYd2S2fc5QaV7Ri(processHeaderPermission, permissionId);
				fRqOsQdoqlGVk0P2ujQ(processHeaderPermission, user);
				processHeaderPermission.UserSecuritySetCacheId = IdCWvWdFEFEUQpj6Qpi(user.Id);
				kATbIQPxkALLxZUyMy0(processHeaderPermission);
				num2 = 2;
				break;
			}
			case 3:
				throw new NullReferenceException((string)n79c2oXmBJNUtbMcGVc(PnRqCnPnwVhafkSNYwq(0x738ABA6E ^ 0x738AD434)));
			case 4:
				if (instance != null)
				{
					if (user != null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[PublicApiNodeId("PermissionsProcessesApi")]
	[PublicApiMember]
	public virtual void DeletePermission(IWorkflowInstance instance, Guid permissionId, EleWise.ELMA.Security.Models.IUser user)
	{
		//Discarded unreachable code: IL_007e, IL_008d, IL_017c, IL_018b
		int num = 5;
		int num2 = num;
		ICollection<IProcessHeaderPermission> source = default(ICollection<IProcessHeaderPermission>);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (!source.Any())
				{
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
					{
						num2 = 5;
					}
				}
				else
				{
					source.FirstOrDefault().Delete();
					num2 = 3;
				}
				break;
			case 6:
				return;
			case 5:
				if (instance != null)
				{
					num2 = 4;
					break;
				}
				goto default;
			default:
				throw new NullReferenceException(SR.T((string)PnRqCnPnwVhafkSNYwq(0x5F534A5C ^ 0x5F532406)));
			case 4:
				if (user != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				throw new NullReferenceException((string)n79c2oXmBJNUtbMcGVc(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F800F5B ^ 0x5F8061AF)));
			case 1:
				source = EntityManager<IProcessHeaderPermission>.Instance.Find(new Filter
				{
					Query = string.Format((string)PnRqCnPnwVhafkSNYwq(-1712492721 ^ -1712521095), user.Id, ((IEntity<long>)xvS1p8d5p4t1VodExkk(eLgYo2PDg0QbWE0OMmG(instance))).Id, permissionId)
				}, null);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
				{
					num2 = 7;
				}
				break;
			case 3:
				return;
			}
		}
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsProcessesApi")]
	public virtual void AddPermission(IWorkflowInstance instance, Guid permissionId, IUserGroup userGroup)
	{
		//Discarded unreachable code: IL_0035, IL_0044
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			default:
				throw new NullReferenceException((string)n79c2oXmBJNUtbMcGVc(PnRqCnPnwVhafkSNYwq(0x1134D2C0 ^ 0x1134BC9A)));
			case 1:
			{
				if (userGroup == null)
				{
					num2 = 4;
					break;
				}
				IProcessHeaderPermission processHeaderPermission = InterfaceActivator.Create<IProcessHeaderPermission>();
				NRgY7id7sSYNrJSrPyN(processHeaderPermission, xvS1p8d5p4t1VodExkk(eLgYo2PDg0QbWE0OMmG(instance)));
				cGsFgYd2S2fc5QaV7Ri(processHeaderPermission, permissionId);
				zVUjFQdiN27N3VmsGWk(processHeaderPermission, userGroup);
				processHeaderPermission.UserSecuritySetCacheId = UserSecuritySetHelper.GetGroupMask(userGroup.Id);
				processHeaderPermission.Save();
				num2 = 3;
				break;
			}
			case 2:
				if (instance != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 4:
				throw new NullReferenceException(SR.T((string)PnRqCnPnwVhafkSNYwq(0x101D10F ^ 0x101BFFB)));
			}
		}
	}

	[PublicApiNodeId("PermissionsProcessesApi")]
	[PublicApiMember]
	public virtual void DeletePermission(IWorkflowInstance instance, Guid permissionId, IUserGroup userGroup)
	{
		//Discarded unreachable code: IL_006c, IL_007b, IL_008b, IL_0153, IL_0162
		int num = 5;
		ICollection<IProcessHeaderPermission> source = default(ICollection<IProcessHeaderPermission>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return;
				case 7:
					xUPO1YXP5TLWa2kiyl0(source.FirstOrDefault());
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 1;
					}
					break;
				case 8:
					if (!source.Any())
					{
						return;
					}
					goto end_IL_0012;
				case 2:
					throw new NullReferenceException((string)n79c2oXmBJNUtbMcGVc(PnRqCnPnwVhafkSNYwq(0x56A753C9 ^ 0x56A73D3D)));
				default:
				{
					IEntityManager<IProcessHeaderPermission> instance2 = EntityManager<IProcessHeaderPermission>.Instance;
					Filter filter = new Filter();
					Bf1XPfdIf2oQB3k4Koy(filter, string.Format((string)PnRqCnPnwVhafkSNYwq(0x5F800F5B ^ 0x5F8060E7), userGroup.Id, ((IEntity<long>)xvS1p8d5p4t1VodExkk(eLgYo2PDg0QbWE0OMmG(instance))).Id, permissionId));
					source = instance2.Find(filter, null);
					num2 = 8;
					break;
				}
				case 1:
					return;
				case 5:
					if (instance != null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 3;
				case 3:
					throw new NullReferenceException(SR.T((string)PnRqCnPnwVhafkSNYwq(0x3C1FFB55 ^ 0x3C1F950F)));
				case 4:
					if (userGroup != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsProcessesApi")]
	public virtual void AddPermission(IWorkflowInstance instance, Guid permissionId, IOrganizationItem orgItem)
	{
		//Discarded unreachable code: IL_0056
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				case 1:
					if (instance == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
						{
							num2 = 0;
						}
						break;
					}
					if (orgItem != null)
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 4:
					throw new NullReferenceException((string)n79c2oXmBJNUtbMcGVc(PnRqCnPnwVhafkSNYwq(0x7AC609FE ^ 0x7AC6670A)));
				case 3:
				{
					IProcessHeaderPermission processHeaderPermission = InterfaceActivator.Create<IProcessHeaderPermission>();
					NRgY7id7sSYNrJSrPyN(processHeaderPermission, xvS1p8d5p4t1VodExkk(instance.Process));
					cGsFgYd2S2fc5QaV7Ri(processHeaderPermission, permissionId);
					uH22CddaXV65prnmHq4(processHeaderPermission, orgItem);
					processHeaderPermission.UserSecuritySetCacheId = O8nUd4dr8pyJrUCWmTJ(orgItem.Id);
					processHeaderPermission.Save();
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
					{
						num2 = 1;
					}
					break;
				}
				default:
					throw new NullReferenceException((string)n79c2oXmBJNUtbMcGVc(PnRqCnPnwVhafkSNYwq(-1539486135 ^ -1539497965)));
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	[PublicApiMember]
	[PublicApiNodeId("PermissionsProcessesApi")]
	public virtual void DeletePermission(IWorkflowInstance instance, Guid permissionId, IOrganizationItem orgItem)
	{
		//Discarded unreachable code: IL_008a, IL_0099
		int num = 4;
		int num2 = num;
		ICollection<IProcessHeaderPermission> source = default(ICollection<IProcessHeaderPermission>);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 4:
				if (instance == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 == 0)
					{
						num2 = 3;
					}
					break;
				}
				if (orgItem != null)
				{
					num2 = 2;
					break;
				}
				goto case 1;
			case 3:
				throw new NullReferenceException((string)n79c2oXmBJNUtbMcGVc(PnRqCnPnwVhafkSNYwq(0x74AB4717 ^ 0x74AB294D)));
			case 6:
				return;
			case 0:
				return;
			case 5:
				if (source.Any())
				{
					source.FirstOrDefault().Delete();
					num2 = 6;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862351694)));
			case 2:
			{
				IEntityManager<IProcessHeaderPermission> instance2 = EntityManager<IProcessHeaderPermission>.Instance;
				Filter filter = new Filter();
				Bf1XPfdIf2oQB3k4Koy(filter, SSeSqSdemHJMUsgtWUL(PnRqCnPnwVhafkSNYwq(-22348816 ^ -22377548), orgItem.Id, ((IEntity<long>)xvS1p8d5p4t1VodExkk(instance.Process)).Id, permissionId));
				source = instance2.Find(filter, null);
				num2 = 5;
				break;
			}
			}
		}
	}

	private IWorkflowInstance StartProcessInnerLogic(IWorkflowProcess process, string instanceName)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (process == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num2 = 2;
					}
					continue;
				}
				if (!string.IsNullOrEmpty(instanceName))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 1;
			case 2:
				throw new NullReferenceException(SR.T((string)PnRqCnPnwVhafkSNYwq(0x5F534A5C ^ 0x5F533AAE)));
			case 1:
				throw new ArgumentException((string)PnRqCnPnwVhafkSNYwq(0x2269BD32 ^ 0x2269CC18));
			}
			if (instanceName[0] == ' ')
			{
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a == 0)
				{
					num2 = 0;
				}
				continue;
			}
			IWorkflowInstance workflowInstance = ((AbstractNHEntityManager<IWorkflowInstance, long>)VKAe6pdNyQjX8vFGHeT()).Create();
			iQK3yUdxYIQAVsBQ520(workflowInstance, pcjv5dPoZRQRwhMcDFE(process.Header));
			workflowInstance.Name = instanceName;
			EwX7PhdSl0vhm5QE26h(workflowInstance, ((IAuthenticationService)hXniDAXKG5bZIQlJEYa(this)).GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
			return workflowInstance;
		}
	}

	[PublicApiMember]
	public virtual IWorkflowInstance StartProcess(IWorkflowProcess process, string instanceName)
	{
		int num = 1;
		int num2 = num;
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		while (true)
		{
			switch (num2)
			{
			default:
				Locator.GetServiceNotNull<IWorkflowRuntimeService>().Run(workflowInstance);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				workflowInstance = StartProcessInnerLogic(process, instanceName);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return workflowInstance;
			}
		}
	}

	[PublicApiMember]
	public virtual IWorkflowInstance StartProcess(IWorkflowProcess process, string instanceName, Action<object> context)
	{
		IWorkflowInstance workflowInstance = StartProcessInnerLogic(process, instanceName);
		context((dynamic)workflowInstance.Context);
		Locator.GetServiceNotNull<IWorkflowRuntimeService>().Run(workflowInstance);
		return workflowInstance;
	}

	public virtual void StartProcess(IWorkflowProcess process, string instanceName, Dictionary<string, object> context)
	{
		StartProcess(process, instanceName, context, offException: false);
	}

	public virtual IWorkflowInstance StartProcess(IWorkflowProcess process, string instanceName, Dictionary<string, object> context, bool offException)
	{
		IWorkflowInstance workflowInstance = StartProcessInnerLogic(process, instanceName);
		foreach (KeyValuePair<string, object> item in context)
		{
			if (!offException && workflowInstance.Context.GetType().GetReflectionProperty(item.Key) == null)
			{
				throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574628209), item.Key));
			}
			workflowInstance.Context.GetType().GetReflectionProperty(item.Key).SetValue(workflowInstance.Context, item.Value, null);
		}
		Locator.GetServiceNotNull<IWorkflowRuntimeService>().Run(workflowInstance);
		return workflowInstance;
	}

	[PublicApiMember]
	public virtual IWorkflowInstance StartProcess(IWorkflowProcess process, string instanceName, object context)
	{
		return StartProcess(process, instanceName, context, offException: false);
	}

	[PublicApiMember]
	public virtual IWorkflowInstance StartProcess(IWorkflowProcess process, string instanceName, object context, bool offException)
	{
		//Discarded unreachable code: IL_00b0, IL_00c4, IL_00d3, IL_022e, IL_0251, IL_029e
		int num = 2;
		int num2 = num;
		IWorkflowRuntimeService serviceNotNull = default(IWorkflowRuntimeService);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		IEnumerator enumerator = default(IEnumerator);
		PropertyDescriptor propertyDescriptor = default(PropertyDescriptor);
		while (true)
		{
			switch (num2)
			{
			case 1:
				serviceNotNull = Locator.GetServiceNotNull<IWorkflowRuntimeService>();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
				{
					num2 = 3;
				}
				continue;
			case 2:
				workflowInstance = StartProcessInnerLogic(process, instanceName);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				return workflowInstance;
			case 6:
				enumerator = (IEnumerator)u5rArgd1JDtpmE0MdPH(System.ComponentModel.TypeDescriptor.GetProperties(context));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				try
				{
					while (true)
					{
						int num3;
						if (!fsj6HfdzlBRAIiMZE0f(enumerator))
						{
							num3 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
							{
								num3 = 3;
							}
							goto IL_00e2;
						}
						goto IL_01ee;
						IL_01ee:
						propertyDescriptor = (PropertyDescriptor)SGYisMdhlWyTOYfkpYK(enumerator);
						num3 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
						{
							num3 = 0;
						}
						goto IL_00e2;
						IL_00e2:
						while (true)
						{
							switch (num3)
							{
							case 5:
								break;
							case 1:
								goto IL_012a;
							default:
								goto IL_015b;
							case 4:
								throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130111190), Q7ILkWdEjL9p7GSW8ir(propertyDescriptor)));
							case 2:
								goto IL_01ee;
							case 3:
								goto end_IL_0104;
							}
							break;
							IL_015b:
							if (!offException)
							{
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 != 0)
								{
									num3 = 0;
								}
								continue;
							}
							goto IL_01a7;
							IL_012a:
							if (M4h8ZBdw7d8J7uGFI13(ByClPmPjBNwtm7qPTmc(workflowInstance).GetType().GetReflectionProperty((string)Q7ILkWdEjL9p7GSW8ir(propertyDescriptor)), null))
							{
								int num4 = 4;
								num3 = num4;
								continue;
							}
							goto IL_01a7;
							IL_01a7:
							THeTrmd47qOnNneRr7Y(ktxuUGdtlfaRD7e2yoD(ByClPmPjBNwtm7qPTmc(workflowInstance).GetType(), Q7ILkWdEjL9p7GSW8ir(propertyDescriptor)), ByClPmPjBNwtm7qPTmc(workflowInstance), propertyDescriptor.GetValue(context), null);
							num3 = 5;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
							{
								num3 = 3;
							}
						}
						continue;
						end_IL_0104:
						break;
					}
				}
				finally
				{
					IDisposable disposable = enumerator as IDisposable;
					int num5 = 2;
					while (true)
					{
						switch (num5)
						{
						default:
							goto end_IL_0232;
						case 1:
							goto end_IL_0232;
						case 2:
							if (disposable == null)
							{
								num5 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
								{
									num5 = 1;
								}
								continue;
							}
							break;
						case 3:
							break;
						case 0:
							goto end_IL_0232;
						}
						disposable.Dispose();
						num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
						{
							num5 = 0;
						}
						continue;
						end_IL_0232:
						break;
					}
				}
				break;
			case 3:
				if (context == null)
				{
					num2 = 7;
					continue;
				}
				goto case 6;
			case 4:
			case 7:
				break;
			}
			PknKrGuKZa3YemFMV5K(serviceNotNull, workflowInstance);
			num2 = 5;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
			{
				num2 = 2;
			}
		}
	}

	[PublicApiMember]
	[Transaction]
	public virtual void TerminateProcess(IWorkflowInstance instance)
	{
		int num = 1;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser currentUser = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 1:
				currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
				{
					num2 = 0;
				}
				break;
			default:
				Instance.Terminate(instance, null, currentUser);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[Transaction]
	[PublicApiMember]
	public virtual void TerminateProcess(IWorkflowInstance instance, string reason)
	{
		int num = 1;
		int num2 = num;
		EleWise.ELMA.Security.Models.IUser currentUser = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			default:
				Instance.Terminate(instance, reason, currentUser);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[Transaction]
	[PublicApiMember]
	public virtual void TerminateProcess(IWorkflowInstance instance, EleWise.ELMA.Security.Models.IUser user)
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
				Instance.Terminate(instance, null, user);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	[Transaction]
	public virtual void TerminateProcess(IWorkflowInstance instance, string reason, EleWise.ELMA.Security.Models.IUser user)
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
				((WorkflowInstanceManager)VKAe6pdNyQjX8vFGHeT()).Terminate(instance, reason, user);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	static WorkflowInstanceManager()
	{
		int num = 31;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 31:
					i7lTluPuM7k2ixNBnxp();
					num2 = 30;
					continue;
				case 30:
					parameterExpression = Expression.Parameter(typeof(IWorkflowInstance), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542172204));
					num2 = 28;
					continue;
				case 7:
					F_ParentInstance = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstance, object>>(Expression.Property(parameterExpression, (MethodInfo)bl7IuWdDnRoc33FrXmr((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					parameterExpression = (ParameterExpression)Y15oMyuvd0KoPbiKnPE(S7lXYkdXEDvfrIuGyWO(typeof(IResumeProcessSchedulerJob).TypeHandle), PnRqCnPnwVhafkSNYwq(-1028861977 ^ -1028876503));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
					{
						num2 = 0;
					}
					continue;
				case 29:
					F_SchedulerTask_ExecuteTime = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerTask, object>>((Expression)yIlsNWuZNOQBj5Y2Ai8(wHbCb5dnJeowlRHWGIa(parameterExpression, (MethodInfo)bl7IuWdDnRoc33FrXmr((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), S7lXYkdXEDvfrIuGyWO(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
					{
						num2 = 0;
					}
					continue;
				case 24:
					F_TimerInfo_ElementUid = LinqUtils.NameOf(Expression.Lambda<Func<WorkflowInstanceTimerInfo, object>>((Expression)yIlsNWuZNOQBj5Y2Ai8(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), S7lXYkdXEDvfrIuGyWO(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
					{
						num2 = 6;
					}
					continue;
				case 5:
					parameterExpression = (ParameterExpression)Y15oMyuvd0KoPbiKnPE(S7lXYkdXEDvfrIuGyWO(typeof(WorkflowInstanceTimerInfo).TypeHandle), PnRqCnPnwVhafkSNYwq(0x213F6477 ^ 0x213F3CB9));
					num2 = 24;
					continue;
				case 25:
					parameterExpression = (ParameterExpression)Y15oMyuvd0KoPbiKnPE(S7lXYkdXEDvfrIuGyWO(typeof(IWorkflowBookmark).TypeHandle), PnRqCnPnwVhafkSNYwq(-398691253 ^ -398709627));
					num2 = 23;
					continue;
				case 13:
					F_TimerInfo_Instance = LinqUtils.NameOf(Expression.Lambda<Func<WorkflowInstanceTimerInfo, object>>((Expression)wHbCb5dnJeowlRHWGIa(parameterExpression, (MethodInfo)bl7IuWdDnRoc33FrXmr((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 5;
					continue;
				case 20:
					parameterExpression = (ParameterExpression)Y15oMyuvd0KoPbiKnPE(S7lXYkdXEDvfrIuGyWO(typeof(WorkflowInstanceTimerInfo).TypeHandle), PnRqCnPnwVhafkSNYwq(0x1145BED7 ^ 0x1145E619));
					num = 14;
					break;
				case 2:
					parameterExpression = Expression.Parameter(S7lXYkdXEDvfrIuGyWO(typeof(IWorkflowInstance).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483FFABC));
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
					{
						num2 = 7;
					}
					continue;
				default:
					F_ResumeJob_Bookmark = LinqUtils.NameOf(Expression.Lambda<Func<IResumeProcessSchedulerJob, object>>((Expression)wHbCb5dnJeowlRHWGIa(parameterExpression, (MethodInfo)bl7IuWdDnRoc33FrXmr((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num = 4;
					break;
				case 10:
					F_SchedulerTask_Status = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerTask, object>>((Expression)yIlsNWuZNOQBj5Y2Ai8(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), S7lXYkdXEDvfrIuGyWO(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 34;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
					{
						num2 = 9;
					}
					continue;
				case 12:
					parameterExpression = (ParameterExpression)Y15oMyuvd0KoPbiKnPE(S7lXYkdXEDvfrIuGyWO(typeof(WorkflowInstanceTimerInfo).TypeHandle), PnRqCnPnwVhafkSNYwq(-1895853023 ^ -1895838481));
					num2 = 19;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
					{
						num2 = 26;
					}
					continue;
				case 14:
					F_TimerInfo_SchedulerJobId = LinqUtils.NameOf(Expression.Lambda<Func<WorkflowInstanceTimerInfo, object>>(Expression.Convert((Expression)wHbCb5dnJeowlRHWGIa(parameterExpression, (MethodInfo)bl7IuWdDnRoc33FrXmr((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), S7lXYkdXEDvfrIuGyWO(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num2 = 0;
					}
					continue;
				case 19:
					F_ResumeJob_Id = LinqUtils.NameOf(Expression.Lambda<Func<IResumeProcessSchedulerJob, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), S7lXYkdXEDvfrIuGyWO(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 != 0)
					{
						num2 = 11;
					}
					continue;
				case 23:
					F_Bookmark_Instance = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowBookmark, object>>((Expression)wHbCb5dnJeowlRHWGIa(parameterExpression, (MethodInfo)bl7IuWdDnRoc33FrXmr((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 20;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
					{
						num2 = 19;
					}
					continue;
				case 26:
					F_TimerInfo_ExecuteTime = LinqUtils.NameOf(Expression.Lambda<Func<WorkflowInstanceTimerInfo, object>>((Expression)yIlsNWuZNOQBj5Y2Ai8(wHbCb5dnJeowlRHWGIa(parameterExpression, (MethodInfo)bl7IuWdDnRoc33FrXmr((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), S7lXYkdXEDvfrIuGyWO(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
					{
						num2 = 8;
					}
					continue;
				case 8:
					return;
				case 3:
					F_TimerInfo_CreationDate = LinqUtils.NameOf(Expression.Lambda<Func<WorkflowInstanceTimerInfo, object>>((Expression)yIlsNWuZNOQBj5Y2Ai8(wHbCb5dnJeowlRHWGIa(parameterExpression, (MethodInfo)bl7IuWdDnRoc33FrXmr((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), S7lXYkdXEDvfrIuGyWO(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num2 = 2;
					}
					continue;
				case 35:
					F_Status = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstance, object>>((Expression)yIlsNWuZNOQBj5Y2Ai8(Expression.Property(parameterExpression, (MethodInfo)bl7IuWdDnRoc33FrXmr((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
					num = 2;
					break;
				case 17:
					F_SchedulerTask_CreationDate = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerTask, object>>(Expression.Convert((Expression)wHbCb5dnJeowlRHWGIa(parameterExpression, (MethodInfo)bl7IuWdDnRoc33FrXmr((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), S7lXYkdXEDvfrIuGyWO(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 27;
					continue;
				case 32:
					F_Bookmark_ElementUid = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowBookmark, object>>((Expression)yIlsNWuZNOQBj5Y2Ai8(wHbCb5dnJeowlRHWGIa(parameterExpression, (MethodInfo)bl7IuWdDnRoc33FrXmr((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), S7lXYkdXEDvfrIuGyWO(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
					{
						num2 = 25;
					}
					continue;
				case 15:
					parameterExpression = Expression.Parameter(S7lXYkdXEDvfrIuGyWO(typeof(IWorkflowInstance).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1647793954 ^ -1647775728));
					num2 = 35;
					continue;
				case 28:
					F_Id = LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowInstance, object>>((Expression)yIlsNWuZNOQBj5Y2Ai8(Expression.Property(parameterExpression, (MethodInfo)tWrakWuObyxC6wOblku((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/, typeof(IEntity<long>).TypeHandle)), S7lXYkdXEDvfrIuGyWO(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num = 15;
					break;
				case 18:
					parameterExpression = (ParameterExpression)Y15oMyuvd0KoPbiKnPE(S7lXYkdXEDvfrIuGyWO(typeof(ISchedulerTask).TypeHandle), PnRqCnPnwVhafkSNYwq(-360662087 ^ -360651913));
					num2 = 29;
					continue;
				case 34:
					parameterExpression = (ParameterExpression)Y15oMyuvd0KoPbiKnPE(S7lXYkdXEDvfrIuGyWO(typeof(ISchedulerTask).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716647838));
					num2 = 17;
					continue;
				case 1:
					parameterExpression = (ParameterExpression)Y15oMyuvd0KoPbiKnPE(S7lXYkdXEDvfrIuGyWO(typeof(IResumeProcessSchedulerJob).TypeHandle), PnRqCnPnwVhafkSNYwq(0x37F755F5 ^ 0x37F70D3B));
					num2 = 19;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
					{
						num2 = 0;
					}
					continue;
				case 33:
					F_ResumeJob_OnceExecuteStatus = LinqUtils.NameOf(Expression.Lambda<Func<IResumeProcessSchedulerJob, object>>((Expression)yIlsNWuZNOQBj5Y2Ai8(wHbCb5dnJeowlRHWGIa(parameterExpression, (MethodInfo)bl7IuWdDnRoc33FrXmr((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), S7lXYkdXEDvfrIuGyWO(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num2 = 18;
					}
					continue;
				case 11:
					parameterExpression = (ParameterExpression)Y15oMyuvd0KoPbiKnPE(S7lXYkdXEDvfrIuGyWO(typeof(IResumeProcessSchedulerJob).TypeHandle), PnRqCnPnwVhafkSNYwq(-1361036319 ^ -1361026257));
					num2 = 22;
					continue;
				case 22:
					F_ResumeJob_Task = LinqUtils.NameOf(Expression.Lambda<Func<IResumeProcessSchedulerJob, object>>((Expression)wHbCb5dnJeowlRHWGIa(parameterExpression, (MethodInfo)bl7IuWdDnRoc33FrXmr((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
					{
						num2 = 16;
					}
					continue;
				case 9:
					parameterExpression = Expression.Parameter(S7lXYkdXEDvfrIuGyWO(typeof(ISchedulerTask).TypeHandle), (string)PnRqCnPnwVhafkSNYwq(-683713632 ^ -683736210));
					num = 10;
					break;
				case 6:
					parameterExpression = (ParameterExpression)Y15oMyuvd0KoPbiKnPE(S7lXYkdXEDvfrIuGyWO(typeof(WorkflowInstanceTimerInfo).TypeHandle), PnRqCnPnwVhafkSNYwq(-708128192 ^ -708146546));
					num2 = 3;
					continue;
				case 21:
					parameterExpression = (ParameterExpression)Y15oMyuvd0KoPbiKnPE(S7lXYkdXEDvfrIuGyWO(typeof(WorkflowInstanceTimerInfo).TypeHandle), PnRqCnPnwVhafkSNYwq(0x34EA50D4 ^ 0x34EA081A));
					num2 = 13;
					continue;
				case 4:
					parameterExpression = Expression.Parameter(S7lXYkdXEDvfrIuGyWO(typeof(IResumeProcessSchedulerJob).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10390409));
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
					{
						num2 = 33;
					}
					continue;
				case 27:
					parameterExpression = (ParameterExpression)Y15oMyuvd0KoPbiKnPE(S7lXYkdXEDvfrIuGyWO(typeof(IWorkflowBookmark).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-261315199 ^ -261292721));
					num2 = 32;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
					{
						num2 = 24;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static bool WMQoYQPXx24ItJP6JHS()
	{
		return HWNcLJPPgoRpgJLYjjq == null;
	}

	internal static WorkflowInstanceManager KbaYKfPdjo5TH14yhFg()
	{
		return HWNcLJPPgoRpgJLYjjq;
	}

	internal static void i7lTluPuM7k2ixNBnxp()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object eLgYo2PDg0QbWE0OMmG(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object PnRqCnPnwVhafkSNYwq(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void sZ46u9PHN5cjbV6iRHO(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object wDwU1tPLsAX8SykaUT1(object P_0)
	{
		return ((IWorkflowProcess)P_0).NamingScheme;
	}

	internal static InstanceNamingScheme.SchemeType gflnsLPf1fV0r752vE3(object P_0)
	{
		return ((InstanceNamingScheme)P_0).Type;
	}

	internal static object M3LpueP9pfSIn5QHqOA(object P_0)
	{
		return ((InstanceNamingScheme)P_0).TemplateText;
	}

	internal static void Nfl4IyPWN8EoPSCZq5m(object P_0, object P_1)
	{
		((NotificationElement.DataSource)P_0).Instance = (IWorkflowInstance)P_1;
	}

	internal static object ByClPmPjBNwtm7qPTmc(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static object TBkw4JPRJ16L1FLtSKZ(object P_0, object P_1)
	{
		return ((TextGenerator)P_0).Generate(P_1);
	}

	internal static object vCjx7rP6aTgCoP7f6no(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static object YCXmywPqO2LKW3OOdYi(Type P_0, bool P_1, bool P_2)
	{
		return MetadataLoader.LoadMetadata(P_0, P_1, P_2);
	}

	internal static object atfNB3P37CoWCprLgFQ(object P_0)
	{
		return ((ClassMetadata)P_0).GetTitleProperty();
	}

	internal static bool TTrSWDPT0LHRYLspwNQ(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object zZOSRLPQyByLPK5XrXR(object P_0, Guid P_1)
	{
		return ((Entity<long>)P_0).GetPropertyValue(P_1);
	}

	internal static void sDdux9PposJVck9HW6K(object P_0, object P_1)
	{
		((IWorkflowInstance)P_0).Name = (string)P_1;
	}

	internal static object qm2aodPC2arZ5caSJbF(object P_0)
	{
		return ((EntityManager<IWorkflowInstance, long>)P_0).Logger;
	}

	internal static void f8QkdaPMRkgWWHtUFCl(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void MXqfS0PkHjcZX8XN54K(object P_0)
	{
		((Entity<long>)P_0).Save();
	}

	internal static object c5XAbqPUCVdHe5t3PfU(object P_0)
	{
		return ((IWorkflowInstance)P_0).MetricValues;
	}

	internal static object wHchNYPVPiLSsrnrGLh(object P_0)
	{
		return ((IWorkflowInstanceFilter)P_0).ProcessHeader;
	}

	internal static object uj1OL7PAo8mNfPvsL7L(object P_0, object P_1)
	{
		return ((EntityManager<IWorkflowInstance, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static void MxXHpePGChkSsTGdbow(object P_0, object P_1, object P_2)
	{
		((AbstractNHEntityManager<IWorkflowInstance, long>)P_0).SetupFilter((ICriteria)P_1, (IEntityFilter)P_2);
	}

	internal static long NuKmwgP7VWHPfqmNjLV(object P_0, object P_1)
	{
		return ((EntityManager<IWorkflowInstance, long>)P_0).ReturnCount((ICriteria)P_1);
	}

	internal static object INgnU8P2ZMpO6lOf7PQ(object P_0, object P_1, object P_2)
	{
		return ((WorkflowInstanceManager)P_0).CreateContextFilterCriteria((IWorkflowInstanceFilter)P_1, (FetchOptions)P_2);
	}

	internal static object pcjv5dPoZRQRwhMcDFE(object P_0)
	{
		return ((IProcessHeader)P_0).Published;
	}

	internal static Type xOYWcvPFfTpGmJ65MXT(object P_0, object P_1)
	{
		return ((WorkflowInstanceContextService)P_0).GetFullInstanceContextType((IWorkflowProcess)P_1);
	}

	internal static void ViTMWHPinPX5mnUiSYs(object P_0, object P_1)
	{
		((IWorkflowInstanceMember)P_0).Instance = (IWorkflowInstance)P_1;
	}

	internal static object mW3UkFPI7RmTOpbwT5m(object P_0)
	{
		return ((IWorkflowInstanceMember)P_0).Task;
	}

	internal static void UfAuOKPa9ILZgFPXT4i(object P_0, object P_1)
	{
		((IWorkflowInstanceMember)P_0).User = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static object R9xJ1FPrALZsammAApU()
	{
		return UserGroupManager.Instance;
	}

	internal static object GpJ5IDPesW1cpNKZ3qt(object P_0)
	{
		return ((IOrganizationItem)P_0).User;
	}

	internal static void lVOs6UPNdl4WYOjgWoI(object P_0, object P_1)
	{
		((IWorkflowInstance)P_0).Responsible = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static void kATbIQPxkALLxZUyMy0(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static Guid uQPSOKPSS6hGKvWhuRi()
	{
		return WorkflowInstanceActions.ChangeResponsibleGuid;
	}

	internal static object q9jMDOP1eLyaXKd4ZXk(object P_0)
	{
		return ((EntityManager<IWorkflowInstance, long>)P_0).ActionHandler;
	}

	internal static void lXsraCPhmjxxcdG3bY5(object P_0, ViewType P_1)
	{
		((FormView)P_0).ViewType = P_1;
	}

	internal static object WacpbZPEK3qOmVdtA6T(object P_0)
	{
		return ((ChangeProcessVersionActionData)P_0).NewProcess;
	}

	internal static bool GKHPNRPwFGh0HCSPXR6(object P_0)
	{
		return ((ChangeProcessVersionValidationResult)P_0).HasCriticalIssues;
	}

	internal static object T5QofYP4mCwjCfAEprn(object P_0)
	{
		return ((ChangeProcessVersionActionData)P_0).Instance;
	}

	internal static object H9cwoJPz5wNNhlitbDs(object P_0, object P_1)
	{
		return ((IWorkflowRuntimeService)P_0).CreateExecutingContext((IWorkflowInstance)P_1);
	}

	internal static object hXniDAXKG5bZIQlJEYa(object P_0)
	{
		return ((EntityManager<IWorkflowInstance, long>)P_0).AuthenticationService;
	}

	internal static void EFKwF3XO2LmIcpDIQxH(object P_0, object P_1)
	{
		((ChangeProcessVersionActionData)P_0).User = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static Guid EaptZjXZLa4XSAgqFXN()
	{
		return WorkflowInstanceActions.ChangeProcessVersionGuid;
	}

	internal static void p3l82LXv2ObFgvtGy8j(object P_0, object P_1)
	{
		((IComment)P_0).Text = (string)P_1;
	}

	internal static object tcKJIjXYiIxHN6oK1O8(object P_0)
	{
		return ((ChangeProcessVersionActionData)P_0).User;
	}

	internal static void OkKwR7X8mANunfjAQtn(object P_0, object P_1)
	{
		((IComment)P_0).CreationAuthor = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static void HwQy5gXsvHZMcaxjnu6(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static void hYc4t0XJZF6PeQeDVlR(object P_0, object P_1, object P_2)
	{
		((IWorkflowRuntimeService)P_0).Terminate((IWorkflowInstance)P_1, (string)P_2);
	}

	internal static void Ou5KEIXlWHksJ0IOh30(object P_0, object P_1)
	{
		((IWorkflowInstance)P_0).TerminateUser = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static Guid r4RsHnX0otefrRotuNK()
	{
		return WorkflowInstanceActions.TerminateGuid;
	}

	internal static void NUekjHXy3AKviUCwAJu(object P_0, object P_1)
	{
		((IEntityActionHandler)P_0).ActionExecuted((EntityActionEventArgs)P_1);
	}

	internal static object n79c2oXmBJNUtbMcGVc(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object pENGXVXt07ppc90cLSH(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object HIeIpTXb4c0rsRywMrR(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object YRSof7X5Y4PlJ1H1sT1(object P_0)
	{
		return ((ISchedulerTaskJob)P_0).Task;
	}

	internal static void xCk7SfXgM3VdHrIbjxt(object P_0, object P_1)
	{
		((SchedulerTaskManager)P_0).ExecuteTask((ISchedulerTask)P_1);
	}

	internal static void TPLJ5XXBm796FMwGLsU(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static object tJJJQWXcJx6mQFQo781(object P_0)
	{
		return ((IWorkflowSwimlaneExecutor)P_0).User;
	}

	internal static void xUPO1YXP5TLWa2kiyl0(object P_0)
	{
		((IEntity)P_0).Delete();
	}

	internal static void z1me7xXX3P17WY0KXY2(object P_0, object P_1)
	{
		((IWorkflowSwimlaneExecutor)P_0).User = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static Guid dyfypyXdyki8uDyAe7s(object P_0)
	{
		return ((SwimlaneElement)P_0).ExecuterProperty;
	}

	internal static bool WiGOVqXuRX4SiRJSxsj(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static void vaAgUnXD98Nw8rh109a(object P_0, Guid P_1, object P_2)
	{
		((Entity<long>)P_0).SetPropertyValue(P_1, P_2);
	}

	internal static object uIgYbUXniq6TSJdxvji(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static SwimlaneType wow7LmXHmq16PxDMXwP(object P_0)
	{
		return ((SwimlaneElement)P_0).SwimlaneType;
	}

	internal static bool mejKXvXLD35pmTIcvka(object P_0)
	{
		return ((SwimlaneElement)P_0).ChangeResponsible;
	}

	internal static object JDQp0NXfKKGQuxsMuZ5(object P_0)
	{
		return ((IWorkflowInstance)P_0).Responsible;
	}

	internal static bool NYgt8oX959LEl0ihRpt(object P_0)
	{
		return ((SwimlaneElement)P_0).SenNotificationToNewResponsible;
	}

	internal static object mX8V1eXWPogSGTl8pfj(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object j1KtReXjetb6lr7wSZn(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object ppSrVpXRt4pkCJRUWMo(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object n3muwoX6QYLYieTM4AV(object P_0)
	{
		return ((IFilter)P_0).FilterFields;
	}

	internal static object H8Y7evXqD7qQYhtWoZJ(object P_0, object P_1, object P_2, object P_3)
	{
		return UniversalFilterSaver.UnPack(P_0, (ReferenceOnEntityType)P_1, (IEntityFilter)P_2, (ITypeWrapperResolver)P_3);
	}

	internal static int lKksXwX3P7jga7pxehS(object P_0)
	{
		return ((List<WorkflowInstanceStatus>)P_0).Count;
	}

	internal static object qMaPAhXT2O0Ktp5OsZb(object P_0, object P_1)
	{
		return ((EntityManager<IWorkflowInstance, long>)P_0).AliasProperty((string)P_1);
	}

	internal static object VuXotDXQ6LwktchEluq(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static Type WSseABXpjiKY6YLm0r6(object P_0)
	{
		return ((ICriteria)P_0).GetRootEntityTypeIfAvailable();
	}

	internal static bool wqhTJZXCiTw74InZwft(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object XMoJhjXMOGXlpT03IN9(object P_0)
	{
		return ((IWorkflowInstanceFilter)P_0).TaskName;
	}

	internal static object d6LV7mXkB5VDj8IlAh0(object P_0, object P_1, object P_2)
	{
		return ElmaRestrictions.InsensitiveLike((string)P_0, (string)P_1, (MatchMode)P_2);
	}

	internal static object cMXllvXUc8RrgFHjRdJ(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object W2ycwdXVv3GLu83lRNm(object P_0)
	{
		return ((IWorkflowInstanceFilter)P_0).TaskExecutor;
	}

	internal static int kp877EXAho5NEPaeSKh(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static Guid xOubfOXG3fOHhhcHtdS(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static object CiP1FhX78JAuSktVyun(Type P_0, object P_1)
	{
		return DetachedCriteria.For(P_0, (string)P_1);
	}

	internal static object rv6eGmX2FlSReM2fGgO(object P_0)
	{
		return ((EntityManager<IWorkflowInstance, long>)P_0).DefaultCriteriaAlias;
	}

	internal static object RYD255XoJn93q4u1Dx5(object P_0, object P_1)
	{
		return Restrictions.EqProperty((string)P_0, (string)P_1);
	}

	internal static object ivpALDXFrn7MgtV2sfC(object P_0, object P_1)
	{
		return ((ProjectionList)P_0).Add((IProjection)P_1);
	}

	internal static object Y3ErIlXiiVEmFP57NWK(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).SetProjection((IProjection)P_1);
	}

	internal static object mckpYOXI1GXdvu9DpQ5(object P_0)
	{
		return Subqueries.Exists((DetachedCriteria)P_0);
	}

	internal static bool KMAga8XaLiW5J2e9IZT(object P_0, object P_1)
	{
		return ((ISecurityService)P_0).HasPermission((Permission)P_1);
	}

	internal static object tHhVFXXrjR4Ik0hSFOI(object P_0)
	{
		return Expression.Sql((string)P_0);
	}

	internal static object yt3HGqXe0eo3LH5CJ02(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (ICollection)P_1);
	}

	internal static Guid bSV4fPXNrxwqYNvM52N(object P_0)
	{
		return ((PermissionRoleType)P_0).UID;
	}

	internal static object jTHNWJXxUci5VWZ7w88(object P_0, object P_1, object P_2, JoinType P_3)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return ((DetachedCriteria)P_0).CreateAlias((string)P_1, (string)P_2, P_3);
	}

	internal static object rb2JjAXSLY8K5tNHMqX()
	{
		return TaskBaseExtensions.ActiveTaskStatuses;
	}

	internal static object wruAT3X1gddVpfXIgbB(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (object[])P_1);
	}

	internal static object X0D18YXhB3QKjJTla2d()
	{
		return Projections.ProjectionList();
	}

	internal static object ipWmXbXEoWR0IK4UQOo()
	{
		return Projections.Id();
	}

	internal static object F2U0sFXwlSbk2DmssZx(object P_0, object P_1, object P_2)
	{
		return Expression.Sql((string)P_0, P_1, (IType)P_2);
	}

	internal static object FYgeKbX4EtRvD85g0Kg(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object ohokmvXzPhbPCaTYtWd(object P_0, object P_1, object P_2)
	{
		return ((SqlSubQuery)P_0).SetParameter((string)P_1, P_2);
	}

	internal static object iS8coVdKOEVyDJQ4w4V(object P_0)
	{
		return ((SqlSubQuery)P_0).Sql;
	}

	internal static object JEJiF8dOd4CSdQPcKjv(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object cktAwBdZB5OEo6jQXwy(object P_0)
	{
		return ((SqlSubQuery)P_0).ParametersValues;
	}

	internal static object hwJUUudv9c6dYsalCYO(object P_0)
	{
		return ((SqlSubQuery)P_0).ParametersTypes;
	}

	internal static object Aquf1adYv1g3cWVewVG(object P_0, object P_1, object P_2)
	{
		return NHQueryExtensions.Sql((string)P_0, (object[])P_1, (IType[])P_2);
	}

	internal static int pPSqBfd8bshc8K2Xg5E(object P_0)
	{
		return ((ICollection<long>)P_0).Count;
	}

	internal static object hHhoNsdsvqVSv6Avon3()
	{
		return ComponentManager.Current;
	}

	internal static object wf48nhdJQytHOCYhNqS(object P_0, object P_1, Type P_2, object P_3, object P_4)
	{
		return ((EntityManager<IWorkflowInstance, long>)P_0).CreateCriteria((FetchOptions)P_1, P_2, (string)P_3, (IEntityFilter)P_4);
	}

	internal static bool c51bqCdlg6e24hyIANY(object P_0, object P_1)
	{
		return (FetchOptions)P_0 != (FetchOptions)P_1;
	}

	internal static object XQdnhwd0XAZfYBUTL8l(object P_0)
	{
		return ((IWorkflowInstanceFilter)P_0).ContextFilter;
	}

	internal static void IPD4T8dyrTChX9eDFoG(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		((EntityManager<IWorkflowInstance, long>)P_0).SetupAutoFilter((ICriteria)P_1, (IEntityFilter)P_2, (EntityMetadata)P_3, (string)P_4);
	}

	internal static object I4W5rfdmLjt8FU4Cj6j(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object ktxuUGdtlfaRD7e2yoD(Type P_0, object P_1)
	{
		return P_0.GetReflectionProperty((string)P_1);
	}

	internal static long CB1yvAdbkFIJ2cMXg4G(object P_0)
	{
		return ((IWorkflowProcess)P_0).VersionNumber;
	}

	internal static object xvS1p8d5p4t1VodExkk(object P_0)
	{
		return ((IWorkflowProcess)P_0).Header;
	}

	internal static bool W719Rddgelf62qRiD4g(object P_0, object P_1, object P_2, bool P_3)
	{
		return ((ISecurityService)P_0).HasPermission((Permission)P_1, P_2, P_3);
	}

	internal static WorkflowInstanceStatus mqDYdFdBxKKEHS0qs9b(object P_0)
	{
		return ((IWorkflowInstance)P_0).Status;
	}

	internal static object wdsbFsdcOdHnbky2mkR(object P_0)
	{
		return ((IProcessHeader)P_0).Name;
	}

	internal static object JD0sNOdP8mORWkILLjV(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static Type S7lXYkdXEDvfrIuGyWO(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object IHtnugddFaSe5nOdPtM(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object srYtyFduR99qDyw8nyT(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static object bl7IuWdDnRoc33FrXmr(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object wHbCb5dnJeowlRHWGIa(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object hL90FTdHovUuXS82rH0(object P_0, object P_1, bool P_2, object P_3)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1, P_2, (MethodInfo)P_3);
	}

	internal static object RrbNVVdL8exMkTO4mNp(object P_0, object P_1)
	{
		return Expression.AndAlso((Expression)P_0, (Expression)P_1);
	}

	internal static object Yj9i9EdfiJqRV2wlLqk(Type processEntityType)
	{
		return WorkflowProcessManager.GetManager(processEntityType);
	}

	internal static object yefXdud9YaVZ6lt5s0h(object P_0, object P_1, object P_2, object P_3)
	{
		return ((IWorkflowProcessManager)P_0).ValidateChangeVersion((IWorkflowProcess)P_1, (IWorkflowProcess)P_2, (Guid[])P_3);
	}

	internal static object SkuSuZdWs43xldP5tHy(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object R8xsYOdjbuqnQAndy5J(object P_0, object P_1)
	{
		return ((ISession)P_0).GetNamedQuery((string)P_1);
	}

	internal static DateTime NePRJndRP6g44rJtKvy()
	{
		return DateTime.Now;
	}

	internal static object iGp52ud6VoVT8BNhuaD()
	{
		return EleWise.ELMA.Security.Services.AuthenticationService.GetCurrentUser();
	}

	internal static object EfOPSLdqPUZ6Si52JTd(object P_0)
	{
		return ((IIdentified)P_0).GetId();
	}

	internal static object YwbCGsd30i7MG8oIaje(object P_0, object P_1, object P_2)
	{
		return ((IQuery)P_0).SetParameter((string)P_1, P_2);
	}

	internal static int w23MkNdTx0BgxZfsIV0(object P_0, bool P_1)
	{
		return ((IQuery)P_0).ExecuteUpdate(P_1);
	}

	internal static void bVHox6dQELBa1gUMPfQ(object P_0, object P_1)
	{
		((ISession)P_0).CleanUpCache((Type[])P_1);
	}

	internal static void bExou3dp6uF6ANIAHUp(object P_0, object P_1)
	{
		((ICommentActionModel)P_0).Comment = (IComment)P_1;
	}

	internal static void IWbfTqdCG56ydao7ys3(object P_0, object P_1, object P_2)
	{
		((ICommentActionHandler)P_0).Process(P_1, (ICommentActionModel)P_2);
	}

	internal static Guid dTUeBbdMVVZuB0jv2iO()
	{
		return WorkflowInstanceActions.AddCommentGuid;
	}

	internal static object EiSQwldkNhyBXjtZCOA(object P_0)
	{
		return ((IAuthenticationService)P_0).GetCurrentUser();
	}

	internal static void tmA8GldUZQWRMSNf3oV(object P_0, object P_1, object P_2)
	{
		((WorkflowInstanceManager)P_0).AddComment((IWorkflowInstance)P_1, (string)P_2);
	}

	internal static long hy2wD9dV82P4D4J11dI(object P_0)
	{
		return ((WorkflowInstanceTimerInfo)P_0).SchedulerJobId;
	}

	internal static SchedulerTaskStatus oAIrdHdAsYjh0B43eq5(object P_0)
	{
		return ((ISchedulerTask)P_0).Status;
	}

	internal static void PdRYnTdGaRVhtEkX1GS(object P_0, object P_1, DateTime time)
	{
		((WorkflowInstanceManager)P_0).ChangeTimer((IResumeProcessSchedulerJob)P_1, time);
	}

	internal static void NRgY7id7sSYNrJSrPyN(object P_0, object P_1)
	{
		((IProcessHeaderPermission)P_0).ProcessHeader = (IProcessHeader)P_1;
	}

	internal static void cGsFgYd2S2fc5QaV7Ri(object P_0, Guid value)
	{
		((IProcessHeaderPermission)P_0).PermissionId = value;
	}

	internal static void fRqOsQdoqlGVk0P2ujQ(object P_0, object P_1)
	{
		((IProcessHeaderPermission)P_0).User = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static long IdCWvWdFEFEUQpj6Qpi(long P_0)
	{
		return UserSecuritySetHelper.GetUserMask(P_0);
	}

	internal static void zVUjFQdiN27N3VmsGWk(object P_0, object P_1)
	{
		((IProcessHeaderPermission)P_0).Group = (IUserGroup)P_1;
	}

	internal static void Bf1XPfdIf2oQB3k4Koy(object P_0, object P_1)
	{
		((Filter)P_0).Query = (string)P_1;
	}

	internal static void uH22CddaXV65prnmHq4(object P_0, object P_1)
	{
		((IProcessHeaderPermission)P_0).OrganizationItemPosition = (IOrganizationItem)P_1;
	}

	internal static long O8nUd4dr8pyJrUCWmTJ(long P_0)
	{
		return UserSecuritySetHelper.GetOrganizationItemMask(P_0);
	}

	internal static object SSeSqSdemHJMUsgtWUL(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object VKAe6pdNyQjX8vFGHeT()
	{
		return Instance;
	}

	internal static void iQK3yUdxYIQAVsBQ520(object P_0, object P_1)
	{
		((IWorkflowInstance)P_0).Process = (IWorkflowProcess)P_1;
	}

	internal static void EwX7PhdSl0vhm5QE26h(object P_0, object P_1)
	{
		((IWorkflowInstance)P_0).Initiator = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static object u5rArgd1JDtpmE0MdPH(object P_0)
	{
		return ((PropertyDescriptorCollection)P_0).GetEnumerator();
	}

	internal static object SGYisMdhlWyTOYfkpYK(object P_0)
	{
		return ((IEnumerator)P_0).Current;
	}

	internal static object Q7ILkWdEjL9p7GSW8ir(object P_0)
	{
		return ((MemberDescriptor)P_0).Name;
	}

	internal static bool M4h8ZBdw7d8J7uGFI13(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static void THeTrmd47qOnNneRr7Y(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool fsj6HfdzlBRAIiMZE0f(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void PknKrGuKZa3YemFMV5K(object P_0, object P_1)
	{
		((IWorkflowRuntimeService)P_0).Run((IWorkflowInstance)P_1);
	}

	internal static object tWrakWuObyxC6wOblku(RuntimeMethodHandle P_0, RuntimeTypeHandle P_1)
	{
		return MethodBase.GetMethodFromHandle(P_0, P_1);
	}

	internal static object yIlsNWuZNOQBj5Y2Ai8(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object Y15oMyuvd0KoPbiKnPE(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}
}
