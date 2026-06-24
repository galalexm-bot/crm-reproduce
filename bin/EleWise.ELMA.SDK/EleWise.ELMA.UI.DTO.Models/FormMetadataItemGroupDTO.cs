using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.DTO;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.DTO.Models;

[Serializable]
public class FormMetadataItemGroupDTO : EntityDTO<long>
{
	internal static FormMetadataItemGroupDTO kybHnEJTjyTgcx5x6wE;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
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

	public long? ParentId { get; set; }

	public Guid MetadataType
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadataType_003Ek__BackingField;
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
					_003CMetadataType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<FormMetadataItemHeaderDTO> Headers { get; set; }

	public List<FormMetadataItemGroupDTO> Groups { get; set; }

	public FormMetadataItemGroupDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		ILYhRKJOtMgjElIFbN2();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				Groups = new List<FormMetadataItemGroupDTO>();
				num = 2;
				break;
			case 1:
				Headers = new List<FormMetadataItemHeaderDTO>();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void ILYhRKJOtMgjElIFbN2()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool EYIXVUJk9fhystUnEXj()
	{
		return kybHnEJTjyTgcx5x6wE == null;
	}

	internal static FormMetadataItemGroupDTO g4uKwlJnyHRdLcHtEUL()
	{
		return kybHnEJTjyTgcx5x6wE;
	}
}
