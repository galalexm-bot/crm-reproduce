using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Runtime.Settings;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow;

public class WorkflowTaskSettings : GlobalSettingsBase
{
	private static WorkflowTaskSettings t1iNN0OAAdvKoOWP3DQ;

	[DisplayName(typeof(WorkflowTaskSettings_SR), "P_ExecuteByResponsible")]
	public bool ExecuteByResponsible
	{
		[CompilerGenerated]
		get
		{
			return _003CExecuteByResponsible_003Ek__BackingField;
		}
		[CompilerGenerated]
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
				case 0:
					return;
				case 1:
					_003CExecuteByResponsible_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public WorkflowTaskSettings()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		IHedjrO2ncD0OW51NXX();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_75a2d0f780b04098ba855df5729e6c30 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				ExecuteByResponsible = true;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a9be7e056b4e4b6e863b634c418144f1 != 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void IHedjrO2ncD0OW51NXX()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool Q4jy1sOGgBws5oc8dYQ()
	{
		return t1iNN0OAAdvKoOWP3DQ == null;
	}

	internal static WorkflowTaskSettings EOPt7TO79pUfpEZgA1X()
	{
		return t1iNN0OAAdvKoOWP3DQ;
	}
}
