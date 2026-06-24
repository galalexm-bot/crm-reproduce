using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Common.ExtensionPoints;
using EleWise.ELMA.Common.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Audit;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Connectors;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Swimlanes;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
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

public class WorkflowTaskBaseManager : EntityExtensionManager<ITaskBase, IWorkflowTaskBase, long, TaskBaseManager>
{
	private readonly IAuthenticationService authenticationService;

	internal static WorkflowTaskBaseManager Ox36TN91demnlJCMrFe;

	public ISecurityService SecurityService => Locator.GetServiceNotNull<ISecurityService>();

	[NotNull]
	public ICommentActionHandler CommentActionHandler => Locator.GetServiceNotNull<ICommentActionHandler>();

	[NotNull]
	public new IEntityActionHandler ActionHandler => Locator.GetServiceNotNull<IEntityActionHandler>();

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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
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

	public static WorkflowTaskBaseManager Instance => Locator.GetServiceNotNull<WorkflowTaskBaseManager>();

	public IEnumerable<IDenyReassignExecutorInElementExtentions> DenyReassignExecutorInElementExtentions { get; set; }

	public WorkflowTaskBaseManager(IAuthenticationService authenticationService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
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
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[Transaction]
	public virtual void DoCompleted(IWorkflowTaskBase task)
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
				ActionHandler.ActionExecuted(new EntityActionEventArgs(task, task, Xnipb09wvsCosF23YhA()));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_08023922bb0e4e809e5cff73a2b04988 == 0)
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
	public virtual void DoCompletedWithTransition(IWorkflowTaskBase task, BPMNFlowElement element, Guid connectorUid)
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
				DoCompletedWithTransition(task, element, connectorUid, null);
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

