using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Autofac;
using Castle.DynamicProxy;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Runtime.AOP;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.NH.Interceptors;

public class AuditInterceptor : AbstractAsyncInterceptor
{
	private readonly ConcurrentDictionary<MethodInfo, AuditableAttribute> methodAttributes;

	private IAuditableEventHandler handler;

	private IAuditableEventHandlerAsync handlerAsync;

	private readonly ILifetimeScopeAccessor lifetimeScopeAccessor;

	private bool shellActivated;

	internal static AuditInterceptor rIacVnWAFopPM9CGV9Ok;

	private bool ShellActivated
	{
		get
		{
			//Discarded unreachable code: IL_0086, IL_0099, IL_00a8
			int num = 4;
			int num2 = num;
			ILifetimeScope val = default(ILifetimeScope);
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (bRZ77hWA8bOv6JX9rXWJ(lifetimeScopeAccessor) != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto case 6;
				case 6:
					val = (ILifetimeScope)Tq0WJyWAZ9BEYBCFZrJu(lifetimeScopeAccessor);
					num2 = 2;
					break;
				case 7:
					handlerAsync = ResolutionExtensions.Resolve<IAuditableEventHandlerAsync>((IComponentContext)(object)val);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 6;
					}
					break;
				case 8:
					shellActivated = handler != null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return shellActivated;
				case 2:
					handler = ResolutionExtensions.Resolve<IAuditableEventHandler>((IComponentContext)(object)val);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 7;
					}
					break;
				case 4:
					if (shellActivated)
					{
						num2 = 3;
						break;
					}
					goto case 5;
				}
			}
		}
	}

	public AuditInterceptor(ILifetimeScopeAccessor lifetimeScopeAccessor)
	{
		//Discarded unreachable code: IL_003a, IL_003f
		AW2TmRWAofmyOVBaLYss();
		methodAttributes = new ConcurrentDictionary<MethodInfo, AuditableAttribute>();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.lifetimeScopeAccessor = lifetimeScopeAccessor;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	[DebuggerHidden]
	public override void Intercept(IInvocation invocation)
	{
		//Discarded unreachable code: IL_01cd, IL_01dc, IL_01ec, IL_01fb, IL_02dd, IL_02ec, IL_02fc, IL_030b
		int num = 20;
		AuditableEventArgs auditableEventArgs = default(AuditableEventArgs);
		AuditableCancelEventArgs auditableCancelEventArgs = default(AuditableCancelEventArgs);
		AuditableAttribute orAdd = default(AuditableAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!ShellActivated)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto default;
				case 6:
					FillEventArgs(invocation, auditableEventArgs);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					continue;
				case 21:
					return;
				case 13:
					auditableCancelEventArgs = new AuditableCancelEventArgs();
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 1;
					}
					continue;
				case 10:
					t9CUIrWAGPAWY1WeGKcY(handler, auditableCancelEventArgs);
					num2 = 17;
					continue;
				case 9:
					Q11auKWAbJ7UNLLHigHT(invocation);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 3;
					}
					continue;
				case 4:
					gF2XSNWACmaxUrEgSpuR(auditableEventArgs, UYmIm8WAQgOcnVvBndYT(invocation));
					num2 = 18;
					continue;
				case 7:
					if (orAdd.Preprocess)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 8;
				case 14:
					FillEventArgs(invocation, auditableCancelEventArgs);
					num2 = 10;
					continue;
				default:
					auditableEventArgs = new AuditableEventArgs();
					num2 = 6;
					continue;
				case 17:
					if (Pv0lxmWAE1VsFXnvK7VB(auditableCancelEventArgs))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto IL_00c9;
				case 16:
					return;
				case 11:
					return;
				case 3:
				case 5:
					if (qmBBHfWAh9nes7tO8UA0(orAdd))
					{
						num2 = 15;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto IL_00c9;
				case 22:
					return;
				case 24:
					return;
				case 8:
					if (orAdd.Postprocess)
					{
						num2 = 3;
						continue;
					}
					goto case 9;
				case 15:
					if (ShellActivated)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto IL_00c9;
				case 23:
					bKahnVWAfaMDpvynX7ay(invocation, auditableCancelEventArgs.Result);
					num2 = 21;
					continue;
				case 18:
					handler.Postprocess(auditableEventArgs);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 12;
					}
					continue;
				case 12:
					bKahnVWAfaMDpvynX7ay(invocation, auditableEventArgs.Result);
					num2 = 22;
					continue;
				case 2:
					if (!orAdd.Postprocess)
					{
						num = 24;
						break;
					}
					goto case 1;
				case 19:
					if (orAdd != null)
					{
						num = 7;
						break;
					}
					goto case 9;
				case 20:
					{
						orAdd = methodAttributes.GetOrAdd(invocation.get_Method(), (MethodInfo mi) => AttributeHelper<AuditableAttribute>.GetAttribute(mi, inherited: true));
						num2 = 8;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 19;
						}
						continue;
					}
					IL_00c9:
					Q11auKWAbJ7UNLLHigHT(invocation);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CInterceptAsync_003Ed__3))]
	[DebuggerHidden]
	public override Task InterceptAsync(IInvocationAsync invocation, CancellationToken cancellationToken)
	{
		int num = 5;
		_003CInterceptAsync_003Ed__3 stateMachine = default(_003CInterceptAsync_003Ed__3);
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					stateMachine.invocation = invocation;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 1;
					}
					continue;
				default:
					return stateMachine._003C_003Et__builder.Task;
				case 2:
					stateMachine._003C_003E1__state = -1;
					num2 = 3;
					continue;
				case 6:
					stateMachine._003C_003Et__builder = tdvNBGWAv8Rwp87RkgSs();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
					_003C_003Et__builder = stateMachine._003C_003Et__builder;
					num2 = 7;
					continue;
				case 1:
					break;
				case 5:
					stateMachine._003C_003E4__this = this;
					num2 = 4;
					continue;
				case 7:
					_003C_003Et__builder.Start(ref stateMachine);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			stateMachine.cancellationToken = cancellationToken;
			num = 6;
		}
	}

	private void FillEventArgs(IInvocation invocation, AuditableEventArgs e)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_0125, IL_0135, IL_0144
		int num = 12;
		int num2 = num;
		object value = default(object);
		int num3 = default(int);
		string name = default(string);
		while (true)
		{
			switch (num2)
			{
			case 8:
				value = invocation.get_Arguments()[num3];
				num2 = 5;
				break;
			case 3:
				name = ((ParameterInfo)((object[])x8ycQgWAixgxnophNoy6(thTtp4WAIpuWIHl2wQYX(invocation)))[num3]).Name;
				num2 = 8;
				break;
			case 12:
				e.Invoker = d6rHW8WAu6Qr4PGXxUnL(invocation);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 11;
				}
				break;
			case 1:
			case 10:
				num3++;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 3;
				}
				break;
			case 11:
				e.InvokerType = invocation.get_TargetType();
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
				{
					num2 = 13;
				}
				break;
			case 9:
				num3 = 0;
				num2 = 6;
				break;
			case 7:
				return;
			case 13:
				di5a5OWAVjCjJGxCtHh7(e, thTtp4WAIpuWIHl2wQYX(invocation));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num2 = 9;
				}
				break;
			case 4:
			case 6:
				if (num3 >= ((Array)x8ycQgWAixgxnophNoy6(invocation.get_Method())).Length)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				e.Params[name] = value;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 1;
				}
				break;
			default:
				if (num3 >= ((Array)sMfR55WASYGgwgdIPbR9(invocation)).Length)
				{
					num2 = 10;
					break;
				}
				goto case 3;
			}
		}
	}

	internal static void AW2TmRWAofmyOVBaLYss()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool AKGDN3WABAtFtL8qb1m1()
	{
		return rIacVnWAFopPM9CGV9Ok == null;
	}

	internal static AuditInterceptor JvYNo1WAWoQXfV5Tdxtu()
	{
		return rIacVnWAFopPM9CGV9Ok;
	}

	internal static void Q11auKWAbJ7UNLLHigHT(object P_0)
	{
		((IInvocation)P_0).Proceed();
	}

	internal static bool qmBBHfWAh9nes7tO8UA0(object P_0)
	{
		return ((AuditableAttribute)P_0).Preprocess;
	}

	internal static void t9CUIrWAGPAWY1WeGKcY(object P_0, object P_1)
	{
		((IAuditableEventHandler)P_0).Preprocess((AuditableCancelEventArgs)P_1);
	}

	internal static bool Pv0lxmWAE1VsFXnvK7VB(object P_0)
	{
		return ((AuditableCancelEventArgs)P_0).Cancel;
	}

	internal static void bKahnVWAfaMDpvynX7ay(object P_0, object P_1)
	{
		((IInvocation)P_0).set_ReturnValue(P_1);
	}

	internal static object UYmIm8WAQgOcnVvBndYT(object P_0)
	{
		return ((IInvocation)P_0).get_ReturnValue();
	}

	internal static void gF2XSNWACmaxUrEgSpuR(object P_0, object P_1)
	{
		((AuditableEventArgs)P_0).Result = P_1;
	}

	internal static AsyncTaskMethodBuilder tdvNBGWAv8Rwp87RkgSs()
	{
		return AsyncTaskMethodBuilder.Create();
	}

	internal static ServiceScope bRZ77hWA8bOv6JX9rXWJ(object P_0)
	{
		return ((ILifetimeScopeAccessor)P_0).CurrentType;
	}

	internal static object Tq0WJyWAZ9BEYBCFZrJu(object P_0)
	{
		return ((ILifetimeScopeAccessor)P_0).Current;
	}

	internal static object d6rHW8WAu6Qr4PGXxUnL(object P_0)
	{
		return ((IInvocation)P_0).get_Proxy();
	}

	internal static object thTtp4WAIpuWIHl2wQYX(object P_0)
	{
		return ((IInvocation)P_0).get_Method();
	}

	internal static void di5a5OWAVjCjJGxCtHh7(object P_0, object P_1)
	{
		((AuditableEventArgs)P_0).Method = (MethodInfo)P_1;
	}

	internal static object sMfR55WASYGgwgdIPbR9(object P_0)
	{
		return ((IInvocation)P_0).get_Arguments();
	}

	internal static object x8ycQgWAixgxnophNoy6(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}
}
