using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Tasks.ExtensionPoints;
using EleWise.ELMA.Workflow.BPMN.Diagrams.Elements.Tasks;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Components;

[Component]
public class UserTaskAcrossChecker : IWorkLogChecker
{
	internal static UserTaskAcrossChecker E7dHqGOymeT12CAM9xc4;

	public bool Check(object element)
	{
		int num = 3;
		int num2 = num;
		UserTaskElement userTaskElement = default(UserTaskElement);
		while (true)
		{
			switch (num2)
			{
			case 3:
				userTaskElement = element as UserTaskElement;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (userTaskElement.WorkLogTimeOfExecution != null)
				{
					num2 = 1;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_c7fe5d092d804f7e91041fb2338cec1a != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0081;
			case 1:
				return PHsX5QOyg3E0Bsve4JnS(PIbM5wOy5u0uTWdeYhOy(userTaskElement));
			case 2:
				{
					if (userTaskElement != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto IL_0081;
				}
				IL_0081:
				return false;
			}
		}
	}

	public UserTaskAcrossChecker()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ELcFxOOyB6ldrPi5otFF();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object PIbM5wOy5u0uTWdeYhOy(object P_0)
	{
		return ((UserTaskElement)P_0).WorkLogTimeOfExecution;
	}

	internal static bool PHsX5QOyg3E0Bsve4JnS(object P_0)
	{
		return ((WorkLogTimeOfExecution)P_0).AcrossWorkLog;
	}

	internal static bool WnsxPFOyte9iwiyAhCsn()
	{
		return E7dHqGOymeT12CAM9xc4 == null;
	}

	internal static UserTaskAcrossChecker p9vJgnOybJrBQrnIARfo()
	{
		return E7dHqGOymeT12CAM9xc4;
	}

	internal static void ELcFxOOyB6ldrPi5otFF()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
