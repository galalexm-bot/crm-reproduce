using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using EleWise.ELMA.Actions;
using EleWise.ELMA.Actions.Impl;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Runtime.AOP;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.NH;

internal class ManagerActionsInterceptor : AbstractAsyncInterceptor
{
	private readonly ActionDispatcherService dispatcherService;

	internal static ManagerActionsInterceptor vX9RPsWwRqx95E6uanHY;

	public ManagerActionsInterceptor(ActionDispatcherService dispatcherService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hrPYyUWwX7xS5YrBEW1f();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
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
			this.dispatcherService = dispatcherService;
			num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
			{
				num = 1;
			}
		}
	}

	[DebuggerHidden]
	public override void Intercept(IInvocation invocation)
	{
		//Discarded unreachable code: IL_00df, IL_00e9, IL_0178, IL_0188, IL_01b5, IL_01e7, IL_021f, IL_022e, IL_031d, IL_034f, IL_0387, IL_0396, IL_0423, IL_0432, IL_0478
		int num = 9;
		int num2 = num;
		ActionMethodAttribute attribute = default(ActionMethodAttribute);
		ActionCheckAttribute attribute2 = default(ActionCheckAttribute);
		IAuditEventHolder auditEventHolder2 = default(IAuditEventHolder);
		IAuditEventHolder auditEventHolder = default(IAuditEventHolder);
		ActionCheckResult actionCheckResult = default(ActionCheckResult);
		while (true)
		{
			object obj2;
			object obj;
			switch (num2)
			{
			case 25:
				return;
			case 5:
				return;
			case 16:
				if (!dispatcherService.InterceptMethodInvocation(invocation.get_Method(), (object[])b4ScAwWwnyEsj8oLmDBw(invocation)))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 10;
					}
				}
				else if (attribute == null)
				{
					if (attribute2 == null)
					{
						return;
					}
					num2 = 13;
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 0;
					}
				}
				break;
			case 20:
				obj2 = null;
				goto IL_04ad;
			case 2:
				return;
			case 14:
				u6hEsZWw2uSCl3c1YbID(invocation, dispatcherService.InvokeAction((IAuditObject)VXomU9WwO2EcfNJM61Og(auditEventHolder2), auditEventHolder2.Action, (object[])b4ScAwWwnyEsj8oLmDBw(invocation)));
				num2 = 25;
				break;
			case 12:
				bi3mMeWwktqF7cveQkt6(invocation);
				num2 = 5;
				break;
			case 11:
				return;
			case 21:
				obj = null;
				goto IL_04c3;
			case 13:
				try
				{
					auditEventHolder = ManagerActionInvokeProvider.GetActionInfoForCheck((MethodInfo)iaiZOiWwTWZ0AmB07q1d(invocation));
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (InvalidOperationException)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							auditEventHolder = null;
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				goto case 27;
			case 26:
				if (auditEventHolder.Action != null)
				{
					actionCheckResult = dispatcherService.CheckAction((IAuditObject)VXomU9WwO2EcfNJM61Og(auditEventHolder), (IAuditAction)IbRa97WwePEBOO3jnvSD(auditEventHolder), invocation.get_Arguments());
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 28;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 4;
					}
				}
				break;
			case 8:
				if ((MethodInfo)iaiZOiWwTWZ0AmB07q1d(invocation) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 1;
					}
					break;
				}
				attribute = AttributeHelper<ActionMethodAttribute>.GetAttribute((MemberInfo)iaiZOiWwTWZ0AmB07q1d(invocation), inherited: false);
				num2 = 15;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 7;
				}
				break;
			case 7:
			case 18:
				bi3mMeWwktqF7cveQkt6(invocation);
				num2 = 2;
				break;
			case 15:
				attribute2 = AttributeHelper<ActionCheckAttribute>.GetAttribute((MemberInfo)iaiZOiWwTWZ0AmB07q1d(invocation), inherited: false);
				num2 = 23;
				break;
			case 19:
				if (auditEventHolder2 == null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 20;
					}
					break;
				}
				obj2 = VXomU9WwO2EcfNJM61Og(auditEventHolder2);
				goto IL_04ad;
			case 6:
				return;
			default:
				try
				{
					auditEventHolder2 = ManagerActionInvokeProvider.GetActionInfoForMethod(invocation.get_Method());
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				catch (InvalidOperationException)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num6 = 0;
					}
					while (true)
					{
						switch (num6)
						{
						default:
							auditEventHolder2 = null;
							num6 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
							{
								num6 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				goto case 19;
			case 23:
				if (attribute != null)
				{
					num2 = 16;
					break;
				}
				goto case 17;
			case 17:
				if (attribute2 == null)
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 12;
					}
					break;
				}
				goto case 16;
			case 22:
				return;
			case 9:
				if (invocation != null)
				{
					num2 = 8;
					break;
				}
				return;
			case 27:
				if (auditEventHolder != null)
				{
					num2 = 3;
					break;
				}
				goto case 21;
			case 1:
				return;
			case 24:
				if (auditEventHolder2.Action != null)
				{
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 14;
					}
					break;
				}
				goto case 7;
			case 4:
				bi3mMeWwktqF7cveQkt6(invocation);
				num2 = 11;
				break;
			case 10:
				bi3mMeWwktqF7cveQkt6(invocation);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
				{
					num2 = 4;
				}
				break;
			case 3:
				obj = VXomU9WwO2EcfNJM61Og(auditEventHolder);
				goto IL_04c3;
			case 28:
				{
					u6hEsZWw2uSCl3c1YbID(invocation, byvDxvWw1SaGZycq5xGA(YVW2bDWwP8ajA0mlLgVd(iaiZOiWwTWZ0AmB07q1d(invocation)), typeof(ActionCheckResult)) ? ((object)actionCheckResult) : ((object)actionCheckResult.Result));
					num2 = 22;
					break;
				}
				IL_04ad:
				if (obj2 == null)
				{
					num2 = 18;
					break;
				}
				goto case 24;
				IL_04c3:
				if (obj != null)
				{
					num2 = 26;
					break;
				}
				goto case 4;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CInterceptAsync_003Ed__3))]
	[DebuggerHidden]
	public override Task InterceptAsync(IInvocationAsync invocation, CancellationToken cancellationToken)
	{
		int num = 1;
		int num2 = num;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CInterceptAsync_003Ed__3 stateMachine = default(_003CInterceptAsync_003Ed__3);
		while (true)
		{
			switch (num2)
			{
			case 7:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 4;
				break;
			case 1:
				stateMachine._003C_003E4__this = this;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 0;
				}
				break;
			default:
				stateMachine.invocation = invocation;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				return stateMachine._003C_003Et__builder.Task;
			case 2:
				stateMachine.cancellationToken = cancellationToken;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 5;
				}
				break;
			case 3:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 7;
				}
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 3;
				}
				break;
			case 5:
				stateMachine._003C_003Et__builder = zScToVWwNAJRVvYRrEcx();
				num2 = 6;
				break;
			}
		}
	}

	internal static void hrPYyUWwX7xS5YrBEW1f()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool BolHWpWwqEsn6hQmmG4p()
	{
		return vX9RPsWwRqx95E6uanHY == null;
	}

	internal static ManagerActionsInterceptor PbnerRWwKxo1ebBHZFyB()
	{
		return vX9RPsWwRqx95E6uanHY;
	}

	internal static object iaiZOiWwTWZ0AmB07q1d(object P_0)
	{
		return ((IInvocation)P_0).get_Method();
	}

	internal static void bi3mMeWwktqF7cveQkt6(object P_0)
	{
		((IInvocation)P_0).Proceed();
	}

	internal static object b4ScAwWwnyEsj8oLmDBw(object P_0)
	{
		return ((IInvocation)P_0).get_Arguments();
	}

	internal static object VXomU9WwO2EcfNJM61Og(object P_0)
	{
		return ((IAuditEventHolder)P_0).Object;
	}

	internal static void u6hEsZWw2uSCl3c1YbID(object P_0, object P_1)
	{
		((IInvocation)P_0).set_ReturnValue(P_1);
	}

	internal static object IbRa97WwePEBOO3jnvSD(object P_0)
	{
		return ((IAuditEventHolder)P_0).Action;
	}

	internal static Type YVW2bDWwP8ajA0mlLgVd(object P_0)
	{
		return ((MethodInfo)P_0).ReturnType;
	}

	internal static bool byvDxvWw1SaGZycq5xGA(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static AsyncTaskMethodBuilder zScToVWwNAJRVvYRrEcx()
	{
		return AsyncTaskMethodBuilder.Create();
	}
}
