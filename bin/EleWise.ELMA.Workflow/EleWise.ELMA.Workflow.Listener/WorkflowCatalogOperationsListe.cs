using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Common.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Runtime.NH.Listeners;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Catalogs;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Event;
using NHibernate.Persister.Entity;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Listeners;

[Component]
internal class WorkflowCatalogOperationsListener : PostFlushEventListener
{
	private IEntityTaskModelDraftService entityTaskModelDraftService;

	internal static WorkflowCatalogOperationsListener AH3R7qj4ccwR7VTDsJ5;

	public WorkflowCatalogOperationsListener(IEntityTaskModelDraftService entityTaskModelDraftService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_71a41ac2fa884d27b721ae0509586eea != 0)
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
				this.entityTaskModelDraftService = entityTaskModelDraftService;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void OnPostUpdate(PostUpdateEvent @event)
	{
		//Discarded unreachable code: IL_0094, IL_00a3, IL_0179, IL_0188, IL_029c
		int num = 15;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		TaskBaseStatus taskBaseStatus = default(TaskBaseStatus);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 15:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 14;
				break;
			case 4:
			case 7:
				if (!((EnumBase)oWW5PKRbrZX6VCVnE3x(_003C_003Ec__DisplayClass2_.workflowTask) != taskBaseStatus))
				{
					num2 = 12;
					break;
				}
				goto default;
			case 11:
				return;
			case 2:
			{
				object array = CfZZSuR8olK6qhQHlyR(((AbstractPostDatabaseOperationEvent)@event).get_Persister());
				ParameterExpression parameterExpression = (ParameterExpression)ewo778RlPp7xCHhe7hQ(sSg6CvRs0bPUif8T6j9(typeof(ITaskBase).TypeHandle), jbxYU9RJPm1b6cjuefm(-261315199 ^ -261350573));
				num3 = Array.IndexOf((string[])array, LinqUtils.NameOf(Expression.Lambda<Func<ITaskBase, object>>((Expression)IpQC4eRyjnttAs5MV4O(parameterExpression, (MethodInfo)Wq7Vt8R0OOMOKQFT0Gx((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				num2 = 13;
				break;
			}
			case 9:
				if (E5ilhQRZ9V2c6FVOYcS(_003C_003Ec__DisplayClass2_.workflowTask) == null)
				{
					num2 = 11;
					break;
				}
				goto case 6;
			case 5:
				if (On6hTuRtwAHIIxPFf0D(_003C_003Ec__DisplayClass2_.workflowTask.Status, TaskBaseStatus.Complete))
				{
					num2 = 4;
					break;
				}
				goto case 8;
			case 1:
				return;
			case 12:
				return;
			case 14:
				_003C_003Ec__DisplayClass2_.workflowTask = DdgJIgROmbjZUgIlwl3(@event) as IWorkflowTaskBase;
				num2 = 10;
				break;
			case 6:
				if (!(((IEnumerable<Element>)gljVaSRY7TIEie6kDJx(((IWorkflowProcess)ssx2ZYRvjSQXIhr0CHk(_003C_003Ec__DisplayClass2_.workflowTask.WorkflowBookmark.Instance)).Diagram)).FirstOrDefault(_003C_003Ec__DisplayClass2_._003COnPostUpdate_003Eb__0) is CatalogEditElement))
				{
					return;
				}
				num2 = 2;
				break;
			case 3:
				taskBaseStatus = ((object[])ieekFHRm4UQSL9PPNie(@event))[num3] as TaskBaseStatus;
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
				{
					num2 = 5;
				}
				break;
			default:
				ClearDraftInfo(_003C_003Ec__DisplayClass2_.workflowTask);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_938c6be4ea2248868d7ed5d0e3346006 != 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				if (!On6hTuRtwAHIIxPFf0D(oWW5PKRbrZX6VCVnE3x(_003C_003Ec__DisplayClass2_.workflowTask), TaskBaseStatus.WasClosed))
				{
					return;
				}
				num2 = 5;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
				{
					num2 = 7;
				}
				break;
			case 13:
				if (num3 <= 0)
				{
					return;
				}
				num2 = 3;
				break;
			case 10:
				if (_003C_003Ec__DisplayClass2_.workflowTask == null)
				{
					return;
				}
				num2 = 6;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bae4e393cddc4c98b9896b25c9e18c7d == 0)
				{
					num2 = 9;
				}
				break;
			}
		}
	}

	public override void OnPostDelete(PostDeleteEvent @event)
	{
		//Discarded unreachable code: IL_0082, IL_0091, IL_00a1, IL_00b0
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			default:
				if (_003C_003Ec__DisplayClass3_.workflowTask == null)
				{
					num2 = 6;
					break;
				}
				goto case 5;
			case 4:
				ClearDraftInfo(_003C_003Ec__DisplayClass3_.workflowTask);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a23e27b648a042f098a477c26c4beed1 != 0)
				{
					num2 = 3;
				}
				break;
			case 7:
				return;
			case 6:
				return;
			case 1:
				_003C_003Ec__DisplayClass3_.workflowTask = DdgJIgROmbjZUgIlwl3(@event) as IWorkflowTaskBase;
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (E5ilhQRZ9V2c6FVOYcS(_003C_003Ec__DisplayClass3_.workflowTask) != null)
				{
					num2 = 8;
					break;
				}
				return;
			case 3:
				return;
			case 2:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
				{
					num2 = 1;
				}
				break;
			case 8:
				if (!(((IEnumerable<Element>)gljVaSRY7TIEie6kDJx(SV7LoRR54YpK09T965j(((IWorkflowBookmark)E5ilhQRZ9V2c6FVOYcS(_003C_003Ec__DisplayClass3_.workflowTask)).Instance.Process))).FirstOrDefault(_003C_003Ec__DisplayClass3_._003COnPostDelete_003Eb__0) is CatalogEditElement))
				{
					num2 = 7;
					break;
				}
				goto case 4;
			}
		}
	}

