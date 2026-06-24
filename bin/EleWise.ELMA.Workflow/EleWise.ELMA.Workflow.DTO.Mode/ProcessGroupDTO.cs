using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.DTO;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.DTO.Models;

[Serializable]
public class ProcessGroupDTO : EntityDTO<long>
{
	private static ProcessGroupDTO ydEMpkrab4XZaJEbEiu;

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
				case 0:
					return;
				case 1:
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_46e05b4e09174e34a9c81741b8b77a2f != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public long ParentId
	{
		[CompilerGenerated]
		get
		{
			return _003CParentId_003Ek__BackingField;
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
					_003CParentId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
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

	public List<ProcessHeaderDTO> Processes { get; set; }

	public List<ProcessGroupDTO> SubGroups { get; set; }

	public ProcessGroupDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_d2d2252621ae43ad8d38af812176c290 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 2:
				SubGroups = new List<ProcessGroupDTO>();
				num = 1;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_4459fbe344a947429d197733d274ef68 == 0)
				{
					num = 1;
				}
				break;
			default:
				Processes = new List<ProcessHeaderDTO>();
				num = 2;
				break;
			}
		}
	}

	internal static bool ObQlyurr18t0xevYoRp()
	{
		return ydEMpkrab4XZaJEbEiu == null;
	}

	internal static ProcessGroupDTO KVeMjtreof38fokfPhf()
	{
		return ydEMpkrab4XZaJEbEiu;
	}
}
