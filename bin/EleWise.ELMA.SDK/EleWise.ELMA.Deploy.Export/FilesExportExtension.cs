using System;
using System.Collections.Generic;
using EleWise.ELMA.BPMApps.Services;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Export;

[Component(Order = 50)]
public class FilesExportExtension : IConfigExportExtension
{
	internal const string DocumentationVersionServiceDataKey = "DocumentationVersions";

	internal const string RootSubFolderForAdditionalFiles = "Files";

	internal const string ComponentFilesFolder = "ComponentFiles";

	internal static FilesExportExtension DBu1KaEj8B6WHGh9rB07;

	public Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			FilesExportConsts.ExportExtensionUid,
			new FilesExportSetting()
		} };
	}

	public void AddExportObjects(ExportExtensionParams parameters)
	{
		//Discarded unreachable code: IL_00e0, IL_0157, IL_0166
		int num = 10;
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		byte[] helpFileContent = default(byte[]);
		byte[] additionalFilesContent = default(byte[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
				case 14:
					if (yieTUbEjIopGJTWeIGPL(_003C_003Ec__DisplayClass4_.setting) == null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 5;
				case 3:
					vtqeVmEjSqaTq0alRHIM(_003C_003Ec__DisplayClass4_.setting, helpFileContent);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					Locator.GetServiceNotNull<IBpmAppService>().LoadFiles(ceLm2XEjVTqcklc7WSCn(_003C_003Ec__DisplayClass4_.setting), out helpFileContent, out additionalFilesContent);
					num2 = 3;
					continue;
				case 8:
					if (ceLm2XEjVTqcklc7WSCn(_003C_003Ec__DisplayClass4_.setting) == 0L)
					{
						num2 = 6;
						continue;
					}
					goto case 16;
				case 15:
					return;
				case 11:
					if (yieTUbEjIopGJTWeIGPL(_003C_003Ec__DisplayClass4_.setting) == null)
					{
						num2 = 17;
						continue;
					}
					goto case 6;
				case 12:
					if (_003C_003Ec__DisplayClass4_.setting == null)
					{
						return;
					}
					num2 = 11;
					continue;
				case 4:
					if (BDAtVkEjRNr4pihYawox(_003C_003Ec__DisplayClass4_.setting) != null)
					{
						num2 = 5;
						continue;
					}
					return;
				case 10:
					_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
					num2 = 9;
					continue;
				case 9:
					_003C_003Ec__DisplayClass4_.setting = parameters.Parameters[FilesExportConsts.ExportExtensionUid] as FilesExportSetting;
					num2 = 12;
					continue;
				case 17:
					if (_003C_003Ec__DisplayClass4_.setting.AdditionalFilesContent == null)
					{
						num2 = 8;
						continue;
					}
					goto case 6;
				case 2:
					return;
				case 5:
					parameters.ServiceData.Add((string)r6pYvnEjqi3NSNmXa6lV(-541731959 ^ -542003737), r6pYvnEjqi3NSNmXa6lV(-105199646 ^ -104941186));
					num2 = 13;
					continue;
				case 1:
					return;
				case 7:
					parameters.WriteComponentFileActions.Add(_003C_003Ec__DisplayClass4_._003CAddExportObjects_003Eb__0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					k9DSpeEjkNbS4e3exrHP(Db3kbvEjKmklHfxajIcO(parameters), (!umPGSeEjTxxkJ3cOvNG3(fmmkQJEjXIA6JYB6JDtU(_003C_003Ec__DisplayClass4_.setting))) ? fmmkQJEjXIA6JYB6JDtU(_003C_003Ec__DisplayClass4_.setting) : "");
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 7;
					}
					continue;
				}
				break;
			}
			hOUxdmEji0JrBs7UpeUw(_003C_003Ec__DisplayClass4_.setting, additionalFilesContent);
			num = 14;
		}
	}

	public FilesExportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Clta1DEjnF3Q8kVGls08();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object yieTUbEjIopGJTWeIGPL(object P_0)
	{
		return ((FilesExportSetting)P_0).HelpFileContent;
	}

	internal static long ceLm2XEjVTqcklc7WSCn(object P_0)
	{
		return ((FilesExportSetting)P_0).BpmAppId;
	}

	internal static void vtqeVmEjSqaTq0alRHIM(object P_0, object P_1)
	{
		((FilesExportSetting)P_0).HelpFileContent = (byte[])P_1;
	}

	internal static void hOUxdmEji0JrBs7UpeUw(object P_0, object P_1)
	{
		((FilesExportSetting)P_0).AdditionalFilesContent = (byte[])P_1;
	}

	internal static object BDAtVkEjRNr4pihYawox(object P_0)
	{
		return ((FilesExportSetting)P_0).AdditionalFilesContent;
	}

	internal static object r6pYvnEjqi3NSNmXa6lV(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Db3kbvEjKmklHfxajIcO(object P_0)
	{
		return ((ExportExtensionParams)P_0).Manifest;
	}

	internal static object fmmkQJEjXIA6JYB6JDtU(object P_0)
	{
		return ((FilesExportSetting)P_0).HelpFileName;
	}

	internal static bool umPGSeEjTxxkJ3cOvNG3(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void k9DSpeEjkNbS4e3exrHP(object P_0, object P_1)
	{
		((ElmaStoreComponentManifest)P_0).HelpFileName = (string)P_1;
	}

	internal static bool H1ZIMEEjZaEmsBqFvC3E()
	{
		return DBu1KaEj8B6WHGh9rB07 == null;
	}

	internal static FilesExportExtension Gw7RBqEjuaANrLoUYCfW()
	{
		return DBu1KaEj8B6WHGh9rB07;
	}

	internal static void Clta1DEjnF3Q8kVGls08()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
