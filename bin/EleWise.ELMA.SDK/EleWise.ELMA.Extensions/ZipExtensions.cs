using System;
using System.IO;
using EleWise.ELMA.Memory;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class ZipExtensions
{
	internal static ZipExtensions kqGq88GHRa370o6VRXSv;

	public static byte[] Zip(this byte[] buffer, int level = 3)
	{
		//Discarded unreachable code: IL_0075, IL_00a9, IL_0219, IL_024d, IL_026c, IL_027b, IL_02b9, IL_02e9, IL_02f8, IL_0304, IL_0313
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_005b: Expected O, but got Unknown
		//IL_014c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0153: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		byte[] result = default(byte[]);
		ZipEntry val2 = default(ZipEntry);
		while (true)
		{
			switch (num2)
			{
			case 1:
				memoryStream = MemoryHelper.GetMemoryStream();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				ZipOutputStream val = new ZipOutputStream((Stream)sFOl64GHXljjuHVkNlaQ(memoryStream));
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					try
					{
						int defaultCodePage = ZipConstants.get_DefaultCodePage();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						default:
							try
							{
								etByw3GHT2JDOGS9kfFM(850);
								int num5 = 3;
								while (true)
								{
									switch (num5)
									{
									case 7:
										return result;
									case 8:
										result = memoryStream.ToArray();
										num5 = 7;
										break;
									case 3:
										piy0XqGHkHA92ekuR0GM(val, false);
										num5 = 5;
										break;
									default:
										RaeSvkGH1q8fQG4VUI1p(val);
										num5 = 8;
										break;
									case 6:
										val2 = new ZipEntry((string)cPWmODGHOBcZoolIyL2r(-1638402543 ^ -1638664717));
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
										{
											num5 = 1;
										}
										break;
									case 5:
									{
										fFGnTQGHnN9ltfLVqIFK(val, level);
										int num6 = 6;
										num5 = num6;
										break;
									}
									case 2:
										pVNbD0GHekSVHrpw4F2b(val, buffer, 0, buffer.Length);
										num5 = 9;
										break;
									case 4:
										SIiSrjGH2fsCYdYN0x5c(val, val2);
										num5 = 2;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
										{
											num5 = 2;
										}
										break;
									case 1:
										val2.set_DateTime(DateTime.MinValue);
										num5 = 4;
										break;
									case 9:
										LS1skgGHPANd5IoTOxut(val);
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
										{
											num5 = 0;
										}
										break;
									}
								}
							}
							finally
							{
								ZipConstants.set_DefaultCodePage(defaultCodePage);
								int num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
								{
									num7 = 0;
								}
								switch (num7)
								{
								case 0:
									break;
								}
							}
						}
					}
					finally
					{
						int num8;
						if (val == null)
						{
							num8 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
							{
								num8 = 0;
							}
							goto IL_0251;
						}
						goto IL_0286;
						IL_0286:
						((IDisposable)val).Dispose();
						num8 = 2;
						goto IL_0251;
						IL_0251:
						switch (num8)
						{
						case 1:
							goto end_IL_022c;
						case 2:
							goto end_IL_022c;
						}
						goto IL_0286;
						end_IL_022c:;
					}
				}
			}
			finally
			{
				int num9;
				if (memoryStream == null)
				{
					num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num9 = 0;
					}
					goto IL_02bd;
				}
				goto IL_02d3;
				IL_02d3:
				Y6lJbsGHNTPhvYhdSgoq(memoryStream);
				num9 = 2;
				goto IL_02bd;
				IL_02bd:
				switch (num9)
				{
				default:
					goto end_IL_0298;
				case 1:
					break;
				case 0:
					goto end_IL_0298;
				case 2:
					goto end_IL_0298;
				}
				goto IL_02d3;
				end_IL_0298:;
			}
		}
	}

	public static byte[] Unzip(this byte[] buffer)
	{
		//Discarded unreachable code: IL_006f, IL_00a3, IL_00da, IL_0144, IL_01ec, IL_0233, IL_0242, IL_0290, IL_02d0, IL_02df, IL_02eb, IL_02fa
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0055: Expected O, but got Unknown
		int num = 1;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		byte[] result = default(byte[]);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 1:
				memoryStream = (MemoryStream)v2ykIqGH3bK0W6Wn5HTZ(buffer, false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return result;
			}
			try
			{
				ZipInputStream val = new ZipInputStream((Stream)memoryStream);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num3 = 0;
				}
				switch (num3)
				{
				default:
					try
					{
						int defaultCodePage = ZipConstants.get_DefaultCodePage();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						default:
							try
							{
								etByw3GHT2JDOGS9kfFM(850);
								int num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
								{
									num5 = 0;
								}
								while (true)
								{
									switch (num5)
									{
									default:
										((InflaterInputStream)val).set_IsStreamOwner(false);
										num5 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
										{
											num5 = 4;
										}
										break;
									case 2:
										jba0bYGHtPGGVaOPMaDx(val, array, 0, array.Length);
										num5 = 5;
										break;
									case 5:
										result = array;
										num5 = 3;
										break;
									case 4:
										if (bRPiHYGHpf8xQdHFapGc(val) != null)
										{
											num5 = 1;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
											{
												num5 = 1;
											}
											break;
										}
										goto case 6;
									case 6:
										throw new InvalidOperationException((string)lpBceAGHa2xJoqCrw7mY(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97709122)));
									case 1:
										array = new byte[xVncK2GHDnjLDNXu4lHI(val)];
										num5 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
										{
											num5 = 2;
										}
										break;
									case 3:
										return result;
									}
								}
							}
							finally
							{
								ZipConstants.set_DefaultCodePage(defaultCodePage);
								int num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
								{
									num6 = 0;
								}
								switch (num6)
								{
								case 0:
									break;
								}
							}
						}
					}
					finally
					{
						int num8;
						if (val == null)
						{
							int num7 = 2;
							num8 = num7;
							goto IL_0218;
						}
						goto IL_024d;
						IL_0218:
						switch (num8)
						{
						default:
							goto end_IL_01ff;
						case 2:
							goto end_IL_01ff;
						case 1:
							break;
						case 0:
							goto end_IL_01ff;
						}
						goto IL_024d;
						IL_024d:
						((IDisposable)val).Dispose();
						num8 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num8 = 0;
						}
						goto IL_0218;
						end_IL_01ff:;
					}
				}
			}
			finally
			{
				int num9;
				if (memoryStream == null)
				{
					num9 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num9 = 0;
					}
					goto IL_0294;
				}
				goto IL_02aa;
				IL_02aa:
				((IDisposable)memoryStream).Dispose();
				num9 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
				{
					num9 = 2;
				}
				goto IL_0294;
				IL_0294:
				switch (num9)
				{
				default:
					goto end_IL_026f;
				case 1:
					break;
				case 0:
					goto end_IL_026f;
				case 2:
					goto end_IL_026f;
				}
				goto IL_02aa;
				end_IL_026f:;
			}
		}
	}

	internal static object sFOl64GHXljjuHVkNlaQ(object P_0)
	{
		return ((MemoryStream)P_0).AsNoClose();
	}

	internal static void etByw3GHT2JDOGS9kfFM(int P_0)
	{
		ZipConstants.set_DefaultCodePage(P_0);
	}

	internal static void piy0XqGHkHA92ekuR0GM(object P_0, bool P_1)
	{
		((DeflaterOutputStream)P_0).set_IsStreamOwner(P_1);
	}

	internal static void fFGnTQGHnN9ltfLVqIFK(object P_0, int P_1)
	{
		((ZipOutputStream)P_0).SetLevel(P_1);
	}

	internal static object cPWmODGHOBcZoolIyL2r(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void SIiSrjGH2fsCYdYN0x5c(object P_0, object P_1)
	{
		((ZipOutputStream)P_0).PutNextEntry((ZipEntry)P_1);
	}

	internal static void pVNbD0GHekSVHrpw4F2b(object P_0, object P_1, int P_2, int P_3)
	{
		((Stream)P_0).Write((byte[])P_1, P_2, P_3);
	}

	internal static void LS1skgGHPANd5IoTOxut(object P_0)
	{
		((ZipOutputStream)P_0).CloseEntry();
	}

	internal static void RaeSvkGH1q8fQG4VUI1p(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static void Y6lJbsGHNTPhvYhdSgoq(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool s83v0iGHqu4i5bFdfwYN()
	{
		return kqGq88GHRa370o6VRXSv == null;
	}

	internal static ZipExtensions XOfaVQGHKrUAklcqywgR()
	{
		return kqGq88GHRa370o6VRXSv;
	}

	internal static object v2ykIqGH3bK0W6Wn5HTZ(object P_0, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
	}

	internal static object bRPiHYGHpf8xQdHFapGc(object P_0)
	{
		return ((ZipInputStream)P_0).GetNextEntry();
	}

	internal static object lpBceAGHa2xJoqCrw7mY(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static long xVncK2GHDnjLDNXu4lHI(object P_0)
	{
		return ((Stream)P_0).Length;
	}

	internal static int jba0bYGHtPGGVaOPMaDx(object P_0, object P_1, int P_2, int P_3)
	{
		return ((Stream)P_0).Read((byte[])P_1, P_2, P_3);
	}
}
