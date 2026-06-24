using System.CodeDom.Compiler;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Properties;

[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "15.9.0.0")]
[CompilerGenerated]
internal sealed class Settings : ApplicationSettingsBase
{
	private static Settings defaultInstance;

	internal static Settings oGd28FvgVxbabqsguC6;

	public static Settings Default => defaultInstance;

	[DefaultSettingValue("http://localhost:7033/ServerInfo.asmx")]
	[ApplicationScopedSetting]
	[DebuggerNonUserCode]
	[SpecialSetting(SpecialSetting.WebServiceUrl)]
	public string EleWise_ELMA_SDK_ServerInfoReference_ServerInfo => (string)Q2yr0ivLcoqINU6OlxE(this, xuXCKqvYqoaZ430CATC(-2099751081 ^ -2099746087));

	public Settings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static Settings()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				JVlPRVvUbDYBsSMyYcE();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				defaultInstance = (Settings)PX46iRvsQD0Lqsjv59y(new Settings());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object xuXCKqvYqoaZ430CATC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Q2yr0ivLcoqINU6OlxE(object P_0, object P_1)
	{
		return ((SettingsBase)P_0)[(string)P_1];
	}

	internal static bool EGXxO2v5rSfwev2Wt2P()
	{
		return oGd28FvgVxbabqsguC6 == null;
	}

	internal static Settings HmPWZOvjQlPbTvRMLOj()
	{
		return oGd28FvgVxbabqsguC6;
	}

	internal static void JVlPRVvUbDYBsSMyYcE()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object PX46iRvsQD0Lqsjv59y(object P_0)
	{
		return SettingsBase.Synchronized((SettingsBase)P_0);
	}
}
