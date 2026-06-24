using System;
using System.Data;
using System.Data.Common;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Proxies;

public class DbTransactionProxy : DbTransaction
{
	private DbConnectionProxy con;

	private DbTransaction tran;

	internal static DbTransactionProxy rbk3ddWRNS56pZG5K6pS;

	public DbTransaction RealTransaction => tran;

	protected override DbConnection DbConnection => con;

	public override IsolationLevel IsolationLevel => hjjhRwWRtsWWsEcsOE7W(tran);

	public DbTransactionProxy(DbConnectionProxy con, DbTransaction tran)
	{
		//Discarded unreachable code: IL_001a, IL_001f
		SingletonReader.JJCZtPuTvSt();
		base._002Ector();
		int num = 4;
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 3:
				this.tran = tran;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_39aeb7d35c1f4f868f1de891fbd20171 == 0)
				{
					num = 0;
				}
				break;
			case 0:
				return;
			case 1:
				throw new ArgumentNullException((string)bSUG9dWRaicWDAxoYnbM(-1317790512 ^ -1317671470));
			case 2:
				throw new ArgumentNullException((string)bSUG9dWRaicWDAxoYnbM(-1633514411 ^ -1633452883));
			case 4:
				if (con != null)
				{
					if (tran != null)
					{
						this.con = con;
						num = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_00111710bff240b2876edfc455f27786 == 0)
						{
							num = 2;
						}
					}
					else
					{
						num = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_52e895f6233c4dbeb9146c87fcf40c13 == 0)
						{
							num = 1;
						}
					}
				}
				else
				{
					num = 2;
				}
				break;
			}
		}
	}

	public override void Commit()
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
				KSs9vLWRDIyyyAEGVtDs(tran);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			}
		}
	}

	public override void Rollback()
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
				Pe5q4MWRwQ0gnu1c9jG2(tran);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ec123c2cff254dd299d869147df69b1c != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	protected override void Dispose(bool disposing)
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				CLkNZMWR4DeqintShNxh(tran);
				num2 = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3f79fc1df51f454c8144de48f315a54f != 0)
				{
					num2 = 2;
				}
				break;
			case 1:
				if (disposing)
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_59b03f350d954bbc969b0f21ae9c1bc8 == 0)
					{
						num2 = 0;
					}
					break;
				}
				return;
			case 2:
				return;
			}
		}
	}

	internal static object bSUG9dWRaicWDAxoYnbM(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static bool SeuhZeWR34Zao7MTQ2qf()
	{
		return rbk3ddWRNS56pZG5K6pS == null;
	}

	internal static DbTransactionProxy bS5v4WWRpiFWsCpvNf4B()
	{
		return rbk3ddWRNS56pZG5K6pS;
	}

	internal static void KSs9vLWRDIyyyAEGVtDs(object P_0)
	{
		((DbTransaction)P_0).Commit();
	}

	internal static IsolationLevel hjjhRwWRtsWWsEcsOE7W(object P_0)
	{
		return ((DbTransaction)P_0).IsolationLevel;
	}

	internal static void Pe5q4MWRwQ0gnu1c9jG2(object P_0)
	{
		((DbTransaction)P_0).Rollback();
	}

	internal static void CLkNZMWR4DeqintShNxh(object P_0)
	{
		((DbTransaction)P_0).Dispose();
	}
}