	private void ClearDraftInfo(IWorkflowTaskBase task)
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
				LfEaeLRgbjZR16UW51o(entityTaskModelDraftService, task.Id);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool s2ClWnjzMdU0VUwr22a()
	{
		return AH3R7qj4ccwR7VTDsJ5 == null;
	}

	internal static WorkflowCatalogOperationsListener ys8xASRKuFPxuqWH0ww()
	{
		return AH3R7qj4ccwR7VTDsJ5;
	}

	internal static object DdgJIgROmbjZUgIlwl3(object P_0)
	{
		return ((AbstractPostDatabaseOperationEvent)P_0).get_Entity();
	}

	internal static object E5ilhQRZ9V2c6FVOYcS(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object ssx2ZYRvjSQXIhr0CHk(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object gljVaSRY7TIEie6kDJx(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static object CfZZSuR8olK6qhQHlyR(object P_0)
	{
		return ((IEntityPersister)P_0).get_PropertyNames();
	}

	internal static Type sSg6CvRs0bPUif8T6j9(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object jbxYU9RJPm1b6cjuefm(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ewo778RlPp7xCHhe7hQ(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object Wq7Vt8R0OOMOKQFT0Gx(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object IpQC4eRyjnttAs5MV4O(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object ieekFHRm4UQSL9PPNie(object P_0)
	{
		return ((PostUpdateEvent)P_0).get_OldState();
	}

	internal static bool On6hTuRtwAHIIxPFf0D(object P_0, object P_1)
	{
		return (EnumBase)P_0 == (EnumBase)P_1;
	}

	internal static object oWW5PKRbrZX6VCVnE3x(object P_0)
	{
		return ((ITaskBase)P_0).Status;
	}

	internal static object SV7LoRR54YpK09T965j(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static void LfEaeLRgbjZR16UW51o(object P_0, long P_1)
	{
		((IEntityTaskModelDraftService)P_0).RemoveStates(P_1);
	}
}
