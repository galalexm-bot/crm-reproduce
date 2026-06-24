using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Actions;

public class DbDeleteColumnAction : DbAction
{
	private string tableName;

	private string columnName;

	private static DbDeleteColumnAction eLU7u3WKgyvDRxIsWJcW;

	public string TableName => tableName;

	public string ColumnName => columnName;

	public DbDeleteColumnAction(ITransformationProvider transform, string tableName, string columnName)
	{
		//Discarded unreachable code: IL_002b, IL_0030
		NWjcJ0WKYtMRv6QpnjZe();
		base._002Ector(transform);
		int num = 0;
		if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 != 0)
		{
			num = 2;
		}
		while (true)
		{
			switch (num)
			{
			case 2:
				this.tableName = tableName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_f2dd274bd63747f39fad2d48d99ab3a6 != 0)
				{
					num = 0;
				}
				break;
			case 1:
				return;
			default:
				this.columnName = columnName;
				num = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 != 0)
				{
					num = 1;
				}
				break;
			}
		}
	}

	public override void Execute()
	{
		int num = 4;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			default:
				return;
			case 2:
				base.Transform.RemoveColumn(tableName, columnName);
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_fc32595b071e4803bccb8ca3a3648a4c != 0)
				{
					num2 = 0;
				}
				break;
			case 0:
				return;
			case 5:
				WriteLogMessage();
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_48f8c031a7b24c18975ea88648c2b9f0 == 0)
				{
					num2 = 2;
				}
				break;
			case 3:
				if (sB2qOnWKL77jBy0JSqSP(base.LogMessage))
				{
					num2 = 1;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_9c2d43dff5774dd790c924489fa79c77 == 0)
					{
						num2 = 1;
					}
					break;
				}
				goto case 5;
			case 1:
				base.LogMessage = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(--1360331293 ^ 0x5114F4D1), columnName, tableName);
				num2 = 5;
				break;
			case 4:
				base.Execute();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_58625cdc96d842f9a59d3e0b5a01bf52 != 0)
				{
					num2 = 3;
				}
				break;
			}
		}
	}

	internal static void NWjcJ0WKYtMRv6QpnjZe()
	{
		SingletonReader.JJCZtPuTvSt();
	}

	internal static bool XhDT7fWK5BGWwM4BFmjd()
	{
		return eLU7u3WKgyvDRxIsWJcW == null;
	}

	internal static DbDeleteColumnAction lrvCYIWKjMAfbhChV2dr()
	{
		return eLU7u3WKgyvDRxIsWJcW;
	}

	internal static bool sB2qOnWKL77jBy0JSqSP(object P_0)
	{
		return string.IsNullOrEmpty((string)P_0);
	}
}
