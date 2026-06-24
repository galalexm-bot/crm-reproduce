using System;
using System.Reflection;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions.QueryFunctionResults;

[Component]
public class DropDownItemTypeConvertion : IQueryTypeConvertion
{
	private static DropDownItemTypeConvertion WTnkuQGmleWOQ6XgkT5W;

	public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
	{
		int num = 2;
		int num2 = num;
		PropertyInfo propertyInfo = default(PropertyInfo);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (!RecCyUGm5BOHXcpeMMil(typeof(string).TypeHandle).IsAssignableFrom(valueType))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					propertyInfo = (PropertyInfo)pfjIpIGmYa9Ncx3hncRl(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(aU5PM0GmjWW9ggqjbtmp(metadata)), propName);
					num2 = 3;
				}
				break;
			case 3:
				if (An8lWWGmLmsoByoUajtc(propertyInfo, null))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				}
				return false;
			default:
				return RecCyUGm5BOHXcpeMMil(typeof(DropDownItem).TypeHandle).IsAssignableFrom(DjjJ2VGmUJ0m3sqLxCUh(propertyInfo));
			case 1:
				return false;
			}
		}
	}

	public object ConvertValue(EntityMetadata metadata, string propName, object value)
	{
		return DkQasZGmsjUPnGlVU610(Locator.GetServiceNotNull<DropDownItemQueryResult>(), metadata, propName, new object[1] { value });
	}

	public DropDownItemTypeConvertion()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type RecCyUGm5BOHXcpeMMil(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Guid aU5PM0GmjWW9ggqjbtmp(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object pfjIpIGmYa9Ncx3hncRl(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool An8lWWGmLmsoByoUajtc(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 != (PropertyInfo)P_1;
	}

	internal static Type DjjJ2VGmUJ0m3sqLxCUh(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static bool uQZZnZGmr8ywKLHDnn1t()
	{
		return WTnkuQGmleWOQ6XgkT5W == null;
	}

	internal static DropDownItemTypeConvertion EQUTBgGmgyOePdUMStEL()
	{
		return WTnkuQGmleWOQ6XgkT5W;
	}

	internal static object DkQasZGmsjUPnGlVU610(object P_0, object P_1, object P_2, object P_3)
	{
		return ((DropDownItemQueryResult)P_0).GetValue((EntityMetadata)P_1, (string)P_2, (object[])P_3);
	}
}
