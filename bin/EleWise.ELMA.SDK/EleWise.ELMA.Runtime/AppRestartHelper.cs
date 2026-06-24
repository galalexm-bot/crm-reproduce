using System;
using System.IO;
using System.Web;
using System.Web.Hosting;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime;

public static class AppRestartHelper
{
	private static AppRestartHelper u8hUnwWWm20l9WMv9TiY;

	private static bool IsFullTrust
	{
		get
		{
			int num = 1;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return plohSFWW510BGhglhgN2(FFV88TWWgA2SS7uiuFPq());
				case 1:
					if (!AppDomain.CurrentDomain.IsHomogenous)
					{
						return false;
					}
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public static void RestartAppDomain()
	{
		//Discarded unreachable code: IL_003d, IL_0066, IL_00f7, IL_0106
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 3:
				if (!BM3PU8WWdCHOtpe4m30O())
				{
					num2 = 2;
					continue;
				}
				break;
			case 2:
				if (e2yxJ2WWlRClL8HLukFf())
				{
					break;
				}
				goto default;
			default:
				throw new Exception(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-475857671 ^ -475826821), XsbpcGWWryM4oC0JCwJJ(-1979251663 ^ -1979283275), XsbpcGWWryM4oC0JCwJJ(-477139494 ^ -477175440)));
			case 5:
				return;
			case 4:
				if (!c1IU19WWJJlIOmMGISjX())
				{
					num2 = 3;
					continue;
				}
				goto case 6;
			case 6:
				lcYslGWW93xYVYI8YHi1();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 != 0)
				{
					num2 = 1;
				}
				continue;
			}
			num2 = 5;
		}
	}

	private static bool TryWriteWebConfig()
	{
		//Discarded unreachable code: IL_0061, IL_00b4, IL_00ec, IL_00fb
		bool result = default(bool);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				TQJHhdWWLktPywCSaxAF(e9bmYsWWjuJgD20wOA2X(XsbpcGWWryM4oC0JCwJJ(-740338220 ^ -740370050)), ki8FxvWWYNioLYPp7RTX());
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
				{
					num = 0;
				}
				while (true)
				{
					switch (num)
					{
					case 1:
						return result;
					}
					result = true;
					num = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 != 0)
					{
						num = 1;
					}
				}
			}
			catch
			{
				int num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f0b047b38a1e48a7985f9b2bda5c7562 == 0)
				{
					num2 = 0;
				}
				while (true)
				{
					switch (num2)
					{
					case 1:
						return result;
					}
					result = false;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 1;
					}
				}
			}
		}
	}

	private static bool TryWriteBinFolder()
	{
		//Discarded unreachable code: IL_007b, IL_00ee, IL_014b, IL_0183, IL_0192, IL_01bd, IL_01f5, IL_0204
		bool result = default(bool);
		switch (1)
		{
		default:
			return result;
		case 1:
			try
			{
				object obj = e9bmYsWWjuJgD20wOA2X(XsbpcGWWryM4oC0JCwJJ(0x17ADCCD8 ^ 0x17AC405C));
				gZDoZYWWUj778v7pmefM(obj);
				StreamWriter streamWriter = (StreamWriter)gdP8RRWWc6BTH8rsRvlq(QqS3Z5WWshs8bi1hWkiI(obj, XsbpcGWWryM4oC0JCwJJ(-606654180 ^ -606683686)));
				int num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num = 2;
				}
				while (true)
				{
					switch (num)
					{
					default:
						return result;
					case 0:
						return result;
					case 1:
						break;
					case 2:
						try
						{
							UVTb3XWWzYrchdrnKHN0(streamWriter, XsbpcGWWryM4oC0JCwJJ(-1710575414 ^ -1710539756), DateTime.UtcNow);
							int num2 = 0;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c57bdfdbf8304f4583b17d3e33b5b6b7 != 0)
							{
								num2 = 0;
							}
							while (true)
							{
								switch (num2)
								{
								default:
									streamWriter.Flush();
									num2 = 1;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f == 0)
									{
										num2 = 1;
									}
									continue;
								case 1:
									break;
								}
								break;
							}
						}
						finally
						{
							if (streamWriter != null)
							{
								int num3 = 1;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
								{
									num3 = 0;
								}
								while (true)
								{
									switch (num3)
									{
									case 1:
										((IDisposable)streamWriter).Dispose();
										num3 = 0;
										if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
										{
											num3 = 0;
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
					}
					result = true;
					num = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
					{
						num = 0;
					}
				}
			}
			catch
			{
				int num4 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
				{
					num4 = 0;
				}
				while (true)
				{
					switch (num4)
					{
					case 1:
						return result;
					}
					result = false;
					num4 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
					{
						num4 = 0;
					}
				}
			}
		}
	}

	internal static bool c1IU19WWJJlIOmMGISjX()
	{
		return IsFullTrust;
	}

	internal static void lcYslGWW93xYVYI8YHi1()
	{
		HttpRuntime.UnloadAppDomain();
	}

	internal static bool BM3PU8WWdCHOtpe4m30O()
	{
		return TryWriteBinFolder();
	}

	internal static bool e2yxJ2WWlRClL8HLukFf()
	{
		return TryWriteWebConfig();
	}

	internal static object XsbpcGWWryM4oC0JCwJJ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool xo4VbZWWyBKgfrHCfk2J()
	{
		return u8hUnwWWm20l9WMv9TiY == null;
	}

	internal static AppRestartHelper pRCBejWWMlrQw1gP3BIj()
	{
		return u8hUnwWWm20l9WMv9TiY;
	}

	internal static object FFV88TWWgA2SS7uiuFPq()
	{
		return AppDomain.CurrentDomain;
	}

	internal static bool plohSFWW510BGhglhgN2(object P_0)
	{
		return ((AppDomain)P_0).IsFullyTrusted;
	}

	internal static object e9bmYsWWjuJgD20wOA2X(object P_0)
	{
		return HostingEnvironment.MapPath((string)P_0);
	}

	internal static DateTime ki8FxvWWYNioLYPp7RTX()
	{
		return DateTime.UtcNow;
	}

	internal static void TQJHhdWWLktPywCSaxAF(object P_0, DateTime P_1)
	{
		File.SetLastWriteTimeUtc((string)P_0, P_1);
	}

	internal static object gZDoZYWWUj778v7pmefM(object P_0)
	{
		return Directory.CreateDirectory((string)P_0);
	}

	internal static object QqS3Z5WWshs8bi1hWkiI(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object gdP8RRWWc6BTH8rsRvlq(object P_0)
	{
		return File.CreateText((string)P_0);
	}

	internal static void UVTb3XWWzYrchdrnKHN0(object P_0, object P_1, object P_2)
	{
		((TextWriter)P_0).WriteLine((string)P_1, P_2);
	}
}
