using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Runtime.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Globalization;

[Component(Order = 100)]
public class ResetSystemSettingsTranslateChangeHandler : ITranslateChangeHandler
{
	private static ResetSystemSettingsTranslateChangeHandler nB7QxmGErn1tfeP8WcXG;

	public void Execute()
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
				((ComponentManager)zpAFgnGEjRmM88dD50tL()).GetExtensionPoints<IGlobalSettingsModule>().ForEach(delegate(IGlobalSettingsModule p)
				{
					_003C_003Ec.kMFbSRvgYaVWdfj3PYpv(p);
				});
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public ResetSystemSettingsTranslateChangeHandler()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		DXkY6WGEYQd32CfiFNUZ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object zpAFgnGEjRmM88dD50tL()
	{
		return ComponentManager.Current;
	}

	internal static bool xb1S79GEgJBb0OicKfsc()
	{
		return nB7QxmGErn1tfeP8WcXG == null;
	}

	internal static ResetSystemSettingsTranslateChangeHandler DdeiXKGE5DRuCPMipf5j()
	{
		return nB7QxmGErn1tfeP8WcXG;
	}

	internal static void DXkY6WGEYQd32CfiFNUZ()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
