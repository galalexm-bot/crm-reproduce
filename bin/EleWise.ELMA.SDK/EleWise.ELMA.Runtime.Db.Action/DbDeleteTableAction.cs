using EleWise.ELMA.Logging;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Actions;

public class DbDeleteTableAction : DbAction
{
	private string tableName;

	internal static DbDeleteTableAction VE8Z52Wq3D0HNiYy0uOQ;

	public string TableName => tableName;

	public DbDeleteTableAction(ITransformationProvider transform, string tableName)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		GgPe9tWqD66o23vmTaPQ();
		base._002Ector(transform);
		int num = 1;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_42724c4491cc46b1a5d6234e06b7909e != 0)
		{
			num = 1;
		}
		while (true)
		{
			switch (num)
			{
			default:
				return;
			case 0:
				return;
			case 1:
				this.tableName = tableName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num = 0;
				}
				break;
			}
		}
	}

	public override void Execute()
	{
		//Discarded unreachable code: IL_00ec, IL_00fb
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 7:
				return;
			case 8:
				if (string.IsNullOrEmpty(base.LogMessage))
				{
					num2 = 3;
					break;
				}
				goto case 4;
			case 6:
				return;
			case 5:
				base.Transform.RemoveTable(tableName);
				num2 = 6;
				break;
			default:
				if (base.Transform.TableExists(tableName))
				{
					num2 = 8;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_26ee82fd2c524121afb3dd85911dad32 == 0)
					{
						num2 = 4;
					}
					break;
				}
				goto case 2;
			case 2:
				lV3t26Wq4KkA4FKNw95Q(WjwMjkWqtVwOaGyLVfc5(), VMCvglWqwwa01kBkw2lc(z2jc63fLkugS1X8Q9N.tE1kD1vbB(0x463A0F3C ^ 0x463BFD22), tableName));
				num2 = 7;
				break;
			case 4:
				WriteLogMessage();
				num2 = 5;
				break;
			case 1:
				base.Execute();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3e4c8181e9ec4ebda8d2482b65674528 != 0)
				{
					num2 = 0;
				}
				break;
			case 3:
				base.LogMessage = SR.T((string)TKifj2Wq6kXor9NqwOu7(0x1637C429 ^ 0x163636AF), tableName);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_2ef47dfd15f24de08611653bf7dc3548 == 0)
				{
					num2 = 4;
				}
				break;
			}
		}
	}

	internal static void GgPe9tWqD66o23vmTaPQ()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool sZ7cM5WqptHf8CKADiAe()
	{
		return VE8Z52Wq3D0HNiYy0uOQ == null;
	}

	internal static DbDeleteTableAction p43aVRWqaOl4TPsgEvP5()
	{
		return VE8Z52Wq3D0HNiYy0uOQ;
	}

	internal static object WjwMjkWqtVwOaGyLVfc5()
	{
		return Logger.Log;
	}

	internal static object VMCvglWqwwa01kBkw2lc(object P_0, object P_1)
	{
		return string.Format((string)P_0, P_1);
	}

	internal static void lV3t26Wq4KkA4FKNw95Q(object P_0, object P_1)
	{
		((ILogger)P_0).Warn(P_1);
	}

	internal static object TKifj2Wq6kXor9NqwOu7(int _0020)
	{
		return z2jc63fLkugS1X8Q9N.tE1kD1vbB(_0020);
	}
}
