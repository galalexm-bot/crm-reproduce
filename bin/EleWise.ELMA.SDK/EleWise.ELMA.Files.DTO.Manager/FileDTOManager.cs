using System;
using AutoMapper;
using EleWise.ELMA.ExtensionPoints;
using EleWise.ELMA.Files.DTO.Models;
using EleWise.ELMA.Model.Managers;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.DTO.Managers;

public class FileDTOManager : DTOManager, IBinaryDTOManager, IConfigurationService
{
	private static FileDTOManager XlexkfGnr94TuZnMubmq;

	protected IFileManager FileManager => Locator.GetServiceNotNull<IFileManager>();

	public virtual string SaveFile(BinaryFileDTO binaryFile)
	{
		//Discarded unreachable code: IL_0077, IL_0086
		int num = 3;
		int num2 = num;
		BinaryFile binaryFile2 = default(BinaryFile);
		while (true)
		{
			switch (num2)
			{
			default:
				throw new ArgumentNullException((string)qOblUGGnjoNm4K6tSYGO(0xE1229CF ^ 0xE138077));
			case 2:
				binaryFile2 = Mapper.Map<BinaryFileDTO, BinaryFile>(binaryFile);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				return (string)frA9wTGnYP6lIqAGlAhN(FileManager, binaryFile2);
			case 3:
				if (binaryFile != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			}
		}
	}

	public virtual BinaryFileDTO LoadFile(string id)
	{
		//Discarded unreachable code: IL_0055, IL_0064
		int num = 1;
		int num2 = num;
		BinaryFile binaryFile = default(BinaryFile);
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (id != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 3:
				throw new ArgumentNullException((string)qOblUGGnjoNm4K6tSYGO(-1876063057 ^ -1876115499));
			default:
				binaryFile = (BinaryFile)mvQ5iTGnLRLsHYMEJOsP(FileManager, id);
				num2 = 4;
				break;
			case 4:
				if (binaryFile == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
					{
						num2 = 1;
					}
					break;
				}
				return Mapper.Map<BinaryFile, BinaryFileDTO>(binaryFile);
			case 2:
				return null;
			}
		}
	}

	public virtual BinaryFileDTO CopyFile(BinaryFileDTO sourceBinaryFile)
	{
		//Discarded unreachable code: IL_0035
		int num = 4;
		int num2 = num;
		BinaryFile binaryFile = default(BinaryFile);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return Mapper.Map<BinaryFile, BinaryFileDTO>(binaryFile);
			case 2:
				throw new ArgumentNullException((string)qOblUGGnjoNm4K6tSYGO(-398663332 ^ -398636296));
			case 3:
				binaryFile = (BinaryFile)PbRPIkGnzHDi3fvrQuSr(rQYDeJGncdVXiSGeaDlP(nDcJyCGnUfqsLc6jKRAs(Mapper.Map<BinaryFileDTO, BinaryFile>(sourceBinaryFile)), LlrsW3Gns7vb5Nea7c0g(sourceBinaryFile)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (sourceBinaryFile != null)
				{
					num2 = 3;
					break;
				}
				goto case 2;
			default:
				frA9wTGnYP6lIqAGlAhN(FileManager, binaryFile);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public FileDTOManager()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		zVLAehGOFBpy4R4lI2ch();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object qOblUGGnjoNm4K6tSYGO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object frA9wTGnYP6lIqAGlAhN(object P_0, object P_1)
	{
		return ((IFileManager)P_0).SaveFile((BinaryFile)P_1);
	}

	internal static bool LoDxOiGngEClHaoKvaMN()
	{
		return XlexkfGnr94TuZnMubmq == null;
	}

	internal static FileDTOManager fLR52XGn5jVHaFOlydlw()
	{
		return XlexkfGnr94TuZnMubmq;
	}

	internal static object mvQ5iTGnLRLsHYMEJOsP(object P_0, object P_1)
	{
		return ((IFileManager)P_0).LoadFile((string)P_1);
	}

	internal static object nDcJyCGnUfqsLc6jKRAs(object P_0)
	{
		return BinaryFile.CreateFrom((BinaryFile)P_0);
	}

	internal static object LlrsW3Gns7vb5Nea7c0g(object P_0)
	{
		return ((BinaryFileDTO)P_0).Content;
	}

	internal static object rQYDeJGncdVXiSGeaDlP(object P_0, object P_1)
	{
		return ((BinaryFileBuilder)P_0).Content((byte[])P_1);
	}

	internal static object PbRPIkGnzHDi3fvrQuSr(object P_0)
	{
		return ((BinaryFileBuilder)P_0).Build();
	}

	internal static void zVLAehGOFBpy4R4lI2ch()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
