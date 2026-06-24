using System;
using System.Collections.Generic;
using System.Xml;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy.Export;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import;

internal sealed class FunctionHeaderImportSaveActions : EntityImportSaveActions
{
	private readonly IFunctionMetadataItemHeaderManager headerManager;

	private readonly IFunctionMetadataItemManager itemManager;

	private readonly IFeatureFlagService featureFlagService;

	private static readonly Guid Uid;

	internal static FunctionHeaderImportSaveActions kTdM6WE080aGuSGVZLC5;

	public FunctionHeaderImportSaveActions(IFunctionMetadataItemHeaderManager headerManager, IFunctionMetadataItemManager itemManager, IFeatureFlagService featureFlagService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		vFvkbPE0Irs1CxtRkCWo();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 3:
				return;
			case 1:
				this.itemManager = itemManager;
				num = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 != 0)
				{
					num = 2;
				}
				break;
			default:
				this.headerManager = headerManager;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num = 1;
				}
				break;
			case 2:
				this.featureFlagService = featureFlagService;
				num = 3;
				break;
			}
		}
	}

	public override bool IsSupported(Guid typeGuid)
	{
		return typeGuid == Uid;
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		//Discarded unreachable code: IL_012f, IL_0328, IL_0337, IL_036d, IL_037c, IL_03f2, IL_0424, IL_0433, IL_0442, IL_0576, IL_0610, IL_061f, IL_06ba, IL_06c9, IL_06fc
		int num = 30;
		XmlReader reader = default(XmlReader);
		Guid result2 = default(Guid);
		string text2 = default(string);
		string text = default(string);
		string errorMessage = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					if (!((string)wbC3vxE0R8J7RB9P2pb9(reader) == FunctionMetadataItemHeaderManager._Resources_PropertyNames.DisplayName))
					{
						num2 = 32;
						continue;
					}
					goto case 6;
				default:
					if (!v06mQuE0ikRqGy4UykO6(reader))
					{
						num2 = 49;
						continue;
					}
					goto case 13;
				case 25:
				case 31:
					if (srIlhNE023tZ6OWHZXgc(result2, Guid.Empty))
					{
						num2 = 7;
						continue;
					}
					return;
				case 44:
					if (!wOJmvME0qPVCxVXRwZj4(wbC3vxE0R8J7RB9P2pb9(reader), FunctionMetadataItemHeaderManager._Resources_PropertyNames.Name))
					{
						num2 = 5;
						continue;
					}
					goto case 46;
				case 46:
					if (FrS85YE0X2b0xW5JRkIZ(reader))
					{
						num2 = 2;
						continue;
					}
					goto case 14;
				case 10:
					result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)ddymVfE0nC1CD9eYuDAg(0xA592A41 ^ 0xA5D8A2B), text2)));
					num2 = 34;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
					{
						num2 = 14;
					}
					continue;
				case 12:
				case 16:
				case 26:
				case 32:
				case 49:
					reader.Skip();
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 4;
					}
					continue;
				case 34:
					return;
				case 24:
					reader.MoveToElement();
					num2 = 38;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 39;
					}
					continue;
				case 37:
					if (!v06mQuE0ikRqGy4UykO6(reader))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 47;
				case 22:
					Guid.TryParse((string)anYQfPE0K89b2JAFfeZ9(reader), out result2);
					num2 = 27;
					continue;
				case 42:
					text2 = null;
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 41;
					}
					continue;
				case 51:
					AddTestImportMessage(result.Messages, SR.T((string)ddymVfE0nC1CD9eYuDAg(0x4DC2B14D ^ 0x4DC6134B), text, errorMessage));
					num2 = 45;
					continue;
				case 1:
				case 45:
					if (headerManager.ValidateDisplayName(result2, text2, out errorMessage))
					{
						num2 = 31;
						continue;
					}
					goto case 9;
				case 14:
					stsDk2E0SeE6UCbfhQGH(reader);
					num2 = 43;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 != 0)
					{
						num2 = 15;
					}
					continue;
				case 48:
					text = null;
					num2 = 42;
					continue;
				case 43:
					text = (string)anYQfPE0K89b2JAFfeZ9(reader);
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
					{
						num2 = 50;
					}
					continue;
				case 40:
					return;
				case 38:
					hJKkZIE0VBc5Rtk0lt7N(reader);
					num2 = 18;
					continue;
				case 7:
					((BPMAppFakeManifest)IaYVJIE0etSyS4tAp4BX(data.ConfigImportSettings)).GetOrCreateChapterByUid(FunctionExportConsts.ExportExtensionUid, "").GetOrCreateItemByUid(result2, text2);
					num2 = 40;
					continue;
				case 19:
					if (reader.IsEmptyElement)
					{
						num2 = 30;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num2 = 33;
						}
						continue;
					}
					goto case 21;
				case 39:
					text2 = (string)anYQfPE0K89b2JAFfeZ9(reader);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 8;
					}
					continue;
				case 18:
					stsDk2E0SeE6UCbfhQGH(reader);
					num2 = 48;
					continue;
				case 41:
					result2 = Guid.Empty;
					num2 = 23;
					continue;
				case 30:
					reader = data.Reader;
					num2 = 29;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
					{
						num2 = 13;
					}
					continue;
				case 17:
				case 20:
				case 33:
				case 53:
					if (!v06mQuE0ikRqGy4UykO6(reader))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 44;
				case 27:
					reader.Read();
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 11;
					}
					continue;
				case 4:
					reader.MoveToContent();
					num = 28;
					break;
				case 21:
					reader.MoveToElement();
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f == 0)
					{
						num2 = 22;
					}
					continue;
				case 8:
					hJKkZIE0VBc5Rtk0lt7N(reader);
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
					{
						num2 = 26;
					}
					continue;
				case 9:
					AddTestImportMessage(result.Messages, SR.T((string)ddymVfE0nC1CD9eYuDAg(-1487388570 ^ -1487343304), text2, errorMessage));
					num = 25;
					break;
				case 35:
					AddTestImportMessage(result.Messages, SR.T((string)ddymVfE0nC1CD9eYuDAg(0x12441CA4 ^ 0x1240BDC4), text));
					num2 = 52;
					continue;
				case 3:
					if (MbZBTdE0k6mFfcNSFZdm(featureFlagService, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-867826612 ^ -867784122), false))
					{
						if (!GypEuRE0OjK1HXoD5OTE(result2, Guid.Empty))
						{
							num2 = 36;
							continue;
						}
						goto case 35;
					}
					num = 10;
					break;
				case 6:
					if (!FrS85YE0X2b0xW5JRkIZ(reader))
					{
						num2 = 24;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
						{
							num2 = 24;
						}
						continue;
					}
					goto case 12;
				case 11:
					stsDk2E0SeE6UCbfhQGH(reader);
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 38;
					}
					continue;
				case 52:
					return;
				case 36:
					if (headerManager.ValidateName(result2, text, out errorMessage))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 51;
				case 23:
				case 28:
					if (zaQ6KwE0T80dwBGa4q8g(reader) == XmlNodeType.EndElement)
					{
						num2 = 3;
						continue;
					}
					goto case 37;
				case 47:
					if (!wOJmvME0qPVCxVXRwZj4(wbC3vxE0R8J7RB9P2pb9(reader), FunctionMetadataItemHeaderManager._Resources_PropertyNames.Uid))
					{
						num2 = 53;
						continue;
					}
					goto case 19;
				case 29:
					hJKkZIE0VBc5Rtk0lt7N(reader);
					num2 = 11;
					continue;
				case 50:
					reader.Read();
					num2 = 16;
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
			AddDeployMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x638095EB ^ 0x6380245D)));
			return false;
		}
		if (propValues.TryGetValue(FunctionMetadataItemHeaderManager._Resources_PropertyNames.Name, out var value) && string.IsNullOrEmpty(value.ToString()))
		{
			AddDeployMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112747868)));
			return false;
		}
		Guid result = Guid.Empty;
		if (propValues.TryGetValue(FunctionMetadataItemHeaderManager._Resources_PropertyNames.Uid, out var value2))
		{
			Guid.TryParse(value2.ToString(), out result);
		}
		if (result == Guid.Empty)
		{
			AddDeployMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C538A33)));
			return false;
		}
		return true;
		void AddDeployMessage(string message)
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, message));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public override List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data)
	{
		if (!(entity is FunctionMetadataItemHeader functionMetadataItemHeader))
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7E6E5A0B ^ 0x7E6AF87B));
			List<TestImportMessages> list = new List<TestImportMessages>();
			list.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858665819), SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1418440330 ^ 0x548F0DFE)))));
			return list;
		}
		List<TestImportMessages> list2 = new List<TestImportMessages>();
		if (!headerManager.ValidateName(functionMetadataItemHeader.Uid, functionMetadataItemHeader.Name, out var errorMessage))
		{
			int num = 0;
			string text = ((!string.IsNullOrEmpty(functionMetadataItemHeader.Name)) ? functionMetadataItemHeader.Name : z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A340F8));
			do
			{
				num++;
				text += num;
			}
			while (!headerManager.ValidateName(functionMetadataItemHeader.Uid, text, out errorMessage) && num < 100);
			if (num <= 100)
			{
				list2.Add(new TestImportMessages(TestImportMessagesType.Warning, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675792263), functionMetadataItemHeader.Name, text)));
				((FunctionMetadata)functionMetadataItemHeader.Draft.Metadata).Name = text;
				GenerateFunctionCodeRequest request = new GenerateFunctionCodeRequest
				{
					OldName = functionMetadataItemHeader.Name,
					GenerateName = true
				};
				string sourceCode = itemManager.GenerateCode(request).SourceCode;
				functionMetadataItemHeader.Draft.ScriptModule.SourceCode = sourceCode;
			}
			else
			{
				AddTestImportMessage(list2, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1A4726), functionMetadataItemHeader.Name));
			}
		}
		if (!headerManager.ValidateDisplayName(functionMetadataItemHeader.Uid, functionMetadataItemHeader.DisplayName, out errorMessage))
		{
			int num2 = 0;
			string text2 = ((!string.IsNullOrEmpty(functionMetadataItemHeader.DisplayName)) ? functionMetadataItemHeader.DisplayName : z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35757471));
			do
			{
				num2++;
				text2 += num2;
			}
			while (!headerManager.ValidateDisplayName(functionMetadataItemHeader.Uid, text2, out errorMessage) && num2 < 100);
			if (num2 <= 100)
			{
				AddTestImportMessage(list2, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998318598), functionMetadataItemHeader.DisplayName, text2));
				functionMetadataItemHeader.DisplayName = text2;
			}
			else
			{
				AddTestImportMessage(list2, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7243A7AC), functionMetadataItemHeader.Name));
			}
		}
		return list2;
	}

	private static void AddTestImportMessage(List<TestImportMessages> messages, object message)
	{
		messages.Add(new TestImportMessages(TestImportMessagesType.Warning, (string)message));
	}

	static FunctionHeaderImportSaveActions()
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
			case 2:
				vFvkbPE0Irs1CxtRkCWo();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				Uid = InterfaceActivator.UID<FunctionMetadataItemHeader>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static void vFvkbPE0Irs1CxtRkCWo()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool TZbogRE0ZW1Q8rhZ0CpU()
	{
		return kTdM6WE080aGuSGVZLC5 == null;
	}

	internal static FunctionHeaderImportSaveActions Ykb8MNE0uoymd8m8apiN()
	{
		return kTdM6WE080aGuSGVZLC5;
	}

	internal static bool hJKkZIE0VBc5Rtk0lt7N(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool stsDk2E0SeE6UCbfhQGH(object P_0)
	{
		return ((XmlReader)P_0).MoveToElement();
	}

	internal static bool v06mQuE0ikRqGy4UykO6(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static object wbC3vxE0R8J7RB9P2pb9(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static bool wOJmvME0qPVCxVXRwZj4(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object anYQfPE0K89b2JAFfeZ9(object P_0)
	{
		return ((XmlReader)P_0).ReadString();
	}

	internal static bool FrS85YE0X2b0xW5JRkIZ(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static XmlNodeType zaQ6KwE0T80dwBGa4q8g(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static bool MbZBTdE0k6mFfcNSFZdm(object P_0, object P_1, bool defaultEnabled)
	{
		return ((IFeatureFlagService)P_0).Enabled((string)P_1, defaultEnabled);
	}

	internal static object ddymVfE0nC1CD9eYuDAg(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool GypEuRE0OjK1HXoD5OTE(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool srIlhNE023tZ6OWHZXgc(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static object IaYVJIE0etSyS4tAp4BX(object P_0)
	{
		return ((IConfigImportSettings)P_0).FakeManifest;
	}
}
