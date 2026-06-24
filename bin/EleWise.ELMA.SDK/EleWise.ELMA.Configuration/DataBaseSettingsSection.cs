using System;
using System.Configuration;
using System.Runtime.CompilerServices;
using EleWise.ELMA.Services;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Configuration;

public class DataBaseSettingsSection : ProviderSettingsSection, IDataBaseSettingsSection
{
	public const string CONNECTIONSTRING_NAME = "connectionStringName";

	public const string BACKUPENABLED_NAME = "backupEnabled";

	public const string BACKUPPATH_NAME = "backupPath";

	public const string COMMANDTIMEOUT_NAME = "commandTimeOut";

	internal readonly ConfigurationProperty _connectionStringName;

	internal readonly ConfigurationProperty _backupEnabled;

	internal readonly ConfigurationProperty _backupPathName;

	internal readonly ConfigurationProperty _commandTimeout;

	private static DataBaseSettingsSection dlZVu7fBIW8HjY2KveE2;

	[ConfigurationProperty("connectionStringName", IsRequired = true)]
	public string ConnectionStringName
	{
		get
		{
			return (string)mVWPTSfBi1C9ZIo27TIC(this, _connectionStringName);
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
					base[_connectionStringName] = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public virtual string ConnectionString => ReplaceConfigDir((string)mjWdVLfBKU7Qa2xVjiAi(((ConnectionStringsSection)AGctr6fBqYThSpYqBOvh(uYK9O0fBRghMJGaZsuc0(this))).ConnectionStrings[ConnectionStringName]));

	public bool DropDatabaseOnStart
	{
		[CompilerGenerated]
		get
		{
			return _003CDropDatabaseOnStart_003Ek__BackingField;
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
					_003CDropDatabaseOnStart_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_b0d8078723fb4cd7add1c8a504713bc7 != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	public int ConnectionAttemptCount => 12;

	public int ConnectionAttemptInverval => 5;

	[ConfigurationProperty("backupEnabled", IsRequired = false)]
	public bool BackupEnabled
	{
		get
		{
			return (bool)base[_backupEnabled];
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
					c8nZEDfBXS6rGb2jc1ib(this, _backupEnabled, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_eadbf314103b4af9a709bbf0e589a800 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[ConfigurationProperty("backupPath", IsRequired = false)]
	public string BackupPath
	{
		get
		{
			//Discarded unreachable code: IL_008a, IL_0099
			int num = 2;
			int num2 = num;
			string text = default(string);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return null;
				default:
					return ReplaceConfigDir(text);
				case 1:
					if (text != null)
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_a01d4fae2aba43bda9f073c5c06aa84f != 0)
						{
							num2 = 0;
						}
						break;
					}
					goto case 3;
				case 2:
					text = (string)mVWPTSfBi1C9ZIo27TIC(this, _backupPathName);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 1;
					}
					break;
				}
			}
		}
	}

	[ConfigurationProperty("commandTimeOut", IsRequired = false)]
	public int? CommandTimeout => (int?)base[_commandTimeout];

	public void SetConnectionString(string name, string connectionString)
	{
		int num = 3;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				return;
			case 3:
				vPOJ7KfBkfcZfGsk8VhZ(NylNTgfBT38vMWWofB7y(AGctr6fBqYThSpYqBOvh(uYK9O0fBRghMJGaZsuc0(this))), name);
				num2 = 2;
				break;
			case 2:
				GaThfQfBnwvJeShSNRrq(NylNTgfBT38vMWWofB7y(AGctr6fBqYThSpYqBOvh(uYK9O0fBRghMJGaZsuc0(this))), new ConnectionStringSettings(name, connectionString));
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				ConnectionStringName = name;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_04a4903886db40b29c472d4e00e3df1f != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	public void SetBackupPath(string path)
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
				base[_backupPathName] = path;
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public void SetCommandTimeOut(int commandTimeOut)
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
				c8nZEDfBXS6rGb2jc1ib(this, _commandTimeout, commandTimeOut);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_19f552317f7a4b94a7e14811dca8c9ab == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override void Init()
	{
		base.Init();
	}

	public DataBaseSettingsSection()
	{
		//Discarded unreachable code: IL_00e8, IL_00ed
		SingletonReader.JJCZtPuTvSt();
		_connectionStringName = new ConfigurationProperty((string)RYv3QEfBO8qVuDTFl8Jk(-281842504 ^ -281641808), lTLenmfB2GMFyVT2LORE(typeof(string).TypeHandle), null);
		_backupEnabled = new ConfigurationProperty(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-1886646897 ^ -1886839365), typeof(bool), true);
		_backupPathName = new ConfigurationProperty((string)RYv3QEfBO8qVuDTFl8Jk(0x49E27B8A ^ 0x49E3BBF0), lTLenmfB2GMFyVT2LORE(typeof(string).TypeHandle), null);
		_commandTimeout = new ConfigurationProperty((string)RYv3QEfBO8qVuDTFl8Jk(0x1FFEF86A ^ 0x1FFBE838), typeof(int), null);
		base._002Ector();
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad == 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal static object mVWPTSfBi1C9ZIo27TIC(object P_0, object P_1)
	{
		return ((ConfigurationElement)P_0)[(ConfigurationProperty)P_1];
	}

	internal static bool F4tAGSfBVJhoVvy6aWUI()
	{
		return dlZVu7fBIW8HjY2KveE2 == null;
	}

	internal static DataBaseSettingsSection OUtRrwfBShxGYVKxHw7L()
	{
		return dlZVu7fBIW8HjY2KveE2;
	}

	internal static object uYK9O0fBRghMJGaZsuc0(object P_0)
	{
		return ((ConfigurationElement)P_0).CurrentConfiguration;
	}

	internal static object AGctr6fBqYThSpYqBOvh(object P_0)
	{
		return ((System.Configuration.Configuration)P_0).ConnectionStrings;
	}

	internal static object mjWdVLfBKU7Qa2xVjiAi(object P_0)
	{
		return ((ConnectionStringSettings)P_0).ConnectionString;
	}

	internal static void c8nZEDfBXS6rGb2jc1ib(object P_0, object P_1, object P_2)
	{
		((ConfigurationElement)P_0)[(ConfigurationProperty)P_1] = P_2;
	}

	internal static object NylNTgfBT38vMWWofB7y(object P_0)
	{
		return ((ConnectionStringsSection)P_0).ConnectionStrings;
	}

	internal static void vPOJ7KfBkfcZfGsk8VhZ(object P_0, object P_1)
	{
		((ConnectionStringSettingsCollection)P_0).Remove((string)P_1);
	}

	internal static void GaThfQfBnwvJeShSNRrq(object P_0, object P_1)
	{
		((ConnectionStringSettingsCollection)P_0).Add((ConnectionStringSettings)P_1);
	}

	internal static object RYv3QEfBO8qVuDTFl8Jk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static Type lTLenmfB2GMFyVT2LORE(RuntimeTypeHandle P_0)
	{
		return Type.GetTypeFromHandle(P_0);
	}
}
