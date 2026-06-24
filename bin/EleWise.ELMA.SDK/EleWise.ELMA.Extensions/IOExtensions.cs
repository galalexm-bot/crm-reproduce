using System;
using System.IO;
using System.Security.Cryptography;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Memory;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class IOExtensions
{
	public const string ElmaTempSubFolder = "ELMA";

	internal static IOExtensions x5VaqaGwMQACbOOycofk;

	public static void WriteAllBytesWithAttempts(string fileName, byte[] bytes, TimeSpan interval, int attemptCount)
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
				xsVhFxGwdmLUsPmZQiQC(fileName, bytes, 0, bytes.Length, interval, attemptCount);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void WriteAllBytesWithAttempts(string fileName, byte[] bytes, int offset, int length, TimeSpan interval, int attemptCount)
	{
		//Discarded unreachable code: IL_0050, IL_0088, IL_00c0, IL_00cf
		int num = 2;
		int num2 = num;
		MemoryStream memoryStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				try
				{
					WriteAllBytesWithAttempts(fileName, memoryStream, interval, attemptCount);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
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
					if (memoryStream != null)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								U7SUxIGwrHTJEKHxMeKX(memoryStream);
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
				}
			case 2:
				memoryStream = (MemoryStream)VjKCLDGwl7QvvqPaMdUF(bytes, offset, length, false);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static void WriteAllBytesWithAttempts(string fileName, Stream dataStream, TimeSpan interval, int attemptCount)
	{
		//Discarded unreachable code: IL_0089, IL_0098, IL_00fb, IL_0123, IL_0163, IL_0172, IL_017e, IL_018d, IL_021b, IL_0259, IL_028c, IL_0320, IL_033f, IL_038c, IL_03c4
		int num = 8;
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		string text = default(string);
		FileStream fileStream = default(FileStream);
		string value = default(string);
		SHA1 sHA = default(SHA1);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
					num2 = 7;
					break;
				case 4:
					if (!KY1l91GwYpX5GcRPHxeV(_003C_003Ec__DisplayClass3_.fileName))
					{
						goto end_IL_0012;
					}
					goto case 3;
				case 10:
					return;
				case 12:
					text = null;
					num2 = 4;
					break;
				case 3:
					fileStream = new FileStream(_003C_003Ec__DisplayClass3_.fileName, FileMode.Open, FileAccess.Read);
					num2 = 5;
					break;
				case 9:
					try
					{
						value = (string)k1F8l9GwjLGEgChA5dji(TjoraNGw5rVqoHnaxByV(sHA, _003C_003Ec__DisplayClass3_.dataStream));
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
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
						if (sHA == null)
						{
							num4 = 2;
							goto IL_0127;
						}
						goto IL_013d;
						IL_0127:
						switch (num4)
						{
						default:
							goto end_IL_0112;
						case 1:
							break;
						case 2:
							goto end_IL_0112;
						case 0:
							goto end_IL_0112;
						}
						goto IL_013d;
						IL_013d:
						U7SUxIGwrHTJEKHxMeKX(sHA);
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
						{
							num4 = 0;
						}
						goto IL_0127;
						end_IL_0112:;
					}
					goto case 12;
				case 1:
					_003C_003Ec__DisplayClass3_.dataStream = dataStream;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 0;
					}
					break;
				case 6:
				case 11:
					if (text != null)
					{
						num2 = 2;
						break;
					}
					goto case 13;
				case 13:
					bZ1BmKGwc6lhSfpleYCq(new Action(_003C_003Ec__DisplayClass3_._003CWriteAllBytesWithAttempts_003Eb__0), interval, attemptCount);
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 4;
					}
					break;
				case 5:
					try
					{
						SHA1 sHA2 = SHA1.Create();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						default:
							try
							{
								text = (string)k1F8l9GwjLGEgChA5dji(TjoraNGw5rVqoHnaxByV(sHA2, fileStream));
								int num6 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
								{
									num6 = 0;
								}
								switch (num6)
								{
								case 0:
									break;
								}
							}
							catch (Exception exception)
							{
								int num7 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
								{
									num7 = 0;
								}
								while (true)
								{
									switch (num7)
									{
									default:
										((ILogger)zs3hmeGwLZfLwGXKybVL()).Warn(QARnLRGwsSBCrOZcNBOd(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x4267CCB1), _003C_003Ec__DisplayClass3_.fileName, JKCURpGwUG049j04gPaZ(-561074844 ^ -561074116)), exception);
										num7 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
										{
											num7 = 1;
										}
										continue;
									case 1:
										break;
									}
									break;
								}
							}
							finally
							{
								int num8;
								if (sHA2 == null)
								{
									num8 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
									{
										num8 = 1;
									}
									goto IL_0324;
								}
								goto IL_0349;
								IL_0349:
								U7SUxIGwrHTJEKHxMeKX(sHA2);
								num8 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
								{
									num8 = 0;
								}
								goto IL_0324;
								IL_0324:
								switch (num8)
								{
								default:
									goto end_IL_02ff;
								case 1:
									goto end_IL_02ff;
								case 2:
									break;
								case 0:
									goto end_IL_02ff;
								}
								goto IL_0349;
								end_IL_02ff:;
							}
							break;
						}
					}
					finally
					{
						if (fileStream != null)
						{
							int num9 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
							{
								num9 = 1;
							}
							while (true)
							{
								switch (num9)
								{
								case 1:
									U7SUxIGwrHTJEKHxMeKX(fileStream);
									num9 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
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
					goto case 6;
				case 2:
					if (text.Equals(value))
					{
						return;
					}
					num2 = 13;
					break;
				case 7:
					_003C_003Ec__DisplayClass3_.fileName = fileName;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				default:
					sHA = (SHA1)rf2cyyGwgX2o64I63RAc();
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 5;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 11;
		}
	}

	public static string GetTempPath()
	{
		//Discarded unreachable code: IL_00b6
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 4:
				mBa611G4WbQZUDtQy9vq(text);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				text = (string)gk3VMeG4FNXZPuvl6R1f(WZxUEEGwzheWb575uPSS(), JKCURpGwUG049j04gPaZ(0x7EC153F ^ 0x7EC46CB));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
			case 3:
				return text;
			default:
				if (QZH8keG4B0aS7WGQrnYu(text))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public static string GetTempPath(string path)
	{
		return (string)gk3VMeG4FNXZPuvl6R1f(GetTempPath(), path);
	}

	public static string GetTempFileName()
	{
		return GetTempFileName(null, needExtension: true, createFile: false);
	}

	public static string GetTempFileName(bool createFile)
	{
		return (string)nYJcy0G4okwBTV7mqrui(null, true, createFile);
	}

	public static string GetTempFileNameWithoutExtension()
	{
		return (string)nYJcy0G4okwBTV7mqrui(null, false, false);
	}

	public static string GetTempFileNameWithoutExtension(bool createFile)
	{
		return GetTempFileName(null, needExtension: false, createFile);
	}

	public static string GetTempFileName(string extension)
	{
		return (string)nYJcy0G4okwBTV7mqrui(extension, true, false);
	}

	public static string GetTempFileName(string extension, bool createFile)
	{
		return (string)nYJcy0G4okwBTV7mqrui(extension, true, createFile);
	}

	private static string GetTempFileName(object extension, bool needExtension, bool createFile)
	{
		//Discarded unreachable code: IL_00ea, IL_0122, IL_0167, IL_0189, IL_0198
		int num = 1;
		int num2 = num;
		Guid guid = default(Guid);
		string tempPath = default(string);
		FileStream fileStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 5:
			case 10:
				guid = Wi7YJcG4EJRWTD2GAOsh();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 7;
				}
				break;
			default:
				if (hNXRvVG4hufuox0VDHRC(extension, JKCURpGwUG049j04gPaZ(-1837662597 ^ -1837669185)))
				{
					num2 = 5;
					break;
				}
				goto case 4;
			case 2:
				if (!createFile)
				{
					num2 = 3;
					break;
				}
				goto case 8;
			case 1:
				if (!ou6RhJG4bsTF30gEk44J(extension))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 5;
			case 9:
				try
				{
					return tempPath;
				}
				finally
				{
					if (fileStream != null)
					{
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							default:
								U7SUxIGwrHTJEKHxMeKX(fileStream);
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
								{
									num3 = 1;
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
				extension = ge96crG4GdVGRviYafA3(JKCURpGwUG049j04gPaZ(--1333735954 ^ 0x4F7F28D6), extension);
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 9;
				}
				break;
			case 3:
			case 6:
				return tempPath;
			case 8:
				fileStream = (FileStream)QSV6GuG4f2EReGkfvlaZ(tempPath);
				num2 = 9;
				break;
			case 7:
				tempPath = GetTempPath((string)ge96crG4GdVGRviYafA3(guid.ToString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A61CFF6)), needExtension ? (extension ?? JKCURpGwUG049j04gPaZ(0x4A1640F ^ 0x4A007D9)) : ""));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	internal static void xsVhFxGwdmLUsPmZQiQC(object P_0, object P_1, int offset, int length, TimeSpan interval, int attemptCount)
	{
		WriteAllBytesWithAttempts((string)P_0, (byte[])P_1, offset, length, interval, attemptCount);
	}

	internal static bool hM9qoSGwJ9mxx9D9Sla6()
	{
		return x5VaqaGwMQACbOOycofk == null;
	}

	internal static IOExtensions p3hXAqGw9pm41OaKf6Uj()
	{
		return x5VaqaGwMQACbOOycofk;
	}

	internal static object VjKCLDGwl7QvvqPaMdUF(object P_0, int offset, int length, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, offset, length, writable);
	}

	internal static void U7SUxIGwrHTJEKHxMeKX(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object rf2cyyGwgX2o64I63RAc()
	{
		return SHA1.Create();
	}

	internal static object TjoraNGw5rVqoHnaxByV(object P_0, object P_1)
	{
		return ((HashAlgorithm)P_0).ComputeHash((Stream)P_1);
	}

	internal static object k1F8l9GwjLGEgChA5dji(object P_0)
	{
		return Convert.ToBase64String((byte[])P_0);
	}

	internal static bool KY1l91GwYpX5GcRPHxeV(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object zs3hmeGwLZfLwGXKybVL()
	{
		return Logger.Log;
	}

	internal static object JKCURpGwUG049j04gPaZ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object QARnLRGwsSBCrOZcNBOd(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void bZ1BmKGwc6lhSfpleYCq(object P_0, TimeSpan interval, int attemptCount)
	{
		ActionExtensions.ExecuteWithAttempts((Action)P_0, interval, attemptCount);
	}

	internal static object WZxUEEGwzheWb575uPSS()
	{
		return Path.GetTempPath();
	}

	internal static object gk3VMeG4FNXZPuvl6R1f(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static bool QZH8keG4B0aS7WGQrnYu(object P_0)
	{
		return Directory.Exists((string)P_0);
	}

	internal static object mBa611G4WbQZUDtQy9vq(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object nYJcy0G4okwBTV7mqrui(object P_0, bool needExtension, bool createFile)
	{
		return GetTempFileName(P_0, needExtension, createFile);
	}

	internal static bool ou6RhJG4bsTF30gEk44J(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool hNXRvVG4hufuox0VDHRC(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static object ge96crG4GdVGRviYafA3(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static Guid Wi7YJcG4EJRWTD2GAOsh()
	{
		return Guid.NewGuid();
	}

	internal static object QSV6GuG4f2EReGkfvlaZ(object P_0)
	{
		return File.Create((string)P_0);
	}
}
