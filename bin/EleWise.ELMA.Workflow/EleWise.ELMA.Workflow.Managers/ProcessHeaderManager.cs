using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.Cache;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.ExportHelper;
using EleWise.ELMA.Events;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.DTO.Models;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.Actors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.SubProcess;
using EleWise.ELMA.Workflow.BPMN.Models;
using EleWise.ELMA.Workflow.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using EleWise.ELMA.Workflow.Security;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using NHibernate.Transform;
using NHibernate.Type;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class ProcessHeaderManager : EntityManager<IProcessHeader, long>, IProcessHeaderManager, IEntityManager<IProcessHeader, long>, IEntityManager<IProcessHeader>, IEntityManager
{
	private sealed class WorkflowProcessPublicationEventHandler : IWorkflowProcessPublicationEventHandler, IEventHandler
	{
		private readonly object actor;

		private readonly long workflowProcessHeaderId;

		private readonly TaskCompletionSource<bool> taskCompletionSource;

		internal static object uRDwtdZQo5738JZoAoGC;

		public Task Wait => taskCompletionSource.Task;

		public WorkflowProcessPublicationEventHandler(IWorkflowProcessPublicationActor actor, long workflowProcessHeaderId)
		{
			//Discarded unreachable code: IL_002c, IL_0031
			gGJp2iZQIHCrZ1bnf3Ly();
			taskCompletionSource = new TaskCompletionSource<bool>(TaskCreationOptions.RunContinuationsAsynchronously);
			base._002Ector();
			int num = 2;
			while (true)
			{
				switch (num)
				{
				case 1:
					return;
				default:
					this.workflowProcessHeaderId = workflowProcessHeaderId;
					num = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b != 0)
					{
						num = 0;
					}
					break;
				case 2:
					this.actor = actor;
					num = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		public Task Complete(long processHeaderId)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (workflowProcessHeaderId != processHeaderId)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
						{
							num2 = 0;
						}
						break;
					}
					taskCompletionSource.TrySetResult(result: true);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return (Task)sdPI7kZQr6J6BFd5GdyV(actor);
				case 1:
					return (Task)QuXXhEZQaFDBsEPykSje();
				}
			}
		}

		public Task Error(long processHeaderId, Exception exception)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (workflowProcessHeaderId != processHeaderId)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b != 0)
						{
							num2 = 1;
						}
						break;
					}
					msT1qpZQecpXi5ZAk6Uu(taskCompletionSource, exception);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return ((IWorkflowProcessPublicationActor)actor).PublicationComplete();
				case 1:
					return (Task)QuXXhEZQaFDBsEPykSje();
				}
			}
		}

		internal static void gGJp2iZQIHCrZ1bnf3Ly()
		{
			j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		}

		internal static bool sWBp6MZQFRhPbFldNjMR()
		{
			return uRDwtdZQo5738JZoAoGC == null;
		}

		internal static WorkflowProcessPublicationEventHandler rPWLEwZQiNkdtofdObnL()
		{
			return (WorkflowProcessPublicationEventHandler)uRDwtdZQo5738JZoAoGC;
		}

		internal static object QuXXhEZQaFDBsEPykSje()
		{
			return Task.CompletedTask;
		}

		internal static object sdPI7kZQr6J6BFd5GdyV(object P_0)
		{
			return ((IWorkflowProcessPublicationActor)P_0).PublicationComplete();
		}

		internal static bool msT1qpZQecpXi5ZAk6Uu(object P_0, object P_1)
		{
			return ((TaskCompletionSource<bool>)P_0).TrySetException((Exception)P_1);
		}
	}

	public static string GetProcessMonitorAllHeaderInfoTimeStamp;

	private IWorkflowMetadataLoaderService workflowMetadataLoaderService;

	private static ProcessHeaderManager AgVrx3HlNciW7GRQc5v;

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
				case 1:
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
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

	public WorkflowProcessManager WorkflowProcessManager => Locator.GetServiceNotNull<WorkflowProcessManager>();

	public IContextBoundVariableService ContextBoundVariableService => Locator.GetServiceNotNull<IContextBoundVariableService>();

	public IActorModelRuntime ActorModelRuntime
	{
		[CompilerGenerated]
		get
		{
			return _003CActorModelRuntime_003Ek__BackingField;
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
					_003CActorModelRuntime_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
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

	public IEventHandlerSubscribeService EventHandlerSubscribeService
	{
		[CompilerGenerated]
		get
		{
			return _003CEventHandlerSubscribeService_003Ek__BackingField;
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
					_003CEventHandlerSubscribeService_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IRuntimeApplication RuntimeApplication
	{
		[CompilerGenerated]
		get
		{
			return _003CRuntimeApplication_003Ek__BackingField;
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
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
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

	public UserGroupManager UserGroupManager
	{
		[CompilerGenerated]
		get
		{
			return _003CUserGroupManager_003Ek__BackingField;
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
					_003CUserGroupManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
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

	public new static ProcessHeaderManager Instance => Locator.GetServiceNotNull<ProcessHeaderManager>();

	private IWorkflowMetadataLoaderService WorkflowMetadataLoaderService
	{
		get
		{
			int num = 1;
			int num2 = num;
			IWorkflowMetadataLoaderService workflowMetadataLoaderService = default(IWorkflowMetadataLoaderService);
			IWorkflowMetadataLoaderService obj;
			while (true)
			{
				switch (num2)
				{
				default:
					workflowMetadataLoaderService = (this.workflowMetadataLoaderService = Locator.GetServiceNotNull<IWorkflowMetadataLoaderService>());
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					obj = this.workflowMetadataLoaderService;
					if (obj == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e != 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 2:
					obj = workflowMetadataLoaderService;
					break;
				}
				break;
			}
			return obj;
		}
	}

	[ContextCache]
	public virtual IEnumerable<IProcessHeader> LoadMyResponsibilityProcess()
	{
		return base.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495267062)).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x1134B918), InterfaceActivator.UID<IOrganizationItem>(loadImplementation: false)).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22376446), InterfaceActivator.UID<IUserGroup>(loadImplementation: false))
			.SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8D5763A ^ 0x8D51A2A), base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>().Id)
			.CleanUpCache(cleanUpCache: false)
			.List<IProcessHeader>();
	}

	public IEnumerable<IProcessHeader> LoadRootProcessHeads()
	{
		return CreateRootProcessHeadsCriteria().List<IProcessHeader>();
	}

	public IEnumerable<IProcessHeader> LoadRootProcessHeads(RuntimeVersion runtimeVersion)
	{
		ICriteria val = CreateRootProcessHeadsCriteria().CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1574607501 ^ -1574573237), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949683591), (JoinType)1);
		switch (runtimeVersion)
		{
		case RuntimeVersion.Version1:
			val.Add((ICriterion)(object)Restrictions.IsNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x6281E9E6)));
			break;
		case RuntimeVersion.Version2:
			val.Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x6281E9E6)));
			break;
		}
		return val.List<IProcessHeader>();
	}

	public IEnumerable<IProcessHeader> GetPublishedProcessHeads(IProcessGroup group)
	{
		return CreateRootProcessHeaderCriteria(group).Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351354844))).List<IProcessHeader>();
	}

	public IEnumerable<IProcessHeader> GetRootProcessHeaders(IProcessGroup group)
	{
		return CreateRootProcessHeaderCriteria(group).List<IProcessHeader>();
	}

	public IEnumerable<IProcessHeader> GetAvailableProcessHeaders()
	{
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		IUserGroup userGroup = UserGroupManager.LoadOrNull(SecurityConstants.AllUsersGroupUid);
		string text = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6CC04061 ^ 0x6CC0CEED), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197762010)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720441549)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF6618C)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -540009527)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x350C0E8 ^ 0x3509E60)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x36166E3F)));
		return ((IQuery)base.Session.CreateSQLQuery(text).AddEntity(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1430645277 ^ -1430621859), InterfaceActivator.TypeOf<IProcessHeader>())).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057758753), userGroup.Id).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1430645277 ^ -1430616741), currentUser.Id).SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716487405), 3)
			.CleanUpCache(cleanUpCache: false)
			.List<IProcessHeader>()
			.ToList();
	}

	public IEnumerable<IProcessHeader> GetStartableProcesses(IProcessHeaderFilter filter = null)
	{
		return GetStartableProcesses(new List<WorkflowProcessRunAvailability> { WorkflowProcessRunAvailability.Allowed }, filter);
	}

	public IEnumerable<IProcessHeader> GetStartableProcesses(List<WorkflowProcessRunAvailability> runAvailability, IProcessHeaderFilter filter = null)
	{
		return (from id in GetStartableProcessIds(runAvailability, filter)
			select Load(id)).ToList();
	}

	public IEnumerable<long> GetStartableProcessIds(IProcessHeaderFilter filter = null)
	{
		return GetStartableProcessIds(new List<WorkflowProcessRunAvailability> { WorkflowProcessRunAvailability.Allowed }, filter);
	}

	public IEnumerable<long> GetStartableProcessIds(List<WorkflowProcessRunAvailability> runAvailability, IProcessHeaderFilter filter = null)
	{
		if (filter == null)
		{
			filter = InterfaceActivator.Create<IProcessHeaderFilter>();
		}
		List<long> list = filter.UserIds;
		if (list == null)
		{
			EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
			list = new List<long> { currentUser.Id };
			list.AddRange(ReplacementManager.Instance.GetReplacedUsers(currentUser));
		}
		return base.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12FF892)).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-130098986 ^ -130108658), InterfaceActivator.UID<IOrganizationItem>(loadImplementation: false)).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F44D93A ^ 0x2F44B2C8), InterfaceActivator.UID<IUserGroup>(loadImplementation: false))
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F05484), 1)
			.SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6D1754), (IEnumerable)list.ToArray())
			.SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776342090), (IEnumerable)runAvailability.ToArray())
			.CleanUpCache(cleanUpCache: false)
			.List<long>()
			.Distinct()
			.ToList();
	}

	public IEnumerable<IProcessHeader> GetStartableProcessesAll()
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11816444))).Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516524382)), (object)WorkflowProcessRunAvailability.Allowed)).List<IProcessHeader>()
			.Distinct(delegate(IProcessHeader p1, IProcessHeader p2)
			{
				//Discarded unreachable code: IL_0035, IL_0044, IL_0065, IL_0074
				int num = 3;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 4:
						return p1.Id == p2.Id;
					case 1:
					case 2:
						return false;
					default:
						if (p2 == null)
						{
							num2 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 4;
					case 3:
						if (p1 == null)
						{
							num2 = 2;
							break;
						}
						goto default;
					}
				}
			})
			.ToList();
	}

	public IEnumerable<long> GetStartableProcessesAllIds()
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.IsNotNull(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--296112178 ^ 0x11A616A8))).Add((ICriterion)(object)Restrictions.Eq((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x3616B9B7)), (object)WorkflowProcessRunAvailability.Allowed)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Id() })
			.List<long>()
			.Distinct()
			.ToList();
	}

	public IEnumerable<IProcessHeader> GetStartableProcessesObject(IProcessHeaderFilter filter = null)
	{
		return GetStartableProcesses(new List<WorkflowProcessRunAvailability>
		{
			WorkflowProcessRunAvailability.Allowed,
			WorkflowProcessRunAvailability.DeniedForUsers
		}, filter);
	}

	public IEnumerable<long> GetStartableProcessIdsObject(IProcessHeaderFilter filter = null)
	{
		return GetStartableProcessIds(new List<WorkflowProcessRunAvailability>
		{
			WorkflowProcessRunAvailability.Allowed,
			WorkflowProcessRunAvailability.DeniedForUsers
		}, filter);
	}

	public List<IProcessHeaderPermission> GetPermissions(IProcessHeader header, Permission permission = null)
	{
		ICriteria val = base.Session.CreateCriteria(InterfaceActivator.TypeOf<IProcessHeaderPermission>()).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-947937941 ^ -947922035), (object)header));
		if (permission != null)
		{
			val.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-106528299 ^ -106557249), (object)permission.Id));
		}
		return val.List<IProcessHeaderPermission>().ToList();
	}

	public List<IProcessHeaderAccess> GetAccessSettings(IProcessHeader header, Permission permission = null)
	{
		ICriteria val = base.Session.CreateCriteria(InterfaceActivator.TypeOf<IProcessHeaderAccess>()).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135692056), (object)header));
		if (permission != null)
		{
			val.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2002063381 ^ -2002092415), (object)permission.Id));
		}
		return val.List<IProcessHeaderAccess>().ToList();
	}

	public IEnumerable<ProcessHeaderInfo> GetProcessesInfo(long? processHeaderId, bool filterByMembers = true, bool isEmulation = false)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		return base.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747F6A66)).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C667233), currentUser.Id).SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x65B7F624 ^ 0x65B76796), processHeaderId.HasValue ? processHeaderId.Value : 0)
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-106528299 ^ -106557439), filterByMembers ? 1 : 0)
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29981480 ^ -30009858), 1)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ProcessHeaderInfo)))
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD305CC2 ^ 0xD30133E), isEmulation ? 1 : 0)
			.CleanUpCache(cleanUpCache: false)
			.List<ProcessHeaderInfo>();
	}

	public IEnumerable<ProcessHeaderInfo> GetMonitorProcessesInfo(IProcessHeaderFilter filter)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		return base.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949688891)).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x157D5AF4 ^ 0x157D312C), InterfaceActivator.UID<IOrganizationItem>(loadImplementation: false)).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x595C500A ^ 0x595C3BF8), InterfaceActivator.UID<IUserGroup>(loadImplementation: false))
			.SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498848777), currentUser.Id)
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C7F6FED ^ 0x1C7FFDAD), filter.IsCurator.HasValue ? 1 : 0)
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495268714), (!filter.IsCurator.HasValue) ? (-1) : (filter.IsCurator.Value ? 1 : 0))
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D65B6B), filter.ResponsibilityLevels.HasItems() ? 1 : 0)
			.SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F53152A), (IEnumerable)((filter.ResponsibilityLevels != null) ? filter.ResponsibilityLevels.Select((ResponsibilityLevel l) => (int)l).ToArray() : new int[1] { -1 }))
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360699637), filter.PermissionId.HasValue ? 1 : 0)
			.SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776343004), filter.PermissionId.HasValue ? filter.PermissionId.Value : Guid.Empty)
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1516552726 ^ -1516524340), 1)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ProcessHeaderInfo)))
			.CleanUpCache(cleanUpCache: false)
			.List<ProcessHeaderInfo>();
	}

	[ContextCache]
	public virtual IEnumerable<ProcessHeaderInfo> GetMonitorProcessesAllInfo(string text = "")
	{
		_003C_003Ec__DisplayClass45_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass45_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.text = text;
		CS_0024_003C_003E8__locals0.user = base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		IComplexCacheService serviceNotNull = Locator.GetServiceNotNull<IComplexCacheService>();
		string key = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7AC609FE ^ 0x7AC69B08), CS_0024_003C_003E8__locals0.user.Id);
		List<ProcessHeaderInfo> orAdd = serviceNotNull.GetOrAdd(key, GetProcessMonitorAllHeaderInfoTimeStamp, () => CS_0024_003C_003E8__locals0._003C_003E4__this.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057755077)).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x738ABA6E ^ 0x738AD1B6), InterfaceActivator.UID<IOrganizationItem>(loadImplementation: false)).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x1145D525), InterfaceActivator.UID<IUserGroup>(loadImplementation: false))
			.SetParameter<long>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050347344), CS_0024_003C_003E8__locals0.user.Id)
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--296112178 ^ 0x11A6C250), 1)
			.SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F09AD4), (IEnumerable)new int[1] { 2 })
			.SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514194428), WorkflowPermissionProvider.ProcessMonitor.Id)
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1108914542), 1)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ProcessHeaderInfo)))
			.CleanUpCache(cleanUpCache: false)
			.List<ProcessHeaderInfo>()
			.ToList());
		if (!string.IsNullOrEmpty(CS_0024_003C_003E8__locals0.text))
		{
			return orAdd.Where(delegate(ProcessHeaderInfo r)
			{
				//Discarded unreachable code: IL_0072, IL_0081
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return _003C_003Ec__DisplayClass45_0.wIXIBrZpvnHOLbXQdgRh(_003C_003Ec__DisplayClass45_0.XsMgnkZpOOEwS1HlOxsV(r), CS_0024_003C_003E8__locals0.text, StringComparison.OrdinalIgnoreCase) >= 0;
					case 1:
						return false;
					case 2:
						if (_003C_003Ec__DisplayClass45_0.fXMQx0ZpZPT8WbFVHOYV(_003C_003Ec__DisplayClass45_0.XsMgnkZpOOEwS1HlOxsV(r)))
						{
							num2 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
							{
								num2 = 1;
							}
							break;
						}
						goto default;
					}
				}
			}).ToList();
		}
		return orAdd;
	}

	public IEnumerable<ProcessHeaderInfo> LoadProcessHeadFullTree(string nameProcess = null, int[] listUser = null, bool isEmulation = false)
	{
		if (listUser == null)
		{
			listUser = new int[1];
		}
		if (listUser.Length == 0)
		{
			listUser = new int[1];
		}
		Guid metadataUid = OrganizationItemDTO.MetadataUid;
		Guid metadataUid2 = UserGroupDTO.MetadataUid;
		nameProcess = ((nameProcess != null) ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-667465279 ^ -667428097), nameProcess.ToUpper()) : "");
		int num = ((!(nameProcess == "")) ? 1 : 0);
		return base.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-935313063 ^ -935276011)).SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D6872F), (IEnumerable)new int[1] { 1 }).SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x350C0E8 ^ 0x3508EB6), (IEnumerable)new int[1] { 2 })
			.SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213F2A09), (IEnumerable)new int[2] { 3, 4 })
			.SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2002063381 ^ -2002083505), (IEnumerable)((IEnumerable<TaskBaseStatus>)TaskBaseExtensions.ActiveTaskStatuses).Select((Func<TaskBaseStatus, Guid>)((TaskBaseStatus s) => s)).ToArray())
			.SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF69A2A), metadataUid)
			.SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1134D2C0 ^ 0x113441BE), metadataUid2)
			.SetParameter<string>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2269BD32 ^ 0x22692E96), nameProcess)
			.SetParameterList(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x651FE29D ^ 0x651F7123), (IEnumerable)listUser.ToArray())
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EF93B1), num)
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA73AA12), isEmulation ? 1 : 0)
			.SetParameter<int>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x101452B), isEmulation ? 1 : 0)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ProcessHeaderInfo)))
			.CleanUpCache(cleanUpCache: false)
			.List<ProcessHeaderInfo>();
	}

	public IEnumerable<DocumentationProcessHeaderInfo> LoadDocumentationProcessHeadFullTree()
	{
		Guid metadataUid = OrganizationItemDTO.MetadataUid;
		Guid metadataUid2 = UserGroupDTO.MetadataUid;
		return base.Session.GetNamedQuery(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-885093259 ^ -885123021)).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75872B6 ^ 0x758196E), metadataUid).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -452098521), metadataUid2)
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(DocumentationProcessHeaderInfo)))
			.CleanUpCache(cleanUpCache: false)
			.List<DocumentationProcessHeaderInfo>();
	}

	public virtual void Publish(IEnumerable<IProcessHeader> processHeaders, string comment)
	{
		Publish(processHeaders, comment, generateDocumentation: false);
	}

	public virtual void Publish(IEnumerable<IProcessHeader> processHeaders, string comment, bool generateDocumentation)
	{
		PublishInternal(processHeaders, comment, generateDocumentation, isEmulation: false);
	}

	[Transaction]
	protected virtual void PublishInternal(IEnumerable<IProcessHeader> processHeaders, string comment, bool generateDocumentation, bool isEmulation)
	{
		Contract.ArgumentNotNull(processHeaders, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712456755));
		foreach (IProcessHeader processHeader in processHeaders)
		{
			PublishAsync(processHeader, comment, generateDocumentation, isEmulation).GetAwaiter().GetResult();
		}
	}

	public virtual void Publish(IProcessHeader processHeader, string comment)
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
				txgU0MHmyxrYXWlQwa1(this, processHeader, comment, false);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public virtual void Publish(IProcessHeader processHeader, string comment, bool generateDocumentation)
	{
		int num = 2;
		int num2 = num;
		TaskAwaiter taskAwaiter = default(TaskAwaiter);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				taskAwaiter = AwbItAHtqB0y4p3GsTs(PublishAsync(processHeader, comment, generateDocumentation, isEmulation: false));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				taskAwaiter.GetResult();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CPublishAsync_003Ed__53))]
	private Task PublishAsync(IProcessHeader processHeader, string comment, bool generateDocumentation, bool isEmulation)
	{
		int num = 7;
		int num2 = num;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CPublishAsync_003Ed__53 stateMachine = default(_003CPublishAsync_003Ed__53);
		while (true)
		{
			switch (num2)
			{
			case 2:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				stateMachine.generateDocumentation = generateDocumentation;
				num2 = 5;
				break;
			case 4:
				return stateMachine._003C_003Et__builder.Task;
			case 7:
				stateMachine._003C_003E4__this = this;
				num2 = 6;
				break;
			case 5:
				stateMachine.isEmulation = isEmulation;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				stateMachine._003C_003E1__state = -1;
				num2 = 2;
				break;
			case 1:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
				{
					num2 = 3;
				}
				break;
			case 9:
				stateMachine.comment = comment;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
				{
					num2 = 8;
				}
				break;
			default:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 4;
				break;
			case 6:
				stateMachine.processHeader = processHeader;
				num2 = 9;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void Unpublish(IEnumerable<long> processHeaderIds)
	{
		Contract.ArgumentNotNull(processHeaderIds, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D4DD1D));
		foreach (long processHeaderId in processHeaderIds)
		{
			IProcessHeader processHeader = LoadOrNull(processHeaderId);
			if (processHeader != null)
			{
				Unpublish(processHeader);
			}
		}
	}

	[Transaction]
	public virtual void Unpublish(IProcessHeader header)
	{
		//Discarded unreachable code: IL_00d8, IL_00e7, IL_00f2, IL_01ac, IL_01e4, IL_01f3
		int num = 3;
		int num2 = num;
		IEnumerator<IProcessHeader> enumerator = default(IEnumerator<IProcessHeader>);
		IProcessHeader current = default(IProcessHeader);
		while (true)
		{
			switch (num2)
			{
			case 1:
				enumerator = ((IEnumerable<IProcessHeader>)header.SubHeaders).GetEnumerator();
				num2 = 4;
				break;
			case 6:
				n3yDpIHBturqUWvOCiM(header, true);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				AnU5VrH5UsTeMMG3UvE(header, rvcFKgHb2pteEnR2GTv(-63028171 ^ -63034101));
				num2 = 2;
				break;
			case 2:
				PYwbTBHgZioeA93dFIE(header, WorkflowProcessStatus.Draft);
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 != 0)
				{
					num2 = 6;
				}
				break;
			default:
				Save(header);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 3;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
							{
								num3 = 2;
							}
							goto IL_00f6;
						}
						goto IL_013a;
						IL_013a:
						current = enumerator.Current;
						num3 = 2;
						goto IL_00f6;
						IL_00f6:
						while (true)
						{
							switch (num3)
							{
							case 1:
								goto IL_013a;
							case 4:
								Unpublish(current);
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								if (ym4dh5Hcvwrw89c5Rx2(current) == WorkflowProcessStatus.Published)
								{
									num3 = 4;
									continue;
								}
								break;
							case 3:
								return;
							}
							break;
						}
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								D4Ug5yHPwwK89lLN8AD(enumerator);
								num4 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
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
				}
			case 5:
				return;
			}
		}
	}

	[Transaction]
	public override void Delete(IProcessHeader header)
	{
		//Discarded unreachable code: IL_00d6, IL_00e0, IL_018f, IL_01c7, IL_023e, IL_024d, IL_025c
		int num = 7;
		IEnumerator<IProcessHeader> enumerator = default(IEnumerator<IProcessHeader>);
		_003C_003Ec__DisplayClass56_0 _003C_003Ec__DisplayClass56_ = default(_003C_003Ec__DisplayClass56_0);
		IProcessHeader current = default(IProcessHeader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					uSGJD9HDA1aSkUA7wyV(JSIxfjHuhlhdpTx2w8r());
					num = 16;
					break;
				case 12:
					enumerator = ((IEnumerable<IProcessHeader>)_003C_003Ec__DisplayClass56_.header.SubHeaders).GetEnumerator();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 != 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
				case 16:
					uJX5uPHnPujVw0aRGrv(_003C_003Ec__DisplayClass56_.header, null);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
					{
						num2 = 10;
					}
					continue;
				case 1:
					try
					{
						while (true)
						{
							int num3;
							if (!ME0NO8HLWGvt0UYHYB0(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
								{
									num3 = 0;
								}
								goto IL_00e4;
							}
							goto IL_0146;
							IL_0146:
							current = enumerator.Current;
							num3 = 1;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
							{
								num3 = 1;
							}
							goto IL_00e4;
							IL_00e4:
							while (true)
							{
								switch (num3)
								{
								default:
									return;
								case 1:
									Delete(current);
									num3 = 3;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
									{
										num3 = 2;
									}
									continue;
								case 3:
									break;
								case 2:
									goto IL_0146;
								case 0:
									return;
								}
								break;
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									enumerator.Dispose();
									num4 = 0;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
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
					}
				case 5:
					if (jFYQOBHXcKYF0SPLCbM(_003C_003Ec__DisplayClass56_.header) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 7:
					_003C_003Ec__DisplayClass56_ = new _003C_003Ec__DisplayClass56_0();
					num2 = 6;
					continue;
				case 17:
					AnU5VrH5UsTeMMG3UvE(_003C_003Ec__DisplayClass56_.header, rvcFKgHb2pteEnR2GTv(0x56F860D7 ^ 0x56F809E9));
					num2 = 5;
					continue;
				case 11:
					return;
				case 14:
					if (_003C_003Ec__DisplayClass56_.header.SubHeaders == null)
					{
						num2 = 11;
						continue;
					}
					goto case 12;
				case 6:
					_003C_003Ec__DisplayClass56_.header = header;
					num2 = 17;
					continue;
				case 13:
					Save(_003C_003Ec__DisplayClass56_.header);
					num2 = 14;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
					{
						num2 = 4;
					}
					continue;
				case 4:
					if (ym4dh5Hcvwrw89c5Rx2(_003C_003Ec__DisplayClass56_.header) == WorkflowProcessStatus.Published)
					{
						num = 2;
						break;
					}
					goto case 8;
				case 3:
					MarkChildPublishedAsDraft(_003C_003Ec__DisplayClass56_.header);
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
					{
						num2 = 13;
					}
					continue;
				case 15:
					return;
				case 10:
					PYwbTBHgZioeA93dFIE(_003C_003Ec__DisplayClass56_.header, WorkflowProcessStatus.Deleted);
					num2 = 9;
					continue;
				case 9:
					((ComponentManager)Syk5wNHHgV3wkpHDm8Z()).GetExtensionPoints<IEventTrigger>().ForEach(_003C_003Ec__DisplayClass56_._003CDelete_003Eb__0);
					num2 = 3;
					continue;
				default:
					if (fHfXpXHdXADVDIsJC6K(_003C_003Ec__DisplayClass56_.header) == null)
					{
						num2 = 8;
						continue;
					}
					goto case 4;
				}
				break;
			}
		}
	}

	[Transaction]
	public virtual void Restore(IProcessHeader header)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				PYwbTBHgZioeA93dFIE(header, WorkflowProcessStatus.Draft);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				AnU5VrH5UsTeMMG3UvE(header, rvcFKgHb2pteEnR2GTv(-1050383744 ^ -1050410050));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return;
			default:
				Save(header);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public virtual bool CheckProcessName(long id, long parentId, string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_0131, IL_01de, IL_01ed
		int num = 6;
		ICriteria val = default(ICriteria);
		IProcessHeader processHeader = default(IProcessHeader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj3;
				switch (num2)
				{
				case 5:
				case 13:
					errorMessage = (string)IsPF52HW4TAJ2MCrLkr(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EB2D35));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					val = CreateCriteria().Add((ICriterion)UNYIMRHjum5l1n646jR(rvcFKgHb2pteEnR2GTv(0xB7793C9 ^ 0xB77D547), name)).Add((ICriterion)it5099H6OcSu2lYuaCT(xLt1sQHRP7SMcf5I88T(rvcFKgHb2pteEnR2GTv(-10408775 ^ -10392967), WorkflowProcessStatus.Deleted)));
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e == 0)
					{
						num2 = 3;
					}
					continue;
				case 8:
					errorMessage = (string)IsPF52HW4TAJ2MCrLkr(rvcFKgHb2pteEnR2GTv(0x651FE29D ^ 0x651F779B));
					num2 = 12;
					continue;
				default:
					return false;
				case 2:
					obj3 = null;
					goto IL_0247;
				case 12:
					return false;
				case 4:
					if (!EhRjalH9akrMCWEnSWe(KD8YJbHfxeYjYtl5lrr(name), string.Empty))
					{
						errorMessage = string.Empty;
						num2 = 10;
					}
					else
					{
						num2 = 13;
					}
					continue;
				case 11:
					if (id > 0)
					{
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 1;
				case 7:
					if (parentId <= 0)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					obj3 = LoadOrNull(parentId);
					goto IL_0247;
				case 1:
					if (!ReturnExists(val))
					{
						return true;
					}
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
					{
						num2 = 3;
					}
					continue;
				case 6:
					if (string.IsNullOrEmpty(name))
					{
						num2 = 5;
						continue;
					}
					goto case 4;
				case 3:
					HWE0DgH3cPgaHjhdY5G(val, Restrictions.Not((ICriterion)(object)Restrictions.Eq((string)rvcFKgHb2pteEnR2GTv(-11799394 ^ -11816424), (object)id)));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					{
						ICriteria obj = val;
						ICriterion obj2;
						if (processHeader == null)
						{
							ICriterion val2 = (ICriterion)fVswrAHqcqW1cJpJHG6(rvcFKgHb2pteEnR2GTv(-1965291699 ^ -1965276675));
							obj2 = val2;
						}
						else
						{
							ICriterion val2 = (ICriterion)(object)Restrictions.Eq((string)rvcFKgHb2pteEnR2GTv(0x74AB4717 ^ 0x74AB01A7), (object)processHeader);
							obj2 = val2;
						}
						HWE0DgH3cPgaHjhdY5G(obj, obj2);
						num = 11;
						break;
					}
					IL_0247:
					processHeader = (IProcessHeader)obj3;
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	public string GenerateNewName(string oldName, Guid newGuid, string postfix = null, string split = " ")
	{
		//Discarded unreachable code: IL_005d, IL_0145
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass59_0 _003C_003Ec__DisplayClass59_ = default(_003C_003Ec__DisplayClass59_0);
		long num3 = default(long);
		IEnumerable<IProcessHeader> enumerable = default(IEnumerable<IProcessHeader>);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 3:
				_003C_003Ec__DisplayClass59_ = new _003C_003Ec__DisplayClass59_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
				{
					num2 = 2;
				}
				break;
			case 8:
				if (num3 < long.MaxValue)
				{
					num2 = 9;
					break;
				}
				goto case 13;
			case 10:
				num3++;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
				{
					num2 = 12;
				}
				break;
			case 7:
			case 12:
				if (enumerable != null)
				{
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 13;
			case 5:
				num3 = 1L;
				num2 = 7;
				break;
			case 11:
				enumerable = LoadReportHeadersByName(text2, ignoreCase: true).Where(_003C_003Ec__DisplayClass59_._003CGenerateNewName_003Eb__0);
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
				{
					num2 = 3;
				}
				break;
			case 6:
				if (enumerable.Count() > 0)
				{
					num2 = 8;
					break;
				}
				goto case 13;
			default:
				enumerable = LoadReportHeadersByName(text2, ignoreCase: true).Where(_003C_003Ec__DisplayClass59_._003CGenerateNewName_003Eb__1);
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
				{
					num2 = 10;
				}
				break;
			case 1:
				text2 = text;
				num2 = 11;
				break;
			case 2:
				_003C_003Ec__DisplayClass59_.newGuid = newGuid;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
				{
					num2 = 0;
				}
				break;
			case 13:
				return text2;
			case 4:
				text = (string)ruEsPrHQeAMMeZEXK0U(rvcFKgHb2pteEnR2GTv(-130098986 ^ -130134654), oldName, (postfix != null) ? E0D5pkHTdC5LbTUDyNk(split, postfix) : "");
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 != 0)
				{
					num2 = 1;
				}
				break;
			case 9:
			case 14:
				text2 = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708163804), (text.Length + CeRlhfHpU0CjksZPajD(num3.ToString()) + 3 > 2000) ? Gr1krcHCeOyJYjPXNPn(text, 1, 2000 - num3.ToString().Length - 3) : text, num3, split);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public IEnumerable<IProcessHeader> LoadReportHeadersByName(string headerName)
	{
		return LoadReportHeadersByName(headerName, ignoreCase: false);
	}

	public IEnumerable<IProcessHeader> LoadReportHeadersByName(string headerName, bool ignoreCase)
	{
		IProcessHeaderFilter processHeaderFilter = InterfaceActivator.Create<IProcessHeaderFilter>();
		processHeaderFilter.DisableSecurity = true;
		ICriteria obj = CreateCriteria(processHeaderFilter);
		obj.Add((ICriterion)(object)(ignoreCase ? ElmaRestrictions.InsensitiveLike(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -452111401), headerName) : ElmaRestrictions.Like(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25692828), headerName)));
		return obj.List<IProcessHeader>();
	}

	public virtual bool CheckProcessClassName(long id, long parentId, string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_00fb
		int num = 5;
		int num2 = num;
		ICriteria val = default(ICriteria);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return false;
			case 10:
				if (id > 0)
				{
					num2 = 8;
					break;
				}
				goto case 3;
			default:
				return false;
			case 8:
				val.Add((ICriterion)it5099H6OcSu2lYuaCT(xLt1sQHRP7SMcf5I88T(rvcFKgHb2pteEnR2GTv(-1028861977 ^ -1028880031), id)));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
				{
					num2 = 3;
				}
				break;
			case 7:
				errorMessage = SR.T((string)rvcFKgHb2pteEnR2GTv(0x42311138 ^ 0x42318446));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				if (!JyJkSDHAh9eDVH2Rvyd(this, val))
				{
					return true;
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
				{
					num2 = 2;
				}
				break;
			case 5:
				if (IsValidIdentifierName(name, out errorMessage))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d87d9a74c9e14f96a288cc3620965fe0 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 9;
			case 2:
				errorMessage = (string)IsPF52HW4TAJ2MCrLkr(rvcFKgHb2pteEnR2GTv(0xA7339EE ^ 0xA73AEF8));
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
				{
					num2 = 6;
				}
				break;
			case 9:
				return false;
			case 4:
				if (!HGUdU8HMTfYME1sNPw4(name))
				{
					errorMessage = string.Empty;
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
					{
						num2 = 7;
					}
				}
				break;
			case 1:
				val = (ICriteria)HWE0DgH3cPgaHjhdY5G(KANxu1HUWoL4j1UbotC(KANxu1HUWoL4j1UbotC(KANxu1HUWoL4j1UbotC(KANxu1HUWoL4j1UbotC(fOHYGFHk2swh6n27MSg(this, null), rvcFKgHb2pteEnR2GTv(-17847711 ^ -17882023), rvcFKgHb2pteEnR2GTv(0xA7339EE ^ 0xA73B7A4)), rvcFKgHb2pteEnR2GTv(-1895853023 ^ -1895890451), rvcFKgHb2pteEnR2GTv(0x63D6C913 ^ 0x63D65CF9)), rvcFKgHb2pteEnR2GTv(0x438A0E43 ^ 0x438A9BBD), rvcFKgHb2pteEnR2GTv(0x6C7F14 ^ 0x6CE938)), rvcFKgHb2pteEnR2GTv(-1516552726 ^ -1516524614), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x548A8DBC)), NX2oBLHVx3uQUecO008(UNYIMRHjum5l1n646jR(rvcFKgHb2pteEnR2GTv(-1214182792 ^ -1214145306), name), NX2oBLHVx3uQUecO008(UNYIMRHjum5l1n646jR(rvcFKgHb2pteEnR2GTv(0xDF4D1F8 ^ 0xDF44744), name), UNYIMRHjum5l1n646jR(rvcFKgHb2pteEnR2GTv(0x34EA50D4 ^ 0x34EAC63E), name))));
				num2 = 10;
				break;
			}
		}
	}

	private bool CheckSimpleCaseTableName(long id, long parentId, string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 9;
		int num2 = num;
		ICriteria val = default(ICriteria);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (JyJkSDHAh9eDVH2Rvyd(this, val))
				{
					num2 = 10;
					break;
				}
				return true;
			case 9:
				if (!IsValidIdentifierName(name, out errorMessage))
				{
					num2 = 8;
					break;
				}
				if (!MMmkqHH7cpXuKx6vGuT(Y1YE5IHGnOBBkaHN3ap(TransformationProvider), name))
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 1:
				val = ((ICriteria)KANxu1HUWoL4j1UbotC(((ICriteria)KANxu1HUWoL4j1UbotC(CreateCriteria(), rvcFKgHb2pteEnR2GTv(0xB7793C9 ^ 0xB771DF1), rvcFKgHb2pteEnR2GTv(--601115071 ^ 0x23D4C7F5))).CreateAlias((string)rvcFKgHb2pteEnR2GTv(0x1C663DA1 ^ 0x1C66A86D), (string)rvcFKgHb2pteEnR2GTv(0x1C663DA1 ^ 0x1C66A84B)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720493411), rvcFKgHb2pteEnR2GTv(-1716629332 ^ -1716599168))).CreateAlias((string)rvcFKgHb2pteEnR2GTv(0xDF4D1F8 ^ 0xDF447A8), (string)rvcFKgHb2pteEnR2GTv(-25709590 ^ -25746026)).Add((ICriterion)(object)Restrictions.Or((ICriterion)UNYIMRHjum5l1n646jR(rvcFKgHb2pteEnR2GTv(0x6871CA ^ 0x68E626), name), (ICriterion)NX2oBLHVx3uQUecO008(UNYIMRHjum5l1n646jR(rvcFKgHb2pteEnR2GTv(-2122743969 ^ -2122717365), name), UNYIMRHjum5l1n646jR(rvcFKgHb2pteEnR2GTv(-1965291699 ^ -1965252863), name))));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return false;
			default:
				if (id > 0)
				{
					num2 = 6;
					break;
				}
				goto case 7;
			case 6:
				HWE0DgH3cPgaHjhdY5G(val, it5099H6OcSu2lYuaCT(xLt1sQHRP7SMcf5I88T(rvcFKgHb2pteEnR2GTv(0x56A753C9 ^ 0x56A7154F), id)));
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				errorMessage = (string)IsPF52HW4TAJ2MCrLkr(rvcFKgHb2pteEnR2GTv(0x5F800F5B ^ 0x5F8098C3));
				num2 = 4;
				break;
			case 8:
				return false;
			case 4:
				return false;
			case 3:
				errorMessage = string.Empty;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
				{
					num2 = 1;
				}
				break;
			case 10:
				errorMessage = (string)IsPF52HW4TAJ2MCrLkr(rvcFKgHb2pteEnR2GTv(-1647793954 ^ -1647824804));
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual bool CheckProcessTableName(long id, long parentId, string name, out string errorMessage)
	{
		int num = 5;
		IProcessHeader processHeader = default(IProcessHeader);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return true;
				case 2:
					return false;
				default:
					if (JYm8kMHiRh3FvQ1LvlG(xkSL9rHFNqxU31V4hB9(processHeader.Context), name, StringComparison.CurrentCultureIgnoreCase))
					{
						num2 = 3;
						continue;
					}
					goto IL_0042;
				case 4:
					if (CheckSimpleCaseTableName(id, parentId, name, out errorMessage))
					{
						if (id > 0)
						{
							num2 = 7;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
							{
								num2 = 6;
							}
							continue;
						}
						goto IL_0042;
					}
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					if (ws8Xs3HoLs5hRPFdLf1(processHeader) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_0042;
				case 1:
					return false;
				case 5:
					IyoqRxH2Qds4sWUsZhn(TransformationProvider, rvcFKgHb2pteEnR2GTv(0xDF4D1F8 ^ 0xDF448FE));
					num2 = 4;
					continue;
				case 7:
					break;
				case 8:
					{
						errorMessage = (string)IsPF52HW4TAJ2MCrLkr(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25744676));
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
						{
							num2 = 1;
						}
						continue;
					}
					IL_0042:
					if (VXlSpoHIi9JnRccdJAN(TransformationProvider, name))
					{
						num2 = 8;
						continue;
					}
					return true;
				}
				break;
			}
			processHeader = Load(id);
			num = 6;
		}
	}

	public virtual bool CheckProcessMetricsTableName(long id, long parentId, string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_006e, IL_007d, IL_010e
		int num = 1;
		int num2 = num;
		IProcessHeader processHeader = default(IProcessHeader);
		while (true)
		{
			switch (num2)
			{
			case 9:
				return true;
			case 2:
				if (!VXlSpoHIi9JnRccdJAN(TransformationProvider, name))
				{
					num2 = 6;
					break;
				}
				goto case 10;
			case 3:
				return false;
			case 6:
				return true;
			case 10:
				errorMessage = (string)IsPF52HW4TAJ2MCrLkr(rvcFKgHb2pteEnR2GTv(-1386448964 ^ -1386418550));
				num2 = 3;
				break;
			case 4:
				return false;
			case 1:
				IyoqRxH2Qds4sWUsZhn(TransformationProvider, rvcFKgHb2pteEnR2GTv(0x361628FF ^ 0x3616B1F9));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				if (NwLivSHaQ9HU9a3GPik(processHeader) != null)
				{
					num2 = 8;
					break;
				}
				goto case 2;
			case 8:
				if (!JYm8kMHiRh3FvQ1LvlG(((EntityMetadata)NwLivSHaQ9HU9a3GPik(processHeader)).TableName, name, StringComparison.CurrentCultureIgnoreCase))
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 9;
			default:
				if (CheckSimpleCaseTableName(id, parentId, name, out errorMessage))
				{
					if (id > 0)
					{
						num2 = 5;
						break;
					}
					goto case 2;
				}
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				processHeader = Load(id);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
				{
					num2 = 7;
				}
				break;
			}
		}
	}

	public virtual bool CheckProcessInstanceMetricsTableName(long id, long parentId, string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_00d0, IL_00df, IL_01ad, IL_01bc
		int num = 6;
		int num2 = num;
		IProcessHeader processHeader = default(IProcessHeader);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return false;
			case 8:
				return true;
			case 10:
				if (!VXlSpoHIi9JnRccdJAN(TransformationProvider, name))
				{
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				break;
			default:
				if (!JYm8kMHiRh3FvQ1LvlG(xkSL9rHFNqxU31V4hB9(iICSv2HrQcTAdLjFYpk(processHeader)), name, StringComparison.CurrentCultureIgnoreCase))
				{
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 != 0)
					{
						num2 = 8;
					}
					continue;
				}
				goto case 8;
			case 6:
				IyoqRxH2Qds4sWUsZhn(TransformationProvider, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -452096929));
				num2 = 5;
				continue;
			case 7:
				if (iICSv2HrQcTAdLjFYpk(processHeader) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 10;
			case 5:
				if (CheckSimpleCaseTableName(id, parentId, name, out errorMessage))
				{
					if (id > 0)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 10;
				}
				num2 = 4;
				continue;
			case 1:
				processHeader = Load(id);
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
				{
					num2 = 3;
				}
				continue;
			case 2:
				return false;
			case 9:
				return true;
			case 3:
				break;
			}
			errorMessage = (string)IsPF52HW4TAJ2MCrLkr(rvcFKgHb2pteEnR2GTv(-2077784392 ^ -2077810802));
			num2 = 2;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 != 0)
			{
				num2 = 0;
			}
		}
	}

	public virtual bool IsOwner(IProcessHeader header, EleWise.ELMA.Security.Models.IUser user = null)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				obj = fHfXpXHdXADVDIsJC6K(header);
				if (obj == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_007f;
			case 3:
				AnU5VrH5UsTeMMG3UvE(header, rvcFKgHb2pteEnR2GTv(0x2F44D93A ^ 0x2F44B004));
				num2 = 2;
				break;
			case 1:
				obj = TjmWqBHeGLAFwfCkdlg(header);
				goto IL_007f;
			default:
				{
					return WorkflowProcessManager.GetResponsibilityMatrixItems((IWorkflowProcess)(fHfXpXHdXADVDIsJC6K(header) ?? TjmWqBHeGLAFwfCkdlg(header)), user).Any((IResponsibilityMatrixItem i) => i.ResponsibilityLevel == ResponsibilityLevel.Owner);
				}
				IL_007f:
				AnU5VrH5UsTeMMG3UvE(obj, rvcFKgHb2pteEnR2GTv(-29981480 ^ -30007992));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual bool IsCurator(IProcessHeader header, EleWise.ELMA.Security.Models.IUser user = null)
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				IWorkflowProcess workflowProcess;
				switch (num2)
				{
				case 3:
					break;
				case 2:
					workflowProcess = header.Published;
					if (workflowProcess == null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto IL_007d;
				case 1:
					workflowProcess = header.PublishedEmulation;
					goto IL_007d;
				default:
					{
						return WorkflowProcessManager.GetResponsibilityMatrixItems((IWorkflowProcess)(header.Published ?? TjmWqBHeGLAFwfCkdlg(header)), user).Any((IResponsibilityMatrixItem i) => _003C_003Ec.SxIhfSZQhhU50dpXVEha(i));
					}
					IL_007d:
					AnU5VrH5UsTeMMG3UvE(workflowProcess, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -452096823));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			AnU5VrH5UsTeMMG3UvE(header, rvcFKgHb2pteEnR2GTv(0x42311138 ^ 0x42317806));
			num = 2;
		}
	}

	public virtual bool HasPermission(IProcessHeader header, Permission permission, EleWise.ELMA.Security.Models.IUser user = null)
	{
		int num = 4;
		_003C_003Ec__DisplayClass69_0 _003C_003Ec__DisplayClass69_ = default(_003C_003Ec__DisplayClass69_0);
		string name = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					_003C_003Ec__DisplayClass69_.header = header;
					num2 = 8;
					continue;
				case 2:
					if (_003C_003Ec__DisplayClass69_.user == null)
					{
						num2 = 7;
						continue;
					}
					name = (string)PNW6HmHNZmC0S81IApI(new object[4]
					{
						SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF6683E),
						_003C_003Ec__DisplayClass69_.header.Id,
						rvcFKgHb2pteEnR2GTv(0x738ABA6E ^ 0x738AF32A),
						_003C_003Ec__DisplayClass69_.user.Id
					});
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					_003C_003Ec__DisplayClass69_._003C_003E4__this = this;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return ContextBoundVariableService.GetOrAdd(name, _003C_003Ec__DisplayClass69_._003CHasPermission_003Eb__0).Contains(kOnWfrHx1Newwpa85b0(permission));
				case 1:
					Contract.ArgumentNotNull(_003C_003Ec__DisplayClass69_.header, (string)rvcFKgHb2pteEnR2GTv(-949717965 ^ -949740275));
					num2 = 5;
					continue;
				case 8:
					_003C_003Ec__DisplayClass69_.user = user;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f != 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					AnU5VrH5UsTeMMG3UvE(permission, rvcFKgHb2pteEnR2GTv(0x4943E3E4 ^ 0x49437A50));
					num2 = 9;
					continue;
				case 7:
					return false;
				case 4:
					_003C_003Ec__DisplayClass69_ = new _003C_003Ec__DisplayClass69_0();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
					{
						num2 = 3;
					}
					continue;
				case 9:
					_003C_003Ec__DisplayClass69_.user = _003C_003Ec__DisplayClass69_.user ?? base.AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
					num = 2;
					break;
				}
				break;
			}
		}
	}

	public virtual List<ProcessInstanceStatistics> GetExecutingInstanceStatistics(bool onlyObsolete = false)
	{
		return GetExecutingInstanceStatistics(onlyObsolete, includeDeleted: true);
	}

	public virtual List<ProcessInstanceStatistics> GetExecutingInstanceStatistics(bool onlyObsolete, bool includeDeleted)
	{
		string text = string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6871CA ^ 0x68EBC8), new int[1] { 1 });
		ITransformationProvider serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
		return ((IQuery)base.Session.CreateSQLQuery(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39151212), serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14383190)), serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A69834B)), text, serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1542190822 ^ -1542172800)), serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-14356676 ^ -14372604)), serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A69830D)), serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF4096B4)), serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801782457)), serviceNotNull.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-539998957 ^ -540009031), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7AC609FE ^ 0x7AC65130)), serviceNotNull.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050399356), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x350C0E8 ^ 0x350CF52)), serviceNotNull.NoLockTableExpression(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22364906), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111226331)), includeDeleted ? "" : string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801782361), serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EBFF33)), 3), onlyObsolete ? string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-10408775 ^ -10373345), serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614274E3 ^ 0x61423265)), serviceNotNull.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF404B62))) : ""))).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ProcessInstanceStatistics))).CleanUpCache(cleanUpCache: false).List<ProcessInstanceStatistics>()
			.ToList();
	}

	public virtual ProcessInstanceStatistics GetProcessExecutingInstanceStatistics(long headerId, bool onlyObsolete = false)
	{
		int num = 2;
		ProcessInstanceStatistics processInstanceStatistics = default(ProcessInstanceStatistics);
		string text = default(string);
		ITransformationProvider serviceNotNull = default(ITransformationProvider);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return processInstanceStatistics;
				default:
					processInstanceStatistics = new ProcessInstanceStatistics();
					num2 = 3;
					continue;
				case 2:
					text = string.Join(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A69C5CD ^ 0x6A695FCF), new int[1] { 1 });
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					serviceNotNull = Locator.GetServiceNotNull<ITransformationProvider>();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					processInstanceStatistics.Versions = ((IQuery)V4ZXUAH4s1Ba7xMIWp8(((IQuery)iXE0m5HwXbt7oy8KOC8(TXP37hHSLlsnibsJoyI(this), IGfZBEHEWciKSfspimf(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716490219), new object[13]
					{
						N2BUjZH1vjdEJAMAjtj(Y1YE5IHGnOBBkaHN3ap(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB2CC54)),
						N2BUjZH1vjdEJAMAjtj(serviceNotNull.Dialect, rvcFKgHb2pteEnR2GTv(-790221436 ^ -790203460)),
						N2BUjZH1vjdEJAMAjtj(Y1YE5IHGnOBBkaHN3ap(serviceNotNull), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1214182792 ^ -1214160146)),
						N2BUjZH1vjdEJAMAjtj(serviceNotNull.Dialect, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46EE54B)),
						((Dialect)Y1YE5IHGnOBBkaHN3ap(serviceNotNull)).QuoteIfNeeded((string)rvcFKgHb2pteEnR2GTv(--1418337216 ^ 0x548A5D00)),
						headerId,
						text,
						onlyObsolete ? ruEsPrHQeAMMeZEXK0U(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -452096257), N2BUjZH1vjdEJAMAjtj(Y1YE5IHGnOBBkaHN3ap(serviceNotNull), rvcFKgHb2pteEnR2GTv(-432000546 ^ -431982760)), N2BUjZH1vjdEJAMAjtj(Y1YE5IHGnOBBkaHN3ap(serviceNotNull), rvcFKgHb2pteEnR2GTv(0x2ACCDD87 ^ 0x2ACC9B1D))) : "",
						N2BUjZH1vjdEJAMAjtj(Y1YE5IHGnOBBkaHN3ap(serviceNotNull), rvcFKgHb2pteEnR2GTv(0x6CC04061 ^ 0x6CC0DDF1)),
						N2BUjZH1vjdEJAMAjtj(serviceNotNull.Dialect, rvcFKgHb2pteEnR2GTv(0x7AC609FE ^ 0x7AC6929E)),
						Pu2Q0OHhDPLsxxWVTH6(serviceNotNull, rvcFKgHb2pteEnR2GTv(--601115071 ^ 0x23D41115), rvcFKgHb2pteEnR2GTv(-1303601216 ^ -1303591154)),
						Pu2Q0OHhDPLsxxWVTH6(serviceNotNull, rvcFKgHb2pteEnR2GTv(-1712492721 ^ -1712510901), rvcFKgHb2pteEnR2GTv(--1418337216 ^ 0x548A147A)),
						serviceNotNull.NoLockTableExpression((string)rvcFKgHb2pteEnR2GTv(-11799394 ^ -11816328), (string)rvcFKgHb2pteEnR2GTv(-130098986 ^ -130106264))
					}))).SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ProcessInstanceStatistics.Version))), false)).List<ProcessInstanceStatistics.Version>().ToList();
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
					{
						num2 = 4;
					}
					continue;
				case 4:
					lVxsXbHzG8046GycyJk(processInstanceStatistics, processInstanceStatistics.Versions.Sum((ProcessInstanceStatistics.Version v) => v.InstancesCount));
					num = 5;
					break;
				}
				break;
			}
		}
	}

	public virtual long GetPublishingVersionNumber(long headerId)
	{
		int num = 3;
		int num2 = num;
		string text = default(string);
		ITransformationProvider service = default(ITransformationProvider);
		while (true)
		{
			switch (num2)
			{
			default:
				return GW38iHLO273DjW6qGR9(dOrvnNLKAlmE93JaDUe(V4ZXUAH4s1Ba7xMIWp8(((ISession)TXP37hHSLlsnibsJoyI(this)).CreateSQLQuery(text), false)));
			case 2:
				return 1L;
			case 3:
				if (headerId > 0)
				{
					service = Locator.GetService<ITransformationProvider>();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 2;
				}
				break;
			case 1:
				text = (string)ruEsPrHQeAMMeZEXK0U(rvcFKgHb2pteEnR2GTv(-684210684 ^ -684237910), (service != null) ? N2BUjZH1vjdEJAMAjtj(Y1YE5IHGnOBBkaHN3ap(service), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105856812)) : SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801818959), headerId);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual IEnumerable<IProcessHeader> FindDeleted()
	{
		return CreateDeletedCriteria().List<IProcessHeader>();
	}

	public virtual long GetDeletedCount()
	{
		return y835WlLvYrqeF7IJpCn(this, vwD2OALZYTgl816CeC1(this));
	}

	public virtual IEnumerable<IProcessHeader> LoadSubProcesses(IProcessHeader header)
	{
		return CreateCriteria().Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483FE4C2), (object)header)).Add((ICriterion)(object)Restrictions.Not((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACC9B47), (object)WorkflowProcessStatus.Deleted))).List<IProcessHeader>();
	}

	public virtual bool ValidateTableName(Guid ownerUid, string tableName, out string message)
	{
		//Discarded unreachable code: IL_0075, IL_0136, IL_0145, IL_01a4, IL_01e3, IL_01f2, IL_0205, IL_033e, IL_034d
		int num = 19;
		string text2 = default(string);
		string text = default(string);
		string text3 = default(string);
		IList<object[]> list = default(IList<object[]>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					message = (string)QCqipULJKdY7H7yxZVD(rvcFKgHb2pteEnR2GTv(-1716458555 ^ -1716488879), new object[3] { text2, text, text3 });
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
					{
						num2 = 12;
					}
					break;
				case 1:
					text = (string)list[0][1];
					num2 = 15;
					break;
				default:
					if (string.IsNullOrEmpty(text2))
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 6;
				case 15:
					text2 = (string)list[0][2];
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
					{
						num2 = 0;
					}
					break;
				case 8:
				case 17:
					if (string.IsNullOrEmpty(text))
					{
						goto end_IL_0012;
					}
					goto case 10;
				case 19:
					message = null;
					num2 = 18;
					break;
				case 2:
				case 3:
				case 12:
				case 16:
					return false;
				case 6:
					if (OjUPSiLsAcIdjYiic5K(text))
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
						{
							num2 = 13;
						}
						break;
					}
					goto case 5;
				case 7:
				case 20:
					message = (string)QCqipULJKdY7H7yxZVD(rvcFKgHb2pteEnR2GTv(-1776305410 ^ -1776343668), new object[1] { text3 });
					num2 = 16;
					break;
				case 11:
				case 13:
					message = SR.T((string)rvcFKgHb2pteEnR2GTv(0x4943E3E4 ^ 0x49437D16), text2, text3);
					num2 = 2;
					break;
				case 4:
					return true;
				case 14:
					text3 = (string)list[0][0];
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
					{
						num2 = 1;
					}
					break;
				case 18:
					list = ((IQuery)V4ZXUAH4s1Ba7xMIWp8(((IQuery)Rm4xIKLYNGDrBPDSKOG(TXP37hHSLlsnibsJoyI(this), rvcFKgHb2pteEnR2GTv(0xF400DF8 ^ 0xF4093CE))).SetParameter<string>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17F0C5A2 ^ 0x17F05BC8), tableName).SetParameter<Guid>(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6CE194), ownerUid), false)).List<object[]>();
					num2 = 9;
					break;
				case 10:
					message = (string)QCqipULJKdY7H7yxZVD(rvcFKgHb2pteEnR2GTv(0x213F6477 ^ 0x213FFB4F), new object[2] { text, text3 });
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
					{
						num2 = 3;
					}
					break;
				case 9:
					if (rgHLaTL8N0r1ZQbXQtN(list) != 0)
					{
						num2 = 6;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
						{
							num2 = 14;
						}
						break;
					}
					goto case 4;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 20;
		}
	}

	public virtual bool ValidateClassName(string className, out string message)
	{
		//Discarded unreachable code: IL_0067, IL_0076, IL_013d, IL_0188, IL_0197
		int num = 4;
		string text2 = default(string);
		string text = default(string);
		IList<object[]> list = default(IList<object[]>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					if (OjUPSiLsAcIdjYiic5K(text2))
					{
						num2 = 8;
						continue;
					}
					goto default;
				case 5:
				case 8:
					message = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--727842433 ^ 0x2B6161F3), text);
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (rgHLaTL8N0r1ZQbXQtN(list) != 0)
					{
						num2 = 6;
						continue;
					}
					goto case 7;
				default:
					message = (string)QCqipULJKdY7H7yxZVD(rvcFKgHb2pteEnR2GTv(0x1145BED7 ^ 0x114521EF), new object[2] { text2, text });
					num2 = 11;
					continue;
				case 7:
					return true;
				case 6:
					text = (string)list[0][0];
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					break;
				case 4:
					message = null;
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					list = ((IQuery)Rm4xIKLYNGDrBPDSKOG(base.Session, rvcFKgHb2pteEnR2GTv(-1303601216 ^ -1303642032))).SetParameter<string>((string)rvcFKgHb2pteEnR2GTv(0x56A753C9 ^ 0x56A7CC0D), className).CleanUpCache(cleanUpCache: false).List<object[]>();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
				case 11:
					return false;
				}
				break;
			}
			text2 = (string)list[0][1];
			num = 10;
		}
	}

	public List<IProcessHeader> GetSubprocessTreeList(Guid headerUid, bool onlyExternal = false)
	{
		IProcessHeader header = LoadOrNull(headerUid);
		return GetSubprocessTreeList(header, onlyExternal);
	}

	public List<IProcessHeader> GetSubprocessTreeList(long headerId, bool onlyExternal = false)
	{
		IProcessHeader header = LoadOrNull(headerId);
		return GetSubprocessTreeList(header, onlyExternal);
	}

	public List<IProcessHeader> GetSubprocessTreeList(IProcessHeader header, bool onlyExternal = false)
	{
		List<IProcessHeader> subprocessTreeList = GetSubprocessTreeList(header, null);
		if (subprocessTreeList.Contains(header))
		{
			subprocessTreeList.Remove(header);
		}
		if (!onlyExternal)
		{
			return subprocessTreeList;
		}
		return subprocessTreeList.Where((IProcessHeader sh) => _003C_003Ec.gjQsYsZQEmTsHFBNAmP1(sh) == null).ToList();
	}

	public ProcessCommonStatistics GetCommonStatistics(bool calculateExecutingCount)
	{
		int num = 4;
		int num2 = num;
		List<ProcessInstanceStatistics> executingInstanceStatistics = default(List<ProcessInstanceStatistics>);
		ProcessCommonStatistics processCommonStatistics = default(ProcessCommonStatistics);
		while (true)
		{
			switch (num2)
			{
			default:
				executingInstanceStatistics = GetExecutingInstanceStatistics(onlyObsolete: true, includeDeleted: false);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				processCommonStatistics = new ProcessCommonStatistics();
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				processCommonStatistics.DeletedCount = (int)y835WlLvYrqeF7IJpCn(this, HWE0DgH3cPgaHjhdY5G(HWE0DgH3cPgaHjhdY5G(CreateCriteria(), fVswrAHqcqW1cJpJHG6(rvcFKgHb2pteEnR2GTv(0x1C7F6FED ^ 0x1C7F295D))), xLt1sQHRP7SMcf5I88T(rvcFKgHb2pteEnR2GTv(0x651FE29D ^ 0x651FA45D), WorkflowProcessStatus.Deleted)));
				num2 = 6;
				break;
			case 7:
				processCommonStatistics.DraftsCount = (int)ReturnCount((ICriteria)HWE0DgH3cPgaHjhdY5G(HWE0DgH3cPgaHjhdY5G(HWE0DgH3cPgaHjhdY5G(fOHYGFHk2swh6n27MSg(this, null), fVswrAHqcqW1cJpJHG6(rvcFKgHb2pteEnR2GTv(-862330810 ^ -862345482))), it5099H6OcSu2lYuaCT(xLt1sQHRP7SMcf5I88T(rvcFKgHb2pteEnR2GTv(-667465279 ^ -667480319), WorkflowProcessStatus.Deleted))), NX2oBLHVx3uQUecO008(NX2oBLHVx3uQUecO008(Restrictions.IsNull((string)rvcFKgHb2pteEnR2GTv(0x7381F16B ^ 0x7381B7F1)), it5099H6OcSu2lYuaCT(Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2F44D93A ^ 0x2F449FFA), (object)WorkflowProcessStatus.Published))), Restrictions.Eq((string)rvcFKgHb2pteEnR2GTv(-790221436 ^ -790187426), (object)true))));
				num2 = 5;
				break;
			case 2:
				return processCommonStatistics;
			case 6:
				if (calculateExecutingCount)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 3:
				bnquH4L0JayvDlEW5lg(processCommonStatistics, (int)ReturnCount((ICriteria)HWE0DgH3cPgaHjhdY5G(((ICriteria)HWE0DgH3cPgaHjhdY5G(fOHYGFHk2swh6n27MSg(this, null), fVswrAHqcqW1cJpJHG6(rvcFKgHb2pteEnR2GTv(0x34EA50D4 ^ 0x34EA1664)))).Add((ICriterion)xLt1sQHRP7SMcf5I88T(rvcFKgHb2pteEnR2GTv(-130098986 ^ -130114026), WorkflowProcessStatus.Published)), s7DTxYLlwUB4UIEdS0h(rvcFKgHb2pteEnR2GTv(0x614274E3 ^ 0x61423279)))));
				num2 = 7;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 != 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				processCommonStatistics.ExecutingCount = executingInstanceStatistics.Count((ProcessInstanceStatistics s) => s.InstancesCount > 0);
				num2 = 2;
				break;
			}
		}
	}

	private List<IProcessHeader> GetSubprocessTreeList(IProcessHeader header, List<IProcessHeader> returnList)
	{
		_003C_003Ec__DisplayClass83_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass83_0();
		CS_0024_003C_003E8__locals0.returnList = returnList;
		if (CS_0024_003C_003E8__locals0.returnList == null)
		{
			CS_0024_003C_003E8__locals0.returnList = new List<IProcessHeader>();
		}
		if (!CS_0024_003C_003E8__locals0.returnList.Contains(header))
		{
			CS_0024_003C_003E8__locals0.returnList.Add(header);
		}
		CS_0024_003C_003E8__locals0.subHeaders = new List<IProcessHeader>();
		if (header != null)
		{
			if (header.SubHeaders != null)
			{
				((IEnumerable<IProcessHeader>)header.SubHeaders).ForEach(delegate(IProcessHeader sh)
				{
					//Discarded unreachable code: IL_004c, IL_005b
					int num3 = 3;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 3:
							if (CS_0024_003C_003E8__locals0.subHeaders.Contains(sh))
							{
								num4 = 2;
								continue;
							}
							break;
						case 2:
							return;
						case 1:
							break;
						case 0:
							return;
						}
						CS_0024_003C_003E8__locals0.subHeaders.Add(sh);
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
						{
							num4 = 0;
						}
					}
				});
			}
			IWorkflowProcess current = header.Current;
			if (current != null && current.Diagram != null && current.Diagram.Elements != null)
			{
				foreach (ExternalSubprocessElement item in current.Diagram.Elements.OfType<ExternalSubprocessElement>())
				{
					IProcessHeader processHeader = LoadOrNull(item.ProcessHeaderId);
					if (processHeader != null && !CS_0024_003C_003E8__locals0.subHeaders.Contains(processHeader))
					{
						CS_0024_003C_003E8__locals0.subHeaders.Add(processHeader);
					}
				}
			}
		}
		foreach (IProcessHeader subHeader in CS_0024_003C_003E8__locals0.subHeaders)
		{
			if (CS_0024_003C_003E8__locals0.returnList.Contains(subHeader))
			{
				continue;
			}
			CS_0024_003C_003E8__locals0.returnList.Add(subHeader);
			GetSubprocessTreeList(subHeader, CS_0024_003C_003E8__locals0.returnList).ForEach(delegate(IProcessHeader sh)
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						CS_0024_003C_003E8__locals0.returnList.Add(sh);
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
						{
							num2 = 1;
						}
						break;
					case 1:
						if (CS_0024_003C_003E8__locals0.returnList.Contains(sh))
						{
							return;
						}
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
						{
							num2 = 0;
						}
						break;
					case 2:
						return;
					}
				}
			});
		}
		return CS_0024_003C_003E8__locals0.returnList;
	}

	public override ExportRuleList ExportRules()
	{
		int num = 1;
		int num2 = num;
		Type type = default(Type);
		while (true)
		{
			switch (num2)
			{
			case 1:
				type = InterfaceActivator.TypeOf<IProcessHeader>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			ExportRuleList exportRuleList = new ExportRuleList();
			ExportRule exportRule = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule, type);
			exportRule.PropertyName = (string)rvcFKgHb2pteEnR2GTv(0x56A753C9 ^ 0x56A7CC33);
			ytG700LmtbcSPfUEREx(exportRule, ExportRuleType.Export);
			exportRuleList.Add(exportRule);
			ExportRule exportRule2 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule2, type);
			CpEwR0LtkoYCqlXS2GD(exportRule2, rvcFKgHb2pteEnR2GTv(-261315199 ^ -261311207));
			ytG700LmtbcSPfUEREx(exportRule2, ExportRuleType.Export);
			exportRuleList.Add(exportRule2);
			ExportRule exportRule3 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule3, type);
			CpEwR0LtkoYCqlXS2GD(exportRule3, rvcFKgHb2pteEnR2GTv(0x1AF6F1F2 ^ 0x1AF69FC8));
			ytG700LmtbcSPfUEREx(exportRule3, ExportRuleType.Export);
			exportRuleList.Add(exportRule3);
			ExportRule exportRule4 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule4, type);
			CpEwR0LtkoYCqlXS2GD(exportRule4, rvcFKgHb2pteEnR2GTv(-2122743969 ^ -2122765385));
			ytG700LmtbcSPfUEREx(exportRule4, ExportRuleType.Export);
			exportRuleList.Add(exportRule4);
			ExportRule obj = new ExportRule
			{
				ParentType = type
			};
			CpEwR0LtkoYCqlXS2GD(obj, rvcFKgHb2pteEnR2GTv(-1393899982 ^ -1393932278));
			ytG700LmtbcSPfUEREx(obj, ExportRuleType.Export);
			exportRuleList.Add(obj);
			ExportRule exportRule5 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule5, type);
			CpEwR0LtkoYCqlXS2GD(exportRule5, rvcFKgHb2pteEnR2GTv(0x63D6C913 ^ 0x63D64E0B));
			ytG700LmtbcSPfUEREx(exportRule5, ExportRuleType.Export);
			exportRuleList.Add(exportRule5);
			ExportRule exportRule6 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule6, type);
			CpEwR0LtkoYCqlXS2GD(exportRule6, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22387670));
			exportRule6.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule6);
			ExportRule exportRule7 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule7, type);
			CpEwR0LtkoYCqlXS2GD(exportRule7, rvcFKgHb2pteEnR2GTv(-980570076 ^ -980552022));
			ytG700LmtbcSPfUEREx(exportRule7, ExportRuleType.Export);
			exportRuleList.Add(exportRule7);
			ExportRule exportRule8 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule8, type);
			exportRule8.PropertyName = (string)rvcFKgHb2pteEnR2GTv(-135674354 ^ -135692098);
			ytG700LmtbcSPfUEREx(exportRule8, ExportRuleType.Export);
			exportRuleList.Add(exportRule8);
			ExportRule exportRule9 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule9, type);
			CpEwR0LtkoYCqlXS2GD(exportRule9, rvcFKgHb2pteEnR2GTv(0x6A69C5CD ^ 0x6A6965D7));
			ytG700LmtbcSPfUEREx(exportRule9, ExportRuleType.Export);
			exportRuleList.Add(exportRule9);
			ExportRule exportRule10 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule10, type);
			exportRule10.PropertyName = (string)rvcFKgHb2pteEnR2GTv(-10408775 ^ -10384243);
			ytG700LmtbcSPfUEREx(exportRule10, ExportRuleType.Export);
			exportRuleList.Add(exportRule10);
			ExportRule exportRule11 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule11, type);
			CpEwR0LtkoYCqlXS2GD(exportRule11, rvcFKgHb2pteEnR2GTv(0x738ABA6E ^ 0x738AFCF4));
			ytG700LmtbcSPfUEREx(exportRule11, ExportRuleType.Export);
			exportRuleList.Add(exportRule11);
			ExportRule obj2 = new ExportRule
			{
				ParentType = type,
				PropertyName = (string)rvcFKgHb2pteEnR2GTv(--296112178 ^ 0x11A6C17A)
			};
			ytG700LmtbcSPfUEREx(obj2, ExportRuleType.Export);
			exportRuleList.Add(obj2);
			ExportRule obj3 = new ExportRule
			{
				ParentType = type
			};
			CpEwR0LtkoYCqlXS2GD(obj3, rvcFKgHb2pteEnR2GTv(-1647793954 ^ -1647834998));
			obj3.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(obj3);
			ExportRule exportRule12 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule12, type);
			exportRule12.PropertyName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -419962331);
			ytG700LmtbcSPfUEREx(exportRule12, ExportRuleType.Export);
			exportRuleList.Add(exportRule12);
			ExportRule exportRule13 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule13, type);
			exportRule13.PropertyName = (string)rvcFKgHb2pteEnR2GTv(-2122743969 ^ -2122719267);
			exportRule13.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule13);
			ExportRule obj4 = new ExportRule
			{
				ParentType = type
			};
			CpEwR0LtkoYCqlXS2GD(obj4, rvcFKgHb2pteEnR2GTv(-1516552726 ^ -1516528290));
			ytG700LmtbcSPfUEREx(obj4, ExportRuleType.Export);
			exportRuleList.Add(obj4);
			ExportRule exportRule14 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule14, type);
			CpEwR0LtkoYCqlXS2GD(exportRule14, rvcFKgHb2pteEnR2GTv(0x5F800F5B ^ 0x5F80AF83));
			ytG700LmtbcSPfUEREx(exportRule14, ExportRuleType.Export);
			exportRuleList.Add(exportRule14);
			ExportRule exportRule15 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule15, type);
			CpEwR0LtkoYCqlXS2GD(exportRule15, rvcFKgHb2pteEnR2GTv(-1647793954 ^ -1647835104));
			ytG700LmtbcSPfUEREx(exportRule15, ExportRuleType.Export);
			exportRuleList.Add(exportRule15);
			ExportRule exportRule16 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule16, type);
			CpEwR0LtkoYCqlXS2GD(exportRule16, rvcFKgHb2pteEnR2GTv(-1712492721 ^ -1712468369));
			exportRule16.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule16);
			ExportRule obj5 = new ExportRule
			{
				ParentType = type,
				PropertyName = (string)rvcFKgHb2pteEnR2GTv(-1361036319 ^ -1361019615)
			};
			ytG700LmtbcSPfUEREx(obj5, ExportRuleType.Export);
			exportRuleList.Add(obj5);
			ExportRule exportRule17 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule17, type);
			CpEwR0LtkoYCqlXS2GD(exportRule17, rvcFKgHb2pteEnR2GTv(0x2F44D93A ^ 0x2F44786C));
			ytG700LmtbcSPfUEREx(exportRule17, ExportRuleType.Export);
			exportRuleList.Add(exportRule17);
			ExportRule exportRule18 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule18, type);
			CpEwR0LtkoYCqlXS2GD(exportRule18, rvcFKgHb2pteEnR2GTv(0x5DB28AD2 ^ 0x5DB22BBC));
			exportRule18.ExportRuleType = ExportRuleType.Export;
			exportRuleList.Add(exportRule18);
			ExportRule exportRule19 = new ExportRule();
			ulRCUjLyrr35DNR1sAg(exportRule19, type);
			CpEwR0LtkoYCqlXS2GD(exportRule19, rvcFKgHb2pteEnR2GTv(-1776305410 ^ -1776288638));
			ytG700LmtbcSPfUEREx(exportRule19, ExportRuleType.Export);
			exportRuleList.Add(exportRule19);
			return exportRuleList;
		}
	}

	[Transaction]
	public virtual void RecompileContext(IProcessHeader header)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass85_0 _003C_003Ec__DisplayClass85_ = default(_003C_003Ec__DisplayClass85_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 3:
			{
				WorkflowProcessManager workflowProcessManager = WorkflowProcessManager;
				ParameterExpression parameterExpression = (ParameterExpression)nd2i5dL5rkbQtl0TeGI(Kdc2VFLb3Pmi3mLRwsP(typeof(IWorkflowProcess).TypeHandle), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-135674354 ^ -135673420));
				workflowProcessManager.Find(Expression.Lambda<Func<IWorkflowProcess, bool>>((Expression)ExfHxRLdSUHqJMVGhi0(YvOmcFLBBaB6eZAbChE(parameterExpression, (MethodInfo)LKhsX8LgL0WYPURLpNy((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), b28rJSLXWYRxMXinol3(VEVK0mLc9QvCoJfm4fE(_003C_003Ec__DisplayClass85_, typeof(_003C_003Ec__DisplayClass85_0)), eIdI8RLPAoisiAZmDNq((RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/))), new ParameterExpression[1] { parameterExpression })).Each(WorkflowProcessManager.RecompileContext);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
				{
					num2 = 2;
				}
				break;
			}
			case 1:
				_003C_003Ec__DisplayClass85_ = new _003C_003Ec__DisplayClass85_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d != 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass85_.header = header;
				num2 = 3;
				break;
			}
		}
	}

	public override void SetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_0081, IL_0090, IL_017a, IL_0189, IL_0246
		int num = 19;
		int num2 = num;
		IProcessHeaderFilter processHeaderFilter = default(IProcessHeaderFilter);
		IEnumerable<IProcessHeader> startableProcesses = default(IEnumerable<IProcessHeader>);
		bool? hasPublished = default(bool?);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (processHeaderFilter.Ids == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 11;
			case 18:
				if (filter != null)
				{
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
					{
						num2 = 2;
					}
					break;
				}
				return;
			case 19:
				BA1LtZLu1JJlOTRdQLi(this, criteria, filter);
				num2 = 18;
				break;
			case 10:
				if (!R8u3diLLj6Sa6lc9thx(filter))
				{
					num2 = 12;
					break;
				}
				return;
			case 20:
				startableProcesses = GetStartableProcesses(processHeaderFilter);
				num2 = 14;
				break;
			case 23:
				if (!hasPublished.Value)
				{
					num2 = 21;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
					{
						num2 = 18;
					}
					break;
				}
				goto case 16;
			case 3:
				if (processHeaderFilter != null)
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
					{
						num2 = 7;
					}
					break;
				}
				return;
			case 6:
				processHeaderFilter = filter as IProcessHeaderFilter;
				num2 = 3;
				break;
			case 2:
			case 13:
				hasPublished = processHeaderFilter.HasPublished;
				num2 = 8;
				break;
			case 21:
				HWE0DgH3cPgaHjhdY5G(criteria, Restrictions.IsNull((string)rvcFKgHb2pteEnR2GTv(-1516552726 ^ -1516536976)));
				num2 = 17;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b == 0)
				{
					num2 = 6;
				}
				break;
			case 8:
				if (hasPublished.HasValue)
				{
					num2 = 15;
					break;
				}
				goto case 9;
			default:
				HWE0DgH3cPgaHjhdY5G(criteria, FvQirCLnDNKFRlwqjFu(rvcFKgHb2pteEnR2GTv(0x1EA50FCC ^ 0x1EA5494A), (ICollection)processHeaderFilter.Ids));
				num2 = 4;
				break;
			case 1:
			case 4:
				if (!processHeaderFilter.Startable)
				{
					num2 = 13;
					break;
				}
				goto case 20;
			case 12:
				if (!((ISecurityService)xUSbNsLfmbbmOP7wIvb(this)).HasPermission(WorkflowPermissionProvider.FullMonitorAccessPermission))
				{
					num2 = 22;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae2bde9e5844c638021cdb56fc01122 != 0)
					{
						num2 = 9;
					}
					break;
				}
				return;
			case 15:
				hasPublished = processHeaderFilter.HasPublished;
				num2 = 23;
				break;
			case 11:
				if (DeJIHOLD5D6VKp3TFXc(processHeaderFilter.Ids) > 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 16:
				HWE0DgH3cPgaHjhdY5G(criteria, s7DTxYLlwUB4UIEdS0h(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108877388 ^ -1108895442)));
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
				{
					num2 = 9;
				}
				break;
			case 22:
				HWE0DgH3cPgaHjhdY5G(criteria, Subqueries.PropertyIn((string)rvcFKgHb2pteEnR2GTv(-1647793954 ^ -1647776168), CreateDetachedCriteriaAllProcessHeader()));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
				{
					num2 = 5;
				}
				break;
			case 9:
			case 17:
				if (processHeaderFilter.MonitorProcessHeaderFilter)
				{
					num2 = 10;
					break;
				}
				return;
			case 5:
				return;
			case 14:
				criteria.Add((ICriterion)gkRI3fLH3wSDd9CgieZ(rvcFKgHb2pteEnR2GTv(-106528299 ^ -106510509), startableProcesses.Select((IProcessHeader h) => h.Id).Cast<object>().ToArray()));
				num2 = 2;
				break;
			}
		}
	}

	protected virtual ICriteria CreateDeletedCriteria()
	{
		return (ICriteria)HWE0DgH3cPgaHjhdY5G(((ICriteria)fOHYGFHk2swh6n27MSg(this, null)).Add((ICriterion)fVswrAHqcqW1cJpJHG6(rvcFKgHb2pteEnR2GTv(0xB7793C9 ^ 0xB77D579))), xLt1sQHRP7SMcf5I88T(rvcFKgHb2pteEnR2GTv(0x5F800F5B ^ 0x5F80499B), WorkflowProcessStatus.Deleted));
	}

	private DetachedCriteria CreateDetachedCriteriaAllProcessHeader()
	{
		int num = 2;
		int num2 = num;
		SqlSubQuery sqlSubQuery = default(SqlSubQuery);
		EleWise.ELMA.Security.Models.IUser currentUser = default(EleWise.ELMA.Security.Models.IUser);
		while (true)
		{
			switch (num2)
			{
			case 1:
				sqlSubQuery = ((SqlSubQuery)uuNsjZLjT5g5iNQIyJp(kP1HEYLRq2stftqSL4B(uuNsjZLjT5g5iNQIyJp(((SqlSubQuery)uuNsjZLjT5g5iNQIyJp(uuNsjZLjT5g5iNQIyJp(IHUdpqLWDtHglupksax(TXP37hHSLlsnibsJoyI(this), rvcFKgHb2pteEnR2GTv(-63028171 ^ -62986935)), rvcFKgHb2pteEnR2GTv(-1050383744 ^ -1050410664), InterfaceActivator.UID<IOrganizationItem>(loadImplementation: false)), rvcFKgHb2pteEnR2GTv(-1050383744 ^ -1050410638), InterfaceActivator.UID<IUserGroup>(loadImplementation: false))).SetParameter((string)rvcFKgHb2pteEnR2GTv(0x17F0C5A2 ^ 0x17F05792), (object)currentUser.Id), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x350C0E8 ^ 0x350528A), 1), rvcFKgHb2pteEnR2GTv(0x5BCD23A0 ^ 0x5BCD7CD6), new int[1] { 2 }), rvcFKgHb2pteEnR2GTv(-772614310 ^ -772651648), kOnWfrHx1Newwpa85b0(WorkflowPermissionProvider.ProcessMonitor))).SetParameter((string)rvcFKgHb2pteEnR2GTv(-29981480 ^ -30009858), (object)1);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				currentUser = ((IAuthenticationService)hWrEmEL9b0mjsRF9hOg(this)).GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
				{
					num2 = 1;
				}
				break;
			default:
			{
				object obj = HEV54yL67984fPFQANk(InterfaceActivator.TypeOf<IProcessHeader>(), rvcFKgHb2pteEnR2GTv(--1756698829 ^ 0x68B5B971));
				coNdfoLQbiP8aiTSgsn(obj, UU2MMCLTu5JSEoWFKYF(ruEsPrHQeAMMeZEXK0U(rvcFKgHb2pteEnR2GTv(0x6A69C5CD ^ 0x6A696417), N2BUjZH1vjdEJAMAjtj(Y1YE5IHGnOBBkaHN3ap(TransformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-708128192 ^ -708143930)), RIIitULqdeBB8LERdC5(sqlSubQuery)), N9p5nQL3EEoUyfFZA4u(sqlSubQuery), sqlSubQuery.ParametersTypes));
				((DetachedCriteria)obj).SetProjection((IProjection)(object)Projections.Property((string)rvcFKgHb2pteEnR2GTv(-2122743969 ^ -2122761767)));
				return (DetachedCriteria)obj;
			}
			}
		}
	}

	private void MarkChildPublishedAsDraft(IProcessHeader header)
	{
		//Discarded unreachable code: IL_008f, IL_009e, IL_016d, IL_018c, IL_019b, IL_01c8, IL_01d7
		int num = 3;
		int num2 = num;
		IEnumerator<IProcessHeader> enumerator = default(IEnumerator<IProcessHeader>);
		IProcessHeader current = default(IProcessHeader);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				enumerator = ((IEnumerable<IProcessHeader>)header.SubHeaders).GetEnumerator();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				AnU5VrH5UsTeMMG3UvE(header, rvcFKgHb2pteEnR2GTv(0x13F63440 ^ 0x13F65D7E));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						IL_0108:
						int num3;
						if (!ME0NO8HLWGvt0UYHYB0(enumerator))
						{
							num3 = 4;
							goto IL_00ad;
						}
						goto IL_00cf;
						IL_00ad:
						while (true)
						{
							switch (num3)
							{
							case 3:
							{
								PYwbTBHgZioeA93dFIE(current, WorkflowProcessStatus.Draft);
								int num4 = 5;
								num3 = num4;
								continue;
							}
							case 2:
								goto IL_0108;
							case 1:
								if (ym4dh5Hcvwrw89c5Rx2(current) == WorkflowProcessStatus.Published)
								{
									num3 = 3;
									continue;
								}
								goto case 5;
							case 5:
								MarkChildPublishedAsDraft(current);
								num3 = 2;
								continue;
							case 4:
								return;
							}
							break;
						}
						goto IL_00cf;
						IL_00cf:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 != 0)
						{
							num3 = 1;
						}
						goto IL_00ad;
					}
				}
				finally
				{
					int num5;
					if (enumerator == null)
					{
						num5 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 != 0)
						{
							num5 = 0;
						}
						goto IL_0171;
					}
					goto IL_01a6;
					IL_01a6:
					D4Ug5yHPwwK89lLN8AD(enumerator);
					num5 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
					{
						num5 = 0;
					}
					goto IL_0171;
					IL_0171:
					switch (num5)
					{
					default:
						goto end_IL_014c;
					case 0:
						goto end_IL_014c;
					case 2:
						break;
					case 1:
						goto end_IL_014c;
					}
					goto IL_01a6;
					end_IL_014c:;
				}
			case 0:
				return;
			}
		}
	}

	private bool IsValidIdentifierName(string name, out string errorMessage)
	{
		//Discarded unreachable code: IL_0051, IL_0060, IL_0095, IL_00a4, IL_00c9
		int num = 10;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 9:
				if (!OjUPSiLsAcIdjYiic5K(name))
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 5;
			case 8:
				return false;
			case 11:
				return true;
			case 10:
				errorMessage = string.Empty;
				num2 = 9;
				continue;
			case 5:
				errorMessage = (string)IsPF52HW4TAJ2MCrLkr(rvcFKgHb2pteEnR2GTv(0x17F0C5A2 ^ 0x17F05164));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				errorMessage = SR.T((string)rvcFKgHb2pteEnR2GTv(-14356676 ^ -14398030));
				num2 = 8;
				continue;
			default:
				return false;
			case 4:
				if (!AqphBALpl8btc7VepNg(name, rvcFKgHb2pteEnR2GTv(-148495695 ^ -148476939)))
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6f64eb224ece438ba2f0bbd2f29cebfd == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 7:
				return false;
			case 1:
				if (Lt1w9XLCDYoHwTeyCYP(name))
				{
					num2 = 11;
					continue;
				}
				goto case 3;
			case 2:
				if (!EhRjalH9akrMCWEnSWe(KD8YJbHfxeYjYtl5lrr(name), string.Empty))
				{
					num2 = 4;
					continue;
				}
				goto case 5;
			case 6:
				break;
			}
			errorMessage = (string)IsPF52HW4TAJ2MCrLkr(rvcFKgHb2pteEnR2GTv(-1647793954 ^ -1647834390));
			num2 = 7;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d != 0)
			{
				num2 = 4;
			}
		}
	}

	private ICriteria CreateRootProcessHeadsCriteria()
	{
		return (ICriteria)HWE0DgH3cPgaHjhdY5G(HWE0DgH3cPgaHjhdY5G(HWE0DgH3cPgaHjhdY5G(fOHYGFHk2swh6n27MSg(this, null), fVswrAHqcqW1cJpJHG6(rvcFKgHb2pteEnR2GTv(-1539486135 ^ -1539445165))), fVswrAHqcqW1cJpJHG6(rvcFKgHb2pteEnR2GTv(0x6A69C5CD ^ 0x6A69837D))), Restrictions.Not((ICriterion)xLt1sQHRP7SMcf5I88T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683729568), WorkflowProcessStatus.Deleted)));
	}

	private ICriteria CreateRootProcessHeaderCriteria(IProcessGroup group)
	{
		object obj = fOHYGFHk2swh6n27MSg(this, null);
		object obj2;
		ParameterExpression parameterExpression;
		if (group != null)
		{
			parameterExpression = (ParameterExpression)nd2i5dL5rkbQtl0TeGI(typeof(IProcessHeader), rvcFKgHb2pteEnR2GTv(-1657582555 ^ -1657552419));
			obj2 = xLt1sQHRP7SMcf5I88T(LinqUtils.NameOf(Expression.Lambda<Func<IProcessHeader, object>>((Expression)YvOmcFLBBaB6eZAbChE(parameterExpression, (MethodInfo)LKhsX8LgL0WYPURLpNy((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })), group);
		}
		else
		{
			parameterExpression = Expression.Parameter(Kdc2VFLb3Pmi3mLRwsP(typeof(IProcessHeader).TypeHandle), (string)rvcFKgHb2pteEnR2GTv(-2077784392 ^ -2077816000));
			obj2 = Restrictions.IsNull(LinqUtils.NameOf(Expression.Lambda<Func<IProcessHeader, object>>((Expression)YvOmcFLBBaB6eZAbChE(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
		}
		object obj3 = HWE0DgH3cPgaHjhdY5G(obj, obj2);
		parameterExpression = (ParameterExpression)nd2i5dL5rkbQtl0TeGI(typeof(IProcessHeader), rvcFKgHb2pteEnR2GTv(-682910880 ^ -682944872));
		return (ICriteria)HWE0DgH3cPgaHjhdY5G(((ICriteria)obj3).Add((ICriterion)fVswrAHqcqW1cJpJHG6(LinqUtils.NameOf(Expression.Lambda<Func<IProcessHeader, object>>((Expression)YvOmcFLBBaB6eZAbChE(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })))), Restrictions.Not((ICriterion)xLt1sQHRP7SMcf5I88T(rvcFKgHb2pteEnR2GTv(-683713632 ^ -683729568), WorkflowProcessStatus.Deleted)));
	}

	public ProcessHeaderManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		pq22IILMe1yMvrOCpQC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ProcessHeaderManager()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				GetProcessMonitorAllHeaderInfoTimeStamp = (string)rvcFKgHb2pteEnR2GTv(0x4940763B ^ 0x4940D56B);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool nvEwGuH0Nw1p4Thg4X7()
	{
		return AgVrx3HlNciW7GRQc5v == null;
	}

	internal static ProcessHeaderManager ts4eWXHySZeXJcPdW8J()
	{
		return AgVrx3HlNciW7GRQc5v;
	}

	internal static void txgU0MHmyxrYXWlQwa1(object P_0, object P_1, object P_2, bool generateDocumentation)
	{
		((ProcessHeaderManager)P_0).Publish((IProcessHeader)P_1, (string)P_2, generateDocumentation);
	}

	internal static TaskAwaiter AwbItAHtqB0y4p3GsTs(object P_0)
	{
		return ((Task)P_0).GetAwaiter();
	}

	internal static object rvcFKgHb2pteEnR2GTv(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void AnU5VrH5UsTeMMG3UvE(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void PYwbTBHgZioeA93dFIE(object P_0, WorkflowProcessStatus value)
	{
		((IProcessHeader)P_0).Status = value;
	}

	internal static void n3yDpIHBturqUWvOCiM(object P_0, bool value)
	{
		((IProcessHeader)P_0).IsDirtyProcess = value;
	}

	internal static WorkflowProcessStatus ym4dh5Hcvwrw89c5Rx2(object P_0)
	{
		return ((IProcessHeader)P_0).Status;
	}

	internal static void D4Ug5yHPwwK89lLN8AD(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object jFYQOBHXcKYF0SPLCbM(object P_0)
	{
		return ((IProcessHeader)P_0).Parent;
	}

	internal static object fHfXpXHdXADVDIsJC6K(object P_0)
	{
		return ((IProcessHeader)P_0).Published;
	}

	internal static object JSIxfjHuhlhdpTx2w8r()
	{
		return WorkflowProcessManager.Instance;
	}

	internal static void uSGJD9HDA1aSkUA7wyV(object P_0)
	{
		((WorkflowProcessManager<IWorkflowProcess>)P_0).UpdateLastPublishTime();
	}

	internal static void uJX5uPHnPujVw0aRGrv(object P_0, object P_1)
	{
		((IProcessHeader)P_0).ParentGroup = (IProcessGroup)P_1;
	}

	internal static object Syk5wNHHgV3wkpHDm8Z()
	{
		return ComponentManager.Current;
	}

	internal static bool ME0NO8HLWGvt0UYHYB0(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static object KD8YJbHfxeYjYtl5lrr(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static bool EhRjalH9akrMCWEnSWe(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}

	internal static object IsPF52HW4TAJ2MCrLkr(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object UNYIMRHjum5l1n646jR(object P_0, object P_1)
	{
		return ElmaRestrictions.InsensitiveLike((string)P_0, P_1);
	}

	internal static object xLt1sQHRP7SMcf5I88T(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object it5099H6OcSu2lYuaCT(object P_0)
	{
		return Restrictions.Not((ICriterion)P_0);
	}

	internal static object fVswrAHqcqW1cJpJHG6(object P_0)
	{
		return Restrictions.IsNull((string)P_0);
	}

	internal static object HWE0DgH3cPgaHjhdY5G(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object E0D5pkHTdC5LbTUDyNk(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object ruEsPrHQeAMMeZEXK0U(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static int CeRlhfHpU0CjksZPajD(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object Gr1krcHCeOyJYjPXNPn(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static bool HGUdU8HMTfYME1sNPw4(object P_0)
	{
		return CSharpHelper.IsKeyword((string)P_0);
	}

	internal static object fOHYGFHk2swh6n27MSg(object P_0, object P_1)
	{
		return ((EntityManager<IProcessHeader, long>)P_0).CreateCriteria((IEntityFilter)P_1);
	}

	internal static object KANxu1HUWoL4j1UbotC(object P_0, object P_1, object P_2)
	{
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2);
	}

	internal static object NX2oBLHVx3uQUecO008(object P_0, object P_1)
	{
		return Restrictions.Or((ICriterion)P_0, (ICriterion)P_1);
	}

	internal static bool JyJkSDHAh9eDVH2Rvyd(object P_0, object P_1)
	{
		return ((EntityManager<IProcessHeader, long>)P_0).ReturnExists((ICriteria)P_1);
	}

	internal static object Y1YE5IHGnOBBkaHN3ap(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static bool MMmkqHH7cpXuKx6vGuT(object P_0, object P_1)
	{
		return ((Dialect)P_0).IsReservedWord((string)P_1);
	}

	internal static void IyoqRxH2Qds4sWUsZhn(object P_0, object P_1)
	{
		Contract.ServiceNotNull(P_0, (string)P_1);
	}

	internal static object ws8Xs3HoLs5hRPFdLf1(object P_0)
	{
		return ((IProcessHeader)P_0).Context;
	}

	internal static object xkSL9rHFNqxU31V4hB9(object P_0)
	{
		return ((EntityMetadata)P_0).TableName;
	}

	internal static bool JYm8kMHiRh3FvQ1LvlG(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static bool VXlSpoHIi9JnRccdJAN(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static object NwLivSHaQ9HU9a3GPik(object P_0)
	{
		return ((IProcessHeader)P_0).ProcessMetrics;
	}

	internal static object iICSv2HrQcTAdLjFYpk(object P_0)
	{
		return ((IProcessHeader)P_0).InstanceMetrics;
	}

	internal static object TjmWqBHeGLAFwfCkdlg(object P_0)
	{
		return ((IProcessHeader)P_0).PublishedEmulation;
	}

	internal static object PNW6HmHNZmC0S81IApI(object P_0)
	{
		return string.Concat((object[])P_0);
	}

	internal static Guid kOnWfrHx1Newwpa85b0(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static object TXP37hHSLlsnibsJoyI(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object N2BUjZH1vjdEJAMAjtj(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object Pu2Q0OHhDPLsxxWVTH6(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).NoLockTableExpression((string)P_1, (string)P_2);
	}

	internal static object IGfZBEHEWciKSfspimf(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object iXE0m5HwXbt7oy8KOC8(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLQuery((string)P_1);
	}

	internal static object V4ZXUAH4s1Ba7xMIWp8(object P_0, bool P_1)
	{
		return ((IQuery)P_0).CleanUpCache(P_1);
	}

	internal static void lVxsXbHzG8046GycyJk(object P_0, int value)
	{
		((ProcessInstanceStatistics)P_0).InstancesCount = value;
	}

	internal static object dOrvnNLKAlmE93JaDUe(object P_0)
	{
		return ((IQuery)P_0).UniqueResult();
	}

	internal static long GW38iHLO273DjW6qGR9(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object vwD2OALZYTgl816CeC1(object P_0)
	{
		return ((ProcessHeaderManager)P_0).CreateDeletedCriteria();
	}

	internal static long y835WlLvYrqeF7IJpCn(object P_0, object P_1)
	{
		return ((EntityManager<IProcessHeader, long>)P_0).ReturnCount((ICriteria)P_1);
	}

	internal static object Rm4xIKLYNGDrBPDSKOG(object P_0, object P_1)
	{
		return ((ISession)P_0).GetNamedQuery((string)P_1);
	}

	internal static int rgHLaTL8N0r1ZQbXQtN(object P_0)
	{
		return ((ICollection<object[]>)P_0).Count;
	}

	internal static bool OjUPSiLsAcIdjYiic5K(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object QCqipULJKdY7H7yxZVD(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object s7DTxYLlwUB4UIEdS0h(object P_0)
	{
		return Restrictions.IsNotNull((string)P_0);
	}

	internal static void bnquH4L0JayvDlEW5lg(object P_0, int value)
	{
		((ProcessCommonStatistics)P_0).PublishedCount = value;
	}

	internal static void ulRCUjLyrr35DNR1sAg(object P_0, Type P_1)
	{
		((ExportRule)P_0).ParentType = P_1;
	}

	internal static void ytG700LmtbcSPfUEREx(object P_0, ExportRuleType P_1)
	{
		((ExportRule)P_0).ExportRuleType = P_1;
	}

	internal static void CpEwR0LtkoYCqlXS2GD(object P_0, object P_1)
	{
		((ExportRule)P_0).PropertyName = (string)P_1;
	}

	internal static Type Kdc2VFLb3Pmi3mLRwsP(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object nd2i5dL5rkbQtl0TeGI(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object LKhsX8LgL0WYPURLpNy(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object YvOmcFLBBaB6eZAbChE(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object VEVK0mLc9QvCoJfm4fE(object P_0, Type P_1)
	{
		return Expression.Constant(P_0, P_1);
	}

	internal static object eIdI8RLPAoisiAZmDNq(RuntimeFieldHandle P_0)
	{
		return FieldInfo.GetFieldFromHandle(P_0);
	}

	internal static object b28rJSLXWYRxMXinol3(object P_0, object P_1)
	{
		return Expression.Field((Expression)P_0, (FieldInfo)P_1);
	}

	internal static object ExfHxRLdSUHqJMVGhi0(object P_0, object P_1)
	{
		return Expression.Equal((Expression)P_0, (Expression)P_1);
	}

	internal static void BA1LtZLu1JJlOTRdQLi(object P_0, object P_1, object P_2)
	{
		((EntityManager<IProcessHeader, long>)P_0).SetupFilter((ICriteria)P_1, (IEntityFilter)P_2);
	}

	internal static int DeJIHOLD5D6VKp3TFXc(object P_0)
	{
		return ((ICollection<long>)P_0).Count;
	}

	internal static object FvQirCLnDNKFRlwqjFu(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (ICollection)P_1);
	}

	internal static object gkRI3fLH3wSDd9CgieZ(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (object[])P_1);
	}

	internal static bool R8u3diLLj6Sa6lc9thx(object P_0)
	{
		return ((IEntityFilter)P_0).DisableSecurity;
	}

	internal static object xUSbNsLfmbbmOP7wIvb(object P_0)
	{
		return ((EntityManager<IProcessHeader, long>)P_0).SecurityService;
	}

	internal static object hWrEmEL9b0mjsRF9hOg(object P_0)
	{
		return ((EntityManager<IProcessHeader, long>)P_0).AuthenticationService;
	}

	internal static object IHUdpqLWDtHglupksax(object P_0, object P_1)
	{
		return ((ISession)P_0).GetNamedSubQuery((string)P_1);
	}

	internal static object uuNsjZLjT5g5iNQIyJp(object P_0, object P_1, object P_2)
	{
		return ((SqlSubQuery)P_0).SetParameter((string)P_1, P_2);
	}

	internal static object kP1HEYLRq2stftqSL4B(object P_0, object P_1, object P_2)
	{
		return ((SqlSubQuery)P_0).SetParameterList((string)P_1, (ICollection)P_2);
	}

	internal static object HEV54yL67984fPFQANk(Type P_0, object P_1)
	{
		return DetachedCriteria.For(P_0, (string)P_1);
	}

	internal static object RIIitULqdeBB8LERdC5(object P_0)
	{
		return ((SqlSubQuery)P_0).Sql;
	}

	internal static object N9p5nQL3EEoUyfFZA4u(object P_0)
	{
		return ((SqlSubQuery)P_0).ParametersValues;
	}

	internal static object UU2MMCLTu5JSEoWFKYF(object P_0, object P_1, object P_2)
	{
		return Expression.Sql((string)P_0, (object[])P_1, (IType[])P_2);
	}

	internal static object coNdfoLQbiP8aiTSgsn(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).Add((ICriterion)P_1);
	}

	internal static bool AqphBALpl8btc7VepNg(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static bool Lt1w9XLCDYoHwTeyCYP(object P_0)
	{
		return ((string)P_0).IsValidIdentifier();
	}

	internal static void pq22IILMe1yMvrOCpQC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
