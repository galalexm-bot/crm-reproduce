using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security;

public class CreateUserParams
{
	internal static CreateUserParams Fc6TCEBjmFYFpZTwqAU3;

	public string Username
	{
		[CompilerGenerated]
		get
		{
			return _003CUsername_003Ek__BackingField;
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
					_003CUsername_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
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

	public string Password
	{
		[CompilerGenerated]
		get
		{
			return _003CPassword_003Ek__BackingField;
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
					_003CPassword_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
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

	public string Email
	{
		[CompilerGenerated]
		get
		{
			return _003CEmail_003Ek__BackingField;
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
					_003CEmail_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public CreateUserParams(string username, string password, string email)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BTTR0hBjJOyxCXUHcEsO();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 1:
				Username = username;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				Email = email;
				num = 3;
				break;
			default:
				Password = password;
				num = 2;
				break;
			}
		}
	}

	internal static void BTTR0hBjJOyxCXUHcEsO()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool WTLxNNBjyoNfwwF4bGm1()
	{
		return Fc6TCEBjmFYFpZTwqAU3 == null;
	}

	internal static CreateUserParams jKpO3DBjMvwtTgPAV8lt()
	{
		return Fc6TCEBjmFYFpZTwqAU3;
	}
}
