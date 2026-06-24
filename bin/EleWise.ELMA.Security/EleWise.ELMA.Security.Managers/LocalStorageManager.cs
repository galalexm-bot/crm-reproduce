using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

public class LocalStorageManager
{
	internal static LocalStorageManager DrKYC3DTq0g9aGibXLv;

	public static IEnumerable<X509Certificate2> GetLocalCertificates(object findValue, X509FindType findType = X509FindType.FindBySubjectName, bool? hasPrivateKey = null)
	{
		_003C_003Ec__DisplayClass0_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass0_0();
		CS_0024_003C_003E8__locals0.hasPrivateKey = hasPrivateKey;
		X509Store x509Store = new X509Store(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4BBFF2C6 ^ 0x4BBF411E), StoreLocation.CurrentUser);
		x509Store.Open(OpenFlags.OpenExistingOnly);
		return x509Store.Certificates.Find(findType, findValue, validOnly: false).Cast<X509Certificate2>().Where(delegate(X509Certificate2 c)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return _003C_003Ec__DisplayClass0_0.x4D5vypaMQslBtWOEuX1(c) == CS_0024_003C_003E8__locals0.hasPrivateKey;
				case 1:
					if (!CS_0024_003C_003E8__locals0.hasPrivateKey.HasValue)
					{
						return true;
					}
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_9a38cebc63824d86b02d76fd37722379 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		});
	}

	public static X509Certificate2 GetLocalCertificateByThumbprint(string thumbprint)
	{
		//Discarded unreachable code: IL_0066, IL_0074, IL_0110, IL_014f, IL_015e, IL_0241, IL_0254, IL_0263
		int num = 2;
		int num2 = num;
		List<X509Certificate2>.Enumerator enumerator = default(List<X509Certificate2>.Enumerator);
		X509Certificate2 result = default(X509Certificate2);
		X509KeyUsageExtension x509KeyUsageExtension = default(X509KeyUsageExtension);
		X509Certificate2 current = default(X509Certificate2);
		X509KeyUsageFlags x509KeyUsageFlags = default(X509KeyUsageFlags);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 2:
				enumerator = GetLocalCertificates(thumbprint, X509FindType.FindByThumbprint, true).ToList().GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a7933e38c68f4f69b40e459b15579199 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 9;
							goto IL_0078;
						}
						goto IL_00f7;
						IL_0078:
						while (true)
						{
							int num4;
							switch (num3)
							{
							default:
								return result;
							case 0:
								return result;
							case 3:
								if (x509KeyUsageExtension == null)
								{
									num3 = 5;
									continue;
								}
								num4 = (int)x509KeyUsageExtension.KeyUsages;
								goto IL_01f9;
							case 6:
								if (hnV9mkD3qXiXxYYFwCr(current))
								{
									num3 = 3;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b1df165db1394c8cbd9914e637f5e083 == 0)
									{
										num3 = 8;
									}
									continue;
								}
								break;
							case 1:
								break;
							case 7:
								goto IL_00f7;
							case 5:
								num4 = 0;
								goto IL_01f9;
							case 8:
								if (x509KeyUsageFlags.HasFlag(X509KeyUsageFlags.DigitalSignature))
								{
									num3 = 4;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8523ddc2b5094f2f87aec3d74da64bd2 != 0)
									{
										num3 = 0;
									}
									continue;
								}
								break;
							case 4:
								result = current;
								num3 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 == 0)
								{
									num3 = 0;
								}
								continue;
							case 2:
								x509KeyUsageExtension = (from X509Extension e in (IEnumerable)pZ9E8vDrk8JYQMQnbOR(current)
									where _003C_003Ec.THBpMtpaTJaiNrlvylpE(_003C_003Ec.HJ8uARpaQnFupOU1TOXg(_003C_003Ec.aw1HO4paVHk0s64taYSc(e)), _003C_003Ec.CnliqXpadpdtnFGDE98D(-1429500015 ^ -1429560709))
									select (X509KeyUsageExtension)e).FirstOrDefault();
								num3 = 3;
								continue;
							case 9:
								goto end_IL_00e1;
								IL_01f9:
								x509KeyUsageFlags = (X509KeyUsageFlags)num4;
								num3 = 6;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc != 0)
								{
									num3 = 0;
								}
								continue;
							}
							break;
						}
						continue;
						IL_00f7:
						current = enumerator.Current;
						num3 = 2;
						goto IL_0078;
						continue;
						end_IL_00e1:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num5 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto default;
			}
		}
	}

	public static void VerifyCertificateChain(X509Certificate2 certificate, string rootThumbprint = null)
	{
		//Discarded unreachable code: IL_00e0, IL_014f, IL_0220, IL_022f, IL_023f, IL_0432, IL_0441, IL_0451, IL_04de
		int num = 30;
		int num2 = num;
		X509ChainElementEnumerator x509ChainElementEnumerator = default(X509ChainElementEnumerator);
		X509Chain x509Chain = default(X509Chain);
		X509ChainElement x509ChainElement = default(X509ChainElement);
		X509ChainElement current = default(X509ChainElement);
		StringBuilder stringBuilder = default(StringBuilder);
		X509ChainStatus x509ChainStatus = default(X509ChainStatus);
		X509ChainStatus[] array = default(X509ChainStatus[]);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 14:
				x509ChainElementEnumerator = (X509ChainElementEnumerator)EfgdmFMWKCck06CqVX1(T9b9uqMAMrbVckJrNdw(x509Chain));
				num2 = 22;
				break;
			case 29:
				u9Tcs4Dbs29gpG3H20a(eRmcovDySspa1DP0y6P(x509Chain), X509RevocationMode.Online);
				num2 = 16;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d == 0)
				{
					num2 = 12;
				}
				break;
			case 28:
				return;
			case 25:
				if (!IMxH20MNibd0YoIUv51(lulHSAMiv9kCfVy5l2f(FXgDxcMXt0syO11gDQC(x509ChainElement)), rootThumbprint))
				{
					num2 = 28;
					break;
				}
				goto case 7;
			case 1:
				throw new CryptographicException((string)DcIEntDf7ww8Cf9gDAc(J61oJhD90XBhb0vmkwN(-1365352774 ^ -1365316262)));
			case 24:
				x509ChainElement = null;
				num2 = 14;
				break;
			case 30:
				x509Chain = new X509Chain();
				num2 = 29;
				break;
			case 5:
				t2RGfQM5jZr1USqZx6O(sfD9oBMpOIA4sKkvxAS(), g2kEF1M7P28oD6WA6PU(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1429357207 ^ -1429403347), new object[2]
				{
					dkfM28Mn1XoIs9MUscM(FXgDxcMXt0syO11gDQC(current)),
					lulHSAMiv9kCfVy5l2f(current.Certificate)
				}));
				num2 = 26;
				break;
			case 26:
				throw new CryptographicException((string)DcIEntDf7ww8Cf9gDAc(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-230994601 ^ -230950451)));
			case 13:
				stringBuilder = new StringBuilder();
				num2 = 17;
				break;
			case 6:
				t2RGfQM5jZr1USqZx6O(sfD9oBMpOIA4sKkvxAS(), stringBuilder.ToString());
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c843c5b509d748f086ceb6be01690351 != 0)
				{
					num2 = 0;
				}
				break;
			case 17:
				UJ7Tx6D12sda4sUOUKU(stringBuilder, DcIEntDf7ww8Cf9gDAc(J61oJhD90XBhb0vmkwN(-1365352774 ^ -1365316262)));
				num2 = 9;
				break;
			case 20:
			case 22:
				if (HexPnOM6iybX6AflsFd(x509ChainElementEnumerator))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 21:
				throw new CryptographicException(SR.T((string)J61oJhD90XBhb0vmkwN(0x487E82CC ^ 0x487E3610)));
			case 27:
				if (!s498tcMlOJWwwNZEecx(rootThumbprint))
				{
					num2 = 3;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
					{
						num2 = 25;
					}
					break;
				}
				return;
			case 11:
			case 18:
				x509ChainStatus = array[num3];
				num2 = 2;
				break;
			case 8:
				if (x509ChainElement != null)
				{
					num2 = 27;
					break;
				}
				goto case 21;
			case 12:
				if (((X509Certificate2)FXgDxcMXt0syO11gDQC(current)).Verify())
				{
					x509ChainElement = current;
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc == 0)
					{
						num2 = 20;
					}
				}
				else
				{
					num2 = 5;
				}
				break;
			default:
				current = x509ChainElementEnumerator.Current;
				num2 = 12;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dee60bd1c491407eb16511279f664d42 == 0)
				{
					num2 = 11;
				}
				break;
			case 16:
				((X509ChainPolicy)eRmcovDySspa1DP0y6P(x509Chain)).RevocationFlag = X509RevocationFlag.EntireChain;
				num2 = 15;
				break;
			case 2:
				UJ7Tx6D12sda4sUOUKU(stringBuilder, CcAqQIMkGKWLoZpMI4u(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1365352774 ^ -1365316982), x509ChainStatus.Status.ToString(), x509ChainStatus.StatusInformation));
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
				{
					num2 = 10;
				}
				break;
			case 7:
				t2RGfQM5jZr1USqZx6O(sfD9oBMpOIA4sKkvxAS(), SR.T((string)J61oJhD90XBhb0vmkwN(-2037738356 ^ -2037767786), x509ChainElement.Certificate.Thumbprint, rootThumbprint));
				num2 = 23;
				break;
			case 19:
				num3 = 0;
				num2 = 4;
				break;
			case 9:
				array = (X509ChainStatus[])Bj44UlDzncKjWrlgZ7r(x509Chain);
				num2 = 19;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d2fa92555e394879ba912e266541f735 != 0)
				{
					num2 = 13;
				}
				break;
			case 15:
				if (MdFrpCDSDqc4ByyErYb(x509Chain, certificate))
				{
					num2 = 24;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd != 0)
					{
						num2 = 9;
					}
					break;
				}
				goto case 13;
			case 10:
				num3++;
				num2 = 31;
				break;
			case 23:
				throw new CryptographicException((string)DcIEntDf7ww8Cf9gDAc(J61oJhD90XBhb0vmkwN(0x715714F9 ^ 0x7157A157)));
			case 4:
			case 31:
				if (num3 < array.Length)
				{
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 6;
			}
		}
	}

	public LocalStorageManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object pZ9E8vDrk8JYQMQnbOR(object P_0)
	{
		return ((X509Certificate2)P_0).Extensions;
	}

	internal static bool hnV9mkD3qXiXxYYFwCr(object P_0)
	{
		return ((X509Certificate2)P_0).Verify();
	}

	internal static bool cLGqN6Dgn1PGYtHs5Vv()
	{
		return DrKYC3DTq0g9aGibXLv == null;
	}

	internal static LocalStorageManager NIKH4yD8y4sltV8k5j9()
	{
		return DrKYC3DTq0g9aGibXLv;
	}

	internal static object eRmcovDySspa1DP0y6P(object P_0)
	{
		return ((X509Chain)P_0).ChainPolicy;
	}

	internal static void u9Tcs4Dbs29gpG3H20a(object P_0, X509RevocationMode P_1)
	{
		((X509ChainPolicy)P_0).RevocationMode = P_1;
	}

	internal static bool MdFrpCDSDqc4ByyErYb(object P_0, object P_1)
	{
		return ((X509Chain)P_0).Build((X509Certificate2)P_1);
	}

	internal static object J61oJhD90XBhb0vmkwN(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object DcIEntDf7ww8Cf9gDAc(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object UJ7Tx6D12sda4sUOUKU(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}

	internal static object Bj44UlDzncKjWrlgZ7r(object P_0)
	{
		return ((X509Chain)P_0).ChainStatus;
	}

	internal static object CcAqQIMkGKWLoZpMI4u(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object sfD9oBMpOIA4sKkvxAS()
	{
		return Logger.Log;
	}

	internal static void t2RGfQM5jZr1USqZx6O(object P_0, object P_1)
	{
		((ILogger)P_0).Error(P_1);
	}

	internal static object T9b9uqMAMrbVckJrNdw(object P_0)
	{
		return ((X509Chain)P_0).ChainElements;
	}

	internal static object EfgdmFMWKCck06CqVX1(object P_0)
	{
		return ((X509ChainElementCollection)P_0).GetEnumerator();
	}

	internal static object FXgDxcMXt0syO11gDQC(object P_0)
	{
		return ((X509ChainElement)P_0).Certificate;
	}

	internal static object dkfM28Mn1XoIs9MUscM(object P_0)
	{
		return ((X509Certificate)P_0).Subject;
	}

	internal static object lulHSAMiv9kCfVy5l2f(object P_0)
	{
		return ((X509Certificate2)P_0).Thumbprint;
	}

	internal static object g2kEF1M7P28oD6WA6PU(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static bool HexPnOM6iybX6AflsFd(object P_0)
	{
		return ((X509ChainElementEnumerator)P_0).MoveNext();
	}

	internal static bool s498tcMlOJWwwNZEecx(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool IMxH20MNibd0YoIUv51(object P_0, object P_1)
	{
		return (string)P_0 != (string)P_1;
	}
}
