using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Security;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Actions;

public sealed class ActionInvokerAsync : IActionInvokerAsync, IActionInvoker
{
	private readonly ILazy<ActionDispatcherService> actionDispatcherService;

	private readonly object entityManager;

	private readonly MethodInfo targetMethodInfo;

	private readonly MethodInfo checkMethodInfo;

	private readonly Func<ActionInvokeEventArgs, object> invokeActionHandler;

	private readonly Func<ActionInvokeEventArgs, CancellationToken, Task<object>> invokeActionHandlerAsync;

	private readonly Func<ActionInvokeEventArgs, ActionCheckResult> checkActionHandler;

	private readonly Func<ActionInvokeEventArgs, CancellationToken, Task<ActionCheckResult>> checkActionHandlerAsync;

	internal static ActionInvokerAsync BwLiu5ftjwfSVal36NQF;

	public IAuditObject ActionObject { get; }

	public IAuditAction ActionType { get; }

	public ActionMethodMetadata MethodMetadata { get; }

	public ActionInvokerAsync(IAuditObject actionObject, IAuditAction actionType, MethodInfo targetMethodInfo, Func<ActionInvokeEventArgs, object> invokeActionHandler, Func<ActionInvokeEventArgs, CancellationToken, Task<object>> invokeActionHandlerAsync, Func<ActionInvokeEventArgs, ActionCheckResult> checkActionHandler = null, Func<ActionInvokeEventArgs, CancellationToken, Task<ActionCheckResult>> checkActionHandlerAsync = null)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.ArgumentNotNull(actionType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575799640));
		Contract.ArgumentNotNull(actionObject, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-521266112 ^ -521452368));
		Contract.ArgumentNotNull(targetMethodInfo, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD38B3FA));
		Contract.ArgumentNotNull(invokeActionHandler, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341D0309));
		Contract.ArgumentNotNull(invokeActionHandlerAsync, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CE1BCD));
		ActionObject = actionObject;
		ActionType = actionType;
		MethodMetadata = ActionMethodMetadata.Create(actionObject, actionType, targetMethodInfo);
		this.invokeActionHandler = invokeActionHandler;
		this.invokeActionHandlerAsync = invokeActionHandlerAsync;
		this.checkActionHandler = checkActionHandler;
		this.checkActionHandlerAsync = checkActionHandlerAsync;
	}

	public ActionInvokerAsync(ILazy<ActionDispatcherService> actionDispatcherService, object entityManager, IAuditObject actionObject, IAuditAction actionType, MethodInfo targetMethodInfo, MethodInfo checkMethodInfo = null)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.ArgumentNotNull(actionDispatcherService, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459243365));
		Contract.ArgumentNotNull(actionObject, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138617080));
		Contract.ArgumentNotNull(actionType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751485716));
		Contract.ArgumentNotNull(entityManager, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1410890687));
		Contract.ArgumentNotNull(targetMethodInfo, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87160589));
		ActionObject = actionObject;
		ActionType = actionType;
		this.actionDispatcherService = actionDispatcherService;
		this.entityManager = entityManager;
		this.targetMethodInfo = targetMethodInfo;
		this.checkMethodInfo = checkMethodInfo;
		MethodMetadata = ActionMethodMetadata.Create(actionObject, actionType, targetMethodInfo);
		if (checkMethodInfo != null)
		{
			checkActionHandler = CheckHandle;
			checkActionHandlerAsync = CheckHandleAsync;
		}
		invokeActionHandler = ActionHandle;
		invokeActionHandlerAsync = ActionHandleAsync;
	}

	public object InvokeAction(ActionInvokeEventArgs e)
	{
		return invokeActionHandler(e);
	}

	public ActionCheckResult CheckAction(ActionInvokeEventArgs e)
	{
		//Discarded unreachable code: IL_004f, IL_00b2, IL_0126, IL_0135, IL_0142, IL_0151
		ActionCheckResult result = default(ActionCheckResult);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				Func<ActionInvokeEventArgs, ActionCheckResult> func = checkActionHandler;
				int num;
				if (func == null)
				{
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num = 0;
					}
					goto IL_0053;
				}
				ActionCheckResult actionCheckResult = func(e);
				goto IL_0075;
				IL_0075:
				result = actionCheckResult;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num = 0;
				}
				goto IL_0053;
				IL_0053:
				switch (num)
				{
				case 1:
					return result;
				}
				actionCheckResult = BN6fO9ftUPoa4T4yH0Wu();
				goto IL_0075;
			}
			catch (TargetInvocationException ex)
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 1;
				}
				while (true)
				{
					switch (num2)
					{
					case 2:
						ufmCCrftzXWdunpIKLiV(UIbnUoftcVIwLoyoUsU3(q5iG3MftsyuDywJUVZ2g(ex)));
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 0;
						}
						break;
					case 1:
						if (ex.InnerException == null)
						{
							num2 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
							{
								num2 = 3;
							}
							break;
						}
						goto case 2;
					default:
						throw;
					}
				}
			}
		}
	}

	public Task<object> InvokeActionAsync(ActionInvokeEventArgs e, CancellationToken cancellationToken)
	{
		return invokeActionHandlerAsync(e, cancellationToken);
	}

	public Task<ActionCheckResult> CheckActionAsync(ActionInvokeEventArgs e, CancellationToken cancellationToken)
	{
		return checkActionHandlerAsync?.Invoke(e, cancellationToken) ?? Task.FromResult(ActionCheckResult.True);
	}

	private ActionCheckResult CheckHandle(ActionInvokeEventArgs e)
	{
		//Discarded unreachable code: IL_01e2, IL_01f1
		int num = 6;
		int num2 = num;
		ActionCheckResult? actionCheckResult = default(ActionCheckResult?);
		while (true)
		{
			switch (num2)
			{
			case 12:
				return new ActionCheckResult((bool)e.Result, null);
			case 7:
				return actionCheckResult.GetValueOrDefault();
			case 5:
				oYg0OAfwFdTcENcRURKJ(e, false);
				num2 = 3;
				break;
			case 1:
				oYg0OAfwFdTcENcRURKJ(e, OqtnpufwoEjHWVQR8AJ2(checkMethodInfo, entityManager, e.Params.ToArray()));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				e.Invoked = false;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 4;
				}
				break;
			case 10:
				if (actionCheckResult.HasValue)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 7;
					}
					break;
				}
				goto case 12;
			default:
				return new ActionCheckResult(result: false, null);
			case 8:
				s1X5aDfwB5v0mVfR3W6f(e, true);
				num2 = 9;
				break;
			case 3:
				s1X5aDfwB5v0mVfR3W6f(e, false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			case 11:
				actionDispatcherService.Value.StartMethodInvocation(checkMethodInfo, e.Params.ToArray());
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				actionCheckResult = td9FgRfwbnqnfQ6aQkUd(e) as ActionCheckResult?;
				num2 = 10;
				break;
			case 4:
				return new ActionCheckResult(result: true, null);
			case 6:
				if (!AttributeHelper<ActionPermissionAttribute>.GetAttributes(targetMethodInfo, inherited: false).Any(delegate(ActionPermissionAttribute attr)
				{
					//Discarded unreachable code: IL_0039, IL_0048
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						case 2:
							return !_003C_003Ec.ODTpLDZfvYX4WmuIQgJH(attr);
						default:
							return true;
						case 1:
							if (attr == null)
							{
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
								{
									num4 = 0;
								}
								break;
							}
							goto case 2;
						}
					}
				}))
				{
					if (!NA5GJffwWQIUjsreooCS(checkMethodInfo, null))
					{
						oYg0OAfwFdTcENcRURKJ(e, true);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 2;
						}
					}
					else
					{
						num2 = 11;
					}
				}
				else
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 3;
					}
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CCheckHandleAsync_003Ed__24))]
	private Task<ActionCheckResult> CheckHandleAsync(ActionInvokeEventArgs e, CancellationToken cancellationToken)
	{
		_003CCheckHandleAsync_003Ed__24 stateMachine = default(_003CCheckHandleAsync_003Ed__24);
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<ActionCheckResult>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<ActionCheckResult> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private object ActionHandle(ActionInvokeEventArgs e)
	{
		//Discarded unreachable code: IL_0070, IL_00de, IL_014b, IL_015b, IL_016a, IL_0175, IL_021b, IL_0261, IL_0280, IL_028f, IL_02bc
		int num = 2;
		int num2 = num;
		object result = default(object);
		IEnumerator<ActionPermissionAttribute> enumerator = default(IEnumerator<ActionPermissionAttribute>);
		ActionPermissionAttribute current = default(ActionPermissionAttribute);
		while (true)
		{
			switch (num2)
			{
			case 4:
				return result;
			default:
				try
				{
					oYg0OAfwFdTcENcRURKJ(e, targetMethodInfo.Invoke(entityManager, e.Params.ToArray()));
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							return result;
						default:
							s1X5aDfwB5v0mVfR3W6f(e, true);
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
							{
								num5 = 2;
							}
							break;
						case 2:
							result = e.Result;
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
							{
								num5 = 0;
							}
							break;
						}
					}
				}
				catch (TargetInvocationException ex)
				{
					int num6 = 2;
					while (true)
					{
						switch (num6)
						{
						case 2:
							if (ex.InnerException != null)
							{
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
								{
									num6 = 1;
								}
								continue;
							}
							break;
						case 1:
							ufmCCrftzXWdunpIKLiV(UIbnUoftcVIwLoyoUsU3(q5iG3MftsyuDywJUVZ2g(ex)));
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
							{
								num6 = 0;
							}
							continue;
						}
						break;
					}
					throw;
				}
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!rjtHH0fwQ8Gb8Tkt8bnN(enumerator))
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
							{
								num3 = 1;
							}
							goto IL_0179;
						}
						goto IL_01f3;
						IL_01f3:
						current = enumerator.Current;
						num3 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num3 = 3;
						}
						goto IL_0179;
						IL_0179:
						while (true)
						{
							switch (num3)
							{
							case 4:
								throw new SecurityException(SR.T((string)cdGbHGfwG7C1dDtamwC8(-475857671 ^ -475553037), p8aVvsfwf4TMWR2rxMy8(LbcTKvfwEXt5Z1tkTvFE(current))));
							case 2:
								break;
							default:
								goto IL_01f3;
							case 3:
								if (R38LD8fwh4G7tasT6je5(current))
								{
									num3 = 2;
									continue;
								}
								goto case 4;
							case 1:
								goto end_IL_01cd;
							}
							break;
						}
						continue;
						end_IL_01cd:
						break;
					}
				}
				finally
				{
					int num4;
					if (enumerator == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num4 = 0;
						}
						goto IL_0265;
					}
					goto IL_029a;
					IL_029a:
					KkqDq4fwCYjewTDxI6xa(enumerator);
					num4 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num4 = 2;
					}
					goto IL_0265;
					IL_0265:
					switch (num4)
					{
					default:
						goto end_IL_0240;
					case 0:
						goto end_IL_0240;
					case 1:
						break;
					case 2:
						goto end_IL_0240;
					}
					goto IL_029a;
					end_IL_0240:;
				}
				break;
			case 2:
				enumerator = AttributeHelper<ActionPermissionAttribute>.GetAttributes(targetMethodInfo, inherited: false).GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 1;
				}
				continue;
			case 3:
				break;
			}
			actionDispatcherService.Value.StartMethodInvocation(targetMethodInfo, e.Params.ToArray());
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
			{
				num2 = 0;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CActionHandleAsync_003Ed__26))]
	private Task<object> ActionHandleAsync(ActionInvokeEventArgs e, CancellationToken cancellationToken)
	{
		_003CActionHandleAsync_003Ed__26 stateMachine = default(_003CActionHandleAsync_003Ed__26);
		stateMachine._003C_003E4__this = this;
		stateMachine.e = e;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<object> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	internal static bool kehb03ftYvIZC3nOkNuD()
	{
		return BwLiu5ftjwfSVal36NQF == null;
	}

	internal static ActionInvokerAsync VJBnneftLfxpM1jyYXK0()
	{
		return BwLiu5ftjwfSVal36NQF;
	}

	internal static ActionCheckResult BN6fO9ftUPoa4T4yH0Wu()
	{
		return ActionCheckResult.True;
	}

	internal static object q5iG3MftsyuDywJUVZ2g(object P_0)
	{
		return ((Exception)P_0).InnerException;
	}

	internal static object UIbnUoftcVIwLoyoUsU3(object P_0)
	{
		return ExceptionDispatchInfo.Capture((Exception)P_0);
	}

	internal static void ufmCCrftzXWdunpIKLiV(object P_0)
	{
		((ExceptionDispatchInfo)P_0).Throw();
	}

	internal static void oYg0OAfwFdTcENcRURKJ(object P_0, object P_1)
	{
		((ActionInvokeEventArgs)P_0).Result = P_1;
	}

	internal static void s1X5aDfwB5v0mVfR3W6f(object P_0, bool value)
	{
		((ActionInvokeEventArgs)P_0).Invoked = value;
	}

	internal static bool NA5GJffwWQIUjsreooCS(object P_0, object P_1)
	{
		return (MethodInfo)P_0 != (MethodInfo)P_1;
	}

	internal static object OqtnpufwoEjHWVQR8AJ2(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static object td9FgRfwbnqnfQ6aQkUd(object P_0)
	{
		return ((ActionInvokeEventArgs)P_0).Result;
	}

	internal static bool R38LD8fwh4G7tasT6je5(object P_0)
	{
		return ((ActionPermissionAttribute)P_0).CheckPermissionCurrentUser();
	}

	internal static object cdGbHGfwG7C1dDtamwC8(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object LbcTKvfwEXt5Z1tkTvFE(object P_0)
	{
		return ((ActionPermissionAttribute)P_0).Permission;
	}

	internal static object p8aVvsfwf4TMWR2rxMy8(object P_0)
	{
		return ((Permission)P_0).Name;
	}

	internal static bool rjtHH0fwQ8Gb8Tkt8bnN(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void KkqDq4fwCYjewTDxI6xa(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
