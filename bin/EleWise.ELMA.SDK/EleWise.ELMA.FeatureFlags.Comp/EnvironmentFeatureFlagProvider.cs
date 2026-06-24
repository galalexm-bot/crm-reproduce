using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using EleWise.ELMA.Scheduling;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FeatureFlags.Components;

[Component(Order = int.MaxValue)]
internal sealed class EnvironmentFeatureFlagProvider : BaseFeatureFlagProvider
{
	[Component]
	private sealed class SweepHandler : ISweepHandler
	{
		private readonly object environmentFeatureFlagProvider;

		private DateTime needUpdate;

		private static object dRo2MsvdfQVGHQrMQ3dp;

		public SweepHandler(EnvironmentFeatureFlagProvider environmentFeatureFlagProvider)
		{
			//Discarded unreachable code: IL_003a, IL_003f
			uYxESfvdvOwvre33ttxd();
			needUpdate = DateTime.MinValue;
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a0c414bdc0434c3eaa6f04f817c310b0 != 0)
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
				this.environmentFeatureFlagProvider = environmentFeatureFlagProvider;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num = 0;
				}
			}
		}

		public void Execute()
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
					if (L3W4i8vd8WtroWOdlOWT(DateTime.Now, needUpdate))
					{
						num2 = 2;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 != 0)
						{
							num2 = 0;
						}
						break;
					}
					return;
				case 2:
					needUpdate = qmtH9evdZpLlatIQyPkh().AddSeconds(SR.GetSetting((string)Gb3niGvdudDlJyqHE7v9(-1411196499 ^ -1410920721), 60));
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				case 1:
					Qxy0vvvdIIfIiRTUedYJ(environmentFeatureFlagProvider);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}

		internal static void uYxESfvdvOwvre33ttxd()
		{
			SingletonReader.JJCZtPuTvSt();
		}

		internal static bool POr7kevdQKyjxmXarpkV()
		{
			return dRo2MsvdfQVGHQrMQ3dp == null;
		}

		internal static SweepHandler gmS2CkvdC489xEE4KXYX()
		{
			return (SweepHandler)dRo2MsvdfQVGHQrMQ3dp;
		}

		internal static bool L3W4i8vd8WtroWOdlOWT(DateTime P_0, DateTime P_1)
		{
			return P_0 >= P_1;
		}

		internal static DateTime qmtH9evdZpLlatIQyPkh()
		{
			return DateTime.Now;
		}

		internal static object Gb3niGvdudDlJyqHE7v9(int _0020)
		{
			return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
		}

		internal static void Qxy0vvvdIIfIiRTUedYJ(object P_0)
		{
			((EnvironmentFeatureFlagProvider)P_0).Refresh();
		}
	}

	private readonly ILogger logger;

	private IDictionary<string, bool?> flags;

	private IDictionary<string, string> processVariables;

	internal static EnvironmentFeatureFlagProvider x8alaZGWmCTi3JBYjHkP;

	public override IEnumerable<(string featureFlagName, bool enabled)> GetFlags(IEnumerable<string> featureFlagNames)
	{
		if (featureFlagNames.Count(delegate(string n)
		{
			//Discarded unreachable code: IL_0031
			int num = 1;
			int num2 = num;
			bool? flag = default(bool?);
			while (true)
			{
				switch (num2)
				{
				case 3:
					flag = (flags[n] = null);
					num2 = 2;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a02ab4fa1d754ab68780a29277390de4 == 0)
					{
						num2 = 1;
					}
					break;
				case 2:
					return flag.HasValue;
				default:
					return false;
				case 1:
					if (flags.ContainsKey(n))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0dfdb869b74a443a9aa8cf63563b0d22 == 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				}
			}
		}) > 0)
		{
			Refresh();
		}
		return from p in flags
			where p.Value.HasValue
			select (p.Key, p.Value.Value);
	}

	private void Refresh()
	{
		//Discarded unreachable code: IL_00fd, IL_010c
		int num = 6;
		int num2 = num;
		_003C_003Ec__DisplayClass5_0 _003C_003Ec__DisplayClass5_ = default(_003C_003Ec__DisplayClass5_0);
		while (true)
		{
			switch (num2)
			{
			case 4:
				if (v2PS43GWd8kj84xcU0pa(flags) == _003C_003Ec__DisplayClass5_.newFlags.Count)
				{
					num2 = 9;
					continue;
				}
				goto case 3;
			case 1:
				return;
			case 3:
				flags = _003C_003Ec__DisplayClass5_.newFlags;
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_72b576a8bec0469a88a683e1609e22de == 0)
				{
					num2 = 10;
				}
				continue;
			case 5:
				iUEGOYGW9uDjOf5FNrD4(logger, uo36E4GWJhfCvRPCmOSY(-1765851862 ^ -1766028786));
				num2 = 8;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 == 0)
				{
					num2 = 1;
				}
				continue;
			case 9:
				if (!flags.Any(_003C_003Ec__DisplayClass5_._003CRefresh_003Eb__0))
				{
					return;
				}
				num2 = 3;
				continue;
			case 10:
				if (!logger.IsInfoEnabled())
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			default:
				FlagsChanged();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num2 = 0;
				}
				continue;
			case 6:
				_003C_003Ec__DisplayClass5_ = new _003C_003Ec__DisplayClass5_0();
				num2 = 5;
				continue;
			case 8:
				_003C_003Ec__DisplayClass5_.newFlags = ReadFlags();
				num2 = 4;
				continue;
			case 2:
				break;
			}
			logger.InfoFormat((string)uo36E4GWJhfCvRPCmOSY(0x2ACE37D ^ 0x2AF540B), string.Concat(from p in flags
				where p.Value.HasValue
				select Environment.NewLine + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1146510045 ^ -1146423073) + p.Key + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1867198571 ^ -1867208767) + p.Value));
			num2 = 7;
		}
	}

	private IDictionary<string, bool?> ReadFlags()
	{
		IDictionary environmentVariables = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User);
		IDictionary environmentVariables2 = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Machine);
		if (processVariables == null)
		{
			lock (this)
			{
				if (processVariables == null)
				{
					IDictionary environmentVariables3 = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Process);
					Dictionary<string, string> dictionary = new Dictionary<string, string>();
					IDictionaryEnumerator enumerator = environmentVariables3.GetEnumerator();
					while (enumerator.MoveNext())
					{
						string key = (string)enumerator.Key;
						string text = (string)enumerator.Value;
						bool num;
						if (!environmentVariables.Contains(key))
						{
							if (!environmentVariables2.Contains(key))
							{
								goto IL_00b8;
							}
							num = (string)environmentVariables2[key] != text;
						}
						else
						{
							num = (string)environmentVariables[key] != text;
						}
						if (!num)
						{
							continue;
						}
						goto IL_00b8;
						IL_00b8:
						dictionary.Add(key, text);
					}
					processVariables = dictionary;
				}
			}
		}
		Dictionary<string, bool?> dictionary2 = new Dictionary<string, bool?>();
		foreach (string key3 in flags.Keys)
		{
			string key2 = string.Format(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x2ACE37D ^ 0x2AF54CD), key3);
			if (!processVariables.TryGetValue(key2, out var value))
			{
				value = (environmentVariables.Contains(key2) ? ((string)environmentVariables[key2]) : (environmentVariables2.Contains(key2) ? ((string)environmentVariables2[key2]) : null));
			}
			bool result;
			if (value == null)
			{
				dictionary2.Add(key3, null);
			}
			else if (bool.TryParse(value, out result))
			{
				dictionary2.Add(key3, result);
			}
			else if (logger.IsDebugEnabled())
			{
				logger.Debug(SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-87337865 ^ -87497805), key3));
			}
		}
		return dictionary2;
	}

	public EnvironmentFeatureFlagProvider()
	{
		//Discarded unreachable code: IL_0054, IL_0059
		SingletonReader.JJCZtPuTvSt();
		logger = (ILogger)FZPZC3GWrLnmmm8rloaR(GjV4W3GWl1GF6fip4dEy(typeof(EnvironmentFeatureFlagProvider).TypeHandle));
		flags = new Dictionary<string, bool?>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object uo36E4GWJhfCvRPCmOSY(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void iUEGOYGW9uDjOf5FNrD4(object P_0, object P_1)
	{
		((ILogger)P_0).Debug(P_1);
	}

	internal static int v2PS43GWd8kj84xcU0pa(object P_0)
	{
		return ((ICollection<KeyValuePair<string, bool?>>)P_0).Count;
	}

	internal static bool yWOoEdGWypU9ouQ5HgCv()
	{
		return x8alaZGWmCTi3JBYjHkP == null;
	}

	internal static EnvironmentFeatureFlagProvider KnOSL5GWMm7dY6vesNOY()
	{
		return x8alaZGWmCTi3JBYjHkP;
	}

	internal static Type GjV4W3GWl1GF6fip4dEy(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object FZPZC3GWrLnmmm8rloaR(Type componentType)
	{
		return Logger.GetLogger(componentType);
	}
}
