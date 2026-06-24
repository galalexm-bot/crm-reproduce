using System;
using System.Collections.Generic;
using System.Xml;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Services;
using EleWise.ELMA.UI.Deploy.Export;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Deploy.Import;

public class FormHeaderImportSaveActions : EntityImportSaveActions
{
	public static readonly Guid UID;

	internal static FormHeaderImportSaveActions lYPG7dlTD8vER6Qg4dX;

	public override bool IsSupported(Guid typeGuid)
	{
		return flQp1MlO1lxZC7E5txs(typeGuid, UID);
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		//Discarded unreachable code: IL_0216, IL_0225, IL_024b, IL_025a, IL_028f, IL_0305, IL_0356, IL_0365, IL_039b, IL_03aa, IL_040c, IL_041b, IL_048d, IL_049c, IL_04d6, IL_059f, IL_05ae, IL_05f0, IL_069a, IL_06a9, IL_06b9, IL_06c8, IL_0728, IL_0807
		int num = 62;
		XmlReader xmlReader = default(XmlReader);
		Guid result3 = default(Guid);
		FormMetadataItemHeaderManager serviceNotNull = default(FormMetadataItemHeaderManager);
		Guid result2 = default(Guid);
		string text = default(string);
		string errorMessage = default(string);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
				case 10:
				case 25:
				case 57:
					if (!St3I82l1htgWeiixhg3(xmlReader))
					{
						num = 2;
						break;
					}
					goto case 52;
				case 1:
					if (!((string)f5V90nlN3nRo5H7Z6b6(xmlReader) == FormMetadataItemHeaderManager.PropertyNames.MetadataType))
					{
						num2 = 49;
						continue;
					}
					goto default;
				case 19:
					yVDYaWlPOC4Rx9pkmRI(xmlReader);
					num2 = 41;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 44:
				case 54:
					if (flQp1MlO1lxZC7E5txs(result3, PortletMetadata.TypeUid))
					{
						num2 = 9;
						continue;
					}
					goto case 7;
				case 52:
					if (!PPjfiil3xxRgxxxFZmK(xmlReader.Name, FormMetadataItemHeaderManager.PropertyNames.DisplayName))
					{
						num2 = 59;
						continue;
					}
					goto case 6;
				case 5:
					if (xmlReader.IsEmptyElement)
					{
						num2 = 8;
						continue;
					}
					goto case 39;
				case 43:
					if (!serviceNotNull.ValidateDisplayName(result2, result3, text, out errorMessage))
					{
						num2 = 21;
						continue;
					}
					return;
				case 60:
					if (!serviceNotNull.ValidateName(result2, result3, text2, out errorMessage))
					{
						num2 = 14;
						continue;
					}
					goto case 43;
				case 13:
					if (!ttA7t3lp2HlwYwZvfRw(xmlReader))
					{
						num2 = 56;
						continue;
					}
					goto case 31;
				case 51:
					if (BSohMTlwHYsgQDtaG8n(data) == null)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 16;
				case 9:
					((BPMAppFakeManifest)aQqDvOl635KXuJQpCaV(BSohMTlwHYsgQDtaG8n(data))).GetOrCreateChapterByUid(UIFormExportConsts.ExportExtensionUidPortlet, "").GetOrCreateItemByUid(result2, text);
					num2 = 38;
					continue;
				case 39:
					xmlReader.MoveToElement();
					num2 = 32;
					continue;
				case 6:
					if (!ttA7t3lp2HlwYwZvfRw(xmlReader))
					{
						num2 = 19;
						continue;
					}
					goto case 2;
				case 65:
					result2 = Guid.Empty;
					num2 = 66;
					continue;
				case 48:
					ViZ2GSle4SZK4O4rG3s(xmlReader);
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 30;
					}
					continue;
				case 17:
					if (PPjfiil3xxRgxxxFZmK(f5V90nlN3nRo5H7Z6b6(xmlReader), FormMetadataItemHeaderManager.PropertyNames.Uid))
					{
						num2 = 13;
						continue;
					}
					goto case 31;
				case 41:
					text = xmlReader.ReadString();
					num2 = 48;
					continue;
				case 32:
					text2 = (string)rL8YculaQBor4l2pOG0(xmlReader);
					num2 = 34;
					continue;
				case 50:
					((BPMAppFakeManifest)aQqDvOl635KXuJQpCaV(BSohMTlwHYsgQDtaG8n(data))).GetOrCreateChapterByUid(UIFormExportConsts.ExportExtensionUidPage, "").GetOrCreateItemByUid(result2, text);
					num2 = 44;
					continue;
				case 53:
					xmlReader.MoveToElement();
					num2 = 24;
					continue;
				case 34:
					ViZ2GSle4SZK4O4rG3s(xmlReader);
					num2 = 26;
					continue;
				case 14:
					result.Messages.Add(new TestImportMessages(TestImportMessagesType.Warning, SR.T((string)nMcFaZlHXqnYRocCvtM(0x3C5338FF ^ 0x3C5388F7), text2, errorMessage)));
					num2 = 43;
					continue;
				case 62:
					xmlReader = (XmlReader)NBPB9El28BMBLFYjO4t(data);
					num2 = 48;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 61;
					}
					continue;
				case 24:
					Guid.TryParse((string)rL8YculaQBor4l2pOG0(xmlReader), out result3);
					num2 = 3;
					continue;
				case 2:
				case 26:
				case 30:
				case 36:
				case 59:
				case 64:
					W8ODYulDJ5rp2ce57gO(xmlReader);
					num2 = 28;
					continue;
				case 27:
					if (!PPjfiil3xxRgxxxFZmK(xmlReader.Name, FormMetadataItemHeaderManager.PropertyNames.Name))
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 5;
				case 18:
					ViZ2GSle4SZK4O4rG3s(xmlReader);
					num2 = 64;
					continue;
				case 33:
					text2 = null;
					num2 = 58;
					continue;
				case 31:
				case 40:
					if (!xmlReader.IsStartElement())
					{
						num2 = 12;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 1;
				default:
					if (!ttA7t3lp2HlwYwZvfRw(xmlReader))
					{
						num2 = 53;
						continue;
					}
					goto case 12;
				case 37:
					if (!(result3 == PageMetadata.TypeUid))
					{
						num2 = 54;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
						{
							num2 = 52;
						}
						continue;
					}
					goto case 50;
				case 56:
					yVDYaWlPOC4Rx9pkmRI(xmlReader);
					num = 45;
					break;
				case 42:
				case 47:
					if (CgoLX4lt0cnRVwbrMKS(xmlReader) == XmlNodeType.EndElement)
					{
						num = 51;
						break;
					}
					goto case 29;
				case 46:
					return;
				case 35:
					if (flQp1MlO1lxZC7E5txs(result3, Guid.Empty))
					{
						num = 63;
						break;
					}
					serviceNotNull = Locator.GetServiceNotNull<FormMetadataItemHeaderManager>();
					num2 = 60;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 31;
					}
					continue;
				case 28:
					xmlReader.MoveToContent();
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 42;
					}
					continue;
				case 4:
					xmlReader.Read();
					num = 22;
					break;
				case 16:
					if (WePJbnl4HkkVkTHF5eZ(result2, default(Guid)))
					{
						num2 = 37;
						continue;
					}
					goto case 7;
				case 61:
					ViZ2GSle4SZK4O4rG3s(xmlReader);
					num2 = 55;
					continue;
				case 66:
					result3 = Guid.Empty;
					num2 = 47;
					continue;
				case 21:
					result.Messages.Add(new TestImportMessages(TestImportMessagesType.Warning, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867781358), text, errorMessage)));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 11;
					}
					continue;
				case 63:
					result.Messages.Add(new TestImportMessages(TestImportMessagesType.Warning, SR.T((string)nMcFaZlHXqnYRocCvtM(-675505729 ^ -675534971), text2)));
					num2 = 15;
					continue;
				case 22:
					yVDYaWlPOC4Rx9pkmRI(xmlReader);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 33;
					}
					continue;
				case 20:
					result.Messages.Add(new TestImportMessages(TestImportMessagesType.Warning, SR.T((string)nMcFaZlHXqnYRocCvtM(-606654180 ^ -606630784), text2)));
					num2 = 46;
					continue;
				case 12:
				case 23:
				case 49:
					if (!St3I82l1htgWeiixhg3(xmlReader))
					{
						num2 = 10;
						continue;
					}
					goto case 27;
				case 55:
					xmlReader.MoveToElement();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 4;
					}
					continue;
				case 29:
					if (!St3I82l1htgWeiixhg3(xmlReader))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
						{
							num2 = 31;
						}
						continue;
					}
					goto case 17;
				case 15:
					return;
				case 58:
					text = null;
					num = 65;
					break;
				case 7:
				case 38:
					if (!flQp1MlO1lxZC7E5txs(result2, Guid.Empty))
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
						{
							num2 = 35;
						}
						continue;
					}
					goto case 20;
				case 11:
					return;
				case 3:
					ViZ2GSle4SZK4O4rG3s(xmlReader);
					num2 = 36;
					continue;
				case 45:
					Guid.TryParse((string)rL8YculaQBor4l2pOG0(xmlReader), out result2);
					num2 = 18;
					continue;
				}
				break;
			}
		}
	}

	public override bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data)
	{
		if (propValues == null)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852881998))));
			return false;
		}
		Locator.GetServiceNotNull<FormMetadataItemHeaderManager>();
		if (string.IsNullOrWhiteSpace(propValues.ContainsKey(FormMetadataItemHeaderManager.PropertyNames.Name) ? propValues[FormMetadataItemHeaderManager.PropertyNames.Name].ToString() : null))
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542766161))));
			return false;
		}
		Guid result = Guid.Empty;
		if (propValues.ContainsKey(FormMetadataItemHeaderManager.PropertyNames.Uid) && propValues[FormMetadataItemHeaderManager.PropertyNames.Uid] != null)
		{
			Guid.TryParse(propValues[FormMetadataItemHeaderManager.PropertyNames.Uid].ToString(), out result);
		}
		if (result == Guid.Empty)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675533965))));
			return false;
		}
		Guid result2 = Guid.Empty;
		if (propValues.ContainsKey(FormMetadataItemHeaderManager.PropertyNames.MetadataType) && propValues[FormMetadataItemHeaderManager.PropertyNames.MetadataType] != null)
		{
			Guid.TryParse(propValues[FormMetadataItemHeaderManager.PropertyNames.MetadataType].ToString(), out result2);
		}
		if (result2 == Guid.Empty)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34185E55 ^ 0x3418E0FB))));
			return false;
		}
		return true;
	}

	public override List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data)
	{
		IFormMetadataItemHeader formMetadataItemHeader = entity as IFormMetadataItemHeader;
		Func<string, TestImportMessages> func = (string e) => new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53CB464B ^ 0x53CFEEE1), e));
		if (formMetadataItemHeader == null)
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538548402));
			return new List<TestImportMessages> { func(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A1D83B))) };
		}
		List<TestImportMessages> list = new List<TestImportMessages>();
		FormMetadataItemHeaderManager serviceNotNull = Locator.GetServiceNotNull<FormMetadataItemHeaderManager>();
		if (!serviceNotNull.ValidateName(formMetadataItemHeader.Uid, formMetadataItemHeader.MetadataType, formMetadataItemHeader.Name, out var errorMessage))
		{
			int num = 0;
			string text;
			do
			{
				num++;
				text = ((!string.IsNullOrEmpty(formMetadataItemHeader.Name)) ? formMetadataItemHeader.Name : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1123633026 ^ -1123678310)) + num;
			}
			while (!serviceNotNull.ValidateName(formMetadataItemHeader.Uid, formMetadataItemHeader.MetadataType, text, out errorMessage) && num < 100);
			if (num <= 100)
			{
				list.Add(new TestImportMessages(TestImportMessagesType.Warning, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217483063), formMetadataItemHeader.Name, text)));
				formMetadataItemHeader.Name = text;
			}
			else
			{
				list.Add(new TestImportMessages(TestImportMessagesType.Warning, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867247631), formMetadataItemHeader.Name)));
			}
		}
		if (!serviceNotNull.ValidateDisplayName(formMetadataItemHeader.Uid, formMetadataItemHeader.MetadataType, formMetadataItemHeader.DisplayName, out errorMessage))
		{
			int num2 = 0;
			string text2;
			do
			{
				num2++;
				text2 = ((!string.IsNullOrEmpty(formMetadataItemHeader.DisplayName)) ? formMetadataItemHeader.DisplayName : z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA5FFD8)) + num2;
			}
			while (!serviceNotNull.ValidateDisplayName(formMetadataItemHeader.Uid, formMetadataItemHeader.MetadataType, text2, out errorMessage) && num2 < 100);
			if (num2 <= 100)
			{
				list.Add(new TestImportMessages(TestImportMessagesType.Warning, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939361170), formMetadataItemHeader.DisplayName, text2)));
				formMetadataItemHeader.DisplayName = text2;
			}
			else
			{
				list.Add(new TestImportMessages(TestImportMessagesType.Warning, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F30B9F2), formMetadataItemHeader.Name)));
			}
		}
		return list;
	}

	public FormHeaderImportSaveActions()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		u90P8klAn0dcegeReYS();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static FormHeaderImportSaveActions()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				UID = new Guid((string)nMcFaZlHXqnYRocCvtM(0x7247028A ^ 0x7247C324));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				u90P8klAn0dcegeReYS();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool flQp1MlO1lxZC7E5txs(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool IcNciKlkIAVNxLasUNj()
	{
		return lYPG7dlTD8vER6Qg4dX == null;
	}

	internal static FormHeaderImportSaveActions N8qnwilnqvM1CAbR9HA()
	{
		return lYPG7dlTD8vER6Qg4dX;
	}

	internal static object NBPB9El28BMBLFYjO4t(object P_0)
	{
		return ((ImportTestReadData)P_0).Reader;
	}

	internal static bool ViZ2GSle4SZK4O4rG3s(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool yVDYaWlPOC4Rx9pkmRI(object P_0)
	{
		return ((XmlReader)P_0).MoveToElement();
	}

	internal static bool St3I82l1htgWeiixhg3(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static object f5V90nlN3nRo5H7Z6b6(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static bool PPjfiil3xxRgxxxFZmK(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool ttA7t3lp2HlwYwZvfRw(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static object rL8YculaQBor4l2pOG0(object P_0)
	{
		return ((XmlReader)P_0).ReadString();
	}

	internal static void W8ODYulDJ5rp2ce57gO(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static XmlNodeType CgoLX4lt0cnRVwbrMKS(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static object BSohMTlwHYsgQDtaG8n(object P_0)
	{
		return ((ImportTestReadData)P_0).ConfigImportSettings;
	}

	internal static bool WePJbnl4HkkVkTHF5eZ(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object aQqDvOl635KXuJQpCaV(object P_0)
	{
		return ((IConfigImportSettings)P_0).FakeManifest;
	}

	internal static object nMcFaZlHXqnYRocCvtM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void u90P8klAn0dcegeReYS()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
