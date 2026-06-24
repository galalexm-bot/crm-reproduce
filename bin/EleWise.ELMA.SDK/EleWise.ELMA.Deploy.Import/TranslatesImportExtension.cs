using System.Linq;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Deploy.Import;

[Component]
internal class TranslatesImportExtension : ConfigImportExtension
{
	internal static TranslatesImportExtension iHhCnpE0YrWwkONhxHKD;

	public override void OnPostCompleteTest(PostCompleteTestImportParameters parameters)
	{
		//Discarded unreachable code: IL_007d, IL_009d, IL_00d7, IL_01a7, IL_01e1, IL_01f0
		int num = 6;
		int num2 = num;
		TranslatesBAChapter translatesBAChapter = default(TranslatesBAChapter);
		ConfigImportSettings configImportSettings = default(ConfigImportSettings);
		BPMAppManifest bPMAppManifest = default(BPMAppManifest);
		_003C_003Ec__DisplayClass0_0 _003C_003Ec__DisplayClass0_ = default(_003C_003Ec__DisplayClass0_0);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 8:
				return;
			case 19:
				if (translatesBAChapter != null)
				{
					num2 = 18;
					break;
				}
				return;
			case 2:
				return;
			case 1:
				if (fYLjjuE0z9affJ0tJt09(configImportSettings) == null)
				{
					num2 = 21;
					break;
				}
				translatesBAChapter = bPMAppManifest.Chapters.FirstOrDefault((BPMAppManifestChapter c) => _003C_003Ec.hDWYKt8DOtchI97YFR8X(c.Uid, TranslateExportConst.ExportExtensionUid)) as TranslatesBAChapter;
				num2 = 19;
				break;
			case 6:
				if (parameters == null)
				{
					num2 = 5;
					break;
				}
				obj = parameters.ImportSettings;
				goto IL_02ae;
			case 5:
				obj = null;
				goto IL_02ae;
			case 11:
				if (configImportSettings == null)
				{
					num2 = 8;
					break;
				}
				goto case 7;
			default:
				if (RXQfUoE0clMXlOIsDdBk(configImportSettings) == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 10;
			case 3:
				return;
			case 10:
				if (configImportSettings.Manifest.Packages.Any())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 18:
				if (!translatesBAChapter.Translates.Any())
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
				{
					num2 = 20;
				}
				break;
			case 13:
				translatesBAChapter.Translates.ForEach(_003C_003Ec__DisplayClass0_._003COnPostCompleteTest_003Eb__1);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 3;
				}
				break;
			case 15:
				if (bPMAppManifest.Chapters.Any())
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 7;
					}
					break;
				}
				return;
			case 17:
				return;
			case 12:
				return;
			case 14:
				bPMAppManifest = ClassSerializationHelper.DeserializeObjectByXml<BPMAppManifest>(parameters.Manifest.BPMAppManifest);
				num2 = 22;
				break;
			case 20:
				_003C_003Ec__DisplayClass0_ = new _003C_003Ec__DisplayClass0_0();
				num2 = 4;
				break;
			case 7:
				if (parameters == null)
				{
					return;
				}
				num2 = 16;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 1;
				}
				break;
			case 16:
				if (ylov2AE0swuD83XJddT4(parameters) == null)
				{
					return;
				}
				num2 = 14;
				break;
			case 9:
				if (configImportSettings == null)
				{
					num2 = 17;
					break;
				}
				goto default;
			case 22:
				if (bPMAppManifest != null)
				{
					num2 = 15;
					break;
				}
				return;
			case 4:
				_003C_003Ec__DisplayClass0_.chapter = ((BPMAppFakeManifest)fYLjjuE0z9affJ0tJt09(configImportSettings)).GetOrCreateChapterByUid(TranslateExportConst.ExportExtensionUid, "");
				num2 = 13;
				break;
			case 21:
				return;
				IL_02ae:
				configImportSettings = obj as ConfigImportSettings;
				num2 = 11;
				break;
			}
		}
	}

	public TranslatesImportExtension()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		FBVBQKEmFkBeuPc0NPwA();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object ylov2AE0swuD83XJddT4(object P_0)
	{
		return ((TestImportExtensionParameters)P_0).Manifest;
	}

	internal static object RXQfUoE0clMXlOIsDdBk(object P_0)
	{
		return ((ConfigImportSettings)P_0).Manifest;
	}

	internal static object fYLjjuE0z9affJ0tJt09(object P_0)
	{
		return ((ConfigImportSettings)P_0).FakeManifest;
	}

	internal static bool yyrD2NE0LACPI4PFYxfV()
	{
		return iHhCnpE0YrWwkONhxHKD == null;
	}

	internal static TranslatesImportExtension UxV6i6E0ULqJIaXAvjvk()
	{
		return iHhCnpE0YrWwkONhxHKD;
	}

	internal static void FBVBQKEmFkBeuPc0NPwA()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
