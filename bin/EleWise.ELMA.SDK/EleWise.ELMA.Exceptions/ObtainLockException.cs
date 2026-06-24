using System;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class ObtainLockException : Exception
{
	internal static ObtainLockException cMKsALG5ITAsLCivOWnf;

	public ObtainLockException()
	{
		//Discarded unreachable code: IL_0040, IL_0045
		EHVYlCG5i3BtWuA64XGP();
		base._002Ector((string)nJJXbxG5que3VS77kRrC(bdc1JaG5RhgO5XGc7kpC(-1767720453 ^ -1767461285)));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ObtainLockException(string lockName)
	{
		//Discarded unreachable code: IL_0049, IL_004e
		EHVYlCG5i3BtWuA64XGP();
		base._002Ector(SR.T((string)bdc1JaG5RhgO5XGc7kpC(-1939377524 ^ -1939643028), lockName));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ObtainLockException(string lockName, Exception innerException)
	{
		//Discarded unreachable code: IL_004a, IL_004f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(SR.T((string)bdc1JaG5RhgO5XGc7kpC(-1146510045 ^ -1146244413), lockName), innerException);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected ObtainLockException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		EHVYlCG5i3BtWuA64XGP();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void EHVYlCG5i3BtWuA64XGP()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object bdc1JaG5RhgO5XGc7kpC(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object nJJXbxG5que3VS77kRrC(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool JOu0PFG5Vw7KdqEjUhin()
	{
		return cMKsALG5ITAsLCivOWnf == null;
	}

	internal static ObtainLockException qt0ycFG5SaBfVEJZC2h9()
	{
		return cMKsALG5ITAsLCivOWnf;
	}
}
