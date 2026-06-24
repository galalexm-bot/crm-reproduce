using System;
using System.Threading;
using Autofac;
using Autofac.Builder;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services.Impl;

public class AutofacLocatorImpl : ILocatorImpl
{
	private readonly IContainer container;

	private readonly object lockObject;

	internal static AutofacLocatorImpl B8xABBBJZ3lWiYubl1dx;

	public AutofacLocatorImpl(IContainer container)
	{
		//Discarded unreachable code: IL_003a, IL_00a8, IL_00b7
		gdRCMfBJVJhOutA0w579();
		lockObject = new object();
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			default:
				this.container = container;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				if (container == null)
				{
					return;
				}
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num = 0;
				}
				break;
			case 4:
				return;
			case 1:
			{
				AddService(WtqTPgBJST8xbMpSjbEH(typeof(IContainer).TypeHandle), container, resolve: true);
				int num2 = 4;
				num = num2;
				break;
			}
			}
		}
	}

	public virtual object GetService(Type type, string name)
	{
		//Discarded unreachable code: IL_0039, IL_0048, IL_00d0, IL_00df
		int num = 2;
		int num2 = num;
		object result = default(object);
		while (true)
		{
			switch (num2)
			{
			case 1:
			case 3:
				ResolutionExtensions.TryResolve((IComponentContext)(object)container, type, ref result);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 4;
				}
				break;
			default:
				ResolutionExtensions.TryResolveNamed((IComponentContext)(object)container, name, type, ref result);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 5;
				}
				break;
			case 2:
				if (P21JGdBJio9TubCXksYG(name))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 4:
			case 5:
				return result;
			}
		}
	}

	public void AddService(Type type, object obj, bool resolve)
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
				AiVjC5BJRGdMZ0m5jNSC(this, type, obj, resolve);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected virtual void AddServiceInternal(Type type, object obj, bool resolve)
	{
		//Discarded unreachable code: IL_00b7, IL_015a, IL_0192, IL_01a1
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d6: Expected O, but got Unknown
		int num = 3;
		int num2 = num;
		object obj2 = default(object);
		IRegistrationBuilder<object, SimpleActivatorData, SingleRegistrationStyle> val2 = default(IRegistrationBuilder<object, SimpleActivatorData, SingleRegistrationStyle>);
		ContainerBuilder val = default(ContainerBuilder);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			default:
				obj2 = lockObject;
				num2 = 5;
				break;
			case 2:
				val2 = RegistrationExtensions.RegisterInstance<object>(val, obj).As(new Type[1] { type }).SingleInstance();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				lockTaken = false;
				num2 = 6;
				break;
			case 6:
				try
				{
					Monitor.Enter(obj2, ref lockTaken);
					int num3 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num3 = 2;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							if (ComponentManager.Initialized)
							{
								num3 = 3;
								break;
							}
							return;
						case 2:
							val.Update(container);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
							{
								num3 = 0;
							}
							break;
						case 3:
							((ComponentManager)c0NJw1BJqjnIAR6GN8GT()).ResetCache();
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
							{
								num3 = 0;
							}
							break;
						case 1:
							return;
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								Monitor.Exit(obj2);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 7:
				RegistrationExtensions.PropertiesAutowired<object, SimpleActivatorData, SingleRegistrationStyle>(val2, (PropertyWiringOptions)1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				val = new ContainerBuilder();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (resolve)
				{
					num2 = 7;
					break;
				}
				goto default;
			case 4:
				return;
			}
		}
	}

	public virtual void RemoveService(Type type)
	{
		throw new NotImplementedException();
	}

	internal static void gdRCMfBJVJhOutA0w579()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type WtqTPgBJST8xbMpSjbEH(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool TIoFPZBJu59PhYwIMUIu()
	{
		return B8xABBBJZ3lWiYubl1dx == null;
	}

	internal static AutofacLocatorImpl QXHIZ3BJI0qK9y7LrRFs()
	{
		return B8xABBBJZ3lWiYubl1dx;
	}

	internal static bool P21JGdBJio9TubCXksYG(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void AiVjC5BJRGdMZ0m5jNSC(object P_0, Type type, object P_2, bool resolve)
	{
		((AutofacLocatorImpl)P_0).AddServiceInternal(type, P_2, resolve);
	}

	internal static object c0NJw1BJqjnIAR6GN8GT()
	{
		return ComponentManager.Current;
	}
}
