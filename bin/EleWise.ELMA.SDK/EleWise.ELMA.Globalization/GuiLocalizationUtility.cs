using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Globalization;

public static class GuiLocalizationUtility
{
	public static string TemplateInCodeRes;

	internal static GuiLocalizationUtility fgtQM2Gfvfa3S2lyhq3g;

	public static bool CheckDesignMode { get; set; }

	public static bool DesignMode
	{
		get
		{
			//Discarded unreachable code: IL_002d, IL_003c
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (pC14RyGfIvCNg2fPduLH())
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
						{
							num2 = 1;
						}
						break;
					}
					goto default;
				default:
					return false;
				case 1:
					return ((IEnumerable<StackFrame>)TyRIRRGfVUi9NSbkR3kl(new StackTrace())).Count(delegate(StackFrame f)
					{
						//Discarded unreachable code: IL_00a0, IL_00af, IL_00df, IL_00ee
						int num3 = 5;
						int num4 = num3;
						while (true)
						{
							switch (num4)
							{
							case 2:
								if (_003C_003Ec.BoMEydv527srSXAjoCbV(_003C_003Ec.YpC1cjv5nlf919G3UVyG(_003C_003Ec.gGLMDfv5TTP1vIxtBb1e(f)).FullName, _003C_003Ec.w30GO5v5OymHXEV8PkB7(-1837662597 ^ -1837979177)))
								{
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3be1502d95074968827ce5c7f0727648 == 0)
									{
										num4 = 0;
									}
									break;
								}
								goto case 3;
							default:
								return _003C_003Ec.BoMEydv527srSXAjoCbV(_003C_003Ec.hFgWdGv5exKLMuVXBWYx(f.GetMethod()), _003C_003Ec.w30GO5v5OymHXEV8PkB7(-420743386 ^ -420597920));
							case 3:
							case 4:
								return false;
							case 1:
								if (!(_003C_003Ec.YpC1cjv5nlf919G3UVyG(_003C_003Ec.gGLMDfv5TTP1vIxtBb1e(f)) != null))
								{
									num4 = 3;
									break;
								}
								goto case 2;
							case 5:
								if (!_003C_003Ec.UUIApRv5kqSYC7BIbSga(_003C_003Ec.gGLMDfv5TTP1vIxtBb1e(f), null))
								{
									num4 = 4;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
									{
										num4 = 2;
									}
									break;
								}
								goto case 1;
							}
						}
					}) > 0;
				}
			}
		}
	}

	static GuiLocalizationUtility()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
				return;
			case 1:
				TemplateInCodeRes = z2jc63fLkugS1X8Q9N.tE1kD1vbB(-97972138 ^ -97865780);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde == 0)
				{
					num2 = 1;
				}
				break;
			default:
				XLCyDpGfuDJDDiJtC3De(value: true);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	public static string GetString(string resourcesString)
	{
		//Discarded unreachable code: IL_002d, IL_003c
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 2:
				if (O8gfP3GfSxWqZG2sOx3n())
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto default;
			default:
			{
				ResourceString resourceString = new ResourceString();
				tBS54nGfi2U9IufP8AwN(resourceString, resourcesString);
				return (string)VpHNfSGfRIFuonu8q16R(resourceString);
			}
			case 1:
				return string.Format((string)phbgp5Gfq8JxJxRomWIe(-521266112 ^ -521296912), resourcesString);
			}
		}
	}

	internal static void XLCyDpGfuDJDDiJtC3De(bool value)
	{
		CheckDesignMode = value;
	}

	internal static bool x43LgCGf8ejhcdUeD8rk()
	{
		return fgtQM2Gfvfa3S2lyhq3g == null;
	}

	internal static GuiLocalizationUtility BwjqE5GfZelm8TdP9VgG()
	{
		return fgtQM2Gfvfa3S2lyhq3g;
	}

	internal static bool pC14RyGfIvCNg2fPduLH()
	{
		return CheckDesignMode;
	}

	internal static object TyRIRRGfVUi9NSbkR3kl(object P_0)
	{
		return ((StackTrace)P_0).GetFrames();
	}

	internal static bool O8gfP3GfSxWqZG2sOx3n()
	{
		return DesignMode;
	}

	internal static void tBS54nGfi2U9IufP8AwN(object P_0, object P_1)
	{
		((ResourceString)P_0).Parse((string)P_1);
	}

	internal static object VpHNfSGfRIFuonu8q16R(object P_0)
	{
		return ((ResourceString)P_0).Value;
	}

	internal static object phbgp5Gfq8JxJxRomWIe(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
