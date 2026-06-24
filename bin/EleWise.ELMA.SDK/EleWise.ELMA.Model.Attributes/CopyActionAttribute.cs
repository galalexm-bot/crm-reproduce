using System;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Interface)]
public class CopyActionAttribute : Attribute
{
	private readonly CopyAction copyAction;

	internal static CopyActionAttribute r2sys4oCqwarR4T0wm5n;

	public CopyAction CopyAction => copyAction;

	public CopyActionAttribute()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JNPA8ZoCTEbEDUnvM6ed();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public CopyActionAttribute(CopyAction copyAction)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		JNPA8ZoCTEbEDUnvM6ed();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.copyAction = copyAction;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void JNPA8ZoCTEbEDUnvM6ed()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool EXy9KxoCKIP4Y0TLm66p()
	{
		return r2sys4oCqwarR4T0wm5n == null;
	}

	internal static CopyActionAttribute Ik21NOoCXFXtpv4ZUHbX()
	{
		return r2sys4oCqwarR4T0wm5n;
	}
}
