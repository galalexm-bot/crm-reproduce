using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using EleWise.ELMA.Cache.Attributes;
using EleWise.ELMA.Runtime.AOP;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Cache.Modules;

public class ComplexCacheInterceptor : CacheInterceptorBase<ComplexCacheAttribute>
{
	private readonly IComplexCacheService complexCacheService;

	private static ComplexCacheInterceptor i04wPjfKHnyj4wXo8OWm;

	public ComplexCacheInterceptor(IComplexCacheService complexCacheService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
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
				this.complexCacheService = complexCacheService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void Invoke(IInvocation invocation, string cacheKey, string cacheRegion, ComplexCacheAttribute cacheAttribute)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 3:
				mAySWDfK0pKh8gTCeEu7(_003C_003Ec__DisplayClass2_.invocation, complexCacheService.GetOrAdd(cacheKey, (string)gYevuxfKxGnuskWthsl7(cacheAttribute), cacheRegion, _003C_003Ec__DisplayClass2_._003CInvoke_003Eb__0));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass2_.invocation = invocation;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CInvokeAsync_003Ed__3))]
	protected override Task InvokeAsync(IInvocationAsync invocation, string cacheKey, string cacheRegion, ComplexCacheAttribute cacheAttribute, CancellationToken cancellationToken)
	{
		int num = 1;
		int num2 = num;
		_003CInvokeAsync_003Ed__3 stateMachine = default(_003CInvokeAsync_003Ed__3);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			default:
				stateMachine.invocation = invocation;
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
				{
					num2 = 8;
				}
				break;
			case 9:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 3;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				stateMachine.cacheAttribute = cacheAttribute;
				num2 = 6;
				break;
			case 8:
				stateMachine.cacheKey = cacheKey;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 7;
				}
				break;
			case 3:
				return stateMachine._003C_003Et__builder.Task;
			case 4:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 9;
				break;
			case 7:
				stateMachine.cacheRegion = cacheRegion;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
				{
					num2 = 2;
				}
				break;
			case 6:
				stateMachine._003C_003Et__builder = c3UEnhfKmO51VVLtG5bN();
				num2 = 5;
				break;
			}
		}
	}

	internal static void ClearRegion(IComplexCacheService complexCacheService, string cacheRegion)
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
				complexCacheService.RefreshTimestampRegion(cacheRegion);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool Xv22BHfKANrEpqKvsh51()
	{
		return i04wPjfKHnyj4wXo8OWm == null;
	}

	internal static ComplexCacheInterceptor XTr5LwfK787F37e4xRoY()
	{
		return i04wPjfKHnyj4wXo8OWm;
	}

	internal static object gYevuxfKxGnuskWthsl7(object P_0)
	{
		return ((ComplexCacheAttribute)P_0).TimestampKey;
	}

	internal static void mAySWDfK0pKh8gTCeEu7(object P_0, object P_1)
	{
		((IInvocation)P_0).set_ReturnValue(P_1);
	}

	internal static AsyncTaskMethodBuilder c3UEnhfKmO51VVLtG5bN()
	{
		return AsyncTaskMethodBuilder.Create();
	}
}
