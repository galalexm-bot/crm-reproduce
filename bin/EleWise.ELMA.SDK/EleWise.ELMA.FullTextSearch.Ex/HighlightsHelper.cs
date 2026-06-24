using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Files;
using EleWise.ELMA.Files.Previews;
using EleWise.ELMA.FullTextSearch.ExtensionPoints;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FullTextSearch.Extensions;

public static class HighlightsHelper
{
	private static Dictionary<Type, Dictionary<string, string>> Mapping;

	private static Dictionary<Type, Dictionary<string, long>> Order;

	internal static HighlightsHelper emxthCGCTp1dcu489TGS;

	public static string CutHtmlTags(BinaryFile file)
	{
		//Discarded unreachable code: IL_0061, IL_00bb, IL_00ca, IL_00f1, IL_0162, IL_0171, IL_0228, IL_0237
		int num = 5;
		int num2 = num;
		IFilePreviewService serviceNotNull = default(IFilePreviewService);
		string text2 = default(string);
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 6:
				if (ig4vrYGCOhBrBfTqk9aI(serviceNotNull, file) <= 100000000)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 2;
					}
					break;
				}
				goto case 14;
			case 14:
				return "";
			case 2:
				text2 = (string)cG15MhGC2mIuJpJVaGnx(serviceNotNull, file);
				num2 = 9;
				break;
			case 15:
				return string.Empty;
			case 4:
				text = "";
				num2 = 13;
				break;
			case 12:
				if (!new List<string>
				{
					z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1411196499 ^ -1411313375),
					(string)XFLjUQGCPPFKlPTVmUOa(-1858887263 ^ -1859098309)
				}.Contains((string)Rc9YAsGC1XMFal4EQmND(text2)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 9:
				if (pbsE4sGCeqXMoxyLxbrP(text2))
				{
					num2 = 10;
					break;
				}
				goto case 12;
			case 3:
				text = serviceNotNull.GetPreviewText(file);
				num2 = 7;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 3;
				}
				break;
			case 8:
			case 11:
				return text;
			case 13:
				serviceNotNull = Locator.GetServiceNotNull<IFilePreviewService>();
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
				{
					num2 = 5;
				}
				break;
			case 5:
				if (!file.Encrypt)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 15;
			default:
				text = serviceNotNull.GetPreviewText(file);
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 11;
				}
				break;
			case 7:
				text = CutHtmlTags(text, isHtml: true);
				num2 = 8;
				break;
			}
		}
	}

	public static string CutHtmlTags(string text, bool isHtml = false)
	{
		//Discarded unreachable code: IL_04b3, IL_04c2
		int num = 18;
		string text2 = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 8:
					text2 = (string)hiLCSlGCphi8nXEZSS4F(text2);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 1;
					}
					continue;
				case 2:
					text2 = (string)fYgevbGC3tdDjQ9udX8n(text2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4E3931), XFLjUQGCPPFKlPTVmUOa(0x3CE17B75 ^ 0x3CE13257), RegexOptions.IgnoreCase);
					num2 = 6;
					continue;
				case 6:
					text2 = (string)fYgevbGC3tdDjQ9udX8n(text2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-477139494 ^ -477321974), XFLjUQGCPPFKlPTVmUOa(0x10E41EDB ^ 0x10E457F9), RegexOptions.IgnoreCase);
					num2 = 13;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 14;
					}
					continue;
				case 11:
					text2 = (string)jhh0nuGCNJyuneab2GwH(text2.GetClearBodyFromHtml());
					num2 = 19;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 20;
					}
					continue;
				case 10:
					text2 = Regex.Replace(text2, (string)XFLjUQGCPPFKlPTVmUOa(0x7459E02 ^ 0x74656EE), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345439002), RegexOptions.IgnoreCase);
					num = 16;
					break;
				case 20:
					text2 = (string)fYgevbGC3tdDjQ9udX8n(text2, XFLjUQGCPPFKlPTVmUOa(0x31326106 ^ 0x3131A9A0), XFLjUQGCPPFKlPTVmUOa(0x12441CA4 ^ 0x12445586), RegexOptions.IgnoreCase);
					num2 = 15;
					continue;
				case 4:
					text2 = Regex.Replace(text2, (string)XFLjUQGCPPFKlPTVmUOa(-978351861 ^ -978567139), (string)XFLjUQGCPPFKlPTVmUOa(-1858887263 ^ -1858869117), RegexOptions.IgnoreCase);
					num2 = 5;
					continue;
				case 18:
					text2 = text;
					num = 17;
					break;
				case 12:
				case 13:
					text2 = (string)j64V3gGCDGZnufPK21hk(text2, XFLjUQGCPPFKlPTVmUOa(-309639236 ^ -309817654), XFLjUQGCPPFKlPTVmUOa(0x12A5FAC7 ^ 0x12A5B3E5));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 9;
					}
					continue;
				case 9:
					return text2;
				case 5:
					text2 = (string)fYgevbGC3tdDjQ9udX8n(text2, XFLjUQGCPPFKlPTVmUOa(0x7459E02 ^ 0x7465726), XFLjUQGCPPFKlPTVmUOa(0x4785BC0D ^ 0x4785F52F), RegexOptions.IgnoreCase);
					num2 = 7;
					continue;
				case 1:
					if (!isHtml)
					{
						num2 = 12;
						continue;
					}
					goto case 19;
				case 14:
					text2 = (string)fYgevbGC3tdDjQ9udX8n(text2, XFLjUQGCPPFKlPTVmUOa(0x68BBB53E ^ 0x68B87DE0), XFLjUQGCPPFKlPTVmUOa(0x3A6135BE ^ 0x3A617C9C), RegexOptions.IgnoreCase);
					num2 = 10;
					continue;
				case 16:
					text2 = (string)fYgevbGC3tdDjQ9udX8n(text2, XFLjUQGCPPFKlPTVmUOa(0x35C0467B ^ 0x35C38E81), XFLjUQGCPPFKlPTVmUOa(-35995181 ^ -36009743), RegexOptions.IgnoreCase);
					num2 = 3;
					continue;
				default:
					text2 = Regex.Replace(text2, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1D2A5E), "");
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 4;
					}
					continue;
				case 3:
					text2 = (string)fYgevbGC3tdDjQ9udX8n(text2, XFLjUQGCPPFKlPTVmUOa(0x35C0467B ^ 0x35C38F73), XFLjUQGCPPFKlPTVmUOa(-97972138 ^ -97953420), RegexOptions.IgnoreCase);
					num2 = 4;
					continue;
				case 15:
					text2 = Regex.Replace(text2, (string)XFLjUQGCPPFKlPTVmUOa(-1867198571 ^ -1867053277), (string)XFLjUQGCPPFKlPTVmUOa(0x6DC147B0 ^ 0x6DC10E92), RegexOptions.IgnoreCase);
					num2 = 2;
					continue;
				case 17:
					if (isHtml)
					{
						num2 = 11;
						continue;
					}
					goto case 8;
				case 19:
					text2 = (string)DY3AySGCamkihXSPZZeO(DY3AySGCamkihXSPZZeO(DY3AySGCamkihXSPZZeO(DY3AySGCamkihXSPZZeO(((string)DY3AySGCamkihXSPZZeO(text2, XFLjUQGCPPFKlPTVmUOa(-740338220 ^ -740516724), XFLjUQGCPPFKlPTVmUOa(0x3B36AB09 ^ 0x3B36E22B))).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-105199646 ^ -105312630), (string)XFLjUQGCPPFKlPTVmUOa(0x53CACA3 ^ 0x53CE581)), XFLjUQGCPPFKlPTVmUOa(0x12441CA4 ^ 0x12447F9A), XFLjUQGCPPFKlPTVmUOa(0x12A5FAC7 ^ 0x12A5B3E5)), XFLjUQGCPPFKlPTVmUOa(0x3A6135BE ^ 0x3A612B46), XFLjUQGCPPFKlPTVmUOa(0x2A7797B7 ^ 0x2A77DE95)), XFLjUQGCPPFKlPTVmUOa(0x6DC147B0 ^ 0x6DC15814), XFLjUQGCPPFKlPTVmUOa(-2138958856 ^ -2138940710)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-289714582 ^ -289713728), XFLjUQGCPPFKlPTVmUOa(-97972138 ^ -97953420));
					num2 = 13;
					continue;
				case 7:
					text2 = (string)fYgevbGC3tdDjQ9udX8n(text2, XFLjUQGCPPFKlPTVmUOa(0x3A6135BE ^ 0x3A62FC8C), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-29254301 ^ -29240255), RegexOptions.IgnoreCase);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
		}
	}

	public static List<KeyValuePair<bool, string>> HighlightToHtml(string highlight, string openTag = null, string closeTag = null)
	{
		if (string.IsNullOrWhiteSpace(highlight))
		{
			return new List<KeyValuePair<bool, string>>();
		}
		string text = (string.IsNullOrWhiteSpace(openTag) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x61EC0CB8 ^ 0x61EFC532) : openTag);
		string value = (string.IsNullOrWhiteSpace(closeTag) ? z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1822890472 ^ -1822740594) : closeTag);
		List<KeyValuePair<bool, string>> list = new List<KeyValuePair<bool, string>>();
		string text2 = highlight.Trim();
		while (text2.Length > 0 && !string.IsNullOrWhiteSpace(text) && !string.IsNullOrWhiteSpace(value))
		{
			int num = text2.IndexOf(text);
			if (num < 0)
			{
				list.Add(new KeyValuePair<bool, string>(key: false, text2));
				text2 = "";
				continue;
			}
			list.Add(new KeyValuePair<bool, string>(key: false, text2.Substring(0, num)));
			text2 = text2.Remove(0, num);
			text2 = text2.Remove(0, text.Length);
			int num2 = text2.IndexOf(value);
			if (num2 < 0)
			{
				list.Add(new KeyValuePair<bool, string>(key: false, text2));
				text2 = "";
			}
			else
			{
				list.Add(new KeyValuePair<bool, string>(key: true, text2.Substring(0, num2)));
				text2 = text2.Remove(0, num2);
				text2 = text2.Remove(0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-3333094 ^ -3215988).Length);
			}
		}
		return list;
	}

	public static long GetOrder(Type type, string key)
	{
		//Discarded unreachable code: IL_0049, IL_0058, IL_0107, IL_0116, IL_015b, IL_0165, IL_0216, IL_024e, IL_025d, IL_02e1, IL_0300, IL_032c, IL_0352, IL_0361
		int num = 3;
		int num2 = num;
		_003C_003Ec__DisplayClass7_0 _003C_003Ec__DisplayClass7_ = default(_003C_003Ec__DisplayClass7_0);
		IEnumerator<IModuleFullTextSearchExtension> enumerator = default(IEnumerator<IModuleFullTextSearchExtension>);
		Dictionary<string, long> dictionary = default(Dictionary<string, long>);
		IEnumerator<KeyValuePair<string, long>> enumerator2 = default(IEnumerator<KeyValuePair<string, long>>);
		KeyValuePair<string, long> current = default(KeyValuePair<string, long>);
		while (true)
		{
			switch (num2)
			{
			case 8:
				Order.Add(type, _003C_003Ec__DisplayClass7_.order);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num2 = 7;
				}
				break;
			case 9:
			{
				IEnumerable<IModuleFullTextSearchExtension> extensionPoints = ComponentManager.Current.GetExtensionPoints<IModuleFullTextSearchExtension>();
				_003C_003Ec__DisplayClass7_.order = new Dictionary<string, long>();
				enumerator = extensionPoints.GetEnumerator();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
				{
					num2 = 1;
				}
				break;
			}
			default:
				_003C_003Ec__DisplayClass7_ = new _003C_003Ec__DisplayClass7_0();
				num2 = 9;
				break;
			case 4:
				return dictionary[key];
			case 6:
				return 1000000L;
			case 3:
				if (Order.ContainsKey(type))
				{
					num2 = 2;
					break;
				}
				goto default;
			case 1:
				try
				{
					while (true)
					{
						int num3;
						if (!uZnKjXGCtqjp1IwgOKgj(enumerator))
						{
							num3 = 3;
							goto IL_0125;
						}
						goto IL_0268;
						IL_0125:
						switch (num3)
						{
						case 2:
							try
							{
								while (true)
								{
									IL_01ca:
									int num4;
									if (!uZnKjXGCtqjp1IwgOKgj(enumerator2))
									{
										num4 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 == 0)
										{
											num4 = 1;
										}
										goto IL_0169;
									}
									goto IL_01b7;
									IL_01b7:
									current = enumerator2.Current;
									num4 = 2;
									goto IL_0169;
									IL_0169:
									while (true)
									{
										switch (num4)
										{
										case 2:
											_003C_003Ec__DisplayClass7_.order.Add(current.Key, current.Value);
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
											{
												num4 = 0;
											}
											continue;
										case 3:
											break;
										default:
											goto IL_01ca;
										case 1:
											goto end_IL_01ca;
										}
										break;
									}
									goto IL_01b7;
									continue;
									end_IL_01ca:
									break;
								}
							}
							finally
							{
								if (enumerator2 != null)
								{
									int num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
									{
										num5 = 0;
									}
									while (true)
									{
										switch (num5)
										{
										case 1:
											enumerator2.Dispose();
											num5 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
											{
												num5 = 0;
											}
											continue;
										case 0:
											break;
										}
										break;
									}
								}
							}
							break;
						case 1:
							goto IL_0268;
						case 3:
							goto end_IL_013f;
						}
						continue;
						IL_0268:
						enumerator2 = enumerator.Current.GetHighlightsOrder(type).Where(_003C_003Ec__DisplayClass7_._003CGetOrder_003Eb__0).GetEnumerator();
						int num6 = 2;
						num3 = num6;
						goto IL_0125;
						continue;
						end_IL_013f:
						break;
					}
				}
				finally
				{
					int num7;
					if (enumerator == null)
					{
						num7 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
						{
							num7 = 0;
						}
						goto IL_02e5;
					}
					goto IL_030a;
					IL_030a:
					enumerator.Dispose();
					num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a != 0)
					{
						num7 = 1;
					}
					goto IL_02e5;
					IL_02e5:
					switch (num7)
					{
					default:
						goto end_IL_02c0;
					case 0:
						goto end_IL_02c0;
					case 2:
						break;
					case 1:
						goto end_IL_02c0;
					}
					goto IL_030a;
					end_IL_02c0:;
				}
				goto case 8;
			case 5:
				if (!dictionary.ContainsKey(key))
				{
					num2 = 6;
					break;
				}
				goto case 4;
			case 2:
			case 7:
				dictionary = Order[type];
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	public static string GetDisplayName(Type type, string key)
	{
		//Discarded unreachable code: IL_00af, IL_00be, IL_00c9, IL_0103, IL_010d, IL_01ce, IL_01ed, IL_01fc, IL_0229, IL_0238, IL_02b3, IL_02d2, IL_02e1, IL_02fe, IL_030d
		int num = 1;
		int num2 = num;
		Dictionary<string, string> dictionary = default(Dictionary<string, string>);
		_003C_003Ec__DisplayClass8_0 _003C_003Ec__DisplayClass8_ = default(_003C_003Ec__DisplayClass8_0);
		IEnumerator<IModuleFullTextSearchExtension> enumerator = default(IEnumerator<IModuleFullTextSearchExtension>);
		IEnumerator<KeyValuePair<string, string>> enumerator2 = default(IEnumerator<KeyValuePair<string, string>>);
		KeyValuePair<string, string> current = default(KeyValuePair<string, string>);
		while (true)
		{
			switch (num2)
			{
			case 3:
				dictionary = Mapping[type];
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				Mapping.Add(type, _003C_003Ec__DisplayClass8_.mapping);
				num2 = 3;
				break;
			case 1:
				if (!Mapping.ContainsKey(type))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 5:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 2;
							goto IL_00cd;
						}
						goto IL_0243;
						IL_00cd:
						switch (num3)
						{
						case 1:
							break;
						case 3:
							try
							{
								while (true)
								{
									IL_0182:
									int num4;
									if (!uZnKjXGCtqjp1IwgOKgj(enumerator2))
									{
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
										{
											num4 = 1;
										}
										goto IL_0111;
									}
									goto IL_015f;
									IL_015f:
									current = enumerator2.Current;
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
									{
										num4 = 2;
									}
									goto IL_0111;
									IL_0111:
									while (true)
									{
										switch (num4)
										{
										case 2:
											_003C_003Ec__DisplayClass8_.mapping.Add(current.Key, current.Value);
											num4 = 0;
											if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
											{
												num4 = 0;
											}
											continue;
										case 3:
											break;
										default:
											goto IL_0182;
										case 1:
											goto end_IL_0182;
										}
										break;
									}
									goto IL_015f;
									continue;
									end_IL_0182:
									break;
								}
							}
							finally
							{
								int num5;
								if (enumerator2 == null)
								{
									num5 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
									{
										num5 = 1;
									}
									goto IL_01d2;
								}
								goto IL_0207;
								IL_0207:
								VGilhaGCw25R7kclySFA(enumerator2);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 == 0)
								{
									num5 = 2;
								}
								goto IL_01d2;
								IL_01d2:
								switch (num5)
								{
								case 1:
									goto end_IL_01ad;
								case 2:
									goto end_IL_01ad;
								}
								goto IL_0207;
								end_IL_01ad:;
							}
							break;
						default:
							goto IL_0243;
						case 2:
							goto end_IL_00e7;
						}
						continue;
						IL_0243:
						enumerator2 = enumerator.Current.GetReverseMapping(type).Where(_003C_003Ec__DisplayClass8_._003CGetDisplayName_003Eb__0).GetEnumerator();
						num3 = 3;
						goto IL_00cd;
						continue;
						end_IL_00e7:
						break;
					}
				}
				finally
				{
					int num6;
					if (enumerator == null)
					{
						num6 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
						{
							num6 = 1;
						}
						goto IL_02b7;
					}
					goto IL_02ec;
					IL_02ec:
					VGilhaGCw25R7kclySFA(enumerator);
					num6 = 2;
					goto IL_02b7;
					IL_02b7:
					switch (num6)
					{
					case 1:
						goto end_IL_0292;
					case 2:
						goto end_IL_0292;
					}
					goto IL_02ec;
					end_IL_0292:;
				}
				goto case 2;
			case 7:
			{
				IEnumerable<IModuleFullTextSearchExtension> extensionPoints = ComponentManager.Current.GetExtensionPoints<IModuleFullTextSearchExtension>();
				_003C_003Ec__DisplayClass8_.mapping = new Dictionary<string, string>();
				enumerator = extensionPoints.GetEnumerator();
				num2 = 5;
				break;
			}
			case 4:
				if (dictionary.ContainsKey(key))
				{
					num2 = 6;
					break;
				}
				return key;
			default:
				_003C_003Ec__DisplayClass8_ = new _003C_003Ec__DisplayClass8_0();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
				{
					num2 = 7;
				}
				break;
			case 6:
				return dictionary[key];
			}
		}
	}

	static HighlightsHelper()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				SingletonReader.JJCZtPuTvSt();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				Mapping = new Dictionary<Type, Dictionary<string, string>>();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 1:
				Order = new Dictionary<Type, Dictionary<string, long>>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static long ig4vrYGCOhBrBfTqk9aI(object P_0, object P_1)
	{
		return ((IFilePreviewService)P_0).GetTextPreviewSize((BinaryFile)P_1);
	}

	internal static object cG15MhGC2mIuJpJVaGnx(object P_0, object P_1)
	{
		return ((IFilePreviewService)P_0).GetTextPreviewPath((BinaryFile)P_1);
	}

	internal static bool pbsE4sGCeqXMoxyLxbrP(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object XFLjUQGCPPFKlPTVmUOa(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object Rc9YAsGC1XMFal4EQmND(object P_0)
	{
		return Path.GetExtension((string)P_0);
	}

	internal static bool TSY2xTGCkcOM7Pr7AOjv()
	{
		return emxthCGCTp1dcu489TGS == null;
	}

	internal static HighlightsHelper TsQFQWGCnpSfDL7AKUeT()
	{
		return emxthCGCTp1dcu489TGS;
	}

	internal static object jhh0nuGCNJyuneab2GwH(object P_0)
	{
		return ((string)P_0).SanitizeHtml();
	}

	internal static object fYgevbGC3tdDjQ9udX8n(object P_0, object P_1, object P_2, RegexOptions P_3)
	{
		return Regex.Replace((string)P_0, (string)P_1, (string)P_2, P_3);
	}

	internal static object hiLCSlGCphi8nXEZSS4F(object P_0)
	{
		return WebUtility.HtmlDecode((string)P_0);
	}

	internal static object DY3AySGCamkihXSPZZeO(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object j64V3gGCDGZnufPK21hk(object P_0, object P_1, object P_2)
	{
		return Regex.Replace((string)P_0, (string)P_1, (string)P_2);
	}

	internal static bool uZnKjXGCtqjp1IwgOKgj(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static void VGilhaGCw25R7kclySFA(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
