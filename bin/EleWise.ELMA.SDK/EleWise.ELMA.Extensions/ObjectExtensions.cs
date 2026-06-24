using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.DataClasses;
using EleWise.ELMA.Model.Metadata;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class ObjectExtensions
{
	internal static ObjectExtensions NcEoO8GHG5CdwGZy4eit;

	public static void CopyFrom([NotNull] this object @this, object other)
	{
		//Discarded unreachable code: IL_00a7, IL_00b6, IL_00c6, IL_00d5, IL_0207
		int num = 10;
		PropertyInfo reflectionProperty = default(PropertyInfo);
		PropertyInfo propertyInfo = default(PropertyInfo);
		int num3 = default(int);
		object obj = default(object);
		PropertyInfo[] array = default(PropertyInfo[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					reflectionProperty = @this.GetType().GetReflectionProperty((string)yrk9u5GH8Bs4IAlE4ee5(propertyInfo));
					num = 15;
					break;
				case 2:
				case 16:
					num3++;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
					{
						num2 = 7;
					}
					continue;
				case 10:
					Contract.ArgumentNotNull(@this, (string)iaRvGoGHQf0OvnxNxuog(0x57A5235E ^ 0x57A68040));
					num = 9;
					break;
				case 7:
					if (BqtPD4GHvsKa8gy76WLr(propertyInfo))
					{
						num2 = 13;
						continue;
					}
					goto case 2;
				case 4:
					q2raAZGHV6E8IE3Wpso0(reflectionProperty, @this, obj, null);
					num2 = 2;
					continue;
				case 3:
					num3 = 0;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
					{
						num2 = 11;
					}
					continue;
				case 5:
					obj = WgBGeEGHIbrbmQUdSA2f(propertyInfo, other, null);
					num2 = 4;
					continue;
				case 9:
					array = (PropertyInfo[])nuZX9hGHCcRc3iW4QePy(other.GetType());
					num2 = 3;
					continue;
				default:
					if (GXtZOnGHZfkmP34bZuaQ(reflectionProperty))
					{
						num2 = 14;
						continue;
					}
					goto case 2;
				case 6:
				case 12:
					propertyInfo = array[num3];
					num = 7;
					break;
				case 8:
				case 11:
					if (num3 < array.Length)
					{
						num2 = 6;
						continue;
					}
					return;
				case 14:
					if (!gtg69eGHuNXxYe2vFIoc(reflectionProperty).IsAssignableFrom(gtg69eGHuNXxYe2vFIoc(propertyInfo)))
					{
						num2 = 16;
						continue;
					}
					goto case 5;
				case 1:
					return;
				case 15:
					if (!(reflectionProperty == null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				}
				break;
			}
		}
	}

	public static object InvokeMethod([NotNull] this object @this, string methodName, params object[] args)
	{
		//Discarded unreachable code: IL_0086, IL_0095
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (args != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 4:
				Contract.ArgumentNotNull(@this, (string)iaRvGoGHQf0OvnxNxuog(-541731959 ^ -541691753));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 3;
				}
				continue;
			case 2:
				if (args.Length == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 1;
			case 1:
				return @this.GetType().GetMethod(methodName, args.Select((object a) => a.GetType()).ToArray()).Invoke(@this, args);
			}
			break;
		}
		return qkqFPPGHSyemR1ZjP15K(@this.GetType().GetMethod(methodName, Enumerable.Empty<Type>().ToArray()), @this, args);
	}

	public static IDictionary<string, object> ToDictionary(this object instance)
	{
		Dictionary<string, object> dictionary = new Dictionary<string, object>();
		if (instance != null)
		{
			if (!(instance is Dictionary<string, object> dictionary2))
			{
				{
					foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(instance))
					{
						dictionary.Add(property.Name, property.GetValue(instance));
					}
					return dictionary;
				}
			}
			dictionary = dictionary2;
		}
		return dictionary;
	}

	public static PropertyInfo GetProperty(this object obj, ClassMetadata metadata, PropertyMetadata propertyMetadata)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		DataClass dataClass = default(DataClass);
		while (true)
		{
			switch (num2)
			{
			default:
				return dataClass.GetProperty(metadata, propertyMetadata);
			case 1:
				return obj.GetType().GetPropertyCached((string)LgWYZ8GHinAOT4NARYaM(propertyMetadata));
			case 2:
				if ((object)(dataClass = obj as DataClass) == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	internal static object iaRvGoGHQf0OvnxNxuog(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object nuZX9hGHCcRc3iW4QePy(Type type)
	{
		return type.GetReflectionProperties();
	}

	internal static bool BqtPD4GHvsKa8gy76WLr(object P_0)
	{
		return ((PropertyInfo)P_0).CanRead;
	}

	internal static object yrk9u5GH8Bs4IAlE4ee5(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static bool GXtZOnGHZfkmP34bZuaQ(object P_0)
	{
		return ((PropertyInfo)P_0).CanWrite;
	}

	internal static Type gtg69eGHuNXxYe2vFIoc(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static object WgBGeEGHIbrbmQUdSA2f(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static void q2raAZGHV6E8IE3Wpso0(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static bool ro8UudGHECsrnx0Uh4Vu()
	{
		return NcEoO8GHG5CdwGZy4eit == null;
	}

	internal static ObjectExtensions SJv8D5GHfe8AGl1TbSpc()
	{
		return NcEoO8GHG5CdwGZy4eit;
	}

	internal static object qkqFPPGHSyemR1ZjP15K(object P_0, object P_1, object P_2)
	{
		return ((MethodBase)P_0).Invoke(P_1, (object[])P_2);
	}

	internal static object LgWYZ8GHinAOT4NARYaM(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}
}
