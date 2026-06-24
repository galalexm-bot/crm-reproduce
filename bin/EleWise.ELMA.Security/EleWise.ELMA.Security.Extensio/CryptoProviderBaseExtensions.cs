using System.Linq;
using EleWise.ELMA.Files;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Extensions;

public static class CryptoProviderBaseExtensions
{
	internal static CryptoProviderBaseExtensions HhakmY8cnWiSGbmAu1y;

	public static string GetFileHash(this ICryptoProviderBase provider, BinaryFile file, string algorithm)
	{
		int num = 2;
		int num2 = num;
		ICryptoProviderBase2 cryptoProviderBase = default(ICryptoProviderBase2);
		while (true)
		{
			switch (num2)
			{
			default:
				if (cryptoProviderBase == null)
				{
					num2 = 3;
					break;
				}
				return (string)NP9xA58Em43O5Q0GUJ2(cryptoProviderBase, file, algorithm);
			case 1:
				cryptoProviderBase = provider as ICryptoProviderBase2;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return provider.GetFileHash(file);
			case 2:
				Contract.ArgumentNotNull(provider, (string)b7gbGl80KVLEMhDKLYm(-1518425080 ^ -1518451376));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static bool IsSupportedDigitalSignatureType(this ICryptoProviderBase provider, IDigitalSignatureType digitalSignatureType)
	{
		return digitalSignatureType.Providers.Contains(provider.ProviderUid);
	}

	internal static object b7gbGl80KVLEMhDKLYm(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object NP9xA58Em43O5Q0GUJ2(object P_0, object P_1, object P_2)
	{
		return ((ICryptoProviderBase2)P_0).GetFileHash((BinaryFile)P_1, (string)P_2);
	}

	internal static bool vyhVI48Gx4JgjsQm38b()
	{
		return HhakmY8cnWiSGbmAu1y == null;
	}

	internal static CryptoProviderBaseExtensions HW0BPh8F5aVPyF4T4np()
	{
		return HhakmY8cnWiSGbmAu1y;
	}
}
