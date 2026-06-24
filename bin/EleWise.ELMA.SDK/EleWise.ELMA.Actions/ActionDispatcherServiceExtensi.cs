using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using EleWise.ELMA.Actions.Impl;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.ExpressionUtil;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Actions;

public static class ActionDispatcherServiceExtensions
{
	internal static ActionDispatcherServiceExtensions PJ0UYYft36P5PZ7rU1KQ;

	public static ActionCheckResult CheckActionWithResult([NotNull] this ActionDispatcherService service, [NotNull] string actionObjectUid, [NotNull] string actionTypeUid, params object[] methodArgs)
	{
		//Discarded unreachable code: IL_0059, IL_0068, IL_00d5, IL_0277, IL_0286
		int num = 2;
		int num2 = num;
		IAuditAction action = default(IAuditAction);
		IAuditObject auditObject = default(IAuditObject);
		IAuditManager serviceNotNull = default(IAuditManager);
		Guid result2 = default(Guid);
		Guid result = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 13:
				if (action == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 6;
					}
					break;
				}
				return service.CheckAction(auditObject, action, methodArgs);
			default:
				throw new ArgumentNullException((string)YQSubbftDDhyhkVdsjXA(0x4A1640F ^ 0x4A43E15));
			case 10:
				if (auditObject != null)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 8;
			case 8:
				throw new InvalidOperationException(SR.T((string)YQSubbftDDhyhkVdsjXA(0x34185E55 ^ 0x341D0423), actionObjectUid));
			case 7:
				action = serviceNotNull.GetAction(auditObject, result2);
				num2 = 13;
				break;
			case 11:
				throw new ArgumentNullException((string)YQSubbftDDhyhkVdsjXA(-1867198571 ^ -1867410007));
			case 9:
				if (Guid.TryParse(actionTypeUid, out result2))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			case 5:
				auditObject = (IAuditObject)nbbw6Jftt3tYHfb4rhh3(serviceNotNull, result);
				num2 = 10;
				break;
			case 12:
				throw new ArgumentException((string)YQSubbftDDhyhkVdsjXA(-812025778 ^ -811851244), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767382047));
			case 4:
				throw new ArgumentException((string)YQSubbftDDhyhkVdsjXA(--1333735954 ^ 0x4F7A6848), (string)YQSubbftDDhyhkVdsjXA(0x7E6E5A0B ^ 0x7E6B0037));
			case 3:
				if (Guid.TryParse(actionObjectUid, out result))
				{
					serviceNotNull = Locator.GetServiceNotNull<IAuditManager>();
					num2 = 5;
					break;
				}
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num2 = 12;
				}
				break;
			case 6:
				throw new InvalidOperationException(SR.T((string)YQSubbftDDhyhkVdsjXA(0x3A5D5EF ^ 0x3A08F29), actionTypeUid));
			case 2:
				if (service == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 1;
					}
					break;
				}
				if (actionObjectUid != null)
				{
					if (actionTypeUid != null)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 11;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				throw new ArgumentNullException((string)YQSubbftDDhyhkVdsjXA(0x571EA399 ^ 0x571FC3F9));
			}
		}
	}

	public static ActionCheckResult CheckActionWithResult<TManager>([NotNull] this ActionDispatcherService service, [NotNull] Expression<Action<TManager>> expression) where TManager : IEntityManager
	{
		if (service == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633424331));
		}
		if (expression == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882123674));
		}
		if (!(expression.Body is MethodCallExpression methodCallExpression) || methodCallExpression.Method == null)
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A08EFF)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870889165));
		}
		IDictionary<string, object> dictionary = new Dictionary<string, object>();
		AddParameterValuesFromExpressionToDictionary(dictionary, methodCallExpression);
		IAuditEventHolder methodActionInfo = ManagerActionInvokeProvider.GetMethodActionInfo(methodCallExpression.Method);
		if (methodActionInfo != null)
		{
			return service.CheckAction(methodActionInfo.Object, methodActionInfo.Action, dictionary.Values.ToArray());
		}
		return ActionCheckResult.False(null);
	}

	public static ActionCheckResult CheckActionWithResult<TManager>([NotNull] this ActionDispatcherService service, [NotNull] Expression<Action<TManager>> expression, [NotNull] Type objectType) where TManager : IEntityManager
	{
		if (service == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE01B15));
		}
		if (expression == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112702062));
		}
		if (objectType == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740487994));
		}
		if (!(expression.Body is MethodCallExpression methodCallExpression) || methodCallExpression.Method == null)
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426400215)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x124411A0));
		}
		IDictionary<string, object> dictionary = new Dictionary<string, object>();
		AddParameterValuesFromExpressionToDictionary(dictionary, methodCallExpression);
		IAuditObject @object = Locator.GetServiceNotNull<IAuditManager>().GetObject(InterfaceActivator.UID(objectType));
		if (@object == null)
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548EF5D0), objectType), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341A0747));
		}
		IAuditEventHolder methodActionInfo = ManagerActionInvokeProvider.GetMethodActionInfo(methodCallExpression.Method);
		if (methodActionInfo != null)
		{
			return service.CheckAction(@object, methodActionInfo.Action, dictionary.Values.ToArray());
		}
		return ActionCheckResult.False(null);
	}

	public static ActionCheckResult CheckActionWithResult<TManager>([NotNull] this TManager manager, [NotNull] Expression<Action<TManager>> expression, [NotNull] Type objectType) where TManager : class, IEntityManager
	{
		if (manager == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -69855754));
		}
		return Locator.GetServiceNotNull<ActionDispatcherService>().CheckActionWithResult(expression, objectType);
	}

	public static bool CheckAction([NotNull] this ActionDispatcherService service, [NotNull] string actionObjectUid, [NotNull] string actionTypeUid, params object[] methodArgs)
	{
		return IGuO7fftwgXUW8qH3tOy(service.CheckActionWithResult(actionObjectUid, actionTypeUid, methodArgs));
	}

	public static bool CheckAction<TManager>([NotNull] this ActionDispatcherService service, [NotNull] Expression<Action<TManager>> expression) where TManager : IEntityManager
	{
		return service.CheckActionWithResult(expression);
	}

	public static bool CheckAction<TManager>([NotNull] this ActionDispatcherService service, [NotNull] Expression<Action<TManager>> expression, [NotNull] Type objectType) where TManager : IEntityManager
	{
		return service.CheckActionWithResult(expression, objectType);
	}

	public static bool CheckAction<TManager>([NotNull] this TManager manager, [NotNull] Expression<Action<TManager>> expression, [NotNull] Type objectType) where TManager : class, IEntityManager
	{
		return manager.CheckActionWithResult(expression, objectType);
	}

	public static void InvokeAction<TManager>([NotNull] this ActionDispatcherService service, [NotNull] Expression<Action<TManager>> expression, [NotNull] Type objectType) where TManager : IEntityManager
	{
		if (service == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4785BC0D ^ 0x4784DC6D));
		}
		if (expression == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561078176));
		}
		if (objectType == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A78CFD));
		}
		MethodCallExpression methodCall = expression.Body as MethodCallExpression;
		InvokeAction(service, objectType, methodCall);
	}

	public static TResult InvokeAction<TManager, TResult>([NotNull] this ActionDispatcherService service, [NotNull] Expression<Func<TManager, TResult>> expression, [NotNull] Type objectType) where TManager : IEntityManager
	{
		if (service == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE2BDE9));
		}
		if (expression == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC2BC49));
		}
		if (objectType == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70148577));
		}
		MethodCallExpression methodCall = expression.Body as MethodCallExpression;
		return (TResult)InvokeAction(service, objectType, methodCall);
	}

	private static object InvokeAction(object service, Type objectType, object methodCall)
	{
		//Discarded unreachable code: IL_0110, IL_0187
		int num = 2;
		IAuditObject auditObject = default(IAuditObject);
		IAuditEventHolder methodActionInfo = default(IAuditEventHolder);
		IDictionary<string, object> dictionary = default(IDictionary<string, object>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 10:
					throw new ArgumentException(SR.T((string)YQSubbftDDhyhkVdsjXA(0x307E9FD1 ^ 0x307BC4C1)), (string)YQSubbftDDhyhkVdsjXA(-1710575414 ^ -1710232798));
				case 7:
					throw new ArgumentException(SR.T((string)YQSubbftDDhyhkVdsjXA(0x7459E02 ^ 0x740C558), objectType), (string)YQSubbftDDhyhkVdsjXA(0x1A33FE36 ^ 0x1A31A724));
				case 3:
					break;
				case 2:
					if (methodCall != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				case 4:
					throw new ArgumentException(SR.T((string)YQSubbftDDhyhkVdsjXA(-1088304168 ^ -1088120872), WTbDQSft6wNZo4hlt3NB(methodCall)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87158881));
				case 8:
					return ((ActionDispatcherService)service).InvokeAction(auditObject, (IAuditAction)JRmfmVftHCSCb4Cfidj9(methodActionInfo), dictionary.Values.ToArray());
				default:
					AddParameterValuesFromExpressionToDictionary(dictionary, (MethodCallExpression)methodCall);
					num2 = 6;
					continue;
				case 1:
					if (!NWdRksft4FNXoQo3X40S(((MethodCallExpression)methodCall).Method, null))
					{
						dictionary = new Dictionary<string, object>();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 9;
						}
					}
					continue;
				case 9:
					if (methodActionInfo != null)
					{
						num2 = 8;
						continue;
					}
					goto case 4;
				case 6:
					auditObject = (IAuditObject)nbbw6Jftt3tYHfb4rhh3(Locator.GetServiceNotNull<IAuditManager>(), InterfaceActivator.UID(objectType));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 2;
					}
					continue;
				case 5:
					if (auditObject != null)
					{
						num2 = 3;
						continue;
					}
					goto case 7;
				}
				break;
			}
			methodActionInfo = ManagerActionInvokeProvider.GetMethodActionInfo((MethodInfo)WTbDQSft6wNZo4hlt3NB(methodCall));
			num = 9;
		}
	}

	public static TResult InvokeAction<TManager, TResult>([NotNull] this TManager manager, [NotNull] Expression<Func<TManager, TResult>> expression, [NotNull] Type objectType) where TManager : class, IEntityManager
	{
		if (manager == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -69821221));
		}
		return Locator.GetServiceNotNull<ActionDispatcherService>().InvokeAction(expression, objectType);
	}

	public static void InvokeAction<TManager>([NotNull] this TManager manager, [NotNull] Expression<Action<TManager>> expression, [NotNull] Type objectType) where TManager : class, IEntityManager
	{
		if (manager == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E7205C));
		}
		Locator.GetServiceNotNull<ActionDispatcherService>().InvokeAction(expression, objectType);
	}

	public static IAuditEventArgs GetActionInfoFor<TManager>([NotNull] this ActionDispatcherService service, [NotNull] Expression<Action<TManager>> expression) where TManager : IEntityManager
	{
		if (service == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC3D12D));
		}
		if (expression == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108654796));
		}
		if (!(expression.Body is MethodCallExpression methodCallExpression) || methodCallExpression.Method == null)
		{
			throw new ArgumentException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A38920)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B36A60D));
		}
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		AddParameterValuesFromExpressionToDictionary(dictionary, methodCallExpression);
		IAuditEventHolder methodActionInfo = ManagerActionInvokeProvider.GetMethodActionInfo(methodCallExpression.Method);
		AuditEventArgs auditEventArgs = new AuditEventArgs(methodActionInfo.Object, methodActionInfo.Action);
		foreach (KeyValuePair<string, object> item in (IEnumerable<KeyValuePair<string, object>>)dictionary)
		{
			auditEventArgs.ExtendedProperties.Add(item.Key, item.Value);
		}
		return auditEventArgs;
	}

	internal static void StartMethodInvocation([NotNull] this ActionDispatcherService service, [NotNull] MethodInfo method, params object[] methodArgs)
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
			{
				IContextBoundVariableService serviceNotNull = Locator.GetServiceNotNull<IContextBoundVariableService>();
				string key = ActionDispatcherService.GetKey(method, methodArgs);
				MyuZrmftAM1Ls64L9e5q(serviceNotNull, key, new object());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	internal static bool InterceptMethodInvocation([NotNull] this ActionDispatcherService service, [NotNull] MethodInfo method, params object[] methodArgs)
	{
		//Discarded unreachable code: IL_006f, IL_007e
		int num = 4;
		int num2 = num;
		object value = default(object);
		IContextBoundVariableService serviceNotNull = default(IContextBoundVariableService);
		string key = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (value == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 4:
				serviceNotNull = Locator.GetServiceNotNull<IContextBoundVariableService>();
				num2 = 3;
				break;
			case 5:
				MyuZrmftAM1Ls64L9e5q(serviceNotNull, key, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				if (serviceNotNull.TryGetValue<object>(key, out value))
				{
					num2 = 2;
					break;
				}
				goto case 1;
			default:
				return false;
			case 1:
				return true;
			case 3:
				key = ActionDispatcherService.GetKey(method, methodArgs);
				num2 = 6;
				break;
			}
		}
	}

	internal static void AddParameterValuesFromExpressionToDictionary([NotNull] IDictionary<string, object> rvd, [NotNull] MethodCallExpression call)
	{
		if (rvd == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12A5FAC7 ^ 0x12A0A69B));
		}
		if (call == null)
		{
			throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D1C1EE4 ^ 0x4D194282));
		}
		ParameterInfo[] parameters = call.Method.GetParameters();
		if (parameters.Length != 0)
		{
			for (int i = 0; i < parameters.Length; i++)
			{
				Expression expression = call.Arguments[i];
				object value = ((!(expression is ConstantExpression constantExpression)) ? CachedExpressionCompiler.Evaluate(expression) : constantExpression.Value);
				rvd.Add(parameters[i].Name, value);
			}
		}
	}

	internal static object YQSubbftDDhyhkVdsjXA(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object nbbw6Jftt3tYHfb4rhh3(object P_0, Guid uid)
	{
		return ((IAuditManager)P_0).GetObject(uid);
	}

	internal static bool A8YdtIftpRYo0BV1EjHQ()
	{
		return PJ0UYYft36P5PZ7rU1KQ == null;
	}

	internal static ActionDispatcherServiceExtensions wRIo6kftanRDLnG1VYrp()
	{
		return PJ0UYYft36P5PZ7rU1KQ;
	}

	internal static bool IGuO7fftwgXUW8qH3tOy(ActionCheckResult actionCheckResult)
	{
		return actionCheckResult;
	}

	internal static bool NWdRksft4FNXoQo3X40S(object P_0, object P_1)
	{
		return (MethodInfo)P_0 == (MethodInfo)P_1;
	}

	internal static object WTbDQSft6wNZo4hlt3NB(object P_0)
	{
		return ((MethodCallExpression)P_0).Method;
	}

	internal static object JRmfmVftHCSCb4Cfidj9(object P_0)
	{
		return ((IAuditEventHolder)P_0).Action;
	}

	internal static void MyuZrmftAM1Ls64L9e5q(object P_0, object P_1, object P_2)
	{
		((IAbstractBoundVariableService)P_0).Set((string)P_1, P_2);
	}
}
