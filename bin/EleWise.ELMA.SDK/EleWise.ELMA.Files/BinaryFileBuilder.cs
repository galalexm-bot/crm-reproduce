using System;
using System.IO;
using EleWise.ELMA.Memory;
using EleWise.ELMA.Runtime.Managers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files;

public class BinaryFileBuilder
{
	private readonly BinaryFile binaryFile;

	internal static BinaryFileBuilder EEB4gfGKCeOYUh86sBal;

	internal BinaryFileBuilder(BinaryFile templateBinaryFile)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		txjaksGKZK7s9PPuw9pg();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				jWQCHOGKuICWhEqHabiw(templateBinaryFile, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637F8023));
				num = 2;
				break;
			case 1:
				return;
			case 2:
			{
				BinaryFile obj = new BinaryFile();
				bAxmToGKVSj6kNJMu6ZX(obj, JsFYJ9GKInJ5XSBwj98D(templateBinaryFile));
				G5uqPyGKSgXcD76myl7H(obj, DateTime.Now);
				dCVXZJGKig7xw05xxrty(obj, true);
				Cu8RfVGKqTxGYpSmjBY8(obj, vrvJ8wGKR1nMSVxOEQE9(templateBinaryFile));
				JcRQ0LGKXrsf6UuPUX8v(obj, G30PvcGKKE3cDYwBcVYA(templateBinaryFile));
				obj.Salt = (string)V1NpIrGKTDQ4Datfpp0D(templateBinaryFile);
				obj.Uid = Guid.NewGuid();
				binaryFile = obj;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num = 1;
				}
				break;
			}
			}
		}
	}

	internal BinaryFileBuilder()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		txjaksGKZK7s9PPuw9pg();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
		{
			num = 0;
		}
		Guid uid = default(Guid);
		while (true)
		{
			switch (num)
			{
			case 1:
			{
				BinaryFile obj = new BinaryFile();
				G5uqPyGKSgXcD76myl7H(obj, SpR2vHGKn9vSVYZA9eBR());
				dCVXZJGKig7xw05xxrty(obj, true);
				JcRQ0LGKXrsf6UuPUX8v(obj, string.Format((string)NGHJdOGKO9Lb7y0a5aqY(-1411196499 ^ -1411316727), uid.ToString((string)NGHJdOGKO9Lb7y0a5aqY(0x92F12D5 ^ 0x92F62DB))));
				obj.Uid = uid;
				binaryFile = obj;
				num = 2;
				break;
			}
			default:
				uid = Gk2NTeGKk5WwvOmIdtNU();
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num = 1;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public BinaryFileBuilder Uid(Guid uid)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				CbJTeyGK2IRp1j0GIg6P(binaryFile, uid);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public BinaryFileBuilder Name(string name)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				JcRQ0LGKXrsf6UuPUX8v(binaryFile, name);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return this;
			}
		}
	}

	public BinaryFileBuilder ContentType(string contentType)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				bAxmToGKVSj6kNJMu6ZX(binaryFile, contentType);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public BinaryFileBuilder Created(DateTime createDate)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return this;
			case 1:
				G5uqPyGKSgXcD76myl7H(binaryFile, createDate);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public BinaryFileBuilder Content(byte[] contentBytes)
	{
		int num = 1;
		int num2 = num;
		MemoryStream contentStream = default(MemoryStream);
		while (true)
		{
			switch (num2)
			{
			default:
				return Content(contentStream, autoCloseStream: true);
			case 1:
				contentStream = (MemoryStream)Pn8r9eGKeMysvWf8si5I(contentBytes, false);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public BinaryFileBuilder Content(string contentFilePath, bool deleteContentFileAfterSave = false)
	{
		int num = 1;
		int num2 = num;
		FileStream contentStream = default(FileStream);
		while (true)
		{
			switch (num2)
			{
			case 1:
				dCVXZJGKig7xw05xxrty(binaryFile, deleteContentFileAfterSave);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				contentStream = new FileStream(contentFilePath, FileMode.Open, FileAccess.Read);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return Content(contentStream, autoCloseStream: true);
			}
		}
	}

	public BinaryFileBuilder Content(Stream contentStream, bool autoCloseStream = false, string extension = null)
	{
		//Discarded unreachable code: IL_005c, IL_0093, IL_00b2, IL_00c1, IL_00ed, IL_00fc
		switch (1)
		{
		case 1:
			try
			{
				object obj = yiTTT4GKPf3K90OyPEJL();
				BinaryFile obj2 = binaryFile;
				PutContentOptions putContentOptions = new PutContentOptions();
				zcCQyPGK121y4ul1ZcbF(putContentOptions, extension);
				((IBinaryFileStreams)obj).PutContent(obj2, contentStream, putContentOptions);
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num = 0;
				}
				return num switch
				{
					0 => this, 
					_ => this, 
				};
			}
			finally
			{
				int num2;
				if (!autoCloseStream)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 2;
					}
					goto IL_0097;
				}
				goto IL_00cc;
				IL_00cc:
				hsw0VDGKNWDAojVc09Gq(contentStream);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 1;
				}
				goto IL_0097;
				IL_0097:
				switch (num2)
				{
				case 2:
					goto end_IL_0073;
				case 1:
					goto end_IL_0073;
				}
				goto IL_00cc;
				end_IL_0073:;
			}
		default:
			return this;
		}
	}

	public BinaryFileBuilder Content(Uri contentLocation, long contentLength, uint contentCrc)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				vfyQFHGK3oxSTbhnIoqS(binaryFile, contentLocation);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				cBkRhxGKp3HDM39OldBe(binaryFile, contentLength);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				FmjqkTGKawDmS9sCE5WR(binaryFile, contentCrc);
				num2 = 3;
				break;
			case 3:
				return this;
			}
		}
	}

	public BinaryFile Build()
	{
		return binaryFile;
	}

	public static implicit operator BinaryFile(BinaryFileBuilder builder)
	{
		return builder.binaryFile;
	}

	internal static void txjaksGKZK7s9PPuw9pg()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static void jWQCHOGKuICWhEqHabiw(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object JsFYJ9GKInJ5XSBwj98D(object P_0)
	{
		return ((BinaryFile)P_0).ContentType;
	}

	internal static void bAxmToGKVSj6kNJMu6ZX(object P_0, object P_1)
	{
		((BinaryFile)P_0).ContentType = (string)P_1;
	}

	internal static void G5uqPyGKSgXcD76myl7H(object P_0, DateTime value)
	{
		((BinaryFile)P_0).CreateDate = value;
	}

	internal static void dCVXZJGKig7xw05xxrty(object P_0, bool value)
	{
		((BinaryFile)P_0).DeleteTempFileAfterSave = value;
	}

	internal static bool vrvJ8wGKR1nMSVxOEQE9(object P_0)
	{
		return ((BinaryFile)P_0).Encrypt;
	}

	internal static void Cu8RfVGKqTxGYpSmjBY8(object P_0, bool value)
	{
		((BinaryFile)P_0).Encrypt = value;
	}

	internal static object G30PvcGKKE3cDYwBcVYA(object P_0)
	{
		return ((BinaryFile)P_0).Name;
	}

	internal static void JcRQ0LGKXrsf6UuPUX8v(object P_0, object P_1)
	{
		((BinaryFile)P_0).Name = (string)P_1;
	}

	internal static object V1NpIrGKTDQ4Datfpp0D(object P_0)
	{
		return ((BinaryFile)P_0).Salt;
	}

	internal static bool Db0glaGKvV6Xg5VJpDTC()
	{
		return EEB4gfGKCeOYUh86sBal == null;
	}

	internal static BinaryFileBuilder UXKAC5GK8GVVUAhH8DUU()
	{
		return EEB4gfGKCeOYUh86sBal;
	}

	internal static Guid Gk2NTeGKk5WwvOmIdtNU()
	{
		return Guid.NewGuid();
	}

	internal static DateTime SpR2vHGKn9vSVYZA9eBR()
	{
		return DateTime.Now;
	}

	internal static object NGHJdOGKO9Lb7y0a5aqY(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void CbJTeyGK2IRp1j0GIg6P(object P_0, Guid value)
	{
		((BinaryFile)P_0).Uid = value;
	}

	internal static object Pn8r9eGKeMysvWf8si5I(object P_0, bool writable)
	{
		return MemoryHelper.GetMemoryStream((byte[])P_0, writable);
	}

	internal static object yiTTT4GKPf3K90OyPEJL()
	{
		return DataAccessManager.BinaryFileStreams;
	}

	internal static void zcCQyPGK121y4ul1ZcbF(object P_0, object P_1)
	{
		((PutContentOptions)P_0).Extension = (string)P_1;
	}

	internal static void hsw0VDGKNWDAojVc09Gq(object P_0)
	{
		((Stream)P_0).Dispose();
	}

	internal static void vfyQFHGK3oxSTbhnIoqS(object P_0, object P_1)
	{
		((BinaryFile)P_0).ContentLocation = (Uri)P_1;
	}

	internal static void cBkRhxGKp3HDM39OldBe(object P_0, long contentLength)
	{
		((BinaryFile)P_0).SetSize(contentLength);
	}

	internal static void FmjqkTGKawDmS9sCE5WR(object P_0, uint contentCrc)
	{
		((BinaryFile)P_0).SetCrc(contentCrc);
	}
}
