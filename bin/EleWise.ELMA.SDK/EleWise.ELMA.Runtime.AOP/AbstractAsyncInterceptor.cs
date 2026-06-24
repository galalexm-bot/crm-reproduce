using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.AOP;

public abstract class AbstractAsyncInterceptor : IAsyncInterceptor, IInterceptor
{
	private sealed class InvocationAsync : IInvocationAsync, IInvocation
	{
		private static readonly ConcurrentDictionary<Type, MethodInfo> AsyncConstructedMethodCache;

		private readonly object baseInvocation;

		private readonly object invocationAsyncInfo;

		private static object r6qT6YQAgYusMPAbZHxM;

		public object[] Arguments => (object[])GetArguments(baseInvocation);

		public Type[] GenericArguments => ((IInvocation)baseInvocation).GenericArguments;

		public object InvocationTarget => kUoXOOQAULvUPW2fxjxn(baseInvocation);

		public MethodInfo Method => (MethodInfo)Bo5M87QAsxosoMA9G11U(baseInvocation);

		public MethodInfo MethodInvocationTarget => (MethodInfo)dbEOC5QAcMgoOF7VlwCd(baseInvocation);

		public object Proxy => XawM7xQAz8gheSYncpRe(baseInvocation);

		public object ReturnValue
		{
			get
			{
				return ((IInvocation)baseInvocation).get_ReturnValue();
			}
			set
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					default:
						return;
					case 1:
						((IInvocation)baseInvocation).set_ReturnValue(value);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 0;
						}
						break;
					case 0:
						return;
					}
				}
			}
		}

		public Type TargetType => GetTargetType(baseInvocation);

		public InvocationAsync(IInvocation baseInvocation)
		{
			//Discarded unreachable code: IL_005c, IL_0061
			SingletonReader.JJCZtPuTvSt();
			invocationAsyncInfo = dEAH01QAY0ciI0cGWXXs(typeof(InvocationAsync).TypeHandle).GetMethod(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889285330), BindingFlags.Instance | BindingFlags.NonPublic);
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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
				this.baseInvocation = baseInvocation;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num = 1;
				}
			}
		}

		public object GetArgumentValue(int index)
		{
			return n1WjlfQ7BW9sfBJHHXDa(baseInvocation, index);
		}

		public MethodInfo GetConcreteMethod()
		{
			return ((IInvocation)baseInvocation).GetConcreteMethod();
		}

		public MethodInfo GetConcreteMethodInvocationTarget()
		{
			return (MethodInfo)DCj7YAQ7W4D4DCWN8Lik(baseInvocation);
		}

		public void Proceed()
		{
			throw new NotImplementedException(SR.T((string)QAsAySQ7o5bf9puEDZMZ(-345420348 ^ -345230758), QAsAySQ7o5bf9puEDZMZ(0x2A7797B7 ^ 0x2A72178F), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921431671)));
		}

		IInvocationProceedInfo IInvocation.CaptureProceedInfo()
		{
			return ((IInvocation)baseInvocation).CaptureProceedInfo();
		}

		public void SetArgumentValue(int index, object value)
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
					tsghnMQ7b1oPKepLCLmr(baseInvocation, index, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		public Task ProceedAsync()
		{
			int num = 2;
			Type key = default(Type);
			System.Threading.Tasks.ValueTask valueTask = default(System.Threading.Tasks.ValueTask);
			IInvocationProceedInfo val = default(IInvocationProceedInfo);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 7:
						break;
					case 1:
						if (((MethodInfo)Bo5M87QAsxosoMA9G11U(baseInvocation)).ReturnType == TypeOf<Task>.Raw)
						{
							num2 = 3;
						}
						else if (!fTcNN9Q7EHlOpyVjBcQK(((IInvocation)baseInvocation).get_Method().ReturnType, TypeOf<System.Threading.Tasks.ValueTask>.Raw))
						{
							key = zc8I0lQ7fwrFD8MSKT2E(Bo5M87QAsxosoMA9G11U(baseInvocation)).GetGenericArguments()[0];
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
							{
								num2 = 0;
							}
						}
						else
						{
							num2 = 7;
						}
						continue;
					case 5:
						valueTask = (System.Threading.Tasks.ValueTask)((IInvocation)baseInvocation).get_ReturnValue();
						num2 = 4;
						continue;
					case 2:
						val = (IInvocationProceedInfo)k8TdDlQ7hMrBpEoVOWC8(baseInvocation);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 1;
						}
						continue;
					case 3:
						QlZS8eQ7G221qLGpKN5K(val);
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 6;
						}
						continue;
					default:
						return (Task)QCN1YHQ7Q3w8wc6rHtcU(AsyncConstructedMethodCache.GetOrAdd(key, (Type type) => ((MethodInfo)invocationAsyncInfo).MakeGenericMethod(new Type[1] { type })), this, new object[2] { baseInvocation, val });
					case 4:
						return valueTask.AsTask();
					case 6:
						return (Task)((IInvocation)baseInvocation).get_ReturnValue();
					}
					break;
				}
				QlZS8eQ7G221qLGpKN5K(val);
				num = 5;
			}
		}

		[AsyncStateMachine(typeof(_003CExecuteInvocationAsync_003Ed__28<>))]
		private Task ExecuteInvocationAsync<TResult>(IInvocation invocation, IInvocationProceedInfo invocationProceedInfo)
		{
			_003CExecuteInvocationAsync_003Ed__28<TResult> stateMachine = default(_003CExecuteInvocationAsync_003Ed__28<TResult>);
			stateMachine.invocation = invocation;
			stateMachine.invocationProceedInfo = invocationProceedInfo;
			stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder.Create();
			stateMachine._003C_003E1__state = -1;
			AsyncTaskMethodBuilder _003C_003Et__builder = stateMachine._003C_003Et__builder;
			_003C_003Et__builder.Start(ref stateMachine);
			return stateMachine._003C_003Et__builder.Task;
		}

		static InvocationAsync()
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return;
				default:
					AsyncConstructedMethodCache = new ConcurrentDictionary<Type, MethodInfo>();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 1;
					}
					break;
				case 1:
					K1jeFAQ7C449ogy4JQcQ();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static Type dEAH01QAY0ciI0cGWXXs(RuntimeTypeHandle P_0)
		{
			return Type.GetTypeFromHandle(P_0);
		}

		internal static bool dFNWZ0QA5SvSkQYqRnsk()
		{
			return r6qT6YQAgYusMPAbZHxM == null;
		}

		internal static InvocationAsync BG3yvSQAjqiqWY2kjeps()
		{
			return (InvocationAsync)r6qT6YQAgYusMPAbZHxM;
		}

		internal static object GetArguments(object P_0)
		{
			return ((IInvocation)P_0).Arguments;
		}

		internal static object kUoXOOQAULvUPW2fxjxn(object P_0)
		{
			return ((IInvocation)P_0).get_InvocationTarget();
		}

		internal static object Bo5M87QAsxosoMA9G11U(object P_0)
		{
			return ((IInvocation)P_0).get_Method();
		}

		internal static object dbEOC5QAcMgoOF7VlwCd(object P_0)
		{
			return ((IInvocation)P_0).get_MethodInvocationTarget();
		}

		internal static object XawM7xQAz8gheSYncpRe(object P_0)
		{
			return ((IInvocation)P_0).get_Proxy();
		}

		internal static Type GetTargetType(object P_0)
		{
			return ((IInvocation)P_0).TargetType;
		}

		internal static object n1WjlfQ7BW9sfBJHHXDa(object P_0, int P_1)
		{
			return ((IInvocation)P_0).GetArgumentValue(P_1);
		}

		internal static object DCj7YAQ7W4D4DCWN8Lik(object P_0)
		{
			return ((IInvocation)P_0).GetConcreteMethodInvocationTarget();
		}

		internal static object QAsAySQ7o5bf9puEDZMZ(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void tsghnMQ7b1oPKepLCLmr(object P_0, int P_1, object P_2)
		{
			((IInvocation)P_0).SetArgumentValue(P_1, P_2);
		}

		internal static object k8TdDlQ7hMrBpEoVOWC8(object P_0)
		{
			return ((IInvocation)P_0).CaptureProceedInfo();
		}

		internal static void QlZS8eQ7G221qLGpKN5K(object P_0)
		{
			((IInvocationProceedInfo)P_0).Invoke();
		}

		internal static bool fTcNN9Q7EHlOpyVjBcQK(Type P_0, Type P_1)
		{
			return P_0 == P_1;
		}

		internal static Type zc8I0lQ7fwrFD8MSKT2E(object P_0)
		{
			return ((MethodInfo)P_0).ReturnType;
		}

		internal static object QCN1YHQ7Q3w8wc6rHtcU(object P_0, object P_1, object P_2)
		{
			return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
		}

		internal static void K1jeFAQ7C449ogy4JQcQ()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private readonly MethodInfo executeInterceptAsyncInfo;

	private static readonly ConcurrentDictionary<Type, MethodInfo> ExecuteInterceptAsyncConstructedMethodCache;

	private readonly MethodInfo executeInterceptForValueTaskAsyncInfo;

	private static readonly ConcurrentDictionary<Type, MethodInfo> ExecuteInterceptForValueTaskAsyncConstructedMethodCache;

	internal static AbstractAsyncInterceptor EywYtWWPkX5g3mnGGCRC;

	public abstract void Intercept(IInvocation invocation);

	public abstract Task InterceptAsync(IInvocationAsync invocation, CancellationToken cancellationToken);

	[DebuggerHidden]
	void IInterceptor.Intercept(IInvocation invocation)
	{
		//Discarded unreachable code: IL_01cf, IL_01d9, IL_01e8, IL_0230, IL_023f
		int num = 3;
		int num2 = num;
		object obj2 = default(object);
		Type key = default(Type);
		MethodInfo methodInfo = default(MethodInfo);
		while (true)
		{
			object obj;
			MethodInfo orAdd;
			switch (num2)
			{
			default:
				return;
			case 9:
				if (S5B6OnWPtGXPJZAcuknS(Md2NKGWPekbV6LhaloYC(hKYSlvWP2O7Rf8pk7Cor(invocation)).GetGenericTypeDefinition(), ClGAKcWPDgF83o8UHrC2(TypeOf.Task1)))
				{
					num2 = 11;
					continue;
				}
				goto case 8;
			case 2:
				yj6MwIWP18usNMOGVBFX(this, invocation);
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 7;
				}
				continue;
			case 3:
			{
				if (!keBxbIWPPyatlLQdfAS1(Md2NKGWPekbV6LhaloYC(hKYSlvWP2O7Rf8pk7Cor(invocation))))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				object obj3 = Csy7xEWPNQNmHGbW1unc(invocation);
				if (obj3 == null)
				{
					num2 = 6;
					continue;
				}
				obj = ((IEnumerable<object>)obj3).FirstOrDefault((object argument) => argument is CancellationToken);
				goto IL_0299;
			}
			case 1:
				jLejWXWPpE7uFAysjx6g(invocation, InterceptAsync(new InvocationAsync(invocation), (CancellationToken)obj2));
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				continue;
			case 10:
				return;
			case 15:
				if (((MethodInfo)hKYSlvWP2O7Rf8pk7Cor(invocation)).ReturnType == TypeOf<System.Threading.Tasks.ValueTask>.Raw)
				{
					num2 = 13;
					continue;
				}
				key = ((MethodInfo)hKYSlvWP2O7Rf8pk7Cor(invocation)).ReturnType.GetGenericArguments()[0];
				num2 = 9;
				continue;
			case 13:
				jLejWXWPpE7uFAysjx6g(invocation, new System.Threading.Tasks.ValueTask((Task)D7fwKxWPaxEg6jachiyn(this, new InvocationAsync(invocation), (CancellationToken)obj2)));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 2;
				}
				continue;
			case 4:
				if (!(Md2NKGWPekbV6LhaloYC(invocation.get_Method()) == TypeOf<Task>.Raw))
				{
					num2 = 15;
					continue;
				}
				goto case 1;
			case 5:
				return;
			case 8:
				orAdd = ExecuteInterceptForValueTaskAsyncConstructedMethodCache.GetOrAdd(key, (Type type) => (MethodInfo)MxmervWPHiKLdxtGvSMf(executeInterceptForValueTaskAsyncInfo, new Type[1] { type }));
				break;
			case 0:
				return;
			case 14:
				jLejWXWPpE7uFAysjx6g(invocation, VqLJ4jWPwtMcbIwIekPT(methodInfo, this, new object[2] { invocation, obj2 }));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				continue;
			case 12:
				return;
			case 6:
				obj = null;
				goto IL_0299;
			case 7:
				obj = E0ipIIWP3SAsdZWGk4wC();
				goto IL_02c9;
			case 11:
				{
					orAdd = ExecuteInterceptAsyncConstructedMethodCache.GetOrAdd(key, (Type type) => (MethodInfo)MxmervWPHiKLdxtGvSMf(executeInterceptAsyncInfo, new Type[1] { type }));
					break;
				}
				IL_02c9:
				obj2 = obj;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 4;
				}
				continue;
				IL_0299:
				if (obj != null)
				{
					goto IL_02c9;
				}
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 2;
				}
				continue;
			}
			methodInfo = orAdd;
			num2 = 14;
		}
	}

	[AsyncStateMachine(typeof(_003CExecuteInterceptAsync_003Ed__8<>))]
	private Task<TResult> ExecuteInterceptAsync<TResult>(IInvocation invocation, CancellationToken cancellationToken)
	{
		_003CExecuteInterceptAsync_003Ed__8<TResult> stateMachine = default(_003CExecuteInterceptAsync_003Ed__8<TResult>);
		stateMachine._003C_003E4__this = this;
		stateMachine.invocation = invocation;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<TResult>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<TResult> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CExecuteInterceptForValueTaskAsync_003Ed__9<>))]
	private unsafe System.Threading.Tasks.ValueTask<TResult> ExecuteInterceptForValueTaskAsync<TResult>(IInvocation invocation, CancellationToken cancellationToken)
	{
		//IL_001a: Unknown result type (might be due to invalid IL or missing references)
		//IL_001f: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Unknown result type (might be due to invalid IL or missing references)
		_003CExecuteInterceptForValueTaskAsync_003Ed__9<TResult> _003CExecuteInterceptForValueTaskAsync_003Ed__ = default(_003CExecuteInterceptForValueTaskAsync_003Ed__9<TResult>);
		_003CExecuteInterceptForValueTaskAsync_003Ed__._003C_003E4__this = this;
		_003CExecuteInterceptForValueTaskAsync_003Ed__.invocation = invocation;
		_003CExecuteInterceptForValueTaskAsync_003Ed__.cancellationToken = cancellationToken;
		_003CExecuteInterceptForValueTaskAsync_003Ed__._003C_003Et__builder = AsyncValueTaskMethodBuilder<TResult>.Create();
		_003CExecuteInterceptForValueTaskAsync_003Ed__._003C_003E1__state = -1;
		AsyncValueTaskMethodBuilder<TResult> _003C_003Et__builder = _003CExecuteInterceptForValueTaskAsync_003Ed__._003C_003Et__builder;
		((AsyncValueTaskMethodBuilder<_003CExecuteInterceptForValueTaskAsync_003Ed__9<TResult>>*)(&_003C_003Et__builder))->Start<_003CExecuteInterceptForValueTaskAsync_003Ed__9<TResult>>(ref _003CExecuteInterceptForValueTaskAsync_003Ed__);
		return _003CExecuteInterceptForValueTaskAsync_003Ed__._003C_003Et__builder.get_Task();
	}

	protected AbstractAsyncInterceptor()
	{
		//Discarded unreachable code: IL_008e, IL_0093
		SingletonReader.JJCZtPuTvSt();
		executeInterceptAsyncInfo = typeof(AbstractAsyncInterceptor).GetMethod((string)l56tFQWP4aniNl0oUnJr(-521266112 ^ -521400208), BindingFlags.Instance | BindingFlags.NonPublic);
		executeInterceptForValueTaskAsyncInfo = typeof(AbstractAsyncInterceptor).GetMethod((string)l56tFQWP4aniNl0oUnJr(0x7C1EE318 ^ 0x7C1CEF46), BindingFlags.Instance | BindingFlags.NonPublic);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static AbstractAsyncInterceptor()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				gNLIFLWP6a8xcUXAdWbK();
				num2 = 2;
				break;
			case 2:
				ExecuteInterceptAsyncConstructedMethodCache = new ConcurrentDictionary<Type, MethodInfo>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				ExecuteInterceptForValueTaskAsyncConstructedMethodCache = new ConcurrentDictionary<Type, MethodInfo>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object hKYSlvWP2O7Rf8pk7Cor(object P_0)
	{
		return ((IInvocation)P_0).get_Method();
	}

	internal static Type Md2NKGWPekbV6LhaloYC(object P_0)
	{
		return ((MethodInfo)P_0).ReturnType;
	}

	internal static bool keBxbIWPPyatlLQdfAS1(Type type)
	{
		return type.IsAsync();
	}

	internal static void yj6MwIWP18usNMOGVBFX(object P_0, object P_1)
	{
		((AbstractAsyncInterceptor)P_0).Intercept((IInvocation)P_1);
	}

	internal static object Csy7xEWPNQNmHGbW1unc(object P_0)
	{
		return ((IInvocation)P_0).get_Arguments();
	}

	internal static CancellationToken E0ipIIWP3SAsdZWGk4wC()
	{
		return CancellationToken.None;
	}

	internal static void jLejWXWPpE7uFAysjx6g(object P_0, object P_1)
	{
		((IInvocation)P_0).set_ReturnValue(P_1);
	}

	internal static object D7fwKxWPaxEg6jachiyn(object P_0, object P_1, CancellationToken cancellationToken)
	{
		return ((AbstractAsyncInterceptor)P_0).InterceptAsync((IInvocationAsync)P_1, cancellationToken);
	}

	internal static Type ClGAKcWPDgF83o8UHrC2(object P_0)
	{
		return ((RipeType)P_0).Raw;
	}

	internal static bool S5B6OnWPtGXPJZAcuknS(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object VqLJ4jWPwtMcbIwIekPT(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static bool HaIY0KWPnDja4XIT4PtS()
	{
		return EywYtWWPkX5g3mnGGCRC == null;
	}

	internal static AbstractAsyncInterceptor TNDmSiWPO5i5xP3aCIQQ()
	{
		return EywYtWWPkX5g3mnGGCRC;
	}

	internal static object l56tFQWP4aniNl0oUnJr(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void gNLIFLWP6a8xcUXAdWbK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object MxmervWPHiKLdxtGvSMf(object P_0, object P_1)
	{
		return ((MethodInfo)P_0).MakeGenericMethod((Type[])P_1);
	}
}
