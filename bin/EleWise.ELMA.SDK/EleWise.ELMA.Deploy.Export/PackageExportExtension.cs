using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Export;

[Component(Order = 400)]
public class PackageExportExtension : IConfigExportExtension
{
	public const string ServiceDataPrefix = "PackageToExport";

	internal static PackageExportExtension JWfkVLEjsEkXS1b40mEA;

	public Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			PackageExportConsts.ExportExtensionUid,
			new PackageExportSettings()
		} };
	}

	public void AddExportObjects(ExportExtensionParams parameters)
	{
		//Discarded unreachable code: IL_007e, IL_008d
		int num = 9;
		PackageExportSettings packageExportSettings = default(PackageExportSettings);
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		PackageService serviceNotNull = default(PackageService);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					packageExportSettings.Packages.ForEach(_003C_003Ec__DisplayClass2_._003CAddExportObjects_003Eb__0);
					num2 = 6;
					break;
				case 8:
					_003C_003Ec__DisplayClass2_.parameters = parameters;
					num2 = 7;
					break;
				case 3:
					if (packageExportSettings == null)
					{
						return;
					}
					goto end_IL_0012;
				case 0:
					return;
				case 5:
					serviceNotNull = Locator.GetServiceNotNull<PackageService>();
					num2 = 4;
					break;
				case 7:
					packageExportSettings = _003C_003Ec__DisplayClass2_.parameters.Parameters[PackageExportConsts.ExportExtensionUid] as PackageExportSettings;
					num2 = 3;
					break;
				case 6:
					return;
				case 9:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 8;
					break;
				case 2:
					if (!sWvumLEYFhDE0k2FDE68(packageExportSettings))
					{
						return;
					}
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 5;
					}
					break;
				case 4:
				{
					_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_2 = _003C_003Ec__DisplayClass2_;
					PackageService packageService = serviceNotNull;
					PackageFilter packageFilter = new PackageFilter();
					Pocb2AEYBhwu9ML70QAT(packageFilter, PackageLevel.All);
					eQHZbDEYW7RRlbqRoWQ0(packageFilter, PackageStatus.Any);
					_003C_003Ec__DisplayClass2_2.allPackages = packageService.Find(packageFilter);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public PackageExportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool sWvumLEYFhDE0k2FDE68(object P_0)
	{
		return ((PackageExportSettings)P_0).ExportPackages;
	}

	internal static void Pocb2AEYBhwu9ML70QAT(object P_0, PackageLevel value)
	{
		((PackageFilter)P_0).Level = value;
	}

	internal static void eQHZbDEYW7RRlbqRoWQ0(object P_0, PackageStatus value)
	{
		((PackageFilter)P_0).Status = value;
	}

	internal static bool h2JKZuEjc8bjKmkGfrM2()
	{
		return JWfkVLEjsEkXS1b40mEA == null;
	}

	internal static PackageExportExtension JDfYH8EjzC5hPngiMCC9()
	{
		return JWfkVLEjsEkXS1b40mEA;
	}
}
