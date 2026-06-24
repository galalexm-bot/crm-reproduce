using System;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Metadata;

[Serializable]
public class Parameter : IXmlSerializable
{
	internal static Parameter J49hZlbtA5eXTVsGrYRU;

	public string Name
	{
		[CompilerGenerated]
		get
		{
			return _003CName_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
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

	public object Value
	{
		[CompilerGenerated]
		get
		{
			return _003CValue_003Ek__BackingField;
		}
		[CompilerGenerated]
		set
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
					_003CValue_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public Parameter()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		rAPnXobt0OaMf9ArvysQ();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	public Parameter(string name, object value)
	{
		//Discarded unreachable code: IL_002a, IL_002f
		rAPnXobt0OaMf9ArvysQ();
		base._002Ector();
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				return;
			default:
				Value = value;
				num = 2;
				break;
			case 1:
				Name = name;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	XmlSchema IXmlSerializable.GetSchema()
	{
		return null;
	}

	void IXmlSerializable.ReadXml(XmlReader reader)
	{
		//Discarded unreachable code: IL_01dd, IL_0338, IL_0347, IL_0373, IL_0382, IL_0392, IL_03a1, IL_03f5, IL_0404, IL_04ac, IL_04bb, IL_0506, IL_05b9, IL_0638, IL_0683, IL_0696, IL_06e1, IL_06f0, IL_06ff, IL_0752, IL_080a, IL_0819, IL_084f, IL_085e, IL_086e, IL_08a5, IL_08b4, IL_08c4, IL_08d3, IL_0955, IL_0964, IL_099e, IL_09f9, IL_0a08, IL_0a18, IL_0a27, IL_0a77, IL_0aa6, IL_0b07, IL_0b16, IL_0b71, IL_0b9b, IL_0bd0, IL_0bdf, IL_0bef, IL_0bfe, IL_0c0d, IL_0c43, IL_0c82, IL_0c91, IL_0ca4, IL_0d43, IL_0ddd, IL_0dfd, IL_0e0c, IL_0e1c, IL_0e2b, IL_0e4b, IL_0e5e
		int num = 41;
		string attribute = default(string);
		uint num3 = default(uint);
		TypeConverter converter = default(TypeConverter);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 13:
					if (tePKdcbtr3V8L0hXeqJW(attribute, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EEF8A6)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 10:
					if (tePKdcbtr3V8L0hXeqJW(attribute, eiNUZ5btmhodNEq1VCh2(0x92F12D5 ^ 0x92DE153)))
					{
						num2 = 70;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
						{
							num2 = 4;
						}
						continue;
					}
					goto case 4;
				default:
					Value = c1NvwNbtsPPxhlSbjIC2(VeGQspbtgGsgnlrDCVer(reader));
					num2 = 15;
					continue;
				case 55:
					if (num3 != 556808448)
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 23;
						}
						continue;
					}
					goto case 20;
				case 6:
				case 21:
					Value = (short)UTZRJCbtLA2I5GFZbw4E(reader);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
					{
						num2 = 48;
					}
					continue;
				case 107:
					if (num3 != 3825147585u)
					{
						num2 = 82;
						continue;
					}
					goto case 64;
				case 18:
					Value = UTZRJCbtLA2I5GFZbw4E(reader);
					num2 = 37;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
					{
						num2 = 16;
					}
					continue;
				case 102:
					if (attribute == (string)eiNUZ5btmhodNEq1VCh2(-1998538950 ^ -1998437318))
					{
						num2 = 101;
						continue;
					}
					goto case 4;
				case 26:
					Value = (uint)wK4V5MbtUDppGan7PTwc(reader);
					num2 = 59;
					continue;
				case 43:
					if (num3 <= 2510089467u)
					{
						num = 72;
						break;
					}
					goto case 38;
				case 101:
				case 110:
					Value = z9jw38btjg3X7KsgfomM(reader);
					num2 = 74;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 30;
					}
					continue;
				case 76:
					if (!tePKdcbtr3V8L0hXeqJW(attribute, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xA592A41 ^ 0xA5BD95B)))
					{
						num2 = 99;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 29;
						}
						continue;
					}
					goto case 24;
				case 66:
				case 81:
					Value = (byte)reader.ReadContentAsInt();
					num = 9;
					break;
				case 17:
					if (!tePKdcbtr3V8L0hXeqJW(attribute, eiNUZ5btmhodNEq1VCh2(0x68BBB53E ^ 0x68B94676)))
					{
						num2 = 88;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 8;
				case 58:
				case 92:
					Value = reader.ReadContentAsString();
					num2 = 86;
					continue;
				case 14:
					if (tePKdcbtr3V8L0hXeqJW(attribute, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837789727)))
					{
						num2 = 21;
						continue;
					}
					goto case 4;
				case 103:
					attribute = reader.GetAttribute((string)eiNUZ5btmhodNEq1VCh2(0xD3DEF7E ^ 0xD3F1DC8));
					num2 = 52;
					continue;
				case 42:
					DPbAcHbtJjY8nPGw2GWF(reader);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 53;
					}
					continue;
				case 24:
					Value = reader.ReadContentAsFloat();
					num2 = 41;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
					{
						num2 = 75;
					}
					continue;
				case 90:
					if (tePKdcbtr3V8L0hXeqJW(attribute, eiNUZ5btmhodNEq1VCh2(0x5DD55050 ^ 0x5DD7A29A)))
					{
						num2 = 18;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
						{
							num2 = 58;
						}
						continue;
					}
					goto case 4;
				case 9:
				case 15:
				case 19:
				case 33:
				case 34:
				case 37:
				case 46:
				case 48:
				case 54:
				case 59:
				case 63:
				case 74:
				case 75:
				case 86:
				case 98:
					DX4P50bwFI6Z275tMiPX(reader);
					num2 = 100;
					continue;
				case 1:
					DX4P50bwFI6Z275tMiPX(reader);
					num2 = 2;
					continue;
				case 27:
					if (num3 != 2510089467u)
					{
						num2 = 108;
						continue;
					}
					goto case 61;
				case 51:
					if (tePKdcbtr3V8L0hXeqJW(attribute, eiNUZ5btmhodNEq1VCh2(-675505729 ^ -675386865)))
					{
						num2 = 96;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9a346b859fbf42ffb993af465115552b == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 4;
				case 56:
					if (attribute == (string)eiNUZ5btmhodNEq1VCh2(0x4EDCBA32 ^ 0x4EDE4950))
					{
						num2 = 41;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 == 0)
						{
							num2 = 66;
						}
						continue;
					}
					goto case 4;
				case 20:
					if (tePKdcbtr3V8L0hXeqJW(attribute, eiNUZ5btmhodNEq1VCh2(-1426094279 ^ -1426230477)))
					{
						num2 = 69;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 93;
						}
						continue;
					}
					goto case 4;
				case 35:
					if (num3 != 2752958846u)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 102;
				case 79:
					Value = g2r4wXbtzDLsQLkQeZ9x(converter, VeGQspbtgGsgnlrDCVer(reader));
					num2 = 33;
					continue;
				case 12:
				case 45:
				case 100:
					if (ESYxYJbt9xqkkGUl2u4B(reader) != XmlNodeType.Whitespace)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 65;
				case 97:
					if (!tePKdcbtr3V8L0hXeqJW(attribute, eiNUZ5btmhodNEq1VCh2(-2138958856 ^ -2139037650)))
					{
						num2 = 22;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
						{
							num2 = 73;
						}
						continue;
					}
					goto case 18;
				case 38:
					if (num3 != 2677843292u)
					{
						num2 = 35;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 10;
				case 5:
					if (num3 != 3087237559u)
					{
						num2 = 49;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 42;
						}
						continue;
					}
					goto case 97;
				case 22:
					if (num3 <= 3450944805u)
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 85;
				case 4:
				case 7:
				case 32:
				case 36:
				case 44:
				case 47:
				case 50:
				case 57:
				case 60:
				case 69:
				case 71:
				case 73:
				case 77:
				case 78:
				case 80:
				case 83:
				case 87:
				case 88:
				case 99:
				case 104:
				case 108:
					converter = TypeDescriptor.GetConverter(YgrEk2btcXU1sGdOnGJT(attribute));
					num2 = 38;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 79;
					}
					continue;
				case 52:
					HTy4EYbtd35taJqqb3SV(reader, eiNUZ5btmhodNEq1VCh2(-1822890472 ^ -1822932916));
					num2 = 28;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
					{
						num2 = 4;
					}
					continue;
				case 2:
					return;
				case 95:
					DPbAcHbtJjY8nPGw2GWF(reader);
					num2 = 12;
					continue;
				case 84:
					if (num3 != 1535340147)
					{
						num = 104;
						break;
					}
					goto case 13;
				case 3:
					if (num3 != 3465876478u)
					{
						num2 = 11;
						continue;
					}
					goto case 29;
				case 8:
					Value = J2cc3NbtYHbsg4HmN96y(reader);
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
					{
						num2 = 63;
					}
					continue;
				case 72:
					if (num3 != 2479764320u)
					{
						num2 = 27;
						continue;
					}
					goto case 14;
				case 68:
				case 70:
					Value = (sbyte)UTZRJCbtLA2I5GFZbw4E(reader);
					num2 = 46;
					continue;
				case 49:
					if (num3 != 3450944805u)
					{
						num = 80;
						break;
					}
					goto case 17;
				case 25:
					Value = KhKUtibt5lWaYHv78X84(VeGQspbtgGsgnlrDCVer(reader), 0);
					num = 19;
					break;
				case 31:
				case 93:
					Value = wK4V5MbtUDppGan7PTwc(reader);
					num2 = 98;
					continue;
				case 89:
				case 96:
					Value = (ushort)reader.ReadContentAsInt();
					num = 34;
					break;
				case 11:
					if (num3 != 3777590079u)
					{
						num2 = 36;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 56;
				case 64:
					if (!tePKdcbtr3V8L0hXeqJW(attribute, eiNUZ5btmhodNEq1VCh2(-1751176224 ^ -1751262974)))
					{
						num2 = 7;
						continue;
					}
					goto case 25;
				case 82:
					if (num3 != 3899788149u)
					{
						num2 = 32;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 51;
				case 40:
					if (Vn5HtgbtMWprJA8B2ZHQ(reader))
					{
						num2 = 39;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
						{
							num2 = 28;
						}
						continue;
					}
					reader.ReadStartElement((string)eiNUZ5btmhodNEq1VCh2(0x57A5235E ^ 0x57A79A2C));
					num2 = 62;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 44;
					}
					continue;
				case 67:
				case 105:
					Value = reader.ReadContentAsDouble();
					num2 = 54;
					continue;
				case 29:
					if (!(attribute == (string)eiNUZ5btmhodNEq1VCh2(-643786247 ^ -643667439)))
					{
						num2 = 47;
						continue;
					}
					goto case 26;
				case 53:
				case 62:
					if (ESYxYJbt9xqkkGUl2u4B(reader) != XmlNodeType.Whitespace)
					{
						num2 = 94;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
						{
							num2 = 51;
						}
						continue;
					}
					goto case 42;
				case 16:
					if (num3 != 2758855996u)
					{
						num2 = 5;
						continue;
					}
					goto case 76;
				case 91:
					if (num3 <= 1535340147)
					{
						num = 55;
						break;
					}
					goto case 43;
				case 30:
					return;
				case 109:
					if (num3 <= 2752958846u)
					{
						num2 = 91;
						continue;
					}
					goto case 22;
				case 28:
					num3 = x2bXowbtlal9lCIjobV9(attribute);
					num2 = 48;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec == 0)
					{
						num2 = 109;
					}
					continue;
				case 85:
					if (num3 <= 3777590079u)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
						{
							num2 = 3;
						}
						continue;
					}
					goto case 107;
				case 94:
					if (Vn5HtgbtMWprJA8B2ZHQ(reader))
					{
						num2 = 95;
						continue;
					}
					goto case 103;
				case 23:
					if (num3 != 1102226759)
					{
						num2 = 84;
						continue;
					}
					goto case 90;
				case 61:
					if (!(attribute == (string)eiNUZ5btmhodNEq1VCh2(-1710575414 ^ -1710734342)))
					{
						goto case 4;
					}
					num2 = 67;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 35;
					}
					continue;
				case 41:
					Name = (string)DA3DntbtyA533oco991s(reader, eiNUZ5btmhodNEq1VCh2(0x5DD55050 ^ 0x5DD52390));
					num = 40;
					break;
				case 65:
					DPbAcHbtJjY8nPGw2GWF(reader);
					num2 = 45;
					continue;
				case 39:
					reader.Read();
					num2 = 30;
					continue;
				}
				break;
			}
		}
	}

	void IXmlSerializable.WriteXml(XmlWriter writer)
	{
		//Discarded unreachable code: IL_0149, IL_0183, IL_0192, IL_01fa, IL_0204, IL_0213, IL_0280, IL_028f, IL_029f, IL_02ae, IL_02be, IL_0341, IL_0392, IL_03a1, IL_03b1, IL_03c0, IL_0401, IL_0410, IL_0423, IL_0478, IL_0487, IL_04dd, IL_04ec, IL_054e, IL_0561, IL_059c, IL_065f, IL_066e, IL_06bc, IL_06cb, IL_0713, IL_0722, IL_0732, IL_0741, IL_0751, IL_080b, IL_0863, IL_0872
		int num = 7;
		Type type = default(Type);
		string value = default(string);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 14:
					iyPd99bwG8rMKwv3m1Sx(writer);
					num2 = 52;
					continue;
				case 58:
					if (!fj6pyMbwb5MbY2I1m7og(type, TypeOf<string>.Raw))
					{
						num2 = 27;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
						{
							num2 = 20;
						}
						continue;
					}
					goto case 36;
				case 34:
					value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882302254);
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 66;
					}
					continue;
				case 56:
					if (!fj6pyMbwb5MbY2I1m7og(type, TypeOf<float>.Raw))
					{
						num2 = 28;
						continue;
					}
					goto case 40;
				case 15:
					obj = eiNUZ5btmhodNEq1VCh2(-2138160520 ^ -2138154910);
					goto IL_08fe;
				default:
					if (!fj6pyMbwb5MbY2I1m7og(type, TypeOf<uint>.Raw))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
						{
							num2 = 12;
						}
						continue;
					}
					goto case 57;
				case 68:
					type = Value.GetType();
					num2 = 48;
					continue;
				case 19:
				case 42:
					if (fj6pyMbwb5MbY2I1m7og(type, TypeOf<bool>.Raw))
					{
						num2 = 4;
						continue;
					}
					goto case 56;
				case 32:
				case 65:
					if (fj6pyMbwb5MbY2I1m7og(type, TypeOf<sbyte>.Raw))
					{
						num2 = 69;
						continue;
					}
					goto case 16;
				case 36:
					value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1317790512 ^ -1317605862);
					num2 = 50;
					continue;
				case 67:
					if (text == null)
					{
						num2 = 23;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 53;
				case 26:
					return;
				case 52:
					return;
				case 25:
				case 47:
					if (fj6pyMbwb5MbY2I1m7og(type, TypeOf<ushort>.Raw))
					{
						num2 = 34;
						continue;
					}
					goto case 22;
				case 9:
				case 28:
					if (!(type == TypeOf<double>.Raw))
					{
						num2 = 43;
						continue;
					}
					goto case 10;
				case 7:
					if (zcIHIEbwBFrQh1hFgdS5(Name))
					{
						num2 = 6;
						continue;
					}
					goto case 24;
				case 48:
					text = null;
					num2 = 58;
					continue;
				case 23:
					text = ((TypeConverter)sw0LOUbwhYKimivdXQ87(type)).ConvertToString(Value);
					num2 = 53;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 5;
					}
					continue;
				case 16:
					if (!fj6pyMbwb5MbY2I1m7og(type, TypeOf<short>.Raw))
					{
						num2 = 47;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 62;
				case 43:
				case 63:
					if (!(type == TypeOf<decimal>.Raw))
					{
						num2 = 31;
						continue;
					}
					goto case 21;
				case 45:
					su2Ikobwob69qK5cEvPi(writer, eiNUZ5btmhodNEq1VCh2(0x1637C429 ^ 0x1637627D));
					num2 = 68;
					continue;
				case 30:
					value = (string)eiNUZ5btmhodNEq1VCh2(0x1FFEF86A ^ 0x1FFC0C74);
					num = 20;
					break;
				case 3:
				case 31:
					if (!(type == TypeOf<byte>.Raw))
					{
						num2 = 32;
						continue;
					}
					goto case 18;
				case 4:
					value = (string)eiNUZ5btmhodNEq1VCh2(0x269E5FCA ^ 0x269CACCA);
					num2 = 61;
					continue;
				case 22:
					if (fj6pyMbwb5MbY2I1m7og(type, TypeOf<int>.Raw))
					{
						num2 = 11;
						continue;
					}
					goto default;
				case 46:
					value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710734808);
					num2 = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 9;
					}
					continue;
				case 17:
				case 27:
					if (!fj6pyMbwb5MbY2I1m7og(type, TypeOf<char>.Raw))
					{
						num2 = 19;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
						{
							num2 = 18;
						}
						continue;
					}
					goto case 46;
				case 18:
					value = (string)eiNUZ5btmhodNEq1VCh2(0x6A81B9B4 ^ 0x6A834AD6);
					num = 37;
					break;
				case 41:
					if (!fj6pyMbwb5MbY2I1m7og(type, TypeOf<ulong>.Raw))
					{
						num2 = 59;
						continue;
					}
					goto case 30;
				case 62:
					value = (string)eiNUZ5btmhodNEq1VCh2(0x571EA399 ^ 0x571C5003);
					num2 = 8;
					continue;
				case 6:
				case 64:
					if (Value == null)
					{
						num2 = 26;
						continue;
					}
					goto case 45;
				case 50:
					text = (string)Value;
					num2 = 60;
					continue;
				case 40:
					value = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x3632007B);
					num2 = 29;
					continue;
				case 57:
					value = (string)eiNUZ5btmhodNEq1VCh2(0x1ECE530A ^ 0x1ECCA0E2);
					num2 = 38;
					continue;
				case 53:
					writer.WriteValue(text);
					num2 = 14;
					continue;
				case 24:
					nvXRmxbwWmDY1QcgU4yV(writer, eiNUZ5btmhodNEq1VCh2(--1333735954 ^ 0x4F7F41D2), Name);
					num2 = 64;
					continue;
				case 55:
					value = (string)eiNUZ5btmhodNEq1VCh2(0x53FA00CE ^ 0x53F8F4C4);
					num2 = 39;
					continue;
				case 69:
					value = (string)eiNUZ5btmhodNEq1VCh2(-2106517564 ^ -2106334142);
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 31;
					}
					continue;
				case 2:
				case 59:
					value = type.AssemblyQualifiedName;
					num2 = 44;
					continue;
				case 21:
					value = (string)eiNUZ5btmhodNEq1VCh2(--1333735954 ^ 0x4F7DC15A);
					num2 = 13;
					continue;
				case 10:
					value = (string)eiNUZ5btmhodNEq1VCh2(-210725949 ^ -210607885);
					num2 = 50;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 51;
					}
					continue;
				case 61:
					if ((bool)Value)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 15;
				case 5:
				case 12:
					if (type == TypeOf<long>.Raw)
					{
						num = 55;
						break;
					}
					goto case 41;
				case 11:
					value = (string)eiNUZ5btmhodNEq1VCh2(-1751176224 ^ -1751263178);
					num2 = 54;
					continue;
				case 8:
				case 13:
				case 20:
				case 29:
				case 33:
				case 35:
				case 37:
				case 38:
				case 39:
				case 44:
				case 49:
				case 51:
				case 54:
				case 60:
				case 66:
					writer.WriteAttributeString(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103D1D37), (string)eiNUZ5btmhodNEq1VCh2(0x76DD48E ^ 0x76DD8AC), null, value);
					num2 = 67;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num2 = 25;
					}
					continue;
				case 1:
					{
						obj = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979244993);
						goto IL_08fe;
					}
					IL_08fe:
					text = (string)obj;
					num2 = 49;
					continue;
				}
				break;
			}
		}
	}

	internal static void rAPnXobt0OaMf9ArvysQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool hDGLCfbt7K2SJXL0Zdeg()
	{
		return J49hZlbtA5eXTVsGrYRU == null;
	}

	internal static Parameter BuY1FHbtxeZ2WNE7VkOM()
	{
		return J49hZlbtA5eXTVsGrYRU;
	}

	internal static object eiNUZ5btmhodNEq1VCh2(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object DA3DntbtyA533oco991s(object P_0, object P_1)
	{
		return ((XmlReader)P_0).GetAttribute((string)P_1);
	}

	internal static bool Vn5HtgbtMWprJA8B2ZHQ(object P_0)
	{
		return ((XmlReader)P_0).IsEmptyElement;
	}

	internal static bool DPbAcHbtJjY8nPGw2GWF(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static XmlNodeType ESYxYJbt9xqkkGUl2u4B(object P_0)
	{
		return ((XmlReader)P_0).NodeType;
	}

	internal static void HTy4EYbtd35taJqqb3SV(object P_0, object P_1)
	{
		((XmlReader)P_0).ReadStartElement((string)P_1);
	}

	internal static uint x2bXowbtlal9lCIjobV9(object P_0)
	{
		return _003CPrivateImplementationDetails_003E.ComputeStringHash((string)P_0);
	}

	internal static bool tePKdcbtr3V8L0hXeqJW(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object VeGQspbtgGsgnlrDCVer(object P_0)
	{
		return ((XmlReader)P_0).ReadContentAsString();
	}

	internal static char KhKUtibt5lWaYHv78X84(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static bool z9jw38btjg3X7KsgfomM(object P_0)
	{
		return ((XmlReader)P_0).ReadContentAsBoolean();
	}

	internal static decimal J2cc3NbtYHbsg4HmN96y(object P_0)
	{
		return ((XmlReader)P_0).ReadContentAsDecimal();
	}

	internal static int UTZRJCbtLA2I5GFZbw4E(object P_0)
	{
		return ((XmlReader)P_0).ReadContentAsInt();
	}

	internal static long wK4V5MbtUDppGan7PTwc(object P_0)
	{
		return ((XmlReader)P_0).ReadContentAsLong();
	}

	internal static ulong c1NvwNbtsPPxhlSbjIC2(object P_0)
	{
		return Convert.ToUInt64((string)P_0);
	}

	internal static Type YgrEk2btcXU1sGdOnGJT(object P_0)
	{
		return Type.GetType((string)P_0);
	}

	internal static object g2r4wXbtzDLsQLkQeZ9x(object P_0, object P_1)
	{
		return ((TypeConverter)P_0).ConvertFromString((string)P_1);
	}

	internal static void DX4P50bwFI6Z275tMiPX(object P_0)
	{
		((XmlReader)P_0).ReadEndElement();
	}

	internal static bool zcIHIEbwBFrQh1hFgdS5(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static void nvXRmxbwWmDY1QcgU4yV(object P_0, object P_1, object P_2)
	{
		((XmlWriter)P_0).WriteAttributeString((string)P_1, (string)P_2);
	}

	internal static void su2Ikobwob69qK5cEvPi(object P_0, object P_1)
	{
		((XmlWriter)P_0).WriteStartElement((string)P_1);
	}

	internal static bool fj6pyMbwb5MbY2I1m7og(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static object sw0LOUbwhYKimivdXQ87(Type P_0)
	{
		return TypeDescriptor.GetConverter(P_0);
	}

	internal static void iyPd99bwG8rMKwv3m1Sx(object P_0)
	{
		((XmlWriter)P_0).WriteEndElement();
	}
}
