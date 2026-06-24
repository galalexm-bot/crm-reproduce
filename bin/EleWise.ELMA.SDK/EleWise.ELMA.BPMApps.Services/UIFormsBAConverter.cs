using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.UI.BPMApps;
using EleWise.ELMA.UI.Deploy.Export;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps.Services;

[Component(Order = 520)]
public class UIFormsBAConverter : IBPMAppItemsConverter
{
	private static readonly Guid _exportUid;

	private static UIFormsBAConverter mGwFAxfexs3Ew698FvDF;

	public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
	{
		//Discarded unreachable code: IL_0059, IL_016a, IL_0179
		int num = 7;
		UIFormsBAChapter uIFormsBAChapter = default(UIFormsBAChapter);
		UIFormExportSetting uIFormExportSetting = default(UIFormExportSetting);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 4:
					return;
				case 5:
				{
					UIFormsBAChapter uIFormsBAChapter2 = new UIFormsBAChapter();
					f5xq1yfedklM0o3C7JSr(uIFormsBAChapter2, UIFormExportConsts.ExportExtensionUid);
					uIFormsBAChapter = uIFormsBAChapter2;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 0;
					}
					continue;
				}
				case 7:
					ieBpQufeywndIc7yY3g4(bpmAppManifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C50EE9));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 6;
					}
					continue;
				case 11:
				{
					if (!settings.CustomSettings.TryGetValue(UIFormExportConsts.ExportExtensionUid, out var value))
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
						{
							num2 = 8;
						}
						continue;
					}
					uIFormExportSetting = value as UIFormExportSetting;
					num = 2;
					break;
				}
				case 8:
					return;
				case 12:
					return;
				case 13:
					if (uIFormsBAChapter.Forms == null)
					{
						num = 4;
						break;
					}
					goto case 3;
				case 9:
					bpmAppManifest.SetChapter(uIFormsBAChapter);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					continue;
				case 10:
					return;
				case 2:
					if (uIFormExportSetting != null)
					{
						gagu3Vfe9vSsit8Vg9RJ(bpmAppManifest, _exportUid, XV4bMyfeJAk2ekevA8Gn(uIFormExportSetting));
						num2 = 5;
					}
					else
					{
						num2 = 8;
					}
					continue;
				case 0:
					return;
				case 6:
					ieBpQufeywndIc7yY3g4(settings, I4h2QDfeMnNLLAdY0JaP(-1108654032 ^ -1108630850));
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					if (M15uSEfelykU0ZxfMntT(uIFormsBAChapter.Forms) <= 0)
					{
						num2 = 10;
						continue;
					}
					goto case 9;
				case 1:
					uIFormsBAChapter.Forms = ((XV4bMyfeJAk2ekevA8Gn(uIFormExportSetting) && uIFormExportSetting.FormHeaderUids != null) ? uIFormExportSetting.FormHeaderUids.Select((Guid u) => new UIFormBAItem
					{
						Uid = u
					}).ToList() : new List<UIFormBAItem>());
					num = 13;
					break;
				}
				break;
			}
		}
	}

	public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		//Discarded unreachable code: IL_004d, IL_005c
		int num = 3;
		UIFormsBAChapter uIFormsBAChapter = default(UIFormsBAChapter);
		UIFormExportSetting uIFormExportSetting = default(UIFormExportSetting);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					return;
				case 7:
					uIFormsBAChapter = PVKQ6ife5E2RRt5NcoAG(bpmAppManifest, UIFormExportConsts.ExportExtensionUid) as UIFormsBAChapter;
					num2 = 5;
					continue;
				case 1:
					if (uIFormsBAChapter.Forms != null)
					{
						num2 = 10;
						continue;
					}
					break;
				case 4:
					uIFormExportSetting = new UIFormExportSetting();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 8;
					}
					continue;
				case 5:
					if (uIFormsBAChapter == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 1;
				case 8:
					DkVrkhfegZ37cZNthu8l(uIFormExportSetting, ziAZiFferdos0AgaFAQB(bpmAppManifest, _exportUid, uIFormExportSetting.ExportForms));
					num2 = 7;
					continue;
				case 3:
					ieBpQufeywndIc7yY3g4(bpmAppManifest, I4h2QDfeMnNLLAdY0JaP(0x1DE3DD89 ^ 0x1DE6951B));
					num2 = 2;
					continue;
				case 2:
					ieBpQufeywndIc7yY3g4(settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606610542));
					num2 = 4;
					continue;
				case 10:
					uIFormExportSetting.FormHeaderUids = uIFormsBAChapter.Forms.Select((UIFormBAItem f) => f.Uid).ToList();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 6;
					}
					continue;
				}
				break;
			}
			settings.CustomSettings[UIFormExportConsts.ExportExtensionUid] = uIFormExportSetting;
			num = 9;
		}
	}

	public UIFormsBAConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static UIFormsBAConverter()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				_exportUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822577414));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void ieBpQufeywndIc7yY3g4(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object I4h2QDfeMnNLLAdY0JaP(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool XV4bMyfeJAk2ekevA8Gn(object P_0)
	{
		return ((UIFormExportSetting)P_0).ExportForms;
	}

	internal static void gagu3Vfe9vSsit8Vg9RJ(object P_0, Guid uid, bool value)
	{
		((BPMAppManifest)P_0).SetFlag(uid, value);
	}

	internal static void f5xq1yfedklM0o3C7JSr(object P_0, Guid value)
	{
		((BPMAppManifestChapter)P_0).Uid = value;
	}

	internal static int M15uSEfelykU0ZxfMntT(object P_0)
	{
		return ((List<UIFormBAItem>)P_0).Count;
	}

	internal static bool mhOt9Xfe0g05fTqjIqHT()
	{
		return mGwFAxfexs3Ew698FvDF == null;
	}

	internal static UIFormsBAConverter HB6bHRfem4T42VR5Yvbs()
	{
		return mGwFAxfexs3Ew698FvDF;
	}

	internal static bool ziAZiFferdos0AgaFAQB(object P_0, Guid uid, bool defaultValue)
	{
		return ((BPMAppManifest)P_0).GetFlag(uid, defaultValue);
	}

	internal static void DkVrkhfegZ37cZNthu8l(object P_0, bool value)
	{
		((UIFormExportSetting)P_0).ExportForms = value;
	}

	internal static object PVKQ6ife5E2RRt5NcoAG(object P_0, Guid uid)
	{
		return ((BPMAppManifest)P_0).GetChapter(uid);
	}
}
