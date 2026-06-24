using System;
using EleWise.ELMA.Helpers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime;

internal class DBStartInformation : StartInformation, IDisposable
{
	private IStartInformation parent;

	private string startMessage;

	private DatabaseConversionStage сurrentDatabaseConversionStage;

	private readonly string level;

	private static DBStartInformation UZfkUEWWCtFcqj8HpkUn;

	public DatabaseConversionStage CurrentDatabaseConversionStage
	{
		get
		{
			return сurrentDatabaseConversionStage;
		}
		set
		{
			int num = 1;
			int num2 = num;
			DBStartInformation dBStartInformation = default(DBStartInformation);
			while (true)
			{
				switch (num2)
				{
				case 3:
					return;
				case 2:
					dBStartInformation.сurrentDatabaseConversionStage = value;
					num2 = 3;
					continue;
				case 1:
					сurrentDatabaseConversionStage = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
					{
						num2 = 0;
					}
					continue;
				}
				if ((dBStartInformation = parent as DBStartInformation) == null)
				{
					return;
				}
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93eeb1d40f4c424ab62831b15d6e05c9 != 0)
				{
					num2 = 2;
				}
			}
		}
	}

	public override string Message
	{
		get
		{
			return (string)b5t8Y3WWVLNaDas88id3(parent);
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
					aldJAVWWqvpaS4NwCT69(parent, value);
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
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

	public DBStartInformation(DatabaseConversionStage databaseStage)
	{
		//Discarded unreachable code: IL_004b
		XsUY04WWZ6M1Nv4rVwWX();
		level = (string)mTBREqWWu5Jm5MjA8wTj(-234299632 ^ -234268636);
		base._002Ector();
		int num = 2;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_7b7601840955431b8667c611372f91fa != 0)
		{
			num = 4;
		}
		while (true)
		{
			switch (num)
			{
			case 1:
				StartInformation.Log((string)mTBREqWWu5Jm5MjA8wTj(-1487388570 ^ -1487288542), level);
				num = 2;
				break;
			default:
				Su897wWWi8eQJjgMYe9t(this, FABJEMWWS7m2NHJVDMRa(databaseStage));
				num = 3;
				break;
			case 4:
				CurrentDatabaseConversionStage = databaseStage;
				num = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37e63d3c4bb144b09fe829a19b51cda0 == 0)
				{
					num = 6;
				}
				break;
			case 6:
			{
				parent = (IStartInformation)x1tLGbWWI1wLxS0sXixW();
				int num2 = 5;
				num = num2;
				break;
			}
			case 5:
				startMessage = (string)b5t8Y3WWVLNaDas88id3(parent);
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca == 0)
				{
					num = 0;
				}
				break;
			case 3:
				RFCZEuWWRxBI2n7YX8T0(this);
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public void Dispose()
	{
		int num = 2;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 3:
				Su897wWWi8eQJjgMYe9t(this, startMessage);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_16c894429d6244cc9f83b8d6eb99434f == 0)
				{
					num2 = 0;
				}
				break;
			case 1:
				StartInformation.Log(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-951514650 ^ -951546188), level);
				num2 = 3;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_df8c1199d4ee43ff879aafd6e9e0eb50 == 0)
				{
					num2 = 2;
				}
				break;
			case 0:
				return;
			case 2:
				StartInformation.Current = parent;
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 != 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static void XsUY04WWZ6M1Nv4rVwWX()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object mTBREqWWu5Jm5MjA8wTj(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object x1tLGbWWI1wLxS0sXixW()
	{
		return StartInformation.Current;
	}

	internal static object b5t8Y3WWVLNaDas88id3(object P_0)
	{
		return ((IStartInformation)P_0).Message;
	}

	internal static object FABJEMWWS7m2NHJVDMRa(Enum enumValue)
	{
		return enumValue.GetDisplayName();
	}

	internal static void Su897wWWi8eQJjgMYe9t(object P_0, object P_1)
	{
		((StartInformation)P_0).Message = (string)P_1;
	}

	internal static void RFCZEuWWRxBI2n7YX8T0(object P_0)
	{
		StartInformation.Current = (IStartInformation)P_0;
	}

	internal static bool QC0skFWWvufha6bXrwjG()
	{
		return UZfkUEWWCtFcqj8HpkUn == null;
	}

	internal static DBStartInformation jOC63kWW8q0ykJQxVavD()
	{
		return UZfkUEWWCtFcqj8HpkUn;
	}

	internal static void aldJAVWWqvpaS4NwCT69(object P_0, object P_1)
	{
		((IStartInformation)P_0).Message = (string)P_1;
	}
}
