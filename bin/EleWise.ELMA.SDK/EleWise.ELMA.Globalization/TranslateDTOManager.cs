using System.Globalization;
using System.IO;
using System.Linq;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Files;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization;

public class TranslateDTOManager : DTOManager, ITranslateDTOManager, IConfigurationService
{
	internal static TranslateDTOManager WIgVR6GhVQEJBsJ8sdbf;

	public virtual bool IsTranslationMode()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return ((TranslateService)uDrTjrGhR66UXirM48pv()).IsTranslationModeEnabled((long?)null);
			case 1:
				if (TranslateService.Instance == null)
				{
					return false;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual bool IsTranslationChanged(LocalizationHash[] designerLocalizationHash)
	{
		int num = 1;
		int num2 = num;
		LocalizationHash[] array = default(LocalizationHash[]);
		while (true)
		{
			switch (num2)
			{
			default:
				return !GJwQLcGhKwTnBQMw4m0D(new ArrayEqualityComparer<LocalizationHash>(), array, designerLocalizationHash);
			case 1:
				array = (LocalizationHash[])VuBj6tGhqDs8VoOxkVoW(uDrTjrGhR66UXirM48pv());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public virtual string[] GetServerLocals()
	{
		return (from c in SR.GetCultureNames()
			select (string)_003C_003Ec.tC8jG1vlxxs6u2Lx7D21(c)).ToArray();
	}

	public virtual byte[] GetTranslations(LocalizationHash[] designerLocalizationHash)
	{
		//Discarded unreachable code: IL_00ff, IL_01ba, IL_01c9
		int num = 6;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		LocalizationHash hash = default(LocalizationHash);
		LocalizationHash[] array = default(LocalizationHash[]);
		int num3 = default(int);
		string text = default(string);
		string tempFileNameWithoutExtension = default(string);
		string dst = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 12:
					if (designerLocalizationHash.All(_003C_003Ec__DisplayClass3_._003CGetTranslations_003Eb__0))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 4;
				case 1:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 7;
					continue;
				case 7:
					_003C_003Ec__DisplayClass3_.hash = hash;
					num2 = 12;
					continue;
				default:
					hash = array[num3];
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					text = (string)Kdd4vhGhTVhetsSo7Yq6(tempFileNameWithoutExtension, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740411724));
					num = 3;
					break;
				case 3:
					IjrrdCGhkqEeaiFKh83q(Locator.GetServiceNotNull<IZipService>(), text, tempFileNameWithoutExtension);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 15;
					}
					continue;
				case 11:
					FileUtils.CopyDirectory(SR.GetCultureDir(_003C_003Ec__DisplayClass3_.hash.Local), dst);
					num2 = 4;
					continue;
				case 6:
					tempFileNameWithoutExtension = IOExtensions.GetTempFileNameWithoutExtension();
					num2 = 5;
					continue;
				case 13:
					dst = Path.Combine(tempFileNameWithoutExtension, (string)r5BRgyGhXH5CVB6mvh3o(_003C_003Ec__DisplayClass3_.hash));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 11;
					}
					continue;
				case 4:
					num3++;
					num2 = 14;
					continue;
				case 10:
					num3 = 0;
					num = 2;
					break;
				case 15:
					return (byte[])ereQTjGhnVtabyQwY0fc(text);
				case 5:
					array = ((TranslateService)uDrTjrGhR66UXirM48pv()).ComputeLocalizationHash();
					num2 = 10;
					continue;
				case 2:
				case 14:
					if (num3 < array.Length)
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 8;
				}
				break;
			}
		}
	}

	public virtual CultureInfoSimple GetDefaultLocal()
	{
		return CultureInfoSimple.CreateFromCultureInfo((CultureInfo)lQ3fqAGhOQdMVpx2afsH());
	}

	public TranslateDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		YsLFExGh2MumSZYpOyPP();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object uDrTjrGhR66UXirM48pv()
	{
		return TranslateService.Instance;
	}

	internal static bool AdYLIHGhS0txpxKYuUZF()
	{
		return WIgVR6GhVQEJBsJ8sdbf == null;
	}

	internal static TranslateDTOManager ri6DUxGhiHG28Od6i2GI()
	{
		return WIgVR6GhVQEJBsJ8sdbf;
	}

	internal static object VuBj6tGhqDs8VoOxkVoW(object P_0)
	{
		return ((TranslateService)P_0).ComputeLocalizationHash();
	}

	internal static bool GJwQLcGhKwTnBQMw4m0D(object P_0, object P_1, object P_2)
	{
		return ((ArrayEqualityComparer<LocalizationHash>)P_0).Equals((LocalizationHash[])P_1, (LocalizationHash[])P_2);
	}

	internal static object r5BRgyGhXH5CVB6mvh3o(object P_0)
	{
		return ((LocalizationHash)P_0).Local;
	}

	internal static object Kdd4vhGhTVhetsSo7Yq6(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object IjrrdCGhkqEeaiFKh83q(object P_0, object P_1, object P_2)
	{
		return ((IZipService)P_0).CreateZipFolder((string)P_1, (string)P_2);
	}

	internal static object ereQTjGhnVtabyQwY0fc(object P_0)
	{
		return File.ReadAllBytes((string)P_0);
	}

	internal static object lQ3fqAGhOQdMVpx2afsH()
	{
		return SR.GetDefaultCulture();
	}

	internal static void YsLFExGh2MumSZYpOyPP()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
