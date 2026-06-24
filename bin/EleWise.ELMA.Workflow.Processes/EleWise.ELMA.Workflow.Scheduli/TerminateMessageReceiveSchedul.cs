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
public class TerminateMessageReceiveSchedulerJobExecutor : WorkflowInstanceSchedulerJobExecutor<ITerminateMessageReceiveSchedulerJob>
{
	internal static TerminateMessageReceiveSchedulerJobExecutor U6Y5CYwoDI1DcTYDbEC;

	protected override bool NoSaveResult => true;

	protected override IWorkflowBookmark GetBookmark(ITerminateMessageReceiveSchedulerJob job)
	{
		//Discarded unreachable code: IL_0056
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (sfJCHHw88yBSeH8oZfU(job) != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_bf7c4b70954d454aa91550540c3daabc != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				return null;
			default:
				return ((IWorkflowMessageBookmark)sfJCHHw88yBSeH8oZfU(job)).Bookmark;
			case 2:
				oM19VJwF33SVMb2sTOH(job, Y7QQeRwxtxUyx9h8PoT(-1737696342 ^ -1737694772));
				num2 = 1;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_405af183be2449cfa4440c68827d6de9 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override IWorkflowExecuteData CreateData(ITerminateMessageReceiveSchedulerJob job, IWorkflowBookmark bookmark, DateTime dateToRun)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				oM19VJwF33SVMb2sTOH(job, Y7QQeRwxtxUyx9h8PoT(0xB863F17 ^ 0xB860571));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7b098b7bc47e4d38a5b2691cab1a4e36 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				oM19VJwF33SVMb2sTOH(sfJCHHw88yBSeH8oZfU(job), SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31D4A123 ^ 0x31D49B53));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_7f79a06dec5f490c93fd11725200b9b3 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new WorkflowMessageReceviesTerminateData((IWorkflowBookmark)q51egSwwySGTP3HCt3J(sfJCHHw88yBSeH8oZfU(job)), job.ConnectorUid.Value, (IWorkflowMessageBookmark)sfJCHHw88yBSeH8oZfU(job));
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
				ParameterExpression parameterExpression = (ParameterExpression)nHPbCBwsgcvvyeyJ4Qi(ifvNl1wtn3ydwhCX3Ed(typeof(ITerminateMessageReceiveSchedulerJob).TypeHandle), Y7QQeRwxtxUyx9h8PoT(-361150192 ^ -361139318));
				object obj = eYMZc2wqITpcHWkqc4f(criteria, LinqUtils.NameOf(Expression.Lambda<Func<ITerminateMessageReceiveSchedulerJob, object>>(Expression.Property(parameterExpression, (MethodInfo)bjRm2Pw2JiQl4LA7rWJ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })), Y7QQeRwxtxUyx9h8PoT(0x60E50EF5 ^ 0x60E53455));
				object obj2 = Y7QQeRwxtxUyx9h8PoT(0x747C4140 ^ 0x747C7BE8);
				parameterExpression = (ParameterExpression)nHPbCBwsgcvvyeyJ4Qi(ifvNl1wtn3ydwhCX3Ed(typeof(IWorkflowMessageBookmark).TypeHandle), Y7QQeRwxtxUyx9h8PoT(0x4E58FEAF ^ 0x4E58C435));
				object obj3 = eYMZc2wqITpcHWkqc4f(obj, vmxaXlwVICP82YAWg7f(obj2, LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowMessageBookmark, object>>((Expression)EgZGZTwQloUxlwQODd6(parameterExpression, (MethodInfo)bjRm2Pw2JiQl4LA7rWJ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }))), Y7QQeRwxtxUyx9h8PoT(0x27475F40 ^ 0x274765F2));
				object obj4 = Y7QQeRwxtxUyx9h8PoT(-1843608060 ^ -1843594050);
				parameterExpression = Expression.Parameter(ifvNl1wtn3ydwhCX3Ed(typeof(IWorkflowBookmark).TypeHandle), (string)Y7QQeRwxtxUyx9h8PoT(0x624F2FBE ^ 0x624F150C));
				object obj5 = vmxaXlwVICP82YAWg7f(obj4, LinqUtils.NameOf(Expression.Lambda<Func<IWorkflowBookmark, object>>(Expression.Property(parameterExpression, (MethodInfo)bjRm2Pw2JiQl4LA7rWJ((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression })));
				object[] array = new IWorkflowInstance[1] { instance };
				S3YGqmwKeHN2hsYLbbQ(obj3, BupxDkwDWPwrLdZjPCM(obj5, array));
				num2 = 0;
				if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_6ee07aa726964a2281f0ce81cd001aec != 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	protected override void DeleteJob(ITerminateMessageReceiveSchedulerJob job)
	{
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					n0Y0vXwMvDiY6qM9gEl(sfJCHHw88yBSeH8oZfU(job), WorkflowMessageBookmarkStatus.Terminated);
					num2 = 1;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_13af7ecdfdd3466b80333112ab4ca5a5 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					break;
				case 4:
					oM19VJwF33SVMb2sTOH(job, Y7QQeRwxtxUyx9h8PoT(0x3907FE5 ^ 0x3904583));
					num2 = 3;
					if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_4d66b27a693d4e1f9d801c17731a3049 == 0)
					{
						num2 = 3;
					}
					continue;
				case 2:
					return;
				case 3:
					if (sfJCHHw88yBSeH8oZfU(job) != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_8ed00be219534188ad23e215449e3f62 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				}
				break;
			}
			base.DeleteJob(job);
			num = 2;
		}
	}

	protected override string GetSuccessMessage()
	{
		return (string)tV8subwan6EZBYgf3nZ(Y7QQeRwxtxUyx9h8PoT(-465190147 ^ -465176519));
	}

	public TerminateMessageReceiveSchedulerJobExecutor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.reZueBLff7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B9f911add_002Dfdfb_002D4313_002Da371_002D5ae1149c9262_007D.m_91adcac8aa2043159a205c4a9f0e85fa != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object Y7QQeRwxtxUyx9h8PoT(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void oM19VJwF33SVMb2sTOH(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object sfJCHHw88yBSeH8oZfU(object P_0)
	{
		return ((ITerminateMessageReceiveSchedulerJob)P_0).MessageBookmark;
	}

	internal static bool S2I6GTw3tLKOLdecxXd()
	{
		return U6Y5CYwoDI1DcTYDbEC == null;
	}

	internal static TerminateMessageReceiveSchedulerJobExecutor Fo1OxpwhgJeJQAvVaEW()
	{
		return U6Y5CYwoDI1DcTYDbEC;
	}

	internal static object q51egSwwySGTP3HCt3J(object P_0)
	{
		return ((IWorkflowMessageBookmark)P_0).Bookmark;
	}

	internal static Type ifvNl1wtn3ydwhCX3Ed(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object nHPbCBwsgcvvyeyJ4Qi(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object bjRm2Pw2JiQl4LA7rWJ(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}

	internal static object eYMZc2wqITpcHWkqc4f(object P_0, object P_1, object P_2)
	{
		return ((ICriteria)P_0).CreateAlias((string)P_1, (string)P_2);
	}

	internal static object EgZGZTwQloUxlwQODd6(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static object vmxaXlwVICP82YAWg7f(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object BupxDkwDWPwrLdZjPCM(object P_0, object P_1)
	{
		return Restrictions.In((string)P_0, (object[])P_1);
	}

	internal static object S3YGqmwKeHN2hsYLbbQ(object P_0, object P_1)
	{
		return ((ICriteria)P_0).Add((ICriterion)P_1);
	}

	internal static void n0Y0vXwMvDiY6qM9gEl(object P_0, WorkflowMessageBookmarkStatus value)
	{
		((IWorkflowMessageBookmark)P_0).Status = value;
	}

	internal static object tV8subwan6EZBYgf3nZ(object P_0)
	{
		return SR.T((string)P_0);
	}
}
