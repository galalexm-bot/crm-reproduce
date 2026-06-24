using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Model.Scripts.BPMApps;
using EleWise.ELMA.Model.Scripts.Deploy.Export;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.BPMApps.Services;

[Component(Order = 800)]
public class ScriptModulesBAConverter : IBPMAppItemsConverter
{
	private static readonly Guid _exportUid;

	internal static ScriptModulesBAConverter GHoKt4feVRgRpReg8SFO;

	public void ToBPMAppManifest(ConfigExportSettings settings, BPMAppManifest bpmAppManifest)
	{
		//Discarded unreachable code: IL_00c9, IL_0147, IL_0156
		int num = 13;
		ScriptModulesBAChapter scriptModulesBAChapter = default(ScriptModulesBAChapter);
		ScriptModuleExportSetting scriptModuleExportSetting = default(ScriptModuleExportSetting);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 3:
					if (scriptModulesBAChapter.Modules != null)
					{
						num2 = 11;
						break;
					}
					return;
				case 12:
					aC0hxHfeRaseLFpLU7uq(settings, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -672079947));
					num2 = 2;
					break;
				case 11:
					if (EGVbgNfeTPU8vtIdI02g(scriptModulesBAChapter.Modules) <= 0)
					{
						goto end_IL_0012;
					}
					goto case 4;
				case 1:
					return;
				case 10:
					return;
				case 13:
					aC0hxHfeRaseLFpLU7uq(bpmAppManifest, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E15649));
					num2 = 12;
					break;
				case 8:
				{
					ScriptModulesBAChapter scriptModulesBAChapter2 = new ScriptModulesBAChapter();
					maCeDrfeXcR1QgYLASPn(scriptModulesBAChapter2, ScriptModuleExportConsts.ExportExtensionUid);
					scriptModulesBAChapter = scriptModulesBAChapter2;
					num2 = 6;
					break;
				}
				case 0:
					return;
				case 5:
					JEO1vOfeKxpky3ZHkRWh(bpmAppManifest, _exportUid, oJgsmsfeqRGGT0pj9eSI(scriptModuleExportSetting));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 4;
					}
					break;
				case 4:
					DHmoBtfekvAeCbFRitZm(bpmAppManifest, scriptModulesBAChapter);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 9;
					}
					break;
				case 9:
					return;
				case 7:
					if (scriptModuleExportSetting == null)
					{
						return;
					}
					num2 = 5;
					break;
				case 2:
				{
					if (settings.CustomSettings.TryGetValue(ScriptModuleExportConsts.ExportExtensionUid, out var value))
					{
						scriptModuleExportSetting = value as ScriptModuleExportSetting;
						num2 = 7;
						break;
					}
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
					{
						num2 = 1;
					}
					break;
				}
				case 6:
					scriptModulesBAChapter.Modules = ((scriptModuleExportSetting.ExportScriptModules && scriptModuleExportSetting.ScriptModuleUids != null) ? scriptModuleExportSetting.ScriptModuleUids.Select((Guid u) => new ScriptModuleBAItem
					{
						Uid = u
					}).ToList() : new List<ScriptModuleBAItem>());
					num2 = 3;
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 10;
		}
	}

	public void ToExportSettings(BPMAppManifest bpmAppManifest, ConfigExportSettings settings)
	{
		//Discarded unreachable code: IL_004d
		int num = 7;
		int num2 = num;
		ScriptModuleExportSetting scriptModuleExportSetting = default(ScriptModuleExportSetting);
		ScriptModulesBAChapter scriptModulesBAChapter = default(ScriptModulesBAChapter);
		while (true)
		{
			switch (num2)
			{
			case 10:
				cOTQqqfe2TJOD7DQxkU8(scriptModuleExportSetting, wRr5bsfeOedvJ4DfMqMY(bpmAppManifest, _exportUid, oJgsmsfeqRGGT0pj9eSI(scriptModuleExportSetting)));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num2 = 1;
				}
				continue;
			case 6:
				Contract.ArgumentNotNull(settings, (string)Bd8sKEfen0TgtXyarCMk(-1837662597 ^ -1837656843));
				num2 = 8;
				continue;
			case 1:
				scriptModulesBAChapter = bpmAppManifest.GetChapter(ScriptModuleExportConsts.ExportExtensionUid) as ScriptModulesBAChapter;
				num2 = 3;
				continue;
			case 2:
			case 4:
				settings.CustomSettings[ScriptModuleExportConsts.ExportExtensionUid] = scriptModuleExportSetting;
				num2 = 9;
				continue;
			case 7:
				Contract.ArgumentNotNull(bpmAppManifest, (string)Bd8sKEfen0TgtXyarCMk(0x7E6E5A0B ^ 0x7E6B1299));
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 3;
				}
				continue;
			default:
				if (scriptModulesBAChapter.Modules == null)
				{
					num2 = 4;
					continue;
				}
				break;
			case 9:
				return;
			case 8:
				scriptModuleExportSetting = new ScriptModuleExportSetting();
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 8;
				}
				continue;
			case 3:
				if (scriptModulesBAChapter != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			case 5:
				break;
			}
			scriptModuleExportSetting.ScriptModuleUids = scriptModulesBAChapter.Modules.Select((ScriptModuleBAItem f) => _003C_003Ec.HTE29CZF8JNZtmPgyYeG(f)).ToList();
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
			{
				num2 = 2;
			}
		}
	}

	public ScriptModulesBAConverter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static ScriptModulesBAConverter()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				BY6ak6feepLdcYA2pL9R();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_exportUid = new Guid(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C50C39));
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void aC0hxHfeRaseLFpLU7uq(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static bool oJgsmsfeqRGGT0pj9eSI(object P_0)
	{
		return ((ScriptModuleExportSetting)P_0).ExportScriptModules;
	}

	internal static void JEO1vOfeKxpky3ZHkRWh(object P_0, Guid uid, bool value)
	{
		((BPMAppManifest)P_0).SetFlag(uid, value);
	}

	internal static void maCeDrfeXcR1QgYLASPn(object P_0, Guid value)
	{
		((BPMAppManifestChapter)P_0).Uid = value;
	}

	internal static int EGVbgNfeTPU8vtIdI02g(object P_0)
	{
		return ((List<ScriptModuleBAItem>)P_0).Count;
	}

	internal static void DHmoBtfekvAeCbFRitZm(object P_0, object P_1)
	{
		((BPMAppManifest)P_0).SetChapter((BPMAppManifestChapter)P_1);
	}

	internal static bool LymB6KfeSGChUblocU1b()
	{
		return GHoKt4feVRgRpReg8SFO == null;
	}

	internal static ScriptModulesBAConverter js9HG3feifqjd5onXIqW()
	{
		return GHoKt4feVRgRpReg8SFO;
	}

	internal static object Bd8sKEfen0TgtXyarCMk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool wRr5bsfeOedvJ4DfMqMY(object P_0, Guid uid, bool defaultValue)
	{
		return ((BPMAppManifest)P_0).GetFlag(uid, defaultValue);
	}

	internal static void cOTQqqfe2TJOD7DQxkU8(object P_0, bool value)
	{
		((ScriptModuleExportSetting)P_0).ExportScriptModules = value;
	}

	internal static void BY6ak6feepLdcYA2pL9R()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