	[Transaction]
	public virtual void DoCompletedWithTransition(IWorkflowTaskBase task, BPMNFlowElement element, Guid connectorUid, Action<TaskActionEventArgs> processArgsFunc)
	{
		_003C_003Ec__DisplayClass19_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass19_0();
		CS_0024_003C_003E8__locals0.connectorUid = connectorUid;
		FlowConnectorElement flowConnectorElement = element.StandardOutputFlows.FirstOrDefault((FlowConnectorElement c) => _003C_003Ec__DisplayClass19_0.IabIxDZMrGYiTHpAu9j8(c.Uid, CS_0024_003C_003E8__locals0.connectorUid));
		if (flowConnectorElement != null)
		{
			TaskActionEventArgs taskActionEventArgs = new TaskActionEventArgs(task, task, TaskBaseActions.CompleteGuid);
			taskActionEventArgs.Caption = SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACC6B33), (!string.IsNullOrEmpty(flowConnectorElement.Name)) ? flowConnectorElement.Name : flowConnectorElement.EndElement.Name);
			TaskActionEventArgs taskActionEventArgs2 = taskActionEventArgs;
			processArgsFunc?.Invoke(taskActionEventArgs2);
			ActionHandler.ActionExecuted(taskActionEventArgs2);
		}
		else
		{
			DoCompleted(task);
		}
	}

	[ContextCache]
	public virtual bool HasSubordinateUsersActiveTasks(EleWise.ELMA.Security.Models.IUser user, IWorkflowInstance instance)
	{
		int num = 1;
		int num2 = num;
		SqlSubQuery sqlSubQuery = default(SqlSubQuery);
		while (true)
		{
			switch (num2)
			{
			case 1:
				sqlSubQuery = (SqlSubQuery)EHQo0mWO20Rk0YHa5SH(oaBZcOWK04FTL4KwHkR(alJdW2947XdNjpnwu2X(this), fO5GdO9zG9pghbe23W7(0x17F0C5A2 ^ 0x17F072A8)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22386240), user.Id);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
				{
					num2 = 0;
				}
				break;
			default:
			{
				ICriteria obj = ((ICriteria)jIbRmFWvWkopou2huEa(qqT5pEWZ5B6S9p7nwfC(this), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1756698829 ^ 0x68B572F7), fO5GdO9zG9pghbe23W7(-261315199 ^ -261307369), (JoinType)0)).CreateAlias((string)fO5GdO9zG9pghbe23W7(0x361628FF ^ 0x36169F27), (string)fO5GdO9zG9pghbe23W7(--727842433 ^ 0x2B619F29), (JoinType)0);
				object obj2 = fO5GdO9zG9pghbe23W7(0xB7793C9 ^ 0xB77D509);
				object[] array = (object[])sXYC9RWYPVvryQWW2LT();
				return XCX0OZWBkYMBw15F9TP(((ICriteria)Woqb4dWg57nHwYTZsE1(MslSvPWbAl06LuI9p5H(IAL2r5WsRPnswinGCJB(IAL2r5WsRPnswinGCJB(IAL2r5WsRPnswinGCJB(obj, rdrWmyW8OpL5A0xga0f(obj2, array)), Restrictions.Eq((string)fO5GdO9zG9pghbe23W7(-1716458555 ^ -1716495331), (object)instance)), AJme1qWta34Txuhy7U1(yLi8G1W0ax4YJTN16dd(new string[5]
				{
					(string)fO5GdO9zG9pghbe23W7(-360662087 ^ -360706997),
					(string)lOb3ZmWlvoVHNGhDMud(sqAV1sWJWxnq7ZgWh1U(TransformationProvider), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-768800937 ^ -768774799)),
					SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716497469),
					sqlSubQuery.Sql,
					(string)fO5GdO9zG9pghbe23W7(-683713632 ^ -683733806)
				}), EOgvktWykiPinNMdSF8(sqlSubQuery), C6Q8KhWmbjhXTQ74J2Y(sqlSubQuery))), 1), new IProjection[1] { (IProjection)DQw42TW5qKPw97LqEZC() })).UniqueResult()) > 0;
			}
			}
		}
	}

	[ContextCache]
	public virtual bool HasUserActiveTasks(EleWise.ELMA.Security.Models.IUser user, IWorkflowInstance instance)
	{
		object obj = jIbRmFWvWkopou2huEa(jIbRmFWvWkopou2huEa(CreateCriteriaNoPermissions(), fO5GdO9zG9pghbe23W7(0x34EA50D4 ^ 0x34EA3AEE), fO5GdO9zG9pghbe23W7(0x46EA3D1 ^ 0x46EC247), (JoinType)0), fO5GdO9zG9pghbe23W7(-1516552726 ^ -1516533198), fO5GdO9zG9pghbe23W7(-398691253 ^ -398715421), (JoinType)0);
		object obj2 = fO5GdO9zG9pghbe23W7(0x4940763B ^ 0x494030FB);
		object[] array = (object[])sXYC9RWYPVvryQWW2LT();
		return XCX0OZWBkYMBw15F9TP(((ICriteria)Woqb4dWg57nHwYTZsE1(MslSvPWbAl06LuI9p5H(IAL2r5WsRPnswinGCJB(((ICriteria)obj).Add((ICriterion)(object)Restrictions.In((string)obj2, array)).Add((ICriterion)Vg6fafWcr4rFO21uUcA(fO5GdO9zG9pghbe23W7(-25709590 ^ -25754574), instance)), Vg6fafWcr4rFO21uUcA(fO5GdO9zG9pghbe23W7(-1514166050 ^ -1514159368), user)), 1), new IProjection[1] { (IProjection)DQw42TW5qKPw97LqEZC() })).UniqueResult()) > 0;
	}

	public IEnumerable<IWorkflowTaskBase> GetTasks(IWorkflowBookmark bookmark)
	{
		return CreateCriteriaNoPermissions().Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x548A71FA), (object)bookmark)).List<IWorkflowTaskBase>();
	}

	public IList<IWorkflowTaskBase> FindMyActiveTasks(IWorkflowInstance instance)
	{
		return FindMyActiveTasks(instance, allowSubInstances: false);
	}

	public IList<IWorkflowTaskBase> FindMyActiveTasks(IWorkflowInstance instance, bool allowSubInstances)
	{
		IList<IWorkflowTaskBase> list = FindMyActiveTasks(instance, allowSubInstances, startFromRoot: false);
		if (list.Count > 0 || !allowSubInstances)
		{
			return list;
		}
		return FindMyActiveTasks(instance, allowSubInstances, startFromRoot: true);
	}

	public IList<IWorkflowTaskBase> GetTasks(IWorkflowInstance instance)
	{
		return GetTasks(instance, allowSubInstances: false);
	}

	public IList<IWorkflowTaskBase> GetTasks(IWorkflowInstance instance, bool allowSubInstances)
	{
		return GetTasks(instance, allowSubInstances, null);
	}

	public IList<IWorkflowTaskBase> GetTasks(IWorkflowInstance instance, bool allowSubInstances, List<string> projections)
	{
		ICriteria val = CreateCriteriaNoPermissions();
		SetupGetActiveTasksCriteria(val, null, allowSubInstances, startFromRoot: false, new IWorkflowInstance[1] { instance });
		base.Manager.SetProjections(val, base.ImplementationType, projections);
		return val.List<IWorkflowTaskBase>();
	}

	public IList<IWorkflowTaskBase> GetAllTasks(IWorkflowInstance instance)
	{
		return GetAllTasks(instance, allowSubInstances: false);
	}

	public IList<IWorkflowTaskBase> GetAllTasks(IWorkflowInstance instance, bool allowSubInstances)
	{
		return GetAllTasks(instance, allowSubInstances, null);
	}

	public IList<IWorkflowTaskBase> GetAllTasks(IWorkflowInstance instance, bool allowSubInstances, List<string> projections)
	{
		return GetAllTasks(instance, allowSubInstances, null, null);
	}

	public IList<IWorkflowTaskBase> GetAllTasks(IWorkflowInstance instance, bool allowSubInstances, List<string> projections, Guid[] guid)
	{
		ICriteria val = CreateCriteriaNoPermissions();
		SetupGetAllTasksCriteria(val, null, allowSubInstances, startFromRoot: false, new IWorkflowInstance[1] { instance }, guid);
		base.Manager.SetProjections(val, base.ImplementationType, projections);
		return val.List<IWorkflowTaskBase>();
	}

	public List<IWorkflowTaskBase> GetTasks(IEnumerable<IWorkflowInstance> instanceList)
	{
		return GetTasks(instanceList, allowSubInstances: false);
	}

	protected virtual void SetupGetAllTasksCriteria(ICriteria criteria, EleWise.ELMA.Security.Models.IUser executor, bool allowSubInstances, bool startFromRoot, IEnumerable<IWorkflowInstance> instanceList, Guid[] guid)
	{
		Contract.ArgumentNotNull(instanceList, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122768859));
		criteria.CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862352772), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420003255 ^ -420011041)).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75BAD659 ^ 0x75BA6181), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56F860D7 ^ 0x56F8017F));
		if (guid != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-763667953 ^ -763677767), (ICollection)guid));
		}
		if (!allowSubInstances)
		{
			criteria.Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1539486135 ^ -1539442287), (ICollection)instanceList.ToList()));
		}
		else
		{
			ICriterion val = WorkflowInstanceManager.Instance.CreateChildInstancesCriterion(instanceList, startFromRoot, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF69032));
			criteria.Add(val);
		}
		if (executor != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077758306), (object)executor));
		}
	}

	public List<IWorkflowTaskBase> GetTasks(IEnumerable<IWorkflowInstance> instanceList, bool allowSubInstances)
	{
		Contract.ArgumentNotNull(instanceList, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1303601216 ^ -1303576902));
		ICriteria val = CreateCriteriaNoPermissions();
		SetupGetActiveTasksCriteria(val, null, allowSubInstances, startFromRoot: false, instanceList);
		return val.List<IWorkflowTaskBase>().ToList();
	}

	protected DetachedCriteria GetDetachedCriteriaByInstanceFilter(long? filterId)
	{
		DetachedCriteria result = null;
		if (filterId.HasValue)
		{
			IWorkflowInstanceFilter filter = WorkflowInstanceManager.Instance.ExtractWorkflowInstanceFilter(filterId.Value);
			return GetDetachedCriteriaByInstanceFilter(filter);
		}
		return result;
	}

	protected DetachedCriteria GetDetachedCriteriaByInstanceFilter(IWorkflowInstanceFilter filter)
	{
		//Discarded unreachable code: IL_00a4, IL_00b3, IL_00c3
		int num = 3;
		int num2 = num;
		DetachedCriteria val2 = default(DetachedCriteria);
		ICriteria val = default(ICriteria);
		while (true)
		{
			switch (num2)
			{
			case 5:
			case 8:
			case 10:
				return val2;
			case 1:
				val2 = (DetachedCriteria)wIw9t3WnIvjl0vLxmq8(val);
				num2 = 6;
				break;
			case 6:
				oCVxuXWfmIqNDuDWJeh(val2, tLqxGXWLSQaylQb43HB(eCNH57WHuwEVQtF0Dkw(eLi4eIWu7jg16DgRc7x(), fO5GdO9zG9pghbe23W7(0x75872B6 ^ 0x7583430))));
				num2 = 10;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 == 0)
				{
					num2 = 6;
				}
				break;
			case 2:
				if (filter != null)
				{
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 5;
			case 9:
				if (filter.ContextFilter == null)
				{
					num2 = 5;
					break;
				}
				goto default;
			case 4:
				val = (ICriteria)gMoXa7WdX1i12G4LWLR(WorkflowInstanceManager.Instance, filter, MsiYbOWXoqjIwWAkFZP());
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
				{
					num2 = 7;
				}
				break;
			case 3:
				val2 = null;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				TmZiYfWD6GlEgyxISJT(eLi4eIWu7jg16DgRc7x(), val, filter);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 == 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (kQl3QcWPDqXy8Q0cpxd(filter) == null)
				{
					num2 = 8;
					break;
				}
				goto case 4;
			}
		}
	}

	public List<ActivityInfoHeader> GetTasksCountByActivitiesSwimlayn(long headerId, long? filterId)
	{
		DetachedCriteria detachedCriteriaByInstanceFilter = GetDetachedCriteriaByInstanceFilter(filterId);
		return GetTasksCountByActivitiesSwimlayn(headerId, detachedCriteriaByInstanceFilter);
	}

	public IList<ElementActiveTasks> GetElementsWithTaskCountByInstance(IWorkflowInstance instance)
	{
		return GetElementsWithTaskCountByInstance(instance, onlyActiveTasks: true);
	}

	public IList<ElementActiveTasks> GetElementsWithTaskCountByInstance(IWorkflowInstance instance, bool onlyActiveTasks)
	{
		_003C_003Ec__DisplayClass39_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass39_0();
		CS_0024_003C_003E8__locals0.elements = instance.Process.Diagram.Elements.OfType<TaskElement>().ToList();
		ICriteria val = CreateCriteria().CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x1927B0A9), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA7339EE ^ 0xA7381FA), (JoinType)0).Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39142528), (ICollection)CS_0024_003C_003E8__locals0.elements.Select((TaskElement x) => x.Uid).ToArray())).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -62981105), (object)instance))
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.GroupProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51EF0063 ^ 0x51EFB87F)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772641010)).Add((IProjection)(object)Projections.Count(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1927DA93 ^ 0x19279C15)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xB7793C9 ^ 0xB772BA5))
				.Add((IProjection)(object)Projections.Min(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6CC04061 ^ 0x6CC006E7)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747F4362)) })
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ElementActiveTasks)));
		if (onlyActiveTasks)
		{
			string text = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-862330810 ^ -862345594);
			object[] activeTaskStatuses = TaskBaseExtensions.ActiveTaskStatuses;
			val.Add((ICriterion)(object)Restrictions.In(text, activeTaskStatuses));
		}
		IList<ElementActiveTasks> list = val.List<ElementActiveTasks>();
		list.ForEach(delegate(ElementActiveTasks r)
		{
			int num = 2;
			int num2 = num;
			_003C_003Ec__DisplayClass39_1 _003C_003Ec__DisplayClass39_ = default(_003C_003Ec__DisplayClass39_1);
			while (true)
			{
				switch (num2)
				{
				default:
					_003C_003Ec__DisplayClass39_.r.Element = CS_0024_003C_003E8__locals0.elements.Find(_003C_003Ec__DisplayClass39_._003CGetElementsWithTaskCountByInstance_003Eb__2);
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 3;
					}
					break;
				case 1:
					_003C_003Ec__DisplayClass39_.r = r;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
					{
						num2 = 0;
					}
					break;
				case 3:
					return;
				case 2:
					_003C_003Ec__DisplayClass39_ = new _003C_003Ec__DisplayClass39_1();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		});
		return list;
	}

	public List<ActivityInfoHeader> GetTasksCountByActivitiesSwimlayn(long headerId, IWorkflowInstanceFilter filter)
	{
		DetachedCriteria detachedCriteriaByInstanceFilter = GetDetachedCriteriaByInstanceFilter(filter);
		return GetTasksCountByActivitiesSwimlayn(headerId, detachedCriteriaByInstanceFilter);
	}

	private List<ActivityInfoHeader> GetTasksCountByActivitiesSwimlayn(long headerId, DetachedCriteria instanceFilter)
	{
		CustomSQLCriterion customSQLCriterion = new CustomSQLCriterion(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716458555 ^ -1716497575), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712518331)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431991414)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1361019567)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x69063C81 ^ 0x6906642B)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1600060848 ^ -1600037784)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050399738)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34EA17D0)), TransformationProvider.Dialect.QuoteIfNeeded(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF69964))), new object[1] { headerId }, (IType[])(object)new IType[1] { (IType)NHibernateUtil.Int64 }, (SqlString sql, ICriteria c, ICriteriaQuery criteriaQuery) => (SqlString)_003C_003Ec.neIFJUZksq4juPl2agX0(sql.Replace((string)_003C_003Ec.oqIFSsZkYlgtxMK2Su90(-1716458555 ^ -1716378497), (string)((object[])_003C_003Ec.zH91f3Zk8FY9UnoYcOW0(criteriaQuery, c, _003C_003Ec.oqIFSsZkYlgtxMK2Su90(-1386448964 ^ -1386473860)))[0]), _003C_003Ec.oqIFSsZkYlgtxMK2Su90(-667465279 ^ -667575329), ((object[])_003C_003Ec.zH91f3Zk8FY9UnoYcOW0(criteriaQuery, c, _003C_003Ec.oqIFSsZkYlgtxMK2Su90(0x74AB4717 ^ 0x74ABF0CF)))[0]));
		ICriteria obj = CreateCriteriaNoPermissions().CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACCB7BD), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-197778752 ^ -197770410), (JoinType)0).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1361015751), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4FD00585 ^ 0x4FD0642D), (JoinType)0, (ICriterion)(object)customSQLCriterion).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12F686A ^ 0x12FD1A2), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-772614310 ^ -772641096), (JoinType)0)
			.CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514204878), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA566F2), (JoinType)0);
		string text = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712510577);
		object[] activeTaskStatuses = TaskBaseExtensions.ActiveTaskStatuses;
		ICriteria val = obj.Add((ICriterion)(object)Restrictions.In(text, activeTaskStatuses)).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F534A5C ^ 0x5F53F058), (object)false)).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.GroupProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712519679)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351396366)).Add((IProjection)(object)Projections.GroupProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1716629332 ^ -1716635366)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-683713632 ^ -683729444))
			.Add((IProjection)(object)Projections.Count(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-25709590 ^ -25692820)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386471672)) })
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ActivityInfoHeader)));
		if (instanceFilter != null)
		{
			val.Add((ICriterion)(object)Subqueries.PropertyIn(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -452103015), instanceFilter));
		}
		return val.List<ActivityInfoHeader>().ToList();
	}

	public List<ActivityInfo> GetTasksCountByActivities(long headerId, long? filterId)
	{
		DetachedCriteria detachedCriteriaByInstanceFilter = GetDetachedCriteriaByInstanceFilter(filterId);
		ICriteria obj = CreateCriteriaNoPermissions().CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-949717965 ^ -949740023), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-45832783 ^ -45824985), (JoinType)0).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4940763B ^ 0x4940C1E3), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-360662087 ^ -360654319), (JoinType)0).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-642713667 ^ -642757003), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1600060848 ^ -1600013390), (JoinType)0)
			.CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1776305410 ^ -1776352494), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-720457373 ^ -720447395), (JoinType)0);
		string text = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F800F5B ^ 0x5F80499B);
		object[] activeTaskStatuses = TaskBaseExtensions.ActiveTaskStatuses;
		ICriteria val = obj.Add((ICriterion)(object)Restrictions.In(text, activeTaskStatuses)).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x69063C81 ^ 0x69068685), (object)false)).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x101D10F ^ 0x101B841), (object)headerId))
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.GroupProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2122743969 ^ -2122770711)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x37F755F5 ^ 0x37F71389)).Add((IProjection)(object)Projections.Count(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x213F6477 ^ 0x213F22F1)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACCB533)) })
			.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(ActivityInfo)));
		if (detachedCriteriaByInstanceFilter != null)
		{
			val.Add((ICriterion)(object)Subqueries.PropertyIn(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x46EA3D1 ^ 0x46EC211), detachedCriteriaByInstanceFilter));
		}
		return val.List<ActivityInfo>().ToList();
	}

	public List<ActivityInfo> GetTasksCountByActivities(long headerId)
	{
		return GetTasksCountByActivities(headerId, null);
	}

	public List<EleWise.ELMA.Workflow.Models.ExecutorInfo> GetTasksCountByExecuters(long headerId, long? filterId)
	{
		DetachedCriteria detachedCriteriaByInstanceFilter = GetDetachedCriteriaByInstanceFilter(filterId);
		return GetTasksCountByExecutors(headerId, detachedCriteriaByInstanceFilter);
	}

	public List<EleWise.ELMA.Workflow.Models.ExecutorInfo> GetTasksCountByExecuters(long headerId, IWorkflowInstanceFilter filter)
	{
		DetachedCriteria detachedCriteriaByInstanceFilter = GetDetachedCriteriaByInstanceFilter(filter);
		return GetTasksCountByExecutors(headerId, detachedCriteriaByInstanceFilter);
	}

	private List<EleWise.ELMA.Workflow.Models.ExecutorInfo> GetTasksCountByExecutors(long headerId, DetachedCriteria instanceFilter)
	{
		ICriteria obj = CreateCriteriaNoPermissions().CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498834435), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-495296780 ^ -495304862), (JoinType)0).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x548AAC18), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393907814), (JoinType)0).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1393899982 ^ -1393917958), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105863102 ^ -105901664), (JoinType)0)
			.CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6C7F14 ^ 0x6CC6F8), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1361030433), (JoinType)0);
		string text = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2077784392 ^ -2077769608);
		object[] activeTaskStatuses = TaskBaseExtensions.ActiveTaskStatuses;
		ICriteria val = obj.Add((ICriterion)(object)Restrictions.In(text, activeTaskStatuses)).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF64BF6), (object)false)).Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5DB28AD2 ^ 0x5DB2E39C), (object)headerId))
			.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.GroupProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x614CF569 ^ 0x614C9F4F)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4940763B ^ 0x49401C1D)).Add((IProjection)(object)Projections.Count(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1001967776 ^ -1001952794)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1AF6F1F2 ^ 0x1AF69946)) });
		if (instanceFilter != null)
		{
			val.Add((ICriterion)(object)Subqueries.PropertyIn(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-148495695 ^ -148487311), instanceFilter));
		}
		return val.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(EleWise.ELMA.Workflow.Models.ExecutorInfo))).List<EleWise.ELMA.Workflow.Models.ExecutorInfo>().ToList();
	}

	public List<EleWise.ELMA.Workflow.Models.ExecutorInfo> GetTasksCountByExecuters(long headerId)
	{
		return GetTasksCountByExecutors(headerId, null);
	}

	internal static List<Guid> GetActivityUidsForFilter(List<Guid> activityUids, long? processHeaderId, Guid? swimlaneUid)
	{
		_003C_003Ec__DisplayClass48_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass48_0();
		CS_0024_003C_003E8__locals0.swimlaneUid = swimlaneUid;
		activityUids = activityUids?.Where((Guid uid) => _003C_003Ec.jAUFemZkJgAQth1kDMTL(uid, Guid.Empty)).ToList();
		if (CS_0024_003C_003E8__locals0.swimlaneUid.HasValue && processHeaderId.HasValue)
		{
			IWorkflowProcess published = EntityManager<IProcessHeader>.Instance.Load(processHeaderId.Value).Published;
			if (published != null)
			{
				if (activityUids == null)
				{
					activityUids = new List<Guid>();
				}
				activityUids.AddRange(from e in published.Diagram.Elements.OfType<BPMNFlowElement>()
					where _003C_003Ec__DisplayClass48_0.UODrdRZkb9dmTaO1juJy(_003C_003Ec__DisplayClass48_0.DbHCRiZktW9kmhd11DWL(e), CS_0024_003C_003E8__locals0.swimlaneUid.Value)
					select e.Uid);
			}
		}
		return activityUids;
	}

	[Transaction]
	public virtual void SaveSwimlaneExecutor(IWorkflowTaskBase task)
	{
		//Discarded unreachable code: IL_0056, IL_0065
		int num = 1;
		SwimlaneElement swimlaneElement = default(SwimlaneElement);
		BPMNFlowElement bPMNFlowElement = default(BPMNFlowElement);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (swimlaneElement != null)
					{
						O2nAe6Wp90MtiIr02lT(eLi4eIWu7jg16DgRc7x(), zOSeOBWRbooXWyrO8H9(sTxjddWj38icO0SyKo0(task)), swimlaneElement, (UvRX2UW33TlOpjx5m8G(task) && UvRX2UW33TlOpjx5m8G(task)) ? task.ExecutorIsEmulation : (hcVl2UWTYQhO3oipowl(task) ?? SJeawrWQK1qgQmfEpTu(task)));
						num2 = 3;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
						{
							num2 = 7;
						}
						break;
					}
					goto end_IL_0012;
				case 3:
					if (bPMNFlowElement != null)
					{
						num2 = 5;
						break;
					}
					return;
				case 7:
					return;
				case 2:
					return;
				case 5:
					swimlaneElement = (SwimlaneElement)J4S1UuWqTRx9e36Fs9E(bPMNFlowElement, ((IWorkflowProcess)sRK36mW6mJX5RpnVBwj(zOSeOBWRbooXWyrO8H9(sTxjddWj38icO0SyKo0(task)))).Diagram);
					num2 = 6;
					break;
				case 1:
					TR6lV9W97yxRpiepfqy(task, fO5GdO9zG9pghbe23W7(0xF400DF8 ^ 0xF404072));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
					{
						num2 = 0;
					}
					break;
				default:
					bPMNFlowElement = (BPMNFlowElement)AF27GRWWtHXwDRYdp84(task);
					num2 = 3;
					break;
				case 4:
					return;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	protected bool? OnPreCanStartReAssign(ITaskBase task, EleWise.ELMA.Security.Models.IUser userToStart, ref bool cancel)
	{
		_003C_003Ec__DisplayClass50_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass50_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.taskBase = task as IWorkflowTaskBase;
		if (CS_0024_003C_003E8__locals0.taskBase == null || CS_0024_003C_003E8__locals0.taskBase.WorkflowBookmark == null || CS_0024_003C_003E8__locals0.taskBase.WorkflowBookmark.Instance == null)
		{
			return null;
		}
		cancel = true;
		if (userToStart == null || task.IsNew() || !task.IsActive())
		{
			return false;
		}
		CS_0024_003C_003E8__locals0.element = CS_0024_003C_003E8__locals0.taskBase.WorkflowBookmark.Instance.Process.Diagram.Elements.FirstOrDefault(delegate(Element e)
		{
			int num3 = 2;
			int num4 = num3;
			Guid? elementUid = default(Guid?);
			Guid guid = default(Guid);
			while (true)
			{
				switch (num4)
				{
				case 1:
					elementUid = ((IWorkflowBookmark)_003C_003Ec__DisplayClass50_0.PckuGNZkXxjoG25204p5(CS_0024_003C_003E8__locals0.taskBase)).ElementUid;
					num4 = 3;
					break;
				default:
					return false;
				case 2:
					guid = _003C_003Ec__DisplayClass50_0.SiXLVYZkPcEyaoPKyb3D(e);
					num4 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num4 = 1;
					}
					break;
				case 3:
					if (elementUid.HasValue)
					{
						return _003C_003Ec__DisplayClass50_0.iknd3OZkd5G0dTvU4su1(guid, elementUid.GetValueOrDefault());
					}
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
					{
						num4 = 0;
					}
					break;
				}
			}
		}) as BPMNFlowElement;
		if (CS_0024_003C_003E8__locals0.element == null)
		{
			return false;
		}
		CS_0024_003C_003E8__locals0.hasReassignProcessTaskPermission = false;
		SecurityService.RunWithUsualPrivilegies(delegate
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
					CS_0024_003C_003E8__locals0.hasReassignProcessTaskPermission = _003C_003Ec__DisplayClass50_0.FDfOYYZkD2rGEGQVLMBA(CS_0024_003C_003E8__locals0._003C_003E4__this.SecurityService, WorkflowPermissionProvider.ReassignProcessTask, _003C_003Ec__DisplayClass50_0.ujZoOUZkuMOo8P0AOe06(CS_0024_003C_003E8__locals0.taskBase.WorkflowBookmark), false);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		});
		if (!DenyReassignExecutorInElementExtentions.Any((IDenyReassignExecutorInElementExtentions p) => _003C_003Ec__DisplayClass50_0.pDOqptZknJMxpC7Bh0nP(p, CS_0024_003C_003E8__locals0.element)))
		{
			if (!CS_0024_003C_003E8__locals0.hasReassignProcessTaskPermission && !TaskBaseManager<ITaskBase>.IsExecutor(task, userToStart, checkSubordinateUser: true))
			{
				return null;
			}
			return true;
		}
		if (!CS_0024_003C_003E8__locals0.hasReassignProcessTaskPermission)
		{
			return null;
		}
		return true;
	}

	public virtual bool IsAvailableReAssign(ITaskBase task)
	{
		//Discarded unreachable code: IL_0114, IL_0123
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass51_0 _003C_003Ec__DisplayClass51_ = default(_003C_003Ec__DisplayClass51_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (sTxjddWj38icO0SyKo0(_003C_003Ec__DisplayClass51_.taskBase) == null)
				{
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 == 0)
					{
						num2 = 5;
					}
				}
				else
				{
					_003C_003Ec__DisplayClass51_.instance = (IWorkflowInstance)zOSeOBWRbooXWyrO8H9(_003C_003Ec__DisplayClass51_.taskBase.WorkflowBookmark);
					num2 = 10;
				}
				break;
			case 10:
				if (_003C_003Ec__DisplayClass51_.instance == null)
				{
					num2 = 11;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
					{
						num2 = 12;
					}
					break;
				}
				_003C_003Ec__DisplayClass51_.element = ((IEnumerable<Element>)SJKVePWCK2T1cLAJya1(((IWorkflowProcess)sRK36mW6mJX5RpnVBwj(_003C_003Ec__DisplayClass51_.instance)).Diagram)).FirstOrDefault(_003C_003Ec__DisplayClass51_._003CIsAvailableReAssign_003Eb__0) as BPMNFlowElement;
				num2 = 11;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
				{
					num2 = 8;
				}
				break;
			case 8:
				return true;
			default:
				_003C_003Ec__DisplayClass51_.taskBase = task as IWorkflowTaskBase;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0262725a60774e44a84fd2b93b79ee8a != 0)
				{
					num2 = 7;
				}
				break;
			case 3:
				_003C_003Ec__DisplayClass51_ = new _003C_003Ec__DisplayClass51_0();
				num2 = 2;
				break;
			case 2:
				_003C_003Ec__DisplayClass51_._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
			case 9:
				return true;
			case 6:
				return !DenyReassignExecutorInElementExtentions.Any(_003C_003Ec__DisplayClass51_._003CIsAvailableReAssign_003Eb__2) | _003C_003Ec__DisplayClass51_.hasReassignProcessTaskPermission;
			case 12:
				return true;
			case 4:
				G4H3wdWMHNTlZn8JYmW(SecurityService, new Action(_003C_003Ec__DisplayClass51_._003CIsAvailableReAssign_003Eb__1));
				num2 = 6;
				break;
			case 7:
				if (_003C_003Ec__DisplayClass51_.taskBase == null)
				{
					num2 = 9;
					break;
				}
				goto case 1;
			case 11:
				if (_003C_003Ec__DisplayClass51_.element != null)
				{
					_003C_003Ec__DisplayClass51_.hasReassignProcessTaskPermission = false;
					num2 = 4;
				}
				else
				{
					num2 = 8;
				}
				break;
			}
		}
	}

	internal ICriteria GetInstanceTasksCriteria(long workflowInstanceId)
	{
		int num = 1;
		int num2 = num;
		IWorkflowTaskBaseFilter workflowTaskBaseFilter = default(IWorkflowTaskBaseFilter);
		ICriteria val = default(ICriteria);
		while (true)
		{
			switch (num2)
			{
			default:
				workflowTaskBaseFilter = InterfaceActivator.Create<IWorkflowTaskBaseFilter>();
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b4c7ccafb1de4af2aa93fb9f2842508b != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				SetupFilter(val, workflowTaskBaseFilter);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				workflowTaskBaseFilter.DisableSecurity = true;
				num2 = 4;
				break;
			case 1:
				val = (ICriteria)qqT5pEWZ5B6S9p7nwfC(this);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return val;
			case 2:
				workflowTaskBaseFilter.InstanceId = workflowInstanceId;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public IEnumerable<IWorkflowTaskBase> GetAllTasksWithSubtasks(IWorkflowTaskBaseFilter filter, FetchOptions fetchOptions)
	{
		string childTaskAlias = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1361036319 ^ -1361018425);
		return GetCriteriaForAllTasksWithSubtasks(filter, fetchOptions, childTaskAlias).SetResultTransformer((IResultTransformer)(object)new WorkflowTaskWithSubtasksTransformer()).List<IWorkflowTaskBase>();
	}

	public int CountOfAllTasksWithSubtasks(IWorkflowTaskBaseFilter filter)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return ((ICriteria)Woqb4dWg57nHwYTZsE1(GetCriteriaForAllTasksWithSubtasks(filter, null, text), new IProjection[1] { (IProjection)Qc5LFpWUyUl9tnAX9o4(Qc5LFpWUyUl9tnAX9o4(PwENPcWkN3Yrrum7qOI(), Projections.CountDistinct((string)fO5GdO9zG9pghbe23W7(-683713632 ^ -683679332)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-801808857 ^ -801774487)), JqlkP6WAPUOk5yy2I3V(S1ljpbWVC2f6bVZetRv(text, fO5GdO9zG9pghbe23W7(-1514166050 ^ -1514157784))), fO5GdO9zG9pghbe23W7(-360662087 ^ -360709679)) })).UniqueResult<object[]>().Cast<int>().Sum();
			case 1:
				text = (string)fO5GdO9zG9pghbe23W7(0x12F686A ^ 0x12FD24C);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private ICriteria GetCriteriaForAllTasksWithSubtasks(IWorkflowTaskBaseFilter filter, FetchOptions fetchOptions, string childTaskAlias = "childTask")
	{
		int num = 2;
		int num2 = num;
		ICriteria val = default(ICriteria);
		while (true)
		{
			switch (num2)
			{
			case 1:
				SetupFilter(val, filter);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				val = (ICriteria)Be3vDhWGjvJpo4vuYuH(this, fetchOptions, InterfaceActivator.TypeOf<IWorkflowTaskBase>(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1514166050 ^ -1514204582));
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return (ICriteria)GZIFxyW2BpYix8NLc9s(val, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x246EEF98 ^ 0x246E5508), childTaskAlias, (JoinType)1, VCRxLaW7yM9Gn6Y5Xmy(S1ljpbWVC2f6bVZetRv(childTaskAlias, fO5GdO9zG9pghbe23W7(-1514166050 ^ -1514204554)), fO5GdO9zG9pghbe23W7(0x6CC04061 ^ 0x6CC0FA5D)));
			}
		}
	}

	protected virtual ICriteria CreateCriteriaNoPermissions()
	{
		return ((ISession)alJdW2947XdNjpnwu2X(this)).CreateCriteria(oxhqBlWo71GCEBnmDIl(this));
	}

	protected override void OnSetupFilter(ICriteria criteria, IEntityFilter filter)
	{
		//Discarded unreachable code: IL_01eb, IL_01f5, IL_0204, IL_0284, IL_0293, IL_03d9, IL_0415, IL_0445, IL_0454, IL_04f4, IL_0503, IL_0608, IL_0617, IL_0693, IL_0715, IL_073e, IL_074d, IL_082c, IL_086c, IL_09ef, IL_0ab8, IL_0c11, IL_0c20, IL_0c75, IL_0c84, IL_0d86, IL_0d90, IL_0d9f, IL_0daf
		int num = 39;
		IWorkflowTaskBaseFilter workflowTaskBaseFilter = default(IWorkflowTaskBaseFilter);
		long? processHeaderId = default(long?);
		_003C_003Ec__DisplayClass57_2 _003C_003Ec__DisplayClass57_2 = default(_003C_003Ec__DisplayClass57_2);
		Guid? permissionId = default(Guid?);
		List<Guid> activityUidsForFilter = default(List<Guid>);
		Action<bool> action = default(Action<bool>);
		IWorkflowInstanceFilter workflowInstanceFilter = default(IWorkflowInstanceFilter);
		string alias2 = default(string);
		_003C_003Ec__DisplayClass57_1 _003C_003Ec__DisplayClass57_ = default(_003C_003Ec__DisplayClass57_1);
		DetachedCriteria val = default(DetachedCriteria);
		_003C_003Ec__DisplayClass57_0 _003C_003Ec__DisplayClass57_4 = default(_003C_003Ec__DisplayClass57_0);
		string alias5 = default(string);
		string alias6 = default(string);
		Guid guid = default(Guid);
		ICriteria val2 = default(ICriteria);
		string alias3 = default(string);
		DetachedCriteria val3 = default(DetachedCriteria);
		List<ProcessHeaderInfo> source = default(List<ProcessHeaderInfo>);
		string alias4 = default(string);
		EleWise.ELMA.Security.Models.IUser currentUser = default(EleWise.ELMA.Security.Models.IUser);
		bool flag2 = default(bool);
		string alias = default(string);
		bool flag = default(bool);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num3;
				switch (num2)
				{
				case 33:
					if (workflowTaskBaseFilter == null)
					{
						num2 = 19;
						continue;
					}
					goto case 81;
				case 7:
					processHeaderId = workflowTaskBaseFilter.ProcessHeaderId;
					num2 = 30;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
					{
						num2 = 40;
					}
					continue;
				case 29:
				case 79:
					_003C_003Ec__DisplayClass57_2 = new _003C_003Ec__DisplayClass57_2();
					num2 = 92;
					continue;
				case 28:
					if (permissionId.HasValue)
					{
						num2 = 89;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_db8eb3e90ad546d4b05544ab6326a49f != 0)
						{
							num2 = 8;
						}
						continue;
					}
					return;
				case 50:
					if (i0OuFoWrkSm19LblRvX(activityUidsForFilter) > 0)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
						{
							num2 = 70;
						}
						continue;
					}
					goto case 34;
				case 69:
					action(obj: true);
					num2 = 68;
					continue;
				case 10:
					if (workflowInstanceFilter != null)
					{
						num2 = 66;
						continue;
					}
					goto case 83;
				case 24:
					return;
				case 23:
					alias2 = (string)fO5GdO9zG9pghbe23W7(0x74AB4717 ^ 0x74AB2E29);
					num2 = 63;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
					{
						num2 = 65;
					}
					continue;
				case 51:
					IAL2r5WsRPnswinGCJB(_003C_003Ec__DisplayClass57_.CS_0024_003C_003E8__locals1.criteria, F7beMVWhUBAH7w7SgHU(val));
					num2 = 47;
					continue;
				case 40:
					if (!processHeaderId.HasValue)
					{
						num2 = 12;
						continue;
					}
					goto case 61;
				case 38:
					_003C_003Ec__DisplayClass57_4.criteria = criteria;
					num2 = 4;
					continue;
				case 12:
				case 58:
				case 60:
					if (workflowTaskBaseFilter.ProcessHeaderIdList == null)
					{
						num2 = 84;
						continue;
					}
					goto case 6;
				case 37:
				{
					ICriteria orCreateAlias = _003C_003Ec__DisplayClass57_.CS_0024_003C_003E8__locals1.criteria.GetOrCreateAlias((string)ArRd7cWFtv4gAonitVX(fO5GdO9zG9pghbe23W7(0x6871CA ^ 0x68CACA), _003C_003Ec__DisplayClass57_.instAlias), (JoinType)0, ref alias5).GetOrCreateAlias((string)ArRd7cWFtv4gAonitVX(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-39189604 ^ -39143290), alias5), (JoinType)0, ref alias6);
					string text = string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-684210684 ^ -684216606), alias6);
					processHeaderId = workflowTaskBaseFilter.ProcessHeaderId;
					IAL2r5WsRPnswinGCJB(orCreateAlias, Vg6fafWcr4rFO21uUcA(text, processHeaderId.Value));
					num2 = 39;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
					{
						num2 = 58;
					}
					continue;
				}
				case 85:
					IAL2r5WsRPnswinGCJB(_003C_003Ec__DisplayClass57_.CS_0024_003C_003E8__locals1.criteria, NDiiaRWwDf2QOCF8wN9(fO5GdO9zG9pghbe23W7(0x5F534A5C ^ 0x5F532052)));
					num2 = 72;
					continue;
				case 49:
					guid = sFsC2OWenSYNmKNIVd4(WorkflowPermissionProvider.ProcessMonitor);
					num2 = 45;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c != 0)
					{
						num2 = 37;
					}
					continue;
				case 15:
					if (kQl3QcWPDqXy8Q0cpxd(workflowInstanceFilter) != null)
					{
						num = 29;
						break;
					}
					goto case 59;
				case 81:
					_003C_003Ec__DisplayClass57_ = new _003C_003Ec__DisplayClass57_1();
					num2 = 53;
					continue;
				case 96:
					val2 = ((WorkflowInstanceManager)eLi4eIWu7jg16DgRc7x()).CreateContextFilterCriteria(workflowInstanceFilter, FetchOptions.All);
					num2 = 18;
					continue;
				case 34:
					permissionId = workflowTaskBaseFilter.PermissionId;
					num2 = 17;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
					{
						num2 = 28;
					}
					continue;
				case 76:
					if (kQl3QcWPDqXy8Q0cpxd(workflowInstanceFilter) == null)
					{
						num2 = 63;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 93;
				case 77:
					return;
				case 68:
					alias5 = (string)fO5GdO9zG9pghbe23W7(0x37E97159 ^ 0x37E9C8BB);
					num2 = 16;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b != 0)
					{
						num2 = 30;
					}
					continue;
				case 47:
					return;
				default:
					permissionId = workflowTaskBaseFilter.PermissionId;
					num2 = 49;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 == 0)
					{
						num2 = 39;
					}
					continue;
				case 72:
					return;
				case 53:
					_003C_003Ec__DisplayClass57_.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass57_4;
					num2 = 75;
					continue;
				case 66:
					action(obj: false);
					num2 = 76;
					continue;
				case 62:
					if (permissionId.HasValue)
					{
						num2 = 16;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_448e6815cb30438893079dcbb906fd65 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 44;
				case 27:
					alias3 = (string)fO5GdO9zG9pghbe23W7(-39189604 ^ -39142786);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
					{
						num2 = 57;
					}
					continue;
				case 19:
					return;
				case 73:
					action(obj: false);
					num2 = 32;
					continue;
				case 63:
				case 67:
					val3 = (DetachedCriteria)oCVxuXWfmIqNDuDWJeh(((AbstractNHEntityManager<IWorkflowInstance, long>)eLi4eIWu7jg16DgRc7x()).CreateDetachedCriteria((FetchOptions)MsiYbOWXoqjIwWAkFZP(), InterfaceActivator.TypeOf<IWorkflowInstance>(), (string)null, (IEntityFilter)workflowTaskBaseFilter.InstanceFilter), tLqxGXWLSQaylQb43HB(fO5GdO9zG9pghbe23W7(0x614CF569 ^ 0x614CB3EF)));
					num2 = 91;
					continue;
				case 83:
					if (DE9oAgWI77L4OrAKbvG(workflowTaskBaseFilter) > 0)
					{
						num2 = 73;
						continue;
					}
					goto case 7;
				case 48:
				case 91:
					IAL2r5WsRPnswinGCJB(_003C_003Ec__DisplayClass57_.CS_0024_003C_003E8__locals1.criteria, pAV4dDWiJVZdysXHJbH(ArRd7cWFtv4gAonitVX(fO5GdO9zG9pghbe23W7(0x1C663DA1 ^ 0x1C668763), _003C_003Ec__DisplayClass57_.wbAlaias), val3));
					num2 = 94;
					continue;
				case 17:
					source = ProcessHeaderManager.Instance.GetMonitorProcessesAllInfo().ToList();
					num2 = 55;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 == 0)
					{
						num2 = 52;
					}
					continue;
				case 11:
					if (processHeaderId.HasValue)
					{
						num2 = 79;
						continue;
					}
					goto IL_0565;
				case 57:
					alias4 = (string)fO5GdO9zG9pghbe23W7(-22348816 ^ -22375730);
					num2 = 20;
					continue;
				case 90:
					action(obj: true);
					num = 27;
					break;
				case 59:
					processHeaderId = workflowInstanceFilter.ProcessHeaderId;
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be != 0)
					{
						num2 = 11;
					}
					continue;
				case 45:
					if (permissionId.HasValue)
					{
						num2 = 62;
						continue;
					}
					goto case 54;
				case 26:
					currentUser = authenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
					num2 = 36;
					continue;
				case 46:
					flag2 = permissionId.HasValue;
					num2 = 32;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
					{
						num2 = 83;
					}
					continue;
				case 93:
					processHeaderId = workflowTaskBaseFilter.ProcessHeaderId;
					num = 2;
					break;
				case 82:
					flag2 = false;
					num2 = 10;
					continue;
				case 75:
					_003C_003Ec__DisplayClass57_.wbAlaias = (string)fO5GdO9zG9pghbe23W7(-45832783 ^ -45824985);
					num2 = 52;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af != 0)
					{
						num2 = 16;
					}
					continue;
				case 14:
				case 22:
				case 84:
					activityUidsForFilter = GetActivityUidsForFilter(workflowTaskBaseFilter.ActivityUids, workflowTaskBaseFilter.ProcessHeaderId, workflowTaskBaseFilter.SwimlaneUid);
					num2 = 71;
					continue;
				case 3:
					action = _003C_003Ec__DisplayClass57_._003COnSetupFilter_003Eb__0;
					num2 = 8;
					continue;
				case 36:
					val = (DetachedCriteria)oCVxuXWfmIqNDuDWJeh(((DetachedCriteria)U74sODWS7wANeTrCZUx(G7csIXWxK9dL3VCAZvR(InterfaceActivator.TypeOf<IWorkflowInstanceMember>(), fO5GdO9zG9pghbe23W7(0x56F860D7 ^ 0x56F80903)), Vg6fafWcr4rFO21uUcA(fO5GdO9zG9pghbe23W7(0x37E97159 ^ 0x37E91887), currentUser))).Add((ICriterion)(object)Restrictions.EqProperty(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-452127399 ^ -452100949), (string)ArRd7cWFtv4gAonitVX(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C663DA1 ^ 0x1C668763), _003C_003Ec__DisplayClass57_.wbAlaias))), nJ2C7wW1KkEPcsWYGL0(PwENPcWkN3Yrrum7qOI(), DQw42TW5qKPw97LqEZC()));
					num2 = 51;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
					{
						num2 = 20;
					}
					continue;
				case 30:
					alias6 = (string)fO5GdO9zG9pghbe23W7(0x4FD00585 ^ 0x4FD06CBB);
					num2 = 37;
					continue;
				case 18:
					((AbstractNHEntityManager<IWorkflowInstance, long>)eLi4eIWu7jg16DgRc7x()).SetupFilter(val2, (IEntityFilter)workflowInstanceFilter);
					num2 = 40;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
					{
						num2 = 42;
					}
					continue;
				case 88:
					alias = (string)fO5GdO9zG9pghbe23W7(-1574607501 ^ -1574630293);
					num = 23;
					break;
				case 89:
					permissionId = workflowTaskBaseFilter.PermissionId;
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 == 0)
					{
						num2 = 64;
					}
					continue;
				case 13:
				case 43:
					action(obj: false);
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
					{
						num2 = 26;
					}
					continue;
				case 70:
					action(obj: false);
					num2 = 41;
					continue;
				case 87:
					if (!source.All(_003C_003Ec__DisplayClass57_2._003COnSetupFilter_003Eb__1))
					{
						num2 = 56;
						continue;
					}
					goto case 85;
				case 42:
					val3 = (DetachedCriteria)wIw9t3WnIvjl0vLxmq8(val2);
					num2 = 74;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
					{
						num2 = 17;
					}
					continue;
				case 44:
				case 78:
					if (LXqXeSWErUEuMVgv1CR(SecurityService, WorkflowPermissionProvider.FullMonitorAccessPermission))
					{
						num2 = 24;
						continue;
					}
					goto case 17;
				case 61:
					if (flag)
					{
						num2 = 31;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
						{
							num2 = 60;
						}
						continue;
					}
					goto case 69;
				case 1:
					action(obj: true);
					num2 = 88;
					continue;
				case 6:
					if (!workflowTaskBaseFilter.ProcessHeaderIdList.Any())
					{
						num2 = 12;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 90;
				case 94:
					permissionId = workflowInstanceFilter.PermissionId;
					num2 = 46;
					continue;
				case 52:
					_003C_003Ec__DisplayClass57_.instAlias = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xDF4D1F8 ^ 0xDF4B050);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num2 = 3;
					}
					continue;
				case 74:
					oCVxuXWfmIqNDuDWJeh(val3, tLqxGXWLSQaylQb43HB(eCNH57WHuwEVQtF0Dkw(eLi4eIWu7jg16DgRc7x(), fO5GdO9zG9pghbe23W7(0x3C1FFB55 ^ 0x3C1FBDD3))));
					num2 = 48;
					continue;
				case 8:
					workflowInstanceFilter = workflowTaskBaseFilter.InstanceFilter as IWorkflowInstanceFilter;
					num2 = 21;
					continue;
				case 55:
					if (workflowInstanceFilter != null)
					{
						num2 = 15;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto IL_0565;
				case 32:
					_003C_003Ec__DisplayClass57_.CS_0024_003C_003E8__locals1.criteria.Add((ICriterion)Vg6fafWcr4rFO21uUcA(ArRd7cWFtv4gAonitVX(fO5GdO9zG9pghbe23W7(0x614274E3 ^ 0x6142CE3D), _003C_003Ec__DisplayClass57_.wbAlaias), DE9oAgWI77L4OrAKbvG(workflowTaskBaseFilter)));
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
					{
						num2 = 7;
					}
					continue;
				case 41:
					IAL2r5WsRPnswinGCJB(_003C_003Ec__DisplayClass57_.CS_0024_003C_003E8__locals1.criteria, FlELP1WaOPR0eEc7K6q(ArRd7cWFtv4gAonitVX(fO5GdO9zG9pghbe23W7(-11799394 ^ -11841620), _003C_003Ec__DisplayClass57_.wbAlaias), activityUidsForFilter));
					num2 = 34;
					continue;
				case 5:
					return;
				case 4:
					workflowTaskBaseFilter = filter as IWorkflowTaskBaseFilter;
					num2 = 33;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
					{
						num2 = 10;
					}
					continue;
				case 64:
					guid = sFsC2OWenSYNmKNIVd4(WorkflowPermissionProvider.MyProcessesPermission);
					num2 = 80;
					continue;
				case 9:
					return;
				case 56:
					return;
				case 21:
					flag = false;
					num2 = 82;
					continue;
				case 39:
					_003C_003Ec__DisplayClass57_4 = new _003C_003Ec__DisplayClass57_0();
					num = 38;
					break;
				case 2:
					if (!processHeaderId.HasValue)
					{
						num2 = 58;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
						{
							num2 = 86;
						}
						continue;
					}
					goto case 31;
				case 71:
					if (activityUidsForFilter != null)
					{
						num2 = 50;
						continue;
					}
					goto case 34;
				case 92:
					action(obj: false);
					num2 = 95;
					continue;
				case 80:
					if (permissionId.HasValue)
					{
						num2 = 25;
						continue;
					}
					goto case 35;
				case 25:
					if (!permissionId.HasValue)
					{
						num = 13;
						break;
					}
					if (XhJhi4WNUbcC176V8SS(permissionId.GetValueOrDefault(), guid))
					{
						goto case 13;
					}
					goto case 35;
				case 31:
				{
					long id = ((IEntity<long>)kQl3QcWPDqXy8Q0cpxd(workflowInstanceFilter)).Id;
					processHeaderId = workflowTaskBaseFilter.ProcessHeaderId;
					num3 = ((id == processHeaderId.Value) ? 1 : 0);
					goto IL_0e38;
				}
				case 20:
					_003C_003Ec__DisplayClass57_.CS_0024_003C_003E8__locals1.criteria.GetOrCreateAlias((string)ArRd7cWFtv4gAonitVX(fO5GdO9zG9pghbe23W7(0x6F6D7B44 ^ 0x6F6DC044), _003C_003Ec__DisplayClass57_.instAlias), (JoinType)1, ref alias3).GetOrCreateAlias((string)ArRd7cWFtv4gAonitVX(fO5GdO9zG9pghbe23W7(0x7381F16B ^ 0x73814A71), alias3), (JoinType)1, ref alias4).Add((ICriterion)FlELP1WaOPR0eEc7K6q(string.Format(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1498811449 ^ -1498834143), alias4), workflowTaskBaseFilter.ProcessHeaderIdList));
					num2 = 14;
					continue;
				case 86:
					num3 = 0;
					goto IL_0e38;
				case 35:
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					if (permissionId.GetValueOrDefault() == guid)
					{
						goto case 44;
					}
					goto case 54;
				case 54:
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2f119e188994b55be2499c193b880fb == 0)
					{
						num2 = 2;
					}
					continue;
				case 95:
				{
					_003C_003Ec__DisplayClass57_2 _003C_003Ec__DisplayClass57_3 = _003C_003Ec__DisplayClass57_2;
					long headerId;
					if (kQl3QcWPDqXy8Q0cpxd(workflowInstanceFilter) == null)
					{
						processHeaderId = workflowInstanceFilter.ProcessHeaderId;
						headerId = processHeaderId.Value;
					}
					else
					{
						headerId = ((IEntity<long>)kQl3QcWPDqXy8Q0cpxd(workflowInstanceFilter)).Id;
					}
					_003C_003Ec__DisplayClass57_3.headerId = headerId;
					num2 = 87;
					continue;
				}
				case 65:
					{
						IAL2r5WsRPnswinGCJB(_003C_003Ec__DisplayClass57_.CS_0024_003C_003E8__locals1.criteria.GetOrCreateAlias((string)ArRd7cWFtv4gAonitVX(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF40B6F8), _003C_003Ec__DisplayClass57_.instAlias), (JoinType)0, ref alias).GetOrCreateAlias((string)ArRd7cWFtv4gAonitVX(fO5GdO9zG9pghbe23W7(-398691253 ^ -398667951), alias), (JoinType)0, ref alias2), FlELP1WaOPR0eEc7K6q(ArRd7cWFtv4gAonitVX(fO5GdO9zG9pghbe23W7(-949717965 ^ -949740331), alias2), source.Select((ProcessHeaderInfo h) => _003C_003Ec.jnmQ1mZklLuFHAakJRlO(h)).ToArray()));
						num2 = 9;
						continue;
					}
					IL_0e38:
					flag = (byte)num3 != 0;
					num = 96;
					break;
					IL_0565:
					if (flag2)
					{
						num2 = 77;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 == 0)
						{
							num2 = 70;
						}
						continue;
					}
					goto case 1;
				}
				break;
			}
		}
	}

	protected virtual ITaskBase OnPreInternalReAssign(IReAssignActionModel reAssignModel, ref bool cancel)
	{
		//Discarded unreachable code: IL_0089, IL_0098, IL_0135
		int num = 6;
		_003C_003Ec__DisplayClass58_0 _003C_003Ec__DisplayClass58_ = default(_003C_003Ec__DisplayClass58_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					if (_003C_003Ec__DisplayClass58_.task == null)
					{
						num = 9;
						break;
					}
					goto case 10;
				case 11:
					_003C_003Ec__DisplayClass58_.task.Save();
					num2 = 13;
					continue;
				case 1:
					if (sTxjddWj38icO0SyKo0(_003C_003Ec__DisplayClass58_.task) == null)
					{
						num2 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 != 0)
						{
							num2 = 8;
						}
						continue;
					}
					goto case 7;
				case 2:
					cancel = true;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					if (base.Manager.CanReAssign(_003C_003Ec__DisplayClass58_.reAssignModel))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 8;
				case 5:
					_003C_003Ec__DisplayClass58_.reAssignModel = reAssignModel;
					num2 = 4;
					continue;
				case 12:
					return null;
				case 4:
					_003C_003Ec__DisplayClass58_.task = LoadOrNull(kXuFX1W4cpHbPEevygL(_003C_003Ec__DisplayClass58_.reAssignModel));
					num = 3;
					break;
				case 7:
					if (GetTasks((IWorkflowBookmark)sTxjddWj38icO0SyKo0(_003C_003Ec__DisplayClass58_.task)).Any(_003C_003Ec__DisplayClass58_._003COnPreInternalReAssign_003Eb__0))
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 8;
				default:
					Ff9dJmjKs2tTG6Js7y6(_003C_003Ec__DisplayClass58_.task, zmVOFtWzcvSsuakbHQ6());
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6782172e84504a7baf3163b8f6b2a916 == 0)
					{
						num2 = 11;
					}
					continue;
				case 13:
					return _003C_003Ec__DisplayClass58_.task;
				case 8:
				case 9:
					cancel = false;
					num2 = 12;
					continue;
				case 6:
					_003C_003Ec__DisplayClass58_ = new _003C_003Ec__DisplayClass58_0();
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	protected virtual bool OnIsAvailableReAssign(ITaskBase task, DateTime startDate, DateTime endDate, EleWise.ELMA.Security.Models.IUser executor, TaskPriority priority, IComment comment, bool result)
	{
		//Discarded unreachable code: IL_008c, IL_009b, IL_00e2
		int num = 9;
		int num2 = num;
		_003C_003Ec__DisplayClass59_0 _003C_003Ec__DisplayClass59_ = default(_003C_003Ec__DisplayClass59_0);
		IWorkflowInstance workflowInstance = default(IWorkflowInstance);
		UserTaskElement userTaskElement = default(UserTaskElement);
		while (true)
		{
			switch (num2)
			{
			case 8:
				if (!result)
				{
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 != 0)
					{
						num2 = 2;
					}
					break;
				}
				_003C_003Ec__DisplayClass59_.taskBase = task as IWorkflowTaskBase;
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 != 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				return SecurityService.HasPermission(WorkflowPermissionProvider.ReassignProcessTask, workflowInstance);
			case 10:
				return true;
			case 4:
				if (_003C_003Ec__DisplayClass59_.taskBase != null)
				{
					num2 = 8;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
					{
						num2 = 12;
					}
					break;
				}
				goto case 5;
			case 9:
				_003C_003Ec__DisplayClass59_ = new _003C_003Ec__DisplayClass59_0();
				num2 = 8;
				break;
			case 3:
				return false;
			case 11:
				return true;
			case 5:
				return true;
			case 6:
				workflowInstance = (IWorkflowInstance)zOSeOBWRbooXWyrO8H9(sTxjddWj38icO0SyKo0(_003C_003Ec__DisplayClass59_.taskBase));
				num2 = 2;
				break;
			case 12:
				if (sTxjddWj38icO0SyKo0(_003C_003Ec__DisplayClass59_.taskBase) != null)
				{
					num2 = 6;
					break;
				}
				goto case 5;
			case 2:
				if (workflowInstance == null)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e9561fecdd4d49678d9f9ea7d295fb1b == 0)
					{
						num2 = 7;
					}
					break;
				}
				userTaskElement = ((IEnumerable<Element>)SJKVePWCK2T1cLAJya1(bOirIJjOn0A3phyZ1Fh(sRK36mW6mJX5RpnVBwj(workflowInstance)))).FirstOrDefault(_003C_003Ec__DisplayClass59_._003COnIsAvailableReAssign_003Eb__0) as UserTaskElement;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (userTaskElement != null)
				{
					if (!mZLCwejZLDxIoFKRrC0(userTaskElement))
					{
						num2 = 10;
						break;
					}
					goto case 1;
				}
				num2 = 11;
				break;
			case 7:
				return true;
			}
		}
	}

	protected virtual void SetupGetActiveTasksCriteria(ICriteria criteria, EleWise.ELMA.Security.Models.IUser executor, bool allowSubInstances, bool startFromRoot, IEnumerable<IWorkflowInstance> instanceList)
	{
		Contract.ArgumentNotNull(instanceList, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1843E01F ^ 0x18438165));
		ICriteria obj = criteria.CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF4067C2), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6F6D7B44 ^ 0x6F6D1AD2)).CreateAlias(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-432000546 ^ -431979002), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x141C968 ^ 0x141A8C0));
		string text = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2057730233 ^ -2057715321);
		object[] activeTaskStatuses = WorkflowTaskBaseExtensions.ActiveTaskStatuses;
		obj.Add((ICriterion)(object)Restrictions.In(text, activeTaskStatuses));
		if (!allowSubInstances)
		{
			criteria.Add((ICriterion)(object)Restrictions.In(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1895853023 ^ -1895881735), (ICollection)instanceList.ToList()));
		}
		else
		{
			ICriterion val = WorkflowInstanceManager.Instance.CreateChildInstancesCriterion(instanceList, startFromRoot, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-43932417 ^ -43924161));
			criteria.Add(val);
		}
		if (executor != null)
		{
			criteria.Add((ICriterion)(object)Restrictions.Eq(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11821384), (object)executor));
		}
	}

	protected virtual IList<IWorkflowTaskBase> FindMyActiveTasks(IWorkflowInstance instance, bool allowSubInstances, bool startFromRoot)
	{
		EleWise.ELMA.Security.Models.IUser currentUser = authenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
		ICriteria val = CreateCriteriaNoPermissions();
		SetupGetActiveTasksCriteria(val, currentUser, allowSubInstances, startFromRoot, new IWorkflowInstance[1] { instance });
		val.AddOrder(Order.Asc(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-947937941 ^ -947921939)));
		return val.List<IWorkflowTaskBase>();
	}

	[PublicApiMember]
	[PublicApiNodeId("WorkflowTaskProcessesApi")]
	public virtual void RenameWorkflowTask(IWorkflowTaskBase task, string name)
	{
		//Discarded unreachable code: IL_0059, IL_008b, IL_009a, IL_0207
		int num = 4;
		int num2 = num;
		IEntityActionHandler serviceNotNull = default(IEntityActionHandler);
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		while (true)
		{
			switch (num2)
			{
			case 12:
				return;
			case 5:
				serviceNotNull.ActionExecuted(entityActionEventArgs);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
				{
					num2 = 6;
				}
				break;
			case 7:
				throw new NullReferenceException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x70EBB9F3 ^ 0x70EB027B));
			case 2:
				if (!(name == ""))
				{
					num2 = 13;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e8980a9fd9d44c20920ffa276900c96f == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 10;
			case 1:
				throw new ArgumentException((string)fO5GdO9zG9pghbe23W7(0x213F6477 ^ 0x213FD857));
			case 3:
				throw new NullReferenceException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74ABFC45));
			default:
				if (entityActionEventArgs == null)
				{
					num2 = 12;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 5;
			case 8:
				entityActionEventArgs = (EntityActionEventArgs)bqTYHejJtVfDN8iJjsV(null, task, egVhlojsmmLhuid29rc());
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				return;
			case 11:
				fWrf5gj8gxoovbBUK6Y(task);
				num2 = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
				{
					num2 = 9;
				}
				break;
			case 10:
				throw new ArgumentException((string)fO5GdO9zG9pghbe23W7(-1361036319 ^ -1361018829));
			case 13:
				if (chDmvijv0kMs88cWAI1(name, 0) != ' ')
				{
					FFDOFZjYT2QQlKKdx3C(task, name);
					num2 = 11;
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				if (task != null)
				{
					if (name != null)
					{
						num2 = 2;
						break;
					}
					goto case 7;
				}
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
				{
					num2 = 2;
				}
				break;
			case 9:
				serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4cc62744d0eb4cd68219b70dcad3e68e == 0)
				{
					num2 = 8;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void SetWorkflowTaskEndDate(IWorkflowTaskBase task, DateTime endDate)
	{
		//Discarded unreachable code: IL_0056, IL_0065
		int num = 8;
		int num2 = num;
		IEntityActionHandler serviceNotNull = default(IEntityActionHandler);
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		while (true)
		{
			switch (num2)
			{
			default:
				serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
				num2 = 2;
				break;
			case 3:
				if (entityActionEventArgs != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 4:
				return;
			case 5:
				fWrf5gj8gxoovbBUK6Y(task);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				entityActionEventArgs = EntityActionEventArgs.TryCreate(null, task, LYfbOtjlT8oEgP0jxCT());
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc == 0)
				{
					num2 = 3;
				}
				break;
			case 8:
				if (task != null)
				{
					num2 = 7;
					break;
				}
				goto case 6;
			case 1:
				serviceNotNull.ActionExecuted(entityActionEventArgs);
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				throw new NullReferenceException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712492721 ^ -1712466915));
			case 7:
				task.EndDate = endDate;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void SetWorkflowTaskEndDate(IWorkflowTaskBase task, DateTime startDate, DateTime endDate)
	{
		//Discarded unreachable code: IL_0137, IL_0146
		int num = 5;
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		IEntityActionHandler serviceNotNull = default(IEntityActionHandler);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					entityActionEventArgs = EntityActionEventArgs.TryCreate(null, task, LYfbOtjlT8oEgP0jxCT());
					num2 = 3;
					continue;
				case 4:
					throw new NullReferenceException((string)fO5GdO9zG9pghbe23W7(0x46EA3D1 ^ 0x46E1883));
				case 5:
					if (task != null)
					{
						task.StartDate = startDate;
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
						{
							num2 = 2;
						}
						continue;
					}
					num = 4;
					break;
				case 2:
					task.EndDate = endDate;
					num = 8;
					break;
				case 3:
					if (entityActionEventArgs == null)
					{
						num2 = 6;
						continue;
					}
					goto case 1;
				case 8:
					fWrf5gj8gxoovbBUK6Y(task);
					num2 = 7;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5537a063960e465db83a04e35eea441b == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					Ut0nu8j0n81ynNF3XSr(serviceNotNull, entityActionEventArgs);
					num2 = 9;
					continue;
				case 6:
					return;
				case 9:
					return;
				case 7:
					serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void SetFactWorkLog(IWorkflowTaskBase task, long minutes, DateTime startDate, string comment)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_0057
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 5:
				if (task != null)
				{
					num2 = 4;
					continue;
				}
				goto case 2;
			case 2:
				throw new NullReferenceException((string)fO5GdO9zG9pghbe23W7(-1303601216 ^ -1303632750));
			case 4:
				if (minutes > 0)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			case 3:
				throw new ArgumentException((string)fO5GdO9zG9pghbe23W7(-1430645277 ^ -1430607519));
			}
			IWorkLog workLog = InterfaceActivator.Create<IWorkLog>();
			workLog.WorkMinutes = new WorkTime
			{
				Value = minutes
			};
			mtWCdSjyVLO6KOAWXGv(workLog, AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
			workLog.StartDate = startDate;
			RvM1xWjmind0VYl9LSd(workLog, comment);
			workLog.TaskBase = task;
			fWrf5gj8gxoovbBUK6Y(workLog);
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
			{
				num2 = 1;
			}
		}
	}

	[PublicApiMember]
	public void SetFactWorkLog(IWorkflowTaskBase task, long minutes, string comment)
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
				SetFactWorkLog(task, minutes, vqqZirjtGJtd1NyO8Cc(), comment);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public void SetFactWorkLog(IWorkflowTaskBase task, long minutes, DateTime startDate)
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
				v5e6xHjb0gMnCGGjLVl(this, task, minutes, startDate, null);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public void SetFactWorkLog(IWorkflowTaskBase task, long minutes)
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
				SetFactWorkLog(task, minutes, vqqZirjtGJtd1NyO8Cc(), null);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
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
	public virtual void SetFactWorkLogHours(IWorkflowTaskBase task, long hours, DateTime startDate)
	{
		int num = 1;
		int num2 = num;
		long minutes = default(long);
		while (true)
		{
			switch (num2)
			{
			case 1:
				minutes = hours * 60;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				v5e6xHjb0gMnCGGjLVl(this, task, minutes, startDate, null);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void SetFactWorkLogHours(IWorkflowTaskBase task, long hours, string comment)
	{
		int num = 1;
		int num2 = num;
		long minutes = default(long);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				minutes = hours * 60;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58f735bab6d046fe96f749ec2e269a96 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				v5e6xHjb0gMnCGGjLVl(this, task, minutes, DateTime.Now, comment);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void SetFactWorkLogHours(IWorkflowTaskBase task, long hours)
	{
		int num = 2;
		int num2 = num;
		long minutes = default(long);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				v5e6xHjb0gMnCGGjLVl(this, task, minutes, vqqZirjtGJtd1NyO8Cc(), null);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				minutes = hours * 60;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void SetFactWorkLogHours(IWorkflowTaskBase task, long hours, DateTime startDate, string comment)
	{
		int num = 2;
		int num2 = num;
		long minutes = default(long);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				minutes = hours * 60;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				SetFactWorkLog(task, minutes, startDate, comment);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void SetFactWorkLogDays(IWorkflowTaskBase task, long days, DateTime startDate)
	{
		int num = 1;
		int num2 = num;
		long minutes = default(long);
		while (true)
		{
			switch (num2)
			{
			default:
				SetFactWorkLog(task, minutes, startDate, null);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				minutes = days * 8 * 60;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[PublicApiMember]
	public virtual void SetFactWorkLogDays(IWorkflowTaskBase task, long days, string comment)
	{
		int num = 1;
		int num2 = num;
		long minutes = default(long);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				minutes = days * 8 * 60;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f != 0)
				{
					num2 = 0;
				}
				break;
			default:
				SetFactWorkLog(task, minutes, DateTime.Now, comment);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void SetFactWorkLogDays(IWorkflowTaskBase task, long days)
	{
		int num = 1;
		int num2 = num;
		long minutes = default(long);
		while (true)
		{
			switch (num2)
			{
			case 1:
				minutes = days * 8 * 60;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				SetFactWorkLog(task, minutes, DateTime.Now, null);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b84ccb8b1bd147ef900b852047ecbf45 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[PublicApiMember]
	public virtual void SetFactWorkLogDays(IWorkflowTaskBase task, long days, DateTime startDate, string comment)
	{
		int num = 1;
		int num2 = num;
		long minutes = default(long);
		while (true)
		{
			switch (num2)
			{
			case 1:
				minutes = days * 8 * 60;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5d3bc916b5664717ac60544de077bd16 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				v5e6xHjb0gMnCGGjLVl(this, task, minutes, startDate, comment);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	[PublicApiMember]
	public virtual IEnumerable<IWorkflowTaskBase> GetActiveTasks(IWorkflowInstance instance)
	{
		if (instance == null)
		{
			throw new NullReferenceException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4943E3E4 ^ 0x49438DBE));
		}
		return Instance.GetTasks(instance, allowSubInstances: false);
	}

	[PublicApiMember]
	public virtual IEnumerable<IWorkflowTaskBase> GetActiveTasks(IWorkflowInstance instance, bool allowSubInstances)
	{
		if (instance == null)
		{
			throw new NullReferenceException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2002063381 ^ -2002091599));
		}
		return Instance.GetTasks(instance, allowSubInstances);
	}

	[PublicApiMember]
	public virtual void ReAssign(IWorkflowTaskBase task, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime endDate)
	{
		//Discarded unreachable code: IL_00ae, IL_00bd
		int num = 4;
		int num2 = num;
		DateTime? startDate = default(DateTime?);
		IComment comment = default(IComment);
		while (true)
		{
			switch (num2)
			{
			case 1:
			{
				object obj = dsgZvfj5CdHa0H3dYR1();
				startDate = task.StartDate;
				((WorkflowTaskBaseManager)obj).ReAssign(task, newExecutor, startDate.Value, endDate, TaskPriority.Medium, comment);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
				{
					num2 = 2;
				}
				break;
			}
			case 4:
				comment = InterfaceActivator.Create<IComment>();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
				{
					num2 = 3;
				}
				break;
			default:
				if (!startDate.HasValue)
				{
					num2 = 6;
					break;
				}
				goto case 1;
			case 5:
				return;
			case 3:
				startDate = task.StartDate;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			case 6:
				PsjynljgU9EPd3o9G4n(dsgZvfj5CdHa0H3dYR1(), task, newExecutor, DateTime.Now, endDate, TaskPriority.Medium, comment);
				num2 = 5;
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void ReAssign(IWorkflowTaskBase task, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime endDate, string comment)
	{
		//Discarded unreachable code: IL_00ad
		int num = 4;
		IComment comment2 = default(IComment);
		DateTime? startDate = default(DateTime?);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					comment2 = InterfaceActivator.Create<IComment>();
					num2 = 3;
					continue;
				case 2:
					comment2.Save();
					num = 5;
					break;
				case 9:
				{
					object obj = dsgZvfj5CdHa0H3dYR1();
					startDate = task.StartDate;
					((WorkflowTaskBaseManager)obj).ReAssign(task, newExecutor, startDate.Value, endDate, TaskPriority.Medium, comment2);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
					{
						num2 = 10;
					}
					continue;
				}
				case 8:
					return;
				case 7:
					if (!startDate.HasValue)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 9;
				case 6:
					comment2.CreationDate = DateTime.Now;
					num2 = 2;
					continue;
				case 5:
					startDate = task.StartDate;
					num = 7;
					break;
				case 1:
					iY4l4ejcD3ClGvoJlIY(comment2, AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
					num2 = 6;
					continue;
				case 10:
					return;
				default:
					PsjynljgU9EPd3o9G4n(dsgZvfj5CdHa0H3dYR1(), task, newExecutor, vqqZirjtGJtd1NyO8Cc(), endDate, TaskPriority.Medium, comment2);
					num2 = 8;
					continue;
				case 3:
					xtAe1vjBKtfdxINdjM3(comment2, comment);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void ReAssign(IWorkflowTaskBase task, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime endDate, IComment comment)
	{
		//Discarded unreachable code: IL_007f, IL_008e
		int num = 2;
		int num2 = num;
		DateTime? startDate = default(DateTime?);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!startDate.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 3:
				return;
			default:
				PsjynljgU9EPd3o9G4n(dsgZvfj5CdHa0H3dYR1(), task, newExecutor, vqqZirjtGJtd1NyO8Cc(), endDate, TaskPriority.Medium, comment);
				num2 = 4;
				continue;
			case 2:
				startDate = task.StartDate;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				break;
			case 4:
				return;
			}
			WorkflowTaskBaseManager instance = Instance;
			startDate = task.StartDate;
			PsjynljgU9EPd3o9G4n(instance, task, newExecutor, startDate.Value, endDate, TaskPriority.Medium, comment);
			num2 = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
			{
				num2 = 3;
			}
		}
	}

	[PublicApiMember]
	public virtual void ReAssign(IWorkflowTaskBase task, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime startDate, DateTime endDate)
	{
		int num = 2;
		int num2 = num;
		IComment comment = default(IComment);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				comment = InterfaceActivator.Create<IComment>();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				((WorkflowTaskBaseManager)dsgZvfj5CdHa0H3dYR1()).ReAssign(task, newExecutor, startDate, endDate, TaskPriority.Medium, comment);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void ReAssign(IWorkflowTaskBase task, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime startDate, DateTime endDate, string comment)
	{
		int num = 3;
		int num2 = num;
		IComment comment2 = default(IComment);
		while (true)
		{
			switch (num2)
			{
			case 5:
				comment2.CreationAuthor = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
				num2 = 6;
				break;
			case 3:
				comment2 = InterfaceActivator.Create<IComment>();
				num2 = 2;
				break;
			case 1:
				return;
			case 4:
				PsjynljgU9EPd3o9G4n(dsgZvfj5CdHa0H3dYR1(), task, newExecutor, startDate, endDate, TaskPriority.Medium, comment2);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				xtAe1vjBKtfdxINdjM3(comment2, comment);
				num2 = 5;
				break;
			default:
				fWrf5gj8gxoovbBUK6Y(comment2);
				num2 = 4;
				break;
			case 6:
				comment2.CreationDate = vqqZirjtGJtd1NyO8Cc();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void ReAssign(IWorkflowTaskBase task, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime startDate, DateTime endDate, IComment comment)
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
				PsjynljgU9EPd3o9G4n(dsgZvfj5CdHa0H3dYR1(), task, newExecutor, startDate, endDate, TaskPriority.Medium, comment);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void ReAssign(IWorkflowTaskBase task, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime startDate, DateTime endDate, TaskPriority priority)
	{
		int num = 2;
		int num2 = num;
		IComment comment = default(IComment);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				comment = InterfaceActivator.Create<IComment>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				PsjynljgU9EPd3o9G4n(Instance, task, newExecutor, startDate, endDate, priority, comment);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void ReAssign(IWorkflowTaskBase task, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime startDate, DateTime endDate, TaskPriority priority, string comment)
	{
		int num = 4;
		IComment comment2 = default(IComment);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				default:
					comment2.CreationAuthor = AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					break;
				case 3:
					comment2.Text = comment;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					comment2.CreationDate = vqqZirjtGJtd1NyO8Cc();
					num2 = 6;
					continue;
				case 4:
					comment2 = InterfaceActivator.Create<IComment>();
					num2 = 3;
					continue;
				case 6:
					fWrf5gj8gxoovbBUK6Y(comment2);
					num2 = 5;
					continue;
				}
				break;
			}
			PsjynljgU9EPd3o9G4n(dsgZvfj5CdHa0H3dYR1(), task, newExecutor, startDate, endDate, priority, comment2);
			num = 2;
		}
	}

	[PublicApiMember]
	public virtual void ReAssign(IWorkflowTaskBase task, EleWise.ELMA.Security.Models.IUser newExecutor, DateTime startDate, DateTime endDate, TaskPriority priority, IComment comment)
	{
		//Discarded unreachable code: IL_009a, IL_00a9, IL_00cd, IL_01d4, IL_01e3
		int num = 9;
		IReAssignActionModel reAssignActionModel = default(IReAssignActionModel);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					throw new ArgumentException((string)fO5GdO9zG9pghbe23W7(-25709590 ^ -25751896));
				case 10:
					reAssignActionModel = InterfaceActivator.Create<IReAssignActionModel>();
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
					{
						num2 = 14;
					}
					continue;
				case 11:
					pak60YjH8yxoesnDMLr(reAssignActionModel, comment);
					num2 = 7;
					continue;
				case 5:
					return;
				case 6:
					throw new NullReferenceException((string)fO5GdO9zG9pghbe23W7(-2111219045 ^ -2111184439));
				case 8:
					if (newExecutor != null)
					{
						num2 = 4;
						continue;
					}
					goto default;
				case 2:
					QQf6l3jntKidlnTxF0r(reAssignActionModel, priority);
					num2 = 11;
					continue;
				case 13:
					HMH0oSjD5RsniNm3CPD(reAssignActionModel, newExecutor);
					num2 = 2;
					continue;
				case 12:
					DOXOGxjdtWcH4YYZ00E(reAssignActionModel, startDate);
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				default:
					throw new NullReferenceException(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1303601216 ^ -1303633214));
				case 4:
					if (vx6CPOjPLYGDQnuCdTX(dsgZvfj5CdHa0H3dYR1(), task))
					{
						num2 = 10;
						continue;
					}
					goto case 3;
				case 7:
					((TaskBaseManager<ITaskBase>)yyi7Z2jLCmgVfw0psg2()).ReAssign(reAssignActionModel);
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
					xM1E7IjXLGVASIxCDVb(reAssignActionModel, task.Id);
					num2 = 12;
					continue;
				case 9:
					if (task != null)
					{
						num2 = 8;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1733a11cae754a598119b94f8d9e4971 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 6;
				}
				break;
			}
			XmKSV5juR392lv5xIHu(reAssignActionModel, endDate);
			num = 13;
		}
	}

	[Obsolete("Больше не используется")]
	[PublicApiMember]
	public void ReAssignToReplacement(IWorkflowTaskBase task)
	{
		//Discarded unreachable code: IL_0156, IL_01cf, IL_01de
		int num = 12;
		int num2 = num;
		IReplacement replacement = default(IReplacement);
		IReplacementFilter replacementFilter = default(IReplacementFilter);
		DateTime? startDate = default(DateTime?);
		ReplacementTaskActionEventArgs replacementTaskActionEventArgs = default(ReplacementTaskActionEventArgs);
		ICommentActionModel commentActionModel = default(ICommentActionModel);
		while (true)
		{
			switch (num2)
			{
			case 10:
				replacement = EntityManager<IReplacement>.Instance.Find(replacementFilter, null).FirstOrDefault();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0991fd79553c4ecc82e8b5cb79c2bff2 != 0)
				{
					num2 = 1;
				}
				break;
			case 13:
			{
				DateTime dateTime = BqNvGtj9pA48HrSTOII(replacement);
				startDate = task.StartDate;
				if (dateTime <= startDate.Value)
				{
					num2 = 4;
					break;
				}
				return;
			}
			case 16:
				if (replacementTaskActionEventArgs != null)
				{
					num2 = 8;
					break;
				}
				goto case 14;
			case 2:
				return;
			case 11:
				replacementFilter = InterfaceActivator.Create<IReplacementFilter>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				RG5skijjkkqXQkjvvRF(task, qgQIl9jWtmusHJF2wFA(replacement));
				num2 = 12;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_60c5782a184b457aa78da2e5c62d4e27 == 0)
				{
					num2 = 17;
				}
				break;
			case 7:
				if (!startDate.HasValue)
				{
					num2 = 15;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a680afde07ce4ae5b71c411a1f75109b == 0)
					{
						num2 = 8;
					}
					break;
				}
				goto case 13;
			case 18:
				commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
				num2 = 16;
				break;
			case 12:
				if (!vx6CPOjPLYGDQnuCdTX(this, task))
				{
					return;
				}
				num2 = 11;
				break;
			default:
				YZ4xXTjfGdHJIIuCvuT(replacementFilter, task.Executor);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
				{
					num2 = 5;
				}
				break;
			case 8:
				byFWZLj6Do5ayP8cUNV(CommentActionHandler, replacementTaskActionEventArgs, commentActionModel);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b != 0)
				{
					num2 = 3;
				}
				break;
			case 15:
				return;
			case 6:
				startDate = task.StartDate;
				num2 = 7;
				break;
			case 14:
				ReAssignToReplacement(task);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
				{
					num2 = 9;
				}
				break;
			case 1:
				if (replacement != null)
				{
					num2 = 6;
					break;
				}
				return;
			case 9:
				return;
			case 3:
				Ut0nu8j0n81ynNF3XSr(ActionHandler, replacementTaskActionEventArgs);
				num2 = 13;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 == 0)
				{
					num2 = 14;
				}
				break;
			case 5:
				replacementFilter.Status = ReplacementStatus.Active;
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
				{
					num2 = 10;
				}
				break;
			case 17:
				replacementTaskActionEventArgs = (ReplacementTaskActionEventArgs)robC0jjR8qUaG3MX5dL(null, task, task.Id);
				num2 = 18;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 == 0)
				{
					num2 = 17;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void SwapTask(EleWise.ELMA.Security.Models.IUser oldExecutor, EleWise.ELMA.Security.Models.IUser newExecutor)
	{
		//Discarded unreachable code: IL_0100, IL_0110, IL_011e, IL_01af, IL_0288, IL_02a7, IL_02b6, IL_02e3
		int num = 2;
		int num2 = num;
		IWorkflowTaskBaseFilter workflowTaskBaseFilter = default(IWorkflowTaskBaseFilter);
		IEntityActionHandler serviceNotNull = default(IEntityActionHandler);
		IEnumerator<IWorkflowTaskBase> enumerator = default(IEnumerator<IWorkflowTaskBase>);
		IWorkflowTaskBase current = default(IWorkflowTaskBase);
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		while (true)
		{
			switch (num2)
			{
			case 8:
				o6vCARjqm2Y8d4MDr1x(workflowTaskBaseFilter, TaskCompleteStatus.Active);
				num2 = 9;
				break;
			default:
				workflowTaskBaseFilter.DisableSecurity = true;
				num2 = 8;
				break;
			case 7:
				throw new NullReferenceException((string)fO5GdO9zG9pghbe23W7(0x738ABA6E ^ 0x738A07E4));
			case 1:
				if (newExecutor == null)
				{
					num2 = 10;
					break;
				}
				serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
				num2 = 3;
				break;
			case 2:
				if (oldExecutor != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8a6cf36da0b84f319a7cf27018f28f5b != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 7;
			case 10:
				throw new NullReferenceException((string)fO5GdO9zG9pghbe23W7(-2077784392 ^ -2077803696));
			case 4:
				workflowTaskBaseFilter.Executor = oldExecutor;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c447ffb64be44c09b6fd398df506785b == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				try
				{
					while (true)
					{
						IL_01f8:
						int num3;
						if (!Q2CunQjTsCQpaNTB3NE(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
							{
								num3 = 0;
							}
							goto IL_0122;
						}
						goto IL_0165;
						IL_0165:
						current = enumerator.Current;
						num3 = 4;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
						{
							num3 = 2;
						}
						goto IL_0122;
						IL_0122:
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 5:
								current.Save();
								num3 = 7;
								continue;
							case 9:
								break;
							case 6:
								RG5skijjkkqXQkjvvRF(current, newExecutor);
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a == 0)
								{
									num3 = 5;
								}
								continue;
							case 4:
								if (vx6CPOjPLYGDQnuCdTX(dsgZvfj5CdHa0H3dYR1(), current))
								{
									num3 = 6;
									continue;
								}
								goto IL_01f8;
							case 7:
								entityActionEventArgs = (EntityActionEventArgs)LWsPOAj3Pwkn1kV85Sb(null, current, fO5GdO9zG9pghbe23W7(-351369538 ^ -351389444));
								num3 = 3;
								continue;
							case 1:
							case 8:
								goto IL_01f8;
							case 3:
								if (entityActionEventArgs == null)
								{
									num3 = 8;
									if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 2;
							case 2:
								Ut0nu8j0n81ynNF3XSr(serviceNotNull, entityActionEventArgs);
								num3 = 1;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede != 0)
								{
									num3 = 1;
								}
								continue;
							case 0:
								return;
							}
							break;
						}
						goto IL_0165;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_dcdfd019631e458b9cb5fa34a16a2fe1 != 0)
						{
							num4 = 1;
						}
						goto IL_028c;
					}
					goto IL_02c1;
					IL_02c1:
					yEvUDojQw59sy85A0bh(enumerator);
					num4 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
					{
						num4 = 0;
					}
					goto IL_028c;
					IL_028c:
					switch (num4)
					{
					default:
						goto end_IL_0267;
					case 1:
						goto end_IL_0267;
					case 2:
						break;
					case 0:
						goto end_IL_0267;
					}
					goto IL_02c1;
					end_IL_0267:;
				}
			case 3:
				workflowTaskBaseFilter = InterfaceActivator.Create<IWorkflowTaskBaseFilter>();
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eef7d2ca1c3c4b74aeb81172ed542639 == 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				return;
			case 9:
				enumerator = EntityManager<IWorkflowTaskBase>.Instance.Find(workflowTaskBaseFilter, null).GetEnumerator();
				num2 = 5;
				break;
			}
		}
	}

	[PublicApiMember]
	[Transaction]
	public virtual void AddComment(IWorkflowTaskBase task, string comment)
	{
		//Discarded unreachable code: IL_010c, IL_012f
		int num = 14;
		ICommentActionHandler serviceNotNull2 = default(ICommentActionHandler);
		EntityActionEventArgs entityActionEventArgs = default(EntityActionEventArgs);
		ICommentActionModel commentActionModel = default(ICommentActionModel);
		IComment comment2 = default(IComment);
		IEntityActionHandler serviceNotNull = default(IEntityActionHandler);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					byFWZLj6Do5ayP8cUNV(serviceNotNull2, entityActionEventArgs, commentActionModel);
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6d48f3b4557a49578bf7f5ef0517e0be == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					serviceNotNull2 = Locator.GetServiceNotNull<ICommentActionHandler>();
					num = 18;
					break;
				case 9:
					commentActionModel = InterfaceActivator.Create<ICommentActionModel>();
					num2 = 4;
					continue;
				case 2:
					xtAe1vjBKtfdxINdjM3(comment2, comment);
					num2 = 15;
					continue;
				case 11:
					entityActionEventArgs = EntityActionEventArgs.TryCreate(null, task, TaskBaseActions.AddCommentGuid);
					num = 12;
					break;
				case 1:
					iY4l4ejcD3ClGvoJlIY(comment2, AuthenticationService.GetCurrentUser<EleWise.ELMA.Security.Models.IUser>());
					num2 = 9;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c != 0)
					{
						num2 = 9;
					}
					continue;
				case 18:
					serviceNotNull2.Process(task, commentActionModel);
					num2 = 7;
					continue;
				case 17:
					return;
				case 12:
					if (entityActionEventArgs == null)
					{
						num2 = 14;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_61395ebf330446ac8ce99b55ee3acfa9 != 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 10;
				case 8:
					return;
				case 14:
					if (task != null)
					{
						num2 = 13;
						continue;
					}
					goto case 16;
				case 15:
					comment2.CreationDate = vqqZirjtGJtd1NyO8Cc();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e632863bfb124ba083e3ba9b363fd70e != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					Ut0nu8j0n81ynNF3XSr(serviceNotNull, entityActionEventArgs);
					num2 = 8;
					continue;
				case 3:
					fWrf5gj8gxoovbBUK6Y(task);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
					{
						num2 = 0;
					}
					continue;
				case 4:
					commentActionModel.Comment = comment2;
					num2 = 5;
					continue;
				case 7:
					task.Comments.Add(comment2);
					num2 = 3;
					continue;
				default:
					serviceNotNull = Locator.GetServiceNotNull<IEntityActionHandler>();
					num2 = 3;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d087ae72a2134de08266411226c5f060 == 0)
					{
						num2 = 11;
					}
					continue;
				case 16:
					throw new NullReferenceException((string)fO5GdO9zG9pghbe23W7(0x7381F16B ^ 0x73814A39));
				case 13:
					comment2 = InterfaceActivator.Create<IComment>();
					num2 = 2;
					continue;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void AddComment(IWorkflowTaskBase task, string comment, EleWise.ELMA.Security.Models.IUser commentAuthor)
	{
		//Discarded unreachable code: IL_006a
		int num = 2;
		_003C_003Ec__DisplayClass92_0 _003C_003Ec__DisplayClass92_ = default(_003C_003Ec__DisplayClass92_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					_003C_003Ec__DisplayClass92_ = new _003C_003Ec__DisplayClass92_0();
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					SecurityService.RunByUser(commentAuthor, _003C_003Ec__DisplayClass92_._003CAddComment_003Eb__0);
					num2 = 6;
					continue;
				case 4:
					return;
				case 8:
					_003C_003Ec__DisplayClass92_.comment = comment;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					_003C_003Ec__DisplayClass92_.task = task;
					num2 = 8;
					continue;
				default:
					if (commentAuthor != null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe7a0ffe67e4fea8e329ae6574ed2ca == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 9;
				case 9:
					throw new NullReferenceException(SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5BCD23A0 ^ 0x5BCD4D08)));
				case 3:
					if (commentAuthor != wo2eZNjpPOF72dSE3yC())
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					Ra2FVRjC2PCRdkofSJu(this, _003C_003Ec__DisplayClass92_.task, _003C_003Ec__DisplayClass92_.comment);
					num2 = 4;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
					{
						num2 = 4;
					}
					continue;
				case 6:
					return;
				case 1:
					break;
				}
				break;
			}
			_003C_003Ec__DisplayClass92_._003C_003E4__this = this;
			num = 5;
		}
	}

	[PublicApiMember]
	public virtual void CompleteTask(IWorkflowTaskBase task)
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
				SfAFq9jMtm4nKcTPp3u(this, task, null);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[PublicApiMember]
	public virtual void CompleteTask(IWorkflowTaskBase task, string connectorName)
	{
		//Discarded unreachable code: IL_00b3, IL_01a5, IL_01b4
		int num = 9;
		int num2 = num;
		_003C_003Ec__DisplayClass94_0 _003C_003Ec__DisplayClass94_ = default(_003C_003Ec__DisplayClass94_0);
		BPMNFlowElement bPMNFlowElement = default(BPMNFlowElement);
		WorkflowTaskExecuteData workflowTaskExecuteData = default(WorkflowTaskExecuteData);
		Connector connector2 = default(Connector);
		while (true)
		{
			Connector connector;
			switch (num2)
			{
			case 8:
				_003C_003Ec__DisplayClass94_.task = task;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f276fa9c20d4dd889000f50d886a41e != 0)
				{
					num2 = 5;
				}
				continue;
			case 3:
				if (caUXpcjk8muNDiFuQ8S(_003C_003Ec__DisplayClass94_.connectorName))
				{
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
					{
						num2 = 3;
					}
					continue;
				}
				goto case 7;
			case 7:
				connector = bPMNFlowElement.OutputConnectors.FirstOrDefault(_003C_003Ec__DisplayClass94_._003CCompleteTask_003Eb__1);
				break;
			case 10:
				zYt5DfjVc5mRA6fMq45(Locator.GetServiceNotNull<IWorkflowRuntimeService>(), workflowTaskExecuteData);
				num2 = 2;
				continue;
			case 5:
				_003C_003Ec__DisplayClass94_.connectorName = connectorName;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6b089b0d02ae4d3186c8d2cb8a24d4d3 == 0)
				{
					num2 = 1;
				}
				continue;
			case 9:
				_003C_003Ec__DisplayClass94_ = new _003C_003Ec__DisplayClass94_0();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
				{
					num2 = 8;
				}
				continue;
			case 2:
				return;
			case 1:
				bPMNFlowElement = (BPMNFlowElement)((IEnumerable<Element>)SJKVePWCK2T1cLAJya1(bOirIJjOn0A3phyZ1Fh(((IWorkflowBookmark)sTxjddWj38icO0SyKo0(_003C_003Ec__DisplayClass94_.task)).Instance.Process))).Single(_003C_003Ec__DisplayClass94_._003CCompleteTask_003Eb__0);
				num2 = 3;
				continue;
			default:
				workflowTaskExecuteData = new WorkflowTaskExecuteData(_003C_003Ec__DisplayClass94_.task, YdtTjAjUdZQHaODDsp8(connector2));
				num2 = 10;
				continue;
			case 4:
				if (connector2 == null)
				{
					throw new ArgumentException((string)vtFWs6jAX3EMTv82RGn(fO5GdO9zG9pghbe23W7(0x4943E3E4 ^ 0x49435D6A), new object[1] { _003C_003Ec__DisplayClass94_.connectorName }));
				}
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				connector = bPMNFlowElement.OutputConnectors.FirstOrDefault();
				break;
			}
			connector2 = connector;
			num2 = 4;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
			{
				num2 = 4;
			}
		}
	}

	internal static bool Blh7lL9hRc0Y4PgX39k()
	{
		return Ox36TN91demnlJCMrFe == null;
	}

	internal static WorkflowTaskBaseManager z85ePU9EZrdwCm6T6Vp()
	{
		return Ox36TN91demnlJCMrFe;
	}

	internal static Guid Xnipb09wvsCosF23YhA()
	{
		return TaskBaseActions.CompleteGuid;
	}

	internal static object alJdW2947XdNjpnwu2X(object P_0)
	{
		return ((NHManagerBase)P_0).Session;
	}

	internal static object fO5GdO9zG9pghbe23W7(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object oaBZcOWK04FTL4KwHkR(object P_0, object P_1)
	{
		return ((ISession)P_0).CreateSQLSubQuery((string)P_1);
	}

	internal static object EHQo0mWO20Rk0YHa5SH(object P_0, object P_1, object P_2)
	{
		return ((SqlSubQuery)P_0).SetParameter((string)P_1, P_2);
	}

	internal static object qqT5pEWZ5B6S9p7nwfC(object P_0)
	{
		return ((WorkflowTaskBaseManager)P_0).CreateCriteriaNoPermissions();
	}

	internal static object jIbRmFWvWkopou2huEa(object P_0, object P_1, object P_2, JoinType P_3)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2, P_3);
	}

	internal static object sXYC9RWYPVvryQWW2LT()
	{
		return TaskBaseExtensions.ActiveTaskStatuses;
	}

	internal static object rdrWmyW8OpL5A0xga0f(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (object[])P_1);
	}

	internal static object IAL2r5WsRPnswinGCJB(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object sqAV1sWJWxnq7ZgWh1U(object P_0)
	{
		return ((ITransformationProvider)P_0).Dialect;
	}

	internal static object lOb3ZmWlvoVHNGhDMud(object P_0, object P_1)
	{
		return ((Dialect)P_0).QuoteIfNeeded((string)P_1);
	}

	internal static object yLi8G1W0ax4YJTN16dd(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object EOgvktWykiPinNMdSF8(object P_0)
	{
		return ((SqlSubQuery)P_0).ParametersValues;
	}

	internal static object C6Q8KhWmbjhXTQ74J2Y(object P_0)
	{
		return ((SqlSubQuery)P_0).ParametersTypes;
	}

	internal static object AJme1qWta34Txuhy7U1(object P_0, object P_1, object P_2)
	{
		return Expression.Sql((string)P_0, (object[])P_1, (IType[])P_2);
	}

	internal static object MslSvPWbAl06LuI9p5H(object P_0, int P_1)
	{
		return ((ICriteria)P_0).SetMaxResults(P_1);
	}

	internal static object DQw42TW5qKPw97LqEZC()
	{
		return Projections.Id();
	}

	internal static object Woqb4dWg57nHwYTZsE1(object P_0, object P_1)
	{
		return ((ICriteria)P_0).SetProjection((IProjection[])P_1);
	}

	internal static long XCX0OZWBkYMBw15F9TP(object P_0)
	{
		return Convert.ToInt64(P_0);
	}

	internal static object Vg6fafWcr4rFO21uUcA(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object kQl3QcWPDqXy8Q0cpxd(object P_0)
	{
		return ((IWorkflowInstanceFilter)P_0).ProcessHeader;
	}

	internal static object MsiYbOWXoqjIwWAkFZP()
	{
		return FetchOptions.All;
	}

	internal static object gMoXa7WdX1i12G4LWLR(object P_0, object P_1, object P_2)
	{
		return ((WorkflowInstanceManager)P_0).CreateContextFilterCriteria((IWorkflowInstanceFilter)P_1, (FetchOptions)P_2);
	}

	internal static object eLi4eIWu7jg16DgRc7x()
	{
		return WorkflowInstanceManager.Instance;
	}

	internal static void TmZiYfWD6GlEgyxISJT(object P_0, object P_1, object P_2)
	{
		((AbstractNHEntityManager<IWorkflowInstance, long>)P_0).SetupFilter((ICriteria)P_1, (IEntityFilter)P_2);
	}

	internal static object wIw9t3WnIvjl0vLxmq8(object P_0)
	{
		return NHibernateHelper.CreateFromCriteria((ICriteria)P_0);
	}

	internal static object eCNH57WHuwEVQtF0Dkw(object P_0, object P_1)
	{
		return ((EntityManager<IWorkflowInstance, long>)P_0).GetAliasedPropertyString((string)P_1);
	}

	internal static object tLqxGXWLSQaylQb43HB(object P_0)
	{
		return Projections.Property((string)P_0);
	}

	internal static object oCVxuXWfmIqNDuDWJeh(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).SetProjection((IProjection)P_1);
	}

	internal static void TR6lV9W97yxRpiepfqy(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object AF27GRWWtHXwDRYdp84(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).GetElement();
	}

	internal static object sTxjddWj38icO0SyKo0(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object zOSeOBWRbooXWyrO8H9(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object sRK36mW6mJX5RpnVBwj(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object J4S1UuWqTRx9e36Fs9E(object P_0, object P_1)
	{
		return ((BPMNFlowElement)P_0).GetSwimlane((Diagram)P_1);
	}

	internal static bool UvRX2UW33TlOpjx5m8G(object P_0)
	{
		return ((ITaskBase)P_0).IsEmulation;
	}

	internal static object hcVl2UWTYQhO3oipowl(object P_0)
	{
		return ((ITaskBase)P_0).ExecutorReplaced;
	}

	internal static object SJeawrWQK1qgQmfEpTu(object P_0)
	{
		return ((ITaskBase)P_0).Executor;
	}

	internal static void O2nAe6Wp90MtiIr02lT(object P_0, object P_1, object P_2, object P_3)
	{
		((WorkflowInstanceManager)P_0).SaveSwimlaneExecutor((IWorkflowInstance)P_1, (SwimlaneElement)P_2, (EleWise.ELMA.Security.Models.IUser)P_3);
	}

	internal static object SJKVePWCK2T1cLAJya1(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static void G4H3wdWMHNTlZn8JYmW(object P_0, object P_1)
	{
		((ISecurityService)P_0).RunWithUsualPrivilegies((Action)P_1);
	}

	internal static object PwENPcWkN3Yrrum7qOI()
	{
		return Projections.ProjectionList();
	}

	internal static object Qc5LFpWUyUl9tnAX9o4(object P_0, object P_1, object P_2)
	{
		return ((ProjectionList)P_0).Add((IProjection)P_1, (string)P_2);
	}

	internal static object S1ljpbWVC2f6bVZetRv(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object JqlkP6WAPUOk5yy2I3V(object P_0)
	{
		return Projections.CountDistinct((string)P_0);
	}

	internal static object Be3vDhWGjvJpo4vuYuH(object P_0, object P_1, Type P_2, object P_3)
	{
		return ((EntityExtensionManager<ITaskBase, IWorkflowTaskBase, long, TaskBaseManager>)P_0).CreateCriteria((FetchOptions)P_1, P_2, (string)P_3);
	}

	internal static object VCRxLaW7yM9Gn6Y5Xmy(object P_0, object P_1)
	{
		return Restrictions.EqProperty((string)P_0, (string)P_1);
	}

	internal static object GZIFxyW2BpYix8NLc9s(object P_0, object P_1, object P_2, JoinType P_3, object P_4)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2, P_3, (ICriterion)P_4);
	}

	internal static Type oxhqBlWo71GCEBnmDIl(object P_0)
	{
		return ((EntityExtensionManager<ITaskBase, IWorkflowTaskBase, long, TaskBaseManager>)P_0).ImplementationType;
	}

	internal static object ArRd7cWFtv4gAonitVX(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object pAV4dDWiJVZdysXHJbH(object P_0, object P_1)
	{
		return Subqueries.PropertyIn((string)P_0, (DetachedCriteria)P_1);
	}

	internal static long DE9oAgWI77L4OrAKbvG(object P_0)
	{
		return ((IWorkflowTaskBaseFilter)P_0).InstanceId;
	}

	internal static object FlELP1WaOPR0eEc7K6q(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (ICollection)P_1);
	}

	internal static int i0OuFoWrkSm19LblRvX(object P_0)
	{
		return ((List<Guid>)P_0).Count;
	}

	internal static Guid sFsC2OWenSYNmKNIVd4(object P_0)
	{
		return ((Permission)P_0).Id;
	}

	internal static bool XhJhi4WNUbcC176V8SS(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object G7csIXWxK9dL3VCAZvR(Type P_0, object P_1)
	{
		return DetachedCriteria.For(P_0, (string)P_1);
	}

	internal static object U74sODWS7wANeTrCZUx(object P_0, object P_1)
	{
		return ((DetachedCriteria)P_0).Add((ICriterion)P_1);
	}

	internal static object nJ2C7wW1KkEPcsWYGL0(object P_0, object P_1)
	{
		return ((ProjectionList)P_0).Add((IProjection)P_1);
	}

	internal static object F7beMVWhUBAH7w7SgHU(object P_0)
	{
		return Subqueries.Exists((DetachedCriteria)P_0);
	}

	internal static bool LXqXeSWErUEuMVgv1CR(object P_0, object P_1)
	{
		return ((ISecurityService)P_0).HasPermission((Permission)P_1);
	}

	internal static object NDiiaRWwDf2QOCF8wN9(object P_0)
	{
		return Expression.Sql((string)P_0);
	}

	internal static long kXuFX1W4cpHbPEevygL(object P_0)
	{
		return ((IReAssignActionModel)P_0).TaskId;
	}

	internal static object zmVOFtWzcvSsuakbHQ6()
	{
		return TaskBaseStatus.WasClosed;
	}

	internal static void Ff9dJmjKs2tTG6Js7y6(object P_0, object P_1)
	{
		((ITaskBase)P_0).Status = (TaskBaseStatus)P_1;
	}

	internal static object bOirIJjOn0A3phyZ1Fh(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static bool mZLCwejZLDxIoFKRrC0(object P_0)
	{
		return ((UserTaskElement)P_0).DenyReassign;
	}

	internal static char chDmvijv0kMs88cWAI1(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static void FFDOFZjYT2QQlKKdx3C(object P_0, object P_1)
	{
		((ITaskBase)P_0).Subject = (string)P_1;
	}

	internal static void fWrf5gj8gxoovbBUK6Y(object P_0)
	{
		((IEntity)P_0).Save();
	}

	internal static Guid egVhlojsmmLhuid29rc()
	{
		return TaskBaseActions.EditGuid;
	}

	internal static object bqTYHejJtVfDN8iJjsV(object P_0, object P_1, Guid P_2)
	{
		return EntityActionEventArgs.TryCreate((IEntity)P_0, (IEntity)P_1, P_2);
	}

	internal static Guid LYfbOtjlT8oEgP0jxCT()
	{
		return TaskBaseActions.ChangeEndDateGuid;
	}

	internal static void Ut0nu8j0n81ynNF3XSr(object P_0, object P_1)
	{
		((IEntityActionHandler)P_0).ActionExecuted((EntityActionEventArgs)P_1);
	}

	internal static void mtWCdSjyVLO6KOAWXGv(object P_0, object P_1)
	{
		((IWorkLog)P_0).Worker = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static void RvM1xWjmind0VYl9LSd(object P_0, object P_1)
	{
		((IWorkLog)P_0).Comment = (string)P_1;
	}

	internal static DateTime vqqZirjtGJtd1NyO8Cc()
	{
		return DateTime.Now;
	}

	internal static void v5e6xHjb0gMnCGGjLVl(object P_0, object P_1, long minutes, DateTime startDate, object P_4)
	{
		((WorkflowTaskBaseManager)P_0).SetFactWorkLog((IWorkflowTaskBase)P_1, minutes, startDate, (string)P_4);
	}

	internal static object dsgZvfj5CdHa0H3dYR1()
	{
		return Instance;
	}

	internal static void PsjynljgU9EPd3o9G4n(object P_0, object P_1, object P_2, DateTime startDate, DateTime endDate, TaskPriority priority, object P_6)
	{
		((WorkflowTaskBaseManager)P_0).ReAssign((IWorkflowTaskBase)P_1, (EleWise.ELMA.Security.Models.IUser)P_2, startDate, endDate, priority, (IComment)P_6);
	}

	internal static void xtAe1vjBKtfdxINdjM3(object P_0, object P_1)
	{
		((IComment)P_0).Text = (string)P_1;
	}

	internal static void iY4l4ejcD3ClGvoJlIY(object P_0, object P_1)
	{
		((IComment)P_0).CreationAuthor = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static bool vx6CPOjPLYGDQnuCdTX(object P_0, object P_1)
	{
		return ((WorkflowTaskBaseManager)P_0).IsAvailableReAssign((ITaskBase)P_1);
	}

	internal static void xM1E7IjXLGVASIxCDVb(object P_0, long P_1)
	{
		((IReAssignActionModel)P_0).TaskId = P_1;
	}

	internal static void DOXOGxjdtWcH4YYZ00E(object P_0, DateTime P_1)
	{
		((IReAssignActionModel)P_0).StartDate = P_1;
	}

	internal static void XmKSV5juR392lv5xIHu(object P_0, DateTime P_1)
	{
		((IReAssignActionModel)P_0).EndDate = P_1;
	}

	internal static void HMH0oSjD5RsniNm3CPD(object P_0, object P_1)
	{
		((IReAssignActionModel)P_0).Executor = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static void QQf6l3jntKidlnTxF0r(object P_0, TaskPriority P_1)
	{
		((IReAssignActionModel)P_0).Priority = P_1;
	}

	internal static void pak60YjH8yxoesnDMLr(object P_0, object P_1)
	{
		((IReAssignActionModel)P_0).Comment = (IComment)P_1;
	}

	internal static object yyi7Z2jLCmgVfw0psg2()
	{
		return TaskBaseManager.Instance;
	}

	internal static void YZ4xXTjfGdHJIIuCvuT(object P_0, object P_1)
	{
		((IReplacementFilter)P_0).SourceUser = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static DateTime BqNvGtj9pA48HrSTOII(object P_0)
	{
		return ((IReplacement)P_0).StartDate;
	}

	internal static object qgQIl9jWtmusHJF2wFA(object P_0)
	{
		return ((IReplacement)P_0).TargetUser;
	}

	internal static void RG5skijjkkqXQkjvvRF(object P_0, object P_1)
	{
		((ITaskBase)P_0).Executor = (EleWise.ELMA.Security.Models.IUser)P_1;
	}

	internal static object robC0jjR8qUaG3MX5dL(object P_0, object P_1, long P_2)
	{
		return ReplacementTaskActionEventArgs.TryCreate((IEntity)P_0, (IEntity)P_1, P_2);
	}

	internal static void byFWZLj6Do5ayP8cUNV(object P_0, object P_1, object P_2)
	{
		((ICommentActionHandler)P_0).ProcessEventArgs((EntityActionEventArgs)P_1, (ICommentActionModel)P_2);
	}

	internal static void o6vCARjqm2Y8d4MDr1x(object P_0, TaskCompleteStatus P_1)
	{
		((ITaskBaseFilter)P_0).CompleteStatus = P_1;
	}

	internal static object LWsPOAj3Pwkn1kV85Sb(object P_0, object P_1, object P_2)
	{
		return EntityActionEventArgs.TryCreate((IEntity)P_0, (IEntity)P_1, (string)P_2);
	}

	internal static bool Q2CunQjTsCQpaNTB3NE(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void yEvUDojQw59sy85A0bh(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object wo2eZNjpPOF72dSE3yC()
	{
		return AuthenticationService.GetCurrentUser();
	}

	internal static void Ra2FVRjC2PCRdkofSJu(object P_0, object P_1, object P_2)
	{
		((WorkflowTaskBaseManager)P_0).AddComment((IWorkflowTaskBase)P_1, (string)P_2);
	}

	internal static void SfAFq9jMtm4nKcTPp3u(object P_0, object P_1, object P_2)
	{
		((WorkflowTaskBaseManager)P_0).CompleteTask((IWorkflowTaskBase)P_1, (string)P_2);
	}

	internal static bool caUXpcjk8muNDiFuQ8S(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static Guid YdtTjAjUdZQHaODDsp8(object P_0)
	{
		return ((Element)P_0).Uid;
	}

	internal static void zYt5DfjVc5mRA6fMq45(object P_0, object P_1)
	{
		((IWorkflowRuntimeService)P_0).Execute((IWorkflowExecuteData)P_1);
	}

	internal static object vtFWs6jAX3EMTv82RGn(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}
}
