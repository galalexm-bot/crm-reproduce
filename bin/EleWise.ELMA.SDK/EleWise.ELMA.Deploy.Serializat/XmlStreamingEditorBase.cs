using System;
using System.Xml;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Deploy.Serialization;

internal abstract class XmlStreamingEditorBase
{
	private readonly XmlReader reader;

	private readonly XmlWriter writer;

	private static XmlStreamingEditorBase uYHYyDEtyGRy0PFraCC3;

	protected XmlStreamingEditorBase(XmlReader reader, XmlWriter writer)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		dOLKaOEt9lqFJuhEbmhy();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			default:
				this.writer = writer;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
				{
					num = 0;
				}
				break;
			case 2:
				this.reader = reader;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			}
		}
	}

	public void Process()
	{
		//Discarded unreachable code: IL_009f, IL_00ae, IL_00bd, IL_00d0, IL_00df
		int num = 8;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
			case 4:
			case 8:
				if (reader.Read())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 1;
					}
					continue;
				}
				return;
			case 9:
				if (!Ko1RlhEtdOojjtTTt74D(this, reader))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			case 5:
				return;
			case 1:
			case 7:
				if (reader.NodeType == XmlNodeType.Element)
				{
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 9;
					}
					continue;
				}
				break;
			case 2:
				EditCurrentElement();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
				{
					num2 = 3;
				}
				continue;
			}
			sSvj23Etlv7a1wSBHbPL(reader, writer);
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 != 0)
			{
				num2 = 4;
			}
		}
	}

	protected abstract bool ShouldTransformElement(XmlReader reader);

	protected abstract void TransformElement(XmlReader reader, XmlWriter writer);

	private void EditCurrentElement()
	{
		//Discarded unreachable code: IL_0051, IL_0089, IL_00a8, IL_00b7, IL_00e4, IL_00f3
		int num = 2;
		int num2 = num;
		XmlReader xmlReader = default(XmlReader);
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				try
				{
					TransformElement(xmlReader, writer);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num3 = 0;
					}
					switch (num3)
					{
					case 0:
						break;
					}
					return;
				}
				finally
				{
					int num4;
					if (xmlReader == null)
					{
						num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
						{
							num4 = 1;
						}
						goto IL_008d;
					}
					goto IL_00c2;
					IL_00c2:
					P2tbnXEtgroa1qrEs26G(xmlReader);
					num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num4 = 0;
					}
					goto IL_008d;
					IL_008d:
					switch (num4)
					{
					default:
						goto end_IL_0068;
					case 1:
						goto end_IL_0068;
					case 2:
						break;
					case 0:
						goto end_IL_0068;
					}
					goto IL_00c2;
					end_IL_0068:;
				}
			case 0:
				return;
			case 2:
				xmlReader = (XmlReader)g5tvQvEtrvUqqIbifBB5(reader);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static void WriteShallowNode(object reader, object writer)
	{
		int num = 8;
		XmlNodeType xmlNodeType = default(XmlNodeType);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					return;
				case 9:
					break;
				case 15:
					return;
				case 2:
					return;
				case 5:
					CmO7uCEtsDP807hnvSRG(writer, reader, true);
					num2 = 3;
					continue;
				case 7:
					bPLBEjEtj75mtjocs7CV(reader, FF61ekEt5x4yfDIDVFIk(-1822890472 ^ -1822861794));
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					return;
				case 10:
					xmlNodeType = atWxAwEtYMmDDJhXaMMa(reader);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_458ac053851844e4b12b357b6e068056 == 0)
					{
						num2 = 7;
					}
					continue;
				case 14:
					return;
				default:
					ivugpsEtzLXFT2WV4kBL(writer);
					num2 = 11;
					continue;
				case 13:
					return;
				case 11:
					return;
				case 8:
					Contract.NotNull(writer, (string)FF61ekEt5x4yfDIDVFIk(-1411196499 ^ -1410965985));
					num2 = 7;
					continue;
				case 12:
					return;
				case 16:
					return;
				case 3:
					if (!GnfjMrEtcoPGOkmES0dI(reader))
					{
						return;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 0;
					}
					continue;
				case 6:
					return;
				}
				switch (xmlNodeType)
				{
				case XmlNodeType.CDATA:
					oLXtPMEwoOkZEmnASThi(writer, TPl0OEEwF7vJcymTNdP6(reader));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 1;
					}
					continue;
				default:
					num = 12;
					break;
				case XmlNodeType.ProcessingInstruction:
				case XmlNodeType.XmlDeclaration:
					DERZxuEwhNx1CkAotgYc(writer, UVxadbEwbJyWhaOtaQTk(reader), TPl0OEEwF7vJcymTNdP6(reader));
					num2 = 14;
					continue;
				case XmlNodeType.EndElement:
					((XmlWriter)writer).WriteFullEndElement();
					num2 = 13;
					continue;
				case XmlNodeType.EntityReference:
					((XmlWriter)writer).WriteEntityRef(((XmlReader)reader).Name);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 2;
					}
					continue;
				case XmlNodeType.DocumentType:
					qB4nGLEwEAkQKK3MIHRP(writer, UVxadbEwbJyWhaOtaQTk(reader), ts1fZyEwGxY0mcUS0II9(reader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1C9495B4 ^ 0x1C901276)), ts1fZyEwGxY0mcUS0II9(reader, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x6A81B9B4 ^ 0x6A853E66)), TPl0OEEwF7vJcymTNdP6(reader));
					num2 = 16;
					continue;
				case XmlNodeType.Attribute:
				case XmlNodeType.Entity:
				case XmlNodeType.Document:
				case XmlNodeType.DocumentFragment:
				case XmlNodeType.Notation:
				case XmlNodeType.EndEntity:
					return;
				case XmlNodeType.Text:
					zHdpBeEwBPuWegPuOsO4(writer, TPl0OEEwF7vJcymTNdP6(reader));
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 6;
					}
					continue;
				case XmlNodeType.Element:
					((XmlWriter)writer).WriteStartElement(((XmlReader)reader).Prefix, (string)Jfc2qeEtLFSyNKonQXB6(reader), (string)Sj5K6REtUZANUNeI4NmM(reader));
					num = 5;
					break;
				case XmlNodeType.Comment:
					((XmlWriter)writer).WriteComment((string)TPl0OEEwF7vJcymTNdP6(reader));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 != 0)
					{
						num2 = 2;
					}
					continue;
				case XmlNodeType.Whitespace:
				case XmlNodeType.SignificantWhitespace:
					SdorReEwWpjdgQLcI1Tm(writer, TPl0OEEwF7vJcymTNdP6(reader));
					num2 = 4;
					continue;
				}
				break;
			}
		}
	}

	internal static void dOLKaOEt9lqFJuhEbmhy()
	{
		SingletonReader.PushGlobal();
	}

	internal static bool bVgFj8EtMvWLH4ucDSJ1()
	{
		return uYHYyDEtyGRy0PFraCC3 == null;
	}

	internal static XmlStreamingEditorBase BdnE2qEtJqjrYIyXQhYX()
	{
		return uYHYyDEtyGRy0PFraCC3;
	}

	internal static bool Ko1RlhEtdOojjtTTt74D(object P_0, object P_1)
	{
		return ((XmlStreamingEditorBase)P_0).ShouldTransformElement((XmlReader)P_1);
	}

	internal static void sSvj23Etlv7a1wSBHbPL(object P_0, object P_1)
	{
		WriteShallowNode(P_0, P_1);
	}

	internal static object g5tvQvEtrvUqqIbifBB5(object P_0)
	{
		return ((XmlReader)P_0).ReadSubtree();
	}

	internal static void P2tbnXEtgroa1qrEs26G(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object FF61ekEt5x4yfDIDVFIk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void bPLBEjEtj75mtjocs7CV(object P_0, object P_1)
	{
		Contract.NotNull(P_0, (string)P_1);
	}

	internal static XmlNodeType atWxAwEtYMmDDJhXaMMa(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static object Jfc2qeEtLFSyNKonQXB6(object P_0)
	{
		return ((XmlReader)P_0).LocalName;
	}

	internal static object Sj5K6REtUZANUNeI4NmM(object P_0)
	{
		return ((XmlReader)P_0).NamespaceURI;
	}

	internal static void CmO7uCEtsDP807hnvSRG(object P_0, object P_1, bool P_2)
	{
		((XmlWriter)P_0).WriteAttributes((XmlReader)P_1, P_2);
	}

	internal static bool GnfjMrEtcoPGOkmES0dI(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static void ivugpsEtzLXFT2WV4kBL(object P_0)
	{
		((XmlWriter)P_0).WriteEndElement();
	}

	internal static object TPl0OEEwF7vJcymTNdP6(object P_0)
	{
		return ((XmlReader)P_0).Value;
	}

	internal static void zHdpBeEwBPuWegPuOsO4(object P_0, object P_1)
	{
		((XmlWriter)P_0).WriteString((string)P_1);
	}

	internal static void SdorReEwWpjdgQLcI1Tm(object P_0, object P_1)
	{
		((XmlWriter)P_0).WriteWhitespace((string)P_1);
	}

	internal static void oLXtPMEwoOkZEmnASThi(object P_0, object P_1)
	{
		((XmlWriter)P_0).WriteCData((string)P_1);
	}

	internal static object UVxadbEwbJyWhaOtaQTk(object P_0)
	{
		return ((XmlReader)P_0).Name;
	}

	internal static void DERZxuEwhNx1CkAotgYc(object P_0, object P_1, object P_2)
	{
		((XmlWriter)P_0).WriteProcessingInstruction((string)P_1, (string)P_2);
	}

	internal static object ts1fZyEwGxY0mcUS0II9(object P_0, object P_1)
	{
		return ((XmlReader)P_0).GetAttribute((string)P_1);
	}

	internal static void qB4nGLEwEAkQKK3MIHRP(object P_0, object P_1, object P_2, object P_3, object P_4)
	{
		((XmlWriter)P_0).WriteDocType((string)P_1, (string)P_2, (string)P_3, (string)P_4);
	}
}
