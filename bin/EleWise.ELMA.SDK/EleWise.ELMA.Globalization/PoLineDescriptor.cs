using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization;

[Serializable]
public class PoLineDescriptor
{
	private List<string> _keyWords;

	private List<string> _valueWords;

	private string _keyHash;

	internal static PoLineDescriptor zKpcp2GG0SVTKEfGARdM;

	public string Key
	{
		[CompilerGenerated]
		get
		{
			return _003CKey_003Ek__BackingField;
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
					_003CKey_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public string Value
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
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b8b5ba3691d34beb9a03ac11c72e32b1 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsFuzzy
	{
		[CompilerGenerated]
		get
		{
			return _003CIsFuzzy_003Ek__BackingField;
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
					_003CIsFuzzy_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public bool IsLow
	{
		[CompilerGenerated]
		get
		{
			return _003CIsLow_003Ek__BackingField;
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
					_003CIsLow_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public List<string> Comments { get; set; }

	public bool IsJsBlock
	{
		get
		{
			//Discarded unreachable code: IL_0052, IL_0061
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (Comments == null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 2;
				case 2:
					return Comments.Any((string c) => c.Contains((string)_003C_003Ec.McwwSAvgyRsJJwLUA4EU(0x5F3078B6 ^ 0x5F33C658)));
				default:
					return false;
				}
			}
		}
	}

	public List<string> KeyWords
	{
		get
		{
			if (_keyWords == null && !string.IsNullOrEmpty(Key))
			{
				_keyWords = LocalizationHolder.SplitByWords(Key).ToList();
			}
			return _keyWords ?? new List<string>();
		}
	}

	public List<string> ValueWords
	{
		get
		{
			if (_valueWords == null && !string.IsNullOrEmpty(Value))
			{
				_valueWords = LocalizationHolder.SplitByWords(Value).ToList();
			}
			return _valueWords ?? new List<string>();
		}
	}

	public string KeyHash
	{
		get
		{
			//Discarded unreachable code: IL_0031, IL_0040
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!ayHbaKGGMnKYg4ytEX6u(_keyHash))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					_keyHash = (string)clCuaeGGJXXiZK77kanG(Key);
					num2 = 3;
					break;
				case 1:
				case 3:
					return _keyHash;
				}
			}
		}
	}

	public PoLineDescriptor()
	{
		//Discarded unreachable code: IL_002a, IL_002f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
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
			Comments = new List<string>();
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 != 0)
			{
				num = 0;
			}
		}
	}

