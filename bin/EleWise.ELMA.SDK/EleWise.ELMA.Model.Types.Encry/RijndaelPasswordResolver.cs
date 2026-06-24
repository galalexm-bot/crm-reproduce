using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component(Order = 10)]
internal class RijndaelPasswordResolver : IPasswordResolver
{
	internal static Guid UID;

	internal static RijndaelPasswordResolver MPpssRojwEsV2PNFOLjk;

	public Guid Uid => UID;

	public string DisplayName => (string)timrmaojAfglWwnKwwFb(u5fGWkojH9YRgPcp1VZ3(-542721635 ^ -542892753));

	public bool Check(string encryptedPassword, string salt, string password)
	{
		int num = 1;
		int num2 = num;
		string value = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return password.Equals(value, StringComparison.Ordinal);
			case 1:
				value = EncryptionHelper.DecryptPwd(encryptedPassword, (byte[])mMo2y8oj7bO6V874BBSE(salt));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public string Decrypt(string password, string salt)
	{
		return (string)NDEvMiojx5IV804O6m5Y(password, mMo2y8oj7bO6V874BBSE(salt));
	}

	public string Encrypt(string password, string salt)
	{
		return (string)AEsHCeoj0ULclSx1fBU6(password, mMo2y8oj7bO6V874BBSE(salt));
	}

	public string GenerateSalt()
	{
		return EncryptionHelper.GenerateSalt();
	}

	public RijndaelPasswordResolver()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		kMCS3TojmqF6di18I9ye();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static RijndaelPasswordResolver()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				UID = new Guid((string)u5fGWkojH9YRgPcp1VZ3(0x1FFEF86A ^ 0x1FFC5CBA));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object u5fGWkojH9YRgPcp1VZ3(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object timrmaojAfglWwnKwwFb(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool FE8Ht9oj4FA6iRAM6b4E()
	{
		return MPpssRojwEsV2PNFOLjk == null;
	}

	internal static RijndaelPasswordResolver bGwrjRoj6Mx7PDEHgxdV()
	{
		return MPpssRojwEsV2PNFOLjk;
	}

	internal static object mMo2y8oj7bO6V874BBSE(object P_0)
	{
		return Convert.FromBase64String((string)P_0);
	}

	internal static object NDEvMiojx5IV804O6m5Y(object P_0, object P_1)
	{
		return EncryptionHelper.DecryptPwd((string)P_0, (byte[])P_1);
	}

	internal static object AEsHCeoj0ULclSx1fBU6(object P_0, object P_1)
	{
		return EncryptionHelper.EncryptPwd((string)P_0, (byte[])P_1);
	}

	internal static void kMCS3TojmqF6di18I9ye()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
