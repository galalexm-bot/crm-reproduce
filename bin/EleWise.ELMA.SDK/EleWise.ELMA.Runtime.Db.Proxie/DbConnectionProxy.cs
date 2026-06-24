using System;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Proxies;

public class DbConnectionProxy : DbConnection
{
	private DbConnection con;

	private readonly bool useSavePoint;

	private static DbConnectionProxy hvMewFWRIyM52c36WRdl;

	public DbConnection RealConnection => con;

	public override string ConnectionString
	{
		get
		{
			return con.ConnectionString;
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
					con.ConnectionString = value;
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ee36ee0e00aa4bb88c048d328bec496a == 0)
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

	public override int ConnectionTimeout => BYdOfOWRTDIKtfiIubHU(con);

	public override string Database => (string)wdxHQZWRnhtPEdcJd8GC(con);

	public override ConnectionState State => MbZ9GgWR2ag8RtQ8Gr8t(con);

	public Action<IDbCommand> OnCreateCommandAction { get; set; }

	public override string DataSource => (string)C34anGWRP7ahRiNcXRnx(con);

	public override string ServerVersion => (string)BwH5hsWR10IWpknTCRsS(con);

	public DbConnectionProxy(DbConnection con)
	{
		//Discarded unreachable code: IL_002c, IL_0031
		SingletonReader.JJCZtPuTvSt();
		this._002Ector(con, useSavePoint: true);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2d7babf4b803435ab9570024598726ad != 0)
		{
			num = 0;
		}
		switch (num)
		{
		case 0:
			break;
		}
	}

	internal DbConnectionProxy(DbConnection con, bool useSavePoint)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		at1sl5WRiMykvTy4DvYe();
		base._002Ector();
		int num = 2;
		while (true)
		{
			switch (num)
			{
			case 1:
				return;
			case 3:
				this.con = con;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 0;
				}
				break;
			default:
				this.useSavePoint = useSavePoint;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_47c00bb12a8f40498a02ade7a3f0c743 == 0)
				{
					num = 1;
				}
				break;
			case 2:
				Bgw2GdWRqNfZ2T96xjYe(con, dXUNLiWRRqvbFKjy5QXw(0xA592A41 ^ 0xA58DAB9));
				num = 3;
				break;
			}
		}
	}

	protected override DbTransaction BeginDbTransaction(IsolationLevel isolationLevel)
	{
		int num = 1;
		int num2 = num;
		DbTransaction dbTransaction = default(DbTransaction);
		while (true)
		{
			switch (num2)
			{
			case 2:
				return null;
			case 1:
				dbTransaction = (DbTransaction)wfTFFVWRKuMaZ1JAHKVJ(con, isolationLevel);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
				{
					num2 = 0;
				}
				continue;
			}
			if (dbTransaction != null)
			{
				return new DbTransactionProxy(this, dbTransaction);
			}
			num2 = 2;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_37fe2efeeb56441a830185f7cf0c9d6c != 0)
			{
				num2 = 2;
			}
		}
	}

	public override void ChangeDatabase(string databaseName)
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
				WN6c9HWRXlNwCyQYH9ED(con, databaseName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_29bc2b13092d45ecbd50d37e69edcea3 == 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public override void Close()
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
				con.Close();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_492bfe2bca86475c8862cc1fbc6ace80 == 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	protected override DbCommand CreateDbCommand()
	{
		//Discarded unreachable code: IL_0099, IL_00a8, IL_00d9, IL_00e8
		int num = 5;
		int num2 = num;
		DbCommand dbCommand = default(DbCommand);
		while (true)
		{
			switch (num2)
			{
			case 3:
				return null;
			case 6:
				return new DbCommandProxy(dbCommand, useSavePoint);
			case 2:
				OnCreateCommandAction(dbCommand);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
				{
					num2 = 0;
				}
				break;
			case 4:
				if (OnCreateCommandAction == null)
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_0fccd96656ea48d1886d99390ad7486e == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 2;
			default:
				if (dbCommand != null)
				{
					num2 = 6;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
					{
						num2 = 0;
					}
					break;
				}
				goto case 3;
			case 5:
				dbCommand = (DbCommand)BNySK4WRkH5ZIK7VVvmB(con);
				num2 = 4;
				break;
			}
		}
	}

	public override void Open()
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
				Ss41dbWROSTBILS7pSJG(con);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_bbf07dd8ec2749979513a053e4fc549b != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	public new void Dispose()
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
				lutMEOWReVjLL3sqxAV4(con);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	internal static bool DxZs8cWRVI1hy7xBwMxf()
	{
		return hvMewFWRIyM52c36WRdl == null;
	}

	internal static DbConnectionProxy vyrkmCWRSb9lB5EGCjxP()
	{
		return hvMewFWRIyM52c36WRdl;
	}

	internal static void at1sl5WRiMykvTy4DvYe()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static object dXUNLiWRRqvbFKjy5QXw(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static void Bgw2GdWRqNfZ2T96xjYe(object P_0, object P_1)
	{
		Contract.ArgumentNotNull(P_0, (string)P_1);
	}

	internal static object wfTFFVWRKuMaZ1JAHKVJ(object P_0, IsolationLevel P_1)
	{
		return ((DbConnection)P_0).BeginTransaction(P_1);
	}

	internal static void WN6c9HWRXlNwCyQYH9ED(object P_0, object P_1)
	{
		((DbConnection)P_0).ChangeDatabase((string)P_1);
	}

	internal static int BYdOfOWRTDIKtfiIubHU(object P_0)
	{
		return ((DbConnection)P_0).ConnectionTimeout;
	}

	internal static object BNySK4WRkH5ZIK7VVvmB(object P_0)
	{
		return ((DbConnection)P_0).CreateCommand();
	}

	internal static object wdxHQZWRnhtPEdcJd8GC(object P_0)
	{
		return ((DbConnection)P_0).Database;
	}

	internal static void Ss41dbWROSTBILS7pSJG(object P_0)
	{
		((DbConnection)P_0).Open();
	}

	internal static ConnectionState MbZ9GgWR2ag8RtQ8Gr8t(object P_0)
	{
		return ((DbConnection)P_0).State;
	}

	internal static void lutMEOWReVjLL3sqxAV4(object P_0)
	{
		((Component)P_0).Dispose();
	}

	internal static object C34anGWRP7ahRiNcXRnx(object P_0)
	{
		return ((DbConnection)P_0).DataSource;
	}

	internal static object BwH5hsWR10IWpknTCRsS(object P_0)
	{
		return ((DbConnection)P_0).ServerVersion;
	}
}
