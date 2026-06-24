using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Packaging;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Export;

[Serializable]
public class PackageExportSettings
{
	internal static PackageExportSettings stEAtIEYonSYajvTw3V7;

	public bool ExportPackages
	{
		[CompilerGenerated]
		get
		{
			return _003CExportPackages_003Ek__BackingField;
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
				case 0:
					return;
				case 1:
					_003CExportPackages_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<PackageDescription> Packages { get; set; }

	public PackageExportSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wh59ysEYGhe1jwCo7MnA();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Packages = new List<PackageDescription>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void wh59ysEYGhe1jwCo7MnA()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool pISIHvEYbfjBSsdV1yqa()
	{
		return stEAtIEYonSYajvTw3V7 == null;
	}

	internal static PackageExportSettings WUpEcXEYh6sh8HF1mtRj()
	{
		return stEAtIEYonSYajvTw3V7;
	}
}
