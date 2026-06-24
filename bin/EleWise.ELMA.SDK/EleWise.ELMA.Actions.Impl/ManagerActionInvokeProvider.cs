using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Events.Audit;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Events.Audit;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.SDK;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Actions.Impl;

[Component]
internal sealed class ManagerActionInvokeProvider : IActionInvokerProvider
{
	private class PropertyInfoTypeComparer : IEqualityComparer<ParameterInfo>
	{
		private static object yXr1bQZf0c3FN9kicKER;

		public bool Equals(ParameterInfo x, ParameterInfo y)
		{
			//Discarded unreachable code: IL_0097, IL_00a6, IL_00d7, IL_00e6
			int num = 5;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return true;
				case 2:
				case 7:
					return false;
				default:
					if (y != null)
					{
						return D3WjX1ZfJOnSqeMFaiRJ(AOWND6ZfMVq6f7QeFe2s(x), AOWND6ZfMVq6f7QeFe2s(y));
					}
					num2 = 2;
					break;
				case 6:
					if (y != null)
					{
						num2 = 3;
						break;
					}
					goto case 1;
				case 5:
					if (x != null)
					{
						num2 = 4;
						break;
					}
					goto case 6;
				case 3:
				case 4:
					if (x != y)
					{
						if (x == null)
						{
							num2 = 7;
							break;
						}
						goto default;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}

		public int GetHashCode(ParameterInfo obj)
		{
			//Discarded unreachable code: IL_0056, IL_0065
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return 0;
				case 1:
					return obj.GetHashCode();
				case 2:
					if (obj != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto default;
				}
			}
		}

		public PropertyInfoTypeComparer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static Type AOWND6ZfMVq6f7QeFe2s(object P_0)
		{
			return ((ParameterInfo)P_0).ParameterType;
		}

		internal static bool D3WjX1ZfJOnSqeMFaiRJ(Type P_0, Type P_1)
		{
			return P_0 == P_1;
		}

		internal static bool L3FRmkZfmdqaDiTqEpt8()
		{
			return yXr1bQZf0c3FN9kicKER == null;
		}

		internal static PropertyInfoTypeComparer orsKLkZfyGjv5h7O5RAR()
		{
			return (PropertyInfoTypeComparer)yXr1bQZf0c3FN9kicKER;
		}
	}

	private readonly ILazy<ActionDispatcherService> actionDispatcherService;

	private readonly IEntityManagerTypesStorage entityManagerTypesStorage;

	private readonly EntityAuditObjectProvider entityAuditObjectProvider;

	public const BindingFlags INVOKE_METHOD_FLAGS = BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod;

	public const BindingFlags CHECK_METHOD_FLAGS = BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod;

	private readonly HashSet<Type> invokerManagers;

	private IEnumerable<IActionInvoker> invokers;

	private static ManagerActionInvokeProvider pomrdjf481NOIFykBxV7;

	public static IAuditEventHolder GetActionInfoForMethod([NotNull] MethodInfo method)
	{
		return GetActionInfo<ActionMethodAttribute>(method);
	}

	public static IAuditEventHolder GetActionInfoForCheck([NotNull] MethodInfo method)
	{
		return GetActionInfo<ActionCheckAttribute>(method);
	}

