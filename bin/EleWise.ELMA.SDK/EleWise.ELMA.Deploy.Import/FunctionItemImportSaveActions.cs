using System;
using System.Collections.Generic;
using System.Xml;
using EleWise.ELMA.Deploy.Import.ExtensionPoints;
using EleWise.ELMA.Deploy.Import.Links;
using EleWise.ELMA.FeatureFlags.Services;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Model.Entities;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.Model.Metadata.Managers;
using EleWise.ELMA.Model.Services;
using EleWise.ELMA.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Import;

internal sealed class FunctionItemImportSaveActions : EntityImportSaveActions
{
	private static readonly Guid Uid;

	private readonly FunctionMetadataItemHeaderManager headerManager;

	private readonly IFeatureFlagService featureFlagService;

	private static FunctionItemImportSaveActions cF1FPWE0PCBwq475OV9M;

	public FunctionItemImportSaveActions(FunctionMetadataItemHeaderManager headerManager, IFeatureFlagService featureFlagService)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		utSKOKE03ia0kk5jUj6D();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 2:
				this.featureFlagService = featureFlagService;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num = 0;
				}
				break;
			case 1:
				this.headerManager = headerManager;
				num = 2;
				break;
			case 0:
				return;
			}
		}
	}

	public override bool IsSupported(Guid typeGuid)
	{
		return OjUThPE0p8SgtYUHpGyb(typeGuid, Uid);
	}

	public override void TestRead(ImportTestReadData data, ImportTestReadResult result)
	{
		//Discarded unreachable code: IL_0110, IL_0199, IL_01a8, IL_0401, IL_0430, IL_0474, IL_0483, IL_0579, IL_05ea, IL_05f9, IL_0608, IL_0617, IL_0661, IL_06a4
		int num = 18;
		XmlReader xmlReader = default(XmlReader);
		Guid result2 = default(Guid);
		string text = default(string);
		string errorMessage2 = default(string);
		string errorMessage = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (!C9TN5yE04EOXl3t2OAZ9(chShcEE0tT6HoFlrA7nB(xmlReader), EBKRrFE0wDqG9o0kFpvm(0x2A7797B7 ^ 0x2A772175)))
					{
						num2 = 25;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
						{
							num2 = 35;
						}
						continue;
					}
					goto case 20;
				case 32:
					return;
				case 24:
					if (YS8pSOE0MZkCueVx08br(result2, Guid.Empty))
					{
						num2 = 7;
						continue;
					}
					return;
				case 17:
					xmlReader.Read();
					num2 = 31;
					continue;
				case 13:
					sxW2TGE06FRFAs6EHNDM(xmlReader);
					num = 6;
					break;
				case 28:
					result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)EBKRrFE0wDqG9o0kFpvm(-643786247 ^ -643548781), result2)));
					num2 = 32;
					continue;
				case 31:
					IGFcopE0DF0ioxidA9d1(xmlReader);
					num2 = 27;
					continue;
				case 15:
					text = (string)QNpZGKE093Q4gKrEWiQd(text, 0, Ymcn4xE0JYrxGmkA4IXd(text, EBKRrFE0wDqG9o0kFpvm(-867826612 ^ -867808374)));
					num = 21;
					break;
				case 29:
					sxW2TGE06FRFAs6EHNDM(xmlReader);
					num2 = 14;
					continue;
				case 6:
					IGFcopE0DF0ioxidA9d1(xmlReader);
					num2 = 10;
					continue;
				case 7:
					if (string.IsNullOrWhiteSpace(text))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 15;
				case 4:
				case 25:
					if (!SRNXuxE0HhpMuyFjJes2(xmlReader))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto default;
				case 22:
					Guid.TryParse(xmlReader.ReadString(), out result2);
					num2 = 29;
					continue;
				case 1:
					if (xHdCmYE0yl0GkUhd7KOv(featureFlagService, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7ECBB35), false))
					{
						num2 = 24;
						continue;
					}
					goto case 28;
				case 8:
					if (xmlReader.IsStartElement())
					{
						num2 = 26;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num2 = 25;
						}
						continue;
					}
					goto case 4;
				case 34:
					if (xmlReader.IsEmptyElement)
					{
						num2 = 25;
						continue;
					}
					goto case 3;
				case 12:
					xmlReader.MoveToContent();
					num2 = 5;
					continue;
				case 9:
				case 11:
				case 14:
				case 35:
					r2SXZKE00vUcdt2lkuiX(xmlReader);
					num2 = 12;
					continue;
				case 5:
				case 19:
					if (zNS8jSE0meppR7KXY7CV(xmlReader) == XmlNodeType.EndElement)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 20:
					if (!DPVNhKE0AWhOBN61f6PP(xmlReader))
					{
						num = 37;
						break;
					}
					goto case 9;
				case 23:
					sxW2TGE06FRFAs6EHNDM(xmlReader);
					num2 = 11;
					continue;
				case 26:
					if (C9TN5yE04EOXl3t2OAZ9(chShcEE0tT6HoFlrA7nB(xmlReader), EBKRrFE0wDqG9o0kFpvm(-70007027 ^ -70028865)))
					{
						num = 34;
						break;
					}
					goto case 4;
				case 10:
					text = (string)I8ei1wE0x0K5qQ4krElx(xmlReader);
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
					{
						num2 = 18;
					}
					continue;
				case 30:
					IGFcopE0DF0ioxidA9d1(xmlReader);
					num = 36;
					break;
				case 3:
					IGFcopE0DF0ioxidA9d1(xmlReader);
					num = 22;
					break;
				case 27:
					xmlReader.Read();
					num = 30;
					break;
				case 21:
					try
					{
						FunctionMetadata functionMetadata = ClassSerializationHelper.DeserializeObjectByXml(VOvvL0E0dlx7m3K7ua6T(typeof(FunctionMetadata).TypeHandle), text) as FunctionMetadata;
						int num3 = 5;
						while (true)
						{
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 1:
							case 2:
								if (headerManager.ValidateDisplayName(result2, (string)sbFSUDE0raCqXbDeTp5j(functionMetadata), out errorMessage2))
								{
									num3 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
									{
										num3 = 0;
									}
									continue;
								}
								goto case 4;
							case 5:
								if (headerManager.ValidateName(result2, (string)im0O1SE0lPYPMKMeUpdI(functionMetadata), out errorMessage))
								{
									num3 = 2;
									continue;
								}
								break;
							case 4:
								result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)EBKRrFE0wDqG9o0kFpvm(0x3A5D5EF ^ 0x3A1707B), result2, errorMessage2)));
								num3 = 6;
								continue;
							case 3:
								break;
							case 6:
								return;
							}
							result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)EBKRrFE0wDqG9o0kFpvm(0x20261A4F ^ 0x2022BFDB), result2, errorMessage)));
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
							{
								num3 = 1;
							}
						}
					}
					catch (Exception)
					{
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
						{
							num4 = 0;
						}
						while (true)
						{
							switch (num4)
							{
							case 1:
								return;
							}
							result.Messages.Add(new TestImportMessages(TestImportMessagesType.Error, SR.T((string)EBKRrFE0wDqG9o0kFpvm(-978351861 ^ -978637583), result2)));
							num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
							{
								num4 = 1;
							}
						}
					}
				case 2:
					return;
				case 37:
					if (sdihShE07DobLyouWLtm(xmlReader, EBKRrFE0wDqG9o0kFpvm(-1146510045 ^ -1146547211)) != null)
					{
						num = 13;
						break;
					}
					goto case 9;
				case 33:
					result2 = Guid.Empty;
					num2 = 19;
					continue;
				case 36:
					text = "";
					num2 = 33;
					continue;
				case 16:
					return;
				case 18:
					xmlReader = (XmlReader)GAAQI6E0agInUsIMQNba(data);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 17;
					}
					continue;
				}
				break;
			}
		}
	}

	public override List<TestImportMessages> ExecPreSaveActions(IEntity entity, ImportEntityPreSaveData data)
	{
		if (!(entity is FunctionMetadataItem functionMetadataItem))
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35756111));
			return new List<TestImportMessages> { CreateErrorMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -69736250))) };
		}
		if (functionMetadataItem.Header == null)
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x10E41EDB ^ 0x10E0B9F9));
			return new List<TestImportMessages> { CreateErrorMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-234299632 ^ -234062748))) };
		}
		if (!(functionMetadataItem.Metadata is FunctionMetadata functionMetadata))
		{
			Logger.Log.Error(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -281556212));
			return new List<TestImportMessages> { CreateErrorMessage(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x18A6761F ^ 0x18A2DE75))) };
		}
		functionMetadata.Name = functionMetadataItem.Header.Name;
		functionMetadata.DisplayName = functionMetadataItem.Header.DisplayName;
		return new List<TestImportMessages>();
		static TestImportMessages CreateErrorMessage(string error)
		{
			return new TestImportMessages(TestImportMessagesType.Error, SR.T((string)EBKRrFE0wDqG9o0kFpvm(-1852837372 ^ -1853138258), error));
		}
	}

	public override void ExecPostSaveActions(IEntity entity, Type type, Dictionary<string, object> values, Dictionary<string, string> serviceData, LinksDictionary links)
	{
		serviceData[z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7F88D6)] = string.Empty;
		base.ExecPostSaveActions(entity, type, values, serviceData, links);
	}

	static FunctionItemImportSaveActions()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				Uid = InterfaceActivator.UID<FunctionMetadataItem>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				utSKOKE03ia0kk5jUj6D();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			}
		}
	}

	internal static void utSKOKE03ia0kk5jUj6D()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool f2r1dgE01Eyu28osPrqc()
	{
		return cF1FPWE0PCBwq475OV9M == null;
	}

	internal static FunctionItemImportSaveActions nn5B1SE0NCahYMCH8Nv0()
	{
		return cF1FPWE0PCBwq475OV9M;
	}

	internal static bool OjUThPE0p8SgtYUHpGyb(Guid P_0, Guid P_1)
	{
		return P_0 == P_1;
	}

	internal static object GAAQI6E0agInUsIMQNba(object P_0)
	{
		return ((ImportTestReadData)P_0).Reader;
	}

	internal static bool IGFcopE0DF0ioxidA9d1(object P_0)
	{
		return ((XmlReader)P_0).MoveToElement();
	}

	internal static object chShcEE0tT6HoFlrA7nB(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static object EBKRrFE0wDqG9o0kFpvm(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool C9TN5yE04EOXl3t2OAZ9(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static bool sxW2TGE06FRFAs6EHNDM(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static bool SRNXuxE0HhpMuyFjJes2(object P_0)
	{
		return ((XmlReader)P_0).IsStartElement();
	}

	internal static bool DPVNhKE0AWhOBN61f6PP(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static object sdihShE07DobLyouWLtm(object P_0, object P_1)
	{
		return ((XmlReader)P_0).GetAttribute((string)P_1);
	}

	internal static object I8ei1wE0x0K5qQ4krElx(object P_0)
	{
		return ((XmlReader)P_0).Value;
	}

	internal static void r2SXZKE00vUcdt2lkuiX(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static XmlNodeType zNS8jSE0meppR7KXY7CV(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static bool xHdCmYE0yl0GkUhd7KOv(object P_0, object P_1, bool defaultEnabled)
	{
		return ((IFeatureFlagService)P_0).Enabled((string)P_1, defaultEnabled);
	}

	internal static bool YS8pSOE0MZkCueVx08br(Guid P_0, Guid P_1)
	{
		return P_0 != P_1;
	}

	internal static int Ymcn4xE0JYrxGmkA4IXd(object P_0, object P_1)
	{
		return ((string)P_0).IndexOf((string)P_1);
	}

	internal static object QNpZGKE093Q4gKrEWiQd(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Remove(P_1, P_2);
	}

	internal static Type VOvvL0E0dlx7m3K7ua6T(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object im0O1SE0lPYPMKMeUpdI(object P_0)
	{
		return ((NamedMetadata)P_0).Name;
	}

	internal static object sbFSUDE0raCqXbDeTp5j(object P_0)
	{
		return ((NamedMetadata)P_0).DisplayName;
	}
}
