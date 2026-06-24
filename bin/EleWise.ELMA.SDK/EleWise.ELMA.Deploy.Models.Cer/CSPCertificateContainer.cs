using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Models.Certificates;

public sealed class CSPCertificateContainer : ICertificateContainer
{
	private X509Certificate2 componentCertificate;

	private X509Certificate2 storeCertificate;

	internal static CSPCertificateContainer Yq091YE4h80lS5Hdy4Gs;

	public CSPCertificateContainer(byte[] certificate, string password)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				storeCertificate = (X509Certificate2)RNLketE4f8k8IZTYRimJ(componentCertificate, certificate, password);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
				{
					num = 1;
				}
				break;
			case 2:
				componentCertificate = new X509Certificate2(certificate, password);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public void WriteSignature(string filePath)
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
			{
				List<SignatureCertificateReference> list = new List<SignatureCertificateReference>();
				SignatureCertificateReference signatureCertificateReference = new SignatureCertificateReference();
				SPdBd6E4Q6wMXRYauFQg(signatureCertificateReference, componentCertificate);
				signatureCertificateReference.StoreCertificate = storeCertificate;
				list.Add(signatureCertificateReference);
				ElmaStoreComponentsBuilder.Sign(filePath, list);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			}
			case 0:
				return;
			}
		}
	}

	public bool ValidateChain()
	{
		return eBbZQIE4CkHQ4Rwqx9XA(componentCertificate, storeCertificate);
	}

	private static X509Certificate2 GetIssuer(object componentCertificate, object certificate, object password)
	{
		//Discarded unreachable code: IL_0147, IL_01bf, IL_01f7, IL_023a
		int num = 1;
		int num2 = num;
		X509Certificate2 result = default(X509Certificate2);
		X509Chain x509Chain = default(X509Chain);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return result;
			case 2:
				try
				{
					x509Chain.ChainPolicy.RevocationMode = X509RevocationMode.NoCheck;
					int num3 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num3 = 2;
					}
					while (true)
					{
						switch (num3)
						{
						case 2:
							return result;
						case 5:
							NX6S1bE4Z8DgfGMPKw1s(c52OQyE48W4GwGbtfuRf(x509Chain.ChainPolicy), certificate, password, X509KeyStorageFlags.Exportable);
							num3 = 3;
							continue;
						case 3:
						{
							vdA0oYE4u8J6l2VktPiu(x509Chain, componentCertificate);
							int num4 = 4;
							num3 = num4;
							continue;
						}
						case 1:
							result = ((X509ChainElementCollection)CNmrqhE4IXwfiQj4YJQo(x509Chain))[1].Certificate;
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
							{
								num3 = 0;
							}
							continue;
						case 4:
							if (((X509ChainElementCollection)CNmrqhE4IXwfiQj4YJQo(x509Chain)).Count > 1)
							{
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
								{
									num3 = 1;
								}
								continue;
							}
							break;
						}
						x509Chain.Reset();
						num3 = 2;
					}
				}
				catch (Exception ex)
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							return result;
						}
						Kw8fkyE4Vwfaf4lt3xVA(Logger.Log, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889232584), ex);
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num5 = 0;
						}
					}
				}
				finally
				{
					if (x509Chain != null)
					{
						int num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							default:
								s8waOBE4SVoZ5CkcTYhU(x509Chain);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
								{
									num6 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 4:
				x509Chain = new X509Chain();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				return (X509Certificate2)componentCertificate;
			default:
				result = null;
				num2 = 4;
				break;
			case 1:
				if (!(((X509Certificate)componentCertificate).Subject == (string)K8HD8gE4vfs475OhmnKC(componentCertificate)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	internal static object RNLketE4f8k8IZTYRimJ(object P_0, object P_1, object P_2)
	{
		return GetIssuer(P_0, P_1, P_2);
	}

	internal static bool bI16FyE4GYeZdwJhCHEp()
	{
		return Yq091YE4h80lS5Hdy4Gs == null;
	}

	internal static CSPCertificateContainer jxQ49PE4ENcxQQ3FuVRw()
	{
		return Yq091YE4h80lS5Hdy4Gs;
	}

	internal static void SPdBd6E4Q6wMXRYauFQg(object P_0, object P_1)
	{
		((SignatureCertificateReference)P_0).ComponentCertificate = (X509Certificate2)P_1;
	}

	internal static bool eBbZQIE4CkHQ4Rwqx9XA(object P_0, object P_1)
	{
		return ElmaStoreComponentsBuilder.ValidateChain((X509Certificate2)P_0, (X509Certificate2)P_1);
	}

	internal static object K8HD8gE4vfs475OhmnKC(object P_0)
	{
		return ((X509Certificate)P_0).Issuer;
	}

	internal static object c52OQyE48W4GwGbtfuRf(object P_0)
	{
		return ((X509ChainPolicy)P_0).ExtraStore;
	}

	internal static void NX6S1bE4Z8DgfGMPKw1s(object P_0, object P_1, object P_2, X509KeyStorageFlags P_3)
	{
		((X509Certificate2Collection)P_0).Import((byte[])P_1, (string)P_2, P_3);
	}

	internal static bool vdA0oYE4u8J6l2VktPiu(object P_0, object P_1)
	{
		return ((X509Chain)P_0).Build((X509Certificate2)P_1);
	}

	internal static object CNmrqhE4IXwfiQj4YJQo(object P_0)
	{
		return ((X509Chain)P_0).ChainElements;
	}

	internal static void Kw8fkyE4Vwfaf4lt3xVA(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void s8waOBE4SVoZ5CkcTYhU(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
