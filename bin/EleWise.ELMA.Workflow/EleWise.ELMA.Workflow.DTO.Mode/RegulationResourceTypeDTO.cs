using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.DTO;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Workflow.DTO.Models;

[Serializable]
public class RegulationResourceTypeDTO : EntityDTO<long>
{
	internal static RegulationResourceTypeDTO Atnk60rDZhPxMEhdMlG;

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
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_bd84f42638494cb6b4427f8e13ec59af == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Guid Uid
	{
		[CompilerGenerated]
		get
		{
			return _003CUid_003Ek__BackingField;
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
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6e8c2dcf6eb644089ebbe42243c60e95 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsDeleted
	{
		[CompilerGenerated]
		get
		{
			return _003CIsDeleted_003Ek__BackingField;
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
					_003CIsDeleted_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f19dffab164a41148300de28b2deec39 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool HardDelete
	{
		[CompilerGenerated]
		get
		{
			return _003CHardDelete_003Ek__BackingField;
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
					_003CHardDelete_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1b8b735647da470aa2d45d64d6f538d1 == 0)
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

	public RegulationResourceTypeDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Movfm3rL0PjOmm0RrQY();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_1c37d4e24e094858975336738e156495 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Uid = fgkPNvrfiTr49h739eU();
			num = 1;
			if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_545887e65739480a965b7ddfab7d0632 == 0)
			{
				num = 1;
			}
		}
	}

	public override void CopyChanges(EntityDTO<long> saved)
	{
		base.CopyChanges(saved);
		RegulationResourceTypeDTO regulationResourceTypeDTO = (RegulationResourceTypeDTO)saved;
		Uid = regulationResourceTypeDTO.Uid;
		Name = regulationResourceTypeDTO.Name;
		IsDeleted = regulationResourceTypeDTO.IsDeleted;
		HardDelete = regulationResourceTypeDTO.HardDelete;
	}

	public override string ToString()
	{
		return Name;
	}

	internal static void Movfm3rL0PjOmm0RrQY()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.zI1vAwLNFSM();
	}

	internal static Guid fgkPNvrfiTr49h739eU()
	{
		return Guid.NewGuid();
	}

	internal static bool phrUdLrnMoy3GdyrNg3()
	{
		return Atnk60rDZhPxMEhdMlG == null;
	}

	internal static RegulationResourceTypeDTO k2yAcDrHoDvvThBC3VE()
	{
		return Atnk60rDZhPxMEhdMlG;
	}
}