	public static IAuditEventHolder GetMethodActionInfo([NotNull] MethodInfo method)
	{
		int num = 1;
		int num2 = num;
		IAuditEventHolder auditEventHolder;
		while (true)
		{
			switch (num2)
			{
			case 1:
				auditEventHolder = GetActionInfoForMethod(method);
				if (auditEventHolder != null)
				{
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				continue;
			default:
				auditEventHolder = GetActionInfoForCheck(method);
				break;
			}
			break;
		}
		return auditEventHolder;
	}

	private static IAuditEventHolder GetActionInfo<TAttrib>([NotNull] MethodInfo method) where TAttrib : ActionImplAttribute
	{
		Contract.ArgumentNotNull(method, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606721014));
		TAttrib attribute = AttributeHelper<TAttrib>.GetAttribute(method, inherited: true);
		Type declaringType = method.DeclaringType;
		IAuditEventHolder result = null;
		if (attribute != null && declaringType != null)
		{
			if (attribute.AuditObjectUid == Guid.Empty)
			{
				Type @interface = declaringType.GetInterface(EleWise.ELMA.SDK.TypeOf.IEntityManager2.FullName);
				if (!(@interface != null))
				{
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575813858), EleWise.ELMA.SDK.TypeOf.IEntityManager2.FullName, declaringType.FullName));
				}
				Type type = @interface.GetGenericArguments()[0];
				IAuditObject @object = Locator.GetServiceNotNull<EntityAuditObjectProvider>().GetObject(InterfaceActivator.UID(type));
				if (@object == null)
				{
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3652520), type.FullName));
				}
				attribute.AuditObjectUid = @object.Uid;
			}
			IAuditObject object2 = attribute.GetObject();
			IAuditAction action = attribute.GetAction();
			result = new AuditEventHolder(object2, action);
		}
		return result;
	}

	private IEnumerable<IActionInvoker> GetInvokers([NotNull] Type managerType)
	{
		_003C_003Ec__DisplayClass12_2 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_0();
		CS_0024_003C_003E8__locals0.managerType = managerType;
		CS_0024_003C_003E8__locals0._003C_003E4__this = this;
		Contract.ArgumentNotNull(CS_0024_003C_003E8__locals0.managerType, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638754521));
		CS_0024_003C_003E8__locals0.invokeMethods = new List<Tuple<MethodInfo, IAuditAction, IAuditObject>>();
		CS_0024_003C_003E8__locals0.checkMethods = new List<Tuple<MethodInfo, IAuditAction, IAuditObject>>();
		MethodInfo[] methods = CS_0024_003C_003E8__locals0.managerType.GetMethods(BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.InvokeMethod);
		foreach (MethodInfo methodInfo in methods)
		{
			foreach (ActionImplAttribute attribute in AttributeHelper<ActionImplAttribute>.GetAttributes(methodInfo, inherited: true))
			{
				if (attribute.AuditObjectUid == Guid.Empty)
				{
					Type @interface = CS_0024_003C_003E8__locals0.managerType.GetInterface(EleWise.ELMA.SDK.TypeOf.IEntityManager2.FullName);
					if (@interface != null)
					{
						Type t = @interface.GetGenericArguments()[0];
						IAuditObject @object = entityAuditObjectProvider.GetObject(InterfaceActivator.UID(t));
						if (@object != null)
						{
							attribute.AuditObjectUid = @object.Uid;
						}
					}
				}
				if (!(attribute.AuditObjectUid == Guid.Empty))
				{
					IAuditObject object2 = attribute.GetObject();
					IAuditAction action = attribute.GetAction();
					((attribute is ActionMethodAttribute) ? CS_0024_003C_003E8__locals0.invokeMethods : CS_0024_003C_003E8__locals0.checkMethods).Add(new Tuple<MethodInfo, IAuditAction, IAuditObject>(methodInfo, action, object2));
				}
			}
		}
		Tuple<MethodInfo, IAuditAction, IAuditObject> tuple = CS_0024_003C_003E8__locals0.checkMethods.FirstOrDefault(delegate(Tuple<MethodInfo, IAuditAction, IAuditObject> method)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_1();
			CS_0024_003C_003E8__locals0.method = method;
			return !CS_0024_003C_003E8__locals0.invokeMethods.Any((Tuple<MethodInfo, IAuditAction, IAuditObject> invokeMethod) => invokeMethod.Item2.Uid == CS_0024_003C_003E8__locals0.method.Item2.Uid && invokeMethod.Item3.Uid == CS_0024_003C_003E8__locals0.method.Item3.Uid && invokeMethod.Item1.ReturnType.IsAsync() == CS_0024_003C_003E8__locals0.method.Item1.ReturnType.IsAsync());
		});
		if (tuple != null)
		{
			throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E17F8B), TypeOf<ActionCheckAttribute>.FullName, TypeOf<ActionMethodAttribute>.FullName, tuple.Item1.Name, CS_0024_003C_003E8__locals0.managerType.FullName));
		}
		return CS_0024_003C_003E8__locals0.invokeMethods.Select(delegate(Tuple<MethodInfo, IAuditAction, IAuditObject> invokeMethodTuple)
		{
			CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass12_2();
			CS_0024_003C_003E8__locals0.invokeMethodTuple = invokeMethodTuple;
			bool flag = CS_0024_003C_003E8__locals0.invokeMethodTuple.Item1.ReturnType.IsAsync();
			Tuple<MethodInfo, IAuditAction, IAuditObject> tuple2 = CS_0024_003C_003E8__locals0.checkMethods.FirstOrDefault((Tuple<MethodInfo, IAuditAction, IAuditObject> checkMethodTuple) => checkMethodTuple.Item2.Uid == CS_0024_003C_003E8__locals0.invokeMethodTuple.Item2.Uid && checkMethodTuple.Item3.Uid == CS_0024_003C_003E8__locals0.invokeMethodTuple.Item3.Uid && checkMethodTuple.Item1.ReturnType.IsAsync() == CS_0024_003C_003E8__locals0.invokeMethodTuple.Item1.ReturnType.IsAsync());
			if (tuple2 != null)
			{
				if (flag)
				{
					if (tuple2.Item1.ReturnParameter.ParameterType != TypeOf<Task<bool>>.Raw && tuple2.Item1.ReturnParameter.ParameterType != TypeOf<System.Threading.Tasks.ValueTask<bool>>.Raw && tuple2.Item1.ReturnParameter.ParameterType != TypeOf<Task<ActionCheckResult>>.Raw && tuple2.Item1.ReturnParameter.ParameterType != TypeOf<System.Threading.Tasks.ValueTask<ActionCheckResult>>.Raw)
					{
						throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740723536), TypeOf<ActionCheckAttribute>.FullName, TypeOf<Task<ActionCheckResult>>.FullName, TypeOf<Task<bool>>.FullName, tuple2.Item1.Name, CS_0024_003C_003E8__locals0.managerType.FullName, TypeOf<System.Threading.Tasks.ValueTask<bool>>.FullName, TypeOf<System.Threading.Tasks.ValueTask<ActionCheckResult>>.FullName));
					}
				}
				else if (tuple2.Item1.ReturnParameter.ParameterType != TypeOf<bool>.Raw && tuple2.Item1.ReturnParameter.ParameterType != TypeOf<ActionCheckResult>.Raw)
				{
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76BF6E2), TypeOf<ActionCheckAttribute>.FullName, TypeOf<ActionCheckResult>.FullName, TypeOf<bool>.FullName, tuple2.Item1.Name, CS_0024_003C_003E8__locals0.managerType.FullName));
				}
				if (!tuple2.Item1.GetParameters().SequenceEqual(CS_0024_003C_003E8__locals0.invokeMethodTuple.Item1.GetParameters(), new PropertyInfoTypeComparer()))
				{
					throw new InvalidOperationException(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E458DE), TypeOf<ActionCheckAttribute>.FullName, tuple2.Item1.Name, CS_0024_003C_003E8__locals0.managerType.FullName));
				}
			}
			return new ActionInvokerAsync(CS_0024_003C_003E8__locals0._003C_003E4__this.actionDispatcherService, Locator.GetServiceNotNull(CS_0024_003C_003E8__locals0.managerType), CS_0024_003C_003E8__locals0.invokeMethodTuple.Item3, CS_0024_003C_003E8__locals0.invokeMethodTuple.Item2, CS_0024_003C_003E8__locals0.invokeMethodTuple.Item1, tuple2?.Item1);
		});
	}

	public ManagerActionInvokeProvider(ILazy<ActionDispatcherService> actionDispatcherService, IEntityManagerTypesStorage entityManagerTypesStorage, EntityAuditObjectProvider entityAuditObjectProvider)
	{
		SingletonReader.JJCZtPuTvSt();
		invokerManagers = new HashSet<Type>();
		invokers = Enumerable.Empty<IActionInvoker>();
		base._002Ector();
		this.actionDispatcherService = actionDispatcherService;
		this.entityManagerTypesStorage = entityManagerTypesStorage;
		this.entityAuditObjectProvider = entityAuditObjectProvider;
	}

	public IEnumerable<IActionInvoker> GetInvokers()
	{
		HashSet<Type> hashSet = entityManagerTypesStorage.GetManagerTypes().Where(delegate(Type manager)
		{
			int num = 2;
			int num2 = num;
			ObsoleteAttribute obsoleteAttribute = default(ObsoleteAttribute);
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (obsoleteAttribute == null)
					{
						return true;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					return !_003C_003Ec.cFiwUaZQG9h5cXuS4IIG(obsoleteAttribute);
				case 2:
					obsoleteAttribute = AttributeHelper<ObsoleteAttribute>.GetAttributes(manager, inherited: false).FirstOrDefault();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}).ToHashSet();
		if (hashSet.Count > invokerManagers.Count)
		{
			lock (this)
			{
				if (hashSet.Count > invokerManagers.Count)
				{
					_003C_003Ec__DisplayClass14_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass14_0();
					CS_0024_003C_003E8__locals0._003C_003E4__this = this;
					CS_0024_003C_003E8__locals0.managerWithInvokers = new List<Type>();
					hashSet.ExceptWith(invokerManagers);
					invokers = invokers.Concat(hashSet.SelectMany(delegate(Type managerType)
					{
						IEnumerable<IActionInvoker> enumerable = CS_0024_003C_003E8__locals0._003C_003E4__this.GetInvokers(managerType);
						if ((enumerable?.Count() ?? 0) > 0)
						{
							CS_0024_003C_003E8__locals0.managerWithInvokers.Add(managerType);
						}
						return enumerable;
					})).ToList();
					invokerManagers.UnionWith(CS_0024_003C_003E8__locals0.managerWithInvokers);
				}
			}
		}
		return invokers;
	}

	public IActionInvoker GetInvoker(Guid actionObjectUid, Guid actionTypeUid)
	{
		int num = 1;
		_003C_003Ec__DisplayClass15_0 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_0);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return GetInvokers().FirstOrDefault(_003C_003Ec__DisplayClass15_._003CGetInvoker_003Eb__0);
				case 3:
					_003C_003Ec__DisplayClass15_.actionObjectUid = actionObjectUid;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass15_.actionTypeUid = actionTypeUid;
			num = 3;
		}
	}

	internal static bool yPhIfuf4ZMhao4cce1Ly()
	{
		return pomrdjf481NOIFykBxV7 == null;
	}

	internal static ManagerActionInvokeProvider mQ6YYMf4u7FaEtqMcOMU()
	{
		return pomrdjf481NOIFykBxV7;
	}
}
