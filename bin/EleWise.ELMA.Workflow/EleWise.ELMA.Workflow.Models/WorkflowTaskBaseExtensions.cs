using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Security;
using EleWise.ELMA.Security.Services;
using EleWise.ELMA.Services;
using EleWise.ELMA.Tasks.Models;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements;
using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Models;

public static class WorkflowTaskBaseExtensions
{
	public enum ExecuteStatusEnum
	{
		Executing,
		Executed,
		Unknown,
		Error
	}

	private static Func<TaskBaseStatus[]> getOpenedStatusesInWorkflowInstanceCached;

	internal static WorkflowTaskBaseExtensions fBqK8CORlw8NbQ6tRxjA;

	public static TaskBaseStatus[] ActiveTaskStatuses => getOpenedStatusesInWorkflowInstanceCached();

	public static void Execute(this IWorkflowTaskBase task, Guid connectorUid)
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
				Locator.GetServiceNotNull<IWorkflowRuntimeService>().Execute(new WorkflowTaskExecuteData(task, connectorUid, AuthenticationService.GetCurrentUser<IUser>()));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f508947b0d94af1961e5aa17a8a2044 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static BPMNFlowElement GetElement(this IWorkflowTaskBase task)
	{
		//Discarded unreachable code: IL_003d, IL_004c
		int num = 5;
		int num2 = num;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (GBT7F5ORbZm6gvWIFeRQ(g5rfmXORtxiBKon3HyqP(_003C_003Ec__DisplayClass3_.task)) != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			default:
				return null;
			case 3:
				return (BPMNFlowElement)((IEnumerable<Element>)dbvhAUOR5NC385WNJgZB(_003C_003Ec__DisplayClass3_.task.WorkflowBookmark.Instance.Process.Diagram)).FirstOrDefault(_003C_003Ec__DisplayClass3_._003CGetElement_003Eb__0);
			case 1:
				if (_003C_003Ec__DisplayClass3_.task == null)
				{
					num2 = 2;
					break;
				}
				if (g5rfmXORtxiBKon3HyqP(_003C_003Ec__DisplayClass3_.task) != null)
				{
					num2 = 6;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			case 2:
				throw new ArgumentNullException((string)JCUNIPORmTNT7VyjH3ZQ(0x5F534A5C ^ 0x5F5307D6));
			case 4:
				_003C_003Ec__DisplayClass3_.task = task;
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 4;
				break;
			}
		}
	}

	private static TaskBaseStatus[] GetOpenedStatusesInWorkflowInstance()
	{
		return TaskBaseExtensions.ActiveTaskStatuses.Concat((IEnumerable<TaskBaseStatus>)OsP2tdORgB29JxvTZkKc()).ToArray();
	}

	static WorkflowTaskBaseExtensions()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				getOpenedStatusesInWorkflowInstanceCached = MetadataLoader.UseCachingForFunc(Expression.Lambda<Func<TaskBaseStatus[]>>((Expression)DpMPe9ORcMhBvxXP8Dh8(null, (MethodInfo)TvPBiEORBTLtNZhOCc9f((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/), Array.Empty<Expression>()), Array.Empty<ParameterExpression>()));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool YXMu9iOR0DcCA4Ma574Z()
	{
		return fBqK8CORlw8NbQ6tRxjA == null;
	}

	internal static WorkflowTaskBaseExtensions uu9padORyHpL338um1oH()
	{
		return fBqK8CORlw8NbQ6tRxjA;
	}

	internal static object JCUNIPORmTNT7VyjH3ZQ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object g5rfmXORtxiBKon3HyqP(object P_0)
	{
		return ((IWorkflowTaskBase)P_0).WorkflowBookmark;
	}

	internal static object GBT7F5ORbZm6gvWIFeRQ(object P_0)
	{
		return ((IWorkflowBookmark)P_0).Instance;
	}

	internal static object dbvhAUOR5NC385WNJgZB(object P_0)
	{
		return ((Diagram)P_0).Elements;
	}

	internal static object OsP2tdORgB29JxvTZkKc()
	{
		return TaskBaseExtensions.ControlStatuses;
	}

	internal static object TvPBiEORBTLtNZhOCc9f(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object DpMPe9ORcMhBvxXP8Dh8(object P_0, object P_1, object P_2)
	{
		return Expression.Call((Expression)P_0, (MethodInfo)P_1, (Expression[])P_2);
	}
}
