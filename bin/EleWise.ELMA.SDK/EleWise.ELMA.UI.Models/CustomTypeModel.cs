using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.UI.Models;

[DataContract]
public sealed class CustomTypeModel : ICloneable
{
	internal static CustomTypeModel yZ8uVJBBruAil7IJqgiG;

	[DataMember]
	public Guid TypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CTypeUid_003Ek__BackingField;
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
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public Guid SubTypeUid
	{
		[CompilerGenerated]
		get
		{
			return _003CSubTypeUid_003Ek__BackingField;
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
					_003CSubTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public bool IsCollection
	{
		[CompilerGenerated]
		get
		{
			return _003CIsCollection_003Ek__BackingField;
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
					_003CIsCollection_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public Guid HeaderUid
	{
		[CompilerGenerated]
		get
		{
			return _003CHeaderUid_003Ek__BackingField;
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
					_003CHeaderUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public Guid ModuleUid
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
				case 0:
					return;
				case 1:
					_003CModuleUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[DataMember]
	public Guid ItemUid
	{
		[CompilerGenerated]
		get
		{
			return _003CItemUid_003Ek__BackingField;
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
					_003CItemUid_003Ek__BackingField = value;
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

	[DataMember]
	public Guid ModuleItemUid
	{
		[CompilerGenerated]
		get
		{
			return _003CModuleItemUid_003Ek__BackingField;
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
					_003CModuleItemUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public object Clone()
	{
		CustomTypeModel customTypeModel = new CustomTypeModel();
		KWa7iLBBjS5V9lDknPND(customTypeModel, HeaderUid);
		zQsh6EBBY5CrtjOjU6xB(customTypeModel, IsCollection);
		mDnTTgBBLeHt2qeFofsZ(customTypeModel, ItemUid);
		Tg9OLLBBUnVpmihVToGD(customTypeModel, ItemUid);
		BuJHCnBBsFZtgeDIyCcB(customTypeModel, TypeUid);
		SHRFf0BBcnKBm7siqWLF(customTypeModel, ModuleItemUid);
		ilMr9oBBz4yQCFfigYEx(customTypeModel, SubTypeUid);
		return customTypeModel;
	}

	public CustomTypeModel()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool cX4ZBcBBgJIAWXGrIaJL()
	{
		return yZ8uVJBBruAil7IJqgiG == null;
	}

	internal static CustomTypeModel qRaol0BB5HBjA2imAsfI()
	{
		return yZ8uVJBBruAil7IJqgiG;
	}

	internal static void KWa7iLBBjS5V9lDknPND(object P_0, Guid value)
	{
		((CustomTypeModel)P_0).HeaderUid = value;
	}

	internal static void zQsh6EBBY5CrtjOjU6xB(object P_0, bool value)
	{
		((CustomTypeModel)P_0).IsCollection = value;
	}

	internal static void mDnTTgBBLeHt2qeFofsZ(object P_0, Guid value)
	{
		((CustomTypeModel)P_0).ItemUid = value;
	}

	internal static void Tg9OLLBBUnVpmihVToGD(object P_0, Guid value)
	{
		((CustomTypeModel)P_0).ModuleUid = value;
	}

	internal static void BuJHCnBBsFZtgeDIyCcB(object P_0, Guid value)
	{
		((CustomTypeModel)P_0).TypeUid = value;
	}

	internal static void SHRFf0BBcnKBm7siqWLF(object P_0, Guid value)
	{
		((CustomTypeModel)P_0).ModuleItemUid = value;
	}

	internal static void ilMr9oBBz4yQCFfigYEx(object P_0, Guid value)
	{
		((CustomTypeModel)P_0).SubTypeUid = value;
	}
}
