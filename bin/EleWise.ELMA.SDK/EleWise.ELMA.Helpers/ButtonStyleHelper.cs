using System.Drawing;
using EleWise.ELMA.Model.Views;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Helpers;

public static class ButtonStyleHelper
{
	internal static ButtonStyleHelper x7WkZahLK0FDWlN7Um7V;

	public static Color GetButtonColor(ButtonStyle style)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return rV5uSxhLkPbVKjGLaBHQ(78, 128, 193);
			case 1:
				return rV5uSxhLkPbVKjGLaBHQ(224, 224, 224);
			case 2:
				{
					switch (style)
					{
					case ButtonStyle.Blue:
						break;
					case ButtonStyle.Green:
						return rV5uSxhLkPbVKjGLaBHQ(60, 170, 108);
					case ButtonStyle.Yellow:
						return rV5uSxhLkPbVKjGLaBHQ(250, 231, 164);
					case ButtonStyle.Red:
						return rV5uSxhLkPbVKjGLaBHQ(231, 76, 60);
					case ButtonStyle.MetroGray:
						return rV5uSxhLkPbVKjGLaBHQ(136, 136, 136);
					default:
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_670ddbf6329347f19559980f06879e11 != 0)
						{
							num2 = 0;
						}
						goto end_IL_0012;
					}
					goto default;
				}
				end_IL_0012:
				break;
			}
		}
	}

	public static Color GetBorderColor(ButtonStyle style)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				switch (style)
				{
				default:
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 0;
					}
					goto end_IL_0012;
				case ButtonStyle.Blue:
					break;
				case ButtonStyle.Green:
					return rV5uSxhLkPbVKjGLaBHQ(49, 159, 97);
				case ButtonStyle.Yellow:
					return rV5uSxhLkPbVKjGLaBHQ(235, 209, 121);
				case ButtonStyle.Red:
					return rV5uSxhLkPbVKjGLaBHQ(219, 64, 48);
				case ButtonStyle.MetroGray:
					return Color.FromArgb(119, 119, 119);
				}
				goto case 2;
			case 2:
				return rV5uSxhLkPbVKjGLaBHQ(79, 128, 191);
			default:
				{
					return Color.FromArgb(208, 208, 208);
				}
				end_IL_0012:
				break;
			}
		}
	}

	public static Color GetTextColor(ButtonStyle style)
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if ((uint)(style - 1) > 1u)
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
				return FUcYNWhLnsfwVGTNY2QI();
			case 1:
				if ((uint)(style - 4) > 1u)
				{
					return ikoSLPhLOrqxZBHXEpXb();
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public static string GetCssClass(ButtonStyle style)
	{
		//Discarded unreachable code: IL_0041, IL_00ee, IL_00fd
		int num = 7;
		char c = default(char);
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 1:
					if (style != ButtonStyle.MetroGray)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -811933704);
				case 6:
					if (style == ButtonStyle.Default)
					{
						num2 = 5;
						continue;
					}
					goto case 1;
				case 4:
				case 5:
					return string.Empty;
				case 2:
					c = ur2WihhLPsmMht0au6c8(hIjWVehLekXY4Q4DCeGX(text, 0));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 == 0)
					{
						num2 = 3;
					}
					continue;
				case 3:
					return (string)kIDRUvhLN3Y8O21w3Qe4(c.ToString(), XMSjQehL1maoBuxycaau(text, 1));
				case 7:
					break;
				default:
					if (style == ButtonStyle.Simple)
					{
						return (string)Iqvrp5hL2bp9tctGwYEB(0x20261A4F ^ 0x2025BD8D);
					}
					num2 = 2;
					continue;
				}
				break;
			}
			text = style.ToString();
			num = 6;
		}
	}

	public static string GetColorString(ButtonStyle style)
	{
		//Discarded unreachable code: IL_009c, IL_00ab
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return (string)Iqvrp5hL2bp9tctGwYEB(-234299632 ^ -234129214);
			case 1:
				return (string)Iqvrp5hL2bp9tctGwYEB(0x7459E02 ^ 0x746362E);
			case 2:
				{
					switch (style)
					{
					case ButtonStyle.Blue:
						break;
					case ButtonStyle.Green:
						return z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x637E299B ^ 0x637D8E7F);
					case ButtonStyle.Yellow:
						return z2jc63fLkugS1X8Q9N.tE1kD1vbB(-210725949 ^ -210553803);
					case ButtonStyle.Red:
						return z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x7247028A ^ 0x7244AA82);
					case ButtonStyle.MetroGray:
						return (string)Iqvrp5hL2bp9tctGwYEB(-16752921 ^ -16517379);
					default:
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd802fe7b5ff4f3ebb4bd677060717d8 == 0)
						{
							num2 = 1;
						}
						goto end_IL_0012;
					}
					goto default;
				}
				end_IL_0012:
				break;
			}
		}
	}

	internal static Color rV5uSxhLkPbVKjGLaBHQ(int P_0, int P_1, int P_2)
	{
		return Color.FromArgb(P_0, P_1, P_2);
	}

	internal static bool rZgWDNhLX8lcnACtTG5w()
	{
		return x7WkZahLK0FDWlN7Um7V == null;
	}

	internal static ButtonStyleHelper RTS2r8hLTDmp3TDic1vk()
	{
		return x7WkZahLK0FDWlN7Um7V;
	}

	internal static Color FUcYNWhLnsfwVGTNY2QI()
	{
		return Color.White;
	}

	internal static Color ikoSLPhLOrqxZBHXEpXb()
	{
		return Color.Black;
	}

	internal static object Iqvrp5hL2bp9tctGwYEB(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static char hIjWVehLekXY4Q4DCeGX(object P_0, int P_1)
	{
		return ((string)P_0)[P_1];
	}

	internal static char ur2WihhLPsmMht0au6c8(char P_0)
	{
		return char.ToLowerInvariant(P_0);
	}

	internal static object XMSjQehL1maoBuxycaau(object P_0, int P_1)
	{
		return ((string)P_0).Substring(P_1);
	}

	internal static object kIDRUvhLN3Y8O21w3Qe4(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}
}
