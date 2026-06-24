using System;
using System.IO;
using EleWise.ELMA.Memory;
using ICSharpCode.SharpZipLib.Zip;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

internal class ZipHelper
{
	private static ZipHelper pFM3Gihj6KYBSCMfl97A;

	internal static byte[] CreateZipByteArrayFromFolder(string sourceDirectory, string fileFilter = null)
	{
		//Discarded unreachable code: IL_0074, IL_00d3, IL_010b
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d3: Expected O, but got Unknown
		int num = 7;
		int num2 = num;
		byte[] result = default(byte[]);
		FastZip val = default(FastZip);
		MemoryStream memoryStream = default(MemoryStream);
		ZipEntryFactory val2 = default(ZipEntryFactory);
		while (true)
		{
			switch (num2)
			{
			case 8:
				return result;
			case 4:
				try
				{
					val.CreateZip((Stream)MqZkfUhjJoeS6Q9p49Kd(memoryStream), sourceDirectory, true, fileFilter, (string)null);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return result;
						}
						result = (byte[])QoGmYDhj9CoQiIu1MGHA(memoryStream);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num3 = 1;
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								TJWol9hjdNM9sLdlpZeC(memoryStream);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc != 0)
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
			case 5:
				hPBrPVhjyfBEpQrHgohP(val2, true);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				Contract.CheckArgument(IoFwJfhjmFlJwRTXNcWx(sourceDirectory), (string)vV1peXhjxh59s0eoVIi3(0x571EA399 ^ 0x571FCAF5));
				num2 = 2;
				break;
			case 7:
				P48QGFhj0lPDYJpVFJ6l(!CEDCZyhj72tsTSlTk0ke(sourceDirectory), vV1peXhjxh59s0eoVIi3(-1638402543 ^ -1638490327));
				num2 = 6;
				break;
			default:
				if (val2 != null)
				{
					num2 = 5;
					break;
				}
				goto case 1;
			case 9:
				memoryStream = MemoryHelper.GetMemoryStream();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 4;
				}
				break;
			case 1:
				KJeYnhhjM8OhpdaIsWZW(val, true);
				num2 = 9;
				break;
			case 2:
				val = new FastZip();
				num2 = 3;
				break;
			case 3:
			{
				IEntryFactory entryFactory = val.get_EntryFactory();
				val2 = (ZipEntryFactory)(object)((entryFactory is ZipEntryFactory) ? entryFactory : null);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				break;
			}
			}
		}
	}

	internal static void ExtractZipFolder(byte[] content, string destinationDirectory)
	{
		//Discarded unreachable code: IL_0046, IL_010e, IL_0146, IL_0186, IL_0195, IL_01a1, IL_01b0
		//IL_0096: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Expected O, but got Unknown
		int num = 3;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		FastZip val = default(FastZip);
		while (true)
		{
			int condition;
			switch (num2)
			{
			case 2:
				condition = ((content.Length != 0) ? 1 : 0);
				break;
			case 5:
				memoryStream = (MemoryStream)AByf7yhjl1MuAoDeDHjC(content, false);
				num2 = 7;
				continue;
			default:
				P48QGFhj0lPDYJpVFJ6l(!CEDCZyhj72tsTSlTk0ke(destinationDirectory), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103C48BD));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				val = new FastZip();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 4;
				}
				continue;
			case 1:
				P48QGFhj0lPDYJpVFJ6l(IoFwJfhjmFlJwRTXNcWx(destinationDirectory), vV1peXhjxh59s0eoVIi3(-35995181 ^ -36084779));
				num2 = 4;
				continue;
			case 6:
				return;
			case 7:
				try
				{
					val.ExtractZip((Stream)MqZkfUhjJoeS6Q9p49Kd(memoryStream), destinationDirectory, (Overwrite)2, (ConfirmOverwriteDelegate)null, (string)null, (string)null, false, false, false);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					int num4;
					if (memoryStream == null)
					{
						num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num4 = 2;
						}
						goto IL_014a;
					}
					goto IL_0160;
					IL_0160:
					((IDisposable)memoryStream).Dispose();
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num4 = 1;
					}
					goto IL_014a;
					IL_014a:
					switch (num4)
					{
					case 2:
						goto end_IL_0125;
					case 1:
						goto end_IL_0125;
					}
					goto IL_0160;
					end_IL_0125:;
				}
			case 3:
				if (content != null)
				{
					num2 = 2;
					continue;
				}
				condition = 0;
				break;
			}
			P48QGFhj0lPDYJpVFJ6l((byte)condition != 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6383346D));
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
			{
				num2 = 0;
			}
		}
	}

	public ZipHelper()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		BIAMjihjrVWy4bPnjdGk();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool CEDCZyhj72tsTSlTk0ke(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object vV1peXhjxh59s0eoVIi3(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void P48QGFhj0lPDYJpVFJ6l(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static bool IoFwJfhjmFlJwRTXNcWx(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static void hPBrPVhjyfBEpQrHgohP(object P_0, bool P_1)
	{
		((ZipEntryFactory)P_0).set_IsUnicodeText(P_1);
	}

	internal static void KJeYnhhjM8OhpdaIsWZW(object P_0, bool P_1)
	{
		((FastZip)P_0).set_CreateEmptyDirectories(P_1);
	}

	internal static object MqZkfUhjJoeS6Q9p49Kd(object P_0)
	{
		return ((MemoryStream)P_0).AsNoClose();
	}

	internal static object QoGmYDhj9CoQiIu1MGHA(object P_0)
	{
		return ((MemoryStream)P_0).ToArray();
	}

	internal static void TJWol9hjdNM9sLdlpZeC(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool JHHRuUhjHPRgSQCH6LAl()
	{
		return pFM3Gihj6KYBSCMfl97A == null;
	}

	internal static ZipHelper Rk8FUkhjAEX35Tx4dvev()
	{
		return pFM3Gihj6KYBSCMfl97A;
	}

	internal static object AByf7yhjl1MuAoDeDHjC(object P_0, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
	}

	internal static void BIAMjihjrVWy4bPnjdGk()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
