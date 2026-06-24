using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public static class ReflectionHelper
{
	internal static ReflectionHelper UR9uwehzMWMMwIbvWohe;

	public static T GetFieldValue<T>(this object target, string fieldName, T defaultValue)
	{
		if (target == null)
		{
			return defaultValue;
		}
		FieldInfo field = target.GetType().GetField(fieldName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic);
		if (field == null)
		{
			return defaultValue;
		}
		return (T)field.GetValue(target);
	}

	public static IEnumerable<FieldInfo> GetAllFields(Type t)
	{
		if (t == null)
		{
			return Enumerable.Empty<FieldInfo>();
		}
		BindingFlags bindingAttr = BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic;
		return t.GetReflectionFields(bindingAttr).Union(GetAllFields(t.BaseType));
	}

	public static object GetPropertyValue(this object target, string fieldName, object defaultValue)
	{
		//Discarded unreachable code: IL_0060
		int num = 4;
		int num2 = num;
		PropertyInfo propertyInfo = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (propertyInfo == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					break;
				}
				return l9R1WPhzlZUanwp87fCP(propertyInfo, target, null);
			case 4:
				if (target != null)
				{
					num2 = 3;
					break;
				}
				goto case 5;
			case 1:
				return defaultValue;
			default:
				return defaultValue;
			case 5:
				return defaultValue;
			case 3:
				if (!string.IsNullOrEmpty(fieldName))
				{
					propertyInfo = (PropertyInfo)wHc5AGhzdZLtw38Q6RGm(target.GetType(), fieldName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.GetProperty);
					num2 = 2;
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public static void SetPropertyValue(this object target, string fieldName, object value)
	{
		//Discarded unreachable code: IL_00a3, IL_00b2
		int num = 5;
		int num2 = num;
		PropertyInfo reflectionProperty = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				if (!(reflectionProperty == null))
				{
					num2 = 2;
					break;
				}
				return;
			case 4:
				return;
			case 3:
				return;
			case 2:
				reflectionProperty.SetValue(target, value, null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				if (target != null)
				{
					reflectionProperty = target.GetType().GetReflectionProperty(fieldName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public | BindingFlags.SetProperty);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 1;
					}
				}
				else
				{
					num2 = 4;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static bool IsInheritOrSame<T>(this Type child)
	{
		return child.IsInheritOrSame(typeof(T));
	}

	public static bool IsInheritOrSame(this Type child, Type parent)
	{
		//Discarded unreachable code: IL_008a, IL_0101, IL_014b
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentNullException((string)htXchFhzg6gVSVlIVpke(-2107978722 ^ -2108059950));
			case 3:
				return child.IsSubclassOf(parent);
			case 6:
				return true;
			case 2:
				if (na7U9lhzrDe2eV5Ig4cp(child, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 1;
					}
					break;
				}
				if (!na7U9lhzrDe2eV5Ig4cp(parent, null))
				{
					if (!parent.IsInterface)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 8;
						}
						break;
					}
					goto case 5;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				throw new ArgumentNullException((string)htXchFhzg6gVSVlIVpke(0x4A1640F ^ 0x4A2D6F3));
			case 4:
				return child.GetInterfaces().Contains(parent);
			case 7:
				return true;
			case 8:
				if (na7U9lhzrDe2eV5Ig4cp(child, parent))
				{
					num2 = 6;
					break;
				}
				goto case 3;
			case 5:
				if (na7U9lhzrDe2eV5Ig4cp(child, parent))
				{
					num2 = 7;
					break;
				}
				goto case 4;
			}
		}
	}

	public static bool IsAssignableToGenericType(this Type type, Type genericType)
	{
		//Discarded unreachable code: IL_0135, IL_0144
		int num = 1;
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		Type baseType = default(Type);
		Type[] interfaces = default(Type[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					if (!(baseType != null))
					{
						num2 = 6;
						break;
					}
					goto case 9;
				case 2:
					interfaces = type.GetInterfaces();
					num2 = 7;
					break;
				case 7:
					if (type.IsGenericType)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
						{
							num2 = 3;
						}
						break;
					}
					goto IL_0109;
				default:
					_003C_003Ec__DisplayClass6_.genericType = genericType;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 1;
					}
					break;
				case 9:
					return c1t8nHhz5G7XlDLLeFAx(baseType, _003C_003Ec__DisplayClass6_.genericType);
				case 6:
					return false;
				case 3:
					if (na7U9lhzrDe2eV5Ig4cp(type.GetGenericTypeDefinition(), _003C_003Ec__DisplayClass6_.genericType))
					{
						num2 = 8;
						break;
					}
					goto IL_0109;
				case 8:
					return true;
				case 5:
					{
						return true;
					}
					IL_0109:
					if (!interfaces.Any(_003C_003Ec__DisplayClass6_._003CIsAssignableToGenericType_003Eb__0))
					{
						baseType = type.BaseType;
						num2 = 4;
						break;
					}
					goto end_IL_0012;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public static object GetPropertyValue(string name, object obj)
	{
		//Discarded unreachable code: IL_003a, IL_0044, IL_0073, IL_0146, IL_0159, IL_0168, IL_01ca
		int num = 1;
		int num2 = num;
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		object result = default(object);
		object obj2 = default(object);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					while (true)
					{
						IL_00d3:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
							{
								num3 = 2;
							}
							goto IL_0048;
						}
						goto IL_009a;
						IL_009a:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num3 = 1;
						}
						goto IL_0048;
						IL_0048:
						while (true)
						{
							switch (num3)
							{
							default:
								result = null;
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
								{
									num3 = 2;
								}
								continue;
							case 4:
								break;
							case 1:
								obj2 = HZiKNvhzYIfTrWRTs9Wi(obj2, current, null);
								num3 = 6;
								continue;
							case 5:
								goto IL_00d3;
							case 6:
								if (obj2 == null)
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto IL_00d3;
							case 2:
								return obj2;
							case 3:
								return result;
							}
							break;
						}
						goto IL_009a;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			default:
				return null;
			case 1:
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			case 2:
				return obj2;
			case 5:
				break;
			}
			if (!MdEqoWhzj7woNaKCZaiP(name))
			{
				List<string> list = name.Split('.').ToList();
				obj2 = obj;
				enumerator = list.GetEnumerator();
				num2 = 3;
			}
			else
			{
				num2 = 4;
			}
		}
	}

	internal static object wHc5AGhzdZLtw38Q6RGm(Type type, object P_1, BindingFlags bindingAttr)
	{
		return type.GetReflectionProperty((string)P_1, bindingAttr);
	}

	internal static object l9R1WPhzlZUanwp87fCP(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static bool Wi7xQJhzJkJwlt86nV2c()
	{
		return UR9uwehzMWMMwIbvWohe == null;
	}

	internal static ReflectionHelper BTp7bwhz9qUQb3HWd9vh()
	{
		return UR9uwehzMWMMwIbvWohe;
	}

	internal static bool na7U9lhzrDe2eV5Ig4cp(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object htXchFhzg6gVSVlIVpke(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool c1t8nHhz5G7XlDLLeFAx(Type type, Type genericType)
	{
		return type.IsAssignableToGenericType(genericType);
	}

	internal static bool MdEqoWhzj7woNaKCZaiP(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object HZiKNvhzYIfTrWRTs9Wi(object P_0, object P_1, object P_2)
	{
		return P_0.GetPropertyValue((string)P_1, P_2);
	}
}
