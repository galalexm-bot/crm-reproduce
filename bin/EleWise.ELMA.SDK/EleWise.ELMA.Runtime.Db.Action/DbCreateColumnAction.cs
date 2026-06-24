using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Actions;

public class DbCreateColumnAction : DbAction
{
	private string tableName;

	private Column column;

	private static DbCreateColumnAction AW6lxxWKKTNknL0RjXa9;

	protected string TableName => tableName;

	protected Column Column => column;

	public DbCreateColumnAction(ITransformationProvider transform, string tableName, Column column)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		pBdGhGWKkwhPAuM3myKg();
		base._002Ector(transform);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_98b68f1bc8f8412da4e436206caef53e == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			default:
				this.tableName = tableName;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num = 1;
				}
				break;
			case 1:
				this.column = column;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_93e237849fe9450198ccc24b28d87fd7 == 0)
				{
					num = 2;
				}
				break;
			case 2:
				return;
			}
		}
	}

	public override void Execute()
	{
		int num = 2;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				default:
					return;
				case 1:
					if (DmryK2WKOYHCP8TkxjCX(base.Transform, tableName, DiSt37WKnBtlGtBjTPkp(column)))
					{
						num2 = 5;
						continue;
					}
					if (string.IsNullOrEmpty(base.LogMessage))
					{
						num2 = 7;
						continue;
					}
					goto case 6;
				case 2:
					base.Execute();
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_268e44f55b32445ea3b8cdc029b0ffca != 0)
					{
						num2 = 1;
					}
					continue;
				case 6:
					WriteLogMessage();
					num2 = 4;
					continue;
				case 3:
					return;
				case 4:
					break;
				case 0:
					return;
				case 5:
					EJWQWaWK1nXi2ncKwjed(nOqQmDWK2WakgTiVhdry(), oyAWCuWKPHfI6npBYKsF(EFuUVuWKeeOfPCdAsKMO(0x4DC2B14D ^ 0x4DC3440D), DiSt37WKnBtlGtBjTPkp(column), tableName));
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_244a161c0e654262868d382e552e43fc == 0)
					{
						num2 = 0;
					}
					continue;
				case 7:
					base.LogMessage = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-583745292 ^ -583715476), DiSt37WKnBtlGtBjTPkp(column), (yAwg2cWKN4ZYPiCu8vrc(column) != null) ? yAwg2cWKN4ZYPiCu8vrc(column).ToString() : "", tableName);
					num2 = 6;
					continue;
				}
				break;
			}
			Tj435FWK3J7eN6jaxFqy(base.Transform, tableName, column);
			num = 3;
		}
	}

	internal static void pBdGhGWKkwhPAuM3myKg()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool FoAGlFWKXt3W7yWPkWA7()
	{
		return AW6lxxWKKTNknL0RjXa9 == null;
	}

	internal static DbCreateColumnAction Wiw3XvWKTDS5tyLNNMv7()
	{
		return AW6lxxWKKTNknL0RjXa9;
	}

	internal static object DiSt37WKnBtlGtBjTPkp(object P_0)
	{
		return ((Column)P_0).Name;
	}

	internal static bool DmryK2WKOYHCP8TkxjCX(object P_0, object P_1, object P_2)
	{
		return ((ITransformationProvider)P_0).ColumnExists((string)P_1, (string)P_2);
	}

	internal static object nOqQmDWK2WakgTiVhdry()
	{
		return Logger.Log;
	}

	internal static object EFuUVuWKeeOfPCdAsKMO(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object oyAWCuWKPHfI6npBYKsF(object P_0, object P_1, object P_2)
	{
		return string.Format((string)P_0, P_1, P_2);
	}

	internal static void EJWQWaWK1nXi2ncKwjed(object P_0, object P_1)
	{
		((ILogger)P_0).Warn(P_1);
	}

	internal static object yAwg2cWKN4ZYPiCu8vrc(object P_0)
	{
		return ((Column)P_0).ColumnType;
	}

	internal static void Tj435FWK3J7eN6jaxFqy(object P_0, object P_1, object P_2)
	{
		((ITransformationProvider)P_0).AddColumn((string)P_1, (Column)P_2);
	}
}
