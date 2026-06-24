using EleWise.ELMA.Workflow.Services;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.ChangeProcessVersion;

public class ChangeProcessVersionUpdateInstanceStateAction : IChangeProcessVersionAction
{
	private IWorkflowInstance instance;

	private IWorkflowProcess newProcess;

	internal static ChangeProcessVersionUpdateInstanceStateAction IA7wNlOp1mNAohv1I7Iv;

	public ChangeProcessVersionUpdateInstanceStateAction(IWorkflowInstance instance, IWorkflowProcess newProcess)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qjH6EZOpwiG8MEy95K4o();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f453500aaab143479696408f48a03c17 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.newProcess = newProcess;
				num = 2;
				continue;
			case 2:
				return;
			}
			this.instance = instance;
			num = 0;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 != 0)
			{
				num = 1;
			}
		}
	}

	public void Execute()
	{
		//Discarded unreachable code: IL_0064, IL_0073
		int num = 5;
		int num2 = num;
		byte[] changedWorkflowInstanceState = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 4:
				pc1CPdOp4w3HsJfU0bD5(instance, newProcess);
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				return;
			default:
				if (kdvjeHOpzUhnWuRWH7Nu(instance) == null)
				{
					num2 = 3;
					continue;
				}
				break;
			case 5:
				changedWorkflowInstanceState = WorkflowInstanceStateHelper.GetChangedWorkflowInstanceState(instance, newProcess);
				num2 = 4;
				continue;
			case 1:
				break;
			case 2:
				return;
			}
			sX6HXsOCK1dhca6vpsqx(kdvjeHOpzUhnWuRWH7Nu(instance), changedWorkflowInstanceState);
			num2 = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_43af423d081c48e3bc6cea30ce47523d == 0)
			{
				num2 = 2;
			}
		}
	}

	internal static void qjH6EZOpwiG8MEy95K4o()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool Rekoy1OphXdrxQiWNxUS()
	{
		return IA7wNlOp1mNAohv1I7Iv == null;
	}

	internal static ChangeProcessVersionUpdateInstanceStateAction DJZdaMOpEfBM5WAdT3pC()
	{
		return IA7wNlOp1mNAohv1I7Iv;
	}

	internal static void pc1CPdOp4w3HsJfU0bD5(object P_0, object P_1)
	{
		((IWorkflowInstance)P_0).Process = (IWorkflowProcess)P_1;
	}

	internal static object kdvjeHOpzUhnWuRWH7Nu(object P_0)
	{
		return ((IWorkflowInstance)P_0).State;
	}

	internal static void sX6HXsOCK1dhca6vpsqx(object P_0, object P_1)
	{
		((IWorkflowInstanceState)P_0).State = (byte[])P_1;
	}
}
