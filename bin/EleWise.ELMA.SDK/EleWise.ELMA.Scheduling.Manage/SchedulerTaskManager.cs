using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Scheduling.Impl;
using EleWise.ELMA.Scheduling.Models;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.SqlCommand;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Scheduling.Managers;

[DeveloperApi(DeveloperApiType.Manager)]
public class SchedulerTaskManager : EntityManager<ISchedulerTask, long>, ISchedulerTaskManager, IEntityManager<ISchedulerTask, long>, IEntityManager<ISchedulerTask>, IEntityManager
{
	private static readonly string F_Status;

	private static readonly string F_Jobs;

	private static readonly string F_Type;

	private static readonly string F_OnceExecuteTime;

	private static readonly string F_StatusUpdateDate;

	private static SchedulerTaskManager cAg3cEBkhZbqHrFft44x;

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
				case 0:
					return;
				case 1:
					_003CRuntimeApplication_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

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
				case 0:
					return;
				case 1:
					_003CTransformationProvider_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public SchedulerTaskJobManager SchedulerTaskJobManager
	{
		[CompilerGenerated]
		get
		{
			return _003CSchedulerTaskJobManager_003Ek__BackingField;
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
					_003CSchedulerTaskJobManager_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IEnumerable<ISchedulerTask> FindTasksToExecute()
	{
		return SelectModeExtensions.Fetch(CreateCriteria().Add((ICriterion)(object)Restrictions.Eq(F_Status, (object)SchedulerTaskStatus.Enabled)).Add((ICriterion)(object)Restrictions.Or((ICriterion)(object)Restrictions.Eq(F_Type, (object)SchedulerTaskType.Periodic), (ICriterion)(object)Restrictions.And((ICriterion)(object)Restrictions.Eq(F_Type, (object)SchedulerTaskType.Once), (ICriterion)(object)Restrictions.Le(F_OnceExecuteTime, (object)DateTime.Now)))), (SelectMode)1, F_Jobs, (string)null).List<ISchedulerTask>();
	}

	public IEnumerable<ISchedulerTask> FindPeriodicTasksToExecute()
	{
		return SelectModeExtensions.Fetch(CreateCriteria().Add((ICriterion)(object)Restrictions.Eq(F_Status, (object)SchedulerTaskStatus.Enabled)).Add((ICriterion)(object)Restrictions.Eq(F_Type, (object)SchedulerTaskType.Periodic)), (SelectMode)1, F_Jobs, (string)null).List<ISchedulerTask>();
	}

	public IEnumerable<ISchedulerTask> FindOnceExecuteTasksToExecute()
	{
		int processingOnceTasksCount = GetProcessingOnceTasksCount();
		if (processingOnceTasksCount <= 0)
		{
			return new ISchedulerTask[0];
		}
		DetachedCriteria val = DetachedCriteria.For(InterfaceActivator.TypeOf<ISchedulerJobRunInfo>(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420816478)).SetProjection((IProjection)(object)Projections.Property(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672064597))).CreateAlias(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x92F12D5 ^ 0x92E3C77), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822832466), (JoinType)0)
			.Add((ICriterion)(object)Restrictions.EqProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -98025750), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638475555)))
			.Add((ICriterion)(object)Restrictions.Gt(F_StatusUpdateDate, (object)DateTime.Now.Subtract(SchedulerJobRunInfoManager.GetJobRunInfoTtl())));
		IEnumerable<Guid> activeConnectionUids = RuntimeApplication.GetActiveConnectionUids();
		if (activeConnectionUids.Any())
		{
			val.Add((ICriterion)(object)Restrictions.In(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C95BB6E), (ICollection)activeConnectionUids.ToArray()));
		}
		ICriteria val2 = SelectModeExtensions.Fetch(base.Session.CreateCriteria(base.ImplementationType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112644204)).Add((ICriterion)(object)Restrictions.Eq(F_Status, (object)SchedulerTaskStatus.Enabled)).Add((ICriterion)(object)Restrictions.Eq(F_Type, (object)SchedulerTaskType.Once))
			.Add((ICriterion)(object)Restrictions.Le(F_OnceExecuteTime, (object)DateTime.Now))
			.Add((ICriterion)(object)Subqueries.NotExists(val)), (SelectMode)1, F_Jobs, (string)null);
		SetupFetchOptions(val2, new FetchOptions(0, processingOnceTasksCount), base.ImplementationType);
		return val2.List<ISchedulerTask>();
	}

	public void ExecuteTask(ISchedulerTask task)
	{
		//Discarded unreachable code: IL_006e, IL_007d
		int num = 3;
		int num2 = num;
		ISchedulerJob schedulerJob = default(ISchedulerJob);
		DateTime dateTime = default(DateTime);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return;
			default:
				throw new InvalidOperationException(SR.T((string)qCnQkABkfaGcMg5Apaub(-281842504 ^ -281918542)));
			case 1:
				Locator.GetServiceNotNull<StepScheduler>().RunSchedulerJob(schedulerJob, dateTime);
				num2 = 5;
				break;
			case 2:
			{
				SchedulerJobRepository serviceNotNull = Locator.GetServiceNotNull<SchedulerJobRepository>();
				dateTime = BakRlfBkCOR0ew5TWLPL();
				schedulerJob = serviceNotNull.CreateSchedulerJob(task, dateTime);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 4;
				}
				break;
			}
			case 3:
				lL5stWBkQDs5rGmXAvu0(task, qCnQkABkfaGcMg5Apaub(0x4785BC0D ^ 0x4784A7FB));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				if (schedulerJob != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	[Transaction]
	public virtual void DeleteTaskAndJobs(ISchedulerTask task, IEnumerable<long> excludeJobs)
	{
		Contract.ArgumentNotNull(task, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099688287));
		ISession session = base.SessionProvider.GetSession("");
		session.Flush();
		SchedulerTaskJobManager.DeleteJobs(((IEnumerable<ISchedulerTaskJob>)task.Jobs).Select((ISchedulerTaskJob j) => j.Id).Except(excludeJobs ?? new long[0]).ToArray());
		string text = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A8096D6), TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345480600)), TransformationProvider.Dialect.QuoteIfNeeded(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3630723F)));
		((IQuery)session.CreateSQLQuery(text)).SetParameter<long>(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87393347), task.Id).ExecuteUpdate(cleanUpCache: false);
		session.CleanUpCache(typeof(ISchedulerTask));
	}

	private int GetProcessingOnceTasksCount()
	{
		int num = 2;
		int num2 = num;
		int setting = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				setting = SR.GetSetting((string)qCnQkABkfaGcMg5Apaub(0x20261A4F ^ 0x20273595), 10);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				if (setting <= 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 0;
					}
					break;
				}
				return setting;
			default:
				return 10;
			}
		}
	}

	public SchedulerTaskManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static SchedulerTaskManager()
	{
		int num = 10;
		ParameterExpression parameterExpression = default(ParameterExpression);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					parameterExpression = (ParameterExpression)Sg5bkdBk85N8NOLsqgvX(PlKJkkBkuvvgkXFvwEo2(typeof(ISchedulerTask).TypeHandle), qCnQkABkfaGcMg5Apaub(-87337865 ^ -87318041));
					num2 = 3;
					continue;
				case 4:
					break;
				default:
					parameterExpression = (ParameterExpression)Sg5bkdBk85N8NOLsqgvX(typeof(ISchedulerTask), qCnQkABkfaGcMg5Apaub(0x7C1EE318 ^ 0x7C1E1688));
					num2 = 7;
					continue;
				case 2:
					return;
				case 3:
					F_Type = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerTask, object>>((Expression)wD9TUkBkILpqsA3a83DX(Expression.Property(parameterExpression, (MethodInfo)CR7KevBkVy3XA3q2Px6e((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), PlKJkkBkuvvgkXFvwEo2(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					F_OnceExecuteTime = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerTask, object>>((Expression)wD9TUkBkILpqsA3a83DX(ERmyIKBkZObuC3XGcP5U(parameterExpression, (MethodInfo)CR7KevBkVy3XA3q2Px6e((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), typeof(object)), new ParameterExpression[1] { parameterExpression }));
					num2 = 4;
					continue;
				case 6:
					F_StatusUpdateDate = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerJobRunInfo, object>>(Expression.Convert(Expression.Property(parameterExpression, (MethodInfo)CR7KevBkVy3XA3q2Px6e((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), PlKJkkBkuvvgkXFvwEo2(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					parameterExpression = (ParameterExpression)Sg5bkdBk85N8NOLsqgvX(typeof(ISchedulerTask), qCnQkABkfaGcMg5Apaub(-1858887263 ^ -1858907087));
					num2 = 11;
					continue;
				case 8:
					F_Status = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerTask, object>>((Expression)wD9TUkBkILpqsA3a83DX(ERmyIKBkZObuC3XGcP5U(parameterExpression, (MethodInfo)MethodBase.GetMethodFromHandle((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), PlKJkkBkuvvgkXFvwEo2(typeof(object).TypeHandle)), new ParameterExpression[1] { parameterExpression }));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					ypp23MBkvTwPVWZE50Ya();
					num2 = 9;
					continue;
				case 9:
					parameterExpression = (ParameterExpression)Sg5bkdBk85N8NOLsqgvX(typeof(ISchedulerTask), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -137956241));
					num2 = 8;
					continue;
				case 11:
					F_Jobs = LinqUtils.NameOf(Expression.Lambda<Func<ISchedulerTask, object>>(Expression.Property(parameterExpression, (MethodInfo)CR7KevBkVy3XA3q2Px6e((RuntimeMethodHandle)/*OpCode not supported: LdMemberToken*/)), new ParameterExpression[1] { parameterExpression }));
					num2 = 5;
					continue;
				}
				break;
			}
			parameterExpression = (ParameterExpression)Sg5bkdBk85N8NOLsqgvX(PlKJkkBkuvvgkXFvwEo2(typeof(ISchedulerJobRunInfo).TypeHandle), qCnQkABkfaGcMg5Apaub(--1418440330 ^ 0x548B5B1A));
			num = 6;
		}
	}

	internal static bool UAmujhBkG7CPNhNRPQ7i()
	{
		return cAg3cEBkhZbqHrFft44x == null;
	}

	internal static SchedulerTaskManager DZZtaIBkEBgBqT8Hb6Nx()
	{
		return cAg3cEBkhZbqHrFft44x;
	}

	internal static object qCnQkABkfaGcMg5Apaub(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void lL5stWBkQDs5rGmXAvu0(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static DateTime BakRlfBkCOR0ew5TWLPL()
	{
		return DateTime.Now;
	}

	internal static void ypp23MBkvTwPVWZE50Ya()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object Sg5bkdBk85N8NOLsqgvX(Type P_0, object P_1)
	{
		return Expression.Parameter(P_0, (string)P_1);
	}

	internal static object ERmyIKBkZObuC3XGcP5U(object P_0, object P_1)
	{
		return Expression.Property((Expression)P_0, (MethodInfo)P_1);
	}

	internal static Type PlKJkkBkuvvgkXFvwEo2(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object wD9TUkBkILpqsA3a83DX(object P_0, Type P_1)
	{
		return Expression.Convert((Expression)P_0, P_1);
	}

	internal static object CR7KevBkVy3XA3q2Px6e(RuntimeMethodHandle P_0)
	{
		return MethodBase.GetMethodFromHandle(P_0);
	}
}
