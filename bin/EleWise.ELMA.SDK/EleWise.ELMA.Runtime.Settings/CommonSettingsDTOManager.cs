using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Settings.DTO;

public class CommonSettingsDTOManager : DTOManager, ICommonSettingsDTOManager, IConfigurationService
{
	private static CommonSettingsDTOManager UZ27PVWGn64x6iFgyiAA;

	public virtual string GetApplicationBaseUrl()
	{
		return (string)SxK29fWGefLi7AKOvCO1(Locator.GetServiceNotNull<CommonSettingsModule>().Settings);
	}

	public CommonSettingsDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zmhLEZWGPQ85mG0xBlip();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object SxK29fWGefLi7AKOvCO1(object P_0)
	{
		return ((CommonSettings)P_0).ApplicationBaseUrl;
	}

	internal static bool HK4SUIWGOymJ6iKEFy3B()
	{
		return UZ27PVWGn64x6iFgyiAA == null;
	}

	internal static CommonSettingsDTOManager ibJAKnWG24I7ipvOBeNT()
	{
		return UZ27PVWGn64x6iFgyiAA;
	}

	internal static void zmhLEZWGPQ85mG0xBlip()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
