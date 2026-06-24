using System;
using System.Runtime.CompilerServices;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Services.Public;

[Serializable]
public class AuthorizeUserEventArgs : EventArgs
{
	private static AuthorizeUserEventArgs zvE4UpB00vLYfo0HhLtb;

	public string UserId
	{
		[CompilerGenerated]
		get
		{
			return _003CUserId_003Ek__BackingField;
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
					_003CUserId_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string SessionToken
	{
		[CompilerGenerated]
		get
		{
			return _003CSessionToken_003Ek__BackingField;
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
					_003CSessionToken_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
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

	public AuthorizeUserEventArgs()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wweRDwB0MO8HVCYMs4dm();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool K0ry4eB0mXEcdbvW6Yij()
	{
		return zvE4UpB00vLYfo0HhLtb == null;
	}

	internal static AuthorizeUserEventArgs cgViNEB0y5qWRE0suMhm()
	{
		return zvE4UpB00vLYfo0HhLtb;
	}

	internal static void wweRDwB0MO8HVCYMs4dm()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
