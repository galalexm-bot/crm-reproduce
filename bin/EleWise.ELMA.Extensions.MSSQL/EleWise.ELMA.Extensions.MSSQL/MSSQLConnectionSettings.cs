using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Runtime.CompilerServices;
using System.Xml.Serialization;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Extensions.MSSQL;

public class MSSQLConnectionSettings
{
	private static MSSQLConnectionSettings qDYbf5SQH5hvExfgD5;

	[XmlElement]
	public Guid ProviderUid => MSSQLProvider.UID;

	[XmlElement]
	public string ServerName
	{
		[CompilerGenerated]
		get
		{
			return _003CServerName_003Ek__BackingField;
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
				case 1:
					_003CServerName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_ec5f92fd6ddb449a9afc09c18f0a77db != 0)
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

	[XmlElement]
	public string DatabaseName
	{
		[CompilerGenerated]
		get
		{
			return _003CDatabaseName_003Ek__BackingField;
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
				case 1:
					_003CDatabaseName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_a20e3edfdf494639a8a8084ef15a8911 == 0)
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

	[XmlElement]
	public string DbPath
	{
		[CompilerGenerated]
		get
		{
			return _003CDbPath_003Ek__BackingField;
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
					_003CDbPath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_11b18682a5a544c7bb53148fce1a13cb != 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement]
	public string LogPath
	{
		[CompilerGenerated]
		get
		{
			return _003CLogPath_003Ek__BackingField;
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
					_003CLogPath_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_1ac7b80080314bbdb29619485c5fbb66 == 0)
					{
						num2 = 0;
					}
					break;
				}
			}
		}
	}

	[XmlElement]
	public bool IntegratedSecurity
	{
		[CompilerGenerated]
		get
		{
			return _003CIntegratedSecurity_003Ek__BackingField;
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
				case 1:
					_003CIntegratedSecurity_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_611f69e7a7a34a4fbeb0099afc53aecd == 0)
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

	[XmlElement]
	public string UserName
	{
		[CompilerGenerated]
		get
		{
			return _003CUserName_003Ek__BackingField;
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
				case 1:
					_003CUserName_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_595bc6899ac747d989e6cbc941c80562 == 0)
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

	[XmlElement]
	public string Password
	{
		[CompilerGenerated]
		get
		{
			return _003CPassword_003Ek__BackingField;
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
				case 1:
					_003CPassword_003Ek__BackingField = value;
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_e4ca8eb6304c45b5b9866ec7523159cd != 0)
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

	public MSSQLConnectionSettings()
	{
		//Discarded unreachable code: IL_001a, IL_001f
		MQsEXGPMdLsukYkFf5();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 5:
				return;
			case 1:
				LogPath = (string)E7h0o7anLhhKDtL4yS(-800941032 ^ -800940834);
				num = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_50026842ab044d008d304fc8fda891b4 != 0)
				{
					num = 0;
				}
				break;
			case 4:
				DatabaseName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(-800941032 ^ -800940900);
				num = 3;
				break;
			case 2:
				ServerName = SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x51286021 ^ 0x51286079);
				num = 4;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_8b024ba6fa664698aa135d9537ef281b == 0)
				{
					num = 4;
				}
				break;
			default:
				IntegratedSecurity = true;
				num = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_80b6e3007a3e4355a8078b16fb1979e5 != 0)
				{
					num = 5;
				}
				break;
			case 3:
				DbPath = (string)E7h0o7anLhhKDtL4yS(0x51286021 ^ 0x512860BB);
				num = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_bb662a6d5969493581c2c367e740adde == 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	protected SqlConnectionStringBuilder CreateConnectionStringBuilder()
	{
		//Discarded unreachable code: IL_0062, IL_0071, IL_00bf
		int num = 2;
		int num2 = num;
		SqlConnectionStringBuilder sqlConnectionStringBuilder = default(SqlConnectionStringBuilder);
		while (true)
		{
			switch (num2)
			{
			default:
				return sqlConnectionStringBuilder;
			case 5:
				if (VLHwnL2Q09aMsJiNLE(Password))
				{
					num2 = 3;
					break;
				}
				goto case 7;
			case 8:
				mdNO7JWTn3p2vH7b2H(sqlConnectionStringBuilder, UserName);
				num2 = 5;
				break;
			case 7:
				mqQklE7PS2ToP5mdHp(sqlConnectionStringBuilder, Password);
				num2 = 0;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_937e86e483374781b74ae1d5b232cdfa != 0)
				{
					num2 = 6;
				}
				break;
			case 2:
				sqlConnectionStringBuilder = new SqlConnectionStringBuilder
				{
					DataSource = ServerName,
					InitialCatalog = DatabaseName,
					IntegratedSecurity = IntegratedSecurity
				};
				num2 = 1;
				if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_5ae23e79a5ef4ec9a6a58c0daa87c096 != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (!string.IsNullOrEmpty(UserName))
				{
					num2 = 8;
					break;
				}
				goto case 5;
			case 1:
				if (IntegratedSecurity)
				{
					num2 = 0;
					if (_003CModule_003E_007B378f8dd0_002D89d6_002D413b_002Dbd77_002Df432504b0fcd_007D.m_dda363349c784d1da4ad7d915f94c5c7 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 4;
			}
		}
	}

	public string BuildConnectionString()
	{
		return (string)sGqJZ33JnOJGTv9orn(CreateConnectionStringBuilder());
	}

	public string BuildMasterConnectionString()
	{
		SqlConnectionStringBuilder sqlConnectionStringBuilder = CreateConnectionStringBuilder();
		MBwoqYzAWOaEZpZlXm(sqlConnectionStringBuilder, SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x63BC7D18 ^ 0x63BC7DEA));
		return (string)sGqJZ33JnOJGTv9orn(sqlConnectionStringBuilder);
	}

	internal static void MQsEXGPMdLsukYkFf5()
	{
		j3AmrhgkCleVTGdEwA.TKW1L3mlUyvXmg29jA.BPCyhsoin5();
	}

	internal static object E7h0o7anLhhKDtL4yS(int _0020)
	{
		return SG9KiyIbtdgGDf12qr.z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool LhxaXY1M5HwEmQumSo()
	{
		return qDYbf5SQH5hvExfgD5 == null;
	}

	internal static MSSQLConnectionSettings YQBRAJrkuupUrFZjJI()
	{
		return qDYbf5SQH5hvExfgD5;
	}

	internal static void mdNO7JWTn3p2vH7b2H(object P_0, object P_1)
	{
		((SqlConnectionStringBuilder)P_0).UserID = (string)P_1;
	}

	internal static bool VLHwnL2Q09aMsJiNLE(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void mqQklE7PS2ToP5mdHp(object P_0, object P_1)
	{
		((SqlConnectionStringBuilder)P_0).Password = (string)P_1;
	}

	internal static object sGqJZ33JnOJGTv9orn(object P_0)
	{
		return ((DbConnectionStringBuilder)P_0).ConnectionString;
	}

	internal static void MBwoqYzAWOaEZpZlXm(object P_0, object P_1)
	{
		((SqlConnectionStringBuilder)P_0).InitialCatalog = (string)P_1;
	}
}
