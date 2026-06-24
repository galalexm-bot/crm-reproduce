using System;
using EleWise.ELMA.Helpers;
using NHibernate;

namespace EleWise.ELMA.Tasks.Components;

[Obsolete("Класс устарел, используйте вместо него EleWise.ELMA.Helpers.SqlQueryBuilder", true)]
public class SqlQueryBuilder
{
	private EleWise.ELMA.Helpers.SqlQueryBuilder sqlQueryBuilder;

	public SqlQueryBuilder(ISession session)
	{
		sqlQueryBuilder = new EleWise.ELMA.Helpers.SqlQueryBuilder(session);
	}

	public string AddPartQuery(ICriteria criteria)
	{
		return sqlQueryBuilder.AddPartQuery(criteria);
	}

	public ISQLQuery Build<T>(string queryString)
	{
		return sqlQueryBuilder.Build<T>(queryString);
	}

	public string GetAliaseIdentifier(ICriteria criteria, string alias = "this")
	{
		return sqlQueryBuilder.GetAliaseIdentifier(criteria, alias);
	}

	public static string GetCriteriaAlias(ICriteria criteria)
	{
		return EleWise.ELMA.Helpers.SqlQueryBuilder.GetCriteriaAlias(criteria);
	}

	public static string EntityTitleProperty(Guid entityUid)
	{
		return EleWise.ELMA.Helpers.SqlQueryBuilder.EntityTitleProperty(entityUid);
	}

	public static string EntityTitleProperty(Type entityType)
	{
		return EleWise.ELMA.Helpers.SqlQueryBuilder.EntityTitleProperty(entityType);
	}

	public static string EntityTitleProperty<T>()
	{
		return EleWise.ELMA.Helpers.SqlQueryBuilder.EntityTitleProperty<T>();
	}
}
