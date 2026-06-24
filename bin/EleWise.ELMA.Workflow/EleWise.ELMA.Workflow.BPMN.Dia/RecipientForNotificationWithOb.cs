using System;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;

public abstract class RecipientForNotificationWithObjectGuid : RecipientInfoForNotification
{
	internal static RecipientForNotificationWithObjectGuid NvWh1ZZt0CUwSYFNc2tb;

	public Guid ObjectGuid
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (base.RecipientValue == null)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return (Guid)base.RecipientValue;
				case 1:
					return Guid.Empty;
				}
			}
		}
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					base.RecipientValue = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bb19f93c0a774f6cbdada859bba83212 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	protected RecipientForNotificationWithObjectGuid()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		gEPt18ZttasY90u8XO8B();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_7ed81ca3cf804abbade4684f28f485d1 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool iJXRxNZtyjFJYj0cbsUo()
	{
		return NvWh1ZZt0CUwSYFNc2tb == null;
	}

	internal static RecipientForNotificationWithObjectGuid xIlOAoZtm1AxTVASyO3B()
	{
		return NvWh1ZZt0CUwSYFNc2tb;
	}

	internal static void gEPt18ZttasY90u8XO8B()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
