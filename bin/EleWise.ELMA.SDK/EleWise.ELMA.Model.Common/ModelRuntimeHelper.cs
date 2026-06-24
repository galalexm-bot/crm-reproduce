using System;
using System.Collections.Concurrent;
using EleWise.ELMA.Model.Metadata;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Model.Common;

public static class ModelRuntimeHelper
{
	private static readonly ConcurrentDictionary<string, Type> loadedContextTypes;

	private static readonly object synk;

	internal static ModelRuntimeHelper qy1Pt0hT4fSXdUxCcPdj;

	public static Type GetEntityType(EntityMetadata context, string assemblyName, byte[] assemblyRaw)
	{
		int num = 2;
		_003C_003Ec__DisplayClass2_0 _003C_003Ec__DisplayClass2_ = default(_003C_003Ec__DisplayClass2_0);
		string key = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 5:
					_003C_003Ec__DisplayClass2_.fullTypeName = context.FullTypeName;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
					{
						num2 = 0;
					}
					continue;
				default:
					return loadedContextTypes.GetOrAdd(key, _003C_003Ec__DisplayClass2_._003CGetEntityType_003Eb__0);
				case 6:
					throw new ArgumentException((string)hRny9RhTxDOulXyYHR0n(0x5DD55050 ^ 0x5DD61D84));
				case 7:
					throw new ArgumentNullException(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-218496594 ^ -218479176));
				case 3:
					if (context != null)
					{
						if (!xKXhiShT7bgIYYpTwtfr(MkblGqhTADiIejQNSAdJ(context)))
						{
							key = (string)vNA6i6hT0RaHPUxqhrid(MkblGqhTADiIejQNSAdJ(context), hRny9RhTxDOulXyYHR0n(-35995181 ^ -35992111), _003C_003Ec__DisplayClass2_.assemblyName);
							num2 = 5;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
							{
								num2 = 3;
							}
						}
						else
						{
							num2 = 6;
						}
					}
					else
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
						{
							num2 = 7;
						}
					}
					continue;
				case 1:
					break;
				case 4:
					_003C_003Ec__DisplayClass2_.assemblyRaw = assemblyRaw;
					num2 = 3;
					continue;
				case 2:
					_003C_003Ec__DisplayClass2_ = new _003C_003Ec__DisplayClass2_0();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 1;
					}
					continue;
				}
				break;
			}
			_003C_003Ec__DisplayClass2_.assemblyName = assemblyName;
			num = 4;
		}
	}

	static ModelRuntimeHelper()
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 2:
				loadedContextTypes = new ConcurrentDictionary<string, Type>();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3123138a1acc4cd7837d0743aca32676 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				synk = new object();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				SingletonReader.JJCZtPuTvSt();
				num2 = 2;
				break;
			}
		}
	}

	internal static object MkblGqhTADiIejQNSAdJ(object P_0)
	{
		return ((ClassMetadata)P_0).FullTypeName;
	}

	internal static bool xKXhiShT7bgIYYpTwtfr(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static object hRny9RhTxDOulXyYHR0n(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object vNA6i6hT0RaHPUxqhrid(object P_0, object P_1, object P_2)
	{
		return (string)P_0 + (string)P_1 + (string)P_2;
	}

	internal static bool AD7SlMhT6GHdEr6HiDDO()
	{
		return qy1Pt0hT4fSXdUxCcPdj == null;
	}

	internal static ModelRuntimeHelper GFq4o0hTHunohjVsoqRc()
	{
		return qy1Pt0hT4fSXdUxCcPdj;
	}
}
