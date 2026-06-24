using System;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Mappings;

[Obsolete("Рекомендуется использовать IPropertyMapService")]
public class PropertyMapHelper
{
	private static IPropertyMapService propertyMapService;

	private static IPropertyMapService PropertyMapService;

	internal static PropertyMapHelper HNDuY7hbSKYrSELXFJwU;

	[Obsolete("Вместо этого метода рекомендуется использовать IPropertyMapService.Map")]
	public static void Map(object objLeft, object objRight, PropertyMap map)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				l6YBgghbqgnfoBUAFIQd(PropertyMapService, objLeft, objRight, map);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public PropertyMapHelper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		UmuiLrhbKHPe35xTIhfD();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PropertyMapHelper()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			IPropertyMapService obj;
			switch (num2)
			{
			case 1:
				UmuiLrhbKHPe35xTIhfD();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			default:
				obj = propertyMapService;
				if (obj != null)
				{
					break;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				obj = (propertyMapService = Locator.GetServiceNotNull<IPropertyMapService>());
				break;
			}
			PropertyMapService = obj;
			num2 = 3;
		}
	}

	internal static void l6YBgghbqgnfoBUAFIQd(object P_0, object P_1, object P_2, object P_3)
	{
		((IPropertyMapService)P_0).Map(P_1, P_2, (PropertyMap)P_3);
	}

	internal static bool zVfPsMhbityiMRiSAMfW()
	{
		return HNDuY7hbSKYrSELXFJwU == null;
	}

	internal static PropertyMapHelper sgEOrNhbRXuLdRNIxS9a()
	{
		return HNDuY7hbSKYrSELXFJwU;
	}

	internal static void UmuiLrhbKHPe35xTIhfD()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
