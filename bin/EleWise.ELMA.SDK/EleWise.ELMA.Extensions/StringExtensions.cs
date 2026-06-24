using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using EleWise.ELMA.Helpers;
using EleWise.ELMA.Memory;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions;

public static class StringExtensions
{
	private static readonly string[] LineSeparators;

	private static readonly Dictionary<string, string> translitChars;

	private static StringExtensions nIdOo9G7Tiv0eZyQJCSV;

	public static string Nl2Br(this string s)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return ((string)OgMe8bG72xJXKcp2X0Rb(s.Replace((string)VJH5sNG7OhRtAcr1FyMa(), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x20261A4F ^ 0x20221D19)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-576149596 ^ -576145060), "")).Replace((string)AVOdFaG7eNJHjjZ89SgL(-345420348 ^ -345419168), (string)AVOdFaG7eNJHjjZ89SgL(0x34185E55 ^ 0x341C5903));
			case 1:
				if (s == null)
				{
					return null;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string Br2Nl(this string s)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)W5vSGDG7PhO3QaPdlqcG(s, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1765851862 ^ -1766114740), VJH5sNG7OhRtAcr1FyMa(), RegexOptions.IgnoreCase);
			case 1:
				if (s == null)
				{
					return null;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3cbb4f9dc1e844f0a4175fa6bf196a02 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string HtmlEncode(this string s)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (string.IsNullOrEmpty(s))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca == 0)
					{
						num2 = 0;
					}
					break;
				}
				return HttpUtility.HtmlEncode(s);
			default:
				return string.Empty;
			}
		}
	}

	public static string HtmlDecode(this string s)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (WvgFDkG71kseC6o8colV(s))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
				return (string)OuKAxfG7Nn1gDqLVlXy4(s);
			case 1:
				return string.Empty;
			}
		}
	}

	public static bool IsNullOrEmpty(this string s)
	{
		return WvgFDkG71kseC6o8colV(s);
	}

	public static bool IsNullOrWhiteSpace(this string s)
	{
		return ULHSZCG73UUNdqQK5KPy(s);
	}

	public static string ToTranslitIdent(this string s, string prefix = null, int maxLength = 0)
	{
		//Discarded unreachable code: IL_014e, IL_015d, IL_016d, IL_018f, IL_0199, IL_01cc, IL_01db, IL_024e, IL_025d, IL_026d, IL_027c, IL_02ad, IL_035b, IL_036a, IL_03be, IL_04ac, IL_0534, IL_053e, IL_0584, IL_0593
		int num = 28;
		int num4 = default(int);
		char[] array = default(char[]);
		bool flag = default(bool);
		bool flag2 = default(bool);
		StringBuilder stringBuilder = default(StringBuilder);
		bool flag3 = default(bool);
		char c2 = default(char);
		string text = default(string);
		string text2 = default(string);
		string value = default(string);
		char c = default(char);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num5;
				int num3;
				object obj;
				switch (num2)
				{
				case 15:
				case 33:
					if (num4 < array.Length)
					{
						num2 = 2;
						continue;
					}
					goto case 32;
				case 20:
					if (flag && flag2)
					{
						num2 = 16;
						continue;
					}
					goto case 6;
				case 29:
					stringBuilder.Append(prefix);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
					{
						num2 = 0;
					}
					continue;
				case 36:
				case 44:
					flag3 = true;
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 47;
					}
					continue;
				case 12:
				case 13:
					flag3 = true;
					num2 = 8;
					continue;
				case 23:
				case 37:
					num5 = ((c2 == '_') ? 1 : 0);
					goto IL_05dc;
				case 31:
					num4++;
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 15;
					}
					continue;
				case 7:
					if (text.Length > 0)
					{
						num2 = 17;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 == 0)
						{
							num2 = 35;
						}
						continue;
					}
					goto case 46;
				case 17:
					flag3 = text2.ToUpper().Equals(c2.ToString());
					num2 = 18;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
					{
						num2 = 15;
					}
					continue;
				default:
					flag = false;
					num2 = 12;
					continue;
				case 2:
				case 11:
					c2 = array[num4];
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 1;
					}
					continue;
				case 43:
					if (string.IsNullOrEmpty(prefix))
					{
						num2 = 13;
						continue;
					}
					goto case 29;
				case 1:
				case 26:
					if (flag3)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 46;
				case 27:
					array = (char[])cxvBCQG7pNejTZcNhC21(s);
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 40;
					}
					continue;
				case 5:
				case 22:
					if (!translitChars.TryGetValue(text2, out value))
					{
						num = 44;
						break;
					}
					goto case 45;
				case 24:
					if (c2 >= '0')
					{
						num2 = 14;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
						{
							num2 = 8;
						}
						continue;
					}
					num3 = 0;
					goto IL_05cf;
				case 10:
					flag3 = false;
					num2 = 31;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 14;
					}
					continue;
				case 46:
					uUmXYAG74Yqd2K1UUw7X(stringBuilder, text);
					num2 = 3;
					continue;
				case 30:
					if (c2 > 'Z')
					{
						num2 = 23;
						continue;
					}
					goto IL_05db;
				case 42:
					if (maxLength <= 0)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 34;
				case 38:
					if (flag3)
					{
						num2 = 33;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 != 0)
						{
							num2 = 39;
						}
						continue;
					}
					goto case 17;
				case 4:
					text2 = c2.ToString().ToLower();
					num2 = 41;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 31;
					}
					continue;
				case 48:
					if (c2 >= 'a')
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 != 0)
						{
							num2 = 21;
						}
						continue;
					}
					goto case 9;
				case 41:
					text = null;
					num2 = 24;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
					{
						num2 = 5;
					}
					continue;
				case 9:
					if (c2 < 'A')
					{
						num2 = 37;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
						{
							num2 = 35;
						}
						continue;
					}
					goto case 30;
				case 3:
					flag = false;
					num2 = 10;
					continue;
				case 6:
					obj = "";
					goto IL_060e;
				case 18:
				case 19:
				case 39:
				case 47:
					if (text != null)
					{
						num2 = 42;
						continue;
					}
					goto case 31;
				case 35:
					c = HfVCJLG7tivFO2BJ4HrC(text, 0);
					num2 = 25;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b == 0)
					{
						num2 = 4;
					}
					continue;
				case 34:
					if (stringBuilder.Length + NUjnTgG7DfQIryEBbioj(text) <= maxLength)
					{
						num = 26;
						break;
					}
					goto case 32;
				case 40:
					flag = true;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 43;
					}
					continue;
				case 14:
					num3 = ((c2 <= '9') ? 1 : 0);
					goto IL_05cf;
				case 32:
					return stringBuilder.ToString();
				case 28:
					stringBuilder = new StringBuilder();
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
					{
						num2 = 10;
					}
					continue;
				case 45:
					text = value;
					num2 = 38;
					continue;
				case 21:
					if (c2 > 'z')
					{
						num2 = 9;
						continue;
					}
					goto IL_05db;
				case 8:
					num4 = 0;
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
					{
						num2 = 33;
					}
					continue;
				case 16:
					obj = AVOdFaG7eNJHjjZ89SgL(-87337865 ^ -87336947);
					goto IL_060e;
				case 25:
					{
						text = (string)Kgk8MlG7aPufrVOxNuUV(c.ToString().ToUpper(), (NUjnTgG7DfQIryEBbioj(text) > 1) ? Kw41c0G7w9N2gu3k4JRk(text, 1) : string.Empty);
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 46;
						}
						continue;
					}
					IL_05cf:
					flag2 = (byte)num3 != 0;
					num2 = 48;
					continue;
					IL_05dc:
					if (((uint)num5 | (flag2 ? 1u : 0u)) == 0)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 22;
						}
						continue;
					}
					goto case 20;
					IL_060e:
					text = (string)Kgk8MlG7aPufrVOxNuUV(obj, c2.ToString());
					num2 = 19;
					continue;
					IL_05db:
					num5 = 1;
					goto IL_05dc;
				}
				break;
			}
		}
	}

	public static string ToLowerFirstChar(this string s)
	{
		int num = 2;
		int num2 = num;
		char c = default(char);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return string.Empty;
			case 2:
				if (!s.IsNullOrEmpty())
				{
					c = nqBa36G76svkE31SOuwl(HfVCJLG7tivFO2BJ4HrC(s, 0));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
					{
						num2 = 1;
					}
				}
				break;
			default:
				return (string)Kgk8MlG7aPufrVOxNuUV(c.ToString(), Kw41c0G7w9N2gu3k4JRk(s, 1));
			}
		}
	}

	public static string ToUpperFirstChar(this string s)
	{
		//Discarded unreachable code: IL_0045
		int num = 1;
		int num2 = num;
		char c = default(char);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return (string)Kgk8MlG7aPufrVOxNuUV(c.ToString(), Kw41c0G7w9N2gu3k4JRk(s, 1));
			case 3:
				return string.Empty;
			default:
				c = gCqGI8G7HP9x8ZnJaC1e(s[0]);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (!s.IsNullOrEmpty())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			}
		}
	}

	public static string ToTranslit(this string s)
	{
		//Discarded unreachable code: IL_003e, IL_004d, IL_0058, IL_00fb, IL_010e, IL_011d, IL_019f
		int num = 5;
		Dictionary<string, string>.Enumerator enumerator = default(Dictionary<string, string>.Enumerator);
		KeyValuePair<string, string> current = default(KeyValuePair<string, string>);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					try
					{
						while (true)
						{
							IL_0089:
							int num3;
							if (!enumerator.MoveNext())
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
								{
									num3 = 0;
								}
								goto IL_005c;
							}
							goto IL_0076;
							IL_0076:
							current = enumerator.Current;
							num3 = 2;
							goto IL_005c;
							IL_005c:
							while (true)
							{
								switch (num3)
								{
								case 1:
									goto IL_0076;
								case 3:
									goto IL_0089;
								case 2:
									s = s.Replace(current.Key, current.Value);
									num3 = 3;
									continue;
								case 0:
									break;
								}
								break;
							}
							break;
						}
					}
					finally
					{
						((IDisposable)enumerator).Dispose();
						int num4 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num4 = 0;
						}
						switch (num4)
						{
						case 0:
							break;
						}
					}
					goto case 2;
				case 5:
					if (ikVDenG7AsccogMHcvpQ(s))
					{
						num2 = 4;
						break;
					}
					enumerator = translitChars.GetEnumerator();
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 4;
					}
					break;
				default:
					s = (string)S0wpsBG77n26cHipl4iy(s, 0, AVOdFaG7eNJHjjZ89SgL(0xD3DEF7E ^ 0xD3DE304));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					if (HfVCJLG7tivFO2BJ4HrC(s, 0) >= '0')
					{
						goto end_IL_0012;
					}
					goto case 1;
				case 3:
					if (HfVCJLG7tivFO2BJ4HrC(s, 0) <= '9')
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 1;
				case 4:
					return s;
				case 1:
					return (string)OgMe8bG72xJXKcp2X0Rb(s, AVOdFaG7eNJHjjZ89SgL(-541731959 ^ -541746517), "");
				}
				continue;
				end_IL_0012:
				break;
			}
			num = 3;
		}
	}

	public static bool IsValidIdentifier(this string s)
	{
		return GqrS8mG7xwLD7A58oV56(s, AVOdFaG7eNJHjjZ89SgL(-1822890472 ^ -1822629478));
	}

	public static string ToHexString(this byte[] bytes)
	{
		return (string)OgMe8bG72xJXKcp2X0Rb(xwnAlkG70DeUBaeTlMvJ(bytes), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099750597), "");
	}

	public static byte[] HexStringToByteArray(this string inputHex)
	{
		//Discarded unreachable code: IL_00b3
		int num = 2;
		int num2 = num;
		int num3 = default(int);
		byte[] array = default(byte[]);
		while (true)
		{
			switch (num2)
			{
			case 5:
			case 6:
				if (num3 >= array.Length)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			case 1:
				num3 = 0;
				num2 = 6;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 != 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				array[num3] = vkNvtUG7yFMZw6QcH87W(z9YxotG7mFkVExOMcRtH(inputHex, num3 * 2, 2), 16);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
				{
					num2 = 3;
				}
				break;
			default:
				return array;
			case 2:
				array = new byte[NUjnTgG7DfQIryEBbioj(inputHex) / 2];
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				num3++;
				num2 = 5;
				break;
			}
		}
	}

	public static string ValueOrDefault(this string value, string defaultValue, string format = "{0}")
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (!value.IsNullOrEmpty())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 0;
					}
					break;
				}
				return defaultValue;
			default:
				return format.FormatWith(value);
			}
		}
	}

	public static string ValueOrDefaultWhiteSpace(this string value, string defaultValue, string format = "{0}")
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				return format.FormatWith(value);
			default:
				return defaultValue;
			case 1:
				if (o0oH4qG7MaZVEQnmsRTl(value))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			}
		}
	}

	public static string Trunk(this string s, int length, string suffix)
	{
		//Discarded unreachable code: IL_0035, IL_0044, IL_0074, IL_0083
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (s != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 4:
				return s.Substring(0, length) + suffix;
			case 3:
				return s;
			case 2:
				return string.Empty;
			default:
				if (NUjnTgG7DfQIryEBbioj(s) <= length)
				{
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public static string Truncate(this string input, int startLength, int endLength)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (startLength + endLength + 3 >= input.Length)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return (string)aP6iCgG79wqx5qVDw8wn(input.Remove(startLength), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7EC153F ^ 0x7E81D7D), Kw41c0G7w9N2gu3k4JRk(input, NUjnTgG7DfQIryEBbioj(input) - endLength));
			case 3:
				Contract.ArgumentNotNull(input, (string)AVOdFaG7eNJHjjZ89SgL(0x6A81B9B4 ^ 0x6A85BE02));
				num2 = 2;
				break;
			case 2:
				iCgIH6G7JesJySkXNReA(startLength >= 0, AVOdFaG7eNJHjjZ89SgL(0x53CB464B ^ 0x53CF418F));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 1;
				}
				break;
			case 1:
				iCgIH6G7JesJySkXNReA(endLength >= 0, AVOdFaG7eNJHjjZ89SgL(0x1FFEF86A ^ 0x1FFAFF82));
				num2 = 5;
				break;
			case 5:
				Contract.CheckArgument(startLength + endLength > 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4EA5403C ^ 0x4EA14834));
				num2 = 4;
				break;
			default:
				return input;
			}
		}
	}

	public static string Truncate(this string input, int startLength, int endLength, int maxLength)
	{
		//Discarded unreachable code: IL_0093, IL_00a2
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 6:
					if (NUjnTgG7DfQIryEBbioj(input) <= maxLength)
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num2 = 2;
						}
						continue;
					}
					goto case 1;
				case 5:
					iCgIH6G7JesJySkXNReA(maxLength >= 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633254375));
					num2 = 6;
					continue;
				case 4:
					XN9jNfG7djrF1996O6pI(input, AVOdFaG7eNJHjjZ89SgL(0x3A5D5EF ^ 0x3A1D259));
					num2 = 3;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					break;
				default:
					Contract.CheckArgument(startLength + endLength > 0, (string)AVOdFaG7eNJHjjZ89SgL(0x63ABA4E8 ^ 0x63AFACE0));
					num2 = 5;
					continue;
				case 2:
					iCgIH6G7JesJySkXNReA(endLength >= 0, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1939377524 ^ -1939638940));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					return (string)xgwJmpG7ldtcXTG5oDlP(input, startLength, endLength);
				case 7:
					return input;
				}
				break;
			}
			Contract.CheckArgument(startLength >= 0, (string)AVOdFaG7eNJHjjZ89SgL(0x34A6D230 ^ 0x34A2D5F4));
			num = 2;
		}
	}

	public static Guid GetDeterministicGuid(this string input)
	{
		return v4IEJfG7rZALoX34LnlR(input, Encoding.UTF8);
	}

	public static Guid GetDeterministicGuid(this string input, Encoding encoding)
	{
		//Discarded unreachable code: IL_0057, IL_00d5, IL_00e8
		int num = 2;
		int num2 = num;
		MD5CryptoServiceProvider mD5CryptoServiceProvider = default(MD5CryptoServiceProvider);
		Guid result = default(Guid);
		while (true)
		{
			switch (num2)
			{
			case 3:
				try
				{
					mD5CryptoServiceProvider = EncryptionHelper.Md5CryptoServiceProviderPool.Get();
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num3 = 0;
					}
					while (true)
					{
						switch (num3)
						{
						case 1:
							return result;
						}
						result = MemoryHelper.ActionWithMemoryBuffer<byte, (MD5CryptoServiceProvider, Encoding, string), Guid>(encoding.GetByteCount(input), (mD5CryptoServiceProvider, encoding, input), GetDeterministicGuidAction);
						num3 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
						{
							num3 = 0;
						}
					}
				}
				finally
				{
					EncryptionHelper.Md5CryptoServiceProviderPool.Return(mD5CryptoServiceProvider);
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
			default:
				throw new ArgumentNullException((string)AVOdFaG7eNJHjjZ89SgL(0xE1229CF ^ 0xE131745));
			case 2:
				if (input == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
					{
						num2 = 0;
					}
				}
				else if (encoding != null)
				{
					mD5CryptoServiceProvider = null;
					num2 = 3;
				}
				else
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 0;
					}
				}
				break;
			case 1:
				throw new ArgumentNullException((string)AVOdFaG7eNJHjjZ89SgL(-195614443 ^ -195875165));
			case 4:
				return result;
			}
		}
	}

	private static Guid GetDeterministicGuidAction(object buffer, int offset, int length, (MD5CryptoServiceProvider, Encoding, string) param)
	{
		var (mD5CryptoServiceProvider, encoding, text) = param;
		encoding.GetBytes(text, 0, text.Length, (byte[])buffer, offset);
		return new Guid(mD5CryptoServiceProvider.ComputeHash((byte[])buffer, offset, length));
	}

	public static string GetSHA1Base64Hash(this string s)
	{
		//Discarded unreachable code: IL_00a4, IL_00dc, IL_00fb, IL_010a, IL_0137, IL_0146
		int num = 2;
		int num2 = num;
		SHA1 sHA = default(SHA1);
		string result = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				throw new ArgumentNullException((string)AVOdFaG7eNJHjjZ89SgL(-1317790512 ^ -1317689674));
			case 3:
				return result;
			case 2:
				if (s != null)
				{
					sHA = (SHA1)WVPODCG7gukwIWCFAvXV();
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
					{
						num2 = 0;
					}
				}
				else
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ba8376385de74edd8ca4e978608be085 != 0)
					{
						num2 = 1;
					}
				}
				continue;
			}
			try
			{
				result = MemoryHelper.ActionWithMemoryBuffer<byte, (SHA1, string), string>(((Encoding)ebm4RJG75Oj9diIko3Y5()).GetByteCount(s), (sHA, s), GetSHA1Base64HashAction);
				int num3 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
				{
					num3 = 0;
				}
				return num3 switch
				{
					0 => result, 
					_ => result, 
				};
			}
			finally
			{
				int num4;
				if (sHA == null)
				{
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num4 = 0;
					}
					goto IL_00e0;
				}
				goto IL_0115;
				IL_0115:
				lxWbpjG7j7tV0bQtdRMw(sHA);
				num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num4 = 0;
				}
				goto IL_00e0;
				IL_00e0:
				switch (num4)
				{
				default:
					goto end_IL_00bb;
				case 1:
					goto end_IL_00bb;
				case 2:
					break;
				case 0:
					goto end_IL_00bb;
				}
				goto IL_0115;
				end_IL_00bb:;
			}
		}
	}

	private static string GetSHA1Base64HashAction(object buffer, int offset, int length, (SHA1, string) param)
	{
		var (sHA, text) = param;
		Encoding.UTF8.GetBytes(text, 0, text.Length, (byte[])buffer, offset);
		return Convert.ToBase64String(sHA.ComputeHash((byte[])buffer, offset, length));
	}

	public static string Base64StringToValidFileName(this string s)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (s != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				throw new ArgumentNullException((string)AVOdFaG7eNJHjjZ89SgL(-957824448 ^ -957777882));
			default:
				return (string)R6B71VG7YSTOyqRMnZMQ(s, '/', '#');
			}
		}
	}

	public static string Base64StringFromValidFileName(this string s)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				if (s != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 2;
			case 2:
				throw new ArgumentNullException((string)AVOdFaG7eNJHjjZ89SgL(-643786247 ^ -643751009));
			default:
				return (string)R6B71VG7YSTOyqRMnZMQ(s, '#', '/');
			}
		}
	}

	public static string FormatWith(this string format, params object[] args)
	{
		return (string)qgKAwfG7LhFaieKnmOnc(format, args);
	}

	public static string FormatWith(this string format, IFormatProvider provider, params object[] args)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				XN9jNfG7djrF1996O6pI(format, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309375024));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 0;
				}
				break;
			default:
				return (string)y4IgPtG7U2EFSe7lu0bn(provider, format, args);
			}
		}
	}

	public static bool IsNullOrEmpty(this string str, bool ignoreWhiteSpace)
	{
		//Discarded unreachable code: IL_002e, IL_0038, IL_0047
		int num = 1;
		int num2 = num;
		object obj;
		while (true)
		{
			switch (num2)
			{
			case 2:
				obj = str;
				break;
			case 1:
				if (ignoreWhiteSpace)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				goto case 2;
			default:
				obj = SDg8t2G7stb8D9VW2xMh(str);
				break;
			}
			break;
		}
		return WvgFDkG71kseC6o8colV(obj);
	}

	public static string Repeat(this string stringToRepeat, int repetitionsCount)
	{
		//Discarded unreachable code: IL_006e, IL_007d, IL_008d, IL_009c
		int num = 1;
		int num2 = num;
		int num3 = default(int);
		StringBuilder stringBuilder = default(StringBuilder);
		while (true)
		{
			switch (num2)
			{
			default:
				num3 = 0;
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 != 0)
				{
					num2 = 1;
				}
				break;
			case 4:
				num3++;
				num2 = 7;
				break;
			case 6:
				return stringBuilder.ToString();
			case 3:
			case 7:
				if (num3 < repetitionsCount)
				{
					num2 = 5;
					break;
				}
				goto case 6;
			case 1:
				stringBuilder = new StringBuilder();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
			case 5:
				uUmXYAG74Yqd2K1UUw7X(stringBuilder, stringToRepeat);
				num2 = 4;
				break;
			}
		}
	}

	public static string Between(this string str, string from, string to = null)
	{
		//Discarded unreachable code: IL_0045, IL_0055
		int num = 2;
		int num3 = default(int);
		int num5 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				int num4;
				switch (num2)
				{
				case 3:
					num4 = R9VQH9G7cYTVT8KvFJMa(str, to, StringComparison.InvariantCultureIgnoreCase);
					break;
				case 5:
					num4 = NUjnTgG7DfQIryEBbioj(str);
					break;
				case 2:
					num3 = R9VQH9G7cYTVT8KvFJMa(str, from, StringComparison.InvariantCultureIgnoreCase);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 != 0)
					{
						num2 = 0;
					}
					continue;
				default:
					if (num5 == -1)
					{
						num2 = 4;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
						{
							num2 = 6;
						}
						continue;
					}
					return (string)z9YxotG7mFkVExOMcRtH(str, 0, num5);
				case 6:
					return null;
				case 4:
					if (num3 != -1)
					{
						return (string)z9YxotG7mFkVExOMcRtH(str, num3 + NUjnTgG7DfQIryEBbioj(from), num5 - num3 - NUjnTgG7DfQIryEBbioj(from));
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (to == null)
					{
						goto end_IL_0012;
					}
					if (num3 == -1)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
						{
							num2 = 3;
						}
						continue;
					}
					num4 = R51ebQG7ztcEBO4H6Yv4(str, to, num3 + NUjnTgG7DfQIryEBbioj(from), StringComparison.InvariantCultureIgnoreCase);
					break;
				}
				num5 = num4;
				num2 = 4;
				continue;
				end_IL_0012:
				break;
			}
			num = 5;
		}
	}

	public static bool SlowEquals(this string str1, string str2)
	{
		return KgL8JTGxWXjx8AY1i4EZ(lW9eduGxBa2P74YkV7jR(hm6FtnGxFZNtuAL5nmfP(), str1), lW9eduGxBa2P74YkV7jR(hm6FtnGxFZNtuAL5nmfP(), str2));
	}

	public static string Quote(this string str, char quote = '"')
	{
		return (string)lrHmLmGxo0WnsUSDG6Vt(quote, str, quote);
	}

	public static string Escape(this string str, char escapeChar = '"')
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)OgMe8bG72xJXKcp2X0Rb(str, escapeChar.ToString(), text);
			case 1:
				text = new string(escapeChar, 2);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string RemoveLineBreaks(this string str)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return null;
			case 1:
				return ((string)OgMe8bG72xJXKcp2X0Rb(str, AVOdFaG7eNJHjjZ89SgL(0x637E299B ^ 0x637E3763), "")).Replace((string)AVOdFaG7eNJHjjZ89SgL(-420743386 ^ -420747134), "");
			case 2:
				if (str != null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 != 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			}
		}
	}

	public static string ReplaceAt(this string str, int index, int length, string replace)
	{
		return ((string)pT7BPaGxhokncVkFUSfY(str, index, C44dEPGxbNUQEWAZFNZh(length, NUjnTgG7DfQIryEBbioj(str) - index))).Insert(index, replace);
	}

	public static string ReplaceInvalidFileNameChars(this string fileName)
	{
		int num = 2;
		int num2 = num;
		char[] array = default(char[]);
		while (true)
		{
			switch (num2)
			{
			case 2:
				XN9jNfG7djrF1996O6pI(fileName, AVOdFaG7eNJHjjZ89SgL(-1088304168 ^ -1088309822));
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				return string.Join((string)AVOdFaG7eNJHjjZ89SgL(-2138160520 ^ -2138157566), fileName.Split(array));
			case 1:
				array = (char[])MO1rs4GxGNBJHe2unXhV();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				array.Union((IEnumerable<char>)HsnTJWGxEZVunWD3q0e1());
				num2 = 3;
				break;
			}
		}
	}

	public static string ReplaceControlCharacters(this string input)
	{
		//Discarded unreachable code: IL_00d0, IL_00df, IL_00ef, IL_017b
		int num = 11;
		int num2 = num;
		StringBuilder stringBuilder = default(StringBuilder);
		string text = default(string);
		char c = default(char);
		int num3 = default(int);
		while (true)
		{
			switch (num2)
			{
			case 7:
				return stringBuilder.ToString();
			case 8:
				text = input;
				num2 = 4;
				break;
			case 1:
			case 9:
				c = HfVCJLG7tivFO2BJ4HrC(text, num3);
				num2 = 5;
				break;
			case 4:
				num3 = 0;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b != 0)
				{
					num2 = 1;
				}
				break;
			case 11:
				XN9jNfG7djrF1996O6pI(input, AVOdFaG7eNJHjjZ89SgL(-1852837372 ^ -1853098574));
				num2 = 10;
				break;
			default:
				num3++;
				num2 = 12;
				break;
			case 2:
			case 12:
				if (num3 < NUjnTgG7DfQIryEBbioj(text))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_519b81e595914ca5bc2f01b5d105756b == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 7;
			case 10:
				stringBuilder = new StringBuilder(NUjnTgG7DfQIryEBbioj(input));
				num2 = 8;
				break;
			case 5:
				if (char.IsControl(c))
				{
					num2 = 13;
					break;
				}
				goto case 6;
			case 6:
				nGm2fFGxfIWDDUHueDQa(stringBuilder, c);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_5eb77e1c8c9e4e409fbcb8dc678c71cd == 0)
				{
					num2 = 0;
				}
				break;
			case 13:
				stringBuilder.Append('_');
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6eae077feeaa49a496965fa87ef2cd18 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string ToBase64String(this string value, Encoding encoding = null)
	{
		int num = 5;
		int num2 = num;
		int num3 = default(int);
		while (true)
		{
			Encoding encoding2;
			switch (num2)
			{
			default:
				num3 = YuK2xeGxQuxtAXhWMQN1(encoding, value);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 1;
				}
				continue;
			case 5:
				XN9jNfG7djrF1996O6pI(value, AVOdFaG7eNJHjjZ89SgL(-35995181 ^ -36009819));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 4;
				}
				continue;
			case 1:
				return MemoryHelper.ActionWithMemoryBuffer<byte, (string, Encoding), string>(num3, (value, encoding), ToBase64StringAction);
			case 3:
				if (num3 == 0)
				{
					return string.Empty;
				}
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2a96f340091d4c458989d123a12a8553 != 0)
				{
					num2 = 1;
				}
				continue;
			case 4:
				encoding2 = encoding;
				if (encoding2 != null)
				{
					break;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 2;
				}
				continue;
			case 2:
				encoding2 = Encoding.UTF8;
				break;
			}
			encoding = encoding2;
			num2 = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
			{
				num2 = 0;
			}
		}
	}

	private static string ToBase64StringAction(object buffer, int offset, int length, (string, Encoding) param)
	{
		(string, Encoding) tuple = param;
		var (text, _) = tuple;
		tuple.Item2.GetBytes(text, 0, text.Length, (byte[])buffer, offset);
		return Convert.ToBase64String((byte[])buffer, offset, length);
	}

	public static string[] SplitToLines(this string value)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return value.Split(LineSeparators, StringSplitOptions.RemoveEmptyEntries);
			case 1:
				XN9jNfG7djrF1996O6pI(value, AVOdFaG7eNJHjjZ89SgL(0x5A4C7B29 ^ 0x5A4C325F));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	static StringExtensions()
	{
		int num = 6;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 15:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-629844702 ^ -630104922)] = (string)AVOdFaG7eNJHjjZ89SgL(0x12A5FAC7 ^ 0x12A572EF);
					num2 = 30;
					continue;
				case 18:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-138018305 ^ -138278911)] = (string)AVOdFaG7eNJHjjZ89SgL(0x269E5FCA ^ 0x269A55CE);
					num2 = 9;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
					{
						num2 = 31;
					}
					continue;
				case 69:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-951514650 ^ -951254976)] = (string)AVOdFaG7eNJHjjZ89SgL(-561074844 ^ -561104296);
					num2 = 14;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
					{
						num2 = 11;
					}
					continue;
				case 68:
					translitChars = new Dictionary<string, string>();
					num2 = 27;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
					{
						num2 = 27;
					}
					continue;
				case 45:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-138018305 ^ -138277929)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2A7797B7 ^ 0x2A739D99);
					num2 = 49;
					continue;
				case 60:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2A8EA6B)] = (string)AVOdFaG7eNJHjjZ89SgL(-1123633026 ^ -1123614184);
					num2 = 19;
					continue;
				case 13:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1852837372 ^ -1853097898)] = (string)AVOdFaG7eNJHjjZ89SgL(0x103FE975 ^ 0x103BE32D);
					num2 = 21;
					continue;
				case 56:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1978478350 ^ -1978213748)] = (string)AVOdFaG7eNJHjjZ89SgL(0x31326106 ^ 0x31366B82);
					num2 = 57;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7a9d00e390be4869a3d6f6b8b460f724 == 0)
					{
						num2 = 20;
					}
					continue;
				case 27:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-1123633026 ^ -1123897342)] = (string)AVOdFaG7eNJHjjZ89SgL(0x12A5FAC7 ^ 0x12A7314D);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e != 0)
					{
						num2 = 41;
					}
					continue;
				case 34:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-1978478350 ^ -1978214400)] = (string)AVOdFaG7eNJHjjZ89SgL(0x637E299B ^ 0x637C5335);
					num2 = 61;
					continue;
				case 24:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x4785BC0D ^ 0x4781B4D7)] = (string)AVOdFaG7eNJHjjZ89SgL(-740338220 ^ -740598476);
					num = 42;
					break;
				case 5:
					LineSeparators = new string[3]
					{
						(string)AVOdFaG7eNJHjjZ89SgL(0xE1229CF ^ 0xE124AF1),
						(string)AVOdFaG7eNJHjjZ89SgL(0x307E9FD1 ^ 0x307E8129),
						(string)AVOdFaG7eNJHjjZ89SgL(0x34185E55 ^ 0x341841F1)
					};
					num2 = 68;
					continue;
				case 30:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-309639236 ^ -309375434)] = (string)AVOdFaG7eNJHjjZ89SgL(-1108654032 ^ -1108393568);
					num2 = 4;
					continue;
				case 42:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-951514650 ^ -951254784)] = (string)AVOdFaG7eNJHjjZ89SgL(-477139494 ^ -477403850);
					num2 = 34;
					continue;
				case 20:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x638095EB ^ 0x6380DAB5)] = (string)AVOdFaG7eNJHjjZ89SgL(0x17ADCCD8 ^ 0x17AF321E);
					num2 = 63;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
					{
						num2 = 8;
					}
					continue;
				case 65:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099487185)] = (string)AVOdFaG7eNJHjjZ89SgL(0x5A4C7B29 ^ 0x5A4FD397);
					num = 22;
					break;
				case 58:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x4A1640F ^ 0x4A56E43)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-675505729 ^ -675289047);
					num = 13;
					break;
				case 12:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-1426094279 ^ -1426354917)] = (string)AVOdFaG7eNJHjjZ89SgL(-542721635 ^ -542717549);
					num2 = 45;
					continue;
				default:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x3B36AB09 ^ 0x3B32A221)] = (string)AVOdFaG7eNJHjjZ89SgL(-87337865 ^ -87073447);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 13;
					}
					continue;
				case 53:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x35C0467B ^ 0x35C44EDD)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-606654180 ^ -606914128);
					num2 = 32;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
					{
						num2 = 6;
					}
					continue;
				case 48:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x68BBB53E ^ 0x68BFBDFC)] = (string)AVOdFaG7eNJHjjZ89SgL(0x68BBB53E ^ 0x68BFBDF6);
					num2 = 36;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba != 0)
					{
						num2 = 14;
					}
					continue;
				case 11:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x31326106 ^ 0x31366B9A)] = (string)AVOdFaG7eNJHjjZ89SgL(-1146510045 ^ -1146245247);
					num2 = 64;
					continue;
				case 63:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-957824448 ^ -957559880)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x1DE3DD89 ^ 0x1DE0754D);
					num2 = 18;
					continue;
				case 50:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x34A6D230 ^ 0x34A2DBDC)] = (string)AVOdFaG7eNJHjjZ89SgL(-281842504 ^ -281582262);
					num2 = 20;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
					{
						num2 = 2;
					}
					continue;
				case 59:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-576149596 ^ -575885708)] = (string)AVOdFaG7eNJHjjZ89SgL(-951514650 ^ -951254992);
					num2 = 43;
					continue;
				case 33:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x68BBB53E ^ 0x68BFBF8A)] = (string)AVOdFaG7eNJHjjZ89SgL(0x307E9FD1 ^ 0x307A9C33);
					num2 = 62;
					continue;
				case 43:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-97972138 ^ -97707640)] = (string)AVOdFaG7eNJHjjZ89SgL(-1886646897 ^ -1886911381);
					num2 = 50;
					continue;
				case 67:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x7247028A ^ 0x724795C8)] = (string)AVOdFaG7eNJHjjZ89SgL(-1334993905 ^ -1335030963);
					num2 = 69;
					continue;
				case 29:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-740338220 ^ -740598412)] = (string)AVOdFaG7eNJHjjZ89SgL(0x637E299B ^ 0x637EA1B3);
					num2 = 53;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_56cefd1d8a5a4818af5d80db38eaa0f3 != 0)
					{
						num2 = 34;
					}
					continue;
				case 51:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1108654032 ^ -1108393628)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1334993905 ^ -1335257771);
					num2 = 10;
					continue;
				case 54:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-2138160520 ^ -2138420510)] = (string)AVOdFaG7eNJHjjZ89SgL(0x103FE975 ^ 0x103CE997);
					num2 = 29;
					continue;
				case 64:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-87337865 ^ -87073057)] = (string)AVOdFaG7eNJHjjZ89SgL(0x53CB464B ^ 0x53C8EE8F);
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					SingletonReader.JJCZtPuTvSt();
					num2 = 5;
					continue;
				case 47:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x4DC2B14D ^ 0x4DC6B8F5)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-561074844 ^ -561339174);
					num = 3;
					break;
				case 35:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-2138958856 ^ -2138695234)] = (string)AVOdFaG7eNJHjjZ89SgL(-882126494 ^ -882246866);
					num2 = 56;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 58;
					}
					continue;
				case 57:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0xA592A41 ^ 0xA5D20CD)] = (string)AVOdFaG7eNJHjjZ89SgL(-521266112 ^ -521529646);
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a1b1f08beb50460aaa983666473eef2e != 0)
					{
						num2 = 5;
					}
					continue;
				case 10:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x5A4C7B29 ^ 0x5A48724B)] = (string)AVOdFaG7eNJHjjZ89SgL(0x34185E55 ^ 0x341C573D);
					num2 = 40;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
					{
						num2 = 18;
					}
					continue;
				case 17:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1876063057 ^ -1876326689)] = (string)AVOdFaG7eNJHjjZ89SgL(-2099751081 ^ -2099487455);
					num2 = 56;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 6;
					}
					continue;
				case 8:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x4DC2B14D ^ 0x4DC6BB85)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x76DD48E ^ 0x769DE40);
					num2 = 26;
					continue;
				case 2:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-672123589 ^ -671859277)] = (string)AVOdFaG7eNJHjjZ89SgL(0x4DC2B14D ^ 0x4DC6B9C3);
					num2 = 28;
					continue;
				case 61:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x34A6D230 ^ 0x34A2DAC8)] = (string)AVOdFaG7eNJHjjZ89SgL(0x66F566B6 ^ 0x66F59CFE);
					num2 = 55;
					continue;
				case 36:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-35995181 ^ -35731171)] = (string)AVOdFaG7eNJHjjZ89SgL(0x10E41EDB ^ 0x10E4EB4B);
					num2 = 46;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 9;
					}
					continue;
				case 1:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-1876063057 ^ -1876326911)] = (string)AVOdFaG7eNJHjjZ89SgL(0x20261A4F ^ 0x202210ED);
					num2 = 23;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 != 0)
					{
						num2 = 33;
					}
					continue;
				case 26:
					return;
				case 16:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x12A5FAC7 ^ 0x12A1F3F3)] = (string)AVOdFaG7eNJHjjZ89SgL(0xE1229CF ^ 0xE12857B);
					num2 = 7;
					continue;
				case 23:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-281842504 ^ -281581870)] = (string)AVOdFaG7eNJHjjZ89SgL(0xD3DEF7E ^ 0xD3DAC32);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 17;
					}
					continue;
				case 40:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x42643203 ^ 0x42603B71)] = (string)AVOdFaG7eNJHjjZ89SgL(0x63ABA4E8 ^ 0x63AA8A5E);
					num2 = 65;
					continue;
				case 44:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-542721635 ^ -542986153)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-2099751081 ^ -2099489611);
					num = 59;
					break;
				case 4:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x2ACE37D ^ 0x2A8EAE5)] = (string)AVOdFaG7eNJHjjZ89SgL(0x61EC0CB8 ^ 0x61E80526);
					num2 = 67;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 43;
					}
					continue;
				case 7:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x5A4C7B29 ^ 0x5A487213)] = (string)AVOdFaG7eNJHjjZ89SgL(-978351861 ^ -978616245);
					num2 = 37;
					continue;
				case 46:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-87337865 ^ -87073629)] = (string)AVOdFaG7eNJHjjZ89SgL(-1767720453 ^ -1767829179);
					num2 = 22;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
					{
						num2 = 24;
					}
					continue;
				case 9:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-420743386 ^ -420479678)] = (string)AVOdFaG7eNJHjjZ89SgL(-583745292 ^ -583603534);
					num2 = 16;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
					{
						num2 = 23;
					}
					continue;
				case 28:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63ABA4E8 ^ 0x63AFAC7C)] = (string)AVOdFaG7eNJHjjZ89SgL(-882126494 ^ -882170142);
					num = 54;
					break;
				case 3:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x42643203 ^ 0x42603BC7)] = (string)AVOdFaG7eNJHjjZ89SgL(--1333735954 ^ 0x4F7EAB04);
					num2 = 44;
					continue;
				case 55:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0xD3DEF7E ^ 0xD39E780)] = (string)AVOdFaG7eNJHjjZ89SgL(-1998538950 ^ -1998275010);
					num2 = 39;
					continue;
				case 49:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-1487388570 ^ -1487123886)] = (string)AVOdFaG7eNJHjjZ89SgL(0x7247028A ^ 0x7244B4C0);
					num2 = 38;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 6;
					}
					continue;
				case 19:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-576149596 ^ -575885640)] = (string)AVOdFaG7eNJHjjZ89SgL(-281842504 ^ -281932198);
					num2 = 25;
					continue;
				case 62:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1638402543 ^ -1638662997)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921463037);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num2 = 5;
					}
					continue;
				case 66:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x2A7797B7 ^ 0x2A739DA1)] = (string)AVOdFaG7eNJHjjZ89SgL(-541731959 ^ -541992555);
					num2 = 12;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a27bee14266a48689e4dedcf18e49809 == 0)
					{
						num2 = 12;
					}
					continue;
				case 37:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-538519530 ^ -538783408)] = (string)AVOdFaG7eNJHjjZ89SgL(0x2A7797B7 ^ 0x2A739EFB);
					num2 = 51;
					continue;
				case 21:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87073239)] = (string)AVOdFaG7eNJHjjZ89SgL(-538519530 ^ -538525626);
					num = 9;
					break;
				case 22:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-2106517564 ^ -2106253638)] = (string)AVOdFaG7eNJHjjZ89SgL(--1333735954 ^ 0x4F7E1CA4);
					num2 = 15;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 != 0)
					{
						num2 = 0;
					}
					continue;
				case 25:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-1824388195 ^ -1824128321)] = (string)AVOdFaG7eNJHjjZ89SgL(0x4EA5403C ^ 0x4EA6EEE0);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 == 0)
					{
						num2 = 0;
					}
					continue;
				case 38:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(0x34A6D230 ^ 0x34A2D80A)] = (string)AVOdFaG7eNJHjjZ89SgL(-2112703338 ^ -2112438570);
					num2 = 35;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
					{
						num2 = 3;
					}
					continue;
				case 41:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-606654180 ^ -606914146)] = (string)AVOdFaG7eNJHjjZ89SgL(-234299632 ^ -234130978);
					num2 = 2;
					continue;
				case 52:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(--1360331293 ^ 0x51110B0D)] = (string)AVOdFaG7eNJHjjZ89SgL(0x48A7E34A ^ 0x48A61244);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 60;
					}
					continue;
				case 31:
					translitChars[z2jc63fLkugS1X8Q9N.tE1kD1vbB(-345420348 ^ -345159730)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1633514411 ^ -1633253819);
					num2 = 66;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 != 0)
					{
						num2 = 63;
					}
					continue;
				case 14:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-210725949 ^ -210462097)] = (string)AVOdFaG7eNJHjjZ89SgL(-1978478350 ^ -1978214080);
					num2 = 47;
					continue;
				case 32:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-787452571 ^ -787192367)] = z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x57A5235E ^ 0x57A12BE4);
					num2 = 48;
					continue;
				case 39:
					translitChars[(string)AVOdFaG7eNJHjjZ89SgL(-1867198571 ^ -1867463009)] = (string)AVOdFaG7eNJHjjZ89SgL(-2138958856 ^ -2138908384);
					num2 = 52;
					continue;
				}
				break;
			}
		}
	}

	internal static object VJH5sNG7OhRtAcr1FyMa()
	{
		return Environment.NewLine;
	}

	internal static object OgMe8bG72xJXKcp2X0Rb(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object AVOdFaG7eNJHjjZ89SgL(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool oqQu61G7kYUkVv53KfBC()
	{
		return nIdOo9G7Tiv0eZyQJCSV == null;
	}

	internal static StringExtensions xZEjoIG7nmaawCtiM7VB()
	{
		return nIdOo9G7Tiv0eZyQJCSV;
	}

	internal static object W5vSGDG7PhO3QaPdlqcG(object P_0, object P_1, object P_2, RegexOptions P_3)
	{
		return Regex.Replace((string)P_0, (string)P_1, (string)P_2, P_3);
	}

	internal static bool WvgFDkG71kseC6o8colV(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object OuKAxfG7Nn1gDqLVlXy4(object P_0)
	{
		return HttpUtility.HtmlDecode((string)P_0);
	}

	internal static bool ULHSZCG73UUNdqQK5KPy(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object cxvBCQG7pNejTZcNhC21(object P_0)
	{
		return ((string)P_0).ToCharArray();
	}

	internal static object Kgk8MlG7aPufrVOxNuUV(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static int NUjnTgG7DfQIryEBbioj(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static char HfVCJLG7tivFO2BJ4HrC(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static object Kw41c0G7w9N2gu3k4JRk(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object uUmXYAG74Yqd2K1UUw7X(object P_0, object P_1)
	{
		return ((StringBuilder)P_0).Append((string)P_1);
	}

	internal static char nqBa36G76svkE31SOuwl(char P_0)
	{
		return char.ToLowerInvariant(P_0);
	}

	internal static char gCqGI8G7HP9x8ZnJaC1e(char P_0)
	{
		return char.ToUpperInvariant(P_0);
	}

	internal static bool ikVDenG7AsccogMHcvpQ(object P_0)
	{
		return ((string)P_0).IsNullOrEmpty();
	}

	internal static object S0wpsBG77n26cHipl4iy(object P_0, int P_1, object P_2)
	{
		return ((string)P_0).Insert(P_1, (string)P_2);
	}

	internal static bool GqrS8mG7xwLD7A58oV56(object P_0, object P_1)
	{
		return Regex.IsMatch((string)P_0, (string)P_1);
	}

	internal static object xwnAlkG70DeUBaeTlMvJ(object P_0)
	{
		return BitConverter.ToString((byte[])P_0);
	}

	internal static object z9YxotG7mFkVExOMcRtH(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}

	internal static byte vkNvtUG7yFMZw6QcH87W(object P_0, int P_1)
	{
		return Convert.ToByte((string)P_0, P_1);
	}

	internal static bool o0oH4qG7MaZVEQnmsRTl(object P_0)
	{
		return ((string)P_0).IsNullOrWhiteSpace();
	}

	internal static void iCgIH6G7JesJySkXNReA(bool condition, object P_1)
	{
		Contract.CheckArgument(condition, (string)P_1);
	}

	internal static object aP6iCgG79wqx5qVDw8wn(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static void XN9jNfG7djrF1996O6pI(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object xgwJmpG7ldtcXTG5oDlP(object P_0, int startLength, int endLength)
	{
		return ((string)P_0).Truncate(startLength, endLength);
	}

	internal static Guid v4IEJfG7rZALoX34LnlR(object P_0, object P_1)
	{
		return ((string)P_0).GetDeterministicGuid((Encoding)P_1);
	}

	internal static object WVPODCG7gukwIWCFAvXV()
	{
		return SHA1.Create();
	}

	internal static object ebm4RJG75Oj9diIko3Y5()
	{
		return Encoding.UTF8;
	}

	internal static void lxWbpjG7j7tV0bQtdRMw(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}

	internal static object R6B71VG7YSTOyqRMnZMQ(object P_0, char P_1, char P_2)
	{
		return ((string)P_0).Replace(P_1, P_2);
	}

	internal static object qgKAwfG7LhFaieKnmOnc(object P_0, object P_1)
	{
		return string.Format((string)P_0, (object[])P_1);
	}

	internal static object y4IgPtG7U2EFSe7lu0bn(object P_0, object P_1, object P_2)
	{
		return string.Format((IFormatProvider)P_0, (string)P_1, (object[])P_2);
	}

	internal static object SDg8t2G7stb8D9VW2xMh(object P_0)
	{
		return ((string)P_0).Trim();
	}

	internal static int R9VQH9G7cYTVT8KvFJMa(object P_0, object P_1, StringComparison P_2)
	{
		return ((string)P_0).IndexOf((string)P_1, P_2);
	}

	internal static int R51ebQG7ztcEBO4H6Yv4(object P_0, object P_1, int P_2, StringComparison P_3)
	{
		return ((string)P_0).IndexOf((string)P_1, P_2, P_3);
	}

	internal static object hm6FtnGxFZNtuAL5nmfP()
	{
		return Encoding.Unicode;
	}

	internal static object lW9eduGxBa2P74YkV7jR(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetBytes((string)P_1);
	}

	internal static bool KgL8JTGxWXjx8AY1i4EZ(object P_0, object P_1)
	{
		return ByteArrayConstTimeEqualityExtension.Equals((byte[])P_0, (byte[])P_1);
	}

	internal static object lrHmLmGxo0WnsUSDG6Vt(object P_0, object P_1, object P_2)
	{
		return string.Concat(P_0, P_1, P_2);
	}

	internal static int C44dEPGxbNUQEWAZFNZh(int P_0, int P_1)
	{
		return Math.Min(P_0, P_1);
	}

	internal static object pT7BPaGxhokncVkFUSfY(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Remove(P_1, P_2);
	}

	internal static object MO1rs4GxGNBJHe2unXhV()
	{
		return Path.GetInvalidFileNameChars();
	}

	internal static object HsnTJWGxEZVunWD3q0e1()
	{
		return Path.GetInvalidPathChars();
	}

	internal static object nGm2fFGxfIWDDUHueDQa(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}

	internal static int YuK2xeGxQuxtAXhWMQN1(object P_0, object P_1)
	{
		return ((Encoding)P_0).GetByteCount((string)P_1);
	}
}
