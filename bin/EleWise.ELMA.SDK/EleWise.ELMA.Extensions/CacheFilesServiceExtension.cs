using System;
using System.IO;
using EleWise.ELMA.Files;
using EleWise.ELMA.Services;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class CacheFilesServiceExtension
{
	internal static CacheFilesServiceExtension rVxVgtGtSpGj9ft6VApq;

	public static BinaryFile GetBinaryFile(this ICacheFilesService cacheFilesService, Guid uid)
	{
		//Discarded unreachable code: IL_019e, IL_01ad, IL_0220
		int num = 6;
		BinaryFile binaryFile = default(BinaryFile);
		string text2 = default(string);
		BinaryFile value = default(BinaryFile);
		string text = default(string);
		IMimeMappingService serviceNotNull = default(IMimeMappingService);
		string name = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 11:
					return binaryFile;
				case 8:
				case 9:
					return null;
				case 13:
					if (!JvDFpvGtnokESKAJcGTi(text2))
					{
						num2 = 8;
						continue;
					}
					goto case 12;
				case 7:
					if (value != null)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					text = (string)tQaI9SGtTPR5rnMIcVHP(cacheFilesService, uid);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 3;
					}
					continue;
				case 12:
					binaryFile = (BinaryFile)X4iPxHGtP9a3iwJCFyoK(((BinaryFileBuilder)fC41eSGteoBTp99cEX83(BinaryFile.CreateNew().Uid(uid), zWQRMYGt2V7Pbc234n2D(serviceNotNull, Path.GetExtension((string)rh5ZctGtO3DaOFB7oyny(text))))).Name(text).Content(text2));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					serviceNotNull = Locator.GetServiceNotNull<IMimeMappingService>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (string.IsNullOrEmpty(text2))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 13;
				case 10:
					ContextVars.TryGetValue<BinaryFile>(name, out value);
					num2 = 7;
					continue;
				case 5:
					name = (string)ETKSQfGtXNjd6Sy7Gh8H(cbQhMEGtKA9t2RV6rER5(0x6A81B9B4 ^ 0x6A8247A0), uid.ToString());
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 3;
					}
					continue;
				case 1:
					break;
				case 3:
					text2 = (string)aKJnNgGtkvduwjRWo7ba(cacheFilesService, uid);
					num2 = 2;
					continue;
				case 6:
					if (gbNidmGtqvZtKELZZRdi(uid, Guid.Empty))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 4:
					return value;
				}
				break;
			}
			ContextVars.Set(name, binaryFile);
			num = 11;
		}
	}

	internal static bool gbNidmGtqvZtKELZZRdi(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object cbQhMEGtKA9t2RV6rER5(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object ETKSQfGtXNjd6Sy7Gh8H(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object tQaI9SGtTPR5rnMIcVHP(object P_0, Guid uid)
	{
		return ((ICacheFilesService)P_0).GetFileName(uid);
	}

	internal static object aKJnNgGtkvduwjRWo7ba(object P_0, Guid uid)
	{
		return ((ICacheFilesService)P_0).GetFilePath(uid);
	}

	internal static bool JvDFpvGtnokESKAJcGTi(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object rh5ZctGtO3DaOFB7oyny(object P_0)
	{
		return ((string)P_0).ReplaceInvalidFileNameChars();
	}

	internal static object zWQRMYGt2V7Pbc234n2D(object P_0, object P_1)
	{
		return ((IMimeMappingService)P_0).GetTypeByExtension((string)P_1);
	}

	internal static object fC41eSGteoBTp99cEX83(object P_0, object P_1)
	{
		return ((BinaryFileBuilder)P_0).ContentType((string)P_1);
	}

	internal static object X4iPxHGtP9a3iwJCFyoK(object P_0)
	{
		return ((BinaryFileBuilder)P_0).Build();
	}

	internal static bool eiIuPqGti0aZD8SmLU9l()
	{
		return rVxVgtGtSpGj9ft6VApq == null;
	}

	internal static CacheFilesServiceExtension pMw0cMGtRAZcbEYn1eY7()
	{
		return rVxVgtGtSpGj9ft6VApq;
	}
}
