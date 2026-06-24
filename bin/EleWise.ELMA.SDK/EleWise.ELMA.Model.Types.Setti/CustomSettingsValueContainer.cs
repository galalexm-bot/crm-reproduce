using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Types.Settings;

[Component]
public class CustomSettingsValueContainer : IXsiRoot
{
	private static CustomSettingsValueContainer kcbBxmosafBhM4ptDuwt;

	public List<CustomSettingValue> Settings { get; set; }

	public CustomSettingsValueContainer()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Settings = new List<CustomSettingValue>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
			{
				num = 1;
			}
		}
	}

	public CustomSettingsValueContainer(List<CustomSettingValue> settings)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Settings = settings;
	}

	internal static bool YdXjjMosD2lI5ku6DP90()
	{
		return kcbBxmosafBhM4ptDuwt == null;
	}

	internal static CustomSettingsValueContainer nfAHlMostHNCXI3WeZbv()
	{
		return kcbBxmosafBhM4ptDuwt;
	}
}
