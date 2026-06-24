using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Services;

public class ProfilePermissionDescriptor
{
	private static ProfilePermissionDescriptor Yvi2BRvDmQG0TJCj5c9;

	public Permission Permission
	{
		[CompilerGenerated]
		get
		{
			return _003CPermission_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CPermission_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d4e4542f38914a2ba9396d8df0939ca9 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Permission ProfilePermission
	{
		[CompilerGenerated]
		get
		{
			return _003CProfilePermission_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CProfilePermission_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Type ProfileType
	{
		[CompilerGenerated]
		get
		{
			return _003CProfileType_003Ek__BackingField;
		}
		[CompilerGenerated]
		private set
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
					_003CProfileType_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public ProfilePermissionDescriptor(Permission permission, Permission profilePermission)
	{
		//Discarded unreachable code: IL_002d, IL_0032
		onsEMmvYfckZIdeUrLk();
		this._002Ector(permission, profilePermission, null);
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ProfilePermissionDescriptor(Permission permission, Permission profilePermission, Type profileType)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		onsEMmvYfckZIdeUrLk();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
		{
			num = 3;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 3:
				Permission = permission;
				num = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_03ad39fc745d49e3be14e8e100fb0203 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				ProfilePermission = profilePermission;
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_77bfde1a0739446782f0bda00c988550 != 0)
				{
					num = 0;
				}
				break;
			default:
				ProfileType = profileType;
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	internal static void onsEMmvYfckZIdeUrLk()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool QOfn6xvMFn6oAVOSfZV()
	{
		return Yvi2BRvDmQG0TJCj5c9 == null;
	}

	internal static ProfilePermissionDescriptor AnbOS9vs13wLcghqxmL()
	{
		return Yvi2BRvDmQG0TJCj5c9;
	}
}
