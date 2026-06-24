using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.BPMApps.DTO.Models;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps.Services;

[Component(Order = 100)]
public class BpmAppsBAConverter : IBPMAppItemsConverter
{
	private static readonly Guid _exportBpmAppsUid;

	private readonly ILazy<IBpmAppService> bpmAppService;

	private static BpmAppsBAConverter dlNGdcf2biKn2shqI6U3;

	public BpmAppsBAConverter(ILazy<IBpmAppService> bpmAppService)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		this.bpmAppService = bpmAppService;
	}

	public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
	{
		//Discarded unreachable code: IL_0147, IL_01c3, IL_01d2, IL_026a, IL_0279
		int num = 9;
		int num2 = num;
		BpmAppsExportSetting bpmAppsExportSetting = default(BpmAppsExportSetting);
		_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_ = default(_003C_003Ec__DisplayClass3_0);
		while (true)
		{
			switch (num2)
			{
			case 18:
			{
				if (!settings.CustomSettings.TryGetValue(BpmAppsExportConsts.ExportBpmAppsUid, out var value))
				{
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 12;
					}
				}
				else
				{
					bpmAppsExportSetting = value as BpmAppsExportSetting;
					num2 = 11;
				}
				break;
			}
			case 11:
				if (bpmAppsExportSetting != null)
				{
					num2 = 5;
					break;
				}
				return;
			case 7:
				return;
			case 5:
			{
				_003C_003Ec__DisplayClass3_0 _003C_003Ec__DisplayClass3_2 = _003C_003Ec__DisplayClass3_;
				BpmAppsBAChapter bpmAppsBAChapter = new BpmAppsBAChapter();
				UEn3ZKf2QLDnrFY5phnY(bpmAppsBAChapter, BpmAppsExportConsts.ExportBpmAppsUid);
				bpmAppsBAChapter.Components = new List<BpmAppBAItem>();
				_003C_003Ec__DisplayClass3_2.chapter = bpmAppsBAChapter;
				num2 = 4;
				break;
			}
			case 6:
				bpmAppsExportSetting.Components.ForEach(_003C_003Ec__DisplayClass3_._003CToBPMAppManifest_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 1;
				}
				break;
			case 16:
				if (_003C_003Ec__DisplayClass3_.chapter.Components.Count <= 0)
				{
					num2 = 12;
					break;
				}
				goto default;
			default:
				cxpaMYf2v552NtlJuStG(bpmAppManifest, _003C_003Ec__DisplayClass3_.chapter);
				num2 = 14;
				break;
			case 15:
				bpmAppsExportSetting.Files.ForEach(_003C_003Ec__DisplayClass3_._003CToBPMAppManifest_003Eb__1);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 10;
				}
				break;
			case 17:
				return;
			case 3:
				if (bpmAppsExportSetting.Components != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 6;
					}
					break;
				}
				goto case 1;
			case 8:
				dp1RpKf2fb6E0xwWZpM7(bpmAppManifest, JD0FcZf2E0csf15CHk5t(-2138958856 ^ -2138612886));
				num2 = 2;
				break;
			case 10:
			case 13:
				if (_003C_003Ec__DisplayClass3_.chapter.Components != null)
				{
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 6;
					}
					break;
				}
				return;
			case 12:
				return;
			case 14:
				return;
			case 1:
				if (bpmAppsExportSetting.Files == null)
				{
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 15;
			case 4:
				zjG0aff2C7Q1B2vJJK09(bpmAppManifest, _exportBpmAppsUid, true);
				num2 = 3;
				break;
			case 9:
				_003C_003Ec__DisplayClass3_ = new _003C_003Ec__DisplayClass3_0();
				num2 = 8;
				break;
			case 2:
				dp1RpKf2fb6E0xwWZpM7(settings, JD0FcZf2E0csf15CHk5t(0x61EC0CB8 ^ 0x61ECE636));
				num2 = 18;
				break;
			}
		}
	}

	public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		//Discarded unreachable code: IL_0051, IL_00ae, IL_00bd, IL_00fb, IL_01f9, IL_020c
		int num = 11;
		List<BpmAppBAItem>.Enumerator enumerator = default(List<BpmAppBAItem>.Enumerator);
		BpmAppsBAChapter bpmAppsBAChapter = default(BpmAppsBAChapter);
		List<BPMAppDTO> source = default(List<BPMAppDTO>);
		BpmAppsExportSetting bpmAppsExportSetting = default(BpmAppsExportSetting);
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		BPMAppDTO bPMAppDTO = default(BPMAppDTO);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					enumerator = bpmAppsBAChapter.Components.GetEnumerator();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					source = bpmAppService.Value.LoadAll().ToList();
					num = 2;
					break;
				case 1:
					try
					{
						while (true)
						{
							IL_014a:
							int num4;
							if (!enumerator.MoveNext())
							{
								int num3 = 4;
								num4 = num3;
								goto IL_00cc;
							}
							goto IL_0105;
							IL_00cc:
							while (true)
							{
								switch (num4)
								{
								case 7:
									bpmAppsExportSetting.Components.Add((string)JDP9qjf2Zqb5nldCG4iS(_003C_003Ec__DisplayClass4_.component), bPMAppDTO);
									num4 = 2;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
									{
										num4 = 2;
									}
									continue;
								case 2:
								case 3:
									goto IL_014a;
								case 5:
									if (bPMAppDTO == null)
									{
										num4 = 3;
										continue;
									}
									goto case 7;
								case 1:
									bPMAppDTO = source.FirstOrDefault(_003C_003Ec__DisplayClass4_._003CToExportSettings_003Eb__0);
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
									{
										num4 = 5;
									}
									continue;
								case 6:
									_003C_003Ec__DisplayClass4_.component = enumerator.Current;
									num4 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
									{
										num4 = 1;
									}
									continue;
								case 4:
									goto end_IL_014a;
								}
								break;
							}
							goto IL_0105;
							IL_0105:
							_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
							num4 = 6;
							goto IL_00cc;
							continue;
							end_IL_014a:
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					goto case 6;
				case 5:
					return;
				case 7:
					bpmAppsBAChapter = HwVNKgf28CiQBlIrgBJi(bpmAppManifest, BpmAppsExportConsts.ExportBpmAppsUid) as BpmAppsBAChapter;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 3;
					}
					continue;
				case 11:
					dp1RpKf2fb6E0xwWZpM7(bpmAppManifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459248205));
					num2 = 10;
					continue;
				default:
					if (bpmAppsBAChapter.Components == null)
					{
						num = 6;
						break;
					}
					goto case 4;
				case 10:
					Contract.ArgumentNotNull(settings, (string)JD0FcZf2E0csf15CHk5t(0x2ACE37D ^ 0x2AC09F3));
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 1;
					}
					continue;
				case 9:
					return;
				case 3:
					if (bpmAppsBAChapter != null)
					{
						bpmAppsExportSetting = new BpmAppsExportSetting();
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 0;
						}
					}
					else
					{
						num2 = 9;
					}
					continue;
				case 6:
				case 8:
					settings.CustomSettings[BpmAppsExportConsts.ExportBpmAppsUid] = bpmAppsExportSetting;
					num2 = 5;
					continue;
				}
				break;
			}
		}
	}

	static BpmAppsBAConverter()
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
				Iedv3ef2ueH6F82YGefp();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
				{
					num2 = 1;
				}
				break;
			case 0:
				return;
			case 1:
				_exportBpmAppsUid = new Guid((string)JD0FcZf2E0csf15CHk5t(0x4DC2B14D ^ 0x4DC7F9FF));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static object JD0FcZf2E0csf15CHk5t(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void dp1RpKf2fb6E0xwWZpM7(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void UEn3ZKf2QLDnrFY5phnY(object P_0, Guid value)
	{
		((BPMAppManifestChapter)P_0).Uid = value;
	}

	internal static void zjG0aff2C7Q1B2vJJK09(object P_0, Guid uid, bool value)
	{
		((BPMAppManifest)P_0).SetFlag(uid, value);
	}

	internal static void cxpaMYf2v552NtlJuStG(object P_0, object P_1)
	{
		((BPMAppManifest)P_0).SetChapter((BPMAppManifestChapter)P_1);
	}

	internal static bool WyKu31f2hWhtf4frgdXC()
	{
		return dlNGdcf2biKn2shqI6U3 == null;
	}

	internal static BpmAppsBAConverter TWGaDlf2Gc0DtgcnpeaC()
	{
		return dlNGdcf2biKn2shqI6U3;
	}

	internal static object HwVNKgf28CiQBlIrgBJi(object P_0, Guid uid)
	{
		return ((BPMAppManifest)P_0).GetChapter(uid);
	}

	internal static object JDP9qjf2Zqb5nldCG4iS(object P_0)
	{
		return ((BpmAppBAItem)P_0).BpmAppId;
	}

	internal static void Iedv3ef2ueH6F82YGefp()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
