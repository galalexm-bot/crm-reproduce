using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.Deploy;

[Serializable]
public class WorkflowExportSetting
{
	internal static WorkflowExportSetting DNHKrG4B2jUcDyqJUWQ;

	public bool ExportProcesses
	{
		[CompilerGenerated]
		get
		{
			return _003CExportProcesses_003Ek__BackingField;
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
					_003CExportProcesses_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_cfe4a54387d744988feba4889229faf1 != 0)
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

	[Obsolete("Используй ProcessesUids")]
	public List<long> ProcessesIds { get; set; }

	public List<Guid> ProcessesUids { get; set; }

	public WorkflowExportSetting()
	{
		//Discarded unreachable code: IL_001e
		d9Ims64XQdcb3Zn726R();
		base._002Ector();
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				ProcessesUids = new List<Guid>();
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b74fcd91509d46c3a9661cffb0465df0 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				ExportProcesses = true;
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b30151cb26574dfaa8f9d818b0352d3b == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				ProcessesIds = new List<long>();
				num2 = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_764abb15e52f4036a7a81fce6cb70f30 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void d9Ims64XQdcb3Zn726R()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool fFwu2D4cxXR2FlMB44B()
	{
		return DNHKrG4B2jUcDyqJUWQ == null;
	}

	internal static WorkflowExportSetting eE5kiW4PtPhGnKueqW0()
	{
		return DNHKrG4B2jUcDyqJUWQ;
	}
}
