using System;
using System.IO;
using System.Threading;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Services;
using ICSharpCode.SharpZipLib.Zip;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

[Service]
public class FilePreviewArchiverService : IFilePreviewArchiverService
{
	private object _lockObj;

	private object _lockDeleteObj;

	private static FilePreviewArchiverService NbGckhGehTZQZERdCHte;

	public string GetArchive(BinaryFile file)
	{
		//Discarded unreachable code: IL_0044, IL_00cd, IL_01cb, IL_020b, IL_021a, IL_0226, IL_0235
		//IL_0130: Unknown result type (might be due to invalid IL or missing references)
		//IL_0137: Expected O, but got Unknown
		int num = 5;
		int num2 = num;
		string text2 = default(string);
		string text = default(string);
		object lockObj = default(object);
		bool lockTaken = default(bool);
		ZipOutputStream val = default(ZipOutputStream);
		int folderOffset = default(int);
		while (true)
		{
			switch (num2)
			{
			default:
				return text2;
			case 5:
				text = (string)QjYhM7GeQkv9W6e04Iug(((IFilePreviewCreator)daSLlpGefNS6KQ5Bx8mE(Locator.GetServiceNotNull<IFilePreviewService>(), file)).GetMainFileName(file));
				num2 = 4;
				break;
			case 4:
				text2 = (string)PsfAncGeCaZOfZuvvaOn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837751535), text);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 3;
				}
				break;
			case 3:
				if (YqpgOHGevgEJjRdQryoW(text2))
				{
					num2 = 6;
					break;
				}
				goto case 2;
			case 1:
				try
				{
					Monitor.Enter(lockObj, ref lockTaken);
					int num3 = 4;
					while (true)
					{
						switch (num3)
						{
						case 5:
							return text2;
						default:
							m8JcHQGeSkOdVEjQJ2wW(val);
							num3 = 5;
							break;
						case 1:
							heLA7hGeIBVmlWfjFP2Z(text, val, folderOffset);
							num3 = 2;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
							{
								num3 = 3;
							}
							break;
						case 4:
							val = new ZipOutputStream((Stream)lUE5xrGe8Lo4Z07MjIWH(text2));
							num3 = 2;
							break;
						case 3:
							U2JAaFGeVF0u91IV8iAo(val, true);
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
							{
								num3 = 0;
							}
							break;
						case 2:
							folderOffset = text.Length + ((!tPmr1IGeud0HDrThdNpi(text, YsAmMgGeZR9uhSslK8em(0x63ABA4E8 ^ 0x63ABBB9E))) ? 1 : 0);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
							{
								num3 = 1;
							}
							break;
						}
					}
				}
				finally
				{
					int num4;
					if (!lockTaken)
					{
						num4 = 2;
						goto IL_01cf;
					}
					goto IL_01e5;
					IL_01cf:
					switch (num4)
					{
					default:
						goto end_IL_01ba;
					case 1:
						break;
					case 2:
						goto end_IL_01ba;
					case 0:
						goto end_IL_01ba;
					}
					goto IL_01e5;
					IL_01e5:
					A77slPGeir14CcDZYNqA(lockObj);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num4 = 0;
					}
					goto IL_01cf;
					end_IL_01ba:;
				}
			case 2:
				lockObj = _lockObj;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 7;
				}
				break;
			case 7:
				lockTaken = false;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ClearArchive(BinaryFile file)
	{
		//Discarded unreachable code: IL_008a, IL_00b8, IL_00ec, IL_011f, IL_0188, IL_01c0
		int num = 1;
		int num2 = num;
		string text = default(string);
		string arg = default(string);
		object lockDeleteObj = default(object);
		bool lockTaken = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 7:
				if (!YqpgOHGevgEJjRdQryoW(text))
				{
					num2 = 3;
					break;
				}
				goto case 5;
			case 3:
				return;
			case 4:
				return;
			case 1:
				arg = (string)QjYhM7GeQkv9W6e04Iug(JMIgJOGeRdrkHrvNlCUb(Locator.GetServiceNotNull<IFilePreviewService>().GetPreviewCreator(file), file));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
				{
					num2 = 0;
				}
				break;
			case 6:
				try
				{
					Monitor.Enter(lockDeleteObj, ref lockTaken);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					}
					try
					{
						okQakYGeqhpMS9r2B2cS(text);
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
						return;
					}
					catch (Exception ex)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								return;
							case 0:
								return;
							case 1:
								jfM7KDGeXdPfs0E3nwxN(Logger.Log, diQAaLGeKgZnAP9yYGvm(ex), ex);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
								{
									num5 = 0;
								}
								break;
							}
						}
					}
				}
				finally
				{
					if (lockTaken)
					{
						int num6 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								Monitor.Exit(lockDeleteObj);
								num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
								{
									num6 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
				}
			case 2:
				lockTaken = false;
				num2 = 6;
				break;
			case 5:
				lockDeleteObj = _lockDeleteObj;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				text = string.Format((string)YsAmMgGeZR9uhSslK8em(--1867379187 ^ 0x6F4CAC99), arg);
				num2 = 7;
				break;
			}
		}
	}

	public FilePreviewArchiverService()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		o49836GeTAMJOKKbbIWa();
		_lockObj = new object();
		_lockDeleteObj = new object();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object daSLlpGefNS6KQ5Bx8mE(object P_0, object P_1)
	{
		return ((IFilePreviewService)P_0).GetPreviewCreator((BinaryFile)P_1);
	}

	internal static object QjYhM7GeQkv9W6e04Iug(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object PsfAncGeCaZOfZuvvaOn(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static bool YqpgOHGevgEJjRdQryoW(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object lUE5xrGe8Lo4Z07MjIWH(object P_0)
	{
		return File.Create((string)P_0);
	}

	internal static object YsAmMgGeZR9uhSslK8em(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool tPmr1IGeud0HDrThdNpi(object P_0, object P_1)
	{
		return ((string)P_0).EndsWith((string)P_1);
	}

	internal static void heLA7hGeIBVmlWfjFP2Z(object P_0, object P_1, int folderOffset)
	{
		FileUtils.CompressFolder((string)P_0, (ZipOutputStream)P_1, folderOffset);
	}

	internal static void U2JAaFGeVF0u91IV8iAo(object P_0, bool P_1)
	{
		((DeflaterOutputStream)P_0).set_IsStreamOwner(P_1);
	}

	internal static void m8JcHQGeSkOdVEjQJ2wW(object P_0)
	{
		((Stream)P_0).Close();
	}

	internal static void A77slPGeir14CcDZYNqA(object P_0)
	{
		Monitor.Exit(P_0);
	}

	internal static bool yFVcM3GeGbjFBDa81A8e()
	{
		return NbGckhGehTZQZERdCHte == null;
	}

	internal static FilePreviewArchiverService WDBAt2GeE9inUt7yd0sa()
	{
		return NbGckhGehTZQZERdCHte;
	}

	internal static object JMIgJOGeRdrkHrvNlCUb(object P_0, object P_1)
	{
		return ((IFilePreviewCreator)P_0).GetMainFileName((BinaryFile)P_1);
	}

	internal static void okQakYGeqhpMS9r2B2cS(object P_0)
	{
		File.Delete((string)P_0);
	}

	internal static object diQAaLGeKgZnAP9yYGvm(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void jfM7KDGeXdPfs0E3nwxN(object P_0, object P_1, object P_2)
	{
		((ILogger)P_0).Error(P_1, (Exception)P_2);
	}

	internal static void o49836GeTAMJOKKbbIWa()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
