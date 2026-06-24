using System;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps.Services;

[Component(Order = 5000)]
public class FilesBAConverter : IBPMAppItemsConverter
{
	private static FilesBAConverter n2UIKhf2Ia5mbsXIHQF0;

	public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
	{
		//Discarded unreachable code: IL_0081, IL_00e9, IL_00f8, IL_012c, IL_013b
		int num = 4;
		FilesBAChapter filesBAChapter = default(FilesBAChapter);
		FilesExportSetting filesExportSetting = default(FilesExportSetting);
		object value = default(object);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 16:
					break;
				case 5:
					OefZXJf2TLRcf6n2l0vU(filesBAChapter, MoctEgf2Xt2oRBv3hsHS(filesExportSetting));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					if (settings.CustomSettings.TryGetValue(FilesExportConsts.ExportExtensionUid, out value))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 5;
						}
						continue;
					}
					return;
				case 0:
					return;
				case 9:
					filesExportSetting = value as FilesExportSetting;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
					{
						num2 = 6;
					}
					continue;
				case 11:
					if (duLJ1If2nGm9NbYjclP2(filesBAChapter.HelpOriginalFullFileName))
					{
						num2 = 15;
						continue;
					}
					goto case 10;
				case 8:
					if (!duLJ1If2nGm9NbYjclP2(W9X54kf2kKA2KpLwNMWE(filesBAChapter)))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 11;
				case 10:
				case 14:
					bpmAppManifest.SetChapter(filesBAChapter);
					num2 = 7;
					continue;
				case 15:
					if (!duLJ1If2nGm9NbYjclP2(jSAarqf2OXUQpePOHH2r(filesBAChapter)))
					{
						num2 = 10;
						continue;
					}
					return;
				case 6:
					if (filesExportSetting != null)
					{
						num2 = 12;
						continue;
					}
					return;
				case 4:
					VAykEif2R49M1xopjxoD(bpmAppManifest, F1lcwPf2iL39mNsevqhj(0x463A0F3C ^ 0x463F47AE));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
					{
						num2 = 3;
					}
					continue;
				case 13:
					ejYLbef2KAy6sAdKhYB1(filesBAChapter, filesExportSetting.HelpOriginalFullFileName);
					num2 = 5;
					continue;
				case 3:
					VAykEif2R49M1xopjxoD(settings, F1lcwPf2iL39mNsevqhj(-1858887263 ^ -1858909393));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					return;
				case 12:
					filesBAChapter = new FilesBAChapter
					{
						Uid = FilesExportConsts.ExportExtensionUid
					};
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 16;
					}
					continue;
				case 7:
					return;
				}
				break;
			}
			LXXV1Xf2qTCP9Yt21HML(filesBAChapter, filesExportSetting.HelpFileName);
			num = 13;
		}
	}

	public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		//Discarded unreachable code: IL_00a6, IL_00b5
		int num = 4;
		int num2 = num;
		FilesExportSetting filesExportSetting = default(FilesExportSetting);
		FilesBAChapter filesBAChapter = default(FilesBAChapter);
		while (true)
		{
			switch (num2)
			{
			case 2:
				filesExportSetting = new FilesExportSetting();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				Contract.ArgumentNotNull(bpmAppManifest, (string)F1lcwPf2iL39mNsevqhj(-1317790512 ^ -1317972926));
				num2 = 3;
				break;
			case 9:
				vI2Zi9f2eVhBan4J0wOs(filesExportSetting, W9X54kf2kKA2KpLwNMWE(filesBAChapter));
				num2 = 7;
				break;
			case 6:
				return;
			case 1:
				filesBAChapter = b755Ysf22naGtHo8inbc(bpmAppManifest, FilesExportConsts.ExportExtensionUid) as FilesBAChapter;
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 7;
				}
				break;
			case 3:
				Contract.ArgumentNotNull(settings, (string)F1lcwPf2iL39mNsevqhj(-740338220 ^ -740311206));
				num2 = 2;
				break;
			case 8:
				F5q1wYf210WJ6Yj8PQXt(filesExportSetting, jSAarqf2OXUQpePOHH2r(filesBAChapter));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				settings.CustomSettings[FilesExportConsts.ExportExtensionUid] = filesExportSetting;
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 6;
				}
				break;
			case 10:
				if (filesBAChapter == null)
				{
					num2 = 5;
					break;
				}
				goto case 9;
			case 7:
				VAYeIAf2PqiXyXDoqWrW(filesExportSetting, filesBAChapter.HelpOriginalFullFileName);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 8;
				}
				break;
			}
		}
	}

	public FilesBAConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object F1lcwPf2iL39mNsevqhj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void VAykEif2R49M1xopjxoD(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void LXXV1Xf2qTCP9Yt21HML(object P_0, object P_1)
	{
		((FilesBAChapter)P_0).HelpFileName = (string)P_1;
	}

	internal static void ejYLbef2KAy6sAdKhYB1(object P_0, object P_1)
	{
		((FilesBAChapter)P_0).HelpOriginalFullFileName = (string)P_1;
	}

	internal static object MoctEgf2Xt2oRBv3hsHS(object P_0)
	{
		return ((FilesExportSetting)P_0).AdditionalFilesOriginalFolder;
	}

	internal static void OefZXJf2TLRcf6n2l0vU(object P_0, object P_1)
	{
		((FilesBAChapter)P_0).AdditionalFilesOriginalFolder = (string)P_1;
	}

	internal static object W9X54kf2kKA2KpLwNMWE(object P_0)
	{
		return ((FilesBAChapter)P_0).HelpFileName;
	}

	internal static bool duLJ1If2nGm9NbYjclP2(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object jSAarqf2OXUQpePOHH2r(object P_0)
	{
		return ((FilesBAChapter)P_0).AdditionalFilesOriginalFolder;
	}

	internal static bool ABjqqff2VjKjrRbbk2Hs()
	{
		return n2UIKhf2Ia5mbsXIHQF0 == null;
	}

	internal static FilesBAConverter knwQEDf2SjExu1qL4M9u()
	{
		return n2UIKhf2Ia5mbsXIHQF0;
	}

	internal static object b755Ysf22naGtHo8inbc(object P_0, Guid uid)
	{
		return ((BPMAppManifest)P_0).GetChapter(uid);
	}

	internal static void vI2Zi9f2eVhBan4J0wOs(object P_0, object P_1)
	{
		((FilesExportSetting)P_0).HelpFileName = (string)P_1;
	}

	internal static void VAYeIAf2PqiXyXDoqWrW(object P_0, object P_1)
	{
		((FilesExportSetting)P_0).HelpOriginalFullFileName = (string)P_1;
	}

	internal static void F5q1wYf210WJ6Yj8PQXt(object P_0, object P_1)
	{
		((FilesExportSetting)P_0).AdditionalFilesOriginalFolder = (string)P_1;
	}
}
