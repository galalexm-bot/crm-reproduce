using System;
using System.Collections.Generic;
using System.Linq;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.ChangeProcessVersion;

public class ChangeProcessVersionRemoveSwimlaneBindingAction : IChangeProcessVersionAction
{
	private IWorkflowInstance instance;

	private Guid swimlaneUid;

	internal static ChangeProcessVersionRemoveSwimlaneBindingAction bOHJPhOCO9Wk2fUB1nmD;

	public ChangeProcessVersionRemoveSwimlaneBindingAction(IWorkflowInstance instance, Guid swimlaneUid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				this.instance = instance;
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_69cb4a76addb44f28bb765f059e441c7 == 0)
				{
					num = 0;
				}
				break;
			default:
				this.swimlaneUid = swimlaneUid;
				num = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a == 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public void Execute()
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
				((IEnumerable<IWorkflowSwimlaneExecutor>)instance.SwimlaneExecutors).Where(delegate(IWorkflowSwimlaneExecutor se)
				{
					//Discarded unreachable code: IL_0099
					int num5 = 2;
					int num6 = num5;
					Guid? guid2 = default(Guid?);
					Guid guid = default(Guid);
					while (true)
					{
						switch (num6)
						{
						case 4:
							if (!guid2.HasValue)
							{
								num6 = 5;
								break;
							}
							if (guid2.HasValue)
							{
								num6 = 0;
								if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f == 0)
								{
									num6 = 0;
								}
								break;
							}
							goto case 3;
						case 5:
							return false;
						case 2:
							guid2 = se.SwimlaneUid;
							num6 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f05298ca2a4a4a639a58bc7f7d9ff7b9 == 0)
							{
								num6 = 1;
							}
							break;
						case 3:
							return true;
						default:
							return ncHZ0uOCYYJwJu3g0MZX(guid2.GetValueOrDefault(), guid);
						case 1:
							guid = swimlaneUid;
							num6 = 4;
							break;
						}
					}
				}).ToList().ForEach(delegate(IWorkflowSwimlaneExecutor i)
				{
					int num3 = 1;
					int num4 = num3;
					while (true)
					{
						switch (num4)
						{
						default:
							return;
						case 1:
							((ICollection<IWorkflowSwimlaneExecutor>)instance.SwimlaneExecutors).Remove(i);
							num4 = 0;
							if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
							{
								num4 = 0;
							}
							break;
						case 0:
							return;
						}
					}
				});
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool DnV1rUOCZc2pH6MqvwE5()
	{
		return bOHJPhOCO9Wk2fUB1nmD == null;
	}

	internal static ChangeProcessVersionRemoveSwimlaneBindingAction TOSQqtOCvgMYQ29AZk2e()
	{
		return bOHJPhOCO9Wk2fUB1nmD;
	}

	internal static bool ncHZ0uOCYYJwJu3g0MZX(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
