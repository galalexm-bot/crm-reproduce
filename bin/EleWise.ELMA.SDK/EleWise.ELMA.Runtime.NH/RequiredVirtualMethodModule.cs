using System;
using System.Collections.Generic;
using System.Reflection;
using Autofac;
using Autofac.Core;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.Cache;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.NH;

public class RequiredVirtualMethodModule : Module
{
	private readonly Func<Type, IEnumerable<MethodInfo>> methodsFunc;

	private readonly Func<Type, MethodInfo, string> message;

	private readonly ApplicationStartCache applicationStartCache;

	internal static RequiredVirtualMethodModule dhrlZEW6vNXZjhg9MglN;

	public RequiredVirtualMethodModule(Func<Type, IEnumerable<MethodInfo>> methodsFunc, Func<Type, MethodInfo, string> message, ApplicationStartCache applicationStartCache = null)
	{
		SingletonReader.JJCZtPuTvSt();
		((Module)this)._002Ector();
		this.methodsFunc = methodsFunc;
		this.message = message;
		this.applicationStartCache = applicationStartCache;
	}

	protected override void AttachToComponentRegistration(IComponentRegistry componentRegistry, IComponentRegistration registration)
	{
		//Discarded unreachable code: IL_00b3, IL_013c, IL_014b, IL_015a, IL_016b, IL_01d2, IL_01dc, IL_0207, IL_02c1, IL_02f9, IL_0308, IL_0354
		int num = 4;
		IEnumerable<MethodInfo> enumerable = default(IEnumerable<MethodInfo>);
		Type nonProxyType = default(Type);
		AssemblyInfoCache assemblyInfoCache = default(AssemblyInfoCache);
		IEnumerator<MethodInfo> enumerator = default(IEnumerator<MethodInfo>);
		MethodInfo current = default(MethodInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				default:
					return;
				case 9:
					enumerable = methodsFunc(nonProxyType);
					num2 = 18;
					continue;
				case 3:
					nonProxyType = GetNonProxyType(bBlEe5W6VtmAeYnw0uEA(c18kLMW6Iq3eFOorICYq(registration)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 1;
					}
					continue;
				case 5:
					return;
				case 1:
					if (uoePfFW6SpwGa3FZc3U9(nonProxyType, null))
					{
						num2 = 17;
						continue;
					}
					goto case 7;
				case 12:
					if (assemblyInfoCache != null)
					{
						num2 = 15;
						continue;
					}
					goto case 9;
				case 7:
					if (!nonProxyType.IsSealed)
					{
						num2 = 10;
						continue;
					}
					return;
				case 8:
					return;
				case 17:
					return;
				case 11:
					if (applicationStartCache != null)
					{
						goto end_IL_0012;
					}
					goto case 14;
				case 4:
					m8jiEAW6uSbU7gZIv944(this, componentRegistry, registration);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
					obj = null;
					break;
				case 18:
					if (enumerable == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						enumerator = enumerable.GetEnumerator();
						num2 = 6;
					}
					continue;
				case 16:
					return;
				case 0:
					return;
				case 15:
					if (!assemblyInfoCache._changed)
					{
						return;
					}
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					try
					{
						while (true)
						{
							IL_024c:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 3;
								goto IL_01e0;
							}
							goto IL_0262;
							IL_01e0:
							while (true)
							{
								switch (num3)
								{
								case 3:
									return;
								case 2:
									if (!WKWVjgW6ieycqBNfQwYC(current))
									{
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
										{
											num3 = 0;
										}
										continue;
									}
									goto IL_0275;
								default:
									throw new InvalidOperationException(message(nonProxyType, current));
								case 4:
									break;
								case 5:
									goto IL_0275;
								}
								break;
								IL_0275:
								if (Yr483dW6Rqxgv7oPWJJr(current))
								{
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
									{
										num3 = 1;
									}
									continue;
								}
								goto IL_024c;
							}
							goto IL_0262;
							IL_0262:
							current = enumerator.Current;
							num3 = 2;
							goto IL_01e0;
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									SEw4unW6qgWPidkH1EDe(enumerator);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				case 2:
					if (nonProxyType.IsValueType)
					{
						return;
					}
					num2 = 11;
					continue;
				case 10:
					if (nonProxyType.IsEnum)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 13:
					obj = applicationStartCache.GetAssemblyInfo(nonProxyType.Assembly);
					break;
				}
				assemblyInfoCache = (AssemblyInfoCache)obj;
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
				{
					num2 = 5;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 13;
		}
	}

	private Type GetNonProxyType(Type type)
	{
		//Discarded unreachable code: IL_00ab
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 3:
				return type;
			case 4:
				type = type.BaseType;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
			case 2:
				if (!(type == null))
				{
					if (Ph45K3W6K5rjq369MLCL(type.Assembly))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto case 3;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void m8jiEAW6uSbU7gZIv944(object P_0, object P_1, object P_2)
	{
		((Module)P_0).AttachToComponentRegistration((IComponentRegistry)P_1, (IComponentRegistration)P_2);
	}

	internal static object c18kLMW6Iq3eFOorICYq(object P_0)
	{
		return ((IComponentRegistration)P_0).get_Activator();
	}

	internal static Type bBlEe5W6VtmAeYnw0uEA(object P_0)
	{
		return ((IInstanceActivator)P_0).get_LimitType();
	}

	internal static bool uoePfFW6SpwGa3FZc3U9(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool WKWVjgW6ieycqBNfQwYC(object P_0)
	{
		return ((MethodBase)P_0).IsVirtual;
	}

	internal static bool Yr483dW6Rqxgv7oPWJJr(object P_0)
	{
		return ((MethodBase)P_0).IsFinal;
	}

	internal static void SEw4unW6qgWPidkH1EDe(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool e7YMm9W68EfeoZoJ3Rfc()
	{
		return dhrlZEW6vNXZjhg9MglN == null;
	}

	internal static RequiredVirtualMethodModule twMbnTW6Z8BOqUDF3d16()
	{
		return dhrlZEW6vNXZjhg9MglN;
	}

	internal static bool Ph45K3W6K5rjq369MLCL(object P_0)
	{
		return InterceptionRegistrationExtensions.IsProxyAssembly((Assembly)P_0);
	}
}
