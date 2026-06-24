using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Components;

[Component]
public class CapiComAuthCryptoProvider : CryptoProviderBase, IAuthCryptoProvider, ICryptoProviderBase
{
	public const string UID_S = "4C91FED4-2FA6-4A49-B16C-32A5BA05E2D4";

	internal static CapiComAuthCryptoProvider HwUoJAfHchOr2lTONSr;

	protected CapiComAuthSettingsModule Module => Locator.GetServiceNotNull<CapiComAuthSettingsModule>();

	public override Guid ProviderUid => new Guid((string)oGjOEQfwWlylrUkyRcA(-426925384 ^ -426988850));

	public CapiComAuthCryptoProvider()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			base.Impl = new CapiComCryptoProviderImpl(Module.Settings);
			num = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 != 0)
			{
				num = 1;
			}
		}
	}

	internal static bool yb6NvMfaL9cj1tDqGgC()
	{
		return HwUoJAfHchOr2lTONSr == null;
	}

	internal static CapiComAuthCryptoProvider mV3h08fRS0KSbMgRlFJ()
	{
		return HwUoJAfHchOr2lTONSr;
	}

	internal static object oGjOEQfwWlylrUkyRcA(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
