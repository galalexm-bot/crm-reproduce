using System;
using System.Collections.Generic;
using System.Xml;
using EleWise.ELMA.Deploy.Import;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using EleWise.ELMA.UI.Managers;
using EleWise.ELMA.UI.Metadata;
using EleWise.ELMA.UI.Models;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.UI.Deploy.Import;

internal sealed class ComponentMetadataItemImportSaveActions : EntityImportSaveActions
{
	private static readonly Guid Uid;

	private readonly ComponentMetadataItemHeaderManager headerManager;

	private readonly IFeatureFlagService featureFlagService;

	internal static ComponentMetadataItemImportSaveActions xEbiMrd5ajh8prCg1YO;

	public ComponentMetadataItemImportSaveActions(ComponentMetadataItemHeaderManager headerManager, IFeatureFlagService featureFlagService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 2:
				this.featureFlagService = featureFlagService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.headerManager = headerManager;
				num = 2;
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
		//Discarded unreachable code: IL_013f, IL_014e, IL_0184, IL_0193, IL_01a3, IL_01c4, IL_027c, IL_043c, IL_04c9, IL_04d8, IL_055d, IL_056c, IL_0597, IL_0603, IL_0624, IL_06bd, IL_0782, IL_0791
		int num = 30;
		string text = default(string);
		XmlReader xmlReader = default(XmlReader);
		Guid result2 = default(Guid);
		string errorMessage2 = default(string);
		Type type = default(Type);
		ComponentMetadata componentMetadata = default(ComponentMetadata);
		string errorMessage = default(string);
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
					text = "";
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
					{
						num2 = 13;
					}
					continue;
				case 8:
					Guid.TryParse((string)S7MTD1lorB028BcUoDC(xmlReader), out result2);
					num2 = 11;
					continue;
				case 29:
					iampsDdU0N65PeZEnKU(xmlReader);
					num2 = 19;
					continue;
				case 19:
					J2JBsrdsxHdrVhUsHGd(xmlReader);
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 10;
					}
					continue;
				case 23:
				case 37:
					if (PZ8n2tlf9cc5Kl2uqAI(xmlReader) == XmlNodeType.EndElement)
					{
						num2 = 33;
						continue;
					}
					goto case 31;
				case 31:
					if (!wjlDDRdcjUHUpJupPVx(xmlReader))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 17;
						}
						continue;
					}
					goto case 4;
				case 26:
					iampsDdU0N65PeZEnKU(xmlReader);
					num2 = 21;
					continue;
				case 11:
					xmlReader.Read();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
					{
						num2 = 1;
					}
					continue;
				case 4:
					if (B9QNcolBsPCoBbkk59i(NsDIqNdzuN9rAQk2iGk(xmlReader), SmT6MolF1wofNHdPNBt(0x35C0467B ^ 0x35C0F0C9)))
					{
						num2 = 14;
						continue;
					}
					goto case 17;
				case 17:
				case 28:
				case 35:
					if (!xmlReader.IsStartElement())
					{
						num2 = 36;
						continue;
					}
					goto case 12;
				case 13:
					result2 = Guid.Empty;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 != 0)
					{
						num2 = 23;
					}
					continue;
				case 21:
					xmlReader.MoveToElement();
					num2 = 6;
					continue;
				case 6:
					text = (string)QVrcODlhtcrOVbRg5Gn(xmlReader);
					num2 = 7;
					continue;
				case 16:
					try
					{
						string text2 = (string)ucFdChlZV1KMVYFOR74(text, 0, jHHFfxl8o1XlHniewDi(text, SmT6MolF1wofNHdPNBt(-195614443 ^ -195598637)));
						int num3 = 10;
						while (true)
						{
							int num4 = num3;
							while (true)
							{
								switch (num4)
								{
								case 5:
									result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)SmT6MolF1wofNHdPNBt(0x1FFEF86A ^ 0x1FFE4FF0), result2, errorMessage2)));
									num4 = 3;
									continue;
								case 10:
									type = xC93g8luBlA95Dh1J1R(text2);
									num3 = 11;
									break;
								case 11:
									text = (string)DfZbZxlII2lFNHsdknH(text, 0, text.IndexOf((string)SmT6MolF1wofNHdPNBt(-583745292 ^ -583758030)));
									num3 = 7;
									break;
								case 7:
									componentMetadata = null;
									num4 = 15;
									continue;
								case 13:
									componentMetadata = ClassSerializationHelper.DeserializeObjectByXml(type, text) as ComponentMetadata;
									num3 = 12;
									break;
								case 3:
									if (headerManager.ValidateDisplayName(result2, (string)l8K6KblSJ8kYqbZV6so(componentMetadata), out errorMessage))
									{
										num4 = 8;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
										{
											num4 = 1;
										}
										continue;
									}
									goto case 6;
								case 4:
									if (!headerManager.ValidateName(result2, (string)CRLdpKlVLGCa5aQrD0m(componentMetadata), out errorMessage2))
									{
										num4 = 5;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
										{
											num4 = 5;
										}
										continue;
									}
									goto case 3;
								case 9:
									return;
								case 1:
									result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)SmT6MolF1wofNHdPNBt(-289714582 ^ -289671016), result2, text2)));
									num4 = 9;
									continue;
								case 15:
									if (!(type != null))
									{
										num4 = 2;
										continue;
									}
									goto default;
								case 2:
								case 12:
									if (componentMetadata == null)
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
										{
											num4 = 1;
										}
										continue;
									}
									goto case 4;
								case 8:
									return;
								default:
									if (typeof(ComponentMetadata).IsAssignableFrom(type))
									{
										num4 = 4;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
										{
											num4 = 13;
										}
										continue;
									}
									goto case 2;
								case 6:
									result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)SmT6MolF1wofNHdPNBt(-1921202237 ^ -1921224615), result2, errorMessage)));
									num4 = 14;
									continue;
								case 14:
									return;
								}
								break;
							}
						}
					}
					catch (Exception)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								return;
							}
							result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538550254), result2)));
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
							{
								num5 = 0;
							}
						}
					}
				case 7:
					xmlReader.Read();
					num2 = 34;
					continue;
				case 12:
					if (!B9QNcolBsPCoBbkk59i(NsDIqNdzuN9rAQk2iGk(xmlReader), SmT6MolF1wofNHdPNBt(-105199646 ^ -105221856)))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 24;
				case 22:
					return;
				case 30:
					xmlReader = (XmlReader)bn1IxSdLjCxfe5B0wCY(data);
					num2 = 29;
					continue;
				case 14:
					if (VeyVx5lW0O1jq58WT9S(xmlReader))
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num2 = 35;
						}
						continue;
					}
					goto case 27;
				case 15:
					J2JBsrdsxHdrVhUsHGd(xmlReader);
					num = 3;
					break;
				case 2:
					if (v2pg0PlbuOQxVcVjmda(xmlReader, SmT6MolF1wofNHdPNBt(-420743386 ^ -420789776)) == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 26;
				case 18:
					if (H4rei6lvqcA963ZeMHY(text))
					{
						return;
					}
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
					{
						num2 = 16;
					}
					continue;
				case 20:
					AZh5qUlEN2hlo0nblxH(xmlReader);
					num = 37;
					break;
				case 27:
					J2JBsrdsxHdrVhUsHGd(xmlReader);
					num2 = 8;
					continue;
				case 0:
					return;
				case 10:
					iampsDdU0N65PeZEnKU(xmlReader);
					num2 = 15;
					continue;
				case 32:
					result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)SmT6MolF1wofNHdPNBt(-97972138 ^ -97927666), result2)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
				case 5:
				case 9:
				case 25:
				case 34:
				case 36:
					rJgnQRlGVl3MT79bSue(xmlReader);
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
					{
						num2 = 5;
					}
					continue;
				case 24:
					if (xmlReader.IsEmptyElement)
					{
						num2 = 5;
						continue;
					}
					goto case 2;
				case 33:
					if (qROCHRlQgZ1uFeFhlVX(featureFlagService, SmT6MolF1wofNHdPNBt(0x103FE975 ^ 0x103F477F), false))
					{
						if (!n5cc3KlC6dTng4JKLPy(result2, Guid.Empty))
						{
							return;
						}
						num = 18;
						break;
					}
					num2 = 32;
					continue;
				}
				break;
			}
		}
	}

	public override List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data)
	{
		List<TestImportMessages> messages = new List<TestImportMessages>();
		if (!(entity is ComponentMetadataItem componentMetadataItem))
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE1C307));
			AddMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x269E5FCA ^ 0x269EE732)));
			return messages;
		}
		if (componentMetadataItem.Header == null)
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3C5338FF ^ 0x3C5381C5));
			AddMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195584665)));
			return messages;
		}
		if (!(componentMetadataItem.Metadata is ComponentMetadata componentMetadata))
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475904713));
			AddMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3630491F)));
			return messages;
		}
		componentMetadata.Name = componentMetadataItem.Header.Name;
		componentMetadata.DisplayName = componentMetadataItem.Header.DisplayName;
		return messages;
		void AddMessage(string message)
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
					messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87300211), message)));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public override void ExecPostSaveActions(IEntity entity, Type type, Dictionary<string, object> values, Dictionary<string, string> serviceData, LinksDictionary links)
	{
		serviceData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A6CCDB)] = string.Empty;
		base.ExecPostSaveActions(entity, type, values, serviceData, links);
	}

	static ComponentMetadataItemImportSaveActions()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return;
			default:
				Uid = InterfaceActivator.UID<ComponentMetadataItem>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				MDCo3Mli4atTkHmHSmH();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool oWVQvrdjGM4I4ietD3O()
	{
		return xEbiMrd5ajh8prCg1YO == null;
	}

	internal static ComponentMetadataItemImportSaveActions wrck3TdYfI7fSFkxtxS()
	{
		return xEbiMrd5ajh8prCg1YO;
	}

	internal static object bn1IxSdLjCxfe5B0wCY(object P_0)
	{
		return ((ImportTestReadData)P_0).Reader;
	}

	internal static bool iampsDdU0N65PeZEnKU(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool J2JBsrdsxHdrVhUsHGd(object P_0)
	{
		return ((XmlReader)P_0).MoveToElement();
	}

	internal static bool wjlDDRdcjUHUpJupPVx(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static object NsDIqNdzuN9rAQk2iGk(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static object SmT6MolF1wofNHdPNBt(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool B9QNcolBsPCoBbkk59i(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool VeyVx5lW0O1jq58WT9S(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static object S7MTD1lorB028BcUoDC(object P_0)
	{
		return ((XmlReader)P_0).ReadString();
	}

	internal static object v2pg0PlbuOQxVcVjmda(object P_0, object P_1)
	{
		return ((XmlReader)P_0).GetAttribute((string)P_1);
	}

	internal static object QVrcODlhtcrOVbRg5Gn(object P_0)
	{
		return ((XmlReader)P_0).Value;
	}

	internal static void rJgnQRlGVl3MT79bSue(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static XmlNodeType AZh5qUlEN2hlo0nblxH(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}

	internal static XmlNodeType PZ8n2tlf9cc5Kl2uqAI(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static bool qROCHRlQgZ1uFeFhlVX(object P_0, object P_1, bool defaultEnabled)
	{
		return ((IFeatureFlagService)P_0).Enabled((string)P_1, defaultEnabled);
	}

	internal static bool n5cc3KlC6dTng4JKLPy(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool H4rei6lvqcA963ZeMHY(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static int jHHFfxl8o1XlHniewDi(object P_0, object P_1)
	{
		return ((string)P_0).IndexOf((string)P_1);
	}

	internal static object ucFdChlZV1KMVYFOR74(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static Type xC93g8luBlA95Dh1J1R(object P_0)
	{
		return Type.GetType((string)P_0);
	}

	internal static object DfZbZxlII2lFNHsdknH(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Remove(P_1, P_2);
	}

	internal static object CRLdpKlVLGCa5aQrD0m(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object l8K6KblSJ8kYqbZV6so(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}

	internal static void MDCo3Mli4atTkHmHSmH()
	{
		SingletonReader.JJCZtPuTvSt();
	}
}
