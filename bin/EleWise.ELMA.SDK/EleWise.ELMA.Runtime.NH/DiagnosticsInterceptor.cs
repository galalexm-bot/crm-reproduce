using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using EleWise.ELMA.Diagnostics;
using EleWise.ELMA.Runtime.AOP;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.NH;

public class DiagnosticsInterceptor : AbstractAsyncInterceptor
{
	internal static DiagnosticsInterceptor fB5weJWaLDLGNRRmRB0y;

	[DebuggerHidden]
	public override void Intercept(IInvocation invocation)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return;
			default:
				_003C_003Ec__DisplayClass0_.invocation = invocation;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				DiagnosticsManager.StartCall((Func<MethodCallInfo>)_003C_003Ec__DisplayClass0_._003CIntercept_003Eb__0, (Action)_003C_003Ec__DisplayClass0_.invocation.Proceed);
				num2 = 3;
				break;
			}
		}
	}

	[DebuggerHidden]
	public override Task InterceptAsync(IInvocationAsync invocation, CancellationToken cancellationToken)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return DiagnosticsManager.StartAsyncCall(_003C_003Ec__DisplayClass1_._003CInterceptAsync_003Eb__0, _003C_003Ec__DisplayClass1_._003CInterceptAsync_003Eb__1, cancellationToken);
			default:
				_003C_003Ec__DisplayClass1_.invocation = invocation;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public DiagnosticsInterceptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool idGIUpWaUWCnwLHxIFA0()
	{
		return fB5weJWaLDLGNRRmRB0y == null;
	}

	internal static DiagnosticsInterceptor sWlcv4WasIBsy8HZin7m()
	{
		return fB5weJWaLDLGNRRmRB0y;
	}
}
