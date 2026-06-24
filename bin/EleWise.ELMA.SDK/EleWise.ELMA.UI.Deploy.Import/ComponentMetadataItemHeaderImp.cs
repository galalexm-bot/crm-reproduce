using System;
using System.Collections.Generic;
using System.Xml;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.UI.Deploy.Export;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Deploy.Import;

internal sealed class ComponentMetadataItemHeaderImportSaveActions : EntityImportSaveActions
{
	private static readonly Guid Uid;

	private readonly IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager;

	private readonly IFeatureFlagService featureFlagService;

	private static ComponentMetadataItemHeaderImportSaveActions xHAaPZdt19SM8bdIJmy;

	public ComponentMetadataItemHeaderImportSaveActions(IComponentMetadataItemHeaderManager componentMetadataItemHeaderManager, IFeatureFlagService featureFlagService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this.featureFlagService = featureFlagService;
				num = 2;
				break;
			case 1:
				this.componentMetadataItemHeaderManager = componentMetadataItemHeaderManager;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public override bool IsSupported(Guid typeGuid)
	{
		return typeGuid == Uid;
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		//Discarded unreachable code: IL_0340, IL_040f, IL_041e, IL_042e, IL_043d, IL_04c7, IL_0629, IL_0638, IL_066b, IL_067a, IL_0710, IL_071f, IL_0770, IL_077f, IL_0867, IL_0876, IL_0885, IL_08e1, IL_0927, IL_0936, IL_0958, IL_0967, IL_0976
		int num = 66;
		Guid result3 = default(Guid);
		string text = default(string);
		string errorMessage = default(string);
		XmlReader reader = default(XmlReader);
		string text2 = default(string);
		Guid result2 = default(Guid);
		BPMAppManifestFakeChapter orCreateChapterByUid = default(BPMAppManifestFakeChapter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 43:
				case 62:
					if (!componentMetadataItemHeaderManager.ValidateDisplayName(result3, text, out errorMessage))
					{
						num2 = 4;
						continue;
					}
					goto case 19;
				case 32:
				case 45:
				case 55:
					if (!hysUC4dAEHxn7eY9rEi(reader))
					{
						num2 = 23;
						continue;
					}
					goto case 16;
				case 35:
					return;
				case 42:
					FHpqg1d6f0232ZtOjjK(reader);
					num2 = 51;
					continue;
				case 40:
					result.Messages.Add(new TestImportMessages(TestImportMessagesType.Warning, SR.T((string)SR4Dn5d9IkNOKEYC9my(-957824448 ^ -957844920), text2, errorMessage)));
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 62;
					}
					continue;
				case 15:
					return;
				case 36:
					if (D1Gbsndl7ddSXxhlkWN(result2, PortletComponentMetadata.TypeUid))
					{
						num2 = 3;
						continue;
					}
					goto case 34;
				case 27:
				case 58:
					if (dJkcSrdJ6yeta6qwM85(reader) == XmlNodeType.EndElement)
					{
						num = 49;
						break;
					}
					goto case 25;
				case 59:
					reader.Read();
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 5;
					}
					continue;
				case 8:
					reader.MoveToElement();
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 17;
					}
					continue;
				case 33:
					result.Messages.Add(new TestImportMessages(TestImportMessagesType.Warning, SR.T((string)SR4Dn5d9IkNOKEYC9my(0x4D1C1EE4 ^ 0x4D1CB1BC), text2)));
					num2 = 15;
					continue;
				case 9:
					orCreateChapterByUid = ((BPMAppFakeManifest)OfQWFTdgCuEc8oRCXQ7(FZV5oxdrcHBdLvNwRv4(data))).GetOrCreateChapterByUid(UIFormExportConsts.ExportExtensionUidPage, "");
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 53;
					}
					continue;
				case 34:
					orCreateChapterByUid = ((BPMAppFakeManifest)OfQWFTdgCuEc8oRCXQ7(FZV5oxdrcHBdLvNwRv4(data))).GetOrCreateChapterByUid(ComponentExportConsts.ExportExtensionUid, "");
					num2 = 2;
					continue;
				case 18:
					if (!VpAX7bdx8DFq476gF7E(CuFidsd7FcbhWixlLDm(reader), ComponentMetadataItemHeaderManager._Resources_PropertyNames.Uid))
					{
						num2 = 11;
						continue;
					}
					goto case 6;
				case 52:
					ljNQKydHBMpXxvELvYG(reader);
					num2 = 10;
					continue;
				case 63:
					if (D1Gbsndl7ddSXxhlkWN(result2, PageComponentMetadata.TypeUid))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 36;
				case 39:
					ljNQKydHBMpXxvELvYG(reader);
					num2 = 46;
					continue;
				case 19:
					if (result3 != Guid.Empty)
					{
						num2 = 63;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
						{
							num2 = 42;
						}
						continue;
					}
					return;
				case 22:
					if (kTaFQ1d0Wc0t3ZRb0lw(reader))
					{
						num2 = 55;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 52;
				case 48:
					if (VpAX7bdx8DFq476gF7E(CuFidsd7FcbhWixlLDm(reader), ComponentMetadataItemHeaderManager._Resources_PropertyNames.DisplayName))
					{
						num2 = 22;
						continue;
					}
					goto case 32;
				case 56:
					ljNQKydHBMpXxvELvYG(reader);
					num2 = 14;
					continue;
				case 49:
					if (aCVNpQddKeTW63E7lw4(featureFlagService, SR4Dn5d9IkNOKEYC9my(0x42643203 ^ 0x42649C09), false))
					{
						if (D1Gbsndl7ddSXxhlkWN(result3, Guid.Empty))
						{
							num2 = 33;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
							{
								num2 = 20;
							}
							continue;
						}
						if (componentMetadataItemHeaderManager.ValidateName(result3, text2, out errorMessage))
						{
							num2 = 43;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
							{
								num2 = 22;
							}
							continue;
						}
						goto case 40;
					}
					num = 38;
					break;
				case 29:
					Guid.TryParse((string)ENaoYqdmoVb0IpgBn72(reader), out result2);
					num2 = 57;
					continue;
				case 1:
				case 11:
				case 24:
				case 30:
					if (!reader.IsStartElement())
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 20;
				case 28:
					text = null;
					num2 = 39;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 47;
					}
					continue;
				case 65:
					FHpqg1d6f0232ZtOjjK(reader);
					num = 8;
					break;
				case 20:
					if (VpAX7bdx8DFq476gF7E(CuFidsd7FcbhWixlLDm(reader), ComponentMetadataItemHeaderManager._Resources_PropertyNames.Name))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 12;
				case 2:
				case 53:
				case 54:
					orCreateChapterByUid.GetOrCreateItemByUid(result3, text);
					num2 = 7;
					continue;
				case 4:
					result.Messages.Add(new TestImportMessages(TestImportMessagesType.Warning, SR.T((string)SR4Dn5d9IkNOKEYC9my(0x42643203 ^ 0x4264835D), text, errorMessage)));
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 5;
					}
					continue;
				case 60:
					ljNQKydHBMpXxvELvYG(reader);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 5;
					}
					continue;
				case 16:
					if (!VpAX7bdx8DFq476gF7E(CuFidsd7FcbhWixlLDm(reader), ComponentMetadataItemHeaderManager._Resources_PropertyNames.MetadataTypeUid))
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
						{
							num2 = 31;
						}
						continue;
					}
					goto case 64;
				case 17:
					FHpqg1d6f0232ZtOjjK(reader);
					num2 = 56;
					continue;
				case 5:
					text2 = reader.ReadString();
					num2 = 50;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 == 0)
					{
						num2 = 42;
					}
					continue;
				case 6:
					if (kTaFQ1d0Wc0t3ZRb0lw(reader))
					{
						num2 = 24;
						continue;
					}
					goto case 39;
				case 21:
				case 23:
				case 26:
				case 31:
				case 37:
				case 51:
					tQFOVudyMOrHtsbR5Wt(reader);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
					{
						num2 = 13;
					}
					continue;
				case 46:
					Guid.TryParse(reader.ReadString(), out result3);
					num2 = 49;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 59;
					}
					continue;
				case 64:
					if (!reader.IsEmptyElement)
					{
						num2 = 16;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 44;
						}
						continue;
					}
					goto case 21;
				case 14:
					text2 = null;
					num2 = 28;
					continue;
				case 44:
					ljNQKydHBMpXxvELvYG(reader);
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be != 0)
					{
						num2 = 14;
					}
					continue;
				case 13:
					VMeIbidM17CNxhilK4i(reader);
					num2 = 27;
					continue;
				case 10:
					text = (string)ENaoYqdmoVb0IpgBn72(reader);
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 42;
					}
					continue;
				case 7:
					return;
				case 38:
					result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)SR4Dn5d9IkNOKEYC9my(0x103FE975 ^ 0x103F472D), text)));
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 23;
					}
					continue;
				case 3:
					orCreateChapterByUid = ((BPMAppFakeManifest)OfQWFTdgCuEc8oRCXQ7(FZV5oxdrcHBdLvNwRv4(data))).GetOrCreateChapterByUid(UIFormExportConsts.ExportExtensionUidPortlet, "");
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 54;
					}
					continue;
				case 50:
					FHpqg1d6f0232ZtOjjK(reader);
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 26;
					}
					continue;
				case 47:
					result3 = Guid.Empty;
					num2 = 41;
					continue;
				case 12:
				case 61:
					if (!hysUC4dAEHxn7eY9rEi(reader))
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num2 = 32;
						}
						continue;
					}
					goto case 48;
				default:
					if (!kTaFQ1d0Wc0t3ZRb0lw(reader))
					{
						num2 = 60;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 51;
						}
						continue;
					}
					goto case 12;
				case 41:
					result2 = Guid.Empty;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 58;
					}
					continue;
				case 25:
					if (!hysUC4dAEHxn7eY9rEi(reader))
					{
						num2 = 30;
						continue;
					}
					goto case 18;
				case 66:
					reader = data.Reader;
					num2 = 65;
					continue;
				case 57:
					reader.Read();
					num = 37;
					break;
				}
				break;
			}
		}
	}

	public override bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data)
	{
		if (propValues == null)
		{
			CreateDeployMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822926930)));
			return false;
		}
		string value = string.Empty;
		if (propValues.TryGetValue(ComponentMetadataItemHeaderManager._Resources_PropertyNames.Name, out var value2))
		{
			value = value2.ToString();
		}
		if (string.IsNullOrWhiteSpace(value))
		{
			CreateDeployMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767765047)));
			return false;
		}
		Guid result = Guid.Empty;
		if (propValues.TryGetValue(ComponentMetadataItemHeaderManager._Resources_PropertyNames.Uid, out var value3) && value3 != null)
		{
			Guid.TryParse(value3.ToString(), out result);
		}
		if (result == Guid.Empty)
		{
			CreateDeployMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A5D5EF ^ 0x3A56723)));
			return false;
		}
		return true;
		void CreateDeployMessage(string message)
		{
			int num = 1;
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
					data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, message));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data)
	{
		List<TestImportMessages> messages = new List<TestImportMessages>();
		if (!(entity is ComponentMetadataItemHeader componentMetadataItemHeader))
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x42643203 ^ 0x42648167));
			messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A618644), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218450468)))));
			return messages;
		}
		if (!componentMetadataItemHeaderManager.ValidateName(componentMetadataItemHeader.Uid, componentMetadataItemHeader.Name, out var errorMessage))
		{
			int num = 0;
			string text;
			do
			{
				num++;
				text = ((!string.IsNullOrEmpty(componentMetadataItemHeader.Name)) ? componentMetadataItemHeader.Name : z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4CCF9F)) + num;
			}
			while (!componentMetadataItemHeaderManager.ValidateName(componentMetadataItemHeader.Uid, text, out errorMessage) && num < 100);
			if (num <= 100)
			{
				AddImportMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1852881208), componentMetadataItemHeader.Name, text));
				componentMetadataItemHeader.Name = text;
			}
			else
			{
				AddImportMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1426094279 ^ -1426115981), componentMetadataItemHeader.Name));
			}
		}
		if (!componentMetadataItemHeaderManager.ValidateDisplayName(componentMetadataItemHeader.Uid, componentMetadataItemHeader.DisplayName, out errorMessage))
		{
			int num2 = 0;
			string text2;
			do
			{
				num2++;
				text2 = ((!string.IsNullOrEmpty(componentMetadataItemHeader.DisplayName)) ? componentMetadataItemHeader.DisplayName : z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA599EF7)) + num2;
			}
			while (!componentMetadataItemHeaderManager.ValidateDisplayName(componentMetadataItemHeader.Uid, text2, out errorMessage) && num2 < 100);
			if (num2 <= 100)
			{
				AddImportMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317754622), componentMetadataItemHeader.DisplayName, text2));
				componentMetadataItemHeader.DisplayName = text2;
			}
			else
			{
				AddImportMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1217523399 ^ -1217485049), componentMetadataItemHeader.Name));
			}
		}
		return messages;
		void AddImportMessage(string message)
		{
			int num3 = 1;
			int num4 = num3;
			while (true)
			{
				switch (num4)
				{
				default:
					return;
				case 1:
					messages.Add(new TestImportMessages(TestImportMessagesType.Warning, message));
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num4 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	static ComponentMetadataItemHeaderImportSaveActions()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Uid = InterfaceActivator.UID<ComponentMetadataItemHeader>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				SingletonReader.JJCZtPuTvSt();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static bool wX0vN7dwHu3FxqWunuk()
	{
		return xHAaPZdt19SM8bdIJmy == null;
	}

	internal static ComponentMetadataItemHeaderImportSaveActions DfRnyid4qeMOMkEcaR0()
	{
		return xHAaPZdt19SM8bdIJmy;
	}

	internal static bool FHpqg1d6f0232ZtOjjK(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool ljNQKydHBMpXxvELvYG(object P_0)
	{
		return ((XmlReader)P_0).MoveToElement();
	}

	internal static bool hysUC4dAEHxn7eY9rEi(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static object CuFidsd7FcbhWixlLDm(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static bool VpAX7bdx8DFq476gF7E(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool kTaFQ1d0Wc0t3ZRb0lw(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static object ENaoYqdmoVb0IpgBn72(object P_0)
	{
		return ((XmlReader)P_0).ReadString();
	}

	internal static void tQFOVudyMOrHtsbR5Wt(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static XmlNodeType VMeIbidM17CNxhilK4i(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}

	internal static XmlNodeType dJkcSrdJ6yeta6qwM85(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static object SR4Dn5d9IkNOKEYC9my(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool aCVNpQddKeTW63E7lw4(object P_0, object P_1, bool defaultEnabled)
	{
		return ((IFeatureFlagService)P_0).Enabled((string)P_1, defaultEnabled);
	}

	internal static bool D1Gbsndl7ddSXxhlkWN(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object FZV5oxdrcHBdLvNwRv4(object P_0)
	{
		return ((ImportTestReadData)P_0).ConfigImportSettings;
	}

	internal static object OfQWFTdgCuEc8oRCXQ7(object P_0)
	{
		return ((IConfigImportSettings)P_0).FakeManifest;
	}
}
