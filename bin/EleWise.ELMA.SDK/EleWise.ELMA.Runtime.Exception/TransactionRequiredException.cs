using System;
using System.Runtime.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Exceptions;

[Serializable]
public class TransactionRequiredException : Exception
{
	internal static TransactionRequiredException x6EE0nWhBP6P1ofmnaNc;

	public TransactionRequiredException()
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public TransactionRequiredException(string operationDescription)
	{
		//Discarded unreachable code: IL_0073, IL_0078
		B85ZwyWhbRqKyZsDN7cq();
		base._002Ector((string)((!W19BgEWhhNCkZlg68C3n(operationDescription)) ? SR.T((string)pWNjx7WhGbR1mUKRdqSQ(-477139494 ^ -477170170), operationDescription) : Vx94RfWhEqYWGQLpLYlG(pWNjx7WhGbR1mUKRdqSQ(0x5F3078B6 ^ 0x5F31E398))));
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	protected TransactionRequiredException(SerializationInfo info, StreamingContext context)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		B85ZwyWhbRqKyZsDN7cq();
		base._002Ector(info, context);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool zwVUCSWhWbXrK9IWA8Y0()
	{
		return x6EE0nWhBP6P1ofmnaNc == null;
	}

	internal static TransactionRequiredException OLP05gWhoaFgu9PgHPiZ()
	{
		return x6EE0nWhBP6P1ofmnaNc;
	}

	internal static void B85ZwyWhbRqKyZsDN7cq()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool W19BgEWhhNCkZlg68C3n(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object pWNjx7WhGbR1mUKRdqSQ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Vx94RfWhEqYWGQLpLYlG(object P_0)
	{
		return SR.T((string)P_0);
	}
}
