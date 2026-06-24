using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using CERTADMINLib;
using CERTCLIENTLib;
using CERTENROLLLib;
using EleWise.ELMA.Security.Models;
using j3AmrhgkCleVTGdEwA;
using Microsoft.CSharp.RuntimeBinder;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Managers;

public class CertificationAuthorityManager
{
	public const int CV_OUT_BASE64 = 1;

	public const int CV_OUT_BINARY = 2;

	public const int CV_OUT_HEX = 4;

	public const int CV_OUT_HEXASCII = 5;

	public const int PROPTYPE_LONG = 1;

	public const int PROPTYPE_DATE = 2;

	public const int PROPTYPE_BINARY = 3;

	public const int PROPTYPE_STRING = 4;

	public const int PROPTYPE_MASK = 255;

	internal static CertificationAuthorityManager lKI12SDp5N8csS5Y5as;

	public static string MakeRequest(string strDn, int providerType)
	{
		int num = 14;
		int num2 = num;
		CObjectId cObjectId = default(CObjectId);
		IX509CertificateRequestPkcs10 iX509CertificateRequestPkcs = default(IX509CertificateRequestPkcs10);
		CX509PrivateKey cX509PrivateKey = default(CX509PrivateKey);
		CX509ExtensionKeyUsage cX509ExtensionKeyUsage = default(CX509ExtensionKeyUsage);
		CObjectIds cObjectIds = default(CObjectIds);
		CX509ExtensionEnhancedKeyUsage cX509ExtensionEnhancedKeyUsage = default(CX509ExtensionEnhancedKeyUsage);
		CX500DistinguishedName cX500DistinguishedName = default(CX500DistinguishedName);
		while (true)
		{
			switch (num2)
			{
			case 19:
				cObjectId = (CObjectId)p1eoudDXYdC5TB0m0Oo(RO65mRDWwCCjbreuqTt(new Guid((string)VAW31CDnJoQU022xZOF(0x3E79A885 ^ 0x3E7905CF))));
				num2 = 12;
				break;
			case 9:
				QibCQiDiJ98xYRvy9LV(iX509CertificateRequestPkcs);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_05864899c47d415d8fae32c68fb25d39 != 0)
				{
					num2 = 1;
				}
				break;
			case 10:
				cX509PrivateKey.KeySpec = X509KeySpec.XCN_AT_SIGNATURE;
				num2 = 17;
				break;
			case 14:
				iX509CertificateRequestPkcs = (CX509CertificateRequestPkcs10)p1eoudDXYdC5TB0m0Oo(RO65mRDWwCCjbreuqTt(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31C71464 ^ 0x31C7B802))));
				num2 = 13;
				break;
			case 11:
				cX509ExtensionKeyUsage = (CX509ExtensionKeyUsage)p1eoudDXYdC5TB0m0Oo(Marshal.GetTypeFromCLSID(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B1D6430 ^ 0x3B1DCA1E))));
				num2 = 8;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 != 0)
				{
					num2 = 8;
				}
				break;
			case 4:
				cObjectIds.Add(cObjectId);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 != 0)
				{
					num2 = 1;
				}
				break;
			default:
				iX509CertificateRequestPkcs.X509Extensions.Add((CX509Extension)cX509ExtensionEnhancedKeyUsage);
				num2 = 11;
				break;
			case 1:
				cX509ExtensionEnhancedKeyUsage = (CX509ExtensionEnhancedKeyUsage)Activator.CreateInstance(RO65mRDWwCCjbreuqTt(new Guid((string)VAW31CDnJoQU022xZOF(-1586242415 ^ -1586269837))));
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c78060c4cac8419092e4610bf7a03750 != 0)
				{
					num2 = 7;
				}
				break;
			case 17:
				iX509CertificateRequestPkcs.InitializeFromPrivateKey(X509CertificateEnrollmentContext.ContextUser, cX509PrivateKey, null);
				num2 = 16;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
				{
					num2 = 4;
				}
				break;
			case 16:
				cX500DistinguishedName = (CX500DistinguishedName)p1eoudDXYdC5TB0m0Oo(Marshal.GetTypeFromCLSID(new Guid((string)VAW31CDnJoQU022xZOF(0x2E78F5A0 ^ 0x2E78595E))));
				num2 = 6;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 != 0)
				{
					num2 = 1;
				}
				break;
			case 13:
				cX509PrivateKey = (CX509PrivateKey)Activator.CreateInstance(RO65mRDWwCCjbreuqTt(new Guid((string)VAW31CDnJoQU022xZOF(0x1B47BFA1 ^ 0x1B471313))));
				num2 = 3;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_dffee0180fb244db9738339fa28792b4 == 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				cX509PrivateKey.ProviderType = (X509ProviderType)providerType;
				num2 = 10;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 != 0)
				{
					num2 = 3;
				}
				break;
			case 12:
				cObjectId.InitializeFromName(CERTENROLL_OBJECTID.XCN_OID_PKIX_KP_CLIENT_AUTH);
				num2 = 15;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4ca2baab70e44d2ca8271afba4c9a72d != 0)
				{
					num2 = 7;
				}
				break;
			case 8:
				cX509ExtensionKeyUsage.InitializeEncode((CERTENROLLLib.X509KeyUsageFlags)240);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
				{
					num2 = 3;
				}
				break;
			case 7:
				cX509ExtensionEnhancedKeyUsage.InitializeEncode(cObjectIds);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_364662b38d3b4bdb9f3f1f11b8889cdc != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				iX509CertificateRequestPkcs.X509Extensions.Add((CX509Extension)cX509ExtensionKeyUsage);
				num2 = 9;
				break;
			case 2:
			{
				CX509Enrollment obj = (CX509Enrollment)p1eoudDXYdC5TB0m0Oo(Marshal.GetTypeFromCLSID(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x71CDF2F ^ 0x71C7155))));
				obj.InitializeFromRequest(iX509CertificateRequestPkcs);
				return obj.CreateRequest();
			}
			case 15:
				cObjectIds = (CObjectIds)Activator.CreateInstance(RO65mRDWwCCjbreuqTt(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7CAA49C6 ^ 0x7CAAE450))));
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
				{
					num2 = 4;
				}
				break;
			case 6:
				cX500DistinguishedName.Encode(strDn);
				num2 = 2;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6949750552fc4dcdbaec6842e5667482 != 0)
				{
					num2 = 18;
				}
				break;
			case 18:
				iX509CertificateRequestPkcs.Subject = cX500DistinguishedName;
				num2 = 19;
				break;
			}
		}
	}

	public static void InstallResponse(string certString)
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
			{
				CX509Enrollment obj = (CX509Enrollment)Activator.CreateInstance(RO65mRDWwCCjbreuqTt(new Guid((string)VAW31CDnJoQU022xZOF(-1365352774 ^ -1365315392))));
				obj.Initialize(X509CertificateEnrollmentContext.ContextUser);
				obj.InstallResponse((InstallResponseRestrictionFlags)6, certString, EncodingType.XCN_CRYPT_STRING_BASE64, null);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	public static X509Certificate2 GetRootCertificate(string address)
	{
		int num = 1;
		int num2 = num;
		string cACertificate = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				cACertificate = ((CCertRequest)p1eoudDXYdC5TB0m0Oo(Marshal.GetTypeFromCLSID(new Guid((string)VAW31CDnJoQU022xZOF(-1973849202 ^ -1973822136))))).GetCACertificate(0, address, 0);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return new X509Certificate2(((Encoding)lLckZOD7fccIcwXtv7G()).GetBytes(cACertificate));
			}
		}
	}

	public static void InstallRootCert(string address)
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
				X509Store x509Store = new X509Store((string)VAW31CDnJoQU022xZOF(0x22A54A05 ^ 0x22A5E517), StoreLocation.CurrentUser);
				x509Store.Open(OpenFlags.ReadWrite | OpenFlags.OpenExistingOnly);
				X509Certificate2 rootCertificate = GetRootCertificate(address);
				x509Store.Add(rootCertificate);
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7fbc19cae8c8414894251bb8ae24a12e == 0)
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

	public static string SubmitRequest(string address, string request)
	{
		CCertRequest obj = (CCertRequest)p1eoudDXYdC5TB0m0Oo(RO65mRDWwCCjbreuqTt(new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-76932334 ^ -76892716))));
		if (obj.Submit(257, request, (string)VAW31CDnJoQU022xZOF(0x23D92C6F ^ 0x23D98371), address) != 3)
		{
			throw new CryptographicException((string)VAW31CDnJoQU022xZOF(0x417D81DE ^ 0x417D31D2));
		}
		return obj.GetCertificate(1);
	}

	public static bool CheckValid(string address, string serial)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (r6ZllsD6eOIs3cXBxit(serial))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c08b0b4e9ab14bedb2a2c7a0048ab814 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return ((CCertAdmin)Activator.CreateInstance(RO65mRDWwCCjbreuqTt(new Guid((string)VAW31CDnJoQU022xZOF(0x1B47BFA1 ^ 0x1B470F9D))))).IsValidCertificate(address, serial) == 3;
			default:
				return false;
			}
		}
	}

	protected static void SetCertProp(CertificateInfo cert, string propName, IEnumCERTVIEWCOLUMN objCol)
	{
		//Discarded unreachable code: IL_0297, IL_0368, IL_038d, IL_039c, IL_03ab, IL_03ba, IL_03c9, IL_03d9, IL_03fe, IL_040d, IL_0481, IL_0490, IL_049f, IL_04af, IL_04be, IL_04ce, IL_04f3, IL_0502, IL_0512, IL_0521, IL_055c, IL_056b, IL_057a, IL_05c5, IL_05d8, IL_05e7, IL_05f7, IL_0606, IL_064b, IL_065a, IL_06b8, IL_06c7, IL_06d6, IL_06e5, IL_06f4, IL_0766, IL_0775, IL_0785, IL_0794, IL_07a4, IL_07b3, IL_0804, IL_0858, IL_0867, IL_0876, IL_0886, IL_0895, IL_08a5, IL_08e9, IL_08f8, IL_0907, IL_0916, IL_0925, IL_0935, IL_0944, IL_09af, IL_09be, IL_09ce, IL_0a03, IL_0a12, IL_0a4d, IL_0aa7, IL_0ab6, IL_0ac5, IL_0ad4, IL_0ae4, IL_0af3, IL_0b03, IL_0b12, IL_0b3b, IL_0b4a, IL_0bc6, IL_0bd5, IL_0be5, IL_0c0a, IL_0c3f, IL_0c99, IL_0cbe, IL_0ccd, IL_0cdd, IL_0cec, IL_0cfb, IL_0dd8, IL_0de7, IL_0df7, IL_0e06, IL_0e16, IL_0e25, IL_0e35, IL_0e44, IL_0e53, IL_0e63, IL_0e8c, IL_0e9b, IL_0ed0, IL_0edf, IL_0eee, IL_1e2f, IL_1e46, IL_1e55
		switch (1)
		{
		case 0:
			break;
		case 1:
			try
			{
				uint num = _003CPrivateImplementationDetails_003E.ComputeStringHash(propName);
				int num2 = 40;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 != 0)
				{
					num2 = 42;
				}
				while (true)
				{
					int num3;
					switch (num2)
					{
					default:
						return;
					case 0:
						return;
					case 1:
						return;
					case 2:
						return;
					case 6:
						return;
					case 8:
						return;
					case 10:
						return;
					case 12:
						return;
					case 15:
						return;
					case 25:
						return;
					case 26:
						return;
					case 27:
						return;
					case 31:
						return;
					case 32:
						return;
					case 33:
						return;
					case 34:
						return;
					case 40:
						return;
					case 45:
						return;
					case 46:
						return;
					case 51:
						return;
					case 59:
						return;
					case 61:
						return;
					case 64:
						return;
					case 71:
						return;
					case 75:
						return;
					case 80:
						return;
					case 81:
						return;
					case 83:
						return;
					case 85:
						return;
					case 87:
						return;
					case 93:
						return;
					case 95:
						return;
					case 99:
						return;
					case 101:
						return;
					case 102:
						return;
					case 105:
						return;
					case 106:
						return;
					case 107:
						return;
					case 109:
						return;
					case 112:
						return;
					case 116:
						return;
					case 120:
						return;
					case 127:
						return;
					case 129:
						return;
					case 133:
						return;
					case 134:
						return;
					case 135:
						return;
					case 137:
						return;
					case 138:
						return;
					case 139:
						return;
					case 140:
						return;
					case 142:
						return;
					case 52:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, VAW31CDnJoQU022xZOF(0x1618182 ^ 0x161332A)))
						{
							return;
						}
						num2 = 77;
						break;
					case 122:
						if (!(propName == (string)VAW31CDnJoQU022xZOF(0x4E6718AE ^ 0x4E67A9BE)))
						{
							return;
						}
						num2 = 23;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 == 0)
						{
							num2 = 17;
						}
						break;
					case 44:
						if (num != 83164785)
						{
							num2 = 64;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae9e5ed1f04543cd9a3ea633dd768889 != 0)
							{
								num2 = 117;
							}
							break;
						}
						goto case 72;
					case 9:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, VAW31CDnJoQU022xZOF(-1718905545 ^ -1718934081)))
						{
							num2 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
							{
								num2 = 1;
							}
							break;
						}
						goto case 86;
					case 42:
						if (num > 1492200390)
						{
							num2 = 131;
							break;
						}
						goto case 22;
					case 54:
						if (num != 1214152085)
						{
							num2 = 15;
							break;
						}
						goto case 60;
					case 91:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, VAW31CDnJoQU022xZOF(-1580392499 ^ -1580356157)))
						{
							return;
						}
						num2 = 30;
						break;
					case 123:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x22A54A05 ^ 0x22A5F883)))
						{
							num2 = 137;
							break;
						}
						goto case 136;
					case 69:
						if (num != 824548944)
						{
							num3 = 54;
							goto IL_0048;
						}
						goto case 84;
					case 128:
						if (num != 3142863279u)
						{
							num2 = 109;
							break;
						}
						goto case 3;
					case 125:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, VAW31CDnJoQU022xZOF(0x6A336151 ^ 0x6A33D361)))
						{
							num2 = 45;
							break;
						}
						goto case 97;
					case 121:
						if (num != 328359283)
						{
							num2 = 56;
							break;
						}
						goto case 125;
					case 74:
						if (num != 3277942151u)
						{
							num2 = 28;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7eacf98b652644699fca43e43408d382 != 0)
							{
								num2 = 71;
							}
							break;
						}
						goto case 91;
					case 16:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, VAW31CDnJoQU022xZOF(0x1B47BFA1 ^ 0x1B470E2F)))
						{
							num2 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto case 113;
					case 84:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6547C338 ^ 0x6547721E)))
						{
							num3 = 59;
							goto IL_0048;
						}
						goto case 20;
					case 3:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, VAW31CDnJoQU022xZOF(0x7CAA49C6 ^ 0x7CAAF896)))
						{
							return;
						}
						num2 = 14;
						break;
					case 53:
					case 55:
						if (num > 3277942151u)
						{
							num2 = 132;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 == 0)
							{
								num2 = 108;
							}
							break;
						}
						goto case 68;
					case 18:
					case 108:
						if (num != 2285031632u)
						{
							num2 = 4;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b496c4412b534db6beb066c8296e663d != 0)
							{
								num2 = 24;
							}
							break;
						}
						goto case 7;
					case 11:
						if (num > 2069686773)
						{
							num2 = 18;
							break;
						}
						goto case 88;
					case 65:
					case 141:
						if (num > 1214152085)
						{
							num2 = 66;
							break;
						}
						goto case 115;
					case 67:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, VAW31CDnJoQU022xZOF(0x62C4BCE8 ^ 0x62C40EB6)))
						{
							return;
						}
						num2 = 39;
						break;
					case 37:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, VAW31CDnJoQU022xZOF(-76932334 ^ -76895560)))
						{
							return;
						}
						num2 = 62;
						break;
					case 88:
						if (num != 1782056091)
						{
							num3 = 73;
							goto IL_0048;
						}
						goto case 52;
					case 48:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A79A716 ^ 0x6A7915C0)))
						{
							return;
						}
						num2 = 89;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f == 0)
						{
							num2 = 28;
						}
						break;
					case 72:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, VAW31CDnJoQU022xZOF(0x8875F5C ^ 0x887EE86)))
						{
							return;
						}
						num3 = 100;
						goto IL_0048;
					case 115:
						if (num != 634921714)
						{
							num2 = 69;
							break;
						}
						goto case 98;
					case 68:
						if (num != 3165258191u)
						{
							num2 = 38;
							break;
						}
						goto case 123;
					case 98:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, VAW31CDnJoQU022xZOF(0xCD88DD8 ^ 0xCD83D00)))
						{
							num2 = 105;
							break;
						}
						goto case 119;
					case 60:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x23D92C6F ^ 0x23D99D55)))
						{
							return;
						}
						num2 = 90;
						break;
					case 4:
						if (num != 3551955008u)
						{
							num2 = 94;
							break;
						}
						goto case 37;
					case 58:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, VAW31CDnJoQU022xZOF(0x6A79A716 ^ 0x6A7916DA)))
						{
							num2 = 21;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_df5466d729844e8ea757565832a01037 != 0)
							{
								num2 = 33;
							}
							break;
						}
						goto case 50;
					case 73:
						if (num != 2069686773)
						{
							num3 = 116;
							goto IL_0048;
						}
						goto case 122;
					case 29:
					case 131:
						if (num > 3142863279u)
						{
							num2 = 53;
							break;
						}
						goto case 11;
					case 41:
						if (num != 1407976548)
						{
							num2 = 28;
							break;
						}
						goto case 35;
					case 104:
						if (num != 617902505)
						{
							num2 = 102;
							break;
						}
						goto case 58;
					case 36:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, VAW31CDnJoQU022xZOF(0x397B0322 ^ 0x397BB2CE)))
						{
							return;
						}
						num2 = 49;
						break;
					case 56:
						if (num != 426894090)
						{
							num2 = 104;
							break;
						}
						goto case 79;
					case 130:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, VAW31CDnJoQU022xZOF(-1429500015 ^ -1429520577)))
						{
							return;
						}
						num2 = 103;
						break;
					case 43:
						if (!(propName == (string)VAW31CDnJoQU022xZOF(0x271B34E4 ^ 0x271B8620)))
						{
							num2 = 56;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a5d922da527e46afbe4b139adb51cde5 != 0)
							{
								num2 = 64;
							}
							break;
						}
						goto case 78;
					case 22:
						if (num > 617902505)
						{
							num2 = 141;
							break;
						}
						goto case 19;
					case 94:
						if (num != 3565254712u)
						{
							return;
						}
						num2 = 9;
						break;
					case 19:
						if (num <= 282874604)
						{
							num2 = 44;
							break;
						}
						goto case 121;
					case 79:
						if (!(propName == (string)VAW31CDnJoQU022xZOF(0x4A799728 ^ 0x4A79256A)))
						{
							return;
						}
						num2 = 114;
						break;
					case 117:
						if (num != 282874604)
						{
							num2 = 95;
							break;
						}
						goto case 36;
					case 38:
						if (num != 3188789611u)
						{
							num2 = 37;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0dd863774da04dfd9f21706b4b60a6b9 != 0)
							{
								num2 = 74;
							}
							break;
						}
						goto case 130;
					case 66:
					case 111:
						if (num != 1335638524)
						{
							num2 = 41;
							break;
						}
						goto case 67;
					case 7:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, VAW31CDnJoQU022xZOF(0x65F93013 ^ 0x65F9820F)))
						{
							num2 = 142;
							break;
						}
						goto case 96;
					case 47:
					case 132:
						if (num != 3353632950u)
						{
							num2 = 4;
							break;
						}
						goto case 48;
					case 28:
						if (num != 1492200390)
						{
							num2 = 46;
							break;
						}
						goto case 43;
					case 35:
						if (!aAqZRhDlkoxGOSTJ2Jv(propName, VAW31CDnJoQU022xZOF(-1858473711 ^ -1858518919)))
						{
							return;
						}
						num2 = 92;
						break;
					case 24:
						if (num != 2565758308u)
						{
							num3 = 128;
							goto IL_0048;
						}
						goto case 16;
					case 86:
						if (_003C_003Eo__18._003C_003Ep__0 == null)
						{
							_003C_003Eo__18._003C_003Ep__0 = CallSite<Func<CallSite, object, int>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.ConvertExplicit, plyZeEDNEgec2vdL9PG(typeof(int).TypeHandle), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
						}
						wfBvvVDxFn0wGykfbK2(cert, _003C_003Eo__18._003C_003Ep__0.Target(_003C_003Eo__18._003C_003Ep__0, objCol.GetValue(1)));
						num2 = 80;
						break;
					case 70:
					case 103:
						if (_003C_003Eo__18._003C_003Ep__1 == null)
						{
							_003C_003Eo__18._003C_003Ep__1 = CallSite<Func<CallSite, object, int>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.ConvertExplicit, plyZeEDNEgec2vdL9PG(typeof(int).TypeHandle), typeof(CertificationAuthorityManager)));
						}
						Udib9bDBtam5PlDvwOX(cert, _003C_003Eo__18._003C_003Ep__1.Target(_003C_003Eo__18._003C_003Ep__1, objCol.GetValue(1)));
						num2 = 32;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 != 0)
						{
							num2 = 129;
						}
						break;
					case 119:
					{
						if (_003C_003Eo__18._003C_003Ep__3 == null)
						{
							_003C_003Eo__18._003C_003Ep__3 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.None, plyZeEDNEgec2vdL9PG(typeof(string).TypeHandle), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
						}
						Func<CallSite, object, string> target2 = _003C_003Eo__18._003C_003Ep__3.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__2 = _003C_003Eo__18._003C_003Ep__3;
						if (_003C_003Eo__18._003C_003Ep__2 == null)
						{
							_003C_003Eo__18._003C_003Ep__2 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858473711 ^ -1858518037), null, typeof(CertificationAuthorityManager), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags.None, null) }));
						}
						cert.RequestDispMessage = target2(_003C_003Ep__2, _003C_003Eo__18._003C_003Ep__2.Target(_003C_003Eo__18._003C_003Ep__2, objCol.GetValue(4)));
						num2 = 134;
						break;
					}
					case 5:
					case 23:
						if (_003C_003Eo__18._003C_003Ep__4 == null)
						{
							_003C_003Eo__18._003C_003Ep__4 = CallSite<Func<CallSite, object, DateTime>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.ConvertExplicit, typeof(DateTime), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
						}
						xT9b4ZDmVcNxYLST4Ih(cert, _003C_003Eo__18._003C_003Ep__4.Target(_003C_003Eo__18._003C_003Ep__4, objCol.GetValue(2)));
						num2 = 8;
						break;
					case 20:
						if (_003C_003Eo__18._003C_003Ep__5 == null)
						{
							_003C_003Eo__18._003C_003Ep__5 = CallSite<Func<CallSite, object, DateTime>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.ConvertExplicit, plyZeEDNEgec2vdL9PG(typeof(DateTime).TypeHandle), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
						}
						G6S0aoDeELMd6SnfOLs(cert, _003C_003Eo__18._003C_003Ep__5.Target(_003C_003Eo__18._003C_003Ep__5, objCol.GetValue(2)));
						num2 = 106;
						break;
					case 90:
					case 118:
					{
						if (_003C_003Eo__18._003C_003Ep__7 == null)
						{
							_003C_003Eo__18._003C_003Ep__7 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.None, plyZeEDNEgec2vdL9PG(typeof(string).TypeHandle), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
						}
						Func<CallSite, object, string> target16 = _003C_003Eo__18._003C_003Ep__7.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__16 = _003C_003Eo__18._003C_003Ep__7;
						if (_003C_003Eo__18._003C_003Ep__6 == null)
						{
							_003C_003Eo__18._003C_003Ep__6 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string)VAW31CDnJoQU022xZOF(0xCD88DD8 ^ 0xCD83F22), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags.None, null) }));
						}
						gLZwPEDLsBV2bx1il70(cert, target16(_003C_003Ep__16, _003C_003Eo__18._003C_003Ep__6.Target(_003C_003Eo__18._003C_003Ep__6, objCol.GetValue(4))));
						num2 = 127;
						break;
					}
					case 13:
					case 14:
					{
						if (_003C_003Eo__18._003C_003Ep__9 == null)
						{
							_003C_003Eo__18._003C_003Ep__9 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.None, plyZeEDNEgec2vdL9PG(typeof(string).TypeHandle), typeof(CertificationAuthorityManager)));
						}
						Func<CallSite, object, string> target14 = _003C_003Eo__18._003C_003Ep__9.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__14 = _003C_003Eo__18._003C_003Ep__9;
						if (_003C_003Eo__18._003C_003Ep__8 == null)
						{
							_003C_003Eo__18._003C_003Ep__8 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string)VAW31CDnJoQU022xZOF(0x487E82CC ^ 0x487E3036), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags.None, null) }));
						}
						fEuBblDjOGmd2FNn6OH(cert, target14(_003C_003Ep__14, _003C_003Eo__18._003C_003Ep__8.Target(_003C_003Eo__18._003C_003Ep__8, objCol.GetValue(4))));
						num2 = 125;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_7ced317202a44233ac3d0deafcdd1923 == 0)
						{
							num2 = 133;
						}
						break;
					}
					case 21:
					case 92:
					{
						if (_003C_003Eo__18._003C_003Ep__11 == null)
						{
							_003C_003Eo__18._003C_003Ep__11 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.None, plyZeEDNEgec2vdL9PG(typeof(string).TypeHandle), typeof(CertificationAuthorityManager)));
						}
						Func<CallSite, object, string> target12 = _003C_003Eo__18._003C_003Ep__11.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__12 = _003C_003Eo__18._003C_003Ep__11;
						if (_003C_003Eo__18._003C_003Ep__10 == null)
						{
							_003C_003Eo__18._003C_003Ep__10 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string)VAW31CDnJoQU022xZOF(0xAEB118D ^ 0xAEBA377), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags.None, null) }));
						}
						JMeeSeDHtCuGf1lFyW1(cert, target12(_003C_003Ep__12, _003C_003Eo__18._003C_003Ep__10.Target(_003C_003Eo__18._003C_003Ep__10, objCol.GetValue(4))));
						num3 = 10;
						goto IL_0048;
					}
					case 113:
					{
						if (_003C_003Eo__18._003C_003Ep__13 == null)
						{
							_003C_003Eo__18._003C_003Ep__13 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.None, plyZeEDNEgec2vdL9PG(typeof(string).TypeHandle), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
						}
						Func<CallSite, object, string> target17 = _003C_003Eo__18._003C_003Ep__13.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__17 = _003C_003Eo__18._003C_003Ep__13;
						if (_003C_003Eo__18._003C_003Ep__12 == null)
						{
							_003C_003Eo__18._003C_003Ep__12 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string)VAW31CDnJoQU022xZOF(-1889123947 ^ -1889078417), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags.None, null) }));
						}
						GJWphXDaaASih0wmndQ(cert, target17(_003C_003Ep__17, _003C_003Eo__18._003C_003Ep__12.Target(_003C_003Eo__18._003C_003Ep__12, objCol.GetValue(4))));
						num2 = 112;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4b098d453cbc45388569889eb6ab714d == 0)
						{
							num2 = 28;
						}
						break;
					}
					case 62:
					case 124:
					{
						if (_003C_003Eo__18._003C_003Ep__15 == null)
						{
							_003C_003Eo__18._003C_003Ep__15 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.None, plyZeEDNEgec2vdL9PG(typeof(string).TypeHandle), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
						}
						Func<CallSite, object, string> target11 = _003C_003Eo__18._003C_003Ep__15.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__11 = _003C_003Eo__18._003C_003Ep__15;
						if (_003C_003Eo__18._003C_003Ep__14 == null)
						{
							_003C_003Eo__18._003C_003Ep__14 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string)VAW31CDnJoQU022xZOF(0xCDF201B ^ 0xCDF92E1), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags.None, null) }));
						}
						kK5xtYDR6gJv1GJo1r6(cert, target11(_003C_003Ep__11, _003C_003Eo__18._003C_003Ep__14.Target(_003C_003Eo__18._003C_003Ep__14, objCol.GetValue(4))));
						num2 = 34;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c3c41b36b4846e0b1701d4e56408883 != 0)
						{
							num2 = 9;
						}
						break;
					}
					case 50:
					{
						if (_003C_003Eo__18._003C_003Ep__17 == null)
						{
							_003C_003Eo__18._003C_003Ep__17 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, plyZeEDNEgec2vdL9PG(typeof(string).TypeHandle), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
						}
						Func<CallSite, object, string> target13 = _003C_003Eo__18._003C_003Ep__17.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__13 = _003C_003Eo__18._003C_003Ep__17;
						if (_003C_003Eo__18._003C_003Ep__16 == null)
						{
							_003C_003Eo__18._003C_003Ep__16 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1429357207 ^ -1429401709), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
						}
						x8qnRGDwaFrsxLyv5fM(cert, target13(_003C_003Ep__13, _003C_003Eo__18._003C_003Ep__16.Target(_003C_003Eo__18._003C_003Ep__16, objCol.GetValue(4))));
						num2 = 40;
						break;
					}
					case 82:
					case 100:
					{
						if (_003C_003Eo__18._003C_003Ep__19 == null)
						{
							_003C_003Eo__18._003C_003Ep__19 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.None, typeof(string), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
						}
						Func<CallSite, object, string> target10 = _003C_003Eo__18._003C_003Ep__19.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__10 = _003C_003Eo__18._003C_003Ep__19;
						if (_003C_003Eo__18._003C_003Ep__18 == null)
						{
							_003C_003Eo__18._003C_003Ep__18 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string)VAW31CDnJoQU022xZOF(0x43ED0455 ^ 0x43EDB6AF), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags.None, null) }));
						}
						cert.Country = target10(_003C_003Ep__10, _003C_003Eo__18._003C_003Ep__18.Target(_003C_003Eo__18._003C_003Ep__18, objCol.GetValue(4)));
						num2 = 138;
						break;
					}
					case 17:
					case 49:
					{
						if (_003C_003Eo__18._003C_003Ep__21 == null)
						{
							_003C_003Eo__18._003C_003Ep__21 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.None, plyZeEDNEgec2vdL9PG(typeof(string).TypeHandle), typeof(CertificationAuthorityManager)));
						}
						Func<CallSite, object, string> target8 = _003C_003Eo__18._003C_003Ep__21.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__8 = _003C_003Eo__18._003C_003Ep__21;
						if (_003C_003Eo__18._003C_003Ep__20 == null)
						{
							_003C_003Eo__18._003C_003Ep__20 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string)VAW31CDnJoQU022xZOF(0x738E3073 ^ 0x738E8289), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags.None, null) }));
						}
						ibe4flD21cmj1p9Nmyu(cert, target8(_003C_003Ep__8, _003C_003Eo__18._003C_003Ep__20.Target(_003C_003Eo__18._003C_003Ep__20, objCol.GetValue(4))));
						num2 = 12;
						break;
					}
					case 30:
					case 63:
					{
						if (_003C_003Eo__18._003C_003Ep__23 == null)
						{
							_003C_003Eo__18._003C_003Ep__23 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.None, plyZeEDNEgec2vdL9PG(typeof(string).TypeHandle), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
						}
						Func<CallSite, object, string> target7 = _003C_003Eo__18._003C_003Ep__23.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__7 = _003C_003Eo__18._003C_003Ep__23;
						if (_003C_003Eo__18._003C_003Ep__22 == null)
						{
							_003C_003Eo__18._003C_003Ep__22 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string)VAW31CDnJoQU022xZOF(-1195916818 ^ -1195937004), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags.None, null) }));
						}
						cert.EMail = target7(_003C_003Ep__7, _003C_003Eo__18._003C_003Ep__22.Target(_003C_003Eo__18._003C_003Ep__22, objCol.GetValue(4)));
						num2 = 74;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c270ab2f5854923a44daf526a7f59af == 0)
						{
							num2 = 87;
						}
						break;
					}
					case 96:
					{
						if (_003C_003Eo__18._003C_003Ep__25 == null)
						{
							_003C_003Eo__18._003C_003Ep__25 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.None, plyZeEDNEgec2vdL9PG(typeof(string).TypeHandle), typeof(CertificationAuthorityManager)));
						}
						Func<CallSite, object, string> target9 = _003C_003Eo__18._003C_003Ep__25.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__9 = _003C_003Eo__18._003C_003Ep__25;
						if (_003C_003Eo__18._003C_003Ep__24 == null)
						{
							_003C_003Eo__18._003C_003Ep__24 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string)VAW31CDnJoQU022xZOF(0x61EAE816 ^ 0x61EA5AEC), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
						}
						FHj6o9DP0RaN9m004Kp(cert, target9(_003C_003Ep__9, _003C_003Eo__18._003C_003Ep__24.Target(_003C_003Eo__18._003C_003Ep__24, objCol.GetValue(4))));
						num2 = 32;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf == 0)
						{
							num2 = 18;
						}
						break;
					}
					case 97:
					{
						if (_003C_003Eo__18._003C_003Ep__27 == null)
						{
							_003C_003Eo__18._003C_003Ep__27 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.None, typeof(string), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
						}
						Func<CallSite, object, string> target18 = _003C_003Eo__18._003C_003Ep__27.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__18 = _003C_003Eo__18._003C_003Ep__27;
						if (_003C_003Eo__18._003C_003Ep__26 == null)
						{
							_003C_003Eo__18._003C_003Ep__26 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-566078848 ^ -566042502), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags.None, null) }));
						}
						J18uadDvSjr7VpAwvvU(cert, target18(_003C_003Ep__18, _003C_003Eo__18._003C_003Ep__26.Target(_003C_003Eo__18._003C_003Ep__26, objCol.GetValue(4))));
						num2 = 101;
						break;
					}
					case 114:
					case 126:
					{
						if (_003C_003Eo__18._003C_003Ep__29 == null)
						{
							_003C_003Eo__18._003C_003Ep__29 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.None, typeof(string), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
						}
						Func<CallSite, object, string> target6 = _003C_003Eo__18._003C_003Ep__29.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__6 = _003C_003Eo__18._003C_003Ep__29;
						if (_003C_003Eo__18._003C_003Ep__28 == null)
						{
							_003C_003Eo__18._003C_003Ep__28 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x432996D0 ^ 0x4329242A), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags.None, null) }));
						}
						Xli6lrDCUARkftuWdPe(cert, target6(_003C_003Ep__6, _003C_003Eo__18._003C_003Ep__28.Target(_003C_003Eo__18._003C_003Ep__28, objCol.GetValue(4))));
						num2 = 120;
						break;
					}
					case 39:
					case 76:
					{
						if (_003C_003Eo__18._003C_003Ep__31 == null)
						{
							_003C_003Eo__18._003C_003Ep__31 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.None, plyZeEDNEgec2vdL9PG(typeof(string).TypeHandle), typeof(CertificationAuthorityManager)));
						}
						Func<CallSite, object, string> target4 = _003C_003Eo__18._003C_003Ep__31.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__4 = _003C_003Eo__18._003C_003Ep__31;
						if (_003C_003Eo__18._003C_003Ep__30 == null)
						{
							_003C_003Eo__18._003C_003Ep__30 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x38328F00 ^ 0x38323DFA), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags.None, null) }));
						}
						cert.PublicKeyAlgorithm = target4(_003C_003Ep__4, _003C_003Eo__18._003C_003Ep__30.Target(_003C_003Eo__18._003C_003Ep__30, objCol.GetValue(4)));
						num2 = 51;
						break;
					}
					case 136:
					{
						if (_003C_003Eo__18._003C_003Ep__33 == null)
						{
							_003C_003Eo__18._003C_003Ep__33 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, plyZeEDNEgec2vdL9PG(typeof(string).TypeHandle), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
						}
						Func<CallSite, object, string> target15 = _003C_003Eo__18._003C_003Ep__33.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__15 = _003C_003Eo__18._003C_003Ep__33;
						if (_003C_003Eo__18._003C_003Ep__32 == null)
						{
							_003C_003Eo__18._003C_003Ep__32 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x71BC7C31 ^ 0x71BCCECB), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { CSharpArgumentInfo.Create(CSharpArgumentInfoFlags.None, null) }));
						}
						yBRD1dDU21dpl3tyDWL(cert, target15(_003C_003Ep__15, _003C_003Eo__18._003C_003Ep__32.Target(_003C_003Eo__18._003C_003Ep__32, objCol.GetValue(4))));
						num2 = 140;
						break;
					}
					case 77:
					case 110:
					{
						if (_003C_003Eo__18._003C_003Ep__35 == null)
						{
							_003C_003Eo__18._003C_003Ep__35 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.None, plyZeEDNEgec2vdL9PG(typeof(string).TypeHandle), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
						}
						Func<CallSite, object, string> target3 = _003C_003Eo__18._003C_003Ep__35.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__3 = _003C_003Eo__18._003C_003Ep__35;
						if (_003C_003Eo__18._003C_003Ep__34 == null)
						{
							_003C_003Eo__18._003C_003Ep__34 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string)VAW31CDnJoQU022xZOF(0x78610A3D ^ 0x7861B8C7), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags.None, null) }));
						}
						cert.RawPublicKey = target3(_003C_003Ep__3, _003C_003Eo__18._003C_003Ep__34.Target(_003C_003Eo__18._003C_003Ep__34, objCol.GetValue(4)));
						num2 = 83;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_615d1cac86f847c090f528929d6310c2 != 0)
						{
							num2 = 5;
						}
						break;
					}
					case 78:
					{
						if (_003C_003Eo__18._003C_003Ep__37 == null)
						{
							_003C_003Eo__18._003C_003Ep__37 = CallSite<Func<CallSite, object, string>>.Create((CallSiteBinder)CWVveNDZDuDhRic3D4n(CSharpBinderFlags.None, plyZeEDNEgec2vdL9PG(typeof(string).TypeHandle), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
						}
						Func<CallSite, object, string> target5 = _003C_003Eo__18._003C_003Ep__37.Target;
						CallSite<Func<CallSite, object, string>> _003C_003Ep__5 = _003C_003Eo__18._003C_003Ep__37;
						if (_003C_003Eo__18._003C_003Ep__36 == null)
						{
							_003C_003Eo__18._003C_003Ep__36 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string)VAW31CDnJoQU022xZOF(0x271B34E4 ^ 0x271B861E), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags.None, null) }));
						}
						cert.SurName = target5(_003C_003Ep__5, _003C_003Eo__18._003C_003Ep__36.Target(_003C_003Eo__18._003C_003Ep__36, objCol.GetValue(4)));
						num3 = 27;
						goto IL_0048;
					}
					case 57:
					case 89:
						{
							if (_003C_003Eo__18._003C_003Ep__39 == null)
							{
								_003C_003Eo__18._003C_003Ep__39 = CallSite<Func<CallSite, object, string>>.Create(Binder.Convert(CSharpBinderFlags.None, plyZeEDNEgec2vdL9PG(typeof(string).TypeHandle), plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle)));
							}
							Func<CallSite, object, string> target = _003C_003Eo__18._003C_003Ep__39.Target;
							CallSite<Func<CallSite, object, string>> _003C_003Ep__ = _003C_003Eo__18._003C_003Ep__39;
							if (_003C_003Eo__18._003C_003Ep__38 == null)
							{
								_003C_003Eo__18._003C_003Ep__38 = CallSite<Func<CallSite, object, object>>.Create(Binder.InvokeMember(CSharpBinderFlags.None, (string)VAW31CDnJoQU022xZOF(-1788380826 ^ -1788359780), null, plyZeEDNEgec2vdL9PG(typeof(CertificationAuthorityManager).TypeHandle), new CSharpArgumentInfo[1] { (CSharpArgumentInfo)haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags.None, null) }));
							}
							TcIHX6Dombk4Efxvb7h(cert, target(_003C_003Ep__, _003C_003Eo__18._003C_003Ep__38.Target(_003C_003Eo__18._003C_003Ep__38, objCol.GetValue(4))));
							num2 = 41;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b == 0)
							{
								num2 = 85;
							}
							break;
						}
						IL_0048:
						num2 = num3;
						break;
					}
				}
			}
			catch (Exception)
			{
				int num4 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc == 0)
				{
					num4 = 0;
				}
				switch (num4)
				{
				case 0:
					break;
				}
				break;
			}
		}
	}

	[IteratorStateMachine(typeof(_003CGetCertificates_003Ed__19))]
	public static IEnumerable<CertificateInfo> GetCertificates()
	{
		//yield-return decompiler failed: Missing enumeratorCtor.Body
		return new _003CGetCertificates_003Ed__19(-2);
	}

	public static CertificateInfo GetCertificateByThumbprint(string thumbprint)
	{
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass20_0 _003C_003Ec__DisplayClass20_ = default(_003C_003Ec__DisplayClass20_0);
		while (true)
		{
			switch (num2)
			{
			default:
				return GetCertificates().FirstOrDefault(_003C_003Ec__DisplayClass20_._003CGetCertificateByThumbprint_003Eb__0);
			case 2:
				_003C_003Ec__DisplayClass20_ = new _003C_003Ec__DisplayClass20_0();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass20_.thumbprint = thumbprint;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e0cdbab05b2b455cab94ec0ba1efc443 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public CertificationAuthorityManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		AHiYehDJfbgQcDDwlOq();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_bed74a20bc6648fab6800acd64e4559d != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static Type RO65mRDWwCCjbreuqTt(Guid P_0)
	{
		return Marshal.GetTypeFromCLSID(P_0);
	}

	internal static object p1eoudDXYdC5TB0m0Oo(Type P_0)
	{
		return Activator.CreateInstance(P_0);
	}

	internal static object VAW31CDnJoQU022xZOF(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void QibCQiDiJ98xYRvy9LV(object P_0)
	{
		((IX509CertificateRequestPkcs10)P_0).Encode();
	}

	internal static bool zSmGlsD5vMcaCJCQCMq()
	{
		return lKI12SDp5N8csS5Y5as == null;
	}

	internal static CertificationAuthorityManager lGU4I7DA48slbuZjwEI()
	{
		return lKI12SDp5N8csS5Y5as;
	}

	internal static object lLckZOD7fccIcwXtv7G()
	{
		return Encoding.UTF8;
	}

	internal static bool r6ZllsD6eOIs3cXBxit(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool aAqZRhDlkoxGOSTJ2Jv(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static Type plyZeEDNEgec2vdL9PG(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object CWVveNDZDuDhRic3D4n(CSharpBinderFlags P_0, Type P_1, Type P_2)
	{
		return Binder.Convert(P_0, P_1, P_2);
	}

	internal static void wfBvvVDxFn0wGykfbK2(object P_0, int value)
	{
		((CertificateInfo)P_0).RequestId = value;
	}

	internal static void Udib9bDBtam5PlDvwOX(object P_0, int value)
	{
		((CertificateInfo)P_0).RequestDisp = value;
	}

	internal static object haFXd2DuCxWBMUxZNjQ(CSharpArgumentInfoFlags P_0, object P_1)
	{
		return CSharpArgumentInfo.Create(P_0, (string)P_1);
	}

	internal static void xT9b4ZDmVcNxYLST4Ih(object P_0, DateTime value)
	{
		((CertificateInfo)P_0).NotBefore = value;
	}

	internal static void G6S0aoDeELMd6SnfOLs(object P_0, DateTime value)
	{
		((CertificateInfo)P_0).NotAfter = value;
	}

	internal static void gLZwPEDLsBV2bx1il70(object P_0, object P_1)
	{
		((CertificateInfo)P_0).GivenName = (string)P_1;
	}

	internal static void fEuBblDjOGmd2FNn6OH(object P_0, object P_1)
	{
		((CertificateInfo)P_0).CommonName = (string)P_1;
	}

	internal static void JMeeSeDHtCuGf1lFyW1(object P_0, object P_1)
	{
		((CertificateInfo)P_0).DistinguishedName = (string)P_1;
	}

	internal static void GJWphXDaaASih0wmndQ(object P_0, object P_1)
	{
		((CertificateInfo)P_0).SerialNumber = (string)P_1;
	}

	internal static void kK5xtYDR6gJv1GJo1r6(object P_0, object P_1)
	{
		((CertificateInfo)P_0).CertificateHash = (string)P_1;
	}

	internal static void x8qnRGDwaFrsxLyv5fM(object P_0, object P_1)
	{
		((CertificateInfo)P_0).Title = (string)P_1;
	}

	internal static void ibe4flD21cmj1p9Nmyu(object P_0, object P_1)
	{
		((CertificateInfo)P_0).DomainComponent = (string)P_1;
	}

	internal static void FHj6o9DP0RaN9m004Kp(object P_0, object P_1)
	{
		((CertificateInfo)P_0).Initials = (string)P_1;
	}

	internal static void J18uadDvSjr7VpAwvvU(object P_0, object P_1)
	{
		((CertificateInfo)P_0).OrgUnit = (string)P_1;
	}

	internal static void Xli6lrDCUARkftuWdPe(object P_0, object P_1)
	{
		((CertificateInfo)P_0).Organization = (string)P_1;
	}

	internal static void yBRD1dDU21dpl3tyDWL(object P_0, object P_1)
	{
		((CertificateInfo)P_0).PublicKeyLength = (string)P_1;
	}

	internal static void TcIHX6Dombk4Efxvb7h(object P_0, object P_1)
	{
		((CertificateInfo)P_0).UnstructuredName = (string)P_1;
	}

	internal static void AHiYehDJfbgQcDDwlOq()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
