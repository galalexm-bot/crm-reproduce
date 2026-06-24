using System;
using System.Collections.Generic;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Scripts;
using EleWise.ELMA.Model.Scripts.Manager;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import;

public class ScriptModuleSaveActions : EntityImportSaveActions
{
	private readonly string tagDoNotTouch;

	public static readonly Guid Uid;

	internal static ScriptModuleSaveActions jlCx1MEmyhmyZXsZQAeh;

	public override bool IsSupported(Guid typeGuid)
	{
		return typeGuid == Uid;
	}

	private string CutOldScript(string script)
	{
		//Discarded unreachable code: IL_009a, IL_00a9
		int num = 4;
		string text = default(string);
		int num3 = default(int);
		int num5 = default(int);
		int num4 = default(int);
		int num6 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					text = script;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 3;
					}
					continue;
				case 9:
					num3 = text.IndexOf((string)z34x8oEm9mdL4YhsbNY9(-1334993905 ^ -1335281735), StringComparison.CurrentCulture);
					num2 = 7;
					continue;
				case 5:
					if (num5 >= num3)
					{
						num2 = 13;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 11;
				case 1:
					if (num4 != -1)
					{
						num2 = 6;
						continue;
					}
					goto case 13;
				case 6:
					if (num5 == num6)
					{
						num2 = 12;
						continue;
					}
					goto case 13;
				case 11:
					return (string)HFUhVREmrvSU49FUCXwQ(text, num5, num3 - num5 + ((string)z34x8oEm9mdL4YhsbNY9(-889460160 ^ -889241098)).Length);
				case 13:
					return text;
				case 7:
					num4 = M3UltuEmleXLw02wIO6T(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7243A93C), StringComparison.CurrentCulture);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
					{
						num2 = 8;
					}
					continue;
				case 12:
					if (num3 == num4)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 13;
				case 3:
					num5 = KUdbajEmdf1AugnpQijk(text, z34x8oEm9mdL4YhsbNY9(0x61EC0CB8 ^ 0x61E8A728), StringComparison.CurrentCulture);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
					{
						num2 = 0;
					}
					continue;
				case 2:
					if (num6 != -1)
					{
						num2 = 10;
						continue;
					}
					goto case 13;
				case 8:
					if (num5 != -1)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 13;
				case 10:
					if (num3 != -1)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 13;
				}
				break;
			}
			num6 = M3UltuEmleXLw02wIO6T(text, z34x8oEm9mdL4YhsbNY9(0x61EC0CB8 ^ 0x61E8A728), StringComparison.CurrentCulture);
			num = 9;
		}
	}

	public override bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data)
	{
		Guid result = Guid.Empty;
		if (propValues.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x31326106 ^ 0x31320E94)) && propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD3D80EC)] != null)
		{
			Guid.TryParse(propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269E3058)].ToString(), out result);
		}
		if (result != Guid.Empty && propValues.ContainsKey(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x830CD1C)) && propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FBB9E0)] != null)
		{
			string key = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459339015) + result;
			if (!data.ServiceData.ContainsKey(key))
			{
				return true;
			}
			ScriptModule scriptModule = Locator.GetServiceNotNull<ScriptModuleManager>().LoadOrNull(result);
			if (scriptModule == null || scriptModule.SourceCode == null)
			{
				return true;
			}
			string text = CutOldScript(scriptModule.SourceCode);
			text = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1824388195 ^ -1824087961), text.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195610959), string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787168915), Environment.NewLine)));
			propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A76B1E)] = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -881885840), CutOldScript(propValues[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146610675)].ToString()), text, tagDoNotTouch, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -868044836), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-138018305 ^ -138237367));
		}
		return true;
	}

	public override void ExecSaveActions(IEntity entity, Dictionary<string, string> serviceData)
	{
		if (entity is ScriptModule scriptModule && scriptModule.LocalReferences != null)
		{
			foreach (AssemblyReference localReference in scriptModule.LocalReferences)
			{
				if (serviceData.TryGetValue(localReference.Uid.ToString(), out var value) && Guid.TryParse(value, out var result))
				{
					localReference.Uid = result;
				}
			}
		}
		base.ExecSaveActions(entity, serviceData);
	}

	public ScriptModuleSaveActions()
	{
		//Discarded unreachable code: IL_004a, IL_004f
		k14OMoEmgAomrqFKmRAK();
		tagDoNotTouch = SR.T((string)z34x8oEm9mdL4YhsbNY9(0x1ECE530A ^ 0x1ECAFF40));
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

	static ScriptModuleSaveActions()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Uid = jMWITTEm5kFQ9wPfdx0q(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751415008));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 2:
				k14OMoEmgAomrqFKmRAK();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool MCSlFSEmMu22h01V0M7v()
	{
		return jlCx1MEmyhmyZXsZQAeh == null;
	}

	internal static ScriptModuleSaveActions RcNuGXEmJcyBg43IP8Hm()
	{
		return jlCx1MEmyhmyZXsZQAeh;
	}

	internal static object z34x8oEm9mdL4YhsbNY9(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static int KUdbajEmdf1AugnpQijk(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).IndexOf((string)P_1, P_2);
	}

	internal static int M3UltuEmleXLw02wIO6T(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).LastIndexOf((string)P_1, P_2);
	}

	internal static object HFUhVREmrvSU49FUCXwQ(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Remove(P_1, P_2);
	}

	internal static void k14OMoEmgAomrqFKmRAK()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Guid jMWITTEm5kFQ9wPfdx0q(object P_0)
	{
		return Guid.Parse((string)P_0);
	}
}
