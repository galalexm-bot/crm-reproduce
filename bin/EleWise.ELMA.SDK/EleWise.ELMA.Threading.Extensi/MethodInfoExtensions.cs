using System;
using System.Collections.Concurrent;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Threading.Extensions;

public static class MethodInfoExtensions
{
	private static readonly MethodInfo InvokeAsyncGenericInfo;

	private static readonly ConcurrentDictionary<Type, MethodInfo> InvokeAsyncGenericConstructedMethodCache;

	private static readonly MethodInfo InvokeValueAsyncGenericInfo;

	private static readonly ConcurrentDictionary<Type, MethodInfo> InvokeValueAsyncGenericConstructedMethodCache;

	internal static MethodInfoExtensions Hkk2XMBRJZUpEygOnNGA;

	[AsyncStateMachine(typeof(_003CInvokeActionAsync_003Ed__4))]
	public static Task InvokeActionAsync(this MethodInfo method, object target, params object[] arguments)
	{
		int num = 4;
		int num2 = num;
		AsyncTaskMethodBuilder _003C_003Et__builder = default(AsyncTaskMethodBuilder);
		_003CInvokeActionAsync_003Ed__4 stateMachine = default(_003CInvokeActionAsync_003Ed__4);
		while (true)
		{
			switch (num2)
			{
			case 7:
				_003C_003Et__builder = stateMachine._003C_003Et__builder;
				num2 = 2;
				break;
			case 5:
				stateMachine.arguments = arguments;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				stateMachine.target = target;
				num2 = 5;
				break;
			case 1:
				return stateMachine._003C_003Et__builder.Task;
			case 4:
				stateMachine.method = method;
				num2 = 3;
				break;
			case 6:
				stateMachine._003C_003E1__state = -1;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
				{
					num2 = 7;
				}
				break;
			default:
				stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
				num2 = 6;
				break;
			case 2:
				_003C_003Et__builder.Start(ref stateMachine);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	[AsyncStateMachine(typeof(_003CInvokeValueActionAsync_003Ed__5))]
	public static System.Threading.Tasks.ValueTask InvokeValueActionAsync(this MethodInfo method, object target, params object[] arguments)
	{
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0069: Unknown result type (might be due to invalid IL or missing references)
		int num = 5;
		int num2 = num;
		_003CInvokeValueActionAsync_003Ed__5 _003CInvokeValueActionAsync_003Ed__ = default(_003CInvokeValueActionAsync_003Ed__5);
		AsyncValueTaskMethodBuilder _003C_003Et__builder = default(AsyncValueTaskMethodBuilder);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003CInvokeValueActionAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder.Create();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				_003C_003Et__builder = _003CInvokeValueActionAsync_003Ed__._003C_003Et__builder;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 2;
				}
				break;
			default:
				_003CInvokeValueActionAsync_003Ed__._003C_003E1__state = -1;
				num2 = 3;
				break;
			case 2:
				((AsyncValueTaskMethodBuilder)(ref _003C_003Et__builder)).Start<_003CInvokeValueActionAsync_003Ed__5>(ref _003CInvokeValueActionAsync_003Ed__);
				num2 = 7;
				break;
			case 4:
				_003CInvokeValueActionAsync_003Ed__.target = target;
				num2 = 6;
				break;
			case 6:
				_003CInvokeValueActionAsync_003Ed__.arguments = arguments;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				_003CInvokeValueActionAsync_003Ed__.method = method;
				num2 = 4;
				break;
			case 7:
				return ((AsyncValueTaskMethodBuilder)(ref _003CInvokeValueActionAsync_003Ed__._003C_003Et__builder)).get_Task();
			}
		}
	}

