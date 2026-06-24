using System;
using System.ComponentModel;
using System.Configuration;
using System.IO;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Configuration;

public abstract class ProviderSettingsSection : ConfigurationSection
{
	public const string CONFIGDIR = "{CONFIGDIR}";

	public const string PROVIDERTYPE = "type";

	private readonly ConfigurationProperty _providerType;

	protected bool? _autoInitialize;

	private static ProviderSettingsSection tH2OUDfB39DnrvDUFtdV;

	[TypeConverter(typeof(TypeNameConverter))]
	[ConfigurationProperty("type", IsRequired = true, IsKey = true)]
	public virtual Type ProviderType
	{
		get
		{
			return (Type)base[_providerType];
		}
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
				case 1:
					W7wcHpfB6f4hfBA5py1o(this, _providerType, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_81bb88e57a714795bc455699bc5b7759 != 0)
					{
						num2 = 0;
					}
					break;
				case 0:
					return;
				}
			}
		}
	}

	public bool AutoInitialize
	{
		get
		{
			int num = 2;
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 2:
					if (!_autoInitialize.HasValue)
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bd835efae1574af2ac4da19dc9e1e955 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					break;
				case 1:
					JxlrvvfBHfIhnSuCrHBc(this);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_54308cf0e33a467f944ef8392bb5fdde != 0)
					{
						num2 = 0;
					}
					continue;
				}
				break;
			}
			return _autoInitialize.Value;
		}
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
					_autoInitialize = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	protected virtual void InitializeAutoInitilize()
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
				_autoInitialize = true;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_6bc030c0637249eea635df8662eae071 != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected string CombinePath(string path)
	{
		int num = 1;
		int num2 = num;
		string text = default(string);
		while (true)
		{
			switch (num2)
			{
			case 1:
				text = (string)DhlA8afBtrF2L87a4XJl(((System.Configuration.Configuration)pwRO69fBDnviVnKRKOJe(this)).FilePath);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				return ReplaceConfigDir((string)((text != null) ? KRTQQvfBwP6FoApPK4yn(text, path) : path));
			}
		}
	}

	protected string ReplaceConfigDir(string path)
	{
		return path.Replace((string)WVtppCfB4mFDLS0AIWAQ(0xD3DEF7E ^ 0xD38FF0C), Path.GetDirectoryName(((System.Configuration.Configuration)pwRO69fBDnviVnKRKOJe(this)).FilePath));
	}

	protected ProviderSettingsSection()
	{
		//Discarded unreachable code: IL_005b, IL_0060
		kZghpIfBAuxBiSbXq08X();
		_providerType = new ConfigurationProperty((string)WVtppCfB4mFDLS0AIWAQ(0xA592A41 ^ 0xA592663), pKUehlfB7nTXu5XLItoV(typeof(Type).TypeHandle), null);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8b9644d563494ceab5d9c10e75f2bcad != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static bool SDVaGbfBpPcFEWIEFl9x()
	{
		return tH2OUDfB39DnrvDUFtdV == null;
	}

	internal static ProviderSettingsSection u7LHXDfBar1ie21rbZDW()
	{
		return tH2OUDfB39DnrvDUFtdV;
	}

	internal static object pwRO69fBDnviVnKRKOJe(object P_0)
	{
		return ((ConfigurationElement)P_0).CurrentConfiguration;
	}

	internal static object DhlA8afBtrF2L87a4XJl(object P_0)
	{
		return Path.GetDirectoryName((string)P_0);
	}

	internal static object KRTQQvfBwP6FoApPK4yn(object P_0, object P_1)
	{
		return Path.Combine((string)P_0, (string)P_1);
	}

	internal static object WVtppCfB4mFDLS0AIWAQ(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void W7wcHpfB6f4hfBA5py1o(object P_0, object P_1, object P_2)
	{
		((ConfigurationElement)P_0)[(ConfigurationProperty)P_1] = P_2;
	}

	internal static void JxlrvvfBHfIhnSuCrHBc(object P_0)
	{
		((ProviderSettingsSection)P_0).InitializeAutoInitilize();
	}

	internal static void kZghpIfBAuxBiSbXq08X()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static Type pKUehlfB7nTXu5XLItoV(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
