using System;
using EleWise.ELMA.Model.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowTablePartManagerMaker : IManagerMaker
{
	private static WorkflowTablePartManagerMaker Twr1ng9rosK77ihqSyq;

	public Type MakeManager(Type objectType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				Contract.ArgumentNotNull(objectType, (string)kZtp1P9xlONhdSk7WJH(-1542190822 ^ -1542149416));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return jno8en9SRGLpv4U1mfC(typeof(WorkflowTablePartManager<>).TypeHandle).MakeGenericType(objectType);
			}
		}
	}

	public WorkflowTablePartManagerMaker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object kZtp1P9xlONhdSk7WJH(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type jno8en9SRGLpv4U1mfC(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static bool dMmQR69e8oW0wsmAlTr()
	{
		return Twr1ng9rosK77ihqSyq == null;
	}

	internal static WorkflowTablePartManagerMaker iECHKZ9NlYf91K8FGny()
	{
		return Twr1ng9rosK77ihqSyq;
	}
}
