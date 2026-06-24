using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Globalization;
using EleWise.ELMA.Packaging;
using EleWise.ELMA.Packaging.ElmaStoreManifest;
using EleWise.ELMA.Runtime.Managers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Services;

[Service]
public class TagService : ITagService
{
	private List<string> tagLanguage;

	private List<string> tagDataBase;

	private List<string> tagEdition;

	private static TagService Y76wxSEAQZhuvFqf2ErR;

	public List<string> TagLanguage
	{
		get
		{
			if (tagLanguage == null)
			{
				tagLanguage = new List<string>();
				CultureInfo[] cultures = CultureInfo.GetCultures(CultureTypes.SpecificCultures);
				tagLanguage.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099460355));
				tagLanguage.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3557982));
				foreach (string item in from c in cultures
					select ((string)_003C_003Ec.lsxK4M8aSIe7nLXa3Dt1(c)).ToLower().ToString() into c
					orderby c
					select c)
				{
					if (!tagLanguage.Contains(item))
					{
						tagLanguage.Add(item);
					}
				}
			}
			return tagLanguage;
		}
	}

	public List<string> TagDataBase
	{
		get
		{
			List<string> list = tagDataBase;
			if (list == null)
			{
				List<string> obj = new List<string>
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426385153),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345121776),
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x341CCFB1)
				};
				List<string> list2 = obj;
				tagDataBase = obj;
				list = list2;
			}
			return list;
		}
	}

	public List<string> TagEdition
	{
		get
		{
			if (tagEdition == null)
			{
				tagEdition = (from ElmaEdition e in Enum.GetValues(typeof(ElmaEdition))
					select (string)_003C_003Ec.xqOBQK8aiXJIoWAyRHhK(e.ToString())).ToList();
			}
			return tagEdition;
		}
	}

	public bool ValidateTags(ElmaStoreComponentManifest manifest)
	{
		List<TestImportMessages> messages;
		return ValidateTags(manifest, out messages);
	}

	public bool ValidateTags(ElmaStoreComponentManifest manifest, out List<TestImportMessages> messages)
	{
		//Discarded unreachable code: IL_0151, IL_0160, IL_0197, IL_01aa, IL_01ef, IL_02c3, IL_03db, IL_03ee, IL_0477, IL_04de
		int num = 27;
		bool result = default(bool);
		_003C_003Ec__DisplayClass10_2 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_2);
		CultureInfo cultureInfo2 = default(CultureInfo);
		ElmaEdition? editionType = default(ElmaEdition?);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_3 = default(_003C_003Ec__DisplayClass10_0);
		string text = default(string);
		_003C_003Ec__DisplayClass10_1 _003C_003Ec__DisplayClass10_2 = default(_003C_003Ec__DisplayClass10_1);
		CultureInfo cultureInfo = default(CultureInfo);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 44:
					if (manifest.TagDataBaseList != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 41;
				case 27:
					messages = new List<TestImportMessages>();
					num2 = 26;
					continue;
				case 19:
					result = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 0;
					}
					continue;
				case 12:
					result = false;
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 11;
					}
					continue;
				case 31:
					if (manifest.TagLanguageList.All(_003C_003Ec__DisplayClass10_._003CValidateTags_003Eb__2))
					{
						num2 = 23;
						continue;
					}
					goto default;
				case 11:
					if (cultureInfo2 != null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = null;
					goto IL_072c;
				case 7:
					obj = ((LanguagesMap)z1BM49EAKTWd0ROxHfdx()).GetBaseCultureInfo((string)EGpFgHEAXfWhalugbC5g(cultureInfo2));
					goto IL_072c;
				case 17:
					if (!editionType.HasValue)
					{
						num2 = 16;
						continue;
					}
					goto case 2;
				case 6:
					_003C_003Ec__DisplayClass10_3 = new _003C_003Ec__DisplayClass10_0();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 15;
					}
					continue;
				case 32:
					if (string.IsNullOrWhiteSpace(text))
					{
						num2 = 5;
						continue;
					}
					goto case 6;
				case 13:
				case 20:
				case 34:
				case 35:
					if (manifest.TagLanguageList == null)
					{
						num2 = 10;
						continue;
					}
					goto case 37;
				case 21:
					text = (string)GDxqhrEAZZakScFwUvO8(--1360331293 ^ 0x511193F9);
					num2 = 32;
					continue;
				case 38:
					result = false;
					num2 = 41;
					continue;
				case 15:
					_003C_003Ec__DisplayClass10_3.currentDataBaseStr = (string)zWV09EEAVI3NPbSyu1qy(gAuA9dEAI9mx1hHAW6DZ(text));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					cultureInfo2 = (CultureInfo)saxTKxEAqPIDsIA9BYY3();
					num2 = 11;
					continue;
				case 23:
					if (!manifest.TagLanguageList.All(_003C_003Ec__DisplayClass10_._003CValidateTags_003Eb__3))
					{
						num2 = 36;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
						{
							num2 = 14;
						}
						continue;
					}
					goto case 22;
				case 37:
					if (manifest.TagLanguageList.Any())
					{
						num2 = 30;
						continue;
					}
					goto default;
				case 2:
					_003C_003Ec__DisplayClass10_2 = new _003C_003Ec__DisplayClass10_1();
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 9;
					}
					continue;
				case 41:
				case 47:
					if (manifest.TagEditionList != null)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num2 = 28;
						}
						continue;
					}
					goto case 13;
				case 42:
					result = false;
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 34;
					}
					continue;
				case 3:
					if (manifest.TagDataBaseList.Any())
					{
						num2 = 24;
						continue;
					}
					goto case 41;
				case 39:
					result = false;
					num2 = 47;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
					{
						num2 = 26;
					}
					continue;
				case 28:
					if (!manifest.TagEditionList.Any())
					{
						num = 20;
						break;
					}
					goto case 45;
				case 24:
					text = string.Empty;
					num2 = 40;
					continue;
				case 1:
					if (manifest.TagDataBaseList.All(_003C_003Ec__DisplayClass10_3._003CValidateTags_003Eb__0))
					{
						num2 = 43;
						continue;
					}
					goto case 41;
				case 18:
					_003C_003Ec__DisplayClass10_2.currentEditionStr = editionType.ToString().ToLower();
					num2 = 33;
					continue;
				case 9:
					return true;
				case 33:
					if (!manifest.TagEditionList.All(_003C_003Ec__DisplayClass10_2._003CValidateTags_003Eb__1))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 46;
				case 45:
					editionType = VersionInfo.GetEditionType();
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 16;
					}
					continue;
				default:
					return result;
				case 30:
					_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_2();
					num = 4;
					break;
				case 26:
					if (manifest != null)
					{
						result = true;
						num2 = 44;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 26;
						}
					}
					else
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
						{
							num2 = 8;
						}
					}
					continue;
				case 40:
				{
					object obj2 = qOJHWwEA8Sfj8qfbvhlG(Locator.GetServiceNotNull<IServerInfoManager>());
					if (krVrvFEAuH2uceDO3G15(obj2, GDxqhrEAZZakScFwUvO8(0x4785BC0D ^ 0x4785CEA1)))
					{
						text = (string)GDxqhrEAZZakScFwUvO8(-889460160 ^ -889226362);
					}
					if (krVrvFEAuH2uceDO3G15(obj2, GDxqhrEAZZakScFwUvO8(0x17ADCCD8 ^ 0x17A95D24)))
					{
						text = (string)GDxqhrEAZZakScFwUvO8(0x5DD55050 ^ 0x5DD1C184);
					}
					if (krVrvFEAuH2uceDO3G15(obj2, GDxqhrEAZZakScFwUvO8(0x4EA5403C ^ 0x4EA532B8)))
					{
						num2 = 21;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 32;
				}
				case 43:
					messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-16752921 ^ -16462597), manifest.Id, manifest.TagDataBase ?? string.Empty)));
					num2 = 39;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
					{
						num2 = 12;
					}
					continue;
				case 5:
				case 14:
					messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)GDxqhrEAZZakScFwUvO8(0x571EA399 ^ 0x571A3185), manifest.Id, jsh3UEEASrgLgHnvhDDl(manifest) ?? string.Empty)));
					num2 = 38;
					continue;
				case 46:
					messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)GDxqhrEAZZakScFwUvO8(0x3630F361 ^ 0x363461CB), dbAN93EAi7PE87rGNThl(manifest), HjSl9SEARf6n6KPBN0s2(manifest) ?? string.Empty)));
					num2 = 42;
					continue;
				case 8:
				case 16:
					messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)GDxqhrEAZZakScFwUvO8(0x3A5D5EF ^ 0x3A14745), manifest.Id, manifest.TagEdition ?? string.Empty)));
					num2 = 12;
					continue;
				case 29:
					_003C_003Ec__DisplayClass10_.currentSystemLanguageStr = (string)((cultureInfo2 == null) ? string.Empty : zWV09EEAVI3NPbSyu1qy(gAuA9dEAI9mx1hHAW6DZ(cultureInfo2.ToString())));
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 6;
					}
					continue;
				case 25:
					_003C_003Ec__DisplayClass10_.currentBaseLangyageStr = ((cultureInfo == null) ? string.Empty : ((string)gAuA9dEAI9mx1hHAW6DZ(cultureInfo.ToString())).ToLower());
					num2 = 31;
					continue;
				case 22:
					{
						messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886871861), dbAN93EAi7PE87rGNThl(manifest), MT8sgAEATSgdbHExsZpT(manifest) ?? string.Empty)));
						num2 = 19;
						continue;
					}
					IL_072c:
					cultureInfo = (CultureInfo)obj;
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 29;
					}
					continue;
				}
				break;
			}
		}
	}

	public TagService()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		srd8KSEAkN3da1lVP0RW();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool r0W9J0EAClxV2bo8Js5h()
	{
		return Y76wxSEAQZhuvFqf2ErR == null;
	}

	internal static TagService eDt3gvEAv9JRre625AYW()
	{
		return Y76wxSEAQZhuvFqf2ErR;
	}

	internal static object qOJHWwEA8Sfj8qfbvhlG(object P_0)
	{
		return ((IServerInfoManager)P_0).GetMainProviderType();
	}

	internal static object GDxqhrEAZZakScFwUvO8(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool krVrvFEAuH2uceDO3G15(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object gAuA9dEAI9mx1hHAW6DZ(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static object zWV09EEAVI3NPbSyu1qy(object P_0)
	{
		return ((string)P_0).ToLower();
	}

	internal static object jsh3UEEASrgLgHnvhDDl(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).TagDataBase;
	}

	internal static object dbAN93EAi7PE87rGNThl(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).Id;
	}

	internal static object HjSl9SEARf6n6KPBN0s2(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).TagEdition;
	}

	internal static object saxTKxEAqPIDsIA9BYY3()
	{
		return SR.GetDefaultCulture();
	}

	internal static object z1BM49EAKTWd0ROxHfdx()
	{
		return SR.LanguagesMap;
	}

	internal static object EGpFgHEAXfWhalugbC5g(object P_0)
	{
		return ((CultureInfo)P_0).Name;
	}

	internal static object MT8sgAEATSgdbHExsZpT(object P_0)
	{
		return ((ElmaStoreComponentManifest)P_0).TagLanguage;
	}

	internal static void srd8KSEAkN3da1lVP0RW()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
