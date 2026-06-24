using System;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Nullifier;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Extensions;

[Serializable]
[Component]
public class UnitNullConfigWorkflow : UnitNullConfig
{
	internal static UnitNullConfigWorkflow U5VQUwiwFSNs1kfXvv5;

	public long[] InstanceStatuses
	{
		[CompilerGenerated]
		get
		{
			return _003CInstanceStatuses_003Ek__BackingField;
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
					_003CInstanceStatuses_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f30401a2cff84771be092252e934fede == 0)
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

	[XmlElement("CheckExactDateWorkflowInstance")]
	public bool CheckExactDateWorkflowInstance
	{
		[CompilerGenerated]
		get
		{
			return _003CCheckExactDateWorkflowInstance_003Ek__BackingField;
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
					_003CCheckExactDateWorkflowInstance_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_85ba8d91af394836ac86666c40b1e150 != 0)
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

	[XmlElement("CheckRelativeDateWorkflowInstance")]
	public bool CheckRelativeDateWorkflowInstance
	{
		[CompilerGenerated]
		get
		{
			return _003CCheckRelativeDateWorkflowInstance_003Ek__BackingField;
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
					_003CCheckRelativeDateWorkflowInstance_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_a27e75af798c48d692c4325f43aa9e6b == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement("CheckRelativeDateWorkflowInstanceYear")]
	public long? CheckRelativeDateWorkflowInstanceYear { get; set; }

	[XmlElement("CheckRelativeDateWorkflowInstanceMonth")]
	public long? CheckRelativeDateWorkflowInstanceMonth { get; set; }

	[XmlElement("CheckRelativeDateWorkflowInstanceDay")]
	public long? CheckRelativeDateWorkflowInstanceDay { get; set; }

	public UnitNullConfigWorkflow()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		xk8aqaIKY6SL5pvfngN();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool YKkBrZi4V3JQnxQscYn()
	{
		return U5VQUwiwFSNs1kfXvv5 == null;
	}

	internal static UnitNullConfigWorkflow kfcJWpiz5pgMNGMo0O3()
	{
		return U5VQUwiwFSNs1kfXvv5;
	}

	internal static void xk8aqaIKY6SL5pvfngN()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}
}
