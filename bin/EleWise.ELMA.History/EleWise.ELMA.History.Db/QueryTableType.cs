using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Threading;
using System.Threading.Tasks;
using NHibernate.Engine;
using NHibernate.SqlTypes;
using NHibernate.Type;

namespace EleWise.ELMA.History.Db;

internal abstract class QueryTableType : AbstractType
{
	protected readonly string TypeName;

	protected readonly Func<string, string> SysObjectNameFunc;

	private static readonly SqlType[] Types = (SqlType[])(object)new SqlType[1]
	{
		new SqlType(DbType.Object)
	};

	public override bool IsCollectionType => true;

	public override bool IsMutable
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override string Name
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public override Type ReturnedClass
	{
		get
		{
			throw new NotImplementedException();
		}
	}

	public QueryTableType(string typeName, Func<string, string> getSysObjectName)
	{
		SysObjectNameFunc = getSysObjectName;
		TypeName = typeName;
	}

	public override SqlType[] SqlTypes(IMapping mapping)
	{
		return Types;
	}

	public override int GetColumnSpan(IMapping mapping)
	{
		return 1;
	}

	protected void TransformIntoServerDateTime(DataTable data)
	{
		for (int i = 0; i < data.Columns.Count; i++)
		{
			if (!(data.Columns[i].DataType == typeof(DateTime)) && !(data.Columns[i].DataType == typeof(DateTime?)))
			{
				continue;
			}
			for (int j = 0; j < data.Rows.Count; j++)
			{
				DateTime? dateTime = data.Rows[j][i] as DateTime?;
				if (dateTime.HasValue)
				{
					data.Rows[j][i] = dateTime.Value.ToServerDateTime();
				}
			}
		}
	}

	public override Task<object> ReplaceAsync(object original, object current, ISessionImplementor session, object owner, IDictionary copiedAlready, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public override Task<object> NullSafeGetAsync(DbDataReader rs, string[] names, ISessionImplementor session, object owner, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public override Task<object> NullSafeGetAsync(DbDataReader rs, string name, ISessionImplementor session, object owner, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public override Task NullSafeSetAsync(DbCommand st, object value, int index, bool[] settable, ISessionImplementor session, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public override Task NullSafeSetAsync(DbCommand st, object value, int index, ISessionImplementor session, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public override Task<bool> IsDirtyAsync(object old, object current, bool[] checkable, ISessionImplementor session, CancellationToken cancellationToken)
	{
		throw new NotImplementedException();
	}

	public override object DeepCopy(object val, ISessionFactoryImplementor factory)
	{
		throw new NotImplementedException();
	}

	public override object Replace(object original, object current, ISessionImplementor session, object owner, IDictionary copiedAlready)
	{
		throw new NotImplementedException();
	}

	public override bool[] ToColumnNullness(object value, IMapping mapping)
	{
		throw new NotImplementedException();
	}

	public override object NullSafeGet(DbDataReader rs, string[] names, ISessionImplementor session, object owner)
	{
		throw new NotImplementedException();
	}

	public override object NullSafeGet(DbDataReader rs, string name, ISessionImplementor session, object owner)
	{
		throw new NotImplementedException();
	}

	public override void NullSafeSet(DbCommand st, object value, int index, bool[] settable, ISessionImplementor session)
	{
		throw new NotImplementedException();
	}

	public override string ToLoggableString(object value, ISessionFactoryImplementor factory)
	{
		throw new NotImplementedException();
	}

	public override bool IsDirty(object old, object current, bool[] checkable, ISessionImplementor session)
	{
		throw new NotImplementedException();
	}
}
