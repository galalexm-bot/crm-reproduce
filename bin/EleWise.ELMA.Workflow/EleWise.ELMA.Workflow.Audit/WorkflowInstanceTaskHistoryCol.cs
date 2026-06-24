using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Common.Managers;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Model.Events;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime.NH;
using EleWise.ELMA.Tasks.Audit;
using EleWise.ELMA.Tasks.Managers;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Transform;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Audit;

[Component]
public class WorkflowInstanceTaskHistoryCollector : BaseEntityActionHistoryCollectorRelated
{
	private readonly Guid collectorGuid;

	private TaskBaseManager taskBaseManager;

	private IAuditManager auditManager;

	private EntityActionHistoryManager entityActionHistoryManager;

	private TaskQuestionHistoryCollector taskQuestionHistoryCollector;

	private ISessionProvider sessionProvider;

	private WorkflowTaskBaseManager workflowTaskBaseManager;

	private static WorkflowInstanceTaskHistoryCollector phlFFyZnvWHVdn0oUDNi;

	public WorkflowInstanceTaskHistoryCollector(TaskBaseManager taskBaseManager, IAuditManager auditManager, EntityActionHistoryManager entityActionHistoryManager, TaskQuestionHistoryCollector taskQuestionHistoryCollector, ISessionProvider sessionProvider, WorkflowTaskBaseManager workflowTaskBaseManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hLYH8DZnsM0atRjTqwUq();
		base._002Ector();
		int num = 7;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_58fb165cafed422d973d4a7156526541 == 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 6:
				this.sessionProvider = sessionProvider;
				num = 4;
				break;
			default:
				this.auditManager = auditManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_fb347e2c5dba4e0ca4d47098be7fd10c != 0)
				{
					num = 3;
				}
				break;
			case 4:
				this.workflowTaskBaseManager = workflowTaskBaseManager;
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7de614af35034bd0a6867d08a2ee4a84 != 0)
				{
					num = 2;
				}
				break;
			case 1:
				this.taskQuestionHistoryCollector = taskQuestionHistoryCollector;
				num = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
				{
					num = 6;
				}
				break;
			case 7:
				this.taskBaseManager = taskBaseManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6fe3beca34a9422e873cd6ef331760ae == 0)
				{
					num = 0;
				}
				break;
			case 5:
				return;
			case 2:
				collectorGuid = new Guid((string)vkK9FjZnJJmynch22B2r(0xA7339EE ^ 0xA71FA3A));
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
				{
					num = 5;
				}
				break;
			case 3:
				this.entityActionHistoryManager = entityActionHistoryManager;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override bool CanUse(long id, Guid actionObject)
	{
		int num = 4;
		int num2 = num;
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		EntityMetadata entityMetadata = default(EntityMetadata);
		while (true)
		{
			switch (num2)
			{
			case 4:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 3;
				break;
			case 3:
				if (!TB0BSHZnlTOq0HwqsduX(this, id, actionObject))
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					entityMetadata = ((IMetadataService)s3EuS6Zn0CvSKwVjfOxf()).GetMetadata(actionObject, loadImplementation: true) as EntityMetadata;
					num2 = 2;
				}
				break;
			case 2:
			{
				if (entityMetadata == null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e2e244178c44ea09cd756894b022a62 == 0)
					{
						num2 = 0;
					}
					break;
				}
				List<ClassMetadata> baseClasses = MetadataLoader.GetBaseClasses(entityMetadata);
				baseClasses.Add(entityMetadata);
				_003C_003Ec__DisplayClass8_.workflowInstanceTypeUid = InterfaceActivator.UID<IWorkflowInstance>();
				return baseClasses.Any(_003C_003Ec__DisplayClass8_._003CCanUse_003Eb__0);
			}
			default:
				return false;
			case 1:
				return false;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CCollectHistory_003Ed__9))]
	public override IEnumerable<EntityActionEventArgs> CollectHistory(long id, Guid actionObject, IEnumerable<EntityActionEventArgs> relatedEventList, IEnumerable<HistoryCollectorRelatedModel> relatedObjectList)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CCollectHistory_003Ed__9(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__relatedEventList = relatedEventList,
			_003C_003E3__relatedObjectList = relatedObjectList
		};
	}

	public override IEnumerable<HistoryCollectorRelatedModel> RelatedObjects(long id, Guid actionObject)
	{
		ICriteria instanceTasksCriteria = workflowTaskBaseManager.GetInstanceTasksCriteria(id);
		instanceTasksCriteria.SetProjection((IProjection[])(object)new IProjection[1] { (IProjection)Projections.ProjectionList().Add((IProjection)(object)Projections.Property(NHibernateHelper.GetCriteriaTypeUidPropertyName(InterfaceActivator.TypeOf<IWorkflowTaskBase>())), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1EA50FCC ^ 0x1EA48BC8)).Add((IProjection)(object)Projections.Id(), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1212129906 ^ 0x483D6178))
			.Add((IProjection)(object)Projections.Property(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42311138 ^ 0x42307536)), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACCDD87 ^ 0x2ACC9B09)) });
		Guid guid = InterfaceActivator.UID<IWorkflowInstance>();
		IList<HistoryCollectorRelatedModel> list = instanceTasksCriteria.SetResultTransformer((IResultTransformer)(object)new AliasToBeanResultTransformer(typeof(HistoryCollectorRelatedModel))).List<HistoryCollectorRelatedModel>();
		List<HistoryCollectorRelatedModel> list2 = new List<HistoryCollectorRelatedModel>();
		foreach (HistoryCollectorRelatedModel item in list)
		{
			item.CollectorGuid = collectorGuid;
			item.AdditionalInformation = guid;
			list2.AddRange(QuestionHistoryCollectorBase.RelatedObjects(item.EntityId, item.EntityTypeUid, collectorGuid, item.Name));
		}
		return list.Union(list2);
	}

	internal static void hLYH8DZnsM0atRjTqwUq()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static object vkK9FjZnJJmynch22B2r(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool pFbTbrZnYEZL9ELbes2O()
	{
		return phlFFyZnvWHVdn0oUDNi == null;
	}

	internal static WorkflowInstanceTaskHistoryCollector mD5fGSZn8LJdF5cBV57O()
	{
		return phlFFyZnvWHVdn0oUDNi;
	}

	internal static bool TB0BSHZnlTOq0HwqsduX(object P_0, long P_1, Guid P_2)
	{
		return ((BaseEntityActionHistoryCollectorRelated)P_0).CanUse(P_1, P_2);
	}

	internal static object s3EuS6Zn0CvSKwVjfOxf()
	{
		return MetadataServiceContext.Service;
	}
}
