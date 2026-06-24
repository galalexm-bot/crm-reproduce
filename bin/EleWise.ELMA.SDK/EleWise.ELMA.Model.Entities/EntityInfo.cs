using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Entities;

[Serializable]
public class EntityInfo : EntityInfoBase, ICloneable
{
	internal static EntityInfo OyXTCthZTf6HEnAjeF7R;

	public string Id
	{
		[CompilerGenerated]
		get
		{
			return _003CId_003Ek__BackingField;
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
					_003CId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

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
				case 1:
					_003CTypeUid_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
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

	public string Title
	{
		[CompilerGenerated]
		get
		{
			return _003CTitle_003Ek__BackingField;
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
					_003CTitle_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
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

	public override string ToString()
	{
		return (string)qHdMuThZel0btuuAIJ5A(Id, eqBJW4hZOZQx2d7WYRwu(0x7EC153F ^ 0x7EC7D6B), (!g42n80hZ2IeiB3MZwyVH(Title)) ? Title : SR.Untitled);
	}

	public virtual EntityInfo Clone()
	{
		EntityInfo entityInfo = new EntityInfo();
		pINJrthZPhXg15ilP8ve(entityInfo, Id);
		entityInfo.Uid = Uid;
		YA9TRThZ1I45B1PNPQVl(entityInfo, TypeUid);
		entityInfo.Title = Title;
		return entityInfo;
	}

	object ICloneable.Clone()
	{
		return c4sx84hZNKCXoCD20T6q(this);
	}

	public EntityInfo()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		iHxa0lhZ3vIQ98kb2Goy();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool SDyMJnhZkmsZlGHYPHAV()
	{
		return OyXTCthZTf6HEnAjeF7R == null;
	}

	internal static EntityInfo kaHbV3hZnsKRoIaLXBGb()
	{
		return OyXTCthZTf6HEnAjeF7R;
	}

	internal static object eqBJW4hZOZQx2d7WYRwu(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool g42n80hZ2IeiB3MZwyVH(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object qHdMuThZel0btuuAIJ5A(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void pINJrthZPhXg15ilP8ve(object P_0, object P_1)
	{
		((EntityInfo)P_0).Id = (string)P_1;
	}

	internal static void YA9TRThZ1I45B1PNPQVl(object P_0, Guid value)
	{
		((EntityInfo)P_0).TypeUid = value;
	}

	internal static object c4sx84hZNKCXoCD20T6q(object P_0)
	{
		return ((EntityInfo)P_0).Clone();
	}

	internal static void iHxa0lhZ3vIQ98kb2Goy()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
