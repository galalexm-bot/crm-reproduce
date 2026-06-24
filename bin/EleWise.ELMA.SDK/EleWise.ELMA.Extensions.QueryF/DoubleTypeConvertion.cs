using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions.QueryFunctionResults;

[Component]
public class DoubleTypeConvertion : IQueryTypeConvertion
{
	internal static DoubleTypeConvertion vMDIRZGmw4hLg92C3iN5;

	public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
	{
		//Discarded unreachable code: IL_0049, IL_007b, IL_00bb, IL_011d, IL_012c, IL_013c
		int num = 1;
		PropertyInfo propertyInfo = default(PropertyInfo);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 3:
					if (propertyInfo == null)
					{
						num2 = 7;
						continue;
					}
					goto case 6;
				case 1:
					if (wOO1TmGmHLeYUrEumubf(typeof(long).TypeHandle).IsAssignableFrom(valueType))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				case 9:
					obj = B9yZIBGmxVYQnGZcQZbO(propertyInfo);
					break;
				case 8:
					return typeof(double).IsAssignableFrom(type);
				case 2:
					return false;
				case 5:
					return false;
				default:
					propertyInfo = (PropertyInfo)DYNn60Gm72XpN0gYlnjD(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(PBFEOwGmA0hntjtgaPnl(metadata)), propName);
					num2 = 3;
					continue;
				case 6:
					if (B9yZIBGmxVYQnGZcQZbO(propertyInfo).IsNullableType())
					{
						obj = DLLnkvGm0M8U9fqdZ29j(propertyInfo.PropertyType);
						break;
					}
					goto end_IL_0012;
				case 4:
					if (!di6OYjGmmioPGNF6QpSj(type, null))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 8;
				case 7:
					obj = null;
					break;
				}
				type = (Type)obj;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	public object ConvertValue(EntityMetadata metadata, string propName, object value)
	{
		return BwkV4UGmy7UI7aJUcdGi(value);
	}

	public DoubleTypeConvertion()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type wOO1TmGmHLeYUrEumubf(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Guid PBFEOwGmA0hntjtgaPnl(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object DYNn60Gm72XpN0gYlnjD(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static Type B9yZIBGmxVYQnGZcQZbO(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static Type DLLnkvGm0M8U9fqdZ29j(Type type)
	{
		return type.GetNonNullableType();
	}

	internal static bool di6OYjGmmioPGNF6QpSj(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static bool jl5mErGm49MdUZJeMw7L()
	{
		return vMDIRZGmw4hLg92C3iN5 == null;
	}

	internal static DoubleTypeConvertion saWdu9Gm6p4dnrLCvUcq()
	{
		return vMDIRZGmw4hLg92C3iN5;
	}

	internal static double BwkV4UGmy7UI7aJUcdGi(object P_0)
	{
		return Convert.ToDouble(P_0);
	}
}
