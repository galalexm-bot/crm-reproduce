using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Diagrams;
using EleWise.ELMA.Scheduling;
using EleWise.ELMA.Scheduling.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models;

public class WorkflowInstanceTimerInfo
{
	private static WorkflowInstanceTimerInfo jC2WgXOjBPLOkdAu8AFe;

	public long SchedulerJobId
	{
		[CompilerGenerated]
		get
		{
			return _003CSchedulerJobId_003Ek__BackingField;
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
					_003CSchedulerJobId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IWorkflowInstance Instance
	{
		[CompilerGenerated]
		get
		{
			return _003CInstance_003Ek__BackingField;
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
				case 1:
					_003CInstance_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a2041b18ca1f4a5cb8e5060163bfdb57 != 0)
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

	public Guid ElementUid
	{
		[CompilerGenerated]
		get
		{
			return _003CElementUid_003Ek__BackingField;
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
				case 1:
					_003CElementUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_ac5d16a577a84bb0b8ee3654769d2d33 != 0)
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

	public DateTime? CreationDate { get; set; }

	public DateTime? ExecuteTime { get; set; }

	public JobStatus? OnceExecuteStatus { get; set; }

	public SchedulerTaskStatus? TaskStatus { get; set; }

	public string ElementName
	{
		get
		{
			//Discarded unreachable code: IL_0036
			int num = 1;
			int num2 = num;
			Element element = default(Element);
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 2:
					obj = null;
					break;
				default:
					if (!rpwvXhOjXKa5mRxQ5YMY(ElementUid, Guid.Empty))
					{
						num2 = 2;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f8ecc99a1f4a4b6abc73e9b50261ea83 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = ((Diagram)aMTneEOjumEfY3TjoEQk(ilu0tdOjd3cpvHtCGNAu(Instance))).Elements.FirstOrDefault((Element e) => L7L5EvOjHhYkxODrl3mV(e.Uid, ElementUid));
					break;
				case 3:
					if (element == null)
					{
						num2 = 4;
						continue;
					}
					return (string)YqcvaJOjDcT7qpbt7bgp(element);
				case 4:
					return string.Empty;
				case 1:
					if (Instance != null)
					{
						num2 = 0;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3f8a84e2cb374827a50ba2cbcf11cf48 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				}
				element = (Element)obj;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_e4c570270f54493d8f3f4763a72f63f7 != 0)
				{
					num2 = 3;
				}
			}
		}
	}

	[DefaultValue(false)]
	public bool IsAjaxRequest
	{
		[CompilerGenerated]
		get
		{
			return _003CIsAjaxRequest_003Ek__BackingField;
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
				case 1:
					_003CIsAjaxRequest_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
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

	public string GridId
	{
		[CompilerGenerated]
		get
		{
			return _003CGridId_003Ek__BackingField;
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
				case 1:
					_003CGridId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_de3723e1fdff427496b973d91a934ee2 != 0)
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

	public WorkflowInstanceTimerInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		N7vJSwOjnVkSHFoygJvI();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool zIobtbOjcoNAZnxHy7Yt()
	{
		return jC2WgXOjBPLOkdAu8AFe == null;
	}

	internal static WorkflowInstanceTimerInfo sJYWbYOjPwaa3PAWSk8k()
	{
		return jC2WgXOjBPLOkdAu8AFe;
	}

	internal static bool rpwvXhOjXKa5mRxQ5YMY(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object ilu0tdOjd3cpvHtCGNAu(object P_0)
	{
		return ((IWorkflowInstance)P_0).Process;
	}

	internal static object aMTneEOjumEfY3TjoEQk(object P_0)
	{
		return ((IWorkflowProcess)P_0).Diagram;
	}

	internal static object YqcvaJOjDcT7qpbt7bgp(object P_0)
	{
		return ((Element)P_0).Name;
	}

	internal static void N7vJSwOjnVkSHFoygJvI()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool L7L5EvOjHhYkxODrl3mV(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}
}
