using System;
using System.Collections.Concurrent;
using System.Linq;
using Autofac;
using Autofac.Core;
using Autofac.Core.Lifetime;
using EleWise.ELMA.Services.Impl;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ComponentModel;

public class LifetimeScopeAccessorLocatorImpl : AutofacLocatorImpl
{
	private readonly ConcurrentDictionary<Service, object> singletonServices;

	private readonly ConcurrentDictionary<Service, bool> isSingletonServices;

	private readonly ILifetimeScopeAccessor lifetimeScopeAccessor;

	private static LifetimeScopeAccessorLocatorImpl UIFr2YfZm58WeSlGQBwV;

	public LifetimeScopeAccessorLocatorImpl(IContainer rootContainer, ILifetimeScopeAccessor lifetimeScopeAccessor)
	{
		//Discarded unreachable code: IL_004b
		SingletonReader.JJCZtPuTvSt();
		singletonServices = new ConcurrentDictionary<Service, object>();
		isSingletonServices = new ConcurrentDictionary<Service, bool>();
		base._002Ector(rootContainer);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426408553));
			case 0:
				return;
			case 1:
				if (lifetimeScopeAccessor == null)
				{
					int num2 = 2;
					num = num2;
					break;
				}
				this.lifetimeScopeAccessor = lifetimeScopeAccessor;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override object GetService(Type type, string name)
	{
		//Discarded unreachable code: IL_007f, IL_008e, IL_00b8, IL_00c7, IL_00d6, IL_0113, IL_0185, IL_018f, IL_019e
		//IL_017b: Unknown result type (might be due to invalid IL or missing references)
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0215: Expected O, but got Unknown
		int num = 10;
		int num2 = num;
		object value = default(object);
		ILifetimeScope val3 = default(ILifetimeScope);
		Service val2 = default(Service);
		while (true)
		{
			_003F val;
			switch (num2)
			{
			case 16:
				return value;
			case 5:
				if (!ResolutionExtensions.TryResolveService((IComponentContext)(object)val3, val2, ref value))
				{
					num2 = 8;
					continue;
				}
				goto case 4;
			default:
				singletonServices.TryAdd(val2, value);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
			case 6:
			case 7:
			case 8:
			case 13:
				return value;
			case 12:
			case 15:
				ResolutionExtensions.TryResolveService((IComponentContext)(object)val3, val2, ref value);
				num2 = 13;
				continue;
			case 14:
				if (!singletonServices.TryGetValue(val2, out value))
				{
					val3 = (ILifetimeScope)ndaUyFfZ9GE1AZFeCg1V(lifetimeScopeAccessor);
					num2 = 3;
					continue;
				}
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 16;
				}
				continue;
			case 3:
				if (!IsSingleton(val2, val3))
				{
					num2 = 12;
					continue;
				}
				goto case 11;
			case 1:
				val = new TypedService(type);
				break;
			case 4:
				if (value == null)
				{
					num2 = 2;
					continue;
				}
				goto default;
			case 11:
				if (singletonServices.TryGetValue(val2, out value))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto case 5;
			case 10:
				if (!MniU77fZJ0gqsVl8TQLW(name))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 9;
					}
					continue;
				}
				goto case 1;
			case 9:
				val = new KeyedService((object)name, type);
				break;
			}
			val2 = (Service)val;
			num2 = 14;
		}
	}

	private bool IsSingleton(Service svc, ILifetimeScope lifetimeScope)
	{
		//Discarded unreachable code: IL_0082, IL_0091, IL_00ff
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		//IL_0147: Invalid comparison between Unknown and I4
		int num = 1;
		int num2 = num;
		bool value = default(bool);
		IComponentRegistration val = default(IComponentRegistration);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return false;
			case 7:
				value = true;
				num2 = 9;
				break;
			case 4:
				if (val != null)
				{
					num2 = 7;
					break;
				}
				goto case 5;
			case 2:
				isSingletonServices.TryAdd(svc, value);
				num2 = 6;
				break;
			case 9:
				value &= val.get_Lifetime() is RootScopeLifetime;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 8;
				}
				break;
			case 3:
				return value;
			default:
				val = ((IComponentRegistry)eo0ogsfZd1L0w3yusdMx(lifetimeScope)).RegistrationsFor(svc).FirstOrDefault();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				if (!isSingletonServices.TryGetValue(svc, out value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 6:
				return value;
			case 8:
				value &= (int)U7Tx1mfZlSPOmArLBN7h(val) == 1;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static bool wTjakWfZyVr75qEqK6aq()
	{
		return UIFr2YfZm58WeSlGQBwV == null;
	}

	internal static LifetimeScopeAccessorLocatorImpl PK76NDfZMNgEcdYdxbaw()
	{
		return UIFr2YfZm58WeSlGQBwV;
	}

	internal static bool MniU77fZJ0gqsVl8TQLW(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object ndaUyFfZ9GE1AZFeCg1V(object P_0)
	{
		return ((ILifetimeScopeAccessor)P_0).Current;
	}

	internal static object eo0ogsfZd1L0w3yusdMx(object P_0)
	{
		return ((IComponentContext)P_0).get_ComponentRegistry();
	}

	internal static InstanceSharing U7Tx1mfZlSPOmArLBN7h(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((IComponentRegistration)P_0).get_Sharing();
	}
}
