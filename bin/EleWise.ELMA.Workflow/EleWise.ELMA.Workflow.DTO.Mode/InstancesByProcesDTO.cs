using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.DTO;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.DTO.Models;

[Serializable]
public class InstancesByProcesDTO : EntityDTO<long>
{
	internal static InstancesByProcesDTO MpssHwryn8OfHLnpI9B;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 != 0)
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

	public Guid process
	{
		[CompilerGenerated]
		get
		{
			return _003Cprocess_003Ek__BackingField;
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
					_003Cprocess_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3bb28bf622874b4689f9265e58d14823 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int RunningInstans
	{
		[CompilerGenerated]
		get
		{
			return _003CRunningInstans_003Ek__BackingField;
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
					_003CRunningInstans_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_32f3e755437f4eacb85c8a0d536f83ea == 0)
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

	public int CompletedInstans
	{
		[CompilerGenerated]
		get
		{
			return _003CCompletedInstans_003Ek__BackingField;
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
					_003CCompletedInstans_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_18b351a59a324c25b4f150a9771bcf69 == 0)
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

	public int AbortedInstans
	{
		[CompilerGenerated]
		get
		{
			return _003CAbortedInstans_003Ek__BackingField;
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
					_003CAbortedInstans_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_978f838cc41a4debb9700ede4b63f820 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public InstancesByProcesDTO()
	{
		//Discarded unreachable code: IL_002a
		XWwTs3rbRAP4abpI32o();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bf623f11574746d6bf3837b66460c576 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				CompletedInstans = 0;
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_719514a5a8ae47ed84e5a777ead0dc9f == 0)
				{
					num = 1;
				}
				break;
			default:
			{
				RunningInstans = 0;
				int num2 = 3;
				num = num2;
				break;
			}
			case 1:
				AbortedInstans = 0;
				num = 2;
				break;
			case 2:
				return;
			}
		}
	}

	internal static void XWwTs3rbRAP4abpI32o()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static bool LqUXLgrmgr0vwc1blVH()
	{
		return MpssHwryn8OfHLnpI9B == null;
	}

	internal static InstancesByProcesDTO QSg7UKrtr85PNJytMgw()
	{
		return MpssHwryn8OfHLnpI9B;
	}
}
