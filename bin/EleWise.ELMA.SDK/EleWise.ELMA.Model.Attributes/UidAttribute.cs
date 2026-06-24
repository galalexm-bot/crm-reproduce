using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Attributes;

[AttributeUsage(AttributeTargets.All, Inherited = false, AllowMultiple = false)]
public class UidAttribute : Attribute
{
	private readonly Guid uid;

	private static UidAttribute Gil68JoVVd2h8qyTLkwU;

	public Guid Uid => uid;

	public UidAttribute(string uid)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		TIquBjoVRDpFHsro1Sxx();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.uid = new Guid(uid);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num = 0;
				}
				break;
			case 2:
				AgNXdnoVKEt2Hyl7OxHe(uid, PaffiHoVqHk6pqKAxCiS(-281842504 ^ -281890962));
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public UidAttribute(Guid uid)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		TIquBjoVRDpFHsro1Sxx();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
		{
			num = 0;
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void TIquBjoVRDpFHsro1Sxx()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object PaffiHoVqHk6pqKAxCiS(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void AgNXdnoVKEt2Hyl7OxHe(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool JWu5TEoVSD0rrYNUnk7a()
	{
		return Gil68JoVVd2h8qyTLkwU == null;
	}

	internal static UidAttribute gtti37oViIWn6CnYHdTR()
	{
		return Gil68JoVVd2h8qyTLkwU;
	}
}
