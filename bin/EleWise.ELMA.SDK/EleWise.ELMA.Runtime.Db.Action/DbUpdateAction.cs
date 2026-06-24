using System.Collections.Generic;
using EleWise.ELMA.Runtime.Db.Migrator.Framework;
using j3AmrhgkCleVTGdEwA;

namespace EleWise.ELMA.Runtime.Db.Actions;

public class DbUpdateAction : DbAction
{
	private string table;

	private string[] columns;

	private object[] values;

	private string where;

	private Dictionary<string, object> paramValues;

	private static DbUpdateAction OX383CWqxysk46KkIKSe;

	protected string Table => table;

	protected string[] Columns => columns;

	protected object[] Values => values;

	protected string Where => where;

	protected Dictionary<string, object> ParamValues => paramValues;

	public DbUpdateAction(ITransformationProvider transform, string table, string[] columns, object[] values, string where = null, Dictionary<string, object> paramValues = null)
	{
		SingletonReader.JJCZtPuTvSt();
		base._002Ector(transform);
		this.table = table;
		this.columns = columns;
		this.values = values;
		this.where = where;
		this.paramValues = paramValues;
	}

	public override void Execute()
	{
		int num = 1;
		int num2 = num;
		while (true)
		{
			switch (num2)
			{
			case 1:
				base.Execute();
				num2 = 0;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_beb14d0e642e408384966576c53c4652 == 0)
				{
					num2 = 0;
				}
				break;
			case 2:
				return;
			default:
				base.Transform.Update(table, columns, values, where, paramValues);
				num2 = 2;
				if (_003CModule_003E_007B3a453932_002D0908_002D413c_002Db2f1_002D639ca5a231f2_007D.m_afcb509d1bd34fcea76e640fbd2ae7ee == 0)
				{
					num2 = 1;
				}
				break;
			}
		}
	}

	internal static bool S7liXBWq0HXl37o59RUZ()
	{
		return OX383CWqxysk46KkIKSe == null;
	}

	internal static DbUpdateAction Ckh0heWqmJJUDPEdpEph()
	{
		return OX383CWqxysk46KkIKSe;
	}
}
