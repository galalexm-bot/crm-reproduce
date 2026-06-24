using System;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Model.DTO;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Metadata.DTO.Models;

[Serializable]
public sealed class FunctionMetadataItemDTO : EntityDTO<long>
{
	private static FunctionMetadataItemDTO YI8hXObr5ekdTuBbiu0e;

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
				case 1:
					_003CUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
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

	public Guid HeaderId
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaderId_003Ek__BackingField;
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
					_003CHeaderId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
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

	public object Metadata
	{
		[CompilerGenerated]
		get
		{
			return _003CMetadata_003Ek__BackingField;
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
					_003CMetadata_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public FunctionMetadataItemDTO()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		y715uIbrLUiyEwWy9Sa8();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool mKpXLabrjYtmp9bjwgew()
	{
		return YI8hXObr5ekdTuBbiu0e == null;
	}

	internal static FunctionMetadataItemDTO HCW155brYEy5mQGtyNel()
	{
		return YI8hXObr5ekdTuBbiu0e;
	}

	internal static void y715uIbrLUiyEwWy9Sa8()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
