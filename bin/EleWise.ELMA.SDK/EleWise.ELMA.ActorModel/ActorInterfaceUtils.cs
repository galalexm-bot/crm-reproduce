using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using EleWise.ELMA.ActorModel.Abstractions;
using EleWise.ELMA.ActorModel.Attributes;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.ActorModel;

public static class ActorInterfaceUtils
{
	private class MethodInfoComparer : IEqualityComparer<MethodInfo>
	{
		internal static object Lk6G7SZWZRUU6p0NCtQV;

		public bool Equals(MethodInfo x, MethodInfo y)
		{
			return bu7aL9ZWSPgeajJdLAdB(fGnxEFZWVQg5Ci0noQZM(x), fGnxEFZWVQg5Ci0noQZM(y), StringComparison.Ordinal);
		}

		public int GetHashCode(MethodInfo obj)
		{
			throw new NotImplementedException();
		}

		private static string GetSignature(object method)
		{
			//Discarded unreachable code: IL_010f, IL_0153, IL_0197, IL_01c3, IL_01d2, IL_01e1, IL_02d0, IL_02df, IL_0389
			int num = 1;
			int num3 = default(int);
			Type[] array = default(Type[]);
			int num4 = default(int);
			ParameterInfo parameterInfo = default(ParameterInfo);
			ParameterInfo[] array2 = default(ParameterInfo[]);
			Type type2 = default(Type);
			TypeInfo typeInfo = default(TypeInfo);
			StringBuilder stringBuilder = default(StringBuilder);
			Type type = default(Type);
			while (true)
			{
				int num2 = num;
				while (true)
				{
					switch (num2)
					{
					case 2:
					case 27:
						if (num3 < array.Length)
						{
							num2 = 7;
							continue;
						}
						goto case 3;
					case 5:
						num4 = 0;
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 22;
						}
						continue;
					case 17:
						parameterInfo = array2[num3];
						num2 = 12;
						continue;
					case 7:
					case 22:
						type2 = array[num3];
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 25;
						}
						continue;
					case 3:
					case 16:
						array2 = (ParameterInfo[])Y2TME9ZWKpJsbu4Xc09G(method);
						num2 = 23;
						continue;
					case 12:
						typeInfo = (TypeInfo)EZBiDpZWTQPv2g2t9nbj(fpeZMnZWXtVaBfVI6B9e(parameterInfo));
						num2 = 19;
						continue;
					case 23:
						num3 = 0;
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 0;
						}
						continue;
					case 21:
						num3++;
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
						{
							num2 = 27;
						}
						continue;
					case 8:
					case 24:
						if (num4 < array.Length)
						{
							num2 = 11;
							continue;
						}
						break;
					case 28:
						goto end_IL_0012;
					case 20:
						if (!typeInfo.IsGenericType)
						{
							num2 = 15;
							continue;
						}
						goto case 29;
					case 13:
						array = (Type[])pAHncSZWRD1FvOfjt1Si(method);
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 25;
						}
						continue;
					case 10:
						return stringBuilder.ToString();
					case 6:
					case 14:
						if (num3 >= array2.Length)
						{
							num2 = 10;
							continue;
						}
						goto case 17;
					case 1:
						stringBuilder = new StringBuilder(((MemberInfo)method).Name);
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
						{
							num2 = 0;
						}
						continue;
					case 26:
						stringBuilder.Append((string)LefsOGZWqjjZME8t8Ooi(type2));
						num2 = 21;
						continue;
					case 19:
						C94qkwZWkSDlGJRaWAsd(stringBuilder, LefsOGZWqjjZME8t8Ooi(typeInfo));
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 16;
						}
						continue;
					case 11:
					case 18:
						type = array[num4];
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 28;
						}
						continue;
					case 4:
						num4++;
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 8;
						}
						continue;
					default:
						if (!ax7tirZWiRXVKcnSPJd3(method))
						{
							num2 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
							{
								num2 = 0;
							}
							continue;
						}
						goto case 13;
					case 25:
						num3 = 0;
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 1;
						}
						continue;
					case 29:
						array = parameterInfo.ParameterType.GetGenericArguments();
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 3;
						}
						continue;
					case 9:
					case 15:
						break;
					}
					num3++;
					num2 = 6;
					continue;
					end_IL_0012:
					break;
				}
				stringBuilder.Append((string)LefsOGZWqjjZME8t8Ooi(type));
				num = 4;
			}
		}

		public MethodInfoComparer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SingletonReader.JJCZtPuTvSt();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static object fGnxEFZWVQg5Ci0noQZM(object P_0)
		{
			return GetSignature(P_0);
		}

		internal static bool bu7aL9ZWSPgeajJdLAdB(object P_0, object P_1, StringComparison P_2)
		{
			return string.Equals((string)P_0, (string)P_1, P_2);
		}

		internal static bool p5m6tTZWumhqr45t5la8()
		{
			return Lk6G7SZWZRUU6p0NCtQV == null;
		}

		internal static MethodInfoComparer hHRfRrZWI6fLuFMZcXUN()
		{
			return (MethodInfoComparer)Lk6G7SZWZRUU6p0NCtQV;
		}

		internal static bool ax7tirZWiRXVKcnSPJd3(object P_0)
		{
			return ((MethodBase)P_0).IsGenericMethodDefinition;
		}

		internal static object pAHncSZWRD1FvOfjt1Si(object P_0)
		{
			return ((MethodBase)P_0).GetGenericArguments();
		}

		internal static object LefsOGZWqjjZME8t8Ooi(object P_0)
		{
			return ((MemberInfo)P_0).Name;
		}

		internal static object Y2TME9ZWKpJsbu4Xc09G(object P_0)
		{
			return ((MethodBase)P_0).GetParameters();
		}

		internal static Type fpeZMnZWXtVaBfVI6B9e(object P_0)
		{
			return ((ParameterInfo)P_0).ParameterType;
		}

		internal static object EZBiDpZWTQPv2g2t9nbj(Type P_0)
		{
			return P_0.GetTypeInfo();
		}

		internal static object C94qkwZWkSDlGJRaWAsd(object P_0, object P_1)
		{
			return ((StringBuilder)P_0).Append((string)P_1);
		}
	}

	private static readonly IEqualityComparer<MethodInfo> MethodComparer;

	internal static ActorInterfaceUtils otK16Rf3uqyqCKqYL4I9;

	public static bool IsActorInterface(Type t)
	{
		//Discarded unreachable code: IL_0087, IL_0096, IL_00d0, IL_0171, IL_0180, IL_0190, IL_019f, IL_01c9
		int num = 10;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (!qaU6qFf3Sn4fw9r0bwCA(t, TypeOf<IActorWithGuidCompoundKey>.Raw))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 11;
			case 12:
				if (!qaU6qFf3Sn4fw9r0bwCA(t, TypeOf<IActorWithGuidKey>.Raw))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 2:
				if (t != TypeOf<IActorWithStringKey>.Raw)
				{
					num2 = 6;
					break;
				}
				goto default;
			case 4:
				if (!(t != TypeOf<IActor>.Raw))
				{
					num2 = 13;
					break;
				}
				goto case 7;
			case 8:
				if (AttributeHelper<AbstractActorAttribute>.GetAttribute(t, inherited: false) != null)
				{
					num2 = 5;
					break;
				}
				goto case 4;
			case 11:
				return qaU6qFf3Sn4fw9r0bwCA(t, TypeOf<IServerPlacementActor>.Raw);
			default:
				return false;
			case 3:
				if (qaU6qFf3Sn4fw9r0bwCA(t.GetInterface(typeof(IActor).FullName), null))
				{
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 14;
					}
					break;
				}
				goto default;
			case 7:
				if (qaU6qFf3Sn4fw9r0bwCA(t, TypeOf<IActorWithIntegerKey>.Raw))
				{
					num2 = 12;
					break;
				}
				goto default;
			case 14:
				if (!t.IsGenericType)
				{
					num2 = 8;
					break;
				}
				goto default;
			case 10:
				if (!t.IsInterface)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public static MethodInfo[] GetMethods(Type actorType, bool bAllMethods = true)
	{
		//Discarded unreachable code: IL_0061, IL_0070, IL_00e6, IL_01b3, IL_01c2
		int num = 8;
		BindingFlags bindingFlags = default(BindingFlags);
		MethodInfo methodInfo = default(MethodInfo);
		MethodInfo[] methods = default(MethodInfo[]);
		int num3 = default(int);
		List<MethodInfo> list = default(List<MethodInfo>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					bindingFlags = BindingFlags.Instance | BindingFlags.Public | BindingFlags.InvokeMethod;
					num2 = 10;
					continue;
				case 14:
					methodInfo = methods[num3];
					num2 = 3;
					continue;
				case 2:
					num3 = 0;
					num2 = 9;
					continue;
				case 6:
					list.Add(methodInfo);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					GetMethodsImpl(actorType, actorType, list);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 15;
					}
					continue;
				case 4:
					return (MethodInfo[])gv25Q9f3i2gkHGEavM2O(list);
				case 10:
					if (bAllMethods)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 13;
				case 8:
					list = new List<MethodInfo>();
					num2 = 7;
					continue;
				case 3:
					if (list.Contains(methodInfo, MethodComparer))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				case 13:
					bindingFlags |= BindingFlags.DeclaredOnly;
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 11;
					}
					continue;
				case 5:
				case 9:
					if (num3 >= methods.Length)
					{
						num2 = 4;
						continue;
					}
					goto case 14;
				case 11:
				case 12:
					methods = actorType.GetMethods(bindingFlags);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			num3++;
			num = 5;
		}
	}

	private static void GetMethodsImpl(Type actorType, Type serviceType, List<MethodInfo> methodInfos)
	{
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
		_003C_003Ec__DisplayClass3_.actorType = actorType;
		Type[] array = GetRemoteInterfaces(serviceType, checkIsActorInterface: false).ToArray();
		_003C_003Ec__DisplayClass3_.methodComparer = new MethodInfoComparer();
		TypeInfo typeInfo = _003C_003Ec__DisplayClass3_.actorType.GetTypeInfo();
		Type[] array2 = array;
		foreach (Type type in array2)
		{
			InterfaceMapping interfaceMapping = default(InterfaceMapping);
			if (typeInfo.IsClass)
			{
				interfaceMapping = typeInfo.GetRuntimeInterfaceMap(type);
			}
			if (!typeInfo.IsInterface && !(interfaceMapping.TargetType == _003C_003Ec__DisplayClass3_.actorType))
			{
				continue;
			}
			MethodInfo[] methods = type.GetMethods();
			foreach (MethodInfo methodInfo in methods)
			{
				if (typeInfo.IsClass)
				{
					_003C_003Ec__DisplayClass3_1 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass3_1();
					CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1 = _003C_003Ec__DisplayClass3_;
					CS_0024_003C_003E8__locals0.mi = methodInfo;
					if (interfaceMapping.TargetMethods.Any(delegate(MethodInfo info)
					{
						//Discarded unreachable code: IL_0063, IL_0072
						int num = 1;
						int num2 = num;
						while (true)
						{
							switch (num2)
							{
							case 1:
								if (!CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.methodComparer.Equals(CS_0024_003C_003E8__locals0.mi, info))
								{
									num2 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
									{
										num2 = 0;
									}
									break;
								}
								goto case 2;
							case 2:
								return _003C_003Ec__DisplayClass3_1.oImyWUZW3V1OQCLyK9In(info.DeclaringType, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.actorType);
							default:
								return false;
							}
						}
					}) && !methodInfos.Contains(CS_0024_003C_003E8__locals0.mi, CS_0024_003C_003E8__locals0.CS_0024_003C_003E8__locals1.methodComparer))
					{
						methodInfos.Add(CS_0024_003C_003E8__locals0.mi);
					}
				}
				else if (!methodInfos.Contains(methodInfo, _003C_003Ec__DisplayClass3_.methodComparer))
				{
					methodInfos.Add(methodInfo);
				}
			}
		}
	}

	private static List<Type> GetRemoteInterfaces(Type type, bool checkIsActorInterface = true)
	{
		_003C_003Ec__DisplayClass4_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass4_0();
		CS_0024_003C_003E8__locals0.checkIsActorInterface = checkIsActorInterface;
		List<Type> list = new List<Type>();
		if (IsActorInterface(type))
		{
			list.Add(type);
		}
		foreach (Type item in type.GetInterfaces().Where(delegate(Type i)
		{
			//Discarded unreachable code: IL_0052, IL_0061
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (!CS_0024_003C_003E8__locals0.checkIsActorInterface)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return _003C_003Ec__DisplayClass4_0.yKHe5MZWtHtxjqgKBjWC(i);
				default:
					return true;
				}
			}
		}))
		{
			list.Add(item);
		}
		return list;
	}

	static ActorInterfaceUtils()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				UIfXwff3RTAw9esjScnv();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				MethodComparer = new MethodInfoComparer();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool qaU6qFf3Sn4fw9r0bwCA(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool kHaBM6f3IlxlBA8HOpmF()
	{
		return otK16Rf3uqyqCKqYL4I9 == null;
	}

	internal static ActorInterfaceUtils rbsAIPf3VfFYu0weyPs4()
	{
		return otK16Rf3uqyqCKqYL4I9;
	}

	internal static object gv25Q9f3i2gkHGEavM2O(object P_0)
	{
		return ((List<MethodInfo>)P_0).ToArray();
	}

	internal static void UIfXwff3RTAw9esjScnv()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
