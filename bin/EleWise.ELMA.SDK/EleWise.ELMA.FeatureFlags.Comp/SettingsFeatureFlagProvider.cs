using System;
using System.Collections.Generic;
using System.Linq;
using EleWise.ELMA.ComponentModel;
using EleWise.ELMA.Logging;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.FeatureFlags.Components;

[Component(Order = int.MinValue)]
internal sealed class SettingsFeatureFlagProvider : BaseFeatureFlagProvider
{
	internal sealed class SettingsFeatureFlagContainer
	{
		private IDictionary<string, bool> flags;

		private SettingsFeatureFlagProvider provider;

		internal static SettingsFeatureFlagContainer d4F56RvdkSO2kdlU2MhQ;

		public void Init(SettingsFeatureFlagProvider provider)
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 2:
					this.provider = provider;
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9be861c1d5d64174abecdbcc36b266e2 == 0)
					{
						num2 = 1;
					}
					break;
				case 0:
					return;
				case 1:
					SR.GetSetting("");
					num2 = 4;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_cebf92db673a44f7983e8b89457554a8 == 0)
					{
						num2 = 4;
					}
					break;
				case 3:
					flags = null;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9ee8734c26fc4d13b81838e1e46f2545 == 0)
					{
						num2 = 0;
					}
					break;
				case 4:
					provider.UpdateFlags(flags);
					num2 = 3;
					break;
				}
			}
		}

		public void UpdateFlags(IDictionary<string, string> settigsStrings)
		{
			bool result;
			Dictionary<string, bool> newFlags = (from p in settigsStrings
				select (!bool.TryParse(p.Value, out result)) ? (null, false) : (p.Key, result) into p
				where p.Key != null
				select p).ToDictionary<(string, bool), string, bool>(((string Key, bool value) p) => p.Key, ((string Key, bool value) p) => p.value);
			if (provider == null)
			{
				flags = newFlags;
			}
			else
			{
				provider.UpdateFlags(newFlags);
			}
		}

		public SettingsFeatureFlagContainer()
		{
			//Discarded unreachable code: IL_002a, IL_002f
			Cxel3Cvd2oqvEtC1jVST();
			base._002Ector();
			int num = 0;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee != 0)
			{
				num = 0;
			}
			switch (num)
			{
			case 0:
				break;
			}
		}

		internal static bool oLbIjYvdnNVnw5c6wfqP()
		{
			return d4F56RvdkSO2kdlU2MhQ == null;
		}

		internal static SettingsFeatureFlagContainer AF0i61vdOskl5gtcLqYj()
		{
			return d4F56RvdkSO2kdlU2MhQ;
		}

		internal static void Cxel3Cvd2oqvEtC1jVST()
		{
			SingletonReader.JJCZtPuTvSt();
		}
	}

	private readonly ILogger logger;

	private ISet<string> flagNames;

	private IDictionary<string, bool> flags;

	internal static SettingsFeatureFlagProvider Ui3HvPGWgLDZ9cThXJt4;

	private bool IsLogEnabled => logger.IsInfoEnabled();

	internal static SettingsFeatureFlagContainer Container { get; }

	public SettingsFeatureFlagProvider()
	{
		//Discarded unreachable code: IL_0054, IL_0059
		tSSV0SGWYUJy840a30E8();
		logger = (ILogger)clBIgSGWUyXt2SdKqSEc(MJTg23GWLF3KWhxo7gqO(typeof(SettingsFeatureFlagProvider).TypeHandle));
		flagNames = new HashSet<string>();
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fe531aa729e241e9a48ba8046819805f != 0)
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
			oNuq3HGWsuGN9QmmAugW(Container, this);
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 != 0)
			{
				num = 0;
			}
		}
	}

	public override IEnumerable<(string featureFlagName, bool enabled)> GetFlags(IEnumerable<string> featureFlagNames)
	{
		int num = (IsLogEnabled ? flags.Count((KeyValuePair<string, bool> p) => flagNames.Contains(p.Key)) : 0);
		flagNames.UnionWith(featureFlagNames);
		if (IsLogEnabled && num < flags.Count((KeyValuePair<string, bool> p) => flagNames.Contains(p.Key)))
		{
			Log();
		}
		bool value;
		return from name in flagNames
			select (!flags.TryGetValue(name, out value)) ? (null, false) : (name, value) into p
			where p.name != null
			select p;
	}

	private void UpdateFlags(IDictionary<string, bool> newFlags)
	{
		_003C_003Ec__DisplayClass5_0 CS_0024_003C_003E8__locals0 = new _003C_003Ec__DisplayClass5_0();
		CS_0024_003C_003E8__locals0.newFlags = newFlags;
		if (flags == null || flags.Count != CS_0024_003C_003E8__locals0.newFlags.Count || flags.Any((KeyValuePair<string, bool> p) => !CS_0024_003C_003E8__locals0.newFlags.TryGetValue(p.Key, out var value) || value != p.Value))
		{
			flags = CS_0024_003C_003E8__locals0.newFlags;
			Log();
			FlagsChanged();
		}
	}

	private void Log()
	{
		//Discarded unreachable code: IL_005b, IL_006a
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 3:
				return;
			case 2:
				if (!IsLogEnabled)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8e162152046c4c96ae0975f28cad631a == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto default;
			default:
				if (PgFAPcGWcV4DRgxUgkKs(flagNames) <= 0)
				{
					return;
				}
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0bd38a82655b469e9354577f70c3d203 != 0)
				{
					num2 = 4;
				}
				break;
			case 4:
				logger.InfoFormat((string)uIKS83GWz0hqhRk5EqTt(0x5F3078B6 ^ 0x5F33C0A4), string.Concat(from p in flags
					where flagNames.Contains(p.Key)
					select Environment.NewLine + z2jc63fLkugS1X8Q9N.tE1kD1vbB(-281842504 ^ -282054332) + p.Key + z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x17ADCCD8 ^ 0x17ADA48C) + p.Value));
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_c9a2a8afc3e647b98935683a927c4d12 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	static SettingsFeatureFlagProvider()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 1:
				Container = new SettingsFeatureFlagContainer();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_be561ee5ed0744d2ad69f101b5b7e9db == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				SingletonReader.JJCZtPuTvSt();
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static void tSSV0SGWYUJy840a30E8()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type MJTg23GWLF3KWhxo7gqO(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}

	internal static object clBIgSGWUyXt2SdKqSEc(Type componentType)
	{
		return Logger.GetLogger(componentType);
	}

	internal static void oNuq3HGWsuGN9QmmAugW(object P_0, object P_1)
	{
		((SettingsFeatureFlagContainer)P_0).Init((SettingsFeatureFlagProvider)P_1);
	}

	internal static bool rKGxR8GW58YEXyIVyEKx()
	{
		return Ui3HvPGWgLDZ9cThXJt4 == null;
	}

	internal static SettingsFeatureFlagProvider XbHcPcGWjYk3UXVeNx0F()
	{
		return Ui3HvPGWgLDZ9cThXJt4;
	}

	internal static int PgFAPcGWcV4DRgxUgkKs(object P_0)
	{
		return ((ICollection<string>)P_0).Count;
	}

	internal static object uIKS83GWz0hqhRk5EqTt(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
