using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization;

public class LanguagesMap
{
	private static LanguagesMap xhvgbFGhaGy28T1blWyD;

	public List<LanguageMapItem> Languages { get; set; }

	public LanguagesMap()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		shdmmKGhwl3YZ96rCw2H();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d != 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			}
			Languages = new List<LanguageMapItem>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
			{
				num = 0;
			}
		}
	}

	public List<CultureInfo> AllBaseCultureInfo()
	{
		return (from c in (from l in Languages
				group l by (string)_003C_003Ec.mbNR18vllwEYt0nhMu6B(l)).Select(delegate(IGrouping<string, LanguageMapItem> g)
			{
				try
				{
					return new CultureInfo(g.Key);
				}
				catch (Exception ex)
				{
					Logger.Log.Error(ex.Message, ex);
				}
				return null;
			})
			where c != null
			select c).ToList();
	}

	public CultureInfo GetBaseCultureInfo(string code)
	{
		//Discarded unreachable code: IL_011a, IL_0143, IL_0175, IL_018c
		int num = 5;
		int num2 = num;
		LanguageMapItem languageMapItem = default(LanguageMapItem);
		_003C_003Ec__DisplayClass6_0 _003C_003Ec__DisplayClass6_ = default(_003C_003Ec__DisplayClass6_0);
		string name = default(string);
		while (true)
		{
			object obj;
			switch (num2)
			{
			case 6:
				if (languageMapItem == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				if (xntObZGh6UZthv83N0dr(languageMapItem.BaseLanguage))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_02fe35d781894c138378d91c8de11fb5 != 0)
					{
						num2 = 3;
					}
					continue;
				}
				obj = QUUsyeGhAh5stQ0XD7AQ(languageMapItem);
				break;
			case 1:
				return (CultureInfo)tg07NDGh4IxG1D8BwPiV();
			default:
				languageMapItem = Languages.FirstOrDefault(_003C_003Ec__DisplayClass6_._003CGetBaseCultureInfo_003Eb__0);
				num2 = 5;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e != 0)
				{
					num2 = 6;
				}
				continue;
			case 4:
				_003C_003Ec__DisplayClass6_.code = code;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 0;
				}
				continue;
			case 5:
				_003C_003Ec__DisplayClass6_ = new _003C_003Ec__DisplayClass6_0();
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 4;
				}
				continue;
			case 7:
				return (CultureInfo)tg07NDGh4IxG1D8BwPiV();
			case 3:
				obj = Nb0X1yGhHXgi3w4gFZ1G(languageMapItem);
				break;
			case 2:
				try
				{
					CultureInfo cultureInfo = new CultureInfo(name);
					int num3 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
					{
						num3 = 0;
					}
					return num3 switch
					{
						0 => cultureInfo, 
						_ => cultureInfo, 
					};
				}
				catch (Exception)
				{
					int num4 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
					{
						num4 = 0;
					}
					switch (num4)
					{
					case 0:
						break;
					}
				}
				goto case 7;
			}
			name = (string)obj;
			num2 = 2;
		}
	}

	public string GetResourceName(string resource, string local)
	{
		return (string)L02p86GhxRQWIVxCBEWd(N9Y47QGh7G1btT9b39Ob(-538519530 ^ -538470158), resource, local.Replace((string)N9Y47QGh7G1btT9b39Ob(0x103FE975 ^ 0x103FE719), (string)N9Y47QGh7G1btT9b39Ob(0x5F3078B6 ^ 0x5F3074CC)));
	}

	public static LanguagesMap Load(string xml)
	{
		//Discarded unreachable code: IL_00dd, IL_00ec, IL_02eb, IL_0323, IL_0332
		int num = 1;
		int num2 = num;
		XmlReader xmlReader = default(XmlReader);
		LanguagesMap languagesMap = default(LanguagesMap);
		LanguageMapItem languageMapItem = default(LanguageMapItem);
		while (true)
		{
			switch (num2)
			{
			default:
				xmlReader = (XmlReader)eVcTMWGh0tB0pOsenJPk(new StringReader(xml));
				num2 = 3;
				break;
			case 1:
				languagesMap = new LanguagesMap();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ac3c99c83a348ea94edf0eaaafa9386 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return languagesMap;
			case 3:
				try
				{
					if (!TIE1dMGhmLoNuEJqhy0H(xmlReader, N9Y47QGh7G1btT9b39Ob(0x5F3078B6 ^ 0x5F33C246)))
					{
						return languagesMap;
					}
					int num3 = 14;
					while (true)
					{
						switch (num3)
						{
						case 10:
							return languagesMap;
						case 6:
							languagesMap.Languages.Add(languageMapItem);
							num3 = 9;
							break;
						case 7:
							languageMapItem = new LanguageMapItem();
							num3 = 5;
							break;
						case 5:
							kn7yyJGhdfOT7gxlARIL(languageMapItem, YNLxu0Gh9YeynGrNgomO(xmlReader, N9Y47QGh7G1btT9b39Ob(0x1A33FE36 ^ 0x1A30452C)));
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_74b3b832e58d418e87e3ee261fe7306d == 0)
							{
								num3 = 0;
							}
							break;
						case 2:
							if (!xntObZGh6UZthv83N0dr(languageMapItem.Code))
							{
								num3 = 6;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
								{
									num3 = 4;
								}
								break;
							}
							goto case 9;
						case 13:
							a2KED1GhMakOC3nLUXmq(xmlReader);
							num3 = 12;
							break;
						case 4:
							pdOVvCGhrpIMu6IUMnAZ(languageMapItem, xmlReader.GetAttribute(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103C522D)));
							num3 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
							{
								num3 = 2;
							}
							break;
						case 9:
						{
							lOyUYxGhgByLxHJa8Fl6(xmlReader);
							int num4 = 11;
							num3 = num4;
							break;
						}
						case 3:
							languageMapItem.NativeName = xmlReader.GetAttribute((string)N9Y47QGh7G1btT9b39Ob(0x26FFCB59 ^ 0x26FC7019));
							num3 = 4;
							break;
						default:
							if (gC7nitGhJJgEy4DyOp7W(xmlReader.Name, N9Y47QGh7G1btT9b39Ob(-1123633026 ^ -1123744904)))
							{
								num3 = 5;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 == 0)
								{
									num3 = 7;
								}
								break;
							}
							goto case 9;
						case 8:
						case 12:
							if (xmlReader.NodeType == XmlNodeType.EndElement)
							{
								num3 = 7;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
								{
									num3 = 10;
								}
								break;
							}
							goto default;
						case 14:
							BDqciKGhyC5WmFxOpnqH(xmlReader);
							num3 = 13;
							break;
						case 1:
							e99ayuGhlXofsJB3V2rv(languageMapItem, YNLxu0Gh9YeynGrNgomO(xmlReader, N9Y47QGh7G1btT9b39Ob(-1146510045 ^ -1146479099)));
							num3 = 3;
							break;
						case 11:
							a2KED1GhMakOC3nLUXmq(xmlReader);
							num3 = 8;
							break;
						}
					}
				}
				finally
				{
					if (xmlReader != null)
					{
						int num5 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a6389eee16e84a47bfa26a4b9506cfec != 0)
						{
							num5 = 0;
						}
						while (true)
						{
							switch (num5)
							{
							case 1:
								hn0c0eGh5LjXVmiJX0lC(xmlReader);
								num5 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
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
			}
		}
	}

	internal static void shdmmKGhwl3YZ96rCw2H()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool GrTlr7GhDrEDvWPe18sn()
	{
		return xhvgbFGhaGy28T1blWyD == null;
	}

	internal static LanguagesMap XJNYSQGhtWpOm0MU2unc()
	{
		return xhvgbFGhaGy28T1blWyD;
	}

	internal static object tg07NDGh4IxG1D8BwPiV()
	{
		return SR.KeyCultureInfo;
	}

	internal static bool xntObZGh6UZthv83N0dr(object P_0)
	{
		return string.IsNullOrWhiteSpace((string)P_0);
	}

	internal static object Nb0X1yGhHXgi3w4gFZ1G(object P_0)
	{
		return ((LanguageMapItem)P_0).Code;
	}

	internal static object QUUsyeGhAh5stQ0XD7AQ(object P_0)
	{
		return ((LanguageMapItem)P_0).BaseLanguage;
	}

	internal static object N9Y47QGh7G1btT9b39Ob(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object L02p86GhxRQWIVxCBEWd(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static object eVcTMWGh0tB0pOsenJPk(object P_0)
	{
		return XmlReader.Create((TextReader)P_0);
	}

	internal static bool TIE1dMGhmLoNuEJqhy0H(object P_0, object P_1)
	{
		return ((XmlReader)P_0).ReadToNextSibling((string)P_1);
	}

	internal static bool BDqciKGhyC5WmFxOpnqH(object P_0)
	{
		return ((XmlReader)P_0).Read();
	}

	internal static XmlNodeType a2KED1GhMakOC3nLUXmq(object P_0)
	{
		return ((XmlReader)P_0).MoveToContent();
	}

	internal static bool gC7nitGhJJgEy4DyOp7W(object P_0, object P_1)
	{
		return (string)P_0 == (string)P_1;
	}

	internal static object YNLxu0Gh9YeynGrNgomO(object P_0, object P_1)
	{
		return ((XmlReader)P_0).GetAttribute((string)P_1);
	}

	internal static void kn7yyJGhdfOT7gxlARIL(object P_0, object P_1)
	{
		((LanguageMapItem)P_0).Code = (string)P_1;
	}

	internal static void e99ayuGhlXofsJB3V2rv(object P_0, object P_1)
	{
		((LanguageMapItem)P_0).EnglishName = (string)P_1;
	}

	internal static void pdOVvCGhrpIMu6IUMnAZ(object P_0, object P_1)
	{
		((LanguageMapItem)P_0).BaseLanguage = (string)P_1;
	}

	internal static void lOyUYxGhgByLxHJa8Fl6(object P_0)
	{
		((XmlReader)P_0).Skip();
	}

	internal static void hn0c0eGh5LjXVmiJX0lC(object P_0)
	{
		((IDisposable)P_0).Dispose();
	}
}
