using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow;

[Component]
public class WorkflowInstanceSubprocessHistoryCollector : BaseEntityActionHistoryCollectorRelated
{
	private readonly Guid collectorGuid;

	private WorkflowInstanceManager workflowInstanceManager;

	private EntityActionHistoryManager entityActionHistoryManager;

	private IAuditManager auditManager;

	private Guid workflowInstanceUid;

	internal static WorkflowInstanceSubprocessHistoryCollector GGFjGFvbfa1aqh6JaOl;

	public WorkflowInstanceSubprocessHistoryCollector(WorkflowInstanceManager workflowInstanceManager, EntityActionHistoryManager entityActionHistoryManager, IAuditManager auditManager)
	{
		//Discarded unreachable code: IL_002a
		XhLNtevBs09byrbajNk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ffb1346d351f436b84bb1e9954c3bfa8 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.workflowInstanceManager = workflowInstanceManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
				{
					num = 0;
				}
				break;
			default:
			{
				this.entityActionHistoryManager = entityActionHistoryManager;
				int num2 = 5;
				num = num2;
				break;
			}
			case 3:
				workflowInstanceUid = InterfaceActivator.UID<IWorkflowInstance>();
				num = 4;
				break;
			case 4:
				collectorGuid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56A753C9 ^ 0x56A759FB));
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c == 0)
				{
					num = 2;
				}
				break;
			case 5:
				this.auditManager = auditManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d42a29e78d4a45518985de3631ade50c == 0)
				{
					num = 3;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public override bool CanUse(long id, Guid actionObject)
	{
		//Discarded unreachable code: IL_0080, IL_008f
		int num = 1;
		int num2 = num;
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return false;
			case 1:
				if (oZ463fvcjavRmdgUiY4(this, id, actionObject))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 4:
				if (entityMetadata != null)
				{
					List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses(entityMetadata);
					baseClasses.Add(entityMetadata);
					return baseClasses.Any((ClassMetadata c) => TtF1aQvX6Tb6wbMJdyS(c.Uid, workflowInstanceUid));
				}
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return false;
			default:
				entityMetadata = s5IBBovPHRLVdcWV92r(MetadataServiceContext.Service, actionObject, true) as EntityMetadata;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f91acf223c4b4303819d2f8f2fc6c8e1 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CCollectHistory_003Ed__7))]
	public override IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList, IEnumerable<HistoryCollectorRelatedModel> relatedObjectList)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CCollectHistory_003Ed__7(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__relatedEventList = relatedEventList,
			_003C_003E3__relatedObjectList = relatedObjectList
		};
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject)
	{
		_003C_003Ec__DisplayClass8_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass8_0();
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		CS_0024_003C_003E8__locals0.typeUid = InterfaceActivator.UID<IWorkflowInstance>();
		return workflowInstanceManager.GetSubInstancesCriteria(id).SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.Id() }).List<long>()
			.Select(delegate(long a)
			{
				HistoryCollectorRelatedModel historyCollectorRelatedModel = new HistoryCollectorRelatedModel();
				_003C_003Ec__DisplayClass8_0.RjBQhRZL5tUGrBRwQUIL(historyCollectorRelatedModel, CS_0024_003C_003E8__locals0._003C_003E4__this.collectorGuid);
				_003C_003Ec__DisplayClass8_0.Yhy4LUZLgTbrpnP95c8E(historyCollectorRelatedModel, a);
				_003C_003Ec__DisplayClass8_0.uriAtbZLB8omHxXw9KEp(historyCollectorRelatedModel, CS_0024_003C_003E8__locals0.typeUid);
				return historyCollectorRelatedModel;
			});
	}

	private EntityActionEventArgs GetSubprocessCreateEventArgs(IEnumerable<EntityActionEventArgs> history)
	{
		try
		{
			EntityActionEventArgs entityActionEventArgs = history.SingleOrDefault();
			if (entityActionEventArgs != null)
			{
				entityActionEventArgs.Object = auditManager.GetObject(workflowInstanceUid);
				entityActionEventArgs.ExtendedProperties[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-106528299 ^ -106525781)] = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--727842433 ^ 0x2B61F415);
				return entityActionEventArgs;
			}
		}
		catch (ArgumentNullException)
		{
		}
		catch (InvalidOperationException)
		{
		}
		return null;
	}

	internal static void XhLNtevBs09byrbajNk()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool YStssDv5oo0FGocnGDJ()
	{
		return GGFjGFvbfa1aqh6JaOl == null;
	}

	internal static WorkflowInstanceSubprocessHistoryCollector chCwVHvg8RQbUZROZ3s()
	{
		return GGFjGFvbfa1aqh6JaOl;
	}

	internal static bool oZ463fvcjavRmdgUiY4(object P_0, long P_1, Guid P_2)
	{
		return ((BaseEntityActionHistoryCollectorRelated)P_0).CanUse(P_1, P_2);
	}

	internal static object s5IBBovPHRLVdcWV92r(object P_0, Guid P_1, bool P_2)
	{
		return ((IMetadataService)P_0).GetMetadata(P_1, P_2);
	}

	internal static bool TtF1aQvX6Tb6wbMJdyS(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
