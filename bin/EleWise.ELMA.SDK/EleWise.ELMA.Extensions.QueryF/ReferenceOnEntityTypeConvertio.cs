using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Entities.EntityReferences;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.QueryFunctionResults;

[Component(Order = 50)]
public class ReferenceOnEntityTypeConvertion : IQueryTypeConvertion
{
	private static ReferenceOnEntityTypeConvertion tTeeFCGyrHnl8eZeQ3xD;

	public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
	{
		//Discarded unreachable code: IL_00e1, IL_00f0
		int num = 3;
		PropertyInfo propertyInfo = default(PropertyInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return H6hpU7GyjwHC8itONqae(typeof(ReferenceOnEntityType).TypeHandle).IsAssignableFrom(bE0XWDGysHdk7EfxFZi8(propertyInfo));
				case 1:
					return true;
				case 4:
					propertyInfo = (PropertyInfo)G4GSOhGyUn3v8V47JaEp(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(lAyYeHGyLgRvLl1q9KL2(metadata)), propName);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					return false;
				case 3:
					if (!H6hpU7GyjwHC8itONqae(typeof(string).TypeHandle).IsAssignableFrom(valueType))
					{
						break;
					}
					if (!z2NT5vGyY8mgJUh1d4Uc(propName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E45CB9)))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 1;
				}
				break;
			}
			num = 2;
		}
	}

	public object ConvertValue(EntityMetadata metadata, string propName, object value)
	{
		return hDJGbcGycu752cynKQk5(Locator.GetServiceNotNull<ReferenceOnEntityTypeQueryResult>(), metadata, propName, new object[1] { value });
	}

	public ReferenceOnEntityTypeConvertion()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ME1lmOGyz4xwiYx9A5Iq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type H6hpU7GyjwHC8itONqae(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool z2NT5vGyY8mgJUh1d4Uc(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static Guid lAyYeHGyLgRvLl1q9KL2(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object G4GSOhGyUn3v8V47JaEp(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static Type bE0XWDGysHdk7EfxFZi8(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static bool s6HmG9Gyg6rJv3JVwrL3()
	{
		return tTeeFCGyrHnl8eZeQ3xD == null;
	}

	internal static ReferenceOnEntityTypeConvertion FHMbrMGy549POnyDEoU9()
	{
		return tTeeFCGyrHnl8eZeQ3xD;
	}

	internal static object hDJGbcGycu752cynKQk5(object P_0, object P_1, object P_2, object P_3)
	{
		return ((ReferenceOnEntityTypeQueryResult)P_0).GetValue((EntityMetadata)P_1, (string)P_2, (object[])P_3);
	}

	internal static void ME1lmOGyz4xwiYx9A5Iq()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
