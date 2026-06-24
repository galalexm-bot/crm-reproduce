using System.Text;
using EleWise.ELMA.Security.Models;

namespace EleWise.ELMA.Security.Extensions;

public static class UserCertificateExtensions
{
	private static UserCertificateExtensions bmI7L8reqZQDE1Yc46m;

	public static string GetThumbprintByPairs(this IUserCertificate cert, string splitter = ":")
	{
		//Discarded unreachable code: IL_006d, IL_007c, IL_008b, IL_00d7, IL_0137, IL_01aa, IL_01b9
		int num = 16;
		StringBuilder stringBuilder = default(StringBuilder);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					return stringBuilder.ToString();
				case 2:
				case 15:
					return null;
				case 7:
					stringBuilder = new StringBuilder();
					num2 = 11;
					continue;
				case 6:
					if (!LMSS0UratAs1yq44tn4(hMJBWwrHTMBPi96gHoj(cert)))
					{
						num2 = 7;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8176869ecaf44a0b8819db51e9ec5eb4 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 2;
				case 11:
					num3 = 0;
					num2 = 10;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
					{
						num2 = 10;
					}
					continue;
				case 5:
					num3++;
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b != 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					if (cert == null)
					{
						num2 = 15;
						continue;
					}
					goto case 6;
				case 12:
					OkjLdXrRI3OjoWphOGn(stringBuilder, splitter);
					num2 = 3;
					continue;
				case 1:
				case 10:
					if (num3 < cM1SK1rPVob9iEGlZv7(cert.Thumbprint))
					{
						num2 = 13;
						continue;
					}
					goto case 8;
				case 9:
					if (num3 <= 0)
					{
						num2 = 14;
						continue;
					}
					goto case 12;
				case 4:
				case 13:
					if (num3 % 2 != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 9;
				}
				break;
			}
			aA5rwYr2tHU0uu3AO9m(stringBuilder, JpAyKCrwtB3Eq160EDp(hMJBWwrHTMBPi96gHoj(cert), num3));
			num = 5;
		}
	}

	internal static object hMJBWwrHTMBPi96gHoj(object P_0)
	{
		return ((IUserCertificate)P_0).Thumbprint;
	}

	internal static bool LMSS0UratAs1yq44tn4(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object OkjLdXrRI3OjoWphOGn(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static char JpAyKCrwtB3Eq160EDp(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static object aA5rwYr2tHU0uu3AO9m(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static int cM1SK1rPVob9iEGlZv7(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static bool z3d4a2rL1UEifQs1kaX()
	{
		return bmI7L8reqZQDE1Yc46m == null;
	}

	internal static UserCertificateExtensions vRm3pFrj8GndWQZ7LR8()
	{
		return bmI7L8reqZQDE1Yc46m;
	}
}
