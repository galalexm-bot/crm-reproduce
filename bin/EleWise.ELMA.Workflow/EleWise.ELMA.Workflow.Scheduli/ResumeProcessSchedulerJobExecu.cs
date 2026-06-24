using System;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Scheduling;

[Component]
public class ResumeProcessSchedulerJobExecutor : WorkflowInstanceSchedulerJobExecutor<IResumeProcessSchedulerJob>
{
	private static ResumeProcessSchedulerJobExecutor iGW4yktnEwMI5fu9OSl;

	protected override IWorkflowBookmark GetBookmark(IResumeProcessSchedulerJob job)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (IWorkflowBookmark)gtm7bot9U3NVBZTJ9ph(job);
			case 1:
				Hukf9Itf7YuvalnmL0R(job, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1539486135 ^ -1539503593));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override IWorkflowExecuteData CreateData(IResumeProcessSchedulerJob job, IWorkflowBookmark bookmark, DateTime dateToRun)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return new WorkflowTimerResumeData(job);
			case 1:
				Hukf9Itf7YuvalnmL0R(job, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1386448964 ^ -1386466334));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override AbstractCriterion CriteriaByOnceExecuteStatus()
	{
		object obj = H9LnuXtWM2YCW89yFJT(this);
		ParameterExpression parameterExpression = (ParameterExpression)KoFxU5tjRAmkSvElHqc(typeof(IResumeProcessSchedulerJob), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1050383744 ^ -1050399080));
		return Restrictions.Or((ICriterion)obj, (ICriterion)hmDjMCt340Ps5hdrHq0(LinqUtils.NameOf(Expression.Lambda<Func<IResumeProcessSchedulerJob, object>>(Expression.Convert((Expression)tgGoJTt6Zk2Ys0kcpNI(parameterExpression, (MethodInfo)p0QeKFtRGaqgX3mH2UI((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), cmKNEUtqeph9irWAY27(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression })), JobStatus.Fail));
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
				ParameterExpression parameterExpression = (ParameterExpression)KoFxU5tjRAmkSvElHqc(cmKNEUtqeph9irWAY27(typeof(IResumeProcessSchedulerJob).TypeHandle), Wj8olJtTqNJ2U1trXsf(-495296780 ^ -495314196));
				object obj = hQbEo6tQgBNyYAFEhjc(criteria, LinqUtils.NameOf(Expression.Lambda<Func<IResumeProcessSchedulerJob, object>>(Expression.Property(parameterExpression, (MethodInfo)p0QeKFtRGaqgX3mH2UI((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })), Wj8olJtTqNJ2U1trXsf(0x17F0C5A2 ^ 0x17F081CA));
				object obj2 = Wj8olJtTqNJ2U1trXsf(-862330810 ^ -862346186);
				parameterExpression = (ParameterExpression)KoFxU5tjRAmkSvElHqc(cmKNEUtqeph9irWAY27(typeof(IWorkflowBookmark).TypeHandle), Wj8olJtTqNJ2U1trXsf(-1108877388 ^ -1108894756));
				object obj3 = UMEOBCtpA2CusOKihxJ(obj2, LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowBookmark, object>>((Expression)tgGoJTt6Zk2Ys0kcpNI(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				object[] array = new IWorkflowInstance[1] { instance };
				Ij9FkjtMeyePUuGnZQt(obj, n7VhKAtCGopmkhhQYUX(obj3, array));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d7a51cf2841b436998bf3f4157fb2c9a != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public ResumeProcessSchedulerJobExecutor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tV0ZDTtkj6cjqn21sZ2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void Hukf9Itf7YuvalnmL0R(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object gtm7bot9U3NVBZTJ9ph(object P_0)
	{
		return ((IResumeProcessSchedulerJob)P_0).WorkflowBookmark;
	}

	internal static bool W6bRPLtHx8ts0YxTiVZ()
	{
		return iGW4yktnEwMI5fu9OSl == null;
	}

	internal static ResumeProcessSchedulerJobExecutor LBFRDCtLlGIGrswm4iX()
	{
		return iGW4yktnEwMI5fu9OSl;
	}

	internal static object H9LnuXtWM2YCW89yFJT(object P_0)
	{
		return ((WorkflowInstanceSchedulerJobExecutor<IResumeProcessSchedulerJob>)P_0).CriteriaByOnceExecuteStatus();
	}

	internal static object KoFxU5tjRAmkSvElHqc(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object p0QeKFtRGaqgX3mH2UI(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object tgGoJTt6Zk2Ys0kcpNI(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static Type cmKNEUtqeph9irWAY27(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object hmDjMCt340Ps5hdrHq0(object P_0, object P_1)
	{
		return Restrictions.Eq((string)P_0, P_1);
	}

	internal static object Wj8olJtTqNJ2U1trXsf(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object hQbEo6tQgBNyYAFEhjc(object P_0, object P_1, object P_2)
	{
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2);
	}

	internal static object UMEOBCtpA2CusOKihxJ(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object n7VhKAtCGopmkhhQYUX(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (object[])P_1);
	}

	internal static object Ij9FkjtMeyePUuGnZQt(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static void tV0ZDTtkj6cjqn21sZ2()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
