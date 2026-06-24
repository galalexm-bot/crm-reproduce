using System;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Types.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.ChangeProcessVersion;

public class ChangeTypeSettingsInstanceStore : IChangeProcessVersionAction
{
	private IWorkflowInstance instance;

	private IWorkflowProcess newProcess;

	internal static ChangeTypeSettingsInstanceStore L242fvOCPufBbbUfNGDx;

	public ChangeTypeSettingsInstanceStore(IWorkflowInstance instance, IWorkflowProcess newProcess)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		HLAb08OCuNN17nvPTc1e();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				this.newProcess = newProcess;
				num = 2;
				break;
			case 1:
				this.instance = instance;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9269d021c6f148b6a1c4afb8cee03b6c == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public void Execute()
	{
		int num = 4;
		int num2 = num;
		ITypeSettingsInstanceStore typeSettingsInstanceStore = default(ITypeSettingsInstanceStore);
		while (true)
		{
			switch (num2)
			{
			case 4:
				typeSettingsInstanceStore = (ITypeSettingsInstanceStore)PqnIwMOCnlQRldW2vrFd(fVQtjXOCDXMNyxu8GbSD(instance), false, true);
				num2 = 3;
				break;
			case 2:
				return;
			default:
				qq9ohUOC9AvX8CXZuOuD(typeSettingsInstanceStore);
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return;
			case 3:
				if (typeSettingsInstanceStore != null)
				{
					dYevgeOCf9LZQnc8tITj(typeSettingsInstanceStore, YSJUZdOCLfk4CVPjvpBB(OVRrpkOCHHEwhjSDKlI7(newProcess)));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c559093b7320494babd70d164a6df42d == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
					{
						num2 = 2;
					}
				}
				break;
			}
		}
	}

	internal static void HLAb08OCuNN17nvPTc1e()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool cH0gxDOCXdXBAmsTj2wc()
	{
		return L242fvOCPufBbbUfNGDx == null;
	}

	internal static ChangeTypeSettingsInstanceStore JMOLYYOCdxCjxUlIZ32b()
	{
		return L242fvOCPufBbbUfNGDx;
	}

	internal static object fVQtjXOCDXMNyxu8GbSD(object P_0)
	{
		return ((IWorkflowInstance)P_0).Context;
	}

	internal static object PqnIwMOCnlQRldW2vrFd(object P_0, bool P_1, bool P_2)
	{
		return ((Entity<long>)P_0).LoadSettingsInstanceStore(P_1, P_2);
	}

	internal static object OVRrpkOCHHEwhjSDKlI7(object P_0)
	{
		return ((IWorkflowProcess)P_0).Context;
	}

	internal static Guid YSJUZdOCLfk4CVPjvpBB(object P_0)
	{
		return ((AbstractMetadata)P_0).Uid;
	}

	internal static void dYevgeOCf9LZQnc8tITj(object P_0, Guid P_1)
	{
		((ITypeSettingsInstanceStore)P_0).ObjectTypeUid = P_1;
	}

	internal static void qq9ohUOC9AvX8CXZuOuD(object P_0)
	{
		((IEntity)P_0).Save();
	}
}
