using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Extensions;

public static class X509Certificate2Extensions
{
	private static readonly Dictionary<X509ChainStatusFlags, string> localizedX509Statuses;

	private static X509Certificate2Extensions iGWewL8rBsjtxt9ZUw1;

	public static void CheckRoot(this X509Certificate2 signerCertificate, string thumbprint)
	{
		//Discarded unreachable code: IL_0108, IL_01ee, IL_0389, IL_0398, IL_03cd, IL_03dc, IL_041c, IL_042b
		int num = 26;
		X509Certificate2 x509Certificate = default(X509Certificate2);
		X509Chain x509Chain = default(X509Chain);
		int num3 = default(int);
		X509ChainStatus[] array = default(X509ChainStatus[]);
		StringBuilder stringBuilder = default(StringBuilder);
		X509ChainStatus x509ChainStatus = default(X509ChainStatus);
		X509ChainElementEnumerator x509ChainElementEnumerator = default(X509ChainElementEnumerator);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 21:
					throw new CryptographicException(SR.T((string)lBKLfj89iykeyZ27JUh(-736288531 ^ -736245045)));
				case 3:
					if (x509Certificate.Thumbprint != thumbprint)
					{
						num2 = 24;
						continue;
					}
					return;
				case 19:
					x509Chain = new X509Chain();
					num2 = 14;
					continue;
				case 26:
					if (!zqZP6w8bG73SB1Bn9yG(thumbprint))
					{
						num2 = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_31b4b139e534452696f4bfdfc16f1b03 != 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 22;
				case 14:
					if (x509Chain.Build(signerCertificate))
					{
						num2 = 4;
						continue;
					}
					goto case 27;
				case 18:
				case 23:
					if (num3 < array.Length)
					{
						num = 7;
						break;
					}
					goto case 17;
				case 11:
					x6Q5Fjrkhvm3tderYlQ(stringBuilder, gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(0x65F93013 ^ 0x65F9D9B1)));
					num2 = 16;
					continue;
				case 10:
					x6Q5Fjrkhvm3tderYlQ(stringBuilder, EWlsEPrpPx7Z5eaK9R7(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2CFDCC80 ^ 0x2CFD78B0), new object[2]
					{
						x509ChainStatus.Status.ToString(),
						localizedX509Statuses[x509ChainStatus.Status]
					}));
					num2 = 8;
					continue;
				case 15:
					throw new CryptographicException(stringBuilder.ToString());
				case 4:
					x509Certificate = null;
					num2 = 28;
					continue;
				case 17:
					PawENIrAeQ8igFaxJ1Q(siDBcDr5tahpQW0cZjG(), stringBuilder.ToString());
					num2 = 15;
					continue;
				case 27:
					stringBuilder = new StringBuilder();
					num = 9;
					break;
				case 24:
					PawENIrAeQ8igFaxJ1Q(Logger.Log, EWlsEPrpPx7Z5eaK9R7(lBKLfj89iykeyZ27JUh(-2119527672 ^ -2119534162), new object[2]
					{
						thumbprint,
						JEU7aFri3uoYPtVTJdX(x509Certificate)
					}));
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					num3++;
					num2 = 23;
					continue;
				case 20:
					if (x509Certificate != null)
					{
						num2 = 3;
						continue;
					}
					goto case 21;
				case 28:
					x509ChainElementEnumerator = (X509ChainElementEnumerator)mGguwDrWfgJAUmdxHKC(x509Chain.ChainElements);
					num2 = 13;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5ae6a44bd52345c5bcadd62b7063c7d9 != 0)
					{
						num2 = 8;
					}
					continue;
				case 2:
				case 6:
					x509Certificate = ((X509ChainElement)HYwb4frXUBrvXGneo1p(x509ChainElementEnumerator)).Certificate;
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bcafdad7ca04437ebcc767622a0f9af3 != 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					if (!((IEnumerable<X509ChainStatus>)nfjR6Q8zUuf9pSSRAcy(x509Chain)).Any())
					{
						num2 = 11;
						continue;
					}
					goto case 16;
				case 22:
					throw new CryptographicException((string)gBsEtY8SWnAutRs6rbg(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA5DAE86 ^ 0xA5D47EA)));
				case 25:
					thumbprint = (string)psgI9H81tefVaGg4P0G(M4yegN8fagUmFUDlQMA(thumbprint, lBKLfj89iykeyZ27JUh(-177725793 ^ -177718683), string.Empty));
					num2 = 19;
					continue;
				case 5:
				case 7:
					x509ChainStatus = array[num3];
					num = 10;
					break;
				default:
					throw new CryptographicException((string)gBsEtY8SWnAutRs6rbg(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1378061210 ^ -1378050262)));
				case 1:
				case 13:
					if (JEhq4DrnmTSQayOdkpi(x509ChainElementEnumerator))
					{
						num2 = 6;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 20;
				case 12:
					num3 = 0;
					num2 = 18;
					continue;
				case 16:
					array = (X509ChainStatus[])nfjR6Q8zUuf9pSSRAcy(x509Chain);
					num2 = 12;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 == 0)
					{
						num2 = 11;
					}
					continue;
				}
				break;
			}
		}
	}

	public static void CheckRoot(this X509Certificate2 signerCertificate, string[] thumbprints)
	{
		//Discarded unreachable code: IL_0051, IL_0060, IL_0091, IL_00a0, IL_00f0, IL_0144, IL_01c0, IL_01cf
		int num = 5;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		bool flag = default(bool);
		int num3 = default(int);
		string[] array = default(string[]);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			case 4:
				stringBuilder = new StringBuilder();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6b49024d17a94a69b2948ac938d43b7c == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				flag = false;
				num2 = 4;
				break;
			case 3:
			case 7:
				if (num3 >= array.Length)
				{
					num2 = 10;
					break;
				}
				goto case 6;
			case 9:
				try
				{
					LGGa6ar7p88FlnhSJ12(signerCertificate, text);
					int num4 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c3d852ec782a44099f926fd43a0da6df != 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						default:
							flag = true;
							num4 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
							{
								num4 = 1;
							}
							continue;
						case 1:
							break;
						}
						break;
					}
				}
				catch (Exception ex)
				{
					int num5 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b700f854946b45dfa4de8ce28732acad == 0)
					{
						num5 = 1;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							IbYkUgrlWJ9HMvmarro(stringBuilder, (thumbprints.Length > 1) ? EWlsEPrpPx7Z5eaK9R7(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2030777218 ^ -2030819378), new object[2] { text, ex.Message }) : pPMeEyr6GhJVlQUuguW(ex));
							num5 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fa1b4c3a88294db7b3c25698c3f06dd7 == 0)
							{
								num5 = 0;
							}
							continue;
						}
						break;
					}
					goto default;
				}
				goto case 10;
			case 8:
				num3 = 0;
				num2 = 3;
				break;
			case 11:
				throw new CryptographicException(stringBuilder.ToString());
			default:
				num3++;
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b1278f673174e87a9fb6665eab69fc6 == 0)
				{
					num2 = 7;
				}
				break;
			case 10:
				if (flag)
				{
					num2 = 2;
					break;
				}
				goto case 11;
			case 6:
				text = array[num3];
				num2 = 7;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 != 0)
				{
					num2 = 9;
				}
				break;
			case 1:
				array = thumbprints;
				num2 = 5;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a16ce287ba7944e2afcf4e52864ec01d != 0)
				{
					num2 = 8;
				}
				break;
			}
		}
	}

	static X509Certificate2Extensions()
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
				uPiW6RrN4gff4ludKvC();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				localizedX509Statuses = new Dictionary<X509ChainStatusFlags, string>
				{
					{
						X509ChainStatusFlags.NoError,
						(string)gBsEtY8SWnAutRs6rbg(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x416A5E3C ^ 0x416AB256))
					},
					{
						X509ChainStatusFlags.NotTimeValid,
						(string)gBsEtY8SWnAutRs6rbg(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1712587919 ^ -1712646155))
					},
					{
						X509ChainStatusFlags.NotTimeNested,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(0x7DABA580 ^ 0x7DAB480C))
					},
					{
						X509ChainStatusFlags.Revoked,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(-236222459 ^ -236231097))
					},
					{
						X509ChainStatusFlags.NotSignatureValid,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(-730071140 ^ -730131992))
					},
					{
						X509ChainStatusFlags.NotValidForUsage,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(-76932334 ^ -76876384))
					},
					{
						X509ChainStatusFlags.UntrustedRoot,
						SR.T((string)lBKLfj89iykeyZ27JUh(-1712587919 ^ -1712646777))
					},
					{
						X509ChainStatusFlags.RevocationStatusUnknown,
						SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31C71464 ^ 0x31C7FB5C))
					},
					{
						X509ChainStatusFlags.Cyclic,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(-219609047 ^ -219551817))
					},
					{
						X509ChainStatusFlags.InvalidExtension,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(0x4BBFF2C6 ^ 0x4BBF1D1A))
					},
					{
						X509ChainStatusFlags.InvalidPolicyConstraints,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(0x1C48C9C4 ^ 0x1C4839D4))
					},
					{
						X509ChainStatusFlags.InvalidBasicConstraints,
						(string)gBsEtY8SWnAutRs6rbg(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x715714F9 ^ 0x7157E4AF))
					},
					{
						X509ChainStatusFlags.InvalidNameConstraints,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(-730071140 ^ -730132736))
					},
					{
						X509ChainStatusFlags.HasNotSupportedNameConstraint,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(0xD946FDB ^ 0xD949F07))
					},
					{
						X509ChainStatusFlags.HasNotDefinedNameConstraint,
						SR.T((string)lBKLfj89iykeyZ27JUh(-764392425 ^ -764363353))
					},
					{
						X509ChainStatusFlags.HasNotPermittedNameConstraint,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(-1329706983 ^ -1329677809))
					},
					{
						X509ChainStatusFlags.HasExcludedNameConstraint,
						(string)gBsEtY8SWnAutRs6rbg(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1429357207 ^ -1429385455))
					},
					{
						X509ChainStatusFlags.PartialChain,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(-764392425 ^ -764363055))
					},
					{
						X509ChainStatusFlags.CtlNotTimeValid,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(0x715714F9 ^ 0x7157E7C7))
					},
					{
						X509ChainStatusFlags.CtlNotSignatureValid,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(-1801396866 ^ -1801442948))
					},
					{
						X509ChainStatusFlags.CtlNotValidForUsage,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(0x37FE8EDE ^ 0x37FE7A52))
					},
					{
						X509ChainStatusFlags.OfflineRevocation,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(-1378061210 ^ -1378057870))
					},
					{
						X509ChainStatusFlags.NoIssuanceChainPolicy,
						(string)gBsEtY8SWnAutRs6rbg(lBKLfj89iykeyZ27JUh(0x62C4BCE8 ^ 0x62C44948))
					}
				};
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool zqZP6w8bG73SB1Bn9yG(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object gBsEtY8SWnAutRs6rbg(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object lBKLfj89iykeyZ27JUh(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object M4yegN8fagUmFUDlQMA(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object psgI9H81tefVaGg4P0G(object P_0)
	{
		return ((string)P_0).ToUpper();
	}

	internal static object nfjR6Q8zUuf9pSSRAcy(object P_0)
	{
		return ((X509Chain)P_0).ChainStatus;
	}

	internal static object x6Q5Fjrkhvm3tderYlQ(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}

	internal static object EWlsEPrpPx7Z5eaK9R7(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object siDBcDr5tahpQW0cZjG()
	{
		return Logger.Log;
	}

	internal static void PawENIrAeQ8igFaxJ1Q(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object mGguwDrWfgJAUmdxHKC(object P_0)
	{
		return ((X509ChainElementCollection)P_0).GetEnumerator();
	}

	internal static object HYwb4frXUBrvXGneo1p(object P_0)
	{
		return ((X509ChainElementEnumerator)P_0).Current;
	}

	internal static bool JEhq4DrnmTSQayOdkpi(object P_0)
	{
		return ((X509ChainElementEnumerator)P_0).MoveNext();
	}

	internal static object JEU7aFri3uoYPtVTJdX(object P_0)
	{
		return ((X509Certificate2)P_0).Thumbprint;
	}

	internal static bool LXOOg283ZHXwmoDmP6h()
	{
		return iGWewL8rBsjtxt9ZUw1 == null;
	}

	internal static X509Certificate2Extensions VxKiXw8y1if4snyaiOx()
	{
		return iGWewL8rBsjtxt9ZUw1;
	}

	internal static void LGGa6ar7p88FlnhSJ12(object P_0, object P_1)
	{
		((X509Certificate2)P_0).CheckRoot((string)P_1);
	}

	internal static object pPMeEyr6GhJVlQUuguW(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object IbYkUgrlWJ9HMvmarro(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static void uPiW6RrN4gff4ludKvC()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
