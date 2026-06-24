using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace System.Linq.Dynamic;

[Serializable]
public sealed class ParseException : Exception
{
	private int position;

	private static ParseException pZdxaOhPiyYR2ZcdyVF;

	public int Position => position;

	public ParseException()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ParseException(string message, int position)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		xoISUah3Nq77wpBEaqe();
		base._002Ector(message);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 1:
				this.position = position;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override string ToString()
	{
		return string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FA0C12), Message, position);
	}

	internal static bool TrWCf7h1OyMxds2eWEq()
	{
		return pZdxaOhPiyYR2ZcdyVF == null;
	}

	internal static ParseException A0475ghNuhCDAJkyG3t()
	{
		return pZdxaOhPiyYR2ZcdyVF;
	}

	internal static void xoISUah3Nq77wpBEaqe()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
