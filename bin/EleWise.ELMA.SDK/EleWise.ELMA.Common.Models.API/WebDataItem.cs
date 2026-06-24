using System;
using System.Linq;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Common.Models.API;

[Serializable]
public class WebDataItem : EleWise.ELMA.Common.Models.WebDataItem
{
	private static WebDataItem GdPrKwfRKRTk3lBftERa;

	public WebDataItem()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		aXspbNfRk1n23jjkvxee();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public static WebDataItem Create(EleWise.ELMA.Common.Models.WebDataItem baseItem)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (baseItem == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return new WebDataItem
				{
					name = (string)XrAbUFfRngty0SNvmSAE(baseItem),
					value = (string)pptoc9fROWfJfHPZtG92(baseItem),
					data = (EleWise.ELMA.Common.Models.WebData)DpOJ0lfReNTbEYWBw5LS(OK82pkfR2C1rc6PkcEBv(baseItem)),
					dataArray = baseItem.DataArray.Select(WebData.Create).Cast<EleWise.ELMA.Common.Models.WebData>().ToArray()
				};
			default:
				return null;
			}
		}
	}

	internal static void aXspbNfRk1n23jjkvxee()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool NMmrQPfRXS8wTWwoV81q()
	{
		return GdPrKwfRKRTk3lBftERa == null;
	}

	internal static WebDataItem iv1kdNfRTPiuqO6dMcIq()
	{
		return GdPrKwfRKRTk3lBftERa;
	}

	internal static object XrAbUFfRngty0SNvmSAE(object P_0)
	{
		return ((EleWise.ELMA.Common.Models.WebDataItem)P_0).Name;
	}

	internal static object pptoc9fROWfJfHPZtG92(object P_0)
	{
		return ((EleWise.ELMA.Common.Models.WebDataItem)P_0).Value;
	}

	internal static object OK82pkfR2C1rc6PkcEBv(object P_0)
	{
		return ((EleWise.ELMA.Common.Models.WebDataItem)P_0).Data;
	}

	internal static object DpOJ0lfReNTbEYWBw5LS(object P_0)
	{
		return WebData.Create((EleWise.ELMA.Common.Models.WebData)P_0);
	}
}
