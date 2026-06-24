using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Export;

[Serializable]
public class TranslateExportSettings
{
	internal static TranslateExportSettings iRyVFlE5UejXutQG7YBJ;

	public bool ExportTranslate
	{
		[CompilerGenerated]
		get
		{
			return _003CExportTranslate_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CExportTranslate_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public List<CultureInfo> Translates { get; set; }

	public TranslateExportSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
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
			Translates = new List<CultureInfo>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
			{
				num = 1;
			}
		}
	}

	internal static bool YAwoXjE5sMlHQ2L36kNI()
	{
		return iRyVFlE5UejXutQG7YBJ == null;
	}

	internal static TranslateExportSettings qEnJ2TE5cpNA3uD07HZy()
	{
		return iRyVFlE5UejXutQG7YBJ;
	}
}
