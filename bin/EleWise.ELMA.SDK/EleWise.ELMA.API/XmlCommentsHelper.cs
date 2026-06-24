using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Model.Attributes;
using EleWise.ELMA.Model.CodeGeneration;
using EleWise.ELMA.Model.CodeGeneration.PublicApi;
using EleWise.ELMA.Model.Metadata;
using EleWise.ELMA.SDK;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.API;

public static class XmlCommentsHelper
{
	internal static XmlCommentsHelper MdWBVxfPfScHqg4ATnvQ;

	public static List<XmlDocument> XmlDocuments { get; set; }

	static XmlCommentsHelper()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				vW3gDgfPvaYwuM3oFSid();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				XmlDocuments = new List<XmlDocument>();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public static string GetSummary(PropertyInfo propertyInfo)
	{
		//Discarded unreachable code: IL_0147
		int num = 7;
		string result = default(string);
		XmlNode xmlNode = default(XmlNode);
		XmlDocument xmlDocument = default(XmlDocument);
		string text2 = default(string);
		string text = default(string);
		Type type2 = default(Type);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				Type type;
				switch (num2)
				{
				case 10:
					result = ((string)zCuoZXfPXvCmRarckDKg(UZ5QaOfPKBai9gLKJZh6(xmlNode), Array.Empty<char>())).TrimStart(Array.Empty<char>());
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
					{
						num2 = 3;
					}
					continue;
				case 7:
					result = "";
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
					{
						num2 = 6;
					}
					continue;
				default:
					return result;
				case 2:
					xmlNode = (XmlNode)ErWIonfPqQZlg9mlDawj(xmlDocument, text2);
					num2 = 9;
					continue;
				case 9:
					if (xmlNode == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 10;
				case 11:
					text = (string)qc9MLnfPiHGe3mBwlrRI(e1cmPPfPuRCc6J13BtBX(-29254301 ^ -29043119), sDOFiIfPIXaEYaK9AFMC(type2.FullName, e1cmPPfPuRCc6J13BtBX(-1459557599 ^ -1459575553), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x8317432 ^ 0x8316EF6)), propertyInfo.Name);
					num2 = 5;
					continue;
				case 6:
					xmlDocument = (XmlDocument)iQGvKrfPV6nRtSBiuoeU(sDOFiIfPIXaEYaK9AFMC(dhi413fPZ5ra0BrHcU5K(RJnUHPfP86NBki4oNyrn(propertyInfo).Assembly), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A32BA8C), e1cmPPfPuRCc6J13BtBX(-1978478350 ^ -1978507588)));
					num = 8;
					break;
				case 1:
					if (xmlDocument != null)
					{
						num = 2;
						break;
					}
					goto default;
				case 5:
					text2 = (string)BnNor0fPRitOybv6Tyof(e1cmPPfPuRCc6J13BtBX(0x26FFCB59 ^ 0x26FA8011), text);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
					{
						num2 = 0;
					}
					continue;
				case 8:
					type = RJnUHPfP86NBki4oNyrn(propertyInfo).DeclaringType;
					if ((object)type != null)
					{
						goto IL_0210;
					}
					num2 = 4;
					continue;
				case 4:
					{
						type = FKylgtfPSQL65EskRmiu(propertyInfo);
						goto IL_0210;
					}
					IL_0210:
					type2 = type;
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 != 0)
					{
						num2 = 11;
					}
					continue;
				}
				break;
			}
		}
	}

	public static string GetRemarks(PropertyInfo propertyInfo)
	{
		return string.Empty;
	}

	public static string GetCodeExample(PropertyInfo propertyInfo)
	{
		return string.Empty;
	}

	public static string ReplaceIgnoreCase(this string originalString, string oldValue, string newValue)
	{
		//Discarded unreachable code: IL_00bd, IL_00cc
		int num = 5;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					break;
				case 7:
					if (num3 >= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 3;
				default:
					return originalString;
				case 1:
					originalString = (string)vy8RWHfPkUXY7w0oXu0g(originalString.Remove(num3, I5FZkQfPTc8nUHfpifcI(oldValue)), num3, newValue);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					num3 += I5FZkQfPTc8nUHfpifcI(newValue);
					num2 = 3;
					continue;
				case 3:
					if (num3 >= 0)
					{
						num2 = 6;
						continue;
					}
					goto default;
				case 4:
				case 6:
					num3 = originalString.IndexOf(oldValue, num3, StringComparison.InvariantCultureIgnoreCase);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 7;
					}
					continue;
				}
				break;
			}
			num3 = 0;
			num = 4;
		}
	}

	public static Dictionary<string, string> GetParametersDescription(MethodInfo info)
	{
		_003C_003Ec__DisplayClass9_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass9_0();
		CS_0024_003C_003E8__locals0.info = info;
		Dictionary<string, string> dictionary = new Dictionary<string, string>();
		XmlDocument xmlDocument = LoadIfNotContains(CS_0024_003C_003E8__locals0.info.DeclaringType.Assembly.CodeBase.ReplaceIgnoreCase(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1837662597 ^ -1837745471), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE12A781)));
		string xpath = string.Format(arg0: string.Format(arg2: (CS_0024_003C_003E8__locals0.info.GetParameters().Length == 0) ? string.Empty : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE1DA39), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-488881205 ^ -488894149), from a in CS_0024_003C_003E8__locals0.info.GetParameters()
			select (string)_003C_003Ec__DisplayClass9_0.WH4txQZF23MOT7PnP4KV(a.ParameterType, CS_0024_003C_003E8__locals0.info))), format: z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1767720453 ^ -1767378335), arg0: CS_0024_003C_003E8__locals0.info.DeclaringType.FullName.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A7AC94), z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x511518D9)), arg1: CS_0024_003C_003E8__locals0.info.Name), format: z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210380683));
		foreach (XmlNode item in xmlDocument.SelectNodes(xpath))
		{
			string innerText = item.Attributes[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889461162)].InnerText;
			int num = item.InnerText.IndexOf('.');
			string value = ((num > 0) ? item.InnerText.Remove(num) : item.InnerText);
			dictionary.Add(innerText, value);
		}
		return dictionary;
	}

	public static string GetSummary(MethodInfo methodInfo)
	{
		//Discarded unreachable code: IL_01da, IL_01e9, IL_026d, IL_027c, IL_02e3, IL_02f2, IL_0315, IL_0324, IL_03a2
		int num = 15;
		int num2 = num;
		Type type = default(Type);
		string text = default(string);
		_003C_003Ec__DisplayClass10_0 _003C_003Ec__DisplayClass10_ = default(_003C_003Ec__DisplayClass10_0);
		XmlDocument xmlDocument = default(XmlDocument);
		string text3 = default(string);
		string text2 = default(string);
		XmlNode xmlNode = default(XmlNode);
		string text4 = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 2:
				if (!MZCJZZfPON0o9tX39Kpv(yotysmfPn0liKKjBVZTD(type), e1cmPPfPuRCc6J13BtBX(0x76DD48E ^ 0x76898FA)))
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
					{
						num2 = 8;
					}
					continue;
				}
				goto case 9;
			case 9:
			case 20:
				return text;
			case 7:
				type = FKylgtfPSQL65EskRmiu(_003C_003Ec__DisplayClass10_.methodInfo);
				num2 = 17;
				continue;
			case 15:
				_003C_003Ec__DisplayClass10_ = new _003C_003Ec__DisplayClass10_0();
				num2 = 14;
				continue;
			case 4:
			case 10:
				xmlDocument = (XmlDocument)iQGvKrfPV6nRtSBiuoeU(((string)dhi413fPZ5ra0BrHcU5K(type.Assembly)).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583955216), (string)e1cmPPfPuRCc6J13BtBX(-2099751081 ^ -2099717863)));
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 9;
				}
				continue;
			case 18:
				text3 = string.Format((string)e1cmPPfPuRCc6J13BtBX(-1837662597 ^ -1838009749), type.Namespace, yotysmfPn0liKKjBVZTD(type), yotysmfPn0liKKjBVZTD(_003C_003Ec__DisplayClass10_.methodInfo), text2);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 16;
				}
				continue;
			case 8:
				if (eXQR4FfP2epSgYso1I4J(type, TypeOf<object>.Raw))
				{
					num2 = 10;
					continue;
				}
				goto case 9;
			case 6:
			case 17:
				if (!text.IsNullOrEmpty())
				{
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
					{
						num2 = 20;
					}
					continue;
				}
				goto case 2;
			case 13:
				xmlNode = (XmlNode)ErWIonfPqQZlg9mlDawj(xmlDocument, text4);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 != 0)
				{
					num2 = 1;
				}
				continue;
			case 16:
				text4 = (string)BnNor0fPRitOybv6Tyof(e1cmPPfPuRCc6J13BtBX(0x103FE975 ^ 0x103AA541), text3);
				num2 = 13;
				continue;
			case 11:
				if (_003C_003Ec__DisplayClass10_.methodInfo.GetParameters().Length == 0)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 5;
			case 12:
				text = "";
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
				{
					num2 = 6;
				}
				continue;
			case 1:
				if (xmlNode != null)
				{
					num2 = 19;
					continue;
				}
				goto case 3;
			case 14:
				_003C_003Ec__DisplayClass10_.methodInfo = methodInfo;
				num2 = 12;
				continue;
			case 19:
				text = (string)UZ5QaOfPKBai9gLKJZh6(xmlNode);
				num2 = 3;
				continue;
			case 3:
				type = type.BaseType;
				num2 = 6;
				continue;
			case 5:
				obj = BnNor0fPRitOybv6Tyof(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1979251663 ^ -1979382911), string.Join((string)e1cmPPfPuRCc6J13BtBX(-1870892489 ^ -1870913337), _003C_003Ec__DisplayClass10_.methodInfo.GetParameters().Select(_003C_003Ec__DisplayClass10_._003CGetSummary_003Eb__0)));
				break;
			default:
				obj = string.Empty;
				break;
			}
			text2 = (string)obj;
			num2 = 18;
		}
	}

	public static string GetRemarks(MethodInfo methodInfo)
	{
		//Discarded unreachable code: IL_00f4, IL_0266, IL_0275, IL_0285, IL_0294, IL_0316, IL_0325, IL_039c
		int num = 5;
		string text3 = default(string);
		XmlNode xmlNode = default(XmlNode);
		_003C_003Ec__DisplayClass11_0 _003C_003Ec__DisplayClass11_ = default(_003C_003Ec__DisplayClass11_0);
		string xpath = default(string);
		string text2 = default(string);
		Type type = default(Type);
		string text = default(string);
		XmlDocument xmlDocument = default(XmlDocument);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 6:
					text3 = (string)UZ5QaOfPKBai9gLKJZh6(xmlNode);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
					{
						num2 = 11;
					}
					continue;
				case 11:
					if (_003C_003Ec__DisplayClass11_.methodInfo.GetParameters().Length != 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = string.Empty;
					goto IL_03a6;
				case 9:
				case 10:
				case 13:
					return text3;
				case 12:
					xpath = (string)BnNor0fPRitOybv6Tyof(e1cmPPfPuRCc6J13BtBX(-521266112 ^ -521449242), text2);
					num = 14;
					break;
				case 19:
				case 20:
					if (!lGUZv2fP1ivmhLi3TSbB(text3))
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 5;
						}
						continue;
					}
					goto case 8;
				case 4:
					_003C_003Ec__DisplayClass11_.methodInfo = methodInfo;
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 7;
					}
					continue;
				case 3:
					if (!eXQR4FfP2epSgYso1I4J(type, TypeOf<object>.Raw))
					{
						num2 = 9;
						continue;
					}
					goto case 17;
				case 8:
					if (MZCJZZfPON0o9tX39Kpv(yotysmfPn0liKKjBVZTD(type), e1cmPPfPuRCc6J13BtBX(0x7459E02 ^ 0x740D276)))
					{
						num2 = 13;
						continue;
					}
					goto case 3;
				case 15:
				case 18:
					type = type.BaseType;
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
					{
						num2 = 20;
					}
					continue;
				case 7:
					text3 = "";
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
					{
						num2 = 1;
					}
					continue;
				case 1:
					type = FKylgtfPSQL65EskRmiu(_003C_003Ec__DisplayClass11_.methodInfo);
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num2 = 19;
					}
					continue;
				case 16:
					text2 = (string)nbDWNsfPPrS9Phjcdixe(e1cmPPfPuRCc6J13BtBX(-1876063057 ^ -1876377409), new object[4]
					{
						type.Namespace,
						yotysmfPn0liKKjBVZTD(type),
						yotysmfPn0liKKjBVZTD(_003C_003Ec__DisplayClass11_.methodInfo),
						text
					});
					num2 = 12;
					continue;
				case 2:
					if (xmlNode == null)
					{
						num = 18;
						break;
					}
					goto case 6;
				case 14:
					xmlNode = xmlDocument.SelectSingleNode(xpath);
					num2 = 2;
					continue;
				case 17:
					xmlDocument = (XmlDocument)iQGvKrfPV6nRtSBiuoeU(((string)dhi413fPZ5ra0BrHcU5K(type.Assembly)).Replace((string)e1cmPPfPuRCc6J13BtBX(0x12A5FAC7 ^ 0x12A0B6C3), (string)e1cmPPfPuRCc6J13BtBX(0x5DD55050 ^ 0x5DD5DE1E)));
					num2 = 11;
					continue;
				case 5:
					_003C_003Ec__DisplayClass11_ = new _003C_003Ec__DisplayClass11_0();
					num = 4;
					break;
				default:
					{
						obj = BnNor0fPRitOybv6Tyof(e1cmPPfPuRCc6J13BtBX(0x53CACA3 ^ 0x53EAB13), string.Join((string)e1cmPPfPuRCc6J13BtBX(-1876063057 ^ -1876042145), ((IEnumerable<ParameterInfo>)gJ144afPeYxHb5qPQSaw(_003C_003Ec__DisplayClass11_.methodInfo)).Select(_003C_003Ec__DisplayClass11_._003CGetRemarks_003Eb__0)));
						goto IL_03a6;
					}
					IL_03a6:
					text = (string)obj;
					num = 16;
					break;
				}
				break;
			}
		}
	}

	public static string GetCodeExample(MethodInfo methodInfo)
	{
		//Discarded unreachable code: IL_00a3, IL_018f, IL_019e, IL_0325
		int num = 11;
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		string text4 = default(string);
		XmlNode xmlNode = default(XmlNode);
		Type type = default(Type);
		string text2 = default(string);
		string text = default(string);
		string text3 = default(string);
		XmlDocument xmlDocument = default(XmlDocument);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 12:
					if (((Array)gJ144afPeYxHb5qPQSaw(_003C_003Ec__DisplayClass12_.methodInfo)).Length != 0)
					{
						num2 = 6;
						continue;
					}
					obj = string.Empty;
					break;
				case 3:
					text4 = (string)UZ5QaOfPKBai9gLKJZh6(xmlNode);
					num2 = 2;
					continue;
				case 4:
				case 15:
					return text4;
				case 5:
					if (MZCJZZfPON0o9tX39Kpv(yotysmfPn0liKKjBVZTD(type), e1cmPPfPuRCc6J13BtBX(-1858887263 ^ -1858671147)))
					{
						num2 = 4;
						continue;
					}
					goto case 13;
				default:
					text2 = (string)BnNor0fPRitOybv6Tyof(e1cmPPfPuRCc6J13BtBX(0x7EC153F ^ 0x7E959D9), text);
					num2 = 7;
					continue;
				case 14:
					if (xmlNode != null)
					{
						num2 = 3;
						continue;
					}
					goto case 2;
				case 11:
					_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
					num2 = 10;
					continue;
				case 9:
					type = FKylgtfPSQL65EskRmiu(_003C_003Ec__DisplayClass12_.methodInfo);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 1;
					}
					continue;
				case 13:
					if (eXQR4FfP2epSgYso1I4J(type, TypeOf<object>.Raw))
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
						{
							num2 = 19;
						}
						continue;
					}
					goto case 4;
				case 1:
				case 16:
					if (text4.IsNullOrEmpty())
					{
						num2 = 5;
						continue;
					}
					goto case 4;
				case 8:
					text = string.Format((string)e1cmPPfPuRCc6J13BtBX(0x4D1C1EE4 ^ 0x4D1952F4), type.Namespace, type.Name, yotysmfPn0liKKjBVZTD(_003C_003Ec__DisplayClass12_.methodInfo), text3);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					xmlNode = (XmlNode)ErWIonfPqQZlg9mlDawj(xmlDocument, text2);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
					{
						num2 = 2;
					}
					continue;
				case 2:
					type = type.BaseType;
					num2 = 16;
					continue;
				case 10:
					_003C_003Ec__DisplayClass12_.methodInfo = methodInfo;
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 2;
					}
					continue;
				case 17:
				case 19:
					xmlDocument = (XmlDocument)iQGvKrfPV6nRtSBiuoeU(sDOFiIfPIXaEYaK9AFMC(dhi413fPZ5ra0BrHcU5K(type.Assembly), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2A9AF79), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477109356)));
					num2 = 12;
					continue;
				case 18:
					goto end_IL_0012;
				case 6:
					obj = BnNor0fPRitOybv6Tyof(e1cmPPfPuRCc6J13BtBX(-643786247 ^ -643654071), string.Join((string)e1cmPPfPuRCc6J13BtBX(-1876063057 ^ -1876042145), ((IEnumerable<ParameterInfo>)gJ144afPeYxHb5qPQSaw(_003C_003Ec__DisplayClass12_.methodInfo)).Select(_003C_003Ec__DisplayClass12_._003CGetCodeExample_003Eb__0)));
					break;
				}
				text3 = (string)obj;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
				{
					num2 = 8;
				}
				continue;
				end_IL_0012:
				break;
			}
			text4 = "";
			num = 9;
		}
	}

	public static List<string> GetParameters(MethodInfo methodInfo)
	{
		_003C_003Ec__DisplayClass13_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass13_0();
		CS_0024_003C_003E8__locals0.methodInfo = methodInfo;
		List<string> list = new List<string>();
		Type type = CS_0024_003C_003E8__locals0.methodInfo.DeclaringType;
		while (list.Count == 0 && !type.Name.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FA872D)) && type != TypeOf<object>.Raw)
		{
			XmlDocument xmlDocument = LoadIfNotContains(type.Assembly.CodeBase.Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475549443), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x76D5AC0)));
			string text = ((CS_0024_003C_003E8__locals0.methodInfo.GetParameters().Length == 0) ? string.Empty : string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7245053A), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97959258), from a in CS_0024_003C_003E8__locals0.methodInfo.GetParameters()
				select (string)_003C_003Ec__DisplayClass13_0.OoZurvZFyCacIWMGLqFM(a.ParameterType, CS_0024_003C_003E8__locals0.methodInfo))));
			string arg = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1858887263 ^ -1858671183), type.Namespace, type.Name, CS_0024_003C_003E8__locals0.methodInfo.Name, text);
			string xpath = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -104887612), arg);
			XmlNodeList xmlNodeList = xmlDocument.SelectNodes(xpath);
			if (xmlNodeList != null && xmlNodeList.Count > 0)
			{
				list.AddRange(from XmlNode result in xmlNodeList
					select result.OuterXml);
			}
			type = type.BaseType;
		}
		return list;
	}

	public static string GetReturns(MethodInfo methodInfo)
	{
		//Discarded unreachable code: IL_009e, IL_018b, IL_019a, IL_0286, IL_0295, IL_02a5, IL_0370
		int num = 9;
		XmlNode xmlNode = default(XmlNode);
		XmlDocument xmlDocument = default(XmlDocument);
		string text4 = default(string);
		string text3 = default(string);
		_003C_003Ec__DisplayClass14_0 _003C_003Ec__DisplayClass14_ = default(_003C_003Ec__DisplayClass14_0);
		Type type = default(Type);
		string text2 = default(string);
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
					xmlNode = (XmlNode)ErWIonfPqQZlg9mlDawj(xmlDocument, text4);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 3;
					}
					continue;
				case 5:
				case 6:
				case 15:
				case 16:
					return text3;
				case 4:
					if (_003C_003Ec__DisplayClass14_.methodInfo.GetParameters().Length != 0)
					{
						num2 = 20;
						continue;
					}
					obj = string.Empty;
					break;
				case 2:
				case 21:
					if (!eXQR4FfP2epSgYso1I4J(type, null))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 6;
						}
						continue;
					}
					goto case 12;
				default:
					type = _003C_003Ec__DisplayClass14_.methodInfo.DeclaringType;
					num2 = 21;
					continue;
				case 19:
					type = type.BaseType;
					num2 = 2;
					continue;
				case 13:
					if (xmlNode != null)
					{
						num2 = 18;
						continue;
					}
					goto case 19;
				case 17:
					if (MZCJZZfPON0o9tX39Kpv(yotysmfPn0liKKjBVZTD(type), e1cmPPfPuRCc6J13BtBX(0x4D1C1EE4 ^ 0x4D195290)))
					{
						num2 = 9;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 15;
						}
						continue;
					}
					goto case 7;
				case 7:
					if (!eXQR4FfP2epSgYso1I4J(type, TypeOf<object>.Raw))
					{
						num2 = 16;
						continue;
					}
					goto case 3;
				case 12:
					if (!lGUZv2fP1ivmhLi3TSbB(text3))
					{
						goto end_IL_0012;
					}
					goto case 17;
				case 8:
					_003C_003Ec__DisplayClass14_.methodInfo = methodInfo;
					num2 = 10;
					continue;
				case 11:
					text4 = (string)BnNor0fPRitOybv6Tyof(e1cmPPfPuRCc6J13BtBX(0x4EDCBA32 ^ 0x4ED9F750), text2);
					num2 = 14;
					continue;
				case 10:
					text3 = "";
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 0;
					}
					continue;
				case 9:
					_003C_003Ec__DisplayClass14_ = new _003C_003Ec__DisplayClass14_0();
					num2 = 8;
					continue;
				case 3:
					xmlDocument = (XmlDocument)iQGvKrfPV6nRtSBiuoeU(sDOFiIfPIXaEYaK9AFMC(dhi413fPZ5ra0BrHcU5K(type.Assembly), e1cmPPfPuRCc6J13BtBX(-398663332 ^ -398873256), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EC82F6)));
					num2 = 4;
					continue;
				case 18:
					text3 = xmlNode.OuterXml;
					num2 = 19;
					continue;
				case 1:
					text2 = (string)nbDWNsfPPrS9Phjcdixe(e1cmPPfPuRCc6J13BtBX(-70007027 ^ -69825763), new object[4]
					{
						type.Namespace,
						yotysmfPn0liKKjBVZTD(type),
						yotysmfPn0liKKjBVZTD(_003C_003Ec__DisplayClass14_.methodInfo),
						text
					});
					num2 = 11;
					continue;
				case 20:
					obj = BnNor0fPRitOybv6Tyof(e1cmPPfPuRCc6J13BtBX(-35995181 ^ -36125085), string.Join((string)e1cmPPfPuRCc6J13BtBX(-234299632 ^ -234320416), ((IEnumerable<ParameterInfo>)gJ144afPeYxHb5qPQSaw(_003C_003Ec__DisplayClass14_.methodInfo)).Select(_003C_003Ec__DisplayClass14_._003CGetReturns_003Eb__0)));
					break;
				}
				text = (string)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
				{
					num2 = 1;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public static IEnumerable<ISyntaxTrivia> GetFullCommentsTrivia(this MethodBase methodInfo, IDictionary<string, TypeArgument> propertyTypeArguments = null)
	{
		_003C_003Ec__DisplayClass15_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass15_0();
		CS_0024_003C_003E8__locals0.methodInfo = methodInfo;
		CS_0024_003C_003E8__locals0.propertyTypeArguments = propertyTypeArguments;
		List<ISyntaxTrivia> list = new List<ISyntaxTrivia>();
		Type type = CS_0024_003C_003E8__locals0.methodInfo.DeclaringType;
		while (type != null && list.Count == 0 && !type.Name.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112358174)) && type != TypeOf<object>.Raw)
		{
			XmlDocument xmlDocument = LoadIfNotContains(Path.ChangeExtension(type.Assembly.CodeBase, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1751176224 ^ -1751145042)));
			if (xmlDocument == null)
			{
				break;
			}
			string text = ((CS_0024_003C_003E8__locals0.methodInfo is ConstructorInfo) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2107670084) : CS_0024_003C_003E8__locals0.methodInfo.Name);
			if (CS_0024_003C_003E8__locals0.methodInfo.IsGenericMethod)
			{
				text = text + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x26FFCB59 ^ 0x26FA86E9) + CS_0024_003C_003E8__locals0.methodInfo.GetGenericArguments().Count();
			}
			string text2 = string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FA523E), from a in CS_0024_003C_003E8__locals0.methodInfo.GetParameters()
				select (string)_003C_003Ec__DisplayClass15_0.uex39tZBheVwpGk5eoVC(_003C_003Ec__DisplayClass15_0.WT8cLFZBbE5iFR3SW9ik(a), CS_0024_003C_003E8__locals0.methodInfo));
			if (!text2.IsNullOrEmpty())
			{
				text2 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x307E9FD1 ^ 0x307E8067) + text2 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1637C429 ^ 0x1637DB95);
			}
			string text3 = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1A33FE36 ^ 0x1A36B38E) + type.Namespace + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3A6135BE ^ 0x3A612F7A) + type.Name + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12440660) + text + text2;
			string xpath = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97755754) + text3 + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138872824);
			XmlNode xmlNode = xmlDocument.SelectSingleNode(xpath);
			if (xmlNode != null)
			{
				XmlNode xmlNode2 = xmlNode.SelectSingleNode(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195926803));
				if (xmlNode2 != null && !xmlNode2.InnerXml.IsNullOrEmpty())
				{
					list.Add(xmlNode2.InnerXml.SummaryComment(trim: true));
				}
				XmlNode xmlNode3 = xmlNode.SelectSingleNode(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-787452571 ^ -787143819));
				if (xmlNode3 != null && !xmlNode3.InnerXml.IsNullOrEmpty())
				{
					list.Add(xmlNode3.InnerXml.RemarksComment(trim: true));
				}
				XmlNode xmlNode4 = xmlNode.SelectSingleNode(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5F3078B6 ^ 0x5F35369E));
				if (xmlNode4 != null && !xmlNode4.InnerXml.IsNullOrEmpty())
				{
					list.Add(xmlNode4.InnerXml.ExampleComment(trim: true));
				}
				XmlNodeList xmlNodeList = xmlNode.SelectNodes(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575804956));
				if (xmlNodeList != null)
				{
					list.AddRange((from p in xmlNodeList.OfType<XmlNode>()
						where !_003C_003Ec.faM0HyZFrQcd1L3U6d6I(_003C_003Ec.LPRuxfZFlyJNhiMTWKSL(p))
						select p).Select(delegate(XmlNode p)
					{
						//Discarded unreachable code: IL_0075, IL_00a5, IL_00d0, IL_00df, IL_00ef, IL_00fe, IL_012b, IL_0136, IL_0140, IL_014f, IL_01d5, IL_0236
						int num = 7;
						ParameterInfo parameterInfo = default(ParameterInfo);
						_003C_003Ec__DisplayClass15_1 _003C_003Ec__DisplayClass15_ = default(_003C_003Ec__DisplayClass15_1);
						TypeArgument value = default(TypeArgument);
						string text4 = default(string);
						while (true)
						{
							int num2 = num;
							while (true)
							{
								object type2;
								object obj;
								switch (num2)
								{
								case 5:
									type2 = _003C_003Ec__DisplayClass15_0.WT8cLFZBbE5iFR3SW9ik(parameterInfo);
									goto IL_02d4;
								case 7:
									_003C_003Ec__DisplayClass15_ = new _003C_003Ec__DisplayClass15_1();
									num2 = 6;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
									{
										num2 = 4;
									}
									break;
								case 15:
									obj = ((IEnumerable<ParameterInfo>)_003C_003Ec__DisplayClass15_0.j3998qZBf8sLG53Yod4a(CS_0024_003C_003E8__locals0.methodInfo)).FirstOrDefault(_003C_003Ec__DisplayClass15_._003CGetFullCommentsTrivia_003Eb__5);
									goto IL_02ba;
								case 1:
									type2 = null;
									goto IL_02d4;
								case 8:
									if (!parameterInfo.ParameterType.IsArray)
									{
										num2 = 5;
										break;
									}
									type2 = _003C_003Ec__DisplayClass15_0.WT8cLFZBbE5iFR3SW9ik(parameterInfo).GetElementType();
									goto IL_02d4;
								case 11:
									if (!CS_0024_003C_003E8__locals0.propertyTypeArguments.TryGetValue(_003C_003Ec__DisplayClass15_.propName, out value))
									{
										num2 = 4;
										break;
									}
									goto case 3;
								case 3:
									text4 = (string)_003C_003Ec__DisplayClass15_0.s4F9HNZBGXcQXXkKxPRl(value);
									num2 = 12;
									break;
								case 17:
									if (CS_0024_003C_003E8__locals0.propertyTypeArguments == null)
									{
										num2 = 6;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
										{
											num2 = 16;
										}
										break;
									}
									goto case 11;
								case 4:
								case 14:
								case 16:
									if (!_003C_003Ec__DisplayClass15_0.qPggw3ZBEiR8538NWI90(_003C_003Ec__DisplayClass15_.propName))
									{
										num2 = 15;
										break;
									}
									obj = null;
									goto IL_02ba;
								case 9:
								case 12:
									if (string.IsNullOrWhiteSpace(text4))
									{
										num2 = 10;
										break;
									}
									goto default;
								case 13:
									if (parameterInfo == null)
									{
										num2 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
										{
											num2 = 1;
										}
										break;
									}
									if (_003C_003Ec__DisplayClass15_0.WT8cLFZBbE5iFR3SW9ik(parameterInfo).IsGenericType)
									{
										goto end_IL_0012;
									}
									goto case 8;
								case 6:
									_003C_003Ec__DisplayClass15_.propName = (from a in p.Attributes.OfType<XmlAttribute>()
										where _003C_003Ec.eeNpAwZFjJGYXImb6yXc(_003C_003Ec.F3Cr2GZFgLu9KgZS3Pl3(a), _003C_003Ec.ekcbUkZF5NheTFNRx4up(0xE1229CF ^ 0xE1225D9))
										select a.Value).FirstOrDefault();
									num2 = 17;
									break;
								case 2:
									type2 = _003C_003Ec__DisplayClass15_0.WT8cLFZBbE5iFR3SW9ik(parameterInfo).GetGenericArguments()[0];
									goto IL_02d4;
								default:
									return ((string)_003C_003Ec__DisplayClass15_0.kowDEQZB8FvSmU3pV7rd(new string[7]
									{
										(string)_003C_003Ec__DisplayClass15_0.L2bTHDZBQ1gYfJ5bMvai(-1858887263 ^ -1859075871),
										_003C_003Ec__DisplayClass15_.propName,
										(string)_003C_003Ec__DisplayClass15_0.L2bTHDZBQ1gYfJ5bMvai(0x1DE3DD89 ^ 0x1DE0BCD7),
										p.InnerXml,
										(string)(_003C_003Ec__DisplayClass15_0.mQK7E6ZBvawXbbZPxlNh(_003C_003Ec__DisplayClass15_0.BuWtoQZBCg6HOLYqXnY3(p)) ? "" : _003C_003Ec__DisplayClass15_0.L2bTHDZBQ1gYfJ5bMvai(0x1FFEF86A ^ 0x1FFBB762)),
										text4,
										(string)_003C_003Ec__DisplayClass15_0.L2bTHDZBQ1gYfJ5bMvai(0xA592A41 ^ 0xA5A4B27)
									})).SplittedComment(trim: true);
								case 10:
									{
										return p.OuterXml.SplittedComment(trim: true);
									}
									IL_02ba:
									parameterInfo = (ParameterInfo)obj;
									num2 = 13;
									break;
									IL_02d4:
									text4 = ((Type)type2).ParameterPath();
									num2 = 9;
									break;
								}
								continue;
								end_IL_0012:
								break;
							}
							num = 2;
						}
					}));
				}
				XmlNode xmlNode5 = xmlNode.SelectSingleNode(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-957824448 ^ -957510636));
				if (xmlNode5 != null && !xmlNode5.OuterXml.IsNullOrEmpty())
				{
					list.Add(xmlNode5.OuterXml.SplittedComment(trim: true));
				}
			}
			type = type.BaseType;
		}
		return list;
	}

	internal static string ParameterPath(this EntityMetadata metadata)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (metadata != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
					{
						num2 = 0;
					}
					break;
				}
				return null;
			default:
				return ParameterPath(snROSRfPNtus824D2Jmr(PublicApiCodeGenerator.Current, metadata));
			}
		}
	}

	public static string ParameterPath(this Type type)
	{
		//Discarded unreachable code: IL_0071
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				if (tOdVtLfPpDGLarmLkxPE(type.Namespace, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x34A6D230 ^ 0x34A39C5C)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 1;
			default:
				return (string)TOScXSfPtPr2GrMVYiX4(p8j3jgfPD0L8KMtciLR6(aJIwqJfPaSgHGYE31vo8(), type));
			case 1:
				return null;
			case 2:
				if (xEwP3ufP3POeeJGqbH03(type, null))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	private static string ParameterPath(object path)
	{
		//Discarded unreachable code: IL_0049, IL_006d, IL_008c, IL_0109, IL_0113, IL_0122, IL_0169, IL_0178
		int num = 6;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 4:
					obj = SR.T((string)e1cmPPfPuRCc6J13BtBX(-35995181 ^ -36151427));
					break;
				case 1:
					obj = PvmvBFfPwQ5QvJsmlmGk(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2A9AD91));
					break;
				case 2:
					if (MZCJZZfPON0o9tX39Kpv(path, e1cmPPfPuRCc6J13BtBX(0x26FFCB59 ^ 0x26FA8591)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 3:
					if (MZCJZZfPON0o9tX39Kpv(path, e1cmPPfPuRCc6J13BtBX(-70007027 ^ -69826139)))
					{
						goto end_IL_0012;
					}
					goto case 2;
				case 9:
					obj = PvmvBFfPwQ5QvJsmlmGk(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE1151A9));
					break;
				case 6:
					if (path != null)
					{
						num2 = 5;
						continue;
					}
					goto case 7;
				case 7:
					return null;
				case 5:
					if (MZCJZZfPON0o9tX39Kpv(path, e1cmPPfPuRCc6J13BtBX(-138018305 ^ -138195083)))
					{
						num2 = 8;
						continue;
					}
					goto case 3;
				default:
					return (string)dGpYNJfP4jF2w4Ys0Hb4(new string[5]
					{
						text,
						(string)e1cmPPfPuRCc6J13BtBX(0x1ECE530A ^ 0x1ECB1C02),
						(string)PvmvBFfPwQ5QvJsmlmGk(e1cmPPfPuRCc6J13BtBX(-1824388195 ^ -1824045939)),
						(string)e1cmPPfPuRCc6J13BtBX(-787452571 ^ -787479247),
						(string)path
					});
				case 8:
					obj = PvmvBFfPwQ5QvJsmlmGk(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-882126494 ^ -882334050));
					break;
				}
				text = (string)obj;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
				{
					num2 = 0;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 9;
		}
	}

	public static string GetFullComments(this MethodInfo methodInfo)
	{
		//Discarded unreachable code: IL_019c, IL_01ab, IL_01ba, IL_01c9, IL_02b2, IL_02c1, IL_0346, IL_0355, IL_0364, IL_046c
		int num = 1;
		int num2 = num;
		XmlNode xmlNode = default(XmlNode);
		StringBuilder stringBuilder = default(StringBuilder);
		XmlNode xmlNode2 = default(XmlNode);
		Type type = default(Type);
		XmlDocument xmlDocument = default(XmlDocument);
		_003C_003Ec__DisplayClass19_0 _003C_003Ec__DisplayClass19_ = default(_003C_003Ec__DisplayClass19_0);
		string text = default(string);
		string text3 = default(string);
		string text2 = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 15:
				if (xmlNode == null)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 18;
					}
					continue;
				}
				goto case 22;
			case 6:
			case 8:
				return stringBuilder.ToString();
			case 2:
				xGDAIJfPHLkMKbc349ay(stringBuilder, UZ5QaOfPKBai9gLKJZh6(xmlNode2));
				num2 = 14;
				continue;
			case 12:
			case 25:
				if (!eXQR4FfP2epSgYso1I4J(type, null))
				{
					num2 = 6;
					continue;
				}
				goto case 23;
			case 17:
			case 21:
				xmlDocument = (XmlDocument)iQGvKrfPV6nRtSBiuoeU(((string)dhi413fPZ5ra0BrHcU5K(type.Assembly)).Replace((string)e1cmPPfPuRCc6J13BtBX(0xA592A41 ^ 0xA586EFB), (string)e1cmPPfPuRCc6J13BtBX(-1876063057 ^ -1876098335)));
				num2 = 24;
				continue;
			case 10:
				stringBuilder = new StringBuilder();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
				{
					num2 = 27;
				}
				continue;
			case 26:
				return null;
			case 5:
				if (((Array)gJ144afPeYxHb5qPQSaw(_003C_003Ec__DisplayClass19_.methodInfo)).Length == 0)
				{
					num2 = 20;
					continue;
				}
				goto case 7;
			case 9:
				if (!lGUZv2fP1ivmhLi3TSbB(UZ5QaOfPKBai9gLKJZh6(xmlNode2)))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 13;
			case 11:
				if (xmlNode2 == null)
				{
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
					{
						num2 = 13;
					}
					continue;
				}
				goto case 9;
			case 3:
				text = (string)BnNor0fPRitOybv6Tyof(e1cmPPfPuRCc6J13BtBX(0x7459E02 ^ 0x740D12E), text3);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 16;
				}
				continue;
			default:
				_003C_003Ec__DisplayClass19_.methodInfo = methodInfo;
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num2 = 10;
				}
				continue;
			case 19:
				text3 = (string)FU51UOfP6vCl88Fsed45(e1cmPPfPuRCc6J13BtBX(0x1A33FE36 ^ 0x1A36B5AC), sDOFiIfPIXaEYaK9AFMC(type.FullName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-541731959 ^ -541746089), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE161B1)), yotysmfPn0liKKjBVZTD(_003C_003Ec__DisplayClass19_.methodInfo), text2);
				num2 = 3;
				continue;
			case 1:
				_003C_003Ec__DisplayClass19_ = new _003C_003Ec__DisplayClass19_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
				{
					num2 = 0;
				}
				continue;
			case 13:
			case 14:
			case 18:
				type = type.BaseType;
				num2 = 12;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 9;
				}
				continue;
			case 23:
				if (!MZCJZZfPON0o9tX39Kpv(yotysmfPn0liKKjBVZTD(type), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x53FA00CE ^ 0x53FF4CBA)))
				{
					num2 = 4;
					continue;
				}
				goto case 6;
			case 22:
				xmlNode2 = (XmlNode)ErWIonfPqQZlg9mlDawj(xmlNode, e1cmPPfPuRCc6J13BtBX(0x53CB464B ^ 0x53CE0BB3));
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 11;
				}
				continue;
			case 4:
				if (eXQR4FfP2epSgYso1I4J(type, TypeOf<object>.Raw))
				{
					num2 = 17;
					continue;
				}
				goto case 6;
			case 16:
				xmlNode = (XmlNode)ErWIonfPqQZlg9mlDawj(xmlDocument, text);
				num2 = 15;
				continue;
			case 24:
				if (xmlDocument != null)
				{
					num2 = 5;
					continue;
				}
				goto case 26;
			case 27:
				type = FKylgtfPSQL65EskRmiu(_003C_003Ec__DisplayClass19_.methodInfo);
				num2 = 25;
				continue;
			case 7:
				obj = BnNor0fPRitOybv6Tyof(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EE0B08), string.Join(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-643786247 ^ -643773687), _003C_003Ec__DisplayClass19_.methodInfo.GetParameters().Select(_003C_003Ec__DisplayClass19_._003CGetFullComments_003Eb__0)));
				break;
			case 20:
				obj = string.Empty;
				break;
			}
			text2 = (string)obj;
			num2 = 11;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
			{
				num2 = 19;
			}
		}
	}

	public static ISyntaxNode MakeClassHide(this ISyntaxNode target)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return target;
			case 1:
				target.AddAttributes(TypeOf<ShowDefaultMethodsAttribute>.Raw.CreateAttribute(false), TypeOf<BrowsableAttribute>.Raw.CreateAttribute(false), TypeOf<EditorBrowsableAttribute>.Raw.CreateAttribute(EditorBrowsableState.Never));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static RefKind GetParameterDirection(this ParameterInfo parameterInfo)
	{
		//Discarded unreachable code: IL_0092, IL_00a1, IL_00b1
		int num = 1;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					if (rhO8LyfP7uxJwIJJW1id(parameterInfo))
					{
						goto end_IL_0012;
					}
					goto case 3;
				case 1:
					if (yYBBnbfPAE2NDhsvDLKo(parameterInfo))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 2:
					return RefKind.None;
				case 4:
					return RefKind.Out;
				case 5:
					return RefKind.Ref;
				case 3:
					if (rhO8LyfP7uxJwIJJW1id(parameterInfo))
					{
						num2 = 4;
						break;
					}
					goto case 2;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public static ISyntaxNode GetParameterBindingExpression(this ParameterInfo parameterInfo)
	{
		//Discarded unreachable code: IL_0060, IL_006f, IL_00d3
		int num = 8;
		ISyntaxNode syntaxNode2 = default(ISyntaxNode);
		Type genericTypeDefinition = default(Type);
		Type[] genericArguments = default(Type[]);
		ISyntaxNode syntaxNode = default(ISyntaxNode);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					syntaxNode2 = (ISyntaxNode)aO5CEufP0qQNanH6LEIB(IpkfwGfPxxv5T2aTXcq2(parameterInfo));
					num2 = 7;
					continue;
				case 9:
					if (!genericTypeDefinition.IsAssignableFrom(L5KjGFfPyIfYPr86HZbu(System.Reflection.TypeOf.List)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 3:
					if (genericTypeDefinition.IsAssignableFrom(System.Reflection.TypeOf.IDictionary.Raw))
					{
						num = 6;
						break;
					}
					goto case 9;
				case 4:
					if (genericArguments.Length == 0)
					{
						num2 = 2;
						continue;
					}
					goto case 5;
				case 7:
					genericArguments = wvnQiFfPmDk22kmFanF3(parameterInfo).GetGenericArguments();
					num = 4;
					break;
				default:
					return ((ISyntaxNode)gp8ltDfPJ58kURCUM1Th(ysajwqfPMbVMHbK7h9BJ(EleWise.ELMA.SDK.TypeOf.EnumerableExtensions.Raw), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1870892489 ^ -1871102631).GenericName(syntaxNode))).InvocationExpression(syntaxNode2);
				case 2:
				case 6:
					return syntaxNode2;
				case 1:
					syntaxNode = (ISyntaxNode)ysajwqfPMbVMHbK7h9BJ(genericArguments[0]);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if ((genericTypeDefinition = wvnQiFfPmDk22kmFanF3(parameterInfo).GetGenericTypeDefinition()).GetInterfaces().Any((Type i) => i.IsAssignableFrom(_003C_003Ec.Kw4PcWZFYopJwlaWptoZ(System.Reflection.TypeOf.IEnumerable))))
					{
						num2 = 3;
						continue;
					}
					goto case 2;
				}
				break;
			}
		}
	}

	private static XmlDocument LoadIfNotContains(object path)
	{
		//Discarded unreachable code: IL_011b, IL_012a, IL_018e, IL_01d0, IL_0208
		int num = 2;
		int num2 = num;
		_003C_003Ec__DisplayClass23_0 _003C_003Ec__DisplayClass23_ = default(_003C_003Ec__DisplayClass23_0);
		XmlDocument xmlDocument = default(XmlDocument);
		XmlDocument result = default(XmlDocument);
		XmlDocument xmlDocument2 = default(XmlDocument);
		while (true)
		{
			switch (num2)
			{
			case 1:
				_003C_003Ec__DisplayClass23_.path = (string)path;
				num2 = 5;
				break;
			case 5:
				xmlDocument = XmlDocuments.FirstOrDefault(_003C_003Ec__DisplayClass23_._003CLoadIfNotContains_003Eb__0);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				_003C_003Ec__DisplayClass23_ = new _003C_003Ec__DisplayClass23_0();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 1;
				}
				break;
			case 3:
				return xmlDocument;
			case 4:
				try
				{
					int num3;
					if (File.Exists((string)Ts1mmSfP9asNyRai6uNd(new Uri(_003C_003Ec__DisplayClass23_.path))))
					{
						num3 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
						{
							num3 = 0;
						}
						goto IL_00da;
					}
					goto IL_0135;
					IL_0135:
					result = null;
					num3 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num3 = 4;
					}
					goto IL_00da;
					IL_00da:
					while (true)
					{
						switch (num3)
						{
						case 5:
							return xmlDocument;
						case 4:
							return result;
						case 1:
						{
							xmlDocument = xmlDocument2;
							int num4 = 5;
							num3 = num4;
							continue;
						}
						case 6:
							break;
						case 7:
							XmlDocuments.Add(xmlDocument2);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
							{
								num3 = 0;
							}
							continue;
						default:
							xmlDocument2 = new XmlDocument();
							num3 = 3;
							continue;
						case 3:
							U3tWGxfPdk2tcFNZFSGG(xmlDocument2, _003C_003Ec__DisplayClass23_.path);
							num3 = 7;
							continue;
						}
						break;
					}
					goto IL_0135;
				}
				catch
				{
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 == 0)
					{
						num5 = 0;
					}
					while (true)
					{
						switch (num5)
						{
						case 1:
							return result;
						}
						result = null;
						num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
						{
							num5 = 0;
						}
					}
				}
			default:
				if (xmlDocument == null)
				{
					num2 = 4;
					break;
				}
				goto case 3;
			}
		}
	}

	private static string GetParameterName(Type parameterType, object methodInfo)
	{
		//Discarded unreachable code: IL_013b, IL_014a, IL_02ae, IL_02bd, IL_030e, IL_031d, IL_0347, IL_0356, IL_0453, IL_04a9, IL_04b8, IL_0560, IL_05af, IL_05be, IL_0684, IL_0693, IL_06a3, IL_081b
		int num = 34;
		int num4 = default(int);
		string text4 = default(string);
		string result = default(string);
		string text2 = default(string);
		string text5 = default(string);
		int num3 = default(int);
		string parameterName = default(string);
		string text3 = default(string);
		string text = default(string);
		Type[] genericArguments = default(Type[]);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 29:
					num4 = IH8vXifPY5u4VQH9ivst(YPbWGkfPUkhx1ENZpKlM(methodInfo), parameterType);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 2;
					}
					continue;
				case 32:
					text4 = (string)mPRE5lfPrwD5hpFUF794(parameterType.FullName, 0, n48kIZfPl9eSdX7yUCNB(parameterType.FullName, e1cmPPfPuRCc6J13BtBX(0x31326106 ^ 0x31312452), StringComparison.Ordinal) + 2);
					num2 = 44;
					continue;
				case 17:
					result = (string)w72m2AfPgMkSnj35h1oJ(e1cmPPfPuRCc6J13BtBX(--1333735954 ^ 0x4F7A7DC4), text4, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E2779A));
					num2 = 3;
					continue;
				case 42:
					if (parameterType.IsGenericParameter)
					{
						num2 = 10;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 28;
				case 8:
				case 9:
					if (!FKylgtfPSQL65EskRmiu(methodInfo).GetGenericArguments().Contains(parameterType))
					{
						num2 = 37;
						continue;
					}
					goto case 26;
				case 33:
					text2 = (string)yotysmfPn0liKKjBVZTD(parameterType);
					num = 6;
					break;
				case 18:
					result = (string)w72m2AfPgMkSnj35h1oJ(e1cmPPfPuRCc6J13BtBX(-1824388195 ^ -1824040025), text5, e1cmPPfPuRCc6J13BtBX(0x3CE17B75 ^ 0x3CE17765));
					num2 = 38;
					continue;
				case 24:
					result = string.Format((string)e1cmPPfPuRCc6J13BtBX(-105199646 ^ -104884410), num3);
					num2 = 14;
					continue;
				case 2:
					result = (string)BnNor0fPRitOybv6Tyof(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671783429), num4);
					num2 = 25;
					continue;
				case 15:
				case 36:
					if (!MZCJZZfPON0o9tX39Kpv(text2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xD3DEF7E ^ 0xD38A0F8)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 45;
				case 37:
				case 43:
					if (parameterType.IsArray)
					{
						num2 = 41;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
						{
							num2 = 16;
						}
						continue;
					}
					goto case 42;
				case 34:
					result = null;
					num2 = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 2;
					}
					continue;
				case 1:
					parameterName = GetParameterName(parameterType.GetGenericArguments()[0], methodInfo);
					num2 = 7;
					continue;
				case 3:
				case 39:
					if (MZCJZZfPON0o9tX39Kpv(text2, e1cmPPfPuRCc6J13BtBX(0x269E5FCA ^ 0x269AD828)))
					{
						num2 = 23;
						continue;
					}
					goto case 14;
				case 45:
					text3 = (string)mPRE5lfPrwD5hpFUF794(parameterType.FullName, 0, n48kIZfPl9eSdX7yUCNB(parameterType.FullName, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575937808), StringComparison.Ordinal) + 2);
					num2 = 11;
					continue;
				case 27:
					result = string.Format((string)e1cmPPfPuRCc6J13BtBX(-672123589 ^ -671783541), IH8vXifPY5u4VQH9ivst(FKylgtfPSQL65EskRmiu(methodInfo).GetGenericArguments(), parameterType.GetElementType()));
					num2 = 21;
					continue;
				case 7:
					text = (string)qc9MLnfPiHGe3mBwlrRI(e1cmPPfPuRCc6J13BtBX(-289714582 ^ -289731480), parameterType.Namespace, DWTcDYfPjqf3Rby3ZvkI(text2, 0, GNHGu6fP55qfpixELMeH(text2, '`')));
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num2 = 0;
					}
					continue;
				case 28:
					result = parameterType.FullName;
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
					{
						num2 = 40;
					}
					continue;
				case 41:
					if (FKylgtfPSQL65EskRmiu(methodInfo).GetGenericArguments().Contains(parameterType.GetElementType()))
					{
						num2 = 27;
						continue;
					}
					goto case 42;
				case 44:
					text4 = (string)mPRE5lfPrwD5hpFUF794(text4, n48kIZfPl9eSdX7yUCNB(text4, e1cmPPfPuRCc6J13BtBX(0x53CB464B ^ 0x53CB14BB), StringComparison.Ordinal), I5FZkQfPTc8nUHfpifcI(text4) - n48kIZfPl9eSdX7yUCNB(text4, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA512CC), StringComparison.Ordinal));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 17;
					}
					continue;
				case 26:
					result = (string)BnNor0fPRitOybv6Tyof(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2138958856 ^ -2138619044), IH8vXifPY5u4VQH9ivst(((MemberInfo)methodInfo).DeclaringType.GetGenericArguments(), parameterType));
					num2 = 16;
					continue;
				default:
					if (!MZCJZZfPON0o9tX39Kpv(text2, e1cmPPfPuRCc6J13BtBX(-70037984 ^ -69860934)))
					{
						num2 = 36;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
						{
							num2 = 39;
						}
						continue;
					}
					goto case 32;
				case 4:
				case 22:
					if (!parameterType.IsGenericType)
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
						{
							num2 = 9;
						}
						continue;
					}
					goto case 1;
				case 12:
					text5 = (string)qc9MLnfPiHGe3mBwlrRI(e1cmPPfPuRCc6J13BtBX(0x48A7E34A ^ 0x48A2B362), genericArguments[0].FullName, genericArguments[1].FullName);
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 18;
					}
					continue;
				case 6:
					if (parameterType.IsGenericType)
					{
						num2 = 35;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 4;
				case 13:
					if (!MZCJZZfPON0o9tX39Kpv(text2, e1cmPPfPuRCc6J13BtBX(-1978478350 ^ -1978247408)))
					{
						num2 = 4;
						continue;
					}
					goto case 15;
				case 14:
				case 16:
				case 21:
				case 25:
				case 38:
				case 40:
				case 46:
					return result;
				case 11:
					text3 = (string)mPRE5lfPrwD5hpFUF794(text3, text3.IndexOf(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x571EA399 ^ 0x571EF169), StringComparison.Ordinal), I5FZkQfPTc8nUHfpifcI(text3) - n48kIZfPl9eSdX7yUCNB(text3, e1cmPPfPuRCc6J13BtBX(0x269E5FCA ^ 0x269E0D3A), StringComparison.Ordinal));
					num2 = 20;
					continue;
				case 10:
					if (fIVbeSfPLmY1jldLxqll(methodInfo))
					{
						num2 = 29;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 != 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 19;
				case 20:
					result = (string)e1cmPPfPuRCc6J13BtBX(0x31326106 ^ 0x31372EB4) + text3 + (string)e1cmPPfPuRCc6J13BtBX(-1858887263 ^ -1858884175);
					num2 = 30;
					continue;
				case 35:
					if (!MZCJZZfPON0o9tX39Kpv(text2, e1cmPPfPuRCc6J13BtBX(-1852837372 ^ -1853178494)))
					{
						num = 31;
						break;
					}
					goto case 15;
				case 31:
					if (text2.Contains(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1710575414 ^ -1710227632)))
					{
						num = 36;
						break;
					}
					goto case 13;
				case 23:
					genericArguments = parameterType.GetGenericArguments();
					num2 = 12;
					continue;
				case 19:
					num3 = IH8vXifPY5u4VQH9ivst(FKylgtfPSQL65EskRmiu(methodInfo).GetGenericArguments(), parameterType);
					num = 24;
					break;
				case 5:
					result = (string)qc9MLnfPiHGe3mBwlrRI(e1cmPPfPuRCc6J13BtBX(-1633514411 ^ -1633166119), text, parameterName);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 46;
					}
					continue;
				}
				break;
			}
		}
	}

	internal static void vW3gDgfPvaYwuM3oFSid()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool wuH6pgfPQbJBvBEUrQ0W()
	{
		return MdWBVxfPfScHqg4ATnvQ == null;
	}

	internal static XmlCommentsHelper AM9IpDfPCNhfEemXJ922()
	{
		return MdWBVxfPfScHqg4ATnvQ;
	}

	internal static Type RJnUHPfP86NBki4oNyrn(object P_0)
	{
		return ((PropertyInfo)P_0).PropertyType;
	}

	internal static object dhi413fPZ5ra0BrHcU5K(object P_0)
	{
		return ((Assembly)P_0).CodeBase;
	}

	internal static object e1cmPPfPuRCc6J13BtBX(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object sDOFiIfPIXaEYaK9AFMC(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object iQGvKrfPV6nRtSBiuoeU(object P_0)
	{
		return LoadIfNotContains(P_0);
	}

	internal static Type FKylgtfPSQL65EskRmiu(object P_0)
	{
		return ((MemberInfo)P_0).DeclaringType;
	}

	internal static object qc9MLnfPiHGe3mBwlrRI(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object BnNor0fPRitOybv6Tyof(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object ErWIonfPqQZlg9mlDawj(object P_0, object P_1)
	{
		return ((XmlNode)P_0).SelectSingleNode((string)P_1);
	}

	internal static object UZ5QaOfPKBai9gLKJZh6(object P_0)
	{
		return ((XmlNode)P_0).InnerXml;
	}

	internal static object zCuoZXfPXvCmRarckDKg(object P_0, object P_1)
	{
		return ((string)P_0).TrimEnd((char[])P_1);
	}

	internal static int I5FZkQfPTc8nUHfpifcI(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object vy8RWHfPkUXY7w0oXu0g(object P_0, int P_1, object P_2)
	{
		return ((string)P_0).Insert(P_1, (string)P_2);
	}

	internal static object yotysmfPn0liKKjBVZTD(object P_0)
	{
		return ((MemberInfo)P_0).Name;
	}

	internal static bool MZCJZZfPON0o9tX39Kpv(object P_0, object P_1)
	{
		return ((string)P_0).Contains((string)P_1);
	}

	internal static bool eXQR4FfP2epSgYso1I4J(Type P_0, Type P_1)
	{
		return P_0 != P_1;
	}

	internal static object gJ144afPeYxHb5qPQSaw(object P_0)
	{
		return ((MethodBase)P_0).GetParameters();
	}

	internal static object nbDWNsfPPrS9Phjcdixe(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static bool lGUZv2fP1ivmhLi3TSbB(object P_0)
	{
		return ((string)P_0).IsNullOrEmpty();
	}

	internal static object snROSRfPNtus824D2Jmr(object P_0, object P_1)
	{
		return ((PublicApiCodeGenerator)P_0).GetNodeFullPath((EntityMetadata)P_1);
	}

	internal static bool xEwP3ufP3POeeJGqbH03(Type P_0, Type P_1)
	{
		return P_0 == P_1;
	}

	internal static bool tOdVtLfPpDGLarmLkxPE(object P_0, object P_1)
	{
		return ((string)P_0).StartsWith((string)P_1);
	}

	internal static object aJIwqJfPaSgHGYE31vo8()
	{
		return PublicApiCodeGenerator.Current;
	}

	internal static object p8j3jgfPD0L8KMtciLR6(object P_0, Type type)
	{
		return ((PublicApiCodeGenerator)P_0).GetNodeFullPath(type);
	}

	internal static object TOScXSfPtPr2GrMVYiX4(object P_0)
	{
		return ParameterPath(P_0);
	}

	internal static object PvmvBFfPwQ5QvJsmlmGk(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object dGpYNJfP4jF2w4Ys0Hb4(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object FU51UOfP6vCl88Fsed45(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object xGDAIJfPHLkMKbc349ay(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).AppendLine((string)P_1);
	}

	internal static bool yYBBnbfPAE2NDhsvDLKo(object P_0)
	{
		return ((ParameterInfo)P_0).IsIn;
	}

	internal static bool rhO8LyfP7uxJwIJJW1id(object P_0)
	{
		return ((ParameterInfo)P_0).IsOut;
	}

	internal static object IpkfwGfPxxv5T2aTXcq2(object P_0)
	{
		return ((ParameterInfo)P_0).Name;
	}

	internal static object aO5CEufP0qQNanH6LEIB(object P_0)
	{
		return ((string)P_0).IdentifierName();
	}

	internal static Type wvnQiFfPmDk22kmFanF3(object P_0)
	{
		return ((ParameterInfo)P_0).ParameterType;
	}

	internal static Type L5KjGFfPyIfYPr86HZbu(object P_0)
	{
		return ((RipeType)P_0).Raw;
	}

	internal static object ysajwqfPMbVMHbK7h9BJ(Type type)
	{
		return type.CreateTypeSyntax();
	}

	internal static object gp8ltDfPJ58kURCUM1Th(object P_0, object P_1)
	{
		return ((ISyntaxNode)P_0).MemberAccessExpression((ISyntaxNode)P_1);
	}

	internal static object Ts1mmSfP9asNyRai6uNd(object P_0)
	{
		return ((Uri)P_0).LocalPath;
	}

	internal static void U3tWGxfPdk2tcFNZFSGG(object P_0, object P_1)
	{
		((XmlDocument)P_0).Load((string)P_1);
	}

	internal static int n48kIZfPl9eSdX7yUCNB(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).IndexOf((string)P_1, P_2);
	}

	internal static object mPRE5lfPrwD5hpFUF794(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Remove(P_1, P_2);
	}

	internal static object w72m2AfPgMkSnj35h1oJ(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static int GNHGu6fP55qfpixELMeH(object P_0, char P_1)
	{
		return ((string)P_0).IndexOf(P_1);
	}

	internal static object DWTcDYfPjqf3Rby3ZvkI(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static int IH8vXifPY5u4VQH9ivst(object P_0, object P_1)
	{
		return ((IEnumerable)P_0).IndexOf(P_1);
	}

	internal static bool fIVbeSfPLmY1jldLxqll(object P_0)
	{
		return ((MethodBase)P_0).IsGenericMethod;
	}

	internal static object YPbWGkfPUkhx1ENZpKlM(object P_0)
	{
		return ((MethodBase)P_0).GetGenericArguments();
	}
}
