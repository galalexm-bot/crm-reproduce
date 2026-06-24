using System;
using System.Collections.Generic;
using System.Xml;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import;

internal sealed class DataClassItemImportSaveActions : EntityImportSaveActions
{
	private static readonly Guid Uid;

	private readonly DataClassMetadataItemHeaderManager headerManager;

	private readonly IFeatureFlagService featureFlagService;

	private static DataClassItemImportSaveActions KbuFX7ExENMsZMfgfbem;

	public DataClassItemImportSaveActions(DataClassMetadataItemHeaderManager headerManager, IFeatureFlagService featureFlagService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		dp6iveExCpVIYR9OlSQT();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this.headerManager = headerManager;
				num = 2;
				break;
			case 2:
				this.featureFlagService = featureFlagService;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public override bool IsSupported(Guid typeGuid)
	{
		return JYpItsExvsOZi3ORb5G2(typeGuid, Uid);
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		//Discarded unreachable code: IL_00cb, IL_015f, IL_022d, IL_023c, IL_0314, IL_0400, IL_0517, IL_0526, IL_05f9, IL_0664, IL_0673, IL_0683, IL_0692
		int num = 30;
		XmlReader xmlReader = default(XmlReader);
		Guid result2 = default(Guid);
		string text = default(string);
		string errorMessage = default(string);
		string errorMessage2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 14:
					if (EHGKE0ExIh1Bq9tZVkbO(xmlReader))
					{
						num2 = 17;
						continue;
					}
					goto case 5;
				case 1:
					return;
				case 9:
					if (!xmlReader.IsEmptyElement)
					{
						num = 15;
						break;
					}
					goto case 3;
				case 25:
					if (featureFlagService.Enabled((string)nuqgCgExqUsLrhftbMqO(0x53CB464B ^ 0x53CBE841), defaultEnabled: false))
					{
						num = 11;
						break;
					}
					goto default;
				case 10:
					xk1RpVExZrAxONLbCYip(xmlReader);
					num2 = 23;
					continue;
				case 18:
					xk1RpVExZrAxONLbCYip(xmlReader);
					num2 = 3;
					continue;
				case 4:
					xnuuUBExuLDmUsrMQFjq(xmlReader);
					num2 = 10;
					continue;
				case 21:
					result2 = Guid.Empty;
					num2 = 8;
					continue;
				case 28:
					xk1RpVExZrAxONLbCYip(xmlReader);
					num2 = 34;
					continue;
				case 15:
					if (EF1LNYExK9BEtBXNWg30(xmlReader, nuqgCgExqUsLrhftbMqO(-2138160520 ^ -2138114898)) != null)
					{
						num2 = 6;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 7;
						}
						continue;
					}
					goto case 3;
				case 17:
					if (!Y3k9xRExSumP2uXh5v24(Pn4RlCExVWhHnBs149fA(xmlReader), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFE4ED8)))
					{
						num2 = 33;
						continue;
					}
					goto case 22;
				case 23:
					xnuuUBExuLDmUsrMQFjq(xmlReader);
					num2 = 35;
					continue;
				case 31:
					xnuuUBExuLDmUsrMQFjq(xmlReader);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 6;
					}
					continue;
				case 19:
					text = (string)of0JEHExPyewHMjHYexu(text, 0, IUUguyExegRvCwkKQy2q(text, nuqgCgExqUsLrhftbMqO(-643786247 ^ -643770817)));
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_77b644128db44ffc8bb14dd69bc7decc == 0)
					{
						num2 = 24;
					}
					continue;
				case 13:
					if (!Y3k9xRExSumP2uXh5v24(Pn4RlCExVWhHnBs149fA(xmlReader), nuqgCgExqUsLrhftbMqO(0x35C0467B ^ 0x35C0F0B9)))
					{
						num2 = 20;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 9;
				default:
					result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F34E304), result2)));
					num2 = 12;
					continue;
				case 26:
					UDa0dwExkf9QkkYNLAj3(xmlReader);
					num2 = 16;
					continue;
				case 5:
				case 33:
					if (EHGKE0ExIh1Bq9tZVkbO(xmlReader))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 13;
						}
						continue;
					}
					goto case 3;
				case 32:
					xnuuUBExuLDmUsrMQFjq(xmlReader);
					num2 = 27;
					continue;
				case 12:
					return;
				case 11:
					if (!aFKqdyExOPxvt8p5gApO(result2, Guid.Empty))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 2;
				case 22:
					if (!CXJepaExi2eirqECV4tG(xmlReader))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 31;
						}
						continue;
					}
					goto case 5;
				case 29:
					xk1RpVExZrAxONLbCYip(xmlReader);
					num2 = 4;
					continue;
				case 8:
				case 16:
					if (dfY2KhExn8dJZFvBTQ5n(xmlReader) == XmlNodeType.EndElement)
					{
						num2 = 25;
						continue;
					}
					goto case 14;
				case 6:
					Guid.TryParse((string)fRjm7fExR0ZeXRr3jl7U(xmlReader), out result2);
					num2 = 28;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num2 = 22;
					}
					continue;
				case 30:
					xmlReader = (XmlReader)lcgYCZEx8G2jga7h1sFC(data);
					num2 = 29;
					continue;
				case 3:
				case 20:
				case 34:
					qPPdZ8ExTOVq27bACBLg(xmlReader);
					num2 = 26;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c == 0)
					{
						num2 = 5;
					}
					continue;
				case 35:
					text = "";
					num2 = 21;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 8;
					}
					continue;
				case 24:
					try
					{
						DataClassMetadata dataClassMetadata = ClassSerializationHelper.DeserializeObjectByXml(jGYyo4Ex1D23RxPpvSZU(typeof(DataClassMetadata).TypeHandle), text) as DataClassMetadata;
						int num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
						{
							num3 = 0;
						}
						while (true)
						{
							switch (num3)
							{
							case 2:
								result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)nuqgCgExqUsLrhftbMqO(0x17ADCCD8 ^ 0x17A95034), result2, errorMessage)));
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
								{
									num3 = 1;
								}
								continue;
							case 5:
								return;
							default:
								if (headerManager.ValidateName(result2, dataClassMetadata.Name, out errorMessage2))
								{
									num3 = 6;
									continue;
								}
								break;
							case 3:
							case 6:
								if (headerManager.ValidateDisplayName(result2, (string)YoGNd9ExNjWShB7C44JS(dataClassMetadata), out errorMessage))
								{
									int num4 = 5;
									num3 = num4;
									continue;
								}
								goto case 2;
							case 4:
								break;
							case 1:
								return;
							}
							result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)nuqgCgExqUsLrhftbMqO(0x12A5FAC7 ^ 0x12A1662B), result2, errorMessage2)));
							num3 = 3;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 != 0)
							{
								num3 = 2;
							}
						}
					}
					catch (Exception)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
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
							result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)nuqgCgExqUsLrhftbMqO(0x1637C429 ^ 0x1633595D), result2)));
							num5 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
							{
								num5 = 1;
							}
						}
					}
				case 2:
					if (!FddSwTEx2lalgdDbeyPV(text))
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 11;
						}
						continue;
					}
					return;
				case 27:
					text = (string)gkwHVJExX1UFlv2dJm8A(xmlReader);
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 3;
					}
					continue;
				case 36:
					return;
				case 7:
					xk1RpVExZrAxONLbCYip(xmlReader);
					num2 = 32;
					continue;
				}
				break;
			}
		}
	}

	public override void ExecPostSaveActions(IEntity entity, Type type, Dictionary<string, object> values, Dictionary<string, string> serviceData, LinksDictionary links)
	{
		serviceData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281815428)] = string.Empty;
		base.ExecPostSaveActions(entity, type, values, serviceData, links);
	}

	static DataClassItemImportSaveActions()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				dp6iveExCpVIYR9OlSQT();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				Uid = InterfaceActivator.UID<DataClassMetadataItem>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void dp6iveExCpVIYR9OlSQT()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool btbtRwExfQ5xR2mLE87H()
	{
		return KbuFX7ExENMsZMfgfbem == null;
	}

	internal static DataClassItemImportSaveActions MepgcwExQe7k7ZNTLAFq()
	{
		return KbuFX7ExENMsZMfgfbem;
	}

	internal static bool JYpItsExvsOZi3ORb5G2(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object lcgYCZEx8G2jga7h1sFC(object P_0)
	{
		return ((ImportTestReadData)P_0).Reader;
	}

	internal static bool xk1RpVExZrAxONLbCYip(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool xnuuUBExuLDmUsrMQFjq(object P_0)
	{
		return ((XmlReader)P_0).MoveToElement();
	}

	internal static bool EHGKE0ExIh1Bq9tZVkbO(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static object Pn4RlCExVWhHnBs149fA(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static bool Y3k9xRExSumP2uXh5v24(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool CXJepaExi2eirqECV4tG(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static object fRjm7fExR0ZeXRr3jl7U(object P_0)
	{
		return ((XmlReader)P_0).ReadString();
	}

	internal static object nuqgCgExqUsLrhftbMqO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object EF1LNYExK9BEtBXNWg30(object P_0, object P_1)
	{
		return ((XmlReader)P_0).GetAttribute((string)P_1);
	}

	internal static object gkwHVJExX1UFlv2dJm8A(object P_0)
	{
		return ((XmlReader)P_0).Value;
	}

	internal static void qPPdZ8ExTOVq27bACBLg(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static XmlNodeType UDa0dwExkf9QkkYNLAj3(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}

	internal static XmlNodeType dfY2KhExn8dJZFvBTQ5n(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static bool aFKqdyExOPxvt8p5gApO(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static bool FddSwTEx2lalgdDbeyPV(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static int IUUguyExegRvCwkKQy2q(object P_0, object P_1)
	{
		return ((string)P_0).IndexOf((string)P_1);
	}

	internal static object of0JEHExPyewHMjHYexu(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Remove(P_1, P_2);
	}

	internal static Type jGYyo4Ex1D23RxPpvSZU(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object YoGNd9ExNjWShB7C44JS(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}
}
