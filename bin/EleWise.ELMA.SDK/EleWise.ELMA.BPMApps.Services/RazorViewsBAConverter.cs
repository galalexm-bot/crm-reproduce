using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps.Services;

[Component(Order = 570)]
public class RazorViewsBAConverter : IBPMAppItemsConverter
{
	private static readonly Guid _exportUid;

	internal static RazorViewsBAConverter FBFORYfeoHeSDmuTl5bT;

	public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
	{
		int num = 4;
		int num2 = num;
		RazorViewsExportSetting razorViewsExportSetting = default(RazorViewsExportSetting);
		RazorViewsBAChapter razorViewsBAChapter = default(RazorViewsBAChapter);
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (razorViewsExportSetting == null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 8;
					}
					break;
				}
				QRXJRsfefLYjYnOB3ZDs(bpmAppManifest, _exportUid, VFgBxHfeENf1NX0Y5A3q(razorViewsExportSetting));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
				{
					num2 = 10;
				}
				break;
			case 8:
				return;
			case 10:
			{
				RazorViewsBAChapter razorViewsBAChapter2 = new RazorViewsBAChapter();
				JgKoKufeQDpGGrwLE235(razorViewsBAChapter2, RazorViewsExportConsts.ExportExtensionUid);
				razorViewsBAChapter = razorViewsBAChapter2;
				num2 = 9;
				break;
			}
			case 11:
				HqBFCefevTDODIkNWRfn(bpmAppManifest, razorViewsBAChapter);
				num2 = 7;
				break;
			case 1:
				return;
			case 6:
				if (wPwW3hfeCYPoY5y2c5IP(razorViewsBAChapter.ViewVirtualPaths) > 0)
				{
					num2 = 11;
					break;
				}
				return;
			case 3:
				Contract.ArgumentNotNull(settings, (string)cMjsXhfeGuviH5e8Jg3n(--1418440330 ^ 0x548B4404));
				num2 = 5;
				break;
			case 5:
			{
				if (settings.CustomSettings.TryGetValue(RazorViewsExportConsts.ExportExtensionUid, out var value))
				{
					razorViewsExportSetting = value as RazorViewsExportSetting;
					num2 = 2;
					break;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num2 = 1;
				}
				break;
			}
			case 7:
				return;
			case 4:
				Contract.ArgumentNotNull(bpmAppManifest, (string)cMjsXhfeGuviH5e8Jg3n(-672123589 ^ -671777367));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
				{
					num2 = 2;
				}
				break;
			default:
				if (razorViewsBAChapter.ViewVirtualPaths == null)
				{
					return;
				}
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
				{
					num2 = 1;
				}
				break;
			case 9:
				razorViewsBAChapter.ViewVirtualPaths = ((VFgBxHfeENf1NX0Y5A3q(razorViewsExportSetting) && razorViewsExportSetting.ViewVirtualPaths != null) ? razorViewsExportSetting.ViewVirtualPaths.Select(delegate(string p)
				{
					RazorViewBAItem razorViewBAItem = new RazorViewBAItem();
					_003C_003Ec.Xa9WfdZFGAoHCJy8W561(razorViewBAItem, p);
					return razorViewBAItem;
				}).ToList() : new List<RazorViewBAItem>());
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		//Discarded unreachable code: IL_0082, IL_0141
		int num = 9;
		RazorViewsBAChapter razorViewsBAChapter = default(RazorViewsBAChapter);
		RazorViewsExportSetting razorViewsExportSetting = default(RazorViewsExportSetting);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (razorViewsBAChapter == null)
					{
						num2 = 6;
						continue;
					}
					goto case 11;
				case 8:
					Uqa8OWfe8O2cFgI97eKI(settings, cMjsXhfeGuviH5e8Jg3n(-1710575414 ^ -1710597564));
					num2 = 10;
					continue;
				case 10:
					razorViewsExportSetting = new RazorViewsExportSetting();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
					{
						num2 = 2;
					}
					continue;
				case 11:
					if (razorViewsBAChapter.ViewVirtualPaths == null)
					{
						num2 = 7;
						continue;
					}
					break;
				case 2:
					razorViewsBAChapter = tevhGlfeuXEmWuetAypw(bpmAppManifest, RazorViewsExportConsts.ExportExtensionUid) as RazorViewsBAChapter;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					settings.CustomSettings[RazorViewsExportConsts.ExportExtensionUid] = razorViewsExportSetting;
					num2 = 5;
					continue;
				case 9:
					Uqa8OWfe8O2cFgI97eKI(bpmAppManifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487075084));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 8;
					}
					continue;
				case 5:
					return;
				case 4:
					goto end_IL_0012;
				case 3:
					break;
				}
				razorViewsExportSetting.ViewVirtualPaths = razorViewsBAChapter.ViewVirtualPaths.Select((RazorViewBAItem i) => (string)_003C_003Ec.fxZAX5ZFEAr5DCmXfJoK(i)).ToList();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			ADJ0nTfeZNkJ34JIsTub(razorViewsExportSetting, bpmAppManifest.GetFlag(_exportUid, razorViewsExportSetting.ExportViews));
			num = 2;
		}
	}

	public RazorViewsBAConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		nRLGAffeIAKRIKhnHrpC();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static RazorViewsBAConverter()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_exportUid = new Guid((string)cMjsXhfeGuviH5e8Jg3n(-1886646897 ^ -1886829443));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static object cMjsXhfeGuviH5e8Jg3n(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool VFgBxHfeENf1NX0Y5A3q(object P_0)
	{
		return ((RazorViewsExportSetting)P_0).ExportViews;
	}

	internal static void QRXJRsfefLYjYnOB3ZDs(object P_0, Guid uid, bool value)
	{
		((BPMAppManifest)P_0).SetFlag(uid, value);
	}

	internal static void JgKoKufeQDpGGrwLE235(object P_0, Guid value)
	{
		((BPMAppManifestChapter)P_0).Uid = value;
	}

	internal static int wPwW3hfeCYPoY5y2c5IP(object P_0)
	{
		return ((List<RazorViewBAItem>)P_0).Count;
	}

	internal static void HqBFCefevTDODIkNWRfn(object P_0, object P_1)
	{
		((BPMAppManifest)P_0).SetChapter((BPMAppManifestChapter)P_1);
	}

	internal static bool tNdAwgfebt3OK5sr7Jpc()
	{
		return FBFORYfeoHeSDmuTl5bT == null;
	}

	internal static RazorViewsBAConverter BtLGJqfehxoKsKsay58R()
	{
		return FBFORYfeoHeSDmuTl5bT;
	}

	internal static void Uqa8OWfe8O2cFgI97eKI(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static void ADJ0nTfeZNkJ34JIsTub(object P_0, bool value)
	{
		((RazorViewsExportSetting)P_0).ExportViews = value;
	}

	internal static object tevhGlfeuXEmWuetAypw(object P_0, Guid uid)
	{
		return ((BPMAppManifest)P_0).GetChapter(uid);
	}

	internal static void nRLGAffeIAKRIKhnHrpC()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
