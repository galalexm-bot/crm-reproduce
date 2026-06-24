using System;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Exceptions;

[Serializable]
public class ElmaInvalidOperationException : Exception
{
	private readonly string actionType;

	private readonly string actionObject;

	private readonly string argsString;

	private static ElmaInvalidOperationException rw94iPG5L6ls5ifAMR6g;

	public string ActionType => actionType;

	public string ActionObject => actionObject;

	public string ArgsString => argsString;

	public ElmaInvalidOperationException()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		Ra9trbG5cWCi0uXI5n1M();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ElmaInvalidOperationException(string message)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		Ra9trbG5cWCi0uXI5n1M();
		base._002Ector(message);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ElmaInvalidOperationException(string message, Exception innerException)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		Ra9trbG5cWCi0uXI5n1M();
		base._002Ector(message, innerException);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ElmaInvalidOperationException(string actionType, string actionObject, string argsString)
	{
		//Discarded unreachable code: IL_002e, IL_0033
		Ra9trbG5cWCi0uXI5n1M();
		this._002Ector(actionType, actionObject, argsString, null);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public ElmaInvalidOperationException(string actionType, string actionObject, string argsString, Exception innerException)
	{
		//Discarded unreachable code: IL_0059, IL_005e
		Ra9trbG5cWCi0uXI5n1M();
		base._002Ector(SR.T((string)tcGv1sG5zIOo0efdnKoR(-3333094 ^ -3588684), actionType, actionObject, argsString), innerException);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this.argsString = argsString;
				num = 3;
				break;
			case 3:
				return;
			case 2:
				this.actionType = actionType;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.actionObject = actionObject;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void Ra9trbG5cWCi0uXI5n1M()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool rnlPHBG5UFUHs8R6k7pk()
	{
		return rw94iPG5L6ls5ifAMR6g == null;
	}

	internal static ElmaInvalidOperationException euZJtIG5sxj56f3jkeQi()
	{
		return rw94iPG5L6ls5ifAMR6g;
	}

	internal static object tcGv1sG5zIOo0efdnKoR(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
