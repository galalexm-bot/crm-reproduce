using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Workflow.BPMN;

public static class HTMLUtility
{
	internal static HTMLUtility cgpV1NOk3HQ4bCsRJevu;

	public static string MakeValidFileName(string name)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		string text2 = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = (string)u6wvfxOkCtUlVDgtAYZ0(new string((char[])hZGuK4OkpcdY5mklxlx6()));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_26fa47f5bd8343debcae8b05a56a3ab5 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return (string)Fjxn1YOkUN8qWZG6ErPf(name, text2, "");
			default:
				text2 = (string)WNyDwPOkkn06dsVjsbLR(UueqoVOkMipF3oJcsLIp(0x6CC04061 ^ 0x6CC26FFD), text);
				num2 = 2;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f33560c5d18b4e10b24a458578aa60fd != 0)
				{
					num2 = 2;
				}
				break;
			}
		}
	}

	public static string InsertImg(string imgName, bool subFolders, Guid tableHeadUid)
	{
		return (string)WNyDwPOkkn06dsVjsbLR(pCWZRWOkVabvBYxYXHU9(UueqoVOkMipF3oJcsLIp(-1539486135 ^ -1539350141), imgName, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-261315199 ^ -261191045)), subFolders ? "" : tableHeadUid.ToString().Replace(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2125897096 ^ -2125770118), ""));
	}

	public static string InsertImg(string imgName, bool subFolders, Guid tableHeadUid, string id, string style)
	{
		return (string)blfk7iOkGC9Sq3BB5Fij(pCWZRWOkVabvBYxYXHU9(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x747FFBE0 ^ 0x747DD42A), imgName, UueqoVOkMipF3oJcsLIp(0x46EA3D1 ^ 0x46C93D9)), subFolders ? "" : VGc9u4OkAJei5V3DVFGg(tableHeadUid.ToString(), UueqoVOkMipF3oJcsLIp(0x34EA50D4 ^ 0x34E860D6), ""), id, style);
	}

	public static string InsertFile(string filename, bool subFolders, Guid tableHeadUid)
	{
		return InsertHyperLink((string)NRiHNEOk7st1d9Af0DvD(UueqoVOkMipF3oJcsLIp(0x595C500A ^ 0x595E6034), subFolders ? "" : tableHeadUid.ToString().Replace((string)UueqoVOkMipF3oJcsLIp(0x246EEF98 ^ 0x246CDF9A), ""), filename.Replace((string)UueqoVOkMipF3oJcsLIp(-29981480 ^ -29957298), "")), "", filename);
	}

	public static string Spoller(string idDiv, string divText, string header, bool subFolders, Guid tableHeadUid)
	{
		return (string)s34pZROkirABBnqLMoPr(kxuriKOk2JP21JwAfEj9(new string[5]
		{
			(string)UueqoVOkMipF3oJcsLIp(0x1134D2C0 ^ 0x1136E29C),
			idDiv,
			SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-11799394 ^ -11942848),
			idDiv,
			SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63D6C913 ^ 0x63D4F9E1)
		}), new object[5]
		{
			idDiv,
			T4i9ZbOkFL3tQHZAwA8o(UueqoVOkMipF3oJcsLIp(0x5F534A5C ^ 0x5F517B84), subFolders, tableHeadUid, VFdbHrOkoYEjlbHYhNkF(UueqoVOkMipF3oJcsLIp(0x70EBB9F3 ^ 0x70E9881D), idDiv), UueqoVOkMipF3oJcsLIp(0x101D10F ^ 0x103E0F3)),
			InsertImg(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1145BED7 ^ 0x11478CCD), subFolders, tableHeadUid, (string)VFdbHrOkoYEjlbHYhNkF(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-351369538 ^ -351488880), idDiv), ""),
			header,
			divText
		});
	}

	public static string InsertRowToTable(string[] valuesCells, bool isBold, string[] styles)
	{
		//Discarded unreachable code: IL_0100, IL_019f, IL_01ae, IL_01f4, IL_0203
		int num = 10;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		int num3 = default(int);
		string[] array = default(string[]);
		int num4 = default(int);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 9:
				IAdAfLOkIFjQeVg5ZaBQ(stringBuilder, UueqoVOkMipF3oJcsLIp(0x6CC04061 ^ 0x6CC1DE8D));
				num2 = 4;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_f2d402219199402696ade21eab23d086 == 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				num3 = 0;
				num2 = 11;
				break;
			case 11:
				array = valuesCells;
				num2 = 3;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_558b46b4f4364838b08ac89d77f9a257 == 0)
				{
					num2 = 7;
				}
				break;
			case 10:
				stringBuilder = new StringBuilder();
				num2 = 9;
				break;
			case 14:
				if (styles != null)
				{
					num2 = 10;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_6dd19c81ff5e41fb8db9b50574437301 == 0)
					{
						num2 = 16;
					}
					break;
				}
				goto case 6;
			case 1:
				num3++;
				num2 = 13;
				break;
			case 8:
				IAdAfLOkIFjQeVg5ZaBQ(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1436248540 ^ 0x559AC9B8));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_805f3361d2ba4dac8da4174f89314253 == 0)
				{
					num2 = 1;
				}
				break;
			case 2:
				stringBuilder.Append((string)UueqoVOkMipF3oJcsLIp(-106528299 ^ -106646739));
				num2 = 18;
				break;
			case 12:
			case 15:
				if (num4 < array.Length)
				{
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_3b4403f77a00495e957e5e4a6840e5d3 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 18:
				return stringBuilder.ToString();
			default:
				text = array[num4];
				num2 = 14;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_67df302d7a2e4c95b7c8b62f21f3a833 != 0)
				{
					num2 = 4;
				}
				break;
			case 7:
				num4 = 0;
				num2 = 15;
				break;
			case 13:
				num4++;
				num2 = 8;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_8f870ea690334e7ab7599d275d195e9a != 0)
				{
					num2 = 12;
				}
				break;
			case 16:
				IAdAfLOkIFjQeVg5ZaBQ(stringBuilder, isBold ? WNyDwPOkkn06dsVjsbLR(UueqoVOkMipF3oJcsLIp(-495296780 ^ -495424342), styles[num3]) : string.Format((string)UueqoVOkMipF3oJcsLIp(-768800937 ^ -768658067), styles[num3]));
				num2 = 3;
				break;
			case 6:
				IAdAfLOkIFjQeVg5ZaBQ(stringBuilder, isBold ? UueqoVOkMipF3oJcsLIp(0x614CF569 ^ 0x614EC7DB) : UueqoVOkMipF3oJcsLIp(-1657582555 ^ -1657700733));
				num2 = 0;
				if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_b1ab9396b25b43af8f32e24b1948be96 == 0)
				{
					num2 = 17;
				}
				break;
			case 3:
			case 17:
				IAdAfLOkIFjQeVg5ZaBQ(stringBuilder, isBold ? pCWZRWOkVabvBYxYXHU9(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-22348816 ^ -22492910), text, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-63028171 ^ -63146279)) : text);
				num2 = 8;
				break;
			}
		}
	}

	public static string InsertListItem(string itemString, bool isBold)
	{
		return (string)pCWZRWOkVabvBYxYXHU9(UueqoVOkMipF3oJcsLIp(-1647793954 ^ -1647666218), isBold ? ((string)UueqoVOkMipF3oJcsLIp(-135674354 ^ -135531284) + itemString + SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-106528299 ^ -106646727)) : itemString, UueqoVOkMipF3oJcsLIp(-1303601216 ^ -1303466796));
	}

	public static string InsertString(string value)
	{
		return (string)pCWZRWOkVabvBYxYXHU9(UueqoVOkMipF3oJcsLIp(0x70EBB9F3 ^ 0x70E98AD1), value, UueqoVOkMipF3oJcsLIp(-949717965 ^ -949598435));
	}

	public static string InsertHyperLink(string href, string target, string nameLink)
	{
		return (string)kxuriKOk2JP21JwAfEj9(new string[7]
		{
			SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x74AB4717 ^ 0x74A9742B),
			href,
			(string)UueqoVOkMipF3oJcsLIp(-1001967776 ^ -1002103754),
			target,
			(string)UueqoVOkMipF3oJcsLIp(0x3C1FFB55 ^ 0x3C1DD4AF),
			nameLink,
			(string)UueqoVOkMipF3oJcsLIp(-398691253 ^ -398602129)
		});
	}

	public static string InsertHyperLink(string href, string nameLink)
	{
		return (string)kxuriKOk2JP21JwAfEj9(new string[5]
		{
			(string)UueqoVOkMipF3oJcsLIp(-360662087 ^ -360544123),
			href,
			(string)UueqoVOkMipF3oJcsLIp(--727842433 ^ 0x2B63D17B),
			nameLink,
			(string)UueqoVOkMipF3oJcsLIp(-684210684 ^ -684301792)
		});
	}

	public static string InsertScript(string script)
	{
		return (string)pCWZRWOkVabvBYxYXHU9(UueqoVOkMipF3oJcsLIp(-1001967776 ^ -1002103790), script, UueqoVOkMipF3oJcsLIp(-25709590 ^ -25853864));
	}

	public static string InsertTopHTML(string csshref, string script)
	{
		int num = 6;
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 7:
					return stringBuilder.ToString();
				case 3:
					if (s1W2RrOka5vLuPpiuhVT(script) > 0)
					{
						num2 = 1;
						if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_0fbdcdb2cea84e8d8852886ebe735d8f == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 4;
				case 6:
					stringBuilder = new StringBuilder();
					num2 = 5;
					continue;
				case 4:
					IAdAfLOkIFjQeVg5ZaBQ(stringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x361628FF ^ 0x36141C33));
					num2 = 7;
					continue;
				case 5:
					IAdAfLOkIFjQeVg5ZaBQ(stringBuilder, UueqoVOkMipF3oJcsLIp(0x3C1FFB55 ^ 0x3C1DC89D));
					num2 = 2;
					continue;
				case 2:
					IAdAfLOkIFjQeVg5ZaBQ(stringBuilder, UueqoVOkMipF3oJcsLIp(-1498811449 ^ -1498693601));
					num2 = 0;
					if (_003CModule_003E_007Bdfa54df4_002D1131_002D467b_002D8162_002D4099ba967ac6_007D.m_9570b4a70465495fba22c942f586465a != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					IAdAfLOkIFjQeVg5ZaBQ(stringBuilder, InsertScript(script));
					num2 = 4;
					continue;
				}
				break;
			}
			IAdAfLOkIFjQeVg5ZaBQ(stringBuilder, (string)UueqoVOkMipF3oJcsLIp(-360662087 ^ -360542245) + csshref + (string)UueqoVOkMipF3oJcsLIp(0x350C0E8 ^ 0x352F448));
			num = 3;
		}
	}

	public static string InsertAlert(string nameLink, string msg)
	{
		return (string)UueqoVOkMipF3oJcsLIp(-1386448964 ^ -1386331294) + msg + (string)UueqoVOkMipF3oJcsLIp(-63028171 ^ -63147735) + nameLink + (string)UueqoVOkMipF3oJcsLIp(0x6A69C5CD ^ 0x6A6861E9);
	}

	public static string InsertOnlyAlert(string msg)
	{
		return (string)pCWZRWOkVabvBYxYXHU9(SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x75BAD659 ^ 0x75B8E371), msg, UueqoVOkMipF3oJcsLIp(-539998957 ^ -539856831));
	}

	public static string InsertSpanClass(string className, string content)
	{
		return (string)kxuriKOk2JP21JwAfEj9(new string[5]
		{
			(string)UueqoVOkMipF3oJcsLIp(0x1C663DA1 ^ 0x1C6408FD),
			className,
			(string)UueqoVOkMipF3oJcsLIp(-1539486135 ^ -1539350093),
			content,
			(string)UueqoVOkMipF3oJcsLIp(-11799394 ^ -11943452)
		});
	}

	internal static object hZGuK4OkpcdY5mklxlx6()
	{
		return Path.GetInvalidFileNameChars();
	}

	internal static object u6wvfxOkCtUlVDgtAYZ0(object P_0)
	{
		return Regex.Escape((string)P_0);
	}

	internal static object UueqoVOkMipF3oJcsLIp(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object WNyDwPOkkn06dsVjsbLR(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static object Fjxn1YOkUN8qWZG6ErPf(object P_0, object P_1, object P_2)
	{
		return Regex.Replace((string)P_0, (string)P_1, (string)P_2);
	}

	internal static bool eQrPfCOkTdRHggpsSEgm()
	{
		return cgpV1NOk3HQ4bCsRJevu == null;
	}

	internal static HTMLUtility K7eipEOkQAroedVPt1H2()
	{
		return cgpV1NOk3HQ4bCsRJevu;
	}

	internal static object pCWZRWOkVabvBYxYXHU9(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static object VGc9u4OkAJei5V3DVFGg(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object blfk7iOkGC9Sq3BB5Fij(object P_0, object P_1, object P_2, object P_3)
	{
		return string.Format((string)P_0, P_1, P_2, P_3);
	}

	internal static object NRiHNEOk7st1d9Af0DvD(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object kxuriKOk2JP21JwAfEj9(object P_0)
	{
		return string.Concat((string[])P_0);
	}

	internal static object VFdbHrOkoYEjlbHYhNkF(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object T4i9ZbOkFL3tQHZAwA8o(object P_0, bool subFolders, Guid tableHeadUid, object P_3, object P_4)
	{
		return InsertImg((string)P_0, subFolders, tableHeadUid, (string)P_3, (string)P_4);
	}

	internal static object s34pZROkirABBnqLMoPr(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object IAdAfLOkIFjQeVg5ZaBQ(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static int s1W2RrOka5vLuPpiuhVT(object P_0)
	{
		return ((string)P_0).Length;
	}
}
