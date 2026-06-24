using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Enums;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Model.Types;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.QueryFunctionResults;

[Component]
public class EnumQueryResult : IQueryFunctionResult, IEQLFunction
{
	internal static EnumQueryResult oTHo5mGMJhSkW8xTyQ4a;

	public string FunctionName => (string)N1ga1NGMl5hFt7S4TJj2(0x4785BC0D ^ 0x4781BAAD);

	public object GetValue(EntityMetadata metadata, string propName, object[] parameters)
	{
		//Discarded unreachable code: IL_0076, IL_00fa, IL_0104, IL_0113, IL_0128, IL_01f0, IL_01ff, IL_0279
		int num = 11;
		TypeConverter typeConverter = default(TypeConverter);
		PropertyInfo propertyInfo = default(PropertyInfo);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Guid guid;
				object obj;
				switch (num2)
				{
				default:
					if (typeConverter == null)
					{
						num2 = 13;
						continue;
					}
					guid = n9kXhVGMzmyfjgu8EMkc((EnumBase)mvO29AGMcX7BTrMEoXva(typeConverter, (string)parameters[0]));
					goto IL_02b4;
				case 3:
					if (!qVAZTGGMjSPVxiE6JSSX(propertyInfo).IsNullableType())
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 15;
						}
						continue;
					}
					obj = qVAZTGGMjSPVxiE6JSSX(propertyInfo).GetNonNullableType();
					goto IL_027f;
				case 8:
					if (!FOaDERGMYPLBD0w0vkV6(type, null))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 6;
				case 10:
					if (parameters[0] is string)
					{
						num2 = 2;
						continue;
					}
					break;
				case 13:
					guid = Guid.Empty;
					goto IL_02b4;
				case 9:
					if (HC6QtnGM5J8FC9uh6Z5y(propertyInfo, null))
					{
						num2 = 16;
						continue;
					}
					goto case 3;
				case 1:
					typeConverter = rEQg61GMs2rIyblZp1yC(typeof(EnumBaseConverter<>).MakeGenericType(type)) as TypeConverter;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					if (!kpaESdGMLIogg8AZn4ct(typeof(Enum).TypeHandle).IsAssignableFrom(type))
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 7;
				case 5:
					if (!kpaESdGMLIogg8AZn4ct(typeof(EnumBase).TypeHandle).IsAssignableFrom(type))
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 11:
					if (parameters.Length == 1)
					{
						num2 = 10;
						continue;
					}
					break;
				case 7:
					return (int)FKSuwPGMUiAyHvC2o2KM(type, (string)parameters[0]);
				case 4:
				case 14:
					if (FOaDERGMYPLBD0w0vkV6(type, null))
					{
						num2 = 5;
						continue;
					}
					break;
				case 2:
					propertyInfo = (PropertyInfo)WAfNGUGMg4tbQvn2PvVl(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(fldgCYGMrgEGrS0spumh(metadata)), propName);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 1;
					}
					continue;
				case 15:
					obj = qVAZTGGMjSPVxiE6JSSX(propertyInfo);
					goto IL_027f;
				case 16:
					obj = null;
					goto IL_027f;
				case 12:
					break;
					IL_027f:
					type = (Type)obj;
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 8;
					}
					continue;
					IL_02b4:
					return guid;
				}
				throw new ArgumentException();
				continue;
				end_IL_0012:
				break;
			}
			num = 12;
		}
	}

	public IEnumerable<EQLFunction> GetEqlFunctions()
	{
		return new EQLFunction[1]
		{
			new EQLFunction
			{
				DisplayName = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195798933), FunctionName, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8357BD6))),
				Description = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105363376)),
				Value = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281583484), FunctionName),
				Types = new Guid[1] { EnumDescriptor.UID }
			}
		};
	}

	public EnumQueryResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object N1ga1NGMl5hFt7S4TJj2(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool keivJUGM9TQnbLajpqqj()
	{
		return oTHo5mGMJhSkW8xTyQ4a == null;
	}

	internal static EnumQueryResult Fm2mHfGMdlI4LhODjIF2()
	{
		return oTHo5mGMJhSkW8xTyQ4a;
	}

	internal static Guid fldgCYGMrgEGrS0spumh(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object WAfNGUGMg4tbQvn2PvVl(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool HC6QtnGM5J8FC9uh6Z5y(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static Type qVAZTGGMjSPVxiE6JSSX(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static bool FOaDERGMYPLBD0w0vkV6(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static Type kpaESdGMLIogg8AZn4ct(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object FKSuwPGMUiAyHvC2o2KM(Type P_0, object P_1)
	{
		return Enum.Parse(P_0, (string)P_1);
	}

	internal static object rEQg61GMs2rIyblZp1yC(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static object mvO29AGMcX7BTrMEoXva(object P_0, object P_1)
	{
		return ((TypeConverter)P_0).ConvertFromInvariantString((string)P_1);
	}

	internal static Guid n9kXhVGMzmyfjgu8EMkc(object P_0)
	{
		return ((EnumBase)P_0).Value;
	}
}
