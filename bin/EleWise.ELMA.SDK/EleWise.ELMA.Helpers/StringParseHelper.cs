using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using EleWise.ELMA.Extensions;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Settings;
using EleWise.ELMA.Services;
using HtmlAgilityPack;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public static class StringParseHelper
{
	public const string BaseUrlPlaceHolder = "{#BaseUrl#}";

	public const string BaseUrlPlaceHolderShortAlias = "@~";

	private static readonly Dictionary<string, string[]> ValidHtmlTags;

	internal static StringParseHelper s3GcvfhUzRMGLQ09KOy2;

	[Obsolete("Use RelativeDateTimeParser.TryParseFromDate or RelativeDateTimeParser.TryParseToDate instead", true)]
	public static bool GetDateTimeFromString(string str, bool isFrom, out DateTime? result, out string errorMessage)
	{
		//Discarded unreachable code: IL_005f, IL_006e
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (isFrom)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				return RelativeDateTimeParser.TryParseToDate(str, out result, out errorMessage);
			case 1:
				return RelativeDateTimeParser.TryParseFromDate(str, out result, out errorMessage);
			}
		}
	}

	public static string GetJSMaskFromServer(string serverMask)
	{
		return Regex.Replace(Regex.Replace(serverMask, (string)OmYS1BhsWb0wBI0xxv7p(-1870892489 ^ -1870668279), (string)OmYS1BhsWb0wBI0xxv7p(-1767720453 ^ -1767828075)), (string)OmYS1BhsWb0wBI0xxv7p(-16752921 ^ -16518503), EvaluateDateTimeMask);
	}

	public static string PrepareDateMask(string mask, string separator, string removeTemplate = null)
	{
		//Discarded unreachable code: IL_0084, IL_0093, IL_00d1, IL_0128, IL_0137
		int num = 12;
		int num2 = num;
		string[] array = default(string[]);
		int num3 = default(int);
		_003C_003Ec__DisplayClass4_0 _003C_003Ec__DisplayClass4_ = default(_003C_003Ec__DisplayClass4_0);
		while (true)
		{
			switch (num2)
			{
			case 8:
			case 13:
				return string.Join(separator, array);
			case 11:
				num3 = 0;
				num2 = 4;
				break;
			case 2:
				if (vouXmXhsG87uqHwuj55D(removeTemplate))
				{
					num2 = 8;
					break;
				}
				goto case 7;
			case 10:
				array[num3] = (string)tEd0SjhshjGCTHilhJlu(array[num3], array[num3]);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb != 0)
				{
					num2 = 0;
				}
				break;
			case 7:
				_003C_003Ec__DisplayClass4_ = new _003C_003Ec__DisplayClass4_0();
				num2 = 3;
				break;
			case 12:
				array = (string[])iDNdaMhsohWGX1PYICkc(mask, new string[1] { separator }, StringSplitOptions.RemoveEmptyEntries);
				num2 = 11;
				break;
			case 1:
			case 6:
				if (mSSgcyhsbhCf0jKTZ6lW(array[num3]) == 1)
				{
					num2 = 10;
					break;
				}
				goto default;
			case 4:
			case 5:
				if (num3 < array.Length)
				{
					num2 = 6;
					break;
				}
				goto case 2;
			default:
				num3++;
				num2 = 5;
				break;
			case 9:
				array = array.Where(_003C_003Ec__DisplayClass4_._003CPrepareDateMask_003Eb__0).ToArray();
				num2 = 13;
				break;
			case 3:
				_003C_003Ec__DisplayClass4_.regex = new Regex(removeTemplate);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 9;
				}
				break;
			}
		}
	}

	public static long[] GetIdsFromString(string ids, params char[] separator)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				separator = new char[1] { '_' };
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 2;
				}
				continue;
			default:
				if (separator.Length == 0)
				{
					num2 = 3;
					continue;
				}
				break;
			case 1:
				if (separator != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fd0d9740d87c47d192d75fe4052cba89 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 3;
			case 2:
				break;
			}
			break;
		}
		return ((IEnumerable<string>)LcQ18PhsElJ3lwaMwDx6(ids, separator)).Select((string i) => _003C_003Ec.p8UZ94vycxf2Uafl8Rug(i)).ToArray();
	}

	public static string GetClearBodyFromHtml(this string source)
	{
		//Discarded unreachable code: IL_0090, IL_00d1, IL_010a, IL_0152, IL_0161, IL_01bc
		int num = 4;
		int num2 = num;
		string text = default(string);
		HtmlDocument html = default(HtmlDocument);
		while (true)
		{
			switch (num2)
			{
			case 5:
				return string.Empty;
			case 2:
				text = null;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
				{
					num2 = 1;
				}
				continue;
			case 1:
				try
				{
					HtmlNode val = ((HtmlNode)akJLOrhsfnAfcF3XxGe1(html)).SelectSingleNode((string)OmYS1BhsWb0wBI0xxv7p(-138018305 ^ -138039965));
					int num3 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						object obj;
						switch (num3)
						{
						case 1:
							if (val == null)
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
								{
									num3 = 0;
								}
								continue;
							}
							obj = LjeEd9hsQkpHbIsoMTKt(val);
							break;
						default:
							obj = source;
							break;
						case 2:
							goto end_IL_0094;
						}
						text = (string)obj;
						num3 = 2;
						continue;
						end_IL_0094:
						break;
					}
				}
				catch (Exception ex)
				{
					int num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num4 = 0;
					}
					while (true)
					{
						switch (num4)
						{
						case 1:
							((ILogger)jy74wYhsCbommOGrOIIq()).Error(CeOM9YhsvRhD2xjEQx2A(ex), ex);
							num4 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
							{
								num4 = 0;
							}
							continue;
						case 0:
							break;
						}
						break;
					}
				}
				break;
			case 3:
				if (html != null)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
					{
						num2 = 2;
					}
					continue;
				}
				goto case 5;
			case 4:
				html = GetHtml(source);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 3;
				}
				continue;
			}
			break;
		}
		return (string)bYWaIrhs8ybmaEnDBMcG(text);
	}

	public static string SetFullPathForImg(this string source, string prefix)
	{
		//Discarded unreachable code: IL_007e, IL_008d
		int num = 3;
		int num2 = num;
		HtmlDocument val = default(HtmlDocument);
		while (true)
		{
			switch (num2)
			{
			case 3:
				val = (HtmlDocument)f6PCNHhsZ2UeFBQPKne4(source);
				num2 = 2;
				break;
			default:
				return string.Empty;
			case 1:
			{
				object obj = akJLOrhsfnAfcF3XxGe1(val);
				feJs8whsuh9t0xPY4Nxm(obj, prefix);
				return (string)LjeEd9hsQkpHbIsoMTKt(obj);
			}
			case 2:
				if (val != null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public static string SanitizeHtml(this string source)
	{
		//Discarded unreachable code: IL_0055, IL_0064, IL_006f, IL_00c0, IL_00ca, IL_0119, IL_0128, IL_0138, IL_0179, IL_024b, IL_025a, IL_02b3, IL_02e3, IL_02f2, IL_02fe, IL_03ce, IL_03e1, IL_03f0
		int num = 4;
		int num2 = num;
		HtmlNode val = default(HtmlNode);
		string[] whitelist = default(string[]);
		Dictionary<string, string[]>.Enumerator enumerator = default(Dictionary<string, string[]>.Enumerator);
		KeyValuePair<string, string[]> current = default(KeyValuePair<string, string[]>);
		_003C_003Ec__DisplayClass9_0 _003C_003Ec__DisplayClass9_ = default(_003C_003Ec__DisplayClass9_0);
		IEnumerator<HtmlNode> enumerator2 = default(IEnumerator<HtmlNode>);
		HtmlAttribute val3 = default(HtmlAttribute);
		HtmlAttribute[] array = default(HtmlAttribute[]);
		int num5 = default(int);
		HtmlNode current2 = default(HtmlNode);
		HtmlDocument val2 = default(HtmlDocument);
		while (true)
		{
			switch (num2)
			{
			default:
				CleanNodes(val, whitelist);
				num2 = 5;
				break;
			case 6:
				try
				{
					while (true)
					{
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 4;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
							{
								num3 = 4;
							}
							goto IL_0073;
						}
						goto IL_037f;
						IL_037f:
						current = enumerator.Current;
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
						{
							num3 = 1;
						}
						goto IL_0073;
						IL_0073:
						while (true)
						{
							switch (num3)
							{
							case 1:
								_003C_003Ec__DisplayClass9_ = new _003C_003Ec__DisplayClass9_0();
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
								{
									num3 = 5;
								}
								continue;
							case 2:
								try
								{
									while (true)
									{
										IL_01a6:
										int num4;
										if (!enumerator2.MoveNext())
										{
											num4 = 10;
											goto IL_00ce;
										}
										goto IL_0183;
										IL_00ce:
										while (true)
										{
											switch (num4)
											{
											case 5:
												if (current.Value.Contains((string)LHYuMThsS3j15OlfqXOL(val3)))
												{
													num4 = 2;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
													{
														num4 = 0;
													}
													continue;
												}
												goto case 6;
											case 3:
												break;
											case 7:
											case 14:
												goto IL_01a6;
											case 1:
											case 11:
												val3 = array[num5];
												num4 = 5;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
												{
													num4 = 0;
												}
												continue;
											case 12:
												num5 = 0;
												num4 = 0;
												if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
												{
													num4 = 0;
												}
												continue;
											default:
												if (num5 < array.Length)
												{
													num4 = 1;
													if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
													{
														num4 = 1;
													}
													continue;
												}
												goto IL_01a6;
											case 8:
												if (!Fp85EphsI6mfnUbLgegG(current2))
												{
													num4 = 7;
													continue;
												}
												goto case 13;
											case 6:
												gK9khehsiQG8rvIUDVO1(val3);
												num4 = 9;
												continue;
											case 13:
												array = ((IEnumerable<HtmlAttribute>)Q4xKHfhsVt8tWWVVpK06(current2)).ToArray();
												num4 = 12;
												continue;
											case 2:
											case 9:
												num5++;
												num4 = 4;
												continue;
											case 10:
												goto end_IL_01a6;
											}
											break;
										}
										goto IL_0183;
										IL_0183:
										current2 = enumerator2.Current;
										num4 = 1;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
										{
											num4 = 8;
										}
										goto IL_00ce;
										continue;
										end_IL_01a6:
										break;
									}
								}
								finally
								{
									int num6;
									if (enumerator2 == null)
									{
										num6 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
										{
											num6 = 0;
										}
										goto IL_02b7;
									}
									goto IL_02cd;
									IL_02cd:
									X3HOKjhsRJMn5ynnRi4j(enumerator2);
									num6 = 2;
									goto IL_02b7;
									IL_02b7:
									switch (num6)
									{
									default:
										goto end_IL_0292;
									case 1:
										break;
									case 0:
										goto end_IL_0292;
									case 2:
										goto end_IL_0292;
									}
									goto IL_02cd;
									end_IL_0292:;
								}
								break;
							case 3:
								break;
							case 5:
								_003C_003Ec__DisplayClass9_.tag1 = current;
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
								{
									num3 = 0;
								}
								continue;
							default:
								enumerator2 = val.DescendantsAndSelf().Where(_003C_003Ec__DisplayClass9_._003CSanitizeHtml_003Eb__1).GetEnumerator();
								num3 = 2;
								continue;
							case 6:
								goto IL_037f;
							case 4:
								goto end_IL_030c;
							}
							break;
						}
						continue;
						end_IL_030c:
						break;
					}
				}
				finally
				{
					((IDisposable)enumerator).Dispose();
					int num7 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num7 = 0;
					}
					switch (num7)
					{
					case 0:
						break;
					}
				}
				goto case 1;
			case 4:
				val2 = (HtmlDocument)f6PCNHhsZ2UeFBQPKne4(source);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 3;
				}
				break;
			case 1:
				return (string)LjeEd9hsQkpHbIsoMTKt(val);
			case 2:
				return string.Empty;
			case 3:
				if (val2 != null)
				{
					val = (HtmlNode)akJLOrhsfnAfcF3XxGe1(val2);
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 2;
					}
				}
				else
				{
					num2 = 2;
				}
				break;
			case 5:
				enumerator = ValidHtmlTags.GetEnumerator();
				num2 = 6;
				break;
			case 7:
				whitelist = ValidHtmlTags.Select(delegate(KeyValuePair<string, string[]> kv)
				{
					KeyValuePair<string, string[]> keyValuePair = kv;
					return keyValuePair.Key;
				}).ToArray();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string PrepareHtmlHref(this string source, string applicationBaseUrl = null)
	{
		//Discarded unreachable code: IL_0070, IL_00b4, IL_00c3, IL_010f
		int num = 1;
		HtmlDocument val = default(HtmlDocument);
		CommonSettingsModule service = default(CommonSettingsModule);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return source;
				case 7:
					if (!xIybkZhsK92sDpReVW7P())
					{
						num2 = 9;
						continue;
					}
					goto case 2;
				case 5:
					return null;
				default:
					val = (HtmlDocument)f6PCNHhsZ2UeFBQPKne4(source.Trim());
					num = 12;
					break;
				case 11:
					if (!val.get_ParseErrors().Any())
					{
						if (string.IsNullOrWhiteSpace(applicationBaseUrl))
						{
							num = 7;
							break;
						}
						goto case 3;
					}
					num2 = 6;
					continue;
				case 12:
					if (val != null)
					{
						num2 = 11;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
						{
							num2 = 11;
						}
						continue;
					}
					goto case 6;
				case 2:
					service = Locator.GetService<CommonSettingsModule>();
					num2 = 10;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 2;
					}
					continue;
				case 3:
				case 4:
				case 9:
				{
					HtmlNode documentNode = val.get_DocumentNode();
					OxR86JhsTXowaotRQ0bO(documentNode, applicationBaseUrl);
					return documentNode.get_OuterHtml();
				}
				case 8:
					applicationBaseUrl = (string)vKugshhsXFeYleIpgm9H(service.Settings);
					num2 = 3;
					continue;
				case 10:
					if (service == null)
					{
						num2 = 4;
						continue;
					}
					goto case 8;
				case 1:
					if (!VgpdprhsqvulPRn6e8C6(source))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 5;
				}
				break;
			}
		}
	}

	public static string FormatWithBaseUrl(this string source, string applicationBaseUrl = null)
	{
		//Discarded unreachable code: IL_00cb
		int num = 2;
		CommonSettingsModule service = default(CommonSettingsModule);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					return null;
				case 1:
					if (VgpdprhsqvulPRn6e8C6(applicationBaseUrl))
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num2 = 5;
						}
						continue;
					}
					break;
				case 7:
					service = Locator.GetService<CommonSettingsModule>();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					continue;
				case 5:
					if (xIybkZhsK92sDpReVW7P())
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
						{
							num2 = 7;
						}
						continue;
					}
					break;
				case 8:
					return source;
				case 3:
					applicationBaseUrl = (string)vKugshhsXFeYleIpgm9H(service.Settings);
					num2 = 4;
					continue;
				case 2:
					if (!VgpdprhsqvulPRn6e8C6(source))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				default:
					if (service != null)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
						{
							num2 = 3;
						}
						continue;
					}
					break;
				case 4:
					break;
				}
				break;
			}
			source = (string)SI77ZthskLeBds0sHEHE(source, OmYS1BhsWb0wBI0xxv7p(-542721635 ^ -542752999), applicationBaseUrl);
			num = 8;
		}
	}

	private static void PrepareHtmlNodeHref(object node, object applicationBaseUrl)
	{
		//Discarded unreachable code: IL_0105, IL_0114, IL_01a6, IL_01de
		//IL_00da: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Invalid comparison between Unknown and I4
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_027a: Invalid comparison between Unknown and I4
		//IL_02c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cb: Invalid comparison between Unknown and I4
		int num = 1;
		int num2 = num;
		string text = default(string);
		_003C_003Ec__DisplayClass12_0 _003C_003Ec__DisplayClass12_ = default(_003C_003Ec__DisplayClass12_0);
		IEnumerator<HtmlNode> enumerator = default(IEnumerator<HtmlNode>);
		while (true)
		{
			switch (num2)
			{
			case 12:
				text = (string)zqLX4ths1V4Pq5snKrsC(text, OmYS1BhsWb0wBI0xxv7p(-1867198571 ^ -1867030007), new MatchEvaluator(_003C_003Ec__DisplayClass12_._003CPrepareHtmlNodeHref_003Eb__2), RegexOptions.IgnoreCase);
				num2 = 3;
				break;
			case 4:
				return;
			case 13:
				return;
			case 10:
				if (DXLKNEhs205cERRMeQsN(mVdNFphsO4Ky0Gjj8ceE(node), OmYS1BhsWb0wBI0xxv7p(-1217523399 ^ -1217602893), StringComparison.InvariantCultureIgnoreCase))
				{
					num2 = 7;
					break;
				}
				goto IL_0273;
			case 8:
				if ((int)CLAjxIhsnRXfsr5H4njl(node) == 2)
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
					{
						num2 = 5;
					}
					break;
				}
				if ((int)CLAjxIhsnRXfsr5H4njl(node) == 1)
				{
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
					{
						num2 = 10;
					}
					break;
				}
				goto IL_0273;
			case 6:
				try
				{
					while (true)
					{
						int num3;
						if (!Urtrirhs3FU8G9CSnrBp(enumerator))
						{
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
							{
								num3 = 0;
							}
							goto IL_0123;
						}
						goto IL_0139;
						IL_0139:
						PrepareHtmlNodeHref(enumerator.Current, _003C_003Ec__DisplayClass12_.applicationBaseUrl);
						int num4 = 2;
						num3 = num4;
						goto IL_0123;
						IL_0123:
						switch (num3)
						{
						case 1:
							return;
						case 2:
							continue;
						}
						goto IL_0139;
					}
				}
				finally
				{
					if (enumerator != null)
					{
						int num5 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
						{
							num5 = 1;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								X3HOKjhsRJMn5ynnRi4j(enumerator);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad == 0)
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
			case 3:
				((HtmlNode)node).set_InnerHtml(text);
				num2 = 13;
				break;
			case 11:
				text = (string)zqLX4ths1V4Pq5snKrsC(text, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103C445B), new MatchEvaluator(_003C_003Ec__DisplayClass12_._003CPrepareHtmlNodeHref_003Eb__1), RegexOptions.IgnoreCase);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num2 = 12;
				}
				break;
			case 1:
				_003C_003Ec__DisplayClass12_ = new _003C_003Ec__DisplayClass12_0();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				_003C_003Ec__DisplayClass12_.applicationBaseUrl = (string)applicationBaseUrl;
				num2 = 8;
				break;
			case 7:
				return;
			case 2:
				if (DeYoU5hsPc7CtthEI6oy(NdIaMvhse3V7gaAxwgaq(node)))
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num2 = 9;
					}
					break;
				}
				text = (string)zqLX4ths1V4Pq5snKrsC(NdIaMvhse3V7gaAxwgaq(node), OmYS1BhsWb0wBI0xxv7p(0x34185E55 ^ 0x341BF2E7), (MatchEvaluator)((Match match) => (string)_003C_003Ec.wfiCPrvMBXbk1lHxVIZH(_003C_003Ec.LFNOnjvyzc5T1jn7XFRu(0x7EC153F ^ 0x7E960D3), _003C_003Ec.aPhVDOvMFpf2nw9T0S7R(match))), RegexOptions.IgnoreCase);
				num2 = 11;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
				{
					num2 = 8;
				}
				break;
			case 5:
				return;
			case 9:
				return;
				IL_0273:
				if ((int)((HtmlNode)node).get_NodeType() != 3)
				{
					enumerator = ((IEnumerable<HtmlNode>)v0L2quhsNl2NfUAIHrhN(node)).GetEnumerator();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 6;
					}
				}
				else
				{
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 2;
					}
				}
				break;
			}
		}
	}

	private static void SetFullPathForImgNode(object node, object prefix)
	{
		//Discarded unreachable code: IL_005e, IL_006d, IL_0078, IL_0105, IL_013d, IL_014c, IL_018d, IL_019c, IL_0306, IL_0315, IL_0326
		//IL_016f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0175: Invalid comparison between Unknown and I4
		int num = 14;
		IEnumerator<HtmlNode> enumerator = default(IEnumerator<HtmlNode>);
		HtmlAttribute val = default(HtmlAttribute);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				object obj;
				switch (num2)
				{
				case 8:
					try
					{
						while (true)
						{
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 2;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
								{
									num3 = 1;
								}
								goto IL_007c;
							}
							goto IL_00b8;
							IL_00b8:
							feJs8whsuh9t0xPY4Nxm(enumerator.Current, prefix);
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
							{
								num3 = 1;
							}
							goto IL_007c;
							IL_007c:
							switch (num3)
							{
							case 1:
								break;
							default:
								goto IL_00b8;
							case 2:
								return;
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									X3HOKjhsRJMn5ynnRi4j(enumerator);
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
									{
										num4 = 0;
									}
									continue;
								case 0:
									break;
								}
								break;
							}
						}
					}
				case 4:
					enumerator = ((IEnumerable<HtmlNode>)v0L2quhsNl2NfUAIHrhN(node)).GetEnumerator();
					num2 = 8;
					continue;
				case 14:
					if ((int)((HtmlNode)node).get_NodeType() == 1)
					{
						num = 13;
						break;
					}
					goto case 2;
				case 11:
					return;
				case 12:
					return;
				case 7:
					if (((string)ymDkAshsagLZD2JneXiR(val)).IndexOf((string)OmYS1BhsWb0wBI0xxv7p(0x35C0467B ^ 0x35C3E879), StringComparison.OrdinalIgnoreCase) >= 0)
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 10;
				case 10:
					if (MGFNjBhsDD0Bh0vKJIod(ymDkAshsagLZD2JneXiR(val), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998382806), StringComparison.OrdinalIgnoreCase) < 0)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 2;
				case 1:
					VThQDfhstJR02eJJLpF4(val, string.Format((string)OmYS1BhsWb0wBI0xxv7p(0x48A7E34A ^ 0x48A731A0), prefix, ymDkAshsagLZD2JneXiR(val)));
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 5;
					}
					continue;
				case 6:
					if (val != null)
					{
						num2 = 7;
						continue;
					}
					goto case 2;
				case 9:
					if (!cfVbGZhspHpspjrsEoUR(Q4xKHfhsVt8tWWVVpK06(node), OmYS1BhsWb0wBI0xxv7p(0x7E6E5A0B ^ 0x7E6DF7F3)))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff == 0)
						{
							num2 = 0;
						}
						continue;
					}
					obj = ((HtmlAttributeCollection)Q4xKHfhsVt8tWWVVpK06(node)).get_Item((string)OmYS1BhsWb0wBI0xxv7p(0x4EDCBA32 ^ 0x4EDF17CA));
					goto IL_034c;
				case 2:
				case 3:
				case 5:
					if (!SflNjbhswwv0aFiiwSxW(node))
					{
						num2 = 11;
						continue;
					}
					goto case 4;
				case 13:
					if (!DXLKNEhs205cERRMeQsN(mVdNFphsO4Ky0Gjj8ceE(node), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-35995181 ^ -35999331), StringComparison.OrdinalIgnoreCase))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 9;
				default:
					{
						obj = null;
						goto IL_034c;
					}
					IL_034c:
					val = (HtmlAttribute)obj;
					num = 6;
					break;
				}
				break;
			}
		}
	}

	private static void CleanNodes(object node, object whitelist)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Invalid comparison between Unknown and I4
		//IL_0090: Unknown result type (might be due to invalid IL or missing references)
		//IL_0097: Expected O, but got Unknown
		int num = 8;
		int num2 = num;
		HtmlNodeCollection val = default(HtmlNodeCollection);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				XFmeMnhs6F1ALE6tGdW6(node, whitelist, val);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 0;
				}
				break;
			case 8:
				if ((int)CLAjxIhsnRXfsr5H4njl(node) == 1)
				{
					num2 = 7;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
					{
						num2 = 7;
					}
					break;
				}
				goto IL_00fb;
			case 3:
				val = new HtmlNodeCollection((HtmlNode)yNAr3Dhs4EyCHohstmGq(node));
				num2 = 2;
				break;
			case 7:
				if (!((IEnumerable<string>)whitelist).Contains(((HtmlNode)node).get_Name()))
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_00fb;
			default:
				((HtmlNode)yNAr3Dhs4EyCHohstmGq(node)).AppendChildren(val);
				num2 = 6;
				break;
			case 6:
				PZP6PPhsHLVhVkq8YiLR(((HtmlNode)node).get_ParentNode(), node);
				num2 = 5;
				break;
			case 5:
				return;
			case 4:
				{
					CleanChildren(node, whitelist);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
					{
						num2 = 1;
					}
					break;
				}
				IL_00fb:
				if (!((HtmlNode)node).get_HasChildNodes())
				{
					return;
				}
				num2 = 4;
				break;
			}
		}
	}

	private static void CleanChildren(object parent, object whitelist)
	{
		//Discarded unreachable code: IL_00a1, IL_00b0
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 2:
				xdq3ephs7BsRMrFe3LNK(((HtmlNodeCollection)v0L2quhsNl2NfUAIHrhN(parent)).get_Item(num3), whitelist);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (num3 < 0)
				{
					num2 = 5;
					break;
				}
				goto case 2;
			case 1:
				num3 = vswwpehsAl7ktWvyFHwQ(v0L2quhsNl2NfUAIHrhN(parent)) - 1;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
				{
					num2 = 0;
				}
				break;
			case 5:
				return;
			case 4:
				num3--;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	private static void GetNodes(object node, object whitelist, object htmlNodes)
	{
		//Discarded unreachable code: IL_00b1, IL_00c0
		//IL_00cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d2: Invalid comparison between Unknown and I4
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 5:
				gSN5oDhsxjUieTL6grJa(htmlNodes, node);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 4;
				}
				break;
			case 2:
				XFmeMnhs6F1ALE6tGdW6(node, whitelist, htmlNodes);
				num2 = 3;
				break;
			default:
				if (!((IEnumerable<string>)whitelist).Contains(((HtmlNode)node).get_Name()))
				{
					num2 = 6;
					break;
				}
				goto case 5;
			case 3:
				return;
			case 4:
			case 6:
				if (!SflNjbhswwv0aFiiwSxW(node))
				{
					return;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if ((int)CLAjxIhsnRXfsr5H4njl(node) == 1)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	private static void GetChildren(object node, object whitelist, object htmlNodes)
	{
		//Discarded unreachable code: IL_003d, IL_004c, IL_006d, IL_007c
		int num = 4;
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					num3++;
					num2 = 6;
					break;
				case 1:
					return;
				case 3:
				case 6:
					if (num3 >= ((HtmlNodeCollection)v0L2quhsNl2NfUAIHrhN(node)).get_Count())
					{
						return;
					}
					goto end_IL_0012;
				default:
					P9LjIEhsmIdxAmnVNNhK(PLTpKnhs0PcpYCaEAIDb(v0L2quhsNl2NfUAIHrhN(node), num3), whitelist, htmlNodes);
					num2 = 2;
					break;
				case 4:
					num3 = 0;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
					{
						num2 = 3;
					}
					break;
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	private static HtmlDocument GetHtml(object source)
	{
		//IL_0000: Unknown result type (might be due to invalid IL or missing references)
		//IL_0005: Unknown result type (might be due to invalid IL or missing references)
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0025: Expected O, but got Unknown
		//IL_0026: Expected O, but got Unknown
		HtmlDocument val = new HtmlDocument
		{
			OptionFixNestedTags = true,
			OptionAutoCloseOnEnd = true,
			OptionDefaultStreamEncoding = (Encoding)MVWAK2hsyrlKGlkKqoQq()
		};
		cYQSdchsM1KN6WadIebv((object)val, source);
		return val;
	}

	private static string EvaluateDateTimeMask(object match)
	{
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 1:
				num3 = mSSgcyhsbhCf0jKTZ6lW(VamJLVhsJmuN9i7f2EmG(match)) - 2;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 != 0)
				{
					num2 = 0;
				}
				continue;
			case 2:
				return (string)LxD5Rmhs9TFVuuc93unF(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3CE17B75 ^ 0x3CE3B0FF), num3);
			}
			if (num3 != 1)
			{
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f == 0)
				{
					num2 = 2;
				}
				continue;
			}
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7244ACAA);
		}
	}

	static StringParseHelper()
	{
		int num = 29;
		Dictionary<string, string[]> dictionary = default(Dictionary<string, string[]>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 18:
					dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-195614443 ^ -195786931), new string[2]
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x72455C96),
						(string)OmYS1BhsWb0wBI0xxv7p(-477139494 ^ -477314052)
					});
					num2 = 6;
					continue;
				case 33:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-1123633026 ^ -1123739666), new string[2]
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1FFEF86A ^ 0x1FFCA676),
						(string)OmYS1BhsWb0wBI0xxv7p(0xA592A41 ^ 0xA5A8467)
					});
					num2 = 25;
					continue;
				case 22:
					dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1333735954 ^ 0x4F7C9C64), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(0x57A5235E ^ 0x57A77D42),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1998538950 ^ -1998382820)
					});
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 30;
					}
					continue;
				case 29:
					SingletonReader.JJCZtPuTvSt();
					num2 = 28;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 == 0)
					{
						num2 = 21;
					}
					continue;
				case 9:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(0x6A81B9B4 ^ 0x6A821646), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(0x49E27B8A ^ 0x49E02596),
						(string)OmYS1BhsWb0wBI0xxv7p(-1426094279 ^ -1426314977)
					});
					num2 = 12;
					continue;
				case 37:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-29254301 ^ -29216077), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(-1870892489 ^ -1870779349),
						(string)OmYS1BhsWb0wBI0xxv7p(0x76DD48E ^ 0x76E7AA8)
					});
					num2 = 34;
					continue;
				default:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-812025778 ^ -811936254), new string[2]
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -575997512),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978564908)
					});
					num2 = 18;
					continue;
				case 35:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(0x34185E55 ^ 0x341BEE49), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(-1870892489 ^ -1870779349),
						(string)OmYS1BhsWb0wBI0xxv7p(0x3A5D5EF ^ 0x3A67BC9)
					});
					num2 = 36;
					continue;
				case 28:
					dictionary = new Dictionary<string, string[]>();
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
					{
						num2 = 2;
					}
					continue;
				case 24:
					dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C3E8F5), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(-1217523399 ^ -1217638619),
						(string)OmYS1BhsWb0wBI0xxv7p(0x307E9FD1 ^ 0x307D31F7)
					});
					num2 = 2;
					continue;
				case 40:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(0x638095EB ^ 0x63833B6D), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(0x2ACE37D ^ 0x2AEBD61),
						(string)OmYS1BhsWb0wBI0xxv7p(-1876063057 ^ -1876024695)
					});
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 == 0)
					{
						num2 = 24;
					}
					continue;
				case 25:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(0x5DD55050 ^ 0x5DD6FFCE), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(0x7E6E5A0B ^ 0x7E6C0417),
						(string)OmYS1BhsWb0wBI0xxv7p(--1867379187 ^ 0x6F4E5FD5)
					});
					num2 = 10;
					continue;
				case 38:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-2112703338 ^ -2112808012), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(-951514650 ^ -951363590),
						(string)OmYS1BhsWb0wBI0xxv7p(-35995181 ^ -36081675)
					});
					num2 = 31;
					continue;
				case 41:
					dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A4FD5FD), new string[2]
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AEBD61),
						(string)OmYS1BhsWb0wBI0xxv7p(0x12441CA4 ^ 0x1247B282)
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
					{
						num2 = 1;
					}
					continue;
				case 20:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-29254301 ^ -29215747), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(0x18A6761F ^ 0x18A42803),
						(string)OmYS1BhsWb0wBI0xxv7p(-606654180 ^ -606822598)
					});
					num2 = 32;
					continue;
				case 31:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(0x4EDCBA32 ^ 0x4EDE71B8), new string[4]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(-583745292 ^ -583622936),
						(string)OmYS1BhsWb0wBI0xxv7p(0x7EC153F ^ 0x7EFBB19),
						(string)OmYS1BhsWb0wBI0xxv7p(-105199646 ^ -105289524),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2107978722 ^ -2108071132)
					});
					num2 = 5;
					continue;
				case 8:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-889460160 ^ -889699288), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(0x49E27B8A ^ 0x49E02596),
						(string)OmYS1BhsWb0wBI0xxv7p(0x1FFEF86A ^ 0x1FFD564C)
					});
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe4a2de1ecd140c4a2194ec54ec77f94 == 0)
					{
						num2 = 22;
					}
					continue;
				case 27:
					dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-889460160 ^ -889699172), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(-16752921 ^ -16645893),
						(string)OmYS1BhsWb0wBI0xxv7p(-542721635 ^ -542828613)
					});
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
					{
						num2 = 16;
					}
					continue;
				case 13:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-812025778 ^ -811939772), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(0x7EC153F ^ 0x7EE4B23),
						(string)OmYS1BhsWb0wBI0xxv7p(-1858887263 ^ -1859121273)
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 35;
					}
					continue;
				case 3:
					ValidHtmlTags = dictionary;
					num2 = 14;
					continue;
				case 21:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-1824388195 ^ -1824414361), new string[2]
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1487388570 ^ -1487266182),
						(string)OmYS1BhsWb0wBI0xxv7p(-1837662597 ^ -1837838243)
					});
					num2 = 23;
					continue;
				case 6:
					dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2112703338 ^ -2112808202), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(-576149596 ^ -575997512),
						(string)OmYS1BhsWb0wBI0xxv7p(-882126494 ^ -882344124)
					});
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 4;
					}
					continue;
				case 10:
					dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146484081), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(-957824448 ^ -957703076),
						(string)OmYS1BhsWb0wBI0xxv7p(0x637E299B ^ 0x637D87BD)
					});
					num = 43;
					break;
				case 14:
					return;
				case 34:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-16752921 ^ -16518849), new string[3]
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70007027 ^ -70149871),
						(string)OmYS1BhsWb0wBI0xxv7p(-951514650 ^ -951408704),
						(string)OmYS1BhsWb0wBI0xxv7p(0x18A6761F ^ 0x18A5D9FF)
					});
					num2 = 7;
					continue;
				case 4:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(0x34A6D230 ^ 0x34A618E8), new string[3]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(0x5A4C7B29 ^ 0x5A4E2535),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17AE62FE),
						(string)OmYS1BhsWb0wBI0xxv7p(-1317790512 ^ -1317555484)
					});
					num2 = 17;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 7;
					}
					continue;
				case 32:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-521266112 ^ -521387588), new string[5]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(-1765851862 ^ -1765973194),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x1247B282),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AAE11E),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561183806),
						(string)OmYS1BhsWb0wBI0xxv7p(0x3A6135BE ^ 0x3A629B0C)
					});
					num2 = 26;
					continue;
				case 19:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(0x463A0F3C ^ 0x463BF1DE), new string[2]
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-538519530 ^ -538671606),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4A1640F ^ 0x4A2CA29)
					});
					num2 = 33;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 23;
					}
					continue;
				case 17:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-218496594 ^ -218517524), new string[3]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(-2138958856 ^ -2139075100),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811936152),
						(string)OmYS1BhsWb0wBI0xxv7p(-867826612 ^ -867849608)
					});
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
					{
						num2 = 0;
					}
					continue;
				case 23:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-1334993905 ^ -1334955251), new string[2]
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x35C0467B ^ 0x35C21867),
						(string)OmYS1BhsWb0wBI0xxv7p(-210725949 ^ -210551323)
					});
					num2 = 11;
					continue;
				case 42:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(0x269E5FCA ^ 0x269DEFFA), new string[2]
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(-542721635 ^ -542840959),
						(string)OmYS1BhsWb0wBI0xxv7p(-1979251663 ^ -1979405801)
					});
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 1;
					}
					continue;
				case 30:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(0x4EDCBA32 ^ 0x4EDF144C), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(-1088304168 ^ -1088186940),
						(string)OmYS1BhsWb0wBI0xxv7p(0x53CB464B ^ 0x53C8E86D)
					});
					num2 = 40;
					continue;
				case 16:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-867826612 ^ -867849554), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(-87337865 ^ -87487893),
						(string)OmYS1BhsWb0wBI0xxv7p(-542721635 ^ -542828613)
					});
					num2 = 39;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
					{
						num2 = 19;
					}
					continue;
				case 36:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(0x34185E55 ^ 0x341BEE73), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(--1418440330 ^ 0x5489F096),
						(string)OmYS1BhsWb0wBI0xxv7p(-1921202237 ^ -1921029659)
					});
					num2 = 42;
					continue;
				case 2:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-1751176224 ^ -1751349898), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(-1334993905 ^ -1334853101),
						(string)OmYS1BhsWb0wBI0xxv7p(-1822890472 ^ -1822734274)
					});
					num2 = 20;
					continue;
				case 39:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-234299632 ^ -234130974), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(0x53CB464B ^ 0x53C91857),
						(string)OmYS1BhsWb0wBI0xxv7p(-672123589 ^ -671900899)
					});
					num2 = 21;
					continue;
				case 5:
					dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-70037984 ^ -70042002), new string[10]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(-1108654032 ^ -1108797908),
						(string)OmYS1BhsWb0wBI0xxv7p(-882126494 ^ -882344124),
						(string)OmYS1BhsWb0wBI0xxv7p(-1751176224 ^ -1751349736),
						(string)OmYS1BhsWb0wBI0xxv7p(-675505729 ^ -675334409),
						(string)OmYS1BhsWb0wBI0xxv7p(0x48A7E34A ^ 0x48A44C12),
						(string)OmYS1BhsWb0wBI0xxv7p(0x7C1EE318 ^ 0x7C1D4C7E),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x49E27B8A ^ 0x49E1D4B0),
						(string)OmYS1BhsWb0wBI0xxv7p(-867826612 ^ -867849412),
						(string)OmYS1BhsWb0wBI0xxv7p(-1459557599 ^ -1459403615),
						(string)OmYS1BhsWb0wBI0xxv7p(0xD3DEF7E ^ 0xD3FB2B4)
					});
					num2 = 19;
					continue;
				case 43:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-35995181 ^ -36082071), new string[3]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(0x63ABA4E8 ^ 0x63A9FAF4),
						(string)OmYS1BhsWb0wBI0xxv7p(-889460160 ^ -889699226),
						(string)OmYS1BhsWb0wBI0xxv7p(0x53CB464B ^ 0x53C8E989)
					});
					num2 = 37;
					continue;
				case 12:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(0x2ACE37D ^ 0x2AF4C83), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(0x49E27B8A ^ 0x49E02596),
						(string)OmYS1BhsWb0wBI0xxv7p(0x463A0F3C ^ 0x4639A11A)
					});
					num2 = 13;
					continue;
				case 1:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-35995181 ^ -36031421), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(-2107978722 ^ -2108124670),
						(string)OmYS1BhsWb0wBI0xxv7p(-1867198571 ^ -1867030093)
					});
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 21;
					}
					continue;
				case 26:
					dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EDCBA32 ^ 0x4EDF148C), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(0x4EA5403C ^ 0x4EA71E20),
						(string)OmYS1BhsWb0wBI0xxv7p(-1852837372 ^ -1853072350)
					});
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
					{
						num2 = 0;
					}
					continue;
				case 11:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(0x4D1C1EE4 ^ 0x4D1FB1EE), new string[2]
					{
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0xE1229CF ^ 0xE1077D3),
						(string)OmYS1BhsWb0wBI0xxv7p(0x638095EB ^ 0x63833BCD)
					});
					num2 = 38;
					continue;
				case 15:
					dictionary.Add((string)OmYS1BhsWb0wBI0xxv7p(-672123589 ^ -671900683), new string[2]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(0x4EDCBA32 ^ 0x4EDEE42E),
						(string)OmYS1BhsWb0wBI0xxv7p(0x571EA399 ^ 0x571D0DBF)
					});
					num = 41;
					break;
				case 7:
					dictionary.Add(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459445139), new string[3]
					{
						(string)OmYS1BhsWb0wBI0xxv7p(0x1DE3DD89 ^ 0x1DE18395),
						z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7C1EE318 ^ 0x7C1D4D3E),
						(string)OmYS1BhsWb0wBI0xxv7p(-629844702 ^ -629736752)
					});
					num2 = 9;
					continue;
				}
				break;
			}
		}
	}

	internal static bool fbuJa4hsFJTQxHqQ1X2I()
	{
		return s3GcvfhUzRMGLQ09KOy2 == null;
	}

	internal static StringParseHelper TcJROIhsBi1jNPDa85Pj()
	{
		return s3GcvfhUzRMGLQ09KOy2;
	}

	internal static object OmYS1BhsWb0wBI0xxv7p(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object iDNdaMhsohWGX1PYICkc(object P_0, object P_1, StringSplitOptions P_2)
	{
		return ((string)P_0).Split((string[])P_1, P_2);
	}

	internal static int mSSgcyhsbhCf0jKTZ6lW(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static object tEd0SjhshjGCTHilhJlu(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static bool vouXmXhsG87uqHwuj55D(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object LcQ18PhsElJ3lwaMwDx6(object P_0, object P_1)
	{
		return ((string)P_0).Split((char[])P_1);
	}

	internal static object akJLOrhsfnAfcF3XxGe1(object P_0)
	{
		return ((HtmlDocument)P_0).get_DocumentNode();
	}

	internal static object LjeEd9hsQkpHbIsoMTKt(object P_0)
	{
		return ((HtmlNode)P_0).get_InnerHtml();
	}

	internal static object jy74wYhsCbommOGrOIIq()
	{
		return Logger.Log;
	}

	internal static object CeOM9YhsvRhD2xjEQx2A(object P_0)
	{
		return ((Exception)P_0).Message;
	}

	internal static object bYWaIrhs8ybmaEnDBMcG(object P_0)
	{
		return ((string)P_0).SanitizeHtml();
	}

	internal static object f6PCNHhsZ2UeFBQPKne4(object P_0)
	{
		return GetHtml(P_0);
	}

	internal static void feJs8whsuh9t0xPY4Nxm(object P_0, object P_1)
	{
		SetFullPathForImgNode(P_0, P_1);
	}

	internal static bool Fp85EphsI6mfnUbLgegG(object P_0)
	{
		return ((HtmlNode)P_0).get_HasAttributes();
	}

	internal static object Q4xKHfhsVt8tWWVVpK06(object P_0)
	{
		return ((HtmlNode)P_0).get_Attributes();
	}

	internal static object LHYuMThsS3j15OlfqXOL(object P_0)
	{
		return ((HtmlAttribute)P_0).get_Name();
	}

	internal static void gK9khehsiQG8rvIUDVO1(object P_0)
	{
		((HtmlAttribute)P_0).Remove();
	}

	internal static void X3HOKjhsRJMn5ynnRi4j(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static bool VgpdprhsqvulPRn6e8C6(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static bool xIybkZhsK92sDpReVW7P()
	{
		return Locator.Initialized;
	}

	internal static object vKugshhsXFeYleIpgm9H(object P_0)
	{
		return ((CommonSettings)P_0).ApplicationBaseUrl;
	}

	internal static void OxR86JhsTXowaotRQ0bO(object P_0, object P_1)
	{
		PrepareHtmlNodeHref(P_0, P_1);
	}

	internal static object SI77ZthskLeBds0sHEHE(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static HtmlNodeType CLAjxIhsnRXfsr5H4njl(object P_0)
	{
		//IL_0004: Unknown result type (might be due to invalid IL or missing references)
		return ((HtmlNode)P_0).get_NodeType();
	}

	internal static object mVdNFphsO4Ky0Gjj8ceE(object P_0)
	{
		return ((HtmlNode)P_0).get_Name();
	}

	internal static bool DXLKNEhs205cERRMeQsN(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).Equals((string)P_1, P_2);
	}

	internal static object NdIaMvhse3V7gaAxwgaq(object P_0)
	{
		return ((HtmlNode)P_0).get_InnerText();
	}

	internal static bool DeYoU5hsPc7CtthEI6oy(object P_0)
	{
		return ((string)P_0).IsNullOrWhiteSpace();
	}

	internal static object zqLX4ths1V4Pq5snKrsC(object P_0, object P_1, object P_2, RegexOptions P_3)
	{
		return Regex.Replace((string)P_0, (string)P_1, (MatchEvaluator)P_2, P_3);
	}

	internal static object v0L2quhsNl2NfUAIHrhN(object P_0)
	{
		return ((HtmlNode)P_0).get_ChildNodes();
	}

	internal static bool Urtrirhs3FU8G9CSnrBp(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool cfVbGZhspHpspjrsEoUR(object P_0, object P_1)
	{
		return ((HtmlAttributeCollection)P_0).Contains((string)P_1);
	}

	internal static object ymDkAshsagLZD2JneXiR(object P_0)
	{
		return ((HtmlAttribute)P_0).get_Value();
	}

	internal static int MGFNjBhsDD0Bh0vKJIod(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).IndexOf((string)P_1, P_2);
	}

	internal static void VThQDfhstJR02eJJLpF4(object P_0, object P_1)
	{
		((HtmlAttribute)P_0).set_Value((string)P_1);
	}

	internal static bool SflNjbhswwv0aFiiwSxW(object P_0)
	{
		return ((HtmlNode)P_0).get_HasChildNodes();
	}

	internal static object yNAr3Dhs4EyCHohstmGq(object P_0)
	{
		return ((HtmlNode)P_0).get_ParentNode();
	}

	internal static void XFmeMnhs6F1ALE6tGdW6(object P_0, object P_1, object P_2)
	{
		GetChildren(P_0, P_1, P_2);
	}

	internal static object PZP6PPhsHLVhVkq8YiLR(object P_0, object P_1)
	{
		return ((HtmlNode)P_0).RemoveChild((HtmlNode)P_1);
	}

	internal static int vswwpehsAl7ktWvyFHwQ(object P_0)
	{
		return ((HtmlNodeCollection)P_0).get_Count();
	}

	internal static void xdq3ephs7BsRMrFe3LNK(object P_0, object P_1)
	{
		CleanNodes(P_0, P_1);
	}

	internal static void gSN5oDhsxjUieTL6grJa(object P_0, object P_1)
	{
		((HtmlNodeCollection)P_0).Append((HtmlNode)P_1);
	}

	internal static object PLTpKnhs0PcpYCaEAIDb(object P_0, int P_1)
	{
		return ((HtmlNodeCollection)P_0).get_Item(P_1);
	}

	internal static void P9LjIEhsmIdxAmnVNNhK(object P_0, object P_1, object P_2)
	{
		GetNodes(P_0, P_1, P_2);
	}

	internal static object MVWAK2hsyrlKGlkKqoQq()
	{
		return Encoding.UTF8;
	}

	internal static void cYQSdchsM1KN6WadIebv(object P_0, object P_1)
	{
		((HtmlDocument)P_0).LoadHtml((string)P_1);
	}

	internal static object VamJLVhsJmuN9i7f2EmG(object P_0)
	{
		return ((Capture)P_0).Value;
	}

	internal static object LxD5Rmhs9TFVuuc93unF(object P_0, int repetitionsCount)
	{
		return ((string)P_0).Repeat(repetitionsCount);
	}
}
