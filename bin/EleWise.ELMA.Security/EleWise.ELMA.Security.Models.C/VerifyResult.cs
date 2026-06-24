using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Models.Crypto;

public class VerifyResult : IVerifyResult
{
	private static VerifyResult q5LDxFF9gL2fgnc9qWd;

	public bool Verified
	{
		[CompilerGenerated]
		get
		{
			return _003CVerified_003Ek__BackingField;
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
					_003CVerified_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 != 0)
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

	public ISigner Signer
	{
		[CompilerGenerated]
		get
		{
			return _003CSigner_003Ek__BackingField;
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
					_003CSigner_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 != 0)
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

	public string Error
	{
		[CompilerGenerated]
		get
		{
			return _003CError_003Ek__BackingField;
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
					_003CError_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b128c216f9744fbcbc93a88cbe7b4554 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Warning
	{
		[CompilerGenerated]
		get
		{
			return _003CWarning_003Ek__BackingField;
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
					_003CWarning_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string ProviderName
	{
		[CompilerGenerated]
		get
		{
			return _003CProviderName_003Ek__BackingField;
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
					_003CProviderName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fb7ef78ec97a4842bca66699308784ed != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public static VerifyResult Fail(X509Certificate2 signerCertificate, string text)
	{
		VerifyResult obj = new VerifyResult
		{
			Verified = false
		};
		qa8BYvFzTEfNlb8HF0u(obj, text);
		qwxoj30k6NPOYZeNByE(obj, new Signer(signerCertificate));
		return obj;
	}

	public static VerifyResult Fail(string text)
	{
		return new VerifyResult
		{
			Verified = false,
			Error = text
		};
	}

	public static VerifyResult Success(X509Certificate2 signerCertificate)
	{
		VerifyResult verifyResult = new VerifyResult();
		vURWxI0pFG3vZilPhPm(verifyResult, true);
		verifyResult.Signer = new Signer(signerCertificate);
		return verifyResult;
	}

	public static VerifyResult Success(X509Certificate2 signerCertificate, string warning)
	{
		VerifyResult verifyResult = new VerifyResult();
		vURWxI0pFG3vZilPhPm(verifyResult, true);
		W0fl9S05tbKKXJ0Xf9x(verifyResult, warning);
		verifyResult.Signer = new Signer(signerCertificate);
		return verifyResult;
	}

	public void ThrowIfNotVerified()
	{
		//Discarded unreachable code: IL_0099, IL_00a8
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				throw new CryptographicException((string)mlReAr0ARst0K9nru2J(Mpg7HA0WsU0evvWawv6(-434542700 ^ -434519890)));
			case 1:
				return;
			case 2:
				throw new CryptographicException((string)mlReAr0ARst0K9nru2J(Error));
			case 3:
				if (Verified)
				{
					if (Signer != null)
					{
						num2 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a33ec05b36714591b0adf150b655c9a8 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
				num2 = 2;
				break;
			}
		}
	}

	public VerifyResult()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		cX39BX0X2xiu8URH7jr();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static void qa8BYvFzTEfNlb8HF0u(object P_0, object P_1)
	{
		((VerifyResult)P_0).Error = (string)P_1;
	}

	internal static void qwxoj30k6NPOYZeNByE(object P_0, object P_1)
	{
		((VerifyResult)P_0).Signer = (ISigner)P_1;
	}

	internal static bool yJcGARFfFsZ6bSI1JTb()
	{
		return q5LDxFF9gL2fgnc9qWd == null;
	}

	internal static VerifyResult QWMECfF12448hdAmMML()
	{
		return q5LDxFF9gL2fgnc9qWd;
	}

	internal static void vURWxI0pFG3vZilPhPm(object P_0, bool value)
	{
		((VerifyResult)P_0).Verified = value;
	}

	internal static void W0fl9S05tbKKXJ0Xf9x(object P_0, object P_1)
	{
		((VerifyResult)P_0).Warning = (string)P_1;
	}

	internal static object mlReAr0ARst0K9nru2J(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object Mpg7HA0WsU0evvWawv6(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void cX39BX0X2xiu8URH7jr()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
