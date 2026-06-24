using System;
using System.IO;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scheduling;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Services.Impl;

[Component]
internal class FileCleaner : ISweepHandler
{
	internal static TimeSpan cacheDuration;

	private DateTime lastRun;

	private static string _cacheFilesDirectory;

	private static ILogger logger;

	internal static FileCleaner PnnQReBMT2GDJbK1U3u6;

	private static ILogger Logger
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					logger = (ILogger)q15QHlBM6LAslacZ5Wow(tZCvJKBMwd8BQTmxj6Ke(0x12A5FAC7 ^ 0x12A4990F));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 0;
					}
					break;
				default:
					return logger;
				case 2:
					if (logger == null)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				}
			}
		}
	}

	public void Execute()
	{
		//Discarded unreachable code: IL_0049, IL_012a
		int num = 7;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					return;
				default:
					rcafMWBMNX8cRuu57ODT(text);
					num2 = 5;
					continue;
				case 7:
					if (!B7NbeeBMPwqMYc1WLSPW(M8U2iWBM2SBAeF1KRn75(MBqAjyBMOrWgBgse2xet(), lastRun), WJL80uBMexEmAi26IByZ(1.0)))
					{
						num = 6;
						break;
					}
					return;
				case 8:
					if (j1GMNYBM1nAupSYKgZSo(_cacheFilesDirectory))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 9;
				case 9:
					rcafMWBMNX8cRuu57ODT(_cacheFilesDirectory);
					num2 = 4;
					continue;
				case 1:
					if (SybmiMBMpUSDy4wfupZM(text, _cacheFilesDirectory, StringComparison.InvariantCultureIgnoreCase))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 0;
					}
					continue;
				case 3:
				case 4:
					text = (string)lOxUhmBM3w8du4EhGLb8();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					return;
				case 6:
					lastRun = DateTime.Now;
					num = 8;
					break;
				}
				break;
			}
		}
	}

	internal static void SetCacheFilesDirectory(string dir)
	{
		_cacheFilesDirectory = dir;
	}

	internal static void CleanFiles(string cacheDir)
	{
		//Discarded unreachable code: IL_0080, IL_014b, IL_018c, IL_01d6, IL_01e5, IL_0225, IL_0249
		int num = 13;
		FileInfo fileInfo = default(FileInfo);
		DateTime dateTime = default(DateTime);
		string text = default(string);
		string[] files = default(string[]);
		int num3 = default(int);
		string path = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					try
					{
						DateTime dateTime2 = wwsq9NBMtJHyX7FBIGIJ(fileInfo);
						int num4 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
						{
							num4 = 3;
						}
						while (true)
						{
							switch (num4)
							{
							case 3:
								if (M8U2iWBM2SBAeF1KRn75(dateTime, dateTime2) > cacheDuration)
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
									{
										num4 = 0;
									}
									continue;
								}
								break;
							case 1:
								EYqoR7BM48OvC0J5F2sF(fileInfo);
								num4 = 2;
								continue;
							default:
								Logger.InfoFormat((string)tZCvJKBMwd8BQTmxj6Ke(-882126494 ^ -882198384), text, dateTime2);
								num4 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
								{
									num4 = 1;
								}
								continue;
							case 2:
								break;
							}
							break;
						}
					}
					catch (Exception message)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							default:
								Logger.Warn(message);
								num5 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
								{
									num5 = 0;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 4;
				case 3:
					files = Directory.GetFiles(cacheDir);
					num2 = 7;
					break;
				case 9:
				case 15:
					if (num3 < files.Length)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 11:
					if (HfRr24BMD9JdGPpQH1as(fileInfo))
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 12:
					return;
				case 13:
					if (!j1GMNYBM1nAupSYKgZSo(cacheDir))
					{
						if (!YNFMPOBMaUwgoifg7J0S(cacheDir))
						{
							return;
						}
						num2 = 6;
					}
					else
					{
						num2 = 12;
					}
					break;
				case 8:
					return;
				case 6:
					dateTime = MBqAjyBMOrWgBgse2xet();
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				case 14:
					fileInfo = new FileInfo(text);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b != 0)
					{
						num2 = 11;
					}
					break;
				case 7:
					num3 = 0;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 15;
					}
					break;
				case 5:
					return;
				default:
					path = files[num3];
					num2 = 10;
					break;
				case 4:
					num3++;
					num2 = 9;
					break;
				case 10:
					text = Path.Combine(cacheDir, path);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 14;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 2;
		}
	}

	public FileCleaner()
	{
		//Discarded unreachable code: IL_003a, IL_003f
		SingletonReader.JJCZtPuTvSt();
		lastRun = DateTime.MinValue;
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static FileCleaner()
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
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				_cacheFilesDirectory = "";
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				cacheDuration = VP1QScBMH2jcerpGFRqO(1.0);
				num2 = 3;
				break;
			case 0:
				return;
			}
		}
	}

	internal static DateTime MBqAjyBMOrWgBgse2xet()
	{
		return DateTime.Now;
	}

	internal static TimeSpan M8U2iWBM2SBAeF1KRn75(DateTime P_0, DateTime P_1)
	{
		return P_0 - P_1;
	}

	internal static TimeSpan WJL80uBMexEmAi26IByZ(double P_0)
	{
		return TimeSpan.FromHours(P_0);
	}

	internal static bool B7NbeeBMPwqMYc1WLSPW(TimeSpan P_0, TimeSpan P_1)
	{
		return P_0 < P_1;
	}

	internal static bool j1GMNYBM1nAupSYKgZSo(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static void rcafMWBMNX8cRuu57ODT(object P_0)
	{
		CleanFiles((string)P_0);
	}

	internal static object lOxUhmBM3w8du4EhGLb8()
	{
		return IOExtensions.GetTempPath();
	}

	internal static bool SybmiMBMpUSDy4wfupZM(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static bool g4JqpQBMkZfGnMjxhtwu()
	{
		return PnnQReBMT2GDJbK1U3u6 == null;
	}

	internal static FileCleaner YRPw1eBMnLrlhHoXTdmL()
	{
		return PnnQReBMT2GDJbK1U3u6;
	}

	internal static bool YNFMPOBMaUwgoifg7J0S(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static bool HfRr24BMD9JdGPpQH1as(object P_0)
	{
		return ((FileSystemInfo)P_0).Exists;
	}

	internal static DateTime wwsq9NBMtJHyX7FBIGIJ(object P_0)
	{
		return ((FileSystemInfo)P_0).LastWriteTime;
	}

	internal static object tZCvJKBMwd8BQTmxj6Ke(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void EYqoR7BM48OvC0J5F2sF(object P_0)
	{
		((FileSystemInfo)P_0).Delete();
	}

	internal static object q15QHlBM6LAslacZ5Wow(object P_0)
	{
		return EleWise.ELMA.Logging.Logger.GetLogger((string)P_0);
	}

	internal static TimeSpan VP1QScBMH2jcerpGFRqO(double P_0)
	{
		return TimeSpan.FromDays(P_0);
	}
}
