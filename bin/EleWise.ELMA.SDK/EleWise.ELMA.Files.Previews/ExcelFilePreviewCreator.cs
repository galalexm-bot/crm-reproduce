using System;
using System.Collections.Generic;
using Aspose.Cells;
using EleWise.ELMA.ComponentModel;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Files.Previews;

[Component(Order = 100)]
public class ExcelFilePreviewCreator : BasePasswordFilePreviewCreatorEx
{
	public static Guid UID;

	private static ExcelFilePreviewCreator QytB6rG1Oo5nc8pqmIlF;

	public override Guid Uid => UID;

	public override string DisplayName => SR.T((string)SsHG3dG1PW5RSyA5li0e(-477139494 ^ -477329744));

	public override List<string> Extensions => new List<string>
	{
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583696310),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA586A8B),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309810144),
		z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882361656)
	};

	public override string ExternalCreatorFileName => z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289888804);

	public override bool CheckPassword(BinaryFile file, string password)
	{
		//Discarded unreachable code: IL_006f, IL_00cc, IL_0108, IL_0117, IL_0124, IL_0133, IL_0153, IL_0186, IL_0195
		//IL_0043: Unknown result type (might be due to invalid IL or missing references)
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004f: Expected O, but got Unknown
		//IL_0054: Expected O, but got Unknown
		//IL_004f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ac: Expected O, but got Unknown
		//IL_00a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ad: Invalid comparison between Unknown and I4
		int num = 2;
		int num2 = num;
		bool result = default(bool);
		while (true)
		{
			switch (num2)
			{
			case 5:
				try
				{
					string contentFilePath = file.ContentFilePath;
					LoadOptions val = new LoadOptions();
					DAJrxpG13s1AfmkFlBVa((object)val, password);
					new Workbook(contentFilePath, val);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
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
						result = true;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num3 = 1;
						}
					}
				}
				catch (CellsException val2)
				{
					if ((int)KyvqRQG1pMOocovLkDXy((object)val2) == 8)
					{
						int num4 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 2:
								result = false;
								num4 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								return result;
							}
							break;
						}
					}
					throw;
				}
			case 4:
				return false;
			case 3:
				num2 = 5;
				break;
			case 7:
				return result;
			default:
				return password == null;
			case 1:
				if (!FileFormatUtil.DetectFileFormat((string)DoML5XG1NKxS9e66OSLL(file)).get_IsEncrypted())
				{
					num2 = 6;
					break;
				}
				if (password != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			case 2:
				if (!VnMANgG11nh9EyrTfFXx(file.ContentFilePath))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			case 6:
				return password == null;
			}
		}
	}

	public ExcelFilePreviewCreator()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ExcelFilePreviewCreator()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				UID = new Guid((string)SsHG3dG1PW5RSyA5li0e(-1317790512 ^ -1317539620));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			case 1:
				a8fPOJG1aTn7DdWSllDC();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object SsHG3dG1PW5RSyA5li0e(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool bWfsykG12MUIc2DtB9NF()
	{
		return QytB6rG1Oo5nc8pqmIlF == null;
	}

	internal static ExcelFilePreviewCreator mp3txaG1evtCuSvbmxS3()
	{
		return QytB6rG1Oo5nc8pqmIlF;
	}

	internal static bool VnMANgG11nh9EyrTfFXx(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object DoML5XG1NKxS9e66OSLL(object P_0)
	{
		return ((BinaryFile)P_0).ContentFilePath;
	}

	internal static void DAJrxpG13s1AfmkFlBVa(object P_0, object P_1)
	{
		((LoadOptions)P_0).set_Password((string)P_1);
	}

	internal static ExceptionType KyvqRQG1pMOocovLkDXy(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((CellsException)P_0).get_Code();
	}

	internal static void a8fPOJG1aTn7DdWSllDC()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
