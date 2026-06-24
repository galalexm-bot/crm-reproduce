using System;
using System.Collections;
using System.Collections.Generic;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Extensions;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Diagnostics.Metrics.Impl.Aggregators;

[Component]
public class WebRequestMetricAggregator : BaseMetricAggregator<CallContextInfo>
{
	internal static WebRequestMetricAggregator zrN2DrEVELhmouoPpSBB;

	public WebRequestMetricAggregator(IEnumerable<IMetricProcessor> processors)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(processors);
	}

	public override void Add(CallContextInfo callInfo, MetricsContainer container)
	{
		//Discarded unreachable code: IL_01f6, IL_0205, IL_02b6, IL_02c5, IL_02d0, IL_034f, IL_0387
		int num = 7;
		int num2 = num;
		CallContextType? type = default(CallContextType?);
		string text = default(string);
		CallContextType callContextType = default(CallContextType);
		WebRequestMetric orAdd = default(WebRequestMetric);
		MetricsGroup<WebRequestMetric> orAdd2 = default(MetricsGroup<WebRequestMetric>);
		IEnumerator<IMetricProcessor> enumerator = default(IEnumerator<IMetricProcessor>);
		while (true)
		{
			switch (num2)
			{
			default:
				type = callInfo.Type;
				num2 = 5;
				break;
			case 18:
				if (text.IsNullOrEmpty())
				{
					num2 = 10;
					break;
				}
				if (!((string)uKduqwEVIGHdTPgZwQHp(callInfo)).IsNullOrEmpty())
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
					{
						num2 = 14;
					}
					break;
				}
				goto case 1;
			case 14:
				if (lxxd7HEVVWQMbFPejWcY(uKduqwEVIGHdTPgZwQHp(callInfo), z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x103FE975 ^ 0x103DDF79)))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			case 15:
				text = (string)uQCs8bEV8oZvucBO2tUo(new Uri((string)kYtqTREVvlaUIF1K3CmF(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x12441CA4 ^ 0x12404C62), e4ZF9cEVCmpZO61OndTP(callInfo)), UriKind.RelativeOrAbsolute));
				num2 = 11;
				break;
			case 4:
				return;
			case 5:
				callContextType = CallContextType.WebRequest;
				num2 = 8;
				break;
			case 8:
				if (type != callContextType)
				{
					num2 = 11;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 != 0)
					{
						num2 = 13;
					}
					break;
				}
				goto IL_0228;
			case 1:
			case 12:
				orAdd = orAdd2.GetOrAdd(text);
				num2 = 17;
				break;
			case 10:
				return;
			case 11:
				if (!text.StartsWith((string)W09dO1EVZrdblJ7olbEa(0x53FA00CE ^ 0x53FA649E)))
				{
					num2 = 9;
					break;
				}
				goto case 16;
			case 7:
				type = callInfo.Type;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a96ebbb7c9364b83918e3295b2ea4927 == 0)
				{
					num2 = 6;
				}
				break;
			case 6:
				if (type.HasValue)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d0a035e9ae274e518bba347305cb7055 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto IL_0228;
			case 17:
				enumerator = base.MetricProcessors.GetEnumerator();
				num2 = 3;
				break;
			case 13:
				return;
			case 16:
				text = (string)B0iKrlEVuxbH20xK8bGY(text);
				num2 = 18;
				break;
			case 2:
				text = (string)cETGVJEVS842TVnSPCjo(text, W09dO1EVZrdblJ7olbEa(-1710575414 ^ -1710301142), uKduqwEVIGHdTPgZwQHp(callInfo), W09dO1EVZrdblJ7olbEa(-1921202237 ^ -1921240789));
				num2 = 12;
				break;
			case 9:
				text = (string)kYtqTREVvlaUIF1K3CmF(W09dO1EVZrdblJ7olbEa(-629844702 ^ -629853838), text);
				num2 = 16;
				break;
			case 3:
				{
					try
					{
						while (true)
						{
							int num3;
							if (!C0oChMEViSgfnsRYMXiJ(enumerator))
							{
								num3 = 0;
								if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
								{
									num3 = 0;
								}
								goto IL_02d4;
							}
							goto IL_0310;
							IL_0310:
							enumerator.Current.Process(callInfo, orAdd);
							num3 = 2;
							goto IL_02d4;
							IL_02d4:
							switch (num3)
							{
							default:
								return;
							case 0:
								return;
							case 2:
								break;
							case 1:
								goto IL_0310;
							}
						}
					}
					finally
					{
						if (enumerator != null)
						{
							int num4 = 1;
							if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 != 0)
							{
								num4 = 1;
							}
							while (true)
							{
								switch (num4)
								{
								case 1:
									enumerator.Dispose();
									num4 = 0;
									if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 != 0)
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
				}
				IL_0228:
				orAdd2 = container.GetOrAdd<WebRequestMetric>();
				num2 = 15;
				break;
			}
		}
	}

	private static string CutUrl(object url)
	{
		//Discarded unreachable code: IL_00ba, IL_00c9, IL_00d9, IL_0132, IL_0142, IL_016a, IL_0179
		int num = 8;
		int num2 = num;
		int num5 = default(int);
		int num6 = default(int);
		int num3 = default(int);
		while (true)
		{
			int num4;
			switch (num2)
			{
			case 12:
				if (num5 == -1)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 != 0)
					{
						num2 = 1;
					}
					continue;
				}
				num6++;
				num2 = 9;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa == 0)
				{
					num2 = 3;
				}
				continue;
			case 9:
			case 10:
				if (num6 < 4)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 != 0)
					{
						num2 = 13;
					}
					continue;
				}
				goto case 11;
			case 7:
				num6 = 0;
				num2 = 10;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d9a1b5d233d64896814b49e8f6f09424 != 0)
				{
					num2 = 10;
				}
				continue;
			case 11:
				if (num5 >= 0)
				{
					num2 = 5;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c == 0)
					{
						num2 = 6;
					}
					continue;
				}
				goto default;
			case 3:
			case 13:
				num3 = NgePOcEVRp6hPscQ5D73(url, '/', num5 + 1);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 4;
				}
				continue;
			case 2:
				num4 = -1;
				break;
			case 4:
				if (num3 >= 0)
				{
					num2 = 5;
					continue;
				}
				goto case 2;
			default:
				return (string)url;
			case 6:
				return (string)NRWGAUEVqBW9D7wGVpjW(url, 0, num5);
			case 1:
				return (string)url;
			case 8:
				num5 = -1;
				num2 = 7;
				continue;
			case 5:
				num4 = num3;
				break;
			}
			num5 = num4;
			num2 = 12;
		}
	}

	internal static object e4ZF9cEVCmpZO61OndTP(object P_0)
	{
		return ((CallContextInfo)P_0).Name;
	}

	internal static object kYtqTREVvlaUIF1K3CmF(object P_0, object P_1)
	{
		return (string)P_0 + (string)P_1;
	}

	internal static object uQCs8bEV8oZvucBO2tUo(object P_0)
	{
		return ((Uri)P_0).AbsolutePath;
	}

	internal static object W09dO1EVZrdblJ7olbEa(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object B0iKrlEVuxbH20xK8bGY(object P_0)
	{
		return CutUrl(P_0);
	}

	internal static object uKduqwEVIGHdTPgZwQHp(object P_0)
	{
		return ((CallContextInfo)P_0).HttpMethod;
	}

	internal static bool lxxd7HEVVWQMbFPejWcY(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}

	internal static object cETGVJEVS842TVnSPCjo(object P_0, object P_1, object P_2, object P_3)
	{
		return (string)P_0 + (string)P_1 + (string)P_2 + (string)P_3;
	}

	internal static bool C0oChMEViSgfnsRYMXiJ(object P_0)
	{
		return ((IEnumerator)P_0).MoveNext();
	}

	internal static bool UgxrcDEVfpBqPTEkfjqo()
	{
		return zrN2DrEVELhmouoPpSBB == null;
	}

	internal static WebRequestMetricAggregator HW0a5SEVQKsnHpuKtk5N()
	{
		return zrN2DrEVELhmouoPpSBB;
	}

	internal static int NgePOcEVRp6hPscQ5D73(object P_0, char P_1, int P_2)
	{
		return ((string)P_0).IndexOf(P_1, P_2);
	}

	internal static object NRWGAUEVqBW9D7wGVpjW(object P_0, int P_1, int P_2)
	{
		return ((string)P_0).Substring(P_1, P_2);
	}
}
