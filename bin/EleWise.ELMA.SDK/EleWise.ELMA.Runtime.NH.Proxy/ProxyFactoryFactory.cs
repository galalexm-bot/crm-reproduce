using System;
using System.Collections.Generic;
using System.Reflection;
using EleWise.ELMA.Model.Entities;
using j3AmrhgkCleVTGdEwA;
using NHibernate.Bytecode;
using NHibernate.Engine;
using NHibernate.Proxy;
using NHibernate.Type;

namespace EleWise.ELMA.Runtime.NH.Proxy;

public class ProxyFactoryFactory : IProxyFactoryFactory
{
	private class DynamicProxyTypeValidator : DynProxyTypeValidator, IProxyValidator
	{
		private static object ebPikQQr7eqovFmrJXxZ;

		ICollection<string> IProxyValidator.ValidateType(Type type)
		{
			if (!TypeOf<IValueContainerObjectInternal>.Raw.IsAssignableFrom(type))
			{
				return ((DynProxyTypeValidator)this).ValidateType(type);
			}
			return null;
		}

		public override bool IsProxeable(MethodInfo method)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (method != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return false;
				default:
					return ((DynProxyTypeValidator)this).IsProxeable(method);
				}
			}
		}

		public DynamicProxyTypeValidator()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			O2ntajQrmYj1Yc7LJLT3();
			((DynProxyTypeValidator)this)._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool rDRGCvQrxx77Gl7qmKP1()
		{
			return ebPikQQr7eqovFmrJXxZ == null;
		}

		internal static DynamicProxyTypeValidator aG4051Qr01YhdV7snMgR()
		{
			return (DynamicProxyTypeValidator)ebPikQQr7eqovFmrJXxZ;
		}

		internal static void O2ntajQrmYj1Yc7LJLT3()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private class ProxyFactory : IProxyFactory
	{
		private class ValueContainerProxyFactory : IProxyFactory
		{
			[Serializable]
			private class LazyInitializer : AbstractLazyInitializer
			{
				private static object PaBRlYZpnxoXaYmPWp14;

				public override Type PersistentClass { get; }

				public LazyInitializer(Type persistentClass, string entityName, object id, ISessionImplementor session)
				{
					//Discarded unreachable code: IL_002e, IL_0033
					SingletonReader.JJCZtPuTvSt();
					((AbstractLazyInitializer)this)._002Ector(entityName, id, session);
					int num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
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
						PersistentClass = persistentClass;
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num = 1;
						}
					}
				}

				internal static bool QgvsKSZpOBUCVGjlpAjx()
				{
					return PaBRlYZpnxoXaYmPWp14 == null;
				}

				internal static LazyInitializer e12r5wZp2KRsnve6M1vH()
				{
					return (LazyInitializer)PaBRlYZpnxoXaYmPWp14;
				}
			}

			private object entityName;

			private Type persistentClass;

			internal static object aYuTbRZuD9nqGtexpXQW;

			public object GetFieldInterceptionProxy(object instanceToWrap)
			{
				throw new NotImplementedException();
			}

			public void PostInstantiate(string entityName, Type persistentClass, ISet<Type> interfaces, MethodInfo getIdentifierMethod, MethodInfo setIdentifierMethod, IAbstractComponentType componentIdType)
			{
				this.entityName = entityName;
				this.persistentClass = persistentClass;
			}

			public INHibernateProxy GetProxy(object id, ISessionImplementor session)
			{
				return (INHibernateProxy)SYIBmEZu6tSyGVwV5dfI((IEntityProxy)Bhq1KyZu4HF3puJEkgGZ(persistentClass), new LazyInitializer(persistentClass, (string)entityName, id, session));
			}

			public ValueContainerProxyFactory()
			{
				//Discarded unreachable code: IL_002a, IL_002f
				SingletonReader.JJCZtPuTvSt();
				base._002Ector();
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
				{
					num = 0;
				}
				switch (num)
				{
				case 0:
					break;
				}
			}

			internal static object Bhq1KyZu4HF3puJEkgGZ(Type P_0)
			{
				return Activator.CreateInstance(P_0);
			}

			internal static object SYIBmEZu6tSyGVwV5dfI(object P_0, object P_1)
			{
				return ((IEntityProxy)P_0).InitLazyInitializer((ILazyInitializer)P_1);
			}

			internal static bool hQejL5ZutQsSiUTVBiHe()
			{
				return aYuTbRZuD9nqGtexpXQW == null;
			}

			internal static ValueContainerProxyFactory amD4Y2ZuwmBUh2Mh9MJX()
			{
				return (ValueContainerProxyFactory)aYuTbRZuD9nqGtexpXQW;
			}
		}

		private object proxyFactory;

		private static object EynQfTQryGvpvY2U0QF0;

		public void PostInstantiate(string entityName, Type persistentClass, ISet<Type> interfaces, MethodInfo getIdentifierMethod, MethodInfo setIdentifierMethod, IAbstractComponentType componentIdType)
		{
			//IL_0011: Unknown result type (might be due to invalid IL or missing references)
			//IL_0017: Expected O, but got Unknown
			IProxyFactory obj;
			if (!TypeOf<IValueContainerObjectInternal>.Raw.IsAssignableFrom(persistentClass))
			{
				IProxyFactory val = (IProxyFactory)new StaticProxyFactory();
				obj = val;
			}
			else
			{
				IProxyFactory val = (IProxyFactory)(object)new ValueContainerProxyFactory();
				obj = val;
			}
			proxyFactory = obj;
			((IProxyFactory)proxyFactory).PostInstantiate(entityName, persistentClass, interfaces, getIdentifierMethod, setIdentifierMethod, componentIdType);
		}

		public object GetFieldInterceptionProxy(object instanceToWrap)
		{
			return FlovKtQr96QXFb3Jiope(proxyFactory);
		}

		public INHibernateProxy GetProxy(object id, ISessionImplementor session)
		{
			return ((IProxyFactory)proxyFactory).GetProxy(id, session);
		}

		public ProxyFactory()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object FlovKtQr96QXFb3Jiope(object P_0)
		{
			return ProxyFactoryExtensions.GetFieldInterceptionProxy((IProxyFactory)P_0);
		}

		internal static bool JWW9PlQrMlyxUrwYAnGi()
		{
			return EynQfTQryGvpvY2U0QF0 == null;
		}

		internal static ProxyFactory I0SO6RQrJk4i3XXZlL6T()
		{
			return (ProxyFactory)EynQfTQryGvpvY2U0QF0;
		}
	}

	internal static ProxyFactoryFactory WJErgUWARJLn09EZrugl;

	IProxyValidator ProxyValidator => (IProxyValidator)(object)new DynamicProxyTypeValidator();

	IProxyFactory IProxyFactoryFactory.BuildProxyFactory()
	{
		return (IProxyFactory)(object)new ProxyFactory();
	}

	bool IProxyFactoryFactory.IsInstrumented(Type entityClass)
	{
		return true;
	}

	bool IProxyFactoryFactory.IsProxy(object obj)
	{
		//Discarded unreachable code: IL_006a, IL_0079
		int num = 2;
		int num2 = num;
		IEntityProxy entityProxy = default(IEntityProxy);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if ((entityProxy = obj as IEntityProxy) != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return obj is INHibernateProxy;
			case 1:
				return OC6gEGWAX0YfimWNibPA(entityProxy) != null;
			}
		}
	}

	public ProxyFactoryFactory()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Slj4m0WATdyL753cOYqO();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object OC6gEGWAX0YfimWNibPA(object P_0)
	{
		return ((INHibernateProxy)P_0).get_HibernateLazyInitializer();
	}

	internal static bool p3OHO3WAqryiyeNrZUvw()
	{
		return WJErgUWARJLn09EZrugl == null;
	}

	internal static ProxyFactoryFactory BXvKYRWAKblqZwItpCY0()
	{
		return WJErgUWARJLn09EZrugl;
	}

	internal static void Slj4m0WATdyL753cOYqO()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
