using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Pkcs;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using EleWise.ELMA.Files;
using EleWise.ELMA.Security.Extensions;
using EleWise.ELMA.Security.Models.Crypto;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Components;

public class CapiComCryptoProviderImpl : ICryptoProviderBase, ICryptoProviderBase2
{
	private CryptoProviderSettingsBase settings;

	public const string UID_S = "1810E4FB-EE34-437A-AAFC-8D213CBD7B88";

	private static CapiComCryptoProviderImpl sscPCy99oeqXOKtk5hS;

	public Guid ProviderUid => new Guid(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4D3A45F ^ 0x4D2ABD7));

	public string DisplayName => (string)k2uYsYfpOdCME70qq4U(oPlBdNfkysoB2RGw9E3(-192929954 ^ -192868214));

	public CryptoProviderSettingsBase Settings => settings;

	public CapiComCryptoProviderImpl(CryptoProviderSettingsBase settings)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		EBGTWW9zHA1UK0xPVFK();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_ae5d5c9fcc284404ba2e43f0c4ab8892 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.settings = settings;
			num = 1;
			if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
			{
				num = 1;
			}
		}
	}

	public IVerifyResult Verify(byte[] originalData, byte[] signedData, bool verifySignatureOnly)
	{
		return Verify(originalData, signedData, verifySignatureOnly, disableWarnings: false);
	}

	public IVerifyResult Verify(byte[] originalData, byte[] signedData, bool verifySignatureOnly, bool disableWarnings)
	{
		//Discarded unreachable code: IL_0066, IL_0144, IL_022d, IL_0278, IL_0287, IL_02e4, IL_02f3, IL_0303, IL_0312, IL_03fb, IL_0422, IL_0431, IL_050e, IL_0535, IL_0544, IL_0554, IL_05bf, IL_05ce, IL_05f0, IL_05ff, IL_060f, IL_06ab, IL_06fe, IL_0729, IL_076e, IL_077d
		int num = 1;
		int num2 = num;
		IVerifyResult result = default(IVerifyResult);
		X509Certificate2 x509Certificate = default(X509Certificate2);
		SignedCms signedCms = default(SignedCms);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return result;
			case 1:
				x509Certificate = null;
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0df0152125fa4e148590f3218518a41b != 0)
				{
					num2 = 0;
				}
				continue;
			}
			try
			{
				bool flag = false;
				int num3 = 9;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_2f11eccd7e8f4339a0b03ad9fe1eb947 == 0)
				{
					num3 = 3;
				}
				while (true)
				{
					switch (num3)
					{
					case 1:
						return result;
					case 16:
						return result;
					case 13:
						throw new CryptographicException((string)k2uYsYfpOdCME70qq4U(oPlBdNfkysoB2RGw9E3(0x78610A3D ^ 0x786005D1)));
					case 31:
						if (((Array)uWwQ3EfAw0pWGHVwaf0(signedCms.ContentInfo)).Length == 0)
						{
							num3 = 3;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
							{
								num3 = 3;
							}
							break;
						}
						goto case 21;
					case 2:
					case 33:
						iDaBg0fNx5HWp8xdcNw(signedCms, verifySignatureOnly);
						num3 = 34;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c != 0)
						{
							num3 = 6;
						}
						break;
					case 15:
						throw new CryptographicException((string)k2uYsYfpOdCME70qq4U(oPlBdNfkysoB2RGw9E3(0x6A336151 ^ 0x6A32715F)));
					case 26:
						if (((ContentInfo)XnbEsxfWtCqBD4VZ6fb(signedCms)).Content.Length == 0)
						{
							num3 = 5;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 != 0)
							{
								num3 = 4;
							}
							break;
						}
						goto case 14;
					case 22:
						if (x509Certificate != null)
						{
							num3 = 25;
							break;
						}
						goto default;
					case 4:
						if (verifySignatureOnly)
						{
							num3 = 33;
							break;
						}
						goto case 11;
					case 19:
						if (uWwQ3EfAw0pWGHVwaf0(signedCms.ContentInfo) != null)
						{
							num3 = 26;
							break;
						}
						goto case 5;
					case 9:
						signedCms = new SignedCms();
						num3 = 30;
						break;
					case 10:
						if (!disableWarnings)
						{
							num3 = 12;
							break;
						}
						goto case 4;
					case 17:
						if (uWwQ3EfAw0pWGHVwaf0(XnbEsxfWtCqBD4VZ6fb(signedCms)) != null)
						{
							num3 = 8;
							break;
						}
						goto case 35;
					case 21:
						if (signedCms.ContentInfo.Content.SequenceEqual(originalData))
						{
							num3 = 32;
							break;
						}
						goto case 3;
					case 23:
					case 29:
					case 32:
						text = "";
						num3 = 10;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8ec57fd3f43f4cf7983bc996ab09feb4 != 0)
						{
							num3 = 1;
						}
						break;
					default:
						throw new CryptographicException(SR.T((string)oPlBdNfkysoB2RGw9E3(-1586242415 ^ -1586311953)));
					case 25:
						if (flag)
						{
							num3 = 24;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
							{
								num3 = 10;
							}
							break;
						}
						goto case 23;
					case 18:
					case 20:
						if (K8RF44fXI8jOY4xOMIl(signedCms.SignerInfos) != 0)
						{
							if (K8RF44fXI8jOY4xOMIl(signedCms.SignerInfos) > 1)
							{
								num3 = 15;
								break;
							}
							x509Certificate = (X509Certificate2)P1qNRof7OH8SCA3e6vB(Ex03KrfiBojrfpt3BYS(OKxMeyfnpvJZr2Lfn6q(signedCms), 0));
							num3 = 22;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
							{
								num3 = 0;
							}
						}
						else
						{
							num3 = 13;
						}
						break;
					case 6:
						if (uWwQ3EfAw0pWGHVwaf0(signedCms.ContentInfo) != null)
						{
							num3 = 31;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f5cf5deab67c429f89caddff1f348afc != 0)
							{
								num3 = 29;
							}
							break;
						}
						goto case 3;
					case 35:
						if (originalData == null)
						{
							num3 = 23;
							break;
						}
						goto case 6;
					case 24:
						if (originalData == null)
						{
							num3 = 17;
							break;
						}
						goto case 35;
					case 36:
						try
						{
							int num4;
							if (Settings.Infos == null)
							{
								num4 = 2;
								goto IL_03ff;
							}
							goto IL_043f;
							IL_0490:
							x509Certificate.CheckRoot(Settings.Infos.Select((CertificationAuthorityInfo i) => (string)_003C_003Ec.YYmDRjpUT5lLvbqDJhf1(i)).ToArray());
							num4 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b6bf1b70a8924e789fc4be8e9aadc953 == 0)
							{
								num4 = 0;
							}
							goto IL_03ff;
							IL_043f:
							if (!Settings.Infos.Any(delegate(CertificationAuthorityInfo i)
							{
								//Discarded unreachable code: IL_004d, IL_005c
								int num7 = 2;
								int num8 = num7;
								while (true)
								{
									switch (num8)
									{
									case 2:
										if (i == null)
										{
											num8 = 1;
											if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_97ec140e839b4bd5a711912170945a29 != 0)
											{
												num8 = 1;
											}
											break;
										}
										goto default;
									default:
										return !_003C_003Ec.RrhFX4pUgE9xwNm1UuKr(_003C_003Ec.YYmDRjpUT5lLvbqDJhf1(i));
									case 1:
										return false;
									}
								}
							}))
							{
								num4 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_488725796a2e487f95c022f5056d8a88 != 0)
								{
									num4 = 0;
								}
								goto IL_03ff;
							}
							goto IL_0490;
							IL_03ff:
							switch (num4)
							{
							case 2:
								break;
							case 1:
								break;
							case 3:
								goto IL_043f;
							case 4:
								goto IL_0490;
							case 0:
								break;
							}
						}
						catch (Exception ex)
						{
							int num5 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
							{
								num5 = 0;
							}
							while (true)
							{
								switch (num5)
								{
								case 4:
									break;
								default:
									if (!verifySignatureOnly)
									{
										num5 = 1;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5c5fc9a9dec4418fa9513347a116bf27 == 0)
										{
											num5 = 1;
										}
										continue;
									}
									goto case 2;
								case 2:
									text = (string)ACXheeflwcW9NneReKG(text, oPlBdNfkysoB2RGw9E3(-426925384 ^ -426932670), ex.Message);
									num5 = 4;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 != 0)
									{
										num5 = 1;
									}
									continue;
								case 1:
								case 3:
									throw;
								}
								break;
							}
						}
						goto case 2;
					case 27:
						kQH25Of5UUJGMjfsU9d(signedCms, signedData);
						num3 = 20;
						break;
					case 3:
					case 7:
						result = (IVerifyResult)F00gTCf6PWKUkHCUf4w(x509Certificate, k2uYsYfpOdCME70qq4U(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-724676315 ^ -724614663)));
						num3 = 16;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1bc92e0376794fc182b6e366eee82dbd == 0)
						{
							num3 = 3;
						}
						break;
					case 11:
					case 12:
						num3 = 36;
						break;
					case 8:
						if (signedCms.ContentInfo.Content.Length == 0)
						{
							num3 = 35;
							break;
						}
						goto case 3;
					case 5:
					case 28:
						signedCms = new SignedCms(new ContentInfo(originalData), detached: true);
						num3 = 4;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_6e35a1cd804541a884550671c71dbb1c == 0)
						{
							num3 = 27;
						}
						break;
					case 30:
						kQH25Of5UUJGMjfsU9d(signedCms, signedData);
						num3 = 19;
						break;
					case 14:
						flag = true;
						num3 = 18;
						break;
					case 34:
						result = (IVerifyResult)TeYlKufZs6b7iVHW1Q1(x509Certificate, text);
						num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1c9893e65c104705bb8b228f8a38d9cd != 0)
						{
							num3 = 1;
						}
						break;
					}
				}
			}
			catch (Exception ex2)
			{
				int num6 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
				{
					num6 = 1;
				}
				while (true)
				{
					switch (num6)
					{
					default:
						return result;
					case 0:
						return result;
					case 1:
						result = (IVerifyResult)F00gTCf6PWKUkHCUf4w(x509Certificate, U13dy8fxjO70VGc5iaV(ex2));
						num6 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3b9996565fb40c18f26b204beedcb7f == 0)
						{
							num6 = 0;
						}
						break;
					}
				}
			}
		}
	}

	public string GetFileHash(BinaryFile file)
	{
		return GetFileHash(file, null);
	}

	public string GetFileHash(BinaryFile file, string algorithm)
	{
		//Discarded unreachable code: IL_0076, IL_00e1, IL_0123, IL_0132, IL_01c9, IL_0222, IL_0262, IL_0271, IL_027d, IL_028c, IL_0304, IL_0347, IL_0356
		int num = 9;
		int num2 = num;
		HashAlgorithm hashAlgorithm = default(HashAlgorithm);
		string text = default(string);
		Stream stream = default(Stream);
		string result = default(string);
		StringBuilder stringBuilder = default(StringBuilder);
		int num5 = default(int);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				hashAlgorithm = (HashAlgorithm)bOvmtifulL0FMgmNB4e(text);
				num2 = 4;
				continue;
			case 3:
				try
				{
					HashAlgorithm hashAlgorithm2 = hashAlgorithm;
					int num3 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_963eedaf34ef4c6cb3f0798bae513387 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							byte[] array = (byte[])XtTEnXfLkOj7kw96Snw(hashAlgorithm, stream);
							int num4 = 1;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_b54421a4e10b4c2fa10cef566e462fbd == 0)
							{
								num4 = 3;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									result = stringBuilder.ToString();
									num4 = 0;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_562220c988b04dea969b2dc6cde52015 == 0)
									{
										num4 = 0;
									}
									break;
								case 5:
									num5++;
									num4 = 2;
									break;
								case 6:
								case 7:
									stringBuilder.Append(array[num5].ToString((string)oPlBdNfkysoB2RGw9E3(0x4D765E72 ^ 0x4D774FC0)));
									num4 = 5;
									break;
								case 2:
								case 4:
									if (num5 < array.Length)
									{
										num4 = 2;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
										{
											num4 = 6;
										}
										break;
									}
									goto case 1;
								case 3:
								{
									num5 = 0;
									int num6 = 4;
									num4 = num6;
									break;
								}
								default:
									return result;
								case 0:
									return result;
								}
							}
						}
						finally
						{
							if (hashAlgorithm2 != null)
							{
								int num7 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2203cd019614c439eaf162fdd0eb05d == 0)
								{
									num7 = 0;
								}
								while (true)
								{
									switch (num7)
									{
									case 1:
										WpIYbefj5lfUcuQBgQH(hashAlgorithm2);
										num7 = 0;
										if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_66aae9daa3f84bb5931ed90b4759f85c == 0)
										{
											num7 = 0;
										}
										continue;
									case 0:
										break;
									}
									break;
								}
							}
						}
					}
				}
				finally
				{
					int num8;
					if (stream == null)
					{
						num8 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f == 0)
						{
							num8 = 0;
						}
						goto IL_0226;
					}
					goto IL_023c;
					IL_023c:
					WpIYbefj5lfUcuQBgQH(stream);
					num8 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_76accc62823f4af5a14c51746ed23095 == 0)
					{
						num8 = 1;
					}
					goto IL_0226;
					IL_0226:
					switch (num8)
					{
					default:
						goto end_IL_0201;
					case 2:
						break;
					case 0:
						goto end_IL_0201;
					case 1:
						goto end_IL_0201;
					}
					goto IL_023c;
					end_IL_0201:;
				}
			case 6:
				throw new Exception((string)d5TPEGfmGLRt4MSxcBR(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-426925384 ^ -426986524), new object[1] { text }));
			case 9:
				a0nO55fBPo6lsSTq151(file, oPlBdNfkysoB2RGw9E3(0x335D4787 ^ 0x335C56C3));
				num2 = 8;
				continue;
			case 5:
				obj = algorithm;
				break;
			case 1:
				return result;
			case 4:
				if (hashAlgorithm != null)
				{
					stringBuilder = new StringBuilder();
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_86eb143f59c14824a2785845ea23f248 == 0)
					{
						num2 = 7;
					}
				}
				else
				{
					num2 = 6;
				}
				continue;
			case 8:
				if (string.IsNullOrEmpty(algorithm))
				{
					num2 = 0;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 5;
			case 7:
				stream = (Stream)mhlp7Tfenm2KnsTX58u(file, GetContentOptions.NonSeekable);
				num2 = 3;
				continue;
			default:
				obj = oPlBdNfkysoB2RGw9E3(-714706387 ^ -714644611);
				break;
			}
			text = (string)obj;
			num2 = 2;
		}
	}

	internal static void EBGTWW9zHA1UK0xPVFK()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}

	internal static bool pUfRxw9f4OOgjy25OcU()
	{
		return sscPCy99oeqXOKtk5hS == null;
	}

	internal static CapiComCryptoProviderImpl o2iIi891C9YssR1D9WF()
	{
		return sscPCy99oeqXOKtk5hS;
	}

	internal static object oPlBdNfkysoB2RGw9E3(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object k2uYsYfpOdCME70qq4U(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static void kQH25Of5UUJGMjfsU9d(object P_0, object P_1)
	{
		((SignedCms)P_0).Decode((byte[])P_1);
	}

	internal static object uWwQ3EfAw0pWGHVwaf0(object P_0)
	{
		return ((ContentInfo)P_0).Content;
	}

	internal static object XnbEsxfWtCqBD4VZ6fb(object P_0)
	{
		return ((SignedCms)P_0).ContentInfo;
	}

	internal static int K8RF44fXI8jOY4xOMIl(object P_0)
	{
		return ((SignerInfoCollection)P_0).Count;
	}

	internal static object OKxMeyfnpvJZr2Lfn6q(object P_0)
	{
		return ((SignedCms)P_0).SignerInfos;
	}

	internal static object Ex03KrfiBojrfpt3BYS(object P_0, int P_1)
	{
		return ((SignerInfoCollection)P_0)[P_1];
	}

	internal static object P1qNRof7OH8SCA3e6vB(object P_0)
	{
		return ((SignerInfo)P_0).Certificate;
	}

	internal static object F00gTCf6PWKUkHCUf4w(object P_0, object P_1)
	{
		return VerifyResult.Fail((X509Certificate2)P_0, (string)P_1);
	}

	internal static object ACXheeflwcW9NneReKG(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void iDaBg0fNx5HWp8xdcNw(object P_0, bool P_1)
	{
		((SignedCms)P_0).CheckSignature(P_1);
	}

	internal static object TeYlKufZs6b7iVHW1Q1(object P_0, object P_1)
	{
		return VerifyResult.Success((X509Certificate2)P_0, (string)P_1);
	}

	internal static object U13dy8fxjO70VGc5iaV(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void a0nO55fBPo6lsSTq151(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object bOvmtifulL0FMgmNB4e(object P_0)
	{
		return HashAlgorithm.Create((string)P_0);
	}

	internal static object d5TPEGfmGLRt4MSxcBR(object P_0, object P_1)
	{
		return SR.T((string)P_0, (object[])P_1);
	}

	internal static object mhlp7Tfenm2KnsTX58u(object P_0, object P_1)
	{
		return ((BinaryFile)P_0).GetContent((GetContentOptions)P_1);
	}

	internal static object XtTEnXfLkOj7kw96Snw(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((Stream)P_1);
	}

	internal static void WpIYbefj5lfUcuQBgQH(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
