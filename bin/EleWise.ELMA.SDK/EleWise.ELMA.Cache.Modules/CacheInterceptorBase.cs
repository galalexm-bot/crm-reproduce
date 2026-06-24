using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.AOP;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Cache.Modules;

public abstract class CacheInterceptorBase<T> : AbstractAsyncInterceptor where T : Attribute
{
	private readonly ConcurrentDictionary<MethodInfo, T> methodAttributes;

	private static object YZdPN2fK55AqoPiJWhbQ;

	public override void Intercept(IInvocation invocation)
	{
		int num = 5;
		int num2 = num;
		T orAdd = default(T);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				invocation.Proceed();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				if (orAdd == null)
				{
					num2 = 2;
					break;
				}
				_003C_003Ec__DisplayClass1_.cacheKey = invocation.get_Method().GetCacheKey(invocation.get_TargetType(), invocation.get_Arguments());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
				_003C_003Ec__DisplayClass1_.invocationParams = new InvocationParameters(invocation);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 8;
				}
				break;
			case 5:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 4;
				break;
			case 1:
				return;
			case 7:
				Invoke(invocation, _003C_003Ec__DisplayClass1_.cacheKey, invocation.get_Method().GetCacheRegion(invocation.get_TargetType()), orAdd);
				num2 = 3;
				break;
			case 8:
				_003C_003Ec__DisplayClass1_.cacheKey = ComponentManager.Current.GetExtensionPoints<ICacheKeyFormatter>(useCache: true).Aggregate(_003C_003Ec__DisplayClass1_.cacheKey, _003C_003Ec__DisplayClass1_._003CIntercept_003Eb__1);
				num2 = 7;
				break;
			case 4:
				orAdd = methodAttributes.GetOrAdd(invocation.get_Method(), (MethodInfo mi) => AttributeHelper<T>.GetAttribute(mi, inherited: true));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 6;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(CacheInterceptorBase<>._003CInterceptAsync_003Ed__2))]
	public override Task InterceptAsync(IInvocationAsync invocation, CancellationToken cancellationToken)
	{
		int num = 7;
		int num2 = num;
		_003CInterceptAsync_003Ed__2 stateMachine = default(_003CInterceptAsync_003Ed__2);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 6:
				stateMachine.invocation = invocation;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 1;
				}
				break;
			default:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 5;
				break;
			case 7:
				stateMachine._003C_003E4__this = this;
				num2 = 6;
				break;
			case 5:
				stateMachine._003C_003E1__state = -1;
				num2 = 2;
				break;
			case 3:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 4;
				break;
			case 4:
				return stateMachine._003C_003Et__builder.Task;
			case 1:
				stateMachine.cancellationToken = cancellationToken;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 3;
				break;
			}
		}
	}

	protected abstract void Invoke(IInvocation invocation, string cacheKey, string cacheRegion, T cacheAttribute);

	protected abstract Task InvokeAsync(IInvocationAsync invocation, string cacheKey, string cacheRegion, T cacheAttribute, CancellationToken cancellationToken);

	protected CacheInterceptorBase()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		methodAttributes = new ConcurrentDictionary<MethodInfo, T>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool YNL93EfKjFAJ8A5pVwvJ()
	{
		return YZdPN2fK55AqoPiJWhbQ == null;
	}

	internal static object Wx6TRmfKYae5KUsXPbcw()
	{
		return YZdPN2fK55AqoPiJWhbQ;
	}
}
