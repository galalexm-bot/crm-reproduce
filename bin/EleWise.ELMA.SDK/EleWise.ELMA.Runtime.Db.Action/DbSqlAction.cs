using System.Collections.Generic;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;
using SG9KiyIbtdgGDf12qr;

namespace EleWise.ELMA.Runtime.Db.Actions;

public class DbSqlAction : DbAction
{
	private string sql;

	private Dictionary<string, object> paramValues;

	private static DbSqlAction L8sDVaWqHQbsVlFkQapN;

	protected string Sql => sql;

	protected Dictionary<string, object> ParamValues => paramValues;

	public DbSqlAction(ITransformationProvider transform, string sql, Dictionary<string, object> paramValues = null)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(transform);
		this.sql = sql;
		this.paramValues = paramValues;
	}

	public override void Execute()
	{
		//Discarded unreachable code: IL_00c4
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 3:
			case 4:
				WriteLogMessage();
				num2 = 6;
				break;
			case 6:
				base.Transform.ExecuteNonQuery(sql, paramValues);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_3d444c86b7e84c21885b3ce33b01a7b0 == 0)
				{
					num2 = 1;
				}
				break;
			case 5:
				base.LogMessage = SR.T(z2jc63fLkugS1X8Q9N.tE1kD1vbB(-812025778 ^ -812086536), sql);
				num2 = 4;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_d1c9165cfd2a4d25abfd932193e33920 == 0)
				{
					num2 = 0;
				}
				break;
			default:
				if (!string.IsNullOrEmpty(base.LogMessage))
				{
					num2 = 0;
					if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_10daacc15bd54fcbba9b5ef87fe45543 == 0)
					{
						num2 = 3;
					}
					break;
				}
				goto case 5;
			case 2:
				return;
			case 1:
				base.Execute();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_28c3d23258ad4864b405e8aef07422ff != 0)
				{
					num2 = 0;
				}
				break;
			}
		}
	}

	internal static bool qW4xDAWqACUxIpQMakjH()
	{
		return L8sDVaWqHQbsVlFkQapN == null;
	}

	internal static DbSqlAction OsjG78Wq78uKFQcBT3Yb()
	{
		return L8sDVaWqHQbsVlFkQapN;
	}
}
