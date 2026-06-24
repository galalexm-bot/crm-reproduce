using System;
using System.IO;
using EleWise.ELMA.ComponentModel;
using ICSharpCode.SharpZipLib.Zip;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services.Impl;

[Service]
internal class ZipService : IZipService, IZipStreamService
{
	internal static ZipService HMcCTFBMQEoxq3vRGpKF;

	public Exception CreateZipFolder(string zipFileName, string sourceDirectory)
	{
		return CreateZipFolder(zipFileName, sourceDirectory, recurse: true);
	}

	public Exception CreateZipFolder(string zipFileName, string sourceDirectory, bool recurse)
	{
		return CreateZipFolder(zipFileName, sourceDirectory, recurse, null, null);
	}

	public Exception CreateZipFolder(string zipFileName, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter)
	{
		//Discarded unreachable code: IL_010b, IL_0177, IL_0186, IL_0192, IL_01a1
		int num = 5;
		int num2 = num;
		FileStream fileStream = default(FileStream);
		Exception ex = default(Exception);
		while (true)
		{
			switch (num2)
			{
			case 1:
				THy6seBMZ8WcbjDJULp1(Directory.Exists(sourceDirectory), CASdLgBMu499sMh9UMj6(0x1637C429 ^ 0x1636AD45));
				num2 = 3;
				break;
			case 5:
				THy6seBMZ8WcbjDJULp1(!X29ZEWBM86VgsH8LQp8A(zipFileName), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-398663332 ^ -398620592));
				num2 = 4;
				break;
			case 4:
				Contract.CheckArgument(!X29ZEWBM86VgsH8LQp8A(sourceDirectory), (string)CASdLgBMu499sMh9UMj6(--1333735954 ^ 0x4F7E5B2A));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
				{
					num2 = 1;
				}
				break;
			default:
				return ex;
			case 3:
				fileStream = new FileStream(zipFileName, FileMode.OpenOrCreate);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				try
				{
					ex = CreateZipFolder(fileStream, sourceDirectory, recurse, fileFilter, directoryFilter);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => ex, 
						_ => ex, 
					};
				}
				finally
				{
					int num4;
					if (fileStream == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
						{
							num4 = 1;
						}
						goto IL_0147;
					}
					goto IL_015d;
					IL_015d:
					vTMNZbBMIgQKXtCPJgH7(fileStream);
					int num5 = 2;
					num4 = num5;
					goto IL_0147;
					IL_0147:
					switch (num4)
					{
					case 1:
						goto end_IL_0122;
					case 2:
						goto end_IL_0122;
					}
					goto IL_015d;
					end_IL_0122:;
				}
			}
		}
	}

	public Exception CreateZipFolder(Stream zipStream, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter)
	{
		//Discarded unreachable code: IL_0084, IL_00b7, IL_00ce, IL_00dd
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0041: Expected O, but got Unknown
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_005e: Expected O, but got Unknown
		//IL_006a: Expected O, but got Unknown
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return null;
			case 4:
				try
				{
					FastZip val = new FastZip();
					object obj = DQbSFZBMS4MQQLABqJ6u((object)val);
					ZipEntryFactory val2 = (ZipEntryFactory)((obj is ZipEntryFactory) ? obj : null);
					if (val2 != null)
					{
						PZpvGABMiYbjvAp8ZFM0(val2, true);
					}
					gnDlrTBMRayLdS8PTdew((object)val, true);
					xRYJwjBMqkNwoSSemBjk((object)val, zipStream, sourceDirectory, recurse, fileFilter, directoryFilter);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num4 = 0;
					}
					return num4 switch
					{
						0 => ex, 
						_ => ex, 
					};
				}
				goto case 1;
			default:
				Contract.CheckArgument(R34pemBMV9EGm47SwNgq(sourceDirectory), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42655B6F));
				num2 = 4;
				break;
			case 2:
				THy6seBMZ8WcbjDJULp1(!X29ZEWBM86VgsH8LQp8A(sourceDirectory), CASdLgBMu499sMh9UMj6(0x48A7E34A ^ 0x48A68A72));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				Contract.ArgumentNotNull(zipStream, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3C86D6));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public Exception CreateZipFolder(Stream zipStream, string sourceDirectory, bool recurse)
	{
		return CreateZipFolder(zipStream, sourceDirectory, recurse, null, null);
	}

	public Exception CreateZipFolder(Stream zipStream, string sourceDirectory)
	{
		return CreateZipFolder(zipStream, sourceDirectory, recurse: true);
	}

	public Exception ExtractZipFolder(string zipFileName, string targetDirectory)
	{
		return ExtractZipFolder(zipFileName, targetDirectory, null);
	}

	public Exception ExtractZipFolder(string zipFileName, string targetDirectory, string fileFilter)
	{
		int num = 3;
		int num2 = num;
		FileStream zipStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 1:
				zipStream = new FileStream(zipFileName, FileMode.Open);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return ExtractZipFolder(zipStream, targetDirectory, fileFilter);
			case 2:
				THy6seBMZ8WcbjDJULp1(!X29ZEWBM86VgsH8LQp8A(targetDirectory), CASdLgBMu499sMh9UMj6(-812025778 ^ -812117520));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				THy6seBMZ8WcbjDJULp1(!X29ZEWBM86VgsH8LQp8A(zipFileName), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335036669));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public Exception ExtractZipFolder(Stream zipStream, string targetDirectory, string fileFilter)
	{
		//Discarded unreachable code: IL_004a, IL_008e, IL_00c6, IL_0106, IL_0111, IL_0120, IL_014c, IL_0163, IL_0172
		//IL_0061: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				try
				{
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					default:
						try
						{
							KeAhhvBMX1YGG6P1Oxfn((object)new FastZip(), zipStream, targetDirectory, (Overwrite)2, null, fileFilter, null, true, false, false);
							int num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
							{
								num4 = 0;
							}
							switch (num4)
							{
							case 0:
								break;
							}
						}
						finally
						{
							int num5;
							if (zipStream == null)
							{
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
								{
									num5 = 1;
								}
								goto IL_00ca;
							}
							goto IL_00e0;
							IL_00e0:
							((IDisposable)zipStream).Dispose();
							num5 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
							{
								num5 = 0;
							}
							goto IL_00ca;
							IL_00ca:
							switch (num5)
							{
							default:
								goto end_IL_00a5;
							case 2:
								break;
							case 1:
								goto end_IL_00a5;
							case 0:
								goto end_IL_00a5;
							}
							goto IL_00e0;
							end_IL_00a5:;
						}
						break;
					case 1:
						break;
					}
				}
				catch (Exception ex)
				{
					int num6 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num6 = 0;
					}
					return num6 switch
					{
						0 => ex, 
						_ => ex, 
					};
				}
				goto case 1;
			case 1:
				return null;
			case 2:
				THy6seBMZ8WcbjDJULp1(!X29ZEWBM86VgsH8LQp8A(targetDirectory), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538463832));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				abRHTYBMKD4xXEJKRxsh(zipStream, CASdLgBMu499sMh9UMj6(0x4EDCBA32 ^ 0x4EDDD39A));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public Exception ExtractZipFolder(Stream zipStream, string targetDirectory)
	{
		return ExtractZipFolder(zipStream, targetDirectory, null);
	}

	public ZipService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool SueMMgBMCpfH8jZTyYo4()
	{
		return HMcCTFBMQEoxq3vRGpKF == null;
	}

	internal static ZipService MBR7stBMvhQEFShVeYxU()
	{
		return HMcCTFBMQEoxq3vRGpKF;
	}

	internal static bool X29ZEWBM86VgsH8LQp8A(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static void THy6seBMZ8WcbjDJULp1(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static object CASdLgBMu499sMh9UMj6(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void vTMNZbBMIgQKXtCPJgH7(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool R34pemBMV9EGm47SwNgq(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object DQbSFZBMS4MQQLABqJ6u(object P_0)
	{
		return ((FastZip)P_0).get_EntryFactory();
	}

	internal static void PZpvGABMiYbjvAp8ZFM0(object P_0, bool P_1)
	{
		((ZipEntryFactory)P_0).set_IsUnicodeText(P_1);
	}

	internal static void gnDlrTBMRayLdS8PTdew(object P_0, bool P_1)
	{
		((FastZip)P_0).set_CreateEmptyDirectories(P_1);
	}

	internal static void xRYJwjBMqkNwoSSemBjk(object P_0, object P_1, object P_2, bool P_3, object P_4, object P_5)
	{
		((FastZip)P_0).CreateZip((Stream)P_1, (string)P_2, P_3, (string)P_4, (string)P_5);
	}

	internal static void abRHTYBMKD4xXEJKRxsh(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void KeAhhvBMX1YGG6P1Oxfn(object P_0, object P_1, object P_2, Overwrite P_3, object P_4, object P_5, object P_6, bool P_7, bool P_8, bool P_9)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		((FastZip)P_0).ExtractZip((Stream)P_1, (string)P_2, P_3, (ConfirmOverwriteDelegate)P_4, (string)P_5, (string)P_6, P_7, P_8, P_9);
	}
}
