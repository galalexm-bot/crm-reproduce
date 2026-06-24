using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Workflow.Managers;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.Components;

[Component]
internal sealed class ProcessViewModelDescriptorExtension : IViewModelDescriptorExtension
{
	private readonly WorkflowProcessManager workflowProcessManager;

	internal static ProcessViewModelDescriptorExtension LtlfajO0F95Yjwphxgi4;

	public ProcessViewModelDescriptorExtension(WorkflowProcessManager workflowProcessManager)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		QhLETKO0aU3eO0TxFdtb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ecf910d183864897a7c8ec77e01689a4 == 0)
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
			this.workflowProcessManager = workflowProcessManager;
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_be442748c2c44d33a71dd83576ab2ba4 == 0)
			{
				num = 0;
			}
		}
	}

	public bool Check(string typeRef)
	{
		return vU7dJsO0e0Vj5YP0145c(typeRef, l1FPR4O0r4epXwTCVcBP(0x37F755F5 ^ 0x37F7FA2D));
	}

	public IMetadata GetMetadata(string typeRef)
	{
		//Discarded unreachable code: IL_0069, IL_0078
		int num = 8;
		string[] array = default(string[]);
		string arg = default(string);
		string arg2 = default(string);
		string eqlFilter = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					if (array.Length != 3)
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5816b3723c134946ad9294172266312e != 0)
						{
							num2 = 0;
						}
						continue;
					}
					arg = array[1];
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
					{
						num2 = 6;
					}
					continue;
				case 6:
					arg2 = array[2];
					num2 = 5;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 != 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					return null;
				case 8:
					if (Check(typeRef))
					{
						num2 = 7;
						continue;
					}
					goto case 1;
				case 1:
					return null;
				case 7:
					array = (string[])lSWPseO0NNkQxG6lDHVi(typeRef, new char[1] { '_' });
					num2 = 2;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num2 = 4;
					}
					continue;
				case 5:
					eqlFilter = string.Format((string)l1FPR4O0r4epXwTCVcBP(-1574607501 ^ -1574642593), arg, arg2);
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 0;
					}
					continue;
				default:
				{
					IWorkflowProcess workflowProcess = workflowProcessManager.Find(eqlFilter, FetchOptions.First).FirstOrDefault();
					if (workflowProcess != null)
					{
						return workflowProcess.Context;
					}
					break;
				}
				case 3:
					return null;
				}
				break;
			}
			num = 3;
		}
	}

	internal static void QhLETKO0aU3eO0TxFdtb()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool RyYT11O0iMjXwnn1ISch()
	{
		return LtlfajO0F95Yjwphxgi4 == null;
	}

	internal static ProcessViewModelDescriptorExtension EsS9WFO0Ic8h4AeY8EsX()
	{
		return LtlfajO0F95Yjwphxgi4;
	}

	internal static object l1FPR4O0r4epXwTCVcBP(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool vU7dJsO0e0Vj5YP0145c(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object lSWPseO0NNkQxG6lDHVi(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}
}
