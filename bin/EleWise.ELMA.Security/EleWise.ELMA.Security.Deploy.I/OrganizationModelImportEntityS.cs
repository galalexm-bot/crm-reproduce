using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using EleWise.ELMA.BPMApps;
using EleWise.ELMA.Deploy;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Security.Deploy.Export;
using EleWise.ELMA.Security.Diagrams;
using EleWise.ELMA.Security.Managers;
using EleWise.ELMA.Security.Models;
using EleWise.ELMA.Security.Validation;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Security.Deploy.Import;

public class OrganizationModelImportEntitySaveAction : EntityImportSaveActions
{
	public static readonly Guid UID;

	internal static OrganizationModelImportEntitySaveAction xSp0JeyIpN8DWie4Q73;

	public override bool IsSupported(Guid typeGuid)
	{
		return zIxgF2yQjkuMhlj7NDI(typeGuid, UID);
	}

	public override bool CanBeSaved(Dictionary<string, object> propValues, ImportEntityCanBeSavedData data)
	{
		if (propValues == null)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74C28149 ^ 0x74C27A55))));
			return false;
		}
		Guid result = Guid.Empty;
		if (propValues.ContainsKey(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x67DFA65E ^ 0x67DFA9C0)) && propValues[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x271B34E4 ^ 0x271B3B7A)] != null)
		{
			Guid.TryParse(propValues[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2121ECF9 ^ 0x2121E367)].ToString(), out result);
		}
		if (result == Guid.Empty)
		{
			data.DeployMessages.Add(new DeployLogMessage(DeployLogMessageType.Error, SR.T(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x84482CB ^ 0x8447953))));
			return false;
		}
		IOrganizationModel organizationModel = Locator.GetServiceNotNull<OrganizationModelManager>().Load();
		if (organizationModel != null)
		{
			propValues[SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74C28149 ^ 0x74C28ED7)] = organizationModel.Uid.ToString();
			Dictionary<string, string> serviceData = data.ServiceData;
			string key = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1329706983 ^ -1329679317) + organizationModel.Uid.ToString().ToLower();
			Guid exportExtensionUidOrgstructure = SecurityExportConsts.ExportExtensionUidOrgstructure;
			serviceData.Add(key, exportExtensionUidOrgstructure.ToString().ToLower());
		}
		else
		{
			Dictionary<string, string> serviceData2 = data.ServiceData;
			string key2 = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1B47BFA1 ^ 0x1B474393) + result.ToString().ToLower();
			Guid exportExtensionUidOrgstructure = SecurityExportConsts.ExportExtensionUidOrgstructure;
			serviceData2.Add(key2, exportExtensionUidOrgstructure.ToString().ToLower());
		}
		return true;
	}

	public override void ExecPostSaveActions(IEntity entity, Type type, Dictionary<string, object> values, Dictionary<string, string> serviceData, LinksDictionary links)
	{
		OrganizationModelManager serviceNotNull = Locator.GetServiceNotNull<OrganizationModelManager>();
		IOrganizationModel organizationModel = serviceNotNull.Load();
		Logger.Log.Info(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xC66FB14 ^ 0xC660760));
		serviceNotNull.Publish(organizationModel);
		Logger.Log.Info(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2037738356 ^ -2037749706));
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		//Discarded unreachable code: IL_01c3, IL_01e6, IL_0215, IL_0283, IL_0292, IL_0339, IL_0382, IL_0391, IL_03fb, IL_040a, IL_045f, IL_04b7, IL_04c6, IL_0533, IL_062b, IL_0687, IL_06b7, IL_06c6, IL_07da, IL_080d, IL_0856, IL_0865, IL_0992, IL_09c5, IL_0a0e, IL_0a1d
		int num = 4;
		XmlReader xmlReader = default(XmlReader);
		string text = default(string);
		string text3 = default(string);
		IOrganizationModel organizationModel = default(IOrganizationModel);
		List<TestImportMessages> messages = default(List<TestImportMessages>);
		OrganizationDiagram organizationDiagram = default(OrganizationDiagram);
		string xml = default(string);
		OrganizationSubDiagram organizationSubDiagram = default(OrganizationSubDiagram);
		Type tp = default(Type);
		Type type = default(Type);
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				OrganizationModelPublishWarning warning;
				switch (num2)
				{
				case 50:
					loIM2Ryrr3O3HdrqZFN(xmlReader);
					num2 = 47;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_c537c1b3b4be444086af51f6e9112d23 == 0)
					{
						num2 = 14;
					}
					continue;
				case 47:
					text = (string)QccrAxy1wjcQVQGu1Dk(xmlReader);
					num2 = 18;
					continue;
				case 32:
					loIM2Ryrr3O3HdrqZFN(xmlReader);
					num = 14;
					break;
				case 48:
				case 53:
					if (!wtEWXtb5JfKdkPuw481(text3))
					{
						num2 = 8;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0ab7ce9a6369414380df24a533da8346 != 0)
						{
							num2 = 52;
						}
						continue;
					}
					goto case 24;
				case 30:
				case 35:
					if (iOwF0cbpRCveU4nLZHE(xmlReader) == XmlNodeType.EndElement)
					{
						num2 = 5;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_61a610c13d6d47c8947a4d2d4016147a == 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 6;
				case 10:
					try
					{
						((OrganizationModelManager)eCLNLcbZPRQZFhQaKPq()).Validate(organizationModel, out warning);
						int num7 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b != 0)
						{
							num7 = 0;
						}
						switch (num7)
						{
						case 0:
							break;
						}
						return;
					}
					catch (OrganizationModelPublishException ex3)
					{
						int num8 = 3;
						while (true)
						{
							switch (num8)
							{
							default:
								return;
							case 0:
								return;
							case 3:
								if (ex3.mess != null)
								{
									num8 = 1;
									if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e2be4970ad4d405ab7ed74c6b68c9f7d != 0)
									{
										num8 = 1;
									}
									continue;
								}
								goto case 2;
							case 1:
								if (JUleqlbxNAAtVp99rL0(ex3.mess) == 0)
								{
									num8 = 5;
									continue;
								}
								break;
							case 2:
							case 5:
								messages.Add(new TestImportMessages(TestImportMessagesType.Error, (string)HcZhGhb6XlymNxTul8s(ex3)));
								num8 = 4;
								continue;
							case 6:
								break;
							case 4:
								return;
							}
							messages.AddRange(from m in ex3.mess
								where _003C_003Ec.ERIwWQpUhHoYNlOIZD3F(m) == OrganizationValidationMessageType.Error
								select m into message
								select new TestImportMessages(TestImportMessagesType.Error, (string)_003C_003Ec.B3uONhpUcaHeGQCUYC48(_003C_003Ec.Ba2pe4pUOWmpF9s1HmtO(0x65F93013 ^ 0x65F87319), new object[1] { _003C_003Ec.zWh6TgpUqZkelyvu9tyf(message) })));
							num8 = 0;
							if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a53a06d0e4134332947f6164df41fb0f == 0)
							{
								num8 = 0;
							}
						}
					}
					catch (Exception ex4)
					{
						int num9 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39d15279765e4050b24c0f7d69df46db == 0)
						{
							num9 = 1;
						}
						while (true)
						{
							switch (num9)
							{
							default:
								return;
							case 1:
								messages.Add(new TestImportMessages(TestImportMessagesType.Error, ex4.Message));
								num9 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_288a03909ebe4f56a0d34bfce957098b == 0)
								{
									num9 = 0;
								}
								break;
							case 0:
								return;
							}
						}
					}
				case 39:
					XnOELOy8CCMnXkOxIU3(xmlReader);
					num2 = 24;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fe0eedb8ce484402a5c9a74346556b9f == 0)
					{
						num2 = 29;
					}
					continue;
				case 37:
					if (wtEWXtb5JfKdkPuw481(text))
					{
						num2 = 48;
						continue;
					}
					goto case 28;
				case 31:
					XnOELOy8CCMnXkOxIU3(xmlReader);
					num2 = 50;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_d133bac4622e4b5596f3c44ee791169d == 0)
					{
						num2 = 20;
					}
					continue;
				default:
					if (!xmlReader.IsEmptyElement)
					{
						num2 = 8;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f4f2657bf7454f44b4829aa89c711f0d == 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 11;
				case 8:
					text = "";
					num2 = 34;
					continue;
				case 49:
					return;
				case 51:
					warning = null;
					num2 = 10;
					continue;
				case 9:
					xmlReader = (XmlReader)gHaB1iyg3oAsdyGyBOK(data);
					num2 = 27;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_417fa9f431a6421fac341b81e122e2e7 == 0)
					{
						num2 = 42;
					}
					continue;
				case 4:
					if (iYMKR6ydhkLFndApjKA(data) != null)
					{
						num2 = 3;
						continue;
					}
					goto case 9;
				case 29:
					xmlReader.MoveToElement();
					num2 = 35;
					continue;
				case 45:
					loIM2Ryrr3O3HdrqZFN(xmlReader);
					num = 46;
					break;
				case 12:
					XnOELOy8CCMnXkOxIU3(xmlReader);
					num2 = 23;
					continue;
				case 23:
					loIM2Ryrr3O3HdrqZFN(xmlReader);
					num2 = 19;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e19c59c87b9f40ffa6cb17beeb01edcf != 0)
					{
						num2 = 26;
					}
					continue;
				case 33:
					UtnHL3blb5Dv1k1t3DV(organizationModel, organizationDiagram);
					num2 = 19;
					continue;
				case 38:
					organizationModel = OrganizationModelManager.Instance.Create();
					num2 = 10;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_a3a30dc594d64d20b0419bc3debf22fd != 0)
					{
						num2 = 33;
					}
					continue;
				case 54:
					XnOELOy8CCMnXkOxIU3(xmlReader);
					num2 = 32;
					continue;
				case 27:
					if (SFlxHtyS6AisXqggoo9(xmlReader.Name, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7DABA580 ^ 0x7DAB2AA8)))
					{
						num2 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_e4840b3cf8a94577862fdc527af9db29 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 11;
				case 2:
					text3 = (string)b5avN5bnG0DRiMtjyNP(text3, 0, Q9ShLTbXI5TVRvnwtI3(text3, QA0iolybEnZTurW6PoW(-230994601 ^ -230969265)));
					num2 = 20;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_fc5e0189a7f447a7b93cd505b96d5f05 == 0)
					{
						num2 = 22;
					}
					continue;
				case 22:
				{
					StringBuilder stringBuilder2 = new StringBuilder((string)QA0iolybEnZTurW6PoW(0x32A45635 ^ 0x32A4AB2B));
					EALN7qb7UYENtVJEneB(stringBuilder2, text3);
					xml = stringBuilder2.ToString();
					num2 = 41;
					continue;
				}
				case 19:
					ux2HoCbNnKATrL9ZkxT(organizationModel, organizationSubDiagram);
					num2 = 51;
					continue;
				case 17:
					organizationDiagram = null;
					num2 = 5;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_07d1789322864bd7a6f8c5e113ce5c9a == 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
					organizationSubDiagram = null;
					num2 = 37;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_01fd90314ba945f0a4ee79d2372961e2 == 0)
					{
						num2 = 6;
					}
					continue;
				case 34:
					text3 = "";
					num2 = 20;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_1e79fb186de547eaaa37d66745fc7b90 == 0)
					{
						num2 = 8;
					}
					continue;
				case 52:
					tp = v6KUE8bW76cXedisaaM(br0nBKbAVPEwohdSCI3(text3, 0, Q9ShLTbXI5TVRvnwtI3(text3, QA0iolybEnZTurW6PoW(-179348817 ^ -179329097))));
					num2 = 2;
					continue;
				case 21:
					text = (string)b5avN5bnG0DRiMtjyNP(text, 0, Q9ShLTbXI5TVRvnwtI3(text, QA0iolybEnZTurW6PoW(0xC66FB14 ^ 0xC66060C)));
					num2 = 44;
					continue;
				case 1:
					loIM2Ryrr3O3HdrqZFN(xmlReader);
					num2 = 4;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8b4bc2d0df7346ebba20e6c22632a575 != 0)
					{
						num2 = 39;
					}
					continue;
				case 36:
					vgIY85bkG5HmtnIyUgu(xmlReader);
					num2 = 30;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_f6614d006512404f8cab65f09d3e1c89 == 0)
					{
						num2 = 3;
					}
					continue;
				case 13:
				case 15:
					if (!osTmtRy3yIICpjf87Uc(xmlReader))
					{
						num2 = 11;
						continue;
					}
					goto case 27;
				case 42:
					messages = result.Messages;
					num2 = 8;
					continue;
				case 43:
					if (!MZBvUXy9IFrURRRnv3k(xmlReader))
					{
						num2 = 40;
						continue;
					}
					goto case 13;
				case 41:
					try
					{
						organizationSubDiagram = ClassSerializationHelper.DeserializeObjectByXml(tp, xml) as OrganizationSubDiagram;
						int num5 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_443cb30a1c3f4e72a61ec4f52377fcc7 == 0)
						{
							num5 = 0;
						}
						switch (num5)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex2)
					{
						int num6 = 1;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5028d2018b41471c962aaca947e33b9d != 0)
						{
							num6 = 0;
						}
						while (true)
						{
							switch (num6)
							{
							case 1:
								messages.Add(new TestImportMessages(TestImportMessagesType.Error, (string)HcZhGhb6XlymNxTul8s(ex2)));
								num6 = 0;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_4aad3b757e09491eb106d72b1e7740cc != 0)
								{
									num6 = 0;
								}
								continue;
							case 0:
								break;
							}
							break;
						}
					}
					goto case 24;
				case 3:
					NvIfreyTslYO8hhskwV(((IConfigImportSettings)iYMKR6ydhkLFndApjKA(data)).FakeManifest, SecurityExportConsts.ExportExtensionUidOrgstructure, "");
					num2 = 9;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_75955a8c33b24cdca4663f20d9ee3c3b != 0)
					{
						num2 = 7;
					}
					continue;
				case 20:
					XnOELOy8CCMnXkOxIU3(xmlReader);
					num2 = 1;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0a82cc1379bc48bbb836c94da8cb8564 == 0)
					{
						num2 = 0;
					}
					continue;
				case 16:
					if (!SFlxHtyS6AisXqggoo9(StuoUwyyJWelvwSAUfW(xmlReader), QA0iolybEnZTurW6PoW(-1586242415 ^ -1586294277)))
					{
						num2 = 9;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_0b98d9f52b424149868b80d852714a70 == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 43;
				case 40:
					if (hUqktNyfeNplMv3IEtk(xmlReader, QA0iolybEnZTurW6PoW(0x40096392 ^ 0x40099F6E)) == null)
					{
						num2 = 55;
						continue;
					}
					goto case 31;
				case 25:
					if (hUqktNyfeNplMv3IEtk(xmlReader, QA0iolybEnZTurW6PoW(0x5EE4A7B ^ 0x5EEB687)) == null)
					{
						num2 = 56;
						continue;
					}
					goto case 12;
				case 24:
					if (organizationDiagram == null)
					{
						return;
					}
					num2 = 38;
					continue;
				case 7:
					try
					{
						organizationDiagram = K5YE0NbiJNVQHdBp0f9(type, text2, true) as OrganizationDiagram;
						int num3 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8fd69cd0bea1432ca401d29377c613cc == 0)
						{
							num3 = 0;
						}
						switch (num3)
						{
						case 0:
							break;
						}
					}
					catch (Exception ex)
					{
						int num4 = 0;
						if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_da1dffb5695d4a95af335a696463801b == 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							default:
								messages.Add(new TestImportMessages(TestImportMessagesType.Error, ex.Message));
								num4 = 1;
								if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_5adff34accb14bd183b62ef1a2f5f964 == 0)
								{
									num4 = 1;
								}
								continue;
							case 1:
								break;
							}
							break;
						}
					}
					goto case 48;
				case 6:
					if (osTmtRy3yIICpjf87Uc(xmlReader))
					{
						num2 = 16;
						continue;
					}
					goto case 13;
				case 11:
				case 14:
				case 46:
				case 55:
				case 56:
					hQZSHAyzZI3dZ3qUBxj(xmlReader);
					num2 = 36;
					continue;
				case 26:
					text3 = xmlReader.Value;
					num2 = 54;
					continue;
				case 18:
					xmlReader.Read();
					num2 = 45;
					continue;
				case 28:
					type = v6KUE8bW76cXedisaaM(br0nBKbAVPEwohdSCI3(text, 0, text.IndexOf(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1130812004 ^ 0x43662F7C))));
					num2 = 20;
					if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_8dab57df677749fba2d5364cf752799f != 0)
					{
						num2 = 21;
					}
					continue;
				case 44:
				{
					StringBuilder stringBuilder = new StringBuilder((string)QA0iolybEnZTurW6PoW(-816887841 ^ -816858431));
					stringBuilder.AppendLine(text);
					text2 = stringBuilder.ToString();
					num = 7;
					break;
				}
				}
				break;
			}
		}
	}

	public OrganizationModelImportEntitySaveAction()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		hel0wpbBNO8yy6A8fhf();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_39a415f51fd045a981443759203cc0ad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	static OrganizationModelImportEntitySaveAction()
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
				hel0wpbBNO8yy6A8fhf();
				num2 = 1;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_3e35bb8d9f5b4a1d9826edea4d9dca96 == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				UID = new Guid((string)QA0iolybEnZTurW6PoW(0x7CAA49C6 ^ 0x7CAAB4A8));
				num2 = 0;
				if (_003CModule_003E_007B66f21d37_002D36a6_002D42c7_002D8f8e_002D89466f2bcb0d_007D.m_daaf990ff0c644fb99cfba0a043a9b93 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool zIxgF2yQjkuMhlj7NDI(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static bool yuXStry49G7R56XDZQg()
	{
		return xSp0JeyIpN8DWie4Q73 == null;
	}

	internal static OrganizationModelImportEntitySaveAction ubmeKmyVq14HBmvicrH()
	{
		return xSp0JeyIpN8DWie4Q73;
	}

	internal static object iYMKR6ydhkLFndApjKA(object P_0)
	{
		return ((ImportTestReadData)P_0).ConfigImportSettings;
	}

	internal static object NvIfreyTslYO8hhskwV(object P_0, Guid P_1, object P_2)
	{
		return ((BPMAppFakeManifest)P_0).GetOrCreateChapterByUid(P_1, (string)P_2);
	}

	internal static object gHaB1iyg3oAsdyGyBOK(object P_0)
	{
		return ((ImportTestReadData)P_0).Reader;
	}

	internal static bool XnOELOy8CCMnXkOxIU3(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool loIM2Ryrr3O3HdrqZFN(object P_0)
	{
		return ((XmlReader)P_0).MoveToElement();
	}

	internal static bool osTmtRy3yIICpjf87Uc(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static object StuoUwyyJWelvwSAUfW(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static object QA0iolybEnZTurW6PoW(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool SFlxHtyS6AisXqggoo9(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool MZBvUXy9IFrURRRnv3k(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static object hUqktNyfeNplMv3IEtk(object P_0, object P_1)
	{
		return ((XmlReader)P_0).GetAttribute((string)P_1);
	}

	internal static object QccrAxy1wjcQVQGu1Dk(object P_0)
	{
		return ((XmlReader)P_0).Value;
	}

	internal static void hQZSHAyzZI3dZ3qUBxj(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static XmlNodeType vgIY85bkG5HmtnIyUgu(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}

	internal static XmlNodeType iOwF0cbpRCveU4nLZHE(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static bool wtEWXtb5JfKdkPuw481(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object br0nBKbAVPEwohdSCI3(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static Type v6KUE8bW76cXedisaaM(object P_0)
	{
		return ReflectionType.GetType((string)P_0);
	}

	internal static int Q9ShLTbXI5TVRvnwtI3(object P_0, object P_1)
	{
		return ((string)P_0).IndexOf((string)P_1);
	}

	internal static object b5avN5bnG0DRiMtjyNP(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Remove(P_1, P_2);
	}

	internal static object K5YE0NbiJNVQHdBp0f9(Type P_0, object P_1, bool P_2)
	{
		return ClassSerializationHelper.DeserializeObjectByXml(P_0, (string)P_1, P_2);
	}

	internal static object EALN7qb7UYENtVJEneB(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}

	internal static object HcZhGhb6XlymNxTul8s(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static void UtnHL3blb5Dv1k1t3DV(object P_0, object P_1)
	{
		((IOrganizationModel)P_0).Diagram = (OrganizationDiagram)P_1;
	}

	internal static void ux2HoCbNnKATrL9ZkxT(object P_0, object P_1)
	{
		((IOrganizationModel)P_0).SubDiagrams = (OrganizationSubDiagram)P_1;
	}

	internal static object eCLNLcbZPRQZFhQaKPq()
	{
		return OrganizationModelManager.Instance;
	}

	internal static int JUleqlbxNAAtVp99rL0(object P_0)
	{
		return ((List<OrganizationValidationMessage>)P_0).Count;
	}

	internal static void hel0wpbBNO8yy6A8fhf()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.xG3phsDXNqb();
	}
}
