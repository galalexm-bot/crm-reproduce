using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Runtime.Settings;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics;

[Component(Order = 10)]
public class DiagnosticsSettingsModule : GlobalSettingsModuleBase<DiagnosticsSettings>
{
	public const string UID = "{9CE3451C-6402-41B5-8F10-9514DB61B89E}";

	public static readonly Guid Uid;

	private static DiagnosticsSettingsModule NDgVvXEWqo9AnbWjKX2s;

	public override Guid ModuleGuid => Uid;

	public override string ModuleName => (string)RZUZG8EWkf8Pa1pLI0nh(VvOyWEEWTgQMMaYFFYCZ(-234299632 ^ -234031366));

	public override void SaveSettings()
	{
		int num = 3;
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
				dOivyhEWPoR4JBHQCGoi(zZ8EAREWnNd5SAF67vwp());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				PODffFEW2nGjyZtixx4y(this);
				num2 = 5;
				break;
			case 2:
				HY4rGjEWOOHNmX9wpon3(zZ8EAREWnNd5SAF67vwp(), Settings);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 4;
				}
				break;
			case 5:
				if (!ACB3gbEWeJyFvQ8swEdw())
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (DiagnosticsManager.Initialized)
				{
					num2 = 2;
					break;
				}
				goto case 4;
			}
		}
	}

	public DiagnosticsSettingsModule()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		biaWfuEW1IQBIFpQMokI();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static DiagnosticsSettingsModule()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Uid = new Guid((string)VvOyWEEWTgQMMaYFFYCZ(-35995181 ^ -35722297));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				biaWfuEW1IQBIFpQMokI();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object VvOyWEEWTgQMMaYFFYCZ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object RZUZG8EWkf8Pa1pLI0nh(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool RfPfyVEWKQ6leSpemCyi()
	{
		return NDgVvXEWqo9AnbWjKX2s == null;
	}

	internal static DiagnosticsSettingsModule huXcymEWXMF9v7SeA527()
	{
		return NDgVvXEWqo9AnbWjKX2s;
	}

	internal static object zZ8EAREWnNd5SAF67vwp()
	{
		return DiagnosticsManager.Instance;
	}

	internal static void HY4rGjEWOOHNmX9wpon3(object P_0, object P_1)
	{
		((DiagnosticsManager)P_0).ValidateSettings((DiagnosticsSettings)P_1);
	}

	internal static void PODffFEW2nGjyZtixx4y(object P_0)
	{
		((GlobalSettingsModuleBase<DiagnosticsSettings>)P_0).SaveSettings();
	}

	internal static bool ACB3gbEWeJyFvQ8swEdw()
	{
		return DiagnosticsManager.Initialized;
	}

	internal static void dOivyhEWPoR4JBHQCGoi(object P_0)
	{
		((DiagnosticsManager)P_0).RefreshSettings();
	}

	internal static void biaWfuEW1IQBIFpQMokI()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
