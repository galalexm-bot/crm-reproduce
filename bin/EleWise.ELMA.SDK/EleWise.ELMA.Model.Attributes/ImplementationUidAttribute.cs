using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface)]
public class ImplementationUidAttribute : Attribute
{
	private Guid uid;

	internal static ImplementationUidAttribute dQdNLJo8tWvZUyVj8pWI;

	public Guid Uid => uid;

	public ImplementationUidAttribute(string uid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wxKo6Uo86MnP2Mgex49P();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				this.uid = new Guid(uid);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 1:
				oiO0peo8AC8f0NiWQUFA(uid, clTILfo8HBkJJ4vbu3Ff(0x5DD55050 ^ 0x5DD49386));
				num = 2;
				break;
			}
		}
	}

	public ImplementationUidAttribute(Guid uid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		wxKo6Uo86MnP2Mgex49P();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
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
				this.uid = uid;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void wxKo6Uo86MnP2Mgex49P()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object clTILfo8HBkJJ4vbu3Ff(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void oiO0peo8AC8f0NiWQUFA(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool AfwRhqo8wCCtCieelqCT()
	{
		return dQdNLJo8tWvZUyVj8pWI == null;
	}

	internal static ImplementationUidAttribute ik1Vhbo84FAyqmsDL06s()
	{
		return dQdNLJo8tWvZUyVj8pWI;
	}
}