	public void WriteToFile(StreamWriter sw)
	{
		//Discarded unreachable code: IL_0049, IL_01ec, IL_029f, IL_02b2
		int num = 6;
		int num2 = num;
		List<string>.Enumerator enumerator = default(List<string>.Enumerator);
		string current = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			default:
				sw.WriteLine((string)Nr3Z0tGGdlelTnH1pXUf(-978351861 ^ -978569987));
				num2 = 8;
				break;
			case 8:
				Q9LhLFGGgVrKuuVE2cjL(sw, Nr3Z0tGGdlelTnH1pXUf(-105199646 ^ -105285148), F2KCFhGGrpZUSsCfF0Qf(iKEo02GGlscbnaPPFS2G(((string)iKEo02GGlscbnaPPFS2G(iKEo02GGlscbnaPPFS2G(iKEo02GGlscbnaPPFS2G(Key.Replace((string)Nr3Z0tGGdlelTnH1pXUf(-787452571 ^ -787451333), ""), Nr3Z0tGGdlelTnH1pXUf(-218496594 ^ -218489128), Nr3Z0tGGdlelTnH1pXUf(0x3A5D5EF ^ 0x3A5CAC1)), Nr3Z0tGGdlelTnH1pXUf(0x1C9495B4 ^ 0x1C972B94), Nr3Z0tGGdlelTnH1pXUf(-583745292 ^ -583737438)), z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1921202237 ^ -1921197977), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x48A7E34A ^ 0x48A7FC1C))).Replace(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x3630F361 ^ 0x36334D4B), (string)Nr3Z0tGGdlelTnH1pXUf(-1870892489 ^ -1870893743)), Nr3Z0tGGdlelTnH1pXUf(-1633514411 ^ -1633512449), Nr3Z0tGGdlelTnH1pXUf(0x42643203 ^ 0x42642D65))));
				num2 = 4;
				break;
			case 7:
				if (!IsFuzzy)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_34cb7b3fc29043488ce22a542299c271 != 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 9;
			case 2:
			case 3:
				if (IsLow)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 8;
			case 5:
				try
				{
					while (true)
					{
						IL_0214:
						int num3;
						if (!enumerator.MoveNext())
						{
							num3 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_24c4d95e07c94a449594142b78a5da65 == 0)
							{
								num3 = 0;
							}
							goto IL_01fa;
						}
						goto IL_025c;
						IL_025c:
						current = enumerator.Current;
						int num4 = 2;
						num3 = num4;
						goto IL_01fa;
						IL_01fa:
						while (true)
						{
							switch (num3)
							{
							case 1:
								goto IL_0214;
							case 2:
								KEdXOUGG9dZMGsZjNh9q(sw, current);
								num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 == 0)
								{
									num3 = 1;
								}
								continue;
							case 3:
								goto IL_025c;
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
					int num5 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
					{
						num5 = 0;
					}
					switch (num5)
					{
					case 0:
						break;
					}
				}
				goto case 7;
			case 6:
				enumerator = Comments.GetEnumerator();
				num2 = 5;
				break;
			case 9:
				KEdXOUGG9dZMGsZjNh9q(sw, Nr3Z0tGGdlelTnH1pXUf(-1751176224 ^ -1751345662));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 2;
				}
				break;
			case 4:
				sw.WriteLine((string)Nr3Z0tGGdlelTnH1pXUf(0x3C5338FF ^ 0x3C5086CB), (Value != null) ? F2KCFhGGrpZUSsCfF0Qf(iKEo02GGlscbnaPPFS2G(iKEo02GGlscbnaPPFS2G(iKEo02GGlscbnaPPFS2G(((string)iKEo02GGlscbnaPPFS2G(iKEo02GGlscbnaPPFS2G(Value, z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1459557599 ^ -1459555201), ""), Nr3Z0tGGdlelTnH1pXUf(-583745292 ^ -583737470), Nr3Z0tGGdlelTnH1pXUf(0x5F3078B6 ^ 0x5F306798))).Replace((string)Nr3Z0tGGdlelTnH1pXUf(0x34A6D230 ^ 0x34A56C10), (string)Nr3Z0tGGdlelTnH1pXUf(-740338220 ^ -740341118)), Nr3Z0tGGdlelTnH1pXUf(-1638402543 ^ -1638405707), Nr3Z0tGGdlelTnH1pXUf(-1108654032 ^ -1108650138)), Nr3Z0tGGdlelTnH1pXUf(0x7247028A ^ 0x7244BCA0), Nr3Z0tGGdlelTnH1pXUf(-475857671 ^ -475864161)), Nr3Z0tGGdlelTnH1pXUf(0x92F12D5 ^ 0x92F0D7F), Nr3Z0tGGdlelTnH1pXUf(-1870892489 ^ -1870893743))) : "");
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	private static string EscapeQuotes(object s)
	{
		//Discarded unreachable code: IL_00b7, IL_00c6, IL_0151
		int num = 8;
		StringBuilder stringBuilder = default(StringBuilder);
		int num3 = default(int);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 9:
					stringBuilder.Append((string)Nr3Z0tGGdlelTnH1pXUf(0x6DC147B0 ^ 0x6DC158C6));
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c61a4898016348629effe6c617bb4dca != 0)
					{
						num2 = 6;
					}
					continue;
				case 2:
					return stringBuilder.ToString();
				case 6:
					sepRErGGYY0gndfCbLkV(stringBuilder, ((string)s)[num3]);
					num2 = 13;
					continue;
				case 11:
					stringBuilder.Append(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583737470));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db != 0)
					{
						num2 = 0;
					}
					continue;
				case 1:
					if (pO1ZC0GGjxwt635RHDa1(s, num3 - 1) != '\\')
					{
						num2 = 9;
						continue;
					}
					goto case 6;
				case 10:
					if (pO1ZC0GGjxwt635RHDa1(s, 0) == '"')
					{
						num2 = 7;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
						{
							num2 = 11;
						}
						continue;
					}
					break;
				case 8:
					if (kxSIhqGG5J9SWAu8CdYL(s) >= 1)
					{
						stringBuilder = new StringBuilder();
						num2 = 10;
						continue;
					}
					goto end_IL_0012;
				case 7:
					return (string)s;
				case 5:
				case 14:
					if (pO1ZC0GGjxwt635RHDa1(s, num3) == '"')
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c4ef7fcd773b4766ad37a58fe3d2b5be == 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 6;
				case 3:
					num3 = 1;
					num2 = 12;
					continue;
				case 4:
				case 12:
					if (num3 < kxSIhqGG5J9SWAu8CdYL(s))
					{
						num2 = 14;
						continue;
					}
					goto case 2;
				case 13:
					num3++;
					num2 = 4;
					continue;
				}
				sepRErGGYY0gndfCbLkV(stringBuilder, pO1ZC0GGjxwt635RHDa1(s, 0));
				num2 = 3;
				continue;
				end_IL_0012:
				break;
			}
			num = 7;
		}
	}

	public override string ToString()
	{
		int num = 1;
		int num2 = num;
		string text;
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = Key;
				if (text == null)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				text = base.ToString();
				break;
			}
			break;
		}
		return text;
	}

	internal static bool vZXuIyGGmZNUTSeXOVFL()
	{
		return zKpcp2GG0SVTKEfGARdM == null;
	}

	internal static PoLineDescriptor CyDXt1GGyG1vPyYyaEdr()
	{
		return zKpcp2GG0SVTKEfGARdM;
	}

	internal static bool ayHbaKGGMnKYg4ytEX6u(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object clCuaeGGJXXiZK77kanG(object P_0)
	{
		return EncryptionHelper.GetMd5Hash((string)P_0);
	}

	internal static void KEdXOUGG9dZMGsZjNh9q(object P_0, object P_1)
	{
		((TextWriter)P_0).WriteLine((string)P_1);
	}

	internal static object Nr3Z0tGGdlelTnH1pXUf(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object iKEo02GGlscbnaPPFS2G(object P_0, object P_1, object P_2)
	{
		return ((string)P_0).Replace((string)P_1, (string)P_2);
	}

	internal static object F2KCFhGGrpZUSsCfF0Qf(object P_0)
	{
		return EscapeQuotes(P_0);
	}

	internal static void Q9LhLFGGgVrKuuVE2cjL(object P_0, object P_1, object P_2)
	{
		((TextWriter)P_0).WriteLine((string)P_1, P_2);
	}

	internal static int kxSIhqGG5J9SWAu8CdYL(object P_0)
	{
		return ((string)P_0).Length;
	}

	internal static char pO1ZC0GGjxwt635RHDa1(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static object sepRErGGYY0gndfCbLkV(object P_0, char P_1)
	{
		return ((StringBuilder)P_0).Append(P_1);
	}
}
