using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Web;
using System.Xml;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Modules.Attributes;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Packaging.FileSystems;
using EleWise.ELMA.Serialization;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Rebranding;

public static class BrandResourceManager
{
	private class MemoryStreamDataSource : IStaticDataSource
	{
		private readonly object bytes;

		internal static object oC6oMDfyG8HSbmJWQe2E;

		public MemoryStreamDataSource(byte[] bytes)
		{
			//Discarded unreachable code: IL_002a, IL_002f
			SPpyoIfyQo5QEWXHQQBt();
			base._002Ector();
			int num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
			{
				num = 1;
			}
			while (true)
			{
				switch (num)
				{
				default:
					return;
				case 1:
					this.bytes = bytes;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
					{
						num = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}

		public Stream GetSource()
		{
			return (Stream)HhHm6cfyCjk6kVcxjunW(bytes, false);
		}

		internal static void SPpyoIfyQo5QEWXHQQBt()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool mU1pS3fyE3lIKkZyexRd()
		{
			return oC6oMDfyG8HSbmJWQe2E == null;
		}

		internal static MemoryStreamDataSource fYsJJdfyfGElLN93SUYL()
		{
			return (MemoryStreamDataSource)oC6oMDfyG8HSbmJWQe2E;
		}

		internal static object HhHm6cfyCjk6kVcxjunW(object P_0, bool writable)
		{
			return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
		}
	}

	private static bool _stringsInitialized;

	private static bool _imagesInitialized;

	private static bool _brandPackageInstalled;

	private static string _reourcesDirectory;

	private static Dictionary<string, Dictionary<string, string>> _localizedRebrandingDictionary;

	private static Dictionary<string, Bitmap> _rebrandingImages;

	private static Dictionary<string, Bitmap> _defaultImages;

	private static object _lockObject;

	private static BrandResourceManager SkDtKr2lZHYkgl1fKtG;

	static BrandResourceManager()
	{
		//Discarded unreachable code: IL_0106
		int num = 5;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object path;
				switch (num2)
				{
				default:
					if (MetadataAccessInfo.EnvironmentType != 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					path = Path.GetDirectoryName((string)pj5TXC2cDHQcXhjaVx8(Ixqq5p2shrenXn0cp4L(WqYm9N2U0JcSt4EMOgr())));
					goto IL_011f;
				case 5:
					w2R4yF25p9e4S6PXi0Y();
					num = 4;
					break;
				case 7:
					_rebrandingImages = new Dictionary<string, Bitmap>();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					_defaultImages = new Dictionary<string, Bitmap>();
					num = 3;
					break;
				case 3:
					_lockObject = new object();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return;
				case 4:
					_localizedRebrandingDictionary = new Dictionary<string, Dictionary<string, string>>();
					num2 = 7;
					continue;
				case 2:
					{
						path = P1SgFv2LuqqenwCSjki(brTeni2Y0TMr8yGPAxO(my7d6N2jwVCBXumxug7(typeof(SR).TypeHandle).Assembly));
						goto IL_011f;
					}
					IL_011f:
					_reourcesDirectory = Path.Combine((string)path, SR.GetSetting((string)ggyJMk2zqwfTfdn04wj(0xA592A41 ^ 0xA5937C7), (string)ggyJMk2zqwfTfdn04wj(0x571EA399 ^ 0x571EBE3B)));
					num2 = 6;
					continue;
				}
				break;
			}
		}
	}

	public static void InstallPackage(bool isDesigner = false)
	{
		//Discarded unreachable code: IL_00cd, IL_00dc, IL_01ad, IL_01bc, IL_01ec, IL_01fb, IL_0222, IL_022c, IL_0292, IL_02db, IL_0313, IL_0353, IL_0362, IL_036e, IL_037d, IL_03a8, IL_03bf, IL_03ce, IL_0428, IL_043b, IL_044a, IL_04fe, IL_0508, IL_0592, IL_05c8, IL_0609, IL_0641, IL_0660, IL_066f, IL_06bd, IL_06ed, IL_06fc, IL_0729, IL_0767, IL_0776, IL_0782, IL_0791, IL_07e8, IL_07fb, IL_080a, IL_08b3, IL_08fa, IL_092c, IL_0943, IL_0a4e, IL_0a8f, IL_0a9e
		int num = 12;
		int num2 = num;
		string text2 = default(string);
		_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_2 = default(_003C_003Ec__DisplayClass1_0);
		string[] source = default(string[]);
		string text = default(string);
		BrandPackageManifest brandPackageManifest = default(BrandPackageManifest);
		string text4 = default(string);
		_003C_003Ec__DisplayClass1_1 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_1);
		List<RebrendingImageManifest>.Enumerator enumerator2 = default(List<RebrendingImageManifest>.Enumerator);
		string text3 = default(string);
		RebrendingImageManifest current2 = default(RebrendingImageManifest);
		List<RebrendingLicenseStringsManifest>.Enumerator enumerator = default(List<RebrendingLicenseStringsManifest>.Enumerator);
		RebrendingLicenseStringsManifest current = default(RebrendingLicenseStringsManifest);
		RebrandingStrings rebrandingStrings = default(RebrandingStrings);
		CultureInfo cultureInfo = default(CultureInfo);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 39:
				text2 = (string)iohVoneo2bTO08knrla(_reourcesDirectory, _003C_003Ec__DisplayClass1_2.dirName);
				num2 = 24;
				break;
			case 37:
				_stringsInitialized = false;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			case 34:
				if (source.Any())
				{
					num2 = 41;
					break;
				}
				goto case 37;
			case 18:
				if (!Directory.Exists(text))
				{
					num2 = 15;
					break;
				}
				goto case 30;
			case 38:
				brandPackageManifest = ManifestBuilder.DeserializeByXmlFromFile<BrandPackageManifest>((string)iohVoneo2bTO08knrla(text2, ggyJMk2zqwfTfdn04wj(0x463A0F3C ^ 0x463A7F28)));
				num2 = 16;
				break;
			case 30:
				text4 = (string)X6eSyReI8F7lRKNX6xk(((HttpContext)OeZl6Reu2qSPdJbPG7M()).Server, "");
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 21;
				}
				break;
			case 9:
			case 14:
			case 15:
			case 33:
				_brandPackageInstalled = true;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num2 = 0;
				}
				break;
			case 32:
				_003C_003Ec__DisplayClass1_.srCultures = SR.GetCultureNames();
				num2 = 13;
				break;
			case 22:
				try
				{
					while (true)
					{
						int num13;
						if (!enumerator2.MoveNext())
						{
							num13 = 2;
							goto IL_0230;
						}
						goto IL_03d9;
						IL_0230:
						switch (num13)
						{
						case 1:
							try
							{
								FileStream fileStream2 = File.Open(Path.Combine(text3, current2.FileName), FileMode.Open, FileAccess.Read);
								int num14 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
								{
									num14 = 0;
								}
								switch (num14)
								{
								default:
									try
									{
										_rebrandingImages.Add((string)bWSTTle8eQLG7qS11Nr(current2), new Bitmap(fileStream2));
										int num15 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
										{
											num15 = 0;
										}
										switch (num15)
										{
										case 0:
											break;
										}
									}
									finally
									{
										int num16;
										if (fileStream2 == null)
										{
											num16 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
											{
												num16 = 0;
											}
											goto IL_0317;
										}
										goto IL_032d;
										IL_032d:
										m0ToGCeZIvtSRPdKeqQ(fileStream2);
										num16 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
										{
											num16 = 0;
										}
										goto IL_0317;
										IL_0317:
										switch (num16)
										{
										default:
											goto end_IL_02f2;
										case 2:
											break;
										case 1:
											goto end_IL_02f2;
										case 0:
											goto end_IL_02f2;
										}
										goto IL_032d;
										end_IL_02f2:;
									}
									break;
								case 1:
									break;
								}
							}
							catch
							{
								int num17 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
								{
									num17 = 0;
								}
								switch (num17)
								{
								case 0:
									break;
								}
							}
							break;
						case 3:
							goto IL_03d9;
						case 2:
							goto end_IL_024a;
						}
						continue;
						IL_03d9:
						current2 = enumerator2.Current;
						num13 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num13 = 1;
						}
						goto IL_0230;
						continue;
						end_IL_024a:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator2).Dispose();
					int num18 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num18 = 0;
					}
					switch (num18)
					{
					case 0:
						break;
					}
				}
				goto case 9;
			case 24:
				if (H8pumvebVpqmYCBfPKF(source.First(), text2))
				{
					num2 = 28;
					break;
				}
				goto case 1;
			case 29:
				if (!yNtA17eF8WNSCKyvwVv(text3))
				{
					num2 = 14;
					break;
				}
				goto case 6;
			case 25:
				text3 = (string)RdBPlYeGVArPEvIIrZ4(text2, ggyJMk2zqwfTfdn04wj(0x5DD55050 ^ 0x5DD5201E), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939406124));
				num2 = 7;
				break;
			case 19:
			case 20:
				source = (string[])bf2SAReWpTSFwIm3h9c(_reourcesDirectory, ggyJMk2zqwfTfdn04wj(-1108654032 ^ -1108662324));
				num2 = 34;
				break;
			case 28:
				_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_1();
				num2 = 38;
				break;
			case 42:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
							{
								num3 = 0;
							}
							goto IL_050c;
						}
						goto IL_07a9;
						IL_07a9:
						current = enumerator.Current;
						num3 = 3;
						goto IL_050c;
						IL_050c:
						while (true)
						{
							switch (num3)
							{
							case 4:
								try
								{
									FileStream fileStream = new FileStream((string)RdBPlYeGVArPEvIIrZ4(text2, ggyJMk2zqwfTfdn04wj(-398663332 ^ -398683880), QQkyPKehvv4DsEtIecx(current)), FileMode.Open, FileAccess.Read);
									int num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
									{
										num4 = 0;
									}
									switch (num4)
									{
									default:
										try
										{
											XmlReader xmlReader = (XmlReader)ilCt3leEn2uk8ZOVPNh(fileStream);
											int num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
											{
												num5 = 0;
											}
											switch (num5)
											{
											default:
												try
												{
													rebrandingStrings = (RebrandingStrings)ClassSerializationHelper.DeserializeObjectByXml(TypeOf<RebrandingStrings>.Raw, xmlReader, useComponentManager: false);
													int num6 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
													{
														num6 = 0;
													}
													switch (num6)
													{
													case 0:
														break;
													}
												}
												finally
												{
													int num7;
													if (xmlReader == null)
													{
														num7 = 1;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
														{
															num7 = 1;
														}
														goto IL_0645;
													}
													goto IL_067a;
													IL_067a:
													((IDisposable)xmlReader).Dispose();
													num7 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
													{
														num7 = 2;
													}
													goto IL_0645;
													IL_0645:
													switch (num7)
													{
													case 1:
														goto end_IL_0620;
													case 2:
														goto end_IL_0620;
													}
													goto IL_067a;
													end_IL_0620:;
												}
												break;
											}
										}
										finally
										{
											int num8;
											if (fileStream == null)
											{
												num8 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
												{
													num8 = 1;
												}
												goto IL_06c1;
											}
											goto IL_06d7;
											IL_06d7:
											((IDisposable)fileStream).Dispose();
											num8 = 2;
											goto IL_06c1;
											IL_06c1:
											switch (num8)
											{
											case 1:
												goto end_IL_069c;
											case 2:
												goto end_IL_069c;
											}
											goto IL_06d7;
											end_IL_069c:;
										}
										break;
									}
								}
								finally
								{
									int num9;
									if (rebrandingStrings == null)
									{
										num9 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
										{
											num9 = 0;
										}
										goto IL_072d;
									}
									goto IL_0743;
									IL_0743:
									_003C_003Ec__DisplayClass1_.rebrandingDictionary.Add((string)VD9c6UefXTLls1I9r5f(current), rebrandingStrings);
									num9 = 2;
									goto IL_072d;
									IL_072d:
									switch (num9)
									{
									default:
										goto end_IL_0708;
									case 1:
										break;
									case 0:
										goto end_IL_0708;
									case 2:
										goto end_IL_0708;
									}
									goto IL_0743;
									end_IL_0708:;
								}
								break;
							case 3:
								rebrandingStrings = null;
								num3 = 4;
								continue;
							case 2:
								goto IL_07a9;
							case 1:
								goto end_IL_052a;
							}
							break;
						}
						continue;
						end_IL_052a:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num10 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num10 = 0;
					}
					switch (num10)
					{
					case 0:
						break;
					}
				}
				goto case 32;
			case 10:
				_stringsInitialized = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				num2 = 2;
				break;
			case 35:
			case 36:
				if (isDesigner)
				{
					num2 = 25;
					break;
				}
				goto case 8;
			case 8:
				text = (string)RdBPlYeGVArPEvIIrZ4(text2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16765271), ggyJMk2zqwfTfdn04wj(0x4EDCBA32 ^ 0x4EDCCA5E));
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 18;
				}
				break;
			case 11:
				if (_brandPackageInstalled)
				{
					num2 = 31;
					break;
				}
				if (yNtA17eF8WNSCKyvwVv(_reourcesDirectory))
				{
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 26;
			case 16:
				_003C_003Ec__DisplayClass1_.rebrandingDictionary = new Dictionary<string, RebrandingStrings>();
				num2 = 5;
				break;
			case 2:
				try
				{
					X2pchaeSDfqlAVhbZRS(text2, true);
					int num11 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num11 = 0;
					}
					switch (num11)
					{
					case 0:
						break;
					}
				}
				catch
				{
					int num12 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num12 = 0;
					}
					switch (num12)
					{
					case 0:
						break;
					}
				}
				goto case 10;
			case 13:
				((IEnumerable<DirectoryInfo>)aVSVAdeQyFuQ7lYA1kr(new DirectoryInfo(_reourcesDirectory))).Where(_003C_003Ec__DisplayClass1_2._003CInstallPackage_003Eb__0).ToList().ForEach(_003C_003Ec__DisplayClass1_._003CInstallPackage_003Eb__1);
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 == 0)
				{
					num2 = 23;
				}
				break;
			case 6:
				enumerator2 = brandPackageManifest.Images.GetEnumerator();
				num2 = 20;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
				{
					num2 = 22;
				}
				break;
			case 5:
				enumerator = brandPackageManifest.Strings.GetEnumerator();
				num2 = 42;
				break;
			case 7:
				if (brandPackageManifest.Images.Count <= 0)
				{
					num2 = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 12;
					}
					break;
				}
				goto case 29;
			case 23:
				if (_003C_003Ec__DisplayClass1_.rebrandingDictionary.ContainsKey((string)ggyJMk2zqwfTfdn04wj(0x61EC0CB8 ^ 0x61EC16FC)))
				{
					num2 = 4;
					break;
				}
				goto case 35;
			case 21:
				wsqHF9eVsy11gGrGMmR(text, text4);
				num2 = 9;
				break;
			case 17:
				if (_003C_003Ec__DisplayClass1_.rebrandingDictionary.ContainsKey(cultureInfo.Name))
				{
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 27;
					}
					break;
				}
				goto case 35;
			case 27:
				MY4mthevNoXb5FlLNyI(cultureInfo, _003C_003Ec__DisplayClass1_.rebrandingDictionary[(string)HxF7JXeCotpfEdnhlft(cultureInfo)]);
				num2 = 20;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 36;
				}
				break;
			case 26:
				a0qblEeBj7QokfcvsP9(_reourcesDirectory);
				num2 = 19;
				break;
			case 3:
				return;
			case 12:
				_003C_003Ec__DisplayClass1_2 = new _003C_003Ec__DisplayClass1_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 11;
				}
				break;
			case 31:
				return;
			case 40:
				if (cultureInfo == null)
				{
					num2 = 35;
					break;
				}
				goto case 17;
			case 0:
				return;
			case 41:
				_003C_003Ec__DisplayClass1_2.dirName = Guid.NewGuid().ToString((string)ggyJMk2zqwfTfdn04wj(0x4DC2B14D ^ 0x4DC2C143));
				num2 = 13;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 39;
				}
				break;
			case 4:
				cultureInfo = _003C_003Ec__DisplayClass1_.srCultures.FirstOrDefault((CultureInfo z) => _003C_003Ec.A1sOCPfypBQ0GDNBvr8d(_003C_003Ec.ibskJ7fyNfITecqOPiff(z), _003C_003Ec.jVRu08fy3Zfy4EPWidfi(0x1637C429 ^ 0x1637DE6D), StringComparison.InvariantCulture));
				num2 = 40;
				break;
			}
		}
	}

	public static string R(CultureInfo culture, string t)
	{
		//Discarded unreachable code: IL_00bf, IL_00ce, IL_00d9, IL_0110, IL_0198, IL_01a2, IL_01dc, IL_022f, IL_0242, IL_0271
		int num = 2;
		int num2 = num;
		Dictionary<string, string>.Enumerator enumerator = default(Dictionary<string, string>.Enumerator);
		CultureInfo cultureInfo = default(CultureInfo);
		KeyValuePair<string, string> current = default(KeyValuePair<string, string>);
		string result = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				obj = culture;
				if (obj == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 4:
				enumerator = _localizedRebrandingDictionary[(string)HxF7JXeCotpfEdnhlft(cultureInfo)].GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
				{
					num2 = 0;
				}
				continue;
			case 3:
				if (_stringsInitialized)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 7;
					}
					continue;
				}
				goto case 5;
			case 5:
			case 6:
				return t;
			default:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
							{
								num3 = 1;
							}
							goto IL_00dd;
						}
						goto IL_015c;
						IL_015c:
						current = enumerator.Current;
						num3 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num3 = 5;
						}
						goto IL_00dd;
						IL_00dd:
						while (true)
						{
							object obj2;
							switch (num3)
							{
							case 1:
								return t;
							case 7:
								return result;
							case 3:
							case 6:
								break;
							case 5:
								if (!OnOU04eR1XO8eJLy7nO(t, current.Key))
								{
									num3 = 6;
									continue;
								}
								goto case 4;
							default:
								goto IL_015c;
							case 8:
								obj2 = j5rI0aeqBwWFAbgwueQ(t, current.Key, current.Value);
								goto IL_01e7;
							case 4:
								if (current.Value.IsNullOrEmpty())
								{
									num3 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
									{
										num3 = 2;
									}
									continue;
								}
								goto case 8;
							case 2:
								{
									obj2 = t;
									goto IL_01e7;
								}
								IL_01e7:
								result = (string)obj2;
								num3 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
								{
									num3 = 7;
								}
								continue;
							}
							break;
						}
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			case 7:
				if (!_localizedRebrandingDictionary.ContainsKey(cultureInfo.Name))
				{
					num2 = 6;
					continue;
				}
				goto case 4;
			case 1:
				obj = Dm7t3DeiUWGxx06TnHF();
				break;
			}
			cultureInfo = (CultureInfo)obj;
			num2 = 3;
		}
	}

	public static Bitmap GetImage(string name)
	{
		//Discarded unreachable code: IL_0060, IL_00fb, IL_010a, IL_013c, IL_014b, IL_0156, IL_02cf, IL_02f5, IL_033c, IL_035b, IL_036a, IL_0397, IL_03cc, IL_03db, IL_046c, IL_048b, IL_04b7, IL_04c6, IL_04d5
		int num = 7;
		object lockObject = default(object);
		bool lockTaken = default(bool);
		IList<BrandResourceAttribute> attributes = default(IList<BrandResourceAttribute>);
		Assembly assembly = default(Assembly);
		int num4 = default(int);
		Assembly[] array = default(Assembly[]);
		IEnumerator<BrandResourceAttribute> enumerator = default(IEnumerator<BrandResourceAttribute>);
		string key = default(string);
		BrandResourceAttribute current = default(BrandResourceAttribute);
		Bitmap bitmap = default(Bitmap);
		Type type = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					try
					{
						Monitor.Enter(lockObject, ref lockTaken);
						int num3 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num3 = 6;
						}
						while (true)
						{
							switch (num3)
							{
							case 6:
								if (_imagesInitialized)
								{
									num3 = 8;
									continue;
								}
								goto case 4;
							default:
								attributes = AttributeHelper<BrandResourceAttribute>.GetAttributes(assembly);
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
								{
									num3 = 11;
								}
								continue;
							case 5:
							case 7:
								if (num4 < array.Length)
								{
									num3 = 13;
									continue;
								}
								goto case 2;
							case 4:
								array = (Assembly[])imIjhReKaMU75bt4BKk();
								num3 = 12;
								continue;
							case 14:
								num4++;
								num3 = 5;
								continue;
							case 1:
								try
								{
									while (true)
									{
										int num5;
										if (!vBFkBde13rE4h5R2B1a(enumerator))
										{
											num5 = 3;
											goto IL_015a;
										}
										goto IL_0303;
										IL_015a:
										while (true)
										{
											switch (num5)
											{
											case 1:
												key = (string)G7VEMZePawcArZ34mso(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70023921), RXKdHheedu2cfGmrYxw(current), HobP9seObe19NKtMnFh(current));
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
												{
													num5 = 0;
												}
												continue;
											case 5:
											case 8:
											case 9:
												break;
											case 2:
												if (bitmap != null)
												{
													num5 = 11;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
													{
														num5 = 0;
													}
													continue;
												}
												break;
											default:
												if (_defaultImages.ContainsKey(key))
												{
													num5 = 8;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
													{
														num5 = 7;
													}
													continue;
												}
												goto case 2;
											case 10:
												type = oJEUMweTkMnC3yr4Dpv(assembly, current.ResourceFullName);
												num5 = 6;
												continue;
											case 7:
												bitmap = YMctBNe2JBTYTivb9dX((ResourceManager)wiei8YenNY1kURKrJf8(type.GetProperty((string)ggyJMk2zqwfTfdn04wj(-1767720453 ^ -1767716467), BindingFlags.Static | BindingFlags.Public | BindingFlags.NonPublic), null, null), HobP9seObe19NKtMnFh(current)) as Bitmap;
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
												{
													num5 = 1;
												}
												continue;
											case 11:
												_defaultImages.Add(key, bitmap);
												num5 = 7;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
												{
													num5 = 9;
												}
												continue;
											case 6:
												if (!G58PO7ek3aTcdZVMij2(type, null))
												{
													num5 = 5;
													continue;
												}
												goto case 7;
											case 4:
												goto IL_0303;
											case 3:
												goto end_IL_01d3;
											}
											break;
										}
										continue;
										IL_0303:
										current = enumerator.Current;
										num5 = 10;
										goto IL_015a;
										continue;
										end_IL_01d3:
										break;
									}
								}
								finally
								{
									int num6;
									if (enumerator == null)
									{
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
										{
											num6 = 0;
										}
										goto IL_0340;
									}
									goto IL_0375;
									IL_0375:
									m0ToGCeZIvtSRPdKeqQ(enumerator);
									num6 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
									{
										num6 = 1;
									}
									goto IL_0340;
									IL_0340:
									switch (num6)
									{
									default:
										goto end_IL_031b;
									case 0:
										goto end_IL_031b;
									case 2:
										break;
									case 1:
										goto end_IL_031b;
									}
									goto IL_0375;
									end_IL_031b:;
								}
								goto case 14;
							case 2:
								_imagesInitialized = true;
								num3 = 9;
								continue;
							case 11:
								if (fh1idieXy2LhyaTnaEJ(attributes) != 0)
								{
									num3 = 10;
									continue;
								}
								goto case 14;
							case 8:
								break;
							case 12:
								num4 = 0;
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
								{
									num3 = 7;
								}
								continue;
							case 10:
								enumerator = attributes.GetEnumerator();
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
								{
									num3 = 1;
								}
								continue;
							case 3:
							case 13:
								assembly = array[num4];
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
								{
									num3 = 0;
								}
								continue;
							case 9:
								break;
							}
							break;
						}
					}
					finally
					{
						int num7;
						if (!lockTaken)
						{
							num7 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
							{
								num7 = 1;
							}
							goto IL_0470;
						}
						goto IL_0495;
						IL_0495:
						GQuBgmeNddcY4BHwfI8(lockObject);
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num7 = 0;
						}
						goto IL_0470;
						IL_0470:
						switch (num7)
						{
						default:
							goto end_IL_044b;
						case 1:
							goto end_IL_044b;
						case 2:
							break;
						case 0:
							goto end_IL_044b;
						}
						goto IL_0495;
						end_IL_044b:;
					}
					goto case 2;
				case 6:
					lockObject = _lockObject;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					if (!_imagesInitialized)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 2;
				case 5:
					return _defaultImages[name];
				case 1:
					return _rebrandingImages[name];
				case 3:
					if (!_defaultImages.ContainsKey(name))
					{
						return null;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 5;
					}
					continue;
				case 2:
					if (!_rebrandingImages.ContainsKey(name))
					{
						num2 = 3;
						continue;
					}
					goto case 1;
				}
				break;
			}
			lockTaken = false;
			num = 4;
		}
	}

	private static void AddLocalizedReplaceDictionary(object culture, object rebrandCulture)
	{
		//Discarded unreachable code: IL_00ac, IL_00bb, IL_00c6, IL_0104, IL_019a, IL_01ad, IL_01e9, IL_01f8
		int num = 7;
		int num2 = num;
		List<RebrandingStrings.RebrandingString>.Enumerator enumerator = default(List<RebrandingStrings.RebrandingString>.Enumerator);
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		RebrandingStrings.RebrandingString current = default(RebrandingStrings.RebrandingString);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (w1858ie3YcmC3lg2dNC(((RebrandingStrings)rebrandCulture).Strings) > 0)
				{
					num2 = 5;
					continue;
				}
				goto case 4;
			case 5:
				enumerator = ((RebrandingStrings)rebrandCulture).Strings.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				continue;
			case 4:
				if (yeTG2FeDWeRbL2N9243(dictionary) <= 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			case 1:
				return;
			case 3:
				return;
			default:
				try
				{
					while (true)
					{
						IL_010e:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 5;
							goto IL_00ca;
						}
						goto IL_00ec;
						IL_00ca:
						while (true)
						{
							switch (num3)
							{
							case 1:
								break;
							default:
								goto IL_010e;
							case 4:
								if (string.IsNullOrEmpty((string)sxSFDFepEjahpxMlrYQ(current)))
								{
									num3 = 3;
									continue;
								}
								goto case 2;
							case 2:
								dictionary.Add(current.Key, (string)qekRiJea6FOFNsDg7ni(current));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
								{
									num3 = 0;
								}
								continue;
							case 5:
								goto end_IL_010e;
							}
							break;
						}
						goto IL_00ec;
						IL_00ec:
						current = enumerator.Current;
						num3 = 4;
						goto IL_00ca;
						continue;
						end_IL_010e:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 4;
			case 7:
				dictionary = new Dictionary<string, string>();
				num2 = 6;
				continue;
			case 2:
				break;
			}
			_localizedRebrandingDictionary.Add((string)HxF7JXeCotpfEdnhlft(culture), dictionary);
			num2 = 3;
		}
	}

	private static void CopyFolderContents(object sourcePath, object destinationPath)
	{
		//Discarded unreachable code: IL_00c7, IL_00ec, IL_013e, IL_01d2, IL_01dc, IL_0236, IL_026b, IL_02cc, IL_02fe, IL_0315, IL_0324, IL_0366, IL_0375
		int num = 8;
		int num3 = default(int);
		string[] array = default(string[]);
		FileInfo fileInfo = default(FileInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				object obj3;
				switch (num2)
				{
				case 6:
					if (yNtA17eF8WNSCKyvwVv(destinationPath))
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 20;
				case 1:
					num3 = 0;
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 5;
					}
					continue;
				case 7:
					obj = TSPZaTewNV478f81S3S(sourcePath, ggyJMk2zqwfTfdn04wj(-1921202237 ^ -1921197899));
					goto IL_0397;
				case 17:
					if (!((string)destinationPath).EndsWith((string)ggyJMk2zqwfTfdn04wj(0x92F12D5 ^ 0x92F0DA3)))
					{
						num2 = 14;
						continue;
					}
					obj3 = destinationPath;
					break;
				case 12:
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 0;
					}
					continue;
				case 19:
				case 21:
				{
					string obj4 = array[num3];
					DirectoryInfo directoryInfo = new DirectoryInfo(obj4);
					CopyFolderContents(obj4, TSPZaTewNV478f81S3S(destinationPath, wUQHOPeHGHmGVNA8Mls(directoryInfo)));
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 14;
					}
					continue;
				}
				case 10:
					num3++;
					num2 = 15;
					continue;
				case 2:
				case 3:
					fileInfo = new FileInfo(array[num3]);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 1;
					}
					continue;
				case 14:
					obj3 = TSPZaTewNV478f81S3S(destinationPath, ggyJMk2zqwfTfdn04wj(-1876063057 ^ -1876061223));
					break;
				case 22:
					return;
				case 5:
					array = Directory.GetDirectories((string)sourcePath);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					if (!wSxNT9etovTH8o3eWEC(sourcePath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A53C28)))
					{
						goto end_IL_0012;
					}
					obj = sourcePath;
					goto IL_0397;
				default:
					if (num3 < array.Length)
					{
						num2 = 3;
						continue;
					}
					goto case 5;
				case 20:
					Directory.CreateDirectory((string)destinationPath);
					num2 = 9;
					continue;
				case 13:
				case 24:
					if (num3 < array.Length)
					{
						num2 = 19;
						continue;
					}
					return;
				case 4:
					try
					{
						RktfeGe6PmmR6kQ44fk(fileInfo, G7VEMZePawcArZ34mso(ggyJMk2zqwfTfdn04wj(-488881205 ^ -488885421), destinationPath, fileInfo.Name), true);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					catch
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 10;
				case 16:
					num3++;
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 24;
					}
					continue;
				case 9:
				case 23:
					array = (string[])K3bxJ7e4WMICEE2MoYi(sourcePath);
					num2 = 12;
					continue;
				case 11:
					if (!Directory.Exists((string)sourcePath))
					{
						num2 = 22;
						continue;
					}
					goto case 6;
				case 18:
					return;
					IL_0397:
					sourcePath = obj;
					num2 = 17;
					continue;
				}
				destinationPath = obj3;
				num2 = 11;
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	private static byte[] EvaluateFilesHashArray(IEnumerable<ZipEntry> entries, Func<ZipEntry, byte[]> extractContent)
	{
		List<ZipEntry> list = entries.Where(delegate(ZipEntry e)
		{
			int num = 3;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (_003C_003Ec.JiuxdYfyDu9kvhHdQhfO(e.get_Name(), _003C_003Ec.jVRu08fy3Zfy4EPWidfi(-787452571 ^ -787473039)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 4;
						}
						break;
					}
					goto IL_00e5;
				case 3:
					if (!_003C_003Ec.GWJd88fyaxgfStApssme(e))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
						{
							num2 = 2;
						}
						break;
					}
					goto IL_00e5;
				default:
					if (_003C_003Ec.JiuxdYfyDu9kvhHdQhfO(e.get_Name(), _003C_003Ec.jVRu08fy3Zfy4EPWidfi(-1217523399 ^ -1217503081)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto IL_00e5;
				case 1:
					return _003C_003Ec.JiuxdYfyDu9kvhHdQhfO(e.get_Name(), _003C_003Ec.jVRu08fy3Zfy4EPWidfi(-606654180 ^ -606650172));
				case 4:
					{
						if (_003C_003Ec.JiuxdYfyDu9kvhHdQhfO(_003C_003Ec.bkBXv1fyt6nlvPqgcaug(e), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE3AC0F)))
						{
							num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
							{
								num2 = 0;
							}
							break;
						}
						goto IL_00e5;
					}
					IL_00e5:
					return false;
				}
			}
		}).OrderBy((ZipEntry e) => (string)_003C_003Ec.bkBXv1fyt6nlvPqgcaug(e), StringComparer.Ordinal).ToList();
		using MemoryStream memoryStream = MemoryHelper.GetMemoryStream();
		foreach (ZipEntry item in list)
		{
			byte[] buffer = extractContent(item);
			byte[] array;
			using (SHA1 sHA = SHA1.Create())
			{
				array = sHA.ComputeHash(buffer);
			}
			memoryStream.Write(array, 0, array.Length);
		}
		return memoryStream.ToArray();
	}

	private static void WriteFileToZip(object zipStream, object filePath, object entryName)
	{
		//Discarded unreachable code: IL_011e, IL_0156, IL_0186, IL_0195, IL_01a1
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_0082: Expected O, but got Unknown
		//IL_0084: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		FileInfo fileInfo = default(FileInfo);
		ZipEntry val = default(ZipEntry);
		byte[] array = default(byte[]);
		FileStream fileStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 1:
				fileInfo = new FileInfo((string)filePath);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
			{
				ZipEntry val2 = new ZipEntry((string)entryName);
				M5WuwhexKYk54xDLix6((object)val2, jLF9UBe7dgympYXPjN3(fileInfo));
				kSOIete0BQ5kE7mwIwy((object)val2, fileInfo.Length);
				val = val2;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 3;
				}
				break;
			}
			case 8:
				wwLYvBeJEyjsQpBpFBf(zipStream);
				num2 = 6;
				break;
			default:
				entryName = U2Hhl5eAdEmlwNlIdM4(entryName);
				num2 = 7;
				break;
			case 4:
				array = new byte[4096];
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 1;
				}
				break;
			case 6:
				return;
			case 2:
				fileStream = (FileStream)S05qnJeyaNYeWbqGjCk(filePath);
				num2 = 5;
				break;
			case 5:
				try
				{
					B2dKtIeMnAOe4eEVIKX(fileStream, zipStream, array);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				finally
				{
					int num4;
					if (fileStream == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num4 = 1;
						}
						goto IL_015a;
					}
					goto IL_0170;
					IL_0170:
					m0ToGCeZIvtSRPdKeqQ(fileStream);
					num4 = 2;
					goto IL_015a;
					IL_015a:
					switch (num4)
					{
					case 1:
						goto end_IL_0135;
					case 2:
						goto end_IL_0135;
					}
					goto IL_0170;
					end_IL_0135:;
				}
				goto case 8;
			case 3:
				nT0yHjem6pwF0Bbc8eK(zipStream, val);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	private static void WriteDirectoryToZip(object zipStream, object path, object entryRootName)
	{
		//Discarded unreachable code: IL_017e, IL_01a6
		int num = 2;
		int num2 = num;
		DirectoryInfo[] array2 = default(DirectoryInfo[]);
		DirectoryInfo directoryInfo2 = default(DirectoryInfo);
		DirectoryInfo directoryInfo = default(DirectoryInfo);
		int num3 = default(int);
		FileInfo[] array = default(FileInfo[]);
		string text2 = default(string);
		string text = default(string);
		FileInfo fileInfo = default(FileInfo);
		while (true)
		{
			switch (num2)
			{
			case 12:
				array2 = (DirectoryInfo[])BgreNmegp96X0BwLr91(directoryInfo2);
				num2 = 11;
				break;
			case 18:
				directoryInfo = array2[num3];
				num2 = 7;
				break;
			case 6:
				array = (FileInfo[])oe8KTre9JXwrJHJXi6E(directoryInfo2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C534855));
				num2 = 13;
				break;
			case 7:
				text2 = (string)G7VEMZePawcArZ34mso(ggyJMk2zqwfTfdn04wj(-138018305 ^ -137989839), entryRootName, wUQHOPeHGHmGVNA8Mls(directoryInfo2));
				num2 = 3;
				break;
			case 14:
				text = (string)j4b13med3nD3HYZN791(ggyJMk2zqwfTfdn04wj(0x6A81B9B4 ^ 0x6A81C900), entryRootName, wUQHOPeHGHmGVNA8Mls(directoryInfo2), wUQHOPeHGHmGVNA8Mls(fileInfo));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 0;
				}
				break;
			case 11:
				num3 = 0;
				num2 = 15;
				break;
			case 13:
				num3 = 0;
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 16;
				}
				break;
			case 8:
				num3++;
				num2 = 17;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 9;
				}
				break;
			case 9:
				fileInfo = array[num3];
				num2 = 14;
				break;
			case 3:
				KR10NGe5JwWAIjkVSLn(zipStream, directoryInfo.FullName, text2);
				num2 = 10;
				break;
			default:
				wDoi0ier3xVKX3MGx2H(zipStream, eCcAjHelpwdqRV1lF99(fileInfo), text);
				num2 = 8;
				break;
			case 1:
				if (directoryInfo2.Exists)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 4;
					}
					break;
				}
				return;
			case 5:
			case 15:
				if (num3 >= array2.Length)
				{
					num2 = 4;
					break;
				}
				goto case 18;
			case 10:
				num3++;
				num2 = 5;
				break;
			case 4:
				return;
			case 2:
				directoryInfo2 = new DirectoryInfo((string)path);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
				{
					num2 = 1;
				}
				break;
			case 16:
			case 17:
				if (num3 >= array.Length)
				{
					num2 = 12;
					break;
				}
				goto case 9;
			}
		}
	}

	private static bool VerifySignature(object data, object csp, object signature)
	{
		//Discarded unreachable code: IL_0071, IL_00e7, IL_011f, IL_012e
		int num = 1;
		int num2 = num;
		SHA1Managed sHA1Managed = default(SHA1Managed);
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 1:
				sHA1Managed = new SHA1Managed();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				byte[] array = sHA1Managed.ComputeHash((byte[])data);
				int num3 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num3 = 1;
				}
				while (true)
				{
					switch (num3)
					{
					default:
						return result;
					case 0:
						return result;
					case 1:
						result = W04kZteYap3jkwtVJPH(csp, array, jmOVkEejQcMuDKA65ab(ggyJMk2zqwfTfdn04wj(0x3CE17B75 ^ 0x3CE10B95)), signature);
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
						{
							num3 = 0;
						}
						break;
					}
				}
			}
			finally
			{
				if (sHA1Managed != null)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num4 = 1;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							((IDisposable)sHA1Managed).Dispose();
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
							{
								num4 = 0;
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

	private static void WriteCertificate(Action<string, byte[]> addEntry, object cert, object entryName)
	{
		byte[] bytes = Encoding.ASCII.GetBytes(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217502763) + Convert.ToBase64String(((X509Certificate)cert).Export(X509ContentType.Cert)) + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A55276));
		addEntry((string)entryName, bytes);
	}

	private static void WriteSignatureItem(Action<string, byte[]> addEntry, object data, object csp, object entryName)
	{
		using SHA1Managed sHA1Managed = new SHA1Managed();
		byte[] rgbHash = sHA1Managed.ComputeHash((byte[])data);
		byte[] arg = ((RSACryptoServiceProvider)csp).SignHash(rgbHash, CryptoConfig.MapNameToOID(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x426442E3)));
		addEntry((string)entryName, arg);
	}

	private static void WriteSignatures(Action<string, byte[]> addEntry, object certRef, object manifestBytes, object resourcesBytes)
	{
		RSACryptoServiceProvider csp = (RSACryptoServiceProvider)((X509Certificate2)certRef).PrivateKey;
		string text = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE3ACE9), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3B36AB09 ^ 0x3B36DA67));
		WriteSignatureItem(addEntry, manifestBytes, csp, text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35999659));
		WriteSignatureItem(addEntry, resourcesBytes, csp, text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459578225));
		WriteCertificate(addEntry, certRef, text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BBC4E6));
	}

	private static void WriteSignatures(object file, object certRefs, object manifestBytes, object resourcesBytes)
	{
		int num = 1;
		int num2 = num;
		_003C_003Ec__DisplayClass13_0 _003C_003Ec__DisplayClass13_;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				_003C_003Ec__DisplayClass13_ = new _003C_003Ec__DisplayClass13_0();
				_003C_003Ec__DisplayClass13_.file = (ZipFile)file;
				WriteSignatures(delegate(string name, byte[] data)
				{
					int num3 = 1;
					int num4 = num3;
					string text = default(string);
					while (true)
					{
						switch (num4)
						{
						case 1:
							text = (string)_003C_003Ec__DisplayClass13_0.Mio6iKfy7DhOIhc41RBj(name);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
							{
								num4 = 0;
							}
							break;
						default:
							_003C_003Ec__DisplayClass13_0.jRRbcyfyx84XOrAbCOOF(_003C_003Ec__DisplayClass13_.file, new MemoryStreamDataSource(data), text);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
							{
								num4 = 2;
							}
							break;
						case 2:
							return;
						}
					}
				}, certRefs, manifestBytes, resourcesBytes);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public static void CreateBrandPackage(string manifestPath, string certPath, string psw)
	{
		//Discarded unreachable code: IL_003d, IL_0097, IL_00f4, IL_0152, IL_0192, IL_01a1, IL_01ad, IL_01bc
		int num = 1;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				if (!Cxw7CbeLyS8j9phrqLu(manifestPath))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 2:
				return;
			case 3:
				return;
			case 5:
				fileStream = File.Open(certPath, FileMode.Open, FileAccess.Read);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num2 = 6;
				}
				break;
			case 4:
				if (!File.Exists(certPath))
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 5;
				}
				break;
			case 6:
				try
				{
					X509Certificate2 x509Certificate = new X509Certificate2(fileStream.ReadAllBytes(), psw);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return;
						}
						FjVMtUeUXMCf279R0AE(manifestPath, x509Certificate);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num3 = 0;
						}
					}
				}
				finally
				{
					int num4;
					if (fileStream == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num4 = 0;
						}
						goto IL_0156;
					}
					goto IL_016c;
					IL_016c:
					((IDisposable)fileStream).Dispose();
					num4 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
					{
						num4 = 1;
					}
					goto IL_0156;
					IL_0156:
					switch (num4)
					{
					default:
						goto end_IL_0131;
					case 1:
						break;
					case 0:
						goto end_IL_0131;
					case 2:
						goto end_IL_0131;
					}
					goto IL_016c;
					end_IL_0131:;
				}
			}
		}
	}

	private static void VerifyFileResources(object manifestPath, object resSubFolder, IList<RebrendingLicenseStringsManifest> fileResources)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals0.manifestPath = (string)manifestPath;
		CS_0024_003C_003E8__locals0.resSubFolder = (string)resSubFolder;
		if (fileResources.Count == 0)
		{
			return;
		}
		foreach (RebrendingLicenseStringsManifest item in fileResources.Where((RebrendingLicenseStringsManifest res) => !_003C_003Ec__DisplayClass15_0.UZTpwAfydsad2TNmx1ly(_003C_003Ec__DisplayClass15_0.Y5axpbfy91AIPiFuDHMw(Path.GetDirectoryName(CS_0024_003C_003E8__locals0.manifestPath), CS_0024_003C_003E8__locals0.resSubFolder, _003C_003Ec__DisplayClass15_0.w1rKQufyJ5KpF344UMcW(res)))).ToList())
		{
			fileResources.Remove(item);
		}
	}

	public static void CreateBrandPackage(string manifestPath, X509Certificate2 cert)
	{
		//Discarded unreachable code: IL_0224, IL_0384, IL_03e2, IL_0422, IL_0431, IL_043d, IL_044c, IL_04b9, IL_04c8, IL_04d3, IL_0584, IL_0597, IL_05e9, IL_06ca, IL_06d9, IL_0710, IL_0723
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		int num = 6;
		_003C_003Ec__DisplayClass16_0 _003C_003Ec__DisplayClass16_ = default(_003C_003Ec__DisplayClass16_0);
		List<RebrendingImageManifest>.Enumerator enumerator = default(List<RebrendingImageManifest>.Enumerator);
		List<RebrendingImageManifest> list = default(List<RebrendingImageManifest>);
		_003C_003Ec__DisplayClass16_1 CS_0024_003C_003E8__locals0;
		FileStream fileStream = default(FileStream);
		byte[] array2 = default(byte[]);
		RebrendingImageManifest current2 = default(RebrendingImageManifest);
		RebrendingImageManifest current = default(RebrendingImageManifest);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					VerifyFileResources(_003C_003Ec__DisplayClass16_.manifestPath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70011063), _003C_003Ec__DisplayClass16_.manifest.Strings);
					num2 = 4;
					continue;
				case 3:
					if (Apoe6lesYY7Cortmf4v(_003C_003Ec__DisplayClass16_.manifest.Images) > 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					break;
				case 15:
					rsJK2HPBsS46gKoBuf9(_003C_003Ec__DisplayClass16_.brandPackagePath, new Action(_003C_003Ec__DisplayClass16_._003CCreateBrandPackage_003Eb__0));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					_003C_003Ec__DisplayClass16_.brandPackagePath = (string)iohVoneo2bTO08knrla(_003C_003Ec__DisplayClass16_.brandPackageDir, string.Format((string)ggyJMk2zqwfTfdn04wj(0x1FFEF86A ^ 0x1FFE8A60), _003C_003Ec__DisplayClass16_.manifest.Title, N54b1TPFRZj2lTNDiv1(_003C_003Ec__DisplayClass16_.manifest)));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 12;
					}
					continue;
				case 9:
					_003C_003Ec__DisplayClass16_.manifest = ManifestBuilder.DeserializeByXmlFromFile<BrandPackageManifest>(_003C_003Ec__DisplayClass16_.manifestPath);
					num2 = 17;
					continue;
				case 14:
					enumerator = list.GetEnumerator();
					num2 = 8;
					continue;
				case 2:
					_003C_003Ec__DisplayClass16_.brandPackageDir = (string)P1SgFv2LuqqenwCSjki(_003C_003Ec__DisplayClass16_.manifestPath);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 7;
					}
					continue;
				case 5:
					_003C_003Ec__DisplayClass16_.manifestPath = manifestPath;
					num2 = 9;
					continue;
				case 13:
					return;
				case 4:
					VerifyFileResources(_003C_003Ec__DisplayClass16_.manifestPath, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309643702), _003C_003Ec__DisplayClass16_.manifest.LicenseFiles);
					num2 = 3;
					continue;
				case 12:
					try
					{
						CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass16_1();
						int num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num8 = 0;
						}
						while (true)
						{
							switch (num8)
							{
							default:
								CS_0024_003C_003E8__locals0.zf = new ZipFile(fileStream);
								num8 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num8 = 1;
								}
								break;
							case 1:
								try
								{
									byte[] array = EvaluateFilesHashArray(((IEnumerable)CS_0024_003C_003E8__locals0.zf).OfType<ZipEntry>(), (ZipEntry e) => CS_0024_003C_003E8__locals0.zf.GetInputStream(e).ReadAllBytes());
									int num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
									{
										num9 = 1;
									}
									while (true)
									{
										switch (num9)
										{
										case 2:
											return;
										case 3:
										{
											t4Wu86PGiQ3AjFvRJoo(CS_0024_003C_003E8__locals0.zf);
											int num10 = 4;
											num9 = num10;
											break;
										}
										default:
											CS_0024_003C_003E8__locals0.zf.CommitUpdate();
											num9 = 2;
											break;
										case 1:
											array2 = (byte[])Dp5PivPhko43bbKknSQ(QKVomOPbSIHWiWgPmmW(CS_0024_003C_003E8__locals0.zf, LRYm93PornK2fSNONEV(CS_0024_003C_003E8__locals0.zf, ggyJMk2zqwfTfdn04wj(-3333094 ^ -3320818))));
											num9 = 3;
											break;
										case 4:
											t4FemEPEhWyxNctO937(CS_0024_003C_003E8__locals0.zf, cert, array2, array);
											num9 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
											{
												num9 = 0;
											}
											break;
										}
									}
								}
								finally
								{
									if (CS_0024_003C_003E8__locals0.zf != null)
									{
										int num11 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
										{
											num11 = 1;
										}
										while (true)
										{
											switch (num11)
											{
											case 1:
												((IDisposable)CS_0024_003C_003E8__locals0.zf).Dispose();
												num11 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
												{
													num11 = 0;
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
					}
					finally
					{
						int num12;
						if (fileStream == null)
						{
							num12 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
							{
								num12 = 1;
							}
							goto IL_03e6;
						}
						goto IL_03fc;
						IL_03fc:
						m0ToGCeZIvtSRPdKeqQ(fileStream);
						num12 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
						{
							num12 = 2;
						}
						goto IL_03e6;
						IL_03e6:
						switch (num12)
						{
						case 1:
							goto end_IL_03c1;
						case 2:
							goto end_IL_03c1;
						}
						goto IL_03fc;
						end_IL_03c1:;
					}
				case 17:
					list = new List<RebrendingImageManifest>();
					num2 = 11;
					continue;
				case 6:
					_003C_003Ec__DisplayClass16_ = new _003C_003Ec__DisplayClass16_0();
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 4;
					}
					continue;
				case 1:
					fileStream = (FileStream)SwijiqPWguAjlEuYKAP(_003C_003Ec__DisplayClass16_.brandPackagePath, FileMode.Open, FileAccess.ReadWrite);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc != 0)
					{
						num2 = 1;
					}
					continue;
				case 8:
					try
					{
						while (true)
						{
							int num6;
							if (!enumerator.MoveNext())
							{
								num6 = 3;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
								{
									num6 = 3;
								}
								goto IL_04d7;
							}
							goto IL_0535;
							IL_0535:
							current2 = enumerator.Current;
							num6 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
							{
								num6 = 0;
							}
							goto IL_04d7;
							IL_04d7:
							while (true)
							{
								switch (num6)
								{
								case 2:
									break;
								default:
									_003C_003Ec__DisplayClass16_.manifest.Images.Remove(current2);
									num6 = 2;
									continue;
								case 1:
									goto IL_0535;
								case 3:
									goto end_IL_04f1;
								}
								break;
							}
							continue;
							end_IL_04f1:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
					}
					break;
				case 16:
					break;
				default:
					enumerator = _003C_003Ec__DisplayClass16_.manifest.Images.GetEnumerator();
					num2 = 10;
					continue;
				case 10:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								goto IL_05f7;
							}
							goto IL_062f;
							IL_05f7:
							while (true)
							{
								switch (num3)
								{
								case 1:
								case 5:
									break;
								case 4:
									goto IL_062f;
								default:
									list.Add(current);
									num3 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
									{
										num3 = 1;
									}
									continue;
								case 3:
									if (Cxw7CbeLyS8j9phrqLu(kcClQ2ezpeZ3Tw5mlfM(P1SgFv2LuqqenwCSjki(_003C_003Ec__DisplayClass16_.manifestPath), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345424502), ggyJMk2zqwfTfdn04wj(-345420348 ^ -345424484), a2DCwmecnr2rWdnIER4(current))))
									{
										num3 = 3;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
										{
											num3 = 5;
										}
										continue;
									}
									goto default;
								case 2:
									goto end_IL_0619;
								}
								break;
							}
							continue;
							IL_062f:
							current = enumerator.Current;
							int num4 = 3;
							num3 = num4;
							goto IL_05f7;
							continue;
							end_IL_0619:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 14;
				}
				break;
			}
			ManifestBuilder.SerializeByXmlToFile<BrandPackageManifest>(_003C_003Ec__DisplayClass16_.manifest, _003C_003Ec__DisplayClass16_.manifestPath);
			num = 2;
		}
	}

	public static bool UnpackBrandPackage(string packagePath, string pathToUnpack)
	{
		//Discarded unreachable code: IL_0092, IL_00e5, IL_013e, IL_017e, IL_0189, IL_01b5, IL_02a2, IL_02b1, IL_02dc, IL_0358, IL_0367, IL_0377, IL_0386, IL_0468, IL_0550, IL_05a9, IL_05b8, IL_05c8, IL_05d7, IL_063c, IL_068a, IL_06a9, IL_06b8, IL_070b, IL_0743, IL_0752
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0078: Expected O, but got Unknown
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d9: Expected O, but got Unknown
		int num = 3;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		bool result = default(bool);
		FileStream fileStream2 = default(FileStream);
		_003C_003Ec__DisplayClass17_0 CS_0024_003C_003E8__locals0;
		ZipEntry entry = default(ZipEntry);
		string text = default(string);
		ZipEntry val3 = default(ZipEntry);
		ZipEntry val2 = default(ZipEntry);
		byte[] data = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (!File.Exists(packagePath))
				{
					num2 = 2;
					continue;
				}
				fileStream = (FileStream)SwijiqPWguAjlEuYKAP(packagePath, FileMode.Open, FileAccess.Read);
				num2 = 5;
				continue;
			case 2:
				return false;
			case 4:
				return result;
			default:
				try
				{
					bMXVRgP8PZSMUACLpay((object)new FastZip(), fileStream2, pathToUnpack, (Overwrite)2, null, null, null, true, false, false);
					int num10 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num10 = 0;
					}
					while (true)
					{
						switch (num10)
						{
						default:
							return result;
						case 0:
							return result;
						case 1:
							result = true;
							num10 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
							{
								num10 = 0;
							}
							break;
						}
					}
				}
				catch
				{
					int num11 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num11 = 0;
					}
					while (true)
					{
						switch (num11)
						{
						default:
							return result;
						case 0:
							return result;
						case 1:
							result = false;
							num11 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
							{
								num11 = 0;
							}
							break;
						}
					}
				}
				finally
				{
					int num12;
					if (fileStream2 == null)
					{
						num12 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
						{
							num12 = 1;
						}
						goto IL_0142;
					}
					goto IL_0158;
					IL_0158:
					m0ToGCeZIvtSRPdKeqQ(fileStream2);
					num12 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num12 = 0;
					}
					goto IL_0142;
					IL_0142:
					switch (num12)
					{
					default:
						goto end_IL_011d;
					case 2:
						break;
					case 1:
						goto end_IL_011d;
					case 0:
						goto end_IL_011d;
					}
					goto IL_0158;
					end_IL_011d:;
				}
			case 5:
				try
				{
					CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass17_0();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						default:
							CS_0024_003C_003E8__locals0.zf = new ZipFile(fileStream);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
							{
								num3 = 1;
							}
							continue;
						case 1:
							try
							{
								ZipEntry val = (ZipEntry)LRYm93PornK2fSNONEV(CS_0024_003C_003E8__locals0.zf, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309643352));
								int num4 = 6;
								while (true)
								{
									switch (num4)
									{
									default:
										return result;
									case 0:
										return result;
									case 15:
										return result;
									case 5:
										if (entry == null)
										{
											num4 = 5;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
											{
												num4 = 10;
											}
											continue;
										}
										goto case 14;
									case 4:
										result = false;
										num4 = 15;
										continue;
									case 7:
									case 13:
									{
										int num7 = 12;
										num4 = num7;
										continue;
									}
									case 11:
										entry = CS_0024_003C_003E8__locals0.zf.GetEntry(text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE10AF3));
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
										{
											num4 = 1;
										}
										continue;
									case 9:
									case 10:
									case 17:
										result = false;
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
										{
											num4 = 0;
										}
										continue;
									case 6:
										if (val != null)
										{
											num4 = 16;
											continue;
										}
										goto case 4;
									case 1:
										val3 = (ZipEntry)LRYm93PornK2fSNONEV(CS_0024_003C_003E8__locals0.zf, TSPZaTewNV478f81S3S(text, ggyJMk2zqwfTfdn04wj(-538519530 ^ -538531400)));
										num4 = 18;
										continue;
									case 18:
										val2 = (ZipEntry)LRYm93PornK2fSNONEV(CS_0024_003C_003E8__locals0.zf, TSPZaTewNV478f81S3S(text, ggyJMk2zqwfTfdn04wj(0x269E5FCA ^ 0x269E2E12)));
										num4 = 5;
										continue;
									case 3:
										text = (string)Nn2VMIPf5JjmWsD7Cmd(ggyJMk2zqwfTfdn04wj(0x1ECE530A ^ 0x1ECE2122), ggyJMk2zqwfTfdn04wj(-2112703338 ^ -2112698888));
										num4 = 11;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
										{
											num4 = 2;
										}
										continue;
									case 2:
										if (val2 != null)
										{
											num4 = 7;
											continue;
										}
										goto case 9;
									case 14:
										if (val3 == null)
										{
											num4 = 3;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
											{
												num4 = 17;
											}
											continue;
										}
										goto case 2;
									case 8:
									case 16:
										data = (byte[])Dp5PivPhko43bbKknSQ(QKVomOPbSIHWiWgPmmW(CS_0024_003C_003E8__locals0.zf, val));
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
										{
											num4 = 3;
										}
										continue;
									case 12:
										try
										{
											X509Certificate2 x509Certificate = new X509Certificate2((byte[])Dp5PivPhko43bbKknSQ(QKVomOPbSIHWiWgPmmW(CS_0024_003C_003E8__locals0.zf, val2)));
											byte[] signature = (byte[])Dp5PivPhko43bbKknSQ(CS_0024_003C_003E8__locals0.zf.GetInputStream(entry));
											byte[] array = (byte[])Dp5PivPhko43bbKknSQ(QKVomOPbSIHWiWgPmmW(CS_0024_003C_003E8__locals0.zf, val3));
											byte[] array2 = EvaluateFilesHashArray(((IEnumerable)CS_0024_003C_003E8__locals0.zf).OfType<ZipEntry>().Where(delegate(ZipEntry e)
											{
												//Discarded unreachable code: IL_0068, IL_0077
												int num13 = 1;
												int num14 = num13;
												while (true)
												{
													switch (num14)
													{
													case 1:
														if (_003C_003Ec.WekipFfywHN6nlXEORaU(_003C_003Ec.bkBXv1fyt6nlvPqgcaug(e), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7F437C)))
														{
															num14 = 0;
															if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
															{
																num14 = 0;
															}
															break;
														}
														goto case 2;
													case 2:
														return !_003C_003Ec.GWJd88fyaxgfStApssme(e);
													default:
														return false;
													}
												}
											}).ToArray(), (ZipEntry e) => (byte[])_003C_003Ec__DisplayClass17_0.UlQfrrfMv39v4rJVDviM(_003C_003Ec__DisplayClass17_0.TA4vyZfMC5CGFwbNcqpf(CS_0024_003C_003E8__locals0.zf, e)));
											RSACryptoServiceProvider rSACryptoServiceProvider = (RSACryptoServiceProvider)jRCuhdPCc7XXpUJfhOq(bTObFRPQNGxekniv5oC(x509Certificate));
											int num5 = 5;
											while (true)
											{
												switch (num5)
												{
												default:
													return result;
												case 0:
													return result;
												case 3:
													if (gkk1yAPvYXMMcFYiqlT(array2, rSACryptoServiceProvider, array))
													{
														num5 = 2;
														if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
														{
															num5 = 1;
														}
														continue;
													}
													break;
												case 2:
													goto end_IL_0554;
												case 5:
													if (!VerifySignature(data, rSACryptoServiceProvider, signature))
													{
														num5 = 4;
														continue;
													}
													goto case 3;
												case 1:
												case 4:
													break;
												case 6:
													goto end_IL_0554;
												}
												result = false;
												num5 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
												{
													num5 = 0;
												}
												continue;
												end_IL_0554:
												break;
											}
										}
										catch
										{
											int num6 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
											{
												num6 = 0;
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
													result = false;
													num6 = 0;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
													{
														num6 = 0;
													}
													break;
												}
											}
										}
										break;
									}
									break;
								}
							}
							finally
							{
								int num8;
								if (CS_0024_003C_003E8__locals0.zf == null)
								{
									num8 = 2;
									goto IL_068e;
								}
								goto IL_06c3;
								IL_068e:
								switch (num8)
								{
								case 2:
									goto end_IL_0674;
								case 1:
									goto end_IL_0674;
								}
								goto IL_06c3;
								IL_06c3:
								m0ToGCeZIvtSRPdKeqQ(CS_0024_003C_003E8__locals0.zf);
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
								{
									num8 = 1;
								}
								goto IL_068e;
								end_IL_0674:;
							}
							break;
						}
						break;
					}
				}
				finally
				{
					if (fileStream != null)
					{
						int num9 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num9 = 1;
						}
						while (true)
						{
							switch (num9)
							{
							case 1:
								m0ToGCeZIvtSRPdKeqQ(fileStream);
								num9 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
								{
									num9 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
				break;
			case 1:
				break;
			}
			fileStream2 = File.Open(packagePath, FileMode.Open, FileAccess.Read);
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
			{
				num2 = 0;
			}
		}
	}

	public static Stream GetBrandPackage()
	{
		//Discarded unreachable code: IL_0057, IL_0066
		int num = 3;
		int num2 = num;
		string[] source = default(string[]);
		while (true)
		{
			switch (num2)
			{
			case 3:
				source = (string[])bf2SAReWpTSFwIm3h9c(_reourcesDirectory, ggyJMk2zqwfTfdn04wj(0x26FFCB59 ^ 0x26FFA4A5));
				num2 = 2;
				break;
			case 2:
				if (!source.Any())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return new FileStream(source.First(), FileMode.Open, FileAccess.Read);
			case 1:
				return null;
			}
		}
	}

	internal static void w2R4yF25p9e4S6PXi0Y()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type my7d6N2jwVCBXumxug7(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object brTeni2Y0TMr8yGPAxO(object P_0)
	{
		return ((Assembly)P_0).Location;
	}

	internal static object P1SgFv2LuqqenwCSjki(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object WqYm9N2U0JcSt4EMOgr()
	{
		return AppDomain.CurrentDomain;
	}

	internal static object Ixqq5p2shrenXn0cp4L(object P_0)
	{
		return ((AppDomain)P_0).SetupInformation;
	}

	internal static object pj5TXC2cDHQcXhjaVx8(object P_0)
	{
		return ((AppDomainSetup)P_0).ConfigurationFile;
	}

	internal static object ggyJMk2zqwfTfdn04wj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool i6ESWb2rulBAGqKEYQQ()
	{
		return SkDtKr2lZHYkgl1fKtG == null;
	}

	internal static BrandResourceManager UtUkLl2gX9vN8BNK2fq()
	{
		return SkDtKr2lZHYkgl1fKtG;
	}

	internal static bool yNtA17eF8WNSCKyvwVv(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object a0qblEeBj7QokfcvsP9(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object bf2SAReWpTSFwIm3h9c(object P_0, object P_1)
	{
		return Directory.GetFiles((string)P_0, (string)P_1);
	}

	internal static object iohVoneo2bTO08knrla(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool H8pumvebVpqmYCBfPKF(object P_0, object P_1)
	{
		return UnpackBrandPackage((string)P_0, (string)P_1);
	}

	internal static object QQkyPKehvv4DsEtIecx(object P_0)
	{
		return ((RebrendingLicenseStringsManifest)P_0).FileName;
	}

	internal static object RdBPlYeGVArPEvIIrZ4(object P_0, object P_1, object P_2)
	{
		return Path.Combine((string)P_0, (string)P_1, (string)P_2);
	}

	internal static object ilCt3leEn2uk8ZOVPNh(object P_0)
	{
		return XmlReader.Create((Stream)P_0);
	}

	internal static object VD9c6UefXTLls1I9r5f(object P_0)
	{
		return ((RebrendingLicenseStringsManifest)P_0).Locale;
	}

	internal static object aVSVAdeQyFuQ7lYA1kr(object P_0)
	{
		return ((DirectoryInfo)P_0).GetDirectories();
	}

	internal static object HxF7JXeCotpfEdnhlft(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static void MY4mthevNoXb5FlLNyI(object P_0, object P_1)
	{
		AddLocalizedReplaceDictionary(P_0, P_1);
	}

	internal static object bWSTTle8eQLG7qS11Nr(object P_0)
	{
		return ((RebrendingImageManifest)P_0).FullName;
	}

	internal static void m0ToGCeZIvtSRPdKeqQ(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object OeZl6Reu2qSPdJbPG7M()
	{
		return HttpContext.Current;
	}

	internal static object X6eSyReI8F7lRKNX6xk(object P_0, object P_1)
	{
		return ((HttpServerUtility)P_0).MapPath((string)P_1);
	}

	internal static void wsqHF9eVsy11gGrGMmR(object P_0, object P_1)
	{
		CopyFolderContents(P_0, P_1);
	}

	internal static void X2pchaeSDfqlAVhbZRS(object P_0, bool P_1)
	{
		Directory.Delete((string)P_0, P_1);
	}

	internal static object Dm7t3DeiUWGxx06TnHF()
	{
		return SR.KeyCultureInfo;
	}

	internal static bool OnOU04eR1XO8eJLy7nO(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static object j5rI0aeqBwWFAbgwueQ(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object imIjhReKaMU75bt4BKk()
	{
		return ComponentManager.GetAssemblies();
	}

	internal static int fh1idieXy2LhyaTnaEJ(object P_0)
	{
		return ((ICollection<BrandResourceAttribute>)P_0).Count;
	}

	internal static Type oJEUMweTkMnC3yr4Dpv(object P_0, object P_1)
	{
		return ((Assembly)P_0).GetType((string)P_1);
	}

	internal static bool G58PO7ek3aTcdZVMij2(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object wiei8YenNY1kURKrJf8(object P_0, object P_1, object P_2)
	{
		return ((PropertyInfo)P_0).GetValue(P_1, (object[])P_2);
	}

	internal static object HobP9seObe19NKtMnFh(object P_0)
	{
		return ((BrandResourceAttribute)P_0).ResourceName;
	}

	internal static object YMctBNe2JBTYTivb9dX(object P_0, object P_1)
	{
		return ((ResourceManager)P_0).GetObject((string)P_1);
	}

	internal static object RXKdHheedu2cfGmrYxw(object P_0)
	{
		return ((BrandResourceAttribute)P_0).ResourceFullName;
	}

	internal static object G7VEMZePawcArZ34mso(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static bool vBFkBde13rE4h5R2B1a(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void GQuBgmeNddcY4BHwfI8(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static int w1858ie3YcmC3lg2dNC(object P_0)
	{
		return ((List<RebrandingStrings.RebrandingString>)P_0).Count;
	}

	internal static object sxSFDFepEjahpxMlrYQ(object P_0)
	{
		return ((RebrandingStrings.RebrandingString)P_0).Key;
	}

	internal static object qekRiJea6FOFNsDg7ni(object P_0)
	{
		return ((RebrandingStrings.RebrandingString)P_0).Value;
	}

	internal static int yeTG2FeDWeRbL2N9243(object P_0)
	{
		return ((Dictionary<string, string>)P_0).Count;
	}

	internal static bool wSxNT9etovTH8o3eWEC(object P_0, object P_1)
	{
		return ((string)P_0).EndsWith((string)P_1);
	}

	internal static object TSPZaTewNV478f81S3S(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object K3bxJ7e4WMICEE2MoYi(object P_0)
	{
		return Directory.GetFiles((string)P_0);
	}

	internal static object RktfeGe6PmmR6kQ44fk(object P_0, object P_1, bool P_2)
	{
		return ((FileInfo)P_0).CopyTo((string)P_1, P_2);
	}

	internal static object wUQHOPeHGHmGVNA8Mls(object P_0)
	{
		return ((FileSystemInfo)P_0).Name;
	}

	internal static object U2Hhl5eAdEmlwNlIdM4(object P_0)
	{
		return ZipEntry.CleanName((string)P_0);
	}

	internal static DateTime jLF9UBe7dgympYXPjN3(object P_0)
	{
		return ((FileSystemInfo)P_0).LastWriteTime;
	}

	internal static void M5WuwhexKYk54xDLix6(object P_0, DateTime P_1)
	{
		((ZipEntry)P_0).set_DateTime(P_1);
	}

	internal static void kSOIete0BQ5kE7mwIwy(object P_0, long P_1)
	{
		((ZipEntry)P_0).set_Size(P_1);
	}

	internal static void nT0yHjem6pwF0Bbc8eK(object P_0, object P_1)
	{
		((ZipOutputStream)P_0).PutNextEntry((ZipEntry)P_1);
	}

	internal static object S05qnJeyaNYeWbqGjCk(object P_0)
	{
		return File.OpenRead((string)P_0);
	}

	internal static void B2dKtIeMnAOe4eEVIKX(object P_0, object P_1, object P_2)
	{
		StreamUtils.Copy((Stream)P_0, (Stream)P_1, (byte[])P_2);
	}

	internal static void wwLYvBeJEyjsQpBpFBf(object P_0)
	{
		((ZipOutputStream)P_0).CloseEntry();
	}

	internal static object oe8KTre9JXwrJHJXi6E(object P_0, object P_1)
	{
		return ((DirectoryInfo)P_0).GetFiles((string)P_1);
	}

	internal static object j4b13med3nD3HYZN791(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object eCcAjHelpwdqRV1lF99(object P_0)
	{
		return ((FileSystemInfo)P_0).FullName;
	}

	internal static void wDoi0ier3xVKX3MGx2H(object P_0, object P_1, object P_2)
	{
		WriteFileToZip(P_0, P_1, P_2);
	}

	internal static object BgreNmegp96X0BwLr91(object P_0)
	{
		return ((DirectoryInfo)P_0).GetDirectories();
	}

	internal static void KR10NGe5JwWAIjkVSLn(object P_0, object P_1, object P_2)
	{
		WriteDirectoryToZip(P_0, P_1, P_2);
	}

	internal static object jmOVkEejQcMuDKA65ab(object P_0)
	{
		return CryptoConfig.MapNameToOID((string)P_0);
	}

	internal static bool W04kZteYap3jkwtVJPH(object P_0, object P_1, object P_2, object P_3)
	{
		return ((RSACryptoServiceProvider)P_0).VerifyHash((byte[])P_1, (string)P_2, (byte[])P_3);
	}

	internal static bool Cxw7CbeLyS8j9phrqLu(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static void FjVMtUeUXMCf279R0AE(object P_0, object P_1)
	{
		CreateBrandPackage((string)P_0, (X509Certificate2)P_1);
	}

	internal static int Apoe6lesYY7Cortmf4v(object P_0)
	{
		return ((List<RebrendingImageManifest>)P_0).Count;
	}

	internal static object a2DCwmecnr2rWdnIER4(object P_0)
	{
		return ((RebrendingImageManifest)P_0).FileName;
	}

	internal static object kcClQ2ezpeZ3Tw5mlfM(object P_0, object P_1, object P_2, object P_3)
	{
		return Path.Combine((string)P_0, (string)P_1, (string)P_2, (string)P_3);
	}

	internal static object N54b1TPFRZj2lTNDiv1(object P_0)
	{
		return ((BrandPackageManifest)P_0).Version;
	}

	internal static void rsJK2HPBsS46gKoBuf9(object P_0, object P_1)
	{
		FS.CreateFile((string)P_0, (Action)P_1);
	}

	internal static object SwijiqPWguAjlEuYKAP(object P_0, FileMode P_1, FileAccess P_2)
	{
		return File.Open((string)P_0, P_1, P_2);
	}

	internal static object LRYm93PornK2fSNONEV(object P_0, object P_1)
	{
		return ((ZipFile)P_0).GetEntry((string)P_1);
	}

	internal static object QKVomOPbSIHWiWgPmmW(object P_0, object P_1)
	{
		return ((ZipFile)P_0).GetInputStream((ZipEntry)P_1);
	}

	internal static object Dp5PivPhko43bbKknSQ(object P_0)
	{
		return ((Stream)P_0).ReadAllBytes();
	}

	internal static void t4Wu86PGiQ3AjFvRJoo(object P_0)
	{
		((ZipFile)P_0).BeginUpdate();
	}

	internal static void t4FemEPEhWyxNctO937(object P_0, object P_1, object P_2, object P_3)
	{
		WriteSignatures(P_0, P_1, P_2, P_3);
	}

	internal static object Nn2VMIPf5JjmWsD7Cmd(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object bTObFRPQNGxekniv5oC(object P_0)
	{
		return ((X509Certificate2)P_0).PublicKey;
	}

	internal static object jRCuhdPCc7XXpUJfhOq(object P_0)
	{
		return ((PublicKey)P_0).Key;
	}

	internal static bool gkk1yAPvYXMMcFYiqlT(object P_0, object P_1, object P_2)
	{
		return VerifySignature(P_0, P_1, P_2);
	}

	internal static void bMXVRgP8PZSMUACLpay(object P_0, object P_1, object P_2, Overwrite P_3, object P_4, object P_5, object P_6, bool P_7, bool P_8, bool P_9)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		((FastZip)P_0).ExtractZip((Stream)P_1, (string)P_2, P_3, (ConfirmOverwriteDelegate)P_4, (string)P_5, (string)P_6, P_7, P_8, P_9);
	}
}
