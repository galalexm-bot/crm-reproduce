using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Actions;

public class DbCreateTableAction : DbAction
{
	private Table table;

	internal static DbCreateTableAction eEyciWWK7YScZBiPxaLj;

	protected Table Table => table;

	public DbCreateTableAction(ITransformationProvider transform, Table table)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(transform);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9383086aadb74aeb89b6e9679eb8ddba == 0)
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
			this.table = table;
			num = 1;
			if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f8a3de6cc1514b44b05f1adc91e1e486 != 0)
			{
				num = 0;
			}
		}
	}

	public override void Execute()
	{
		//Discarded unreachable code: IL_010e, IL_011d
		int num = 4;
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 4:
					base.Execute();
					num = 3;
					break;
				case 5:
					return;
				case 1:
					if (kbf5ElWKlQFIa1GoeB4K(base.LogMessage))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 8;
				case 6:
					kp3D0TWKdtDKMKpGTRLZ(QqqnxNWKMMABw5j4nBtr(), LL9ct3WK9t6AgfXrppx1(Xvooc4WKJfqdoEjJI6Jk(0x1FFEF86A ^ 0x1FFF0E0E), AmSMN0WKmt5JGrYASNbB(Table)));
					num2 = 5;
					continue;
				case 7:
					jumUBLWKrlHpRhSojOyt(base.Transform, Table);
					num2 = 2;
					continue;
				case 3:
					if (!pPKBaOWKy98vJgEkXlnI(base.Transform, AmSMN0WKmt5JGrYASNbB(Table)))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 != 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 6;
				case 2:
					return;
				case 8:
					WriteLogMessage();
					num2 = 7;
					continue;
				default:
					base.LogMessage = SR.T((string)Xvooc4WKJfqdoEjJI6Jk(-2138160520 ^ -2138065692), Table.Name);
					num = 8;
					break;
				}
				break;
			}
		}
	}

	internal static bool I3ginGWKxyJSyGUspVPa()
	{
		return eEyciWWK7YScZBiPxaLj == null;
	}

	internal static DbCreateTableAction x7xMD5WK02UjbovksIdG()
	{
		return eEyciWWK7YScZBiPxaLj;
	}

	internal static object AmSMN0WKmt5JGrYASNbB(object P_0)
	{
		return ((Table)P_0).Name;
	}

	internal static bool pPKBaOWKy98vJgEkXlnI(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static object QqqnxNWKMMABw5j4nBtr()
	{
		return Logger.Log;
	}

	internal static object Xvooc4WKJfqdoEjJI6Jk(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object LL9ct3WK9t6AgfXrppx1(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void kp3D0TWKdtDKMKpGTRLZ(object P_0, object P_1)
	{
		((ILogger)P_0).Warn(P_1);
	}

	internal static bool kbf5ElWKlQFIa1GoeB4K(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}

	internal static void jumUBLWKrlHpRhSojOyt(object P_0, object P_1)
	{
		((ITransformationProvider)P_0).AddTable((Table)P_1);
	}
}
