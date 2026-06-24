using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using EleWise.ELMA.Runtime.Db.Migrator.Providers;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Actions;

public class DbRenameTableAction : DbAction
{
	private string oldTableName;

	private string newTableName;

	private static DbRenameTableAction hoi9PJWqcU76lLAp2qMY;

	public DbRenameTableAction(ITransformationProvider transform, string oldTableName, string newTableName)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		I6bBusWKBDn1jN4jQ4yw();
		base._002Ector(transform);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_8575f6e311ac4db8b96176046b2c5efb == 0)
		{
			num = 0;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				this.newTableName = newTableName;
				num = 1;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_410c9cfa7ca84605b564ae92b43adbc5 == 0)
				{
					num = 1;
				}
				break;
			case 1:
				return;
			default:
				this.oldTableName = oldTableName;
				num = 2;
				break;
			}
		}
	}

	public override void Execute()
	{
		//Discarded unreachable code: IL_0081, IL_0090, IL_01b8, IL_01c7, IL_02d6, IL_030e
		int num = 19;
		string text = default(string);
		while (true)
		{
			int num2 = num;
			while (true)
			{
				switch (num2)
				{
				case 18:
					if (kfcIDpWKW6NVsAuNvDKW(oldTableName, newTableName))
					{
						num2 = 20;
						continue;
					}
					goto IL_01d3;
				case 14:
					if (DEheXBWKh8bWa4kyICNu(base.Transform, newTableName))
					{
						num2 = 0;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_15b4035e530d46429104ec3abcdabf41 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto IL_00ec;
				case 4:
					return;
				case 16:
					if (!base.Transform.TableExists(newTableName))
					{
						num2 = 3;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
						{
							num2 = 12;
						}
						continue;
					}
					return;
				case 11:
					hGcmAIWKG2HJqVDwWco4(base.Transform, oldTableName, newTableName);
					num2 = 3;
					continue;
				case 19:
					base.Execute();
					num2 = 18;
					continue;
				case 2:
				case 5:
					WriteLogMessage();
					num2 = 11;
					continue;
				case 3:
					return;
				case 1:
					PH0kVFWKvRImEldoCmXA(Logger.Log, bFuY2uWKCTbbWPchYgtB(BoUQaNWKQCR6ADttgZsn(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1867379187 ^ 0x6F4C0563)), oldTableName));
					num2 = 10;
					continue;
				case 17:
					return;
				case 8:
					text = (string)sU2H80WKbFnWtieSB3VL(base.Transform.Dialect, oldTableName);
					num2 = 23;
					continue;
				case 22:
					hGcmAIWKG2HJqVDwWco4(base.Transform, text, newTableName);
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 == 0)
					{
						num2 = 17;
					}
					continue;
				default:
					PH0kVFWKvRImEldoCmXA(Yxb77DWKE572sZfgB3lr(), bFuY2uWKCTbbWPchYgtB(BoUQaNWKQCR6ADttgZsn(mmW7u4WKfohlZENbtR93(0x3A5D5EF ^ 0x3A421C9)), newTableName));
					num2 = 4;
					continue;
				case 9:
					if (!base.Transform.TableExists(newTableName))
					{
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_e08894dba5a54e85b5c77f59df2d65b3 != 0)
						{
							num2 = 1;
						}
						continue;
					}
					goto case 7;
				case 10:
					return;
				case 7:
					if (base.Transform.TableExists(oldTableName))
					{
						num = 6;
						break;
					}
					goto case 16;
				case 20:
					if (mXo2OKWKoT7cYLCqD5Ev(base.Transform.Dialect, newTableName))
					{
						num = 21;
						break;
					}
					goto IL_01d3;
				case 21:
					WriteLogMessage();
					num2 = 8;
					continue;
				case 15:
					base.LogMessage = SR.T((string)mmW7u4WKfohlZENbtR93(-643786247 ^ -643732213), oldTableName, newTableName);
					num2 = 2;
					continue;
				case 13:
					return;
				case 6:
				case 12:
					if (!PWOvULWK8mPLLPFiQpco(base.LogMessage))
					{
						num2 = 5;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_ebbcc5dc5fd94ffbb810b25a42bbec85 == 0)
						{
							num2 = 0;
						}
						continue;
					}
					goto case 15;
				case 23:
					{
						if (!DEheXBWKh8bWa4kyICNu(base.Transform, text))
						{
							return;
						}
						num2 = 1;
						if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e == 0)
						{
							num2 = 22;
						}
						continue;
					}
					IL_00ec:
					if (DEheXBWKh8bWa4kyICNu(base.Transform, oldTableName))
					{
						num2 = 7;
						continue;
					}
					goto case 9;
					IL_01d3:
					if (DEheXBWKh8bWa4kyICNu(base.Transform, oldTableName))
					{
						num2 = 14;
						continue;
					}
					goto IL_00ec;
				}
				break;
			}
		}
	}

	internal static void I6bBusWKBDn1jN4jQ4yw()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool x17WsLWqzcl6Nwja9h1k()
	{
		return hoi9PJWqcU76lLAp2qMY == null;
	}

	internal static DbRenameTableAction Hmk2NjWKFGZagVHI4XZo()
	{
		return hoi9PJWqcU76lLAp2qMY;
	}

	internal static bool kfcIDpWKW6NVsAuNvDKW(object P_0, object P_1)
	{
		return ((string)P_0).Equals((string)P_1);
	}

	internal static bool mXo2OKWKoT7cYLCqD5Ev(object P_0, object P_1)
	{
		return ((Dialect)P_0).IsReservedWord((string)P_1);
	}

	internal static object sU2H80WKbFnWtieSB3VL(object P_0, object P_1)
	{
		return ((Dialect)P_0).UnQuoteString((string)P_1);
	}

	internal static bool DEheXBWKh8bWa4kyICNu(object P_0, object P_1)
	{
		return ((ITransformationProvider)P_0).TableExists((string)P_1);
	}

	internal static void hGcmAIWKG2HJqVDwWco4(object P_0, object P_1, object P_2)
	{
		((ITransformationProvider)P_0).RenameTable((string)P_1, (string)P_2);
	}

	internal static object Yxb77DWKE572sZfgB3lr()
	{
		return Logger.Log;
	}

	internal static object mmW7u4WKfohlZENbtR93(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}

	internal static object BoUQaNWKQCR6ADttgZsn(object P_0)
	{
		return SR.T((string)P_0);
	}

	internal static object bFuY2uWKCTbbWPchYgtB(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void PH0kVFWKvRImEldoCmXA(object P_0, object P_1)
	{
		((ILogger)P_0).Warn(P_1);
	}

	internal static bool PWOvULWK8mPLLPFiQpco(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
