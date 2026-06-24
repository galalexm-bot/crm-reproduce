using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Security.Extensions;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Components;

[Component]
public class DefaultDigitalSignatureType : AbstractDefaultDigitalSignatureType
{
	private static DefaultDigitalSignatureType gSNTMd1ksKdd2yDjPmt;

	public override IEnumerable<Guid> Providers => from p in ComponentManager.Current.GetExtensionPoints<IAuthCryptoProvider>()
		select p.ProviderUid;

	public DefaultDigitalSignatureType()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		GwmEnZ1ApieK8TD5ZPW();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void GwmEnZ1ApieK8TD5ZPW()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool pM2wQI1pBRm5pxEDQwq()
	{
		return gSNTMd1ksKdd2yDjPmt == null;
	}

	internal static DefaultDigitalSignatureType xB2Obi15fXwhdsZaeQy()
	{
		return gSNTMd1ksKdd2yDjPmt;
	}
}
