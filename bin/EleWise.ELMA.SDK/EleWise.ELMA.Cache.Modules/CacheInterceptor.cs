using System;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Runtime.AOP;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Cache.Modules;

public class CacheInterceptor : CacheInterceptorBase<CacheAttribute>
{
	private readonly ICacheService cacheService;

	internal static CacheInterceptor LFMGp2fKyxQwubqTcMW8;

	public CacheInterceptor(ICacheService cacheService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IIvFbOfK9hLsYoyjjABF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.cacheService = cacheService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
			{
				num = 1;
			}
		}
	}

	protected override void Invoke(IInvocation invocation, string cacheKey, string cacheRegion, CacheAttribute cacheAttribute)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_00b8, IL_00c7
		int num = 9;
		TimeSpan? durationTime = default(TimeSpan?);
		object value = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return;
				case 8:
					BOdTlDfKd4qfweKBOtwu(invocation);
					num2 = 2;
					break;
				case 5:
					if (!durationTime.HasValue)
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 2:
					durationTime = cacheAttribute.DurationTime;
					num2 = 5;
					break;
				default:
					invocation.set_ReturnValue(value);
					num2 = 6;
					break;
				case 3:
					return;
				case 4:
					cacheService.Insert(cacheKey, T0gaPIfKlYORyOjg77jX(invocation), cacheRegion);
					num2 = 7;
					break;
				case 1:
				{
					ICacheService obj = cacheService;
					object value2 = T0gaPIfKlYORyOjg77jX(invocation);
					durationTime = cacheAttribute.DurationTime;
					obj.Insert(cacheKey, value2, cacheRegion, durationTime.Value);
					num2 = 3;
					break;
				}
				case 7:
					return;
				case 9:
					if (!cacheService.TryGetValue<object>(cacheKey, cacheRegion, out value))
					{
						num2 = 8;
						break;
					}
					goto default;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 4;
		}
	}

	[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__3))]
	protected override Task InvokeAsync(IInvocationAsync invocation, string cacheKey, string cacheRegion, CacheAttribute cacheAttribute, CancellationToken cancellationToken)
	{
		int num = 9;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CInvokeAsync_003Ed__3 stateMachine = default(_003CInvokeAsync_003Ed__3);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 4;
					continue;
				case 3:
					stateMachine._003C_003Et__builder = MQQEuKfKr9ATuMXxQAyM();
					num2 = 6;
					continue;
				default:
					stateMachine.cacheKey = cacheKey;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 7;
					continue;
				case 4:
					return stateMachine._003C_003Et__builder.Task;
				case 8:
					stateMachine.invocation = invocation;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					stateMachine.cacheAttribute = cacheAttribute;
					num2 = 3;
					continue;
				case 6:
					stateMachine._003C_003E1__state = -1;
					num2 = 5;
					continue;
				case 1:
					break;
				case 9:
					stateMachine._003C_003E4__this = this;
					num2 = 8;
					continue;
				}
				break;
			}
			stateMachine.cacheRegion = cacheRegion;
			num = 2;
		}
	}

	internal static void ClearRegion(ICacheService cacheService, string cacheRegion)
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
				n8G4nGfKgO1gZPW9y0Km(cacheService, cacheRegion);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void IIvFbOfK9hLsYoyjjABF()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool D39Fk0fKMrulKWhwUx6J()
	{
		return LFMGp2fKyxQwubqTcMW8 == null;
	}

	internal static CacheInterceptor RrlL2hfKJu4MUK2NWJkl()
	{
		return LFMGp2fKyxQwubqTcMW8;
	}

	internal static void BOdTlDfKd4qfweKBOtwu(object P_0)
	{
		((IInvocation)P_0).Proceed();
	}

	internal static object T0gaPIfKlYORyOjg77jX(object P_0)
	{
		return ((IInvocation)P_0).get_ReturnValue();
	}

	internal static AsyncTaskMethodBuilder MQQEuKfKr9ATuMXxQAyM()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static void n8G4nGfKgO1gZPW9y0Km(object P_0, object P_1)
	{
		((ICacheService)P_0).ClearRegion((string)P_1);
	}
}
