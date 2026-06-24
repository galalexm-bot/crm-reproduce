using System;
using System.Collections.Concurrent;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.AOP;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.NH;

internal sealed class TransactionInterceptor : AbstractAsyncInterceptor
{
	private static readonly ConcurrentDictionary<MethodInfo, TransactionAttribute> AttributesCache;

	private readonly ILazy<IUnitOfWorkManagerAsync> unitOfWorkManager;

	internal static TransactionInterceptor ihGtuhWHQGVkDUQpFKEE;

	public TransactionInterceptor(ILazy<IUnitOfWorkManagerAsync> unitOfWorkManager)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.unitOfWorkManager = unitOfWorkManager;
	}

	[DebuggerHidden]
	public override void Intercept(IInvocation invocation)
	{
		//Discarded unreachable code: IL_012c, IL_015e, IL_0197, IL_01a6, IL_01b1, IL_020e, IL_024e, IL_025d, IL_0269
		int num = 3;
		TransactionAttribute orAdd = default(TransactionAttribute);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		IUnitOfWork unitOfWork = default(IUnitOfWork);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					orAdd = AttributesCache.GetOrAdd((MethodInfo)FJ9syFWH81oMQZpaP2q9(_003C_003Ec__DisplayClass3_.invocation), _003C_003Ec__DisplayClass3_._003CIntercept_003Eb__0);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 2;
					continue;
				case 5:
					return;
				case 2:
					break;
				case 1:
					if (orAdd != null)
					{
						unitOfWork = unitOfWorkManager.Value.Create(string.Empty, transactional: true, M67RqqWHuqx8n4KLYXGF(orAdd));
						num2 = 7;
						continue;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					e1tL0NWHZfNNsPdu1iEQ(_003C_003Ec__DisplayClass3_.invocation);
					num2 = 5;
					continue;
				case 6:
					return;
				case 7:
					try
					{
						try
						{
							e1tL0NWHZfNNsPdu1iEQ(_003C_003Ec__DisplayClass3_.invocation);
							int num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
							{
								num3 = 0;
							}
							switch (num3)
							{
							case 0:
								break;
							}
						}
						catch
						{
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									gxt34DWHI0KYEPSEPu2I(unitOfWork);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
									{
										num4 = 0;
									}
									break;
								default:
									throw;
								}
							}
						}
						while (true)
						{
							unitOfWork.Commit();
							int num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
							{
								num5 = 0;
							}
							switch (num5)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								break;
							}
						}
					}
					finally
					{
						int num6;
						if (unitOfWork == null)
						{
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
							{
								num6 = 0;
							}
							goto IL_0212;
						}
						goto IL_0228;
						IL_0228:
						iDIjNPWHV6bRvb33i8MS(unitOfWork);
						num6 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num6 = 2;
						}
						goto IL_0212;
						IL_0212:
						switch (num6)
						{
						default:
							goto end_IL_01ed;
						case 1:
							break;
						case 0:
							goto end_IL_01ed;
						case 2:
							goto end_IL_01ed;
						}
						goto IL_0228;
						end_IL_01ed:;
					}
				}
				break;
			}
			_003C_003Ec__DisplayClass3_.invocation = invocation;
			num = 4;
		}
	}

	[AsyncStateMachine(typeof(_003CInterceptAsync_003Ed__4))]
	[DebuggerHidden]
	public override Task InterceptAsync(IInvocationAsync invocation, CancellationToken cancellationToken)
	{
		int num = 6;
		int num2 = num;
		_003CInterceptAsync_003Ed__4 stateMachine = default(_003CInterceptAsync_003Ed__4);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 5:
				stateMachine.invocation = invocation;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 3;
				}
				break;
			case 2:
				return stateMachine._003C_003Et__builder.Task;
			case 4:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 2;
				break;
			case 3:
				stateMachine.cancellationToken = cancellationToken;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 7;
				}
				break;
			case 7:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 4;
				break;
			default:
				stateMachine._003C_003Et__builder = xDvZlfWHSpdaFTIYZNw6();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				stateMachine._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 5;
				}
				break;
			}
		}
	}

	static TransactionInterceptor()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				BqdlUOWHiRKEYGvvucKe();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				AttributesCache = new ConcurrentDictionary<MethodInfo, TransactionAttribute>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object FJ9syFWH81oMQZpaP2q9(object P_0)
	{
		return ((IInvocation)P_0).get_Method();
	}

	internal static void e1tL0NWHZfNNsPdu1iEQ(object P_0)
	{
		((IInvocation)P_0).Proceed();
	}

	internal static IsolationLevel M67RqqWHuqx8n4KLYXGF(object P_0)
	{
		return ((TransactionAttribute)P_0).IsolationLevel;
	}

	internal static void gxt34DWHI0KYEPSEPu2I(object P_0)
	{
		((IUnitOfWork)P_0).Rollback();
	}

	internal static void iDIjNPWHV6bRvb33i8MS(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool eEZNWFWHCPmSsZQnvc73()
	{
		return ihGtuhWHQGVkDUQpFKEE == null;
	}

	internal static TransactionInterceptor kGUfAPWHvjQsuYSNSbnu()
	{
		return ihGtuhWHQGVkDUQpFKEE;
	}

	internal static AsyncTaskMethodBuilder xDvZlfWHSpdaFTIYZNw6()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static void BqdlUOWHiRKEYGvvucKe()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
