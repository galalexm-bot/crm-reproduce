using EleWise.ELMA.Configuration;
using EleWise.ELMA.Runtime;
using EleWise.ELMA.Services;
using Glimpse.AspNet.Extensibility;
using Glimpse.Core.Extensibility;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Glimpse;

public class CurrentConfigurationTab : AspNetTab
{
	private static CurrentConfigurationTab tYH6qiEikWpPS3807O9r;

	public override string Name => (string)oB3bYdEi22SRS8SVAKhu(0x53CB464B ^ 0x53CF150D);

	public override object GetData(ITabContext context)
	{
		int num = 3;
		int num2 = num;
		IRuntimeApplication service = default(IRuntimeApplication);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			case 3:
				if (!Locator.Initialized)
				{
					num2 = 2;
					continue;
				}
				service = Locator.GetService<IRuntimeApplication>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return null;
			}
			if (service == null)
			{
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 1;
				}
				continue;
			}
			return VRiSLPEiPIN3Tyd2oWfo(((RuntimeConfiguration)NA22TjEieiBblepcD30T(service)).MainDB);
		}
	}

	public CurrentConfigurationTab()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		bYdpi2Ei1rcOfeufUxtm();
		((AspNetTab)this)._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object oB3bYdEi22SRS8SVAKhu(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool fWVxbDEin2O0gIAWijkK()
	{
		return tYH6qiEikWpPS3807O9r == null;
	}

	internal static CurrentConfigurationTab Ng1B37EiOZufVgQxl5Hv()
	{
		return tYH6qiEikWpPS3807O9r;
	}

	internal static object NA22TjEieiBblepcD30T(object P_0)
	{
		return ((IRuntimeApplication)P_0).Configuration;
	}

	internal static object VRiSLPEiPIN3Tyd2oWfo(object P_0)
	{
		return ((IDataBaseSettingsSection)P_0).ConnectionString;
	}

	internal static void bYdpi2Ei1rcOfeufUxtm()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
