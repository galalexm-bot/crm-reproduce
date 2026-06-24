using System.Collections.Generic;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security;

public sealed class AuthInfoContainer
{
	private static readonly IDictionary<string, string> EmptyAdditionalClaims;

	internal static AuthInfoContainer qfLKrdB5RJwvWwpksWKZ;

	public long UserId { get; }

	public string ApplicationToken { get; }

	public IDictionary<string, string> AdditionalClaims { get; private set; }

	public AuthInfoContainer(long userId, string applicationToken)
	{
		//Discarded unreachable code: IL_0031, IL_0036
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(userId, applicationToken, EmptyAdditionalClaims);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public AuthInfoContainer(long userId, string applicationToken, IDictionary<string, string> additionalClaims)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		Contract.ArgumentNotNullOrEmpty(applicationToken, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812122042));
		Contract.ArgumentNotNull(additionalClaims, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87413669));
		UserId = userId;
		ApplicationToken = applicationToken;
		AdditionalClaims = additionalClaims;
	}

	static AuthInfoContainer()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				EmptyAdditionalClaims = new Dictionary<string, string>(0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				FEHAtZB5XJHVO0t08G3e();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool RNGv0bB5qR5SwFvsSlgL()
	{
		return qfLKrdB5RJwvWwpksWKZ == null;
	}

	internal static AuthInfoContainer cVR45GB5Ktv2Qolg6Px5()
	{
		return qfLKrdB5RJwvWwpksWKZ;
	}

	internal static void FEHAtZB5XJHVO0t08G3e()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
