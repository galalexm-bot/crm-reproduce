using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Diagrams;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.ExtensionPoints;

[Component(Order = 1)]
internal sealed class OpenSettingsContextAction : IBPMNElementContextAction
{
	private static OpenSettingsContextAction NMmAr1ZO0EtZQqhZbTP1;

	public Guid ActionUid => new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1965291699 ^ -1965132105));

	public string Text => (string)smgrXSZOtim9EuUptpXH();

	public string Image => (string)tpPncUZObwS10VLJ0QYq(0x2ACCDD87 ^ 0x2ACEAFC1);

	public bool IsSupported(Type type)
	{
		return fq7S16ZO5qaGQssHXJMy(typeof(Element).TypeHandle).IsAssignableFrom(type);
	}

	public OpenSettingsContextAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		MWabMDZOgqAvprbmcMdV();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool tnHtO6ZOy1jW20w1DMfj()
	{
		return NMmAr1ZO0EtZQqhZbTP1 == null;
	}

	internal static OpenSettingsContextAction I3PDYnZOmhBc1TGBOOfD()
	{
		return NMmAr1ZO0EtZQqhZbTP1;
	}

	internal static object smgrXSZOtim9EuUptpXH()
	{
		return SR.Settings;
	}

	internal static object tpPncUZObwS10VLJ0QYq(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type fq7S16ZO5qaGQssHXJMy(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static void MWabMDZOgqAvprbmcMdV()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