	public static Task<object> InvokeFunctionAsync(this MethodInfo method, object target, params object[] arguments)
	{
		_003C_003Ec__DisplayClass6_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass6_0();
		Contract.ArgumentNotNull(method, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x51141F0B));
		Contract.ArgumentNotNull(target, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138160520 ^ -2138087586));
		CS_0024_003C_003E8__locals0.resultType = (method.ReturnType.IsAsync() ? method.ReturnType.GetGenericArguments()[0] : method.ReturnType);
		return (Task<object>)InvokeAsyncGenericConstructedMethodCache.GetOrAdd(CS_0024_003C_003E8__locals0.resultType, (Type type) => (MethodInfo)_003C_003Ec__DisplayClass6_0.QeipL3QvYD4QfKaeW0St(InvokeAsyncGenericInfo, new Type[1] { CS_0024_003C_003E8__locals0.resultType })).Invoke(null, new object[3] { method, target, arguments });
	}

	public static System.Threading.Tasks.ValueTask<object> InvokeValueFunctionAsync(this MethodInfo method, object target, params object[] arguments)
	{
		_003C_003Ec__DisplayClass7_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass7_0();
		Contract.ArgumentNotNull(method, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7459E02 ^ 0x7448314));
		Contract.ArgumentNotNull(target, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C15B5D));
		CS_0024_003C_003E8__locals0.resultType = (method.ReturnType.IsAsync() ? method.ReturnType.GetGenericArguments()[0] : method.ReturnType);
		return (System.Threading.Tasks.ValueTask<object>)InvokeValueAsyncGenericConstructedMethodCache.GetOrAdd(CS_0024_003C_003E8__locals0.resultType, (Type type) => (MethodInfo)_003C_003Ec__DisplayClass7_0.Q7foIdQvz6har2fiDvH5(InvokeValueAsyncGenericInfo, new Type[1] { CS_0024_003C_003E8__locals0.resultType })).Invoke(null, new object[3] { method, target, arguments });
	}

	[AsyncStateMachine(typeof(_003CInvokeAsyncGeneric_003Ed__8<>))]
	private static Task<object> InvokeAsyncGeneric<TResult>(object method, object target, params object[] arguments)
	{
		_003CInvokeAsyncGeneric_003Ed__8<TResult> stateMachine = default(_003CInvokeAsyncGeneric_003Ed__8<TResult>);
		stateMachine.method = (MethodInfo)method;
		stateMachine.target = target;
		stateMachine.arguments = arguments;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<object> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CInvokeValueAsyncGeneric_003Ed__9<>))]
	private static System.Threading.Tasks.ValueTask<object> InvokeValueAsyncGeneric<TResult>(object method, object target, params object[] arguments)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CInvokeValueAsyncGeneric_003Ed__9<TResult> _003CInvokeValueAsyncGeneric_003Ed__ = default(_003CInvokeValueAsyncGeneric_003Ed__9<TResult>);
		_003CInvokeValueAsyncGeneric_003Ed__.method = (MethodInfo)method;
		_003CInvokeValueAsyncGeneric_003Ed__.target = target;
		_003CInvokeValueAsyncGeneric_003Ed__.arguments = arguments;
		_003CInvokeValueAsyncGeneric_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<object>.Create();
		_003CInvokeValueAsyncGeneric_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<object> _003C_003Et__builder = _003CInvokeValueAsyncGeneric_003Ed__._003C_003Et__builder;
		_003C_003Et__builder.Start<_003CInvokeValueAsyncGeneric_003Ed__9<TResult>>(ref _003CInvokeValueAsyncGeneric_003Ed__);
		return _003CInvokeValueAsyncGeneric_003Ed__._003C_003Et__builder.get_Task();
	}

	static MethodInfoExtensions()
	{
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 5:
					InvokeValueAsyncGenericInfo = typeof(MethodInfoExtensions).GetMethod((string)QxmKduBRrugaqDMFRVkC(0x269E5FCA ^ 0x269F4294), BindingFlags.Static | BindingFlags.NonPublic);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					lBjR9kBRlPThsRLyLyet();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					InvokeValueAsyncGenericConstructedMethodCache = new ConcurrentDictionary<Type, MethodInfo>();
					num2 = 3;
					continue;
				case 4:
					InvokeAsyncGenericConstructedMethodCache = new ConcurrentDictionary<Type, MethodInfo>();
					num2 = 5;
					continue;
				}
				break;
			}
			InvokeAsyncGenericInfo = typeof(MethodInfoExtensions).GetMethod((string)QxmKduBRrugaqDMFRVkC(0x5A4C7B29 ^ 0x5A4D661F), BindingFlags.Static | BindingFlags.NonPublic);
			num = 4;
		}
	}

	internal static bool qmMocbBR9NrYlygGJT4b()
	{
		return Hkk2XMBRJZUpEygOnNGA == null;
	}

	internal static MethodInfoExtensions Pt3edKBRddNSElu0ikOI()
	{
		return Hkk2XMBRJZUpEygOnNGA;
	}

	internal static void lBjR9kBRlPThsRLyLyet()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object QxmKduBRrugaqDMFRVkC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
