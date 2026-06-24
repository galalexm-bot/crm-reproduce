using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps.Services;

[Component(Order = 2600)]
internal class TranslateBAConverter : IBPMAppItemsConverter
{
	private static readonly Guid _exportTranslatesUid;

	internal static TranslateBAConverter XQV1Y6fePEkEsr2F2ZqI;

	public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
	{
		//Discarded unreachable code: IL_00c4
		int num = 1;
		int num2 = num;
		TranslateExportSettings translateSettings = default(TranslateExportSettings);
		while (true)
		{
			switch (num2)
			{
			case 2:
				SetTranslateChapter(bpmAppManifest, translateSettings);
				num2 = 4;
				break;
			case 1:
				CheckArguments(bpmAppManifest, settings);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				return;
			default:
				translateSettings = GetTranslateSettings(settings);
				num2 = 3;
				break;
			case 5:
				return;
			case 6:
				B3JskVfepNnClcqPYej9(bpmAppManifest, _exportTranslatesUid, cXCV2ufe3QUW8jZvUnBp(translateSettings));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				if (translateSettings == null)
				{
					return;
				}
				num2 = 6;
				break;
			}
		}
	}

	public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
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
				CheckArguments(bpmAppManifest, settings);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				SetTranlateSettings(bpmAppManifest, settings);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	private void SetTranslateChapter(BPMAppManifest bpmAppManifest, TranslateExportSettings settings)
	{
		//Discarded unreachable code: IL_00c7, IL_00f2, IL_0101
		int num = 4;
		TranslatesBAChapter translatesBAChapter = default(TranslatesBAChapter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					return;
				case 7:
					return;
				case 9:
					return;
				case 8:
					if (translatesBAChapter.Translates == null)
					{
						num2 = 7;
						continue;
					}
					goto case 6;
				case 4:
				{
					TranslatesBAChapter translatesBAChapter2 = new TranslatesBAChapter();
					wKUSpHfeaDFKLHvatQom(translatesBAChapter2, TranslateExportConst.ExportExtensionUid);
					translatesBAChapter = translatesBAChapter2;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 2;
					}
					continue;
				}
				case 2:
					Y1sumNfetWbWqxl8VH7a(bpmAppManifest, translatesBAChapter);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (settings.Translates != null)
					{
						num = 5;
						break;
					}
					goto case 8;
				case 6:
					if (nlfuL2feD7tZAXIQFLJw(translatesBAChapter.Translates) <= 0)
					{
						num2 = 9;
						continue;
					}
					goto case 2;
				case 3:
					if (settings.ExportTranslate)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 5:
					translatesBAChapter.Translates = settings.Translates.Select(delegate(CultureInfo c)
					{
						TranslateBAItem translateBAItem = new TranslateBAItem();
						_003C_003Ec.vjjoUuZFS4WaguJEZDdh(translateBAItem, c.NativeName);
						_003C_003Ec.kMrQuVZFiovmbm3iWHle(translateBAItem, c.ToString());
						return translateBAItem;
					}).ToList();
					num = 8;
					break;
				}
				break;
			}
		}
	}

	private TranslateExportSettings GetTranslateSettings(ConfigExportSettings settings)
	{
		//Discarded unreachable code: IL_007c, IL_008b
		int num = 2;
		int num2 = num;
		TranslateExportSettings translateExportSettings = default(TranslateExportSettings);
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 3:
				return translateExportSettings;
			case 4:
				if (translateExportSettings != null)
				{
					num2 = 3;
					break;
				}
				goto default;
			case 2:
			{
				if (!settings.CustomSettings.TryGetValue(TranslateExportConst.ExportExtensionUid, out var value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 1;
					}
				}
				else
				{
					translateExportSettings = value as TranslateExportSettings;
					num2 = 4;
				}
				break;
			}
			case 1:
				return null;
			}
		}
	}

	private void SetTranlateSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		int num = 1;
		int num2 = num;
		TranslateExportSettings tranlateSettings = default(TranslateExportSettings);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				settings.CustomSettings[TranslateExportConst.ExportExtensionUid] = tranlateSettings;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				tranlateSettings = GetTranlateSettings(bpmAppManifest);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	private TranslateExportSettings GetTranlateSettings(BPMAppManifest bpmAppManifest)
	{
		//Discarded unreachable code: IL_0051, IL_00b7, IL_00c6, IL_00d5
		int num = 6;
		int num2 = num;
		TranslatesBAChapter translatesBAChapter = default(TranslatesBAChapter);
		TranslateExportSettings translateExportSettings = default(TranslateExportSettings);
		while (true)
		{
			switch (num2)
			{
			case 3:
				translatesBAChapter = fWXJE7fe6nRVHCDhkeIs(bpmAppManifest, TranslateExportConst.ExportExtensionUid) as TranslatesBAChapter;
				num2 = 10;
				break;
			case 2:
				if (translatesBAChapter.Translates == null)
				{
					num2 = 8;
					break;
				}
				goto case 7;
			case 10:
				if (translatesBAChapter == null)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 11;
					}
					break;
				}
				goto case 2;
			default:
				translateExportSettings.Translates = new List<CultureInfo>();
				num2 = 9;
				break;
			case 5:
				VImIj1fe4eY62gbeGRLX(translateExportSettings, jkDeBsfew6I8Hmh1b267(bpmAppManifest, _exportTranslatesUid, cXCV2ufe3QUW8jZvUnBp(translateExportSettings)));
				num2 = 3;
				break;
			case 1:
			case 4:
			case 8:
			case 11:
				return translateExportSettings;
			case 6:
				translateExportSettings = new TranslateExportSettings();
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
				{
					num2 = 2;
				}
				break;
			case 7:
				if (translatesBAChapter.Translates.Count <= 0)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			case 9:
				translateExportSettings.Translates = translatesBAChapter.Translates.Select((TranslateBAItem p) => new CultureInfo((string)_003C_003Ec.PHSs81ZFR3QWNv11aAb7(p))).ToList();
				num2 = 4;
				break;
			}
		}
	}

	private void CheckArguments(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				gnHVLGfeAgySIAkSl6LH(bpmAppManifest, XCGMWPfeHN7F2VNoVSnw(0x307E9FD1 ^ 0x307BD743));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				gnHVLGfeAgySIAkSl6LH(settings, XCGMWPfeHN7F2VNoVSnw(-1317790512 ^ -1317734818));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public TranslateBAConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		OPT53mfe7B7xYq8uQkif();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static TranslateBAConverter()
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
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				_exportTranslatesUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CE0CD9));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool cXCV2ufe3QUW8jZvUnBp(object P_0)
	{
		return ((TranslateExportSettings)P_0).ExportTranslate;
	}

	internal static void B3JskVfepNnClcqPYej9(object P_0, Guid uid, bool value)
	{
		((BPMAppManifest)P_0).SetFlag(uid, value);
	}

	internal static bool A3Ym20fe1cbbQYdT77YP()
	{
		return XQV1Y6fePEkEsr2F2ZqI == null;
	}

	internal static TranslateBAConverter yYaxgqfeNwxu8giLQeCK()
	{
		return XQV1Y6fePEkEsr2F2ZqI;
	}

	internal static void wKUSpHfeaDFKLHvatQom(object P_0, Guid value)
	{
		((BPMAppManifestChapter)P_0).Uid = value;
	}

	internal static int nlfuL2feD7tZAXIQFLJw(object P_0)
	{
		return ((List<TranslateBAItem>)P_0).Count;
	}

	internal static void Y1sumNfetWbWqxl8VH7a(object P_0, object P_1)
	{
		((BPMAppManifest)P_0).SetChapter((BPMAppManifestChapter)P_1);
	}

	internal static bool jkDeBsfew6I8Hmh1b267(object P_0, Guid uid, bool defaultValue)
	{
		return ((BPMAppManifest)P_0).GetFlag(uid, defaultValue);
	}

	internal static void VImIj1fe4eY62gbeGRLX(object P_0, bool value)
	{
		((TranslateExportSettings)P_0).ExportTranslate = value;
	}

	internal static object fWXJE7fe6nRVHCDhkeIs(object P_0, Guid uid)
	{
		return ((BPMAppManifest)P_0).GetChapter(uid);
	}

	internal static object XCGMWPfeHN7F2VNoVSnw(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void gnHVLGfeAgySIAkSl6LH(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void OPT53mfe7B7xYq8uQkif()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
