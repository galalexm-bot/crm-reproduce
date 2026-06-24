using System;
using System.Xml;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import;

internal sealed class DataClassHeaderImportSaveActions : EntityImportSaveActions
{
	private static readonly Guid Uid;

	private readonly IFeatureFlagService featureFlagService;

	private static DataClassHeaderImportSaveActions cB9Qe1ExxEKmTUothhRQ;

	public DataClassHeaderImportSaveActions(IFeatureFlagService featureFlagService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		yRstKgExybHk0HXyo43U();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			this.featureFlagService = featureFlagService;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
			{
				num = 1;
			}
		}
	}

	public override bool IsSupported(Guid typeGuid)
	{
		return typeGuid == Uid;
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		//Discarded unreachable code: IL_00f2, IL_0128, IL_0222, IL_02e8, IL_02f7, IL_0388, IL_0397, IL_03a6, IL_0408, IL_0417
		int num = 14;
		XmlReader xmlReader = default(XmlReader);
		Guid result2 = default(Guid);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 26:
					if (hRkNPGExlZAG7rNaWxtv(OOf4v5ExdFcJ3IUrZHgm(xmlReader), DataClassMetadataItemHeaderManager._Resources_PropertyNames.DisplayName))
					{
						num2 = 38;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 38;
						}
						continue;
					}
					goto case 12;
				case 19:
					return;
				case 33:
					return;
				case 32:
					if (t3aUyHExg1s20VZETltj(xmlReader))
					{
						num2 = 39;
						continue;
					}
					goto default;
				case 12:
				case 22:
				case 28:
				case 30:
				case 34:
					SUHBoNExjuXt9Kjfts5i(xmlReader);
					num2 = 37;
					continue;
				case 11:
					if (!h5hrQvExr4s85og1Z3Jr(xmlReader))
					{
						num2 = 3;
						continue;
					}
					goto default;
				case 21:
					NZLG6AExJKlueaiFRJSd(xmlReader);
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
					{
						num2 = 7;
					}
					continue;
				case 39:
					if (hRkNPGExlZAG7rNaWxtv(OOf4v5ExdFcJ3IUrZHgm(xmlReader), DataClassMetadataItemHeaderManager._Resources_PropertyNames.Name))
					{
						num = 11;
						break;
					}
					goto default;
				case 4:
					if (!h5hrQvExr4s85og1Z3Jr(xmlReader))
					{
						num2 = 21;
						continue;
					}
					goto case 32;
				case 7:
					Guid.TryParse(xmlReader.ReadString(), out result2);
					num2 = 6;
					continue;
				case 37:
					xmlReader.MoveToContent();
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 6;
					}
					continue;
				case 27:
					if (xmlReader.IsStartElement())
					{
						num2 = 9;
						continue;
					}
					goto case 32;
				case 16:
					gWrklqEx9vFnL7iRxEYU(xmlReader);
					num = 30;
					break;
				case 14:
					xmlReader = (XmlReader)r1kTWeExMFlkxrD8ehw5(data);
					num2 = 13;
					continue;
				case 31:
					NZLG6AExJKlueaiFRJSd(xmlReader);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					xmlReader.Read();
					num2 = 12;
					continue;
				case 24:
					gWrklqEx9vFnL7iRxEYU(xmlReader);
					num2 = 31;
					continue;
				case 18:
					result2 = Guid.Empty;
					num = 17;
					break;
				case 8:
				case 17:
					if (nCXyvCExYljfyyMxeMAU(xmlReader) == XmlNodeType.EndElement)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
						{
							num2 = 35;
						}
						continue;
					}
					goto case 27;
				case 20:
					xmlReader.ReadString();
					num2 = 5;
					continue;
				case 25:
					NZLG6AExJKlueaiFRJSd(xmlReader);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 24;
					}
					continue;
				case 15:
					return;
				case 2:
					if (!YX06nnExU32SGHHKgZL7(result2, Guid.Empty))
					{
						num2 = 33;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 23;
				case 9:
					if (hRkNPGExlZAG7rNaWxtv(OOf4v5ExdFcJ3IUrZHgm(xmlReader), DataClassMetadataItemHeaderManager._Resources_PropertyNames.Uid))
					{
						num2 = 4;
						continue;
					}
					goto case 32;
				case 13:
					xmlReader.Read();
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 16;
					}
					continue;
				case 36:
					text = (string)YNqqxFEx5oyqDVHNsT4M(xmlReader);
					num2 = 16;
					continue;
				case 10:
					xmlReader.MoveToElement();
					num2 = 36;
					continue;
				case 23:
					((BPMAppFakeManifest)t0JkTxExcTYQ5JQHLYPr(M5D3tCExsLNI1xo9sTW7(data))).GetOrCreateChapterByUid(ObjectsExportConsts.ExportExtensionUidDataClass, "").GetOrCreateItemByUid(result2, text);
					num2 = 19;
					continue;
				case 3:
					NZLG6AExJKlueaiFRJSd(xmlReader);
					num2 = 20;
					continue;
				case 5:
					xmlReader.Read();
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 22;
					}
					continue;
				case 35:
					if (featureFlagService.Enabled((string)JCoYkjExLwDbi1ceKJDh(-542721635 ^ -542763113), defaultEnabled: false))
					{
						num2 = 2;
						continue;
					}
					goto case 29;
				default:
					if (!t3aUyHExg1s20VZETltj(xmlReader))
					{
						num2 = 28;
						continue;
					}
					goto case 26;
				case 38:
					if (h5hrQvExr4s85og1Z3Jr(xmlReader))
					{
						num2 = 34;
						continue;
					}
					goto case 10;
				case 29:
					result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)JCoYkjExLwDbi1ceKJDh(-218496594 ^ -218195428), text)));
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 10;
					}
					continue;
				case 1:
					text = null;
					num2 = 18;
					continue;
				}
				break;
			}
		}
	}

	static DataClassHeaderImportSaveActions()
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
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Uid = InterfaceActivator.UID<DataClassMetadataItemHeader>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void yRstKgExybHk0HXyo43U()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool B8WpaREx0ib5Q4f8Qf7P()
	{
		return cB9Qe1ExxEKmTUothhRQ == null;
	}

	internal static DataClassHeaderImportSaveActions XoUOSZExmsdPv4Nq8mUe()
	{
		return cB9Qe1ExxEKmTUothhRQ;
	}

	internal static object r1kTWeExMFlkxrD8ehw5(object P_0)
	{
		return ((ImportTestReadData)P_0).Reader;
	}

	internal static bool NZLG6AExJKlueaiFRJSd(object P_0)
	{
		return ((XmlReader)P_0).MoveToElement();
	}

	internal static bool gWrklqEx9vFnL7iRxEYU(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static object OOf4v5ExdFcJ3IUrZHgm(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static bool hRkNPGExlZAG7rNaWxtv(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool h5hrQvExr4s85og1Z3Jr(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static bool t3aUyHExg1s20VZETltj(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static object YNqqxFEx5oyqDVHNsT4M(object P_0)
	{
		return ((XmlReader)P_0).ReadString();
	}

	internal static void SUHBoNExjuXt9Kjfts5i(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static XmlNodeType nCXyvCExYljfyyMxeMAU(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static object JCoYkjExLwDbi1ceKJDh(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool YX06nnExU32SGHHKgZL7(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object M5D3tCExsLNI1xo9sTW7(object P_0)
	{
		return ((ImportTestReadData)P_0).ConfigImportSettings;
	}

	internal static object t0JkTxExcTYQ5JQHLYPr(object P_0)
	{
		return ((IConfigImportSettings)P_0).FakeManifest;
	}
}
