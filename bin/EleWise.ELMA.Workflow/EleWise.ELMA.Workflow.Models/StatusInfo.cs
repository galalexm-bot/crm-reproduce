using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models;

public class StatusInfo
{
	private static StatusInfo SI1pVQOuITxX51VE4BYC;

	public WorkflowInstanceStatus State
	{
		[CompilerGenerated]
		get
		{
			return _003CState_003Ek__BackingField;
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
					_003CState_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_abfb511163674a3eae959fd60da8f319 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int Count
	{
		[CompilerGenerated]
		get
		{
			return _003CCount_003Ek__BackingField;
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
					_003CCount_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_160bffb148c14c5da92d8d6ddf481bdc != 0)
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

	public WorkflowInstanceGeneralStatus? GeneralStatus
	{
		get
		{
			switch (State)
			{
			case WorkflowInstanceStatus.Running:
				return WorkflowInstanceGeneralStatus.Current;
			case WorkflowInstanceStatus.Completed:
			case WorkflowInstanceStatus.Aborted:
				return WorkflowInstanceGeneralStatus.Completed;
			case WorkflowInstanceStatus.Terminated:
				return WorkflowInstanceGeneralStatus.Terminated;
			default:
				return null;
			}
		}
	}

	public StatusInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		qsw5GUOueoq1r5TGjtch();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool yQfwNkOuaYSo7wQu4vRO()
	{
		return SI1pVQOuITxX51VE4BYC == null;
	}

	internal static StatusInfo Xtnew0OurjCx1L8oBhoA()
	{
		return SI1pVQOuITxX51VE4BYC;
	}

	internal static void qsw5GUOueoq1r5TGjtch()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
