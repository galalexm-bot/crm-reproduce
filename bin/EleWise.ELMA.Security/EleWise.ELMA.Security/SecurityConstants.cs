using System;
using EleWise.ELMA.Security.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

public static class SecurityConstants
{
	public static readonly Guid AdminUserUid;

	public static readonly Guid SystemUserUid;

	public static readonly Guid AdminGroupUid;

	public static readonly Guid AllUsersGroupUid;

	public static readonly Guid ConfiguringGroupUid;

	public static readonly Guid UsersManagementGroupUid;

	public static readonly Guid PrivilegeUsersGroupUid;

	public static readonly GroupDescriptor AdminGroupDescriptor;

	public static readonly GroupDescriptor AllUsersGroupDescriptor;

	public static readonly GroupDescriptor ConfiguringGroupDescriptor;

	public static readonly GroupDescriptor UsersManagementGroupDescriptor;

	private static SecurityConstants KjdfWIlVlOVsdLhYLM6;

	static SecurityConstants()
	{
		int num = 3;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					AllUsersGroupDescriptor = new GroupDescriptor(AllUsersGroupUid, (string)RbQOYkl8JKpyc0c9BVo(Ujp3A4lgnEehbXv9col(-426925384 ^ -426933620)), SR.T((string)Ujp3A4lgnEehbXv9col(-698589567 ^ -698587953)));
					num2 = 9;
					continue;
				case 8:
					AdminGroupDescriptor = new GroupDescriptor(AdminGroupUid, (string)RbQOYkl8JKpyc0c9BVo(Ujp3A4lgnEehbXv9col(0x2CFDCC80 ^ 0x2CFDF53E)), (string)RbQOYkl8JKpyc0c9BVo(Ujp3A4lgnEehbXv9col(0x271B34E4 ^ 0x271B0D3A)));
					num2 = 7;
					continue;
				case 11:
					ConfiguringGroupUid = new Guid((string)Ujp3A4lgnEehbXv9col(-434542700 ^ -434544818));
					num2 = 12;
					continue;
				case 4:
					AdminGroupUid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7A093321 ^ 0x7A090B63));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					AdminUserUid = new Guid((string)Ujp3A4lgnEehbXv9col(-230994601 ^ -230982927));
					num2 = 10;
					continue;
				case 1:
					UsersManagementGroupDescriptor = new GroupDescriptor(UsersManagementGroupUid, SR.T((string)Ujp3A4lgnEehbXv9col(0x116C2699 ^ 0x116C1DEF)), (string)RbQOYkl8JKpyc0c9BVo(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5FD42272 ^ 0x5FD419C4)));
					num2 = 5;
					continue;
				case 5:
					return;
				case 10:
					SystemUserUid = new Guid((string)Ujp3A4lgnEehbXv9col(-764392425 ^ -764380187));
					num2 = 4;
					continue;
				default:
					AllUsersGroupUid = new Guid((string)Ujp3A4lgnEehbXv9col(-1858473711 ^ -1858483809));
					num2 = 6;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 == 0)
					{
						num2 = 11;
					}
					continue;
				case 6:
					PrivilegeUsersGroupUid = new Guid((string)Ujp3A4lgnEehbXv9col(0x8875F5C ^ 0x887662E));
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 != 0)
					{
						num2 = 8;
					}
					continue;
				case 9:
					ConfiguringGroupDescriptor = new GroupDescriptor(ConfiguringGroupUid, (string)RbQOYkl8JKpyc0c9BVo(Ujp3A4lgnEehbXv9col(0x23D92C6F ^ 0x23D916AB)), (string)RbQOYkl8JKpyc0c9BVo(Ujp3A4lgnEehbXv9col(-726732645 ^ -726742423)));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
					{
						num2 = 1;
					}
					continue;
				case 3:
					y4BDnUlTaOVB29lrrVt();
					num2 = 2;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6f96338790994363b52cd5c55eb1342f == 0)
					{
						num2 = 2;
					}
					continue;
				case 12:
					break;
				}
				break;
			}
			UsersManagementGroupUid = new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-731479136 ^ -731465082));
			num = 6;
		}
	}

	internal static void y4BDnUlTaOVB29lrrVt()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object Ujp3A4lgnEehbXv9col(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object RbQOYkl8JKpyc0c9BVo(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool u4SOnrlQn0gGleLSjhh()
	{
		return KjdfWIlVlOVsdLhYLM6 == null;
	}

	internal static SecurityConstants NKVvLRldtPKSwgUxWCT()
	{
		return KjdfWIlVlOVsdLhYLM6;
	}
}
