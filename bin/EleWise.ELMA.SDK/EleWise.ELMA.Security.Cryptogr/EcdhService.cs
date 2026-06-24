using System;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Cryptography;

[Service]
public class EcdhService : IEcdhService
{
	private static readonly byte[] keyTypePublicP256;

	private static readonly byte[] keyLength256;

	private static readonly byte[] dotNetFormatSignature;

	internal static EcdhService KQVTddBLfA95PgOTBpAP;

	public IEcdhKey DeriveKeyMaterial(byte[] publicKey)
	{
		//Discarded unreachable code: IL_00e5, IL_011d, IL_013c, IL_014b, IL_0178, IL_0187
		int num = 1;
		int num2 = num;
		byte[] normalizedPublicKey = default(byte[]);
		ECDiffieHellmanCng eCDiffieHellmanCng = default(ECDiffieHellmanCng);
		IEcdhKey ecdhKey = default(IEcdhKey);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return ecdhKey;
			default:
				throw new CryptographicException(SR.T((string)RncpBlBLvb3VmSYs94Qp(-542721635 ^ -542653527)));
			case 1:
				if (CheckFixPublicKey(publicKey, out normalizedPublicKey))
				{
					eCDiffieHellmanCng = new ECDiffieHellmanCng(256);
					num2 = 3;
					break;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				try
				{
					object publicKey2 = AAthZJBLZ1S0PfEyaMFp(qdGm4KBL8hPSrLiPB8y7(eCDiffieHellmanCng));
					eCDiffieHellmanCng.KeyDerivationFunction = ECDiffieHellmanKeyDerivationFunction.Hash;
					eCDiffieHellmanCng.HashAlgorithm = (CngAlgorithm)eSPRMHBLuXSbgMNevTBU();
					ECDiffieHellmanPublicKey eCDiffieHellmanPublicKey = (ECDiffieHellmanPublicKey)w059oPBLVfG33aVIoHAx(normalizedPublicKey, BU6L32BLIFSZ28M4dilo());
					byte[] sharedSecret = (byte[])HsD2RDBLSQ7pZSrqaAqS(eCDiffieHellmanCng, eCDiffieHellmanPublicKey);
					ecdhKey = new EcdhKey((byte[])publicKey2, sharedSecret);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => ecdhKey, 
						_ => ecdhKey, 
					};
				}
				finally
				{
					int num4;
					if (eCDiffieHellmanCng == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num4 = 1;
						}
						goto IL_0121;
					}
					goto IL_0156;
					IL_0156:
					seEAKOBLi3e152xWKqwH(eCDiffieHellmanCng);
					num4 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num4 = 0;
					}
					goto IL_0121;
					IL_0121:
					switch (num4)
					{
					case 1:
						goto end_IL_00fc;
					case 2:
						goto end_IL_00fc;
					}
					goto IL_0156;
					end_IL_00fc:;
				}
			}
		}
	}

	public byte[] DotNetToUncompressed(byte[] publicKey)
	{
		return new byte[1] { 4 }.Concat(publicKey.Skip(dotNetFormatSignature.Length)).ToArray();
	}

	public bool CheckFixPublicKey(byte[] publicKey, out byte[] normalizedPublicKey)
	{
		//Discarded unreachable code: IL_0104
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				normalizedPublicKey = dotNetFormatSignature.Concat(publicKey.Skip(1)).ToArray();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				if (publicKey.Length == 65)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto IL_00c4;
			case 7:
				return true;
			case 6:
				normalizedPublicKey = Array.Empty<byte>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				normalizedPublicKey = publicKey;
				num2 = 7;
				break;
			case 4:
				return true;
			case 1:
				if (publicKey[0] == 4)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto IL_00c4;
			default:
				{
					return false;
				}
				IL_00c4:
				if (!CheckDotNetPublicKeyFormat(publicKey))
				{
					num2 = 6;
					break;
				}
				goto case 5;
			}
		}
	}

	private bool CheckDotNetPublicKeyFormat(byte[] publicKey)
	{
		//Discarded unreachable code: IL_0067, IL_00fe
		int num = 3;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 6:
				return true;
			case 3:
				if (publicKey.Length != 72)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 1;
					}
					break;
				}
				num3 = 0;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
			case 4:
				if (num3 < dotNetFormatSignature.Length)
				{
					num2 = 5;
					break;
				}
				goto case 6;
			default:
				return false;
			case 5:
			case 7:
				if (publicKey[num3] == dotNetFormatSignature[num3])
				{
					num3++;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 0;
					}
				}
				break;
			case 2:
				return false;
			}
		}
	}

	public EcdhService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		unCSU6BLRmiopuIRcuA7();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static EcdhService()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				return;
			case 2:
				dotNetFormatSignature = keyTypePublicP256.Concat(keyLength256).ToArray();
				num2 = 4;
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				keyLength256 = new byte[4] { 32, 0, 0, 0 };
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 2;
				}
				break;
			default:
			{
				byte[] array = new byte[4];
				InC968BLqtoPIripWEEy(array, (RuntimeFieldHandle)/*OpCode not supported: LdMemberToken*/);
				keyTypePublicP256 = array;
				num2 = 3;
				break;
			}
			}
		}
	}

	internal static object RncpBlBLvb3VmSYs94Qp(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object qdGm4KBL8hPSrLiPB8y7(object P_0)
	{
		return ((ECDiffieHellman)P_0).PublicKey;
	}

	internal static object AAthZJBLZ1S0PfEyaMFp(object P_0)
	{
		return ((ECDiffieHellmanPublicKey)P_0).ToByteArray();
	}

	internal static object eSPRMHBLuXSbgMNevTBU()
	{
		return CngAlgorithm.Sha256;
	}

	internal static object BU6L32BLIFSZ28M4dilo()
	{
		return CngKeyBlobFormat.EccPublicBlob;
	}

	internal static object w059oPBLVfG33aVIoHAx(object P_0, object P_1)
	{
		return ECDiffieHellmanCngPublicKey.FromByteArray((byte[])P_0, (CngKeyBlobFormat)P_1);
	}

	internal static object HsD2RDBLSQ7pZSrqaAqS(object P_0, object P_1)
	{
		return ((ECDiffieHellman)P_0).DeriveKeyMaterial((ECDiffieHellmanPublicKey)P_1);
	}

	internal static void seEAKOBLi3e152xWKqwH(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool C64tt7BLQtaxXvHWjhkv()
	{
		return KQVTddBLfA95PgOTBpAP == null;
	}

	internal static EcdhService U7CM1nBLCjDhk1WJ3Nx6()
	{
		return KQVTddBLfA95PgOTBpAP;
	}

	internal static void unCSU6BLRmiopuIRcuA7()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void InC968BLqtoPIripWEEy(object P_0, RuntimeFieldHandle P_1)
	{
		RuntimeHelpers.InitializeArray((Array)P_0, P_1);
	}
}
