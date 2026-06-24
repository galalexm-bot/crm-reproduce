using System;
using System.Collections.Generic;
using System.IO;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

[Component(Order = 100)]
public class PdfFilePreviewCreator : BaseFilePreviewCreatorEx
{
	public static Guid UID;

	internal static PdfFilePreviewCreator qJeT3qG1Mv9iQ6k5m32a;

	public override Guid Uid => UID;

	public override string DisplayName => (string)HMIjbgG1lyVexe3UnGYr(uTnfesG1duufoYtqrlF1(0x92F12D5 ^ 0x92CFFC7));

	public override List<string> Extensions => new List<string> { z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97992990) };

	public override string ExternalCreatorFileName => (string)uTnfesG1duufoYtqrlF1(0x1ECE530A ^ 0x1ECDBE22);

	public override string GetMainFileName(BinaryFile file)
	{
		return (string)XxQbBiG1rOUBs2sS9CdW(file);
	}

	public override bool HasPreview(BinaryFile file, long priority)
	{
		//Discarded unreachable code: IL_0051, IL_0060, IL_00b1, IL_00fa, IL_0109, IL_0119
		int num = 6;
		string mainFileName = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					if (gRElrgG1gR32ugMyXs3B(mainFileName))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 4:
				case 9:
					return false;
				case 10:
					return true;
				default:
					Locator.GetServiceNotNull<IFilePreviewService>().AddPreviewWork(file, 0L);
					num2 = 2;
					continue;
				case 6:
					mainFileName = base.GetMainFileName(file);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num2 = 5;
					}
					continue;
				case 2:
				case 11:
					break;
				case 1:
					if (qFdQp8G158ysL509BwYv(mainFileName))
					{
						num2 = 11;
						continue;
					}
					goto default;
				case 7:
					if (string.IsNullOrEmpty(text))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 8;
				case 8:
					if (qFdQp8G158ysL509BwYv(text))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				}
				break;
			}
			text = (string)BgLMrqG1joT829UX9ien(this, file);
			num = 7;
		}
	}

	public override bool EnableGenerateHtml()
	{
		return false;
	}

	public PdfFilePreviewCreator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		tDIqKlG1YVcCDvhesTLW();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static PdfFilePreviewCreator()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				tDIqKlG1YVcCDvhesTLW();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				UID = new Guid((string)uTnfesG1duufoYtqrlF1(0x66F566B6 ^ 0x66F68BCC));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object uTnfesG1duufoYtqrlF1(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object HMIjbgG1lyVexe3UnGYr(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static bool R3cmvDG1JYFJhuYIgnQg()
	{
		return qJeT3qG1Mv9iQ6k5m32a == null;
	}

	internal static PdfFilePreviewCreator eASt1KG19OEM7pyloakx()
	{
		return qJeT3qG1Mv9iQ6k5m32a;
	}

	internal static object XxQbBiG1rOUBs2sS9CdW(object P_0)
	{
		return ((BinaryFile)P_0).ContentFilePath;
	}

	internal static bool gRElrgG1gR32ugMyXs3B(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static bool qFdQp8G158ysL509BwYv(object P_0)
	{
		return File.Exists((string)P_0);
	}

	internal static object BgLMrqG1joT829UX9ien(object P_0, object P_1)
	{
		return ((BaseFilePreviewCreator)P_0).GetMainFileName((BinaryFile)P_1);
	}

	internal static void tDIqKlG1YVcCDvhesTLW()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
