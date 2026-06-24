using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.Common;
using EleWise.ELMA.Workflow.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Managers;

public class WorkflowProcessFilter : Filter, IWorkflowProcessFilter, IEntityFilter
{
	private static WorkflowProcessFilter RvJJok9BXeYpHLSQAQs;

	public bool Published
	{
		[CompilerGenerated]
		get
		{
			return _003CPublished_003Ek__BackingField;
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
					_003CPublished_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_639c11c7bb65456db9f29c9c42f28bf7 != 0)
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

	public IProcessHeader Header
	{
		[CompilerGenerated]
		get
		{
			return _003CHeader_003Ek__BackingField;
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
					_003CHeader_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool? NonZeroVersion { get; set; }

	public WorkflowProcessFilter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_5c45a6e5a4614bfba7591d8a1c7ced1d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool RtiI0C9cwMWyjZLyxkE()
	{
		return RvJJok9BXeYpHLSQAQs == null;
	}

	internal static WorkflowProcessFilter f4jUMH9PT7pipoCFtvO()
	{
		return RvJJok9BXeYpHLSQAQs;
	}
}
