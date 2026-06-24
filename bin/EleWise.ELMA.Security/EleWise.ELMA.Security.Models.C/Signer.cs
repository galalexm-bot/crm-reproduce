using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Security.Models.Crypto;

public class Signer : ISigner
{
	internal static Signer J6UHCgFVdFVb4lHrrqU;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f791092a54884ca2ab7376df2d89215c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Issuer
	{
		[CompilerGenerated]
		get
		{
			return _003CIssuer_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CIssuer_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Thumbprint
	{
		[CompilerGenerated]
		get
		{
			return _003CThumbprint_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					_003CThumbprint_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public string Algorithm
	{
		[CompilerGenerated]
		get
		{
			return _003CAlgorithm_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CAlgorithm_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public DateTime? ValidFrom { get; set; }

	public DateTime? ValidTill { get; set; }

	public byte[] RawData
	{
		[CompilerGenerated]
		get
		{
			return _003CRawData_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 0:
					return;
				case 1:
					_003CRawData_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Signer(X509Certificate2 certificate)
	{
		//Discarded unreachable code: IL_001a
		KxSM2NFTdo2NLYcNXsG();
		base._002Ector();
		int num = 3;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 7:
				ValidTill = null;
				num = 14;
				break;
			case 3:
				if (certificate != null)
				{
					num = 13;
					break;
				}
				Name = null;
				num = 2;
				break;
			case 6:
				ValidFrom = r7s9HvF8Cct1UVpvxGY(certificate);
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
				{
					num = 9;
				}
				break;
			case 13:
				Name = certificate.GetNameInfo(X509NameType.SimpleName, forIssuer: false);
				num = 10;
				break;
			case 4:
				ValidFrom = null;
				num = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 != 0)
				{
					num = 2;
				}
				break;
			case 14:
				return;
			case 9:
			{
				ValidTill = certificate.NotAfter;
				int num2 = 11;
				num = num2;
				break;
			}
			case 5:
				Thumbprint = null;
				num = 12;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db != 0)
				{
					num = 10;
				}
				break;
			case 12:
				Algorithm = null;
				num = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
				{
					num = 4;
				}
				break;
			case 8:
				Thumbprint = certificate.Thumbprint;
				num = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3c78e0d08cb4410a900ca26e4b83108c == 0)
				{
					num = 1;
				}
				break;
			case 10:
				Issuer = (string)m9vryLFgGWyOGPttWAL(certificate);
				num = 8;
				break;
			case 0:
				return;
			case 1:
				RawData = (byte[])ivEVteFSf2CTC1ipNNP(certificate);
				num = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				Issuer = null;
				num = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc == 0)
				{
					num = 5;
				}
				break;
			case 11:
				Algorithm = (string)((!string.IsNullOrEmpty((string)JBIEuUFyBaoydru8Caf(R0VCKtF3LSk6gksUi7J(SATtRoFrblv0TG8c5D3(certificate))))) ? certificate.PublicKey.Oid.FriendlyName : lW61IpFbYajPc3Ls22s(R0VCKtF3LSk6gksUi7J(SATtRoFrblv0TG8c5D3(certificate))));
				num = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	internal static void KxSM2NFTdo2NLYcNXsG()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static object m9vryLFgGWyOGPttWAL(object P_0)
	{
		return ((X509Certificate)P_0).Issuer;
	}

	internal static DateTime r7s9HvF8Cct1UVpvxGY(object P_0)
	{
		return ((X509Certificate2)P_0).NotBefore;
	}

	internal static object SATtRoFrblv0TG8c5D3(object P_0)
	{
		return ((X509Certificate2)P_0).PublicKey;
	}

	internal static object R0VCKtF3LSk6gksUi7J(object P_0)
	{
		return ((PublicKey)P_0).Oid;
	}

	internal static object JBIEuUFyBaoydru8Caf(object P_0)
	{
		return ((Oid)P_0).FriendlyName;
	}

	internal static object lW61IpFbYajPc3Ls22s(object P_0)
	{
		return ((Oid)P_0).Value;
	}

	internal static object ivEVteFSf2CTC1ipNNP(object P_0)
	{
		return ((X509Certificate2)P_0).RawData;
	}

	internal static bool aaWkdBFQovXTkwrNNih()
	{
		return J6UHCgFVdFVb4lHrrqU == null;
	}

	internal static Signer d3Dx7QFd8xECP2UniGq()
	{
		return J6UHCgFVdFVb4lHrrqU;
	}
}
