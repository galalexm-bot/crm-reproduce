using System;
using System.Linq;
using System.Reflection;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Entities;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public static class DataBoundHelper
{
	internal static DataBoundHelper dWvTQyGBxqeGubFCYbbP;

	public static bool IsNullableType(this Type theType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (theType.IsGenericType)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return theType.GetGenericTypeDefinition().Equals(SmnctMGByi5tICKd0No8(typeof(Nullable<>).TypeHandle));
			}
		}
	}

	public static bool CanBeNullableType(this Type sourceType)
	{
		//Discarded unreachable code: IL_00ab, IL_00ba
		int num = 5;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return false;
			case 5:
				if (TRdMpSGBMDUR55hMx8St(sourceType, null))
				{
					num2 = 4;
					continue;
				}
				if (!TRdMpSGBMDUR55hMx8St(sourceType, typeof(void)))
				{
					if (!sourceType.IsValueType)
					{
						num2 = 2;
						continue;
					}
					break;
				}
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 3;
				}
				continue;
			case 4:
				throw new ArgumentNullException((string)JAEIntGBJhAHOiauBR6x(-477139494 ^ -477284892));
			default:
				return kwiYjWGB9QOGR9t5xuoc(sourceType.GetGenericTypeDefinition(), SmnctMGByi5tICKd0No8(typeof(Nullable<>).TypeHandle));
			case 2:
				return false;
			case 1:
				break;
			}
			if (!sourceType.IsGenericType)
			{
				break;
			}
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
			{
				num2 = 0;
			}
		}
		return true;
	}

	public static Type NullableType(this Type sourceType)
	{
		//Discarded unreachable code: IL_0045, IL_006f, IL_007e, IL_0158, IL_0167
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					return null;
				case 4:
					if (sourceType.GetGenericTypeDefinition() == SmnctMGByi5tICKd0No8(typeof(Nullable<>).TypeHandle))
					{
						num2 = 3;
						break;
					}
					goto case 7;
				case 6:
					if (!sourceType.IsGenericType)
					{
						goto end_IL_0012;
					}
					goto case 4;
				default:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8332C0C));
				case 1:
					if (!TRdMpSGBMDUR55hMx8St(sourceType, null))
					{
						if (!TRdMpSGBMDUR55hMx8St(sourceType, typeof(void)))
						{
							if (!sourceType.IsValueType)
							{
								num2 = 5;
								break;
							}
							goto case 6;
						}
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 2;
						}
						break;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 0;
					}
					break;
				case 7:
				case 8:
					return typeof(Nullable<>).MakeGenericType(sourceType);
				case 3:
				case 5:
					return sourceType;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	public static object GetValue(object dataSourceObject, string dataPropertyName)
	{
		return M1QBwNGBd9UUYDvjrLVi(dataSourceObject, dataPropertyName, null, null);
	}

	public static object GetValue(object dataSourceObject, string dataPropertyName, Type requiredType, object defaultValue)
	{
		//Discarded unreachable code: IL_0167, IL_0176, IL_0186, IL_01fd, IL_020c, IL_021c, IL_022b, IL_0265, IL_0286, IL_02b9, IL_02d9, IL_0344, IL_0404
		int num = 4;
		PropertyInfo property = default(PropertyInfo);
		object obj = default(object);
		string text = default(string);
		object obj2 = default(object);
		DynamicEntity dynamicEntity = default(DynamicEntity);
		PropertyInfo propertyInfo = default(PropertyInfo);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 27:
					property = dataSourceObject.GetType().GetProperty((string)JAEIntGBJhAHOiauBR6x(-345420348 ^ -345422678), new Type[1] { SmnctMGByi5tICKd0No8(typeof(string).TypeHandle) });
					num2 = 8;
					continue;
				case 31:
					return M1QBwNGBd9UUYDvjrLVi(obj, text, requiredType, defaultValue);
				default:
					if (obj2 != null)
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 26;
						}
						continue;
					}
					goto case 17;
				case 8:
					if (!(property != null))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 9;
				case 24:
					if (!dynamicEntity.GetDynamicMemberNames().Contains(dataPropertyName))
					{
						num = 35;
						break;
					}
					goto case 27;
				case 20:
					if (!requiredType.IsAssignableFrom(obj2.GetType()))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
						{
							num2 = 13;
						}
						continue;
					}
					return obj2;
				case 11:
				{
					PropertyInfo propertyInfo2 = property;
					object[] array = new string[1] { dataPropertyName };
					obj2 = pViHvJGB5T17Cgh4Txne(propertyInfo2, dataSourceObject, array);
					num = 37;
					break;
				}
				case 34:
					if (TRdMpSGBMDUR55hMx8St(requiredType, null))
					{
						num2 = 19;
						continue;
					}
					goto case 29;
				case 13:
					return defaultValue;
				case 18:
					return M1QBwNGBd9UUYDvjrLVi(obj2, text, requiredType, defaultValue);
				case 15:
				case 36:
					dynamicEntity = dataSourceObject as DynamicEntity;
					num2 = 10;
					continue;
				case 12:
				case 26:
					if (obj2 == null)
					{
						num2 = 16;
					}
					else if (text == null)
					{
						if (TRdMpSGBMDUR55hMx8St(requiredType, null))
						{
							return obj2;
						}
						num2 = 20;
					}
					else
					{
						num2 = 18;
					}
					continue;
				case 16:
					return defaultValue;
				case 33:
					if (dynamicEntity != null)
					{
						num2 = 24;
						continue;
					}
					goto default;
				case 6:
					if (!sX8NMaGBYYTw8848nqFY(propertyInfo, null))
					{
						num2 = 32;
						continue;
					}
					goto case 21;
				case 5:
					return defaultValue;
				case 2:
					return dataSourceObject;
				case 19:
					return dataSourceObject;
				case 29:
					if (requiredType.IsAssignableFrom(dataSourceObject.GetType()))
					{
						num2 = 2;
						continue;
					}
					goto case 5;
				case 30:
				{
					PropertyInfo propertyInfo3 = property;
					object[] array = new string[1] { dataPropertyName };
					obj = pViHvJGB5T17Cgh4Txne(propertyInfo3, dataSourceObject, array);
					num2 = 23;
					continue;
				}
				case 10:
					obj2 = null;
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 33;
					}
					continue;
				case 21:
					return defaultValue;
				case 32:
					obj2 = pViHvJGB5T17Cgh4Txne(propertyInfo, dataSourceObject, null);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 0;
					}
					continue;
				case 17:
					propertyInfo = (PropertyInfo)GILmlHGBjn3ceZvgJJP1(dataSourceObject.GetType(), dataPropertyName);
					num2 = 6;
					continue;
				case 14:
					text = dataPropertyName.Substring(num3 + 1);
					num2 = 22;
					continue;
				case 1:
					text = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 7;
					}
					continue;
				case 22:
					dataPropertyName = (string)wSupl3GBggebGWSg1JJT(dataPropertyName, 0, num3);
					num2 = 36;
					continue;
				case 7:
					if (num3 <= 0)
					{
						num2 = 15;
						continue;
					}
					goto case 14;
				case 28:
					return defaultValue;
				case 3:
					if (!VEtbBVGBlXTo5wgY3J3u(dataPropertyName))
					{
						num3 = FInnhUGBrPjj0KglcQsS(dataPropertyName, '.');
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					num = 34;
					break;
				case 23:
					if (obj == null)
					{
						num2 = 25;
						continue;
					}
					goto case 31;
				case 9:
					if (text == null)
					{
						num2 = 11;
						continue;
					}
					goto case 30;
				case 4:
					if (dataSourceObject != null)
					{
						num2 = 3;
						continue;
					}
					goto case 28;
				}
				break;
			}
		}
	}

	public static Type GetPropertyType(object dataSourceObject, string dataPropertyName)
	{
		//Discarded unreachable code: IL_0080, IL_00da, IL_00e4, IL_00f3, IL_0173, IL_019b, IL_01a5
		int num = 8;
		PropertyInfo propertyInfo = default(PropertyInfo);
		Type type = default(Type);
		string text = default(string);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj2;
				object obj;
				switch (num2)
				{
				case 14:
					if (!(propertyInfo == null))
					{
						type = RWQJ5CGBUbioY5Qm4dlk(propertyInfo);
						num2 = 15;
						continue;
					}
					goto end_IL_0012;
				case 8:
					if (dataSourceObject != null)
					{
						num2 = 7;
						continue;
					}
					goto case 3;
				case 2:
					propertyInfo = (PropertyInfo)GILmlHGBjn3ceZvgJJP1(type, text);
					num2 = 14;
					continue;
				default:
					if (num3 > 0)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 4;
				case 1:
					return type;
				case 13:
					obj2 = dataPropertyName;
					goto IL_01cd;
				case 9:
				case 15:
					if (!VEtbBVGBlXTo5wgY3J3u(dataPropertyName))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 1;
				case 7:
					if (VEtbBVGBlXTo5wgY3J3u(dataPropertyName))
					{
						num2 = 3;
						continue;
					}
					type = dataSourceObject.GetType();
					num2 = 9;
					continue;
				case 16:
					if (num3 > 0)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 13;
				case 5:
				case 11:
					num3 = FInnhUGBrPjj0KglcQsS(dataPropertyName, '.');
					num2 = 16;
					continue;
				case 3:
					return null;
				case 4:
					obj = null;
					break;
				case 12:
					return null;
				case 6:
					obj2 = wSupl3GBggebGWSg1JJT(dataPropertyName, 0, num3);
					goto IL_01cd;
				case 10:
					{
						obj = nqi75pGBLsXYwM6fwtgF(dataPropertyName, num3 + 1);
						break;
					}
					IL_01cd:
					text = (string)obj2;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				dataPropertyName = (string)obj;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 12;
		}
	}

	public static void SetValue(object dataSourceObject, string dataPropertyName, object value)
	{
		//Discarded unreachable code: IL_00e4, IL_012c, IL_013b, IL_014a, IL_01a9, IL_01dc, IL_024c, IL_0274, IL_02b8
		int num = 22;
		string text = default(string);
		int num3 = default(int);
		object obj = default(object);
		DynamicEntity dynamicEntity = default(DynamicEntity);
		PropertyInfo propertyInfo = default(PropertyInfo);
		PropertyInfo property = default(PropertyInfo);
		object obj2 = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 27:
					text = (string)nqi75pGBLsXYwM6fwtgF(dataPropertyName, num3 + 1);
					num2 = 18;
					break;
				case 11:
					if (obj == null)
					{
						goto end_IL_0012;
					}
					goto case 28;
				case 12:
					return;
				case 36:
					return;
				case 20:
				case 24:
					dynamicEntity = dataSourceObject as DynamicEntity;
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 4;
					}
					break;
				case 0:
					return;
				case 18:
					dataPropertyName = (string)wSupl3GBggebGWSg1JJT(dataPropertyName, 0, num3);
					num2 = 24;
					break;
				case 28:
					OWWNA8GBccRRkmM256kq(obj, text, value);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
					{
						num2 = 10;
					}
					break;
				case 8:
					if (!(propertyInfo == null))
					{
						if (text != null)
						{
							num2 = 37;
							break;
						}
						if (value != null)
						{
							num2 = 17;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
							{
								num2 = 30;
							}
							break;
						}
						goto case 32;
					}
					num2 = 36;
					break;
				case 2:
					return;
				case 5:
					vhPCgxGBsdV1WO2PT20D(propertyInfo, dataSourceObject, value, null);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 10;
					}
					break;
				case 15:
					return;
				case 4:
					property = dataSourceObject.GetType().GetProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767722859), new Type[1] { SmnctMGByi5tICKd0No8(typeof(string).TypeHandle) });
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 25;
					}
					break;
				case 1:
					if (num3 <= 0)
					{
						num2 = 20;
						break;
					}
					goto case 27;
				case 34:
					return;
				case 16:
					num3 = dataPropertyName.IndexOf('.');
					num2 = 17;
					break;
				case 14:
				{
					PropertyInfo propertyInfo2 = property;
					object[] array = new string[1] { dataPropertyName };
					vhPCgxGBsdV1WO2PT20D(propertyInfo2, dataSourceObject, value, array);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 29;
					}
					break;
				}
				case 13:
					return;
				case 31:
					propertyInfo = (PropertyInfo)GILmlHGBjn3ceZvgJJP1(dataSourceObject.GetType(), dataPropertyName);
					num2 = 8;
					break;
				case 29:
					return;
				case 3:
				{
					PropertyInfo propertyInfo3 = property;
					object[] array = new string[1] { dataPropertyName };
					obj = pViHvJGB5T17Cgh4Txne(propertyInfo3, dataSourceObject, array);
					num2 = 11;
					break;
				}
				case 22:
					if (dataSourceObject != null)
					{
						num2 = 21;
						break;
					}
					return;
				case 19:
					if (obj2 == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 7;
				case 35:
					propertyInfo.SetValue(dataSourceObject, null, null);
					num2 = 9;
					break;
				case 7:
					OWWNA8GBccRRkmM256kq(obj2, text, value);
					num2 = 33;
					break;
				case 37:
					obj2 = pViHvJGB5T17Cgh4Txne(propertyInfo, dataSourceObject, null);
					num2 = 19;
					break;
				case 17:
					text = null;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 1;
					}
					break;
				case 26:
					if (text != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto case 14;
				case 6:
					if (dynamicEntity != null)
					{
						num2 = 10;
						break;
					}
					goto case 31;
				case 33:
					return;
				case 9:
					return;
				case 30:
					if (!propertyInfo.PropertyType.IsAssignableFrom(value.GetType()))
					{
						return;
					}
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				case 10:
					if (!dynamicEntity.GetDynamicMemberNames().Contains(dataPropertyName))
					{
						num2 = 31;
						break;
					}
					goto case 4;
				case 23:
					return;
				case 21:
					if (VEtbBVGBlXTo5wgY3J3u(dataPropertyName))
					{
						return;
					}
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 12;
					}
					break;
				case 32:
					if (!RWQJ5CGBUbioY5Qm4dlk(propertyInfo).IsAssignableFromNull())
					{
						return;
					}
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 11;
					}
					break;
				case 25:
					if (!(property != null))
					{
						num2 = 15;
						break;
					}
					goto case 26;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	internal static Type SmnctMGByi5tICKd0No8(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool I9D3dNGB0JDqXa0GL9XI()
	{
		return dWvTQyGBxqeGubFCYbbP == null;
	}

	internal static DataBoundHelper uqeLc2GBmBb7UHtQ4Imy()
	{
		return dWvTQyGBxqeGubFCYbbP;
	}

	internal static bool TRdMpSGBMDUR55hMx8St(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object JAEIntGBJhAHOiauBR6x(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool kwiYjWGB9QOGR9t5xuoc(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object M1QBwNGBd9UUYDvjrLVi(object P_0, object P_1, Type requiredType, object P_3)
	{
		return GetValue(P_0, (string)P_1, requiredType, P_3);
	}

	internal static bool VEtbBVGBlXTo5wgY3J3u(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static int FInnhUGBrPjj0KglcQsS(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static object wSupl3GBggebGWSg1JJT(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static object pViHvJGB5T17Cgh4Txne(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static object GILmlHGBjn3ceZvgJJP1(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool sX8NMaGBYYTw8848nqFY(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static object nqi75pGBLsXYwM6fwtgF(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static Type RWQJ5CGBUbioY5Qm4dlk(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static void vhPCgxGBsdV1WO2PT20D(object P_0, object P_1, object P_2, object P_3)
	{
		((PropertyInfo)P_0).SetValue(P_1, P_2, (object[])P_3);
	}

	internal static void OWWNA8GBccRRkmM256kq(object P_0, object P_1, object P_2)
	{
		SetValue(P_0, (string)P_1, P_2);
	}
}
