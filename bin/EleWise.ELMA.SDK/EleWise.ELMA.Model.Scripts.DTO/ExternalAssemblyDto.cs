using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Model.DTO;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Scripts.DTO.Models;

[Serializable]
public class ExternalAssemblyDto : EntityDTO<long>, IMetadata, IXsiType
{
	internal static ExternalAssemblyDto MHKo1EbqleIAekQIeXPB;

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual Guid ModuleUid
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleUid_003Ek__BackingField;
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
					_003CModuleUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
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

	[DefaultValue(false)]
	public virtual bool Internal
	{
		[CompilerGenerated]
		get
		{
			return _003CInternal_003Ek__BackingField;
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
					_003CInternal_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
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

	public byte[] Raw
	{
		[CompilerGenerated]
		get
		{
			return _003CRaw_003Ek__BackingField;
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
					_003CRaw_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string HashCode
	{
		[CompilerGenerated]
		get
		{
			return _003CHashCode_003Ek__BackingField;
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
					_003CHashCode_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public void InitNew()
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
				Uid = KPqR8Ubq5XbBhK6mOrTw();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public void AfterLoad()
	{
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public bool ShouldSerializeModuleUid()
	{
		return jyUpNEbqY8Cmtr1iY7KU(nKRCwdbqjLCnNED1s3wb(this), Guid.Empty);
	}

	public static ExternalAssemblyDto New()
	{
		ExternalAssemblyDto externalAssemblyDto = new ExternalAssemblyDto();
		externalAssemblyDto.InitNew();
		return externalAssemblyDto;
	}

	public ExternalAssemblyDto()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool mVBVUFbqr99g94xwGLVI()
	{
		return MHKo1EbqleIAekQIeXPB == null;
	}

	internal static ExternalAssemblyDto sS28tSbqgBj9tXERUhLV()
	{
		return MHKo1EbqleIAekQIeXPB;
	}

	internal static Guid KPqR8Ubq5XbBhK6mOrTw()
	{
		return Guid.NewGuid();
	}

	internal static Guid nKRCwdbqjLCnNED1s3wb(object P_0)
	{
		return ((ExternalAssemblyDto)P_0).ModuleUid;
	}

	internal static bool jyUpNEbqY8Cmtr1iY7KU(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}
}
