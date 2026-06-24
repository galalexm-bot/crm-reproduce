using System;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Settings;

[Component]
public class CommonSettingsModule : GlobalSettingsModuleBase<CommonSettings>
{
	public const string UID = "e0fe14e4-ff52-435c-85f0-5e92a5d11c6b";

	public static readonly Guid Uid;

	private static CommonSettingsModule Cag9BUWhpFk0Y4E8hiKA;

	public override Guid ModuleGuid => Uid;

	public override string ModuleName => (string)bZZr9IWhtix0YHtbyPw4(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672028519));

	protected override void LoadSettings()
	{
		//Discarded unreachable code: IL_0052, IL_0061, IL_0092, IL_00a1
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (_settings == null)
					{
						num2 = 4;
						continue;
					}
					goto case 3;
				case 2:
					return;
				case 6:
					Yq7aQ0Whw9NQHHJIsIaI(this);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					return;
				case 4:
					return;
				case 3:
					if (c8bKEwWh6D2KdO3uPQBH(RilbNXWh46Wk5tBK4Ibi(_settings)))
					{
						break;
					}
					goto end_IL_0012;
				}
				DIDC5QWhHTR7r4nE8Tlq(_settings, SR.GetDefaultCulture().Name);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public override void SaveSettings()
	{
		//Discarded unreachable code: IL_0039
		int num = 4;
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
				SR.SaveCultureToSettings((string)RilbNXWh46Wk5tBK4Ibi(Settings));
				num2 = 5;
				break;
			case 3:
				if (Settings == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				if (!c8bKEwWh6D2KdO3uPQBH(Settings.SystemDefaultCultureName))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num2 = 1;
					}
					break;
				}
				return;
			case 5:
				return;
			case 4:
				g5NAKZWhAuIffZDFB6rT(this);
				num2 = 3;
				break;
			}
		}
	}

	public CommonSettingsModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BteGKvWh7AUD1Qd7sXsG();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static CommonSettingsModule()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Uid = new Guid((string)zMVi1sWhxbGHCP2hcYC2(-1876063057 ^ -1876053665));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				BteGKvWh7AUD1Qd7sXsG();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static object bZZr9IWhtix0YHtbyPw4(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool z7mwnUWhaSfCyK70kORv()
	{
		return Cag9BUWhpFk0Y4E8hiKA == null;
	}

	internal static CommonSettingsModule WcDGndWhDbeOCVqsQ305()
	{
		return Cag9BUWhpFk0Y4E8hiKA;
	}

	internal static void Yq7aQ0Whw9NQHHJIsIaI(object P_0)
	{
		((GlobalSettingsModuleBase<CommonSettings>)P_0).LoadSettings();
	}

	internal static object RilbNXWh46Wk5tBK4Ibi(object P_0)
	{
		return ((CommonSettings)P_0).SystemDefaultCultureName;
	}

	internal static bool c8bKEwWh6D2KdO3uPQBH(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void DIDC5QWhHTR7r4nE8Tlq(object P_0, object P_1)
	{
		((CommonSettings)P_0).SystemDefaultCultureName = (string)P_1;
	}

	internal static void g5NAKZWhAuIffZDFB6rT(object P_0)
	{
		((GlobalSettingsModuleBase<CommonSettings>)P_0).SaveSettings();
	}

	internal static void BteGKvWh7AUD1Qd7sXsG()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object zMVi1sWhxbGHCP2hcYC2(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
