using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using EleWise.ELMA.Runtime.AOP;
using EleWise.ELMA.Threading;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.NH;

public class CallSessionInterceptor : AbstractAsyncInterceptor
{
	internal static CallSessionInterceptor wY27LYW4rakj2ihnqaPO;

	public override void Intercept(IInvocation invocation)
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
				new BackgroundTask((Action)invocation.Proceed, J8mQE4W4jGPK1fkO2g7Y(invocation).GetType(), (string)NNU9yqW4znOChTMbYDMM(VGRfJdW4YITSNROBDrLM(-1123633026 ^ -1123771748), roqws0W4LGsD4QscGAmS(invocation.get_TargetType()), OKbKbaW4sKamXQbdIf79(F82y1GW4Ui20J3gNV3vT(invocation), null) ? z3iLH9W4cI0QwU7O4ip9(VGRfJdW4YITSNROBDrLM(-1123633026 ^ -1123638598), roqws0W4LGsD4QscGAmS(F82y1GW4Ui20J3gNV3vT(invocation))) : ""), SR.T((string)VGRfJdW4YITSNROBDrLM(-1867198571 ^ -1867060079)), useCallSessionOwner: true, handleExceptions: false).Execute();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CInterceptAsync_003Ed__1))]
	public override Task InterceptAsync(IInvocationAsync invocation, CancellationToken cancellationToken)
	{
		int num = 4;
		int num2 = num;
		_003CInterceptAsync_003Ed__1 stateMachine = default(_003CInterceptAsync_003Ed__1);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 4:
				stateMachine.invocation = invocation;
				num2 = 3;
				break;
			case 5:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				stateMachine._003C_003E1__state = -1;
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 5;
				}
				break;
			default:
				return stateMachine._003C_003Et__builder.Task;
			case 2:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public CallSessionInterceptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object J8mQE4W4jGPK1fkO2g7Y(object P_0)
	{
		return ((IInvocation)P_0).get_InvocationTarget();
	}

	internal static object VGRfJdW4YITSNROBDrLM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object roqws0W4LGsD4QscGAmS(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static object F82y1GW4Ui20J3gNV3vT(object P_0)
	{
		return ((IInvocation)P_0).get_Method();
	}

	internal static bool OKbKbaW4sKamXQbdIf79(object P_0, object P_1)
	{
		return (MethodInfo)P_0 != (MethodInfo)P_1;
	}

	internal static object z3iLH9W4cI0QwU7O4ip9(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object NNU9yqW4znOChTMbYDMM(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool DZZBmNW4gidO7FIdI3AC()
	{
		return wY27LYW4rakj2ihnqaPO == null;
	}

	internal static CallSessionInterceptor P9fxNxW45v4CIH7eYqkD()
	{
		return wY27LYW4rakj2ihnqaPO;
	}
}
