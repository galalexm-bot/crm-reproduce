using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Scheduling;

[Component]
public class TerminateExternalSubProcessSchedulerJobExecutor : WorkflowInstanceSchedulerJobExecutor<ITerminateExternalSubProcessShelulerJob>
{
	internal static TerminateExternalSubProcessSchedulerJobExecutor gkEujstSJZW8HNmdl2w;

	protected override bool NoSaveResult => true;

	protected override IWorkflowBookmark GetBookmark(ITerminateExternalSubProcessShelulerJob job)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(job, (string)HmhuittEanhM6OXu3nU(0x747FFBE0 ^ 0x747FBFBE));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return job.WorkflowBookmark;
			}
		}
	}

	protected override IWorkflowExecuteData CreateData(ITerminateExternalSubProcessShelulerJob job, IWorkflowBookmark bookmark, DateTime dateToRun)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(job, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--601115071 ^ 0x23D40DE1));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b876fa7b083748c8abf8c4b192a11078 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new WorkflowExternalSubProcessTerminateData(job.WorkflowBookmark, job.ConnectorUid.Value, (IWorkflowInstance)aJrCiHtwXrluFSUs9S9(job));
			}
		}
	}

	protected override void SetupFindActiveJobsCriteria(IWorkflowInstance instance, ICriteria criteria)
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
			{
				ParameterExpression parameterExpression = (ParameterExpression)tIgik5tzRfRrVQKTKkm(XQuT86t4JRm9UGqabn2(typeof(ITerminateExternalSubProcessShelulerJob).TypeHandle), HmhuittEanhM6OXu3nU(0x1843E01F ^ 0x1843A407));
				object obj = HcbiH9bKUCt4sFlIykA(criteria, LinqUtils.NameOf(Expression.Lambda<Func<ITerminateExternalSubProcessShelulerJob, object>>(Expression.Property(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })), HmhuittEanhM6OXu3nU(0x56F860D7 ^ 0x56F824BF));
				object obj2 = HmhuittEanhM6OXu3nU(-63028171 ^ -63045563);
				parameterExpression = Expression.Parameter(XQuT86t4JRm9UGqabn2(typeof(IWorkflowBookmark).TypeHandle), (string)HmhuittEanhM6OXu3nU(0xA7339EE ^ 0xA737D86));
				object obj3 = SKrNchbvamiQcklX1qp(obj2, LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowBookmark, object>>((Expression)ADBUEebZCSsKMOBgjDR(parameterExpression, (MethodInfo)VEDV54bO2IL3f1yYiw4((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				object[] array = new IWorkflowInstance[1] { instance };
				((ICriteria)obj).Add((ICriterion)wRZTRqbYGQi34YGgwDp(obj3, array));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	protected override string GetSuccessMessage()
	{
		return (string)TmAOWZb8fnLL9u2hokD(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF404852));
	}

	public TerminateExternalSubProcessSchedulerJobExecutor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		woghiMbslQSSi2rnN6a();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object HmhuittEanhM6OXu3nU(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool HJmda7t1Q2WnQqUfrIv()
	{
		return gkEujstSJZW8HNmdl2w == null;
	}

	internal static TerminateExternalSubProcessSchedulerJobExecutor mqd9cythW8tX90TdDwy()
	{
		return gkEujstSJZW8HNmdl2w;
	}

	internal static object aJrCiHtwXrluFSUs9S9(object P_0)
	{
		return ((ITerminateExternalSubProcessShelulerJob)P_0).subInstance;
	}

	internal static Type XQuT86t4JRm9UGqabn2(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object tIgik5tzRfRrVQKTKkm(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object HcbiH9bKUCt4sFlIykA(object P_0, object P_1, object P_2)
	{
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2);
	}

	internal static object VEDV54bO2IL3f1yYiw4(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object ADBUEebZCSsKMOBgjDR(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object SKrNchbvamiQcklX1qp(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object wRZTRqbYGQi34YGgwDp(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (object[])P_1);
	}

	internal static object TmAOWZb8fnLL9u2hokD(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void woghiMbslQSSi2rnN6a()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
