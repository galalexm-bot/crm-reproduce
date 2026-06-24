using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Workflow.Extensions;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component(Order = 20)]
public class SetNullStatusWorkflowProcessTerminateAction : IStatusWorkflowProcessTerminateAction
{
	public static Guid UID;

	internal static SetNullStatusWorkflowProcessTerminateAction vbJa0WOg2HCDqsStZH35;

	public string Name => (string)L3mVloOgITlg8FqOPMpd(kGA3CgOgieWRO7BNyRFu(-1028861977 ^ -1028848433));

	public Guid Uid => UID;

	public void Execute(IWorkflowInstance instance)
	{
		//Discarded unreachable code: IL_0098, IL_00a7
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				if (!(VxExE9OgrI2L4KUh2CG0(uPh5VIOgajlTIeqUqIHJ(instance)) == Guid.Empty))
				{
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 0:
				return;
			case 1:
				return;
			case 2:
				a0GUnnOge2oPucjSNJEi(instance.Context, ((IWorkflowProcess)uPh5VIOgajlTIeqUqIHJ(instance)).StatusContextVar, null);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public SetNullStatusWorkflowProcessTerminateAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		NvabeuOgNb85qdkK8xdF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static SetNullStatusWorkflowProcessTerminateAction()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				UID = new Guid((string)kGA3CgOgieWRO7BNyRFu(0xF400DF8 ^ 0xF41C6B2));
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				NvabeuOgNb85qdkK8xdF();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object kGA3CgOgieWRO7BNyRFu(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object L3mVloOgITlg8FqOPMpd(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool d2QfE5Ogo79uOFZ2nfmu()
	{
		return vbJa0WOg2HCDqsStZH35 == null;
	}

	internal static SetNullStatusWorkflowProcessTerminateAction zD4iU5OgFy1La6saicJk()
	{
		return vbJa0WOg2HCDqsStZH35;
	}

	internal static object uPh5VIOgajlTIeqUqIHJ(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static Guid VxExE9OgrI2L4KUh2CG0(object P_0)
	{
		return ((IWorkflowProcess)P_0).StatusContextVar;
	}

	internal static void a0GUnnOge2oPucjSNJEi(object P_0, Guid P_1, object P_2)
	{
		((Entity<long>)P_0).SetPropertyValue(P_1, P_2);
	}

	internal static void NvabeuOgNb85qdkK8xdF()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
