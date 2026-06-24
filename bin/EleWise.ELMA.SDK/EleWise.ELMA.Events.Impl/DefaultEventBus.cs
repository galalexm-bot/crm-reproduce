using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Events.Impl;

internal class DefaultEventBus : IEventBusAsync, IEventBus, IEventHandlerSubscribeService
{
	private class UnSubscriber : IDisposable
	{
		private readonly object defaultEventBus;

		private readonly object eventHandler;

		internal static object rhM1dO88zPYrAf6vkCTL;

		public UnSubscriber(DefaultEventBus defaultEventBus, IEventHandler eventHandler)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			KEfJhq8ZWV8KG7xvg75Y();
			base._002Ector();
			int num = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
			{
				num = 0;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					this.eventHandler = eventHandler;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num = 0;
					}
					break;
				case 2:
					this.defaultEventBus = defaultEventBus;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num = 1;
					}
					break;
				}
			}
		}

		public void Dispose()
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
					cPMEmg8ZosZLe9ekjwYh(defaultEventBus, eventHandler);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void KEfJhq8ZWV8KG7xvg75Y()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool flLxF18ZFKkjpiWTeMOK()
		{
			return rhM1dO88zPYrAf6vkCTL == null;
		}

		internal static UnSubscriber Pr9c5E8ZBOTewLVvCYIA()
		{
			return (UnSubscriber)rhM1dO88zPYrAf6vkCTL;
		}

		internal static void cPMEmg8ZosZLe9ekjwYh(object P_0, object P_1)
		{
			((DefaultEventBus)P_0).RemoveEventHandler((IEventHandler)P_1);
		}
	}

	private readonly Func<IEnumerable<LazyEventHandler>> eventHandlersFunc;

	private readonly List<IEventHandler> eventHandlers;

	private readonly ReaderWriterLockSlim eventHandlersLock;

	internal static DefaultEventBus pwEhgKGY4LKsLwZm8a8l;

	public ILogger Logger
	{
		[CompilerGenerated]
		get
		{
			return _003CLogger_003Ek__BackingField;
		}
		[CompilerGenerated]
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
				case 0:
					return;
				case 1:
					_003CLogger_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DefaultEventBus(Func<IEnumerable<LazyEventHandler>> eventHandlersFunc)
	{
		SingletonReader.JJCZtPuTvSt();
		eventHandlers = new List<IEventHandler>();
		eventHandlersLock = new ReaderWriterLockSlim();
		base._002Ector();
		this.eventHandlersFunc = eventHandlersFunc;
		Logger = NullLogger.Instance;
	}

	public IDisposable Subscribe(IEventHandler eventHandler)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				AddEventHandler(eventHandler);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				sbjR1LGY7antC5NT79rM(eventHandler, kUEfU5GYAOSIVUfBHc5h(-957824448 ^ -957555108));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return new UnSubscriber(this, eventHandler);
			}
		}
	}

	public IEnumerable Notify(string messageName, IDictionary<string, object> eventData)
	{
		return NotifyHandlers(messageName, eventData, failFast: true).ToArray();
	}

	[AsyncStateMachine(typeof(_003CNotifyAsync_003Ed__10))]
	public Task<IEnumerable> NotifyAsync(string messageName, IDictionary<string, object> eventData, CancellationToken cancellationToken = default(CancellationToken))
	{
		_003CNotifyAsync_003Ed__10 stateMachine = default(_003CNotifyAsync_003Ed__10);
		stateMachine._003C_003E4__this = this;
		stateMachine.messageName = messageName;
		stateMachine.eventData = eventData;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IEnumerable> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[IteratorStateMachine(typeof(_003CNotifyHandlers_003Ed__11))]
	private IEnumerable<object> NotifyHandlers(string messageName, IDictionary<string, object> eventData, bool failFast)
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CNotifyHandlers_003Ed__11(-2)
		{
			_003C_003E4__this = this,
			_003C_003E3__messageName = messageName,
			_003C_003E3__eventData = eventData,
			_003C_003E3__failFast = failFast
		};
	}

	[AsyncStateMachine(typeof(_003CNotifyHandlersAsync_003Ed__12))]
	private Task<IEnumerable<object>> NotifyHandlersAsync(string messageName, IDictionary<string, object> eventData, bool failFast, CancellationToken cancellationToken)
	{
		_003CNotifyHandlersAsync_003Ed__12 stateMachine = default(_003CNotifyHandlersAsync_003Ed__12);
		stateMachine._003C_003E4__this = this;
		stateMachine.messageName = messageName;
		stateMachine.eventData = eventData;
		stateMachine.failFast = failFast;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable<object>>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IEnumerable<object>> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private bool TryNotifyHandler(LazyEventHandler eventHandler, string messageName, string interfaceName, string methodName, IDictionary<string, object> eventData, bool failFast, out IEnumerable returnValue)
	{
		try
		{
			return TryInvoke(eventHandler, interfaceName, methodName, eventData, out returnValue);
		}
		catch (Exception ex)
		{
			Logger.Error(string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x835680A), messageName, eventHandler.GetType().FullName, ex.GetType().Name), ex);
			if (failFast)
			{
				throw;
			}
			returnValue = null;
			return false;
		}
	}

	[AsyncStateMachine(typeof(_003CTryNotifyHandlerAsync_003Ed__14))]
	private Task<IEnumerable> TryNotifyHandlerAsync(LazyEventHandler eventHandler, string messageName, string interfaceName, string methodName, IDictionary<string, object> eventData, bool failFast, CancellationToken cancellationToken)
	{
		_003CTryNotifyHandlerAsync_003Ed__14 stateMachine = default(_003CTryNotifyHandlerAsync_003Ed__14);
		stateMachine._003C_003E4__this = this;
		stateMachine.eventHandler = eventHandler;
		stateMachine.messageName = messageName;
		stateMachine.interfaceName = interfaceName;
		stateMachine.methodName = methodName;
		stateMachine.eventData = eventData;
		stateMachine.failFast = failFast;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IEnumerable> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool TryInvoke(LazyEventHandler eventHandler, string interfaceName, string methodName, IDictionary<string, object> arguments, out IEnumerable returnValue)
	{
		Type[] interfaces = eventHandler.EventHandlerType.GetInterfaces();
		foreach (Type type in interfaces)
		{
			if (string.Equals(type.Name, interfaceName, StringComparison.OrdinalIgnoreCase))
			{
				return TryInvokeMethod(eventHandler.Value, type, methodName, arguments, out returnValue);
			}
		}
		returnValue = null;
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[AsyncStateMachine(typeof(_003CTryInvokeAsync_003Ed__16))]
	private Task<IEnumerable> TryInvokeAsync(LazyEventHandler eventHandler, string interfaceName, string methodName, IDictionary<string, object> arguments, CancellationToken cancellationToken)
	{
		_003CTryInvokeAsync_003Ed__16 stateMachine = default(_003CTryInvokeAsync_003Ed__16);
		stateMachine._003C_003E4__this = this;
		stateMachine.eventHandler = eventHandler;
		stateMachine.interfaceName = interfaceName;
		stateMachine.methodName = methodName;
		stateMachine.arguments = arguments;
		stateMachine.cancellationToken = cancellationToken;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IEnumerable> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	private bool TryInvokeMethod(IEventHandler eventHandler, Type interfaceType, string methodName, IDictionary<string, object> arguments, out IEnumerable returnValue)
	{
		MethodInfo matchingMethod = GetMatchingMethod(interfaceType, methodName, arguments);
		if (matchingMethod != null)
		{
			List<object> list = new List<object>();
			ParameterInfo[] parameters = matchingMethod.GetParameters();
			foreach (ParameterInfo parameterInfo in parameters)
			{
				list.Add(arguments[parameterInfo.Name]);
			}
			object obj = matchingMethod.Invoke(eventHandler, list.ToArray());
			returnValue = obj as IEnumerable;
			if (returnValue == null && obj != null)
			{
				returnValue = new object[1] { obj };
			}
			return true;
		}
		returnValue = null;
		return false;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[AsyncStateMachine(typeof(_003CTryInvokeMethodAsync_003Ed__18))]
	private Task<IEnumerable> TryInvokeMethodAsync(IEventHandler eventHandler, Type interfaceType, string methodName, IDictionary<string, object> arguments, CancellationToken cancellationToken)
	{
		_003CTryInvokeMethodAsync_003Ed__18 stateMachine = default(_003CTryInvokeMethodAsync_003Ed__18);
		stateMachine._003C_003E4__this = this;
		stateMachine.eventHandler = eventHandler;
		stateMachine.interfaceType = interfaceType;
		stateMachine.methodName = methodName;
		stateMachine.arguments = arguments;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<IEnumerable>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<IEnumerable> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	[AsyncStateMachine(typeof(_003CInvokeAsyncWithResult_003Ed__19))]
	private Task<object> InvokeAsyncWithResult(MethodInfo method, IEventHandler eventHandler, object[] parameters)
	{
		_003CInvokeAsyncWithResult_003Ed__19 stateMachine = default(_003CInvokeAsyncWithResult_003Ed__19);
		stateMachine.method = method;
		stateMachine.eventHandler = eventHandler;
		stateMachine.parameters = parameters;
		stateMachine._003C_003Et__builder = AsyncTaskMethodBuilder<object>.Create();
		stateMachine._003C_003E1__state = -1;
		AsyncTaskMethodBuilder<object> _003C_003Et__builder = stateMachine._003C_003Et__builder;
		_003C_003Et__builder.Start(ref stateMachine);
		return stateMachine._003C_003Et__builder.Task;
	}

	private MethodInfo GetMatchingMethod(Type interfaceType, string methodName, IDictionary<string, object> arguments)
	{
		List<MethodInfo> list = new List<MethodInfo>(interfaceType.GetMethods());
		List<MethodInfo> list2 = new List<MethodInfo>(list);
		foreach (MethodInfo item in list)
		{
			if (string.Equals(item.Name, methodName, StringComparison.OrdinalIgnoreCase))
			{
				ParameterInfo[] parameters = item.GetParameters();
				foreach (ParameterInfo parameterInfo in parameters)
				{
					if (!arguments.ContainsKey(parameterInfo.Name))
					{
						list2.Remove(item);
						break;
					}
				}
			}
			else
			{
				list2.Remove(item);
			}
		}
		if (list2.Count != 0)
		{
			return list2.OrderBy((MethodInfo x) => ((Array)_003C_003Ec.lgcWRD8Z806yBUmvLsB5(x)).Length).Last();
		}
		return null;
	}

	private void AddEventHandler(IEventHandler eventHandler)
	{
		//Discarded unreachable code: IL_0075, IL_00b1, IL_00c4, IL_00d3
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				HwEhRYGYxJQjfF8Jr5uc(eventHandlersLock);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				eventHandlers.Add(eventHandler);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				return;
			}
			finally
			{
				zoPa5vGY00MR4hUjSOif(eventHandlersLock);
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	private void RemoveEventHandler(IEventHandler eventHandler)
	{
		//Discarded unreachable code: IL_0050, IL_008c, IL_009f, IL_00ae
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 1:
				HwEhRYGYxJQjfF8Jr5uc(eventHandlersLock);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				eventHandlers.Remove(eventHandler);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				case 0:
					break;
				}
				return;
			}
			finally
			{
				zoPa5vGY00MR4hUjSOif(eventHandlersLock);
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
			}
		}
	}

	private LazyEventHandler[] CloneEventHandlers()
	{
		//Discarded unreachable code: IL_009f, IL_00db, IL_00ee, IL_00fd
		int num = 2;
		int num2 = num;
		LazyEventHandler[] array = default(LazyEventHandler[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				uNd67aGYmxN9FoCej8pH(eventHandlersLock);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return array;
			case 1:
				try
				{
					array = eventHandlers.Select((IEventHandler h) => new LazyEventHandler(h)).ToArray();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => array, 
						_ => array, 
					};
				}
				finally
				{
					FtlELMGYy6FUjhMeTlyp(eventHandlersLock);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			}
		}
	}

	internal static bool iGdv4bGY655Ft9eZVxNY()
	{
		return pwEhgKGY4LKsLwZm8a8l == null;
	}

	internal static DefaultEventBus cipuvuGYHluQTaSBtsMc()
	{
		return pwEhgKGY4LKsLwZm8a8l;
	}

	internal static object kUEfU5GYAOSIVUfBHc5h(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void sbjR1LGY7antC5NT79rM(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void HwEhRYGYxJQjfF8Jr5uc(object P_0)
	{
		((ReaderWriterLockSlim)P_0).EnterWriteLock();
	}

	internal static void zoPa5vGY00MR4hUjSOif(object P_0)
	{
		((ReaderWriterLockSlim)P_0).ExitWriteLock();
	}

	internal static void uNd67aGYmxN9FoCej8pH(object P_0)
	{
		((ReaderWriterLockSlim)P_0).EnterReadLock();
	}

	internal static void FtlELMGYy6FUjhMeTlyp(object P_0)
	{
		((ReaderWriterLockSlim)P_0).ExitReadLock();
	}
}
