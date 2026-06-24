using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Components;

public abstract class CryptoProviderSettingsModuleBase<TSettings, TProvider> : GlobalSettingsModuleBase<TSettings> where TSettings : CryptoProviderSettingsBase, new()where TProvider : CryptoProviderBase
{
	private static object lrK8aNff3VVCDdlAy9B;

	public TProvider Provider => Locator.GetService<TProvider>();

	protected CryptoProviderSettingsModuleBase()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool DQxaRUf1BqE6TlKCabu()
	{
		return lrK8aNff3VVCDdlAy9B == null;
	}

	internal static object rBrobGfzLldtQaVf652()
	{
		return lrK8aNff3VVCDdlAy9B;
	}
}
