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
public class TerminateTaskSchedulerJobExecutor : WorkflowInstanceSchedulerJobExecutor<ITerminateTaskSchedulerJob>
{
	private static TerminateTaskSchedulerJobExecutor dgNFvObJ9vmMKMBxI8G;

	protected override bool NoSaveResult => true;

	protected override IWorkflowBookmark GetBookmark(ITerminateTaskSchedulerJob job)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(job, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418337216 ^ 0x548A5F9E));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_eb7de45300244c968ac00be3ffdf3d29 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return job.WorkflowBookmark;
			}
		}
	}

	protected override IWorkflowExecuteData CreateData(ITerminateTaskSchedulerJob job, IWorkflowBookmark bookmark, DateTime dateToRun)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				k2t2mUbmnAGAn9LQk8m(job, Px8u4Eby9IrlIToavf6(-14356676 ^ -14374046));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new WorkflowTaskTerminateData((IWorkflowBookmark)rrSY4QbtBNc8owa3Jhw(job), E38SJJbbYSCAF1PxeLA(job));
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
			case 1:
			{
				ParameterExpression parameterExpression = (ParameterExpression)txROBPbgK9jmJLTIATW(lvh40Ab5Nj2sZ8TV8CU(typeof(ITerminateTaskSchedulerJob).TypeHandle), Px8u4Eby9IrlIToavf6(-398691253 ^ -398708653));
				object obj = snGJvrbPrTTLbHdaQHg(criteria, LinqUtils.NameOf(Expression.Lambda<Func<ITerminateTaskSchedulerJob, object>>((Expression)GFH211bcTigebCoW58y(parameterExpression, (MethodInfo)OIIwf9bBXQlgHYyAqUO((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })), Px8u4Eby9IrlIToavf6(-790221436 ^ -790205972));
				object obj2 = Px8u4Eby9IrlIToavf6(0x1AF6F1F2 ^ 0x1AF6B582);
				parameterExpression = Expression.Parameter(lvh40Ab5Nj2sZ8TV8CU(typeof(IWorkflowBookmark).TypeHandle), (string)Px8u4Eby9IrlIToavf6(-935313063 ^ -935328463));
				object obj3 = pMKydbbXywmbsm0kG5D(obj2, LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowBookmark, object>>((Expression)GFH211bcTigebCoW58y(parameterExpression, (MethodInfo)OIIwf9bBXQlgHYyAqUO((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				object[] array = new IWorkflowInstance[1] { instance };
				((ICriteria)obj).Add((ICriterion)cBfoBTbdPXHDsTnjk0j(obj3, array));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	protected override string GetSuccessMessage()
	{
		return SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x628167BE ^ 0x62812256));
	}

	public TerminateTaskSchedulerJobExecutor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		jqkpPYbuoiPOetqGGuE();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ba57b850b1d34fd9bce66a583e71dc16 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool yyHgurblemRgIkcKLlF()
	{
		return dgNFvObJ9vmMKMBxI8G == null;
	}

	internal static TerminateTaskSchedulerJobExecutor G9uR00b0kvR9KyIsmot()
	{
		return dgNFvObJ9vmMKMBxI8G;
	}

	internal static object Px8u4Eby9IrlIToavf6(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void k2t2mUbmnAGAn9LQk8m(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object rrSY4QbtBNc8owa3Jhw(object P_0)
	{
		return ((ITerminateTaskSchedulerJob)P_0).WorkflowBookmark;
	}

	internal static Guid E38SJJbbYSCAF1PxeLA(object P_0)
	{
		return ((ITerminateTaskSchedulerJob)P_0).ConnectorUid;
	}

	internal static Type lvh40Ab5Nj2sZ8TV8CU(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object txROBPbgK9jmJLTIATW(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object OIIwf9bBXQlgHYyAqUO(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object GFH211bcTigebCoW58y(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object snGJvrbPrTTLbHdaQHg(object P_0, object P_1, object P_2)
	{
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2);
	}

	internal static object pMKydbbXywmbsm0kG5D(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object cBfoBTbdPXHDsTnjk0j(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (object[])P_1);
	}

	internal static void jqkpPYbuoiPOetqGGuE()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
