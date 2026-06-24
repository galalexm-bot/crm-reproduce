using System;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Globalization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Globalization;

[Component]
public class ProcessesLocalizationLoadCustomSettings : ILocalizationLoadCustomSettings
{
	public static readonly Guid ExtensionUid;

	private static ProcessesLocalizationLoadCustomSettings nPbug3CmiTFLnSyjPmG;

	public Dictionary<Guid, object> GetNewSettingObj()
	{
		return new Dictionary<Guid, object> { 
		{
			ExtensionUid,
			new ProcessGlobalizationSettings()
		} };
	}

	public ProcessesLocalizationLoadCustomSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dwWuDsC5d9KrKnMJtoP();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cb262bcfe4074a1ab16e653815d57f28 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ProcessesLocalizationLoadCustomSettings()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				ExtensionUid = new Guid((string)TNWdgcCgLUQMotl4GQJ(-1516552726 ^ -1516516408));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				dwWuDsC5d9KrKnMJtoP();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void dwWuDsC5d9KrKnMJtoP()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool Bj4xtLCtlwS83P5j3mg()
	{
		return nPbug3CmiTFLnSyjPmG == null;
	}

	internal static ProcessesLocalizationLoadCustomSettings VEWkrcCbQLDY5kbt96d()
	{
		return nPbug3CmiTFLnSyjPmG;
	}

	internal static object TNWdgcCgLUQMotl4GQJ(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
