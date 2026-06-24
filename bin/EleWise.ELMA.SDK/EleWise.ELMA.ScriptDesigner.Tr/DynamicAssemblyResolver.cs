using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.API;
using EleWise.ELMA.ScriptDesigner.ToolBoxItems;
using EleWise.ELMA.Security;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.ScriptDesigner.TranslateData;

public static class DynamicAssemblyResolver
{
	private static DynamicAssemblyResolver T6Y2xZ84S33FNHQYKFp;

	public static ActionGroupCodeItemPoint GetElmaApiFullTree(Assembly dynamicAssembly)
	{
		return RegistrateActionDesigner(dynamicAssembly.GetType(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426078193)), null, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA5010A));
	}

	private static ActionGroupCodeItemPoint RegistrateActionDesigner(Type nodeType, object actionGroup, object callPath)
	{
		//Discarded unreachable code: IL_0059, IL_00d3, IL_00e2, IL_00ed, IL_019e, IL_01b1, IL_01fb, IL_020a, IL_03d2, IL_03e5, IL_0435, IL_0444
		int num = 13;
		int num2 = num;
		List<MethodInfo> source = default(List<MethodInfo>);
		List<IGrouping<string, MethodInfo>>.Enumerator enumerator2 = default(List<IGrouping<string, MethodInfo>>.Enumerator);
		ActionGroupCodeItemPoint actionGroupCodeItemPoint = default(ActionGroupCodeItemPoint);
		ActionOverridesCodeItemPoint item = default(ActionOverridesCodeItemPoint);
		List<PropertyInfo>.Enumerator enumerator = default(List<PropertyInfo>.Enumerator);
		PropertyInfo current = default(PropertyInfo);
		ActionGroupCodeItemPoint actionGroupCodeItemPoint2 = default(ActionGroupCodeItemPoint);
		string text = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			default:
				if (!KdKSsi87Qvv3LG8cVWo(nodeType.Namespace, oP4FUP8AdoRtcbRAIOe(0x4785BC0D ^ 0x4785FD85)))
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 1;
			case 6:
				if (Kv1J6s80qqyZNH5n921(nodeType.Name, oP4FUP8AdoRtcbRAIOe(-1979251663 ^ -1979234863)))
				{
					num2 = 3;
					continue;
				}
				source = (from a in nodeType.GetMethods().Where(IsValidMethod)
					orderby a.Name
					select a).ToList();
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 9;
				}
				continue;
			case 4:
				try
				{
					while (true)
					{
						IL_015c:
						int num3;
						if (!enumerator2.MoveNext())
						{
							num3 = 3;
							goto IL_00f1;
						}
						goto IL_010b;
						IL_00f1:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								actionGroupCodeItemPoint.Actions.Add(item);
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
								{
									num3 = 2;
								}
								continue;
							case 2:
								goto IL_015c;
							case 3:
								return actionGroupCodeItemPoint;
							}
							break;
						}
						goto IL_010b;
						IL_010b:
						item = new ActionOverridesCodeItemPoint(enumerator2.Current, (string)callPath);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num3 = 0;
						}
						goto IL_00f1;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 1:
				if (!Kv1J6s80qqyZNH5n921(LNGs4v8xFpbkVfr0v7G(nodeType), oP4FUP8AdoRtcbRAIOe(0x35C0467B ^ 0x35C007DF)))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 5;
					}
					continue;
				}
				goto case 2;
			case 10:
				try
				{
					while (true)
					{
						IL_030b:
						int num5;
						if (!enumerator.MoveNext())
						{
							num5 = 7;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
							{
								num5 = 0;
							}
							goto IL_0219;
						}
						goto IL_029b;
						IL_0215:
						int num6;
						num5 = num6;
						goto IL_0219;
						IL_0219:
						while (true)
						{
							switch (num5)
							{
							case 2:
							{
								ActionGroupCodeItemPoint actionGroupCodeItemPoint3 = new ActionGroupCodeItemPoint((string)LNGs4v8xFpbkVfr0v7G(current));
								RqlI9l8MBtjZlDFNCUu(actionGroupCodeItemPoint3, GXp8YG8yGCxKghKFrRf(current));
								actionGroupCodeItemPoint2 = actionGroupCodeItemPoint3;
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
								{
									num5 = 0;
								}
								continue;
							}
							case 8:
								goto IL_029b;
							case 6:
								if (!UgPruH8myrTncoDA61S(current).GetMethods().Where(IsValidMethod).Any())
								{
									num5 = 4;
									continue;
								}
								goto case 2;
							case 1:
								actionGroupCodeItemPoint.ActionGroups.Add(actionGroupCodeItemPoint2);
								num5 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
								{
									num5 = 3;
								}
								continue;
							case 3:
								goto IL_030b;
							case 4:
								if (UgPruH8myrTncoDA61S(current).GetProperties().Any(IsValidProperty))
								{
									num5 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
									{
										num5 = 2;
									}
									continue;
								}
								goto IL_030b;
							case 5:
								text = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103FAB77), callPath, current.Name);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
								{
									num5 = 0;
								}
								continue;
							case 7:
								goto end_IL_030b;
							}
							break;
						}
						pXashy8J4XDJaMWSi4E(UgPruH8myrTncoDA61S(current), actionGroupCodeItemPoint2, text);
						num6 = 3;
						goto IL_0215;
						IL_029b:
						current = enumerator.Current;
						num6 = 6;
						goto IL_0215;
						continue;
						end_IL_030b:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
				break;
			case 11:
				return actionGroupCodeItemPoint;
			case 5:
				if (Kv1J6s80qqyZNH5n921(LNGs4v8xFpbkVfr0v7G(nodeType), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951498714)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 6;
			case 13:
				obj = actionGroup;
				if (obj != null)
				{
					goto IL_047c;
				}
				num2 = 12;
				continue;
			case 12:
				obj = new ActionGroupCodeItemPoint((string)oP4FUP8AdoRtcbRAIOe(-541731959 ^ -541748505));
				goto IL_047c;
			case 2:
			case 3:
			case 7:
				return null;
			case 9:
				enumerator = (from a in nodeType.GetProperties()
					where _003C_003Ec.VhGc3wf7dLtem7Mary3F(_003C_003Ec.mhPX0Hf793mJn90AdVev(a), typeof(Permission))
					select a).ToList().Where(IsValidProperty).ToList()
					.GetEnumerator();
				num2 = 10;
				continue;
			case 8:
				break;
				IL_047c:
				actionGroupCodeItemPoint = (ActionGroupCodeItemPoint)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				continue;
			}
			enumerator2 = (from a in source
				group a by (string)_003C_003Ec.zDk32Tf7le7ad4X2hwt3(a)).ToList().GetEnumerator();
			num2 = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
			{
				num2 = 4;
			}
		}
	}

	private static bool IsValidProperty(object propertyInfo)
	{
		//Discarded unreachable code: IL_00ad, IL_00bc, IL_014c, IL_0185
		int num = 7;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				if (Kv1J6s80qqyZNH5n921(((MemberInfo)propertyInfo).Name, oP4FUP8AdoRtcbRAIOe(-606654180 ^ -606637272)))
				{
					num2 = 4;
					break;
				}
				goto default;
			case 1:
			case 2:
			case 4:
			case 6:
				return false;
			default:
				if (!((string)LNGs4v8xFpbkVfr0v7G(propertyInfo) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-420743386 ^ -420760206)))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			case 8:
				if (Kv1J6s80qqyZNH5n921(LNGs4v8xFpbkVfr0v7G(propertyInfo), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1870909419)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 5;
			case 3:
				if (!((string)LNGs4v8xFpbkVfr0v7G(propertyInfo) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6E1869)))
				{
					return true;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				if (Kv1J6s80qqyZNH5n921(LNGs4v8xFpbkVfr0v7G(propertyInfo), oP4FUP8AdoRtcbRAIOe(-1822890472 ^ -1822907380)))
				{
					num2 = 6;
					break;
				}
				goto case 8;
			}
		}
	}

	private static bool IsValidMethod(object method)
	{
		//Discarded unreachable code: IL_00ef, IL_00fe, IL_010d, IL_01d1, IL_021e, IL_037a
		int num = 22;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (uCgpTV8lfMG7PZd6rfi(Vo3mJr89mKnMXZyeGoT(method), mDupjr8dsKD180UCFo8(typeof(object).TypeHandle)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
					{
						num2 = 0;
					}
					break;
				}
				return true;
			case 23:
				if (!KdKSsi87Qvv3LG8cVWo(LNGs4v8xFpbkVfr0v7G(method), oP4FUP8AdoRtcbRAIOe(0x34185E55 ^ 0x341852D9)))
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			case 3:
				if (KdKSsi87Qvv3LG8cVWo(((MemberInfo)method).Name, oP4FUP8AdoRtcbRAIOe(0x42643203 ^ 0x42643E83)))
				{
					num2 = 11;
					break;
				}
				goto case 23;
			case 18:
				if (!KdKSsi87Qvv3LG8cVWo(LNGs4v8xFpbkVfr0v7G(method), oP4FUP8AdoRtcbRAIOe(0x63ABA4E8 ^ 0x63ABE69C)))
				{
					num2 = 3;
					break;
				}
				goto default;
			case 8:
				if (KdKSsi87Qvv3LG8cVWo(LNGs4v8xFpbkVfr0v7G(method), oP4FUP8AdoRtcbRAIOe(-1487388570 ^ -1487404294)))
				{
					num2 = 12;
					break;
				}
				goto case 18;
			case 15:
				if (!Kv1J6s80qqyZNH5n921(LNGs4v8xFpbkVfr0v7G(method), oP4FUP8AdoRtcbRAIOe(0x12A5FAC7 ^ 0x12A5B9D9)))
				{
					num2 = 2;
					break;
				}
				goto default;
			case 1:
				if (Kv1J6s80qqyZNH5n921(LNGs4v8xFpbkVfr0v7G(method), oP4FUP8AdoRtcbRAIOe(0xD3DEF7E ^ 0xD3DE490)))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 20;
					}
					break;
				}
				goto case 6;
			case 17:
				if (Kv1J6s80qqyZNH5n921(LNGs4v8xFpbkVfr0v7G(method), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217506341)))
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 10;
					}
					break;
				}
				goto case 13;
			case 6:
				if ((string)LNGs4v8xFpbkVfr0v7G(method) == (string)oP4FUP8AdoRtcbRAIOe(0x1DE3DD89 ^ 0x1DE39E85))
				{
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 5;
					}
					break;
				}
				goto case 15;
			case 14:
				if (!Kv1J6s80qqyZNH5n921(LNGs4v8xFpbkVfr0v7G(method), oP4FUP8AdoRtcbRAIOe(-541731959 ^ -541748915)))
				{
					num2 = 4;
					break;
				}
				goto default;
			case 13:
				if (!Kv1J6s80qqyZNH5n921(((MemberInfo)method).Name, oP4FUP8AdoRtcbRAIOe(0x7247028A ^ 0x72474064)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 9:
				if (!Kv1J6s80qqyZNH5n921(((MemberInfo)method).Name, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978494354)))
				{
					num2 = 5;
					break;
				}
				goto default;
			case 4:
				if (!Kv1J6s80qqyZNH5n921(LNGs4v8xFpbkVfr0v7G(method), oP4FUP8AdoRtcbRAIOe(0x1DE3DD89 ^ 0x1DE39F5F)))
				{
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto default;
			default:
				return false;
			case 16:
				if (!((string)LNGs4v8xFpbkVfr0v7G(method) == z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70024143)))
				{
					num2 = 8;
					break;
				}
				goto default;
			case 2:
				if (!Kv1J6s80qqyZNH5n921(LNGs4v8xFpbkVfr0v7G(method), oP4FUP8AdoRtcbRAIOe(-1852837372 ^ -1852853976)))
				{
					num2 = 16;
					break;
				}
				goto default;
			case 5:
				if (!Kv1J6s80qqyZNH5n921(LNGs4v8xFpbkVfr0v7G(method), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FA4266)))
				{
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto default;
			case 22:
				if (!Kv1J6s80qqyZNH5n921(LNGs4v8xFpbkVfr0v7G(method), oP4FUP8AdoRtcbRAIOe(-1217523399 ^ -1217506483)))
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 21;
					}
					break;
				}
				goto default;
			case 21:
				if (!Kv1J6s80qqyZNH5n921(LNGs4v8xFpbkVfr0v7G(method), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103FABF1)))
				{
					num2 = 9;
					break;
				}
				goto default;
			}
		}
	}

	internal static bool sMqaTW86SNyy5rxJKOS()
	{
		return T6Y2xZ84S33FNHQYKFp == null;
	}

	internal static DynamicAssemblyResolver tH22tM8H3riemfOO7OL()
	{
		return T6Y2xZ84S33FNHQYKFp;
	}

	internal static object oP4FUP8AdoRtcbRAIOe(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool KdKSsi87Qvv3LG8cVWo(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object LNGs4v8xFpbkVfr0v7G(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static bool Kv1J6s80qqyZNH5n921(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static Type UgPruH8myrTncoDA61S(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static object GXp8YG8yGCxKghKFrRf(object P_0)
	{
		return XmlCommentsHelper.GetSummary((PropertyInfo)P_0);
	}

	internal static void RqlI9l8MBtjZlDFNCUu(object P_0, object P_1)
	{
		((ActionGroupBaseCodeItemPoint)P_0).Description = (string)P_1;
	}

	internal static object pXashy8J4XDJaMWSi4E(Type nodeType, object P_1, object P_2)
	{
		return RegistrateActionDesigner(nodeType, P_1, P_2);
	}

	internal static Type Vo3mJr89mKnMXZyeGoT(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	internal static Type mDupjr8dsKD180UCFo8(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool uCgpTV8lfMG7PZd6rfi(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}
}
