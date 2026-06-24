using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Models.ChangeProcessVersion;

public class ChangeProcessVersionActionData
{
	private static ChangeProcessVersionActionData coNCGuOpi82mSjJqwI8C;

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
				case 0:
					return;
				case 1:
					_003CInstance_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d843b0b7f23e489fb6d586d64b0a634a == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IWorkflowProcess NewProcess
	{
		[CompilerGenerated]
		get
		{
			return _003CNewProcess_003Ek__BackingField;
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
					_003CNewProcess_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4ef74b4b7d13430e9d2f9b78cbdb367b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Reason
	{
		[CompilerGenerated]
		get
		{
			return _003CReason_003Ek__BackingField;
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
					_003CReason_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IUser User
	{
		[CompilerGenerated]
		get
		{
			return _003CUser_003Ek__BackingField;
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
					_003CUser_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_39af03d004af472bb66e60f46e79703a != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public IList<IChangeProcessVersionAction> Actions { get; set; }

	public ChangeProcessVersionActionData()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TSdxKwOprq0XQNXGOLIh();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f236c3d0fade492db73e8204df65377d == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				Actions = new List<IChangeProcessVersionAction>();
				num = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1de08766357542bdb81146373079f817 != 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool HWldWaOpIlOXciqU3GSl()
	{
		return coNCGuOpi82mSjJqwI8C == null;
	}

	internal static ChangeProcessVersionActionData skaOFEOpac9KV4bKLlp2()
	{
		return coNCGuOpi82mSjJqwI8C;
	}

	internal static void TSdxKwOprq0XQNXGOLIh()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
