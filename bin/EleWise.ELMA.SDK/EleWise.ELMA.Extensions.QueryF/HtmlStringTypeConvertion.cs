using System;
using System.Reflection;
using System.Web;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Extensions.QueryFunctionResults;

[Component]
public class HtmlStringTypeConvertion : IQueryTypeConvertion
{
	internal static HtmlStringTypeConvertion jFNrgLGmc2vgLwdA4OyH;

	public bool AvailableConvert(EntityMetadata metadata, string propName, Type valueType)
	{
		//Discarded unreachable code: IL_0045, IL_008f, IL_00c7, IL_00d6, IL_0101
		int num = 2;
		int num2 = num;
		Type type = default(Type);
		PropertyInfo propertyInfo = default(PropertyInfo);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				if (O6tUQGGyBeSsTlWvNapG(typeof(string).TypeHandle).IsAssignableFrom(valueType))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
					continue;
				}
				goto case 7;
			case 5:
				if (!(type != null))
				{
					num2 = 6;
					continue;
				}
				goto default;
			case 8:
				if (!WigQToGybGUV71o0ZCo9(propertyInfo, null))
				{
					num2 = 4;
					continue;
				}
				obj = null;
				break;
			default:
				return O6tUQGGyBeSsTlWvNapG(typeof(HtmlString).TypeHandle).IsAssignableFrom(type);
			case 6:
				return false;
			case 3:
				obj = propertyInfo.PropertyType;
				break;
			case 4:
				if (rDL00AGyhsbVpdCtvibp(propertyInfo.PropertyType))
				{
					obj = faWwkIGyE5e27NQk4PVv(bcNLEHGyGk9lFxHR0bne(propertyInfo));
					break;
				}
				num2 = 3;
				continue;
			case 7:
				return false;
			case 1:
				propertyInfo = (PropertyInfo)sNVNEwGyofwhhpWq7dkh(Locator.GetServiceNotNull<IMetadataRuntimeService>().GetTypeByUid(AhycvCGyWiyvQYidhtOx(metadata)), propName);
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 7;
				}
				continue;
			}
			type = (Type)obj;
			num2 = 5;
		}
	}

	public object ConvertValue(EntityMetadata metadata, string propName, object value)
	{
		return new HtmlString((string)value);
	}

	public HtmlStringTypeConvertion()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		NRoutIGyfslZeiDWicZ9();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type O6tUQGGyBeSsTlWvNapG(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static Guid AhycvCGyWiyvQYidhtOx(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static object sNVNEwGyofwhhpWq7dkh(Type type, object P_1)
	{
		return type.GetReflectionProperty((string)P_1);
	}

	internal static bool WigQToGybGUV71o0ZCo9(object P_0, object P_1)
	{
		return (PropertyInfo)P_0 == (PropertyInfo)P_1;
	}

	internal static bool rDL00AGyhsbVpdCtvibp(Type type)
	{
		return type.IsNullableType();
	}

	internal static Type bcNLEHGyGk9lFxHR0bne(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static Type faWwkIGyE5e27NQk4PVv(Type type)
	{
		return type.GetNonNullableType();
	}

	internal static bool aUSeCWGmzeeR6GnlDVSH()
	{
		return jFNrgLGmc2vgLwdA4OyH == null;
	}

	internal static HtmlStringTypeConvertion QGM8yLGyF63lCSp0plOp()
	{
		return jFNrgLGmc2vgLwdA4OyH;
	}

	internal static void NRoutIGyfslZeiDWicZ9()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
