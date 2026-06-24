using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.Deploy.Export.ExtensionPoints;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Deploy.Export;

public class ProcessHeaderExportValuesEdit : EntityExportValuesEdit
{
	public static readonly Guid UID;

	private static ProcessHeaderExportValuesEdit jy8kMNOOQENolT8B7h1f;

	public override Guid TypeUid => UID;

	public override void EditValues(Dictionary<string, object> values)
	{
		if (values[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C7F6FED ^ 0x1C7FCEBB)] is IEnumerable source)
		{
			values[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34EA50D4 ^ 0x34EAF182)] = (from IProcessHeader p in source
				where _003C_003Ec.aBeKMwZhEljqeWayBbex(p) != WorkflowProcessStatus.Deleted
				select p).ToList();
		}
		values[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xF400DF8 ^ 0xF401D60)] = null;
		values[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x56A753C9 ^ 0x56A71553)] = null;
		values[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398691253 ^ -398660687)] = null;
		values[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2111219045 ^ -2111177797)] = null;
	}

	public ProcessHeaderExportValuesEdit()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		U8KLk4OOMUtoHGqZi9qg();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3ab79470996d472f815915b21f45aac1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ProcessHeaderExportValuesEdit()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				U8KLk4OOMUtoHGqZi9qg();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7d23dbc0284240b99ff34f0f55f345f6 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid((string)Vb2efnOOkMfBO22Rsh11(-420003255 ^ -420075191));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_90dfe18b3d784ead92a1e4e4e2547482 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void U8KLk4OOMUtoHGqZi9qg()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool AUcKN4OOpHaAYyqXJrv9()
	{
		return jy8kMNOOQENolT8B7h1f == null;
	}

	internal static ProcessHeaderExportValuesEdit x1hxsSOOCZwGiosUhoSZ()
	{
		return jy8kMNOOQENolT8B7h1f;
	}

	internal static object Vb2efnOOkMfBO22Rsh11(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
