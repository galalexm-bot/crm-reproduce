using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Types.Encrypters;

[Component(Order = 10)]
internal class SHA256PasswordResolver : IPasswordResolver
{
	internal static Guid UID;

	private static SHA256PasswordResolver K2c5w0ojynOV1cVRwPPn;

	public Guid Uid => UID;

	public string DisplayName => SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411351411));

	public bool Check(string encryptedPassword, string salt, string password)
	{
		int num = 1;
		int num2 = num;
		string sha256Hash = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				sha256Hash = EncryptionHelper.GetSha256Hash(password, salt);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return OOODnkoj9qS03y3Wsc2p(encryptedPassword, sha256Hash, StringComparison.Ordinal);
			}
		}
	}

	public string Decrypt(string password, string salt)
	{
		return password;
	}

	public string Encrypt(string password, string salt)
	{
		return (string)ibHyVFojdku6oLrKuCuj(password, salt);
	}

	public string GenerateSalt()
	{
		return EncryptionHelper.GenerateSalt();
	}

	public SHA256PasswordResolver()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vpwhYMojlIvkoU2G5HZX();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static SHA256PasswordResolver()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				vpwhYMojlIvkoU2G5HZX();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				UID = new Guid((string)sc6m8kojrJeSkbxwtf0W(0x1ECE530A ^ 0x1ECCF636));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool UtYJY3ojMEgqIObW80xZ()
	{
		return K2c5w0ojynOV1cVRwPPn == null;
	}

	internal static SHA256PasswordResolver G1iJeeojJhxSk0TesqC0()
	{
		return K2c5w0ojynOV1cVRwPPn;
	}

	internal static bool OOODnkoj9qS03y3Wsc2p(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static object ibHyVFojdku6oLrKuCuj(object P_0, object P_1)
	{
		return EncryptionHelper.GetSha256Hash((string)P_0, (string)P_1);
	}

	internal static void vpwhYMojlIvkoU2G5HZX()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object sc6m8kojrJeSkbxwtf0W(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
