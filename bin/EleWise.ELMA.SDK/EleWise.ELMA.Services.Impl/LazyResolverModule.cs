using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services.Impl;

public class LazyResolverModule : Module
{
	private class AutofacLazyResolver<T> : ILazy<T> where T : class
	{
		private readonly IContainer container;

		private T value;

		private static object aQwLjvQONKDCcynek78O;

		public bool IsRegistered
		{
			get
			{
				int num = 1;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 1:
						if (value == null)
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
							{
								num2 = 0;
							}
							break;
						}
						return true;
					default:
						return ResolutionExtensions.IsRegistered<T>((IComponentContext)(object)container);
					}
				}
			}
		}

		public T Value => value ?? (value = ResolutionExtensions.Resolve<T>((IComponentContext)(object)container));

		public AutofacLazyResolver(IContainer container)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
			{
				num = 1;
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
					this.container = container;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num = 0;
					}
					break;
				}
			}
		}

		internal static bool pOk01mQO3ZER1OVANMfk()
		{
			return aQwLjvQONKDCcynek78O == null;
		}

		internal static object CsfGdjQOpxXiItA8eMIl()
		{
			return aQwLjvQONKDCcynek78O;
		}
	}

	private class AutofacEnumerableLazyResolver<T> : IEnumerableLazy<T>, ILazy<IEnumerable<T>> where T : class
	{
		private readonly IContainer container;

		private IEnumerable<T> value;

		internal static object ApMrBwQOajBE0dpIe2eZ;

		public bool IsRegistered
		{
			get
			{
				int num = 2;
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
						if (value != null)
						{
							num2 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
							{
								num2 = 1;
							}
							break;
						}
						goto default;
					case 1:
						if (!value.Any())
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
							{
								num2 = 0;
							}
							break;
						}
						return true;
					default:
						return ResolutionExtensions.IsRegistered<T>((IComponentContext)(object)container);
					}
				}
			}
		}

		public IEnumerable<T> Value
		{
			get
			{
				if (value == null)
				{
					IEnumerable<T> enumerable = ResolutionExtensions.Resolve<IEnumerable<T>>((IComponentContext)(object)container);
					if (enumerable.Any())
					{
						value = enumerable;
					}
					return enumerable;
				}
				return value;
			}
		}

		public AutofacEnumerableLazyResolver(IContainer container)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
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
				this.container = container;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num = 1;
				}
			}
		}

		internal static bool iC8NLZQODIdwtkFJW92W()
		{
			return ApMrBwQOajBE0dpIe2eZ == null;
		}

		internal static object OxEWQqQOtqvjVDoXWlWw()
		{
			return ApMrBwQOajBE0dpIe2eZ;
		}
	}

	internal static LazyResolverModule dIfCxWBMbVKhP4GKTKv7;

	protected override void Load(ContainerBuilder builder)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 2:
				RegistrationExtensions.RegisterGeneric(builder, OI6vfvBMEhhc12NXp0tj(typeof(AutofacLazyResolver<>).TypeHandle)).As(new Type[1] { typeof(ILazy<>) }).InstancePerDependency();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				RegistrationExtensions.RegisterGeneric(builder, OI6vfvBMEhhc12NXp0tj(typeof(AutofacEnumerableLazyResolver<>).TypeHandle)).As(new Type[1] { typeof(IEnumerableLazy<>) }).InstancePerDependency();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 0;
				}
				break;
			default:
				Th6VpUBMffs8ODdwAkH2(this, builder);
				num2 = 3;
				break;
			}
		}
	}

	public LazyResolverModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		((Module)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type OI6vfvBMEhhc12NXp0tj(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void Th6VpUBMffs8ODdwAkH2(object P_0, object P_1)
	{
		((Module)P_0).Load((ContainerBuilder)P_1);
	}

	internal static bool aUo0N3BMhacU6cckEdpN()
	{
		return dIfCxWBMbVKhP4GKTKv7 == null;
	}

	internal static LazyResolverModule VPSa46BMGwUawbTmQ6mk()
	{
		return dIfCxWBMbVKhP4GKTKv7;
	}
}
